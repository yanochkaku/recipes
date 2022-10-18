using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Recipes.Core
{
    public class RecipesContext : IdentityDbContext<User>
    {
        public RecipesContext(DbContextOptions<RecipesContext> options)
            : base(options)
        {
        }
    }
}