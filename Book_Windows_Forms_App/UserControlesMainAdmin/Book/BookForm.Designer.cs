namespace Book_Windows_Forms_App.UserControles.Book
{
    partial class BookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookForm));
            this.lblID = new System.Windows.Forms.Label();
            this.gtbBookName = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudBookPart = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.rbBookTrue = new System.Windows.Forms.RadioButton();
            this.rbBookFalse = new System.Windows.Forms.RadioButton();
            this.gabBookConfirm = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudBookPart)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(171, 29);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(51, 19);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "label1";
            // 
            // gtbBookName
            // 
            this.gtbBookName.BaseColor = System.Drawing.Color.White;
            this.gtbBookName.BorderColor = System.Drawing.Color.Silver;
            this.gtbBookName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtbBookName.FocusedBaseColor = System.Drawing.Color.White;
            this.gtbBookName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gtbBookName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gtbBookName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gtbBookName.Location = new System.Drawing.Point(69, 105);
            this.gtbBookName.Name = "gtbBookName";
            this.gtbBookName.PasswordChar = '\0';
            this.gtbBookName.SelectedText = "";
            this.gtbBookName.Size = new System.Drawing.Size(263, 37);
            this.gtbBookName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "BookName";
            // 
            // nudBookPart
            // 
            this.nudBookPart.Location = new System.Drawing.Point(69, 195);
            this.nudBookPart.Name = "nudBookPart";
            this.nudBookPart.Size = new System.Drawing.Size(120, 27);
            this.nudBookPart.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Part";
            // 
            // rbBookTrue
            // 
            this.rbBookTrue.AutoSize = true;
            this.rbBookTrue.Location = new System.Drawing.Point(73, 267);
            this.rbBookTrue.Name = "rbBookTrue";
            this.rbBookTrue.Size = new System.Drawing.Size(67, 23);
            this.rbBookTrue.TabIndex = 5;
            this.rbBookTrue.TabStop = true;
            this.rbBookTrue.Text = "True";
            this.rbBookTrue.UseVisualStyleBackColor = true;
            // 
            // rbBookFalse
            // 
            this.rbBookFalse.AutoSize = true;
            this.rbBookFalse.Location = new System.Drawing.Point(235, 267);
            this.rbBookFalse.Name = "rbBookFalse";
            this.rbBookFalse.Size = new System.Drawing.Size(69, 23);
            this.rbBookFalse.TabIndex = 6;
            this.rbBookFalse.TabStop = true;
            this.rbBookFalse.Text = "False";
            this.rbBookFalse.UseVisualStyleBackColor = true;
            // 
            // gabBookConfirm
            // 
            this.gabBookConfirm.AnimationHoverSpeed = 0.07F;
            this.gabBookConfirm.AnimationSpeed = 0.03F;
            this.gabBookConfirm.BackColor = System.Drawing.Color.Transparent;
            this.gabBookConfirm.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(149)))), ((int)(((byte)(85)))));
            this.gabBookConfirm.BorderColor = System.Drawing.Color.Black;
            this.gabBookConfirm.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gabBookConfirm.CheckedBorderColor = System.Drawing.Color.Black;
            this.gabBookConfirm.CheckedForeColor = System.Drawing.Color.White;
            this.gabBookConfirm.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gabBookConfirm.CheckedImage")));
            this.gabBookConfirm.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gabBookConfirm.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gabBookConfirm.FocusedColor = System.Drawing.Color.Empty;
            this.gabBookConfirm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gabBookConfirm.ForeColor = System.Drawing.Color.White;
            this.gabBookConfirm.Image = ((System.Drawing.Image)(resources.GetObject("gabBookConfirm.Image")));
            this.gabBookConfirm.ImageSize = new System.Drawing.Size(20, 20);
            this.gabBookConfirm.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gabBookConfirm.Location = new System.Drawing.Point(121, 320);
            this.gabBookConfirm.Name = "gabBookConfirm";
            this.gabBookConfirm.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(149)))), ((int)(((byte)(85)))));
            this.gabBookConfirm.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gabBookConfirm.OnHoverForeColor = System.Drawing.Color.White;
            this.gabBookConfirm.OnHoverImage = null;
            this.gabBookConfirm.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gabBookConfirm.OnPressedColor = System.Drawing.Color.Black;
            this.gabBookConfirm.Radius = 20;
            this.gabBookConfirm.Size = new System.Drawing.Size(180, 42);
            this.gabBookConfirm.TabIndex = 7;
            this.gabBookConfirm.Text = "تأكيد";
            this.gabBookConfirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gabBookConfirm.Click += new System.EventHandler(this.gabBookConfirm_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Borrowing";
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gabBookConfirm);
            this.Controls.Add(this.rbBookFalse);
            this.Controls.Add(this.rbBookTrue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudBookPart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gtbBookName);
            this.Controls.Add(this.lblID);
            this.Name = "BookForm";
            this.Size = new System.Drawing.Size(416, 375);
            this.Load += new System.EventHandler(this.BookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudBookPart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private Guna.UI.WinForms.GunaTextBox gtbBookName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudBookPart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbBookTrue;
        private System.Windows.Forms.RadioButton rbBookFalse;
        private Guna.UI.WinForms.GunaAdvenceButton gabBookConfirm;
        private System.Windows.Forms.Label label3;
    }
}
