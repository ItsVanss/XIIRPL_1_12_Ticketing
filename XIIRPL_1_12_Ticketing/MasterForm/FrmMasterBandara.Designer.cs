namespace XIIRPL_1_12_Ticketing.MasterForm
{
    partial class FrmMasterBandara
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
            txtNegara = new ComboBox();
            txtKota = new TextBox();
            txtKodeIATA = new TextBox();
            txtNama = new TextBox();
            txtAlamat = new RichTextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvBandara = new DataGridView();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            txtJumlahTerminal = new NumericUpDown();
            id = new TextBox();
            btnEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBandara).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtJumlahTerminal).BeginInit();
            SuspendLayout();
            // 
            // btnSimpan
            // 
            btnSimpan.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSimpan.Location = new Point(593, 423);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(75, 23);
            btnSimpan.TabIndex = 51;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnBatal
            // 
            btnBatal.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnBatal.Location = new Point(685, 423);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(75, 23);
            btnBatal.TabIndex = 50;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            // 
            // txtNegara
            // 
            txtNegara.FormattingEnabled = true;
            txtNegara.Location = new Point(146, 390);
            txtNegara.Name = "txtNegara";
            txtNegara.Size = new Size(264, 23);
            txtNegara.TabIndex = 49;
            // 
            // txtKota
            // 
            txtKota.Location = new Point(146, 355);
            txtKota.Name = "txtKota";
            txtKota.Size = new Size(264, 23);
            txtKota.TabIndex = 48;
            // 
            // txtKodeIATA
            // 
            txtKodeIATA.Location = new Point(146, 320);
            txtKodeIATA.Name = "txtKodeIATA";
            txtKodeIATA.Size = new Size(264, 23);
            txtKodeIATA.TabIndex = 47;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(146, 285);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(264, 23);
            txtNama.TabIndex = 46;
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(553, 330);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(207, 87);
            txtAlamat.TabIndex = 45;
            txtAlamat.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(445, 331);
            label8.Name = "label8";
            label8.Size = new Size(48, 17);
            label8.TabIndex = 44;
            label8.Text = "Alamat";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(445, 288);
            label7.Name = "label7";
            label7.Size = new Size(101, 17);
            label7.TabIndex = 43;
            label7.Text = "Jumlah Terminal";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(46, 392);
            label6.Name = "label6";
            label6.Size = new Size(52, 17);
            label6.TabIndex = 42;
            label6.Text = "Negara";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(46, 357);
            label5.Name = "label5";
            label5.Size = new Size(35, 17);
            label5.TabIndex = 41;
            label5.Text = "Kota";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(46, 322);
            label4.Name = "label4";
            label4.Size = new Size(67, 17);
            label4.TabIndex = 40;
            label4.Text = "Kode IATA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(46, 288);
            label3.Name = "label3";
            label3.Size = new Size(43, 17);
            label3.TabIndex = 39;
            label3.Text = "Nama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(44, 63);
            label2.Name = "label2";
            label2.Size = new Size(271, 15);
            label2.TabIndex = 38;
            label2.Text = "Semua bandara yang terdaftar akan muncul di sini";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(46, 31);
            label1.Name = "label1";
            label1.Size = new Size(194, 32);
            label1.TabIndex = 37;
            label1.Text = "Master Bandara";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvBandara
            // 
            dgvBandara.BackgroundColor = Color.White;
            dgvBandara.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBandara.Columns.AddRange(new DataGridViewColumn[] { Edit, Delete });
            dgvBandara.Location = new Point(46, 96);
            dgvBandara.Name = "dgvBandara";
            dgvBandara.RowTemplate.Height = 25;
            dgvBandara.Size = new Size(714, 167);
            dgvBandara.TabIndex = 36;
            dgvBandara.CellClick += dgvBandara_CellClick;
            dgvBandara.CellContentClick += dgvBandara_CellContentClick;
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
            // txtJumlahTerminal
            // 
            txtJumlahTerminal.Location = new Point(553, 285);
            txtJumlahTerminal.Name = "txtJumlahTerminal";
            txtJumlahTerminal.Size = new Size(207, 23);
            txtJumlahTerminal.TabIndex = 35;
            // 
            // id
            // 
            id.Location = new Point(431, 391);
            id.Name = "id";
            id.Size = new Size(100, 23);
            id.TabIndex = 52;
            id.Visible = false;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.Location = new Point(499, 423);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 53;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += button1_Click;
            // 
            // FrmMasterBandara
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 483);
            Controls.Add(btnEdit);
            Controls.Add(id);
            Controls.Add(btnSimpan);
            Controls.Add(btnBatal);
            Controls.Add(txtNegara);
            Controls.Add(txtKota);
            Controls.Add(txtKodeIATA);
            Controls.Add(txtNama);
            Controls.Add(txtAlamat);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvBandara);
            Controls.Add(txtJumlahTerminal);
            Name = "FrmMasterBandara";
            Text = "FrmMasterBandara";
            Load += FrmMasterBandara_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBandara).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtJumlahTerminal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSimpan;
        private Button btnBatal;
        private ComboBox txtNegara;
        private TextBox txtKota;
        private TextBox txtKodeIATA;
        private TextBox txtNama;
        private RichTextBox txtAlamat;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvBandara;
        private NumericUpDown txtJumlahTerminal;
        private TextBox id;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private Button btnEdit;
    }
}