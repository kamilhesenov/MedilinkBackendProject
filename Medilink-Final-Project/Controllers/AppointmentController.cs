using Medilink_Final_Project.Data;
using Medilink_Final_Project.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medilink_Final_Project.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly AplicationDbContext _context;
        public AppointmentController(AplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            AppointmentViewModel model = new AppointmentViewModel
            {
                AppointmentPhoto = _context.AppointmentPhotos.FirstOrDefault(),
                BannerViewModel = new BannerViewModel
                {
                    Title = "Appointment Form"
                }
            };
            return View(model);
        }
    }
}
