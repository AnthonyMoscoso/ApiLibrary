using Models.Ado.Library;
using System.Collections.Generic;
using Nucleo.DBAccess.Ado;

namespace Ado.Library
{
    public interface IDocumentFileRepository : IRepository<DocumentFile>
    {
        new dynamic Delete (IEnumerable <string> ids );

    }
}
