﻿using Microsoft.AspNetCore.Identity;

namespace PustokLayout.Models
{
    public class AppUser:IdentityUser
    {
        public string Fullname { get; set; }
        public List<BasketItem> BasketItems { get; set; }
    }
}
