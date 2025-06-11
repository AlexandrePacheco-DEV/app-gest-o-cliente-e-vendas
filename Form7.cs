using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestão_de_negócio_clientes_e_vendas
{
    public partial class clientes : Form
    {
        private string caminho = "clientes.csv";
        public clientes()
        {
            InitializeComponent();
        }

        private void clientes_Load(object sender, EventArgs e)
        {

        }

        private async void btn_buscarCep_Click(object sender, EventArgs e)
        {
            string cep = txtCep.Text.Replace("-", "").Trim();
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync($"https://viacep.com.br/ws/{cep}/json/");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var endereco = JsonSerializer.Deserialize<ViaCepResponse>(json);
                    txtLogradouro.Text = endereco.logradouro;
                    txtBairro.Text = endereco.bairro;
                    txtCidade.Text = endereco.localidade;
                    txtEstado.Text = endereco.uf;
                }
            }

        }

        public class ViaCepResponse
        {
            public string cep { get; set; }
            public string logradouro { get; set; }
            public string complemento { get; set; }
            public string bairro { get; set; }
            public string localidade { get; set; }
            public string uf { get; set; }
            public string ibge { get; set; }
            public string gia { get; set; }
            public string ddd { get; set; }
            public string siafi { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string linha = string.Join(",",
                txtNome.Text,
                txtCPF.Text,
                txtEmail.Text,
                txtCep.Text,
                txtLogradouro.Text,
                txtBairro.Text,
                txtCidade.Text,
                txtEstado.Text,
                txtTelefone.Text,
                txtWhatsapp.Text);

            using (StreamWriter sw = File.AppendText(caminho))
            {
                sw.WriteLine(linha);
            }
            MessageBox.Show("Cliente cadastrado com sucesso.");
        }
    }

}
    


