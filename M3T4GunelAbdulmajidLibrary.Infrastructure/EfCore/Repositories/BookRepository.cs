using M3T4GunelAbdulmajidLibrary.Domain.Entities;
using M3T4GunelAbdulmajidLibrary.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3T4GunelAbdulmajidLibrary.Infrastructure.EfCore.Repositories
{
    public class BookRepository:EfCoreRepository<Book>, IBookRepository
    {
        public BookRepository():base() { }
    }
}
