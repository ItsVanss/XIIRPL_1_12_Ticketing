using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace XIIRPL_1_12_Ticketing.MasterForm
{
    public partial class FrmKodePromo : Form
    {
        public NpgsqlCommand cmd;
        public NpgsqlDataReader dr;
        public FrmKodePromo()
        {
            InitializeComponent();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.conn.Open();
                String sql = "INSERT INTO db_ticket_xii_rpl_1_12.tbl_kode_promo (id,kode,berlaku_sampai,presentase_diskon,maksimum_diskon,deskripsi)" +
                    "VALUES" +
                    "('" + id.Text + "'," +
                    "'" + txtKodePromo.Text + "'," +
                    "'" + dtKuponKadaluarsa.Text + "'," +
                    "'" + nPersentaseDiskon.Text + "'," +
                    "'" + nMaksimumDiskon.Text + "'," +
                    "'" + rtbDeskripsiKodePromo.Text + "')";
                cmd = new NpgsqlCommand(sql, koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Simpan Data Kode Promo");
                view_data();
                koneksi.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void view_data()
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT * FROM db_ticket_xii_rpl_1_12.tbl_kode_promo", koneksi.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "db_ticket_xii_rpl_1_12.tbl_kode_promo");
            dgvKodePromo.DataSource = ds.Tables[0].DefaultView;
        }

        public void nomor_urut()
        {
            int hitung, nomor;
            koneksi.conn.Open();
            string sql = "SELECT id FROM db_ticket_xii_rpl_1_12.tbl_kode_promo where id in(select max(id) FROM db_ticket_xii_rpl_1_12.tbl_kode_promo) order by id desc";
            cmd = new NpgsqlCommand(sql, koneksi.conn);
            dr = cmd.ExecuteReader();
            dr.Read();

            if (dr.HasRows)
            {
                nomor = Convert.ToInt32(dr[0]);
                hitung = nomor + 1;
            }
            else
            {
                hitung = 1;
            }
            dr.Close();
            id.Text = Convert.ToString(hitung);
            koneksi.conn.Close();
        }

        private void FrmKodePromo_Load(object sender, EventArgs e)
        {
            view_data();
            nomor_urut();
        }

        private void dgvKodePromo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvKodePromo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvKodePromo.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                int id;
                id = Convert.ToInt32(dgvKodePromo.Rows[e.RowIndex].Cells["id"].Value);
                try
                {
                    koneksi.conn.Open();
                    String sql = "DELETE FROM db_ticket_xii_rpl_1_12.tbl_kode_promo WHERE id=@id";
                    cmd = new NpgsqlCommand(sql, koneksi.conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Data Berhasil Dihapus");
                        view_data();
                    }
                    else
                    {
                        MessageBox.Show("Data Tidak Berhasil Dihapus");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    koneksi.conn.Close();
                }
            }
            if (dgvKodePromo.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                id.Text = Convert.ToString(dgvKodePromo.Rows[e.RowIndex].Cells["id"].Value);
                txtKodePromo.Text = Convert.ToString(dgvKodePromo.Rows[e.RowIndex].Cells["kode"].Value);
                dtKuponKadaluarsa.Text = Convert.ToString(dgvKodePromo.Rows[e.RowIndex].Cells["berlaku_sampai"].Value);
                nPersentaseDiskon.Text = Convert.ToString(dgvKodePromo.Rows[e.RowIndex].Cells["presentase_diskon"].Value);
                nMaksimumDiskon.Text = Convert.ToString(dgvKodePromo.Rows[e.RowIndex].Cells["maksimum_diskon"].Value);
                rtbDeskripsiKodePromo.Text = Convert.ToString(dgvKodePromo.Rows[e.RowIndex].Cells["deskripsi"].Value);

                btnSimpan.Enabled = false;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.conn.Open();
                String sql = "UPDATE db_ticket_xii_rpl_1_12.tbl_kode_promo SET " +
                    "kode='" + txtKodePromo.Text + "'," +
                    "berlaku_sampai='" + dtKuponKadaluarsa.Text + "', " +
                    "presentase_diskon='" + nPersentaseDiskon.Text + "', " +
                    "maksimum_diskon='" + nMaksimumDiskon.Text + "', " +
                    "deskripsi='" + rtbDeskripsiKodePromo.Text + "'" +
                    
                    " WHERE id='" + id.Text + "'";

                cmd = new NpgsqlCommand(sql, koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Edit Data Kode Promo");
                view_data();
                koneksi.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
