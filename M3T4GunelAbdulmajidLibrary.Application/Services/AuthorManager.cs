using M3T4GunelAbdulmajidLibrary.Application.DTOs;
using M3T4GunelAbdulmajidLibrary.Application.Interfaces;
using M3T4GunelAbdulmajidLibrary.Domain.Entities;

namespace M3T4GunelAbdulmajidLibrary.Application.Services
{
    public class AuthorManager : CrudManager<Author, AuthorDto,AuthorCreateDto, AuthorUpdateDto>, IAuthorService
    {
    }
}
