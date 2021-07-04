using Models.Ado.Library;
using Models.Dtos;
using Ado.Library.Specifics;
using Business.BookStoreServices.Abstracts;
using Core.Services.Abstracts;
using System.Collections.Generic;
using System;
using Ado.Library;

namespace Business.BookStoreServices.Specifics
{
    public class CouponService : ServiceMapperBase<CouponDto, Coupon>, ICouponService
    {
        readonly new ICouponRepository _repository;
        public CouponService(ICouponRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public IEnumerable<CouponDto> GetByDate(DateTime createTime)
        {
            IEnumerable<Coupon> result = _repository.GetByDate(createTime);
            return mapper.Map<IEnumerable<CouponDto>>(result);
        }

        public IEnumerable<CouponDto> GetByDate(DateTime createTime, int pag, int element)
        {
            IEnumerable<Coupon> result = _repository.GetByDate(createTime,pag,element);
            return mapper.Map<IEnumerable<CouponDto>>(result);
        }

        public IEnumerable<CouponDto> GetBySale(string IdSale)
        {
            IEnumerable<Coupon> result = _repository.GetBySale(IdSale);
            return mapper.Map<IEnumerable<CouponDto>>(result);
        }

        public IEnumerable<CouponDto> GetBySale(string IdSale, int pag, int element)
        {
            IEnumerable<Coupon> result = _repository.GetBySale(IdSale,pag,element);
            return mapper.Map<IEnumerable<CouponDto>>(result);
        }

        public IEnumerable<CouponDto> GetFinalized()
        {
            IEnumerable<Coupon> result = _repository.GetFinalized();
            return mapper.Map<IEnumerable<CouponDto>>(result);
        }

        public IEnumerable<CouponDto> GetFinalized(int pag, int element)
        {
            IEnumerable<Coupon> result = _repository.GetFinalized(pag,element);
            return mapper.Map<IEnumerable<CouponDto>>(result);
        }

        public IEnumerable<CouponDto> GetNotFinalized()
        {
            IEnumerable<Coupon> result = _repository.GetNotFinalized();
            return mapper.Map<IEnumerable<CouponDto>>(result);
        }

        public IEnumerable<CouponDto> GetNotFinalized(int pag, int element)
        {
            IEnumerable<Coupon> result = _repository.GetNotFinalized(pag,element);
            return mapper.Map<IEnumerable<CouponDto>>(result);
        }
    }
}
