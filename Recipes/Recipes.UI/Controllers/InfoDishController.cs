using Recipes.Core;
using Recipes.Repos;
using Recipes.Repos.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Data;
using System.Drawing.Drawing2D;
using Microsoft.EntityFrameworkCore;

namespace Recipes.UI.Controllers
{
    public class InfoDishController : Controller
    {
        private readonly InfoDishRepository infoDishRepository;
        private readonly CategoryRepository categoryRepository;
        private readonly TagsRepository tagsRepository;
        private readonly RecipesContext rContext;

        public InfoDishController(InfoDishRepository infoDishRepository, TagsRepository tagsRepository, CategoryRepository categoryRepository)
        {
            this.infoDishRepository = infoDishRepository;
            this.tagsRepository = tagsRepository;
            this.categoryRepository = categoryRepository;
            
        }

        [HttpGet]
        public IActionResult Index()
        {
            var infoDish = infoDishRepository.GetInfoDishes();
            return View(infoDish);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Tags = tagsRepository.GetTags();
            ViewBag.Categories = categoryRepository.GetCategories();
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(InfoDishCreateDto infoDishCreateDto, string tags, string categories)
        {
            ViewBag.Tags = tagsRepository.GetTags();
            ViewBag.Categories = categoryRepository.GetCategories();          
            if (ModelState.IsValid)
            {
                var tag = tagsRepository.GetTagsByName(tags);
                if (tag == null)
                {
                    tag = new InfoDishTag() { Title = tags };
                    tag = await tagsRepository.AddTagsAsync(tag);
                }
                var category = categoryRepository.GetCategoryByName(categories);
                if (category == null)
                {
                    category = new Category() { NameCategory = categories };
                    category = await categoryRepository.AddCategoryAsync(category);
                }
                

                var infoDish = await infoDishRepository.AddInfoDishAsync(new InfoDish()
                {
                    Title = infoDishCreateDto.Title,
                    IconPath = infoDishCreateDto.IconPath,
                    Difficulty = infoDishCreateDto.Difficulty,
                    CookingTime = infoDishCreateDto.CookingTime,
                    Ingredients = infoDishCreateDto.Ingredients,
                    Preparation = infoDishCreateDto.Preparation,                  
                    Tags = tag,
                    Categories = category,
                });

                return RedirectToAction("Edit", "InfoDish", new { id = infoDish.Id });
            }
            return View(infoDishCreateDto);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            ViewBag.Tags = tagsRepository.GetTags();
            ViewBag.Categories = categoryRepository.GetCategories();
            return View(await infoDishRepository.GetInfoDishDto(id));
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Edit(InfoDishCreateDto model, string categories, string tags)
        {
            if (ModelState.IsValid)
            {
                await infoDishRepository.UpdateAsync(model, categories, tags);
                return RedirectToAction("Index");
            }
            ViewBag.Tags = tagsRepository.GetTags();
            ViewBag.Categories = categoryRepository.GetCategories();
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            return View(await infoDishRepository.GetInfoDishDto(id));
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> ConfirmDelete(int id)
        {
            await infoDishRepository.DeleteInfoDishAsync(id);
            return RedirectToAction("Index");
        }
        public async Task<ViewResult> Details(int id)
        {
            var info = await infoDishRepository.GetInfoDishDto(id);
            return View(info);
        }
        
    }
}