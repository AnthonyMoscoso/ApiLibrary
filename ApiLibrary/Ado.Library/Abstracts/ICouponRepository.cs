using Models.Ado.Library;
using Models.Dtos;
using System;
using System.Collections.Generic;
using Nucleo.DBAccess.Ado;

namespace Ado.Library
{
    public interface ICouponRepository : IRepository<Coupon>
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
