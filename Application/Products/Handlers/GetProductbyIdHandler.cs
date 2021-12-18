using Application.Products.Queries;
using Core.Entities.Store;
using Core.Interfaces;
using Core.Specification;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Products.Handlers
{
    class GetProductbyIdHandler : IRequestHandler<GetProductbyIdQuery, Product>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetProductbyIdHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Product> Handle(GetProductbyIdQuery request, CancellationToken cancellationToken)
        {
            var spec = new ProductWithCategorySpecification(request.Id);
            return await _unitOfWork.Repository<Product>().GetbyIdSpecAsync(spec);
        }
    }
}
