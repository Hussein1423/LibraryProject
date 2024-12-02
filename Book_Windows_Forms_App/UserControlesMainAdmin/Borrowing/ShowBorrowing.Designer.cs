namespace Book_Windows_Forms_App.UserControles.Borrowing
{
    partial class ShowBorrowing
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gdgvBorrowing = new Guna.UI.WinForms.GunaDataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gtbSearch = new Guna.UI.WinForms.GunaTextBox();
            this.rbBenefit = new System.Windows.Forms.RadioButton();
            this.rbRecipient = new System.Windows.Forms.RadioButton();
            this.rbBook = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.gdgvBorrowing)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gdgvBorrowing
            // 
            this.gdgvBorrowing.AllowUserToAddRows = false;
            this.gdgvBorrowing.AllowUserToDeleteRows = false;
            this.gdgvBorrowing.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.gdgvBorrowing.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gdgvBorrowing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gdgvBorrowing.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdgvBorrowing.BackgroundColor = System.Drawing.Color.White;
            this.gdgvBorrowing.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gdgvBorrowing.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gdgvBorrowing.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdgvBorrowing.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gdgvBorrowing.ColumnHeadersHeight = 4;
            this.gdgvBorrowing.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gdgvBorrowing.DefaultCellStyle = dataGridViewCellStyle6;
            this.gdgvBorrowing.EnableHeadersVisualStyles = false;
            this.gdgvBorrowing.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdgvBorrowing.Location = new System.Drawing.Point(-3, 84);
            this.gdgvBorrowing.Name = "gdgvBorrowing";
            this.gdgvBorrowing.ReadOnly = true;
            this.gdgvBorrowing.RowHeadersVisible = false;
            this.gdgvBorrowing.RowHeadersWidth = 62;
            this.gdgvBorrowing.RowTemplate.Height = 29;
            this.gdgvBorrowing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdgvBorrowing.Size = new System.Drawing.Size(548, 312);
            this.gdgvBorrowing.TabIndex = 0;
            this.gdgvBorrowing.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gdgvBorrowing.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gdgvBorrowing.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gdgvBorrowing.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gdgvBorrowing.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gdgvBorrowing.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gdgvBorrowing.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gdgvBorrowing.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdgvBorrowing.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gdgvBorrowing.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gdgvBorrowing.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gdgvBorrowing.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gdgvBorrowing.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gdgvBorrowing.ThemeStyle.HeaderStyle.Height = 4;
            this.gdgvBorrowing.ThemeStyle.ReadOnly = true;
            this.gdgvBorrowing.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gdgvBorrowing.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gdgvBorrowing.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gdgvBorrowing.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gdgvBorrowing.ThemeStyle.RowsStyle.Height = 29;
            this.gdgvBorrowing.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdgvBorrowing.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(135, 68);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(134, 32);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(134, 32);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // gtbSearch
            // 
            this.gtbSearch.BaseColor = System.Drawing.Color.White;
            this.gtbSearch.BorderColor = System.Drawing.Color.Silver;
            this.gtbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtbSearch.FocusedBaseColor = System.Drawing.Color.White;
            this.gtbSearch.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gtbSearch.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gtbSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gtbSearch.Location = new System.Drawing.Point(19, 23);
            this.gtbSearch.Name = "gtbSearch";
            this.gtbSearch.PasswordChar = '\0';
            this.gtbSearch.SelectedText = "";
            this.gtbSearch.Size = new System.Drawing.Size(197, 42);
            this.gtbSearch.TabIndex = 13;
            this.gtbSearch.TextChanged += new System.EventHandler(this.gtbSearch_TextChanged);
            // 
            // rbBenefit
            // 
            this.rbBenefit.AutoSize = true;
            this.rbBenefit.Checked = true;
            this.rbBenefit.Location = new System.Drawing.Point(222, 13);
            this.rbBenefit.Name = "rbBenefit";
            this.rbBenefit.Size = new System.Drawing.Size(130, 23);
            this.rbBenefit.TabIndex = 15;
            this.rbBenefit.TabStop = true;
            this.rbBenefit.Text = "ابحث عن مفيد";
            this.rbBenefit.UseVisualStyleBackColor = true;
            // 
            // rbRecipient
            // 
            this.rbRecipient.AutoSize = true;
            this.rbRecipient.Location = new System.Drawing.Point(267, 42);
            this.rbRecipient.Name = "rbRecipient";
            this.rbRecipient.Size = new System.Drawing.Size(153, 23);
            this.rbRecipient.TabIndex = 16;
            this.rbRecipient.TabStop = true;
            this.rbRecipient.Text = "ابحث عن مستفيد";
            this.rbRecipient.UseVisualStyleBackColor = true;
            // 
            // rbBook
            // 
            this.rbBook.AutoSize = true;
            this.rbBook.Location = new System.Drawing.Point(367, 13);
            this.rbBook.Name = "rbBook";
            this.rbBook.Size = new System.Drawing.Size(131, 23);
            this.rbBook.TabIndex = 17;
            this.rbBook.TabStop = true;
            this.rbBook.Text = "ابحث عن كتاب";
            this.rbBook.UseVisualStyleBackColor = true;
            // 
            // ShowBorrowing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rbBook);
            this.Controls.Add(this.rbRecipient);
            this.Controls.Add(this.rbBenefit);
            this.Controls.Add(this.gtbSearch);
            this.Controls.Add(this.gdgvBorrowing);
            this.Name = "ShowBorrowing";
            this.Size = new System.Drawing.Size(548, 396);
            this.Load += new System.EventHandler(this.ShowBorrowing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdgvBorrowing)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaDataGridView gdgvBorrowing;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        public Guna.UI.WinForms.GunaTextBox gtbSearch;
        private System.Windows.Forms.RadioButton rbBenefit;
        private System.Windows.Forms.RadioButton rbRecipient;
        private System.Windows.Forms.RadioButton rbBook;
    }
}
