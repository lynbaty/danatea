using System.Collections.Generic;
using System.Threading.Tasks;
using API.Dtos.Store;
using AutoMapper;
using Core.Entities.Store;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class CategoryController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CategoryController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<Category>>> GetAll(){
            var rs = await _unitOfWork.Repository<Category>().GetAllAsync();
            return Ok(_mapper.Map<IReadOnlyList<CategoryDto>>(rs));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CategoryDto>> GetbyId(int id){
            var rs = await _unitOfWork.Repository<Category>().GetbyIdAsync(id);
            return Ok(_mapper.Map<CategoryDto>(rs));
        }
        
        [HttpPost]
        public async Task<ActionResult<Category>> Create(CategoryDto categoryDto){
            _unitOfWork.Repository<Category>().Add(_mapper.Map<Category>(categoryDto));
            var rs =await _unitOfWork.Complete();
            if(rs > 0) return Ok();
            return BadRequest();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id){
            var category =await _unitOfWork.Repository<Category>().GetbyIdAsync(id);
            _unitOfWork.Repository<Category>().Delete(category);
            await _unitOfWork.Complete();
            return Ok();
        }
        
        [HttpPut]
        public async Task<ActionResult<Category>> Update(CategoryDto categoryDto){
            _unitOfWork.Repository<Category>().Update(_mapper.Map<Category>(categoryDto));
            var rs = await _unitOfWork.Complete();
            if(rs > 0) return Ok(categoryDto);
            return BadRequest();
        }
    }
}