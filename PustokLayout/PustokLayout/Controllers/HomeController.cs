using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PustokLayout.DAL;
using PustokLayout.ViewModels;
using System.Diagnostics;
using System.Linq;

namespace PustokLayout.Controllers
{
    public class HomeController : Controller
    {
        private readonly PustokContext _context;

        public HomeController(PustokContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeViewModel homeVM = new HomeViewModel
            {
                SpecialBooks = _context.Books.Include(x=>x.Author).Include(x=>x.BookImages).Where(x=>x.IsSpecial).Take(20).ToList(),
                NewBooks = _context.Books.Include(x => x.Author).Include(x => x.BookImages).Where(x=>x.IsNew).Take(20).ToList(),
                DiscountedBooks = _context.Books.Include(x => x.Author).Include(x => x.BookImages).Where(x=>x.DiscountPercent > 0).Take(20).ToList(),
                Sliders = _context.Sliders.ToList(),
                Settings = _context.Settings.ToDictionary(x=>x.Key, x => x.Value)
            };
            return View(homeVM);
        }
    }
}