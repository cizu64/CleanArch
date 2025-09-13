using System.Collections.Concurrent;
using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces;
using Microsoft.Extensions.Logging;

namespace CleanArch.Infrastructure.Services.Logs;

public class Logger:ILog
{
    static ConcurrentQueue<Log> _logs = new();
    public async Task LogAsync(string message)
    {
        var log = new Log(message);
        _logs.Enqueue(log);
    }
}