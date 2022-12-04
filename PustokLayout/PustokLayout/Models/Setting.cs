using System.ComponentModel.DataAnnotations;

namespace PustokLayout.Models
{
    public class Setting
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Key { get; set; }
        [MaxLength(150)]
        public string Value { get; set; } 
    }
}
