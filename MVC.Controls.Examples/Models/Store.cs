using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC.Controls.Examples.Models
{
    [MetadataType(typeof(MetaData))]
    public class Store
    {
        // To test and demonstrate that MetaData works
        private static class MetaData
        {
            [Display(Name = "My name (FROM META)")]
            [Required]
            public static string Name { get; set; }
        }

        [Key]
        public int StoreId { get; set; }
        public string Name { get; set; }
        [Display(Name = "Street Address")]
        public string Address { get; set; }
        
        public List<Product> Products { get; set; }
        public DateTime Created { get; set; }
        public Store() { this.Products = new List<Product>(); }
    }
}
