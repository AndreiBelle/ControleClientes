namespace ControleClientes
{
    public class Os
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string TipoOs { get; set; }
        public string valor {  get; set; }
        public string quantidade { get; set; }
        public string valorTotal { get; set; }
        public Cliente Cliente { get; set; }
        public int OsId { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string Uf { get; set; }
    }
}
