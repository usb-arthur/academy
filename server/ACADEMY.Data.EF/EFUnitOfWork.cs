using System.Threading.Tasks;
using ACADEMY.Infrastructure.Interfaces;

namespace ACADEMY.Data.EF
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private readonly AcademyDbContext _context;

        public EFUnitOfWork(AcademyDbContext context)
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