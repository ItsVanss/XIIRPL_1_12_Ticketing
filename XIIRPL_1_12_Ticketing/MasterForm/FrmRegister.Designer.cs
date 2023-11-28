namespace XIIRPL_1_12_Ticketing.MasterForm
{
    partial class FrmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegister));
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtUsername = new TextBox();
            txtNama = new TextBox();
            txtTanggalLahir = new DateTimePicker();
            txtNomorTlp = new TextBox();
            txtPassword = new TextBox();
            pictureBox1 = new PictureBox();
            btnDaftar = new Button();
            label8 = new Label();
            txtLinkLabel = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(32, 110);
            label3.Name = "label3";
            label3.Size = new Size(67, 17);
            label3.TabIndex = 5;
            label3.Text = "Username";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            label3.Click += label3_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(31, 53);
            label2.Name = "label2";
            label2.Size = new Size(331, 17);
            label2.TabIndex = 4;
            label2.Text = "Daftarkan diri Anda untuk menggunakan Bromo Airlines";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(28, 19);
            label1.Name = "label1";
            label1.Size = new Size(153, 32);
            label1.TabIndex = 3;
            label1.Text = "Daftar Akun";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(32, 150);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(43, 17);
            label4.TabIndex = 6;
            label4.Text = "Nama";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(32, 190);
            label5.Name = "label5";
            label5.Size = new Size(86, 17);
            label5.TabIndex = 7;
            label5.Text = "Tanggal Lahir";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(32, 230);
            label6.Name = "label6";
            label6.Size = new Size(100, 17);
            label6.TabIndex = 8;
            label6.Text = "Nomor Telepon";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(32, 270);
            label7.Name = "label7";
            label7.Size = new Size(64, 17);
            label7.TabIndex = 9;
            label7.Text = "Password";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(180, 105);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(217, 23);
            txtUsername.TabIndex = 10;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(180, 145);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(217, 23);
            txtNama.TabIndex = 11;
            // 
            // txtTanggalLahir
            // 
            txtTanggalLahir.Location = new Point(180, 185);
            txtTanggalLahir.Name = "txtTanggalLahir";
            txtTanggalLahir.Size = new Size(217, 23);
            txtTanggalLahir.TabIndex = 12;
            // 
            // txtNomorTlp
            // 
            txtNomorTlp.Location = new Point(180, 225);
            txtNomorTlp.Name = "txtNomorTlp";
            txtNomorTlp.Size = new Size(217, 23);
            txtNomorTlp.TabIndex = 13;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(180, 265);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(217, 23);
            txtPassword.TabIndex = 14;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(427, 96);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(340, 250);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // btnDaftar
            // 
            btnDaftar.Location = new Point(322, 305);
            btnDaftar.Name = "btnDaftar";
            btnDaftar.Size = new Size(75, 23);
            btnDaftar.TabIndex = 16;
            btnDaftar.Text = "Daftar";
            btnDaftar.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(32, 400);
            label8.Name = "label8";
            label8.Size = new Size(120, 17);
            label8.TabIndex = 17;
            label8.Text = "Sudah punya akun?";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtLinkLabel
            // 
            txtLinkLabel.AutoSize = true;
            txtLinkLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtLinkLabel.Location = new Point(154, 400);
            txtLinkLabel.Name = "txtLinkLabel";
            txtLinkLabel.Size = new Size(40, 17);
            txtLinkLabel.TabIndex = 18;
            txtLinkLabel.TabStop = true;
            txtLinkLabel.Text = "Login";
            txtLinkLabel.LinkClicked += txtLinkLabel_LinkClicked;
            // 
            // FrmRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(txtLinkLabel);
            Controls.Add(label8);
            Controls.Add(btnDaftar);
            Controls.Add(pictureBox1);
            Controls.Add(txtPassword);
            Controls.Add(txtNomorTlp);
            Controls.Add(txtTanggalLahir);
            Controls.Add(txtNama);
            Controls.Add(txtUsername);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmRegister";
            Text = "FrmRegister";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtUsername;
        private TextBox txtNama;
        private DateTimePicker txtTanggalLahir;
        private TextBox txtNomorTlp;
        private TextBox txtPassword;
        private PictureBox pictureBox1;
        private Button btnDaftar;
        private Label label8;
        private LinkLabel txtLinkLabel;
    }
}