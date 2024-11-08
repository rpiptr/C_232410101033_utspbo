namespace C_232410101033_utspbo.View
{
    partial class Registrasi
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnBuatAkun = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(311, 30);
            label1.Name = "label1";
            label1.Size = new Size(144, 38);
            label1.TabIndex = 0;
            label1.Text = "Buat Akun";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 150);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 197);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(179, 147);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(417, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(179, 194);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(417, 27);
            textBox2.TabIndex = 4;
            // 
            // btnBuatAkun
            // 
            btnBuatAkun.Location = new Point(652, 353);
            btnBuatAkun.Name = "btnBuatAkun";
            btnBuatAkun.Size = new Size(94, 29);
            btnBuatAkun.TabIndex = 5;
            btnBuatAkun.Text = "Buat Akun";
            btnBuatAkun.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Location = new Point(539, 353);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Kembali";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Registrasi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnBuatAkun);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Registrasi";
            Text = "Registrasi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnBuatAkun;
        private Button button1;
    }
}