namespace M3T4GunelAbdulmajidLibrary.Domain.Entities
{
    public class User:Entity
    {
        public required string Name { get; set; }
        public required string Password { get; set; }
        public string Email { get; set; } = null!;
        public required string Phone { get; set; }
        public List<UserBook> UserBooks { get; set; } = new();
    }
}
