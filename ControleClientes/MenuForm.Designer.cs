namespace ControleClientes
{
    partial class MenuForm
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
            menuStrip1 = new MenuStrip();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            cidadeToolStripMenuItem = new ToolStripMenuItem();
            janelaToolStripMenuItem = new ToolStripMenuItem();
            cascataToolStripMenuItem = new ToolStripMenuItem();
            ladoALadoHorizontalToolStripMenuItem = new ToolStripMenuItem();
            ladoALadoVerticalToolStripMenuItem = new ToolStripMenuItem();
            íconesMinimizadosToolStripMenuItem = new ToolStripMenuItem();
            ordemDeServiçoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, janelaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(947, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clienteToolStripMenuItem, cidadeToolStripMenuItem, ordemDeServiçoToolStripMenuItem });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(82, 24);
            cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(224, 26);
            clienteToolStripMenuItem.Text = "Cliente";
            clienteToolStripMenuItem.Click += clienteToolStripMenuItem_Click;
            // 
            // cidadeToolStripMenuItem
            // 
            cidadeToolStripMenuItem.Name = "cidadeToolStripMenuItem";
            cidadeToolStripMenuItem.Size = new Size(224, 26);
            cidadeToolStripMenuItem.Text = "Cidade";
            cidadeToolStripMenuItem.Click += cidadeToolStripMenuItem_Click;
            // 
            // janelaToolStripMenuItem
            // 
            janelaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cascataToolStripMenuItem, ladoALadoHorizontalToolStripMenuItem, ladoALadoVerticalToolStripMenuItem, íconesMinimizadosToolStripMenuItem });
            janelaToolStripMenuItem.Name = "janelaToolStripMenuItem";
            janelaToolStripMenuItem.Size = new Size(64, 24);
            janelaToolStripMenuItem.Text = "Janela";
            // 
            // cascataToolStripMenuItem
            // 
            cascataToolStripMenuItem.Name = "cascataToolStripMenuItem";
            cascataToolStripMenuItem.Size = new Size(242, 26);
            cascataToolStripMenuItem.Text = "Cascata";
            cascataToolStripMenuItem.Click += cascataToolStripMenuItem_Click;
            // 
            // ladoALadoHorizontalToolStripMenuItem
            // 
            ladoALadoHorizontalToolStripMenuItem.Name = "ladoALadoHorizontalToolStripMenuItem";
            ladoALadoHorizontalToolStripMenuItem.Size = new Size(242, 26);
            ladoALadoHorizontalToolStripMenuItem.Text = "Lado a lado horizontal";
            ladoALadoHorizontalToolStripMenuItem.Click += ladoALadoHorizontalToolStripMenuItem_Click;
            // 
            // ladoALadoVerticalToolStripMenuItem
            // 
            ladoALadoVerticalToolStripMenuItem.Name = "ladoALadoVerticalToolStripMenuItem";
            ladoALadoVerticalToolStripMenuItem.Size = new Size(242, 26);
            ladoALadoVerticalToolStripMenuItem.Text = "Lado a lado vertical";
            ladoALadoVerticalToolStripMenuItem.Click += ladoALadoVerticalToolStripMenuItem_Click;
            // 
            // íconesMinimizadosToolStripMenuItem
            // 
            íconesMinimizadosToolStripMenuItem.Name = "íconesMinimizadosToolStripMenuItem";
            íconesMinimizadosToolStripMenuItem.Size = new Size(242, 26);
            íconesMinimizadosToolStripMenuItem.Text = "Ícones minimizados";
            íconesMinimizadosToolStripMenuItem.Click += íconesMinimizadosToolStripMenuItem_Click;
            // 
            // ordemDeServiçoToolStripMenuItem
            // 
            ordemDeServiçoToolStripMenuItem.Name = "ordemDeServiçoToolStripMenuItem";
            ordemDeServiçoToolStripMenuItem.Size = new Size(224, 26);
            ordemDeServiçoToolStripMenuItem.Text = "Ordem de Serviço";
            ordemDeServiçoToolStripMenuItem.Click += ordemDeServiçoToolStripMenuItem_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 615);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MenuForm";
            Text = "Controle de Clientes";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem janelaToolStripMenuItem;
        private ToolStripMenuItem cascataToolStripMenuItem;
        private ToolStripMenuItem ladoALadoHorizontalToolStripMenuItem;
        private ToolStripMenuItem ladoALadoVerticalToolStripMenuItem;
        private ToolStripMenuItem íconesMinimizadosToolStripMenuItem;
        private ToolStripMenuItem cidadeToolStripMenuItem;
        private ToolStripMenuItem ordemDeServiçoToolStripMenuItem;
    }
}
