using M3T4GunelAbdulmajidLibrary.Application.DTOs;
using M3T4GunelAbdulmajidLibrary.Application.Interfaces;
using M3T4GunelAbdulmajidLibrary.Domain.Entities;
using M3T4GunelAbdulmajidLibrary.Infrastructure.EfCore.Repositories;
using Microsoft.EntityFrameworkCore;

namespace M3T4GunelAbdulmajidLibrary.Application.Services
{
    public class UserManager : CrudManager<User, UserDto, UserCreateDto, UserUpdateDto>, IUserService
    {
        public void BorrowBook(int borrowedBookId, int userId)
        {
            var user = Repository.Get(x => x.Id == userId,
                include: x => x.Include(y => y.UserBooks));
            if (user == null)
                throw new InvalidOperationException("user not found");

            if (!user.UserBooks.Any(ub => ub.BookId == borrowedBookId))
            {
                user.UserBooks.Add(new UserBook
                {
                    BookId = borrowedBookId,
                });
            }

            Mapper.Map<UserDto>(Repository.Update(user));
        }

        public void ReturnBook(int returnedBookId, int userId)
        {
            var user = Repository.Get(x => x.Id == userId,
                    include: x => x.Include(y => y.UserBooks));
            if (user == null)
                throw new InvalidOperationException("user not found");

            user.UserBooks.RemoveAll(ub => returnedBookId==ub.BookId);

            var userBookRepository = new EfCoreRepository<UserBook>();
            var existBorrowedBook = userBookRepository
                .Get(x => x.BookId == returnedBookId && x.UserId == user.Id);
            if (existBorrowedBook != null)
            {
                userBookRepository.Delete(existBorrowedBook);
            }

            Mapper.Map<UserDto>(Repository.Update(user));
        }

        //public override UserDto Update(UserUpdateDto updateDto)
        //{
        //    var user = Repository.Get(x => x.Id == updateDto.Id,
        //        include: x => x.Include(y => y.UserBooks));
        //    if (user == null)
        //        throw new InvalidOperationException("user not found");

        //    user.Name = updateDto.Name;
        //    user.Email = updateDto.Email;
        //    user.Phone = updateDto.Phone;

        //    user.UserBooks.RemoveAll(ub => updateDto.ReturnedBookIds.Contains(ub.BookId));
        //    foreach (var bookId in updateDto.BorrowedBookIds)
        //    {
        //        if (!user.UserBooks.Any(ub => ub.BookId == bookId))
        //        {
        //            user.UserBooks.Add(new UserBook
        //            {
        //                BookId = bookId,
        //            });
        //        }
        //    }

        //    if (updateDto.ReturnedBookIds.Count > 0)
        //    {
        //        var userBookRepository = new EfCoreRepository<UserBook>();

        //        foreach (var item in updateDto.ReturnedBookIds)
        //        {
        //            var existBorrowedBook = userBookRepository
        //                .Get(x => x.BookId == item && x.UserId == updateDto.Id);
        //            if (existBorrowedBook != null)
        //            {
        //                userBookRepository.Delete(existBorrowedBook);
        //            }
        //        }
        //    }

        //    return Mapper.Map<UserDto>(Repository.Update(user));
        //}
    }
}
