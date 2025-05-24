namespace QPAProjeto
{
    partial class F_Adicionar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbxNome = new TextBox();
            tbxQtd = new TextBox();
            tbxCor = new TextBox();
            cbxMarca = new ComboBox();
            cbxCategoria = new ComboBox();
            tbxModelo = new TextBox();
            btnLimpar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnAdicionar = new Button();
            SuspendLayout();
            // 
            // tbxNome
            // 
            tbxNome.Location = new Point(101, 31);
            tbxNome.Margin = new Padding(2);
            tbxNome.Name = "tbxNome";
            tbxNome.Size = new Size(224, 23);
            tbxNome.TabIndex = 0;
            // 
            // tbxQtd
            // 
            tbxQtd.Location = new Point(101, 197);
            tbxQtd.Margin = new Padding(2);
            tbxQtd.Name = "tbxQtd";
            tbxQtd.Size = new Size(224, 23);
            tbxQtd.TabIndex = 3;
            tbxQtd.TextChanged += textBox4_TextChanged;
            // 
            // tbxCor
            // 
            tbxCor.Location = new Point(101, 154);
            tbxCor.Margin = new Padding(2);
            tbxCor.Name = "tbxCor";
            tbxCor.Size = new Size(224, 23);
            tbxCor.TabIndex = 4;
            // 
            // cbxMarca
            // 
            cbxMarca.FormattingEnabled = true;
            cbxMarca.Items.AddRange(new object[] { "Nike", "Adibas", "Jordan", "Sansumg", "Iphone", "xiaome" });
            cbxMarca.Location = new Point(101, 70);
            cbxMarca.Margin = new Padding(2);
            cbxMarca.Name = "cbxMarca";
            cbxMarca.Size = new Size(224, 23);
            cbxMarca.TabIndex = 6;
            // 
            // cbxCategoria
            // 
            cbxCategoria.FormattingEnabled = true;
            cbxCategoria.Items.AddRange(new object[] { "Sapato", "Smartphones", "Camisas", "Calça", "Notebook", "Tv", "Óculos", "Mochilas" });
            cbxCategoria.Location = new Point(101, 241);
            cbxCategoria.Margin = new Padding(2);
            cbxCategoria.Name = "cbxCategoria";
            cbxCategoria.Size = new Size(224, 23);
            cbxCategoria.TabIndex = 8;
            // 
            // tbxModelo
            // 
            tbxModelo.Location = new Point(101, 113);
            tbxModelo.Margin = new Padding(2);
            tbxModelo.Name = "tbxModelo";
            tbxModelo.Size = new Size(224, 23);
            tbxModelo.TabIndex = 2;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(343, 352);
            btnLimpar.Margin = new Padding(2);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(78, 20);
            btnLimpar.TabIndex = 9;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(24, 30);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 10;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Impact", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(19, 73);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 11;
            label2.Text = "Marca";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Impact", 12F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(15, 113);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 12;
            label3.Text = "Modelo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Impact", 12F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(8, 243);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 13;
            label4.Text = "Categoria";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Impact", 12F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(8, 197);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 14;
            label5.Text = "Quantidade";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Impact", 12F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(20, 155);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(32, 20);
            label6.TabIndex = 15;
            label6.Text = "Cor";
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(343, 320);
            btnAdicionar.Margin = new Padding(2);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(78, 20);
            btnAdicionar.TabIndex = 16;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // F_Adicionar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fundo_de_papel_de_parede_colorido_embacado_artistico_58702_8313;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(752, 404);
            Controls.Add(btnAdicionar);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLimpar);
            Controls.Add(cbxCategoria);
            Controls.Add(cbxMarca);
            Controls.Add(tbxCor);
            Controls.Add(tbxQtd);
            Controls.Add(tbxModelo);
            Controls.Add(tbxNome);
            DoubleBuffered = true;
            Margin = new Padding(2);
            Name = "F_Adicionar";
            Text = "Adicionar";
            Load += F_Adicionar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxNome;
        private TextBox tbxQtd;
        private TextBox tbxCor;
        private ComboBox cbxMarca;
        private ComboBox cbxCategoria;
        private TextBox tbxModelo;
        private Button btnLimpar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnAdicionar;
    }
}