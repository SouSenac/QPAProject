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
            tbxNome.Location = new Point(144, 51);
            tbxNome.Name = "tbxNome";
            tbxNome.Size = new Size(318, 31);
            tbxNome.TabIndex = 0;
            // 
            // tbxQtd
            // 
            tbxQtd.Location = new Point(144, 328);
            tbxQtd.Name = "tbxQtd";
            tbxQtd.Size = new Size(318, 31);
            tbxQtd.TabIndex = 3;
            tbxQtd.TextChanged += textBox4_TextChanged;
            // 
            // tbxCor
            // 
            tbxCor.Location = new Point(144, 257);
            tbxCor.Name = "tbxCor";
            tbxCor.Size = new Size(318, 31);
            tbxCor.TabIndex = 4;
            // 
            // cbxMarca
            // 
            cbxMarca.FormattingEnabled = true;
            cbxMarca.Items.AddRange(new object[] { "Nike", "Adibas", "Jordan", "Sansumg", "Iphone", "xiaome" });
            cbxMarca.Location = new Point(144, 117);
            cbxMarca.Name = "cbxMarca";
            cbxMarca.Size = new Size(318, 33);
            cbxMarca.TabIndex = 6;
            // 
            // cbxCategoria
            // 
            cbxCategoria.FormattingEnabled = true;
            cbxCategoria.Items.AddRange(new object[] { "Sapato", "Smartphones", "Camisas", "Calça", "Notebook", "Tv", "Óculos", "Mochilas" });
            cbxCategoria.Location = new Point(144, 401);
            cbxCategoria.Name = "cbxCategoria";
            cbxCategoria.Size = new Size(318, 33);
            cbxCategoria.TabIndex = 8;
            // 
            // tbxModelo
            // 
            tbxModelo.Location = new Point(144, 189);
            tbxModelo.Name = "tbxModelo";
            tbxModelo.Size = new Size(318, 31);
            tbxModelo.TabIndex = 2;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(490, 587);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(112, 34);
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
            label1.Location = new Point(34, 50);
            label1.Name = "label1";
            label1.Size = new Size(69, 29);
            label1.TabIndex = 10;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Impact", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(27, 122);
            label2.Name = "label2";
            label2.Size = new Size(75, 29);
            label2.TabIndex = 11;
            label2.Text = "Marca";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Impact", 12F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(22, 189);
            label3.Name = "label3";
            label3.Size = new Size(84, 29);
            label3.TabIndex = 12;
            label3.Text = "Modelo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Impact", 12F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 405);
            label4.Name = "label4";
            label4.Size = new Size(108, 29);
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
            label5.Location = new Point(12, 328);
            label5.Name = "label5";
            label5.Size = new Size(125, 29);
            label5.TabIndex = 14;
            label5.Text = "Quantidade";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Impact", 12F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(28, 259);
            label6.Name = "label6";
            label6.Size = new Size(47, 29);
            label6.TabIndex = 15;
            label6.Text = "Cor";
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(490, 534);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(112, 34);
            btnAdicionar.TabIndex = 16;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // F_Adicionar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fundo_de_papel_de_parede_colorido_embacado_artistico_58702_8313;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1075, 674);
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
            Name = "F_Adicionar";
            Text = "F_Adicionar";
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