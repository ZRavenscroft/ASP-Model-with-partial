using PustokLayout.Models;

namespace PustokLayout.ViewModels
{
    public class ShopViewModel
    {
        public PaginatedList<Book> Books { get; set; }
        public List<Genre> Genres { get; set; }
        public List<Author> Authors { get; set; }
        public decimal MaxPrice { get; set; }
        public decimal MinPrice { get; set; }
    }
}
