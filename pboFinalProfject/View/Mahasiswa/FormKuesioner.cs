using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using pboFinalProfject.Model;
using pboFinalProfject.Repositories;
using pboFinalProfject.Session;

namespace pboFinalProfject.View.Mahasiswa
{
    public partial class FormKuesioner : Form
    {
        private readonly PertanyaanAssessmentRepository _pertanyaanRepo = new PertanyaanAssessmentRepository();
        private readonly HasilAssessmentRepository _hasilRepo = new HasilAssessmentRepository();
        private readonly JawabanAssessmentRepository _jawabanRepo = new JawabanAssessmentRepository();

        private List<PertanyaanAssessment> _questions;
        private List<GroupBox> _questionBoxes = new List<GroupBox>();
        private static object lblResult;

        public FormKuesioner()
        {
            InitializeComponent();
            if (System.ComponentModel.LicenseManager.UsageMode != System.ComponentModel.LicenseUsageMode.Designtime)
            {
                LoadQuestions();
                WireSidebar();
                ShowLatestScore();
                try { btnKeluar.Click += (s, e) => { var auth = new Controllers.AuthController(); auth.LogoutAndRedirect(this); }; } catch { }
            }
            // help ensure single-click buttons respond immediately when form is shown
            this.Shown += (s, e) => { this.Activate(); };
        }

        private void WireSidebar()
        {
            btnKuisioner.Click += (s, e) => { /* already here */ };
            btnKonselor.Click += (s, e) => { new FormDaftarKonselor().ShowDialog(this); };
            btnKonsultasi.Click += (s, e) => { new FormBuatBooking().ShowDialog(this); };
            btnProfile.Click += (s, e) => { new FormProfilMahasiswa().ShowDialog(this); };
            btnBeranda.Click += (s, e) => { pboFinalProfject.Utils.Navigation.GoToDashboard(this); };
            this.Shown += (s, e) => { this.Activate(); };
        }

        private void ShowLatestScore()
        {
            try
            {
                var latest = _hasilRepo.GetLatestByUserId(UserSession.GetCurrentUserId());
                if (latest != null)
                {
                    lblLastScore.Text = $"Skor terakhir: {latest.SkorTotal} ({latest.TingkatStres}) - {latest.TanggalAssessment:d}";
                }
                else
                {
                    lblLastScore.Text = "Belum ada kuisioner yang tersimpan.";
                }
            }
            catch { }
        }

        private void LoadQuestions()
        {
            _questions = _pertanyaanRepo.GetAll();
            int y = 10;
            int idx = 0;
            foreach (var q in _questions)
            {
                var gb = new GroupBox
                {
                    Text = $"{++idx}. {q.PertanyaanText}",
                    Width = 900,
                    Height = 80,
                    Location = new Point(10, y)
                };

                var rbA = new RadioButton { Text = "A (Ringan)", Tag = new Tuple<int, char>(q.BobotA, 'A'), Location = new Point(10, 25), AutoSize = true };
                var rbB = new RadioButton { Text = "B (Sedang)", Tag = new Tuple<int, char>(q.BobotB, 'B'), Location = new Point(140, 25), AutoSize = true };
                var rbC = new RadioButton { Text = "C (Berat)", Tag = new Tuple<int, char>(q.BobotC, 'C'), Location = new Point(300, 25), AutoSize = true };

                gb.Controls.Add(rbA);
                gb.Controls.Add(rbB);
                gb.Controls.Add(rbC);

                panelQuestions.Controls.Add(gb);
                _questionBoxes.Add(gb);

                y += 90;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // validate
            var answers = new List<JawabanAssessment>();
            for (int i = 0; i < _questionBoxes.Count; i++)
            {
                var gb = _questionBoxes[i];
                var selected = gb.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                if (selected == null)
                {
                    MessageBox.Show($"Silakan jawab semua pertanyaan. Pertanyaan nomor {i + 1} belum dijawab.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var tuple = (Tuple<int, char>)selected.Tag;
                answers.Add(new JawabanAssessment
                {
                    PertanyaanId = _questions[i].PertanyaanId,
                    Jawaban = tuple.Item2,
                    Nilai = tuple.Item1
                });
            }

            int total = 0;
            foreach (var a in answers) total += a.Nilai;

            // simple classification
            string tingkat;
            string rekom;

            if (total < _questions.Count * 2)
            {
                tingkat = "Rendah";
                rekom = "Tingkat stres rendah. Pertahankan pola hidup sehat dan manajemen waktu.";
            }
            else if (total < _questions.Count * 3)
            {
                tingkat = "Sedang";
                rekom = "Tingkat stres sedang. Coba atur manajemen waktu dan pertimbangkan konseling singkat.";
            }
            else
            {
                tingkat = "Tinggi";
                rekom = "Tingkat stres tinggi. Sangat disarankan menghubungi konselor atau psikolog kampus.";
            }

            var hasil = new HasilAssessment
            {
                UserId = UserSession.GetCurrentUserId(),
                SkorTotal = total,
                TingkatStres = tingkat,
                Rekomendasi = rekom
            };

            int hasilId = _hasilRepo.Insert(hasil);
            if (hasilId > 0)
            {
                // assign hasil id to each answer then bulk insert
                foreach (var a in answers) a.HasilId = hasilId;
                var saved = _jawabanRepo.InsertMany(hasilId, answers);
                if (saved)
                {
                    // show result and offer mulai lagi / kembali
                    kuisTotal(total, tingkat, rekom);
                    ShowLatestScore();
                    btnMulaiLagi.Visible = true;
                    btnKembali.Visible = true;
                    btnSubmit.Enabled = false;
                    // keep form open so user can choose action
                }
                else
                {
                    MessageBox.Show("Gagal menyimpan jawaban.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Gagal menyimpan hasil.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //static void kuisTotal(int total, string tingkat, string rekom)
            //{
            //    lblResult.Text = $"Kuisioner selesai. Skor: {total} - {tingkat}\n{rekom}";
            //    lblResult.Visible = true;
            //}
        }

        private void kuisTotal(int total, string tingkat, string rekom)
        {
            try
            {
                string msg = $"Kuisioner selesai. Skor: {total} - {tingkat}\n{rekom}";
                MessageBox.Show(msg, "Hasil Kuisioner", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch { }
        }

        private void btnMulaiLagi_Click(object sender, EventArgs e)
        {
            // reset choices
            foreach (var gb in _questionBoxes)
            {
                foreach (var rb in gb.Controls.OfType<RadioButton>())
                    rb.Checked = false;
            }
            btnSubmit.Enabled = true;
            btnMulaiLagi.Visible = false;
            btnKembali.Visible = false;
            //lblResult.Visible = false;
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormKuesioner_Load(object sender, EventArgs e)
        {

        }

        private void btnKuisioner_Click(object sender, EventArgs e)
        {

        }
    }
}
