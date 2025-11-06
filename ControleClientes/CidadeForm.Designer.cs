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
            tabControlCidades = new TabControl();
            tabPageConsultaCidades = new TabPage();
            panelSuperior = new Panel();
            btnPesquisarCidade = new Button();
            txtPesquisaCidade = new TextBox();
            panelInferior = new Panel();
            btnVisualizarCidade = new Button();
            btnNovaCidade = new Button();
            dataGridCidade = new DataGridView();
            Cidade = new DataGridViewTextBoxColumn();
            UF = new DataGridViewTextBoxColumn();
            tabPageCadastroCidades = new TabPage();
            btnCancelarCidade = new Button();
            btnSalvarCidade = new Button();
            btnExcluirCidade = new Button();
            textUF = new TextBox();
            textCidade = new TextBox();
            labelUF = new Label();
            labelCidade = new Label();
            tabControlCidades.SuspendLayout();
            tabPageConsultaCidades.SuspendLayout();
            panelSuperior.SuspendLayout();
            panelInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCidade).BeginInit();
            tabPageCadastroCidades.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlCidades
            // 
            tabControlCidades.Controls.Add(tabPageConsultaCidades);
            tabControlCidades.Controls.Add(tabPageCadastroCidades);
            tabControlCidades.Location = new Point(-1, 0);
            tabControlCidades.Margin = new Padding(3, 4, 3, 4);
            tabControlCidades.Name = "tabControlCidades";
            tabControlCidades.SelectedIndex = 0;
            tabControlCidades.Size = new Size(722, 432);
            tabControlCidades.TabIndex = 3;
            // 
            // tabPageConsultaCidades
            // 
            tabPageConsultaCidades.Controls.Add(panelSuperior);
            tabPageConsultaCidades.Controls.Add(panelInferior);
            tabPageConsultaCidades.Controls.Add(dataGridCidade);
            tabPageConsultaCidades.Location = new Point(4, 29);
            tabPageConsultaCidades.Margin = new Padding(3, 4, 3, 4);
            tabPageConsultaCidades.Name = "tabPageConsultaCidades";
            tabPageConsultaCidades.Padding = new Padding(3, 4, 3, 4);
            tabPageConsultaCidades.Size = new Size(714, 399);
            tabPageConsultaCidades.TabIndex = 0;
            tabPageConsultaCidades.Text = "tabPage1";
            tabPageConsultaCidades.UseVisualStyleBackColor = true;
            // 
            // panelSuperior
            // 
            panelSuperior.Controls.Add(btnPesquisarCidade);
            panelSuperior.Controls.Add(txtPesquisaCidade);
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Margin = new Padding(3, 4, 3, 4);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(712, 36);
            panelSuperior.TabIndex = 0;
            // 
            // btnPesquisarCidade
            // 
            btnPesquisarCidade.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPesquisarCidade.ForeColor = SystemColors.ControlText;
            btnPesquisarCidade.Image = Properties.Resources.search;
            btnPesquisarCidade.Location = new Point(595, 3);
            btnPesquisarCidade.Margin = new Padding(3, 4, 3, 4);
            btnPesquisarCidade.Name = "btnPesquisarCidade";
            btnPesquisarCidade.Size = new Size(101, 31);
            btnPesquisarCidade.TabIndex = 2;
            btnPesquisarCidade.Text = "&Pesquisar";
            btnPesquisarCidade.TextAlign = ContentAlignment.MiddleRight;
            btnPesquisarCidade.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPesquisarCidade.UseVisualStyleBackColor = true;
            btnPesquisarCidade.Click += btnPesquisarCidade_Click;
            // 
            // txtPesquisaCidade
            // 
            txtPesquisaCidade.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPesquisaCidade.Location = new Point(3, 4);
            txtPesquisaCidade.Margin = new Padding(3, 4, 3, 4);
            txtPesquisaCidade.Name = "txtPesquisaCidade";
            txtPesquisaCidade.PlaceholderText = "Pesquisar cidades";
            txtPesquisaCidade.Size = new Size(581, 27);
            txtPesquisaCidade.TabIndex = 1;
            // 
            // panelInferior
            // 
            panelInferior.Controls.Add(btnVisualizarCidade);
            panelInferior.Controls.Add(btnNovaCidade);
            panelInferior.Location = new Point(0, 360);
            panelInferior.Margin = new Padding(3, 4, 3, 4);
            panelInferior.Name = "panelInferior";
            panelInferior.Size = new Size(712, 37);
            panelInferior.TabIndex = 2;
            // 
            // btnVisualizarCidade
            // 
            btnVisualizarCidade.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnVisualizarCidade.Image = Properties.Resources.eye;
            btnVisualizarCidade.Location = new Point(546, 1);
            btnVisualizarCidade.Margin = new Padding(3, 4, 3, 4);
            btnVisualizarCidade.Name = "btnVisualizarCidade";
            btnVisualizarCidade.Size = new Size(94, 32);
            btnVisualizarCidade.TabIndex = 5;
            btnVisualizarCidade.Text = "&Visualizar";
            btnVisualizarCidade.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVisualizarCidade.UseVisualStyleBackColor = true;
            btnVisualizarCidade.Click += btnVisualizarCidade_Click;
            // 
            // btnNovaCidade
            // 
            btnNovaCidade.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNovaCidade.Image = Properties.Resources.add_document;
            btnNovaCidade.Location = new Point(640, 1);
            btnNovaCidade.Margin = new Padding(3, 4, 3, 4);
            btnNovaCidade.Name = "btnNovaCidade";
            btnNovaCidade.Size = new Size(69, 32);
            btnNovaCidade.TabIndex = 4;
            btnNovaCidade.Text = "&Novo";
            btnNovaCidade.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNovaCidade.UseVisualStyleBackColor = true;
            btnNovaCidade.Click += btnNovaCidade_Click;
            // 
            // dataGridCidade
            // 
            dataGridCidade.AllowUserToAddRows = false;
            dataGridCidade.AllowUserToDeleteRows = false;
            dataGridCidade.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridCidade.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCidade.Columns.AddRange(new DataGridViewColumn[] { Cidade, UF });
            dataGridCidade.Location = new Point(0, 43);
            dataGridCidade.Margin = new Padding(3, 4, 3, 4);
            dataGridCidade.Name = "dataGridCidade";
            dataGridCidade.ReadOnly = true;
            dataGridCidade.RowHeadersWidth = 51;
            dataGridCidade.Size = new Size(712, 309);
            dataGridCidade.TabIndex = 1;
            // 
            // Cidade
            // 
            Cidade.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Cidade.HeaderText = "Cidade";
            Cidade.MinimumWidth = 6;
            Cidade.Name = "Cidade";
            Cidade.ReadOnly = true;
            // 
            // UF
            // 
            UF.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            UF.HeaderText = "UF";
            UF.MinimumWidth = 6;
            UF.Name = "UF";
            UF.ReadOnly = true;
            // 
            // tabPageCadastroCidades
            // 
            tabPageCadastroCidades.Controls.Add(btnCancelarCidade);
            tabPageCadastroCidades.Controls.Add(btnSalvarCidade);
            tabPageCadastroCidades.Controls.Add(btnExcluirCidade);
            tabPageCadastroCidades.Controls.Add(textUF);
            tabPageCadastroCidades.Controls.Add(textCidade);
            tabPageCadastroCidades.Controls.Add(labelUF);
            tabPageCadastroCidades.Controls.Add(labelCidade);
            tabPageCadastroCidades.Location = new Point(4, 29);
            tabPageCadastroCidades.Margin = new Padding(3, 4, 3, 4);
            tabPageCadastroCidades.Name = "tabPageCadastroCidades";
            tabPageCadastroCidades.Padding = new Padding(3, 4, 3, 4);
            tabPageCadastroCidades.Size = new Size(714, 399);
            tabPageCadastroCidades.TabIndex = 1;
            tabPageCadastroCidades.Text = "tabPage2";
            tabPageCadastroCidades.UseVisualStyleBackColor = true;
            // 
            // btnCancelarCidade
            // 
            btnCancelarCidade.Image = Properties.Resources.cross_circle;
            btnCancelarCidade.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelarCidade.Location = new Point(609, 266);
            btnCancelarCidade.Margin = new Padding(3, 4, 3, 4);
            btnCancelarCidade.Name = "btnCancelarCidade";
            btnCancelarCidade.Size = new Size(96, 31);
            btnCancelarCidade.TabIndex = 16;
            btnCancelarCidade.Text = "&Cancelar";
            btnCancelarCidade.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelarCidade.UseVisualStyleBackColor = true;
            btnCancelarCidade.Click += btnCancelarCidade_Click;
            // 
            // btnSalvarCidade
            // 
            btnSalvarCidade.Image = Properties.Resources.floppy_disk_circle_arrow_right;
            btnSalvarCidade.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvarCidade.Location = new Point(499, 266);
            btnSalvarCidade.Margin = new Padding(3, 4, 3, 4);
            btnSalvarCidade.Name = "btnSalvarCidade";
            btnSalvarCidade.Size = new Size(103, 31);
            btnSalvarCidade.TabIndex = 15;
            btnSalvarCidade.Text = "&Salvar";
            btnSalvarCidade.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalvarCidade.UseVisualStyleBackColor = true;
            btnSalvarCidade.Click += btnSalvarCidade_Click;
            // 
            // btnExcluirCidade
            // 
            btnExcluirCidade.Image = Properties.Resources.trash_xmark__1_;
            btnExcluirCidade.ImageAlign = ContentAlignment.TopLeft;
            btnExcluirCidade.Location = new Point(15, 266);
            btnExcluirCidade.Margin = new Padding(3, 4, 3, 4);
            btnExcluirCidade.Name = "btnExcluirCidade";
            btnExcluirCidade.Size = new Size(97, 31);
            btnExcluirCidade.TabIndex = 14;
            btnExcluirCidade.Text = "  &Excluir";
            btnExcluirCidade.UseVisualStyleBackColor = true;
            btnExcluirCidade.Click += btnExcluirCidade_Click;
            // 
            // textUF
            // 
            textUF.Location = new Point(26, 130);
            textUF.Name = "textUF";
            textUF.Size = new Size(125, 27);
            textUF.TabIndex = 3;
            // 
            // textCidade
            // 
            textCidade.Location = new Point(26, 51);
            textCidade.Name = "textCidade";
            textCidade.Size = new Size(125, 27);
            textCidade.TabIndex = 2;
            // 
            // labelUF
            // 
            labelUF.AutoSize = true;
            labelUF.Location = new Point(26, 107);
            labelUF.Name = "labelUF";
            labelUF.Size = new Size(26, 20);
            labelUF.TabIndex = 1;
            labelUF.Text = "UF";
            // 
            // labelCidade
            // 
            labelCidade.AutoSize = true;
            labelCidade.Location = new Point(26, 28);
            labelCidade.Name = "labelCidade";
            labelCidade.Size = new Size(56, 20);
            labelCidade.TabIndex = 0;
            labelCidade.Text = "Cidade";
            // 
            // CidadeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 432);
            Controls.Add(tabControlCidades);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CidadeForm";
            Text = "Cadastro Cidade";
            tabControlCidades.ResumeLayout(false);
            tabPageConsultaCidades.ResumeLayout(false);
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            panelInferior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridCidade).EndInit();
            tabPageCadastroCidades.ResumeLayout(false);
            tabPageCadastroCidades.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlCidades;
        private TabPage tabPageConsultaCidades;
        private Panel panelSuperior;
        private Button btnPesquisarCidade;
        private TextBox txtPesquisaCidade;
        private Panel panelInferior;
        private Button btnVisualizarCidade;
        private Button btnNovaCidade;
        private DataGridView dataGridCidade;
        private TabPage tabPageCadastroCidades;
        private TextBox textUF;
        private TextBox textCidade;
        private Label labelUF;
        private Label labelCidade;
        private Button btnCancelarCidade;
        private Button btnSalvarCidade;
        private Button btnExcluirCidade;
        private DataGridViewTextBoxColumn Cidade;
        private DataGridViewTextBoxColumn UF;
    }
}