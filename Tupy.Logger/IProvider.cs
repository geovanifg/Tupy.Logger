using System;
using System.Threading.Tasks;
using Tupy;

namespace Tupy.Logger
{
    public interface IProvider
    {
        ProviderTypes Type { get; }
        string ID { get; set; }
        ExecutionResponse WriteEntry(EventEntry entry);
        Task<ExecutionResponse> RemoveBefore(string sourceName, DateTime date);
    }
}
