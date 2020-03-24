using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Asg1.Models
{
    public class Product
    {
        [Key]
        public string Name { get; set; }
        public Category Category { get; set;} 
    }
}