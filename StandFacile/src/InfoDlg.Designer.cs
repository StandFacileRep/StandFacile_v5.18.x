namespace StandFacile
{
    partial class InfoDlg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoDlg));
            this.textBox = new System.Windows.Forms.TextBox();
            this.GI_lblTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.GI_lblSW_Rel = new System.Windows.Forms.Label();
            this.ImageLic = new System.Windows.Forms.PictureBox();
            this.ProgramIcon = new System.Windows.Forms.PictureBox();
            this.GI_LinkLbl_Web = new System.Windows.Forms.LinkLabel();
            this.GI_lbl_DB = new System.Windows.Forms.Label();
            this.GI_lbl_Printer = new System.Windows.Forms.Label();
            this.GI_dll_Ver = new System.Windows.Forms.Label();
            this.GI_LinkLbl_mail = new System.Windows.Forms.LinkLabel();
            this.ImageDona = new System.Windows.Forms.PictureBox();
            this.GI_lblDB_Rel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImageLic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgramIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageDona)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(14, 153);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(543, 264);
            this.textBox.TabIndex = 7;
            this.textBox.TabStop = false;
            this.textBox.Text = resources.GetString("textBox.Text");
            // 
            // GI_lblTitle
            // 
            this.GI_lblTitle.AutoSize = true;
            this.GI_lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GI_lblTitle.Location = new System.Drawing.Point(94, 12);
            this.GI_lblTitle.Name = "GI_lblTitle";
            this.GI_lblTitle.Size = new System.Drawing.Size(88, 16);
            this.GI_lblTitle.TabIndex = 2;
            this.GI_lblTitle.Text = "StandFacile...";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(94, 35);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(131, 16);
            this.lblAuthor.TabIndex = 4;
            this.lblAuthor.Text = "Autore: Mauro Artuso";
            // 
            // GI_lblRel
            // 
            this.GI_lblSW_Rel.AutoSize = true;
            this.GI_lblSW_Rel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GI_lblSW_Rel.Location = new System.Drawing.Point(216, 12);
            this.GI_lblSW_Rel.Name = "GI_lblRel";
            this.GI_lblSW_Rel.Size = new System.Drawing.Size(68, 16);
            this.GI_lblSW_Rel.TabIndex = 3;
            this.GI_lblSW_Rel.Text = "Release...";
            // 
            // ImageLic
            // 
            this.ImageLic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ImageLic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImageLic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImageLic.ErrorImage = global::StandFacile.Properties.Resources.paypal_dona;
            this.ImageLic.Image = global::StandFacile.Properties.Resources.gplv3_84x42;
            this.ImageLic.Location = new System.Drawing.Point(52, 433);
            this.ImageLic.Margin = new System.Windows.Forms.Padding(0);
            this.ImageLic.Name = "ImageLic";
            this.ImageLic.Size = new System.Drawing.Size(86, 44);
            this.ImageLic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ImageLic.TabIndex = 6;
            this.ImageLic.TabStop = false;
            this.ImageLic.Click += new System.EventHandler(this.ImageLic_Click);
            // 
            // ProgramIcon
            // 
            this.ProgramIcon.Image = global::StandFacile.Properties.Resources.Spaghetti;
            this.ProgramIcon.Location = new System.Drawing.Point(24, 12);
            this.ProgramIcon.Margin = new System.Windows.Forms.Padding(0);
            this.ProgramIcon.Name = "ProgramIcon";
            this.ProgramIcon.Size = new System.Drawing.Size(32, 29);
            this.ProgramIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ProgramIcon.TabIndex = 4;
            this.ProgramIcon.TabStop = false;
            // 
            // GI_LinkLbl_Web
            // 
            this.GI_LinkLbl_Web.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GI_LinkLbl_Web.AutoSize = true;
            this.GI_LinkLbl_Web.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GI_LinkLbl_Web.Location = new System.Drawing.Point(319, 464);
            this.GI_LinkLbl_Web.Name = "GI_LinkLbl_Web";
            this.GI_LinkLbl_Web.Size = new System.Drawing.Size(117, 17);
            this.GI_LinkLbl_Web.TabIndex = 1;
            this.GI_LinkLbl_Web.TabStop = true;
            this.GI_LinkLbl_Web.Text = "www.standfacile...";
            this.GI_LinkLbl_Web.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLbl_Web_LinkClicked);
            // 
            // GI_lbl_DB
            // 
            this.GI_lbl_DB.AutoSize = true;
            this.GI_lbl_DB.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GI_lbl_DB.Location = new System.Drawing.Point(94, 71);
            this.GI_lbl_DB.Name = "GI_lbl_DB";
            this.GI_lbl_DB.Size = new System.Drawing.Size(67, 16);
            this.GI_lbl_DB.TabIndex = 5;
            this.GI_lbl_DB.Text = "DB server:";
            // 
            // GI_lbl_Printer
            // 
            this.GI_lbl_Printer.AutoSize = true;
            this.GI_lbl_Printer.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.GI_lbl_Printer.Location = new System.Drawing.Point(94, 123);
            this.GI_lbl_Printer.Name = "GI_lbl_Printer";
            this.GI_lbl_Printer.Size = new System.Drawing.Size(78, 16);
            this.GI_lbl_Printer.TabIndex = 6;
            this.GI_lbl_Printer.Text = "Stampante :";
            // 
            // GI_dll_Ver
            // 
            this.GI_dll_Ver.AutoSize = true;
            this.GI_dll_Ver.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GI_dll_Ver.Location = new System.Drawing.Point(94, 98);
            this.GI_dll_Ver.Name = "GI_dll_Ver";
            this.GI_dll_Ver.Size = new System.Drawing.Size(89, 16);
            this.GI_dll_Ver.TabIndex = 8;
            this.GI_dll_Ver.Text = "DB dll version:";
            // 
            // GI_LinkLbl_mail
            // 
            this.GI_LinkLbl_mail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GI_LinkLbl_mail.AutoSize = true;
            this.GI_LinkLbl_mail.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GI_LinkLbl_mail.Location = new System.Drawing.Point(319, 439);
            this.GI_LinkLbl_mail.Name = "GI_LinkLbl_mail";
            this.GI_LinkLbl_mail.Size = new System.Drawing.Size(118, 17);
            this.GI_LinkLbl_mail.TabIndex = 9;
            this.GI_LinkLbl_mail.TabStop = true;
            this.GI_LinkLbl_mail.Text = "info@standfacile...";
            this.GI_LinkLbl_mail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLbl_mail_LinkClicked);
            // 
            // ImageDona
            // 
            this.ImageDona.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ImageDona.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImageDona.Image = global::StandFacile.Properties.Resources.paypal_dona;
            this.ImageDona.Location = new System.Drawing.Point(171, 433);
            this.ImageDona.Margin = new System.Windows.Forms.Padding(0);
            this.ImageDona.Name = "ImageDona";
            this.ImageDona.Size = new System.Drawing.Size(136, 44);
            this.ImageDona.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ImageDona.TabIndex = 10;
            this.ImageDona.TabStop = false;
            this.ImageDona.Click += new System.EventHandler(this.ImageDona_Click);
            // 
            // GI_lblDB_Rel
            // 
            this.GI_lblDB_Rel.AutoSize = true;
            this.GI_lblDB_Rel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GI_lblDB_Rel.Location = new System.Drawing.Point(333, 12);
            this.GI_lblDB_Rel.Name = "GI_lblDB_Rel";
            this.GI_lblDB_Rel.Size = new System.Drawing.Size(72, 16);
            this.GI_lblDB_Rel.TabIndex = 12;
            this.GI_lblDB_Rel.Text = "db tables...";
            // 
            // InfoDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 491);
            this.Controls.Add(this.GI_lblDB_Rel);
            this.Controls.Add(this.ImageDona);
            this.Controls.Add(this.GI_LinkLbl_mail);
            this.Controls.Add(this.GI_dll_Ver);
            this.Controls.Add(this.GI_lbl_Printer);
            this.Controls.Add(this.GI_lbl_DB);
            this.Controls.Add(this.GI_LinkLbl_Web);
            this.Controls.Add(this.ImageLic);
            this.Controls.Add(this.ProgramIcon);
            this.Controls.Add(this.GI_lblSW_Rel);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.GI_lblTitle);
            this.Controls.Add(this.textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InfoDlg";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Informazioni";
            ((System.ComponentModel.ISupportInitialize)(this.ImageLic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgramIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageDona)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label GI_lblTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label GI_lblSW_Rel;
        private System.Windows.Forms.PictureBox ProgramIcon;
        private System.Windows.Forms.PictureBox ImageLic;
        private System.Windows.Forms.LinkLabel GI_LinkLbl_Web;
        private System.Windows.Forms.Label GI_lbl_DB;
        private System.Windows.Forms.Label GI_lbl_Printer;
        private System.Windows.Forms.Label GI_dll_Ver;
        private System.Windows.Forms.LinkLabel GI_LinkLbl_mail;
        private System.Windows.Forms.PictureBox ImageDona;
        private System.Windows.Forms.Label GI_lblDB_Rel;
    }
}