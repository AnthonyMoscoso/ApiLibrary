using Models.Ado.Library;
using System.Collections.Generic;
using Nucleo.DBAccess.Ado;

namespace Ado.Library
{
    public interface IDocumentFileRepositorie : IRepository<DocumentFile>
    {
        new dynamic Delete (List <string> ids );

    }
}
