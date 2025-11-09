namespace ControleClientes
{
    public partial class OsForm : Form
    {
        private readonly OsRepository _repository;
        private int? editingId = null;

        List<Cliente> _clientes;

        public OsForm()
        {
            _repository = new OsRepository();
            InitializeComponent();
            CarregarClientes();
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
            comboBoxTipoOs.Items.Clear();
            textBoxValor.Clear();
            textBoxQuantidade.Clear();
            textBoxValorTotal.Clear();
            textBoxCEP.Clear();

        }

        public void AtualizarGrid()
        {
            var os = _repository.ListarTodos();
            dataGridOS.DataSource = os;
            dataGridOS.Columns["Cep"].Visible = false;
            dataGridOS.Columns["Logradouro"].Visible = false;
            dataGridOS.Columns["Numero"].Visible = false;
            dataGridOS.Columns["Complemento"].Visible = false;
            dataGridOS.Columns["Bairro"].Visible = false;
            dataGridOS.Columns["Localidade"].Visible = false;
            dataGridOS.Columns["uf"].Visible = false;
        }


        private void buttonNovo_Click(object sender, EventArgs e)
        {

            LimparCampos();
            tabControlOS.SelectTab(tabPageCadastroOS);
            CarregarClientes();

        }

        private void buttonVizualizar_Click(object sender, EventArgs e)
        {
            if (dataGridOS.SelectedRows.Count == 0)
            { return; }
            var os = (Os)dataGridOS.SelectedRows[0].DataBoundItem;
            var clientes = _clientes.FirstOrDefault(c => c.Id == os.Id);
            comboBoxCliente.SelectedItem = clientes;
            textBoxLogradouro.Text = os.Logradouro;
            textBoxNumero.Text = os.Numero;
            textBoxComplemento.Text = os.Complemento;
            textBoxUf.Text = os.Uf;
            textBoxCEP.Text = os.Cep;
            textBoxBairro.Text = os.Bairro;
            textBoxCidade.Text = os.Localidade;
            textBoxDescricao.Text = os.Descricao;
            comboBoxTipoOs.Text = os.TipoOs;
            textBoxValor.Text = os.valor;
            textBoxQuantidade.Text = os.quantidade;
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
            Cliente cliente = (Cliente)comboBoxCliente.SelectedItem;

            var os = new Os
            {
                Descricao = textBoxDescricao.Text.Trim(),
                TipoOs = comboBoxTipoOs.Text.Trim(),
                valor = textBoxValor.Text.Trim(),
                quantidade = textBoxQuantidade.Text.Trim(),
                valorTotal = textBoxValorTotal.Text.Trim(),
                Cep = textBoxCEP.Text.Trim(),
                Logradouro = textBoxLogradouro.Text.Trim(),
                Complemento = textBoxComplemento.Text.Trim(),
                Bairro = textBoxBairro.Text.Trim(),
                Localidade = textBoxCidade.Text.Trim(),
                Uf = textBoxUf.Text.Trim(),
                Numero = textBoxNumero.Text.Trim(),

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

        private void buttonCancelar_Click(object sender, EventArgs e)
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
            var os = _repository.ObterPorNome(textBoxPesquisarOs.Text);
            dataGridOS.AutoGenerateColumns = false;
            dataGridOS.DataSource = os;
        }

        private void buttonTipo_Click(object sender, EventArgs e)
        {

        }
    }
}

