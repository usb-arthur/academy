using System.IO;
using System.Threading.Tasks;

namespace ACADEMY.Application.StorageService
{
    public interface IStorageService
    {
        Task SaveFileAsync(Stream mediaBinaryStream, string directory, string fileName);

        Task DeleteFileAsync(string directory, string fileName);
        Task<string> GetImagePathAsync(string directory, string fileName);
    }
}