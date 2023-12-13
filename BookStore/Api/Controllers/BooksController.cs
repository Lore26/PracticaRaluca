using BookStore.Entities;
using BookStore.Services.BookService;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;
        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }
        [HttpGet("/GetBooks")]
        public async Task<IActionResult> GetBooks(){
            var books = await  _bookService.GetBooks();
            if (books != null)
            {
                return Ok(books);
            }
            else
            {
                return NotFound();
            }
        }
        [HttpPost("/AddBook")]
        public async Task<IActionResult> AddBook(Book newBook)
        {
            var book = await _bookService.AddBook(newBook);
            return Ok(book);
        }
        [HttpPut("/EditBook/{id}")]
        public async Task<IActionResult> EditBook(Book new_book, int id)
        {
            var book = await _bookService.EditBook(new_book,id);
            return Ok(book);
        }
        [HttpDelete("/DeleteBook/{id}")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            var book = await _bookService.DeleteBook(id);
            return Ok(book);
        }
    }
}