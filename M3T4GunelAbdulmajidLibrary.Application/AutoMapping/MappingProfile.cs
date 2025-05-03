using AutoMapper;
using M3T4GunelAbdulmajidLibrary.Application.DTOs;
using M3T4GunelAbdulmajidLibrary.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3T4GunelAbdulmajidLibrary.Application.AutoMapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Author, AuthorDto>().ReverseMap();
            CreateMap<Author, AuthorCreateDto>().ReverseMap();
            CreateMap<Author, AuthorUpdateDto>().ReverseMap();


            CreateMap<Book, BookDto>().
                ForMember(x=>x.AuthorName, opt=>opt.MapFrom(src=>src.Author.Name))
                .ReverseMap();
            CreateMap<Book, BookCreateDto>().ReverseMap();
            CreateMap<Book,BookUpdateDto>().ReverseMap();

            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<User, UserCreateDto>().ReverseMap();
            CreateMap<User,UserUpdateDto>().ReverseMap();

            CreateMap<UserBook, UserBookDto>()
                .ForMember(x => x.UserName, opt => opt.MapFrom(src => src.User.Name))
                .ForMember(x => x.BookName, opt => opt.MapFrom(src => src.Book.Title))
                .ReverseMap();
        }
    }
}
