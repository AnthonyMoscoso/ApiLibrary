using BookStoreApi.Models.Library;
using LibraryApiRest.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApi.Repositories.Abstract.Files
{
    interface IImageFileRepositorie : IRepository<ImageFile>
    {
       new dynamic Delete(List<string> ids);
    }
}
