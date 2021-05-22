﻿using Models.Ado.Library;
using System.Collections.Generic;
using Nucleo.DBAccess.Ado;

namespace Ado.Library
{
    public interface IEditionRepositorie : IRepository<Edition>
    {
      List<Edition>  SearchByName(string text);

       List<Edition> SearchByName(string text,int pag,int element);
    }
}
