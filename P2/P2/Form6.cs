using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2
{
    public partial class frmUsuário : Form
    {
        private UsuarioSelecionado usuarioSelecionadoAtual;
        public string Usuario { get; set; }
        public frmUsuário(string usuario)
        {
            InitializeComponent();
            Usuario = usuario;
        }
        public class UsuarioSelecionado
        {
            public string Nome { get; set; }
            public string Senha { get; set; }
        }
        public void CarregarDados()
        {
            try
            {
                string caminhoCSV = "Login.csv";
                if (!File.Exists(caminhoCSV))
                {
                    MessageBox.Show("Arquivo de usuários não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                using (var reader = new StreamReader(caminhoCSV))
                {
                    list1.Items.Clear();
                    while (!reader.EndOfStream)
                    {
                        var linha = reader.ReadLine();
                        if (!string.IsNullOrWhiteSpace(linha))
                        {
                            var colunas = linha.Split(',');
                            if (colunas.Length >= 2)
                            {
                                list1.Items.Add($"{colunas[0].Trim()} - {colunas[1].Trim()}");
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCadas_Click(object sender, EventArgs e)
        {
            string usuario = txtUsu.Text;
            string senha = txtSen.Text;

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Preencha todos os campos.");
                return;
            }
            else
            {
                try
                {

                    string caminhoCSV = "usuarios.csv";
                    if (!File.Exists(caminhoCSV))
                    {
                        MessageBox.Show("Arquivo de usuários não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (btnCadas.Text == "Atualizar" && list1.SelectedItem != null)
                        {
                            try
                            {

                                string linhaSelecionada = list1.SelectedItem.ToString();
                                string usuarioOriginal = linhaSelecionada.Split('-')[0].Trim();

                                var linhas = File.ReadAllLines(caminhoCSV).ToList();

                                for (int i = 0; i < linhas.Count; i++)
                                {
                                    var dados = linhas[i].Split(',');
                                    if (dados[0].Trim().Equals(usuarioOriginal, StringComparison.OrdinalIgnoreCase))
                                    {
                                        linhas[i] = $"{usuario},{senha}";
                                        break;
                                    }
                                }

                                File.WriteAllLines(caminhoCSV, linhas);

                                MessageBox.Show("Usuário atualizado com sucesso!");


                                txtUsu.Clear();
                                txtSen.Clear();
                                btnCadas.Text = "Cadastrar";
                                CarregarDados();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Erro ao atualizar usuário: " + ex.Message);
                            }

                        }
                        else
                        {
                            try
                            {
                                var linhas = File.ReadAllLines(caminhoCSV);
                                foreach (var linha in linhas)
                                {
                                    var dados = linha.Split(',');
                                    if (dados.Length >= 2 && dados[0].Trim().Equals(usuario, StringComparison.OrdinalIgnoreCase))
                                    {
                                        MessageBox.Show("Usuário já existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                }
                                using (var writer = new StreamWriter(caminhoCSV, true))
                                {
                                    writer.WriteLine($"{usuario},{senha}");
                                    MessageBox.Show("Usuário cadastrado com sucesso!");
                                    list1.Items.Add($"{usuario} - {senha}");
                                    txtUsu.Clear();
                                    txtSen.Clear();
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Erro ao cadastrar usuário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar usuário: " + ex.Message);
                    return;
                }
            }
        }
        private void list1_DoubleClick(object sender, EventArgs e)
        {
            if (list1.SelectedItem != null)
            {
                string linhaSelecionada = list1.SelectedItem.ToString();
                var partes = linhaSelecionada.Split('-');



                if (partes.Length >= 2)
                {
                    txtUsu.Text = partes[0].Trim();
                    txtSen.Text = partes[1].Trim();

                    usuarioSelecionadoAtual = new UsuarioSelecionado
                    {
                        Nome = partes[0].Trim(),
                        Senha = partes[1].Trim()
                    };

                    btnCadas.Text = "Atualizar";
                }
                else
                {
                    MessageBox.Show("Seleção inválida. Por favor, selecione um usuário válido.");
                }
            }
        }
        private void btnEx_Click(object sender, EventArgs e)
        {
            if (usuarioSelecionadoAtual == null)
            {
                MessageBox.Show("Nenhum usuário selecionado para exclusão.");
                return;
            }
            else
            {
                var confirmar = MessageBox.Show($"Deseja realmente excluir o usuário '{usuarioSelecionadoAtual.Nome}'?", "Confirmar exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            }

    }
}
