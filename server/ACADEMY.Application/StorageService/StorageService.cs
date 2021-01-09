using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace ACADEMY.Application.StorageService
{
    public class StorageService : IStorageService
    {
        private readonly string _contentFolder;
        
        private const string CONTENT_FOLDER_NAME = "Contents";

        public StorageService(IWebHostEnvironment  webHostEnvironment)
        {
            _contentFolder = Path.Combine(webHostEnvironment.WebRootPath, CONTENT_FOLDER_NAME);
        }
        
        public async Task SaveFileAsync(Stream mediaBinaryStream, string directory, string fileName)
        {
            var directoryPath = Path.Combine(_contentFolder, directory);
            
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            var filePath = Path.Combine(directoryPath, fileName);
            
            await using var output = new FileStream(filePath, FileMode.Create);
            await mediaBinaryStream.CopyToAsync(output);
        }

        public async Task DeleteFileAsync(string directory, string fileName)
        {
            var filePath = Path.Combine(_contentFolder, directory, fileName);
            if (File.Exists(filePath))
            {
                await Task.Run(() => File.Delete(filePath));
            }
        }

        public Task<string> GetFilePathAsync(string directory, string fileName)
        {
            return Task.FromResult(Path.Combine(_contentFolder, directory, fileName));
        }
    }
}