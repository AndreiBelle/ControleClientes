namespace ControleClientes
{
    public partial class OsForm : Form
    {
        private List<OsItem> _itensServico = new List<OsItem>();
        private readonly OsRepository _repository;
        private readonly TipoOsRepository _tosRepository;
        private int? editingId = null;

        List<Cliente> _clientes;

        List<TipoOs> _tos;

        public OsForm()
        {
            _repository = new OsRepository();
            _tosRepository = new TipoOsRepository();
            InitializeComponent();
            CarregarClientes();
            CarregarTiposDeOs();
            AtualizarGrid();
            ConfigurarGridItens();
        }

        private void ConfigurarGridItens()
        {

            dataGridCadastro.AutoGenerateColumns = false;
            dataGridCadastro.DataSource = null;

            dataGridCadastro.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ServicoNome",
                HeaderText = "Serviço",
                DataPropertyName = "TipoOsNome"
            });

        }

        private void AtualizarGridItens()
        {

            var listaParaGrid = _itensServico.Select(item => new
            {
                Servico = item.TipoOs.Nome,
                Quantidade = item.Quantidade,
                ValorUnitario = item.ValorUnitario,
                ValorTotal = item.ValorTotalItem
            }).ToList();

            dataGridCadastro.DataSource = null;
            dataGridCadastro.DataSource = listaParaGrid;

            if (dataGridCadastro.Columns.Contains("ValorUnitario"))
                dataGridCadastro.Columns["ValorUnitario"].DefaultCellStyle.Format = "C2";
            if (dataGridCadastro.Columns.Contains("ValorTotal"))
                dataGridCadastro.Columns["ValorTotal"].DefaultCellStyle.Format = "C2";
        }

        public void CarregarClientes()
        {
            var clienteRepository = new ClienteRepository();
            _clientes = clienteRepository.ListarTodos();
            comboBoxCliente.DataSource = _clientes;
            comboBoxCliente.DisplayMember = "Nome";
            comboBoxCliente.ValueMember = "Id";
            comboBoxCliente.SelectedIndex = -1;

        }

        public void CarregarTiposDeOs()
        {
            var TipoRepository = new TipoOsRepository();
            _tos = TipoRepository.ListarTodosTipos();
            comboBoxTipoOs.DataSource = _tos;
            comboBoxTipoOs.DisplayMember = "Nome";
            comboBoxTipoOs.ValueMember = "Id";
            comboBoxTipoOs.SelectedIndex = -1;
            //comboBoxTipo.DataSource = _tos;
            //comboBoxTipo.DisplayMember = "Nome";
            //comboBoxTipo.ValueMember = "Id";
            //comboBoxTipo.SelectedIndex = -1;
        }

        private void comboBoxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCliente.SelectedItem is Cliente clienteSelecionado)
            {
                textBoxLogradouro.Text = clienteSelecionado.Logradouro;
                textBoxNumero.Text = clienteSelecionado.Numero;
                textBoxComplemento.Text = clienteSelecionado.Complemento;
                textBoxUf.Text = clienteSelecionado.Uf;
                textBoxBairro.Text = clienteSelecionado.Bairro;
                textBoxCidade.Text = clienteSelecionado.Localidade;
                textBoxCEP.Text = clienteSelecionado.Cep;
            }
            else
            {
                textBoxLogradouro.Text = "";
                textBoxNumero.Text = "";
                textBoxComplemento.Text = "";
                textBoxUf.Text = "";
                textBoxBairro.Text = "";
                textBoxCidade.Text = "";
                textBoxCEP.Text = "";



            }

        }

        private void LimparCampos()
        {
            comboBoxCliente.DataSource = null;
            textBoxLogradouro.Clear();
            textBoxNumero.Clear();
            textBoxComplemento.Clear();
            textBoxUf.Clear();
            textBoxBairro.Clear();
            textBoxCidade.Clear();
            textBoxDescricao.Clear();
            comboBoxCliente.SelectedIndex = -1;
            comboBoxTipoOs.SelectedIndex = -1;
          //  textBoxValor.Clear();
            textBoxQuantidade.Clear();
            textBoxValorTotal.Clear();
            textBoxCEP.Clear();
            editingId = null;
            _itensServico.Clear();
            AtualizarGridItens();

        }

        public void AtualizarGrid()
        {
            dataGridOS.AutoGenerateColumns = false;
            var os = _repository.ListarTodos();
            dataGridOS.DataSource = null;
            dataGridOS.DataSource = os;
        }


        private void buttonNovo_Click(object sender, EventArgs e)
        {
            CarregarTiposDeOs();
            LimparCampos();
            tabControlOS.SelectTab(tabPageCadastroOS);
            CarregarClientes();

        }

        private void buttonVizualizar_Click(object sender, EventArgs e)
        {
            if (dataGridOS.SelectedRows.Count == 0)
            { return; }


            var osSelecionada = (Os)dataGridOS.SelectedRows[0].DataBoundItem;


            var osCompleta = _repository.ObterPorId(osSelecionada.Id);

            if (osCompleta == null)
            {
                MessageBox.Show("Não foi possível carregar a Ordem de Serviço.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

     
            LimparCampos(); 
            CarregarClientes();
            CarregarTiposDeOs();

            var cliente = _clientes.FirstOrDefault(c => c.Id == osCompleta.ClienteId);
            comboBoxCliente.SelectedItem = cliente;
            textBoxLogradouro.Text = osCompleta.Logradouro;
            textBoxNumero.Text = osCompleta.Numero;
            textBoxComplemento.Text = osCompleta.Complemento;
            textBoxUf.Text = osCompleta.Uf;
            textBoxCEP.Text = osCompleta.Cep;
            textBoxBairro.Text = osCompleta.Bairro;
            textBoxCidade.Text = osCompleta.Localidade;
            textBoxDescricao.Text = osCompleta.Descricao;

            _itensServico = osCompleta.Itens.ToList();

            AtualizarGridItens();
            editingId = osCompleta.Id;
            tabControlOS.SelectTab(tabPageCadastroOS);
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (comboBoxCliente.SelectedItem == null)
            {
                MessageBox.Show("Por Favor, Selecione um cliente.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBoxTipoOs.SelectedItem == null)
            {
                if (comboBoxCliente.SelectedItem == null)
                {
                    MessageBox.Show("Por Favor, Selecione um cliente.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (_itensServico.Count == 0)
                {
                    MessageBox.Show("Adicione pelo menos um serviço à OS.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                foreach (var item in _itensServico)
                {
                    item.TipoOs = null;
                }

                Cliente cliente = (Cliente)comboBoxCliente.SelectedItem;


                var os = new Os
                {
                    Descricao = textBoxDescricao.Text.Trim(),
                    Cep = textBoxCEP.Text.Trim(),
                    Logradouro = textBoxLogradouro.Text.Trim(),
                    Complemento = textBoxComplemento.Text.Trim(),
                    Bairro = textBoxBairro.Text.Trim(),
                    Localidade = textBoxCidade.Text.Trim(),
                    Uf = textBoxUf.Text.Trim(),
                    Numero = textBoxNumero.Text.Trim(),
                    ClienteId = cliente.Id,

                    Itens = _itensServico,

                  
                    ValorTotalGeral = _itensServico.Sum(item => item.ValorTotalItem)
                };

               
                if (editingId == null)
                {
                    _repository.Adicionar(os);
                }
                else
                {
                    os.Id = editingId.Value;
                    _repository.Atualizar(os); 
                }

                LimparCampos();
                CarregarTiposDeOs();
                AtualizarGrid();
                tabControlOS.SelectTab(tabPageConsultaOS);
            }

         
        }

        

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            tabControlOS.SelectTab(tabPageConsultaOS);
        }

        private void buttonCancelTipo_Click(object sender, EventArgs e)
        {
            tabControlOS.SelectTab(tabPageConsultaOS);
        }

        

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridOS.SelectedRows.Count == 0)
            {
                return;
            }

            if (MessageBox.Show("Excluir Registro", "Ordem de Serviço", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                tabControlOS.SelectTab(tabPageConsultaOS);
            }

            var os = (Os)dataGridOS.SelectedRows[0].DataBoundItem;
            _repository.Remover(os.Id);
            AtualizarGrid();
            tabControlOS.SelectTab(tabPageConsultaOS);
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            //     var os = _repository.ObterPorNome(textBoxPesquisarOs.Text);
            //     dataGridOS.AutoGenerateColumns = false;
            //     dataGridOS.DataSource = os;
        }

        private void buttonTipo_Click(object sender, EventArgs e)
        {
            var tipoOs = new TipoOsForm();
            tipoOs.MdiParent = this.MdiParent;
            tipoOs.Show();
        }

        //private void comboboxtipoos_selectedindexchanged(object sender, eventargs e)
        //{

        //    if (comboboxtipoos.selecteditem is tipoos osselecionada)
        //    {
        //        textboxvalor.text = osselecionada.valor.tostring();
        //        textboxvalorcadastro.text = osselecionada.valor.tostring();
        //    }
        //    else
        //    {
        //        textboxvalor.text = "";
        //        textboxvalorcadastro.text = "";
        //    }
        //}

        private void CalcularTotal()
        {
            bool vValido = decimal.TryParse(textBoxValorCadastro.Text, out decimal valor);

            bool qValido = decimal.TryParse(textBoxQuantidade.Text, out decimal quantidade);

            if (vValido && qValido)
            {
                decimal total = valor * quantidade;

                textBoxValorTotal.Text = total.ToString("C");
            }
            else
            {
                textBoxValorTotal.Text = "";

            }
        }


        private void textBoxValorTotal_TextChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void textBoxQuantidade_TextChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void textBoxValorCadastro_TextChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void buttonAdicionarServico_Click(object sender, EventArgs e)
        {
            if (comboBoxTipoOs.SelectedItem == null)
            {
                MessageBox.Show("Selecione um Tipo de Serviço.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBoxQuantidade.Text, out int quantidade) || quantidade <= 0)
            {
                MessageBox.Show("Informe uma quantidade válida.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            TipoOs tipoSelecionado = (TipoOs)comboBoxTipoOs.SelectedItem;

            decimal.TryParse(textBoxValorCadastro.Text, out decimal valorUnitario);


            string strValorTotal = textBoxValorTotal.Text
                .Replace("R$", "")
                .Trim();

            decimal.TryParse(strValorTotal, out decimal valorTotalItem);

            var novoItem = new OsItem
            {
                TipoOsId = tipoSelecionado.Id,
                TipoOs = tipoSelecionado,
                Quantidade = quantidade,
                ValorUnitario = valorUnitario,
                ValorTotalItem = valorTotalItem
            };

            _itensServico.Add(novoItem);

            AtualizarGridItens();

            comboBoxTipoOs.SelectedIndex = -1;
          //  textBoxValor.Clear(); 
            textBoxValorCadastro.Clear(); 
            textBoxQuantidade.Clear();
            textBoxValorTotal.Clear();
        }
    }
}


