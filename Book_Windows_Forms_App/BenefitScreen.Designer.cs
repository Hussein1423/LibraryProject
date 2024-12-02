namespace Book_Windows_Forms_App
{
    partial class BenefitScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BenefitScreen));
            this.glblGreeting = new Guna.UI.WinForms.GunaLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gabRequests = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gabBooks = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gabBorrowings = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gabExit = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // glblGreeting
            // 
            this.glblGreeting.AutoSize = true;
            this.glblGreeting.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.glblGreeting.Location = new System.Drawing.Point(14, 18);
            this.glblGreeting.Name = "glblGreeting";
            this.glblGreeting.Size = new System.Drawing.Size(103, 25);
            this.glblGreeting.TabIndex = 0;
            this.glblGreeting.Text = "gunaLabel1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gabExit);
            this.panel1.Controls.Add(this.gabRequests);
            this.panel1.Controls.Add(this.gabBooks);
            this.panel1.Controls.Add(this.gabBorrowings);
            this.panel1.Controls.Add(this.glblGreeting);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 452);
            this.panel1.TabIndex = 1;
            // 
            // gabRequests
            // 
            this.gabRequests.AnimationHoverSpeed = 0.07F;
            this.gabRequests.AnimationSpeed = 0.03F;
            this.gabRequests.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(149)))), ((int)(((byte)(85)))));
            this.gabRequests.BorderColor = System.Drawing.Color.Black;
            this.gabRequests.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gabRequests.CheckedBorderColor = System.Drawing.Color.Black;
            this.gabRequests.CheckedForeColor = System.Drawing.Color.White;
            this.gabRequests.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gabRequests.CheckedImage")));
            this.gabRequests.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gabRequests.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gabRequests.FocusedColor = System.Drawing.Color.Empty;
            this.gabRequests.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gabRequests.ForeColor = System.Drawing.Color.White;
            this.gabRequests.Image = ((System.Drawing.Image)(resources.GetObject("gabRequests.Image")));
            this.gabRequests.ImageSize = new System.Drawing.Size(40, 40);
            this.gabRequests.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gabRequests.Location = new System.Drawing.Point(19, 256);
            this.gabRequests.Name = "gabRequests";
            this.gabRequests.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(149)))), ((int)(((byte)(85)))));
            this.gabRequests.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gabRequests.OnHoverForeColor = System.Drawing.Color.White;
            this.gabRequests.OnHoverImage = null;
            this.gabRequests.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gabRequests.OnPressedColor = System.Drawing.Color.Black;
            this.gabRequests.Size = new System.Drawing.Size(225, 42);
            this.gabRequests.TabIndex = 3;
            this.gabRequests.Text = "طلباتي";
            this.gabRequests.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gabRequests.Click += new System.EventHandler(this.gabRequests_Click);
            // 
            // gabBooks
            // 
            this.gabBooks.AnimationHoverSpeed = 0.07F;
            this.gabBooks.AnimationSpeed = 0.03F;
            this.gabBooks.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(149)))), ((int)(((byte)(85)))));
            this.gabBooks.BorderColor = System.Drawing.Color.Black;
            this.gabBooks.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gabBooks.CheckedBorderColor = System.Drawing.Color.Black;
            this.gabBooks.CheckedForeColor = System.Drawing.Color.White;
            this.gabBooks.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gabBooks.CheckedImage")));
            this.gabBooks.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gabBooks.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gabBooks.FocusedColor = System.Drawing.Color.Empty;
            this.gabBooks.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gabBooks.ForeColor = System.Drawing.Color.White;
            this.gabBooks.Image = ((System.Drawing.Image)(resources.GetObject("gabBooks.Image")));
            this.gabBooks.ImageSize = new System.Drawing.Size(40, 40);
            this.gabBooks.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gabBooks.Location = new System.Drawing.Point(19, 160);
            this.gabBooks.Name = "gabBooks";
            this.gabBooks.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(149)))), ((int)(((byte)(85)))));
            this.gabBooks.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gabBooks.OnHoverForeColor = System.Drawing.Color.White;
            this.gabBooks.OnHoverImage = null;
            this.gabBooks.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gabBooks.OnPressedColor = System.Drawing.Color.Black;
            this.gabBooks.Size = new System.Drawing.Size(225, 42);
            this.gabBooks.TabIndex = 2;
            this.gabBooks.Text = "الكتب";
            this.gabBooks.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gabBooks.Click += new System.EventHandler(this.gabBooks_Click);
            // 
            // gabBorrowings
            // 
            this.gabBorrowings.AnimationHoverSpeed = 0.07F;
            this.gabBorrowings.AnimationSpeed = 0.03F;
            this.gabBorrowings.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(149)))), ((int)(((byte)(85)))));
            this.gabBorrowings.BorderColor = System.Drawing.Color.Black;
            this.gabBorrowings.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gabBorrowings.CheckedBorderColor = System.Drawing.Color.Black;
            this.gabBorrowings.CheckedForeColor = System.Drawing.Color.White;
            this.gabBorrowings.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gabBorrowings.CheckedImage")));
            this.gabBorrowings.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gabBorrowings.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gabBorrowings.FocusedColor = System.Drawing.Color.Empty;
            this.gabBorrowings.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gabBorrowings.ForeColor = System.Drawing.Color.White;
            this.gabBorrowings.Image = ((System.Drawing.Image)(resources.GetObject("gabBorrowings.Image")));
            this.gabBorrowings.ImageSize = new System.Drawing.Size(40, 40);
            this.gabBorrowings.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gabBorrowings.Location = new System.Drawing.Point(19, 72);
            this.gabBorrowings.Name = "gabBorrowings";
            this.gabBorrowings.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(149)))), ((int)(((byte)(85)))));
            this.gabBorrowings.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gabBorrowings.OnHoverForeColor = System.Drawing.Color.White;
            this.gabBorrowings.OnHoverImage = null;
            this.gabBorrowings.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gabBorrowings.OnPressedColor = System.Drawing.Color.Black;
            this.gabBorrowings.Size = new System.Drawing.Size(225, 42);
            this.gabBorrowings.TabIndex = 1;
            this.gabBorrowings.Text = "استعاراتي";
            this.gabBorrowings.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gabBorrowings.Click += new System.EventHandler(this.gabBorrowings_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Location = new System.Drawing.Point(281, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(518, 452);
            this.panel2.TabIndex = 2;
            // 
            // gabExit
            // 
            this.gabExit.AnimationHoverSpeed = 0.07F;
            this.gabExit.AnimationSpeed = 0.03F;
            this.gabExit.BaseColor = System.Drawing.Color.DarkRed;
            this.gabExit.BorderColor = System.Drawing.Color.Black;
            this.gabExit.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gabExit.CheckedBorderColor = System.Drawing.Color.Black;
            this.gabExit.CheckedForeColor = System.Drawing.Color.White;
            this.gabExit.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gabExit.CheckedImage")));
            this.gabExit.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gabExit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gabExit.FocusedColor = System.Drawing.Color.Empty;
            this.gabExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gabExit.ForeColor = System.Drawing.Color.White;
            this.gabExit.Image = ((System.Drawing.Image)(resources.GetObject("gabExit.Image")));
            this.gabExit.ImageSize = new System.Drawing.Size(40, 40);
            this.gabExit.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gabExit.Location = new System.Drawing.Point(19, 347);
            this.gabExit.Name = "gabExit";
            this.gabExit.OnHoverBaseColor = System.Drawing.Color.DarkRed;
            this.gabExit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gabExit.OnHoverForeColor = System.Drawing.Color.White;
            this.gabExit.OnHoverImage = null;
            this.gabExit.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gabExit.OnPressedColor = System.Drawing.Color.Black;
            this.gabExit.Size = new System.Drawing.Size(225, 42);
            this.gabExit.TabIndex = 4;
            this.gabExit.Text = "خروج";
            this.gabExit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gabExit.Click += new System.EventHandler(this.gabExit_Click);
            // 
            // BenefitScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "BenefitScreen";
            this.Text = "BenefitScreen";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel glblGreeting;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaAdvenceButton gabBorrowings;
        private Guna.UI.WinForms.GunaAdvenceButton gabBooks;
        private Guna.UI.WinForms.GunaAdvenceButton gabRequests;
        private Guna.UI.WinForms.GunaAdvenceButton gabExit;
    }
}