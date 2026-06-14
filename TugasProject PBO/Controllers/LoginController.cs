using System.Windows.Forms;
using TugasProject_PBO.Helpers;
using TugasProject_PBO.Models;
using TugasProject_PBO.Views.Admin;
using TugasProject_PBO.Views.Petani;

namespace TugasProject_PBO.Controllers
{
    public class LoginController
    {
        public void ProcessLogin(string email, string password, string role)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show(
                    "Email dan Password tidak boleh kosong!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (role == "Admin")
            {
                DashboardAdmin dashboard = new DashboardAdmin();
                dashboard.Show();
            }
            else if (role == "Petani")
            {
                DataHasilPanenPetani formPetani = new DataHasilPanenPetani();
                formPetani.Show();
            }
            else
            {
                MessageBox.Show(
                    "Role tidak dikenali!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}