namespace ControleClientes
{
    partial class ClienteForm
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
            tabPageClienteCadastro = new TabPage();
            comboBoxCidade = new ComboBox();
            textBoxUf = new TextBox();
            textBoxBairro = new TextBox();
            textBoxNumero = new TextBox();
            textBoxComplemento = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxLogradouro = new TextBox();
            buttonCep = new Button();
            textCEP = new MaskedTextBox();
            txtCEP = new Label();
            labelEstadoCivil = new Label();
            comboBoxEstadoCivil = new ComboBox();
            labelGenero = new Label();
            comboBoxGenero = new ComboBox();
            buttonCancelar = new Button();
            buttonSalvar = new Button();
            buttonExcluir = new Button();
            textBoxEmail = new TextBox();
            textBoxNome = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tabPageClienteConsulta = new TabPage();
            dataGridClientes = new DataGridView();
            ColID = new DataGridViewTextBoxColumn();
            ColNome = new DataGridViewTextBoxColumn();
            colemail = new DataGridViewTextBoxColumn();
            pnlSuperior = new Panel();
            textBoxPesquisa = new TextBox();
            buttonPesquisar = new Button();
            pnlInferior = new Panel();
            buttonVisualizar = new Button();
            buttonNovo = new Button();
            tabControlCliente = new TabControl();
            tabPageClienteCadastro.SuspendLayout();
            tabPageClienteConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridClientes).BeginInit();
            pnlSuperior.SuspendLayout();
            pnlInferior.SuspendLayout();
            tabControlCliente.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageClienteCadastro
            // 
            tabPageClienteCadastro.Controls.Add(comboBoxCidade);
            tabPageClienteCadastro.Controls.Add(textBoxUf);
            tabPageClienteCadastro.Controls.Add(textBoxBairro);
            tabPageClienteCadastro.Controls.Add(textBoxNumero);
            tabPageClienteCadastro.Controls.Add(textBoxComplemento);
            tabPageClienteCadastro.Controls.Add(label8);
            tabPageClienteCadastro.Controls.Add(label7);
            tabPageClienteCadastro.Controls.Add(label6);
            tabPageClienteCadastro.Controls.Add(label5);
            tabPageClienteCadastro.Controls.Add(label3);
            tabPageClienteCadastro.Controls.Add(label4);
            tabPageClienteCadastro.Controls.Add(textBoxLogradouro);
            tabPageClienteCadastro.Controls.Add(buttonCep);
            tabPageClienteCadastro.Controls.Add(textCEP);
            tabPageClienteCadastro.Controls.Add(txtCEP);
            tabPageClienteCadastro.Controls.Add(labelEstadoCivil);
            tabPageClienteCadastro.Controls.Add(comboBoxEstadoCivil);
            tabPageClienteCadastro.Controls.Add(labelGenero);
            tabPageClienteCadastro.Controls.Add(comboBoxGenero);
            tabPageClienteCadastro.Controls.Add(buttonCancelar);
            tabPageClienteCadastro.Controls.Add(buttonSalvar);
            tabPageClienteCadastro.Controls.Add(buttonExcluir);
            tabPageClienteCadastro.Controls.Add(textBoxEmail);
            tabPageClienteCadastro.Controls.Add(textBoxNome);
            tabPageClienteCadastro.Controls.Add(label1);
            tabPageClienteCadastro.Controls.Add(label2);
            tabPageClienteCadastro.Location = new Point(4, 29);
            tabPageClienteCadastro.Margin = new Padding(3, 4, 3, 4);
            tabPageClienteCadastro.Name = "tabPageClienteCadastro";
            tabPageClienteCadastro.Padding = new Padding(3, 4, 3, 4);
            tabPageClienteCadastro.Size = new Size(702, 395);
            tabPageClienteCadastro.TabIndex = 2;
            tabPageClienteCadastro.Text = "Cadastro";
            tabPageClienteCadastro.UseVisualStyleBackColor = true;
            // 
            // comboBoxCidade
            // 
            comboBoxCidade.FormattingEnabled = true;
            comboBoxCidade.Location = new Point(374, 240);
            comboBoxCidade.Margin = new Padding(3, 4, 3, 4);
            comboBoxCidade.Name = "comboBoxCidade";
            comboBoxCidade.Size = new Size(266, 28);
            comboBoxCidade.TabIndex = 13;
            // 
            // textBoxUf
            // 
            textBoxUf.Location = new Point(647, 239);
            textBoxUf.Margin = new Padding(3, 4, 3, 4);
            textBoxUf.Name = "textBoxUf";
            textBoxUf.Size = new Size(46, 27);
            textBoxUf.TabIndex = 14;
            // 
            // textBoxBairro
            // 
            textBoxBairro.Location = new Point(214, 239);
            textBoxBairro.Margin = new Padding(3, 4, 3, 4);
            textBoxBairro.Name = "textBoxBairro";
            textBoxBairro.Size = new Size(153, 27);
            textBoxBairro.TabIndex = 12;
            // 
            // textBoxNumero
            // 
            textBoxNumero.Location = new Point(583, 176);
            textBoxNumero.Margin = new Padding(3, 4, 3, 4);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(114, 27);
            textBoxNumero.TabIndex = 6;
            // 
            // textBoxComplemento
            // 
            textBoxComplemento.Location = new Point(0, 239);
            textBoxComplemento.Margin = new Padding(3, 4, 3, 4);
            textBoxComplemento.Name = "textBoxComplemento";
            textBoxComplemento.Size = new Size(206, 27);
            textBoxComplemento.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(647, 216);
            label8.Name = "label8";
            label8.Size = new Size(26, 20);
            label8.TabIndex = 35;
            label8.Text = "UF";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(374, 216);
            label7.Name = "label7";
            label7.Size = new Size(56, 20);
            label7.TabIndex = 34;
            label7.Text = "Cidade";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(214, 215);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 33;
            label6.Text = "Bairro";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 215);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 32;
            label5.Text = "Complemento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(583, 151);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 31;
            label3.Text = "Número";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(217, 152);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 30;
            label4.Text = "Logradouro";
            // 
            // textBoxLogradouro
            // 
            textBoxLogradouro.Location = new Point(217, 176);
            textBoxLogradouro.Margin = new Padding(3, 4, 3, 4);
            textBoxLogradouro.Name = "textBoxLogradouro";
            textBoxLogradouro.Size = new Size(358, 27);
            textBoxLogradouro.TabIndex = 11;
            // 
            // buttonCep
            // 
            buttonCep.Location = new Point(125, 175);
            buttonCep.Margin = new Padding(3, 4, 3, 4);
            buttonCep.Name = "buttonCep";
            buttonCep.Size = new Size(86, 31);
            buttonCep.TabIndex = 5;
            buttonCep.Text = "Buscar";
            buttonCep.UseVisualStyleBackColor = true;
            buttonCep.Click += btnCep_Click;
            // 
            // textCEP
            // 
            textCEP.Location = new Point(3, 175);
            textCEP.Margin = new Padding(3, 4, 3, 4);
            textCEP.Mask = "00000-000";
            textCEP.Name = "textCEP";
            textCEP.Size = new Size(114, 27);
            textCEP.TabIndex = 4;
            // 
            // txtCEP
            // 
            txtCEP.AutoSize = true;
            txtCEP.Location = new Point(3, 151);
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(34, 20);
            txtCEP.TabIndex = 18;
            txtCEP.Text = "CEP";
            // 
            // labelEstadoCivil
            // 
            labelEstadoCivil.AutoSize = true;
            labelEstadoCivil.Location = new Point(455, 77);
            labelEstadoCivil.Name = "labelEstadoCivil";
            labelEstadoCivil.Size = new Size(86, 20);
            labelEstadoCivil.TabIndex = 17;
            labelEstadoCivil.Text = "Estado Civil";
            // 
            // comboBoxEstadoCivil
            // 
            comboBoxEstadoCivil.FormattingEnabled = true;
            comboBoxEstadoCivil.Location = new Point(455, 105);
            comboBoxEstadoCivil.Margin = new Padding(3, 4, 3, 4);
            comboBoxEstadoCivil.Name = "comboBoxEstadoCivil";
            comboBoxEstadoCivil.Size = new Size(121, 28);
            comboBoxEstadoCivil.TabIndex = 3;
            // 
            // labelGenero
            // 
            labelGenero.AutoSize = true;
            labelGenero.Location = new Point(455, 9);
            labelGenero.Name = "labelGenero";
            labelGenero.Size = new Size(57, 20);
            labelGenero.TabIndex = 15;
            labelGenero.Text = "Gênero";
            // 
            // comboBoxGenero
            // 
            comboBoxGenero.FormattingEnabled = true;
            comboBoxGenero.Location = new Point(455, 37);
            comboBoxGenero.Margin = new Padding(3, 4, 3, 4);
            comboBoxGenero.Name = "comboBoxGenero";
            comboBoxGenero.Size = new Size(121, 28);
            comboBoxGenero.TabIndex = 1;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Image = Properties.Resources.cross_circle;
            buttonCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCancelar.Location = new Point(600, 316);
            buttonCancelar.Margin = new Padding(3, 4, 3, 4);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(96, 31);
            buttonCancelar.TabIndex = 9;
            buttonCancelar.Text = "&Cancelar";
            buttonCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += btnCancelar_Click;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Image = Properties.Resources.floppy_disk_circle_arrow_right;
            buttonSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSalvar.Location = new Point(490, 316);
            buttonSalvar.Margin = new Padding(3, 4, 3, 4);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(103, 31);
            buttonSalvar.TabIndex = 8;
            buttonSalvar.Text = "&Salvar";
            buttonSalvar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += btnSalvar_Click;
            // 
            // buttonExcluir
            // 
            buttonExcluir.Image = Properties.Resources.trash_xmark__1_;
            buttonExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            buttonExcluir.Location = new Point(6, 316);
            buttonExcluir.Margin = new Padding(3, 4, 3, 4);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(97, 31);
            buttonExcluir.TabIndex = 10;
            buttonExcluir.Text = "  &Excluir";
            buttonExcluir.UseVisualStyleBackColor = true;
            buttonExcluir.Click += btnExcluir_Click;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(3, 105);
            textBoxEmail.Margin = new Padding(3, 4, 3, 4);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(425, 27);
            textBoxEmail.TabIndex = 2;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(3, 37);
            textBoxNome.Margin = new Padding(3, 4, 3, 4);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(427, 27);
            textBoxNome.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 81);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 9;
            label1.Text = "E-mail";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 13);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 7;
            label2.Text = "Nome:";
            // 
            // tabPageClienteConsulta
            // 
            tabPageClienteConsulta.Controls.Add(dataGridClientes);
            tabPageClienteConsulta.Controls.Add(pnlSuperior);
            tabPageClienteConsulta.Controls.Add(pnlInferior);
            tabPageClienteConsulta.Location = new Point(4, 29);
            tabPageClienteConsulta.Margin = new Padding(3, 4, 3, 4);
            tabPageClienteConsulta.Name = "tabPageClienteConsulta";
            tabPageClienteConsulta.Padding = new Padding(3, 4, 3, 4);
            tabPageClienteConsulta.Size = new Size(702, 395);
            tabPageClienteConsulta.TabIndex = 1;
            tabPageClienteConsulta.Text = "Consulta";
            tabPageClienteConsulta.UseVisualStyleBackColor = true;
            // 
            // dataGridClientes
            // 
            dataGridClientes.AllowUserToAddRows = false;
            dataGridClientes.AllowUserToDeleteRows = false;
            dataGridClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridClientes.Columns.AddRange(new DataGridViewColumn[] { ColID, ColNome, colemail });
            dataGridClientes.Dock = DockStyle.Fill;
            dataGridClientes.Location = new Point(3, 35);
            dataGridClientes.Margin = new Padding(3, 4, 3, 4);
            dataGridClientes.Name = "dataGridClientes";
            dataGridClientes.ReadOnly = true;
            dataGridClientes.RowHeadersWidth = 51;
            dataGridClientes.Size = new Size(696, 324);
            dataGridClientes.TabIndex = 0;
            // 
            // ColID
            // 
            ColID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColID.DataPropertyName = "Id";
            ColID.HeaderText = "ID";
            ColID.MinimumWidth = 6;
            ColID.Name = "ColID";
            ColID.ReadOnly = true;
            ColID.Resizable = DataGridViewTriState.True;
            ColID.Width = 53;
            // 
            // ColNome
            // 
            ColNome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColNome.DataPropertyName = "Nome";
            ColNome.HeaderText = "Nome";
            ColNome.MinimumWidth = 6;
            ColNome.Name = "ColNome";
            ColNome.ReadOnly = true;
            // 
            // colemail
            // 
            colemail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colemail.DataPropertyName = "Email";
            colemail.HeaderText = "E-mail";
            colemail.MinimumWidth = 6;
            colemail.Name = "colemail";
            colemail.ReadOnly = true;
            // 
            // pnlSuperior
            // 
            pnlSuperior.Controls.Add(textBoxPesquisa);
            pnlSuperior.Controls.Add(buttonPesquisar);
            pnlSuperior.Dock = DockStyle.Top;
            pnlSuperior.Location = new Point(3, 4);
            pnlSuperior.Margin = new Padding(3, 4, 3, 4);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(696, 31);
            pnlSuperior.TabIndex = 0;
            pnlSuperior.TabStop = true;
            // 
            // textBoxPesquisa
            // 
            textBoxPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxPesquisa.Location = new Point(0, 0);
            textBoxPesquisa.Margin = new Padding(3, 4, 3, 4);
            textBoxPesquisa.Name = "textBoxPesquisa";
            textBoxPesquisa.PlaceholderText = "Pesquisar nomes";
            textBoxPesquisa.Size = new Size(583, 27);
            textBoxPesquisa.TabIndex = 0;
            // 
            // buttonPesquisar
            // 
            buttonPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonPesquisar.ForeColor = SystemColors.ControlText;
            buttonPesquisar.Image = Properties.Resources.search;
            buttonPesquisar.Location = new Point(588, -1);
            buttonPesquisar.Margin = new Padding(3, 4, 3, 4);
            buttonPesquisar.Name = "buttonPesquisar";
            buttonPesquisar.Size = new Size(101, 31);
            buttonPesquisar.TabIndex = 1;
            buttonPesquisar.Text = "&Pesquisar";
            buttonPesquisar.TextAlign = ContentAlignment.MiddleRight;
            buttonPesquisar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonPesquisar.UseVisualStyleBackColor = true;
            buttonPesquisar.Click += btnPesquisar_Click;
            // 
            // pnlInferior
            // 
            pnlInferior.Controls.Add(buttonVisualizar);
            pnlInferior.Controls.Add(buttonNovo);
            pnlInferior.Dock = DockStyle.Bottom;
            pnlInferior.Location = new Point(3, 359);
            pnlInferior.Margin = new Padding(3, 4, 3, 4);
            pnlInferior.Name = "pnlInferior";
            pnlInferior.Size = new Size(696, 32);
            pnlInferior.TabIndex = 0;
            pnlInferior.TabStop = true;
            // 
            // buttonVisualizar
            // 
            buttonVisualizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonVisualizar.Image = Properties.Resources.eye;
            buttonVisualizar.ImageAlign = ContentAlignment.MiddleLeft;
            buttonVisualizar.Location = new Point(525, 0);
            buttonVisualizar.Margin = new Padding(3, 4, 3, 4);
            buttonVisualizar.Name = "buttonVisualizar";
            buttonVisualizar.Size = new Size(102, 32);
            buttonVisualizar.TabIndex = 0;
            buttonVisualizar.Text = "&Visualizar";
            buttonVisualizar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonVisualizar.UseVisualStyleBackColor = true;
            buttonVisualizar.Click += btnVisualizar_Click;
            // 
            // buttonNovo
            // 
            buttonNovo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonNovo.Image = Properties.Resources.add_document;
            buttonNovo.Location = new Point(627, 0);
            buttonNovo.Margin = new Padding(3, 4, 3, 4);
            buttonNovo.Name = "buttonNovo";
            buttonNovo.Size = new Size(69, 32);
            buttonNovo.TabIndex = 1;
            buttonNovo.Text = "&Novo";
            buttonNovo.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonNovo.UseVisualStyleBackColor = true;
            buttonNovo.Click += btnNovo_Click;
            // 
            // tabControlCliente
            // 
            tabControlCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlCliente.Controls.Add(tabPageClienteConsulta);
            tabControlCliente.Controls.Add(tabPageClienteCadastro);
            tabControlCliente.Location = new Point(1, -29);
            tabControlCliente.Margin = new Padding(3, 4, 3, 4);
            tabControlCliente.Name = "tabControlCliente";
            tabControlCliente.SelectedIndex = 0;
            tabControlCliente.Size = new Size(710, 428);
            tabControlCliente.TabIndex = 0;
            // 
            // ClienteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(710, 399);
            Controls.Add(tabControlCliente);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ClienteForm";
            Text = "Controle Clientes";
            tabPageClienteCadastro.ResumeLayout(false);
            tabPageClienteCadastro.PerformLayout();
            tabPageClienteConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridClientes).EndInit();
            pnlSuperior.ResumeLayout(false);
            pnlSuperior.PerformLayout();
            pnlInferior.ResumeLayout(false);
            tabControlCliente.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPageClienteCadastro;
        private Button buttonCancelar;
        private Button buttonSalvar;
        private Button buttonExcluir;
        private TextBox textBoxEmail;
        private TextBox textBoxNome;
        private Label label1;
        private Label label2;
        private TabPage tabPageClienteConsulta;
        private TabControl tabControlCliente;
        private DataGridView dataGridClientes;
        private Button buttonVisualizar;
        private Button buttonPesquisar;
        private Button buttonNovo;
        private TextBox textBoxPesquisa;
        private Panel pnlInferior;
        private Panel pnlSuperior;
        private DataGridViewTextBoxColumn ColID;
        private DataGridViewTextBoxColumn ColNome;
        private DataGridViewTextBoxColumn colemail;
        private ComboBox comboBoxGenero;
        private Label labelGenero;
        private Label labelEstadoCivil;
        private ComboBox comboBoxEstadoCivil;
        private Label txtCEP;
        private MaskedTextBox textCEP;
        private Button buttonCep;
        private TextBox textBoxUf;
        private TextBox textBoxBairro;
        private TextBox textBoxNumero;
        private TextBox textBoxComplemento;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label4;
        private TextBox textBoxLogradouro;
        private ComboBox comboBoxCidade;
    }
}