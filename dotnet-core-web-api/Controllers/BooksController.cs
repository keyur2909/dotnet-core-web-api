using dotnet_core_web_api.Repository;
using dotnet_core_web_api.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_core_web_api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BooksController : ControllerBase
	{
		private readonly IBookRepository bookRepository;
		public BooksController(IBookRepository _bookRepository)
		{
			bookRepository = _bookRepository;
		}

		[HttpGet]
		public async Task<IActionResult> GetBooks() 
		{
			var records = await bookRepository.GetBooks();
			if (records == null)
			{
				return NotFound();
			}
			return Ok(records);
		}

		[HttpGet]
		[Route("{bookid}")]
		public async Task<IActionResult> GetBookById([FromRoute] int bookid)
		{
			var record = await bookRepository.GetBook(bookid);
			if (record == null)
			{
				return NotFound();
			}
			return Ok(record);
		}

		[HttpPost]
		public async Task<IActionResult> AddBook([FromBody] BookModel model)
		{
			var id = await bookRepository.AddBook(model);
			return Ok("Record save successfully.");
		}

		[HttpPut]
		[Route("{bookid}")]
		public async Task<IActionResult> UpdateBook([FromRoute] int bookid, [FromBody] BookModel model)
		{
			var id = await bookRepository.UpdateBook(bookid,model);

			return Ok("Record updated successfully.");
		}

		[HttpPatch]
		[Route("{bookid}")]
		public async Task<IActionResult> BookPatch([FromRoute] int bookid, [FromBody] JsonPatchDocument model)
		{
			var id = await bookRepository.BookPatch(bookid, model);
			return Ok("Patch updated successfully.");
		}
		[HttpDelete]
		[Route("{bookid}")]
		public async Task<IActionResult> DeleteBook([FromRoute] int bookid)
		{
			var id = await bookRepository.DeleteBook(bookid);
			return Ok("Record deleted successfully.");
		}


	}
}
 