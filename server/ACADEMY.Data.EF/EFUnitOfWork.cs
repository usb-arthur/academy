using System.Threading.Tasks;
using ACADEMY.Infrastructure.Interfaces;

namespace ACADEMY.Data.EF
{
    public class EfUnitOfWork : IUnitOfWork
    {
        private readonly AcademyDbContext _context;

        public EfUnitOfWork(AcademyDbContext context)
        {
            _context = context;
        }

        public void Dispose()
        {
            _context?.Dispose();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}