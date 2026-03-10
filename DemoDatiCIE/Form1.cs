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
            txtDataNascita.Text = dati.DataNascita;
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
    }
}