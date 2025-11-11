namespace ControleClientes
{
    internal class TipoOsRepository
    {
        private readonly AppDbContext _context;

        public TipoOsRepository()
        {
            _context = new AppDbContext();
        }

        public void AdicionarTipo(TipoOs os)
        {
            _context.TiposDeOs.Add(os);
            _context.SaveChanges();
        }

        public List<TipoOs> ListarTodosTipos()
        {
            return _context.TiposDeOs.ToList();
        }

        public TipoOs ObterporIdTipo(int id)
        {
            return _context.TiposDeOs.Find(id);
        }

        public void AtualizarTipo(TipoOs os)
        {
            TipoOs tipoOs = ObterporIdTipo (os.Id);
            if(tipoOs != null)
            {
                tipoOs.Id = os.Id;
                tipoOs.Nome = os.Nome;
                _context.SaveChanges();
            }
        }

        public void RemoverTipo(int id)
        {
            var tipoOs = _context.TiposDeOs.Find(id);
            if (tipoOs != null)
            {
                _context.TiposDeOs.Remove(tipoOs);
                _context.SaveChanges();
            }
        }
    }
}
