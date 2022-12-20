using System.ComponentModel.DataAnnotations;

namespace PustokLayout.Models
{
    public class Author
    {
        public int Id { get; set; }
        [MaxLength(35)]
        public string Fullname { get; set; }
        public List<Book>? Books { get; set; }
    }
}
