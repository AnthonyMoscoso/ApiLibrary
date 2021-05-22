using Ado.Library;
using Models.Ado.Library;
using Models.Dtos;
using Models.Repositories.Abstract;
using Nucleo.DBAccess.Ado;

namespace Models.Repositories.Concrect.BarCodes
{
    public class BarCodeRepository : Repository<Barcode,BarCodeDto>, IBarCodeRepository
    {
        public BarCodeRepository(string identificator= "IdBarcode") : base(identificator)
        {
        }
    }
}