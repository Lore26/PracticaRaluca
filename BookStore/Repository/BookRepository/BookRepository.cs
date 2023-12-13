using BookStore.Data;
using BookStore.Entities;
using Dapper;
using System.Data;

namespace BookStore.Repository.BookRepository
{
    public class BookRepository:IBookRepository
    {
        private readonly BookStoreContext _context;
        public BookRepository(BookStoreContext context)
        {
            _context = context;
        }
        public async Task<List<Book>> GetBooks()
        {
            string query = "select * from Book";
            using (var connection = _context.CreateConnection())
            {
                var book = await connection.QueryAsync<Book>(query);
                return book.ToList();
            }
        }
        public async Task<Boolean> AddBook(Book book)
        {
            Boolean response = false;
            string query = "insert into Book(id,title,author_id,category_id,page_number,description,availability,release_date,review_id) values (@id,@title,@author_id,@category_id,@page_number,@description,@availability,@release_date,@review_id)";
            var parameters = new DynamicParameters();
            parameters.Add("id", book.id, DbType.Int32);
            parameters.Add("title", book.title, DbType.String);
            parameters.Add("author_id", book.author_id, DbType.Int32);
            parameters.Add("category_id", book.category_id, DbType.Int32);
            parameters.Add("page_number", book.page_number, DbType.Int32);
            parameters.Add("description", book.description, DbType.String);
            parameters.Add("availability", book.availability, DbType.Int32);
            parameters.Add("release_date", book.release_date, DbType.Date);
            parameters.Add("review_id", book.review_id, DbType.Int32);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
                response = true;
            }
            return response;
        }
        public async Task<Boolean> EditBook(Book book, int id)
        {
            Boolean response = false;
            string query = "update Book set title=@title,author_id=@author_id,category_id=@category_id,page_number=@page_number,description=@description,availability=@availability,release_date=@release_date,review_id=@review_id where id=@id";
            var parameters = new DynamicParameters();
            parameters.Add("id", id, DbType.Int32);
            parameters.Add("title", book.title, DbType.String);
            parameters.Add("author_id", book.author_id, DbType.Int32);
            parameters.Add("category_id", book.category_id, DbType.Int32);
            parameters.Add("page_number", book.page_number, DbType.Int32);
            parameters.Add("description", book.description, DbType.String);
            parameters.Add("availability", book.availability, DbType.Int32);
            parameters.Add("release_date", book.release_date, DbType.Date);
            parameters.Add("review_id", book.review_id, DbType.Int32);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
                response = true;
            }
            return response;
        }
        public async Task<Boolean> DeleteBook(int id)
        {
            Boolean response = false;
            string query = "delete from Book where id=@id";
            using (var connection = _context.CreateConnection())
            {
                var book = await connection.ExecuteAsync(query, new { id });
                response = true;
            }
            return response;
        }
    }
}

