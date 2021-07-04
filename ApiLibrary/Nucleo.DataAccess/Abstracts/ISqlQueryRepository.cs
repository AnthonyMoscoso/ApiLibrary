using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.Abstracts
{
    public interface ISqlQueryRepository
    {
        void ExecuteQuery(string query);
        void Dispose();
    }
}
