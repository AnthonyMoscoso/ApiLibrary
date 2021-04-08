﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApiRest.Repositories.Abstract
{
    interface IRepository<T>
    {
        dynamic Get();
        dynamic Get(string id);
        dynamic GetList(string ids);
        dynamic Get(int elements,int pag);
        dynamic Insert(List<T> list);
        dynamic Update(List<T> list);
        dynamic Insert(T entity);
        dynamic Delete(List<string> id);       
        dynamic Save();
    }
}