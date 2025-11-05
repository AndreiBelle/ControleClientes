namespace ControleClientes
{
    partial class CidadeForm
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            txtPesquisaCidade = new TextBox();
            btnPesquisarCidade = new Button();
            panelSuperior = new Panel();
            UF = new DataGridViewTextBoxColumn();
            Cidade = new DataGridViewTextBoxColumn();
            IDCidade = new DataGridViewTextBoxColumn();
            dataGridCidade = new DataGridView();
            btnNovaCidade = new Button();
            btnVisualizarCidade = new Button();
            panelInferior = new Panel();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCidade).BeginInit();
            panelInferior.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(-1, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(632, 324);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panelSuperior);
            tabPage1.Controls.Add(panelInferior);
            tabPage1.Controls.Add(dataGridCidade);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(624, 296);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(624, 296);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtPesquisaCidade
            // 
            txtPesquisaCidade.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPesquisaCidade.Location = new Point(3, 3);
            txtPesquisaCidade.Name = "txtPesquisaCidade";
            txtPesquisaCidade.PlaceholderText = "Pesquisar cidades";
            txtPesquisaCidade.Size = new Size(509, 23);
            txtPesquisaCidade.TabIndex = 1;
            // 
            // btnPesquisarCidade
            // 
            btnPesquisarCidade.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPesquisarCidade.ForeColor = SystemColors.ControlText;
            btnPesquisarCidade.Image = Properties.Resources.search;
            btnPesquisarCidade.Location = new Point(521, 2);
            btnPesquisarCidade.Name = "btnPesquisarCidade";
            btnPesquisarCidade.Size = new Size(88, 23);
            btnPesquisarCidade.TabIndex = 2;
            btnPesquisarCidade.Text = "&Pesquisar";
            btnPesquisarCidade.TextAlign = ContentAlignment.MiddleRight;
            btnPesquisarCidade.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPesquisarCidade.UseVisualStyleBackColor = true;
            // 
            // panelSuperior
            // 
            panelSuperior.Controls.Add(btnPesquisarCidade);
            panelSuperior.Controls.Add(txtPesquisaCidade);
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(623, 27);
            panelSuperior.TabIndex = 0;
            // 
            // UF
            // 
            UF.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            UF.HeaderText = "UF";
            UF.Name = "UF";
            UF.ReadOnly = true;
            // 
            // Cidade
            // 
            Cidade.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Cidade.HeaderText = "Cidade";
            Cidade.Name = "Cidade";
            Cidade.ReadOnly = true;
            // 
            // IDCidade
            // 
            IDCidade.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            IDCidade.HeaderText = "ID";
            IDCidade.Name = "IDCidade";
            IDCidade.ReadOnly = true;
            IDCidade.Width = 43;
            // 
            // dataGridCidade
            // 
            dataGridCidade.AllowUserToAddRows = false;
            dataGridCidade.AllowUserToDeleteRows = false;
            dataGridCidade.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCidade.Columns.AddRange(new DataGridViewColumn[] { IDCidade, Cidade, UF });
            dataGridCidade.Location = new Point(0, 32);
            dataGridCidade.Name = "dataGridCidade";
            dataGridCidade.ReadOnly = true;
            dataGridCidade.Size = new Size(623, 232);
            dataGridCidade.TabIndex = 1;
            // 
            // btnNovaCidade
            // 
            btnNovaCidade.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNovaCidade.Image = Properties.Resources.add_document;
            btnNovaCidade.Location = new Point(560, 1);
            btnNovaCidade.Name = "btnNovaCidade";
            btnNovaCidade.Size = new Size(60, 24);
            btnNovaCidade.TabIndex = 4;
            btnNovaCidade.Text = "&Novo";
            btnNovaCidade.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNovaCidade.UseVisualStyleBackColor = true;
            // 
            // btnVisualizarCidade
            // 
            btnVisualizarCidade.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnVisualizarCidade.Image = Properties.Resources.eye;
            btnVisualizarCidade.Location = new Point(478, 1);
            btnVisualizarCidade.Name = "btnVisualizarCidade";
            btnVisualizarCidade.Size = new Size(82, 24);
            btnVisualizarCidade.TabIndex = 5;
            btnVisualizarCidade.Text = "&Visualizar";
            btnVisualizarCidade.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVisualizarCidade.UseVisualStyleBackColor = true;
            // 
            // panelInferior
            // 
            panelInferior.Controls.Add(btnVisualizarCidade);
            panelInferior.Controls.Add(btnNovaCidade);
            panelInferior.Location = new Point(0, 270);
            panelInferior.Name = "panelInferior";
            panelInferior.Size = new Size(623, 28);
            panelInferior.TabIndex = 2;
            // 
            // CidadeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 324);
            Controls.Add(tabControl1);
            Name = "CidadeForm";
            Text = "Cadastro Cidade";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCidade).EndInit();
            panelInferior.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Panel panelSuperior;
        private Button btnPesquisarCidade;
        private TextBox txtPesquisaCidade;
        private Panel panelInferior;
        private Button btnVisualizarCidade;
        private Button btnNovaCidade;
        private DataGridView dataGridCidade;
        private DataGridViewTextBoxColumn IDCidade;
        private DataGridViewTextBoxColumn Cidade;
        private DataGridViewTextBoxColumn UF;
        private TabPage tabPage2;
    }
}