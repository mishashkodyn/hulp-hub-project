using Microsoft.AspNetCore.Http;

namespace Infrastructure.Services.Interfaces
{
    public interface IStorageService
    {
        public Task<string> UploadFileAsync(IFormFile file);
        public Task DeleteFileAsync(string blobName);
    }
}
