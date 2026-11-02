namespace StandFacile
{
    partial class PrintConfigLightDlg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintConfigLightDlg));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnCommonPrintSetup = new System.Windows.Forms.Button();
            this.BtnLegacy = new System.Windows.Forms.Button();
            this.BtnWin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnCommonPrintSetup);
            this.groupBox1.Controls.Add(this.BtnLegacy);
            this.groupBox1.Controls.Add(this.BtnWin);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 103);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Imposta stampanti Windows, ESC/POS e Legacy";
            // 
            // BtnCommonPrintSetup
            // 
            this.BtnCommonPrintSetup.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCommonPrintSetup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnCommonPrintSetup.Image = global::StandFacile.Properties.Resources.globe;
            this.BtnCommonPrintSetup.Location = new System.Drawing.Point(121, 29);
            this.BtnCommonPrintSetup.Name = "BtnCommonPrintSetup";
            this.BtnCommonPrintSetup.Size = new System.Drawing.Size(50, 50);
            this.BtnCommonPrintSetup.TabIndex = 3;
            this.BtnCommonPrintSetup.UseVisualStyleBackColor = false;
            this.BtnCommonPrintSetup.Click += new System.EventHandler(this.BtnGeneric_Click);
            // 
            // BtnLegacy
            // 
            this.BtnLegacy.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnLegacy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnLegacy.Image = ((System.Drawing.Image)(resources.GetObject("BtnLegacy.Image")));
            this.BtnLegacy.Location = new System.Drawing.Point(219, 29);
            this.BtnLegacy.Name = "BtnLegacy";
            this.BtnLegacy.Size = new System.Drawing.Size(50, 50);
            this.BtnLegacy.TabIndex = 1;
            this.BtnLegacy.UseVisualStyleBackColor = false;
            this.BtnLegacy.Click += new System.EventHandler(this.BtnLegacy_Click);
            // 
            // BtnWin
            // 
            this.BtnWin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnWin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnWin.Image = ((System.Drawing.Image)(resources.GetObject("BtnWin.Image")));
            this.BtnWin.Location = new System.Drawing.Point(23, 29);
            this.BtnWin.Name = "BtnWin";
            this.BtnWin.Size = new System.Drawing.Size(50, 50);
            this.BtnWin.TabIndex = 0;
            this.BtnWin.UseVisualStyleBackColor = false;
            this.BtnWin.Click += new System.EventHandler(this.BtnWin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(68, 159);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 28);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Image = global::StandFacile.Properties.Resources.OK;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(204, 159);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 28);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK  ";
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // PrintConfigLightDlg
            // 
            this.AcceptButton = this.btnCancel;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 206);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrintConfigLightDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurazione Stampanti";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnWin;
        private System.Windows.Forms.Button BtnLegacy;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button BtnCommonPrintSetup;
    }
}