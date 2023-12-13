using BookStore.Entities;
using System.Net.Sockets;

namespace BookStore.Services.AuthorSerice
{
    public interface IAuthorService
    {
        Task<List<Author>> GetAuthors();
        Task<Boolean> AddAuthor(Author author);
        Task<Boolean> DeleteAuthor(int id);
    }
}