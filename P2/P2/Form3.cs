using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Runtime.ConstrainedExecution;

namespace P2
{
    public partial class frmClientes : Form
    {
        private ClienteSelecionado clienteSelecionadoAtual;
        public class Endereco
        {
            public string Cep { get; set; }
            public string Logradouro { get; set; }
            public string Complemento { get; set; }
            public string Bairro { get; set; }
            public string Localidade { get; set; }
            public string Uf { get; set; }
            public string Ibge { get; set; }
            public string Gia { get; set; }
            public string Ddd { get; set; }
            public string Siafi { get; set; }
        }
        public class ClienteSelecionado
        {
            public string cpf { get; set; }
        }
        public frmClientes()
        {
            InitializeComponent();
            carregaDados();
            txtBai.ReadOnly = true;
            txtCid.ReadOnly = true;
            txtLogra.ReadOnly = true;
            txtEst.ReadOnly = true;

            list1.DoubleClick += list1_DoubleClick;

        }

        private void btnBus_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void carregaDados()
        {
            string caminhoCSV = "Clientes.csv";
            if (!File.Exists(caminhoCSV))
            {
                MessageBox.Show("Arquivo de cadastro não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                list1.Items.Clear();
                using (StreamReader sr = new StreamReader(caminhoCSV))
                {
                    string linha;
                    while ((linha = sr.ReadLine()) != null)
                    {
                        if (!string.IsNullOrWhiteSpace(linha))
                        {
                            var colunas = linha.Split(',');
                            if (colunas.Length >= 11)
                            {
                                list1.Items.Add($"{colunas[0].Trim()} - {colunas[1].Trim()} - {colunas[2].Trim()} - {colunas[3].Trim()} - {colunas[4].Trim()} - {colunas[5].Trim()} - {colunas[6].Trim()} - {colunas[7].Trim()} - {colunas[8].Trim()} - {colunas[9].Trim()} - {colunas[10].Trim()}");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void list1_DoubleClick(object sender, EventArgs e)
        {
            if (list1.SelectedItem != null)
            {
                string[] dados = list1.SelectedItem.ToString().Split('-');
                if (dados.Length >= 11)
                {
                    txtNome.Text = dados[0].Trim();
                    msCPF.Text = dados[1].Trim();
                    txtEmail.Text = dados[2].Trim();
                    msCEP.Text = dados[3].Trim();
                    txtLogra.Text = dados[4].Trim();
                    txtNum.Text = dados[5].Trim();
                    txtBai.Text = dados[6].Trim();
                    txtCid.Text = dados[7].Trim();
                    txtEst.Text = dados[8].Trim();
                    msTel.Text = dados[9].Trim();
                    msWhats.Text = dados[10].Trim();
                    clienteSelecionadoAtual = new ClienteSelecionado
                    {
                        cpf = msCPF.Text.Trim()
                    };
                    btnSalva.Text = "Atualizar";
                }
                else
                {
                    MessageBox.Show("Selecione um cliente da lista para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


            }
        }
    }
}
