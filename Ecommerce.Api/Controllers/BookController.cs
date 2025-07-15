using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Api.Controllers;


public class BookController : ControllerBase
{

    public async Task<ActionResult> GetBooks()
    {
        var books = new List<string> { "Book 1", "Book 2", "Book 3" };

        return Ok(books);
    }
    
}