﻿using CRWBookStore.Data;
using System.Linq;

namespace CRWBookStore.Models
{
    public class EFStoreRepository : IStoreRepository
    {
        private DataContext context;
        public EFStoreRepository(DataContext ctx)
        {
            context = ctx;
        }
        public IQueryable<BookModel> Books => context.Book;
    }

}
