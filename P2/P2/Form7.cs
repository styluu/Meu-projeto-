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
    public partial class frmSenha : Form
    {
        public string Usuario { get; set; }
        public frmSenha(string usuario)
        {
            Usuario = usuario;
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt1.Text))
            {
                MessageBox.Show("A nova senha não pode estar vazia.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    string caminhoCSV = "Login.csv";
                    if (!File.Exists(caminhoCSV))
                    {
                        MessageBox.Show("Arquivo de usuários não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    var linhas = File.ReadAllLines(caminhoCSV).ToList();
                    for (int i = 0; i < linhas.Count; i++)
                    {
                        var colunas = linhas[i].Split(',');
                        if (colunas.Length >= 2 && colunas[0].Trim() == Usuario)
                        {
                            colunas[1] = txt1.Text.Trim();
                            linhas[i] = string.Join(",", colunas);
                            break;
                        }
                    }
                    File.WriteAllLines(caminhoCSV, linhas);
                    MessageBox.Show("Senha atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar a nova senha: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
