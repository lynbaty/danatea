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
    class GetProductHandler : IRequestHandler<GetProductQuery, IReadOnlyList<Product>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetProductHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IReadOnlyList<Product>> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            var spec = new ProductWithCategorySpecification("dateCreated");
            return await _unitOfWork.Repository<Product>().GetAllSpecAsync(spec);
        }
    }
}
