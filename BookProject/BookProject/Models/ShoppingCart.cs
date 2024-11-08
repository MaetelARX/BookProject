﻿using System.ComponentModel.DataAnnotations;

namespace BookProject.Models
{
    public class ShoppingCart
    {
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
