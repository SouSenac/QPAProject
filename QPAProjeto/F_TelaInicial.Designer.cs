namespace QPAProjeto
{
    partial class F_TelaInicial
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
            btnEditar = new Button();
            btnAdd = new Button();
            btnConfig = new Button();
            cbxFiltro = new ComboBox();
            bntPesquisa = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(520, 13);
            btnEditar.Margin = new Padding(2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(55, 20);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(579, 13);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(69, 20);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnConfig
            // 
            btnConfig.Location = new Point(652, 12);
            btnConfig.Margin = new Padding(2);
            btnConfig.Name = "btnConfig";
            btnConfig.Size = new Size(78, 20);
            btnConfig.TabIndex = 3;
            btnConfig.Text = "Configurar";
            btnConfig.UseVisualStyleBackColor = true;
            // 
            // cbxFiltro
            // 
            cbxFiltro.FormattingEnabled = true;
            cbxFiltro.Items.AddRange(new object[] { "Nike", "Adibas", "Jordan", "Sansumg", "Iphone", "xiaome" });
            cbxFiltro.Location = new Point(326, 13);
            cbxFiltro.Margin = new Padding(2);
            cbxFiltro.Name = "cbxFiltro";
            cbxFiltro.RightToLeft = RightToLeft.No;
            cbxFiltro.Size = new Size(160, 23);
            cbxFiltro.TabIndex = 4;
            cbxFiltro.Text = "Nike";
            // 
            // bntPesquisa
            // 
            bntPesquisa.BackgroundImage = Properties.Resources.lupa;
            bntPesquisa.BackgroundImageLayout = ImageLayout.Zoom;
            bntPesquisa.Location = new Point(489, 13);
            bntPesquisa.Margin = new Padding(2);
            bntPesquisa.Name = "bntPesquisa";
            bntPesquisa.Size = new Size(26, 23);
            bntPesquisa.TabIndex = 5;
            bntPesquisa.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.LogoQPA_SEM_FUNDO;
            pictureBox1.Location = new Point(12, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // F_TelaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 395);
            Controls.Add(pictureBox1);
            Controls.Add(bntPesquisa);
            Controls.Add(cbxFiltro);
            Controls.Add(btnConfig);
            Controls.Add(btnAdd);
            Controls.Add(btnEditar);
            Margin = new Padding(2);
            Name = "F_TelaInicial";
            Text = "Estoque";
            Load += F_TelaInicial_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnEditar;
        private Button btnAdd;
        private Button btnConfig;
        private ComboBox cbxFiltro;
        private Button bntPesquisa;
        private PictureBox pictureBox1;
    }
}