namespace StandFacile
{
    partial class VisMessaggiDlg
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
            this.textEdit_Messaggi = new System.Windows.Forms.TextBox();
            this.BtnPrev = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.VisTicketStatusBar = new System.Windows.Forms.StatusStrip();
            this.VM_toolStripMsgNum = new System.Windows.Forms.ToolStripStatusLabel();
            this.VM_toolStripTotalMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.VM_toolStripCashNum = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnExit = new System.Windows.Forms.Button();
            this.VM_lblRemChar = new System.Windows.Forms.Label();
            this.VM_ckBoxAllCashDesk = new System.Windows.Forms.CheckBox();
            this.BtnPrintMsg = new System.Windows.Forms.Button();
            this.PrintersListCombo = new System.Windows.Forms.ComboBox();
            this.checkBox_escpos = new System.Windows.Forms.CheckBox();
            this.VisTicketStatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // textEdit_Messaggi
            // 
            this.textEdit_Messaggi.AcceptsReturn = true;
            this.textEdit_Messaggi.AcceptsTab = true;
            this.textEdit_Messaggi.BackColor = System.Drawing.Color.Teal;
            this.textEdit_Messaggi.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit_Messaggi.ForeColor = System.Drawing.SystemColors.Window;
            this.textEdit_Messaggi.Location = new System.Drawing.Point(12, 47);
            this.textEdit_Messaggi.Multiline = true;
            this.textEdit_Messaggi.Name = "textEdit_Messaggi";
            this.textEdit_Messaggi.ReadOnly = true;
            this.textEdit_Messaggi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textEdit_Messaggi.Size = new System.Drawing.Size(368, 269);
            this.textEdit_Messaggi.TabIndex = 3;
            this.textEdit_Messaggi.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextEdit_Messaggi_KeyUp);
            // 
            // BtnPrev
            // 
            this.BtnPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnPrev.Image = global::StandFacile.Properties.Resources.ArrowSLeft;
            this.BtnPrev.Location = new System.Drawing.Point(187, 360);
            this.BtnPrev.Name = "BtnPrev";
            this.BtnPrev.Size = new System.Drawing.Size(70, 30);
            this.BtnPrev.TabIndex = 4;
            this.BtnPrev.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnPrev.UseVisualStyleBackColor = true;
            this.BtnPrev.Click += new System.EventHandler(this.PrevBtn_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnNext.Image = global::StandFacile.Properties.Resources.ArrowSRight;
            this.BtnNext.Location = new System.Drawing.Point(295, 360);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(70, 30);
            this.BtnNext.TabIndex = 5;
            this.BtnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // btnSend
            // 
            this.btnSend.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSend.Image = global::StandFacile.Properties.Resources.OK;
            this.btnSend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSend.Location = new System.Drawing.Point(295, 486);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(70, 30);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Invia";
            this.btnSend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // VisTicketStatusBar
            // 
            this.VisTicketStatusBar.AutoSize = false;
            this.VisTicketStatusBar.Dock = System.Windows.Forms.DockStyle.None;
            this.VisTicketStatusBar.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VisTicketStatusBar.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.VisTicketStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VM_toolStripMsgNum,
            this.VM_toolStripTotalMsg,
            this.VM_toolStripCashNum});
            this.VisTicketStatusBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.VisTicketStatusBar.Location = new System.Drawing.Point(12, 329);
            this.VisTicketStatusBar.Name = "VisTicketStatusBar";
            this.VisTicketStatusBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.VisTicketStatusBar.Size = new System.Drawing.Size(368, 22);
            this.VisTicketStatusBar.SizingGrip = false;
            this.VisTicketStatusBar.Stretch = false;
            this.VisTicketStatusBar.TabIndex = 6;
            // 
            // VM_toolStripMsgNum
            // 
            this.VM_toolStripMsgNum.AutoSize = false;
            this.VM_toolStripMsgNum.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VM_toolStripMsgNum.Name = "VM_toolStripMsgNum";
            this.VM_toolStripMsgNum.Size = new System.Drawing.Size(120, 17);
            this.VM_toolStripMsgNum.Text = "Scontrino : 100";
            this.VM_toolStripMsgNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // VM_toolStripTotalMsg
            // 
            this.VM_toolStripTotalMsg.AutoSize = false;
            this.VM_toolStripTotalMsg.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VM_toolStripTotalMsg.Name = "VM_toolStripTotalMsg";
            this.VM_toolStripTotalMsg.Size = new System.Drawing.Size(80, 17);
            this.VM_toolStripTotalMsg.Text = "Totali : 100";
            this.VM_toolStripTotalMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // VM_toolStripCashNum
            // 
            this.VM_toolStripCashNum.AutoSize = false;
            this.VM_toolStripCashNum.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VM_toolStripCashNum.Name = "VM_toolStripCashNum";
            this.VM_toolStripCashNum.Size = new System.Drawing.Size(140, 17);
            this.VM_toolStripCashNum.Text = "Cassa n.1  Principale";
            this.VM_toolStripCashNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Image = global::StandFacile.Properties.Resources.Cancel;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(30, 486);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(70, 30);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Esci";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // VM_lblRemChar
            // 
            this.VM_lblRemChar.AutoSize = true;
            this.VM_lblRemChar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VM_lblRemChar.Location = new System.Drawing.Point(17, 21);
            this.VM_lblRemChar.Name = "VM_lblRemChar";
            this.VM_lblRemChar.Size = new System.Drawing.Size(115, 14);
            this.VM_lblRemChar.TabIndex = 2;
            this.VM_lblRemChar.Text = "Caratteri rimanenti :";
            // 
            // VM_ckBoxAllCashDesk
            // 
            this.VM_ckBoxAllCashDesk.AutoSize = true;
            this.VM_ckBoxAllCashDesk.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VM_ckBoxAllCashDesk.Location = new System.Drawing.Point(30, 367);
            this.VM_ckBoxAllCashDesk.Name = "VM_ckBoxAllCashDesk";
            this.VM_ckBoxAllCashDesk.Size = new System.Drawing.Size(129, 18);
            this.VM_ckBoxAllCashDesk.TabIndex = 7;
            this.VM_ckBoxAllCashDesk.Text = "Vedi tutte le casse";
            this.VM_ckBoxAllCashDesk.UseVisualStyleBackColor = true;
            // 
            // BtnPrintMsg
            // 
            this.BtnPrintMsg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnPrintMsg.Image = global::StandFacile.Properties.Resources.printer_s;
            this.BtnPrintMsg.Location = new System.Drawing.Point(187, 472);
            this.BtnPrintMsg.Name = "BtnPrintMsg";
            this.BtnPrintMsg.Size = new System.Drawing.Size(54, 44);
            this.BtnPrintMsg.TabIndex = 20;
            this.BtnPrintMsg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnPrintMsg.UseVisualStyleBackColor = true;
            this.BtnPrintMsg.Click += new System.EventHandler(this.BtnPrintMsg_Click);
            // 
            // PrintersListCombo
            // 
            this.PrintersListCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PrintersListCombo.FormattingEnabled = true;
            this.PrintersListCombo.Location = new System.Drawing.Point(30, 433);
            this.PrintersListCombo.Name = "PrintersListCombo";
            this.PrintersListCombo.Size = new System.Drawing.Size(211, 21);
            this.PrintersListCombo.TabIndex = 21;
            // 
            // checkBox_escpos
            // 
            this.checkBox_escpos.AutoCheck = false;
            this.checkBox_escpos.AutoSize = true;
            this.checkBox_escpos.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_escpos.Location = new System.Drawing.Point(30, 400);
            this.checkBox_escpos.Name = "checkBox_escpos";
            this.checkBox_escpos.Padding = new System.Windows.Forms.Padding(1);
            this.checkBox_escpos.Size = new System.Drawing.Size(256, 20);
            this.checkBox_escpos.TabIndex = 84;
            this.checkBox_escpos.Text = "utilizza la stampa con protocollo ESC/POS ";
            this.checkBox_escpos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_escpos.UseVisualStyleBackColor = true;
            // 
            // VisMessaggiDlg
            // 
            this.AcceptButton = this.btnExit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 537);
            this.Controls.Add(this.checkBox_escpos);
            this.Controls.Add(this.PrintersListCombo);
            this.Controls.Add(this.BtnPrintMsg);
            this.Controls.Add(this.VM_ckBoxAllCashDesk);
            this.Controls.Add(this.VM_lblRemChar);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.VisTicketStatusBar);
            this.Controls.Add(this.BtnPrev);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.textEdit_Messaggi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VisMessaggiDlg";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Messaggio inviato mediante stampa o StandCucina";
            this.Shown += new System.EventHandler(this.VisMessaggiDlg_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.VisTicketsDlg_KeyDown);
            this.VisTicketStatusBar.ResumeLayout(false);
            this.VisTicketStatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textEdit_Messaggi;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnPrev;
        private System.Windows.Forms.StatusStrip VisTicketStatusBar;
        private System.Windows.Forms.ToolStripStatusLabel VM_toolStripMsgNum;
        private System.Windows.Forms.ToolStripStatusLabel VM_toolStripTotalMsg;
        private System.Windows.Forms.ToolStripStatusLabel VM_toolStripCashNum;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label VM_lblRemChar;
        private System.Windows.Forms.CheckBox VM_ckBoxAllCashDesk;
        private System.Windows.Forms.Button BtnPrintMsg;
        private System.Windows.Forms.ComboBox PrintersListCombo;
        private System.Windows.Forms.CheckBox checkBox_escpos;
    }
}