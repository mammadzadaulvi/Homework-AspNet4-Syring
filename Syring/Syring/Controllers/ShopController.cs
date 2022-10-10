using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Syring.DAL;
//using Syring.Models;
using Syring.ViewModels.Shop;

namespace Syring.Controllers
{
    public class ShopController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public ShopController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<IActionResult> Index()
        {
            var product = await _appDbContext.Products.Include(x => x.ProductComponents).ToListAsync();
            var model = new ShopIndexViewModel
            {
                Products = product
            };
            return View(model);
        }
    }
}
