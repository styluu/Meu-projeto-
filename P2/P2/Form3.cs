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

        private async void btnBus_Click(object sender, EventArgs e)
        {
            string cep = msCEP.Text.Trim();
            if (string.IsNullOrEmpty(cep) || cep.Length != 8)
            {
                MessageBox.Show("Por favor, insira um CEP válido com 8 dígitos.");
                return;
            }
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string url = $"https://viacep.com.br/ws/{cep}/json/";
                    HttpResponseMessage response = await client.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResponse = await response.Content.ReadAsStringAsync();
                        Endereco endereco = JsonSerializer.Deserialize<Endereco>(jsonResponse, new JsonSerializerOptions
                        {
                            PropertyNameCaseInsensitive = true
                        });

                        if (endereco != null)
                        {
                            txtLogra.Text = endereco.Logradouro;
                            txtBai.Text = endereco.Bairro;
                            txtCid.Text = endereco.Localidade;
                            txtEst.Text = endereco.Uf;

                            txtBai.ReadOnly = false;
                            txtCid.ReadOnly = false;
                            txtLogra.ReadOnly = false;
                            txtEst.ReadOnly = false;

                            txtNum.Focus();
                        }
                        else
                        {
                            MessageBox.Show("CEP não encontrado.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Erro ao buscar CEP. Verifique o CEP informado.");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar CEP: " + ex.Message);
            }
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

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(msCPF.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(msCEP.Text) || string.IsNullOrEmpty(txtLogra.Text) || string.IsNullOrEmpty(txtNum.Text) || string.IsNullOrEmpty(txtBai.Text) || string.IsNullOrEmpty(txtCid.Text) || string.IsNullOrEmpty(txtEst.Text) || string.IsNullOrEmpty(msTel.Text) || string.IsNullOrEmpty(msWhats.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.");
                return;
            }
            else
            {
                try
                {
                    string caminhoCSV = "cadastroClientes.csv";

                    if (btnSalva.Text == "Atualizar" && clienteSelecionadoAtual != null)
                    {
                        try
                        {
                            string linhaSelecionada = list1.SelectedItem.ToString();
                            string clienteOriginal = linhaSelecionada.Split('-')[0].Trim();

                            string cpf = msCPF.Text.Trim();
                            using (StreamReader sr = new StreamReader(caminhoCSV))
                            {
                                string linha;
                                while ((linha = sr.ReadLine()) != null)
                                {
                                    var colunas = linha.Split(',');
                                    if (colunas.Length > 1 && colunas[1].Trim() == cpf)
                                    {
                                        MessageBox.Show("CPF já cadastrado.");
                                        return;
                                    }
                                }

                            }

                            string[] linhas = File.ReadAllLines(caminhoCSV);
                            for (int i = 0; i < linhas.Length; i++)
                            {
                                var colunas = linhas[i].Split(',');
                                if (colunas.Length > 1 && colunas[1].Trim() == clienteSelecionadoAtual.cpf)
                                {
                                    linhas[i] = $"{txtNome.Text.Trim()},{msCPF.Text.Trim()},{txtEmail.Text.Trim()},{msCEP.Text.Trim()},{txtLogra.Text.Trim()},{txtNum.Text.Trim()},{txtBai.Text.Trim()},{txtCid.Text.Trim()},{txtEst.Text.Trim()},{msTel.Text.Trim()},{msWhats.Text.Trim()}";
                                    break;
                                }
                            }
                            File.WriteAllLines(caminhoCSV, linhas);
                            MessageBox.Show("Dados atualizados com sucesso!");
                            carregaDados();
                            txtNome.Clear();
                            msCPF.Clear();
                            txtEmail.Clear();
                            msCEP.Clear();
                            txtLogra.Clear();
                            txtNum.Clear();
                            txtBai.Clear();
                            txtCid.Clear();
                            txtEst.Clear();
                            msTel.Clear();
                            msWhats.Clear();
                            clienteSelecionadoAtual = null;
                            btnSalva.Text = "Salvar";
                            list1.SelectedItem = null;
                            txtNome.Focus();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao atualizar os dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        try
                        {
                            string caminho = "cadastroClientes.csv";
                            if (!File.Exists(caminho))
                            {
                                MessageBox.Show("Arquivo de cadastro não encontrado. Criando novo arquivo.");
                                return;
                            }
                            else
                            {
                                string cpf = msCPF.Text.Trim();
                                using (StreamReader sr = new StreamReader(caminho))
                                {
                                    string linha;
                                    while ((linha = sr.ReadLine()) != null)
                                    {
                                        var colunas = linha.Split(',');
                                        if (colunas.Length > 1 && colunas[1].Trim() == cpf)
                                        {
                                            MessageBox.Show("CPF já cadastrado.");
                                            return;
                                        }
                                    }

                                }
                                using (StreamWriter sw = new StreamWriter(caminho, true))
                                {
                                    string linha = $"{txtNome.Text.Trim()},{msCPF.Text.Trim()},{txtEmail.Text.Trim()},{msCEP.Text.Trim()},{txtLogra.Text.Trim()},{txtNum.Text.Trim()},{txtBai.Text.Trim()},{txtCid.Text.Trim()},{txtEst.Text.Trim()},{msTel.Text.Trim()},{msWhats.Text.Trim()}";
                                    sw.WriteLine(linha);
                                    MessageBox.Show("Dados salvos com sucesso!");
                                }
                                carregaDados();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao salvar os dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar os dados. Verifique as informações e tente novamente.");
                }
            }
        }
    }
}
