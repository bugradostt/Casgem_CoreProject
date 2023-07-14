using Microsoft.EntityFrameworkCore;
using PizzaPan.DataAccessLayer.Abstract;
using PizzaPan.DataAccessLayer.Concrete;
using PizzaPan.DataAccessLayer.Repositories;
using PizzaPan.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPan.DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepositoriy<Product>, IProductDal
    {
        public List<Product> GetProductsWithCategory()
        {
            using var c = new Context();
            return c.Products.Include(x => x.Category).ToList();
        }
    }
}
