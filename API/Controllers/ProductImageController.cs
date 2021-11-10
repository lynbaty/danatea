using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities.Store;
using Core.Interfaces;
using Core.Interfaces.IServices;
using Core.Specification;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ProductImageController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IImageUpload _imageUpload;
       
        public ProductImageController(IUnitOfWork unitOfWork,IImageUpload imageUpload)
        {
            _unitOfWork = unitOfWork;
            _imageUpload = imageUpload;
        }
        [HttpGet("{productId}")]
        public async Task<ActionResult<IReadOnlyList<ProductImage>>> GetbyProduct(int productId)
        {
           var spec = new ImageInProductSpecification(productId);
           var rs = await _unitOfWork.Repository<ProductImage>().GetAllSpecAsync(spec);

           return Ok(rs);
        }
        [HttpPost("{productId}")]
        public async Task<ActionResult> CreatebyProduct(int productId, IFormFile file)
        {
           var url = await _imageUpload.UpAsync(file);
           var productImage = new ProductImage(){ProductId= productId, Url = url};
           _unitOfWork.Repository<ProductImage>().Add(productImage);
           var rs = await _unitOfWork.Complete();
           if(rs>0) return Ok(rs);
           return BadRequest();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
           var image = await _unitOfWork.Repository<ProductImage>().GetbyIdAsync(id);
           _imageUpload.Delete(image.Url);

           _unitOfWork.Repository<ProductImage>().Delete(image);
           var rs = await _unitOfWork.Complete();
           if(rs>0) return Ok(rs);
           return BadRequest();
        }

    }
}