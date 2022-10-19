using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Core.Interface
{
     interface IAllRecipes
    {
        IEnumerable<InfoDish> infoDishes { get;  }
        IEnumerable<InfoDish> Difficulty { get; set; }
        InfoDish getObjectInfoDish (int InfodishId);
    }
}
