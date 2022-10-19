using Recipes.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Repos
{
    public class RecipesRepository
    {
        private readonly RecipesContext recipesContext;
        public RecipesRepository(RecipesContext recipesContext)
        {
            this.recipesContext = recipesContext;
        }
        /*public async Task<User> AddRecipesAsync(string? firstName, string? lastName, string? password, string? email)
        {
            var newUser = new User
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                UserName = email,
                NormalizedEmail = email.ToUpper(),
                NormalizedUserName = email.ToUpper(),
                EmailConfirmed = true
            };
        }*/
    }
}
