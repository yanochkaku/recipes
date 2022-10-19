using Microsoft.AspNetCore.Mvc;
using Recipes.Repos;

namespace Recipes.UI.Controllers
{
    public class UpdateController : Controller
    {
        private readonly UpdateRepository updateRepository;
        public UpdateController (UpdateController UpdateRepository)
        {
            this.updateRepository = updateRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
