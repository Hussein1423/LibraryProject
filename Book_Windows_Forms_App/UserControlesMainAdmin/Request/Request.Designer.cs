namespace Book_Windows_Forms_App.UserControlesMainAdmin.Request
{
    partial class Request
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Request));
            this.gabShowAllRequests = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gabInsertBook = new Guna.UI.WinForms.GunaAdvenceButton();
            this.SuspendLayout();
            // 
            // gabShowAllRequests
            // 
            this.gabShowAllRequests.AnimationHoverSpeed = 0.07F;
            this.gabShowAllRequests.AnimationSpeed = 0.03F;
            this.gabShowAllRequests.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(149)))), ((int)(((byte)(85)))));
            this.gabShowAllRequests.BorderColor = System.Drawing.Color.Black;
            this.gabShowAllRequests.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gabShowAllRequests.CheckedBorderColor = System.Drawing.Color.Black;
            this.gabShowAllRequests.CheckedForeColor = System.Drawing.Color.White;
            this.gabShowAllRequests.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gabShowAllRequests.CheckedImage")));
            this.gabShowAllRequests.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gabShowAllRequests.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gabShowAllRequests.FocusedColor = System.Drawing.Color.Empty;
            this.gabShowAllRequests.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gabShowAllRequests.ForeColor = System.Drawing.Color.White;
            this.gabShowAllRequests.Image = ((System.Drawing.Image)(resources.GetObject("gabShowAllRequests.Image")));
            this.gabShowAllRequests.ImageSize = new System.Drawing.Size(30, 30);
            this.gabShowAllRequests.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gabShowAllRequests.Location = new System.Drawing.Point(14, 51);
            this.gabShowAllRequests.Name = "gabShowAllRequests";
            this.gabShowAllRequests.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(149)))), ((int)(((byte)(85)))));
            this.gabShowAllRequests.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gabShowAllRequests.OnHoverForeColor = System.Drawing.Color.White;
            this.gabShowAllRequests.OnHoverImage = null;
            this.gabShowAllRequests.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gabShowAllRequests.OnPressedColor = System.Drawing.Color.Black;
            this.gabShowAllRequests.Size = new System.Drawing.Size(181, 42);
            this.gabShowAllRequests.TabIndex = 11;
            this.gabShowAllRequests.Text = "عرض الطلبات";
            this.gabShowAllRequests.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gabShowAllRequests.Click += new System.EventHandler(this.gabShowAllRequests_Click);
            // 
            // gabInsertBook
            // 
            this.gabInsertBook.AnimationHoverSpeed = 0.07F;
            this.gabInsertBook.AnimationSpeed = 0.03F;
            this.gabInsertBook.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(149)))), ((int)(((byte)(85)))));
            this.gabInsertBook.BorderColor = System.Drawing.Color.Black;
            this.gabInsertBook.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gabInsertBook.CheckedBorderColor = System.Drawing.Color.Black;
            this.gabInsertBook.CheckedForeColor = System.Drawing.Color.White;
            this.gabInsertBook.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gabInsertBook.CheckedImage")));
            this.gabInsertBook.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gabInsertBook.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gabInsertBook.FocusedColor = System.Drawing.Color.Empty;
            this.gabInsertBook.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gabInsertBook.ForeColor = System.Drawing.Color.White;
            this.gabInsertBook.Image = ((System.Drawing.Image)(resources.GetObject("gabInsertBook.Image")));
            this.gabInsertBook.ImageSize = new System.Drawing.Size(30, 30);
            this.gabInsertBook.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gabInsertBook.Location = new System.Drawing.Point(332, 51);
            this.gabInsertBook.Name = "gabInsertBook";
            this.gabInsertBook.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(149)))), ((int)(((byte)(85)))));
            this.gabInsertBook.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gabInsertBook.OnHoverForeColor = System.Drawing.Color.White;
            this.gabInsertBook.OnHoverImage = null;
            this.gabInsertBook.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gabInsertBook.OnPressedColor = System.Drawing.Color.Black;
            this.gabInsertBook.Size = new System.Drawing.Size(181, 42);
            this.gabInsertBook.TabIndex = 10;
            this.gabInsertBook.Text = "عرض غير مسجل";
            this.gabInsertBook.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gabInsertBook.Click += new System.EventHandler(this.gabInsertBook_Click);
            // 
            // Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gabShowAllRequests);
            this.Controls.Add(this.gabInsertBook);
            this.Name = "Request";
            this.Size = new System.Drawing.Size(547, 150);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaAdvenceButton gabShowAllRequests;
        private Guna.UI.WinForms.GunaAdvenceButton gabInsertBook;
    }
}
