namespace gestão_de_negócio_clientes_e_vendas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public class UserModel
        {
            public string Username { get; set; }
            public string Password { get; set; }

            public UserModel(string username, string password)
            {
                Username = username;
                Password = password;
            }
        }
        public static class CsvHelper
        {
            private static readonly string filePath = @"C:\Users\Alexandre Pacheco\Desktop\aplicação negocio vendas\usuarios";

            public static List<UserModel> LoadUsers()
            {
                var users = new List<UserModel>();

                if (!File.Exists(filePath))
                    return users;

                var lines = File.ReadAllLines(filePath);

                for (int i = 1; i < lines.Length; i++) // pula o cabeçalho
                {
                    var parts = lines[i].Split(',');

                    if (parts.Length >= 2)
                    {
                        var user = new UserModel(parts[0].Trim(), parts[1].Trim());
                        users.Add(user);
                    }
                }

                return users;
            }
        }
        public static class AuthService
        {
            public static bool Authenticate(string username, string password)
            {
                if (username.ToUpper() == "ADMIN" && password == "123")
                    return true;

                var users = CsvHelper.LoadUsers();

                return users.Any(u =>
                    u.Username.Equals(username, System.StringComparison.OrdinalIgnoreCase) &&
                    u.Password == password);
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_usuario.Text.Trim();
            string password = txt_senha.Text.Trim();

            if (AuthService.Authenticate(username, password))
            {
                this.Hide();
                cadastros main = new cadastros();
                main.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }

