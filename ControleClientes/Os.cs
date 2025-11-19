namespace ControleClientes
{
    public class Os
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal ValorTotalGeral { get; set; }

        public Cliente Cliente { get; set; }
        public int ClienteId { get; set; }

        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string Uf { get; set; }

        public virtual ICollection<OsItem> Itens { get; set; } = new List<OsItem>();

    }
}