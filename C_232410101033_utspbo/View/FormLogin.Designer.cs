namespace C_232410101033_utspbo.View
{
    partial class FormLogin
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            btnMasuk = new Button();
            btnKembali = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(344, 111);
            label1.Name = "label1";
            label1.Size = new Size(92, 41);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(164, 190);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(164, 246);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(275, 187);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(334, 27);
            tbUsername.TabIndex = 3;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(275, 243);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(334, 27);
            tbPassword.TabIndex = 4;
            // 
            // btnMasuk
            // 
            btnMasuk.Location = new Point(656, 357);
            btnMasuk.Name = "btnMasuk";
            btnMasuk.Size = new Size(94, 29);
            btnMasuk.TabIndex = 5;
            btnMasuk.Text = "Masuk";
            btnMasuk.UseVisualStyleBackColor = true;
            btnMasuk.Click += btnMasuk_Click;
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.FromArgb(255, 128, 128);
            btnKembali.ForeColor = Color.Black;
            btnKembali.Location = new Point(556, 357);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(94, 29);
            btnKembali.TabIndex = 6;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(btnKembali);
            Controls.Add(btnMasuk);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormLogin";
            Text = "FormLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private Button btnMasuk;
        private Button btnKembali;
    }
}