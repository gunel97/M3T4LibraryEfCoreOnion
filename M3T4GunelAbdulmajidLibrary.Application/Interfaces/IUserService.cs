using M3T4GunelAbdulmajidLibrary.Application.DTOs;
using M3T4GunelAbdulmajidLibrary.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3T4GunelAbdulmajidLibrary.Application.Interfaces
{
    public interface IUserService:ICrudService<User, UserDto, UserCreateDto, UserUpdateDto>
    {
    }
}
