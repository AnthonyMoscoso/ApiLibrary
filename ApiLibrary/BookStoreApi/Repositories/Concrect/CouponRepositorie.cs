using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Coupons;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.Coupons
{
    public class CouponRepositorie : Repositorie<Coupon>, ICouponRepositorie
    {
        public CouponRepositorie(string identificator="IdCoupon") : base(identificator)
        {
        }

        public List<Coupon> GetByDate(DateTime createTime)
        {
            var list = dbSet.Where(w => w.CreateDate.Date== createTime.Date).ToList();
            return list;
        }

        public List<Coupon> GetByDate(DateTime createTime, int pag, int element)
        {
            return dbSet.Where(w => w.CreateDate.Date == createTime.Date)
                .OrderByDescending(w => w.CreateDate)
                .Skip((pag-1)*element).Take(element)
                .ToList();
        }

        public List<Coupon> GetBySale(string IdSale)
        {
            var list = dbSet.Where(w => w.Sale.Any(s => s.IdSale.Equals(IdSale))).ToList();
            return list;
        }

        public List<Coupon> GetBySale(string IdSale, int pag, int element)
        {
            return dbSet.Where(w => w.Sale.Any(s => s.IdSale.Equals(IdSale)))
                .OrderByDescending(w=>w.CreateDate)
                .Skip((pag - 1) * element).Take(element)
                .ToList();
        }

        public List<Coupon> GetFinalized()
        {
            return dbSet.Where(w => w.FinishOffert.Value <= DateTime.Now.Date).ToList();
        }

        public List<Coupon> GetFinalized(int pag, int element)
        {
            return dbSet.Where(w => w.FinishOffert.Value <= DateTime.Now.Date)
                .OrderByDescending(w => w.CreateDate)
                .Skip((pag - 1) * element).Take(element)
                .ToList();
        }

        public List<Coupon> GetNotFinalized()
        {
            var list = dbSet.Where(w => w.FinishOffert.Value > DateTime.Now).ToList();
            return list;
        }

        public List<Coupon> GetNotFinalized(int pag, int element)
        {
            return dbSet.Where(w => w.FinishOffert.Value > DateTime.Now)
                .OrderByDescending(w=> w.CreateDate)
                .Skip((pag - 1) * element).Take(element)
                .ToList();
        }
    }
}