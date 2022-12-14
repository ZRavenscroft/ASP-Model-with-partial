﻿using System.ComponentModel.DataAnnotations;

namespace PustokLayout.ViewModels
{
    public class ReviewCreateViewModel
    {
        [Range(1, 5)]
        public int Rate { get; set; }
        [MaxLength(50)]
        public string Text { get; set; }
        public int BookId { get; set; }
    }
}
