using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3T4GunelAbdulmajidLibrary.Application.DTOs
{
    public class UserDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone {  get; set; }
        public List<UserBookDto> UserBooks { get; set; } = new();
    }

    public class UserCreateDto
    {
        public required string Name {  get; set; }
        public required string Password {  get; set; }
        public string Email { get; set; }
        public required string Phone { get; set; }
        public List<int> UserBooks { get; set; } = new();
    }

    public class UserUpdateDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public List<int> ReturnedBookIds { get; set; } = new();
        public List<int> BorrowedBookIds { get; set; } = new();

    }
}
