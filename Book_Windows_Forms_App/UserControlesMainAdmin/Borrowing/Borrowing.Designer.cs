namespace Book_Windows_Forms_App.UserControles.Borrowing
{
    partial class Borrowing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Borrowing));
            this.gabShowBorrowings = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gabInsertBorrowing = new Guna.UI.WinForms.GunaAdvenceButton();
            this.SuspendLayout();
            // 
            // gabShowBorrowings
            // 
            this.gabShowBorrowings.AnimationHoverSpeed = 0.07F;
            this.gabShowBorrowings.AnimationSpeed = 0.03F;
            this.gabShowBorrowings.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(149)))), ((int)(((byte)(85)))));
            this.gabShowBorrowings.BorderColor = System.Drawing.Color.Black;
            this.gabShowBorrowings.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gabShowBorrowings.CheckedBorderColor = System.Drawing.Color.Black;
            this.gabShowBorrowings.CheckedForeColor = System.Drawing.Color.White;
            this.gabShowBorrowings.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gabShowBorrowings.CheckedImage")));
            this.gabShowBorrowings.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gabShowBorrowings.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gabShowBorrowings.FocusedColor = System.Drawing.Color.Empty;
            this.gabShowBorrowings.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gabShowBorrowings.ForeColor = System.Drawing.Color.White;
            this.gabShowBorrowings.Image = ((System.Drawing.Image)(resources.GetObject("gabShowBorrowings.Image")));
            this.gabShowBorrowings.ImageSize = new System.Drawing.Size(30, 30);
            this.gabShowBorrowings.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gabShowBorrowings.Location = new System.Drawing.Point(14, 51);
            this.gabShowBorrowings.Name = "gabShowBorrowings";
            this.gabShowBorrowings.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(149)))), ((int)(((byte)(85)))));
            this.gabShowBorrowings.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gabShowBorrowings.OnHoverForeColor = System.Drawing.Color.White;
            this.gabShowBorrowings.OnHoverImage = null;
            this.gabShowBorrowings.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gabShowBorrowings.OnPressedColor = System.Drawing.Color.Black;
            this.gabShowBorrowings.Size = new System.Drawing.Size(181, 42);
            this.gabShowBorrowings.TabIndex = 9;
            this.gabShowBorrowings.Text = "عرض الاستعارات";
            this.gabShowBorrowings.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gabShowBorrowings.Click += new System.EventHandler(this.gabShowBorrowings_Click);
            // 
            // gabInsertBorrowing
            // 
            this.gabInsertBorrowing.AnimationHoverSpeed = 0.07F;
            this.gabInsertBorrowing.AnimationSpeed = 0.03F;
            this.gabInsertBorrowing.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(149)))), ((int)(((byte)(85)))));
            this.gabInsertBorrowing.BorderColor = System.Drawing.Color.Black;
            this.gabInsertBorrowing.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gabInsertBorrowing.CheckedBorderColor = System.Drawing.Color.Black;
            this.gabInsertBorrowing.CheckedForeColor = System.Drawing.Color.White;
            this.gabInsertBorrowing.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gabInsertBorrowing.CheckedImage")));
            this.gabInsertBorrowing.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gabInsertBorrowing.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gabInsertBorrowing.FocusedColor = System.Drawing.Color.Empty;
            this.gabInsertBorrowing.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gabInsertBorrowing.ForeColor = System.Drawing.Color.White;
            this.gabInsertBorrowing.Image = ((System.Drawing.Image)(resources.GetObject("gabInsertBorrowing.Image")));
            this.gabInsertBorrowing.ImageSize = new System.Drawing.Size(30, 30);
            this.gabInsertBorrowing.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gabInsertBorrowing.Location = new System.Drawing.Point(332, 51);
            this.gabInsertBorrowing.Name = "gabInsertBorrowing";
            this.gabInsertBorrowing.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(149)))), ((int)(((byte)(85)))));
            this.gabInsertBorrowing.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gabInsertBorrowing.OnHoverForeColor = System.Drawing.Color.White;
            this.gabInsertBorrowing.OnHoverImage = null;
            this.gabInsertBorrowing.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gabInsertBorrowing.OnPressedColor = System.Drawing.Color.Black;
            this.gabInsertBorrowing.Size = new System.Drawing.Size(181, 42);
            this.gabInsertBorrowing.TabIndex = 8;
            this.gabInsertBorrowing.Text = "اضافة استعارة";
            this.gabInsertBorrowing.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gabInsertBorrowing.Click += new System.EventHandler(this.gabInsertBorrowing_Click);
            // 
            // Borrowing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gabShowBorrowings);
            this.Controls.Add(this.gabInsertBorrowing);
            this.Name = "Borrowing";
            this.Size = new System.Drawing.Size(547, 150);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaAdvenceButton gabInsertBorrowing;
        private Guna.UI.WinForms.GunaAdvenceButton gabShowBorrowings;
    }
}
