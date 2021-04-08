using BookStoreApi.Dtos;
using BookStoreApi.Models.Library;
using LibraryApiRest.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApi.Repositories.Abstract.Coupons
{
    interface ICouponRepositorie : IRepository<Coupon>
    {
        List<CouponDto>GetBySale(string IdSale);
        List<CouponDto> GetBySale(string IdSale,int pag,int element);
        List<CouponDto> GetByDate(DateTime createTime);
        List<CouponDto> GetByDate(DateTime createTime,int pag,int element);
        List<CouponDto> GetNotFinalized();
        List<CouponDto> GetNotFinalized(int pag,int element);
        List<CouponDto> GetFinalized();
        List<CouponDto> GetFinalized(int pag,int element);
    }
}
