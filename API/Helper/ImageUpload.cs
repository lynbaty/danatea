using System;
using System.IO;
using System.Threading.Tasks;
using Core.Interfaces.IServices;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace API.Helper
{
    public class ImageUpload : IImageUpload
    {
        private readonly IWebHostEnvironment _env;

        public ImageUpload(IWebHostEnvironment env)
        {
            _env = env;
        }
        public Task<string> AddImageAsync(string filename)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(string filename)
        {
            string wwwRootPath = _env.WebRootPath;
            string path = Path.Combine(wwwRootPath, filename);
            if(File.Exists(path)) File.Delete(path);
        }

        public async Task<string> UpAsync(IFormFile file)
        {
            string wwwRootPath = _env.WebRootPath;
            string extension = Path.GetExtension(file.FileName);
            var name = Guid.NewGuid() + extension;
            string path = Path.Combine(wwwRootPath,"ProductImages",name);
            using(var fileStream = new FileStream(path,FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }
            return "ProductImages/"+ name;
        }
    }
}