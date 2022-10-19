using Recipes.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Core.mocks
{
    public class MockCategory : IRecipesCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { NameCategory = "Перші страви"},
                    new Category { NameCategory = "Другі страви"},
                    new Category { NameCategory = "Десерти"}
                };
            }
        }
    }
}
