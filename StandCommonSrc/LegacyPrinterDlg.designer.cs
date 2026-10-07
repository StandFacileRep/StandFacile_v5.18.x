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
            this.lblPrt = new System.Windows.Forms.Label();
            this.lblCom = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.TP_PaperSizeGroupBox = new System.Windows.Forms.GroupBox();
            this.width80 = new System.Windows.Forms.RadioButton();
            this.width57 = new System.Windows.Forms.RadioButton();
            this.TP_btnText = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.Lbl_ImpSer = new System.Windows.Forms.Label();
            this.TP_SettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.TP_flow_RTS_CTS = new System.Windows.Forms.RadioButton();
            this.TP_flow_XON_XOFF = new System.Windows.Forms.RadioButton();
            this.TP_flow_NONE = new System.Windows.Forms.RadioButton();
            this.TP_FlowRadio = new System.Windows.Forms.GroupBox();
            this.TP_PaperSizeGroupBox.SuspendLayout();
            this.TP_SettingsGroupBox.SuspendLayout();
            this.TP_FlowRadio.SuspendLayout();
            this.SuspendLayout();
            // 
            // PORT_Combo
            // 
            this.PORT_Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PORT_Combo.FormattingEnabled = true;
            this.PORT_Combo.Location = new System.Drawing.Point(213, 53);
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
            this.LogoBmpCombo.Location = new System.Drawing.Point(16, 133);
            this.LogoBmpCombo.Margin = new System.Windows.Forms.Padding(4);
            this.LogoBmpCombo.Name = "LogoBmpCombo";
            this.LogoBmpCombo.Size = new System.Drawing.Size(164, 24);
            this.LogoBmpCombo.TabIndex = 8;
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
            this.lblCom.Location = new System.Drawing.Point(210, 33);
            this.lblCom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCom.Name = "lblCom";
            this.lblCom.Size = new System.Drawing.Size(141, 16);
            this.lblCom.TabIndex = 4;
            this.lblCom.Text = "Scelta porta COM/LPT";
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Location = new System.Drawing.Point(12, 114);
            this.lblLogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(101, 16);
            this.lblLogo.TabIndex = 7;
            this.lblLogo.Text = "Scelta del Logo";
            // 
            // TP_PaperSizeGroupBox
            // 
            this.TP_PaperSizeGroupBox.Controls.Add(this.width80);
            this.TP_PaperSizeGroupBox.Controls.Add(this.width57);
            this.TP_PaperSizeGroupBox.Location = new System.Drawing.Point(213, 114);
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
            // TP_btnText
            // 
            this.TP_btnText.Location = new System.Drawing.Point(13, 215);
            this.TP_btnText.Margin = new System.Windows.Forms.Padding(4);
            this.TP_btnText.Name = "TP_btnText";
            this.TP_btnText.Size = new System.Drawing.Size(164, 28);
            this.TP_btnText.TabIndex = 17;
            this.TP_btnText.Text = "stampa testo di prova";
            this.TP_btnText.UseVisualStyleBackColor = true;
            this.TP_btnText.Click += new System.EventHandler(this.BtnTestoProva_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOK.BackColor = System.Drawing.SystemColors.Control;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Image = global::StandFacile.Properties.Resources.OK;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(312, 295);
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
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnCancel.Image = global::StandFacile.Properties.Resources.Cancel;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(153, 295);
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
            this.TP_SettingsGroupBox.Location = new System.Drawing.Point(374, 33);
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
            this.TP_FlowRadio.Location = new System.Drawing.Point(374, 114);
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
            this.ClientSize = new System.Drawing.Size(539, 341);
            this.Controls.Add(this.TP_FlowRadio);
            this.Controls.Add(this.TP_SettingsGroupBox);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.TP_btnText);
            this.Controls.Add(this.TP_PaperSizeGroupBox);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.lblCom);
            this.Controls.Add(this.lblPrt);
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
        private System.Windows.Forms.Label lblPrt;
        private System.Windows.Forms.Label lblCom;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.GroupBox TP_PaperSizeGroupBox;
        private System.Windows.Forms.RadioButton width80;
        private System.Windows.Forms.RadioButton width57;
        private System.Windows.Forms.Button TP_btnText;
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