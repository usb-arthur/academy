using System;
using System.Threading.Tasks;

namespace ACADEMY.Infrastructure.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        Task CommitAsync();
    }
}