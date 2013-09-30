using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class Product
    {
        [Key, Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(250), Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Range(1,1000)]
        public int Warranty { get; set; }

        [Range(1,1000000000)]
        public decimal Price { get; set; }
        
        [StringLength(500)]
        public decimal SaleOff { get; set; }

        [StringLength(50)]
        public string Color { get; set; }

        virtual public Category Category { get; set; }
        virtual public Property Property { get;set;}
    }
}