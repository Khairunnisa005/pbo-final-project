using pboFinalProfject.Controllers;
using pboFinalProfject.Session;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace pboFinalProfject.View.Mahasiswa
{

    public partial class FormDashboardMahasiswa : Form
    {
        private Panel containerPanel;
        private FlowLayoutPanel flowPanel;
        private Controllers.MahasiswaController _mahasiswaController;

        public FormDashboardMahasiswa()
        {
            InitializeComponent();
            _mahasiswaController = new Controllers.MahasiswaController();

            // wire existing buttons
            btnKuisioner.Click += btnKuisioner_Click;
            //btnKuis.Click += btnCekKeadaan_Click;
            btnJadwal.Click += BtnJadwal_Click;
        }

        //private void InitializeDashboard()
        //{
        //    // Outer container that keeps fixed client size but allows flowPanel to be scrollable
        //    containerPanel = new Panel
        //    {
        //        Dock = DockStyle.Fill,
        //        AutoScroll = true,
        //        BackColor = SystemColors.ControlLight,
        //    };

        //    // FlowLayoutPanel to arrange dashboard items vertically
        //    flowPanel = new FlowLayoutPanel
        //    {
        //        FlowDirection = FlowDirection.TopDown,
        //        WrapContents = false,
        //        AutoSize = true,
        //        Padding = new Padding(10),
        //    };

        //    containerPanel.Controls.Add(flowPanel);
        //    this.Controls.Add(containerPanel);

        //    // Add sample cards to demonstrate scrolling
        //    for (int i = 0; i < 12; i++)
        //    {
        //        var card = CreateCard($"Panel {i + 1}", "Konten contoh...");
        //        flowPanel.Controls.Add(card);
        //    }

        //    // Optional: set a preferred starting size similar to typical login form
        //    this.ClientSize = new Size(880, 503);
        //}

        //private Control CreateCard(string title, string content)
        //{
        //    var panel = new Panel
        //    {
        //        Width = 800,
        //        Height = 80,
        //        BackColor = Color.White,
        //        Margin = new Padding(0, 0, 0, 10),
        //    };

        //    var lblTitle = new Label
        //    {
        //        Text = title,
        //        Font = new Font("Segoe UI", 9F, FontStyle.Bold),
        //        Location = new Point(10, 10),
        //        AutoSize = true,
        //    };

        //    var lblContent = new Label
        //    {
        //        Text = content,
        //        Font = new Font("Segoe UI", 8F),
        //        Location = new Point(10, 35),
        //        AutoSize = true,
        //    };

        //    panel.Controls.Add(lblTitle);
        //    panel.Controls.Add(lblContent);

        //    return panel;
        //}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnKuisioner_Click(object sender, EventArgs e)
        {
            try
            {
                var form = new FormKuesioner();
                form.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka kuisioner: " + ex.Message);
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            var f = new FormProfilMahasiswa();
            f.ShowDialog(this);
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            var f = new FormDaftarKonselor();
            f.ShowDialog(this);
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            var auth = new Controllers.AuthController();
            auth.Logout(this);
            var login = new FormLogin();
            login.Show();
        }

        //private void btnCekKeadaan_Click(object sender, EventArgs e)
        //{
        //    var form = new FormCekKeadaan();
        //    form.ShowDialog(this);
        //}

        private void BtnJadwal_Click(object sender, EventArgs e)
        {
            var form = new FormBuatBooking();
            form.ShowDialog(this);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(1535, 864);
            // Load jadwal ke dataGridView1 sebagai Jadwal Konsultasi summary
            try
            {
                var dt = _mahasiswaController.GetJadwalAktif();
                dataGridView1.DataSource = dt;
                if (dataGridView1.Columns.Contains("jadwal_id")) dataGridView1.Columns["jadwal_id"].Visible = false;
                if (dataGridView1.Columns.Contains("psikolog_nama")) dataGridView1.Columns["psikolog_nama"].HeaderText = "Psikolog";
                if (dataGridView1.Columns.Contains("kategori")) dataGridView1.Columns["kategori"].HeaderText = "Kategori";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                // add edit/delete buttons if not present
                if (!dataGridView1.Columns.Contains("_edit"))
                {
                    var edit = new DataGridViewButtonColumn { Name = "_edit", HeaderText = "Edit", Text = "Edit", UseColumnTextForButtonValue = true };
                    var del = new DataGridViewButtonColumn { Name = "_delete", HeaderText = "Hapus", Text = "Hapus", UseColumnTextForButtonValue = true };
                    dataGridView1.Columns.Add(edit);
                    dataGridView1.Columns.Add(del);
                    dataGridView1.CellContentClick += DataGridView1_CellContentClick;
                }
            }
            catch (Exception ex)
            {
                // jangan crash dashboard
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var grid = sender as DataGridView;
            var row = grid.Rows[e.RowIndex];
            if (grid.Columns[e.ColumnIndex].Name == "_edit")
            {
                // Edit booking: open booking-edit mode so previous booking info is shown
                if (!grid.Columns.Contains("booking_id")) return;
                int bookingId = Convert.ToInt32(row.Cells["booking_id"].Value);
                try
                {
                    // The TimeSpan/System exception reported earlier likely came from invalid cast of jam columns; ensure Safe
                    var form = new FormBuatBooking(bookingId, true);
                    form.Text = "Edit Booking";
                    if (form.ShowDialog(this) == DialogResult.OK)
                {
                    Dashboard_Load(this, EventArgs.Empty);
                }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal membuka mode edit: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (grid.Columns[e.ColumnIndex].Name == "_delete")
            {
                if (!grid.Columns.Contains("booking_id")) return;
                int bookingId = Convert.ToInt32(row.Cells["booking_id"].Value);
                int userId;
                try
                {
                    userId = UserSession.GetCurrentUserId();
                }
                catch (Exception)
                {
                    MessageBox.Show("Tidak ada user yang login.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var confirm = MessageBox.Show("Hapus booking ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        var ctrl = new Controllers.MahasiswaController();
                        bool ok = ctrl.HapusBooking(bookingId, userId);
                        if (ok)
                        {
                            MessageBox.Show("Booking dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Dashboard_Load(this, EventArgs.Empty);
                        }
                        else
                        {
                            MessageBox.Show("Tidak ada data yang terhapus. Pastikan booking memang ada.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Gagal menghapus booking: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void btnKuis_Click(object sender, EventArgs e)
        {
            var form = new FormKuesioner();
            form.ShowDialog(this);
        }
    }
}
