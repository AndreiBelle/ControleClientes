using System.Windows.Forms;

namespace ControleClientes
{
    public partial class TipoOsForm : Form
    {
        private readonly TipoOsRepository repository;
        List<TipoOs> tipos;
        private int? editingId = null;
        public TipoOsForm()
        {
            InitializeComponent();
            repository = new TipoOsRepository();
            LimparCampos();
            CarregarTiposDeOs();
        }

        private void LimparCampos()
        {
            comboBoxTipo.SelectedIndex = -1;
            textBoxValor.Clear();
        }

        private void CarregarTiposDeOs()
        {
            var tipoOs = new TipoOsRepository();
            tipos = tipoOs.ListarTodosTipos();
            comboBoxTipo.DataSource = tipos;
            comboBoxTipo.DisplayMember = "Nome";
            comboBoxTipo.ValueMember = "Id";
            comboBoxTipo.SelectedIndex = -1;
        }

        private void buttonSalvarTipo_Click(object sender, EventArgs e)
        {

            if (comboBoxTipo.Text == "")
            {
                MessageBox.Show("Por Favor Preencha o campo do Tipo de Serviço!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (textBoxValor.Text == null)
            {
                MessageBox.Show("Por Favor Preencha o campo do Valor do serviço!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!decimal.TryParse(textBoxValor.Text, out decimal valorConvertido))
            {
                MessageBox.Show("Digite um valor numérico válido.");
                return;
            }

            var tipo = new TipoOs
            {
                Nome = comboBoxTipo.Text.Trim(),
                Valor = decimal.Parse(textBoxValor.Text.Trim())
            };

            if (editingId == null)
            {
                repository.AdicionarTipo(tipo);
            }
            else
            {
                tipo.Id = editingId.Value;
                repository.AtualizarTipo(tipo);
            }

            LimparCampos();
            CarregarTiposDeOs();

        }

        private void buttonExcluirTipo_Click(object sender, EventArgs e)
        {
            if (!(comboBoxTipo.SelectedItem is TipoOs tipoSelecionado))
            {
                MessageBox.Show("Selecione um item para excluir.");
                return;
            }

            if (MessageBox.Show("Excluir Registro: " + tipoSelecionado.Nome + "?", "Tipo de Ordem de Serviço", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                repository.RemoverTipo(tipoSelecionado.Id);
                CarregarTiposDeOs();
                LimparCampos();
                MessageBox.Show("Excluído com Sucesso!");

            }

            CarregarTiposDeOs();


        }

        private void comboBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBoxTipo.SelectedItem is TipoOs tipoSelecionado)
            {
                textBoxValor.Text = tipoSelecionado.Valor.ToString("N2");
                editingId = tipoSelecionado.Id;
            }
            else
            {
                textBoxValor.Clear();
                editingId = null;
            }
        }

        private void buttonCancelTipo_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
