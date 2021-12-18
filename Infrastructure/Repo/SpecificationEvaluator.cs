using System.Linq;
using Core.Entities;
using Core.Specification;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repo
{
    public class SpecificationEvaluator<TEntity> where TEntity : BaseEntity
    {
        public static IQueryable<TEntity> GetQuery (IQueryable<TEntity> inputQuery, ISpecification<TEntity> spec){
            
            var query = inputQuery;

            if(spec.Criteria != null)
            {
                query = query.Where(spec.Criteria);
            }
            if(spec.Includes.Count > 0)
            {
                foreach(var inclu in spec.Includes){
                    query = query.Include(inclu);
                }
            }
            if(spec.Orderby != null)
            {
                query = query.OrderBy(spec.Orderby);
            }
            if(spec.OrderbyDesc != null)
            {
                query = query.OrderByDescending(spec.OrderbyDesc);
            }
            if(spec.Ladder != null)
            {
                query = query.Where(spec.Ladder);
            }
             if(spec.Search != null)
            {
                query = query.Where(spec.Search);
            }
            return query;
        }
    }
}