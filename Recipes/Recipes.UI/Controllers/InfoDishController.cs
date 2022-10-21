using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Recipes.Core;
using Recipes.Repos;
using Recipes.Repos.Dto;
using System.Data;
using System.Drawing.Drawing2D;

namespace Recipes.UI.Controllers
{
    public class InfoDishController : Controller
    {   
        private readonly InfoDishRepository infoDishRepository;
        private readonly RecipesContext _context;
        
        public InfoDishController(InfoDishRepository infoDishRepository, RecipesContext context)
        {
            this.infoDishRepository = infoDishRepository;
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {          
            var infoDishes = infoDishRepository.GetInfoDishes();
            return View(infoDishes);
        }
        [HttpGet]
        [Authorize(Roles = "Admin,Manager")]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(InfoDishCreateDto model)
        {
            
            if (ModelState.IsValid)
            {
                var infoDish = infoDishRepository.GetInfoDishByName(model.Title);
                var category = _context.Categories.FirstOrDefault(x => x.Id == 1);
                var infoDish1 = await infoDishRepository.AddInfoDishAsync(new InfoDish()
                {
                    Title = model.Title,
                    IconPath = model.IconPath,
                    Rating = model.Rating,
                    Difficulty = model.Difficulty,
                    CookingTime = model.CookingTime,
                    Ingredients = model.Ingredients,
                    Preparation = model.Preparation,
                    Categories = category
                });

            
            
            return RedirectToAction("Edit", "InfoDishes", new { id = infoDish1.Id });
            }
            return View(model);
        }
        public IActionResult Detail(int id)
        {
            if (id == null) return NotFound();

            var infoDishes = _context.InfoDishes
                .FirstOrDefault(x => x.Id == id);
            if (infoDishes == null) return NotFound();
            return View(infoDishes);
        }
        [HttpGet]
        [HttpGet]
        [Authorize(Roles = "Admin,Manager")]
        public async Task<IActionResult> Delete(InfoDishCreateDto model)
        {
            return View(model);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> ConfirmDelete(int id)
        {
            await infoDishRepository.DeleteInfoDishAsync(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        [HttpGet]
        [Authorize(Roles = "Admin,Manager")]
        public async Task<IActionResult> Edit(InfoDish model)
        {
            return View(model);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> ConfirmEdit(InfoDish model)
        {
            if (ModelState.IsValid)
            {
                await infoDishRepository.UpdateInfoDishAsync(model);
                return RedirectToAction("Index");

            }
            return View(model);
        }

    }

}
