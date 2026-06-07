namespace StandFacile
{
    partial class VisDatiDlg
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
            this.textEditDati = new System.Windows.Forms.TextBox();
            this.VD_CheckBoxRedColumns = new System.Windows.Forms.CheckBox();
            this.VD_CheckBoxExport = new System.Windows.Forms.CheckBox();
            this.VD_lblCashDesk = new System.Windows.Forms.Label();
            this.Combo_NumCassa = new System.Windows.Forms.ComboBox();
            this.VD_CheckBoxCashUnion = new System.Windows.Forms.CheckBox();
            this.comboReport = new System.Windows.Forms.ComboBox();
            this.VD_LblReport = new System.Windows.Forms.Label();
            this.CkBoxSkipZero = new System.Windows.Forms.CheckBox();
            this.VD_ComboExpFormat = new System.Windows.Forms.ComboBox();
            this.OKBtn = new System.Windows.Forms.Button();
            this.BtnExport = new System.Windows.Forms.Button();
            this.BtnDate = new System.Windows.Forms.Button();
            this.BtnPrt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textEditDati
            // 
            this.textEditDati.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEditDati.BackColor = System.Drawing.Color.Teal;
            this.textEditDati.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditDati.ForeColor = System.Drawing.SystemColors.Window;
            this.textEditDati.Location = new System.Drawing.Point(12, 12);
            this.textEditDati.Multiline = true;
            this.textEditDati.Name = "textEditDati";
            this.textEditDati.ReadOnly = true;
            this.textEditDati.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textEditDati.Size = new System.Drawing.Size(568, 346);
            this.textEditDati.TabIndex = 0;
            // 
            // VD_CheckBoxRedColumns
            // 
            this.VD_CheckBoxRedColumns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.VD_CheckBoxRedColumns.AutoSize = true;
            this.VD_CheckBoxRedColumns.Checked = true;
            this.VD_CheckBoxRedColumns.CheckState = System.Windows.Forms.CheckState.Checked;
            this.VD_CheckBoxRedColumns.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VD_CheckBoxRedColumns.Location = new System.Drawing.Point(12, 412);
            this.VD_CheckBoxRedColumns.Name = "VD_CheckBoxRedColumns";
            this.VD_CheckBoxRedColumns.Size = new System.Drawing.Size(156, 18);
            this.VD_CheckBoxRedColumns.TabIndex = 2;
            this.VD_CheckBoxRedColumns.Text = "Riduzione colonne/righe";
            this.VD_CheckBoxRedColumns.UseVisualStyleBackColor = true;
            this.VD_CheckBoxRedColumns.Click += new System.EventHandler(this.CheckBoxRidColonne_Click);
            // 
            // VD_CheckBoxExport
            // 
            this.VD_CheckBoxExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.VD_CheckBoxExport.AutoSize = true;
            this.VD_CheckBoxExport.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VD_CheckBoxExport.Location = new System.Drawing.Point(12, 381);
            this.VD_CheckBoxExport.Name = "VD_CheckBoxExport";
            this.VD_CheckBoxExport.Size = new System.Drawing.Size(208, 18);
            this.VD_CheckBoxExport.TabIndex = 1;
            this.VD_CheckBoxExport.Text = "Visualizza esportazione Excel/ODS";
            this.VD_CheckBoxExport.UseVisualStyleBackColor = true;
            // 
            // VD_lblCashDesk
            // 
            this.VD_lblCashDesk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.VD_lblCashDesk.AutoSize = true;
            this.VD_lblCashDesk.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VD_lblCashDesk.Location = new System.Drawing.Point(229, 481);
            this.VD_lblCashDesk.Name = "VD_lblCashDesk";
            this.VD_lblCashDesk.Size = new System.Drawing.Size(110, 14);
            this.VD_lblCashDesk.TabIndex = 7;
            this.VD_lblCashDesk.Text = "numero della Cassa";
            // 
            // Combo_NumCassa
            // 
            this.Combo_NumCassa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Combo_NumCassa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_NumCassa.Enabled = false;
            this.Combo_NumCassa.FormattingEnabled = true;
            this.Combo_NumCassa.Location = new System.Drawing.Point(200, 498);
            this.Combo_NumCassa.Name = "Combo_NumCassa";
            this.Combo_NumCassa.Size = new System.Drawing.Size(164, 21);
            this.Combo_NumCassa.TabIndex = 8;
            this.Combo_NumCassa.SelectedIndexChanged += new System.EventHandler(this.Combo_NumCassa_SelectedIndexChanged);
            // 
            // VD_CheckBoxCashUnion
            // 
            this.VD_CheckBoxCashUnion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.VD_CheckBoxCashUnion.AutoSize = true;
            this.VD_CheckBoxCashUnion.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VD_CheckBoxCashUnion.Location = new System.Drawing.Point(12, 443);
            this.VD_CheckBoxCashUnion.Name = "VD_CheckBoxCashUnion";
            this.VD_CheckBoxCashUnion.Size = new System.Drawing.Size(121, 18);
            this.VD_CheckBoxCashUnion.TabIndex = 3;
            this.VD_CheckBoxCashUnion.Text = "Unione dati casse";
            this.VD_CheckBoxCashUnion.UseVisualStyleBackColor = true;
            this.VD_CheckBoxCashUnion.Click += new System.EventHandler(this.CheckBoxRidColonne_Click);
            // 
            // comboReport
            // 
            this.comboReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboReport.FormattingEnabled = true;
            this.comboReport.Location = new System.Drawing.Point(21, 498);
            this.comboReport.Name = "comboReport";
            this.comboReport.Size = new System.Drawing.Size(164, 21);
            this.comboReport.TabIndex = 6;
            this.comboReport.SelectedIndexChanged += new System.EventHandler(this.ComboReport_SelectedIndexChanged);
            // 
            // VD_LblReport
            // 
            this.VD_LblReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.VD_LblReport.AutoSize = true;
            this.VD_LblReport.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VD_LblReport.Location = new System.Drawing.Point(52, 481);
            this.VD_LblReport.Name = "VD_LblReport";
            this.VD_LblReport.Size = new System.Drawing.Size(90, 14);
            this.VD_LblReport.TabIndex = 5;
            this.VD_LblReport.Text = "modalità report";
            // 
            // CkBoxSkipZero
            // 
            this.CkBoxSkipZero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CkBoxSkipZero.AutoSize = true;
            this.CkBoxSkipZero.Checked = true;
            this.CkBoxSkipZero.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CkBoxSkipZero.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CkBoxSkipZero.Location = new System.Drawing.Point(208, 444);
            this.CkBoxSkipZero.Name = "CkBoxSkipZero";
            this.CkBoxSkipZero.Size = new System.Drawing.Size(144, 18);
            this.CkBoxSkipZero.TabIndex = 4;
            this.CkBoxSkipZero.Text = "tralascia quantità zero";
            this.CkBoxSkipZero.UseVisualStyleBackColor = true;
            this.CkBoxSkipZero.Click += new System.EventHandler(this.CheckBoxRidColonne_Click);
            // 
            // VD_ComboExpFormat
            // 
            this.VD_ComboExpFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.VD_ComboExpFormat.FormattingEnabled = true;
            this.VD_ComboExpFormat.Items.AddRange(new object[] {
            "XLS MS Office",
            "XLS Free Export",
            "ODS Free Export"});
            this.VD_ComboExpFormat.Location = new System.Drawing.Point(259, 380);
            this.VD_ComboExpFormat.Name = "VD_ComboExpFormat";
            this.VD_ComboExpFormat.Size = new System.Drawing.Size(105, 21);
            this.VD_ComboExpFormat.TabIndex = 9;
            this.VD_ComboExpFormat.Text = "XLS MS Office";
            // 
            // OKBtn
            // 
            this.OKBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OKBtn.BackColor = System.Drawing.SystemColors.Control;
            this.OKBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKBtn.Image = global::StandFacile.Properties.Resources.OK;
            this.OKBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OKBtn.Location = new System.Drawing.Point(489, 490);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(70, 35);
            this.OKBtn.TabIndex = 13;
            this.OKBtn.Text = "OK";
            this.OKBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OKBtn.UseVisualStyleBackColor = true;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            this.OKBtn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OKBtn_KeyPress);
            // 
            // BtnExport
            // 
            this.BtnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnExport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnExport.Image = global::StandFacile.Properties.Resources.Xls;
            this.BtnExport.Location = new System.Drawing.Point(393, 373);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(70, 35);
            this.BtnExport.TabIndex = 10;
            this.BtnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnExport.UseVisualStyleBackColor = true;
            this.BtnExport.Click += new System.EventHandler(this.BtnXls_Click);
            // 
            // BtnDate
            // 
            this.BtnDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDate.Image = global::StandFacile.Properties.Resources.Calendar;
            this.BtnDate.Location = new System.Drawing.Point(489, 373);
            this.BtnDate.Name = "BtnDate";
            this.BtnDate.Size = new System.Drawing.Size(70, 35);
            this.BtnDate.TabIndex = 11;
            this.BtnDate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnDate.UseVisualStyleBackColor = true;
            this.BtnDate.Click += new System.EventHandler(this.BtnDate_Click);
            // 
            // BtnPrt
            // 
            this.BtnPrt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnPrt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnPrt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnPrt.Image = global::StandFacile.Properties.Resources.printer_s;
            this.BtnPrt.Location = new System.Drawing.Point(393, 490);
            this.BtnPrt.Name = "BtnPrt";
            this.BtnPrt.Size = new System.Drawing.Size(70, 35);
            this.BtnPrt.TabIndex = 12;
            this.BtnPrt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnPrt.UseVisualStyleBackColor = true;
            this.BtnPrt.Click += new System.EventHandler(this.BtnPrt_Click);
            // 
            // VisDatiDlg
            // 
            this.AcceptButton = this.OKBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.OKBtn;
            this.ClientSize = new System.Drawing.Size(592, 538);
            this.Controls.Add(this.VD_ComboExpFormat);
            this.Controls.Add(this.CkBoxSkipZero);
            this.Controls.Add(this.VD_LblReport);
            this.Controls.Add(this.comboReport);
            this.Controls.Add(this.BtnExport);
            this.Controls.Add(this.BtnDate);
            this.Controls.Add(this.VD_CheckBoxCashUnion);
            this.Controls.Add(this.Combo_NumCassa);
            this.Controls.Add(this.VD_lblCashDesk);
            this.Controls.Add(this.VD_CheckBoxExport);
            this.Controls.Add(this.VD_CheckBoxRedColumns);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.BtnPrt);
            this.Controls.Add(this.textEditDati);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VisDatiDlg";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Incasso";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VisDatiDlg_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

#endregion

        private System.Windows.Forms.TextBox textEditDati;
        private System.Windows.Forms.Button BtnPrt;
        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.CheckBox VD_CheckBoxRedColumns;
        private System.Windows.Forms.CheckBox VD_CheckBoxExport;
        private System.Windows.Forms.Label VD_lblCashDesk;
        private System.Windows.Forms.ComboBox Combo_NumCassa;
        private System.Windows.Forms.CheckBox VD_CheckBoxCashUnion;
        private System.Windows.Forms.Button BtnDate;
        private System.Windows.Forms.Button BtnExport;
        private System.Windows.Forms.ComboBox comboReport;
        private System.Windows.Forms.Label VD_LblReport;
        private System.Windows.Forms.CheckBox CkBoxSkipZero;
        private System.Windows.Forms.ComboBox VD_ComboExpFormat;
    }
}