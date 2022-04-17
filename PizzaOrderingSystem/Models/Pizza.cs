using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PizzaOrderingSystem.Models
{
    //POCO Class
    [Table("tbl_pizza")]
    public class Pizza
    {

        public int Id { get; set; }

        [Required]
        public string PizzaName { get; set; }

        [Required]
        [StringLength(maximumLength: 25, MinimumLength = 5)]
        public string PizzaDescription { get; set; }

        [Required]
        public string PizzaType { get; set; }

        [Required]
        public int PizzaUnitPrice { get; set; }
    }
}