﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PizzaPan.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPan.DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser,AppRole,int>
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=BUDOTEKNO\\SQLEXPRESS; initial catalog=Casgem_CoreProject; integrated security=true");

        }

        public DbSet<Category> Categories { get; private set; }
        public DbSet<Contact> Contacts { get; private set; }
        public DbSet<Product> Products { get; private set; }
        public DbSet<Testimonial> Testimonials { get; private set; }
        public DbSet<Discount> Discounts { get; private set; }
        public DbSet<ProductImage> ProductImages { get; private set; }
        public DbSet<OurTeam> OurTeams{ get; private set; }
        public DbSet<About> Abouts{ get; private set; }
        public DbSet<ContactInfo> ContactInfos{ get; private set; }

    }
}
