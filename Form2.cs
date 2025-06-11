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
    public partial class cadastro_clientes : Form
    {
        public cadastro_clientes()
        {
            InitializeComponent();

        }

        private void cadastro_clientes_Load(object sender, EventArgs e)
        {

        }
        private string currentUser;

        public cadastro_clientes(string user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lbl_user.Text = $"Usuário logado: {currentUser}";
        }

        private void cadastro_usuarios_Click(object sender, EventArgs e)
        {
            if (currentUser == "ADMIN")
            {
                new clientes().ShowDialog();
            }
            else
            {
                MessageBox.Show("Apenas o ADMIN pode acessar este módulo.");
            }


        }

        private void btn_pedidos_Click(object sender, EventArgs e)
        {
            cadastro_pedidos form = new cadastro_pedidos();
            form.ShowDialog();
        }

        private void btn_produtos_Click(object sender, EventArgs e)
        {
            cadastro_produtos form = new cadastro_produtos();
            form.ShowDialog();
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            clientes form = new clientes();
            form.ShowDialog();
        }
    }
}
