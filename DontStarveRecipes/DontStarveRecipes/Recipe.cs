using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontStarveRecipes
{
    class Recipe
    {
        public string Name { get; set; }
        public string[] Ingredients { get; set; }
        public string[] Restrictions { get; set; }
        public int Health { get; set; }
        public int Hunger { get; set; }
        public int Sanity { get; set; }

        public Recipe()
        {

        }
    }
}
