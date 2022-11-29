using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required(ErrorMessage =("please enter your name ")),DisplayName("Customer Name")]
        public string? CustomerName { get; set; }
        public int CustomerPhone { get; set;}
        public string? CustomerEmail { get; set;}
    }
}
