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
            tpClienteCadastro = new TabPage();
            cmbCidade = new ComboBox();
            txtUf = new TextBox();
            txtBairro = new TextBox();
            txtNumero = new TextBox();
            txtComplemento = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtLogradouro = new TextBox();
            btnCep = new Button();
            textCEP = new MaskedTextBox();
            txtCEP = new Label();
            labelEstadoCivil = new Label();
            cmbEstadoCivil = new ComboBox();
            labelGenero = new Label();
            cmbGenero = new ComboBox();
            btnCancelar = new Button();
            btnSalvar = new Button();
            btnExcluir = new Button();
            txtEmail = new TextBox();
            txtNome = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tpClienteConsulta = new TabPage();
            gridClientes = new DataGridView();
            ColID = new DataGridViewTextBoxColumn();
            ColNome = new DataGridViewTextBoxColumn();
            colemail = new DataGridViewTextBoxColumn();
            pnlSuperior = new Panel();
            txtPesquisa = new TextBox();
            btnPesquisar = new Button();
            pnlInferior = new Panel();
            btnVisualizar = new Button();
            btnNovo = new Button();
            tcCliente = new TabControl();
            tpClienteCadastro.SuspendLayout();
            tpClienteConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridClientes).BeginInit();
            pnlSuperior.SuspendLayout();
            pnlInferior.SuspendLayout();
            tcCliente.SuspendLayout();
            SuspendLayout();
            // 
            // tpClienteCadastro
            // 
            tpClienteCadastro.Controls.Add(cmbCidade);
            tpClienteCadastro.Controls.Add(txtUf);
            tpClienteCadastro.Controls.Add(txtBairro);
            tpClienteCadastro.Controls.Add(txtNumero);
            tpClienteCadastro.Controls.Add(txtComplemento);
            tpClienteCadastro.Controls.Add(label8);
            tpClienteCadastro.Controls.Add(label7);
            tpClienteCadastro.Controls.Add(label6);
            tpClienteCadastro.Controls.Add(label5);
            tpClienteCadastro.Controls.Add(label3);
            tpClienteCadastro.Controls.Add(label4);
            tpClienteCadastro.Controls.Add(txtLogradouro);
            tpClienteCadastro.Controls.Add(btnCep);
            tpClienteCadastro.Controls.Add(textCEP);
            tpClienteCadastro.Controls.Add(txtCEP);
            tpClienteCadastro.Controls.Add(labelEstadoCivil);
            tpClienteCadastro.Controls.Add(cmbEstadoCivil);
            tpClienteCadastro.Controls.Add(labelGenero);
            tpClienteCadastro.Controls.Add(cmbGenero);
            tpClienteCadastro.Controls.Add(btnCancelar);
            tpClienteCadastro.Controls.Add(btnSalvar);
            tpClienteCadastro.Controls.Add(btnExcluir);
            tpClienteCadastro.Controls.Add(txtEmail);
            tpClienteCadastro.Controls.Add(txtNome);
            tpClienteCadastro.Controls.Add(label1);
            tpClienteCadastro.Controls.Add(label2);
            tpClienteCadastro.Location = new Point(4, 29);
            tpClienteCadastro.Margin = new Padding(3, 4, 3, 4);
            tpClienteCadastro.Name = "tpClienteCadastro";
            tpClienteCadastro.Padding = new Padding(3, 4, 3, 4);
            tpClienteCadastro.Size = new Size(702, 395);
            tpClienteCadastro.TabIndex = 2;
            tpClienteCadastro.Text = "Cadastro";
            tpClienteCadastro.UseVisualStyleBackColor = true;
            // 
            // cmbCidade
            // 
            cmbCidade.FormattingEnabled = true;
            cmbCidade.Location = new Point(374, 240);
            cmbCidade.Margin = new Padding(3, 4, 3, 4);
            cmbCidade.Name = "cmbCidade";
            cmbCidade.Size = new Size(266, 28);
            cmbCidade.TabIndex = 41;
            // 
            // txtUf
            // 
            txtUf.Location = new Point(647, 239);
            txtUf.Margin = new Padding(3, 4, 3, 4);
            txtUf.Name = "txtUf";
            txtUf.Size = new Size(46, 27);
            txtUf.TabIndex = 40;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(214, 239);
            txtBairro.Margin = new Padding(3, 4, 3, 4);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(153, 27);
            txtBairro.TabIndex = 38;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(583, 176);
            txtNumero.Margin = new Padding(3, 4, 3, 4);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(114, 27);
            txtNumero.TabIndex = 37;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(0, 239);
            txtComplemento.Margin = new Padding(3, 4, 3, 4);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(206, 27);
            txtComplemento.TabIndex = 36;
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
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(217, 176);
            txtLogradouro.Margin = new Padding(3, 4, 3, 4);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(358, 27);
            txtLogradouro.TabIndex = 22;
            // 
            // btnCep
            // 
            btnCep.Location = new Point(125, 175);
            btnCep.Margin = new Padding(3, 4, 3, 4);
            btnCep.Name = "btnCep";
            btnCep.Size = new Size(86, 31);
            btnCep.TabIndex = 21;
            btnCep.Text = "Buscar";
            btnCep.UseVisualStyleBackColor = true;
            btnCep.Click += btnCep_Click;
            // 
            // textCEP
            // 
            textCEP.Location = new Point(3, 175);
            textCEP.Margin = new Padding(3, 4, 3, 4);
            textCEP.Mask = "00000-000";
            textCEP.Name = "textCEP";
            textCEP.Size = new Size(114, 27);
            textCEP.TabIndex = 20;
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
            // cmbEstadoCivil
            // 
            cmbEstadoCivil.FormattingEnabled = true;
            cmbEstadoCivil.Location = new Point(455, 105);
            cmbEstadoCivil.Margin = new Padding(3, 4, 3, 4);
            cmbEstadoCivil.Name = "cmbEstadoCivil";
            cmbEstadoCivil.Size = new Size(121, 28);
            cmbEstadoCivil.TabIndex = 16;
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
            // cmbGenero
            // 
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Location = new Point(455, 37);
            cmbGenero.Margin = new Padding(3, 4, 3, 4);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(121, 28);
            cmbGenero.TabIndex = 14;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.cross_circle;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(600, 316);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(96, 31);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Image = Properties.Resources.floppy_disk_circle_arrow_right;
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.Location = new Point(490, 316);
            btnSalvar.Margin = new Padding(3, 4, 3, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(103, 31);
            btnSalvar.TabIndex = 12;
            btnSalvar.Text = "&Salvar";
            btnSalvar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Image = Properties.Resources.trash_xmark__1_;
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.Location = new Point(6, 316);
            btnExcluir.Margin = new Padding(3, 4, 3, 4);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(97, 31);
            btnExcluir.TabIndex = 11;
            btnExcluir.Text = "  &Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(3, 105);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(425, 27);
            txtEmail.TabIndex = 10;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(3, 37);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(427, 27);
            txtNome.TabIndex = 8;
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
            // tpClienteConsulta
            // 
            tpClienteConsulta.Controls.Add(gridClientes);
            tpClienteConsulta.Controls.Add(pnlSuperior);
            tpClienteConsulta.Controls.Add(pnlInferior);
            tpClienteConsulta.Location = new Point(4, 29);
            tpClienteConsulta.Margin = new Padding(3, 4, 3, 4);
            tpClienteConsulta.Name = "tpClienteConsulta";
            tpClienteConsulta.Padding = new Padding(3, 4, 3, 4);
            tpClienteConsulta.Size = new Size(702, 395);
            tpClienteConsulta.TabIndex = 1;
            tpClienteConsulta.Text = "Consulta";
            tpClienteConsulta.UseVisualStyleBackColor = true;
            // 
            // gridClientes
            // 
            gridClientes.AllowUserToAddRows = false;
            gridClientes.AllowUserToDeleteRows = false;
            gridClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridClientes.Columns.AddRange(new DataGridViewColumn[] { ColID, ColNome, colemail });
            gridClientes.Dock = DockStyle.Fill;
            gridClientes.Location = new Point(3, 35);
            gridClientes.Margin = new Padding(3, 4, 3, 4);
            gridClientes.Name = "gridClientes";
            gridClientes.ReadOnly = true;
            gridClientes.RowHeadersWidth = 51;
            gridClientes.Size = new Size(696, 324);
            gridClientes.TabIndex = 0;
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
            pnlSuperior.Controls.Add(txtPesquisa);
            pnlSuperior.Controls.Add(btnPesquisar);
            pnlSuperior.Dock = DockStyle.Top;
            pnlSuperior.Location = new Point(3, 4);
            pnlSuperior.Margin = new Padding(3, 4, 3, 4);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(696, 31);
            pnlSuperior.TabIndex = 0;
            pnlSuperior.TabStop = true;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPesquisa.Location = new Point(0, 0);
            txtPesquisa.Margin = new Padding(3, 4, 3, 4);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.PlaceholderText = "Pesquisar nomes";
            txtPesquisa.Size = new Size(583, 27);
            txtPesquisa.TabIndex = 0;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPesquisar.ForeColor = SystemColors.ControlText;
            btnPesquisar.Image = Properties.Resources.search;
            btnPesquisar.Location = new Point(588, -1);
            btnPesquisar.Margin = new Padding(3, 4, 3, 4);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(101, 31);
            btnPesquisar.TabIndex = 1;
            btnPesquisar.Text = "&Pesquisar";
            btnPesquisar.TextAlign = ContentAlignment.MiddleRight;
            btnPesquisar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // pnlInferior
            // 
            pnlInferior.Controls.Add(btnVisualizar);
            pnlInferior.Controls.Add(btnNovo);
            pnlInferior.Dock = DockStyle.Bottom;
            pnlInferior.Location = new Point(3, 359);
            pnlInferior.Margin = new Padding(3, 4, 3, 4);
            pnlInferior.Name = "pnlInferior";
            pnlInferior.Size = new Size(696, 32);
            pnlInferior.TabIndex = 0;
            pnlInferior.TabStop = true;
            // 
            // btnVisualizar
            // 
            btnVisualizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnVisualizar.Image = Properties.Resources.eye;
            btnVisualizar.ImageAlign = ContentAlignment.MiddleLeft;
            btnVisualizar.Location = new Point(525, 0);
            btnVisualizar.Margin = new Padding(3, 4, 3, 4);
            btnVisualizar.Name = "btnVisualizar";
            btnVisualizar.Size = new Size(102, 32);
            btnVisualizar.TabIndex = 3;
            btnVisualizar.Text = "&Visualizar";
            btnVisualizar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVisualizar.UseVisualStyleBackColor = true;
            btnVisualizar.Click += btnVisualizar_Click;
            // 
            // btnNovo
            // 
            btnNovo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNovo.Image = Properties.Resources.add_document;
            btnNovo.Location = new Point(627, 0);
            btnNovo.Margin = new Padding(3, 4, 3, 4);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(69, 32);
            btnNovo.TabIndex = 2;
            btnNovo.Text = "&Novo";
            btnNovo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // tcCliente
            // 
            tcCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tcCliente.Controls.Add(tpClienteConsulta);
            tcCliente.Controls.Add(tpClienteCadastro);
            tcCliente.Location = new Point(1, -29);
            tcCliente.Margin = new Padding(3, 4, 3, 4);
            tcCliente.Name = "tcCliente";
            tcCliente.SelectedIndex = 0;
            tcCliente.Size = new Size(710, 428);
            tcCliente.TabIndex = 0;
            // 
            // ClienteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(710, 399);
            Controls.Add(tcCliente);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ClienteForm";
            Text = "Controle Clientes";
            tpClienteCadastro.ResumeLayout(false);
            tpClienteCadastro.PerformLayout();
            tpClienteConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridClientes).EndInit();
            pnlSuperior.ResumeLayout(false);
            pnlSuperior.PerformLayout();
            pnlInferior.ResumeLayout(false);
            tcCliente.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tpClienteCadastro;
        private Button btnCancelar;
        private Button btnSalvar;
        private Button btnExcluir;
        private TextBox txtEmail;
        private TextBox txtNome;
        private Label label1;
        private Label label2;
        private TabPage tpClienteConsulta;
        private TabControl tcCliente;
        private DataGridView gridClientes;
        private Button btnVisualizar;
        private Button btnPesquisar;
        private Button btnNovo;
        private TextBox txtPesquisa;
        private Panel pnlInferior;
        private Panel pnlSuperior;
        private DataGridViewTextBoxColumn ColID;
        private DataGridViewTextBoxColumn ColNome;
        private DataGridViewTextBoxColumn colemail;
        private ComboBox cmbGenero;
        private Label labelGenero;
        private Label labelEstadoCivil;
        private ComboBox cmbEstadoCivil;
        private Label txtCEP;
        private MaskedTextBox textCEP;
        private Button btnCep;
        private TextBox txtUf;
        private TextBox txtBairro;
        private TextBox txtNumero;
        private TextBox txtComplemento;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label4;
        private TextBox txtLogradouro;
        private ComboBox cmbCidade;
    }
}