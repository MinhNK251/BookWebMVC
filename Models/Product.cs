﻿//using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required]
        public string ISBN { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        [DisplayName("List Price")]
        [Range(1, 10000)]
        public double ListPrice { get; set; }
        [Required]
        [DisplayName("Price for 1-50")]
        [Range(1, 10000)]
        public double Price { get; set; }
        [Required]
        [DisplayName("Price for 50-100")]
        [Range(1, 10000)]
        public double Price50 { get; set; }
        [Required]
        [DisplayName("Price for 100+")]
        [Range(1, 10000)]
        public double Price100 { get; set; }

		public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
		[ValidateNever]
		public Category Category { get; set; }
		[ValidateNever]
		public string ImageUrl { get; set; }
        //[Required]
        //public int CoverTypeId { get; set; }
        //public CoverType CoverType { get; set; }
    }
}