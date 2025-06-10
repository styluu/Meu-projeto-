using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace P2
{
    public partial class Form1 : Form
    {
        private string caminhoCsv = "C:\\Users\\stylu\\source\\repos\\Meu-projeto-\\P2\\P2\\Login.csv";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsu.Text.Trim();
            string senha = txtSen.Text.Trim();

            try
            {
                if (!File.Exists(caminhoCsv))
                {
                    MessageBox.Show("Arquivo de login não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string[] linhas = File.ReadAllLines(caminhoCsv);

                bool credenciaisValidas = linhas
                    .Skip(1)
                    .Select(linha => linha.Split(','))
                    .Any(campos => campos.Length >= 2 && campos[0] == usuario && campos[1] == senha);

                if (credenciaisValidas)
                {
                    frmMenu menu = new frmMenu();
                    this.Hide();
                    menu.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos. Por favor, tente novamente.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao verificar as credenciais: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
