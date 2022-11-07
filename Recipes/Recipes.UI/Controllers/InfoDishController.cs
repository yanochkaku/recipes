﻿using Recipes.Core;
using Recipes.Repos;
using Recipes.Repos.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Data;
using System.Drawing.Drawing2D;

namespace Recipes.UI.Controllers
{
    public class InfoDishController : Controller
    {
        private readonly InfoDishRepository infoDishRepository;
        private readonly CategoryRepository categoryRepository;

        public InfoDishController(InfoDishRepository infoDishRepository, CategoryRepository categoryRepository)
        {
            this.infoDishRepository = infoDishRepository;
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
            ViewBag.Categories = categoryRepository.GetCategories();
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(InfoDishCreateDto infoDishCreateDto, string categories)
        {
            ViewBag.Categories = categoryRepository.GetCategories();
            if (ModelState.IsValid)
            {
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
                    Categories = category,
                });

                return RedirectToAction("Edit", "InfoDish", new { id = infoDish.Id });
            }
            return View(infoDishCreateDto);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            ViewBag.Categories = categoryRepository.GetCategories();
            return View(await infoDishRepository.GetInfoDishDto(id));
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Edit(InfoDishCreateDto model, string categories)
        {
            if (ModelState.IsValid)
            {
                await infoDishRepository.UpdateAsync(model, categories);
                return RedirectToAction("Index");
            }
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
    }
}