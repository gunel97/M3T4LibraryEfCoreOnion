using M3T4GunelAbdulmajidLibrary.Domain.Entities;
using M3T4GunelAbdulmajidLibrary.Domain.Interfaces;

namespace M3T4GunelAbdulmajidLibrary.Infrastructure.EfCore.Repositories
{
    public class UserBookRepository : EfCoreRepository<UserBook>, IUserBookRepository
    {
        public UserBookRepository() : base() { }
    }
}
