using Microsoft.EntityFrameworkCore;

namespace ControleClientes
{
    public class OsRepository
    {
        //  public IEnumerable<Os> ObterPorNome(string nome)
        //{
        //  return _context.OrdemServico.Where(o => o.TipoOs.ToLower().Contains(nome.ToLower()))
        //    .ToList();
        //}

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

            return _context.OrdemServico
                .Include(o => o.Cliente)

                .ToList();
        }

        public Os ObterPorId(int id)
        {
            return _context.OrdemServico
                .Include(o => o.Itens) 
                    .ThenInclude(item => item.TipoOs) 
                .FirstOrDefault(o => o.Id == id);
        }

        public void Atualizar(Os os)
        {
 

            _context.Entry(os).State = EntityState.Modified;

 

            _context.SaveChanges();
        }

        public void Remover(int id)
        {
            var os = _context.OrdemServico.Find(id);
            if (os != null)
            {
         
                _context.OrdemServico.Remove(os);
                _context.SaveChanges();
            }
        }
    }
}
