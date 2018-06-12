using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Delicious.Models
{
    public class Recipe
    {
        public Guid Id { get; set; }
        public string RecipeName { get; set; }
        public string Description { get; set; }
        public string ImageName { get; set; }
        public DateTime InputDate { get; set; }
        public Category Category { get; set; }
        public virtual ICollection<Ingredient> Ingredients { get; set; }
    }
}