using Models.Dtos;
using System;
using Models.Ado.Library;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Ado.Library;
using Nucleo.DBAccess.Ado;

namespace Models.Repositories.Concrect.Coupons
{
    public class CouponRepository : Repository<Coupon,CouponDto>, ICouponRepository
    {
        public CouponRepository(string identificator="IdCoupon") : base(identificator)
        {
        }

        public List<CouponDto> GetByDate(DateTime createTime)
        {

            var list = dbSet.Where(w => DbFunctions.TruncateTime(w.CreateDate) == DbFunctions.TruncateTime( createTime)).ToList();
            return mapper.Map<List<CouponDto>>(list);
        }

        public List<CouponDto> GetByDate(DateTime createTime, int pag, int element)
        {
            DateTime tomorrow = createTime.AddDays(1);
            var list = dbSet.Where(w => DbFunctions.TruncateTime( w.CreateDate) == DbFunctions.TruncateTime( createTime.Date))
                .OrderByDescending(w => w.CreateDate)
                .Skip((pag-1)*element).Take(element)
                .ToList();

            return mapper.Map<List<CouponDto>>(list);
        }

        public List<CouponDto> GetBySale(string IdSale)
        {
            var list = dbSet.Where(w => w.Sale.Any(s => s.IdSale.Equals(IdSale))).ToList();
            return mapper.Map<List<CouponDto>>(list);
        }

        public List<CouponDto> GetBySale(string IdSale, int pag, int element)
        {
            var list = dbSet.Where(w => w.Sale.Any(s => s.IdSale.Equals(IdSale)))
                .OrderByDescending(w=>w.CreateDate)
                .Skip((pag - 1) * element).Take(element)
                .ToList();
            return mapper.Map<List<CouponDto>>(list);
        }

        public List<CouponDto> GetFinalized()
        {
            var list = dbSet.
                Where(x =>x.FinishOffert.Value <= DateTime.Now)
                .ToList();

            return mapper.Map<List<CouponDto>>(list);
        }

        public List<CouponDto> GetFinalized(int pag, int element)
        {
            var list = dbSet.Where(w => w.FinishOffert<= DateTime.Now)
                .OrderByDescending(w => w.CreateDate)
                .Skip((pag - 1) * element).Take(element)
                .ToList();
            return mapper.Map<List<CouponDto>>(list);
        }

        public List<CouponDto> GetNotFinalized()
        {
            var list = dbSet.Where(w => w.FinishOffert.Value > DateTime.Now || !w.FinishOffert.HasValue).ToList();
            return mapper.Map<List<CouponDto>>(list);
        }

        public List<CouponDto> GetNotFinalized(int pag, int element)
        {
            var list= dbSet.Where(w => w.FinishOffert.Value > DateTime.Now || !w.FinishOffert.HasValue)
                .OrderByDescending(w=> w.CreateDate)
                .Skip((pag - 1) * element).Take(element)
                .ToList();
            return mapper.Map<List<CouponDto>>(list);
        }
    }
}