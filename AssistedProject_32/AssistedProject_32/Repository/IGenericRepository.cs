using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AssistedProject_32.Repository
{
    public interface IGenericRepository<t> where T : class
    {
        IEnumerable<t> SelectAll();
        T SelectByID(object id);
        void Insert(T obj);
        void Update(T obj);
        void Delete(object id);
        void Save();
    }
}
