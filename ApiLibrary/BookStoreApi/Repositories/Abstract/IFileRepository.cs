using BookStoreApi.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApi.Utilities
{
    interface IFileRepository
    {
        dynamic Upload();
        dynamic DownLoad(int type,string dir,string name);
        dynamic Delete(int type, string dir, string name,string format);
    }
}
