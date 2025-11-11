namespace ControleClientes
{
    public class Os
    {
        public TipoOs TipoOs { get; set; }
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int TipoOsID { get; set; }
        public string Quantidade { get; set; }
        public string valorTotal { get; set; }
        public Cliente Cliente { get; set; }
        public int ClienteId { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string Uf { get; set; }
        
    }
}
