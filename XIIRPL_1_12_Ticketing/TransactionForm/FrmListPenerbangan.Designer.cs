namespace XIIRPL_1_12_Ticketing.TransactionForm
{
    partial class FrmListPenerbangan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListPenerbangan));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            pictureBox4 = new PictureBox();
            groupBox1 = new GroupBox();
            btnPenerapanFilter = new Button();
            cbUrutkanBerdasarkan = new ComboBox();
            label8 = new Label();
            ckbMalamHari = new CheckBox();
            ckbSiangSoreHari = new CheckBox();
            ckbPagiHari = new CheckBox();
            ckbDiniHari = new CheckBox();
            label7 = new Label();
            label6 = new Label();
            dgvListPenerbangan = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListPenerbangan).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(40, 14);
            label1.Name = "label1";
            label1.Size = new Size(182, 30);
            label1.TabIndex = 1;
            label1.Text = "List Penerbangan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(70, 70, 70);
            label2.Location = new Point(44, 46);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 2;
            label2.Text = "Surabaya (SUB)";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(143, 46);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(15, 15);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(70, 70, 70);
            label3.Location = new Point(170, 46);
            label3.Name = "label3";
            label3.Size = new Size(124, 15);
            label3.TabIndex = 4;
            label3.Text = "Soekarno-Hatta (CGK)";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(305, 47);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(10, 10);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(70, 70, 70);
            label4.Location = new Point(331, 46);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 6;
            label4.Text = "Mon, 22 May 2023";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(70, 70, 70);
            label5.Location = new Point(471, 47);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 8;
            label5.Text = "1 Penumpang";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(445, 48);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(10, 10);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnPenerapanFilter);
            groupBox1.Controls.Add(cbUrutkanBerdasarkan);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(ckbMalamHari);
            groupBox1.Controls.Add(ckbSiangSoreHari);
            groupBox1.Controls.Add(ckbPagiHari);
            groupBox1.Controls.Add(ckbDiniHari);
            groupBox1.Controls.Add(label7);
            groupBox1.Location = new Point(12, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(765, 139);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnPenerapanFilter
            // 
            btnPenerapanFilter.Location = new Point(626, 95);
            btnPenerapanFilter.Name = "btnPenerapanFilter";
            btnPenerapanFilter.Size = new Size(113, 23);
            btnPenerapanFilter.TabIndex = 10;
            btnPenerapanFilter.Text = "Terapkan Filter";
            btnPenerapanFilter.UseVisualStyleBackColor = true;
            // 
            // cbUrutkanBerdasarkan
            // 
            cbUrutkanBerdasarkan.FormattingEnabled = true;
            cbUrutkanBerdasarkan.Location = new Point(20, 95);
            cbUrutkanBerdasarkan.Name = "cbUrutkanBerdasarkan";
            cbUrutkanBerdasarkan.Size = new Size(213, 23);
            cbUrutkanBerdasarkan.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(18, 77);
            label8.Name = "label8";
            label8.Size = new Size(116, 15);
            label8.TabIndex = 8;
            label8.Text = "Urutkan Berdasarkan";
            // 
            // ckbMalamHari
            // 
            ckbMalamHari.AutoSize = true;
            ckbMalamHari.Location = new Point(335, 40);
            ckbMalamHari.Name = "ckbMalamHari";
            ckbMalamHari.Size = new Size(91, 19);
            ckbMalamHari.TabIndex = 7;
            ckbMalamHari.Text = "18:00 - 24:00";
            ckbMalamHari.UseVisualStyleBackColor = true;
            // 
            // ckbSiangSoreHari
            // 
            ckbSiangSoreHari.AutoSize = true;
            ckbSiangSoreHari.Location = new Point(230, 40);
            ckbSiangSoreHari.Name = "ckbSiangSoreHari";
            ckbSiangSoreHari.Size = new Size(91, 19);
            ckbSiangSoreHari.TabIndex = 6;
            ckbSiangSoreHari.Text = "12:00 - 18:00";
            ckbSiangSoreHari.UseVisualStyleBackColor = true;
            // 
            // ckbPagiHari
            // 
            ckbPagiHari.AutoSize = true;
            ckbPagiHari.Location = new Point(125, 40);
            ckbPagiHari.Name = "ckbPagiHari";
            ckbPagiHari.Size = new Size(91, 19);
            ckbPagiHari.TabIndex = 5;
            ckbPagiHari.Text = "06:00 - 12:00";
            ckbPagiHari.UseVisualStyleBackColor = true;
            // 
            // ckbDiniHari
            // 
            ckbDiniHari.AutoSize = true;
            ckbDiniHari.Location = new Point(20, 40);
            ckbDiniHari.Name = "ckbDiniHari";
            ckbDiniHari.Size = new Size(91, 19);
            ckbDiniHari.TabIndex = 4;
            ckbDiniHari.Text = "00:00 - 06:00";
            ckbDiniHari.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(18, 19);
            label7.Name = "label7";
            label7.Size = new Size(123, 15);
            label7.TabIndex = 3;
            label7.Text = "Waktu Keberangkatan";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(70, 70, 70);
            label6.Location = new Point(357, 218);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 10;
            // 
            // dgvListPenerbangan
            // 
            dgvListPenerbangan.BackgroundColor = Color.White;
            dgvListPenerbangan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListPenerbangan.GridColor = Color.White;
            dgvListPenerbangan.Location = new Point(12, 236);
            dgvListPenerbangan.Name = "dgvListPenerbangan";
            dgvListPenerbangan.RowTemplate.Height = 25;
            dgvListPenerbangan.Size = new Size(765, 263);
            dgvListPenerbangan.TabIndex = 11;
            // 
            // FrmListPenerbangan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 530);
            Controls.Add(dgvListPenerbangan);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(pictureBox4);
            Controls.Add(label4);
            Controls.Add(pictureBox3);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "FrmListPenerbangan";
            Text = "FrmListPenerbangan";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListPenerbangan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox2;
        private Label label3;
        private PictureBox pictureBox3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox4;
        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private CheckBox ckbMalamHari;
        private CheckBox ckbSiangSoreHari;
        private CheckBox ckbPagiHari;
        private CheckBox ckbDiniHari;
        private Button btnPenerapanFilter;
        private ComboBox cbUrutkanBerdasarkan;
        private Label label8;
        private DataGridView dgvListPenerbangan;
    }
}