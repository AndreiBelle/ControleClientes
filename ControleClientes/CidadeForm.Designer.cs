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
            buttonCancelarCidade = new Button();
            buttonSalvarCidade = new Button();
            buttonExcluirCidade = new Button();
            textBoxUF = new TextBox();
            textBoxCidade = new TextBox();
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
            tabControlCidades.Location = new Point(-1, -29);
            tabControlCidades.Margin = new Padding(3, 4, 3, 4);
            tabControlCidades.Name = "tabControlCidades";
            tabControlCidades.SelectedIndex = 0;
            tabControlCidades.Size = new Size(722, 461);
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
            tabPageConsultaCidades.Size = new Size(714, 428);
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
            btnPesquisarCidade.TabIndex = 1;
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
            txtPesquisaCidade.TabIndex = 0;
            // 
            // panelInferior
            // 
            panelInferior.Controls.Add(btnVisualizarCidade);
            panelInferior.Controls.Add(btnNovaCidade);
            panelInferior.Location = new Point(0, 383);
            panelInferior.Margin = new Padding(3, 4, 3, 4);
            panelInferior.Name = "panelInferior";
            panelInferior.Size = new Size(712, 37);
            panelInferior.TabIndex = 2;
            // 
            // btnVisualizarCidade
            // 
            btnVisualizarCidade.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnVisualizarCidade.Image = Properties.Resources.eye;
            btnVisualizarCidade.ImageAlign = ContentAlignment.MiddleLeft;
            btnVisualizarCidade.Location = new Point(535, 1);
            btnVisualizarCidade.Margin = new Padding(3, 4, 3, 4);
            btnVisualizarCidade.Name = "btnVisualizarCidade";
            btnVisualizarCidade.Size = new Size(105, 32);
            btnVisualizarCidade.TabIndex = 0;
            btnVisualizarCidade.Text = "Visualizar";
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
            btnNovaCidade.TabIndex = 1;
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
            dataGridCidade.Size = new Size(712, 331);
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
            tabPageCadastroCidades.Controls.Add(buttonCancelarCidade);
            tabPageCadastroCidades.Controls.Add(buttonSalvarCidade);
            tabPageCadastroCidades.Controls.Add(buttonExcluirCidade);
            tabPageCadastroCidades.Controls.Add(textBoxUF);
            tabPageCadastroCidades.Controls.Add(textBoxCidade);
            tabPageCadastroCidades.Controls.Add(labelUF);
            tabPageCadastroCidades.Controls.Add(labelCidade);
            tabPageCadastroCidades.Location = new Point(4, 29);
            tabPageCadastroCidades.Margin = new Padding(3, 4, 3, 4);
            tabPageCadastroCidades.Name = "tabPageCadastroCidades";
            tabPageCadastroCidades.Padding = new Padding(3, 4, 3, 4);
            tabPageCadastroCidades.Size = new Size(714, 428);
            tabPageCadastroCidades.TabIndex = 1;
            tabPageCadastroCidades.Text = "tabPage2";
            tabPageCadastroCidades.UseVisualStyleBackColor = true;
            // 
            // buttonCancelarCidade
            // 
            buttonCancelarCidade.Image = Properties.Resources.cross_circle;
            buttonCancelarCidade.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCancelarCidade.Location = new Point(609, 266);
            buttonCancelarCidade.Margin = new Padding(3, 4, 3, 4);
            buttonCancelarCidade.Name = "buttonCancelarCidade";
            buttonCancelarCidade.Size = new Size(96, 31);
            buttonCancelarCidade.TabIndex = 3;
            buttonCancelarCidade.Text = "&Cancelar";
            buttonCancelarCidade.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonCancelarCidade.UseVisualStyleBackColor = true;
            buttonCancelarCidade.Click += btnCancelarCidade_Click;
            // 
            // buttonSalvarCidade
            // 
            buttonSalvarCidade.Image = Properties.Resources.floppy_disk_circle_arrow_right;
            buttonSalvarCidade.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSalvarCidade.Location = new Point(499, 266);
            buttonSalvarCidade.Margin = new Padding(3, 4, 3, 4);
            buttonSalvarCidade.Name = "buttonSalvarCidade";
            buttonSalvarCidade.Size = new Size(103, 31);
            buttonSalvarCidade.TabIndex = 2;
            buttonSalvarCidade.Text = "&Salvar";
            buttonSalvarCidade.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonSalvarCidade.UseVisualStyleBackColor = true;
            buttonSalvarCidade.Click += btnSalvarCidade_Click;
            // 
            // buttonExcluirCidade
            // 
            buttonExcluirCidade.Image = Properties.Resources.trash_xmark__1_;
            buttonExcluirCidade.ImageAlign = ContentAlignment.MiddleLeft;
            buttonExcluirCidade.Location = new Point(15, 266);
            buttonExcluirCidade.Margin = new Padding(3, 4, 3, 4);
            buttonExcluirCidade.Name = "buttonExcluirCidade";
            buttonExcluirCidade.Size = new Size(97, 31);
            buttonExcluirCidade.TabIndex = 4;
            buttonExcluirCidade.Text = "  &Excluir";
            buttonExcluirCidade.UseVisualStyleBackColor = true;
            buttonExcluirCidade.Click += btnExcluirCidade_Click;
            // 
            // textBoxUF
            // 
            textBoxUF.Location = new Point(26, 130);
            textBoxUF.Name = "textBoxUF";
            textBoxUF.Size = new Size(125, 27);
            textBoxUF.TabIndex = 1;
            // 
            // textBoxCidade
            // 
            textBoxCidade.Location = new Point(26, 51);
            textBoxCidade.Name = "textBoxCidade";
            textBoxCidade.Size = new Size(125, 27);
            textBoxCidade.TabIndex = 0;
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
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
        private TextBox textBoxUF;
        private TextBox textBoxCidade;
        private Label labelUF;
        private Label labelCidade;
        private Button buttonCancelarCidade;
        private Button buttonSalvarCidade;
        private Button buttonExcluirCidade;
        private DataGridViewTextBoxColumn Cidade;
        private DataGridViewTextBoxColumn UF;
    }
}