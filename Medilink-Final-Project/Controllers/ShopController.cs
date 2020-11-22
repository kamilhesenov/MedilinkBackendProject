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

        [Route("products")]
        public IActionResult Index(string name)
        {
            ShopViewModel model = new ShopViewModel();
            BannerViewModel bannerView = new BannerViewModel
            {
                Title = "Products"
            };
            model.BannerViewModel = bannerView;

            if(name != null)
            {
                model.Shops = _context.Shops.Where(s => s.Name.ToLower().Contains(name.ToLower())).ToList();
                return View(model);
            }
            else
            {
                model.Shops = _context.Shops.ToList();
                return View(model);
            }

            
        }
    }
}
