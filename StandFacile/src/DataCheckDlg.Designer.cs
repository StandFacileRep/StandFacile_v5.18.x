namespace StandFacile
{
    partial class DataCheckDlg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataCheckDlg));
            this.DC_lblTavolo = new System.Windows.Forms.Label();
            this.DC_EditTavolo = new System.Windows.Forms.TextBox();
            this.DC_lblCoperti = new System.Windows.Forms.Label();
            this.DC_EditCoperti = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.radioSatispayBtn = new System.Windows.Forms.RadioButton();
            this.radioCardBtn = new System.Windows.Forms.RadioButton();
            this.radioContantiBtn = new System.Windows.Forms.RadioButton();
            this.BtnPrt = new System.Windows.Forms.Button();
            this.DC_Edit_CAP = new System.Windows.Forms.TextBox();
            this.DC_lbl_CAP = new System.Windows.Forms.Label();
            this.labelWarn = new System.Windows.Forms.Label();
            this.DC_EditName = new System.Windows.Forms.TextBox();
            this.DC_lblName = new System.Windows.Forms.Label();
            this.DC_lbl_Cash = new System.Windows.Forms.Label();
            this.DC_Edit_CASH = new System.Windows.Forms.TextBox();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // DC_lblTavolo
            // 
            this.DC_lblTavolo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DC_lblTavolo.AutoSize = true;
            this.DC_lblTavolo.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.DC_lblTavolo.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.DC_lblTavolo.Location = new System.Drawing.Point(55, 91);
            this.DC_lblTavolo.Margin = new System.Windows.Forms.Padding(3, 0, 3, 4);
            this.DC_lblTavolo.Name = "DC_lblTavolo";
            this.DC_lblTavolo.Size = new System.Drawing.Size(57, 18);
            this.DC_lblTavolo.TabIndex = 20;
            this.DC_lblTavolo.Text = "Tavolo:";
            // 
            // DC_EditTavolo
            // 
            this.DC_EditTavolo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DC_EditTavolo.BackColor = System.Drawing.Color.LightBlue;
            this.DC_EditTavolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DC_EditTavolo.Location = new System.Drawing.Point(151, 86);
            this.DC_EditTavolo.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.DC_EditTavolo.MaxLength = 12;
            this.DC_EditTavolo.Name = "DC_EditTavolo";
            this.DC_EditTavolo.Size = new System.Drawing.Size(100, 26);
            this.DC_EditTavolo.TabIndex = 0;
            this.DC_EditTavolo.WordWrap = false;
            this.DC_EditTavolo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyUp);
            // 
            // DC_lblCoperti
            // 
            this.DC_lblCoperti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DC_lblCoperti.AutoSize = true;
            this.DC_lblCoperti.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DC_lblCoperti.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.DC_lblCoperti.Location = new System.Drawing.Point(55, 55);
            this.DC_lblCoperti.Margin = new System.Windows.Forms.Padding(3, 0, 3, 4);
            this.DC_lblCoperti.Name = "DC_lblCoperti";
            this.DC_lblCoperti.Size = new System.Drawing.Size(58, 18);
            this.DC_lblCoperti.TabIndex = 22;
            this.DC_lblCoperti.Text = "Coperti:";
            // 
            // DC_EditCoperti
            // 
            this.DC_EditCoperti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DC_EditCoperti.BackColor = System.Drawing.Color.LightBlue;
            this.DC_EditCoperti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DC_EditCoperti.Location = new System.Drawing.Point(151, 50);
            this.DC_EditCoperti.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.DC_EditCoperti.MaxLength = 3;
            this.DC_EditCoperti.Name = "DC_EditCoperti";
            this.DC_EditCoperti.Size = new System.Drawing.Size(48, 26);
            this.DC_EditCoperti.TabIndex = 1;
            this.DC_EditCoperti.WordWrap = false;
            this.DC_EditCoperti.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EditFilter_KeyPress);
            this.DC_EditCoperti.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyUp);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(249, 361);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 35);
            this.btnOK.TabIndex = 9;
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
            this.btnCancel.Location = new System.Drawing.Point(30, 361);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 35);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Annulla";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // groupBox
            // 
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox.Controls.Add(this.radioSatispayBtn);
            this.groupBox.Controls.Add(this.radioCardBtn);
            this.groupBox.Controls.Add(this.radioContantiBtn);
            this.groupBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox.Location = new System.Drawing.Point(30, 224);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(299, 70);
            this.groupBox.TabIndex = 3;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "modo di pagamento";
            // 
            // radioSatispayBtn
            // 
            this.radioSatispayBtn.AutoSize = true;
            this.radioSatispayBtn.Location = new System.Drawing.Point(210, 30);
            this.radioSatispayBtn.Name = "radioSatispayBtn";
            this.radioSatispayBtn.Size = new System.Drawing.Size(73, 20);
            this.radioSatispayBtn.TabIndex = 6;
            this.radioSatispayBtn.TabStop = true;
            this.radioSatispayBtn.Text = "Satispay";
            this.radioSatispayBtn.UseVisualStyleBackColor = true;
            this.radioSatispayBtn.Click += new System.EventHandler(this.RadioBtn_Click);
            // 
            // radioCardBtn
            // 
            this.radioCardBtn.AutoSize = true;
            this.radioCardBtn.Location = new System.Drawing.Point(126, 30);
            this.radioCardBtn.Name = "radioCardBtn";
            this.radioCardBtn.Size = new System.Drawing.Size(52, 20);
            this.radioCardBtn.TabIndex = 5;
            this.radioCardBtn.TabStop = true;
            this.radioCardBtn.Text = "Card";
            this.radioCardBtn.UseVisualStyleBackColor = true;
            this.radioCardBtn.Click += new System.EventHandler(this.RadioBtn_Click);
            // 
            // radioContantiBtn
            // 
            this.radioContantiBtn.AutoSize = true;
            this.radioContantiBtn.Location = new System.Drawing.Point(25, 30);
            this.radioContantiBtn.Name = "radioContantiBtn";
            this.radioContantiBtn.Size = new System.Drawing.Size(72, 20);
            this.radioContantiBtn.TabIndex = 4;
            this.radioContantiBtn.TabStop = true;
            this.radioContantiBtn.Text = "Contanti";
            this.radioContantiBtn.UseVisualStyleBackColor = true;
            this.radioContantiBtn.Click += new System.EventHandler(this.RadioBtn_Click);
            // 
            // BtnPrt
            // 
            this.BtnPrt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnPrt.Image = global::StandFacile.Properties.Resources.printer_s;
            this.BtnPrt.Location = new System.Drawing.Point(151, 360);
            this.BtnPrt.Name = "BtnPrt";
            this.BtnPrt.Size = new System.Drawing.Size(70, 35);
            this.BtnPrt.TabIndex = 8;
            this.BtnPrt.UseVisualStyleBackColor = true;
            this.BtnPrt.Click += new System.EventHandler(this.BtnPrt_Click);
            // 
            // DC_Edit_CAP
            // 
            this.DC_Edit_CAP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DC_Edit_CAP.BackColor = System.Drawing.Color.LightBlue;
            this.DC_Edit_CAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DC_Edit_CAP.Location = new System.Drawing.Point(151, 163);
            this.DC_Edit_CAP.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.DC_Edit_CAP.MaxLength = 5;
            this.DC_Edit_CAP.Name = "DC_Edit_CAP";
            this.DC_Edit_CAP.Size = new System.Drawing.Size(70, 26);
            this.DC_Edit_CAP.TabIndex = 23;
            this.DC_Edit_CAP.WordWrap = false;
            this.DC_Edit_CAP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EditFilter_KeyPress);
            this.DC_Edit_CAP.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyUp);
            // 
            // DC_lbl_CAP
            // 
            this.DC_lbl_CAP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DC_lbl_CAP.AutoSize = true;
            this.DC_lbl_CAP.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DC_lbl_CAP.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.DC_lbl_CAP.Location = new System.Drawing.Point(55, 168);
            this.DC_lbl_CAP.Margin = new System.Windows.Forms.Padding(3, 0, 3, 4);
            this.DC_lbl_CAP.Name = "DC_lbl_CAP";
            this.DC_lbl_CAP.Size = new System.Drawing.Size(39, 18);
            this.DC_lbl_CAP.TabIndex = 24;
            this.DC_lbl_CAP.Text = "CAP:";
            // 
            // labelWarn
            // 
            this.labelWarn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWarn.AutoSize = true;
            this.labelWarn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWarn.ForeColor = System.Drawing.Color.Blue;
            this.labelWarn.Location = new System.Drawing.Point(52, 12);
            this.labelWarn.Margin = new System.Windows.Forms.Padding(3, 0, 3, 4);
            this.labelWarn.Name = "labelWarn";
            this.labelWarn.Size = new System.Drawing.Size(256, 18);
            this.labelWarn.TabIndex = 25;
            this.labelWarn.Text = "i campi obbligatori hanno l\'etichetta blu";
            // 
            // DC_EditName
            // 
            this.DC_EditName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DC_EditName.BackColor = System.Drawing.Color.LightBlue;
            this.DC_EditName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DC_EditName.Location = new System.Drawing.Point(151, 124);
            this.DC_EditName.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.DC_EditName.MaxLength = 20;
            this.DC_EditName.Name = "DC_EditName";
            this.DC_EditName.Size = new System.Drawing.Size(159, 26);
            this.DC_EditName.TabIndex = 26;
            this.DC_EditName.WordWrap = false;
            this.DC_EditName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyUp);
            // 
            // DC_lblName
            // 
            this.DC_lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DC_lblName.AutoSize = true;
            this.DC_lblName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DC_lblName.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.DC_lblName.Location = new System.Drawing.Point(58, 129);
            this.DC_lblName.Margin = new System.Windows.Forms.Padding(3, 0, 3, 4);
            this.DC_lblName.Name = "DC_lblName";
            this.DC_lblName.Size = new System.Drawing.Size(52, 18);
            this.DC_lblName.TabIndex = 27;
            this.DC_lblName.Text = "Nome:";
            // 
            // DC_lbl_Cash
            // 
            this.DC_lbl_Cash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DC_lbl_Cash.AutoSize = true;
            this.DC_lbl_Cash.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DC_lbl_Cash.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.DC_lbl_Cash.Location = new System.Drawing.Point(55, 307);
            this.DC_lbl_Cash.Margin = new System.Windows.Forms.Padding(3, 0, 3, 4);
            this.DC_lbl_Cash.Name = "DC_lbl_Cash";
            this.DC_lbl_Cash.Size = new System.Drawing.Size(72, 18);
            this.DC_lbl_Cash.TabIndex = 28;
            this.DC_lbl_Cash.Text = "Contante:";
            // 
            // DC_Edit_CASH
            // 
            this.DC_Edit_CASH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DC_Edit_CASH.BackColor = System.Drawing.Color.LightBlue;
            this.DC_Edit_CASH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DC_Edit_CASH.Location = new System.Drawing.Point(151, 303);
            this.DC_Edit_CASH.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.DC_Edit_CASH.MaxLength = 5;
            this.DC_Edit_CASH.Name = "DC_Edit_CASH";
            this.DC_Edit_CASH.Size = new System.Drawing.Size(70, 26);
            this.DC_Edit_CASH.TabIndex = 29;
            this.DC_Edit_CASH.WordWrap = false;
            this.DC_Edit_CASH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EditCashFilter_KeyPress);
            this.DC_Edit_CASH.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyUp);
            // 
            // DataCheckDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(363, 412);
            this.Controls.Add(this.DC_Edit_CASH);
            this.Controls.Add(this.DC_lbl_Cash);
            this.Controls.Add(this.DC_EditName);
            this.Controls.Add(this.DC_lblName);
            this.Controls.Add(this.labelWarn);
            this.Controls.Add(this.DC_Edit_CAP);
            this.Controls.Add(this.DC_lbl_CAP);
            this.Controls.Add(this.BtnPrt);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.DC_EditCoperti);
            this.Controls.Add(this.DC_lblCoperti);
            this.Controls.Add(this.DC_EditTavolo);
            this.Controls.Add(this.DC_lblTavolo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DataCheckDlg";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "modulo di verifica dei campi obbligatori";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DC_lblTavolo;
        private System.Windows.Forms.TextBox DC_EditTavolo;
        private System.Windows.Forms.Label DC_lblCoperti;
        private System.Windows.Forms.TextBox DC_EditCoperti;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton radioSatispayBtn;
        private System.Windows.Forms.RadioButton radioCardBtn;
        private System.Windows.Forms.RadioButton radioContantiBtn;
        private System.Windows.Forms.Button BtnPrt;
        private System.Windows.Forms.TextBox DC_Edit_CAP;
        private System.Windows.Forms.Label DC_lbl_CAP;
        private System.Windows.Forms.Label labelWarn;
        private System.Windows.Forms.TextBox DC_EditName;
        private System.Windows.Forms.Label DC_lblName;
        private System.Windows.Forms.Label DC_lbl_Cash;
        private System.Windows.Forms.TextBox DC_Edit_CASH;
    }
}