namespace QPAProjeto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            tbxCred = new TextBox();
            tbxSenha = new TextBox();
            btnAcessar = new Button();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(134, 49);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Credencial";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(146, 96);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Senha";
            // 
            // tbxCred
            // 
            tbxCred.Location = new Point(116, 65);
            tbxCred.Margin = new Padding(2, 2, 2, 2);
            tbxCred.Name = "tbxCred";
            tbxCred.Size = new Size(106, 23);
            tbxCred.TabIndex = 2;
            // 
            // tbxSenha
            // 
            tbxSenha.Location = new Point(116, 113);
            tbxSenha.Margin = new Padding(2, 2, 2, 2);
            tbxSenha.Name = "tbxSenha";
            tbxSenha.Size = new Size(106, 23);
            tbxSenha.TabIndex = 3;
            // 
            // btnAcessar
            // 
            btnAcessar.Location = new Point(128, 161);
            btnAcessar.Margin = new Padding(2, 2, 2, 2);
            btnAcessar.Name = "btnAcessar";
            btnAcessar.Size = new Size(78, 20);
            btnAcessar.TabIndex = 4;
            btnAcessar.Text = "Acessar";
            btnAcessar.UseVisualStyleBackColor = true;
            btnAcessar.Click += btnAcessar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Swis721 Hv BT", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(134, 17);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(73, 22);
            label3.TabIndex = 5;
            label3.Text = "LOGIN";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.LogoQPA_SEM_FUNDO;
            pictureBox1.Location = new Point(12, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fundo_de_papel_de_parede_colorido_embacado_artistico_58702_8313;
            ClientSize = new Size(349, 257);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(btnAcessar);
            Controls.Add(tbxSenha);
            Controls.Add(tbxCred);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbxCred;
        private TextBox tbxSenha;
        private Button btnAcessar;
        private Label label3;
        private PictureBox pictureBox1;
    }
}
