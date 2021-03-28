using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeJournal.Models.Commands.Recipes
{
    public class CreateRecipeCommand
    {
        [Required]
        public string Title { get; set; } = "Rice Pudding";
        [Required]
        public List<string> Directions { get; set; } = new List<string>();
    }
}
