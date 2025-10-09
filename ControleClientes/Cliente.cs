namespace ControleClientes
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public Genero Genero { get; set; }

        public estadocivil estadocivil { get; set; }
    }
}
