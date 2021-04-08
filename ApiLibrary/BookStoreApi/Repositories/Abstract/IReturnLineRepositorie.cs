﻿using BookStoreApi.Models.Library;
using LibraryApiRest.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApi.Repositories.Abstract.Returns
{
    interface IReturnLineRepositorie : IRepository <ReturnLine>
    {
       List<ReturnLine> GetByReturn(string idReturn);
    }
}
