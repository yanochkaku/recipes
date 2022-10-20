using Microsoft.AspNetCore.Mvc;
using Recipes.Core;

namespace Recipes.UI.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            List<Category> AllCategories = new List<Category>
            {
            };
            return View();
        }
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
