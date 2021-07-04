using Core.Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.DBAccess.Ado
{
    public interface IRepository<T>
    {
        int Count();
        int Count(Expression<Func<T,bool>> predicate);
        IEnumerable<T> Get();
        IEnumerable<T> Get(Expression<Func<T, bool>> predicate);
        IEnumerable<T> Get(int elements, int pag);
        IEnumerable<T> Get(Expression<Func<T, bool>> predicate, int pag, int element,string order);
        IEnumerable<T> GetOrderBy(string order);
        IEnumerable<T> GetOrderBy(int elements, int pag,string order);
        IEnumerable<T> GetOrderBy(Expression<Func<T,bool>> predicate,string order);
        T GetSingle(string id);
        T GetSingle(Expression<Func<T, bool>> predicate);
        dynamic Insert(IEnumerable<T> list);
        dynamic Update(IEnumerable<T> list);
        dynamic Update(T entity);
        dynamic Insert(T entity);
        dynamic Delete(IEnumerable<string> id);
        dynamic Delete(string id);
        dynamic Save(string text = null, MessageCode Code = MessageCode.information);       
    }
}
