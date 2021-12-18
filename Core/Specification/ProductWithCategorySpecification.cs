using System;
using System.Linq.Expressions;
using Core.Entities.Store;

namespace Core.Specification
{
    public class ProductWithCategorySpecification : BaseSpecification<Product>
    {
        public ProductWithCategorySpecification(string order) : base()
        {
            AddInclude(p => p.Category);
            AddInclude(p => p.ProductImages);
            switch (order)
            {
                case "price":
                AddOrderby(p => p.Price);
                break;
                case "priceDesc":
                AddOrderbyDesc(p => p.Price);
                break;
                case "name":
                AddOrderby(p => p.Name);
                break;
                case "dateCreated":
                AddOrderbyDesc(p => p.DateCreated);
                break;
                default:
                AddOrderby(p => p.Name);
                break;
            }
        }
        public ProductWithCategorySpecification(int id) : base(p => p.Id == id)
        {
            AddInclude(p => p.Category);
            AddInclude(p => p.ProductImages);
        }
    }
}