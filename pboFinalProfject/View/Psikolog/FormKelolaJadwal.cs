using System;
using System.Drawing;
using System.Windows.Forms;

namespace pboFinalProfject.View
{
    public partial class FormKelolaJadwal : Form
    {
        private DatabaseHelper dbHelper = new DatabaseHelper();
        private int selectedSlotId = -1; // Menyimpan ID baris yang sedang dipilih/diedit

        public FormKelolaJadwal()
        {
            InitializeComponent();

            // Registrasi Event Form & Komponen
            this.Load += new EventHandler(this.FormKelolaJadwal_Load);
            this.dgvSlotJadwal.CellClick += new DataGridViewCellEventHandler(this.dgvSlotJadwal_CellClick);

            // Registrasi Event Tombol CRUD
            this.btnTambah.Click += new EventHandler(this.btnTambah_Click);
            this.btnUbah.Click += new EventHandler(this.btnUbah_Click);
            this.btnHapus.Click += new EventHandler(this.btnHapus_Click);
            this.btnBersihkan.Click += new EventHandler(this.btnBersihkan_Click);
        }

        private void FormKelolaJadwal_Load(object sender, EventArgs e)
        {
            ResetForm();
            RefreshDataGrid();
        }

        // ==================== OPERASI CRUD ====================

        // 1. READ: Menampilkan & Menyegarkan Data Grid
        private void RefreshDataGrid()
        {
            string query = "SELECT * FROM jadwal_psikolog ORDER BY jadwal_id";
            try
            {
                DataTable dt = DatabaseHelper.EksekusiSelect(query);
                dgvSlotJadwal.DataSource = dt;
                dgvSlotJadwal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Tampil Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 2. CREATE: Tambah Slot Jadwal Baru
        private void btnTambah_Click(object sender, EventArgs e)
        {
            string hari = cmbHari.SelectedItem.ToString();
            string jamMulai = dtpJamMulai.Value.ToString("HH:mm:ss");
            string jamSelesai = dtpJamSelesai.Value.ToString("HH:mm:ss");
            string metode = cmbMetode.SelectedItem.ToString();
            int kuota = int.Parse(tbKuota.Text);
            bool isActive = chkIsActive.Checked;

            string query = $"INSERT INTO jadwal_psikolog (hari, jam_mulai, jam_selesai, metode, kuota, is_active) " +
                           $"VALUES ('{hari}', '{jamMulai}', '{jamSelesai}', '{metode}', {kuota}, {isActive})";

            try
            {
                dbHelper.ExecuteNonQuery(query);
                MessageBox.Show("Slot jadwal berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetForm();
                RefreshDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Tambah Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 3. UPDATE: Mengubah Data Slot Jadwal yang Dipilih
        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (selectedSlotId == -1)
            {
                MessageBox.Show("Pilih data pada tabel terlebih dahulu untuk diubah!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string hari = cmbHari.SelectedItem.ToString();
            string jamMulai = dtpJamMulai.Value.ToString("HH:mm:ss");
            string jamSelesai = dtpJamSelesai.Value.ToString("HH:mm:ss");
            string metode = cmbMetode.SelectedItem.ToString();
            int kuota = int.Parse(tbKuota.Text);
            bool isActive = chkIsActive.Checked;

            string query = $"UPDATE jadwal_psikolog SET hari='{hari}', jam_mulai='{jamMulai}', " +
                           $"jam_selesai='{jamSelesai}', metode='{metode}', kuota={kuota}, is_active={isActive} " +
                           $"WHERE jadwal_id={selectedSlotId}";

            try
            {
                dbHelper.ExecuteNonQuery(query);
                MessageBox.Show("Slot jadwal berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetForm();
                RefreshDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Update Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 4. DELETE: Menghapus Slot Jadwal
        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (selectedSlotId == -1)
            {
                MessageBox.Show("Pilih data pada tabel terlebih dahulu untuk dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult konfirmasi = MessageBox.Show("Apakah Anda yakin ingin menghapus slot jadwal ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (konfirmasi == DialogResult.Yes)
            {
                string query = $"DELETE FROM jadwal_psikolog WHERE jadwal_id={selectedSlotId}";
                try
                {
                    dbHelper.ExecuteNonQuery(query);
                    MessageBox.Show("Slot jadwal berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetForm();
                    RefreshDataGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Hapus Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ==================== LOGIKA KONTROL INTERFACE ====================

        // Mengambil data dari baris grid yang diklik user untuk dimasukkan kembali ke form input
        private void dgvSlotJadwal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSlotJadwal.Rows[e.RowIndex];

                selectedSlotId = Convert.ToInt32(row.Cells["ID"].Value);
                cmbHari.SelectedItem = row.Cells["Hari"].Value.ToString();

                // Parsing string jam dari DB agar bisa dibaca oleh DateTimePicker
                dtpJamMulai.Value = DateTime.Parse(row.Cells["Jam Mulai"].Value.ToString());
                dtpJamSelesai.Value = DateTime.Parse(row.Cells["Jam Selesai"].Value.ToString());


                // Atur tombol status saat mengedit data
                btnTambah.Enabled = false;
                btnUbah.Enabled = true;
                btnHapus.Enabled = true;
            }
        }

        private void btnBersihkan_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        // Mengembalikan inputan form ke kondisi default
        private void ResetForm()
        {
            selectedSlotId = -1;
            cmbHari.SelectedIndex = 0; // Pilih Senin secara default
            dtpJamMulai.Value = DateTime.Today.AddHours(08); // Default jam 08:00
            dtpJamSelesai.Value = DateTime.Today.AddHours(09); // Default jam 09:00

            btnTambah.Enabled = true;
            btnUbah.Enabled = false;
            btnHapus.Enabled = false;
        }
        private void FormKelolaJadwal_Load_1(object sender, EventArgs e)
        {

        }
    }
}