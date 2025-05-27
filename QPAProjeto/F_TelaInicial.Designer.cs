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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            adicionarToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            configurarToolStripMenuItem = new ToolStripMenuItem();
            configuraçõesToolStripMenuItem = new ToolStripMenuItem();
            editarItensToolStripMenuItem = new ToolStripMenuItem();
            adicionarItensToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.LogoQPA_SEM_FUNDO;
            pictureBox1.Location = new Point(0, -6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { adicionarToolStripMenuItem, adicionarItensToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(181, 70);
            // 
            // adicionarToolStripMenuItem
            // 
            adicionarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { editarToolStripMenuItem, editarItensToolStripMenuItem });
            adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            adicionarToolStripMenuItem.Size = new Size(180, 22);
            adicionarToolStripMenuItem.Text = "Adicionar";
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { configurarToolStripMenuItem, configuraçõesToolStripMenuItem });
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(132, 22);
            editarToolStripMenuItem.Text = "Editar";
            // 
            // configurarToolStripMenuItem
            // 
            configurarToolStripMenuItem.Name = "configurarToolStripMenuItem";
            configurarToolStripMenuItem.Size = new Size(151, 22);
            configurarToolStripMenuItem.Text = "Configurar";
            // 
            // configuraçõesToolStripMenuItem
            // 
            configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            configuraçõesToolStripMenuItem.Size = new Size(151, 22);
            configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // editarItensToolStripMenuItem
            // 
            editarItensToolStripMenuItem.Name = "editarItensToolStripMenuItem";
            editarItensToolStripMenuItem.Size = new Size(132, 22);
            editarItensToolStripMenuItem.Text = "Editar Itens";
            // 
            // adicionarItensToolStripMenuItem
            // 
            adicionarItensToolStripMenuItem.Name = "adicionarItensToolStripMenuItem";
            adicionarItensToolStripMenuItem.Size = new Size(180, 22);
            adicionarItensToolStripMenuItem.Text = "Adicionar Itens";
            // 
            // F_TelaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 395);
            Controls.Add(pictureBox1);
            Margin = new Padding(2);
            Name = "F_TelaInicial";
            Text = "Estoque";
            Load += F_TelaInicial_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem adicionarToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem configurarToolStripMenuItem;
        private ToolStripMenuItem adicionarItensToolStripMenuItem;
        private ToolStripMenuItem configuraçõesToolStripMenuItem;
        private ToolStripMenuItem editarItensToolStripMenuItem;
    }
}