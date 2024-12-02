namespace Book_Windows_Forms_App.UserControles.Book
{
    partial class Book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Book));
            this.gabShowBooks = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gabInsertBook = new Guna.UI.WinForms.GunaAdvenceButton();
            this.SuspendLayout();
            // 
            // gabShowBooks
            // 
            this.gabShowBooks.AnimationHoverSpeed = 0.07F;
            this.gabShowBooks.AnimationSpeed = 0.03F;
            this.gabShowBooks.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(149)))), ((int)(((byte)(85)))));
            this.gabShowBooks.BorderColor = System.Drawing.Color.Black;
            this.gabShowBooks.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gabShowBooks.CheckedBorderColor = System.Drawing.Color.Black;
            this.gabShowBooks.CheckedForeColor = System.Drawing.Color.White;
            this.gabShowBooks.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gabShowBooks.CheckedImage")));
            this.gabShowBooks.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gabShowBooks.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gabShowBooks.FocusedColor = System.Drawing.Color.Empty;
            this.gabShowBooks.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gabShowBooks.ForeColor = System.Drawing.Color.White;
            this.gabShowBooks.Image = ((System.Drawing.Image)(resources.GetObject("gabShowBooks.Image")));
            this.gabShowBooks.ImageSize = new System.Drawing.Size(30, 30);
            this.gabShowBooks.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gabShowBooks.Location = new System.Drawing.Point(14, 51);
            this.gabShowBooks.Name = "gabShowBooks";
            this.gabShowBooks.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(149)))), ((int)(((byte)(85)))));
            this.gabShowBooks.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gabShowBooks.OnHoverForeColor = System.Drawing.Color.White;
            this.gabShowBooks.OnHoverImage = null;
            this.gabShowBooks.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gabShowBooks.OnPressedColor = System.Drawing.Color.Black;
            this.gabShowBooks.Size = new System.Drawing.Size(181, 42);
            this.gabShowBooks.TabIndex = 9;
            this.gabShowBooks.Text = "عرض الكتب";
            this.gabShowBooks.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gabShowBooks.Click += new System.EventHandler(this.gabShowBooks_Click);
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
            this.gabInsertBook.TabIndex = 8;
            this.gabInsertBook.Text = "اضافة كتاب";
            this.gabInsertBook.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gabInsertBook.Click += new System.EventHandler(this.gabInsertBook_Click);
            // 
            // Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gabShowBooks);
            this.Controls.Add(this.gabInsertBook);
            this.Name = "Book";
            this.Size = new System.Drawing.Size(547, 150);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaAdvenceButton gabInsertBook;
        private Guna.UI.WinForms.GunaAdvenceButton gabShowBooks;
    }
}
