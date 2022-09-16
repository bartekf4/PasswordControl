namespace PasswordControl
{
    partial class UserControl1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.characters_pictureBox = new System.Windows.Forms.PictureBox();
            this.special_char_pictureBox = new System.Windows.Forms.PictureBox();
            this.confirm_button = new System.Windows.Forms.Button();
            this.capital_char_pictureBox = new System.Windows.Forms.PictureBox();
            this.digit_pictureBox = new System.Windows.Forms.PictureBox();
            this.special_char_label = new System.Windows.Forms.Label();
            this.capital_char_label = new System.Windows.Forms.Label();
            this.digit_label = new System.Windows.Forms.Label();
            this.characters_label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.characters_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.special_char_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capital_char_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digit_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.875F));
            this.tableLayoutPanel1.Controls.Add(this.password_textBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.characters_pictureBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.special_char_pictureBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.confirm_button, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.capital_char_pictureBox, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.digit_pictureBox, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.special_char_label, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.capital_char_label, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.digit_label, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.characters_label, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // password_textBox
            // 
            this.password_textBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.password_textBox.Location = new System.Drawing.Point(268, 93);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(472, 22);
            this.password_textBox.TabIndex = 1;
            this.password_textBox.UseSystemPasswordChar = true;
            this.password_textBox.TextChanged += new System.EventHandler(this.password_textBox_TextChanged);
            // 
            // characters_pictureBox
            // 
            this.characters_pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.characters_pictureBox.Location = new System.Drawing.Point(222, 212);
            this.characters_pictureBox.Name = "characters_pictureBox";
            this.characters_pictureBox.Size = new System.Drawing.Size(40, 44);
            this.characters_pictureBox.TabIndex = 2;
            this.characters_pictureBox.TabStop = false;
            // 
            // special_char_pictureBox
            // 
            this.special_char_pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.special_char_pictureBox.Location = new System.Drawing.Point(222, 262);
            this.special_char_pictureBox.Name = "special_char_pictureBox";
            this.special_char_pictureBox.Size = new System.Drawing.Size(40, 44);
            this.special_char_pictureBox.TabIndex = 3;
            this.special_char_pictureBox.TabStop = false;
            // 
            // confirm_button
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.confirm_button, 2);
            this.confirm_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.confirm_button.Enabled = false;
            this.confirm_button.Location = new System.Drawing.Point(3, 412);
            this.confirm_button.Name = "confirm_button";
            this.confirm_button.Size = new System.Drawing.Size(794, 35);
            this.confirm_button.TabIndex = 4;
            this.confirm_button.Text = "Confirm";
            this.confirm_button.UseVisualStyleBackColor = true;
            this.confirm_button.Click += new System.EventHandler(this.confirm_button_Click);
            // 
            // capital_char_pictureBox
            // 
            this.capital_char_pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.capital_char_pictureBox.Location = new System.Drawing.Point(222, 312);
            this.capital_char_pictureBox.Name = "capital_char_pictureBox";
            this.capital_char_pictureBox.Size = new System.Drawing.Size(40, 44);
            this.capital_char_pictureBox.TabIndex = 5;
            this.capital_char_pictureBox.TabStop = false;
            // 
            // digit_pictureBox
            // 
            this.digit_pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.digit_pictureBox.Location = new System.Drawing.Point(222, 362);
            this.digit_pictureBox.Name = "digit_pictureBox";
            this.digit_pictureBox.Size = new System.Drawing.Size(40, 44);
            this.digit_pictureBox.TabIndex = 6;
            this.digit_pictureBox.TabStop = false;
            // 
            // special_char_label
            // 
            this.special_char_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.special_char_label.AutoSize = true;
            this.special_char_label.Location = new System.Drawing.Point(268, 259);
            this.special_char_label.Name = "special_char_label";
            this.special_char_label.Size = new System.Drawing.Size(182, 50);
            this.special_char_label.TabIndex = 8;
            this.special_char_label.Text = "at least one special character";
            this.special_char_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // capital_char_label
            // 
            this.capital_char_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.capital_char_label.AutoSize = true;
            this.capital_char_label.Location = new System.Drawing.Point(268, 309);
            this.capital_char_label.Name = "capital_char_label";
            this.capital_char_label.Size = new System.Drawing.Size(44, 50);
            this.capital_char_label.TabIndex = 9;
            this.capital_char_label.Text = "label4";
            this.capital_char_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // digit_label
            // 
            this.digit_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.digit_label.AutoSize = true;
            this.digit_label.Location = new System.Drawing.Point(268, 359);
            this.digit_label.Name = "digit_label";
            this.digit_label.Size = new System.Drawing.Size(44, 50);
            this.digit_label.TabIndex = 10;
            this.digit_label.Text = "label5";
            this.digit_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // characters_label
            // 
            this.characters_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.characters_label.AutoSize = true;
            this.characters_label.Location = new System.Drawing.Point(268, 209);
            this.characters_label.Name = "characters_label";
            this.characters_label.Size = new System.Drawing.Size(126, 50);
            this.characters_label.TabIndex = 7;
            this.characters_label.Text = "at least 8 characters";
            this.characters_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.characters_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.special_char_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capital_char_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digit_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.PictureBox characters_pictureBox;
        private System.Windows.Forms.PictureBox special_char_pictureBox;
        private System.Windows.Forms.Button confirm_button;
        private System.Windows.Forms.PictureBox capital_char_pictureBox;
        private System.Windows.Forms.PictureBox digit_pictureBox;
        private System.Windows.Forms.Label characters_label;
        private System.Windows.Forms.Label special_char_label;
        private System.Windows.Forms.Label capital_char_label;
        private System.Windows.Forms.Label digit_label;
    }
}
