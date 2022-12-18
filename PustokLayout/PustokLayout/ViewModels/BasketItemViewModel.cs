using PustokLayout.Models;

namespace PustokLayout.ViewModels
{
    public class BasketItemViewModel
    {
        public int Id { get; set; }
        public int Count { get; set; }
        public Book Book { get; set; }
    }
}
