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
            tpClienteCadastro.Location = new Point(4, 24);
            tpClienteCadastro.Name = "tpClienteCadastro";
            tpClienteCadastro.Padding = new Padding(3);
            tpClienteCadastro.Size = new Size(613, 293);
            tpClienteCadastro.TabIndex = 2;
            tpClienteCadastro.Text = "Cadastro";
            tpClienteCadastro.UseVisualStyleBackColor = true;
            // 
            // cmbCidade
            // 
            cmbCidade.FormattingEnabled = true;
            cmbCidade.Location = new Point(327, 180);
            cmbCidade.Name = "cmbCidade";
            cmbCidade.Size = new Size(233, 23);
            cmbCidade.TabIndex = 41;
            // 
            // txtUf
            // 
            txtUf.Location = new Point(566, 179);
            txtUf.Name = "txtUf";
            txtUf.Size = new Size(41, 23);
            txtUf.TabIndex = 40;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(187, 179);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(134, 23);
            txtBairro.TabIndex = 38;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(510, 132);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 37;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(0, 179);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(181, 23);
            txtComplemento.TabIndex = 36;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(566, 162);
            label8.Name = "label8";
            label8.Size = new Size(21, 15);
            label8.TabIndex = 35;
            label8.Text = "UF";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(327, 162);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 34;
            label7.Text = "Cidade";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(187, 161);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 33;
            label6.Text = "Bairro";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 161);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 32;
            label5.Text = "Complemento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(510, 113);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 31;
            label3.Text = "Número";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(190, 114);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 30;
            label4.Text = "Logradouro";
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(190, 132);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(314, 23);
            txtLogradouro.TabIndex = 22;
            // 
            // btnCep
            // 
            btnCep.Location = new Point(109, 131);
            btnCep.Name = "btnCep";
            btnCep.Size = new Size(75, 23);
            btnCep.TabIndex = 21;
            btnCep.Text = "Buscar";
            btnCep.UseVisualStyleBackColor = true;
            btnCep.Click += btnCep_Click;
            // 
            // textCEP
            // 
            textCEP.Location = new Point(3, 131);
            textCEP.Mask = "00000-000";
            textCEP.Name = "textCEP";
            textCEP.Size = new Size(100, 23);
            textCEP.TabIndex = 20;
            // 
            // txtCEP
            // 
            txtCEP.AutoSize = true;
            txtCEP.Location = new Point(3, 113);
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(28, 15);
            txtCEP.TabIndex = 18;
            txtCEP.Text = "CEP";
            // 
            // labelEstadoCivil
            // 
            labelEstadoCivil.AutoSize = true;
            labelEstadoCivil.Location = new Point(398, 58);
            labelEstadoCivil.Name = "labelEstadoCivil";
            labelEstadoCivil.Size = new Size(68, 15);
            labelEstadoCivil.TabIndex = 17;
            labelEstadoCivil.Text = "Estado Civil";
            // 
            // cmbEstadoCivil
            // 
            cmbEstadoCivil.FormattingEnabled = true;
            cmbEstadoCivil.Location = new Point(398, 79);
            cmbEstadoCivil.Name = "cmbEstadoCivil";
            cmbEstadoCivil.Size = new Size(106, 23);
            cmbEstadoCivil.TabIndex = 16;
            // 
            // labelGenero
            // 
            labelGenero.AutoSize = true;
            labelGenero.Location = new Point(398, 7);
            labelGenero.Name = "labelGenero";
            labelGenero.Size = new Size(45, 15);
            labelGenero.TabIndex = 15;
            labelGenero.Text = "Gênero";
            // 
            // cmbGenero
            // 
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Location = new Point(398, 28);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(106, 23);
            cmbGenero.TabIndex = 14;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.cross_circle;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(525, 237);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(84, 23);
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
            btnSalvar.Location = new Point(429, 237);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(90, 23);
            btnSalvar.TabIndex = 12;
            btnSalvar.Text = "&Salvar";
            btnSalvar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Image = Properties.Resources.trash_xmark__1_;
            btnExcluir.ImageAlign = ContentAlignment.TopLeft;
            btnExcluir.Location = new Point(5, 237);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(85, 23);
            btnExcluir.TabIndex = 11;
            btnExcluir.Text = "  &Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(3, 79);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(372, 23);
            txtEmail.TabIndex = 10;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(3, 28);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(374, 23);
            txtNome.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 61);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 9;
            label1.Text = "E-mail";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 10);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 7;
            label2.Text = "Nome:";
            // 
            // tpClienteConsulta
            // 
            tpClienteConsulta.Controls.Add(gridClientes);
            tpClienteConsulta.Controls.Add(pnlSuperior);
            tpClienteConsulta.Controls.Add(pnlInferior);
            tpClienteConsulta.Location = new Point(4, 24);
            tpClienteConsulta.Name = "tpClienteConsulta";
            tpClienteConsulta.Padding = new Padding(3);
            tpClienteConsulta.Size = new Size(613, 293);
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
            gridClientes.Location = new Point(3, 26);
            gridClientes.Name = "gridClientes";
            gridClientes.ReadOnly = true;
            gridClientes.Size = new Size(607, 240);
            gridClientes.TabIndex = 0;
            // 
            // ColID
            // 
            ColID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColID.DataPropertyName = "Id";
            ColID.HeaderText = "ID";
            ColID.Name = "ColID";
            ColID.ReadOnly = true;
            ColID.Resizable = DataGridViewTriState.True;
            ColID.Width = 43;
            // 
            // ColNome
            // 
            ColNome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColNome.DataPropertyName = "Nome";
            ColNome.HeaderText = "Nome";
            ColNome.Name = "ColNome";
            ColNome.ReadOnly = true;
            // 
            // colemail
            // 
            colemail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colemail.DataPropertyName = "Email";
            colemail.HeaderText = "E-mail";
            colemail.Name = "colemail";
            colemail.ReadOnly = true;
            // 
            // pnlSuperior
            // 
            pnlSuperior.Controls.Add(txtPesquisa);
            pnlSuperior.Controls.Add(btnPesquisar);
            pnlSuperior.Dock = DockStyle.Top;
            pnlSuperior.Location = new Point(3, 3);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(607, 23);
            pnlSuperior.TabIndex = 0;
            pnlSuperior.TabStop = true;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPesquisa.Location = new Point(0, 0);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.PlaceholderText = "Pesquisar nomes";
            txtPesquisa.Size = new Size(509, 23);
            txtPesquisa.TabIndex = 0;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPesquisar.ForeColor = SystemColors.ControlText;
            btnPesquisar.Image = Properties.Resources.search;
            btnPesquisar.Location = new Point(513, -1);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(88, 23);
            btnPesquisar.TabIndex = 1;
            btnPesquisar.Text = "&Pesquisar";
            btnPesquisar.TextAlign = ContentAlignment.MiddleRight;
            btnPesquisar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // pnlInferior
            // 
            pnlInferior.Controls.Add(btnVisualizar);
            pnlInferior.Controls.Add(btnNovo);
            pnlInferior.Dock = DockStyle.Bottom;
            pnlInferior.Location = new Point(3, 266);
            pnlInferior.Name = "pnlInferior";
            pnlInferior.Size = new Size(607, 24);
            pnlInferior.TabIndex = 0;
            pnlInferior.TabStop = true;
            // 
            // btnVisualizar
            // 
            btnVisualizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnVisualizar.Image = Properties.Resources.eye;
            btnVisualizar.Location = new Point(465, 0);
            btnVisualizar.Name = "btnVisualizar";
            btnVisualizar.Size = new Size(82, 24);
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
            btnNovo.Location = new Point(547, 0);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(60, 24);
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
            tcCliente.Location = new Point(1, -22);
            tcCliente.Name = "tcCliente";
            tcCliente.SelectedIndex = 0;
            tcCliente.Size = new Size(621, 321);
            tcCliente.TabIndex = 0;
            // 
            // ClienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(621, 299);
            Controls.Add(tcCliente);
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