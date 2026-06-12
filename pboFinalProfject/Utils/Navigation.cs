using System;
using System.Windows.Forms;

namespace pboFinalProfject.Utils
{
    public static class Navigation
    {
        public static void GoToDashboard(Form currentForm)
        {
            try
            {
                // If a dashboard is already open, bring it forward
                foreach (Form f in Application.OpenForms)
                {
                    if (f.GetType() == typeof(pboFinalProfject.View.Mahasiswa.FormDashboardMahasiswa))
                    {
                        if (f.WindowState == FormWindowState.Minimized) f.WindowState = FormWindowState.Normal;
                        f.BringToFront();
                        f.Activate();
                        if (currentForm != f) currentForm.Close();
                        return;
                    }
                }

                // Otherwise create a new dashboard and show it
                var dash = new pboFinalProfject.View.Mahasiswa.FormDashboardMahasiswa();
                dash.StartPosition = FormStartPosition.CenterScreen;
                dash.Show();
                currentForm.Close();
            }
            catch
            {
                try { currentForm.Close(); } catch { }
            }
        }
    }
}
