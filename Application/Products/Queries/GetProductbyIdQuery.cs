using Core.Entities.Store;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Products.Queries
{
    public record GetProductbyIdQuery(int Id) : IRequest<Product>;
}
