using Models.Dtos;
using System;
using Models.Ado.Library;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Ado.Library;
using Nucleo.DBAccess.Ado;

namespace Ado.Library.Specifics
{
    public class CouponRepository : Repository<Coupon>, ICouponRepository
    {
        public CouponRepository(BookStoreEntities context,string identificator="IdCoupon") : base(context,identificator)
        {
        }

        public IEnumerable<Coupon> GetByDate(DateTime createTime)
        {

            var IEnumerable = dbSet.Where(w => DbFunctions.TruncateTime(w.CreateDate) == DbFunctions.TruncateTime(createTime));
            return IEnumerable;
        }

        public IEnumerable<Coupon> GetByDate(DateTime createTime, int pag, int element)
        {
            IEnumerable<Coupon> search = dbSet.Where(w => DbFunctions.TruncateTime(w.CreateDate) == DbFunctions.TruncateTime(createTime.Date))
                .OrderByDescending(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element);

            return search;
        }

        public IEnumerable<Coupon> GetBySale(string IdSale)
        {
            IEnumerable<Coupon> search = dbSet.Where(w => w.Sale.Any(s => s.IdSale.Equals(IdSale)));
            return search;
        }

        public IEnumerable<Coupon> GetBySale(string IdSale, int pag, int element)
        {
            IEnumerable<Coupon> search = dbSet.Where(w => w.Sale.Any(s => s.IdSale.Equals(IdSale)))
                .OrderByDescending(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element);
            return search;
        }

        public IEnumerable<Coupon> GetFinalized()
        {
            IEnumerable<Coupon> search = dbSet.Where(x => x.FinishOffert.Value <= DateTime.Now);

            return search;
        }

        public IEnumerable<Coupon> GetFinalized(int pag, int element)
        {
            IEnumerable<Coupon> search = dbSet.Where(w => w.FinishOffert <= DateTime.Now)
                .OrderByDescending(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element);
            return search;
        }

        public IEnumerable<Coupon> GetNotFinalized()
        {
            IEnumerable<Coupon> search = dbSet.Where(w => w.FinishOffert.Value > DateTime.Now || !w.FinishOffert.HasValue);
            return search;
        }

        public IEnumerable<Coupon> GetNotFinalized(int pag, int element)
        {
            IEnumerable<Coupon> search = dbSet.Where(w => w.FinishOffert.Value > DateTime.Now || !w.FinishOffert.HasValue)
                .OrderByDescending(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element);
            return search;
        }
    }
}