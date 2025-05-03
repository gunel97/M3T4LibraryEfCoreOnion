using M3T4GunelAbdulmajidLibrary.Application.DTOs;
using M3T4GunelAbdulmajidLibrary.Application.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.Json;

namespace M3Task4GunelAbdulmajidLibrary.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bookService = new BookManager();
            var userService = new UserManager();
            var authorService = new AuthorManager();

            #region user
            ////add user
            //var userCreateDto = new UserCreateDto
            //{
            //    Name = "userTest",
            //    Email = "user1email",
            //    Password = "user1pass",
            //    Phone = "123456",
            //};
            // userService.Add(userCreateDto);

            ////******UPDATE USER BORROW AND RETURN BOOK
            //var user=userService.Get(x=>x.Id==2, include: x=>x.Include(b=>b.UserBooks));

            //var userUpdateDto = new UserUpdateDto
            //{
            //    Id = user.Id,
            //    Name="update",
            //    Email="updatedEmail",
            //    Phone="update",
            //    ReturnedBookIds = new List<int> { 2 },
            //    BorrowedBookIds = new List<int> { 1 },
            //};

            //userService.Update(userUpdateDto);

            ////******** BORROW AND RETURN ONE BOOK
            //userService.BorrowBook(2,2);
            //userService.ReturnBook(4, 4);

            #endregion

            #region author
            ////*******ADD AUTHOR

            //var authorCreateDto = new AuthorCreateDto
            //{
            //    Name = "Antoine Exupery",
            //};

            //authorService.Add(authorCreateDto);

            ////******UPDATE AUTHOR
            //var authorUpdateDto = new AuthorUpdateDto
            //{
            //    Id = 3,
            //    Name = "Erich Fromm"
            //};


            ////*********DELETE AUTHOR
            //authorService.Delete(4);

            ////*******GETALL AUTHORS
            //var authors = authorService.GetAll();
            //foreach (var author in authors)
            //{
            //    Console.WriteLine(author.Id + " " + author.Name);
            //}
            #endregion

            #region book
            ////********ADD BOOK

            //var bookCreateDto = new BookCreateDto
            //{
            //    Title = "The Little Prince",
            //    Year = 1943,
            //    PageCount = 150,
            //    AuthorId = 2
            //};

            //bookService.Add(bookCreateDto);

            ////******UPDATE BOOK
            //var bookUpdateDto = new BookUpdateDto
            //{
            //    Id = 3,
            //    Title = "updated",
            //    Year = 2000,
            //    PageCount = 300,
            //    AuthorId = 1,
            //};

            //bookService.Update(bookUpdateDto);

            ////*******DELETE BOOK
            //bookService.Delete(3);
            #endregion
        }
    }
}
