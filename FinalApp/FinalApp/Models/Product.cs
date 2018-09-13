﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalApp.Models
{
    public class Product
    {
        public Product()
        {
            ProductId = Guid.NewGuid();
        }

        
        public Guid ProductId { get; set; }

        [Required]
        public Category Category { get; set; }
        public Guid CategoryId { get; set; }

        [Required]
        public string ProductName { get; set; }

        //Purchase Date
        [DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime PurchaseDate { get; set; }


        //Expiration Date
        [Required]
        [DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime ExpirationDate { get; set; }


        //POSSIBLE NEW FUNCTION
        //EXPIRING SOON
        //EXPIRATION DATE - 2 DAYS???

    }
}
