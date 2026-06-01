namespace StandFacile
{
    partial class LegacyPrinterDlg
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
            this.PORT_Combo = new System.Windows.Forms.ComboBox();
            this.PrinterTypeCombo = new System.Windows.Forms.ComboBox();
            this.LogoBmpCombo = new System.Windows.Forms.ComboBox();
            this.FontTypeCombo = new System.Windows.Forms.ComboBox();
            this.lblPrt = new System.Windows.Forms.Label();
            this.lblCom = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblFont = new System.Windows.Forms.Label();
            this.TP_PaperSizeGroupBox = new System.Windows.Forms.GroupBox();
            this.width80 = new System.Windows.Forms.RadioButton();
            this.width57 = new System.Windows.Forms.RadioButton();
            this.TP_speedGroupBox = new System.Windows.Forms.GroupBox();
            this.TP_speedHigh = new System.Windows.Forms.RadioButton();
            this.TP_speedLow = new System.Windows.Forms.RadioButton();
            this.TP_speedMedium = new System.Windows.Forms.RadioButton();
            this.TP_densityGroupBox = new System.Windows.Forms.GroupBox();
            this.TP_densityHigh = new System.Windows.Forms.RadioButton();
            this.TP_densityMedium = new System.Windows.Forms.RadioButton();
            this.TP_densityLow = new System.Windows.Forms.RadioButton();
            this.TP_btnAutotest = new System.Windows.Forms.Button();
            this.TP_btnText = new System.Windows.Forms.Button();
            this.TP_btnInfo = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.Lbl_ImpSer = new System.Windows.Forms.Label();
            this.TP_SettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.TP_flow_RTS_CTS = new System.Windows.Forms.RadioButton();
            this.TP_flow_XON_XOFF = new System.Windows.Forms.RadioButton();
            this.TP_flow_NONE = new System.Windows.Forms.RadioButton();
            this.TP_FlowRadio = new System.Windows.Forms.GroupBox();
            this.TP_PaperSizeGroupBox.SuspendLayout();
            this.TP_speedGroupBox.SuspendLayout();
            this.TP_densityGroupBox.SuspendLayout();
            this.TP_SettingsGroupBox.SuspendLayout();
            this.TP_FlowRadio.SuspendLayout();
            this.SuspendLayout();
            // 
            // PORT_Combo
            // 
            this.PORT_Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PORT_Combo.FormattingEnabled = true;
            this.PORT_Combo.Location = new System.Drawing.Point(229, 53);
            this.PORT_Combo.Margin = new System.Windows.Forms.Padding(4);
            this.PORT_Combo.Name = "PORT_Combo";
            this.PORT_Combo.Size = new System.Drawing.Size(138, 24);
            this.PORT_Combo.TabIndex = 5;
            // 
            // PrinterTypeCombo
            // 
            this.PrinterTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PrinterTypeCombo.FormattingEnabled = true;
            this.PrinterTypeCombo.Location = new System.Drawing.Point(16, 53);
            this.PrinterTypeCombo.Margin = new System.Windows.Forms.Padding(4);
            this.PrinterTypeCombo.Name = "PrinterTypeCombo";
            this.PrinterTypeCombo.Size = new System.Drawing.Size(165, 24);
            this.PrinterTypeCombo.TabIndex = 3;
            this.PrinterTypeCombo.SelectedIndexChanged += new System.EventHandler(this.PrinterTypeCombo_SelectedIndexChanged);
            // 
            // LogoBmpCombo
            // 
            this.LogoBmpCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LogoBmpCombo.FormattingEnabled = true;
            this.LogoBmpCombo.Location = new System.Drawing.Point(17, 164);
            this.LogoBmpCombo.Margin = new System.Windows.Forms.Padding(4);
            this.LogoBmpCombo.Name = "LogoBmpCombo";
            this.LogoBmpCombo.Size = new System.Drawing.Size(164, 24);
            this.LogoBmpCombo.TabIndex = 8;
            // 
            // FontTypeCombo
            // 
            this.FontTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FontTypeCombo.Enabled = false;
            this.FontTypeCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FontTypeCombo.FormattingEnabled = true;
            this.FontTypeCombo.Location = new System.Drawing.Point(16, 285);
            this.FontTypeCombo.Margin = new System.Windows.Forms.Padding(4);
            this.FontTypeCombo.Name = "FontTypeCombo";
            this.FontTypeCombo.Size = new System.Drawing.Size(192, 23);
            this.FontTypeCombo.TabIndex = 12;
            // 
            // lblPrt
            // 
            this.lblPrt.AutoSize = true;
            this.lblPrt.Location = new System.Drawing.Point(12, 33);
            this.lblPrt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrt.Name = "lblPrt";
            this.lblPrt.Size = new System.Drawing.Size(144, 16);
            this.lblPrt.TabIndex = 2;
            this.lblPrt.Text = "Scelta della stampante";
            // 
            // lblCom
            // 
            this.lblCom.AutoSize = true;
            this.lblCom.Location = new System.Drawing.Point(226, 33);
            this.lblCom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCom.Name = "lblCom";
            this.lblCom.Size = new System.Drawing.Size(141, 16);
            this.lblCom.TabIndex = 4;
            this.lblCom.Text = "Scelta porta COM/LPT";
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Location = new System.Drawing.Point(13, 145);
            this.lblLogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(101, 16);
            this.lblLogo.TabIndex = 7;
            this.lblLogo.Text = "Scelta del Logo";
            // 
            // lblFont
            // 
            this.lblFont.AutoSize = true;
            this.lblFont.Location = new System.Drawing.Point(12, 265);
            this.lblFont.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(210, 16);
            this.lblFont.TabIndex = 11;
            this.lblFont.Text = "Scelta del Font della Copia cliente";
            // 
            // TP_PaperSizeGroupBox
            // 
            this.TP_PaperSizeGroupBox.Controls.Add(this.width80);
            this.TP_PaperSizeGroupBox.Controls.Add(this.width57);
            this.TP_PaperSizeGroupBox.Location = new System.Drawing.Point(229, 114);
            this.TP_PaperSizeGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.TP_PaperSizeGroupBox.Name = "TP_PaperSizeGroupBox";
            this.TP_PaperSizeGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.TP_PaperSizeGroupBox.Size = new System.Drawing.Size(138, 138);
            this.TP_PaperSizeGroupBox.TabIndex = 9;
            this.TP_PaperSizeGroupBox.TabStop = false;
            this.TP_PaperSizeGroupBox.Text = "larghezza carta";
            // 
            // width80
            // 
            this.width80.AutoSize = true;
            this.width80.Location = new System.Drawing.Point(31, 85);
            this.width80.Margin = new System.Windows.Forms.Padding(4);
            this.width80.Name = "width80";
            this.width80.Size = new System.Drawing.Size(64, 20);
            this.width80.TabIndex = 1;
            this.width80.TabStop = true;
            this.width80.Text = "80 mm";
            this.width80.UseVisualStyleBackColor = true;
            this.width80.CheckedChanged += new System.EventHandler(this.PrinterTypeCombo_SelectedIndexChanged);
            // 
            // width57
            // 
            this.width57.AutoSize = true;
            this.width57.Location = new System.Drawing.Point(31, 28);
            this.width57.Margin = new System.Windows.Forms.Padding(4);
            this.width57.Name = "width57";
            this.width57.Size = new System.Drawing.Size(64, 20);
            this.width57.TabIndex = 0;
            this.width57.TabStop = true;
            this.width57.Text = "57 mm";
            this.width57.UseVisualStyleBackColor = true;
            this.width57.CheckedChanged += new System.EventHandler(this.PrinterTypeCombo_SelectedIndexChanged);
            // 
            // TP_speedGroupBox
            // 
            this.TP_speedGroupBox.Controls.Add(this.TP_speedHigh);
            this.TP_speedGroupBox.Controls.Add(this.TP_speedLow);
            this.TP_speedGroupBox.Controls.Add(this.TP_speedMedium);
            this.TP_speedGroupBox.Location = new System.Drawing.Point(229, 285);
            this.TP_speedGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.TP_speedGroupBox.Name = "TP_speedGroupBox";
            this.TP_speedGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.TP_speedGroupBox.Size = new System.Drawing.Size(138, 117);
            this.TP_speedGroupBox.TabIndex = 13;
            this.TP_speedGroupBox.TabStop = false;
            this.TP_speedGroupBox.Text = "velocità di stampa";
            // 
            // TP_speedHigh
            // 
            this.TP_speedHigh.AutoSize = true;
            this.TP_speedHigh.Location = new System.Drawing.Point(23, 84);
            this.TP_speedHigh.Margin = new System.Windows.Forms.Padding(4);
            this.TP_speedHigh.Name = "TP_speedHigh";
            this.TP_speedHigh.Size = new System.Drawing.Size(47, 20);
            this.TP_speedHigh.TabIndex = 2;
            this.TP_speedHigh.TabStop = true;
            this.TP_speedHigh.Text = "alta";
            this.TP_speedHigh.UseVisualStyleBackColor = true;
            this.TP_speedHigh.CheckedChanged += new System.EventHandler(this.PrinterTypeCombo_SelectedIndexChanged);
            this.TP_speedHigh.RightToLeftChanged += new System.EventHandler(this.PrinterTypeCombo_SelectedIndexChanged);
            // 
            // TP_speedLow
            // 
            this.TP_speedLow.AutoSize = true;
            this.TP_speedLow.Location = new System.Drawing.Point(23, 28);
            this.TP_speedLow.Margin = new System.Windows.Forms.Padding(4);
            this.TP_speedLow.Name = "TP_speedLow";
            this.TP_speedLow.Size = new System.Drawing.Size(63, 20);
            this.TP_speedLow.TabIndex = 0;
            this.TP_speedLow.TabStop = true;
            this.TP_speedLow.Text = "bassa";
            this.TP_speedLow.UseVisualStyleBackColor = true;
            this.TP_speedLow.CheckedChanged += new System.EventHandler(this.PrinterTypeCombo_SelectedIndexChanged);
            // 
            // TP_speedMedium
            // 
            this.TP_speedMedium.AutoSize = true;
            this.TP_speedMedium.Location = new System.Drawing.Point(23, 56);
            this.TP_speedMedium.Margin = new System.Windows.Forms.Padding(4);
            this.TP_speedMedium.Name = "TP_speedMedium";
            this.TP_speedMedium.Size = new System.Drawing.Size(63, 20);
            this.TP_speedMedium.TabIndex = 1;
            this.TP_speedMedium.TabStop = true;
            this.TP_speedMedium.Text = "media";
            this.TP_speedMedium.UseVisualStyleBackColor = true;
            this.TP_speedMedium.CheckedChanged += new System.EventHandler(this.PrinterTypeCombo_SelectedIndexChanged);
            // 
            // TP_densityGroupBox
            // 
            this.TP_densityGroupBox.Controls.Add(this.TP_densityHigh);
            this.TP_densityGroupBox.Controls.Add(this.TP_densityMedium);
            this.TP_densityGroupBox.Controls.Add(this.TP_densityLow);
            this.TP_densityGroupBox.Location = new System.Drawing.Point(390, 285);
            this.TP_densityGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.TP_densityGroupBox.Name = "TP_densityGroupBox";
            this.TP_densityGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.TP_densityGroupBox.Size = new System.Drawing.Size(146, 117);
            this.TP_densityGroupBox.TabIndex = 14;
            this.TP_densityGroupBox.TabStop = false;
            this.TP_densityGroupBox.Text = "densità di stampa";
            // 
            // TP_densityHigh
            // 
            this.TP_densityHigh.AutoSize = true;
            this.TP_densityHigh.Location = new System.Drawing.Point(29, 83);
            this.TP_densityHigh.Margin = new System.Windows.Forms.Padding(4);
            this.TP_densityHigh.Name = "TP_densityHigh";
            this.TP_densityHigh.Size = new System.Drawing.Size(47, 20);
            this.TP_densityHigh.TabIndex = 2;
            this.TP_densityHigh.TabStop = true;
            this.TP_densityHigh.Text = "alta";
            this.TP_densityHigh.UseVisualStyleBackColor = true;
            this.TP_densityHigh.CheckedChanged += new System.EventHandler(this.PrinterTypeCombo_SelectedIndexChanged);
            // 
            // TP_densityMedium
            // 
            this.TP_densityMedium.AutoSize = true;
            this.TP_densityMedium.Location = new System.Drawing.Point(29, 53);
            this.TP_densityMedium.Margin = new System.Windows.Forms.Padding(4);
            this.TP_densityMedium.Name = "TP_densityMedium";
            this.TP_densityMedium.Size = new System.Drawing.Size(63, 20);
            this.TP_densityMedium.TabIndex = 1;
            this.TP_densityMedium.TabStop = true;
            this.TP_densityMedium.Text = "media";
            this.TP_densityMedium.UseVisualStyleBackColor = true;
            this.TP_densityMedium.CheckedChanged += new System.EventHandler(this.PrinterTypeCombo_SelectedIndexChanged);
            // 
            // TP_densityLow
            // 
            this.TP_densityLow.AutoSize = true;
            this.TP_densityLow.Location = new System.Drawing.Point(29, 23);
            this.TP_densityLow.Margin = new System.Windows.Forms.Padding(4);
            this.TP_densityLow.Name = "TP_densityLow";
            this.TP_densityLow.Size = new System.Drawing.Size(63, 20);
            this.TP_densityLow.TabIndex = 0;
            this.TP_densityLow.TabStop = true;
            this.TP_densityLow.Text = "bassa";
            this.TP_densityLow.UseVisualStyleBackColor = true;
            this.TP_densityLow.CheckedChanged += new System.EventHandler(this.PrinterTypeCombo_SelectedIndexChanged);
            // 
            // TP_btnAutotest
            // 
            this.TP_btnAutotest.Location = new System.Drawing.Point(19, 427);
            this.TP_btnAutotest.Margin = new System.Windows.Forms.Padding(4);
            this.TP_btnAutotest.Name = "TP_btnAutotest";
            this.TP_btnAutotest.Size = new System.Drawing.Size(119, 28);
            this.TP_btnAutotest.TabIndex = 15;
            this.TP_btnAutotest.Text = "stampa Autotest";
            this.TP_btnAutotest.UseVisualStyleBackColor = true;
            this.TP_btnAutotest.Click += new System.EventHandler(this.BtnAutotest_Click);
            // 
            // TP_btnText
            // 
            this.TP_btnText.Location = new System.Drawing.Point(367, 427);
            this.TP_btnText.Margin = new System.Windows.Forms.Padding(4);
            this.TP_btnText.Name = "TP_btnText";
            this.TP_btnText.Size = new System.Drawing.Size(160, 28);
            this.TP_btnText.TabIndex = 17;
            this.TP_btnText.Text = "stampa testo di prova";
            this.TP_btnText.UseVisualStyleBackColor = true;
            this.TP_btnText.Click += new System.EventHandler(this.BtnTestoProva_Click);
            // 
            // TP_btnInfo
            // 
            this.TP_btnInfo.Location = new System.Drawing.Point(199, 427);
            this.TP_btnInfo.Margin = new System.Windows.Forms.Padding(4);
            this.TP_btnInfo.Name = "TP_btnInfo";
            this.TP_btnInfo.Size = new System.Drawing.Size(107, 28);
            this.TP_btnInfo.TabIndex = 16;
            this.TP_btnInfo.Text = "stampa Info";
            this.TP_btnInfo.UseVisualStyleBackColor = true;
            this.TP_btnInfo.Click += new System.EventHandler(this.BtnInfo_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.SystemColors.Control;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Image = global::StandFacile.Properties.Resources.OK;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(327, 485);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 28);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK  ";
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnCancel.Image = global::StandFacile.Properties.Resources.Cancel;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(153, 485);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 28);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Annulla";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // Lbl_ImpSer
            // 
            this.Lbl_ImpSer.AutoSize = true;
            this.Lbl_ImpSer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ImpSer.Location = new System.Drawing.Point(10, 28);
            this.Lbl_ImpSer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_ImpSer.Name = "Lbl_ImpSer";
            this.Lbl_ImpSer.Size = new System.Drawing.Size(75, 16);
            this.Lbl_ImpSer.TabIndex = 0;
            this.Lbl_ImpSer.Text = "19200,N,8,1";
            // 
            // TP_SettingsGroupBox
            // 
            this.TP_SettingsGroupBox.Controls.Add(this.Lbl_ImpSer);
            this.TP_SettingsGroupBox.Location = new System.Drawing.Point(390, 33);
            this.TP_SettingsGroupBox.Name = "TP_SettingsGroupBox";
            this.TP_SettingsGroupBox.Size = new System.Drawing.Size(146, 58);
            this.TP_SettingsGroupBox.TabIndex = 6;
            this.TP_SettingsGroupBox.TabStop = false;
            this.TP_SettingsGroupBox.Text = "impostazioni seriale";
            // 
            // TP_flow_RTS_CTS
            // 
            this.TP_flow_RTS_CTS.AutoSize = true;
            this.TP_flow_RTS_CTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TP_flow_RTS_CTS.Location = new System.Drawing.Point(13, 64);
            this.TP_flow_RTS_CTS.Name = "TP_flow_RTS_CTS";
            this.TP_flow_RTS_CTS.Size = new System.Drawing.Size(123, 17);
            this.TP_flow_RTS_CTS.TabIndex = 1;
            this.TP_flow_RTS_CTS.TabStop = true;
            this.TP_flow_RTS_CTS.Text = "RTS/CTS (standard)";
            this.TP_flow_RTS_CTS.UseVisualStyleBackColor = true;
            // 
            // TP_flow_XON_XOFF
            // 
            this.TP_flow_XON_XOFF.AutoSize = true;
            this.TP_flow_XON_XOFF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TP_flow_XON_XOFF.Location = new System.Drawing.Point(13, 101);
            this.TP_flow_XON_XOFF.Name = "TP_flow_XON_XOFF";
            this.TP_flow_XON_XOFF.Size = new System.Drawing.Size(80, 17);
            this.TP_flow_XON_XOFF.TabIndex = 2;
            this.TP_flow_XON_XOFF.TabStop = true;
            this.TP_flow_XON_XOFF.Text = "XON/XOFF";
            this.TP_flow_XON_XOFF.UseVisualStyleBackColor = true;
            // 
            // TP_flow_NONE
            // 
            this.TP_flow_NONE.AutoSize = true;
            this.TP_flow_NONE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TP_flow_NONE.Location = new System.Drawing.Point(13, 27);
            this.TP_flow_NONE.Name = "TP_flow_NONE";
            this.TP_flow_NONE.Size = new System.Drawing.Size(112, 17);
            this.TP_flow_NONE.TabIndex = 0;
            this.TP_flow_NONE.TabStop = true;
            this.TP_flow_NONE.Text = "NESSUNO (delay)";
            this.TP_flow_NONE.UseVisualStyleBackColor = true;
            // 
            // TP_FlowRadio
            // 
            this.TP_FlowRadio.Controls.Add(this.TP_flow_NONE);
            this.TP_FlowRadio.Controls.Add(this.TP_flow_XON_XOFF);
            this.TP_FlowRadio.Controls.Add(this.TP_flow_RTS_CTS);
            this.TP_FlowRadio.Location = new System.Drawing.Point(390, 114);
            this.TP_FlowRadio.Name = "TP_FlowRadio";
            this.TP_FlowRadio.Size = new System.Drawing.Size(146, 138);
            this.TP_FlowRadio.TabIndex = 10;
            this.TP_FlowRadio.TabStop = false;
            this.TP_FlowRadio.Text = "controllo di flusso";
            // 
            // LegacyPrinterDlg
            // 
            this.AcceptButton = this.btnCancel;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(558, 531);
            this.Controls.Add(this.TP_FlowRadio);
            this.Controls.Add(this.TP_SettingsGroupBox);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.TP_btnInfo);
            this.Controls.Add(this.TP_btnText);
            this.Controls.Add(this.TP_btnAutotest);
            this.Controls.Add(this.TP_speedGroupBox);
            this.Controls.Add(this.TP_densityGroupBox);
            this.Controls.Add(this.TP_PaperSizeGroupBox);
            this.Controls.Add(this.lblFont);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.lblCom);
            this.Controls.Add(this.lblPrt);
            this.Controls.Add(this.FontTypeCombo);
            this.Controls.Add(this.LogoBmpCombo);
            this.Controls.Add(this.PrinterTypeCombo);
            this.Controls.Add(this.PORT_Combo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LegacyPrinterDlg";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Impostazioni stampante Legacy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ThermPrinterDlg_FormClosing);
            this.TP_PaperSizeGroupBox.ResumeLayout(false);
            this.TP_PaperSizeGroupBox.PerformLayout();
            this.TP_speedGroupBox.ResumeLayout(false);
            this.TP_speedGroupBox.PerformLayout();
            this.TP_densityGroupBox.ResumeLayout(false);
            this.TP_densityGroupBox.PerformLayout();
            this.TP_SettingsGroupBox.ResumeLayout(false);
            this.TP_SettingsGroupBox.PerformLayout();
            this.TP_FlowRadio.ResumeLayout(false);
            this.TP_FlowRadio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PORT_Combo;
        private System.Windows.Forms.ComboBox PrinterTypeCombo;
        private System.Windows.Forms.ComboBox LogoBmpCombo;
        private System.Windows.Forms.ComboBox FontTypeCombo;
        private System.Windows.Forms.Label lblPrt;
        private System.Windows.Forms.Label lblCom;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblFont;
        private System.Windows.Forms.GroupBox TP_PaperSizeGroupBox;
        private System.Windows.Forms.RadioButton width80;
        private System.Windows.Forms.RadioButton width57;
        private System.Windows.Forms.GroupBox TP_speedGroupBox;
        private System.Windows.Forms.GroupBox TP_densityGroupBox;
        private System.Windows.Forms.RadioButton TP_densityMedium;
        private System.Windows.Forms.RadioButton TP_densityLow;
        private System.Windows.Forms.RadioButton TP_densityHigh;
        private System.Windows.Forms.RadioButton TP_speedHigh;
        private System.Windows.Forms.RadioButton TP_speedLow;
        private System.Windows.Forms.RadioButton TP_speedMedium;
        private System.Windows.Forms.Button TP_btnAutotest;
        private System.Windows.Forms.Button TP_btnText;
        private System.Windows.Forms.Button TP_btnInfo;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label Lbl_ImpSer;
        private System.Windows.Forms.GroupBox TP_SettingsGroupBox;
        private System.Windows.Forms.RadioButton TP_flow_RTS_CTS;
        private System.Windows.Forms.RadioButton TP_flow_XON_XOFF;
        private System.Windows.Forms.RadioButton TP_flow_NONE;
        private System.Windows.Forms.GroupBox TP_FlowRadio;
    }
}