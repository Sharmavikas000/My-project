using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Domain;
using System.Web.Mvc;


namespace Repository
{
    public interface IRepository<T> where T: class
    {
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        IList<T> FetchAll();
        IQueryable<T> FetchAl();
        T GetById(int id);

        
        //void BulkInsert(List<T> entities);
        //void BulkUpdate(List<T> entities);
        IQueryable<T> Table { get; }
        //void Delete(Expression<Func<T, bool>> exp);

    }
}
