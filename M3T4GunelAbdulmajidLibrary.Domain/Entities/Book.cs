namespace M3T4GunelAbdulmajidLibrary.Domain.Entities
{
    public class Book : Entity
    {
        public required string Title { get; set; }
        public required int Year { get; set; }
        public required int PageCount { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public List<UserBook> UserBooks = new();
    }
}
