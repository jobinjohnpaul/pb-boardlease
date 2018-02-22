using PBBoardLeaseCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PBBoardLeaseCalculator.Repositories
{
    public interface IRepository<T> where T:BaseEntity
    {
        IEnumerable<T> Get(
                Expression<Func<T, bool>> filter = null,
                Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                string includeProperties = "");
        T GetByID(object Id);
        void Insert(T entity);
        void Delete(object ID);
        void Update(T entity);
        void Save();
    }
}
