using System;
using System.Data;
using System.Windows.Forms;
using Npgsql; // Library Connector PostgreSQL

namespace pboFinalProfject.View
{
    public partial class FormManageUser : Form
    {
        // Ganti dengan string koneksi database PostgreSQL Anda yang sebenarnya
        private readonly string connString = "Host=localhost;Port=5432;Database=unimind_db;Username=postgres;Password=yourpassword;";
        private int selectedIdPsikolog = -1;
        private int selectedIdMahasiswa = -1;

        public FormManageUser()
        {
            InitializeComponent();
        }

        private void FormManageUser_Load(object sender, EventArgs e)
        {
            LoadDataPsikolog();
            LoadDataMahasiswa();
        }

        #region LOGIKA MANAJEMEN PSIKOLOG (KARYAWAN)

        private void LoadDataPsikolog()
        {
            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    string query = @"SELECT user_id, username, nama_lengkap, email, no_telepon
                                     FROM users
                                     ORDER BY user_id";

                    using (var da = new NpgsqlDataAdapter(query, conn))
                    {
                        var dt = new DataTable();
                        da.Fill(dt);
                        dgvPsikolog.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat data psikolog: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSimpanPsikolog_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserPsi.Text) || string.IsNullOrWhiteSpace(txtNamaPsi.Text))
            {
                MessageBox.Show("Username dan Nama Psikolog wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    using (var trans = conn.BeginTransaction())
                    {
                        // 1. Insert ke Tabel Utama (Supertype)
                        string sqlAkun = @"INSERT INTO akun (username, email, no_telepon, password_hash, nama_lengkap, role) 
                                           VALUES (@u, @e, @t, @p, @n, 'Psikolog') RETURNING id_akun";
                        int newId;
                        using (var cmd = new NpgsqlCommand(sqlAkun, conn))
                        {
                            cmd.Parameters.AddWithValue("u", txtUserPsi.Text.Trim());
                            cmd.Parameters.AddWithValue("p", "Psi123!"); // Default password awal
                            cmd.Parameters.AddWithValue("n", txtNamaPsi.Text.Trim());
                            cmd.Parameters.AddWithValue("e", txtEmailPsi.Text.Trim());
                            cmd.Parameters.AddWithValue("t", txtTelpPsi.Text.Trim());
                            newId = Convert.ToInt32(cmd.ExecuteScalar());
                        }

                        

                        trans.Commit();
                    }
                    MessageBox.Show("Akun Psikolog baru sukses didaftarkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataPsikolog();
                    ClearFieldsPsikolog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal menyimpan data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHapusPsi_Click(object sender, EventArgs e)
        {
            if (selectedIdPsikolog == -1) return;

            var result = MessageBox.Show("Apakah Anda yakin ingin menghapus akun psikolog ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (var conn = new NpgsqlConnection(connString))
                    {
                        conn.Open();
                        // Berkat klausa 'ON DELETE CASCADE' di DDL, menghapus di tabel Akun otomatis membersihkan tabel Karyawan
                        string sql = "DELETE FROM users WHERE user_id = @id";
                        using (var cmd = new NpgsqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("id", selectedIdPsikolog);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    LoadDataPsikolog();
                    ClearFieldsPsikolog();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void dgvPsikolog_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPsikolog.Rows[e.RowIndex];
                selectedIdPsikolog = Convert.ToInt32(row.Cells["id_akun"].Value);
                txtUserPsi.Text = row.Cells["username"].Value.ToString();
                txtNamaPsi.Text = row.Cells["nama"].Value.ToString();
                txtEmailPsi.Text = row.Cells["email"].Value.ToString();
                txtTelpPsi.Text = row.Cells["no_telepon"].Value.ToString();
            }
        }

        private void ClearFieldsPsikolog()
        {
            txtUserPsi.Clear(); txtNamaPsi.Clear(); txtEmailPsi.Clear(); txtTelpPsi.Clear();
            selectedIdPsikolog = -1;
        }

        #endregion

        #region LOGIKA MANAJEMEN MAHASISWA (CUSTOMER)

        private void LoadDataMahasiswa()
        {
            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    string query = @"SELECT user_id, username, nama_lengkap, email, no_telepon 
                                     FROM users
                                     ORDER BY user_id";

                    using (var da = new NpgsqlDataAdapter(query, conn))
                    {
                        var dt = new DataTable();
                        da.Fill(dt);
                        dgvMahasiswa.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat data mahasiswa: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSimpanMhs_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserMhs.Text) || string.IsNullOrWhiteSpace(txtNamaMhs.Text))
            {
                MessageBox.Show("Username dan Nama Mahasiswa wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    using (var trans = conn.BeginTransaction())
                    {
                        string sqlUser = @"INSERT INTO users (username, password, nama_lengkap, email, no_telepon) 
                                           VALUES (@u, @p, @n, @e, @t) RETURNING user_id";
                        int newId;
                        using (var cmd = new NpgsqlCommand(sqlUser, conn))
                        {
                            cmd.Parameters.AddWithValue("u", txtUserMhs.Text.Trim());
                            cmd.Parameters.AddWithValue("p", "Mhs123!");
                            cmd.Parameters.AddWithValue("n", txtNamaMhs.Text.Trim());
                            cmd.Parameters.AddWithValue("e", txtEmailMhs.Text.Trim());
                            cmd.Parameters.AddWithValue("t", txtTelpMhs.Text.Trim());
                            newId = Convert.ToInt32(cmd.ExecuteScalar());
                        }

                        trans.Commit();
                    }
                    MessageBox.Show("Data Mahasiswa baru berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataMahasiswa();
                    ClearFieldsMahasiswa();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnHapusMhs_Click(object sender, EventArgs e)
        {
            if (selectedIdMahasiswa == -1) return;

            var result = MessageBox.Show("Hapus data mahasiswa pilihan?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (var conn = new NpgsqlConnection(connString))
                    {
                        conn.Open();
                        string sql = "DELETE FROM users WHERE user_id = @id";
                        using (var cmd = new NpgsqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("id", selectedIdMahasiswa);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    LoadDataMahasiswa();
                    ClearFieldsMahasiswa();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void dgvMahasiswa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMahasiswa.Rows[e.RowIndex];
                selectedIdMahasiswa = Convert.ToInt32(row.Cells["id_akun"].Value);
                txtUserMhs.Text = row.Cells["username"].Value.ToString();
                txtNamaMhs.Text = row.Cells["nama"].Value.ToString();
                txtEmailMhs.Text = row.Cells["email"].Value.ToString();
                txtTelpMhs.Text = row.Cells["no_telepon"].Value.ToString();
                cmbStatusMhs.Text = row.Cells["status_customer"].Value.ToString();
            }
        }

        private void ClearFieldsMahasiswa()
        {
            txtUserMhs.Clear(); txtNamaMhs.Clear(); txtEmailMhs.Clear(); txtTelpMhs.Clear();
            cmbStatusMhs.SelectedIndex = 0;
            selectedIdMahasiswa = -1;
        }

        #endregion
    }
}