using Contexto.Data.Interface;
using Contexto.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Contexto.Data.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly SistemaContext _sistemaContext;

        public UsuarioRepository(SistemaContext sistemaContext)
        {
            _sistemaContext = sistemaContext;
        }

        public void Add<T>(T entity) where T : class
        {
            _sistemaContext.Add(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            _sistemaContext.Update(entity);
        }
        public void Delete<T>(T entity) where T : class
        {
            _sistemaContext.Remove(entity);
        }
        public async Task<bool> SavechangesAsync()
        {
            return (await _sistemaContext.SaveChangesAsync()) > 0;
        }
        public async Task<Usuario[]> GetTodosUsuarios()
        {
            IQueryable<Usuario> query = _sistemaContext.Usuario.OrderBy(i=>i.primeiroNome);

            query = query.AsNoTracking()
                         .OrderBy(i=>i.primeiroNome);

            return await query.ToArrayAsync();
        }

        public async Task<Usuario> GetUsuario(int usuarioId)
        {
            IQueryable<Usuario> query = _sistemaContext.Usuario
                .Where(i=>i.id == usuarioId)
                .OrderBy(i => i.primeiroNome);

            query = query.AsNoTracking()
                         .OrderBy(i => i.primeiroNome);

            return await query.FirstOrDefaultAsync();
        }
    }
}
