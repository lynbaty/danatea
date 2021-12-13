using System.Collections.Generic;
using Core.Entities.Store;

namespace Core.Interfaces.Query
{
    public interface IImageQuery
    {
        public IReadOnlyList<ProductImage> GetAll();
        public IReadOnlyList<ProductImage> GetbyId(int productId);
        public bool DeletebyId(int id);
        public int UploadImage(int productId, string url);
        public IReadOnlyList<ProductCateDto> MultiMapping();
    }
}