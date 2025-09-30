using Microsoft.AspNetCore.Mvc;
using carnage.Models;

namespace carnage.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ILogger<ProductsController> _logger;

        public ProductsController(ILogger<ProductsController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string? category = null, string? subcategory = null)
        {
            // For now, we'll create some sample products
            // Later you can replace this with database calls
            var products = GetSampleProducts();
            
            // Filter by category if specified
            if (!string.IsNullOrEmpty(category))
            {
                products = products.Where(p => p.Category.ToLower() == category.ToLower()).ToList();
            }
            
            // Filter by subcategory if specified
            if (!string.IsNullOrEmpty(subcategory))
            {
                products = products.Where(p => p.SubCategory.ToLower() == subcategory.ToLower()).ToList();
            }
            
            // Pass filter info to the view
            ViewBag.Category = category;
            ViewBag.SubCategory = subcategory;
            ViewBag.Title = GetPageTitle(category, subcategory);
            
            return View(products);
        }

        // Sample data - replace with actual database calls later
        private List<Product> GetSampleProducts()
        {
            return new List<Product>
            {
                new Product { Id = 1, Name = "Essential Tank", Category = "Men", SubCategory = "Tanks", Price = 25.99m, ImageUrl = "/images/products/men-tank1.jpg" },
                new Product { Id = 2, Name = "Premium T-Shirt", Category = "Men", SubCategory = "T-Shirts", Price = 35.99m, ImageUrl = "/images/products/men-tshirt1.jpg" },
                new Product { Id = 3, Name = "Compression Shirt", Category = "Men", SubCategory = "Compressions", Price = 45.99m, ImageUrl = "/images/products/men-compression1.jpg" },
                new Product { Id = 4, Name = "Classic Hoodie", Category = "Men", SubCategory = "Hoodies", Price = 65.99m, ImageUrl = "/images/products/men-hoodie1.jpg" },
                
                new Product { Id = 5, Name = "Women's Tank", Category = "Women", SubCategory = "Tanks", Price = 28.99m, ImageUrl = "/images/products/women-tank1.jpg" },
                new Product { Id = 6, Name = "Sports Bra", Category = "Women", SubCategory = "Sports Bras", Price = 32.99m, ImageUrl = "/images/products/women-bra1.jpg" },
                new Product { Id = 7, Name = "Yoga Leggings", Category = "Women", SubCategory = "Leggings", Price = 48.99m, ImageUrl = "/images/products/women-leggings1.jpg" },
                
                new Product { Id = 8, Name = "Gym Bag", Category = "Accessories", SubCategory = "Bags", Price = 55.99m, ImageUrl = "/images/products/bag1.jpg" },
                new Product { Id = 9, Name = "Water Bottle", Category = "Accessories", SubCategory = "Bottles", Price = 15.99m, ImageUrl = "/images/products/bottle1.jpg" }
            };
        }

        private string GetPageTitle(string? category, string? subcategory)
        {
            if (!string.IsNullOrEmpty(subcategory))
            {
                return $"{category} - {subcategory}";
            }
            else if (!string.IsNullOrEmpty(category))
            {
                return $"{category} Products";
            }
            else
            {
                return "All Products";
            }
        }
    }
}