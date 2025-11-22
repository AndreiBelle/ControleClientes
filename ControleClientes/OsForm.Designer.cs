namespace ControleClientes
{
    partial class OsForm
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
            tabPageCadastroOS = new TabPage();
            labelServico = new Label();
            buttonRemoverServico = new Button();
            comboBoxStatus = new ComboBox();
            labelStatus = new Label();
            buttonAdicionarServico = new Button();
            dataGridCadastro = new DataGridView();
            textBoxCEP = new TextBox();
            textBoxValorTotal = new TextBox();
            textBoxQuantidade = new TextBox();
            textBoxValorCadastro = new TextBox();
            textBoxDescricao = new TextBox();
            textBoxCidade = new TextBox();
            textBoxNumero = new TextBox();
            textBoxUf = new TextBox();
            textBoxBairro = new TextBox();
            textBoxComplemento = new TextBox();
            textBoxLogradouro = new TextBox();
            labelCEP = new Label();
            labelTotal = new Label();
            labelQuantidade = new Label();
            labelValorTipo = new Label();
            comboBoxTipoOs = new ComboBox();
            labelTipoDeOrdem = new Label();
            labelDescricao = new Label();
            labelOs = new Label();
            labelUF = new Label();
            labelCidade = new Label();
            labelBairro = new Label();
            labelComplemento = new Label();
            labelNumero = new Label();
            labelLogradouro = new Label();
            labelEndereco = new Label();
            comboBoxCliente = new ComboBox();
            labelCliente = new Label();
            buttonCancelar = new Button();
            buttonSalvar = new Button();
            buttonExcluir = new Button();
            OS = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
            tabControlOS = new TabControl();
            tabPageConsultaOS = new TabPage();
            panelSuperior = new Panel();
            buttonPesquisar = new Button();
            textBoxPesquisarOs = new TextBox();
            panelInferior = new Panel();
            buttonTipo = new Button();
            buttonVizualizar = new Button();
            buttonNovo = new Button();
            dataGridOS = new DataGridView();
            ColumnId = new DataGridViewTextBoxColumn();
            ColunaNome = new DataGridViewTextBoxColumn();
            ColumnStatus = new DataGridViewTextBoxColumn();
            descricao = new DataGridViewTextBoxColumn();
            valorSomado = new DataGridViewTextBoxColumn();
            tabPageCadastroOS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCadastro).BeginInit();
            tabControlOS.SuspendLayout();
            tabPageConsultaOS.SuspendLayout();
            panelSuperior.SuspendLayout();
            panelInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridOS).BeginInit();
            SuspendLayout();
            // 
            // tabPageCadastroOS
            // 
            tabPageCadastroOS.Controls.Add(labelServico);
            tabPageCadastroOS.Controls.Add(buttonRemoverServico);
            tabPageCadastroOS.Controls.Add(comboBoxStatus);
            tabPageCadastroOS.Controls.Add(labelStatus);
            tabPageCadastroOS.Controls.Add(buttonAdicionarServico);
            tabPageCadastroOS.Controls.Add(dataGridCadastro);
            tabPageCadastroOS.Controls.Add(textBoxCEP);
            tabPageCadastroOS.Controls.Add(textBoxValorTotal);
            tabPageCadastroOS.Controls.Add(textBoxQuantidade);
            tabPageCadastroOS.Controls.Add(textBoxValorCadastro);
            tabPageCadastroOS.Controls.Add(textBoxDescricao);
            tabPageCadastroOS.Controls.Add(textBoxCidade);
            tabPageCadastroOS.Controls.Add(textBoxNumero);
            tabPageCadastroOS.Controls.Add(textBoxUf);
            tabPageCadastroOS.Controls.Add(textBoxBairro);
            tabPageCadastroOS.Controls.Add(textBoxComplemento);
            tabPageCadastroOS.Controls.Add(textBoxLogradouro);
            tabPageCadastroOS.Controls.Add(labelCEP);
            tabPageCadastroOS.Controls.Add(labelTotal);
            tabPageCadastroOS.Controls.Add(labelQuantidade);
            tabPageCadastroOS.Controls.Add(labelValorTipo);
            tabPageCadastroOS.Controls.Add(comboBoxTipoOs);
            tabPageCadastroOS.Controls.Add(labelTipoDeOrdem);
            tabPageCadastroOS.Controls.Add(labelDescricao);
            tabPageCadastroOS.Controls.Add(labelOs);
            tabPageCadastroOS.Controls.Add(labelUF);
            tabPageCadastroOS.Controls.Add(labelCidade);
            tabPageCadastroOS.Controls.Add(labelBairro);
            tabPageCadastroOS.Controls.Add(labelComplemento);
            tabPageCadastroOS.Controls.Add(labelNumero);
            tabPageCadastroOS.Controls.Add(labelLogradouro);
            tabPageCadastroOS.Controls.Add(labelEndereco);
            tabPageCadastroOS.Controls.Add(comboBoxCliente);
            tabPageCadastroOS.Controls.Add(labelCliente);
            tabPageCadastroOS.Controls.Add(buttonCancelar);
            tabPageCadastroOS.Controls.Add(buttonSalvar);
            tabPageCadastroOS.Controls.Add(buttonExcluir);
            tabPageCadastroOS.Location = new Point(4, 29);
            tabPageCadastroOS.Margin = new Padding(3, 4, 3, 4);
            tabPageCadastroOS.Name = "tabPageCadastroOS";
            tabPageCadastroOS.Padding = new Padding(3, 4, 3, 4);
            tabPageCadastroOS.Size = new Size(873, 758);
            tabPageCadastroOS.TabIndex = 1;
            tabPageCadastroOS.Text = "tabPage2";
            tabPageCadastroOS.UseVisualStyleBackColor = true;
            // 
            // labelServico
            // 
            labelServico.AutoSize = true;
            labelServico.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelServico.Location = new Point(15, 410);
            labelServico.Name = "labelServico";
            labelServico.Size = new Size(83, 27);
            labelServico.TabIndex = 72;
            labelServico.Text = "Serviço";
            // 
            // buttonRemoverServico
            // 
            buttonRemoverServico.Image = Properties.Resources.cross_circle;
            buttonRemoverServico.ImageAlign = ContentAlignment.MiddleLeft;
            buttonRemoverServico.Location = new Point(118, 527);
            buttonRemoverServico.Name = "buttonRemoverServico";
            buttonRemoverServico.Size = new Size(145, 31);
            buttonRemoverServico.TabIndex = 71;
            buttonRemoverServico.Text = "Remover Serviço";
            buttonRemoverServico.TextAlign = ContentAlignment.MiddleRight;
            buttonRemoverServico.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonRemoverServico.UseVisualStyleBackColor = true;
            buttonRemoverServico.Click += buttonRemoverServico_Click;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(381, 347);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(215, 28);
            comboBoxStatus.TabIndex = 70;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(381, 323);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(49, 20);
            labelStatus.TabIndex = 69;
            labelStatus.Text = "Status";
            // 
            // buttonAdicionarServico
            // 
            buttonAdicionarServico.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAdicionarServico.Location = new Point(552, 477);
            buttonAdicionarServico.Margin = new Padding(3, 4, 3, 4);
            buttonAdicionarServico.Name = "buttonAdicionarServico";
            buttonAdicionarServico.Size = new Size(172, 31);
            buttonAdicionarServico.TabIndex = 68;
            buttonAdicionarServico.Text = "Adicionar Serviço";
            buttonAdicionarServico.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAdicionarServico.UseVisualStyleBackColor = true;
            buttonAdicionarServico.Click += buttonAdicionarServico_Click;
            // 
            // dataGridCadastro
            // 
            dataGridCadastro.AllowUserToAddRows = false;
            dataGridCadastro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCadastro.Location = new Point(0, 562);
            dataGridCadastro.Name = "dataGridCadastro";
            dataGridCadastro.RowHeadersWidth = 51;
            dataGridCadastro.Size = new Size(873, 196);
            dataGridCadastro.TabIndex = 5;
            dataGridCadastro.CellDoubleClick += dataGridCadastro_CellDoubleClick;
            // 
            // textBoxCEP
            // 
            textBoxCEP.Location = new Point(381, 222);
            textBoxCEP.Name = "textBoxCEP";
            textBoxCEP.Size = new Size(125, 27);
            textBoxCEP.TabIndex = 67;
            // 
            // textBoxValorTotal
            // 
            textBoxValorTotal.Location = new Point(407, 479);
            textBoxValorTotal.Name = "textBoxValorTotal";
            textBoxValorTotal.Size = new Size(125, 27);
            textBoxValorTotal.TabIndex = 65;
            textBoxValorTotal.TextChanged += textBoxValorTotal_TextChanged;
            // 
            // textBoxQuantidade
            // 
            textBoxQuantidade.Location = new Point(312, 479);
            textBoxQuantidade.Name = "textBoxQuantidade";
            textBoxQuantidade.Size = new Size(89, 27);
            textBoxQuantidade.TabIndex = 63;
            textBoxQuantidade.TextChanged += textBoxQuantidade_TextChanged;
            // 
            // textBoxValorCadastro
            // 
            textBoxValorCadastro.Location = new Point(181, 479);
            textBoxValorCadastro.Name = "textBoxValorCadastro";
            textBoxValorCadastro.Size = new Size(125, 27);
            textBoxValorCadastro.TabIndex = 61;
            textBoxValorCadastro.TextChanged += textBoxValorCadastro_TextChanged;
            // 
            // textBoxDescricao
            // 
            textBoxDescricao.Location = new Point(18, 347);
            textBoxDescricao.Multiline = true;
            textBoxDescricao.Name = "textBoxDescricao";
            textBoxDescricao.Size = new Size(355, 27);
            textBoxDescricao.TabIndex = 57;
            // 
            // textBoxCidade
            // 
            textBoxCidade.Location = new Point(178, 222);
            textBoxCidade.Name = "textBoxCidade";
            textBoxCidade.Size = new Size(195, 27);
            textBoxCidade.TabIndex = 55;
            // 
            // textBoxNumero
            // 
            textBoxNumero.Location = new Point(381, 162);
            textBoxNumero.Margin = new Padding(3, 4, 3, 4);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(114, 27);
            textBoxNumero.TabIndex = 53;
            // 
            // textBoxUf
            // 
            textBoxUf.Location = new Point(654, 162);
            textBoxUf.Margin = new Padding(3, 4, 3, 4);
            textBoxUf.Name = "textBoxUf";
            textBoxUf.Size = new Size(46, 27);
            textBoxUf.TabIndex = 51;
            // 
            // textBoxBairro
            // 
            textBoxBairro.Location = new Point(18, 222);
            textBoxBairro.Margin = new Padding(3, 4, 3, 4);
            textBoxBairro.Name = "textBoxBairro";
            textBoxBairro.Size = new Size(153, 27);
            textBoxBairro.TabIndex = 50;
            // 
            // textBoxComplemento
            // 
            textBoxComplemento.Location = new Point(506, 162);
            textBoxComplemento.Margin = new Padding(3, 4, 3, 4);
            textBoxComplemento.Name = "textBoxComplemento";
            textBoxComplemento.Size = new Size(142, 27);
            textBoxComplemento.TabIndex = 49;
            // 
            // textBoxLogradouro
            // 
            textBoxLogradouro.Location = new Point(15, 162);
            textBoxLogradouro.Margin = new Padding(3, 4, 3, 4);
            textBoxLogradouro.Name = "textBoxLogradouro";
            textBoxLogradouro.Size = new Size(358, 27);
            textBoxLogradouro.TabIndex = 42;
            // 
            // labelCEP
            // 
            labelCEP.AutoSize = true;
            labelCEP.Location = new Point(381, 199);
            labelCEP.Name = "labelCEP";
            labelCEP.Size = new Size(34, 20);
            labelCEP.TabIndex = 66;
            labelCEP.Text = "CEP";
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(407, 456);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(80, 20);
            labelTotal.TabIndex = 64;
            labelTotal.Text = "Valor Total";
            // 
            // labelQuantidade
            // 
            labelQuantidade.AutoSize = true;
            labelQuantidade.Location = new Point(312, 455);
            labelQuantidade.Name = "labelQuantidade";
            labelQuantidade.Size = new Size(87, 20);
            labelQuantidade.TabIndex = 62;
            labelQuantidade.Text = "Quantidade";
            // 
            // labelValorTipo
            // 
            labelValorTipo.AutoSize = true;
            labelValorTipo.Location = new Point(181, 455);
            labelValorTipo.Name = "labelValorTipo";
            labelValorTipo.Size = new Size(43, 20);
            labelValorTipo.TabIndex = 60;
            labelValorTipo.Text = "Valor";
            // 
            // comboBoxTipoOs
            // 
            comboBoxTipoOs.FormattingEnabled = true;
            comboBoxTipoOs.Location = new Point(15, 478);
            comboBoxTipoOs.Name = "comboBoxTipoOs";
            comboBoxTipoOs.Size = new Size(151, 28);
            comboBoxTipoOs.TabIndex = 59;
            comboBoxTipoOs.SelectedIndexChanged += comboBoxTipoOs_SelectedIndexChanged;
            // 
            // labelTipoDeOrdem
            // 
            labelTipoDeOrdem.AutoSize = true;
            labelTipoDeOrdem.Location = new Point(17, 455);
            labelTipoDeOrdem.Name = "labelTipoDeOrdem";
            labelTipoDeOrdem.Size = new Size(112, 20);
            labelTipoDeOrdem.TabIndex = 58;
            labelTipoDeOrdem.Text = "Tipo de Serviço";
            // 
            // labelDescricao
            // 
            labelDescricao.AutoSize = true;
            labelDescricao.Location = new Point(15, 324);
            labelDescricao.Name = "labelDescricao";
            labelDescricao.Size = new Size(74, 20);
            labelDescricao.TabIndex = 56;
            labelDescricao.Text = "Descrição";
            // 
            // labelOs
            // 
            labelOs.AutoSize = true;
            labelOs.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelOs.Location = new Point(15, 285);
            labelOs.Name = "labelOs";
            labelOs.Size = new Size(185, 27);
            labelOs.TabIndex = 54;
            labelOs.Text = "Ordem de Serviço";
            // 
            // labelUF
            // 
            labelUF.AutoSize = true;
            labelUF.Location = new Point(654, 139);
            labelUF.Name = "labelUF";
            labelUF.Size = new Size(26, 20);
            labelUF.TabIndex = 48;
            labelUF.Text = "UF";
            // 
            // labelCidade
            // 
            labelCidade.AutoSize = true;
            labelCidade.Location = new Point(178, 199);
            labelCidade.Name = "labelCidade";
            labelCidade.Size = new Size(56, 20);
            labelCidade.TabIndex = 47;
            labelCidade.Text = "Cidade";
            // 
            // labelBairro
            // 
            labelBairro.AutoSize = true;
            labelBairro.Location = new Point(18, 198);
            labelBairro.Name = "labelBairro";
            labelBairro.Size = new Size(49, 20);
            labelBairro.TabIndex = 46;
            labelBairro.Text = "Bairro";
            // 
            // labelComplemento
            // 
            labelComplemento.AutoSize = true;
            labelComplemento.Location = new Point(506, 137);
            labelComplemento.Name = "labelComplemento";
            labelComplemento.Size = new Size(104, 20);
            labelComplemento.TabIndex = 45;
            labelComplemento.Text = "Complemento";
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.Location = new Point(381, 137);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(63, 20);
            labelNumero.TabIndex = 44;
            labelNumero.Text = "Número";
            // 
            // labelLogradouro
            // 
            labelLogradouro.AutoSize = true;
            labelLogradouro.Location = new Point(15, 138);
            labelLogradouro.Name = "labelLogradouro";
            labelLogradouro.Size = new Size(87, 20);
            labelLogradouro.TabIndex = 43;
            labelLogradouro.Text = "Logradouro";
            // 
            // labelEndereco
            // 
            labelEndereco.AutoSize = true;
            labelEndereco.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEndereco.Location = new Point(15, 99);
            labelEndereco.Name = "labelEndereco";
            labelEndereco.Size = new Size(101, 27);
            labelEndereco.TabIndex = 19;
            labelEndereco.Text = "Endereço";
            // 
            // comboBoxCliente
            // 
            comboBoxCliente.FormattingEnabled = true;
            comboBoxCliente.Location = new Point(18, 48);
            comboBoxCliente.Name = "comboBoxCliente";
            comboBoxCliente.Size = new Size(182, 28);
            comboBoxCliente.TabIndex = 18;
            comboBoxCliente.SelectedIndexChanged += comboBoxCliente_SelectedIndexChanged;
            // 
            // labelCliente
            // 
            labelCliente.AutoSize = true;
            labelCliente.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCliente.Location = new Point(15, 18);
            labelCliente.Name = "labelCliente";
            labelCliente.Size = new Size(79, 27);
            labelCliente.TabIndex = 17;
            labelCliente.Text = "Cliente";
            // 
            // buttonCancelar
            // 
            buttonCancelar.Image = Properties.Resources.cross_circle;
            buttonCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCancelar.Location = new Point(759, 524);
            buttonCancelar.Margin = new Padding(3, 4, 3, 4);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(96, 31);
            buttonCancelar.TabIndex = 16;
            buttonCancelar.Text = "&Cancelar";
            buttonCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Image = Properties.Resources.floppy_disk_circle_arrow_right;
            buttonSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSalvar.Location = new Point(650, 524);
            buttonSalvar.Margin = new Padding(3, 4, 3, 4);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(103, 31);
            buttonSalvar.TabIndex = 15;
            buttonSalvar.Text = "&Salvar";
            buttonSalvar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // buttonExcluir
            // 
            buttonExcluir.Image = Properties.Resources.trash_xmark__1_;
            buttonExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            buttonExcluir.Location = new Point(15, 527);
            buttonExcluir.Margin = new Padding(3, 4, 3, 4);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(97, 31);
            buttonExcluir.TabIndex = 14;
            buttonExcluir.Text = "  &Excluir";
            buttonExcluir.UseVisualStyleBackColor = true;
            buttonExcluir.Click += buttonExcluir_Click;
            // 
            // OS
            // 
            OS.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            OS.HeaderText = "Id";
            OS.MinimumWidth = 6;
            OS.Name = "OS";
            OS.ReadOnly = true;
            // 
            // Cliente
            // 
            Cliente.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Cliente.HeaderText = "Cliente";
            Cliente.MinimumWidth = 6;
            Cliente.Name = "Cliente";
            Cliente.ReadOnly = true;
            // 
            // tabControlOS
            // 
            tabControlOS.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlOS.Controls.Add(tabPageConsultaOS);
            tabControlOS.Controls.Add(tabPageCadastroOS);
            tabControlOS.Location = new Point(-4, -31);
            tabControlOS.Margin = new Padding(3, 4, 3, 4);
            tabControlOS.Name = "tabControlOS";
            tabControlOS.SelectedIndex = 0;
            tabControlOS.Size = new Size(881, 791);
            tabControlOS.TabIndex = 4;
            // 
            // tabPageConsultaOS
            // 
            tabPageConsultaOS.Controls.Add(panelSuperior);
            tabPageConsultaOS.Controls.Add(panelInferior);
            tabPageConsultaOS.Controls.Add(dataGridOS);
            tabPageConsultaOS.Location = new Point(4, 29);
            tabPageConsultaOS.Margin = new Padding(3, 4, 3, 4);
            tabPageConsultaOS.Name = "tabPageConsultaOS";
            tabPageConsultaOS.Padding = new Padding(3, 4, 3, 4);
            tabPageConsultaOS.Size = new Size(865, 758);
            tabPageConsultaOS.TabIndex = 0;
            tabPageConsultaOS.Text = "tabPage1";
            tabPageConsultaOS.UseVisualStyleBackColor = true;
            // 
            // panelSuperior
            // 
            panelSuperior.Controls.Add(buttonPesquisar);
            panelSuperior.Controls.Add(textBoxPesquisarOs);
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Margin = new Padding(3, 4, 3, 4);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(864, 36);
            panelSuperior.TabIndex = 0;
            // 
            // buttonPesquisar
            // 
            buttonPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonPesquisar.ForeColor = SystemColors.ControlText;
            buttonPesquisar.Image = Properties.Resources.search;
            buttonPesquisar.Location = new Point(748, 2);
            buttonPesquisar.Margin = new Padding(3, 4, 3, 4);
            buttonPesquisar.Name = "buttonPesquisar";
            buttonPesquisar.Size = new Size(101, 31);
            buttonPesquisar.TabIndex = 5;
            buttonPesquisar.Text = "&Pesquisar";
            buttonPesquisar.TextAlign = ContentAlignment.MiddleRight;
            buttonPesquisar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonPesquisar.UseVisualStyleBackColor = true;
            buttonPesquisar.Click += buttonPesquisar_Click;
            // 
            // textBoxPesquisarOs
            // 
            textBoxPesquisarOs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxPesquisarOs.Location = new Point(6, 4);
            textBoxPesquisarOs.Margin = new Padding(3, 4, 3, 4);
            textBoxPesquisarOs.Name = "textBoxPesquisarOs";
            textBoxPesquisarOs.PlaceholderText = "Pesquisar OS";
            textBoxPesquisarOs.Size = new Size(736, 27);
            textBoxPesquisarOs.TabIndex = 1;
            // 
            // panelInferior
            // 
            panelInferior.Controls.Add(buttonTipo);
            panelInferior.Controls.Add(buttonVizualizar);
            panelInferior.Controls.Add(buttonNovo);
            panelInferior.Location = new Point(0, 471);
            panelInferior.Margin = new Padding(3, 4, 3, 4);
            panelInferior.Name = "panelInferior";
            panelInferior.Size = new Size(864, 37);
            panelInferior.TabIndex = 2;
            // 
            // buttonTipo
            // 
            buttonTipo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonTipo.Image = Properties.Resources.add_document;
            buttonTipo.Location = new Point(692, 3);
            buttonTipo.Name = "buttonTipo";
            buttonTipo.Size = new Size(169, 29);
            buttonTipo.TabIndex = 8;
            buttonTipo.Text = "Novo Tipo de OS";
            buttonTipo.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonTipo.UseVisualStyleBackColor = true;
            buttonTipo.Click += buttonTipo_Click;
            // 
            // buttonVizualizar
            // 
            buttonVizualizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonVizualizar.Image = Properties.Resources.eye;
            buttonVizualizar.Location = new Point(513, 5);
            buttonVizualizar.Margin = new Padding(3, 4, 3, 4);
            buttonVizualizar.Name = "buttonVizualizar";
            buttonVizualizar.Size = new Size(98, 31);
            buttonVizualizar.TabIndex = 7;
            buttonVizualizar.Text = "&Visualizar";
            buttonVizualizar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonVizualizar.UseVisualStyleBackColor = true;
            buttonVizualizar.Click += buttonVizualizar_Click;
            // 
            // buttonNovo
            // 
            buttonNovo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonNovo.Image = Properties.Resources.add_document;
            buttonNovo.Location = new Point(617, 3);
            buttonNovo.Margin = new Padding(3, 4, 3, 4);
            buttonNovo.Name = "buttonNovo";
            buttonNovo.Size = new Size(69, 32);
            buttonNovo.TabIndex = 6;
            buttonNovo.Text = "&Novo";
            buttonNovo.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonNovo.UseVisualStyleBackColor = true;
            buttonNovo.Click += buttonNovo_Click;
            // 
            // dataGridOS
            // 
            dataGridOS.AllowUserToAddRows = false;
            dataGridOS.AllowUserToOrderColumns = true;
            dataGridOS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridOS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridOS.Columns.AddRange(new DataGridViewColumn[] { ColumnId, ColunaNome, ColumnStatus, descricao, valorSomado });
            dataGridOS.Location = new Point(0, 43);
            dataGridOS.Margin = new Padding(3, 4, 3, 4);
            dataGridOS.Name = "dataGridOS";
            dataGridOS.ReadOnly = true;
            dataGridOS.RowHeadersWidth = 51;
            dataGridOS.Size = new Size(864, 420);
            dataGridOS.TabIndex = 1;
            // 
            // ColumnId
            // 
            ColumnId.DataPropertyName = "iD";
            ColumnId.FillWeight = 53.47593F;
            ColumnId.HeaderText = "ID";
            ColumnId.MinimumWidth = 6;
            ColumnId.Name = "ColumnId";
            ColumnId.ReadOnly = true;
            // 
            // ColunaNome
            // 
            ColunaNome.DataPropertyName = "ColunaNome";
            ColunaNome.FillWeight = 111.63102F;
            ColunaNome.HeaderText = "Cliente";
            ColunaNome.MinimumWidth = 6;
            ColunaNome.Name = "ColunaNome";
            ColunaNome.ReadOnly = true;
            // 
            // ColumnStatus
            // 
            ColumnStatus.DataPropertyName = "StatusNome";
            ColumnStatus.FillWeight = 111.63102F;
            ColumnStatus.HeaderText = "Status";
            ColumnStatus.MinimumWidth = 6;
            ColumnStatus.Name = "ColumnStatus";
            ColumnStatus.ReadOnly = true;
            // 
            // descricao
            // 
            descricao.DataPropertyName = "Descricao";
            descricao.FillWeight = 111.63102F;
            descricao.HeaderText = "Descrição";
            descricao.MinimumWidth = 6;
            descricao.Name = "descricao";
            descricao.ReadOnly = true;
            // 
            // valorSomado
            // 
            valorSomado.DataPropertyName = "ValorTotalGeral";
            valorSomado.FillWeight = 111.63102F;
            valorSomado.HeaderText = "Valor";
            valorSomado.MinimumWidth = 6;
            valorSomado.Name = "valorSomado";
            valorSomado.ReadOnly = true;
            // 
            // OsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 756);
            Controls.Add(tabControlOS);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "OsForm";
            Text = "Cadastro de Ordem de Serviço";
            tabPageCadastroOS.ResumeLayout(false);
            tabPageCadastroOS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCadastro).EndInit();
            tabControlOS.ResumeLayout(false);
            tabPageConsultaOS.ResumeLayout(false);
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            panelInferior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridOS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPageCadastroOS;
        private TabControl tabControlOS;
        private DataGridViewTextBoxColumn OS;
        private DataGridViewTextBoxColumn Cliente;
        private Button buttonAdicionarServico;
        private DataGridView dataGridCadastro;
        private TextBox textBoxCEP;
        private TextBox textBoxValorTotal;
        private TextBox textBoxQuantidade;
        private TextBox textBoxValorCadastro;
        private TextBox textBoxDescricao;
        private TextBox textBoxCidade;
        private TextBox textBoxNumero;
        private TextBox textBoxUf;
        private TextBox textBoxBairro;
        private TextBox textBoxComplemento;
        private TextBox textBoxLogradouro;
        private Label labelCEP;
        private Label labelTotal;
        private Label labelQuantidade;
        private Label labelValorTipo;
        private ComboBox comboBoxTipoOs;
        private Label labelTipoDeOrdem;
        private Label labelDescricao;
        private Label labelOs;
        private Label labelUF;
        private Label labelCidade;
        private Label labelBairro;
        private Label labelComplemento;
        private Label labelNumero;
        private Label labelLogradouro;
        private Label labelEndereco;
        private ComboBox comboBoxCliente;
        private Label labelCliente;
        private Button buttonCancelar;
        private Button buttonSalvar;
        private Button buttonExcluir;
        private TabPage tabPageConsultaOS;
        private Panel panelSuperior;
        private Button buttonPesquisar;
        private TextBox textBoxPesquisarOs;
        private Panel panelInferior;
        private Button buttonTipo;
        private Button buttonVizualizar;
        private Button buttonNovo;
        private DataGridView dataGridOS;
        private ComboBox comboBoxStatus;
        private Label labelStatus;
        private Button buttonRemoverServico;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColunaNome;
        private DataGridViewTextBoxColumn ColumnStatus;
        private DataGridViewTextBoxColumn descricao;
        private DataGridViewTextBoxColumn valorSomado;
        private Label labelServico;
    }
}