using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Products.Queries;
using AutoMapper;
using Core.Entities.Store;
using Core.Interfaces;
using Core.Specification;
using Dtos.Store;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    
    public class ProductController : BaseController
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public ProductController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }
        [HttpGet]
        
        public async Task<ActionResult<IReadOnlyList<Product>>> GetAll()
        {
            var rs =await _mediator.Send(new GetProductQuery());
            return Ok(_mapper.Map<IReadOnlyList<ProductDto>>(rs));
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetbyId(int id)
        {
            var rs = await _mediator.Send(new GetProductbyIdQuery(id));
            return Ok(_mapper.Map<ProductDto>(rs));
        }
    }
}