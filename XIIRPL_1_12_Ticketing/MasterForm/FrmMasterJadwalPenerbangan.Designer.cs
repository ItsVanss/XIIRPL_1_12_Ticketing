namespace XIIRPL_1_12_Ticketing.MasterForm
{
    partial class FrmMasterJadwalPenerbangan
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
            btnSimpan = new Button();
            btnBatal = new Button();
            txtKodePenerbangan = new TextBox();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            dgvJadwalPenerbangan = new DataGridView();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            label2 = new Label();
            label1 = new Label();
            cbMaskapai = new ComboBox();
            label6 = new Label();
            cbAlamatTujuan = new ComboBox();
            cbAlamatKeberangkatan = new ComboBox();
            dtTanggalKeberangkatan = new DateTimePicker();
            label8 = new Label();
            txtDurasiPenerbangan = new TextBox();
            label9 = new Label();
            label10 = new Label();
            nHarga = new NumericUpDown();
            id = new TextBox();
            dtWaktuKeberangkatan = new DateTimePicker();
            btnEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvJadwalPenerbangan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nHarga).BeginInit();
            SuspendLayout();
            // 
            // btnSimpan
            // 
            btnSimpan.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSimpan.Location = new Point(685, 431);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(75, 23);
            btnSimpan.TabIndex = 45;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnBatal
            // 
            btnBatal.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnBatal.Location = new Point(593, 431);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(75, 23);
            btnBatal.TabIndex = 44;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            // 
            // txtKodePenerbangan
            // 
            txtKodePenerbangan.Location = new Point(171, 285);
            txtKodePenerbangan.Name = "txtKodePenerbangan";
            txtKodePenerbangan.Size = new Size(204, 23);
            txtKodePenerbangan.TabIndex = 41;
            txtKodePenerbangan.TextChanged += txtKodePenerbangan_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(410, 287);
            label7.Name = "label7";
            label7.Size = new Size(54, 17);
            label7.TabIndex = 39;
            label7.Text = "Tanggal";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(42, 357);
            label5.Name = "label5";
            label5.Size = new Size(23, 17);
            label5.TabIndex = 38;
            label5.Text = "Ke";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(42, 322);
            label4.Name = "label4";
            label4.Size = new Size(32, 17);
            label4.TabIndex = 37;
            label4.Text = "Dari";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(42, 287);
            label3.Name = "label3";
            label3.Size = new Size(120, 17);
            label3.TabIndex = 36;
            label3.Text = "Kode Penerbangan";
            // 
            // dgvJadwalPenerbangan
            // 
            dgvJadwalPenerbangan.BackgroundColor = Color.White;
            dgvJadwalPenerbangan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJadwalPenerbangan.Columns.AddRange(new DataGridViewColumn[] { Edit, Delete });
            dgvJadwalPenerbangan.Location = new Point(46, 95);
            dgvJadwalPenerbangan.Name = "dgvJadwalPenerbangan";
            dgvJadwalPenerbangan.RowTemplate.Height = 25;
            dgvJadwalPenerbangan.Size = new Size(714, 167);
            dgvJadwalPenerbangan.TabIndex = 35;
            dgvJadwalPenerbangan.CellClick += dgvJadwalPenerbangan_CellClick;
            dgvJadwalPenerbangan.CellContentClick += dgvJadwalPenerbangan_CellContentClick;
            // 
            // Edit
            // 
            Edit.HeaderText = "Edit";
            Edit.Name = "Edit";
            Edit.Text = "Edit";
            Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.Name = "Delete";
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(44, 63);
            label2.Name = "label2";
            label2.Size = new Size(307, 17);
            label2.TabIndex = 34;
            label2.Text = "Semua maskapai yang terdaftar akan muncul di sini";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(40, 30);
            label1.Name = "label1";
            label1.Size = new Size(336, 32);
            label1.TabIndex = 33;
            label1.Text = "Master Jadwal Penerbangan";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbMaskapai
            // 
            cbMaskapai.FormattingEnabled = true;
            cbMaskapai.Location = new Point(171, 390);
            cbMaskapai.Name = "cbMaskapai";
            cbMaskapai.Size = new Size(204, 23);
            cbMaskapai.TabIndex = 47;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(42, 392);
            label6.Name = "label6";
            label6.Size = new Size(64, 17);
            label6.TabIndex = 46;
            label6.Text = "Maskapai";
            // 
            // cbAlamatTujuan
            // 
            cbAlamatTujuan.FormattingEnabled = true;
            cbAlamatTujuan.Location = new Point(171, 355);
            cbAlamatTujuan.Name = "cbAlamatTujuan";
            cbAlamatTujuan.Size = new Size(204, 23);
            cbAlamatTujuan.TabIndex = 49;
            // 
            // cbAlamatKeberangkatan
            // 
            cbAlamatKeberangkatan.FormattingEnabled = true;
            cbAlamatKeberangkatan.Location = new Point(171, 320);
            cbAlamatKeberangkatan.Name = "cbAlamatKeberangkatan";
            cbAlamatKeberangkatan.Size = new Size(204, 23);
            cbAlamatKeberangkatan.TabIndex = 50;
            // 
            // dtTanggalKeberangkatan
            // 
            dtTanggalKeberangkatan.Location = new Point(547, 285);
            dtTanggalKeberangkatan.Name = "dtTanggalKeberangkatan";
            dtTanggalKeberangkatan.Size = new Size(213, 23);
            dtTanggalKeberangkatan.TabIndex = 51;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(410, 322);
            label8.Name = "label8";
            label8.Size = new Size(135, 17);
            label8.TabIndex = 52;
            label8.Text = "Waktu Keberangkatan";
            // 
            // txtDurasiPenerbangan
            // 
            txtDurasiPenerbangan.Location = new Point(547, 354);
            txtDurasiPenerbangan.Name = "txtDurasiPenerbangan";
            txtDurasiPenerbangan.Size = new Size(213, 23);
            txtDurasiPenerbangan.TabIndex = 56;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(410, 356);
            label9.Name = "label9";
            label9.Size = new Size(126, 17);
            label9.TabIndex = 55;
            label9.Text = "Durasi Penerbangan";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(410, 389);
            label10.Name = "label10";
            label10.Size = new Size(99, 17);
            label10.TabIndex = 57;
            label10.Text = "Harga per Tiket";
            // 
            // nHarga
            // 
            nHarga.Location = new Point(547, 387);
            nHarga.Name = "nHarga";
            nHarga.Size = new Size(213, 23);
            nHarga.TabIndex = 59;
            // 
            // id
            // 
            id.Location = new Point(436, 41);
            id.Name = "id";
            id.Size = new Size(100, 23);
            id.TabIndex = 75;
            id.Visible = false;
            // 
            // dtWaktuKeberangkatan
            // 
            dtWaktuKeberangkatan.Format = DateTimePickerFormat.Time;
            dtWaktuKeberangkatan.Location = new Point(547, 318);
            dtWaktuKeberangkatan.Name = "dtWaktuKeberangkatan";
            dtWaktuKeberangkatan.ShowUpDown = true;
            dtWaktuKeberangkatan.Size = new Size(213, 23);
            dtWaktuKeberangkatan.TabIndex = 76;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.Location = new Point(498, 431);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 77;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // FrmMasterJadwalPenerbangan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 501);
            Controls.Add(btnEdit);
            Controls.Add(dtWaktuKeberangkatan);
            Controls.Add(id);
            Controls.Add(nHarga);
            Controls.Add(label10);
            Controls.Add(txtDurasiPenerbangan);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(dtTanggalKeberangkatan);
            Controls.Add(cbAlamatKeberangkatan);
            Controls.Add(cbAlamatTujuan);
            Controls.Add(cbMaskapai);
            Controls.Add(label6);
            Controls.Add(btnSimpan);
            Controls.Add(btnBatal);
            Controls.Add(txtKodePenerbangan);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dgvJadwalPenerbangan);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmMasterJadwalPenerbangan";
            Text = "FrmMasterJadwalPenerbangan";
            Load += FrmMasterJadwalPenerbangan_Load;
            ((System.ComponentModel.ISupportInitialize)dgvJadwalPenerbangan).EndInit();
            ((System.ComponentModel.ISupportInitialize)nHarga).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSimpan;
        private Button btnBatal;
        private TextBox txtKodePenerbangan;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private DataGridView dgvJadwalPenerbangan;
        private Label label2;
        private Label label1;
        private ComboBox cbMaskapai;
        private Label label6;
        private ComboBox cbAlamatTujuan;
        private ComboBox cbAlamatKeberangkatan;
        private DateTimePicker dtTanggalKeberangkatan;
        private Label label8;
        private TextBox txtDurasiPenerbangan;
        private Label label9;
        private Label label10;
        private NumericUpDown nHarga;
        private TextBox id;
        private DateTimePicker dtWaktuKeberangkatan;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private Button btnEdit;
    }
}