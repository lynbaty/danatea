using Core.Entities.Store;
using Dtos.Store;

namespace Core.Specification
{
    public class CategoryParentwithSearchSpecification : BaseSpecification<Category>
    {
        public CategoryParentwithSearchSpecification(CategoryRequestDto request) : base()
        {
            if(!request.ParentId.HasValue)
            {
                AddLadder(c => c.ParentId == null);
            }else
            {
                AddLadder(c => c.ParentId == request.ParentId);
            }
            if(request.Search != null)
            {
                AddSearch(c => c.Name.Contains(request.Search));
            }
        }
    }
}