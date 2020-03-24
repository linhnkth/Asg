using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Asg1.Models
{
    public class Category
    {
        [Key]
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; } 
    }
}