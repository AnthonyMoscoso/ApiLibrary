using Models.Dtos;
using Nucleo.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.BookStoreServices.Abstracts
{
    public interface ICouponService : IServices<CouponDto>
    {
        IEnumerable<CouponDto> GetBySale(string IdSale);
        IEnumerable<CouponDto> GetBySale(string IdSale, int pag, int element);
        IEnumerable<CouponDto> GetByDate(DateTime createTime);
        IEnumerable<CouponDto> GetByDate(DateTime createTime, int pag, int element);
        IEnumerable<CouponDto> GetNotFinalized();
        IEnumerable<CouponDto> GetNotFinalized(int pag, int element);
        IEnumerable<CouponDto> GetFinalized();
        IEnumerable<CouponDto> GetFinalized(int pag, int element);
    }
}
