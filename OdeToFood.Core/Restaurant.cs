using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OdeToFood.Core
{
    public partial class Restaurant
    {
        public int Id { get; set; }

        [Required, StringLength(80), MinLength(3)]
        public string Name { get; set; }
        [Required, StringLength(255), MinLength(5)]
        public string Location { get; set; }
       public CuisineType cuisine { get; set; }

        
    }
}
