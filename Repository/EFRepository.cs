using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Domain;
using DBMapping;
using System.Data;
using System.Data.Entity;
using Settings;
using System.Web.Mvc;

namespace Repository
{
    public class EFRepository<T> : IRepository<T> where T : class
    {
        private readonly DbDealer _context;
        private IDbSet<T> _entities;

        public EFRepository(DbDealer _context)
        {
            this._context = _context;
        }
        public T GetById(int id)
        {
            return this._entities.Find(id);
        }
        //public T GetById(object id)
        //{
        //    return this._entities.Find(id);
        //}
        public IList<T> FetchAll()
        {
            return FetchAl().ToList();

        }
        public IQueryable<T> FetchAl()
        {
            return _context.Set<T>();

        }
        public IList<T> FetchAllStates()
        {
            return Fetchstates().ToList();
        }
        public IQueryable<T> Fetchstates()
        {
            return _context.Set<T>();
        }
       
        public IList<T> FetchAllByID(Expression<Func<T, bool>> exp)
        {
            return GetAll(exp).ToList();
        }
        public IQueryable<T> GetAll(Expression<Func<T, bool>> exp)
        {
            return _context.Set<T>().Where(exp);
        }

        public void Insert(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            this.Entities.Add(entity);
            this._context.SaveChanges();


        }
        public void Update(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            //_entities.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            this._context.SaveChanges();
            
            
        }
        public void Delete(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            this._entities.Remove(entity);
            this._context.SaveChanges();
        }
        public virtual IQueryable<T> Table
        {
            get
            {
                return this.Entities;
            }
        }

        private IDbSet<T> Entities
        {
            get
            {
                if (_entities == null)
                    _entities = _context.Set<T>();
                return _entities;
            }
        }


    }
}
