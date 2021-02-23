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
    }
}