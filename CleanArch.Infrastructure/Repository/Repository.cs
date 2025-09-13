using CleanArch.Domain.Entities;
using CleanArch.Infrastructure.Persistence;
using CleanArch.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore.Internal;

namespace CleanArch.Infrastructure.Repository;

public class Repository<T> : IRepository<T> where T : BaseEntity
{
    protected readonly MyContext _context;
    public IUnitOfWork UnitOfWork => _context;

    public Repository(MyContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public async Task<T> AddAsync(T entity, CancellationToken cancellationToken = default)
    {
        if (entity == null)
        {
            throw new ArgumentNullException(nameof(entity));
        }

        await _context.Set<T>().AddAsync(entity, cancellationToken);
        return entity;
    }

}