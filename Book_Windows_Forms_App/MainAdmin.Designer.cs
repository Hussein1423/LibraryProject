namespace Book_Windows_Forms_App
{
    partial class MainAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainAdmin));
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gabRequests = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gabBorrwings = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gabBooks = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gabUsers = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gabExit = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(25, 25);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(223, 25);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Welcome To Admin Screen";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gabExit);
            this.panel1.Controls.Add(this.gabRequests);
            this.panel1.Controls.Add(this.gabBorrwings);
            this.panel1.Controls.Add(this.gabBooks);
            this.panel1.Controls.Add(this.gabUsers);
            this.panel1.Controls.Add(this.gunaLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
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
            this.gabRequests.Location = new System.Drawing.Point(37, 303);
            this.gabRequests.Name = "gabRequests";
            this.gabRequests.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(149)))), ((int)(((byte)(85)))));
            this.gabRequests.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gabRequests.OnHoverForeColor = System.Drawing.Color.White;
            this.gabRequests.OnHoverImage = null;
            this.gabRequests.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gabRequests.OnPressedColor = System.Drawing.Color.Black;
            this.gabRequests.Size = new System.Drawing.Size(218, 42);
            this.gabRequests.TabIndex = 4;
            this.gabRequests.Text = "الطلبات";
            this.gabRequests.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gabRequests.Click += new System.EventHandler(this.gabRequests_Click);
            // 
            // gabBorrwings
            // 
            this.gabBorrwings.AnimationHoverSpeed = 0.07F;
            this.gabBorrwings.AnimationSpeed = 0.03F;
            this.gabBorrwings.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(149)))), ((int)(((byte)(85)))));
            this.gabBorrwings.BorderColor = System.Drawing.Color.Black;
            this.gabBorrwings.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gabBorrwings.CheckedBorderColor = System.Drawing.Color.Black;
            this.gabBorrwings.CheckedForeColor = System.Drawing.Color.White;
            this.gabBorrwings.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gabBorrwings.CheckedImage")));
            this.gabBorrwings.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gabBorrwings.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gabBorrwings.FocusedColor = System.Drawing.Color.Empty;
            this.gabBorrwings.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gabBorrwings.ForeColor = System.Drawing.Color.White;
            this.gabBorrwings.Image = ((System.Drawing.Image)(resources.GetObject("gabBorrwings.Image")));
            this.gabBorrwings.ImageSize = new System.Drawing.Size(40, 40);
            this.gabBorrwings.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gabBorrwings.Location = new System.Drawing.Point(37, 235);
            this.gabBorrwings.Name = "gabBorrwings";
            this.gabBorrwings.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(149)))), ((int)(((byte)(85)))));
            this.gabBorrwings.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gabBorrwings.OnHoverForeColor = System.Drawing.Color.White;
            this.gabBorrwings.OnHoverImage = null;
            this.gabBorrwings.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gabBorrwings.OnPressedColor = System.Drawing.Color.Black;
            this.gabBorrwings.Size = new System.Drawing.Size(218, 42);
            this.gabBorrwings.TabIndex = 3;
            this.gabBorrwings.Text = "الاستعارات";
            this.gabBorrwings.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gabBorrwings.Click += new System.EventHandler(this.gabBorrwings_Click);
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
            this.gabBooks.Location = new System.Drawing.Point(37, 167);
            this.gabBooks.Name = "gabBooks";
            this.gabBooks.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(149)))), ((int)(((byte)(85)))));
            this.gabBooks.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gabBooks.OnHoverForeColor = System.Drawing.Color.White;
            this.gabBooks.OnHoverImage = null;
            this.gabBooks.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gabBooks.OnPressedColor = System.Drawing.Color.Black;
            this.gabBooks.Size = new System.Drawing.Size(218, 42);
            this.gabBooks.TabIndex = 2;
            this.gabBooks.Text = "الكتب";
            this.gabBooks.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gabBooks.Click += new System.EventHandler(this.gabBooks_Click);
            // 
            // gabUsers
            // 
            this.gabUsers.AnimationHoverSpeed = 0.07F;
            this.gabUsers.AnimationSpeed = 0.03F;
            this.gabUsers.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(149)))), ((int)(((byte)(85)))));
            this.gabUsers.BorderColor = System.Drawing.Color.Black;
            this.gabUsers.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gabUsers.CheckedBorderColor = System.Drawing.Color.Black;
            this.gabUsers.CheckedForeColor = System.Drawing.Color.White;
            this.gabUsers.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gabUsers.CheckedImage")));
            this.gabUsers.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gabUsers.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gabUsers.FocusedColor = System.Drawing.Color.Empty;
            this.gabUsers.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gabUsers.ForeColor = System.Drawing.Color.White;
            this.gabUsers.Image = ((System.Drawing.Image)(resources.GetObject("gabUsers.Image")));
            this.gabUsers.ImageSize = new System.Drawing.Size(40, 40);
            this.gabUsers.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gabUsers.Location = new System.Drawing.Point(37, 99);
            this.gabUsers.Name = "gabUsers";
            this.gabUsers.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(149)))), ((int)(((byte)(85)))));
            this.gabUsers.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gabUsers.OnHoverForeColor = System.Drawing.Color.White;
            this.gabUsers.OnHoverImage = null;
            this.gabUsers.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gabUsers.OnPressedColor = System.Drawing.Color.Black;
            this.gabUsers.Size = new System.Drawing.Size(218, 42);
            this.gabUsers.TabIndex = 1;
            this.gabUsers.Text = "المستخدمين";
            this.gabUsers.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gabUsers.Click += new System.EventHandler(this.gabUsers_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSize = true;
            this.panel2.Location = new System.Drawing.Point(272, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(528, 356);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Location = new System.Drawing.Point(272, -2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(528, 100);
            this.panel3.TabIndex = 6;
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
            this.gabExit.Location = new System.Drawing.Point(37, 371);
            this.gabExit.Name = "gabExit";
            this.gabExit.OnHoverBaseColor = System.Drawing.Color.DarkRed;
            this.gabExit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gabExit.OnHoverForeColor = System.Drawing.Color.White;
            this.gabExit.OnHoverImage = null;
            this.gabExit.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gabExit.OnPressedColor = System.Drawing.Color.Black;
            this.gabExit.Size = new System.Drawing.Size(218, 42);
            this.gabExit.TabIndex = 5;
            this.gabExit.Text = "خروج";
            this.gabExit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gabExit.Click += new System.EventHandler(this.gabExit_Click);
            // 
            // MainAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainAdmin";
            this.Text = "MainAdmin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaAdvenceButton gabBorrwings;
        private Guna.UI.WinForms.GunaAdvenceButton gabBooks;
        private Guna.UI.WinForms.GunaAdvenceButton gabUsers;
        public  System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI.WinForms.GunaAdvenceButton gabRequests;
        private Guna.UI.WinForms.GunaAdvenceButton gabExit;
    }
}