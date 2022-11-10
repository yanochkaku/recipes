using Recipes.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Repos
{
    public class TagsRepository
    {
        private readonly RecipesContext _ctx;

        public TagsRepository(RecipesContext _ctx)
        {
            this._ctx = _ctx;
        }

        public async Task<InfoDishTag> AddTagsAsync(InfoDishTag tags)
        {
            _ctx.Tags.Add(tags);
            await _ctx.SaveChangesAsync();
            return _ctx.Tags.FirstOrDefault(x => x.Title == tags.Title);
        }

        public InfoDishTag GetTags(int id)
        {
            return _ctx.Tags.FirstOrDefault(x => x.Id == id);
        }
        public InfoDishTag GetTagsByName(string name)
        {
            return _ctx.Tags.FirstOrDefault(x => x.Title == name);
        }

        public List<InfoDishTag> GetTags()
        {
            var tagsList = _ctx.Tags.ToList();
            return tagsList;
        }

        public async Task DeleteTagsAsync(int id)
        {
            _ctx.Remove(GetTags(id));
            await _ctx.SaveChangesAsync();
        }

        public async Task UpdateTagsAsync(InfoDishTag updatedTags)
        {
            var tags = _ctx.Tags.FirstOrDefault(x => x.Id == updatedTags.Id);
            tags.Title = updatedTags.Title;
            await _ctx.SaveChangesAsync();
        }
    }
}