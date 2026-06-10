using inventory_panen_mvc.Models;
//using inventory_panen_mvc.Views;
//using inventory_panen_mvc.Helpers;
//using System.Windows.Forms;

//namespace inventory_panen_mvc.Controllers
//{
//    public class LoginController
//    {
//        private LoginForm view;
//        private UserContext context;

//        public LoginController(LoginForm loginForm)
//        {
//            this.view = loginForm;
//            this.context = new UserContext();
//        }

//        public void ProcessLogin()
//        {
//            string email = view.EmailInput;
//            string password = view.PasswordInput;

//            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
//            {
//                MessageBox.Show("Email dan Password tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                return;
//            }

//            User user = context.Login(email, password);
//            if (user != null)
//            {
//                // Set Global Session
//                SessionHelper.StartSession(user.Id, user.Username, user.Role);

//                MessageBox.Show($"Selamat datang, {user.Username}! Anda masuk sebagai {user.Role}.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

//                // Buka Dashboard & Sembunyikan Form Login
//                DashboardForm dashboard = new DashboardForm();
//                dashboard.Show();
//                view.Hide();
//            }
//            else
//            {
//                MessageBox.Show("Email atau Password salah!", "Gagal Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }
//    }
//}