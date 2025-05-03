namespace M3T4GunelAbdulmajidLibrary.Domain.Entities
{
    public class UserBook:Entity
    {
        public int UserId { get; set; }
        public int BookId { get; set; }
        public User User { get; set; }
        public Book Book { get; set; }
       
    }
}
