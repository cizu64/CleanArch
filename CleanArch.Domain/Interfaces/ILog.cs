namespace CleanArch.Domain.Interfaces;
public interface ILog
{
    Task LogAsync(string message);
}