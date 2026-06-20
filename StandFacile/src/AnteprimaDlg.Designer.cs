namespace StandFacile
{
    partial class AnteprimaDlg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnteprimaDlg));
            this.panel = new System.Windows.Forms.Panel();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.checkBoxLogoPreview = new System.Windows.Forms.CheckBox();
            this.checkBox_PrimoPiano = new System.Windows.Forms.CheckBox();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.AutoScroll = true;
            this.panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel.Controls.Add(this.picBox);
            this.panel.Location = new System.Drawing.Point(11, 14);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(389, 479);
            this.panel.TabIndex = 1;
            // 
            // picBox
            // 
            this.picBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBox.BackColor = System.Drawing.Color.White;
            this.picBox.Location = new System.Drawing.Point(1, -2);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(368, 481);
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            this.picBox.Paint += new System.Windows.Forms.PaintEventHandler(this.picBox_Paint);
            // 
            // checkBoxLogoPreview
            // 
            this.checkBoxLogoPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxLogoPreview.AutoSize = true;
            this.checkBoxLogoPreview.Checked = true;
            this.checkBoxLogoPreview.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLogoPreview.Location = new System.Drawing.Point(40, 516);
            this.checkBoxLogoPreview.Name = "checkBoxLogoPreview";
            this.checkBoxLogoPreview.Size = new System.Drawing.Size(101, 17);
            this.checkBoxLogoPreview.TabIndex = 2;
            this.checkBoxLogoPreview.Text = "visualizza il logo";
            this.checkBoxLogoPreview.UseVisualStyleBackColor = true;
            this.checkBoxLogoPreview.CheckedChanged += new System.EventHandler(this.CheckBoxLogo_CheckedChanged);
            // 
            // checkBox_PrimoPiano
            // 
            this.checkBox_PrimoPiano.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox_PrimoPiano.AutoSize = true;
            this.checkBox_PrimoPiano.Checked = true;
            this.checkBox_PrimoPiano.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_PrimoPiano.Location = new System.Drawing.Point(176, 516);
            this.checkBox_PrimoPiano.Name = "checkBox_PrimoPiano";
            this.checkBox_PrimoPiano.Size = new System.Drawing.Size(91, 17);
            this.checkBox_PrimoPiano.TabIndex = 3;
            this.checkBox_PrimoPiano.Text = "in primo piano";
            this.checkBox_PrimoPiano.UseVisualStyleBackColor = true;
            this.checkBox_PrimoPiano.CheckedChanged += new System.EventHandler(this.checkBox_PrimoPiano_CheckedChanged);
            // 
            // AnteprimaDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(412, 550);
            this.Controls.Add(this.checkBox_PrimoPiano);
            this.Controls.Add(this.checkBoxLogoPreview);
            this.Controls.Add(this.panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AnteprimaDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Anteprima Scontrino";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnteprimaDlg_FormClosing);
            this.Resize += new System.EventHandler(this.AnteprimaDlg_Resize);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBoxLogoPreview;
        private System.Windows.Forms.CheckBox checkBox_PrimoPiano;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Panel panel;
    }
}