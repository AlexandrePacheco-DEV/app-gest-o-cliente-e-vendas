using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestão_de_negócio_clientes_e_vendas
{
    public partial class cadastro_users : Form
    {
        private string caminhoCsv = "usuarios.csv";

        private object currentUser;

        public cadastro_users(string currentUser)
        {
            InitializeComponent();
            CarregarUsuarios();
        }
        private void CarregarUsuarios()
        {
            listUsuarios.Items.Clear();
            if (!File.Exists(caminhoCsv)) return;
            foreach (var linha in File.ReadAllLines(caminhoCsv))
            {
                var partes = linha.Split(',');
                listUsuarios.Items.Add(partes[0]);
            }
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

        private void cadastro_users_Load(object sender, EventArgs e)
        {
            cadastro_users_Load(sender, e, currentUser);
        }

        private void cadastro_users_Load(object sender, EventArgs e, object? currentUser)
        {
            lbl_user.Text = "Usuário logado: " + (currentUser ?? "desconhecido");
            LoadUsuarios();

            if (!string.Equals((string?)currentUser, "ADMIN", StringComparison.OrdinalIgnoreCase))
            {
                btn_adicionarUsuario.Enabled = false;
                btn_excluirUsuario.Enabled = false;
            }
        }

        private void LoadUsuarios()
        {
            throw new NotImplementedException();
        }

        public static class CsvHelper
        {
            public static readonly string UsuariosPath = @"C:\SeuCaminho\usuarios.csv";

            public static void EnsureUsuariosCsvExists()
            {
                if (!File.Exists(UsuariosPath))
                {
                    using (var writer = new StreamWriter(UsuariosPath))
                    {
                        writer.WriteLine("usuario,senha");
                        writer.WriteLine("ADMIN,123");
                    }
                }
            }

            public static List<UserModel> LoadUsuarios()
            {
                EnsureUsuariosCsvExists();

                var users = new List<UserModel>();
                var lines = File.ReadAllLines(UsuariosPath);

                for (int i = 1; i < lines.Length; i++)
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

            public static void SaveUsuarios(List<UserModel> users)
            {
                EnsureUsuariosCsvExists();

                using (var writer = new StreamWriter(UsuariosPath, false))
                {
                    writer.WriteLine("usuario,senha");

                    foreach (var user in users)
                    {
                        writer.WriteLine($"{user.Username},{user.Password}");
                    }
                }
            }

            public static void AddUsuario(string username, string password)
            {
                var users = LoadUsuarios();

                if (users.Any(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase)))
                    return;

                users.Add(new UserModel(username, password));
                SaveUsuarios(users);
            }

            public static void DeleteUsuario(string username)
            {
                var users = LoadUsuarios();

                var userToRemove = users.FirstOrDefault(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase));

                if (userToRemove != null && userToRemove.Username.ToUpper() != "ADMIN")
                {
                    users.Remove(userToRemove);
                    SaveUsuarios(users);
                }
            }

            public static void UpdateUsuarioPassword(string username, string newPassword)
            {
                var users = LoadUsuarios();

                var userToUpdate = users.FirstOrDefault(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase));

                if (userToUpdate != null)
                {
                    userToUpdate.Password = newPassword;
                    SaveUsuarios(users);
                }
            }
        }

        private void btn_adicionarUsuario_Click(object sender, EventArgs e)
        {
            string usuario = PassUsuario.Text;
            string senha = usuarioSenha.Text;

            if (usuario == "ADMIN")
            {
                MessageBox.Show("Não é permitido sobrescrever o ADMIN.");
                return;
            }

            using (StreamWriter sw = File.AppendText(caminhoCsv))
            {
                sw.WriteLine($"{usuario},{senha}");
            }

            CarregarUsuarios();
            PassUsuario.Clear();
            usuarioSenha.Clear();
        }
    }
}
