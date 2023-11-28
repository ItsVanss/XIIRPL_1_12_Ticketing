namespace XIIRPL_1_12_Ticketing.TransactionForm
{
    partial class FrmCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomer));
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox4 = new PictureBox();
            label3 = new Label();
            txtLokasiKeberangakatan = new TextBox();
            label4 = new Label();
            pictureBox5 = new PictureBox();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            pictureBox6 = new PictureBox();
            txtTujuanKeberangkatan = new TextBox();
            label6 = new Label();
            pictureBox7 = new PictureBox();
            nJumlahPenumpang = new NumericUpDown();
            btnCariPenerbangan = new Button();
            pictureBox8 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nJumlahPenumpang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 93, 169);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(692, 30);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(741, 30);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(206, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(40, 110);
            label1.Name = "label1";
            label1.Size = new Size(72, 30);
            label1.TabIndex = 1;
            label1.Text = "Halo !";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(43, 141);
            label2.Name = "label2";
            label2.Size = new Size(249, 17);
            label2.TabIndex = 2;
            label2.Text = "Mau pergi ke mana hari ini, [nama akun]?";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(44, 178);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 30);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(85, 175);
            label3.Name = "label3";
            label3.Size = new Size(93, 17);
            label3.TabIndex = 4;
            label3.Text = "Berangkat dari";
            label3.Click += label3_Click;
            // 
            // txtLokasiKeberangakatan
            // 
            txtLokasiKeberangakatan.Location = new Point(88, 196);
            txtLokasiKeberangakatan.Name = "txtLokasiKeberangakatan";
            txtLokasiKeberangakatan.Size = new Size(233, 23);
            txtLokasiKeberangakatan.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(85, 239);
            label4.Name = "label4";
            label4.Size = new Size(116, 17);
            label4.TabIndex = 7;
            label4.Text = "Tanggal Berangkat";
            label4.Click += label4_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(44, 242);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(30, 30);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 6;
            pictureBox5.TabStop = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(88, 260);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(233, 23);
            dateTimePicker1.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(402, 239);
            label5.Name = "label5";
            label5.Size = new Size(121, 17);
            label5.TabIndex = 14;
            label5.Text = "Jumlah Penumpang";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(361, 242);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(30, 30);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 13;
            pictureBox6.TabStop = false;
            // 
            // txtTujuanKeberangkatan
            // 
            txtTujuanKeberangkatan.Location = new Point(405, 196);
            txtTujuanKeberangkatan.Name = "txtTujuanKeberangkatan";
            txtTujuanKeberangkatan.Size = new Size(233, 23);
            txtTujuanKeberangkatan.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(402, 175);
            label6.Name = "label6";
            label6.Size = new Size(46, 17);
            label6.TabIndex = 11;
            label6.Text = "Tujuan";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(361, 178);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(30, 30);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 10;
            pictureBox7.TabStop = false;
            // 
            // nJumlahPenumpang
            // 
            nJumlahPenumpang.Location = new Point(405, 260);
            nJumlahPenumpang.Name = "nJumlahPenumpang";
            nJumlahPenumpang.Size = new Size(233, 23);
            nJumlahPenumpang.TabIndex = 17;
            // 
            // btnCariPenerbangan
            // 
            btnCariPenerbangan.Location = new Point(88, 307);
            btnCariPenerbangan.Name = "btnCariPenerbangan";
            btnCariPenerbangan.Size = new Size(157, 27);
            btnCariPenerbangan.TabIndex = 18;
            btnCariPenerbangan.Text = "Cari Penerbangan";
            btnCariPenerbangan.UseVisualStyleBackColor = true;
            btnCariPenerbangan.Click += button1_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(541, 350);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(259, 100);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 19;
            pictureBox8.TabStop = false;
            // 
            // FrmCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox8);
            Controls.Add(btnCariPenerbangan);
            Controls.Add(nJumlahPenumpang);
            Controls.Add(label5);
            Controls.Add(pictureBox6);
            Controls.Add(txtTujuanKeberangkatan);
            Controls.Add(label6);
            Controls.Add(pictureBox7);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(pictureBox5);
            Controls.Add(txtLokasiKeberangakatan);
            Controls.Add(label3);
            Controls.Add(pictureBox4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "FrmCustomer";
            Text = "FrmCustomer";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)nJumlahPenumpang).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox4;
        private Label label3;
        private TextBox txtLokasiKeberangakatan;
        private Label label4;
        private PictureBox pictureBox5;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private PictureBox pictureBox6;
        private TextBox txtTujuanKeberangkatan;
        private Label label6;
        private PictureBox pictureBox7;
        private NumericUpDown nJumlahPenumpang;
        private Button btnCariPenerbangan;
        private PictureBox pictureBox8;
    }
}