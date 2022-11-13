﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Core
{
    public class InfoDish
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }

        public string? Title { get; set; }

        public string? IconPath { get; set; }

        public string? Difficulty { get; set; }

        public string? CookingTime { get; set; }

        public string? Ingredients { get; set; }

        public string? Preparation { get; set; }

        public  Category? Categories { get; set; }

    }
}
