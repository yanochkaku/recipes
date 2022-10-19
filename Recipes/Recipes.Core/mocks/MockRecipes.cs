using Recipes.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Core.mocks
{
    public class MockRecipes : IAllRecipes
    {
        private readonly IRecipesCategory _categoryRecipes = new MockCategory();
        public IEnumerable<InfoDish> infoDishes {

            get
            {
                return new List<InfoDish>
                {
                    new InfoDish
                    {
                        Id = 1,
                        Title = "Капусняк",
                        IconPath = @"Photos/Dishes/kapusnyak",
                        Rating = 5,
                        Difficulty = "Легке приготування",
                        CookingTime = "2 години",
                        Ingredients = "Вода, свинина, картопля, квашена капуста, цибулина, морква, перець",
                        Preparation = "Вимити м'ясо, покласти у каструлю з водою, довести до кипіння, зняти шумовкою піну і варити протягом 1.5 год. Коли бульйон звариться, м'ясо, при бажанні, нарізати меншими кусками або відділити від кістки.\nДрібно нарізати цибулю, моркву нарізати дрібною соломкою і пасерувати на олії, поки цибуля не стане прозорою. Додати квашену капусту і готувати разом, помішуючи, декілька хвилин на середньому вогні.\nПочистити картоплю і нарізати. Промити пшоно. Покласти картоплю та пшоно в киплячий бульйон, додати лавровий листок та чорний перець горошком.\nДодати капусту, посолити і готувати 15-20 хвилин.",
                        Categories = _categoryRecipes.AllCategories.First()
                    },
                    new InfoDish
                    {
                        Id = 2,
                        Title = "Курячі гомілки в рукаві",
                        IconPath = @"Photos/Dishes/kuryachi_gomilky",
                        Rating = 5,
                        Difficulty = "Легке приготування",
                        CookingTime = "1.5 години",
                        Ingredients = "Курячі гомілки, олія, соєвий соус, сушений часник, сіль, перець",
                        Preparation = "Курячі гомілки або стегна помиємо та обсушимо.\nЗмішаємо сіль, паприку, сушений часник, чорний перець та прованські трави.\nСухою сумішшю натираємо кожен шматочок.\nЗмішуємо соєвий соус з олією, заллємо ним курячі гомілки та залишимо на 30 хвилин маринуватися.\nПокладемо гомілки в рукав для запікання, фіксуємо один край і акуратно виллємо всередину маринад, зафіксуємо другий край.\nВикладаємо рукав на деко і ставимо в розігріту до 180°С духовку на 40 хвилин.",
                    Categories = _categoryRecipes.AllCategories.Last()
                    },

                    new InfoDish
                    {
                        Id = 3,
                        Title = "Пиріг з домашнім сиром та ягодами",
                        IconPath = @"Photos/Dishes/pyrih-z-domashnim-syrom-ta-yagodamy",
                        Rating = 5,
                        Difficulty = "Легке приготування",
                        CookingTime = "1 година",
                        Ingredients = "Домашній сир, 2 яйця, борошно, цукор, сметана, масло, ягоди",
                        Preparation = "Просіємо борошно та змішаємо з розпушувачем.\nНарізаємо невеликими кубиками вершкове масло, змішуємо з борошном та розтираємо у крихту.\nДодаємо яйце і 100 г цукру, замішуємо тісто. Воно має бути м'яким та еластичним.\nПокладемо тісто у холодильник на 30 хвилин.\nЗбиваємо домашній сир блендером з ванільним цукром, сметаною, цукром та яйцем.\nЗмащуємо форму маслом або застеляємо пергаментом та розподіляємо тісто у формі, зробивши бортики 4-5 см.\nВикладаємо на тісто сирну масу, а зверху будь-які ягоди – свіжі або заморожені.\nВипікаємо 40 хвилин у духовці при 180°С.",
                    Categories = _categoryRecipes.AllCategories.Last()
                    }


                };
            }
        }
        public IEnumerable<InfoDish> Difficulty { get; set; }

        public InfoDish getObjectInfoDish(int InfodishId)
        {
            throw new NotImplementedException();
        }
    }
}
