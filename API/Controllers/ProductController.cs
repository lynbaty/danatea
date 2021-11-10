using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities.Store;
using Core.Interfaces;
using Core.Specification;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    
    public class ProductController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IReadOnlyList<Product>>> GetAll()
        {
            var spec = new ProductWithCategorySpecification("nameDesc");
            var rs = await _unitOfWork.Repository<Product>().GetAllSpecAsync(spec);
            return Ok(rs);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetbyId(int id)
        {
            var spec = new ProductWithCategorySpecification(id);
            var rs = await _unitOfWork.Repository<Product>().GetbyIdSpecAsync(spec);
            return Ok(rs);
        }
    }
}