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
        public frmMenu()
        {
            InitializeComponent();
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
    }
}
