using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Delicious.Models
{
    public class Ingredient
    {
        public Guid Id { get; set; }
        public string IngredientName { get; set; }
        public double Quantity { get; set; }    
        public virtual ICollection<Recipe> Recipes { get; set; }
    }
}