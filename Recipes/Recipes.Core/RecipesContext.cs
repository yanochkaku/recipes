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
        public DbSet<Recipes> Recipes { get; set; }
        public DbSet<InfoDish> InfoDishes { get; set; }

    }
}