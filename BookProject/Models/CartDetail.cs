﻿using System.ComponentModel.DataAnnotations;

namespace BookProject.Models
{
    public class CartDetail
    {
        public int Id { get; set; }
        [Required]
        public int ShoppingCartId { get; set; }
        [Required]
        public int BookId { get; set; }
        [Required]
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public Book Book {  get; set; }
        public ShoppingCart ShoppingCart { get; set; }
    }
}
