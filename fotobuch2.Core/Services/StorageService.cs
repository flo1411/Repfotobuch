using System;
using System.Diagnostics;
using PCLStorage;
using System.Threading.Tasks;

namespace fotobuch2.Core.Services
{
    public class StorageService : IStorageService
    {
        public StorageService()
        {
        }

        public async Task CreateTextFile(string content, string filename)
        {
            IFolder rootFolder = FileSystem.Current.LocalStorage;

			IFile file = await rootFolder.CreateFileAsync(filename,
			 CreationCollisionOption.ReplaceExisting);
			await file.WriteAllTextAsync(content); 
            

        }

        public async Task<string> ReadStringFromLocalPath(string filename)
        {
            IFolder rootFolder = FileSystem.Current.LocalStorage;
            var types = await rootFolder.GetFileAsync(filename);
            return await types.ReadAllTextAsync();
        }
    }
}
