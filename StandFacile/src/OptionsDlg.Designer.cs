namespace StandFacile
{
    partial class OptionsDlg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsDlg));
            this.MO_checkBoxPlaceSett = new System.Windows.Forms.CheckBox();
            this.MO_checkBoxTable = new System.Windows.Forms.CheckBox();
            this.MO_checkBox_InitialAvailabilityDlg = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelPresale = new System.Windows.Forms.Panel();
            this.MO_checkBoxPresales_loadMode = new System.Windows.Forms.CheckBox();
            this.MO_checkBoxPresale_workMode = new System.Windows.Forms.CheckBox();
            this.MO_checkBoxPayment = new System.Windows.Forms.CheckBox();
            this.MO_checkBoxPrivacy = new System.Windows.Forms.CheckBox();
            this.comboColorTheme = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MO_checkBox_Enter = new System.Windows.Forms.CheckBox();
            this.MO_checkBoxShowPrevReceipt = new System.Windows.Forms.CheckBox();
            this.MO_checkBox_ZeroPriceItems = new System.Windows.Forms.CheckBox();
            this.panelShowHideButtons = new System.Windows.Forms.Panel();
            this.MO_checkBox_Show_CAP = new System.Windows.Forms.CheckBox();
            this.MO_checkBox_ShowDiscount = new System.Windows.Forms.CheckBox();
            this.MO_checkBox_ShowSendMsg = new System.Windows.Forms.CheckBox();
            this.MO_checkBox_ShowTakeAway = new System.Windows.Forms.CheckBox();
            this.MO_checkBox_Show_DB_Check = new System.Windows.Forms.CheckBox();
            this.MO_checkBox_Show_OSKeyb = new System.Windows.Forms.CheckBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.MO_checkBox_CAP = new System.Windows.Forms.CheckBox();
            this.MO_checkBox_Name = new System.Windows.Forms.CheckBox();
            this.MO_ckBoxExternalPreview = new System.Windows.Forms.CheckBox();
            this.panelPresale.SuspendLayout();
            this.panelShowHideButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // MO_checkBoxPlaceSett
            // 
            this.MO_checkBoxPlaceSett.AutoSize = true;
            this.MO_checkBoxPlaceSett.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MO_checkBoxPlaceSett.Location = new System.Drawing.Point(15, 68);
            this.MO_checkBoxPlaceSett.Name = "MO_checkBoxPlaceSett";
            this.MO_checkBoxPlaceSett.Size = new System.Drawing.Size(296, 18);
            this.MO_checkBoxPlaceSett.TabIndex = 3;
            this.MO_checkBoxPlaceSett.Text = "rendi obbligatorio l\'inserimento del num di Coperti";
            this.MO_checkBoxPlaceSett.UseVisualStyleBackColor = true;
            // 
            // MO_checkBoxTable
            // 
            this.MO_checkBoxTable.AutoSize = true;
            this.MO_checkBoxTable.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MO_checkBoxTable.Location = new System.Drawing.Point(15, 105);
            this.MO_checkBoxTable.Name = "MO_checkBoxTable";
            this.MO_checkBoxTable.Size = new System.Drawing.Size(252, 18);
            this.MO_checkBoxTable.TabIndex = 2;
            this.MO_checkBoxTable.Text = "rendi obbligatorio l\'inserimento del Tavolo";
            this.MO_checkBoxTable.UseVisualStyleBackColor = true;
            // 
            // MO_checkBox_InitialAvailabilityDlg
            // 
            this.MO_checkBox_InitialAvailabilityDlg.AutoSize = true;
            this.MO_checkBox_InitialAvailabilityDlg.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MO_checkBox_InitialAvailabilityDlg.Location = new System.Drawing.Point(15, 378);
            this.MO_checkBox_InitialAvailabilityDlg.Name = "MO_checkBox_InitialAvailabilityDlg";
            this.MO_checkBox_InitialAvailabilityDlg.Size = new System.Drawing.Size(328, 18);
            this.MO_checkBox_InitialAvailabilityDlg.TabIndex = 7;
            this.MO_checkBox_InitialAvailabilityDlg.Text = "mostra all\'avvio il dialogo di selezione disponibilità Articoli";
            this.MO_checkBox_InitialAvailabilityDlg.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(458, 470);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 32);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "OK   ";
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(308, 470);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 32);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Annulla";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // panelPresale
            // 
            this.panelPresale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPresale.Controls.Add(this.MO_checkBoxPresales_loadMode);
            this.panelPresale.Controls.Add(this.MO_checkBoxPresale_workMode);
            this.panelPresale.Location = new System.Drawing.Point(358, 338);
            this.panelPresale.Name = "panelPresale";
            this.panelPresale.Size = new System.Drawing.Size(312, 90);
            this.panelPresale.TabIndex = 8;
            // 
            // MO_checkBoxPresales_loadMode
            // 
            this.MO_checkBoxPresales_loadMode.AutoSize = true;
            this.MO_checkBoxPresales_loadMode.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MO_checkBoxPresales_loadMode.Location = new System.Drawing.Point(11, 53);
            this.MO_checkBoxPresales_loadMode.Name = "MO_checkBoxPresales_loadMode";
            this.MO_checkBoxPresales_loadMode.Size = new System.Drawing.Size(249, 18);
            this.MO_checkBoxPresales_loadMode.TabIndex = 10;
            this.MO_checkBoxPresales_loadMode.Text = "modalità caricamento ordini in prevendita";
            this.MO_checkBoxPresales_loadMode.UseVisualStyleBackColor = true;
            this.MO_checkBoxPresales_loadMode.CheckedChanged += new System.EventHandler(this.CheckBoxLoadPresale_CheckedChanged);
            // 
            // MO_checkBoxPresale_workMode
            // 
            this.MO_checkBoxPresale_workMode.AutoSize = true;
            this.MO_checkBoxPresale_workMode.Enabled = false;
            this.MO_checkBoxPresale_workMode.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MO_checkBoxPresale_workMode.Location = new System.Drawing.Point(11, 19);
            this.MO_checkBoxPresale_workMode.Name = "MO_checkBoxPresale_workMode";
            this.MO_checkBoxPresale_workMode.Size = new System.Drawing.Size(291, 18);
            this.MO_checkBoxPresale_workMode.TabIndex = 9;
            this.MO_checkBoxPresale_workMode.Text = "modalità giorno di prevendita (riavvio necessario)";
            this.MO_checkBoxPresale_workMode.UseVisualStyleBackColor = true;
            this.MO_checkBoxPresale_workMode.CheckedChanged += new System.EventHandler(this.CheckBoxPresaleMode_CheckedChanged);
            // 
            // MO_checkBoxPayment
            // 
            this.MO_checkBoxPayment.AutoSize = true;
            this.MO_checkBoxPayment.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MO_checkBoxPayment.Location = new System.Drawing.Point(15, 179);
            this.MO_checkBoxPayment.Name = "MO_checkBoxPayment";
            this.MO_checkBoxPayment.Size = new System.Drawing.Size(326, 18);
            this.MO_checkBoxPayment.TabIndex = 4;
            this.MO_checkBoxPayment.Text = "rendi obbligatorio l\'inserimento del modo di pagamento";
            this.MO_checkBoxPayment.UseVisualStyleBackColor = true;
            // 
            // MO_checkBoxPrivacy
            // 
            this.MO_checkBoxPrivacy.AutoSize = true;
            this.MO_checkBoxPrivacy.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MO_checkBoxPrivacy.Location = new System.Drawing.Point(15, 341);
            this.MO_checkBoxPrivacy.Name = "MO_checkBoxPrivacy";
            this.MO_checkBoxPrivacy.Size = new System.Drawing.Size(205, 18);
            this.MO_checkBoxPrivacy.TabIndex = 5;
            this.MO_checkBoxPrivacy.Text = "modo riservato (nascondi incassi)";
            this.MO_checkBoxPrivacy.UseVisualStyleBackColor = true;
            // 
            // comboColorTheme
            // 
            this.comboColorTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboColorTheme.FormattingEnabled = true;
            this.comboColorTheme.Items.AddRange(new object[] {
            "Classico con diversi colori carattere",
            "Chiaro con diversi colori sfondo",
            "Vivace con diversi colori sfondo"});
            this.comboColorTheme.Location = new System.Drawing.Point(15, 20);
            this.comboColorTheme.Name = "comboColorTheme";
            this.comboColorTheme.Size = new System.Drawing.Size(205, 21);
            this.comboColorTheme.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "selezione tema colori";
            // 
            // MO_checkBox_Enter
            // 
            this.MO_checkBox_Enter.AutoSize = true;
            this.MO_checkBox_Enter.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MO_checkBox_Enter.Location = new System.Drawing.Point(15, 304);
            this.MO_checkBox_Enter.Name = "MO_checkBox_Enter";
            this.MO_checkBox_Enter.Size = new System.Drawing.Size(234, 18);
            this.MO_checkBox_Enter.TabIndex = 6;
            this.MO_checkBox_Enter.Text = "consenti stampa scontrino con ENTER";
            this.MO_checkBox_Enter.UseVisualStyleBackColor = true;
            // 
            // MO_checkBoxShowPrevReceipt
            // 
            this.MO_checkBoxShowPrevReceipt.AutoSize = true;
            this.MO_checkBoxShowPrevReceipt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MO_checkBoxShowPrevReceipt.Location = new System.Drawing.Point(15, 415);
            this.MO_checkBoxShowPrevReceipt.Name = "MO_checkBoxShowPrevReceipt";
            this.MO_checkBoxShowPrevReceipt.Size = new System.Drawing.Size(319, 18);
            this.MO_checkBoxShowPrevReceipt.TabIndex = 25;
            this.MO_checkBoxShowPrevReceipt.Text = "mostra nello stato il totale dello scontrino precedente";
            this.MO_checkBoxShowPrevReceipt.UseVisualStyleBackColor = true;
            // 
            // MO_checkBox_ZeroPriceItems
            // 
            this.MO_checkBox_ZeroPriceItems.AutoSize = true;
            this.MO_checkBox_ZeroPriceItems.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MO_checkBox_ZeroPriceItems.Location = new System.Drawing.Point(15, 267);
            this.MO_checkBox_ZeroPriceItems.Name = "MO_checkBox_ZeroPriceItems";
            this.MO_checkBox_ZeroPriceItems.Size = new System.Drawing.Size(202, 18);
            this.MO_checkBox_ZeroPriceItems.TabIndex = 26;
            this.MO_checkBox_ZeroPriceItems.Text = "consenti Articoli con prezzo zero";
            this.MO_checkBox_ZeroPriceItems.UseVisualStyleBackColor = true;
            // 
            // panelShowHideButtons
            // 
            this.panelShowHideButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelShowHideButtons.Controls.Add(this.MO_checkBox_Show_CAP);
            this.panelShowHideButtons.Controls.Add(this.MO_checkBox_ShowDiscount);
            this.panelShowHideButtons.Controls.Add(this.MO_checkBox_ShowSendMsg);
            this.panelShowHideButtons.Controls.Add(this.MO_checkBox_ShowTakeAway);
            this.panelShowHideButtons.Controls.Add(this.MO_checkBox_Show_DB_Check);
            this.panelShowHideButtons.Controls.Add(this.MO_checkBox_Show_OSKeyb);
            this.panelShowHideButtons.Location = new System.Drawing.Point(358, 69);
            this.panelShowHideButtons.Name = "panelShowHideButtons";
            this.panelShowHideButtons.Size = new System.Drawing.Size(312, 245);
            this.panelShowHideButtons.TabIndex = 31;
            // 
            // MO_checkBox_Show_CAP
            // 
            this.MO_checkBox_Show_CAP.AutoSize = true;
            this.MO_checkBox_Show_CAP.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MO_checkBox_Show_CAP.Location = new System.Drawing.Point(11, 206);
            this.MO_checkBox_Show_CAP.Name = "MO_checkBox_Show_CAP";
            this.MO_checkBox_Show_CAP.Size = new System.Drawing.Size(156, 18);
            this.MO_checkBox_Show_CAP.TabIndex = 34;
            this.MO_checkBox_Show_CAP.Text = "mostra inserimento CAP";
            this.MO_checkBox_Show_CAP.UseVisualStyleBackColor = true;
            // 
            // MO_checkBox_ShowDiscount
            // 
            this.MO_checkBox_ShowDiscount.AutoSize = true;
            this.MO_checkBox_ShowDiscount.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MO_checkBox_ShowDiscount.Location = new System.Drawing.Point(11, 92);
            this.MO_checkBox_ShowDiscount.Name = "MO_checkBox_ShowDiscount";
            this.MO_checkBox_ShowDiscount.Size = new System.Drawing.Size(154, 18);
            this.MO_checkBox_ShowDiscount.TabIndex = 33;
            this.MO_checkBox_ShowDiscount.Text = "mostra pulsante sconto";
            this.MO_checkBox_ShowDiscount.UseVisualStyleBackColor = true;
            // 
            // MO_checkBox_ShowSendMsg
            // 
            this.MO_checkBox_ShowSendMsg.AutoSize = true;
            this.MO_checkBox_ShowSendMsg.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MO_checkBox_ShowSendMsg.Location = new System.Drawing.Point(11, 16);
            this.MO_checkBox_ShowSendMsg.Name = "MO_checkBox_ShowSendMsg";
            this.MO_checkBox_ShowSendMsg.Size = new System.Drawing.Size(249, 18);
            this.MO_checkBox_ShowSendMsg.TabIndex = 32;
            this.MO_checkBox_ShowSendMsg.Text = "mostra pulsante invio messaggio a cucina";
            this.MO_checkBox_ShowSendMsg.UseVisualStyleBackColor = true;
            // 
            // MO_checkBox_ShowTakeAway
            // 
            this.MO_checkBox_ShowTakeAway.AutoSize = true;
            this.MO_checkBox_ShowTakeAway.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MO_checkBox_ShowTakeAway.Location = new System.Drawing.Point(11, 54);
            this.MO_checkBox_ShowTakeAway.Name = "MO_checkBox_ShowTakeAway";
            this.MO_checkBox_ShowTakeAway.Size = new System.Drawing.Size(160, 18);
            this.MO_checkBox_ShowTakeAway.TabIndex = 31;
            this.MO_checkBox_ShowTakeAway.Text = "mostra pulsante Asporto";
            this.MO_checkBox_ShowTakeAway.UseVisualStyleBackColor = true;
            // 
            // MO_checkBox_Show_DB_Check
            // 
            this.MO_checkBox_Show_DB_Check.AutoSize = true;
            this.MO_checkBox_Show_DB_Check.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MO_checkBox_Show_DB_Check.Location = new System.Drawing.Point(11, 130);
            this.MO_checkBox_Show_DB_Check.Name = "MO_checkBox_Show_DB_Check";
            this.MO_checkBox_Show_DB_Check.Size = new System.Drawing.Size(168, 18);
            this.MO_checkBox_Show_DB_Check.TabIndex = 30;
            this.MO_checkBox_Show_DB_Check.Text = "mostra pulsante DB check";
            this.MO_checkBox_Show_DB_Check.UseVisualStyleBackColor = true;
            // 
            // MO_checkBox_Show_OSKeyb
            // 
            this.MO_checkBox_Show_OSKeyb.AutoSize = true;
            this.MO_checkBox_Show_OSKeyb.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MO_checkBox_Show_OSKeyb.Location = new System.Drawing.Point(11, 168);
            this.MO_checkBox_Show_OSKeyb.Name = "MO_checkBox_Show_OSKeyb";
            this.MO_checkBox_Show_OSKeyb.Size = new System.Drawing.Size(218, 18);
            this.MO_checkBox_Show_OSKeyb.TabIndex = 29;
            this.MO_checkBox_Show_OSKeyb.Text = "mostra pulsante Tastiera OnScreen";
            this.MO_checkBox_Show_OSKeyb.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReset.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(89, 472);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(115, 28);
            this.btnReset.TabIndex = 32;
            this.btnReset.Text = "ripristina default";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // MO_checkBox_CAP
            // 
            this.MO_checkBox_CAP.AutoSize = true;
            this.MO_checkBox_CAP.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MO_checkBox_CAP.Location = new System.Drawing.Point(15, 216);
            this.MO_checkBox_CAP.Name = "MO_checkBox_CAP";
            this.MO_checkBox_CAP.Size = new System.Drawing.Size(238, 18);
            this.MO_checkBox_CAP.TabIndex = 33;
            this.MO_checkBox_CAP.Text = "rendi obbligatorio l\'inserimento del CAP";
            this.MO_checkBox_CAP.UseVisualStyleBackColor = true;
            // 
            // MO_checkBox_Name
            // 
            this.MO_checkBox_Name.AutoSize = true;
            this.MO_checkBox_Name.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MO_checkBox_Name.Location = new System.Drawing.Point(15, 142);
            this.MO_checkBox_Name.Name = "MO_checkBox_Name";
            this.MO_checkBox_Name.Size = new System.Drawing.Size(289, 18);
            this.MO_checkBox_Name.TabIndex = 35;
            this.MO_checkBox_Name.Text = "rendi obbligatorio l\'inserimento del nome utente";
            this.MO_checkBox_Name.UseVisualStyleBackColor = true;
            // 
            // MO_ckBoxExternalPreview
            // 
            this.MO_ckBoxExternalPreview.AutoSize = true;
            this.MO_ckBoxExternalPreview.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MO_ckBoxExternalPreview.ForeColor = System.Drawing.Color.Blue;
            this.MO_ckBoxExternalPreview.Location = new System.Drawing.Point(420, 24);
            this.MO_ckBoxExternalPreview.Name = "MO_ckBoxExternalPreview";
            this.MO_ckBoxExternalPreview.Size = new System.Drawing.Size(176, 20);
            this.MO_ckBoxExternalPreview.TabIndex = 36;
            this.MO_ckBoxExternalPreview.Text = "mostra Anteprima esterna";
            this.MO_ckBoxExternalPreview.UseVisualStyleBackColor = true;
            // 
            // OptionsDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 516);
            this.Controls.Add(this.MO_ckBoxExternalPreview);
            this.Controls.Add(this.MO_checkBox_Name);
            this.Controls.Add(this.MO_checkBox_CAP);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.panelShowHideButtons);
            this.Controls.Add(this.MO_checkBox_ZeroPriceItems);
            this.Controls.Add(this.MO_checkBoxShowPrevReceipt);
            this.Controls.Add(this.MO_checkBox_Enter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboColorTheme);
            this.Controls.Add(this.MO_checkBoxPrivacy);
            this.Controls.Add(this.MO_checkBoxPayment);
            this.Controls.Add(this.panelPresale);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.MO_checkBox_InitialAvailabilityDlg);
            this.Controls.Add(this.MO_checkBoxPlaceSett);
            this.Controls.Add(this.MO_checkBoxTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsDlg";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Opzioni varie";
            this.panelPresale.ResumeLayout(false);
            this.panelPresale.PerformLayout();
            this.panelShowHideButtons.ResumeLayout(false);
            this.panelShowHideButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox MO_checkBoxPlaceSett;
        private System.Windows.Forms.CheckBox MO_checkBoxTable;
        private System.Windows.Forms.CheckBox MO_checkBox_InitialAvailabilityDlg;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panelPresale;
        private System.Windows.Forms.CheckBox MO_checkBoxPresales_loadMode;
        private System.Windows.Forms.CheckBox MO_checkBoxPresale_workMode;
        private System.Windows.Forms.CheckBox MO_checkBoxPayment;
        private System.Windows.Forms.CheckBox MO_checkBoxPrivacy;
        private System.Windows.Forms.ComboBox comboColorTheme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox MO_checkBox_Enter;
        private System.Windows.Forms.CheckBox MO_checkBoxShowPrevReceipt;
        private System.Windows.Forms.CheckBox MO_checkBox_ZeroPriceItems;
        private System.Windows.Forms.Panel panelShowHideButtons;
        private System.Windows.Forms.CheckBox MO_checkBox_ShowDiscount;
        private System.Windows.Forms.CheckBox MO_checkBox_ShowSendMsg;
        private System.Windows.Forms.CheckBox MO_checkBox_ShowTakeAway;
        private System.Windows.Forms.CheckBox MO_checkBox_Show_DB_Check;
        private System.Windows.Forms.CheckBox MO_checkBox_Show_OSKeyb;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.CheckBox MO_checkBox_Show_CAP;
        private System.Windows.Forms.CheckBox MO_checkBox_CAP;
        private System.Windows.Forms.CheckBox MO_checkBox_Name;
        private System.Windows.Forms.CheckBox MO_ckBoxExternalPreview;
    }
}