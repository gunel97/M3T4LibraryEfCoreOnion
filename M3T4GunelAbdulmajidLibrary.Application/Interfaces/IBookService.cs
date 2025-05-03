using M3T4GunelAbdulmajidLibrary.Application.DTOs;
using M3T4GunelAbdulmajidLibrary.Domain.Entities;

namespace M3T4GunelAbdulmajidLibrary.Application.Interfaces
{
    public interface IBookService : ICrudService<Book, BookDto, BookCreateDto, BookUpdateDto>
    {
    }
}
