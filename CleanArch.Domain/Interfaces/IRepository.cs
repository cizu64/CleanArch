using System.Linq.Expressions;
using CleanArch.Domain.Entities;

namespace CleanArch.Domain.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        IUnitOfWork UnitOfWork { get; }
        Task<T> AddAsync(T entity, CancellationToken cancellationToken = default);
    }
}