using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Core.Entities.Store;
using Core.Interfaces.IServices;
using Core.Interfaces.Query;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ImageController : BaseController
    {
        private readonly IImageQuery _imageQuery;
        private readonly IImageUpload _imageUpload;

        public ImageController(IImageQuery imageQuery, IImageUpload imageUpload)
        {
            _imageQuery = imageQuery;
            _imageUpload = imageUpload;
        }
        [HttpGet]
        public ActionResult<IReadOnlyList<ProductImage>> GetAll(){
            return Ok(_imageQuery.GetAll());
        }
        [HttpGet("{productId}")]
        public ActionResult<IReadOnlyList<ProductImage>> GetAll(int productId){
            return Ok(_imageQuery.GetbyId(productId));
        }
        [HttpDelete("{id}")]
        public ActionResult<IReadOnlyList<ProductImage>> Delele(int id){
            return Ok(_imageQuery.DeletebyId(id));
        }
        [HttpPost("{productId}")]
        public async Task<ActionResult<int>> Delete(int productId, IFormFile file){
            var url =await _imageUpload.UpAsync(file);
            return Ok(_imageQuery.UploadImage(productId,url));
        }
        [HttpGet("Join")]
        public ActionResult<IReadOnlyList<ProductCateDto>>  Join(){
            return Ok(_imageQuery.MultiMapping());
        }
    }
}