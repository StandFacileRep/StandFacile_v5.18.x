namespace StandFacile
{
    partial class PrintLocalCopiesConfigDlg
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintLocalCopiesConfigDlg));
            this.RadioGroup_PrinterType = new System.Windows.Forms.GroupBox();
            this.prt_Legacy = new System.Windows.Forms.RadioButton();
            this.prt_Windows = new System.Windows.Forms.RadioButton();
            this.printersGroupBox = new System.Windows.Forms.GroupBox();
            this.BtnGenPrinterOptions = new System.Windows.Forms.Button();
            this.BtnLegacy = new System.Windows.Forms.Button();
            this.BtnWin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.LC_panelLocalCopies = new System.Windows.Forms.Panel();
            this.LC_checkBox_LocPrices = new System.Windows.Forms.CheckBox();
            this.LC_labelWarn1 = new System.Windows.Forms.Label();
            this.LC_checkBox_AvoidPrintGroups = new System.Windows.Forms.CheckBox();
            this.LC_labelWarn2 = new System.Windows.Forms.Label();
            this.LC_checkBox_CUT = new System.Windows.Forms.CheckBox();
            this.LC_checkBoxUnitItems = new System.Windows.Forms.CheckBox();
            this.panelCopies = new System.Windows.Forms.Panel();
            this.checkBoxCopia_9 = new System.Windows.Forms.CheckBox();
            this.checkBoxCopia_8 = new System.Windows.Forms.CheckBox();
            this.labelNoWebLoad = new System.Windows.Forms.Label();
            this.checkBoxCopia_7 = new System.Windows.Forms.CheckBox();
            this.checkBoxCopia_6 = new System.Windows.Forms.CheckBox();
            this.checkBoxCopia_5 = new System.Windows.Forms.CheckBox();
            this.checkBoxCopia_4 = new System.Windows.Forms.CheckBox();
            this.checkBoxCopia_3 = new System.Windows.Forms.CheckBox();
            this.checkBoxCopia_2 = new System.Windows.Forms.CheckBox();
            this.checkBoxCopia_1 = new System.Windows.Forms.CheckBox();
            this.checkBoxCopia_0 = new System.Windows.Forms.CheckBox();
            this.LC_checkBoxSingleRowItems = new System.Windows.Forms.CheckBox();
            this.LC_checkBoxSelectedOnly = new System.Windows.Forms.CheckBox();
            this.LC_checkBoxLocalCopy = new System.Windows.Forms.CheckBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.LC_LinkLbl_Mnu_CCR = new System.Windows.Forms.LinkLabel();
            this.LC_label2 = new System.Windows.Forms.Label();
            this.LC_label3 = new System.Windows.Forms.Label();
            this.LC_label1 = new System.Windows.Forms.Label();
            this.PrintersListCombo = new System.Windows.Forms.ComboBox();
            this.LC_checkBoxRiepilogo = new System.Windows.Forms.CheckBox();
            this.LC_label4 = new System.Windows.Forms.Label();
            this.BtnPrintCheck = new System.Windows.Forms.Button();
            this.LC_label5 = new System.Windows.Forms.Label();
            this.RadioGroup_PrinterType.SuspendLayout();
            this.printersGroupBox.SuspendLayout();
            this.LC_panelLocalCopies.SuspendLayout();
            this.panelCopies.SuspendLayout();
            this.SuspendLayout();
            // 
            // RadioGroup_PrinterType
            // 
            this.RadioGroup_PrinterType.Controls.Add(this.prt_Legacy);
            this.RadioGroup_PrinterType.Controls.Add(this.prt_Windows);
            this.RadioGroup_PrinterType.Font = new System.Drawing.Font("Tahoma", 9F);
            this.RadioGroup_PrinterType.Location = new System.Drawing.Point(312, 14);
            this.RadioGroup_PrinterType.Name = "RadioGroup_PrinterType";
            this.RadioGroup_PrinterType.Size = new System.Drawing.Size(211, 94);
            this.RadioGroup_PrinterType.TabIndex = 1;
            this.RadioGroup_PrinterType.TabStop = false;
            this.RadioGroup_PrinterType.Text = "tipo di Stampante dello Scontrino";
            // 
            // prt_Legacy
            // 
            this.prt_Legacy.AutoSize = true;
            this.prt_Legacy.Location = new System.Drawing.Point(128, 50);
            this.prt_Legacy.Name = "prt_Legacy";
            this.prt_Legacy.Size = new System.Drawing.Size(69, 18);
            this.prt_Legacy.TabIndex = 1;
            this.prt_Legacy.TabStop = true;
            this.prt_Legacy.Text = "LEGACY";
            this.prt_Legacy.UseVisualStyleBackColor = true;
            // 
            // prt_Windows
            // 
            this.prt_Windows.AutoSize = true;
            this.prt_Windows.Location = new System.Drawing.Point(19, 50);
            this.prt_Windows.Name = "prt_Windows";
            this.prt_Windows.Size = new System.Drawing.Size(85, 18);
            this.prt_Windows.TabIndex = 0;
            this.prt_Windows.TabStop = true;
            this.prt_Windows.Text = "WINDOWS";
            this.prt_Windows.UseVisualStyleBackColor = true;
            // 
            // printersGroupBox
            // 
            this.printersGroupBox.Controls.Add(this.BtnGenPrinterOptions);
            this.printersGroupBox.Controls.Add(this.BtnLegacy);
            this.printersGroupBox.Controls.Add(this.BtnWin);
            this.printersGroupBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printersGroupBox.Location = new System.Drawing.Point(30, 14);
            this.printersGroupBox.Name = "printersGroupBox";
            this.printersGroupBox.Size = new System.Drawing.Size(260, 94);
            this.printersGroupBox.TabIndex = 0;
            this.printersGroupBox.TabStop = false;
            this.printersGroupBox.Text = "Impostazione stampanti Windows e Legacy";
            // 
            // BtnGenPrinterOptions
            // 
            this.BtnGenPrinterOptions.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnGenPrinterOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnGenPrinterOptions.Image = global::StandFacile.Properties.Resources.globe;
            this.BtnGenPrinterOptions.Location = new System.Drawing.Point(106, 29);
            this.BtnGenPrinterOptions.Name = "BtnGenPrinterOptions";
            this.BtnGenPrinterOptions.Size = new System.Drawing.Size(50, 50);
            this.BtnGenPrinterOptions.TabIndex = 1;
            this.BtnGenPrinterOptions.UseVisualStyleBackColor = false;
            this.BtnGenPrinterOptions.Click += new System.EventHandler(this.BtnGeneric_Click);
            // 
            // BtnLegacy
            // 
            this.BtnLegacy.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnLegacy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnLegacy.Image = ((System.Drawing.Image)(resources.GetObject("BtnLegacy.Image")));
            this.BtnLegacy.Location = new System.Drawing.Point(192, 29);
            this.BtnLegacy.Name = "BtnLegacy";
            this.BtnLegacy.Size = new System.Drawing.Size(50, 50);
            this.BtnLegacy.TabIndex = 2;
            this.BtnLegacy.UseVisualStyleBackColor = false;
            this.BtnLegacy.Click += new System.EventHandler(this.BtnLegacy_Click);
            // 
            // BtnWin
            // 
            this.BtnWin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnWin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnWin.Image = ((System.Drawing.Image)(resources.GetObject("BtnWin.Image")));
            this.BtnWin.Location = new System.Drawing.Point(19, 29);
            this.BtnWin.Name = "BtnWin";
            this.BtnWin.Size = new System.Drawing.Size(50, 50);
            this.BtnWin.TabIndex = 0;
            this.BtnWin.UseVisualStyleBackColor = false;
            this.BtnWin.Click += new System.EventHandler(this.BtnWin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(163, 655);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 28);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOK.Image = global::StandFacile.Properties.Resources.OK;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(299, 655);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 28);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK  ";
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // LC_panelLocalCopies
            // 
            this.LC_panelLocalCopies.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LC_panelLocalCopies.Controls.Add(this.LC_checkBox_LocPrices);
            this.LC_panelLocalCopies.Controls.Add(this.LC_labelWarn1);
            this.LC_panelLocalCopies.Controls.Add(this.LC_checkBox_AvoidPrintGroups);
            this.LC_panelLocalCopies.Controls.Add(this.LC_labelWarn2);
            this.LC_panelLocalCopies.Controls.Add(this.LC_checkBox_CUT);
            this.LC_panelLocalCopies.Controls.Add(this.LC_checkBoxUnitItems);
            this.LC_panelLocalCopies.Controls.Add(this.panelCopies);
            this.LC_panelLocalCopies.Controls.Add(this.LC_checkBoxSingleRowItems);
            this.LC_panelLocalCopies.Controls.Add(this.LC_checkBoxSelectedOnly);
            this.LC_panelLocalCopies.Controls.Add(this.LC_checkBoxLocalCopy);
            this.LC_panelLocalCopies.Location = new System.Drawing.Point(16, 190);
            this.LC_panelLocalCopies.Name = "LC_panelLocalCopies";
            this.LC_panelLocalCopies.Size = new System.Drawing.Size(517, 379);
            this.LC_panelLocalCopies.TabIndex = 6;
            // 
            // LC_checkBox_LocPrices
            // 
            this.LC_checkBox_LocPrices.AutoSize = true;
            this.LC_checkBox_LocPrices.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LC_checkBox_LocPrices.Location = new System.Drawing.Point(17, 52);
            this.LC_checkBox_LocPrices.Name = "LC_checkBox_LocPrices";
            this.LC_checkBox_LocPrices.Size = new System.Drawing.Size(215, 18);
            this.LC_checkBox_LocPrices.TabIndex = 1;
            this.LC_checkBox_LocPrices.Text = "abilita stampa dei prezzi nelle copie";
            this.LC_checkBox_LocPrices.UseVisualStyleBackColor = true;
            // 
            // LC_labelWarn1
            // 
            this.LC_labelWarn1.AutoSize = true;
            this.LC_labelWarn1.BackColor = System.Drawing.SystemColors.Control;
            this.LC_labelWarn1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.LC_labelWarn1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LC_labelWarn1.Location = new System.Drawing.Point(264, 41);
            this.LC_labelWarn1.Name = "LC_labelWarn1";
            this.LC_labelWarn1.Size = new System.Drawing.Size(240, 13);
            this.LC_labelWarn1.TabIndex = 5;
            this.LC_labelWarn1.Text = "attivabile se sono selezionate le opzioni qui sotto";
            // 
            // LC_checkBox_AvoidPrintGroups
            // 
            this.LC_checkBox_AvoidPrintGroups.AutoSize = true;
            this.LC_checkBox_AvoidPrintGroups.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LC_checkBox_AvoidPrintGroups.Location = new System.Drawing.Point(265, 24);
            this.LC_checkBox_AvoidPrintGroups.Name = "LC_checkBox_AvoidPrintGroups";
            this.LC_checkBox_AvoidPrintGroups.Size = new System.Drawing.Size(239, 18);
            this.LC_checkBox_AvoidPrintGroups.TabIndex = 4;
            this.LC_checkBox_AvoidPrintGroups.Text = "evita stampa per gruppi non selezionati";
            this.LC_checkBox_AvoidPrintGroups.UseVisualStyleBackColor = true;
            // 
            // LC_labelWarn2
            // 
            this.LC_labelWarn2.AutoSize = true;
            this.LC_labelWarn2.BackColor = System.Drawing.SystemColors.Control;
            this.LC_labelWarn2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.LC_labelWarn2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LC_labelWarn2.Location = new System.Drawing.Point(283, 100);
            this.LC_labelWarn2.Name = "LC_labelWarn2";
            this.LC_labelWarn2.Size = new System.Drawing.Size(185, 13);
            this.LC_labelWarn2.TabIndex = 7;
            this.LC_labelWarn2.Text = "opzioni ad elevato consumo di carta !";
            // 
            // LC_checkBox_CUT
            // 
            this.LC_checkBox_CUT.AutoSize = true;
            this.LC_checkBox_CUT.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LC_checkBox_CUT.Location = new System.Drawing.Point(17, 89);
            this.LC_checkBox_CUT.Name = "LC_checkBox_CUT";
            this.LC_checkBox_CUT.Size = new System.Drawing.Size(221, 18);
            this.LC_checkBox_CUT.TabIndex = 2;
            this.LC_checkBox_CUT.Text = "stampa con taglio di separaz. gruppi";
            this.LC_checkBox_CUT.UseVisualStyleBackColor = true;
            // 
            // LC_checkBoxUnitItems
            // 
            this.LC_checkBoxUnitItems.AutoSize = true;
            this.LC_checkBoxUnitItems.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LC_checkBoxUnitItems.Location = new System.Drawing.Point(265, 122);
            this.LC_checkBoxUnitItems.Name = "LC_checkBoxUnitItems";
            this.LC_checkBoxUnitItems.Size = new System.Drawing.Size(204, 18);
            this.LC_checkBoxUnitItems.TabIndex = 8;
            this.LC_checkBoxUnitItems.Text = "singolo articolo con quantità uno";
            this.LC_checkBoxUnitItems.UseVisualStyleBackColor = true;
            this.LC_checkBoxUnitItems.CheckedChanged += new System.EventHandler(this.CheckBoxUnitItems_CheckedChanged);
            // 
            // panelCopies
            // 
            this.panelCopies.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelCopies.Controls.Add(this.checkBoxCopia_9);
            this.panelCopies.Controls.Add(this.checkBoxCopia_8);
            this.panelCopies.Controls.Add(this.labelNoWebLoad);
            this.panelCopies.Controls.Add(this.checkBoxCopia_7);
            this.panelCopies.Controls.Add(this.checkBoxCopia_6);
            this.panelCopies.Controls.Add(this.checkBoxCopia_5);
            this.panelCopies.Controls.Add(this.checkBoxCopia_4);
            this.panelCopies.Controls.Add(this.checkBoxCopia_3);
            this.panelCopies.Controls.Add(this.checkBoxCopia_2);
            this.panelCopies.Controls.Add(this.checkBoxCopia_1);
            this.panelCopies.Controls.Add(this.checkBoxCopia_0);
            this.panelCopies.Location = new System.Drawing.Point(10, 156);
            this.panelCopies.Name = "panelCopies";
            this.panelCopies.Size = new System.Drawing.Size(496, 209);
            this.panelCopies.TabIndex = 1;
            // 
            // checkBoxCopia_9
            // 
            this.checkBoxCopia_9.AutoSize = true;
            this.checkBoxCopia_9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCopia_9.Location = new System.Drawing.Point(265, 173);
            this.checkBoxCopia_9.Name = "checkBoxCopia_9";
            this.checkBoxCopia_9.Size = new System.Drawing.Size(189, 17);
            this.checkBoxCopia_9.TabIndex = 10;
            this.checkBoxCopia_9.Text = "##### COPIE SINGOLE #####";
            this.checkBoxCopia_9.UseVisualStyleBackColor = true;
            // 
            // checkBoxCopia_8
            // 
            this.checkBoxCopia_8.AutoSize = true;
            this.checkBoxCopia_8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCopia_8.Location = new System.Drawing.Point(265, 130);
            this.checkBoxCopia_8.Name = "checkBoxCopia_8";
            this.checkBoxCopia_8.Size = new System.Drawing.Size(178, 17);
            this.checkBoxCopia_8.TabIndex = 8;
            this.checkBoxCopia_8.Text = "### COPIA GRP NO WEB ###";
            this.checkBoxCopia_8.UseVisualStyleBackColor = true;
            // 
            // labelNoWebLoad
            // 
            this.labelNoWebLoad.AutoSize = true;
            this.labelNoWebLoad.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.labelNoWebLoad.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelNoWebLoad.Location = new System.Drawing.Point(282, 147);
            this.labelNoWebLoad.Name = "labelNoWebLoad";
            this.labelNoWebLoad.Size = new System.Drawing.Size(163, 13);
            this.labelNoWebLoad.TabIndex = 9;
            this.labelNoWebLoad.Text = "no ordini web per questo gruppo";
            // 
            // checkBoxCopia_7
            // 
            this.checkBoxCopia_7.AutoSize = true;
            this.checkBoxCopia_7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCopia_7.Location = new System.Drawing.Point(265, 92);
            this.checkBoxCopia_7.Name = "checkBoxCopia_7";
            this.checkBoxCopia_7.Size = new System.Drawing.Size(194, 17);
            this.checkBoxCopia_7.TabIndex = 7;
            this.checkBoxCopia_7.Text = "##### COPIA GRUPPO8 #####";
            this.checkBoxCopia_7.UseVisualStyleBackColor = true;
            // 
            // checkBoxCopia_6
            // 
            this.checkBoxCopia_6.AutoSize = true;
            this.checkBoxCopia_6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCopia_6.Location = new System.Drawing.Point(265, 54);
            this.checkBoxCopia_6.Name = "checkBoxCopia_6";
            this.checkBoxCopia_6.Size = new System.Drawing.Size(194, 17);
            this.checkBoxCopia_6.TabIndex = 6;
            this.checkBoxCopia_6.Text = "##### COPIA GRUPPO7 #####";
            this.checkBoxCopia_6.UseVisualStyleBackColor = true;
            // 
            // checkBoxCopia_5
            // 
            this.checkBoxCopia_5.AutoSize = true;
            this.checkBoxCopia_5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCopia_5.Location = new System.Drawing.Point(265, 16);
            this.checkBoxCopia_5.Name = "checkBoxCopia_5";
            this.checkBoxCopia_5.Size = new System.Drawing.Size(194, 17);
            this.checkBoxCopia_5.TabIndex = 5;
            this.checkBoxCopia_5.Text = "##### COPIA GRUPPO6 #####";
            this.checkBoxCopia_5.UseVisualStyleBackColor = true;
            // 
            // checkBoxCopia_4
            // 
            this.checkBoxCopia_4.AutoSize = true;
            this.checkBoxCopia_4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCopia_4.Location = new System.Drawing.Point(16, 168);
            this.checkBoxCopia_4.Name = "checkBoxCopia_4";
            this.checkBoxCopia_4.Size = new System.Drawing.Size(194, 17);
            this.checkBoxCopia_4.TabIndex = 4;
            this.checkBoxCopia_4.Text = "##### COPIA GRUPPO5 #####";
            this.checkBoxCopia_4.UseVisualStyleBackColor = true;
            // 
            // checkBoxCopia_3
            // 
            this.checkBoxCopia_3.AutoSize = true;
            this.checkBoxCopia_3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCopia_3.Location = new System.Drawing.Point(16, 130);
            this.checkBoxCopia_3.Name = "checkBoxCopia_3";
            this.checkBoxCopia_3.Size = new System.Drawing.Size(194, 17);
            this.checkBoxCopia_3.TabIndex = 3;
            this.checkBoxCopia_3.Text = "##### COPIA GRUPPO4 #####";
            this.checkBoxCopia_3.UseVisualStyleBackColor = true;
            // 
            // checkBoxCopia_2
            // 
            this.checkBoxCopia_2.AutoSize = true;
            this.checkBoxCopia_2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCopia_2.Location = new System.Drawing.Point(16, 92);
            this.checkBoxCopia_2.Name = "checkBoxCopia_2";
            this.checkBoxCopia_2.Size = new System.Drawing.Size(194, 17);
            this.checkBoxCopia_2.TabIndex = 2;
            this.checkBoxCopia_2.Text = "##### COPIA GRUPPO3 #####";
            this.checkBoxCopia_2.UseVisualStyleBackColor = true;
            // 
            // checkBoxCopia_1
            // 
            this.checkBoxCopia_1.AutoSize = true;
            this.checkBoxCopia_1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCopia_1.Location = new System.Drawing.Point(16, 54);
            this.checkBoxCopia_1.Name = "checkBoxCopia_1";
            this.checkBoxCopia_1.Size = new System.Drawing.Size(194, 17);
            this.checkBoxCopia_1.TabIndex = 1;
            this.checkBoxCopia_1.Text = "##### COPIA GRUPPO2 #####";
            this.checkBoxCopia_1.UseVisualStyleBackColor = true;
            // 
            // checkBoxCopia_0
            // 
            this.checkBoxCopia_0.AutoSize = true;
            this.checkBoxCopia_0.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCopia_0.Location = new System.Drawing.Point(16, 16);
            this.checkBoxCopia_0.Name = "checkBoxCopia_0";
            this.checkBoxCopia_0.Size = new System.Drawing.Size(194, 17);
            this.checkBoxCopia_0.TabIndex = 0;
            this.checkBoxCopia_0.Text = "##### COPIA GRUPPO1 #####";
            this.checkBoxCopia_0.UseVisualStyleBackColor = true;
            // 
            // LC_checkBoxSingleRowItems
            // 
            this.LC_checkBoxSingleRowItems.AutoSize = true;
            this.LC_checkBoxSingleRowItems.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LC_checkBoxSingleRowItems.Location = new System.Drawing.Point(265, 74);
            this.LC_checkBoxSingleRowItems.Name = "LC_checkBoxSingleRowItems";
            this.LC_checkBoxSingleRowItems.Size = new System.Drawing.Size(200, 18);
            this.LC_checkBoxSingleRowItems.TabIndex = 6;
            this.LC_checkBoxSingleRowItems.Text = "singolo articolo nella copia locale";
            this.LC_checkBoxSingleRowItems.UseVisualStyleBackColor = true;
            this.LC_checkBoxSingleRowItems.CheckedChanged += new System.EventHandler(this.CheckBoxSingleRowItems_CheckedChanged);
            // 
            // LC_checkBoxSelectedOnly
            // 
            this.LC_checkBoxSelectedOnly.AutoSize = true;
            this.LC_checkBoxSelectedOnly.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LC_checkBoxSelectedOnly.Location = new System.Drawing.Point(17, 126);
            this.LC_checkBoxSelectedOnly.Name = "LC_checkBoxSelectedOnly";
            this.LC_checkBoxSelectedOnly.Size = new System.Drawing.Size(149, 18);
            this.LC_checkBoxSelectedOnly.TabIndex = 3;
            this.LC_checkBoxSelectedOnly.Text = "stampa solo selezionati";
            this.LC_checkBoxSelectedOnly.UseVisualStyleBackColor = true;
            this.LC_checkBoxSelectedOnly.CheckedChanged += new System.EventHandler(this.CheckBoxNoPrice_CheckedChanged);
            // 
            // LC_checkBoxLocalCopy
            // 
            this.LC_checkBoxLocalCopy.AutoSize = true;
            this.LC_checkBoxLocalCopy.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LC_checkBoxLocalCopy.Location = new System.Drawing.Point(17, 15);
            this.LC_checkBoxLocalCopy.Name = "LC_checkBoxLocalCopy";
            this.LC_checkBoxLocalCopy.Size = new System.Drawing.Size(165, 18);
            this.LC_checkBoxLocalCopy.TabIndex = 0;
            this.LC_checkBoxLocalCopy.Text = "abilita stampa copie Locali";
            this.LC_checkBoxLocalCopy.UseVisualStyleBackColor = true;
            this.LC_checkBoxLocalCopy.CheckedChanged += new System.EventHandler(this.CheckBoxNoPrice_CheckedChanged);
            // 
            // timer
            // 
            this.timer.Interval = 250;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // LC_LinkLbl_Mnu_CCR
            // 
            this.LC_LinkLbl_Mnu_CCR.AutoSize = true;
            this.LC_LinkLbl_Mnu_CCR.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LC_LinkLbl_Mnu_CCR.Location = new System.Drawing.Point(339, 160);
            this.LC_LinkLbl_Mnu_CCR.Name = "LC_LinkLbl_Mnu_CCR";
            this.LC_LinkLbl_Mnu_CCR.Size = new System.Drawing.Size(188, 14);
            this.LC_LinkLbl_Mnu_CCR.TabIndex = 5;
            this.LC_LinkLbl_Mnu_CCR.TabStop = true;
            this.LC_LinkLbl_Mnu_CCR.Text = "\"Configurazione Gruppi di Articoli\"";
            this.LC_LinkLbl_Mnu_CCR.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLbl_Mnu_CCR_LinkClicked);
            // 
            // LC_label2
            // 
            this.LC_label2.AutoSize = true;
            this.LC_label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LC_label2.Location = new System.Drawing.Point(21, 139);
            this.LC_label2.Name = "LC_label2";
            this.LC_label2.Size = new System.Drawing.Size(489, 16);
            this.LC_label2.TabIndex = 3;
            this.LC_label2.Text = "per modifica testo descrittivo dei gruppi, raggruppamento per colore, stampa in r" +
    "ete";
            // 
            // LC_label3
            // 
            this.LC_label3.AutoSize = true;
            this.LC_label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LC_label3.Location = new System.Drawing.Point(21, 159);
            this.LC_label3.Name = "LC_label3";
            this.LC_label3.Size = new System.Drawing.Size(317, 16);
            this.LC_label3.TabIndex = 4;
            this.LC_label3.Text = "e/o ordini da smartphone usare in alternativa il menu:";
            // 
            // LC_label1
            // 
            this.LC_label1.AutoSize = true;
            this.LC_label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LC_label1.Location = new System.Drawing.Point(21, 119);
            this.LC_label1.Name = "LC_label1";
            this.LC_label1.Size = new System.Drawing.Size(450, 16);
            this.LC_label1.TabIndex = 2;
            this.LC_label1.Text = "da qui si effettuano le impostazioni di stampa delle sole copie in cassa locale:";
            // 
            // PrintersListCombo
            // 
            this.PrintersListCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PrintersListCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PrintersListCombo.FormattingEnabled = true;
            this.PrintersListCombo.Location = new System.Drawing.Point(237, 612);
            this.PrintersListCombo.Name = "PrintersListCombo";
            this.PrintersListCombo.Size = new System.Drawing.Size(194, 21);
            this.PrintersListCombo.TabIndex = 9;
            // 
            // LC_checkBoxRiepilogo
            // 
            this.LC_checkBoxRiepilogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LC_checkBoxRiepilogo.AutoSize = true;
            this.LC_checkBoxRiepilogo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LC_checkBoxRiepilogo.Location = new System.Drawing.Point(33, 612);
            this.LC_checkBoxRiepilogo.Name = "LC_checkBoxRiepilogo";
            this.LC_checkBoxRiepilogo.Padding = new System.Windows.Forms.Padding(1);
            this.LC_checkBoxRiepilogo.Size = new System.Drawing.Size(188, 20);
            this.LC_checkBoxRiepilogo.TabIndex = 10;
            this.LC_checkBoxRiepilogo.Text = "stampa una copia di Riepilogo";
            this.LC_checkBoxRiepilogo.UseVisualStyleBackColor = true;
            // 
            // LC_label4
            // 
            this.LC_label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LC_label4.AutoSize = true;
            this.LC_label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LC_label4.Location = new System.Drawing.Point(234, 589);
            this.LC_label4.Name = "LC_label4";
            this.LC_label4.Size = new System.Drawing.Size(293, 16);
            this.LC_label4.TabIndex = 11;
            this.LC_label4.Text = "selezione della stampante per la copia di riepilogo";
            // 
            // BtnPrintCheck
            // 
            this.BtnPrintCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnPrintCheck.Image = global::StandFacile.Properties.Resources.OK;
            this.BtnPrintCheck.Location = new System.Drawing.Point(460, 612);
            this.BtnPrintCheck.Name = "BtnPrintCheck";
            this.BtnPrintCheck.Size = new System.Drawing.Size(27, 23);
            this.BtnPrintCheck.TabIndex = 42;
            this.BtnPrintCheck.UseVisualStyleBackColor = true;
            this.BtnPrintCheck.Click += new System.EventHandler(this.BtnPrintCheck_Click);
            // 
            // LC_label5
            // 
            this.LC_label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LC_label5.AutoSize = true;
            this.LC_label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LC_label5.Location = new System.Drawing.Point(50, 589);
            this.LC_label5.Name = "LC_label5";
            this.LC_label5.Size = new System.Drawing.Size(169, 16);
            this.LC_label5.TabIndex = 43;
            this.LC_label5.Text = "in aggiunta alle copie Locali:";
            // 
            // PrintLocalCopiesConfigDlg
            // 
            this.AcceptButton = this.btnCancel;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 699);
            this.Controls.Add(this.LC_label5);
            this.Controls.Add(this.BtnPrintCheck);
            this.Controls.Add(this.LC_label4);
            this.Controls.Add(this.LC_checkBoxRiepilogo);
            this.Controls.Add(this.PrintersListCombo);
            this.Controls.Add(this.LC_label2);
            this.Controls.Add(this.LC_label3);
            this.Controls.Add(this.LC_label1);
            this.Controls.Add(this.LC_LinkLbl_Mnu_CCR);
            this.Controls.Add(this.LC_panelLocalCopies);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.printersGroupBox);
            this.Controls.Add(this.RadioGroup_PrinterType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrintLocalCopiesConfigDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurazione Gruppi e Stampante per le copie Locali";
            this.RadioGroup_PrinterType.ResumeLayout(false);
            this.RadioGroup_PrinterType.PerformLayout();
            this.printersGroupBox.ResumeLayout(false);
            this.LC_panelLocalCopies.ResumeLayout(false);
            this.LC_panelLocalCopies.PerformLayout();
            this.panelCopies.ResumeLayout(false);
            this.panelCopies.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox RadioGroup_PrinterType;
        private System.Windows.Forms.RadioButton prt_Legacy;
        private System.Windows.Forms.RadioButton prt_Windows;
        private System.Windows.Forms.GroupBox printersGroupBox;
        private System.Windows.Forms.Button BtnWin;
        private System.Windows.Forms.Button BtnLegacy;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Panel LC_panelLocalCopies;
        private System.Windows.Forms.CheckBox LC_checkBoxSelectedOnly;
        private System.Windows.Forms.CheckBox LC_checkBoxLocalCopy;
        private System.Windows.Forms.CheckBox LC_checkBoxSingleRowItems;
        private System.Windows.Forms.Panel panelCopies;
        private System.Windows.Forms.CheckBox checkBoxCopia_7;
        private System.Windows.Forms.CheckBox checkBoxCopia_6;
        private System.Windows.Forms.CheckBox checkBoxCopia_5;
        private System.Windows.Forms.CheckBox checkBoxCopia_4;
        private System.Windows.Forms.CheckBox checkBoxCopia_3;
        private System.Windows.Forms.CheckBox checkBoxCopia_2;
        private System.Windows.Forms.CheckBox checkBoxCopia_1;
        private System.Windows.Forms.CheckBox checkBoxCopia_0;
        private System.Windows.Forms.CheckBox LC_checkBoxUnitItems;
        private System.Windows.Forms.Label labelNoWebLoad;
        private System.Windows.Forms.CheckBox LC_checkBox_CUT;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.LinkLabel LC_LinkLbl_Mnu_CCR;
        private System.Windows.Forms.Label LC_labelWarn2;
        private System.Windows.Forms.Label LC_label2;
        private System.Windows.Forms.Label LC_label3;
        private System.Windows.Forms.Label LC_label1;
        private System.Windows.Forms.CheckBox LC_checkBox_AvoidPrintGroups;
        private System.Windows.Forms.CheckBox checkBoxCopia_8;
        private System.Windows.Forms.CheckBox checkBoxCopia_9;
        private System.Windows.Forms.Label LC_labelWarn1;
        private System.Windows.Forms.CheckBox LC_checkBox_LocPrices;
        private System.Windows.Forms.Button BtnGenPrinterOptions;
        private System.Windows.Forms.ComboBox PrintersListCombo;
        private System.Windows.Forms.CheckBox LC_checkBoxRiepilogo;
        private System.Windows.Forms.Label LC_label4;
        private System.Windows.Forms.Button BtnPrintCheck;
        private System.Windows.Forms.Label LC_label5;
    }
}