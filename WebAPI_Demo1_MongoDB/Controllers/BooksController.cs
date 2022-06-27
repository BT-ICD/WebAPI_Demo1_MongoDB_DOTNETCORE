/*
 * To learn about MongoDB with .NET Code Web API
 * Learning References:
 * https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mongo-app?view=aspnetcore-3.1&tabs=visual-studio
 * 
 */
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_Demo1_MongoDB.Services;

namespace WebAPI_Demo1_MongoDB.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly BookService _bookService;

        public BooksController(BookService bookService)
        {
            _bookService = bookService;
        }
        [HttpGet]
        public IActionResult GetBooks()
        {
            var result = _bookService.Get();
            return Ok(result);
        }
    }
}
