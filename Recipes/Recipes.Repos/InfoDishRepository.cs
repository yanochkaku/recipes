using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Recipes.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Repos
{
    public class InfoDishRepository
    {
        private readonly RecipesContext _ctx;

        public InfoDishRepository(RecipesContext _ctx)
        {
            this._ctx = _ctx;
        }

        public async Task<InfoDish> AddInfoDishAsync(InfoDish infoDish)
        {
            _ctx.InfoDishes.Add(infoDish);
            await _ctx.SaveChangesAsync();
            return _ctx.InfoDishes.FirstOrDefault(x=> x.Title == infoDish.Title);
        }

        public InfoDish GetInfoDish(int id)
        {
            return _ctx.InfoDishes.Include(x => x.Categories).FirstOrDefault(x => x.Id == id);

        }
        public InfoDish GetInfoDishByName(string name)
        {
            return _ctx.InfoDishes.Include(x => x.Categories).FirstOrDefault(x => x.Title == name);

        }

        public List<InfoDish> GetInfoDishes()
        {
            var infoDishList = _ctx.InfoDishes.ToList();
            return infoDishList;
        }

        public async Task DeleteInfoDishAsync(int id)
        {
            _ctx.Remove(GetInfoDish(id));
            await _ctx.SaveChangesAsync();
        }

        public async Task UpdateInfoDishAsync(InfoDish updatedInfoDish)
        {
            var infoDish = _ctx.InfoDishes.FirstOrDefault(x => x.Id == updatedInfoDish.Id);
            infoDish.Title = updatedInfoDish.Title;
            infoDish.IconPath = updatedInfoDish.IconPath;
            infoDish.Rating = updatedInfoDish.Rating;
            infoDish.Difficulty = updatedInfoDish.Difficulty;
            infoDish.CookingTime = updatedInfoDish.CookingTime;
            infoDish.Ingredients = updatedInfoDish.Ingredients;
            infoDish.Preparation = updatedInfoDish.Preparation;
          
            infoDish.Categories = updatedInfoDish.Categories;
            await _ctx.SaveChangesAsync();
        }

        public async Task<InfoDish> CreateInfoDishAsync(string? title, string? iconPath, int rating, string? difficulty, string? cookingTime, string? ingredients, string? preparation, int categoriesId)
        {
            var category = _ctx.Categories.FirstOrDefault(x => x.Id == 1);
            var newInfoDish = new InfoDish
            {
                Title = title,
                IconPath = iconPath,
                Rating = rating,
                Difficulty = difficulty,
                CookingTime = cookingTime,
                Ingredients = ingredients,
                Preparation = preparation,
             Categories = category   
            };
            _ctx.InfoDishes.Add(newInfoDish);
            await _ctx.SaveChangesAsync();
           
            return await _ctx.InfoDishes.FirstAsync(x => x.Title == title);
        }
    }
}
