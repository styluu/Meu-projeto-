using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace P2
{
    public partial class Form1 : Form
    {
        private string caminhoCsv = "C:\\Users\\stylu\\source\\repos\\Meu-projeto-\\P2\\P2\\bin\\Debug\\net9.0-windows\\Login.csv";

        public Form1()
        {
            InitializeComponent();
            txtSen.UseSystemPasswordChar = true;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsu.Text.Trim();
            string senha = txtSen.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ValidarCSV(usuario, senha);
            }
        }

        private bool ValidarCSV(string usuario, string senha)
        {
            try
            {
                string caminhoCSV = "Login.csv";

                if (!File.Exists(caminhoCSV))
                {
                    MessageBox.Show("Arquivo de usuários não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                using (var reader = new StreamReader(caminhoCSV))
                {
                    while (!reader.EndOfStream)
                    {
                        var linha = reader.ReadLine();
                        var colunas = linha.Split(',');
                        if (colunas.Length >= 2 && colunas[0].Trim() == usuario && colunas[1].Trim() == senha)
                        {
                            frmMenu menu = new frmMenu(usuario);
                            menu.Show();
                            this.Hide();
                            return true;
                        }
                    }
                }
                MessageBox.Show("Usuário ou senha inválidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao validar usuário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
