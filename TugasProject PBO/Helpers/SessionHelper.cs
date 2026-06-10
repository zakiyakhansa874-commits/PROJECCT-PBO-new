namespace TugasProject_PBO.Helpers
{
    internal class SessionHelper
    {
        public static int IdUser { get; set; }
        public static string Username { get; set; }
        public static string Nama { get; set; }
        public static string Role { get; set; }

        public static void SetSession(int idUser, string username, string nama, string role)
        {
            IdUser = idUser;
            Username = username;
            Nama = nama;
            Role = role;
        }

        public static void ClearSession()
        {
            IdUser = 0;
            Username = null;
            Nama = null;
            Role = null;
        }
    }
}