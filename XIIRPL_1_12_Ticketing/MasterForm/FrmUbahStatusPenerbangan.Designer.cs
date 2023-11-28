namespace XIIRPL_1_12_Ticketing.MasterForm
{
    partial class FrmUbahStatusPenerbangan
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
            label2 = new Label();
            label1 = new Label();
            dgvUbahStatusPenerbangan = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvUbahStatusPenerbangan).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(44, 63);
            label2.Name = "label2";
            label2.Size = new Size(331, 17);
            label2.TabIndex = 74;
            label2.Text = "Anda bisa mengubah status jadwal penerbangan di sini";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(40, 30);
            label1.Name = "label1";
            label1.Size = new Size(307, 32);
            label1.TabIndex = 73;
            label1.Text = "Ubah Status Penerbangan";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvUbahStatusPenerbangan
            // 
            dgvUbahStatusPenerbangan.BackgroundColor = Color.White;
            dgvUbahStatusPenerbangan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUbahStatusPenerbangan.Location = new Point(46, 96);
            dgvUbahStatusPenerbangan.Name = "dgvUbahStatusPenerbangan";
            dgvUbahStatusPenerbangan.RowTemplate.Height = 25;
            dgvUbahStatusPenerbangan.Size = new Size(714, 330);
            dgvUbahStatusPenerbangan.TabIndex = 72;
            // 
            // FrmUbahStatusPenerbangan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 498);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvUbahStatusPenerbangan);
            Name = "FrmUbahStatusPenerbangan";
            Text = "FrmUbahStatusPenerbangan";
            ((System.ComponentModel.ISupportInitialize)dgvUbahStatusPenerbangan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nPersentaseDiskon;
        private NumericUpDown nMaksimumDiskon;
        private DateTimePicker dtBerlakuSampai;
        private Button btnSimpan;
        private Button btnBatal;
        private TextBox txtKodePromo;
        private RichTextBox rtbDeskripsiKodePromo;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvUbahStatusPenerbangan;
    }
}