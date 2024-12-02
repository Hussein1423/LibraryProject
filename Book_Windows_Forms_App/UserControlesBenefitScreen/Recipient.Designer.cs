namespace Book_Windows_Forms_App.UserControlesBenefitScreen
{
    partial class Recipient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recipient));
            this.gcbRecipient = new Guna.UI.WinForms.GunaComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBook = new System.Windows.Forms.Label();
            this.lblPart = new System.Windows.Forms.Label();
            this.gabConfirm = new Guna.UI.WinForms.GunaAdvenceButton();
            this.SuspendLayout();
            // 
            // gcbRecipient
            // 
            this.gcbRecipient.BackColor = System.Drawing.Color.Transparent;
            this.gcbRecipient.BaseColor = System.Drawing.Color.White;
            this.gcbRecipient.BorderColor = System.Drawing.Color.Silver;
            this.gcbRecipient.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gcbRecipient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gcbRecipient.FocusedColor = System.Drawing.Color.Empty;
            this.gcbRecipient.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gcbRecipient.ForeColor = System.Drawing.Color.Black;
            this.gcbRecipient.FormattingEnabled = true;
            this.gcbRecipient.Location = new System.Drawing.Point(229, 111);
            this.gcbRecipient.Name = "gcbRecipient";
            this.gcbRecipient.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gcbRecipient.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gcbRecipient.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gcbRecipient.Size = new System.Drawing.Size(316, 35);
            this.gcbRecipient.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(482, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "مستفيد";
            // 
            // lblBook
            // 
            this.lblBook.AutoSize = true;
            this.lblBook.Location = new System.Drawing.Point(371, 32);
            this.lblBook.Name = "lblBook";
            this.lblBook.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblBook.Size = new System.Drawing.Size(57, 19);
            this.lblBook.TabIndex = 2;
            this.lblBook.Text = "label2:";
            // 
            // lblPart
            // 
            this.lblPart.AutoSize = true;
            this.lblPart.Location = new System.Drawing.Point(325, 32);
            this.lblPart.Name = "lblPart";
            this.lblPart.Size = new System.Drawing.Size(51, 19);
            this.lblPart.TabIndex = 3;
            this.lblPart.Text = "label2";
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
            this.gabConfirm.Image = ((System.Drawing.Image)(resources.GetObject("gabConfirm.Image")));
            this.gabConfirm.ImageSize = new System.Drawing.Size(20, 20);
            this.gabConfirm.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gabConfirm.Location = new System.Drawing.Point(581, 104);
            this.gabConfirm.Name = "gabConfirm";
            this.gabConfirm.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(149)))), ((int)(((byte)(85)))));
            this.gabConfirm.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gabConfirm.OnHoverForeColor = System.Drawing.Color.White;
            this.gabConfirm.OnHoverImage = null;
            this.gabConfirm.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gabConfirm.OnPressedColor = System.Drawing.Color.Black;
            this.gabConfirm.Radius = 20;
            this.gabConfirm.Size = new System.Drawing.Size(180, 42);
            this.gabConfirm.TabIndex = 4;
            this.gabConfirm.Text = "Confirm";
            this.gabConfirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gabConfirm.Click += new System.EventHandler(this.gabConfirm_Click);
            // 
            // Recipient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 195);
            this.Controls.Add(this.gabConfirm);
            this.Controls.Add(this.lblPart);
            this.Controls.Add(this.lblBook);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gcbRecipient);
            this.Name = "Recipient";
            this.Text = "Recipient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaComboBox gcbRecipient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.Label lblPart;
        private Guna.UI.WinForms.GunaAdvenceButton gabConfirm;
    }
}