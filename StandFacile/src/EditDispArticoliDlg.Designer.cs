namespace StandFacile
{
    partial class EditDispArticoliDlg
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
            this.EAA_lb1 = new System.Windows.Forms.Label();
            this.EAA_TipoEdit = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AzzeraBtn = new System.Windows.Forms.Button();
            this.RipristinaBtn = new System.Windows.Forms.Button();
            this.EAA_label5 = new System.Windows.Forms.Label();
            this.EAA_label4 = new System.Windows.Forms.Label();
            this.EAA_DispEdit = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.EAA_lbl2 = new System.Windows.Forms.Label();
            this.EAA_lblDescGruppo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EAA_lb1
            // 
            this.EAA_lb1.AutoSize = true;
            this.EAA_lb1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EAA_lb1.Location = new System.Drawing.Point(16, 19);
            this.EAA_lb1.Name = "EAA_lb1";
            this.EAA_lb1.Size = new System.Drawing.Size(105, 14);
            this.EAA_lb1.TabIndex = 4;
            this.EAA_lb1.Text = "Nome dell\'Articolo";
            // 
            // EAA_TipoEdit
            // 
            this.EAA_TipoEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EAA_TipoEdit.Location = new System.Drawing.Point(135, 15);
            this.EAA_TipoEdit.MaxLength = 18;
            this.EAA_TipoEdit.Name = "EAA_TipoEdit";
            this.EAA_TipoEdit.ReadOnly = true;
            this.EAA_TipoEdit.Size = new System.Drawing.Size(200, 22);
            this.EAA_TipoEdit.TabIndex = 0;
            this.EAA_TipoEdit.TabStop = false;
            this.EAA_TipoEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EditDispArticoliDlg_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AzzeraBtn);
            this.groupBox1.Controls.Add(this.RipristinaBtn);
            this.groupBox1.Controls.Add(this.EAA_label5);
            this.groupBox1.Controls.Add(this.EAA_label4);
            this.groupBox1.Controls.Add(this.EAA_DispEdit);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(19, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 123);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // AzzeraBtn
            // 
            this.AzzeraBtn.Image = global::StandFacile.Properties.Resources.Cancel;
            this.AzzeraBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AzzeraBtn.Location = new System.Drawing.Point(18, 78);
            this.AzzeraBtn.Name = "AzzeraBtn";
            this.AzzeraBtn.Size = new System.Drawing.Size(110, 32);
            this.AzzeraBtn.TabIndex = 1;
            this.AzzeraBtn.TabStop = false;
            this.AzzeraBtn.Text = "Azzera Disp.";
            this.AzzeraBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AzzeraBtn.UseVisualStyleBackColor = true;
            this.AzzeraBtn.Click += new System.EventHandler(this.BtnAzzera_Click);
            this.AzzeraBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EditDispArticoliDlg_KeyDown);
            // 
            // RipristinaBtn
            // 
            this.RipristinaBtn.Image = global::StandFacile.Properties.Resources.edit;
            this.RipristinaBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RipristinaBtn.Location = new System.Drawing.Point(154, 78);
            this.RipristinaBtn.Name = "RipristinaBtn";
            this.RipristinaBtn.Size = new System.Drawing.Size(143, 32);
            this.RipristinaBtn.TabIndex = 2;
            this.RipristinaBtn.TabStop = false;
            this.RipristinaBtn.Text = "  Ripristina max Disp.";
            this.RipristinaBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RipristinaBtn.UseVisualStyleBackColor = true;
            this.RipristinaBtn.Click += new System.EventHandler(this.BtnRipristina_Click);
            this.RipristinaBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EditDispArticoliDlg_KeyDown);
            // 
            // EAA_label5
            // 
            this.EAA_label5.AutoSize = true;
            this.EAA_label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EAA_label5.Location = new System.Drawing.Point(161, 26);
            this.EAA_label5.Name = "EAA_label5";
            this.EAA_label5.Size = new System.Drawing.Size(110, 14);
            this.EAA_label5.TabIndex = 4;
            this.EAA_label5.Text = "OK = nessun limite";
            // 
            // EAA_label4
            // 
            this.EAA_label4.AutoSize = true;
            this.EAA_label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EAA_label4.Location = new System.Drawing.Point(15, 26);
            this.EAA_label4.Name = "EAA_label4";
            this.EAA_label4.Size = new System.Drawing.Size(69, 14);
            this.EAA_label4.TabIndex = 3;
            this.EAA_label4.Text = "Disponibilità";
            // 
            // EAA_DispEdit
            // 
            this.EAA_DispEdit.Location = new System.Drawing.Point(95, 24);
            this.EAA_DispEdit.MaxLength = 6;
            this.EAA_DispEdit.Name = "EAA_DispEdit";
            this.EAA_DispEdit.Size = new System.Drawing.Size(47, 20);
            this.EAA_DispEdit.TabIndex = 0;
            this.EAA_DispEdit.Text = "OK";
            this.EAA_DispEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EAA_DispEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EditDispArticoliDlg_KeyDown);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::StandFacile.Properties.Resources.Cancel;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(81, 239);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 28);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EditDispArticoliDlg_KeyDown);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Image = global::StandFacile.Properties.Resources.OK;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(206, 239);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 28);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK  ";
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            this.btnOK.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EditDispArticoliDlg_KeyDown);
            // 
            // EAA_lbl2
            // 
            this.EAA_lbl2.AutoSize = true;
            this.EAA_lbl2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EAA_lbl2.Location = new System.Drawing.Point(16, 59);
            this.EAA_lbl2.Name = "EAA_lbl2";
            this.EAA_lbl2.Size = new System.Drawing.Size(91, 14);
            this.EAA_lbl2.TabIndex = 5;
            this.EAA_lbl2.Text = "Gruppo Articoli:";
            // 
            // EAA_lblDescGruppo
            // 
            this.EAA_lblDescGruppo.AutoSize = true;
            this.EAA_lblDescGruppo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EAA_lblDescGruppo.Location = new System.Drawing.Point(109, 59);
            this.EAA_lblDescGruppo.Name = "EAA_lblDescGruppo";
            this.EAA_lblDescGruppo.Size = new System.Drawing.Size(63, 14);
            this.EAA_lblDescGruppo.TabIndex = 6;
            this.EAA_lblDescGruppo.Text = "PIETANZE";
            // 
            // EditDispArticoliDlg
            // 
            this.AcceptButton = this.btnCancel;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 285);
            this.ControlBox = false;
            this.Controls.Add(this.EAA_lblDescGruppo);
            this.Controls.Add(this.EAA_lbl2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.EAA_TipoEdit);
            this.Controls.Add(this.EAA_lb1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EditDispArticoliDlg";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modifica Disponibilità";
            this.Shown += new System.EventHandler(this.DispDlg_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EditDispArticoliDlg_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EAA_lb1;
        private System.Windows.Forms.TextBox EAA_TipoEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label EAA_label5;
        private System.Windows.Forms.Label EAA_label4;
        private System.Windows.Forms.TextBox EAA_DispEdit;
        private System.Windows.Forms.Button AzzeraBtn;
        private System.Windows.Forms.Button RipristinaBtn;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label EAA_lbl2;
        private System.Windows.Forms.Label EAA_lblDescGruppo;
    }
}