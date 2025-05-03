using M3T4GunelAbdulmajidLibrary.Application.DTOs;
using M3T4GunelAbdulmajidLibrary.Application.Interfaces;
using M3T4GunelAbdulmajidLibrary.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3T4GunelAbdulmajidLibrary.Application.Services
{
    public class BookManager : CrudManager<Book, BookDto, BookCreateDto, BookUpdateDto>, IBookService
    {
    }
}
