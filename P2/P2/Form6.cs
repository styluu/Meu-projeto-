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

                }

        private void btnEx_Click(object sender, EventArgs e)
        {
            
        }
    }
}
