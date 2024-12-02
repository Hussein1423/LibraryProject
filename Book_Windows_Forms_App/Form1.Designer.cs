namespace Book_Windows_Forms_App
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gtbFirstName = new Guna.UI.WinForms.GunaTextBox();
            this.gtbPassword = new Guna.UI.WinForms.GunaTextBox();
            this.gtbMiddleName = new Guna.UI.WinForms.GunaTextBox();
            this.gtbLastName = new Guna.UI.WinForms.GunaTextBox();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gcpbforPassword = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.gabConfirm = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gcpbforPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gtbFirstName
            // 
            this.gtbFirstName.BaseColor = System.Drawing.Color.White;
            this.gtbFirstName.BorderColor = System.Drawing.Color.Silver;
            this.gtbFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtbFirstName.FocusedBaseColor = System.Drawing.Color.White;
            this.gtbFirstName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gtbFirstName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gtbFirstName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gtbFirstName.Location = new System.Drawing.Point(509, 50);
            this.gtbFirstName.Name = "gtbFirstName";
            this.gtbFirstName.PasswordChar = '\0';
            this.gtbFirstName.SelectedText = "";
            this.gtbFirstName.Size = new System.Drawing.Size(255, 34);
            this.gtbFirstName.TabIndex = 1;
            this.gtbFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gtbPassword
            // 
            this.gtbPassword.BaseColor = System.Drawing.Color.White;
            this.gtbPassword.BorderColor = System.Drawing.Color.Silver;
            this.gtbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtbPassword.FocusedBaseColor = System.Drawing.Color.White;
            this.gtbPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gtbPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gtbPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gtbPassword.Location = new System.Drawing.Point(509, 248);
            this.gtbPassword.Name = "gtbPassword";
            this.gtbPassword.PasswordChar = '*';
            this.gtbPassword.SelectedText = "";
            this.gtbPassword.Size = new System.Drawing.Size(255, 34);
            this.gtbPassword.TabIndex = 2;
            this.gtbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gtbMiddleName
            // 
            this.gtbMiddleName.BaseColor = System.Drawing.Color.White;
            this.gtbMiddleName.BorderColor = System.Drawing.Color.Silver;
            this.gtbMiddleName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtbMiddleName.FocusedBaseColor = System.Drawing.Color.White;
            this.gtbMiddleName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gtbMiddleName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gtbMiddleName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gtbMiddleName.Location = new System.Drawing.Point(509, 116);
            this.gtbMiddleName.Name = "gtbMiddleName";
            this.gtbMiddleName.PasswordChar = '\0';
            this.gtbMiddleName.SelectedText = "";
            this.gtbMiddleName.Size = new System.Drawing.Size(255, 34);
            this.gtbMiddleName.TabIndex = 8;
            this.gtbMiddleName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gtbLastName
            // 
            this.gtbLastName.BaseColor = System.Drawing.Color.White;
            this.gtbLastName.BorderColor = System.Drawing.Color.Silver;
            this.gtbLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtbLastName.FocusedBaseColor = System.Drawing.Color.White;
            this.gtbLastName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gtbLastName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gtbLastName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gtbLastName.Location = new System.Drawing.Point(509, 182);
            this.gtbLastName.Name = "gtbLastName";
            this.gtbLastName.PasswordChar = '\0';
            this.gtbLastName.SelectedText = "";
            this.gtbLastName.Size = new System.Drawing.Size(255, 34);
            this.gtbLastName.TabIndex = 9;
            this.gtbLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMessage.Location = new System.Drawing.Point(614, 374);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(0, 19);
            this.lblErrorMessage.TabIndex = 10;
            this.lblErrorMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(678, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "الاسم الاول";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(685, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "اسم الوالد";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(717, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "اللقب";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(678, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "كلمة المرور";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gcpbforPassword
            // 
            this.gcpbforPassword.BackColor = System.Drawing.Color.Transparent;
            this.gcpbforPassword.BaseColor = System.Drawing.Color.Transparent;
            this.gcpbforPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gcpbforPassword.Image = global::Book_Windows_Forms_App.Properties.Resources.invisible_100px;
            this.gcpbforPassword.Location = new System.Drawing.Point(464, 248);
            this.gcpbforPassword.Name = "gcpbforPassword";
            this.gcpbforPassword.Size = new System.Drawing.Size(39, 34);
            this.gcpbforPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gcpbforPassword.TabIndex = 15;
            this.gcpbforPassword.TabStop = false;
            this.gcpbforPassword.Tag = "0";
            this.gcpbforPassword.UseTransfarantBackground = false;
            this.gcpbforPassword.Click += new System.EventHandler(this.gunaCirclePictureBox1_Click);
            // 
            // gabConfirm
            // 
            this.gabConfirm.AnimationHoverSpeed = 0.07F;
            this.gabConfirm.AnimationSpeed = 0.03F;
            this.gabConfirm.BackColor = System.Drawing.Color.Transparent;
            this.gabConfirm.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(149)))), ((int)(((byte)(85)))));
            this.gabConfirm.BorderColor = System.Drawing.Color.Black;
            this.gabConfirm.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gabConfirm.CheckedBorderColor = System.Drawing.Color.Black;
            this.gabConfirm.CheckedForeColor = System.Drawing.Color.White;
            this.gabConfirm.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gabConfirm.CheckedImage")));
            this.gabConfirm.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gabConfirm.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gabConfirm.FocusedColor = System.Drawing.Color.Empty;
            this.gabConfirm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gabConfirm.ForeColor = System.Drawing.Color.White;
            this.gabConfirm.Image = null;
            this.gabConfirm.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gabConfirm.ImageSize = new System.Drawing.Size(20, 20);
            this.gabConfirm.LineColor = System.Drawing.Color.White;
            this.gabConfirm.Location = new System.Drawing.Point(509, 315);
            this.gabConfirm.Name = "gabConfirm";
            this.gabConfirm.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(149)))), ((int)(((byte)(85)))));
            this.gabConfirm.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gabConfirm.OnHoverForeColor = System.Drawing.Color.White;
            this.gabConfirm.OnHoverImage = null;
            this.gabConfirm.OnHoverLineColor = System.Drawing.Color.Goldenrod;
            this.gabConfirm.OnPressedColor = System.Drawing.Color.Black;
            this.gabConfirm.Radius = 20;
            this.gabConfirm.Size = new System.Drawing.Size(255, 42);
            this.gabConfirm.TabIndex = 5;
            this.gabConfirm.Text = "تأكيد";
            this.gabConfirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gabConfirm.Click += new System.EventHandler(this.gunaAdvenceButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(461, 452);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(43)))), ((int)(((byte)(32)))));
            this.gunaLabel1.Font = new System.Drawing.Font("AlAhram", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gunaLabel1.Location = new System.Drawing.Point(26, 183);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(373, 62);
            this.gunaLabel1.TabIndex = 16;
            this.gunaLabel1.Text = "مرحبا بكم بالنظام المكتبة";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gcpbforPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.gtbLastName);
            this.Controls.Add(this.gtbMiddleName);
            this.Controls.Add(this.gabConfirm);
            this.Controls.Add(this.gtbPassword);
            this.Controls.Add(this.gtbFirstName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gcpbforPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaTextBox gtbFirstName;
        private Guna.UI.WinForms.GunaTextBox gtbPassword;
        private Guna.UI.WinForms.GunaAdvenceButton gabConfirm;
        private Guna.UI.WinForms.GunaTextBox gtbMiddleName;
        private Guna.UI.WinForms.GunaTextBox gtbLastName;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaCirclePictureBox gcpbforPassword;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}

