using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bulk.DataAccess.Data;
using Bulk.DataAccess.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Bulk.DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        //Dependency Injection
        private readonly ApplicationDbContext _db;
        //Object-Relational mapping
        internal DbSet<T> dbSet;
        //Constractor
        public Repository(ApplicationDbContext db)
        {
            _db = db;
            this.dbSet = _db.Set<T>();//same as _db.Categories == dbSet (check in CategoryController.cs)
            
        }
        //Methods for CRUD operations
        //Update operation will handle in controller 
        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public IEnumerable<T> GetAll()
        {
            IQueryable<T> query = dbSet;
            return query.ToList();
        }

        public T Get(System.Linq.Expressions.Expression<Func<T, bool>> filter)
        {
            IQueryable<T> query = dbSet;
            query = query.Where(filter);
            return query.FirstOrDefault();
        }

        public void Remove(T entity)
        {
            dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            dbSet.RemoveRange(entities);
        }
    }
}
