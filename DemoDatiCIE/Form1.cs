using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using CieReader;

namespace DemoDatiCIE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLeggiCie_Click(object sender, EventArgs e)
        {
            try
            {
                ClearOutput();

                string can = txtCan.Text.Trim();

                if (!IsValidCan(can))
                {
                    MessageBox.Show(
                        "Il CAN deve contenere esattamente 6 cifre.",
                        "CAN non valido",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtCan.Focus();
                    txtCan.SelectAll();
                    return;
                }

                UseWaitCursor = true;
                btnLeggiCie.Enabled = false;

                DatiCie dati = DatiCie.ReadCie(can);
                
                FillForm(dati);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Errore durante la lettura della CIE:\r\n\r\n" + ex.Message,
                    "Errore",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                btnLeggiCie.Enabled = true;
                UseWaitCursor = false;
            }
        }

        private void FillForm(DatiCie dati)
        {
            txtCognome.Text = dati.Cognome;
            txtNome.Text = dati.Nome;
            txtLocalitaNascita.Text = dati.LocalitaNascita;
            txtDataNascita.Text = FormatItalianDate(dati.DataNascita);
            txtProvinciaNascita.Text = dati.ProvinciaNascita;
            txtIndirizzoResidenza.Text = dati.IndirizzoResidenza;
            txtCittaResidenza.Text = dati.CittaResidenza;
            txtProvinciaResidenza.Text = dati.ProvinciaResidenza;
            txtCodiceFiscale.Text = dati.CodiceFiscale;
            txtScadenzaCarta.Text = dati.ScadenzaCarta;
            txtMrz.Text = dati.Mrz;

            txtTipoDocumento.Text = dati.MrzData.DocumentType;
            txtNazionalita.Text = dati.MrzData.Nationality;
            txtNumeroDocumento.Text = dati.MrzData.DocumentNumber;
            txtSesso.Text = dati.MrzData.Sex;
            txtCittadinanza.Text = dati.MrzData.Citizenship;

            txtCheckNumero.Text = FormatCheck(dati.MrzData.DocumentNumberCheckOk, dati.MrzData.DocumentNumberCheckDigit);
            txtCheckDataNascita.Text = FormatCheck(dati.MrzData.BirthDateCheckOk, dati.MrzData.BirthDateCheckDigit);
            txtCheckScadenza.Text = FormatCheck(dati.MrzData.ExpiryDateCheckOk, dati.MrzData.ExpiryDateCheckDigit);
            txtCheckFinale.Text = FormatCheck(dati.MrzData.FinalCheckOk, dati.MrzData.FinalCheckDigit);

            txtPathJp2.Text = dati.ImagePathJp2;
            txtPathJpg.Text = dati.ImagePathJpg;

            LoadPhoto(dati.ImagePathJpg);
        }

        private void LoadPhoto(string imagePath)
        {
            if (string.IsNullOrWhiteSpace(imagePath) || !File.Exists(imagePath))
            {
                return;
            }

            using FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
            using Image img = Image.FromStream(fs);
            picFoto.Image = new Bitmap(img);
        }

        private void ClearOutput()
        {
            txtCognome.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtLocalitaNascita.Text = string.Empty;
            txtDataNascita.Text = string.Empty;
            txtProvinciaNascita.Text = string.Empty;
            txtIndirizzoResidenza.Text = string.Empty;
            txtCittaResidenza.Text = string.Empty;
            txtProvinciaResidenza.Text = string.Empty;
            txtCodiceFiscale.Text = string.Empty;
            txtScadenzaCarta.Text = string.Empty;
            txtMrz.Text = string.Empty;

            txtTipoDocumento.Text = string.Empty;
            txtNazionalita.Text = string.Empty;
            txtNumeroDocumento.Text = string.Empty;
            txtSesso.Text = string.Empty;
            txtCittadinanza.Text = string.Empty;

            txtCheckNumero.Text = string.Empty;
            txtCheckDataNascita.Text = string.Empty;
            txtCheckScadenza.Text = string.Empty;
            txtCheckFinale.Text = string.Empty;

            txtPathJp2.Text = string.Empty;
            txtPathJpg.Text = string.Empty;

            if (picFoto.Image != null)
            {
                var oldImage = picFoto.Image;
                picFoto.Image = null;
                oldImage.Dispose();
            }
        }

        private static bool IsValidCan(string can)
        {
            if (string.IsNullOrWhiteSpace(can) || can.Length != 6)
            {
                return false;
            }

            for (int i = 0; i < can.Length; i++)
            {
                if (!char.IsDigit(can[i]))
                {
                    return false;
                }
            }

            return true;
        }

        private static string FormatCheck(bool ok, string digit)
        {
            string esito = ok ? "OK" : "ATTENZIONE";
            return $"Letto: {digit} - Esito: {esito}";
        }

        private void btnEsporta_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = SafeFileNamePart(txtNome.Text).ToUpper();
                string cognome = SafeFileNamePart(txtCognome.Text).ToUpper();
                string codiceFiscale = SafeFileNamePart(txtCodiceFiscale.Text).ToUpper();

                string nomeFile = $"{nome}_{cognome}_{codiceFiscale}.txt";
                string cartellaDestinazione = Application.StartupPath;
                string percorsoCompleto = Path.Combine(cartellaDestinazione, nomeFile);

                string contenuto =
                    "---------------------------------------------------------------" + Environment.NewLine +
                    "Cognome: " + txtCognome.Text + Environment.NewLine +
                    "Nome: " + txtNome.Text + Environment.NewLine +
                    "---------------------------------------------------------------" + Environment.NewLine +
                    "Data di nascita: " + txtDataNascita.Text + Environment.NewLine +
                    "Località di nascita: " + txtLocalitaNascita.Text + Environment.NewLine +
                    "Provincia di nascita: " + txtProvinciaNascita.Text + Environment.NewLine +
                    "---------------------------------------------------------------" + Environment.NewLine +
                    "Indirizzo di residenza: " + txtIndirizzoResidenza.Text + Environment.NewLine +
                    "Città di residenza: " + txtCittaResidenza.Text + Environment.NewLine +
                    "Provincia di residenza: " + txtProvinciaResidenza.Text + Environment.NewLine +
                    "---------------------------------------------------------------" + Environment.NewLine +
                    "Codice fiscale: " + txtCodiceFiscale.Text + Environment.NewLine +
                    "---------------------------------------------------------------" + Environment.NewLine +
                    "Tipo documento: " + txtTipoDocumento.Text + Environment.NewLine +
                    "Numero documento: " + txtNumeroDocumento.Text + Environment.NewLine +
                    "Scadenza carta: " + txtScadenzaCarta.Text + Environment.NewLine +
                    "---------------------------------------------------------------" + Environment.NewLine +
                    "Nazionalità: " + txtNazionalita.Text + Environment.NewLine +
                    "Cittadinanza: " + txtCittadinanza.Text + Environment.NewLine +
                    "Sesso: " + txtSesso.Text + Environment.NewLine +
                    "---------------------------------------------------------------" + Environment.NewLine;

                File.WriteAllText(percorsoCompleto, contenuto, System.Text.Encoding.UTF8);
                System.Diagnostics.Process.Start("explorer.exe", "/select,\"" + percorsoCompleto + "\"");
                MessageBox.Show(
                    "Dati esportati correttamente in:\r\n" + percorsoCompleto,
                    "Esportazione completata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Errore durante l'esportazione:\r\n\r\n" + ex.Message,
                    "Errore",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private static string SafeFileNamePart(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return "VUOTO";
            }

            foreach (char c in Path.GetInvalidFileNameChars())
            {
                value = value.Replace(c, '_');
            }

            return value.Trim().Replace(' ', '_');
        }

        private static string FormatItalianDate(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return string.Empty;
            }

            DateTime data;
            if (DateTime.TryParseExact(
                    value,
                    "yyyy-MM-dd",
                    System.Globalization.CultureInfo.InvariantCulture,
                    System.Globalization.DateTimeStyles.None,
                    out data))
            {
                return data.ToString("dd/MM/yyyy");
            }

            return value;
        }

        private void txtCan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnLeggiCie_Click(btnLeggiCie, EventArgs.Empty);
            }
        }
    }
}