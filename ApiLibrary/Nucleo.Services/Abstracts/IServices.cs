using System.Collections.Generic;

namespace Core.Services.Abstracts
{
    public interface IServices<T>
    {
        int Count();       
        T Get(string id);
        IEnumerable<T> Get();
        IEnumerable<T> GetList(string ids);
        IEnumerable<T> Get(int pag, int element);     
        dynamic Insert(T entity);
        dynamic Insert(IEnumerable<T> list);
        dynamic Update(T entity);
        dynamic Update(IEnumerable<T> list);
        dynamic Delete(string id);
        dynamic Delete(IEnumerable<string> ids);

    }
}
