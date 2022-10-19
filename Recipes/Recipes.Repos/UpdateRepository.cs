using Microsoft.Extensions.Configuration;
using Recipes.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Repos
{
    public class UpdateRepository
    {
        private readonly RecipesContext _ctx;
        private readonly IConfiguration _configuration;

        public UpdateRepository(RecipesContext ctx, IConfiguration configuration)
        {
            _ctx = ctx;
            _configuration = configuration;
        }
    }

    /*public async Task<List<string>> UpdateAsync()
    {
        HttpClient client = new HttpClient();
        var url = _configuration ["Update:GithubUrl"];

        return new List<string> { url };
    }*/
}

      