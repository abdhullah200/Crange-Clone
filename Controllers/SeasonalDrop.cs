using Microsoft.AspNetCore.Mvc;
using carnage.Models;

namespace carnage.Controllers
{
    public class SeasonalDropController : Controller
    {
        public IActionResult Index()
        {
            var seasonal = new SeasonalDrop
            {
                Id = 1,
                Title = "Green Shirt",
                Colors = "Red, Blue, Black",
                Sizes = "S, M, L, XL",
                Price = 49.99m,
                ImageUrl1 = "https://incarnage.com/cdn/shop/files/IMG_7914_800x.jpg?v=1756456251",
                SeasonName = "Summer Collection 2025"
            };

            // returns Views/SeasonalDrop/Index.cshtml with model; if you want to reuse Home view:
            // return View("~/Views/Home/Index.cshtml", seasonal);
            return View(seasonal);
        }

        public IActionResult SummerDrop()
        {
            return View();
        }
    }
}