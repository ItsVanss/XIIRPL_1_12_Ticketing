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
    public partial class FrmMasterJadwalPenerbangan : Form
    {
        ComboBoxFunction cb = new ComboBoxFunction();
        public NpgsqlCommand cmd;
        public NpgsqlDataReader dr;
        
        public FrmMasterJadwalPenerbangan()
        {
            InitializeComponent();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.conn.Open();
                String sql = "INSERT INTO db_ticket_xii_rpl_1_12.tbl_jadwal_penerbangan (id,kode_penerbangan,bandara_keberangkatan_id,bandara_tujuan_id,maskapai_id,tanggal_keberangkatan,waktu_keberangkatan,durasi_penerbangan,harga_ticket)" +
                    "VALUES" +
                    "('" + id.Text + "'," +
                    "'" + txtKodePenerbangan.Text + "'," +
                    "'" + cbAlamatKeberangkatan.SelectedValue + "'," +
                    "'" + cbAlamatTujuan.SelectedValue + "'," +
                    "'" + cbMaskapai.SelectedValue + "'," +
                    "'" + dtTanggalKeberangkatan.Text + "'," +
                    "'" + dtWaktuKeberangkatan.Text + "'," +
                    "'" + txtDurasiPenerbangan.Text + "'," +
                    "'" + nHarga.Text + "')";
                cmd = new NpgsqlCommand(sql, koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Simpan Data Jadwal Penerbangan");
                koneksi.conn.Close();
                view_data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                koneksi.conn.Close();
            }
        }

        public void view_data()
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT * FROM db_ticket_xii_rpl_1_12.tbl_jadwal_penerbangan", koneksi.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "db_ticket_xii_rpl_1_12.tbl_jadwal_penerbangan");
            dgvJadwalPenerbangan.DataSource = ds.Tables[0].DefaultView;
        }

        public void nomor_urut()
        {
            int hitung, nomor;
            koneksi.conn.Open();
            string sql = "SELECT id FROM db_ticket_xii_rpl_1_12.tbl_jadwal_penerbangan where id in(select max(id) FROM db_ticket_xii_rpl_1_12.tbl_jadwal_penerbangan) order by id desc";
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

        private void dgvJadwalPenerbangan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmMasterJadwalPenerbangan_Load(object sender, EventArgs e)
        {
            view_data();
            nomor_urut();

            string query = "SELECT * FROM db_ticket_xii_rpl_1_12.tbl_maskapai";
            //ComboBoxFunction.Set_ComboBox(query, "nama", cbMaskapai);
            cbMaskapai.DataSource = cb.GetData(query);
            cbMaskapai.DisplayMember = "nama";
            cbMaskapai.ValueMember = "id";

            string query1 = "SELECT * FROM db_ticket_xii_rpl_1_12.tbl_bandara";
            //ComboBoxFunction.Set_ComboBox(query1, "nama", cbAlamatKeberangkatan);
            cbAlamatKeberangkatan.DataSource = cb.GetData(query1);
            cbAlamatKeberangkatan.DisplayMember = "nama";
            cbAlamatKeberangkatan.ValueMember = "id";

            string query2 = "SELECT * FROM db_ticket_xii_rpl_1_12.tbl_bandara";
            //ComboBoxFunction.Set_ComboBox(query2, "nama", cbAlamatTujuan);
            cbAlamatTujuan.DataSource = cb.GetData(query2);
            cbAlamatTujuan.DisplayMember = "nama";
            cbAlamatTujuan.ValueMember = "id";
        }

        private void txtKodePenerbangan_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvJadwalPenerbangan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvJadwalPenerbangan.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                int id;
                id = Convert.ToInt32(dgvJadwalPenerbangan.Rows[e.RowIndex].Cells["id"].Value);
                try
                {
                    koneksi.conn.Open();
                    String sql = "DELETE FROM db_ticket_xii_rpl_1_12.tbl_jadwal_penerbangan WHERE id=@id";
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
            if (dgvJadwalPenerbangan.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                id.Text = Convert.ToString(dgvJadwalPenerbangan.Rows[e.RowIndex].Cells["id"].Value);
                txtKodePenerbangan.Text = Convert.ToString(dgvJadwalPenerbangan.Rows[e.RowIndex].Cells["kode_penerbangan"].Value);
                cbAlamatKeberangkatan.Text = Convert.ToString(dgvJadwalPenerbangan.Rows[e.RowIndex].Cells["bandara_keberangkatan_id"].Value);
                cbAlamatTujuan.Text = Convert.ToString(dgvJadwalPenerbangan.Rows[e.RowIndex].Cells["bandara_tujuan_id"].Value);
                cbMaskapai.Text = Convert.ToString(dgvJadwalPenerbangan.Rows[e.RowIndex].Cells["maskapai_id"].Value);
                //dtTanggalKeberangkatan.Text = Convert.ToString(dgvJadwalPenerbangan.Rows[e.RowIndex].Cells["tanggal_keberangkatan"].Value);
                //dtWaktuKeberangkatan.Text = Convert.ToString(dgvJadwalPenerbangan.Rows[e.RowIndex].Cells["waktu_keberangkatan"].Value);
                txtDurasiPenerbangan.Text = Convert.ToString(dgvJadwalPenerbangan.Rows[e.RowIndex].Cells["durasi_penerbangan"].Value);
                nHarga.Text = Convert.ToString(dgvJadwalPenerbangan.Rows[e.RowIndex].Cells["harga_ticket"].Value);

                btnSimpan.Enabled = false;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.conn.Open();
                String sql = "UPDATE db_ticket_xii_rpl_1_12.tbl_jadwal_penerbangan SET " +
                    "kode_penerbangan='" + txtKodePenerbangan.Text + "'," +
                    "bandara_keberangkatan_id='" + cbAlamatKeberangkatan.Text + "', " +
                    "bandara_tujuan_id='" + cbAlamatTujuan.Text + "', " +
                    "maskapai_id='" + cbMaskapai.Text + "', " +
                    "tanggal_keberangkatan='" + dtTanggalKeberangkatan.Text + "', " +
                    "waktu_keberangkatan='" + dtWaktuKeberangkatan.Text + "', " +
                    "durasi_penerbangan='" + txtDurasiPenerbangan.Text + "', " +
                    "harga_ticket='" + nHarga.Text + "'" +

                    " WHERE id='" + id.Text + "'";

                cmd = new NpgsqlCommand(sql, koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Edit Data Jadwal Penerbangan");
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
