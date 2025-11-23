using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace ControleClientes
{
    public partial class ClienteForm : Form
    {
        private readonly ClienteRepository _repository;

        private readonly CidadeRepository _cidadeRepository;

        private int? editingId = null;

        List<Cidade> _cidades;

        private static readonly HttpClient _httpClient = new HttpClient();

        private void CarregarCidades()
        {
            var cidadeRepository = new CidadeRepository();
            _cidades = cidadeRepository.ListarTodos();
            comboBoxCidade.DataSource = _cidades;
            comboBoxCidade.DisplayMember = "Nome";
            comboBoxCidade.ValueMember = "id";
            comboBoxCidade.SelectedIndex = -1;

        }

        List<ItemEstadoCivil> estadocivillista = new List<ItemEstadoCivil>
        {
            new ItemEstadoCivil {Valor = estadocivil.Solteiro, Descricao = "Solteiro(a)"},
            new ItemEstadoCivil {Valor = estadocivil.Casado, Descricao = "Casado(a)"},
            new ItemEstadoCivil {Valor = estadocivil.Uniao_Estavel, Descricao = "União Estável"},
            new ItemEstadoCivil {Valor = estadocivil.Viúvo, Descricao = "Viúvo(a)"},
            new ItemEstadoCivil {Valor = estadocivil.Divorciado, Descricao = "Divorciado(a)"},
            new ItemEstadoCivil {Valor = estadocivil.Separado_judicialmente, Descricao = "Separado Judicialmente(a)"}

        };

        List<ItemGenero> itemGeneros = new List<ItemGenero>
        {
            new ItemGenero {Valor = Genero.Masculino, Descricao = "Masculino" },
            new ItemGenero {Valor = Genero.Feminino, Descricao = "Feminino"}
        };

        private void CarregarEnd()
        {

            comboBoxGenero.DisplayMember = "Localidade";

        }

        private void CarregarGenero()
        {
            comboBoxGenero.DataSource = itemGeneros;
            comboBoxGenero.DisplayMember = "Descricao";
            comboBoxGenero.ValueMember = "Valor";
        }

        private void CarregarEstado()
        {
            comboBoxEstadoCivil.DataSource = estadocivillista;
            comboBoxEstadoCivil.DisplayMember = "Descricao";
            comboBoxEstadoCivil.ValueMember = "Valor";
        }

        public ClienteForm()
        {
            InitializeComponent();
            CarregarGenero();
            CarregarEstado();
            CarregarEnd();
            _repository = new ClienteRepository();
            _cidadeRepository = new CidadeRepository(); 
            AtualizarGrid();
            CarregarCidades();
        }

        private void AtualizarGrid()
        {

            var clientes = _repository.ListarTodos();
            dataGridClientes.DataSource = null;
            dataGridClientes.DataSource = clientes;
            dataGridClientes.Columns["CidadeId"].Visible = false;
            dataGridClientes.Columns["Cidade"].Visible = false;
            dataGridClientes.Columns["Cep"].Visible = false;
            dataGridClientes.Columns["Logradouro"].Visible = false;
            dataGridClientes.Columns["Numero"].Visible = false;
            dataGridClientes.Columns["Complemento"].Visible = false;
            dataGridClientes.Columns["Bairro"].Visible = false;
            dataGridClientes.Columns["Localidade"].Visible = false;
            dataGridClientes.Columns["uf"].Visible = false;
            dataGridClientes.Columns["estadocivil"].Visible = false;
            dataGridClientes.Columns["OS"].Visible = false;
            dataGridClientes.Columns["Genero"].Visible = false;
        }
        private void LimparCampos()
        {
            textBoxNome.Clear();
            textBoxEmail.Clear();
            textCEP.Clear();
            textBoxLogradouro.Clear();
            textBoxBairro.Clear();
            textBoxUf.Clear();
            textBoxNumero.Focus();
            editingId = null;
            dataGridClientes.ClearSelection();
            
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();

            tabControlCliente.SelectTab(tabPageClienteCadastro);
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            if (dataGridClientes.SelectedRows.Count == 0)
                return;
            var cliente = (Cliente)dataGridClientes.SelectedRows[0].DataBoundItem;
            var cidade = _cidades.FirstOrDefault(c => c.Id == cliente.CidadeId);
            comboBoxCidade.SelectedItem = cidade;
            textBoxUf.Text = cidade.UF;
            textBoxNome.Text = cliente.Nome;
            textBoxEmail.Text = cliente.Email;
            textCEP.Text = cliente.Cep;
            textBoxBairro.Text = cliente.Bairro;
            textBoxLogradouro.Text = cliente.Logradouro;
            textBoxNumero.Text = cliente.Numero;
            textBoxComplemento.Text = cliente.Complemento;
            comboBoxGenero.SelectedItem = itemGeneros.FirstOrDefault(
                g => g.Valor == cliente.Genero);
            comboBoxEstadoCivil.SelectedItem = estadocivillista.FirstOrDefault(e => e.Valor == cliente.estadocivil);
            editingId = cliente.Id;
            tabControlCliente.SelectTab(tabPageClienteCadastro);

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridClientes.SelectedRows.Count == 0)
                return;

            if (MessageBox.Show("Excluir Registo?", "Clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tabControlCliente.SelectTab(tabPageClienteConsulta);
            }
            var cliente = (Cliente)dataGridClientes.SelectedRows[0].DataBoundItem;
            _repository.Remover(cliente.Id);
            AtualizarGrid();
            tabControlCliente.SelectTab(tabPageClienteConsulta);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            ItemEstadoCivil estado = (ItemEstadoCivil)comboBoxEstadoCivil.SelectedItem;
            ItemGenero genero = (ItemGenero)comboBoxGenero.SelectedItem;

            string nomeCidade = comboBoxCidade.Text.Trim();
            string ufCidade = textBoxUf.Text.Trim();

            Cidade cidade = _cidades.FirstOrDefault(c => c.Nome.Equals(nomeCidade, StringComparison.OrdinalIgnoreCase) && 
            c.UF.Equals(ufCidade, StringComparison.OrdinalIgnoreCase));

            if (cidade == null)
            {
                MessageBox.Show("Cidade não encontrada no cadastro. Resgistrando nova cidade...", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Nova cidade cadastrada!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cidade = new Cidade
                {
                    Nome = nomeCidade,
                    UF = ufCidade,
                };

                _cidadeRepository.Adicionar(cidade);
                CarregarCidades();
                AtualizarGrid();

            }

            if (textBoxNome.Text.Trim() == "")
            {
                if (MessageBox.Show("Você deve atribuir o nome do seu cliente no espaço Nome", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    return;
                }
                else {
                    buttonSalvar.PerformClick();

                    var cliente = new Cliente
                    {
                        Nome = textBoxNome.Text.Trim(),
                        Email = textBoxEmail.Text.Trim(),
                        Cep = textCEP.Text.Trim(),
                        Logradouro = textBoxLogradouro.Text.Trim(),
                        Complemento = textBoxComplemento.Text.Trim(),
                        Bairro = textBoxBairro.Text.Trim(),
                        Localidade = cidade.Nome,
                        Uf = cidade.UF,
                        Numero = textBoxNumero.Text.Trim(),
                        Genero = genero.Valor,
                        estadocivil = estado.Valor,
                        CidadeId = cidade.Id
                    };

                    if (editingId == null)
                    {
                        _repository.Adicionar(cliente);
                    }
                    else
                    {
                        cliente.Id = editingId.Value;
                        _repository.Atualizar(cliente);
                    }

                    LimparCampos();
                    AtualizarGrid();
                    tabControlCliente.SelectTab(tabPageClienteConsulta);

            }   }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (textBoxNome.Text.Trim() != "" || comboBoxCidade.Text.Trim() != "")
            {

                if (MessageBox.Show("Você não salvou o cadastro do Cliente deseja salvar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    buttonSalvar.PerformClick();
                }
                tabControlCliente.SelectTab(tabPageClienteConsulta);
            }   
            
        }

        private async Task<Endereco> BuscarCepAsync(string cep)
        {
            string url = $"https://viacep.com.br/ws/{cep}/json/";

            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    return JsonSerializer.Deserialize<Endereco>(responseBody);
                }
                else
                    throw new Exception($"Consultando o CEP. Código de status: {response.StatusCode}");
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro de rede ao buscar CEP: {ex.Message}");
            }
        }

        private async void btnCep_Click(object sender, EventArgs e)
        {
            string cep = textCEP.Text.Trim();
            if (string.IsNullOrEmpty(cep))
            {
                MessageBox.Show("Por favor, insira um CEP válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Endereco endereco = await BuscarCepAsync(cep);
                textBoxLogradouro.Text = endereco.Logradouro;
                textBoxBairro.Text = endereco.Bairro;
                comboBoxCidade.Text = endereco.Localidade;
                textBoxUf.Text = endereco.Uf;
                textBoxNumero.Focus();
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Erro na requisição HTTP: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (JsonException ex)
            {
                MessageBox.Show($"Desserializando o JSON: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            var Clientes = _repository.ObterPorNome(textBoxPesquisa.Text);
            dataGridClientes.AutoGenerateColumns = false;
            dataGridClientes.DataSource = Clientes;
        }
    }
}
