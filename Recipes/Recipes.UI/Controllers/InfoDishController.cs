using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Recipes.Core;
using Recipes.Core.mocks;
using Recipes.Repos;
using Recipes.Repos.Dto;
using System.Drawing.Drawing2D;

namespace Recipes.UI.Controllers
{
    public class InfoDishController : Controller
    {   
        private readonly InfoDishRepository infoDishRepository;
        private readonly RecipesContext _context;
        //private readonly CategoryRepository categoryRepository;
        public InfoDishController(InfoDishRepository infoDishRepository, RecipesContext context)
        {
            this.infoDishRepository = infoDishRepository;
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            /*List<InfoDish> infoDishes = new List<InfoDish>
            {
                 new InfoDish
                    {
                        Title = "Капусняк",
                        IconPath = @"https://fayni-recepty.com.ua/wp-content/uploads/2021/11/kapusnyak.jpg",
                        Rating = 5,
                        Difficulty = "Легке приготування",
                        CookingTime = "2 години",
                        Ingredients = "Вода, свинина, картопля, квашена капуста, цибулина, морква, перець",
                        Preparation = "Вимити м'ясо, покласти у каструлю з водою, довести до кипіння, зняти шумовкою піну і варити протягом 1.5 год. Коли бульйон звариться, м'ясо, при бажанні, нарізати меншими кусками або відділити від кістки.\nДрібно нарізати цибулю, моркву нарізати дрібною соломкою і пасерувати на олії, поки цибуля не стане прозорою. Додати квашену капусту і готувати разом, помішуючи, декілька хвилин на середньому вогні.\nПочистити картоплю і нарізати. Промити пшоно. Покласти картоплю та пшоно в киплячий бульйон, додати лавровий листок та чорний перець горошком.\nДодати капусту, посолити і готувати 15-20 хвилин."

                 },
                 new InfoDish
                 {
                        Title = "Курячі гомілки в рукаві",
                        IconPath = @"https://fayni-recepty.com.ua/wp-content/uploads/2022/08/kuryachi_gomilky.jpg",
                        Rating = 5,
                        Difficulty = "Легке приготування",
                        CookingTime = "1.5 години",
                        Ingredients = "Курячі гомілки, олія, соєвий соус, сушений часник, сіль, перець",
                        Preparation = "Курячі гомілки або стегна помиємо та обсушимо.\nЗмішаємо сіль, паприку, сушений часник, чорний перець та прованські трави.\nСухою сумішшю натираємо кожен шматочок.\nЗмішуємо соєвий соус з олією, заллємо ним курячі гомілки та залишимо на 30 хвилин маринуватися.\nПокладемо гомілки в рукав для запікання, фіксуємо один край і акуратно виллємо всередину маринад, зафіксуємо другий край.\nВикладаємо рукав на деко і ставимо в розігріту до 180°С духовку на 40 хвилин.",

                 },

                 new InfoDish
                 {
                        Title = "Пиріг з домашнім сиром та ягодами",
                        IconPath = @"https://fayni-recepty.com.ua/wp-content/uploads/2022/09/pyrih-z-domashnim-syrom-ta-yagodamy.jpg",
                        Rating = 5,
                        Difficulty = "Легке приготування",
                        CookingTime = "1 година",
                        Ingredients = "Домашній сир, 2 яйця, борошно, цукор, сметана, масло, ягоди",
                        Preparation = "Просіємо борошно та змішаємо з розпушувачем.\nНарізаємо невеликими кубиками вершкове масло, змішуємо з борошном та розтираємо у крихту.\nДодаємо яйце і 100 г цукру, замішуємо тісто. Воно має бути м'яким та еластичним.\nПокладемо тісто у холодильник на 30 хвилин.\nЗбиваємо домашній сир блендером з ванільним цукром, сметаною, цукром та яйцем.\nЗмащуємо форму маслом або застеляємо пергаментом та розподіляємо тісто у формі, зробивши бортики 4-5 см.\nВикладаємо на тісто сирну масу, а зверху будь-які ягоди – свіжі або заморожені.\nВипікаємо 40 хвилин у духовці при 180°С.",

                 }
            };*/ 
            var infoDishes = infoDishRepository.GetInfoDishes();
            return View(infoDishes);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(InfoDishCreateDto model)
        {
            //ViewBag.InfoDish = InfoDishRepository.GetInfoDish();
            if (ModelState.IsValid)
            {
                var infoDish = infoDishRepository.GetInfoDishByName(model.Title);
                /*if (brand == null)
                {
                    brand = new Brand() { Name = brands };
                    brand = await brandsRepository.AddBrandAsync(brand);
                }*/
                var category = _context.Categories.FirstOrDefault(x => x.Id == 1);
                var infoDish1 = await infoDishRepository.AddInfoDishAsync(new InfoDish()
                {
                    Title = model.Title,
                    IconPath = model.IconPath,
                    Rating = model.Rating,
                    Difficulty = model.Difficulty,
                    CookingTime = model.CookingTime,
                    Ingredients = model.Ingredients,
                    Preparation = model.Preparation,
                    Categories = category
                });

            
            
            return RedirectToAction("Edit", "InfoDishes", new { id = infoDish1.Id });
            }
            return View(model);
        }
    }

}
