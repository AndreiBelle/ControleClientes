using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ControleClientes
{
    public partial class ClienteForm : Form
    {
        private readonly ClienteRepository _repository;
        private int? editingId = null;

        List<Cidade> _cidades;

        private void CarregarCidades()
        {
            var cidadeRepository = new CidadeRepository();
            _cidades = cidadeRepository.ListarTodos();
            cmbCidade.DataSource = _cidades;
            cmbCidade.DisplayMember = "Nome";
            cmbCidade.ValueMember = "id";

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

            cmbGenero.DisplayMember = "Localidade";

        }

        private void CarregarGenero()
        {
            cmbGenero.DataSource = itemGeneros;
            cmbGenero.DisplayMember = "Descricao";
            cmbGenero.ValueMember = "Valor";
        }

        private void CarregarEstado()
        {
            cmbEstadoCivil.DataSource = estadocivillista;
            cmbEstadoCivil.DisplayMember = "Descricao";
            cmbEstadoCivil.ValueMember = "Valor";
        }

        public ClienteForm()
        {
            InitializeComponent();
            CarregarGenero();
            CarregarEstado();
            CarregarEnd();
            _repository = new ClienteRepository();
            AtualizarGrid();
            CarregarCidades();
        }

        private void AtualizarGrid()
        {
            var clientes = _repository.ListarTodos();
            gridClientes.DataSource = clientes;
            gridClientes.Columns["CidadeId"].Visible = false;
            gridClientes.Columns["Cidade"].Visible = false;
            gridClientes.Columns["Cep"].Visible = false;
            gridClientes.Columns["Logradouro"].Visible = false;
            gridClientes.Columns["Numero"].Visible = false;
            gridClientes.Columns["Complemento"].Visible = false;
            gridClientes.Columns["Bairro"].Visible = false;
            gridClientes.Columns["Localidade"].Visible = false;
            gridClientes.Columns["uf"].Visible = false;
            gridClientes.Columns["estadocivil"].Visible = false;
        }
        private void LimparCampos()
        {
            txtNome.Clear();
            txtEmail.Clear();
            textCEP.Clear();
            txtLogradouro.Clear();
            txtBairro.Clear();
            txtUf.Clear();
            txtNumero.Focus();
            editingId = null;
            gridClientes.ClearSelection();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();

            tcCliente.SelectTab(tpClienteCadastro);
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            if (gridClientes.SelectedRows.Count == 0)
                return;
            var cliente = (Cliente)gridClientes.SelectedRows[0].DataBoundItem;
            var cidade = _cidades.FirstOrDefault(c => c.Id == cliente.Id);
            cmbCidade.SelectedItem = cidade;
            txtUf.Text = cidade.UF;
            txtNome.Text = cliente.Nome;
            txtEmail.Text = cliente.Email;
            textCEP.Text = cliente.Cep;
            txtLogradouro.Text = cliente.Logradouro;
            txtComplemento.Text = cliente.Complemento;
            cmbGenero.SelectedItem = itemGeneros.FirstOrDefault(
                g => g.Valor == cliente.Genero);
            cmbEstadoCivil.SelectedItem = estadocivillista.FirstOrDefault(e => e.Valor == cliente.estadocivil);
            editingId = cliente.Id;
            tcCliente.SelectTab(tpClienteCadastro);

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (gridClientes.SelectedRows.Count == 0)
                return;

            if (MessageBox.Show("Excluir Registo?", "Clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tcCliente.SelectTab(tpClienteConsulta);
            }
            var cliente = (Cliente)gridClientes.SelectedRows[0].DataBoundItem;
            _repository.Remover(cliente.Id);
            AtualizarGrid();
            tcCliente.SelectTab(tpClienteConsulta);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            ItemEstadoCivil estado = (ItemEstadoCivil)cmbEstadoCivil.SelectedItem;
            ItemGenero genero = (ItemGenero)cmbGenero.SelectedItem;
            Cidade cidade = (Cidade)cmbCidade.SelectedItem;

            var cliente = new Cliente
            {
                Nome = txtNome.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Cep = textCEP.Text.Trim(),
                Logradouro = txtLogradouro.Text.Trim(),
                Complemento = txtComplemento.Text.Trim(),
                Bairro = txtBairro.Text.Trim(),
                Localidade = cmbCidade.Text.Trim(),
                Uf = txtUf.Text.Trim(),
                Numero = txtNumero.Text.Trim(),
                Genero = genero.Valor,
                estadocivil = estado.Valor,
                CidadeId = cidade.Id

            }; ;

            if (editingId == null)
                _repository.Adicionar(cliente);
            else
            {
                cliente.Id = editingId.Value;
                _repository.Atualizar(cliente);
            }

            LimparCampos();
            AtualizarGrid();
            tcCliente.SelectTab(tpClienteConsulta);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tcCliente.SelectTab(tpClienteConsulta);
        }

        private async Task<Endereco> BuscarCepAsync(string cep)
        {
            string url = $"https://viacep.com.br/ws/{cep}/json/";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    return JsonSerializer.Deserialize<Endereco>(responseBody);
                }
                else
                    throw new Exception($"Consultando o CEP. Código de status: {response.StatusCode}");
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
                txtLogradouro.Text = endereco.Logradouro;
                txtBairro.Text = endereco.Bairro;
                cmbCidade.Text = endereco.Localidade;
                txtUf.Text = endereco.Uf;
                txtNumero.Focus();
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
            var Clientes = _repository.ObterPorNome(txtPesquisa.Text);
            gridClientes.AutoGenerateColumns = false;
            gridClientes.DataSource = Clientes;
        }
    }
}
