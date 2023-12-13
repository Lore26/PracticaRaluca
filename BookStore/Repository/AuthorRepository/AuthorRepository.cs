using BookStore.Data;
using BookStore.Entities;
using Dapper;
using System.Data;

namespace BookStore.Repository.AuthorRepository
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly BookStoreContext _context;
        public AuthorRepository(BookStoreContext context)
        {
            _context = context;
        }
        public async Task<List<Author>> GetAuthors()
        {
            string query = "select * from Author";
            using (var connection = _context.CreateConnection())
            {
                var author = await connection.QueryAsync<Author>(query);
                return author.ToList();
            }
        }
        public async Task<Boolean> AddAuthor(Author author)
        {
            Boolean response = false;
            string query = "insert into Author(id,author_name) values (@id,@author_name)";
            var parameters = new DynamicParameters();
            parameters.Add("id", author.id, DbType.Int32);
            parameters.Add("author_name", author.author_name, DbType.String);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
                response = true;
            }
            return response;
        }
        public async Task<Boolean> DeleteAuthor(int id)
        {
            Boolean response = false;
            string query = "delete from Author where id=@id";
            using (var connection = _context.CreateConnection())
            {
                var author = await connection.ExecuteAsync(query, new { id });
                response = true;
            }
            return response;
        }
    }
}
