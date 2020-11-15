using Medilink_Final_Project.Data;
using Medilink_Final_Project.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medilink_Final_Project.Controllers
{
    public class DoctorSearchController : Controller
    {
        private readonly AplicationDbContext _context;
        public DoctorSearchController(AplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.Departments = _context.Departments.ToList();
            DoctorSearchViewModel model = new DoctorSearchViewModel
            {
                Doctors = _context.Doctors.Include(d => d.Department).ToList(),
                BannerViewModel = new BannerViewModel
                {
                    Title = "Doctors Search"
                }
            };
            return View(model);
        }
    }
}
