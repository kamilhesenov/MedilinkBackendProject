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
    public class AppointmentController : Controller
    {
        private readonly AplicationDbContext _context;
        public AppointmentController(AplicationDbContext context)
        {
            _context = context;
        }

        [Route("appointment")]
        public IActionResult Index()
        {
            AppointmentViewModel model = new AppointmentViewModel
            {
                AppointmentPhoto = _context.AppointmentPhotos.FirstOrDefault(),
                BannerViewModel = new BannerViewModel
                {
                    Title = "Appointment Form"
                },
                Doctors = _context.Doctors.ToList(),
                Departments = _context.Departments.Include(d=>d.Doctors).ToList()
            };
            return View(model);
        }

        public IActionResult GetDoctorsByDepartment(int? id)
        {
            if (id == null) return NotFound();
            var doctors = _context.Doctors.Where(d => d.DepartmentId == id).ToList();
            return PartialView("_getDoctor",doctors);
        }
    }
}
