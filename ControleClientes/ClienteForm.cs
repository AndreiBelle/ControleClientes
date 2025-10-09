using ControleClientes.Migrations;

namespace ControleClientes
{
    public partial class ClienteForm : Form
    {
        private readonly ClienteRepository _repository;
        private int? editingId = null;

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
            _repository = new ClienteRepository();
            AtualizarGrid();
            
        }

        private void AtualizarGrid()
        {
            var clientes = _repository.ListarTodos();
            gridClientes.DataSource = clientes;
        }
        private void LimparCampos()
        {
            txtNome.Clear();
            txtEmail.Clear();
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
            txtNome.Text = cliente.Nome;
            txtEmail.Text = cliente.Email;
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
            var cliente = new Cliente
            {
                Nome = txtNome.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Genero = genero.Valor,
                estadocivil = estado.Valor
            };
            
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
    }
}
