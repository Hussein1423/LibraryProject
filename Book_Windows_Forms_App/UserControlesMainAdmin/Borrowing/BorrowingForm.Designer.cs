namespace Book_Windows_Forms_App.UserControles.Borrowing
{
    partial class BorrowingForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowingForm));
            this.lblBorrowingID = new System.Windows.Forms.Label();
            this.cmbRecipients = new System.Windows.Forms.ComboBox();
            this.cmbBenefits = new System.Windows.Forms.ComboBox();
            this.cmbBooks = new System.Windows.Forms.ComboBox();
            this.dtpBorrowingDate = new System.Windows.Forms.DateTimePicker();
            this.dtpRecoveryDate = new System.Windows.Forms.DateTimePicker();
            this.gabBorrowingConfirm = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBorrowingID
            // 
            this.lblBorrowingID.AutoSize = true;
            this.lblBorrowingID.Location = new System.Drawing.Point(184, 12);
            this.lblBorrowingID.Name = "lblBorrowingID";
            this.lblBorrowingID.Size = new System.Drawing.Size(51, 19);
            this.lblBorrowingID.TabIndex = 0;
            this.lblBorrowingID.Text = "label1";
            // 
            // cmbRecipients
            // 
            this.cmbRecipients.FormattingEnabled = true;
            this.cmbRecipients.Location = new System.Drawing.Point(47, 83);
            this.cmbRecipients.Name = "cmbRecipients";
            this.cmbRecipients.Size = new System.Drawing.Size(121, 27);
            this.cmbRecipients.TabIndex = 1;
            // 
            // cmbBenefits
            // 
            this.cmbBenefits.FormattingEnabled = true;
            this.cmbBenefits.Location = new System.Drawing.Point(188, 83);
            this.cmbBenefits.Name = "cmbBenefits";
            this.cmbBenefits.Size = new System.Drawing.Size(121, 27);
            this.cmbBenefits.TabIndex = 2;
            // 
            // cmbBooks
            // 
            this.cmbBooks.FormattingEnabled = true;
            this.cmbBooks.Location = new System.Drawing.Point(47, 156);
            this.cmbBooks.Name = "cmbBooks";
            this.cmbBooks.Size = new System.Drawing.Size(121, 27);
            this.cmbBooks.TabIndex = 3;
            // 
            // dtpBorrowingDate
            // 
            this.dtpBorrowingDate.Location = new System.Drawing.Point(188, 156);
            this.dtpBorrowingDate.Name = "dtpBorrowingDate";
            this.dtpBorrowingDate.Size = new System.Drawing.Size(200, 27);
            this.dtpBorrowingDate.TabIndex = 4;
            // 
            // dtpRecoveryDate
            // 
            this.dtpRecoveryDate.Location = new System.Drawing.Point(96, 222);
            this.dtpRecoveryDate.Name = "dtpRecoveryDate";
            this.dtpRecoveryDate.Size = new System.Drawing.Size(200, 27);
            this.dtpRecoveryDate.TabIndex = 5;
            // 
            // gabBorrowingConfirm
            // 
            this.gabBorrowingConfirm.AnimationHoverSpeed = 0.07F;
            this.gabBorrowingConfirm.AnimationSpeed = 0.03F;
            this.gabBorrowingConfirm.BackColor = System.Drawing.Color.Transparent;
            this.gabBorrowingConfirm.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(149)))), ((int)(((byte)(85)))));
            this.gabBorrowingConfirm.BorderColor = System.Drawing.Color.Black;
            this.gabBorrowingConfirm.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gabBorrowingConfirm.CheckedBorderColor = System.Drawing.Color.Black;
            this.gabBorrowingConfirm.CheckedForeColor = System.Drawing.Color.White;
            this.gabBorrowingConfirm.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gabBorrowingConfirm.CheckedImage")));
            this.gabBorrowingConfirm.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gabBorrowingConfirm.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gabBorrowingConfirm.FocusedColor = System.Drawing.Color.Empty;
            this.gabBorrowingConfirm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gabBorrowingConfirm.ForeColor = System.Drawing.Color.White;
            this.gabBorrowingConfirm.Image = ((System.Drawing.Image)(resources.GetObject("gabBorrowingConfirm.Image")));
            this.gabBorrowingConfirm.ImageSize = new System.Drawing.Size(20, 20);
            this.gabBorrowingConfirm.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gabBorrowingConfirm.Location = new System.Drawing.Point(106, 283);
            this.gabBorrowingConfirm.Name = "gabBorrowingConfirm";
            this.gabBorrowingConfirm.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(149)))), ((int)(((byte)(85)))));
            this.gabBorrowingConfirm.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gabBorrowingConfirm.OnHoverForeColor = System.Drawing.Color.White;
            this.gabBorrowingConfirm.OnHoverImage = null;
            this.gabBorrowingConfirm.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gabBorrowingConfirm.OnPressedColor = System.Drawing.Color.Black;
            this.gabBorrowingConfirm.Radius = 20;
            this.gabBorrowingConfirm.Size = new System.Drawing.Size(180, 42);
            this.gabBorrowingConfirm.TabIndex = 6;
            this.gabBorrowingConfirm.Text = "تأكيد";
            this.gabBorrowingConfirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gabBorrowingConfirm.Click += new System.EventHandler(this.gabBorrowingConfirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Recipient";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Benefit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "ID_Book";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Borrowing_Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Recovery_Date";
            // 
            // BorrowingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gabBorrowingConfirm);
            this.Controls.Add(this.dtpRecoveryDate);
            this.Controls.Add(this.dtpBorrowingDate);
            this.Controls.Add(this.cmbBooks);
            this.Controls.Add(this.cmbBenefits);
            this.Controls.Add(this.cmbRecipients);
            this.Controls.Add(this.lblBorrowingID);
            this.Name = "BorrowingForm";
            this.Size = new System.Drawing.Size(416, 375);
            this.Load += new System.EventHandler(this.BorrowingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBorrowingID;
        private System.Windows.Forms.ComboBox cmbRecipients;
        private System.Windows.Forms.ComboBox cmbBenefits;
        private System.Windows.Forms.ComboBox cmbBooks;
        private System.Windows.Forms.DateTimePicker dtpBorrowingDate;
        private System.Windows.Forms.DateTimePicker dtpRecoveryDate;
        private Guna.UI.WinForms.GunaAdvenceButton gabBorrowingConfirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}
