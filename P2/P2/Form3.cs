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
        }

        private void btnBus_Click(object sender, EventArgs e)
        {

        }
    }
}
