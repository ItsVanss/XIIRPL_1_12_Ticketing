namespace XIIRPL_1_12_Ticketing.TransactionForm
{
    partial class FrmTiketCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTiketCustomer));
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dgvListPenerbangan = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvListPenerbangan).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(70, 70, 70);
            label2.Location = new Point(44, 46);
            label2.Name = "label2";
            label2.Size = new Size(261, 15);
            label2.TabIndex = 5;
            label2.Text = "Semua tiket Anda yang aktif akan muncul di sini";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(40, 14);
            label1.Name = "label1";
            label1.Size = new Size(182, 30);
            label1.TabIndex = 4;
            label1.Text = "List Penerbangan";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // dgvListPenerbangan
            // 
            dgvListPenerbangan.BackgroundColor = Color.White;
            dgvListPenerbangan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListPenerbangan.Location = new Point(12, 75);
            dgvListPenerbangan.Name = "dgvListPenerbangan";
            dgvListPenerbangan.RowTemplate.Height = 25;
            dgvListPenerbangan.Size = new Size(776, 150);
            dgvListPenerbangan.TabIndex = 6;
            // 
            // FrmTiketCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvListPenerbangan);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "FrmTiketCustomer";
            Text = "FrmTiketCustomer";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvListPenerbangan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private DataGridView dgvListPenerbangan;
    }
}