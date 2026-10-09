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
            this.MO_checkBoxPayment = new System.Windows.Forms.CheckBox();
            this.MO_checkBoxPrivacy = new System.Windows.Forms.CheckBox();
            this.comboColorTheme = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MO_checkBox_Enter = new System.Windows.Forms.CheckBox();
            this.MO_checkBoxShowPrevReceipt = new System.Windows.Forms.CheckBox();
            this.MO_checkBox_ZeroPriceItems = new System.Windows.Forms.CheckBox();
            this.panelShowHideButtons = new System.Windows.Forms.Panel();
            this.MO_checkBox_ShowDiscount = new System.Windows.Forms.CheckBox();
            this.MO_checkBox_ShowSendMsg = new System.Windows.Forms.CheckBox();
            this.MO_checkBox_ShowTakeAway = new System.Windows.Forms.CheckBox();
            this.MO_checkBox_Show_DB_Check = new System.Windows.Forms.CheckBox();
            this.MO_checkBox_Show_OSKeyb = new System.Windows.Forms.CheckBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.MO_checkBox_CAP = new System.Windows.Forms.CheckBox();
            this.MO_checkBox_Name = new System.Windows.Forms.CheckBox();
            this.MO_ckBoxExternalPreview = new System.Windows.Forms.CheckBox();
            this.MO_checkBox_PAGER = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MO_radioButton_Show_CAP = new System.Windows.Forms.RadioButton();
            this.MO_radioButton_Show_PAGER = new System.Windows.Forms.RadioButton();
            this.panelShowHideButtons.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MO_checkBoxPlaceSett
            // 
            this.MO_checkBoxPlaceSett.AutoSize = true;
            this.MO_checkBoxPlaceSett.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MO_checkBoxPlaceSett.Location = new System.Drawing.Point(15, 68);
            this.MO_checkBoxPlaceSett.Name = "MO_checkBoxPlaceSett";
            this.MO_checkBoxPlaceSett.Size = new System.Drawing.Size(296, 18);
            this.MO_checkBoxPlaceSett.TabIndex = 6;
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
            this.MO_checkBoxTable.TabIndex = 7;
            this.MO_checkBoxTable.Text = "rendi obbligatorio l\'inserimento del Tavolo";
            this.MO_checkBoxTable.UseVisualStyleBackColor = true;
            // 
            // MO_checkBox_InitialAvailabilityDlg
            // 
            this.MO_checkBox_InitialAvailabilityDlg.AutoSize = true;
            this.MO_checkBox_InitialAvailabilityDlg.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MO_checkBox_InitialAvailabilityDlg.Location = new System.Drawing.Point(15, 423);
            this.MO_checkBox_InitialAvailabilityDlg.Name = "MO_checkBox_InitialAvailabilityDlg";
            this.MO_checkBox_InitialAvailabilityDlg.Size = new System.Drawing.Size(328, 18);
            this.MO_checkBox_InitialAvailabilityDlg.TabIndex = 14;
            this.MO_checkBox_InitialAvailabilityDlg.Text = "mostra all\'avvio il dialogo di selezione disponibilità Articoli";
            this.MO_checkBox_InitialAvailabilityDlg.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(458, 508);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 32);
            this.btnOK.TabIndex = 5;
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
            this.btnCancel.Location = new System.Drawing.Point(308, 508);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 32);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Annulla";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // MO_checkBoxPayment
            // 
            this.MO_checkBoxPayment.AutoSize = true;
            this.MO_checkBoxPayment.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MO_checkBoxPayment.Location = new System.Drawing.Point(15, 179);
            this.MO_checkBoxPayment.Name = "MO_checkBoxPayment";
            this.MO_checkBoxPayment.Size = new System.Drawing.Size(326, 18);
            this.MO_checkBoxPayment.TabIndex = 9;
            this.MO_checkBoxPayment.Text = "rendi obbligatorio l\'inserimento del modo di pagamento";
            this.MO_checkBoxPayment.UseVisualStyleBackColor = true;
            // 
            // MO_checkBoxPrivacy
            // 
            this.MO_checkBoxPrivacy.AutoSize = true;
            this.MO_checkBoxPrivacy.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MO_checkBoxPrivacy.Location = new System.Drawing.Point(15, 386);
            this.MO_checkBoxPrivacy.Name = "MO_checkBoxPrivacy";
            this.MO_checkBoxPrivacy.Size = new System.Drawing.Size(205, 18);
            this.MO_checkBoxPrivacy.TabIndex = 13;
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
            this.comboColorTheme.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "selezione tema colori";
            // 
            // MO_checkBox_Enter
            // 
            this.MO_checkBox_Enter.AutoSize = true;
            this.MO_checkBox_Enter.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MO_checkBox_Enter.Location = new System.Drawing.Point(15, 349);
            this.MO_checkBox_Enter.Name = "MO_checkBox_Enter";
            this.MO_checkBox_Enter.Size = new System.Drawing.Size(234, 18);
            this.MO_checkBox_Enter.TabIndex = 12;
            this.MO_checkBox_Enter.Text = "consenti stampa scontrino con ENTER";
            this.MO_checkBox_Enter.UseVisualStyleBackColor = true;
            // 
            // MO_checkBoxShowPrevReceipt
            // 
            this.MO_checkBoxShowPrevReceipt.AutoSize = true;
            this.MO_checkBoxShowPrevReceipt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MO_checkBoxShowPrevReceipt.Location = new System.Drawing.Point(15, 460);
            this.MO_checkBoxShowPrevReceipt.Name = "MO_checkBoxShowPrevReceipt";
            this.MO_checkBoxShowPrevReceipt.Size = new System.Drawing.Size(319, 18);
            this.MO_checkBoxShowPrevReceipt.TabIndex = 15;
            this.MO_checkBoxShowPrevReceipt.Text = "mostra nello stato il totale dello scontrino precedente";
            this.MO_checkBoxShowPrevReceipt.UseVisualStyleBackColor = true;
            // 
            // MO_checkBox_ZeroPriceItems
            // 
            this.MO_checkBox_ZeroPriceItems.AutoSize = true;
            this.MO_checkBox_ZeroPriceItems.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MO_checkBox_ZeroPriceItems.Location = new System.Drawing.Point(15, 312);
            this.MO_checkBox_ZeroPriceItems.Name = "MO_checkBox_ZeroPriceItems";
            this.MO_checkBox_ZeroPriceItems.Size = new System.Drawing.Size(202, 18);
            this.MO_checkBox_ZeroPriceItems.TabIndex = 11;
            this.MO_checkBox_ZeroPriceItems.Text = "consenti Articoli con prezzo zero";
            this.MO_checkBox_ZeroPriceItems.UseVisualStyleBackColor = true;
            // 
            // panelShowHideButtons
            // 
            this.panelShowHideButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelShowHideButtons.Controls.Add(this.MO_checkBox_ShowDiscount);
            this.panelShowHideButtons.Controls.Add(this.MO_checkBox_ShowSendMsg);
            this.panelShowHideButtons.Controls.Add(this.MO_checkBox_ShowTakeAway);
            this.panelShowHideButtons.Controls.Add(this.MO_checkBox_Show_DB_Check);
            this.panelShowHideButtons.Controls.Add(this.MO_checkBox_Show_OSKeyb);
            this.panelShowHideButtons.Location = new System.Drawing.Point(386, 106);
            this.panelShowHideButtons.Name = "panelShowHideButtons";
            this.panelShowHideButtons.Size = new System.Drawing.Size(284, 242);
            this.panelShowHideButtons.TabIndex = 16;
            // 
            // MO_checkBox_ShowDiscount
            // 
            this.MO_checkBox_ShowDiscount.AutoSize = true;
            this.MO_checkBox_ShowDiscount.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MO_checkBox_ShowDiscount.Location = new System.Drawing.Point(11, 110);
            this.MO_checkBox_ShowDiscount.Name = "MO_checkBox_ShowDiscount";
            this.MO_checkBox_ShowDiscount.Size = new System.Drawing.Size(154, 18);
            this.MO_checkBox_ShowDiscount.TabIndex = 2;
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
            this.MO_checkBox_ShowSendMsg.TabIndex = 0;
            this.MO_checkBox_ShowSendMsg.Text = "mostra pulsante invio messaggio a cucina";
            this.MO_checkBox_ShowSendMsg.UseVisualStyleBackColor = true;
            // 
            // MO_checkBox_ShowTakeAway
            // 
            this.MO_checkBox_ShowTakeAway.AutoSize = true;
            this.MO_checkBox_ShowTakeAway.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MO_checkBox_ShowTakeAway.Location = new System.Drawing.Point(11, 63);
            this.MO_checkBox_ShowTakeAway.Name = "MO_checkBox_ShowTakeAway";
            this.MO_checkBox_ShowTakeAway.Size = new System.Drawing.Size(160, 18);
            this.MO_checkBox_ShowTakeAway.TabIndex = 1;
            this.MO_checkBox_ShowTakeAway.Text = "mostra pulsante Asporto";
            this.MO_checkBox_ShowTakeAway.UseVisualStyleBackColor = true;
            // 
            // MO_checkBox_Show_DB_Check
            // 
            this.MO_checkBox_Show_DB_Check.AutoSize = true;
            this.MO_checkBox_Show_DB_Check.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MO_checkBox_Show_DB_Check.Location = new System.Drawing.Point(11, 157);
            this.MO_checkBox_Show_DB_Check.Name = "MO_checkBox_Show_DB_Check";
            this.MO_checkBox_Show_DB_Check.Size = new System.Drawing.Size(168, 18);
            this.MO_checkBox_Show_DB_Check.TabIndex = 3;
            this.MO_checkBox_Show_DB_Check.Text = "mostra pulsante DB check";
            this.MO_checkBox_Show_DB_Check.UseVisualStyleBackColor = true;
            // 
            // MO_checkBox_Show_OSKeyb
            // 
            this.MO_checkBox_Show_OSKeyb.AutoSize = true;
            this.MO_checkBox_Show_OSKeyb.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MO_checkBox_Show_OSKeyb.Location = new System.Drawing.Point(11, 204);
            this.MO_checkBox_Show_OSKeyb.Name = "MO_checkBox_Show_OSKeyb";
            this.MO_checkBox_Show_OSKeyb.Size = new System.Drawing.Size(218, 18);
            this.MO_checkBox_Show_OSKeyb.TabIndex = 4;
            this.MO_checkBox_Show_OSKeyb.Text = "mostra pulsante Tastiera OnScreen";
            this.MO_checkBox_Show_OSKeyb.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReset.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(89, 510);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(115, 28);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "ripristina default";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // MO_checkBox_CAP
            // 
            this.MO_checkBox_CAP.AutoSize = true;
            this.MO_checkBox_CAP.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MO_checkBox_CAP.Location = new System.Drawing.Point(15, 225);
            this.MO_checkBox_CAP.Name = "MO_checkBox_CAP";
            this.MO_checkBox_CAP.Size = new System.Drawing.Size(238, 18);
            this.MO_checkBox_CAP.TabIndex = 10;
            this.MO_checkBox_CAP.Text = "rendi obbligatorio l\'inserimento del CAP";
            this.MO_checkBox_CAP.UseVisualStyleBackColor = true;
            this.MO_checkBox_CAP.Click += new System.EventHandler(this.MO_checkBox_CAP_Click);
            // 
            // MO_checkBox_Name
            // 
            this.MO_checkBox_Name.AutoSize = true;
            this.MO_checkBox_Name.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MO_checkBox_Name.Location = new System.Drawing.Point(15, 142);
            this.MO_checkBox_Name.Name = "MO_checkBox_Name";
            this.MO_checkBox_Name.Size = new System.Drawing.Size(289, 18);
            this.MO_checkBox_Name.TabIndex = 8;
            this.MO_checkBox_Name.Text = "rendi obbligatorio l\'inserimento del nome utente";
            this.MO_checkBox_Name.UseVisualStyleBackColor = true;
            // 
            // MO_ckBoxExternalPreview
            // 
            this.MO_ckBoxExternalPreview.AutoSize = true;
            this.MO_ckBoxExternalPreview.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MO_ckBoxExternalPreview.ForeColor = System.Drawing.Color.Blue;
            this.MO_ckBoxExternalPreview.Location = new System.Drawing.Point(398, 68);
            this.MO_ckBoxExternalPreview.Name = "MO_ckBoxExternalPreview";
            this.MO_ckBoxExternalPreview.Size = new System.Drawing.Size(180, 20);
            this.MO_ckBoxExternalPreview.TabIndex = 2;
            this.MO_ckBoxExternalPreview.Text = "mostra Anteprima flottante";
            this.MO_ckBoxExternalPreview.UseVisualStyleBackColor = true;
            // 
            // MO_checkBox_PAGER
            // 
            this.MO_checkBox_PAGER.AutoSize = true;
            this.MO_checkBox_PAGER.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MO_checkBox_PAGER.Location = new System.Drawing.Point(15, 262);
            this.MO_checkBox_PAGER.Name = "MO_checkBox_PAGER";
            this.MO_checkBox_PAGER.Size = new System.Drawing.Size(253, 18);
            this.MO_checkBox_PAGER.TabIndex = 17;
            this.MO_checkBox_PAGER.Text = "rendi obbligatorio l\'inserimento del PAGER";
            this.MO_checkBox_PAGER.UseVisualStyleBackColor = true;
            this.MO_checkBox_PAGER.Click += new System.EventHandler(this.MO_checkBox_PAGER_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.MO_radioButton_Show_PAGER);
            this.panel1.Controls.Add(this.MO_radioButton_Show_CAP);
            this.panel1.Location = new System.Drawing.Point(386, 360);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 97);
            this.panel1.TabIndex = 18;
            // 
            // MO_radioButton_Show_CAP
            // 
            this.MO_radioButton_Show_CAP.AutoCheck = false;
            this.MO_radioButton_Show_CAP.AutoSize = true;
            this.MO_radioButton_Show_CAP.Font = new System.Drawing.Font("Tahoma", 9F);
            this.MO_radioButton_Show_CAP.Location = new System.Drawing.Point(13, 23);
            this.MO_radioButton_Show_CAP.Name = "MO_radioButton_Show_CAP";
            this.MO_radioButton_Show_CAP.Size = new System.Drawing.Size(155, 18);
            this.MO_radioButton_Show_CAP.TabIndex = 8;
            this.MO_radioButton_Show_CAP.TabStop = true;
            this.MO_radioButton_Show_CAP.Text = "mostra inserimento CAP";
            this.MO_radioButton_Show_CAP.UseVisualStyleBackColor = true;
            this.MO_radioButton_Show_CAP.Click += new System.EventHandler(this.MO_radioButton_Show_CAP_Click);
            // 
            // MO_radioButton_Show_PAGER
            // 
            this.MO_radioButton_Show_PAGER.AutoCheck = false;
            this.MO_radioButton_Show_PAGER.AutoSize = true;
            this.MO_radioButton_Show_PAGER.Font = new System.Drawing.Font("Tahoma", 9F);
            this.MO_radioButton_Show_PAGER.Location = new System.Drawing.Point(13, 62);
            this.MO_radioButton_Show_PAGER.Name = "MO_radioButton_Show_PAGER";
            this.MO_radioButton_Show_PAGER.Size = new System.Drawing.Size(170, 18);
            this.MO_radioButton_Show_PAGER.TabIndex = 9;
            this.MO_radioButton_Show_PAGER.TabStop = true;
            this.MO_radioButton_Show_PAGER.Text = "mostra inserimento PAGER";
            this.MO_radioButton_Show_PAGER.UseVisualStyleBackColor = true;
            this.MO_radioButton_Show_PAGER.Click += new System.EventHandler(this.MO_radioButton_Show_PAGER_Click);
            // 
            // OptionsDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MO_checkBox_PAGER);
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
            this.panelShowHideButtons.ResumeLayout(false);
            this.panelShowHideButtons.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox MO_checkBoxPlaceSett;
        private System.Windows.Forms.CheckBox MO_checkBoxTable;
        private System.Windows.Forms.CheckBox MO_checkBox_InitialAvailabilityDlg;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox MO_checkBoxPayment;
        private System.Windows.Forms.CheckBox MO_checkBoxPrivacy;
        private System.Windows.Forms.ComboBox comboColorTheme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox MO_checkBox_Enter;
        private System.Windows.Forms.CheckBox MO_checkBoxShowPrevReceipt;
        private System.Windows.Forms.CheckBox MO_checkBox_ZeroPriceItems;
        private System.Windows.Forms.Panel panelShowHideButtons;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.CheckBox MO_checkBox_CAP;
        private System.Windows.Forms.CheckBox MO_checkBox_Name;
        private System.Windows.Forms.CheckBox MO_ckBoxExternalPreview;
        private System.Windows.Forms.CheckBox MO_checkBox_ShowDiscount;
        private System.Windows.Forms.CheckBox MO_checkBox_ShowSendMsg;
        private System.Windows.Forms.CheckBox MO_checkBox_ShowTakeAway;
        private System.Windows.Forms.CheckBox MO_checkBox_Show_DB_Check;
        private System.Windows.Forms.CheckBox MO_checkBox_Show_OSKeyb;
        private System.Windows.Forms.CheckBox MO_checkBox_PAGER;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton MO_radioButton_Show_PAGER;
        private System.Windows.Forms.RadioButton MO_radioButton_Show_CAP;
    }
}