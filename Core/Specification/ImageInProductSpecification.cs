using Core.Entities.Store;

namespace Core.Specification
{
    public class ImageInProductSpecification : BaseSpecification<ProductImage>
    {
        public ImageInProductSpecification(int productId) : base(x => x.ProductId == productId)
        {
            
        }
    }
}