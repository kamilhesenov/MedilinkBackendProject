using Medilink_Final_Project.Data;
using Medilink_Final_Project.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medilink_Final_Project.Controllers
{
    public class ContactController : Controller
    {
        private readonly AplicationDbContext _context;
        public ContactController(AplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ContactViewModel model = new ContactViewModel
            {
                Setting = _context.Settings.FirstOrDefault(),
                BannerViewModel = new BannerViewModel
                {
                    Title = "Contact"
                }
            };
            return View(model);
        }
    }
}
