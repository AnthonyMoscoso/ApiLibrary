using Nucleo.Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Nucleo.DBAccess.Ado
{
    public interface IRepository<T>
    {
        int Count();
        int Count(Expression<Func<T,bool>> predicate);
        IEnumerable<T> Get();
        IEnumerable<T> GetList(string ids);
        IEnumerable<T> Get(int elements, int pag);
        IEnumerable<T> Get(Expression<Func<T, bool>> predicate);
        T Get(string id);
        T GetSingle(Expression<Func<T, bool>> predicate);
        dynamic Insert(IEnumerable<T> list);
        dynamic Update(IEnumerable<T> list);
        dynamic Update(T entity);
        dynamic Insert(T entity);
        dynamic Delete(IEnumerable<string> id);
        dynamic Delete(string id);
        dynamic Save(string text = null, MessageCode Code = MessageCode.error, MessageType type = MessageType.Exception);
        dynamic SqlQuery(string query);
        void Dispose();
    }
}
