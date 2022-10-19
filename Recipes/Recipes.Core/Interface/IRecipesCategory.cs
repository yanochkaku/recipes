using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Core.Interface
{
     interface IRecipesCategory
    {
        IEnumerable<Category> AllCategories { get; }

    }
}
