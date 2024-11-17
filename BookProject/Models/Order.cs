﻿using System.ComponentModel.DataAnnotations;

namespace BookProject.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Required]
        public string UserId { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.UtcNow;
        [Required]
        public int OrderStatusId { get; set; }
        public bool IsDeleted { get; set; } = false;
        public OrderStatus OrderStatus { get; set; }
        [Required]
        [MaxLength(30)]
        public string? Name { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        [Required]
        public string? MobileNumber { get; set; }
        [Required]
        [MaxLength(250)]
        public string? Address { get; set; }
        public bool? IsPaid { get; set; }
        [Required]
        [MaxLength(30)]
        public string? PaymentMethod {  get; set; }
        public List<OrderDetail> OrderDetail { get; set; }
    }
}
