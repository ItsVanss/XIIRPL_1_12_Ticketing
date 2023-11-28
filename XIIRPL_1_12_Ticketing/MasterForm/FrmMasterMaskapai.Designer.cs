namespace XIIRPL_1_12_Ticketing.MasterForm
{
    partial class FrmMasterMaskapai
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
            txtPerusahaan = new TextBox();
            txtNama = new TextBox();
            rtbDeskripsi = new RichTextBox();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            dgvMaskapai = new DataGridView();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            label2 = new Label();
            label1 = new Label();
            nJumlahKru = new NumericUpDown();
            id = new TextBox();
            btnEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMaskapai).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nJumlahKru).BeginInit();
            SuspendLayout();
            // 
            // btnSimpan
            // 
            btnSimpan.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSimpan.Location = new Point(685, 392);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(75, 23);
            btnSimpan.TabIndex = 45;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnBatal
            // 
            btnBatal.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnBatal.Location = new Point(593, 392);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(75, 23);
            btnBatal.TabIndex = 44;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            // 
            // txtPerusahaan
            // 
            txtPerusahaan.Location = new Point(142, 320);
            txtPerusahaan.Name = "txtPerusahaan";
            txtPerusahaan.Size = new Size(264, 23);
            txtPerusahaan.TabIndex = 42;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(142, 285);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(264, 23);
            txtNama.TabIndex = 41;
            // 
            // rtbDeskripsi
            // 
            rtbDeskripsi.Location = new Point(508, 285);
            rtbDeskripsi.Name = "rtbDeskripsi";
            rtbDeskripsi.Size = new Size(252, 87);
            rtbDeskripsi.TabIndex = 40;
            rtbDeskripsi.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(441, 287);
            label7.Name = "label7";
            label7.Size = new Size(61, 17);
            label7.TabIndex = 39;
            label7.Text = "Deskripsi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(42, 357);
            label5.Name = "label5";
            label5.Size = new Size(72, 17);
            label5.TabIndex = 38;
            label5.Text = "Jumlah Kru";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(42, 322);
            label4.Name = "label4";
            label4.Size = new Size(75, 17);
            label4.TabIndex = 37;
            label4.Text = "Perusahaan";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(42, 287);
            label3.Name = "label3";
            label3.Size = new Size(43, 17);
            label3.TabIndex = 36;
            label3.Text = "Nama";
            // 
            // dgvMaskapai
            // 
            dgvMaskapai.BackgroundColor = Color.White;
            dgvMaskapai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaskapai.Columns.AddRange(new DataGridViewColumn[] { Edit, Delete });
            dgvMaskapai.Location = new Point(46, 95);
            dgvMaskapai.Name = "dgvMaskapai";
            dgvMaskapai.RowTemplate.Height = 25;
            dgvMaskapai.Size = new Size(714, 167);
            dgvMaskapai.TabIndex = 35;
            dgvMaskapai.CellClick += dgvMaskapai_CellClick;
            dgvMaskapai.CellContentClick += dgvMaskapai_CellContentClick;
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
            label1.Size = new Size(208, 32);
            label1.TabIndex = 33;
            label1.Text = "Master Maskapai";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nJumlahKru
            // 
            nJumlahKru.Location = new Point(142, 355);
            nJumlahKru.Name = "nJumlahKru";
            nJumlahKru.Size = new Size(264, 23);
            nJumlahKru.TabIndex = 46;
            // 
            // id
            // 
            id.Location = new Point(412, 355);
            id.Name = "id";
            id.Size = new Size(83, 23);
            id.TabIndex = 47;
            id.Visible = false;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.Location = new Point(498, 392);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 48;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // FrmMasterMaskapai
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEdit);
            Controls.Add(id);
            Controls.Add(nJumlahKru);
            Controls.Add(btnSimpan);
            Controls.Add(btnBatal);
            Controls.Add(txtPerusahaan);
            Controls.Add(txtNama);
            Controls.Add(rtbDeskripsi);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dgvMaskapai);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmMasterMaskapai";
            Text = "                                  ";
            Load += FrmMasterMaskapai_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMaskapai).EndInit();
            ((System.ComponentModel.ISupportInitialize)nJumlahKru).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSimpan;
        private Button btnBatal;
        private TextBox txtPerusahaan;
        private TextBox txtNama;
        private RichTextBox rtbDeskripsi;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private DataGridView dgvMaskapai;
        private Label label2;
        private Label label1;
        private NumericUpDown nJumlahKru;
        private TextBox id;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private Button btnEdit;
    }
}