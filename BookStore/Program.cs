using BookStore.Data;
using BookStore.Entities;
using BookStore.Repository.AuthorRepository;
using BookStore.Repository.BookRepository;
using BookStore.Repository.CategoryRepository;
using BookStore.Services.AuthorSerice;
using BookStore.Services.BookService;
using BookStore.Services.CategoryService;
using Dapper;
using Microsoft.Data.SqlClient;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<BookStoreContext>();
builder.Services.AddSingleton<IBookRepository, BookRepository>();
builder.Services.AddSingleton<IBookService,BookService>();
builder.Services.AddSingleton<IAuthorRepository, AuthorRepository>();
builder.Services.AddSingleton<IAuthorService, AuthorService>();
builder.Services.AddSingleton<ICategoryRepository, CategoryRepository>();
builder.Services.AddSingleton<ICategoryService, CategoryService>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();


app.Run();
