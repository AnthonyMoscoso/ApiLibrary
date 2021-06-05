using Ado.Library;
using Models.Ado.Library;
using Models.Dtos;
using Models.Repositories.Abstract;
using Nucleo.DBAccess.Ado;

namespace Ado.Library.Specifics
{
    public class BarCodeRepository : Repository<Barcode>, IBarCodeRepository
    {
        public BarCodeRepository(BookStoreEntities context, string identificator= "IdBarcode") :
            base(context,identificator)
        {
        }
    }
}