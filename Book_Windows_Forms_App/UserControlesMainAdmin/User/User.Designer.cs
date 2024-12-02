namespace Book_Windows_Forms_App.UserControles
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.gabShowUsers = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gabInsertUser = new Guna.UI.WinForms.GunaAdvenceButton();
            this.SuspendLayout();
            // 
            // gabShowUsers
            // 
            this.gabShowUsers.AnimationHoverSpeed = 0.07F;
            this.gabShowUsers.AnimationSpeed = 0.03F;
            this.gabShowUsers.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(149)))), ((int)(((byte)(85)))));
            this.gabShowUsers.BorderColor = System.Drawing.Color.Black;
            this.gabShowUsers.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gabShowUsers.CheckedBorderColor = System.Drawing.Color.Black;
            this.gabShowUsers.CheckedForeColor = System.Drawing.Color.White;
            this.gabShowUsers.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gabShowUsers.CheckedImage")));
            this.gabShowUsers.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gabShowUsers.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gabShowUsers.FocusedColor = System.Drawing.Color.Empty;
            this.gabShowUsers.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gabShowUsers.ForeColor = System.Drawing.Color.White;
            this.gabShowUsers.Image = ((System.Drawing.Image)(resources.GetObject("gabShowUsers.Image")));
            this.gabShowUsers.ImageSize = new System.Drawing.Size(20, 25);
            this.gabShowUsers.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gabShowUsers.Location = new System.Drawing.Point(14, 51);
            this.gabShowUsers.Name = "gabShowUsers";
            this.gabShowUsers.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(149)))), ((int)(((byte)(85)))));
            this.gabShowUsers.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gabShowUsers.OnHoverForeColor = System.Drawing.Color.White;
            this.gabShowUsers.OnHoverImage = null;
            this.gabShowUsers.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gabShowUsers.OnPressedColor = System.Drawing.Color.Black;
            this.gabShowUsers.Size = new System.Drawing.Size(181, 42);
            this.gabShowUsers.TabIndex = 6;
            this.gabShowUsers.Text = "عرض المستخدمين";
            this.gabShowUsers.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gabShowUsers.Click += new System.EventHandler(this.gabShowUsers_Click);
            // 
            // gabInsertUser
            // 
            this.gabInsertUser.AnimationHoverSpeed = 0.07F;
            this.gabInsertUser.AnimationSpeed = 0.03F;
            this.gabInsertUser.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(149)))), ((int)(((byte)(85)))));
            this.gabInsertUser.BorderColor = System.Drawing.Color.Black;
            this.gabInsertUser.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gabInsertUser.CheckedBorderColor = System.Drawing.Color.Black;
            this.gabInsertUser.CheckedForeColor = System.Drawing.Color.White;
            this.gabInsertUser.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gabInsertUser.CheckedImage")));
            this.gabInsertUser.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gabInsertUser.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gabInsertUser.FocusedColor = System.Drawing.Color.Empty;
            this.gabInsertUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gabInsertUser.ForeColor = System.Drawing.Color.White;
            this.gabInsertUser.Image = ((System.Drawing.Image)(resources.GetObject("gabInsertUser.Image")));
            this.gabInsertUser.ImageSize = new System.Drawing.Size(30, 30);
            this.gabInsertUser.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gabInsertUser.Location = new System.Drawing.Point(332, 51);
            this.gabInsertUser.Name = "gabInsertUser";
            this.gabInsertUser.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(149)))), ((int)(((byte)(85)))));
            this.gabInsertUser.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gabInsertUser.OnHoverForeColor = System.Drawing.Color.White;
            this.gabInsertUser.OnHoverImage = null;
            this.gabInsertUser.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gabInsertUser.OnPressedColor = System.Drawing.Color.Black;
            this.gabInsertUser.Size = new System.Drawing.Size(181, 42);
            this.gabInsertUser.TabIndex = 7;
            this.gabInsertUser.Text = "اضافة مستخدم";
            this.gabInsertUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gabInsertUser.Click += new System.EventHandler(this.gabInsertUser_Click);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gabInsertUser);
            this.Controls.Add(this.gabShowUsers);
            this.Name = "User";
            this.Size = new System.Drawing.Size(547, 150);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaAdvenceButton gabShowUsers;
        private Guna.UI.WinForms.GunaAdvenceButton gabInsertUser;
    }
}
