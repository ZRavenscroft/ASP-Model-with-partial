using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PustokLayout.DAL;
using PustokLayout.Models;

namespace PustokLayout.Controllers
{
    public class BookController : Controller
    {
        private readonly PustokContext _context;
        public BookController(PustokContext context)
        {
            _context = context;
        }
        
        public IActionResult GetBook(int id)
        {
            Book book = _context.Books.Include(x=>x.BookImages).FirstOrDefault(x=>x.Id==id);

            //return Ok(book);
            return PartialView("_BookModalPartial", book);
        }
    }
}
