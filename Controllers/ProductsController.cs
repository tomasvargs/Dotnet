using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using EcomApp.Models;
using System.Collections.Generic;
namespace EcomApp.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IConfiguration _configuration;

        public ProductsController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            // Fetch image URLs from appsettings.json
                var img1 = _configuration["ImageUrls:img1"] ?? throw new InvalidOperationException("ImageUrls:img1 is not configured");
                var img2 = _configuration["ImageUrls:img2"] ?? throw new InvalidOperationException("ImageUrls:img2 is not configured");
                var img3 = _configuration["ImageUrls:img3"] ?? throw new InvalidOperationException("ImageUrls:img3 is not configured");
                var img4 = _configuration["ImageUrls:img4"] ?? throw new InvalidOperationException("ImageUrls:img4 is not configured");
                var img5 = _configuration["ImageUrls:img5"] ?? throw new InvalidOperationException("ImageUrls:img5 is not configured");
            var products = new List<Product>
            {

                new Product { Id = 1, Name = "Regular Fit Linen-blend shirt", Description = "Shirt in an airy cotton and linen weave with a turn-down collar, classic front, a yoke at the back and an open chest pocket. ", Price = 2299, ImageUrl = img1 },
                new Product { Id = 2, Name = "Regular Fit Short-sleeved linen-blend shirt", Description = "Short-sleeved shirt in an airy cotton and linen blend with a resort collar, French front and a yoke at the back.", Price = 1999, ImageUrl = img2 },
                new Product { Id = 2, Name = "Slim Fit Linen shirt", Description = "Shirt in airy linen with a cutaway collar, French front and a yoke at the back. ", Price = 2999, ImageUrl = img3 },
                new Product { Id = 2, Name = "Relaxed Fit Linen trousers", Description = "Trousers in an airy linen and cotton weave with covered elastication and a drawstring at the waist", Price = 3999, ImageUrl = img4 },
                new Product { Id = 2, Name = "Regular Fit Shacket", Description = "Shacket in a soft weave with a collar, zip down the front, vertical seam at the back and long sleeves with buttoned cuffs.", Price = 4999, ImageUrl = img5 }
            };

            return View(products);
        }
    }
}
