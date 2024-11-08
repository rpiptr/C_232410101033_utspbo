namespace C_232410101033_utspbo
{
    partial class Welcome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            btnInventaris = new Button();
            btnRegistrasi = new Button();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(88, 72);
            label1.Name = "label1";
            label1.Size = new Size(634, 46);
            label1.TabIndex = 0;
            label1.Text = "Welcome To Inventory Management App";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(272, 169);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 1;
            label2.Text = "Lanjutkan ke";
            // 
            // btnInventaris
            // 
            btnInventaris.Location = new Point(307, 203);
            btnInventaris.Name = "btnInventaris";
            btnInventaris.Size = new Size(174, 29);
            btnInventaris.TabIndex = 2;
            btnInventaris.Text = "Halaman Inventaris";
            btnInventaris.UseVisualStyleBackColor = true;
            btnInventaris.Click += btnInventaris_Click;
            // 
            // btnRegistrasi
            // 
            btnRegistrasi.Location = new Point(307, 248);
            btnRegistrasi.Name = "btnRegistrasi";
            btnRegistrasi.Size = new Size(174, 29);
            btnRegistrasi.TabIndex = 3;
            btnRegistrasi.Text = "Registrasi";
            btnRegistrasi.UseVisualStyleBackColor = true;
            btnRegistrasi.Click += btnRegistrasi_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(307, 293);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(174, 29);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(btnRegistrasi);
            Controls.Add(btnInventaris);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Welcome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Welcome";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnInventaris;
        private Button btnRegistrasi;
        private Button btnLogin;
    }
}
