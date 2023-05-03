using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            List<Pizza> pizze = new List<Pizza>
            {
                new Pizza("Pizza Margherita", "Bella buona", "https://giorgiacastioni.files.wordpress.com/2015/01/pizza-margherita-1.jpg", 6),
                new Pizza("Pizza Marinara", "Bella buona", "https://www.anticogatoleto.com/shop/wp-content/uploads/2021/02/marinara-min-scaled.jpeg", 6),
                new Pizza("Pizza Wurstel e patatine", "Bella buona", "https://i0.wp.com/www.piccolericette.net/piccolericette/wp-content/uploads/2017/11/3244_Pizza.jpg?resize=895%2C616&ssl=1", 8),
            };
            return View(pizze);
        }
    }
}
