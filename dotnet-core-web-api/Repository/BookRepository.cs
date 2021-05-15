using AutoMapper;
using dotnet_core_web_api.Models;
using dotnet_core_web_api.ViewModels;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_core_web_api.Repository
{
	public class BookRepository : IBookRepository
	{
		private readonly BooksContext context;
		private readonly IMapper mapper;
		public BookRepository(BooksContext _context,IMapper _mapper) 
		{
			context = _context;
			mapper = _mapper;
		}
		public async Task<List<BookModel>> GetBooks() 
		{
			var records = await context.Books.ToListAsync();
			return mapper.Map<List<BookModel>>(records);
		}

		public async Task<BookModel> GetBook(int BookId)
		{
			var record = await context.Books.FindAsync(BookId);
			return mapper.Map<BookModel>(record);
		}

		public async Task<int> AddBook(BookModel model)
		{
			context.Books.Add(mapper.Map<Book>(model));
			await context.SaveChangesAsync();
			return model.BookId;
		}

		public async Task<BookModel> UpdateBook(int BookId, BookModel model)
		{
			model.BookId = BookId;
			context.Books.Update(mapper.Map<Book>(model));
			await context.SaveChangesAsync();
			return model;
		}


		public async Task<BookModel> BookPatch(int BookId, JsonPatchDocument model)
		{
			var book = await context.Books.FindAsync(BookId);
			model.ApplyTo(book);
			await context.SaveChangesAsync();

			return null;
		}
		public async Task<int> DeleteBook(int BookId)
		{
			Book book = new Book { BookId = BookId };
			context.Books.Remove(book);
			await context.SaveChangesAsync();
			return BookId;
		}
	}
}
