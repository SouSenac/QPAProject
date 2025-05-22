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
    public partial class F_TelaInicial : Form
    {
        public F_TelaInicial()
        {
            InitializeComponent();
        }

        private void F_TelaInicial_Load(object sender, EventArgs e)
        {
            // Criar o DataGridView
            DataGridView dgvEstoque = new DataGridView();
            dgvEstoque.Name = "dgvEstoque";
            dgvEstoque.Location = new Point(10, 100);
            dgvEstoque.Size = new Size(900, 250);
            dgvEstoque.AllowUserToAddRows = false; // Não permite adicionar linhas manualmente

            // Adiciona colunas
            dgvEstoque.Columns.Add("Produto", "Produto");
            dgvEstoque.Columns.Add("Marca", "Marca");
            dgvEstoque.Columns.Add("Categoria", "Categoria");
            dgvEstoque.Columns.Add("Modelo", "Modelo");
            dgvEstoque.Columns.Add("Quantidade", "Quantidade");

            // Adiciona algumas linhas de exemplo
            dgvEstoque.Rows.Add("Iphone 12", "Apple", "Smartphone", "Iphone 12", 10);
            dgvEstoque.Rows.Add("Tenis Nike Air force", "Nike", "Tênis", "Masculino", 27);
            dgvEstoque.Rows.Add("Smart TV", "Samsung", "TV", "Smart TV", 7);
            dgvEstoque.Rows.Add("Smart TV", "Samsung", "TV", "Smart TV", 7);

            // Adiciona o controle ao formulário
            this.Controls.Add(dgvEstoque);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
