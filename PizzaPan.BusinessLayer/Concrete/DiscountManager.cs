﻿using PizzaPan.BusinessLayer.Abstract;
using PizzaPan.DataAccessLayer.Abstract;
using PizzaPan.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPan.BusinessLayer.Concrete
{
    public class DiscountManager : IDiscountService
    {

        readonly IDiscountDal _discountDal;
       public DiscountManager(IDiscountDal discountDal)
        {
            _discountDal = discountDal;
        }
        public void TDelete(Discount t)
        {
            _discountDal.Delete(t);
        }

        public Discount TGetById(int id)
        {
            return _discountDal.GetById(id);
        }

        public List<Discount> TGetList()
        {
            return _discountDal.GetList();
        }

        public void TInsert(Discount t)
        {
            _discountDal.Insert(t);
        }

        public void TUpdate(Discount t)
        {
            _discountDal.Update(t);
        }
    }
}
