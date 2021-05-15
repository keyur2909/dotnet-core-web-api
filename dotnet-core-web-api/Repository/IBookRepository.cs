using dotnet_core_web_api.ViewModels;
using Microsoft.AspNetCore.JsonPatch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_core_web_api.Repository
{
	public interface IBookRepository
	{
		Task<List<BookModel>> GetBooks();
		Task<BookModel> GetBook(int BookId);
		Task<int> AddBook(BookModel model);
		Task<BookModel> UpdateBook(int BookId, BookModel model);
		Task<BookModel> BookPatch(int BookId, JsonPatchDocument model);
		Task<int> DeleteBook(int BookId);
	}
}
