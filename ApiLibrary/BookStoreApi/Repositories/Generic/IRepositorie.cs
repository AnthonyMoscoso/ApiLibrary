using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApiRest.Repositories.Abstract
{
    interface IRepositorie<T>
    {
        dynamic Get();
        dynamic Get(List<string>ids);
        dynamic Get(int elements,int page);
        dynamic Update(List<T> list);
        dynamic Insert(List<T> list);
        dynamic Insert(T entity);
        dynamic Delete(List<string> id);       
        dynamic Save();
    }
}
