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
            comboBox1 = new ComboBox();
            bntPesquisa = new Button();
            SuspendLayout();
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(732, 21);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(78, 34);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(816, 21);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(99, 34);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnConfig
            // 
            btnConfig.Location = new Point(921, 21);
            btnConfig.Name = "btnConfig";
            btnConfig.Size = new Size(112, 34);
            btnConfig.TabIndex = 3;
            btnConfig.Text = "Configurar";
            btnConfig.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Nike", "Adibas", "Jordan", "Sansumg", "Iphone", "xiaome" });
            comboBox1.Location = new Point(450, 21);
            comboBox1.Name = "comboBox1";
            comboBox1.RightToLeft = RightToLeft.No;
            comboBox1.Size = new Size(227, 33);
            comboBox1.TabIndex = 4;
            comboBox1.Text = "Nike";
            // 
            // bntPesquisa
            // 
            bntPesquisa.BackgroundImage = Properties.Resources.lupa;
            bntPesquisa.BackgroundImageLayout = ImageLayout.Zoom;
            bntPesquisa.Location = new Point(683, 21);
            bntPesquisa.Name = "bntPesquisa";
            bntPesquisa.Size = new Size(49, 34);
            bntPesquisa.TabIndex = 5;
            bntPesquisa.UseVisualStyleBackColor = true;
            // 
            // F_TelaInicial
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fundoTeste;
            ClientSize = new Size(1056, 658);
            Controls.Add(bntPesquisa);
            Controls.Add(comboBox1);
            Controls.Add(btnConfig);
            Controls.Add(btnAdd);
            Controls.Add(btnEditar);
            Name = "F_TelaInicial";
            Text = "F_TelaInicial";
            Load += F_TelaInicial_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnEditar;
        private Button btnAdd;
        private Button btnConfig;
        private ComboBox comboBox1;
        private Button bntPesquisa;
    }
}