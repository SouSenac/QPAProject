using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QPAProjeto
{
    public partial class F_Adicionar : Form
    {
        public F_Adicionar()
        {
            InitializeComponent();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void F_Adicionar_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tbxNome.Clear();
            tbxCor.Clear();
            tbxModelo.Clear();
            tbxQtd.Clear();

            cbxCategoria.SelectedIndex = -1;
            cbxMarca.SelectedIndex = -1;


        }
    }
}
