using System.ComponentModel.DataAnnotations;

namespace PustokLayout.Models
{
    public class Genre
    {
        public int Id { get; set; }
        [MaxLength(25)]
        public string Name { get; set; }
        public List<Book>? Books { get; set; }
    }
}
