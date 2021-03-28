using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeJournal.Models.Results.Recipes
{
    public class RecipeResult
    {
        public string Title { get; set; }
        public List<string> Directions { get; set; } = new List<string>();
    }
}
