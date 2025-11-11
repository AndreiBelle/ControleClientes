namespace ControleClientes
{
    public partial class OsForm : Form
    {
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
            comboBoxTipo.DataSource = _tos;
            comboBoxTipo.DisplayMember = "Nome";
            comboBoxTipo.ValueMember = "Id";
            comboBoxTipo.SelectedIndex = -1;
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
            textBoxValor.Clear();
            textBoxQuantidade.Clear();
            textBoxValorTotal.Clear();
            textBoxCEP.Clear();
            editingId = null;

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
            var os = (Os)dataGridOS.SelectedRows[0].DataBoundItem;
            var TipoOs = _tos.FirstOrDefault(t => t.Id == os.TipoOsID);
            var clientes = _clientes.FirstOrDefault(c => c.Id == os.ClienteId);
            comboBoxCliente.SelectedItem = clientes;
            textBoxLogradouro.Text = os.Logradouro;
            textBoxNumero.Text = os.Numero;
            textBoxComplemento.Text = os.Complemento;
            textBoxUf.Text = os.Uf;
            textBoxCEP.Text = os.Cep;
            textBoxBairro.Text = os.Bairro;
            textBoxCidade.Text = os.Localidade;
            textBoxDescricao.Text = os.Descricao;
            comboBoxTipoOs.Text = TipoOs.Nome;
            textBoxValor.Text = TipoOs.Valor;
            textBoxQuantidade.Text = os.Quantidade;
            textBoxValorTotal.Text = os.valorTotal;
            editingId = os.Id;
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
                MessageBox.Show("Por Favor, Selecione um Tipo de Ordem de Serviço.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Cliente cliente = (Cliente)comboBoxCliente.SelectedItem;
            TipoOs tipoSelecionado = (TipoOs)comboBoxTipoOs.SelectedItem;

            var os = new Os
            {
                Descricao = textBoxDescricao.Text.Trim(),
                Quantidade = textBoxQuantidade.Text.Trim(),
                valorTotal = textBoxValorTotal.Text.Trim(),
                Cep = textBoxCEP.Text.Trim(),
                Logradouro = textBoxLogradouro.Text.Trim(),
                Complemento = textBoxComplemento.Text.Trim(),
                Bairro = textBoxBairro.Text.Trim(),
                Localidade = textBoxCidade.Text.Trim(),
                Uf = textBoxUf.Text.Trim(),
                Numero = textBoxNumero.Text.Trim(),
                ClienteId = cliente.Id,
                TipoOsID = tipoSelecionado.Id
            };
            var TipoOs = new TipoOs
            {
                Nome = comboBoxTipoOs.Text.Trim(),
                Valor = textBoxValor.Text.Trim(),
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
            AtualizarGrid();
            tabControlOS.SelectTab(tabPageConsultaOS);
        }

        private void buttonSalvarTipo_Click(object sender, EventArgs e)
        {
            string nomeTipo = comboBoxTipo.Text.Trim();
            string valor = textBoxValor.Text.Trim();

            TipoOs tos = _tos.FirstOrDefault(os => os.Nome.Equals(nomeTipo, StringComparison.OrdinalIgnoreCase));

            if (string.IsNullOrEmpty(nomeTipo))
            {
                MessageBox.Show("Não é possivel salvar sem nome do Tipo de Serviço!.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            tos = new TipoOs
            {
                Nome = nomeTipo,
                Valor = valor,
            };

            if (editingId == null)
            {
                _tosRepository.AdicionarTipo(tos);
            }
            else
            {
                tos.Id = editingId.Value;
                _tosRepository.AtualizarTipo(tos);
            }

            LimparCampos();
            AtualizarGrid();
            tabControlOS.SelectTab(tabPageConsultaOS);

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            tabControlOS.SelectTab(tabPageConsultaOS);
        }

        private void buttonCancelTipo_Click(object sender, EventArgs e)
        {
            tabControlOS.SelectTab(tabPageConsultaOS);
        }

        private void buttonExcluirTipo_Click(object sender, EventArgs e)
        {
            if (dataGridOS.SelectedRows.Count == 0)
            {
                return;
            }

            if (MessageBox.Show("Excluir Registro", "Tipo de Ordem de Serviço", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                tabControlOS.SelectTab(tabPageConsultaOS);
            }

            var Tos = (TipoOs)dataGridOS.SelectedRows[0].DataBoundItem;
            _tosRepository.RemoverTipo(Tos.Id);
            AtualizarGrid();
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
            LimparCampos();
            tabControlOS.SelectTab(tabPageCadastroTipo);
        }

        private void comboBoxTipoOs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTipoOs.SelectedItem is TipoOs OsSelecionada)
            {
                textBoxValor.Text = OsSelecionada.Valor;
                textBoxValorCadastro.Text = OsSelecionada.Valor;
            }
            else
            {
                textBoxValor.Text = "";
                textBoxValorCadastro.Text = "";
            }
        }

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
    }
}

