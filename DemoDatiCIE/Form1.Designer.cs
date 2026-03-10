namespace DemoDatiCIE
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblCan;
        private System.Windows.Forms.TextBox txtCan;
        private System.Windows.Forms.Button btnLeggiCie;
        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.GroupBox grpDatiAnagrafici;
        private System.Windows.Forms.TableLayoutPanel tlpDati;
        private System.Windows.Forms.Label lblCognome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblLocalitaNascita;
        private System.Windows.Forms.Label lblDataNascita;
        private System.Windows.Forms.Label lblProvinciaNascita;
        private System.Windows.Forms.Label lblIndirizzoResidenza;
        private System.Windows.Forms.Label lblCittaResidenza;
        private System.Windows.Forms.Label lblProvinciaResidenza;
        private System.Windows.Forms.Label lblCodiceFiscale;
        private System.Windows.Forms.Label lblScadenzaCarta;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtLocalitaNascita;
        private System.Windows.Forms.TextBox txtDataNascita;
        private System.Windows.Forms.TextBox txtProvinciaNascita;
        private System.Windows.Forms.TextBox txtIndirizzoResidenza;
        private System.Windows.Forms.TextBox txtCittaResidenza;
        private System.Windows.Forms.TextBox txtProvinciaResidenza;
        private System.Windows.Forms.TextBox txtCodiceFiscale;
        private System.Windows.Forms.TextBox txtScadenzaCarta;
        private System.Windows.Forms.GroupBox grpMrz;
        private System.Windows.Forms.TableLayoutPanel tlpMrz;
        private System.Windows.Forms.Label lblMrz;
        private System.Windows.Forms.TextBox txtMrz;
        private System.Windows.Forms.Label lblTipoDocumento;
        private System.Windows.Forms.Label lblNazionalita;
        private System.Windows.Forms.Label lblNumeroDocumento;
        private System.Windows.Forms.Label lblSesso;
        private System.Windows.Forms.Label lblCittadinanza;
        private System.Windows.Forms.TextBox txtTipoDocumento;
        private System.Windows.Forms.TextBox txtNazionalita;
        private System.Windows.Forms.TextBox txtNumeroDocumento;
        private System.Windows.Forms.TextBox txtSesso;
        private System.Windows.Forms.TextBox txtCittadinanza;
        private System.Windows.Forms.Label lblCheckNumero;
        private System.Windows.Forms.Label lblCheckDataNascita;
        private System.Windows.Forms.Label lblCheckScadenza;
        private System.Windows.Forms.Label lblCheckFinale;
        private System.Windows.Forms.TextBox txtCheckNumero;
        private System.Windows.Forms.TextBox txtCheckDataNascita;
        private System.Windows.Forms.TextBox txtCheckScadenza;
        private System.Windows.Forms.TextBox txtCheckFinale;
        private System.Windows.Forms.GroupBox grpFoto;
        private System.Windows.Forms.TableLayoutPanel tlpFoto;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.Label lblPathJp2;
        private System.Windows.Forms.Label lblPathJpg;
        private System.Windows.Forms.TextBox txtPathJp2;
        private System.Windows.Forms.TextBox txtPathJpg;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (picFoto != null && picFoto.Image != null)
                {
                    picFoto.Image.Dispose();
                    picFoto.Image = null;
                }

                if (components != null)
                {
                    components.Dispose();
                }
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support.
        /// </summary>
        private void InitializeComponent()
        {
            tlpMain = new TableLayoutPanel();
            pnlTop = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            lblCan = new Label();
            txtCan = new TextBox();
            btnLeggiCie = new Button();
            splitMain = new SplitContainer();
            grpMrz = new GroupBox();
            tlpMrz = new TableLayoutPanel();
            lblMrz = new Label();
            txtMrz = new TextBox();
            lblTipoDocumento = new Label();
            txtTipoDocumento = new TextBox();
            lblNazionalita = new Label();
            txtNazionalita = new TextBox();
            lblNumeroDocumento = new Label();
            txtNumeroDocumento = new TextBox();
            lblSesso = new Label();
            txtSesso = new TextBox();
            lblCittadinanza = new Label();
            txtCittadinanza = new TextBox();
            lblCheckNumero = new Label();
            txtCheckNumero = new TextBox();
            lblCheckDataNascita = new Label();
            txtCheckDataNascita = new TextBox();
            lblCheckScadenza = new Label();
            txtCheckScadenza = new TextBox();
            lblCheckFinale = new Label();
            txtCheckFinale = new TextBox();
            grpDatiAnagrafici = new GroupBox();
            tlpDati = new TableLayoutPanel();
            lblCognome = new Label();
            txtCognome = new TextBox();
            lblNome = new Label();
            txtNome = new TextBox();
            lblLocalitaNascita = new Label();
            txtLocalitaNascita = new TextBox();
            lblDataNascita = new Label();
            txtDataNascita = new TextBox();
            lblProvinciaNascita = new Label();
            txtProvinciaNascita = new TextBox();
            lblIndirizzoResidenza = new Label();
            txtIndirizzoResidenza = new TextBox();
            lblCittaResidenza = new Label();
            txtCittaResidenza = new TextBox();
            lblProvinciaResidenza = new Label();
            txtProvinciaResidenza = new TextBox();
            lblCodiceFiscale = new Label();
            txtCodiceFiscale = new TextBox();
            lblScadenzaCarta = new Label();
            txtScadenzaCarta = new TextBox();
            grpFoto = new GroupBox();
            tlpFoto = new TableLayoutPanel();
            picFoto = new PictureBox();
            lblPathJp2 = new Label();
            txtPathJp2 = new TextBox();
            lblPathJpg = new Label();
            txtPathJpg = new TextBox();
            tlpMain.SuspendLayout();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitMain).BeginInit();
            splitMain.Panel1.SuspendLayout();
            splitMain.Panel2.SuspendLayout();
            splitMain.SuspendLayout();
            grpMrz.SuspendLayout();
            tlpMrz.SuspendLayout();
            grpDatiAnagrafici.SuspendLayout();
            tlpDati.SuspendLayout();
            grpFoto.SuspendLayout();
            tlpFoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFoto).BeginInit();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.Controls.Add(pnlTop, 0, 0);
            tlpMain.Controls.Add(splitMain, 0, 1);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 2;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 110F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.Size = new Size(1280, 820);
            tlpMain.TabIndex = 0;
            // 
            // pnlTop
            // 
            pnlTop.Controls.Add(label1);
            pnlTop.Controls.Add(pictureBox1);
            pnlTop.Controls.Add(lblCan);
            pnlTop.Controls.Add(txtCan);
            pnlTop.Controls.Add(btnLeggiCie);
            pnlTop.Dock = DockStyle.Fill;
            pnlTop.Location = new Point(3, 3);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1274, 104);
            pnlTop.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(172, 6);
            label1.Name = "label1";
            label1.Size = new Size(344, 25);
            label1.TabIndex = 4;
            label1.Text = "Leggi dati Carta d'identità elettronica";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cie_esempio;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lblCan
            // 
            lblCan.AutoSize = true;
            lblCan.Location = new Point(172, 48);
            lblCan.Name = "lblCan";
            lblCan.Size = new Size(223, 15);
            lblCan.TabIndex = 0;
            lblCan.Text = "CAN CIE (6 cifre, fronte in basso a destra)";
            // 
            // txtCan
            // 
            txtCan.Location = new Point(172, 68);
            txtCan.MaxLength = 6;
            txtCan.Name = "txtCan";
            txtCan.Size = new Size(110, 23);
            txtCan.TabIndex = 1;
            // 
            // btnLeggiCie
            // 
            btnLeggiCie.Location = new Point(288, 65);
            btnLeggiCie.Name = "btnLeggiCie";
            btnLeggiCie.Size = new Size(132, 27);
            btnLeggiCie.TabIndex = 2;
            btnLeggiCie.Text = "Leggi CIE";
            btnLeggiCie.UseVisualStyleBackColor = true;
            btnLeggiCie.Click += btnLeggiCie_Click;
            // 
            // splitMain
            // 
            splitMain.Dock = DockStyle.Fill;
            splitMain.Location = new Point(3, 113);
            splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            splitMain.Panel1.Controls.Add(grpMrz);
            splitMain.Panel1.Controls.Add(grpDatiAnagrafici);
            // 
            // splitMain.Panel2
            // 
            splitMain.Panel2.Controls.Add(grpFoto);
            splitMain.Size = new Size(1274, 704);
            splitMain.SplitterDistance = 860;
            splitMain.TabIndex = 1;
            // 
            // grpMrz
            // 
            grpMrz.Controls.Add(tlpMrz);
            grpMrz.Dock = DockStyle.Fill;
            grpMrz.Location = new Point(0, 320);
            grpMrz.Name = "grpMrz";
            grpMrz.Padding = new Padding(10);
            grpMrz.Size = new Size(860, 384);
            grpMrz.TabIndex = 1;
            grpMrz.TabStop = false;
            grpMrz.Text = "Dati MRZ e controlli";
            // 
            // tlpMrz
            // 
            tlpMrz.ColumnCount = 2;
            tlpMrz.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tlpMrz.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMrz.Controls.Add(lblMrz, 0, 0);
            tlpMrz.Controls.Add(txtMrz, 1, 0);
            tlpMrz.Controls.Add(lblTipoDocumento, 0, 1);
            tlpMrz.Controls.Add(txtTipoDocumento, 1, 1);
            tlpMrz.Controls.Add(lblNazionalita, 0, 2);
            tlpMrz.Controls.Add(txtNazionalita, 1, 2);
            tlpMrz.Controls.Add(lblNumeroDocumento, 0, 3);
            tlpMrz.Controls.Add(txtNumeroDocumento, 1, 3);
            tlpMrz.Controls.Add(lblSesso, 0, 4);
            tlpMrz.Controls.Add(txtSesso, 1, 4);
            tlpMrz.Controls.Add(lblCittadinanza, 0, 5);
            tlpMrz.Controls.Add(txtCittadinanza, 1, 5);
            tlpMrz.Controls.Add(lblCheckNumero, 0, 6);
            tlpMrz.Controls.Add(txtCheckNumero, 1, 6);
            tlpMrz.Controls.Add(lblCheckDataNascita, 0, 7);
            tlpMrz.Controls.Add(txtCheckDataNascita, 1, 7);
            tlpMrz.Controls.Add(lblCheckScadenza, 0, 8);
            tlpMrz.Controls.Add(txtCheckScadenza, 1, 8);
            tlpMrz.Controls.Add(lblCheckFinale, 0, 9);
            tlpMrz.Controls.Add(txtCheckFinale, 1, 9);
            tlpMrz.Dock = DockStyle.Fill;
            tlpMrz.Location = new Point(10, 26);
            tlpMrz.Name = "tlpMrz";
            tlpMrz.RowCount = 11;
            tlpMrz.RowStyles.Add(new RowStyle(SizeType.Absolute, 78F));
            tlpMrz.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpMrz.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpMrz.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpMrz.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpMrz.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpMrz.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpMrz.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpMrz.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpMrz.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpMrz.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpMrz.Size = new Size(840, 348);
            tlpMrz.TabIndex = 0;
            // 
            // lblMrz
            // 
            lblMrz.AutoSize = true;
            lblMrz.Dock = DockStyle.Fill;
            lblMrz.Location = new Point(3, 0);
            lblMrz.Name = "lblMrz";
            lblMrz.Size = new Size(144, 78);
            lblMrz.TabIndex = 0;
            lblMrz.Text = "MRZ";
            lblMrz.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtMrz
            // 
            txtMrz.Dock = DockStyle.Fill;
            txtMrz.Location = new Point(153, 3);
            txtMrz.Multiline = true;
            txtMrz.Name = "txtMrz";
            txtMrz.ReadOnly = true;
            txtMrz.ScrollBars = ScrollBars.Vertical;
            txtMrz.Size = new Size(684, 72);
            txtMrz.TabIndex = 1;
            // 
            // lblTipoDocumento
            // 
            lblTipoDocumento.AutoSize = true;
            lblTipoDocumento.Dock = DockStyle.Fill;
            lblTipoDocumento.Location = new Point(3, 78);
            lblTipoDocumento.Name = "lblTipoDocumento";
            lblTipoDocumento.Size = new Size(144, 30);
            lblTipoDocumento.TabIndex = 2;
            lblTipoDocumento.Text = "Tipo documento";
            lblTipoDocumento.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtTipoDocumento
            // 
            txtTipoDocumento.Dock = DockStyle.Fill;
            txtTipoDocumento.Location = new Point(153, 81);
            txtTipoDocumento.Name = "txtTipoDocumento";
            txtTipoDocumento.ReadOnly = true;
            txtTipoDocumento.Size = new Size(684, 23);
            txtTipoDocumento.TabIndex = 3;
            // 
            // lblNazionalita
            // 
            lblNazionalita.AutoSize = true;
            lblNazionalita.Dock = DockStyle.Fill;
            lblNazionalita.Location = new Point(3, 108);
            lblNazionalita.Name = "lblNazionalita";
            lblNazionalita.Size = new Size(144, 30);
            lblNazionalita.TabIndex = 4;
            lblNazionalita.Text = "Nazionalità";
            lblNazionalita.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNazionalita
            // 
            txtNazionalita.Dock = DockStyle.Fill;
            txtNazionalita.Location = new Point(153, 111);
            txtNazionalita.Name = "txtNazionalita";
            txtNazionalita.ReadOnly = true;
            txtNazionalita.Size = new Size(684, 23);
            txtNazionalita.TabIndex = 5;
            // 
            // lblNumeroDocumento
            // 
            lblNumeroDocumento.AutoSize = true;
            lblNumeroDocumento.Dock = DockStyle.Fill;
            lblNumeroDocumento.Location = new Point(3, 138);
            lblNumeroDocumento.Name = "lblNumeroDocumento";
            lblNumeroDocumento.Size = new Size(144, 30);
            lblNumeroDocumento.TabIndex = 6;
            lblNumeroDocumento.Text = "Numero documento";
            lblNumeroDocumento.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNumeroDocumento
            // 
            txtNumeroDocumento.Dock = DockStyle.Fill;
            txtNumeroDocumento.Location = new Point(153, 141);
            txtNumeroDocumento.Name = "txtNumeroDocumento";
            txtNumeroDocumento.ReadOnly = true;
            txtNumeroDocumento.Size = new Size(684, 23);
            txtNumeroDocumento.TabIndex = 7;
            // 
            // lblSesso
            // 
            lblSesso.AutoSize = true;
            lblSesso.Dock = DockStyle.Fill;
            lblSesso.Location = new Point(3, 168);
            lblSesso.Name = "lblSesso";
            lblSesso.Size = new Size(144, 30);
            lblSesso.TabIndex = 8;
            lblSesso.Text = "Sesso";
            lblSesso.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSesso
            // 
            txtSesso.Dock = DockStyle.Fill;
            txtSesso.Location = new Point(153, 171);
            txtSesso.Name = "txtSesso";
            txtSesso.ReadOnly = true;
            txtSesso.Size = new Size(684, 23);
            txtSesso.TabIndex = 9;
            // 
            // lblCittadinanza
            // 
            lblCittadinanza.AutoSize = true;
            lblCittadinanza.Dock = DockStyle.Fill;
            lblCittadinanza.Location = new Point(3, 198);
            lblCittadinanza.Name = "lblCittadinanza";
            lblCittadinanza.Size = new Size(144, 30);
            lblCittadinanza.TabIndex = 10;
            lblCittadinanza.Text = "Cittadinanza";
            lblCittadinanza.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCittadinanza
            // 
            txtCittadinanza.Dock = DockStyle.Fill;
            txtCittadinanza.Location = new Point(153, 201);
            txtCittadinanza.Name = "txtCittadinanza";
            txtCittadinanza.ReadOnly = true;
            txtCittadinanza.Size = new Size(684, 23);
            txtCittadinanza.TabIndex = 11;
            // 
            // lblCheckNumero
            // 
            lblCheckNumero.AutoSize = true;
            lblCheckNumero.Dock = DockStyle.Fill;
            lblCheckNumero.Location = new Point(3, 228);
            lblCheckNumero.Name = "lblCheckNumero";
            lblCheckNumero.Size = new Size(144, 30);
            lblCheckNumero.TabIndex = 12;
            lblCheckNumero.Text = "Check numero documento";
            lblCheckNumero.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCheckNumero
            // 
            txtCheckNumero.Dock = DockStyle.Fill;
            txtCheckNumero.Location = new Point(153, 231);
            txtCheckNumero.Name = "txtCheckNumero";
            txtCheckNumero.ReadOnly = true;
            txtCheckNumero.Size = new Size(684, 23);
            txtCheckNumero.TabIndex = 13;
            // 
            // lblCheckDataNascita
            // 
            lblCheckDataNascita.AutoSize = true;
            lblCheckDataNascita.Dock = DockStyle.Fill;
            lblCheckDataNascita.Location = new Point(3, 258);
            lblCheckDataNascita.Name = "lblCheckDataNascita";
            lblCheckDataNascita.Size = new Size(144, 30);
            lblCheckDataNascita.TabIndex = 14;
            lblCheckDataNascita.Text = "Check data nascita";
            lblCheckDataNascita.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCheckDataNascita
            // 
            txtCheckDataNascita.Dock = DockStyle.Fill;
            txtCheckDataNascita.Location = new Point(153, 261);
            txtCheckDataNascita.Name = "txtCheckDataNascita";
            txtCheckDataNascita.ReadOnly = true;
            txtCheckDataNascita.Size = new Size(684, 23);
            txtCheckDataNascita.TabIndex = 15;
            // 
            // lblCheckScadenza
            // 
            lblCheckScadenza.AutoSize = true;
            lblCheckScadenza.Dock = DockStyle.Fill;
            lblCheckScadenza.Location = new Point(3, 288);
            lblCheckScadenza.Name = "lblCheckScadenza";
            lblCheckScadenza.Size = new Size(144, 30);
            lblCheckScadenza.TabIndex = 16;
            lblCheckScadenza.Text = "Check data scadenza";
            lblCheckScadenza.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCheckScadenza
            // 
            txtCheckScadenza.Dock = DockStyle.Fill;
            txtCheckScadenza.Location = new Point(153, 291);
            txtCheckScadenza.Name = "txtCheckScadenza";
            txtCheckScadenza.ReadOnly = true;
            txtCheckScadenza.Size = new Size(684, 23);
            txtCheckScadenza.TabIndex = 17;
            // 
            // lblCheckFinale
            // 
            lblCheckFinale.AutoSize = true;
            lblCheckFinale.Dock = DockStyle.Fill;
            lblCheckFinale.Location = new Point(3, 318);
            lblCheckFinale.Name = "lblCheckFinale";
            lblCheckFinale.Size = new Size(144, 30);
            lblCheckFinale.TabIndex = 18;
            lblCheckFinale.Text = "Check finale";
            lblCheckFinale.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCheckFinale
            // 
            txtCheckFinale.Dock = DockStyle.Fill;
            txtCheckFinale.Location = new Point(153, 321);
            txtCheckFinale.Name = "txtCheckFinale";
            txtCheckFinale.ReadOnly = true;
            txtCheckFinale.Size = new Size(684, 23);
            txtCheckFinale.TabIndex = 19;
            // 
            // grpDatiAnagrafici
            // 
            grpDatiAnagrafici.Controls.Add(tlpDati);
            grpDatiAnagrafici.Dock = DockStyle.Top;
            grpDatiAnagrafici.Location = new Point(0, 0);
            grpDatiAnagrafici.Name = "grpDatiAnagrafici";
            grpDatiAnagrafici.Padding = new Padding(10);
            grpDatiAnagrafici.Size = new Size(860, 320);
            grpDatiAnagrafici.TabIndex = 0;
            grpDatiAnagrafici.TabStop = false;
            grpDatiAnagrafici.Text = "Dati anagrafici";
            // 
            // tlpDati
            // 
            tlpDati.ColumnCount = 2;
            tlpDati.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tlpDati.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpDati.Controls.Add(lblCognome, 0, 0);
            tlpDati.Controls.Add(txtCognome, 1, 0);
            tlpDati.Controls.Add(lblNome, 0, 1);
            tlpDati.Controls.Add(txtNome, 1, 1);
            tlpDati.Controls.Add(lblLocalitaNascita, 0, 2);
            tlpDati.Controls.Add(txtLocalitaNascita, 1, 2);
            tlpDati.Controls.Add(lblDataNascita, 0, 3);
            tlpDati.Controls.Add(txtDataNascita, 1, 3);
            tlpDati.Controls.Add(lblProvinciaNascita, 0, 4);
            tlpDati.Controls.Add(txtProvinciaNascita, 1, 4);
            tlpDati.Controls.Add(lblIndirizzoResidenza, 0, 5);
            tlpDati.Controls.Add(txtIndirizzoResidenza, 1, 5);
            tlpDati.Controls.Add(lblCittaResidenza, 0, 6);
            tlpDati.Controls.Add(txtCittaResidenza, 1, 6);
            tlpDati.Controls.Add(lblProvinciaResidenza, 0, 7);
            tlpDati.Controls.Add(txtProvinciaResidenza, 1, 7);
            tlpDati.Controls.Add(lblCodiceFiscale, 0, 8);
            tlpDati.Controls.Add(txtCodiceFiscale, 1, 8);
            tlpDati.Controls.Add(lblScadenzaCarta, 0, 9);
            tlpDati.Controls.Add(txtScadenzaCarta, 1, 9);
            tlpDati.Dock = DockStyle.Fill;
            tlpDati.Location = new Point(10, 26);
            tlpDati.Name = "tlpDati";
            tlpDati.RowCount = 10;
            tlpDati.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tlpDati.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tlpDati.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tlpDati.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tlpDati.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tlpDati.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tlpDati.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tlpDati.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tlpDati.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tlpDati.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tlpDati.Size = new Size(840, 284);
            tlpDati.TabIndex = 0;
            // 
            // lblCognome
            // 
            lblCognome.AutoSize = true;
            lblCognome.Dock = DockStyle.Fill;
            lblCognome.Location = new Point(3, 0);
            lblCognome.Name = "lblCognome";
            lblCognome.Size = new Size(144, 28);
            lblCognome.TabIndex = 0;
            lblCognome.Text = "Cognome";
            lblCognome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCognome
            // 
            txtCognome.Dock = DockStyle.Fill;
            txtCognome.Location = new Point(153, 3);
            txtCognome.Name = "txtCognome";
            txtCognome.ReadOnly = true;
            txtCognome.Size = new Size(684, 23);
            txtCognome.TabIndex = 1;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Dock = DockStyle.Fill;
            lblNome.Location = new Point(3, 28);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(144, 28);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome";
            lblNome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNome
            // 
            txtNome.Dock = DockStyle.Fill;
            txtNome.Location = new Point(153, 31);
            txtNome.Name = "txtNome";
            txtNome.ReadOnly = true;
            txtNome.Size = new Size(684, 23);
            txtNome.TabIndex = 3;
            // 
            // lblLocalitaNascita
            // 
            lblLocalitaNascita.AutoSize = true;
            lblLocalitaNascita.Dock = DockStyle.Fill;
            lblLocalitaNascita.Location = new Point(3, 56);
            lblLocalitaNascita.Name = "lblLocalitaNascita";
            lblLocalitaNascita.Size = new Size(144, 28);
            lblLocalitaNascita.TabIndex = 4;
            lblLocalitaNascita.Text = "Località di nascita";
            lblLocalitaNascita.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtLocalitaNascita
            // 
            txtLocalitaNascita.Dock = DockStyle.Fill;
            txtLocalitaNascita.Location = new Point(153, 59);
            txtLocalitaNascita.Name = "txtLocalitaNascita";
            txtLocalitaNascita.ReadOnly = true;
            txtLocalitaNascita.Size = new Size(684, 23);
            txtLocalitaNascita.TabIndex = 5;
            // 
            // lblDataNascita
            // 
            lblDataNascita.AutoSize = true;
            lblDataNascita.Dock = DockStyle.Fill;
            lblDataNascita.Location = new Point(3, 84);
            lblDataNascita.Name = "lblDataNascita";
            lblDataNascita.Size = new Size(144, 28);
            lblDataNascita.TabIndex = 6;
            lblDataNascita.Text = "Data di nascita";
            lblDataNascita.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDataNascita
            // 
            txtDataNascita.Dock = DockStyle.Fill;
            txtDataNascita.Location = new Point(153, 87);
            txtDataNascita.Name = "txtDataNascita";
            txtDataNascita.ReadOnly = true;
            txtDataNascita.Size = new Size(684, 23);
            txtDataNascita.TabIndex = 7;
            // 
            // lblProvinciaNascita
            // 
            lblProvinciaNascita.AutoSize = true;
            lblProvinciaNascita.Dock = DockStyle.Fill;
            lblProvinciaNascita.Location = new Point(3, 112);
            lblProvinciaNascita.Name = "lblProvinciaNascita";
            lblProvinciaNascita.Size = new Size(144, 28);
            lblProvinciaNascita.TabIndex = 8;
            lblProvinciaNascita.Text = "Provincia di nascita";
            lblProvinciaNascita.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtProvinciaNascita
            // 
            txtProvinciaNascita.Dock = DockStyle.Fill;
            txtProvinciaNascita.Location = new Point(153, 115);
            txtProvinciaNascita.Name = "txtProvinciaNascita";
            txtProvinciaNascita.ReadOnly = true;
            txtProvinciaNascita.Size = new Size(684, 23);
            txtProvinciaNascita.TabIndex = 9;
            // 
            // lblIndirizzoResidenza
            // 
            lblIndirizzoResidenza.AutoSize = true;
            lblIndirizzoResidenza.Dock = DockStyle.Fill;
            lblIndirizzoResidenza.Location = new Point(3, 140);
            lblIndirizzoResidenza.Name = "lblIndirizzoResidenza";
            lblIndirizzoResidenza.Size = new Size(144, 28);
            lblIndirizzoResidenza.TabIndex = 10;
            lblIndirizzoResidenza.Text = "Indirizzo di residenza";
            lblIndirizzoResidenza.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtIndirizzoResidenza
            // 
            txtIndirizzoResidenza.Dock = DockStyle.Fill;
            txtIndirizzoResidenza.Location = new Point(153, 143);
            txtIndirizzoResidenza.Name = "txtIndirizzoResidenza";
            txtIndirizzoResidenza.ReadOnly = true;
            txtIndirizzoResidenza.Size = new Size(684, 23);
            txtIndirizzoResidenza.TabIndex = 11;
            // 
            // lblCittaResidenza
            // 
            lblCittaResidenza.AutoSize = true;
            lblCittaResidenza.Dock = DockStyle.Fill;
            lblCittaResidenza.Location = new Point(3, 168);
            lblCittaResidenza.Name = "lblCittaResidenza";
            lblCittaResidenza.Size = new Size(144, 28);
            lblCittaResidenza.TabIndex = 12;
            lblCittaResidenza.Text = "Città di residenza";
            lblCittaResidenza.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCittaResidenza
            // 
            txtCittaResidenza.Dock = DockStyle.Fill;
            txtCittaResidenza.Location = new Point(153, 171);
            txtCittaResidenza.Name = "txtCittaResidenza";
            txtCittaResidenza.ReadOnly = true;
            txtCittaResidenza.Size = new Size(684, 23);
            txtCittaResidenza.TabIndex = 13;
            // 
            // lblProvinciaResidenza
            // 
            lblProvinciaResidenza.AutoSize = true;
            lblProvinciaResidenza.Dock = DockStyle.Fill;
            lblProvinciaResidenza.Location = new Point(3, 196);
            lblProvinciaResidenza.Name = "lblProvinciaResidenza";
            lblProvinciaResidenza.Size = new Size(144, 28);
            lblProvinciaResidenza.TabIndex = 14;
            lblProvinciaResidenza.Text = "Provincia di residenza";
            lblProvinciaResidenza.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtProvinciaResidenza
            // 
            txtProvinciaResidenza.Dock = DockStyle.Fill;
            txtProvinciaResidenza.Location = new Point(153, 199);
            txtProvinciaResidenza.Name = "txtProvinciaResidenza";
            txtProvinciaResidenza.ReadOnly = true;
            txtProvinciaResidenza.Size = new Size(684, 23);
            txtProvinciaResidenza.TabIndex = 15;
            // 
            // lblCodiceFiscale
            // 
            lblCodiceFiscale.AutoSize = true;
            lblCodiceFiscale.Dock = DockStyle.Fill;
            lblCodiceFiscale.Location = new Point(3, 224);
            lblCodiceFiscale.Name = "lblCodiceFiscale";
            lblCodiceFiscale.Size = new Size(144, 28);
            lblCodiceFiscale.TabIndex = 16;
            lblCodiceFiscale.Text = "Codice fiscale";
            lblCodiceFiscale.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCodiceFiscale
            // 
            txtCodiceFiscale.Dock = DockStyle.Fill;
            txtCodiceFiscale.Location = new Point(153, 227);
            txtCodiceFiscale.Name = "txtCodiceFiscale";
            txtCodiceFiscale.ReadOnly = true;
            txtCodiceFiscale.Size = new Size(684, 23);
            txtCodiceFiscale.TabIndex = 17;
            // 
            // lblScadenzaCarta
            // 
            lblScadenzaCarta.AutoSize = true;
            lblScadenzaCarta.Dock = DockStyle.Fill;
            lblScadenzaCarta.Location = new Point(3, 252);
            lblScadenzaCarta.Name = "lblScadenzaCarta";
            lblScadenzaCarta.Size = new Size(144, 32);
            lblScadenzaCarta.TabIndex = 18;
            lblScadenzaCarta.Text = "Scadenza carta";
            lblScadenzaCarta.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtScadenzaCarta
            // 
            txtScadenzaCarta.Dock = DockStyle.Fill;
            txtScadenzaCarta.Location = new Point(153, 255);
            txtScadenzaCarta.Name = "txtScadenzaCarta";
            txtScadenzaCarta.ReadOnly = true;
            txtScadenzaCarta.Size = new Size(684, 23);
            txtScadenzaCarta.TabIndex = 19;
            // 
            // grpFoto
            // 
            grpFoto.Controls.Add(tlpFoto);
            grpFoto.Dock = DockStyle.Fill;
            grpFoto.Location = new Point(0, 0);
            grpFoto.Name = "grpFoto";
            grpFoto.Padding = new Padding(10);
            grpFoto.Size = new Size(410, 704);
            grpFoto.TabIndex = 0;
            grpFoto.TabStop = false;
            grpFoto.Text = "Foto e file immagine";
            // 
            // tlpFoto
            // 
            tlpFoto.ColumnCount = 1;
            tlpFoto.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpFoto.Controls.Add(picFoto, 0, 0);
            tlpFoto.Controls.Add(lblPathJp2, 0, 1);
            tlpFoto.Controls.Add(txtPathJp2, 0, 2);
            tlpFoto.Controls.Add(lblPathJpg, 0, 3);
            tlpFoto.Controls.Add(txtPathJpg, 0, 4);
            tlpFoto.Dock = DockStyle.Fill;
            tlpFoto.Location = new Point(10, 26);
            tlpFoto.Name = "tlpFoto";
            tlpFoto.RowCount = 5;
            tlpFoto.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpFoto.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tlpFoto.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tlpFoto.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tlpFoto.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tlpFoto.Size = new Size(390, 668);
            tlpFoto.TabIndex = 0;
            // 
            // picFoto
            // 
            picFoto.BorderStyle = BorderStyle.FixedSingle;
            picFoto.Dock = DockStyle.Fill;
            picFoto.Location = new Point(3, 3);
            picFoto.Name = "picFoto";
            picFoto.Size = new Size(384, 514);
            picFoto.SizeMode = PictureBoxSizeMode.Zoom;
            picFoto.TabIndex = 0;
            picFoto.TabStop = false;
            // 
            // lblPathJp2
            // 
            lblPathJp2.AutoSize = true;
            lblPathJp2.Dock = DockStyle.Fill;
            lblPathJp2.Location = new Point(3, 520);
            lblPathJp2.Name = "lblPathJp2";
            lblPathJp2.Size = new Size(384, 22);
            lblPathJp2.TabIndex = 1;
            lblPathJp2.Text = "Percorso file JP2";
            lblPathJp2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtPathJp2
            // 
            txtPathJp2.Dock = DockStyle.Fill;
            txtPathJp2.Location = new Point(3, 545);
            txtPathJp2.Multiline = true;
            txtPathJp2.Name = "txtPathJp2";
            txtPathJp2.ReadOnly = true;
            txtPathJp2.ScrollBars = ScrollBars.Vertical;
            txtPathJp2.Size = new Size(384, 46);
            txtPathJp2.TabIndex = 2;
            // 
            // lblPathJpg
            // 
            lblPathJpg.AutoSize = true;
            lblPathJpg.Dock = DockStyle.Fill;
            lblPathJpg.Location = new Point(3, 594);
            lblPathJpg.Name = "lblPathJpg";
            lblPathJpg.Size = new Size(384, 22);
            lblPathJpg.TabIndex = 3;
            lblPathJpg.Text = "Percorso file JPG";
            lblPathJpg.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtPathJpg
            // 
            txtPathJpg.Dock = DockStyle.Fill;
            txtPathJpg.Location = new Point(3, 619);
            txtPathJpg.Multiline = true;
            txtPathJpg.Name = "txtPathJpg";
            txtPathJpg.ReadOnly = true;
            txtPathJpg.ScrollBars = ScrollBars.Vertical;
            txtPathJpg.Size = new Size(384, 46);
            txtPathJpg.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 820);
            Controls.Add(tlpMain);
            MinimumSize = new Size(1100, 760);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Demo lettura dati CIE";
            tlpMain.ResumeLayout(false);
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            splitMain.Panel1.ResumeLayout(false);
            splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitMain).EndInit();
            splitMain.ResumeLayout(false);
            grpMrz.ResumeLayout(false);
            tlpMrz.ResumeLayout(false);
            tlpMrz.PerformLayout();
            grpDatiAnagrafici.ResumeLayout(false);
            tlpDati.ResumeLayout(false);
            tlpDati.PerformLayout();
            grpFoto.ResumeLayout(false);
            tlpFoto.ResumeLayout(false);
            tlpFoto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFoto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
    }
}