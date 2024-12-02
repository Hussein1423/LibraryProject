namespace Book_Windows_Forms_App
{
    partial class RecipientScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecipientScreen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gabBooks = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gabUsers = new Guna.UI.WinForms.GunaAdvenceButton();
            this.glblGreeting = new Guna.UI.WinForms.GunaLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gabExit = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gabExit);
            this.panel1.Controls.Add(this.gabBooks);
            this.panel1.Controls.Add(this.gabUsers);
            this.panel1.Controls.Add(this.glblGreeting);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 2;
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
            this.gabBooks.Location = new System.Drawing.Point(30, 198);
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
            this.gabUsers.Location = new System.Drawing.Point(30, 104);
            this.gabUsers.Name = "gabUsers";
            this.gabUsers.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(149)))), ((int)(((byte)(85)))));
            this.gabUsers.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gabUsers.OnHoverForeColor = System.Drawing.Color.White;
            this.gabUsers.OnHoverImage = null;
            this.gabUsers.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gabUsers.OnPressedColor = System.Drawing.Color.Black;
            this.gabUsers.Size = new System.Drawing.Size(218, 42);
            this.gabUsers.TabIndex = 1;
            this.gabUsers.Text = "استعارتي";
            this.gabUsers.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gabUsers.Click += new System.EventHandler(this.gabUsers_Click);
            // 
            // glblGreeting
            // 
            this.glblGreeting.AutoSize = true;
            this.glblGreeting.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.glblGreeting.Location = new System.Drawing.Point(25, 21);
            this.glblGreeting.Name = "glblGreeting";
            this.glblGreeting.Size = new System.Drawing.Size(223, 25);
            this.glblGreeting.TabIndex = 0;
            this.glblGreeting.Text = "Welcome To Admin Screen";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Location = new System.Drawing.Point(286, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(520, 453);
            this.panel2.TabIndex = 3;
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
            this.gabExit.Location = new System.Drawing.Point(30, 292);
            this.gabExit.Name = "gabExit";
            this.gabExit.OnHoverBaseColor = System.Drawing.Color.DarkRed;
            this.gabExit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gabExit.OnHoverForeColor = System.Drawing.Color.White;
            this.gabExit.OnHoverImage = null;
            this.gabExit.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gabExit.OnPressedColor = System.Drawing.Color.Black;
            this.gabExit.Size = new System.Drawing.Size(225, 42);
            this.gabExit.TabIndex = 5;
            this.gabExit.Text = "خروج";
            this.gabExit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gabExit.Click += new System.EventHandler(this.gabExit_Click);
            // 
            // RecipientScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "RecipientScreen";
            this.Text = "RecipientScreen";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaAdvenceButton gabBooks;
        private Guna.UI.WinForms.GunaAdvenceButton gabUsers;
        private Guna.UI.WinForms.GunaLabel glblGreeting;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaAdvenceButton gabExit;
    }
}