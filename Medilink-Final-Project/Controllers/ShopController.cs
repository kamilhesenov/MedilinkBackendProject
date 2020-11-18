using Medilink_Final_Project.Data;
using Medilink_Final_Project.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medilink_Final_Project.Controllers
{
    public class ShopController : Controller
    {
        private readonly AplicationDbContext _context;
        public ShopController(AplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ShopViewModel model = new ShopViewModel
            {
                Shops = _context.Shops.ToList(),
                BannerViewModel = new BannerViewModel
                {
                    Title = "Products"
                }
            };
            return View(model);
        }
    }
}
