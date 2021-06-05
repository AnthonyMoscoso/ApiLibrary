using Models.Ado.Library;
using Models.Dtos;
using Ado.Library.Specifics;
using Negocios.BookStoreServices.Abstracts;
using Nucleo.Services.Abstracts;
using System.Collections.Generic;
using System;

namespace Negocios.BookStoreServices.Specifics
{
    public class CouponService : ServiceMapperBase<CouponDto, Coupon>, ICouponService
    {
        public CouponService(CouponRepository repository) : base(repository)
        {
        }

        public IEnumerable<CouponDto> GetByDate(DateTime createTime)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CouponDto> GetByDate(DateTime createTime, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CouponDto> GetBySale(string IdSale)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CouponDto> GetBySale(string IdSale, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CouponDto> GetFinalized()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CouponDto> GetFinalized(int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CouponDto> GetNotFinalized()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CouponDto> GetNotFinalized(int pag, int element)
        {
            throw new NotImplementedException();
        }
    }
}
