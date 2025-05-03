namespace M3T4GunelAbdulmajidLibrary.Domain.Entities
{
    public class Author : Entity
    {
        public required string Name { get; set; }
        public List<Book> Books = new();
    }
}
