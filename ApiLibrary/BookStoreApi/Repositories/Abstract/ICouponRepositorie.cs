using BookStoreApi.Models.Library;
using LibraryApiRest.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApi.Repositories.Abstract.Coupons
{
    interface ICouponRepositorie : IRepositorie<Coupon>
    {
        List<Coupon>GetBySale(string IdSale);
        List<Coupon> GetBySale(string IdSale,int pag,int element);
        List<Coupon> GetByDate(DateTime createTime);
        List<Coupon> GetByDate(DateTime createTime,int pag,int element);
        List<Coupon> GetNotFinalized();
        List<Coupon> GetNotFinalized(int pag,int element);
        List<Coupon> GetFinalized();
        List<Coupon> GetFinalized(int pag,int element);
    }
}
