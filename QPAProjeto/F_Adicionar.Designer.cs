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
            textBox1 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox3 = new ComboBox();
            textBox3 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(144, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(318, 31);
            textBox1.TabIndex = 0;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(144, 328);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(318, 31);
            textBox4.TabIndex = 3;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(144, 257);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(318, 31);
            textBox5.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Nike", "Adibas", "Jordan", "Sansumg", "Iphone", "xiaome" });
            comboBox1.Location = new Point(144, 117);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(318, 33);
            comboBox1.TabIndex = 6;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Sapato", "Smartphones", "Camisas", "Calça", "Notebook", "Tv", "Óculos", "Mochilas" });
            comboBox3.Location = new Point(144, 401);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(318, 33);
            comboBox3.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(144, 189);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(318, 31);
            textBox3.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(490, 587);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 9;
            button1.Text = "Limpar";
            button1.UseVisualStyleBackColor = true;
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
            // button2
            // 
            button2.Location = new Point(490, 534);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 16;
            button2.Text = "Adicionar";
            button2.UseVisualStyleBackColor = true;
            // 
            // F_Adicionar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fundo_de_papel_de_parede_colorido_embacado_artistico_58702_8313;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1075, 674);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(comboBox3);
            Controls.Add(comboBox1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            DoubleBuffered = true;
            Name = "F_Adicionar";
            Text = "F_Adicionar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox4;
        private TextBox textBox5;
        private ComboBox comboBox1;
        private ComboBox comboBox3;
        private TextBox textBox3;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button2;
    }
}