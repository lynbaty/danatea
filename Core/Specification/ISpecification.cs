using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.Specification
{
    public interface ISpecification<T>
    {
        Expression<Func<T,bool>> Criteria {get;}
        
        List<Expression<Func<T,Object>>> Includes {get;}
        Expression<Func<T,Object>> Orderby {get;}
        Expression<Func<T,Object>> OrderbyDesc {get; }
        Expression<Func<T,bool>> Ladder {get; }
        Expression<Func<T,bool>> Search {get; }
    }

}