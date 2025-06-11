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
    public partial class cadastro_produtos : Form
    {
        private string caminho = "produtos.csv";
        public cadastro_produtos()
        {
            InitializeComponent();
            CarregarProdutos();
        }
        private void CarregarProdutos()
        {
            listProdutos.Items.Clear();
            if (!File.Exists(caminho)) return;

            foreach (var linha in File.ReadAllLines(caminho))
            {
                listProdutos.Items.Add(linha);
            }
        }
        private void cadastro_produtos_Load(object sender, EventArgs e)
        {

        }

        private void btnAdicionarProdutos_Click(object sender, EventArgs e)
        {
            string produto = string.Join(",",
                txtCodigo.Text,
                txtProduto.Text,
                txtPreco.Text,
                txtDescricao.Text);

            using (StreamWriter sw = File.AppendText(caminho))
            {
                sw.WriteLine(produto);
            }
            CarregarProdutos();
        }

        private void btn_excluirProdutos_Click(object sender, EventArgs e)
        {
            if (listProdutos.SelectedItem == null) return;
            string selecionado = listProdutos.SelectedItem.ToString();
            string codigo = selecionado.Split(',')[0];

            var linhas = File.ReadAllLines(caminho);
            using (StreamWriter sw = new StreamWriter(caminho))
            {
                foreach (var linha in linhas)
                {
                    if (!linha.StartsWith(codigo + ","))
                    {
                        sw.WriteLine(linha);
                    }
                }
            }
            CarregarProdutos();
        }
    }
}
