namespace QPAProjeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            int credencial = Convert.ToInt32(tbxCred.Text);
            String senha = tbxSenha.Text;

            if (credencial == 1)
            {
                if (senha == "1")
                {
                    //MessageBox.Show("Acesso permitido", "teste", MessageBoxButtons.OK);
                    F_TelaInicial f_TelaInicial = new F_TelaInicial();
                    f_TelaInicial.ShowDialog();
                    tbxCred.Text = "";
                    tbxSenha.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Acesso negado", "teste", MessageBoxButtons.OK);
                tbxCred.Text = "";
                tbxSenha.Text = "";
            }
        }
    }
}
