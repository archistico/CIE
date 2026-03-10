using System;
using System.Text;

namespace CieReader
{
    internal static class Program
    {
        private static int Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Inserire nel lettore la CIE");

            try
            {
                string? can = DatiCie.GetValidatedCan(args);
                if (string.IsNullOrWhiteSpace(can))
                {
                    Console.Error.WriteLine("CAN non valido: deve contenere esattamente 6 cifre.");
                    return 1;
                }

                DatiCie dati = DatiCie.ReadCie(can);

                Console.WriteLine($"Cognome: {dati.Cognome}");
                Console.WriteLine($"Nome: {dati.Nome}");
                Console.WriteLine($"Località di nascita: {dati.LocalitaNascita}");
                Console.WriteLine($"Data di nascita: {dati.DataNascita}");
                Console.WriteLine($"Provincia di nascita: {dati.ProvinciaNascita}");
                Console.WriteLine($"Indirizzo di residenza: {dati.IndirizzoResidenza}");
                Console.WriteLine($"Città di residenza: {dati.CittaResidenza}");
                Console.WriteLine($"Provincia di residenza: {dati.ProvinciaResidenza}");
                Console.WriteLine($"CF: {dati.CodiceFiscale}");
                Console.WriteLine($"Scadenza carta: {dati.ScadenzaCarta}");
                Console.WriteLine($"MRZ: {dati.Mrz}");

                Console.WriteLine($"Tipo documento: {dati.MrzData.DocumentType}");
                Console.WriteLine($"Nazionalità: {dati.MrzData.Nationality}");
                Console.WriteLine($"Numero documento: {dati.MrzData.DocumentNumber}");
                Console.WriteLine($"Sesso: {dati.MrzData.Sex}");
                Console.WriteLine($"Cittadinanza: {dati.MrzData.Citizenship}");

                Console.WriteLine($"Check numero documento: letto {dati.MrzData.DocumentNumberCheckDigit}, esito {FormatCheck(dati.MrzData.DocumentNumberCheckOk)}");
                Console.WriteLine($"Check data nascita: letto {dati.MrzData.BirthDateCheckDigit}, esito {FormatCheck(dati.MrzData.BirthDateCheckOk)}");
                Console.WriteLine($"Check data scadenza: letto {dati.MrzData.ExpiryDateCheckDigit}, esito {FormatCheck(dati.MrzData.ExpiryDateCheckOk)}");
                Console.WriteLine($"Check finale: letto {dati.MrzData.FinalCheckDigit}, esito {FormatCheck(dati.MrzData.FinalCheckOk)}");

                Console.WriteLine($"Immagine JP2 salvata: {dati.ImagePathJp2}");
                Console.WriteLine($"Immagine JPG salvata: {dati.ImagePathJpg}");

                Console.Write("Premi un tasto per continuare... ");
                Console.ReadKey();

                return 0;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Errore: {ex.Message}");
                return 2;
            }
        }

        private static string FormatCheck(bool ok)
        {
            return ok ? "OK" : "!!! Attenzione !!!";
        }
    }
}