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
    public partial class cadastro_pedidos : Form
    {
        private string caminhoPedidos = "pedidos.csv";
        private string caminhoItens = "itens_pedido.csv";
        private List<string> itensPedido = new List<string>();

        public cadastro_pedidos()
        {
            InitializeComponent();
        }

        private void cadastro_pedidos_Load(object sender, EventArgs e)
        {

        }

        private void txtCPFCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            string cpf = txtCPFCliente.Text;
            var cliente = File.ReadLines("clientes.csv").FirstOrDefault(l => l.Contains(cpf));
            if (cliente != null)
            {
                lblNomeCliente.Text = cliente.Split(',')[0];
            }
            else
            {
                lblNomeCliente.Text = "Cliente não encontrado.";
            }
        }

        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            string codigoProduto = txtCodigoProduto.Text;
            int quantidade = int.Parse(txtQuantidade.Text);

            var produto = File.ReadLines("produtos.csv").FirstOrDefault(l => l.StartsWith(codigoProduto + ","));
            if (produto != null)
            {
                var dados = produto.Split(',');
                string nome = dados[1];
                decimal preco = decimal.Parse(dados[2]);
                decimal total = preco * quantidade;

                string item = string.Join(",", codigoProduto, nome, preco.ToString("F2"), quantidade, total.ToString("F2"));
                itensPedido.Add(item);
                listItensPedido.Items.Add(item);

                AtualizarTotalPedido();
            }
        }
        private void AtualizarTotalPedido()
        {
            decimal total = itensPedido.Sum(item => decimal.Parse(item.Split(',')[4]));
            lblTotalPedido.Text = $"Total: R$ {total:F2}";
        }

        private void btnSalvarPedido_Click(object sender, EventArgs e)
        {
            string codigoPedido = txtCodigoProduto.Text;
            string cpf = txtCPFCliente.Text;
            decimal total = itensPedido.Sum(i => decimal.Parse(i.Split(',')[4]));

            File.AppendAllText(caminhoPedidos, $"{codigoPedido},{cpf},{total:F2}\n");
            foreach (var item in itensPedido)
            {
                var partes = item.Split(',');
                File.AppendAllText(caminhoItens, $"{codigoPedido},{partes[0]},{partes[3]}\n");
            }

            MessageBox.Show("Pedido salvo com sucesso!");
            itensPedido.Clear();
            listItensPedido.Items.Clear();
            lblTotalPedido.Text = "Total: R$ 0,00";
        
    }
    }
}
