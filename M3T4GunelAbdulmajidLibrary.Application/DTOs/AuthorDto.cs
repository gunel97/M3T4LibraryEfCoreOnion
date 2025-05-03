using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3T4GunelAbdulmajidLibrary.Application.DTOs
{
    public class AuthorDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<BookDto> Books { get; set; } = new();
    }
    public class AuthorCreateDto
    {
        public required string Name { get; set; }
    }
    public class AuthorUpdateDto
    {
        public int Id { get; set; }
        public required string Name { get; set; }
    }
}
