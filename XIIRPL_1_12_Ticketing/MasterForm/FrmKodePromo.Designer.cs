namespace XIIRPL_1_12_Ticketing.MasterForm
{
    partial class FrmKodePromo
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
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvKodePromo = new DataGridView();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            dtKuponKadaluarsa = new DateTimePicker();
            nMaksimumDiskon = new NumericUpDown();
            nPersentaseDiskon = new NumericUpDown();
            txtKodePromo = new TextBox();
            rtbDeskripsiKodePromo = new RichTextBox();
            id = new TextBox();
            btnEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKodePromo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nMaksimumDiskon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nPersentaseDiskon).BeginInit();
            SuspendLayout();
            // 
            // btnSimpan
            // 
            btnSimpan.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSimpan.Location = new Point(685, 425);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(75, 23);
            btnSimpan.TabIndex = 68;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnBatal
            // 
            btnBatal.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnBatal.Location = new Point(593, 425);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(75, 23);
            btnBatal.TabIndex = 67;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(445, 288);
            label7.Name = "label7";
            label7.Size = new Size(61, 17);
            label7.TabIndex = 60;
            label7.Text = "Deskripsi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(46, 392);
            label6.Name = "label6";
            label6.Size = new Size(114, 17);
            label6.TabIndex = 59;
            label6.Text = "Maksimum Diskon";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(46, 357);
            label5.Name = "label5";
            label5.Size = new Size(114, 17);
            label5.TabIndex = 58;
            label5.Text = "Persentase Diskon";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(46, 322);
            label4.Name = "label4";
            label4.Size = new Size(97, 17);
            label4.TabIndex = 57;
            label4.Text = "Berlaku Sampai";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(46, 288);
            label3.Name = "label3";
            label3.Size = new Size(82, 17);
            label3.TabIndex = 56;
            label3.Text = "Kode Promo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(44, 60);
            label2.Name = "label2";
            label2.Size = new Size(325, 17);
            label2.TabIndex = 55;
            label2.Text = "Semua kode promo yang terdaftar akan muncul di sini";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(40, 30);
            label1.Name = "label1";
            label1.Size = new Size(243, 32);
            label1.TabIndex = 54;
            label1.Text = "Master Kode Promo";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvKodePromo
            // 
            dgvKodePromo.BackgroundColor = Color.White;
            dgvKodePromo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKodePromo.Columns.AddRange(new DataGridViewColumn[] { Edit, Delete });
            dgvKodePromo.Location = new Point(46, 96);
            dgvKodePromo.Name = "dgvKodePromo";
            dgvKodePromo.RowTemplate.Height = 25;
            dgvKodePromo.Size = new Size(714, 167);
            dgvKodePromo.TabIndex = 53;
            dgvKodePromo.CellClick += dgvKodePromo_CellClick;
            dgvKodePromo.CellContentClick += dgvKodePromo_CellContentClick;
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
            // dtKuponKadaluarsa
            // 
            dtKuponKadaluarsa.Location = new Point(171, 320);
            dtKuponKadaluarsa.Name = "dtKuponKadaluarsa";
            dtKuponKadaluarsa.Size = new Size(239, 23);
            dtKuponKadaluarsa.TabIndex = 69;
            // 
            // nMaksimumDiskon
            // 
            nMaksimumDiskon.Location = new Point(171, 390);
            nMaksimumDiskon.Name = "nMaksimumDiskon";
            nMaksimumDiskon.Size = new Size(239, 23);
            nMaksimumDiskon.TabIndex = 70;
            // 
            // nPersentaseDiskon
            // 
            nPersentaseDiskon.Location = new Point(171, 355);
            nPersentaseDiskon.Name = "nPersentaseDiskon";
            nPersentaseDiskon.Size = new Size(239, 23);
            nPersentaseDiskon.TabIndex = 71;
            // 
            // txtKodePromo
            // 
            txtKodePromo.Location = new Point(171, 285);
            txtKodePromo.Name = "txtKodePromo";
            txtKodePromo.Size = new Size(239, 23);
            txtKodePromo.TabIndex = 72;
            // 
            // rtbDeskripsiKodePromo
            // 
            rtbDeskripsiKodePromo.Location = new Point(508, 285);
            rtbDeskripsiKodePromo.Name = "rtbDeskripsiKodePromo";
            rtbDeskripsiKodePromo.Size = new Size(252, 113);
            rtbDeskripsiKodePromo.TabIndex = 73;
            rtbDeskripsiKodePromo.Text = "";
            // 
            // id
            // 
            id.Location = new Point(475, 39);
            id.Name = "id";
            id.Size = new Size(100, 23);
            id.TabIndex = 74;
            id.Visible = false;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.Location = new Point(500, 425);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 75;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // FrmKodePromo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 475);
            Controls.Add(btnEdit);
            Controls.Add(id);
            Controls.Add(rtbDeskripsiKodePromo);
            Controls.Add(txtKodePromo);
            Controls.Add(nPersentaseDiskon);
            Controls.Add(nMaksimumDiskon);
            Controls.Add(dtKuponKadaluarsa);
            Controls.Add(btnSimpan);
            Controls.Add(btnBatal);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvKodePromo);
            Name = "FrmKodePromo";
            Text = "FrmKodePromo";
            Load += FrmKodePromo_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKodePromo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nMaksimumDiskon).EndInit();
            ((System.ComponentModel.ISupportInitialize)nPersentaseDiskon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSimpan;
        private Button btnBatal;
        private TextBox txtKota;
        private TextBox txtNamaBandara;
        private RichTextBox rtbAlamatBandara;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvKodePromo;
        private NumericUpDown nJumlahTerminal;
        private DateTimePicker dtKuponKadaluarsa;
        private NumericUpDown nMaksimumDiskon;
        private NumericUpDown nPersentaseDiskon;
        private TextBox txtKodePromo;
        private RichTextBox rtbDeskripsiKodePromo;
        private TextBox id;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private Button btnEdit;
    }
}