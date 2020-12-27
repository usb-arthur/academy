using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public void Commit()
        {
            _context.SaveChanges();
        }

        public Task CommitAsync()
        {
            return Task.FromResult(_context.SaveChangesAsync());
        }
    }
}
