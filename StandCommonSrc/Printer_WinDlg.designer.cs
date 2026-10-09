namespace StandFacile
{
    partial class WinPrinterDlg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PrintersListCombo = new System.Windows.Forms.ComboBox();
            this.WP_lblPrintersList = new System.Windows.Forms.Label();
            this.WP_btnRcpFontSelect = new System.Windows.Forms.Button();
            this.WP_btnLogoFileSelect = new System.Windows.Forms.Button();
            this.WP_btnRepFontSelect = new System.Windows.Forms.Button();
            this.WP_btnDeleteLogo = new System.Windows.Forms.Button();
            this.WP_btnSampleText = new System.Windows.Forms.Button();
            this.Memo = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.WP_lblRecap = new System.Windows.Forms.Label();
            this.WP_labelMarginRcp = new System.Windows.Forms.Label();
            this.WP_labelMarginRep = new System.Windows.Forms.Label();
            this.WP_logoImage = new System.Windows.Forms.PictureBox();
            this.numUpDownRcpZoom = new System.Windows.Forms.NumericUpDown();
            this.numUpDownRepZoom = new System.Windows.Forms.NumericUpDown();
            this.numUpDownLogoZoom = new System.Windows.Forms.NumericUpDown();
            this.WP_labelZoomRcp = new System.Windows.Forms.Label();
            this.WP_labelZoomRep = new System.Windows.Forms.Label();
            this.WP_labelZoomLogo = new System.Windows.Forms.Label();
            this.WP_labelCenterLogo = new System.Windows.Forms.Label();
            this.numUpDown_RcpMargin = new System.Windows.Forms.NumericUpDown();
            this.numUpDown_RepMargin = new System.Windows.Forms.NumericUpDown();
            this.numUpDown_LogoCenter = new System.Windows.Forms.NumericUpDown();
            this.BtnDefaults = new System.Windows.Forms.Button();
            this.labelDefault = new System.Windows.Forms.Label();
            this.WP_groupBoxLogoChoice = new System.Windows.Forms.GroupBox();
            this.WP_lblLogoPreview = new System.Windows.Forms.Label();
            this.RadioBtnLogo_B = new System.Windows.Forms.RadioButton();
            this.RadioBtnLogo_T = new System.Windows.Forms.RadioButton();
            this.checkBox_escpos = new System.Windows.Forms.CheckBox();
            this.checkBox_CashDrawer = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.WP_logoImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownRcpZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownRepZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownLogoZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_RcpMargin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_RepMargin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_LogoCenter)).BeginInit();
            this.WP_groupBoxLogoChoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // PrintersListCombo
            // 
            this.PrintersListCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PrintersListCombo.FormattingEnabled = true;
            this.PrintersListCombo.Location = new System.Drawing.Point(26, 45);
            this.PrintersListCombo.Name = "PrintersListCombo";
            this.PrintersListCombo.Size = new System.Drawing.Size(200, 21);
            this.PrintersListCombo.TabIndex = 1;
            this.PrintersListCombo.SelectedIndexChanged += new System.EventHandler(this.PrintersListCombo_SelectedIndexChanged);
            // 
            // WP_lblPrintersList
            // 
            this.WP_lblPrintersList.AutoSize = true;
            this.WP_lblPrintersList.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WP_lblPrintersList.Location = new System.Drawing.Point(23, 19);
            this.WP_lblPrintersList.Name = "WP_lblPrintersList";
            this.WP_lblPrintersList.Size = new System.Drawing.Size(110, 14);
            this.WP_lblPrintersList.TabIndex = 0;
            this.WP_lblPrintersList.Text = "Elenco Stampanti :";
            // 
            // WP_btnRcpFontSelect
            // 
            this.WP_btnRcpFontSelect.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WP_btnRcpFontSelect.Location = new System.Drawing.Point(26, 102);
            this.WP_btnRcpFontSelect.Name = "WP_btnRcpFontSelect";
            this.WP_btnRcpFontSelect.Size = new System.Drawing.Size(141, 23);
            this.WP_btnRcpFontSelect.TabIndex = 4;
            this.WP_btnRcpFontSelect.Text = "Scegli &Font scontrini ...";
            this.WP_btnRcpFontSelect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WP_btnRcpFontSelect.UseVisualStyleBackColor = true;
            this.WP_btnRcpFontSelect.Click += new System.EventHandler(this.BtnTicketsFontSelect_Click);
            // 
            // WP_btnLogoFileSelect
            // 
            this.WP_btnLogoFileSelect.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WP_btnLogoFileSelect.Location = new System.Drawing.Point(26, 413);
            this.WP_btnLogoFileSelect.Name = "WP_btnLogoFileSelect";
            this.WP_btnLogoFileSelect.Size = new System.Drawing.Size(141, 23);
            this.WP_btnLogoFileSelect.TabIndex = 10;
            this.WP_btnLogoFileSelect.Text = "Scegli il File del &Logo";
            this.WP_btnLogoFileSelect.UseVisualStyleBackColor = true;
            this.WP_btnLogoFileSelect.Click += new System.EventHandler(this.BtnLogoFileSelect_Click);
            // 
            // WP_btnRepFontSelect
            // 
            this.WP_btnRepFontSelect.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WP_btnRepFontSelect.Location = new System.Drawing.Point(26, 205);
            this.WP_btnRepFontSelect.Name = "WP_btnRepFontSelect";
            this.WP_btnRepFontSelect.Size = new System.Drawing.Size(141, 23);
            this.WP_btnRepFontSelect.TabIndex = 7;
            this.WP_btnRepFontSelect.Text = "Scegli F&ont riepiloghi ...";
            this.WP_btnRepFontSelect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WP_btnRepFontSelect.UseVisualStyleBackColor = true;
            this.WP_btnRepFontSelect.Click += new System.EventHandler(this.BtnReportsFontSelect_Click);
            // 
            // WP_btnDeleteLogo
            // 
            this.WP_btnDeleteLogo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WP_btnDeleteLogo.Image = global::StandFacile.Properties.Resources.Cancel;
            this.WP_btnDeleteLogo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WP_btnDeleteLogo.Location = new System.Drawing.Point(26, 456);
            this.WP_btnDeleteLogo.Name = "WP_btnDeleteLogo";
            this.WP_btnDeleteLogo.Size = new System.Drawing.Size(141, 23);
            this.WP_btnDeleteLogo.TabIndex = 11;
            this.WP_btnDeleteLogo.Text = "    Elimina Logo";
            this.WP_btnDeleteLogo.UseVisualStyleBackColor = true;
            this.WP_btnDeleteLogo.Click += new System.EventHandler(this.BtnDeleteLogo_Click);
            // 
            // WP_btnSampleText
            // 
            this.WP_btnSampleText.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WP_btnSampleText.Location = new System.Drawing.Point(26, 498);
            this.WP_btnSampleText.Name = "WP_btnSampleText";
            this.WP_btnSampleText.Size = new System.Drawing.Size(141, 23);
            this.WP_btnSampleText.TabIndex = 13;
            this.WP_btnSampleText.Text = "stampa testo di prova";
            this.WP_btnSampleText.UseVisualStyleBackColor = true;
            this.WP_btnSampleText.Click += new System.EventHandler(this.SampleTextBtn_Click);
            // 
            // Memo
            // 
            this.Memo.AcceptsReturn = true;
            this.Memo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Memo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Memo.Location = new System.Drawing.Point(276, 45);
            this.Memo.Multiline = true;
            this.Memo.Name = "Memo";
            this.Memo.ReadOnly = true;
            this.Memo.Size = new System.Drawing.Size(250, 219);
            this.Memo.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = global::StandFacile.Properties.Resources.Cancel;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(152, 628);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 28);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Annulla";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Image = global::StandFacile.Properties.Resources.OK;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(302, 630);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(72, 28);
            this.btnOK.TabIndex = 15;
            this.btnOK.Text = "OK";
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // WP_lblRecap
            // 
            this.WP_lblRecap.AutoSize = true;
            this.WP_lblRecap.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WP_lblRecap.Location = new System.Drawing.Point(273, 19);
            this.WP_lblRecap.Name = "WP_lblRecap";
            this.WP_lblRecap.Size = new System.Drawing.Size(144, 16);
            this.WP_lblRecap.TabIndex = 2;
            this.WP_lblRecap.Text = "Riepilogo Impostazioni :";
            // 
            // WP_labelMarginRcp
            // 
            this.WP_labelMarginRcp.AutoSize = true;
            this.WP_labelMarginRcp.Font = new System.Drawing.Font("Tahoma", 9F);
            this.WP_labelMarginRcp.Location = new System.Drawing.Point(34, 147);
            this.WP_labelMarginRcp.Name = "WP_labelMarginRcp";
            this.WP_labelMarginRcp.Size = new System.Drawing.Size(123, 14);
            this.WP_labelMarginRcp.TabIndex = 5;
            this.WP_labelMarginRcp.Text = "Margine SX (0,1mm):";
            // 
            // WP_labelMarginRep
            // 
            this.WP_labelMarginRep.AutoSize = true;
            this.WP_labelMarginRep.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WP_labelMarginRep.Location = new System.Drawing.Point(34, 246);
            this.WP_labelMarginRep.Name = "WP_labelMarginRep";
            this.WP_labelMarginRep.Size = new System.Drawing.Size(123, 14);
            this.WP_labelMarginRep.TabIndex = 8;
            this.WP_labelMarginRep.Text = "Margine SX (0,1mm):";
            // 
            // WP_logoImage
            // 
            this.WP_logoImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WP_logoImage.Location = new System.Drawing.Point(276, 346);
            this.WP_logoImage.Name = "WP_logoImage";
            this.WP_logoImage.Size = new System.Drawing.Size(250, 150);
            this.WP_logoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WP_logoImage.TabIndex = 17;
            this.WP_logoImage.TabStop = false;
            // 
            // numUpDownRcpZoom
            // 
            this.numUpDownRcpZoom.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUpDownRcpZoom.Location = new System.Drawing.Point(181, 105);
            this.numUpDownRcpZoom.Maximum = new decimal(new int[] {
            140,
            0,
            0,
            0});
            this.numUpDownRcpZoom.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numUpDownRcpZoom.Name = "numUpDownRcpZoom";
            this.numUpDownRcpZoom.Size = new System.Drawing.Size(45, 20);
            this.numUpDownRcpZoom.TabIndex = 25;
            this.numUpDownRcpZoom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUpDownRcpZoom.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numUpDownRcpZoom.Click += new System.EventHandler(this.NumUpDown_Click);
            // 
            // numUpDownRepZoom
            // 
            this.numUpDownRepZoom.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUpDownRepZoom.Location = new System.Drawing.Point(181, 207);
            this.numUpDownRepZoom.Maximum = new decimal(new int[] {
            140,
            0,
            0,
            0});
            this.numUpDownRepZoom.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numUpDownRepZoom.Name = "numUpDownRepZoom";
            this.numUpDownRepZoom.Size = new System.Drawing.Size(45, 20);
            this.numUpDownRepZoom.TabIndex = 26;
            this.numUpDownRepZoom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUpDownRepZoom.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numUpDownRepZoom.Click += new System.EventHandler(this.NumUpDown_Click);
            // 
            // numUpDownLogoZoom
            // 
            this.numUpDownLogoZoom.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUpDownLogoZoom.Location = new System.Drawing.Point(181, 369);
            this.numUpDownLogoZoom.Maximum = new decimal(new int[] {
            140,
            0,
            0,
            0});
            this.numUpDownLogoZoom.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numUpDownLogoZoom.Name = "numUpDownLogoZoom";
            this.numUpDownLogoZoom.Size = new System.Drawing.Size(45, 20);
            this.numUpDownLogoZoom.TabIndex = 27;
            this.numUpDownLogoZoom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUpDownLogoZoom.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numUpDownLogoZoom.Click += new System.EventHandler(this.NumUpDown_Click);
            // 
            // WP_labelZoomRcp
            // 
            this.WP_labelZoomRcp.AutoSize = true;
            this.WP_labelZoomRcp.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WP_labelZoomRcp.Location = new System.Drawing.Point(178, 86);
            this.WP_labelZoomRcp.Name = "WP_labelZoomRcp";
            this.WP_labelZoomRcp.Size = new System.Drawing.Size(55, 16);
            this.WP_labelZoomRcp.TabIndex = 28;
            this.WP_labelZoomRcp.Text = "Zoom %";
            // 
            // WP_labelZoomRep
            // 
            this.WP_labelZoomRep.AutoSize = true;
            this.WP_labelZoomRep.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WP_labelZoomRep.Location = new System.Drawing.Point(178, 188);
            this.WP_labelZoomRep.Name = "WP_labelZoomRep";
            this.WP_labelZoomRep.Size = new System.Drawing.Size(55, 16);
            this.WP_labelZoomRep.TabIndex = 29;
            this.WP_labelZoomRep.Text = "Zoom %";
            // 
            // WP_labelZoomLogo
            // 
            this.WP_labelZoomLogo.AutoSize = true;
            this.WP_labelZoomLogo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WP_labelZoomLogo.Location = new System.Drawing.Point(23, 370);
            this.WP_labelZoomLogo.Name = "WP_labelZoomLogo";
            this.WP_labelZoomLogo.Size = new System.Drawing.Size(140, 16);
            this.WP_labelZoomLogo.TabIndex = 30;
            this.WP_labelZoomLogo.Text = "Logo, Barcode Zoom %";
            // 
            // WP_labelCenterLogo
            // 
            this.WP_labelCenterLogo.AutoSize = true;
            this.WP_labelCenterLogo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WP_labelCenterLogo.Location = new System.Drawing.Point(19, 331);
            this.WP_labelCenterLogo.Name = "WP_labelCenterLogo";
            this.WP_labelCenterLogo.Size = new System.Drawing.Size(152, 14);
            this.WP_labelCenterLogo.TabIndex = 8;
            this.WP_labelCenterLogo.Text = "Centro Logo (+/- 0,1mm):";
            // 
            // numUpDown_RcpMargin
            // 
            this.numUpDown_RcpMargin.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUpDown_RcpMargin.Location = new System.Drawing.Point(181, 146);
            this.numUpDown_RcpMargin.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numUpDown_RcpMargin.Name = "numUpDown_RcpMargin";
            this.numUpDown_RcpMargin.Size = new System.Drawing.Size(45, 20);
            this.numUpDown_RcpMargin.TabIndex = 75;
            this.numUpDown_RcpMargin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUpDown_RcpMargin.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpDown_RcpMargin.Click += new System.EventHandler(this.NumUpDown_Click);
            // 
            // numUpDown_RepMargin
            // 
            this.numUpDown_RepMargin.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUpDown_RepMargin.Location = new System.Drawing.Point(181, 245);
            this.numUpDown_RepMargin.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numUpDown_RepMargin.Name = "numUpDown_RepMargin";
            this.numUpDown_RepMargin.Size = new System.Drawing.Size(45, 20);
            this.numUpDown_RepMargin.TabIndex = 76;
            this.numUpDown_RepMargin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUpDown_RepMargin.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpDown_RepMargin.Click += new System.EventHandler(this.NumUpDown_Click);
            // 
            // numUpDown_LogoCenter
            // 
            this.numUpDown_LogoCenter.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUpDown_LogoCenter.Location = new System.Drawing.Point(181, 329);
            this.numUpDown_LogoCenter.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numUpDown_LogoCenter.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            -2147483648});
            this.numUpDown_LogoCenter.Name = "numUpDown_LogoCenter";
            this.numUpDown_LogoCenter.Size = new System.Drawing.Size(45, 20);
            this.numUpDown_LogoCenter.TabIndex = 77;
            this.numUpDown_LogoCenter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUpDown_LogoCenter.Click += new System.EventHandler(this.NumUpDown_Click);
            // 
            // BtnDefaults
            // 
            this.BtnDefaults.Image = global::StandFacile.Properties.Resources.Cancel1;
            this.BtnDefaults.Location = new System.Drawing.Point(478, 510);
            this.BtnDefaults.Name = "BtnDefaults";
            this.BtnDefaults.Size = new System.Drawing.Size(35, 26);
            this.BtnDefaults.TabIndex = 78;
            this.BtnDefaults.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDefaults.UseVisualStyleBackColor = true;
            this.BtnDefaults.Click += new System.EventHandler(this.BtnDefaults_Click);
            // 
            // labelDefault
            // 
            this.labelDefault.AutoSize = true;
            this.labelDefault.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDefault.Location = new System.Drawing.Point(281, 516);
            this.labelDefault.Name = "labelDefault";
            this.labelDefault.Size = new System.Drawing.Size(181, 14);
            this.labelDefault.TabIndex = 79;
            this.labelDefault.Text = "ripristina default Zoom e margini";
            // 
            // WP_groupBoxLogoChoice
            // 
            this.WP_groupBoxLogoChoice.Controls.Add(this.WP_lblLogoPreview);
            this.WP_groupBoxLogoChoice.Controls.Add(this.RadioBtnLogo_B);
            this.WP_groupBoxLogoChoice.Controls.Add(this.RadioBtnLogo_T);
            this.WP_groupBoxLogoChoice.Location = new System.Drawing.Point(276, 270);
            this.WP_groupBoxLogoChoice.Name = "WP_groupBoxLogoChoice";
            this.WP_groupBoxLogoChoice.Size = new System.Drawing.Size(250, 71);
            this.WP_groupBoxLogoChoice.TabIndex = 81;
            this.WP_groupBoxLogoChoice.TabStop = false;
            // 
            // WP_lblLogoPreview
            // 
            this.WP_lblLogoPreview.AutoSize = true;
            this.WP_lblLogoPreview.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WP_lblLogoPreview.Location = new System.Drawing.Point(13, 47);
            this.WP_lblLogoPreview.Name = "WP_lblLogoPreview";
            this.WP_lblLogoPreview.Size = new System.Drawing.Size(106, 16);
            this.WP_lblLogoPreview.TabIndex = 14;
            this.WP_lblLogoPreview.Text = "Anteprima Logo :";
            // 
            // RadioBtnLogo_B
            // 
            this.RadioBtnLogo_B.AutoSize = true;
            this.RadioBtnLogo_B.Location = new System.Drawing.Point(142, 16);
            this.RadioBtnLogo_B.Name = "RadioBtnLogo_B";
            this.RadioBtnLogo_B.Size = new System.Drawing.Size(89, 17);
            this.RadioBtnLogo_B.TabIndex = 2;
            this.RadioBtnLogo_B.TabStop = true;
            this.RadioBtnLogo_B.Text = "Logo inferiore";
            this.RadioBtnLogo_B.UseVisualStyleBackColor = true;
            this.RadioBtnLogo_B.Click += new System.EventHandler(this.RadioBtnLogo_Click);
            // 
            // RadioBtnLogo_T
            // 
            this.RadioBtnLogo_T.AutoSize = true;
            this.RadioBtnLogo_T.Checked = true;
            this.RadioBtnLogo_T.Location = new System.Drawing.Point(16, 16);
            this.RadioBtnLogo_T.Name = "RadioBtnLogo_T";
            this.RadioBtnLogo_T.Size = new System.Drawing.Size(95, 17);
            this.RadioBtnLogo_T.TabIndex = 1;
            this.RadioBtnLogo_T.TabStop = true;
            this.RadioBtnLogo_T.Text = "Logo superiore";
            this.RadioBtnLogo_T.UseVisualStyleBackColor = true;
            this.RadioBtnLogo_T.Click += new System.EventHandler(this.RadioBtnLogo_Click);
            // 
            // checkBox_escpos
            // 
            this.checkBox_escpos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox_escpos.AutoSize = true;
            this.checkBox_escpos.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_escpos.Location = new System.Drawing.Point(26, 546);
            this.checkBox_escpos.Name = "checkBox_escpos";
            this.checkBox_escpos.Padding = new System.Windows.Forms.Padding(1);
            this.checkBox_escpos.Size = new System.Drawing.Size(252, 20);
            this.checkBox_escpos.TabIndex = 82;
            this.checkBox_escpos.Text = "utilizza la stampa con protocollo ESC/POS";
            this.checkBox_escpos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_escpos.UseVisualStyleBackColor = true;
            this.checkBox_escpos.Click += new System.EventHandler(this.checkBox_escpos_Click);
            // 
            // checkBox_CashDrawer
            // 
            this.checkBox_CashDrawer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox_CashDrawer.AutoSize = true;
            this.checkBox_CashDrawer.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_CashDrawer.Location = new System.Drawing.Point(26, 582);
            this.checkBox_CashDrawer.Name = "checkBox_CashDrawer";
            this.checkBox_CashDrawer.Padding = new System.Windows.Forms.Padding(1);
            this.checkBox_CashDrawer.Size = new System.Drawing.Size(254, 20);
            this.checkBox_CashDrawer.TabIndex = 83;
            this.checkBox_CashDrawer.Text = "comanda apertura cassetto con ESC/POS";
            this.checkBox_CashDrawer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_CashDrawer.UseVisualStyleBackColor = true;
            // 
            // WinPrinterDlg
            // 
            this.AcceptButton = this.btnCancel;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 669);
            this.Controls.Add(this.checkBox_CashDrawer);
            this.Controls.Add(this.checkBox_escpos);
            this.Controls.Add(this.WP_groupBoxLogoChoice);
            this.Controls.Add(this.labelDefault);
            this.Controls.Add(this.BtnDefaults);
            this.Controls.Add(this.numUpDown_LogoCenter);
            this.Controls.Add(this.numUpDown_RepMargin);
            this.Controls.Add(this.numUpDown_RcpMargin);
            this.Controls.Add(this.WP_labelZoomLogo);
            this.Controls.Add(this.WP_labelZoomRep);
            this.Controls.Add(this.WP_labelZoomRcp);
            this.Controls.Add(this.numUpDownLogoZoom);
            this.Controls.Add(this.numUpDownRepZoom);
            this.Controls.Add(this.numUpDownRcpZoom);
            this.Controls.Add(this.WP_logoImage);
            this.Controls.Add(this.WP_labelCenterLogo);
            this.Controls.Add(this.WP_labelMarginRep);
            this.Controls.Add(this.WP_labelMarginRcp);
            this.Controls.Add(this.WP_lblRecap);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.Memo);
            this.Controls.Add(this.WP_btnSampleText);
            this.Controls.Add(this.WP_btnDeleteLogo);
            this.Controls.Add(this.WP_btnRepFontSelect);
            this.Controls.Add(this.WP_btnLogoFileSelect);
            this.Controls.Add(this.WP_btnRcpFontSelect);
            this.Controls.Add(this.WP_lblPrintersList);
            this.Controls.Add(this.PrintersListCombo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WinPrinterDlg";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impostazioni stampante Scontrino Windows o ESC/POS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WinPrinterDlg_FormClosing);
            this.Click += new System.EventHandler(this.NumUpDown_Click);
            ((System.ComponentModel.ISupportInitialize)(this.WP_logoImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownRcpZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownRepZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownLogoZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_RcpMargin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_RepMargin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_LogoCenter)).EndInit();
            this.WP_groupBoxLogoChoice.ResumeLayout(false);
            this.WP_groupBoxLogoChoice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PrintersListCombo;
        private System.Windows.Forms.Label WP_lblPrintersList;
        private System.Windows.Forms.Button WP_btnRcpFontSelect;
        private System.Windows.Forms.Button WP_btnLogoFileSelect;
        private System.Windows.Forms.Button WP_btnRepFontSelect;
        private System.Windows.Forms.Button WP_btnDeleteLogo;
        private System.Windows.Forms.Button WP_btnSampleText;
        private System.Windows.Forms.TextBox Memo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label WP_lblRecap;
        private System.Windows.Forms.Label WP_labelMarginRcp;
        private System.Windows.Forms.Label WP_labelMarginRep;
        private System.Windows.Forms.PictureBox WP_logoImage;
        private System.Windows.Forms.NumericUpDown numUpDownRcpZoom;
        private System.Windows.Forms.NumericUpDown numUpDownRepZoom;
        private System.Windows.Forms.NumericUpDown numUpDownLogoZoom;
        private System.Windows.Forms.Label WP_labelZoomRcp;
        private System.Windows.Forms.Label WP_labelZoomRep;
        private System.Windows.Forms.Label WP_labelZoomLogo;
        private System.Windows.Forms.Label WP_labelCenterLogo;
        private System.Windows.Forms.NumericUpDown numUpDown_RcpMargin;
        private System.Windows.Forms.NumericUpDown numUpDown_RepMargin;
        private System.Windows.Forms.NumericUpDown numUpDown_LogoCenter;
        private System.Windows.Forms.Button BtnDefaults;
        private System.Windows.Forms.Label labelDefault;
        private System.Windows.Forms.GroupBox WP_groupBoxLogoChoice;
        private System.Windows.Forms.RadioButton RadioBtnLogo_T;
        private System.Windows.Forms.Label WP_lblLogoPreview;
        private System.Windows.Forms.RadioButton RadioBtnLogo_B;
        private System.Windows.Forms.CheckBox checkBox_escpos;
        private System.Windows.Forms.CheckBox checkBox_CashDrawer;
    }
}