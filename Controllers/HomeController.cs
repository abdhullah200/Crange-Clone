using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using carnage.Models;
using System;
using System.Diagnostics;
using System.Collections.Generic; // added

namespace carnage.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
public IActionResult Index()
{
    // Create example seasonal drops as a collection
    var seasonal = new List<SeasonalDrop>
    {
        new SeasonalDrop
        {
            Id = 1,
            Title = "Green Shirt",
            Colors = "Red, Blue, Black",
            Sizes = "S, M, L, XL",
            Price = 49.99m,
            SeasonName = GetSeasonalTitle(),
            ImageUrl1 = "https://incarnage.com/cdn/shop/files/IMG_7914_800x.jpg?v=1756456251",
            ImageUrl2 = "https://incarnage.com/cdn/shop/files/IMG_7912_2000x.jpg?v=1756447992"
        },
        new SeasonalDrop
        {
            Id = 2,
            Title = "Luxe Knit Polo",
            Colors = "White, Black, Navy",
            Sizes = "M, L, XL",
            Price = 58.50m,
            SeasonName = GetSeasonalTitle(),
            ImageUrl1 = "https://incarnage.com/cdn/shop/products/IMG_20230824_153259_800x.jpg?v=1759750685",
            ImageUrl2 = "https://incarnage.com/cdn/shop/products/IMG_20230824_153259_800x.jpg?v=1759750685"
        },
        new SeasonalDrop
        {
            Id = 3,
            Title = "Casual Denim Jeans",
            Colors = "Light Blue, Dark Blue, Black",
            Sizes = "28, 30, 32, 34, 36",
            Price = 65.00m,
            SeasonName = GetSeasonalTitle(),
            ImageUrl1 = "https://example.com/images/denim_jeans_1.jpg",
            ImageUrl2 = "https://example.com/images/denim_jeans_2.jpg"
        },
        new SeasonalDrop
        {
            Id = 4,
            Title = "Classic White Sneakers",
            Colors = "White, Black, Grey",
            Sizes = "7, 8, 9, 10, 11",
            Price = 75.00m,
            SeasonName = GetSeasonalTitle(),
            ImageUrl1 = "https://example.com/images/white_sneakers_1.jpg",
            ImageUrl2 = "https://example.com/images/white_sneakers_2.jpg"
        },
        new SeasonalDrop
        {
            Id = 5,
            Title = "Leather Jacket",
            Colors = "Black, Brown",
            Sizes = "M, L, XL",
            Price = 120.00m,
            SeasonName = GetSeasonalTitle(),
            ImageUrl1 = "https://example.com/images/leather_jacket_1.jpg",
            ImageUrl2 = "https://example.com/images/leather_jacket_2.jpg"
        },
        new SeasonalDrop
        {
            Id = 6,
            Title = "Summer Floral Dress",
            Colors = "Red, Yellow, Blue",
            Sizes = "S, M, L",
            Price = 55.00m,
            SeasonName = GetSeasonalTitle(),
            ImageUrl1 = "https://example.com/images/floral_dress_1.jpg",
            ImageUrl2 = "https://example.com/images/floral_dress_2.jpg"
        }
    };

    // Pass collection to view
    return View(seasonal);
}

        private string GetSeasonalTitle()
        {
            // Simple seasonal title logic based on current month
            var month = DateTime.Now.Month;
            return month switch
            {
                12 or 1 or 2 => "Winter Drop",
                3 or 4 or 5 => "Spring Drop",
                6 or 7 or 8 => "Summer Drop",
                9 or 10 or 11 => "Autumn Drop",
                _ => "Seasonal Drop"
            };
        }

        public IActionResult SummerDrop()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
