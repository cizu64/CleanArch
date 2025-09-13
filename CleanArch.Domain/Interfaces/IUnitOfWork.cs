namespace CleanArch.Domain.Interfaces;

public interface IUnitOfWork
{
    Task<int> SaveAsync(CancellationToken cancellationToken=default);
}
