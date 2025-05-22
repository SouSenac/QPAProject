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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(192, 81);
            label1.Name = "label1";
            label1.Size = new Size(93, 25);
            label1.TabIndex = 0;
            label1.Text = "Credencial";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(208, 160);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 1;
            label2.Text = "Senha";
            // 
            // tbxCred
            // 
            tbxCred.Location = new Point(165, 109);
            tbxCred.Name = "tbxCred";
            tbxCred.Size = new Size(150, 31);
            tbxCred.TabIndex = 2;
            // 
            // tbxSenha
            // 
            tbxSenha.Location = new Point(165, 188);
            tbxSenha.Name = "tbxSenha";
            tbxSenha.Size = new Size(150, 31);
            tbxSenha.TabIndex = 3;
            // 
            // btnAcessar
            // 
            btnAcessar.Location = new Point(183, 269);
            btnAcessar.Name = "btnAcessar";
            btnAcessar.Size = new Size(112, 34);
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
            label3.Location = new Point(192, 28);
            label3.Name = "label3";
            label3.Size = new Size(106, 34);
            label3.TabIndex = 5;
            label3.Text = "LOGIN";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fundo_de_papel_de_parede_colorido_embacado_artistico_58702_8313;
            ClientSize = new Size(499, 429);
            Controls.Add(label3);
            Controls.Add(btnAcessar);
            Controls.Add(tbxSenha);
            Controls.Add(tbxCred);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
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
    }
}
