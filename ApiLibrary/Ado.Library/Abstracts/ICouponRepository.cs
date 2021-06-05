using Models.Ado.Library;
using Models.Dtos;
using System;
using System.Collections.Generic;
using Nucleo.DBAccess.Ado;

namespace Ado.Library
{
    public interface ICouponRepository : IRepository<Coupon>
    {
        IEnumerable<Coupon> GetBySale(string IdSale);
        IEnumerable<Coupon> GetBySale(string IdSale, int pag, int element);
        IEnumerable<Coupon> GetByDate(DateTime createTime);
        IEnumerable<Coupon> GetByDate(DateTime createTime, int pag, int element);
        IEnumerable<Coupon> GetNotFinalized();
        IEnumerable<Coupon> GetNotFinalized(int pag, int element);
        IEnumerable<Coupon> GetFinalized();
        IEnumerable<Coupon> GetFinalized(int pag, int element);
    }
}
