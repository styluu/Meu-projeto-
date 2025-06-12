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
        public string Usuario { get; set; }
        public frmUsuário(string usuario)
        {
            InitializeComponent();
            Usuario = usuario;
        }
    }
}
