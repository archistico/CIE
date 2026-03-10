using CIE.MRTD.SDK.EAC;
using CIE.MRTD.SDK.PARSERLIB;
using CIE.MRTD.SDK.PCSC;
using PCSC;

namespace CieReader.Service;

public sealed class Reader : IDisposable
{
    private readonly SmartCard _smartCard;
    private bool _disposed;

    public Reader()
    {
        _smartCard = new SmartCard
        {
            LogEnabled = false
        };
    }

    public string ReadCardAsJson(string can)
    {
        if (string.IsNullOrWhiteSpace(can))
        {
            throw new ArgumentException("Il CAN è obbligatorio.", nameof(can));
        }

        string readerName = GetSingleReaderName();

        bool connected = false;
        try
        {
            connected = ConnectWithRetry(readerName);
            if (!connected)
            {
                throw new InvalidOperationException("Impossibile collegarsi alla carta tramite il lettore NFC.");
            }

            var eac = new EAC(_smartCard);

            if (!eac.IsSAC())
            {
                throw new InvalidOperationException("La carta non supporta PACE/SAC.");
            }

            eac.PACE(can);
            eac.ReadDG(DG.DG14);
            eac.ChipAuthentication();

            var document = new C_CIE(eac);
            return document.ToJsonString();
        }
        finally
        {
            if (connected)
            {
                try
                {
                    _smartCard.Disconnect(Disposition.SCARD_RESET_CARD);
                }
                catch
                {
                    // ignoro errori in chiusura
                }
            }
        }
    }

    private static string GetSingleReaderName()
    {
        using var context = ContextFactory.Instance.Establish(SCardScope.System);
        var readers = context.GetReaders();

        if (readers == null || readers.Length == 0)
        {
            throw new InvalidOperationException("Nessun lettore smart card trovato.");
        }

        if (readers.Length == 1)
        {
            return readers[0];
        }

        return readers[0];
    }

    private bool ConnectWithRetry(string readerName)
    {
        for (int attempt = 0; attempt < 10; attempt++)
        {
            if (_smartCard.Connect(readerName, Share.SCARD_SHARE_EXCLUSIVE, Protocol.SCARD_PROTOCOL_T1))
            {
                return true;
            }

            Thread.Sleep(100);

            if (attempt >= 4)
            {
                if (_smartCard.Reconnect(Share.SCARD_SHARE_EXCLUSIVE, Protocol.SCARD_PROTOCOL_T1, Disposition.SCARD_RESET_CARD))
                {
                    return true;
                }
            }
        }

        return false;
    }

    public void Dispose()
    {
        if (_disposed)
        {
            return;
        }

        try
        {
            _smartCard.StopMonitoring();
        }
        catch
        {
            // niente
        }

        _disposed = true;
        GC.SuppressFinalize(this);
    }
}
