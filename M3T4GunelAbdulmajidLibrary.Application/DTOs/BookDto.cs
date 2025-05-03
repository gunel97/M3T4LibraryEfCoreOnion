using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3T4GunelAbdulmajidLibrary.Application.DTOs
{
    public class BookDto
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int Year { get; set; }
        public int PageCount { get; set; }
        public string? AuthorName { get; set; }
    }
    public class BookCreateDto
    {
        public required string Title { get; set; }
        public required int Year { get; set; }
        public required int PageCount { get; set; }
        public required int AuthorId { get; set; }
    }
    public class BookUpdateDto
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required int Year { get; set; }
        public required int PageCount { get; set; }
        public int AuthorId { get; set; }
    }
}
