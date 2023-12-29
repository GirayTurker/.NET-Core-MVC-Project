using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bulk.DataAccess.Repository.IRepository
{
    //Repository Interface for CRUD operations. Generic,class base  
    public interface IRepository <T> where T : class
    {
        // T- Category 
        // Retrieve all DbContext categories  
        IEnumerable<T> GetAll ();
        //Retrieve selected DbContext Category by (Id,Name,etc)
        T Get(Expression<Func<T, bool>> filter);
        //Add in DbContext
        void Add (T entity);
        //Remove single from DbContext
        void Remove (T entity);
        //Remove multiple from DbContext
        void RemoveRange(IEnumerable<T> entities);
        // Update is not added for avoid conflicts. There are many scenarios to update DbContext
    }
}
