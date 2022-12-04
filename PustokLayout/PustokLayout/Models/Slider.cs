using System.ComponentModel.DataAnnotations;

namespace PustokLayout.Models
{
    public class Slider
    {
        public int Id { get; set; }
        [MaxLength (100)]
        public string? Title { get; set; }
        [MaxLength(150)]
        public string? Subtitle { get; set; }
        [MaxLength(250)]
        public string? Desc { get; set; }
        [MaxLength(50)]
        public string BtnText { get; set; }
        [MaxLength(150)]
        public string BtnUrl { get; set; }
        [MaxLength(100)]
        public string Image { get; set; }
    }
}
