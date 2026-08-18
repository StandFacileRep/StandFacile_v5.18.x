namespace StandFacile
{
    partial class ViewOrdersDlg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewOrdersDlg));
            this.textEdit_Ticket = new System.Windows.Forms.TextBox();
            this.VisTicketStatusBar = new System.Windows.Forms.StatusStrip();
            this.VO_toolStripNumTicket = new System.Windows.Forms.ToolStripStatusLabel();
            this.VO_toolStripTotalOrders = new System.Windows.Forms.ToolStripStatusLabel();
            this.VO_toolStripCashDesk = new System.Windows.Forms.ToolStripStatusLabel();
            this.VO_ckBoxAllCashDesk = new System.Windows.Forms.CheckBox();
            this.OKBtn = new System.Windows.Forms.Button();
            this.VO_btnCancel = new System.Windows.Forms.Button();
            this.BtnPrev = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnPrt = new System.Windows.Forms.Button();
            this.VO_labelPrint = new System.Windows.Forms.Label();
            this.VO_comboPaymentType = new System.Windows.Forms.ComboBox();
            this.VO_labelPayMethod = new System.Windows.Forms.Label();
            this.VO_checkBoxNotPaid = new System.Windows.Forms.CheckBox();
            this.VO_lbl_Info = new System.Windows.Forms.Label();
            this.VO_labelBrowse = new System.Windows.Forms.Label();
            this.VisTicketStatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // textEdit_Ticket
            // 
            this.textEdit_Ticket.BackColor = System.Drawing.Color.Teal;
            this.textEdit_Ticket.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit_Ticket.ForeColor = System.Drawing.SystemColors.Window;
            this.textEdit_Ticket.Location = new System.Drawing.Point(12, 12);
            this.textEdit_Ticket.Multiline = true;
            this.textEdit_Ticket.Name = "textEdit_Ticket";
            this.textEdit_Ticket.ReadOnly = true;
            this.textEdit_Ticket.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textEdit_Ticket.Size = new System.Drawing.Size(376, 409);
            this.textEdit_Ticket.TabIndex = 1;
            // 
            // VisTicketStatusBar
            // 
            this.VisTicketStatusBar.AutoSize = false;
            this.VisTicketStatusBar.Dock = System.Windows.Forms.DockStyle.None;
            this.VisTicketStatusBar.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.VisTicketStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VO_toolStripNumTicket,
            this.VO_toolStripTotalOrders,
            this.VO_toolStripCashDesk});
            this.VisTicketStatusBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.VisTicketStatusBar.Location = new System.Drawing.Point(13, 424);
            this.VisTicketStatusBar.Name = "VisTicketStatusBar";
            this.VisTicketStatusBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.VisTicketStatusBar.Size = new System.Drawing.Size(375, 22);
            this.VisTicketStatusBar.SizingGrip = false;
            this.VisTicketStatusBar.Stretch = false;
            this.VisTicketStatusBar.TabIndex = 8;
            // 
            // VO_toolStripNumTicket
            // 
            this.VO_toolStripNumTicket.AutoSize = false;
            this.VO_toolStripNumTicket.Name = "VO_toolStripNumTicket";
            this.VO_toolStripNumTicket.Size = new System.Drawing.Size(120, 17);
            this.VO_toolStripNumTicket.Text = "Scontrino : 100";
            this.VO_toolStripNumTicket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // VO_toolStripTotalOrders
            // 
            this.VO_toolStripTotalOrders.AutoSize = false;
            this.VO_toolStripTotalOrders.Name = "VO_toolStripTotalOrders";
            this.VO_toolStripTotalOrders.Size = new System.Drawing.Size(80, 17);
            this.VO_toolStripTotalOrders.Text = "Totali : 100";
            this.VO_toolStripTotalOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // VO_toolStripCashDesk
            // 
            this.VO_toolStripCashDesk.AutoSize = false;
            this.VO_toolStripCashDesk.Name = "VO_toolStripCashDesk";
            this.VO_toolStripCashDesk.Size = new System.Drawing.Size(140, 17);
            this.VO_toolStripCashDesk.Text = "Cassa n.1  Principale";
            this.VO_toolStripCashDesk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // VO_ckBoxAllCashDesk
            // 
            this.VO_ckBoxAllCashDesk.AutoSize = true;
            this.VO_ckBoxAllCashDesk.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VO_ckBoxAllCashDesk.Location = new System.Drawing.Point(21, 482);
            this.VO_ckBoxAllCashDesk.Name = "VO_ckBoxAllCashDesk";
            this.VO_ckBoxAllCashDesk.Size = new System.Drawing.Size(129, 18);
            this.VO_ckBoxAllCashDesk.TabIndex = 2;
            this.VO_ckBoxAllCashDesk.Text = "Vedi tutte le casse";
            this.VO_ckBoxAllCashDesk.UseVisualStyleBackColor = true;
            this.VO_ckBoxAllCashDesk.Click += new System.EventHandler(this.VO_ckBoxAllCashDesk_Click);
            // 
            // OKBtn
            // 
            this.OKBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKBtn.Image = global::StandFacile.Properties.Resources.OK;
            this.OKBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OKBtn.Location = new System.Drawing.Point(303, 546);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(70, 35);
            this.OKBtn.TabIndex = 3;
            this.OKBtn.Text = "OK  ";
            this.OKBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OKBtn.UseVisualStyleBackColor = true;
            // 
            // VO_btnCancel
            // 
            this.VO_btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("VO_btnCancel.Image")));
            this.VO_btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.VO_btnCancel.Location = new System.Drawing.Point(21, 545);
            this.VO_btnCancel.Name = "VO_btnCancel";
            this.VO_btnCancel.Size = new System.Drawing.Size(113, 35);
            this.VO_btnCancel.TabIndex = 4;
            this.VO_btnCancel.Text = " annullo Ordine";
            this.VO_btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.VO_btnCancel.UseVisualStyleBackColor = true;
            this.VO_btnCancel.Click += new System.EventHandler(this.VO_btnCancel_Click);
            // 
            // BtnPrev
            // 
            this.BtnPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnPrev.Image = global::StandFacile.Properties.Resources.ArrowSLeft;
            this.BtnPrev.Location = new System.Drawing.Point(206, 477);
            this.BtnPrev.Name = "BtnPrev";
            this.BtnPrev.Size = new System.Drawing.Size(70, 35);
            this.BtnPrev.TabIndex = 5;
            this.BtnPrev.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnPrev.UseVisualStyleBackColor = true;
            this.BtnPrev.Click += new System.EventHandler(this.PrevBtn_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnNext.Image = global::StandFacile.Properties.Resources.ArrowSRight;
            this.BtnNext.Location = new System.Drawing.Point(303, 477);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(70, 35);
            this.BtnNext.TabIndex = 6;
            this.BtnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // BtnPrt
            // 
            this.BtnPrt.Image = global::StandFacile.Properties.Resources.printer_s;
            this.BtnPrt.Location = new System.Drawing.Point(206, 546);
            this.BtnPrt.Name = "BtnPrt";
            this.BtnPrt.Size = new System.Drawing.Size(70, 35);
            this.BtnPrt.TabIndex = 7;
            this.BtnPrt.UseVisualStyleBackColor = true;
            this.BtnPrt.Click += new System.EventHandler(this.BtnPrt_Click);
            // 
            // VO_labelPrint
            // 
            this.VO_labelPrint.AutoSize = true;
            this.VO_labelPrint.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VO_labelPrint.Location = new System.Drawing.Point(193, 524);
            this.VO_labelPrint.Name = "VO_labelPrint";
            this.VO_labelPrint.Size = new System.Drawing.Size(110, 13);
            this.VO_labelPrint.TabIndex = 9;
            this.VO_labelPrint.Text = "stampa tutto in locale";
            // 
            // VO_comboPaymentType
            // 
            this.VO_comboPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VO_comboPaymentType.FormattingEnabled = true;
            this.VO_comboPaymentType.ItemHeight = 13;
            this.VO_comboPaymentType.Items.AddRange(new object[] {
            "CONTANTI",
            "CARD",
            "SATYSPAY",
            "   "});
            this.VO_comboPaymentType.Location = new System.Drawing.Point(21, 517);
            this.VO_comboPaymentType.Name = "VO_comboPaymentType";
            this.VO_comboPaymentType.Size = new System.Drawing.Size(113, 21);
            this.VO_comboPaymentType.TabIndex = 25;
            this.VO_comboPaymentType.SelectedIndexChanged += new System.EventHandler(this.ComboCashPos_SelectedIndexChanged);
            // 
            // VO_labelPayMethod
            // 
            this.VO_labelPayMethod.AutoSize = true;
            this.VO_labelPayMethod.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VO_labelPayMethod.Location = new System.Drawing.Point(18, 501);
            this.VO_labelPayMethod.Name = "VO_labelPayMethod";
            this.VO_labelPayMethod.Size = new System.Drawing.Size(147, 13);
            this.VO_labelPayMethod.TabIndex = 26;
            this.VO_labelPayMethod.Text = "cambia metodo di pagamento";
            // 
            // VO_checkBoxNotPaid
            // 
            this.VO_checkBoxNotPaid.AutoSize = true;
            this.VO_checkBoxNotPaid.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VO_checkBoxNotPaid.Location = new System.Drawing.Point(21, 457);
            this.VO_checkBoxNotPaid.Name = "VO_checkBoxNotPaid";
            this.VO_checkBoxNotPaid.Size = new System.Drawing.Size(154, 18);
            this.VO_checkBoxNotPaid.TabIndex = 27;
            this.VO_checkBoxNotPaid.Text = "filtra pag. da effettuare";
            this.VO_checkBoxNotPaid.UseVisualStyleBackColor = true;
            // 
            // VO_lbl_Info
            // 
            this.VO_lbl_Info.BackColor = System.Drawing.Color.MediumAquamarine;
            this.VO_lbl_Info.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VO_lbl_Info.Location = new System.Drawing.Point(34, 525);
            this.VO_lbl_Info.Name = "VO_lbl_Info";
            this.VO_lbl_Info.Padding = new System.Windows.Forms.Padding(2);
            this.VO_lbl_Info.Size = new System.Drawing.Size(88, 20);
            this.VO_lbl_Info.TabIndex = 28;
            this.VO_lbl_Info.Text = "  info colori ?  ";
            this.VO_lbl_Info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.VO_lbl_Info.Click += new System.EventHandler(this.Lbl_Info_Click);
            // 
            // VO_labelBrowse
            // 
            this.VO_labelBrowse.AutoSize = true;
            this.VO_labelBrowse.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VO_labelBrowse.Location = new System.Drawing.Point(208, 457);
            this.VO_labelBrowse.Name = "VO_labelBrowse";
            this.VO_labelBrowse.Size = new System.Drawing.Size(165, 13);
            this.VO_labelBrowse.TabIndex = 29;
            this.VO_labelBrowse.Text = "usare anche frecce, PgUp, PgDw";
            // 
            // ViewOrdersDlg
            // 
            this.AcceptButton = this.OKBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 594);
            this.Controls.Add(this.VO_labelBrowse);
            this.Controls.Add(this.VO_lbl_Info);
            this.Controls.Add(this.VO_checkBoxNotPaid);
            this.Controls.Add(this.VO_labelPayMethod);
            this.Controls.Add(this.VO_comboPaymentType);
            this.Controls.Add(this.VO_labelPrint);
            this.Controls.Add(this.VO_btnCancel);
            this.Controls.Add(this.VO_ckBoxAllCashDesk);
            this.Controls.Add(this.VisTicketStatusBar);
            this.Controls.Add(this.BtnPrev);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.BtnPrt);
            this.Controls.Add(this.textEdit_Ticket);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewOrdersDlg";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Visualizza Ordini";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VisOrdiniDlg_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.VisTicketsDlg_KeyDown);
            this.VisTicketStatusBar.ResumeLayout(false);
            this.VisTicketStatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textEdit_Ticket;
        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.Button BtnPrt;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnPrev;
        private System.Windows.Forms.StatusStrip VisTicketStatusBar;
        private System.Windows.Forms.ToolStripStatusLabel VO_toolStripNumTicket;
        private System.Windows.Forms.ToolStripStatusLabel VO_toolStripTotalOrders;
        private System.Windows.Forms.ToolStripStatusLabel VO_toolStripCashDesk;
        private System.Windows.Forms.CheckBox VO_ckBoxAllCashDesk;
        private System.Windows.Forms.Button VO_btnCancel;
        private System.Windows.Forms.Label VO_labelPrint;
        private System.Windows.Forms.ComboBox VO_comboPaymentType;
        private System.Windows.Forms.Label VO_labelPayMethod;
        private System.Windows.Forms.CheckBox VO_checkBoxNotPaid;
        private System.Windows.Forms.Label VO_lbl_Info;
        private System.Windows.Forms.Label VO_labelBrowse;
    }
}