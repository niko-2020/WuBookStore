﻿using Microsoft.EntityFrameworkCore;
using CRWBookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRWBookStore.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {       
        
        }

        public DbSet<BookModel> Book { get; set; }
        public DbSet<CustomerModel> customers { get; set; }
        //public DbSet<PriceModel> Price { get; set; }
    }
}
