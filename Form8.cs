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
    public partial class rastrear_pedido : Form
    {
        public rastrear_pedido()
        {
            InitializeComponent();
        }

        private void btn_buscarPedidos_Click(object sender, EventArgs e)
        {
            listPedidos.Items.Clear();
            listItens.Items.Clear();

            string cpf = txt_BuscarCpf.Text;
            var cliente = File.ReadLines("clientes.csv").FirstOrDefault(l => l.Contains(cpf));
            if (cliente != null)
            {
                lblNomeConsulta.Text = cliente.Split(',')[0];
                var pedidos = File.ReadLines("pedidos.csv").Where(p => p.Contains(cpf));

                foreach (var pedido in pedidos)
                {
                    listPedidos.Items.Add(pedido);
                }
            }
            else
            {
                lblNomeConsulta.Text = "Cliente não encontrado.";
            }
        }

        private void listPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            listItens.Items.Clear();
            if (listPedidos.SelectedItem == null) return;

            string codigoPedido = listPedidos.SelectedItem.ToString().Split(',')[0];
            var itens = File.ReadLines("itens_pedido.csv").Where(l => l.StartsWith(codigoPedido + ","));

            decimal total = 0;
            foreach (var item in itens)
            {
                var partes = item.Split(',');
                string linha = $"Produto: {partes[1]}, Quantidade: {partes[2]}";
                listItens.Items.Add(linha);

                var produto = File.ReadLines("produtos.csv").FirstOrDefault(p => p.StartsWith(partes[1] + ","));
                if (produto != null)
                {
                    decimal preco = decimal.Parse(produto.Split(',')[2]);
                    total += preco * int.Parse(partes[2]);
                }
            }
            lblTotalConsulta.Text = $"Total do Pedido: R$ {total:F2}";
        }
    }
}
