namespace ControleClientes
{
    public class OsRepository
    {
        public IEnumerable<Os> ObterPorNome(string nome)
        {
            return _context.OrdemServico.Where(o => o.TipoOs.ToLower().Contains(nome.ToLower()))
                .ToList();
        }

        private readonly AppDbContext _context;

        public OsRepository()
        {
            _context = new AppDbContext();
        }

        public void Adicionar(Os os)
        {
            _context.OrdemServico.Add(os);
            _context.SaveChanges();
        }

        public List<Os> ListarTodos()
        {
            return _context.OrdemServico.ToList();
        }

        public Os ObterPorId(int id)
        {
            return _context.OrdemServico.Find(id);
        }

        public void Atualizar(Os os)
        {
            Os osExistente = ObterPorId (os.Id);
            if(osExistente != null)
            {
                osExistente.Descricao = os.Descricao;
                osExistente.valor = os.valor;
                osExistente.quantidade = os.quantidade;
                osExistente.valorTotal = os.valorTotal;
                osExistente.TipoOs = os.TipoOs;
                _context.SaveChanges ();
            }
        }

        public void Remover(int id)
        {
            var os = _context.OrdemServico.Find(id);
            if( os != null )
            {
                _context.OrdemServico.Remove(os);
                _context.SaveChanges();
            }
        }
    }
}
