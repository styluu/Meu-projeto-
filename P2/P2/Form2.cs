using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2
{
    public partial class frmMenu : Form
    {
        public string Usuario { get; set; }
        public frmMenu(string usuario)
        {
            InitializeComponent();
            Usuario = usuario;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmClientes clientes = new frmClientes();
            this.Hide();
            clientes.ShowDialog();
            this.Show();

        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            frmProdutos produtos = new frmProdutos();
            this.Hide();
            produtos.ShowDialog();
            this.Show();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            frmPedidos pedidos = new frmPedidos();
            this.Hide();
            pedidos.ShowDialog();
            this.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            if (Usuario == "ADMIN")
            {
                frmUsuário usuarios = new frmUsuário(Usuario);
                this.Hide();
                usuarios.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Apenas usuários administradores podem acessar.", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnMudar_Click(object sender, EventArgs e)
        {
            frmSenha senha = new frmSenha(Usuario);
            this.Hide();
            senha.ShowDialog();
            this.Show();
        }
    }
}
