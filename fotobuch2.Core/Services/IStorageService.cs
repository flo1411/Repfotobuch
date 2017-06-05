using System;
using System.Threading.Tasks;

namespace fotobuch2.Core.Services
{
    public interface IStorageService
    {
        Task<string> ReadStringFromLocalPath(string filename);
        Task CreateTextFile(string content, string filename);
    }
}
