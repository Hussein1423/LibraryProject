namespace Book_Windows_Forms_App.UserControlesRecipientScreen
{
    partial class MyBorrowings
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyBorrowings));
            this.gdgvMyBorrowings = new Guna.UI.WinForms.GunaDataGridView();
            this.lblNumberofMyBooks = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gdgvMyBorrowings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gdgvMyBorrowings
            // 
            this.gdgvMyBorrowings.AllowUserToAddRows = false;
            this.gdgvMyBorrowings.AllowUserToDeleteRows = false;
            this.gdgvMyBorrowings.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gdgvMyBorrowings.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gdgvMyBorrowings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gdgvMyBorrowings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdgvMyBorrowings.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gdgvMyBorrowings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gdgvMyBorrowings.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gdgvMyBorrowings.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdgvMyBorrowings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gdgvMyBorrowings.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gdgvMyBorrowings.DefaultCellStyle = dataGridViewCellStyle3;
            this.gdgvMyBorrowings.EnableHeadersVisualStyles = false;
            this.gdgvMyBorrowings.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdgvMyBorrowings.Location = new System.Drawing.Point(0, 96);
            this.gdgvMyBorrowings.Name = "gdgvMyBorrowings";
            this.gdgvMyBorrowings.ReadOnly = true;
            this.gdgvMyBorrowings.RowHeadersVisible = false;
            this.gdgvMyBorrowings.RowHeadersWidth = 62;
            this.gdgvMyBorrowings.RowTemplate.Height = 29;
            this.gdgvMyBorrowings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdgvMyBorrowings.Size = new System.Drawing.Size(520, 357);
            this.gdgvMyBorrowings.TabIndex = 0;
            this.gdgvMyBorrowings.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gdgvMyBorrowings.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gdgvMyBorrowings.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gdgvMyBorrowings.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gdgvMyBorrowings.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gdgvMyBorrowings.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gdgvMyBorrowings.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gdgvMyBorrowings.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdgvMyBorrowings.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gdgvMyBorrowings.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gdgvMyBorrowings.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gdgvMyBorrowings.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gdgvMyBorrowings.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gdgvMyBorrowings.ThemeStyle.HeaderStyle.Height = 4;
            this.gdgvMyBorrowings.ThemeStyle.ReadOnly = true;
            this.gdgvMyBorrowings.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gdgvMyBorrowings.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gdgvMyBorrowings.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gdgvMyBorrowings.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gdgvMyBorrowings.ThemeStyle.RowsStyle.Height = 29;
            this.gdgvMyBorrowings.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdgvMyBorrowings.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // lblNumberofMyBooks
            // 
            this.lblNumberofMyBooks.AutoSize = true;
            this.lblNumberofMyBooks.Location = new System.Drawing.Point(65, 22);
            this.lblNumberofMyBooks.Name = "lblNumberofMyBooks";
            this.lblNumberofMyBooks.Size = new System.Drawing.Size(51, 19);
            this.lblNumberofMyBooks.TabIndex = 1;
            this.lblNumberofMyBooks.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "عدد الكتب التي قرأتها";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // MyBorrowings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNumberofMyBooks);
            this.Controls.Add(this.gdgvMyBorrowings);
            this.Name = "MyBorrowings";
            this.Size = new System.Drawing.Size(520, 453);
            this.Load += new System.EventHandler(this.MyBorrowings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdgvMyBorrowings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaDataGridView gdgvMyBorrowings;
        private System.Windows.Forms.Label lblNumberofMyBooks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
