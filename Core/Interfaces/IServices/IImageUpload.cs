using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Core.Interfaces.IServices
{
    public interface IImageUpload
    {
        Task<string> UpAsync(IFormFile file);
        Task<string> AddImageAsync(string filename);
        void Delete(string filename);
    }
}