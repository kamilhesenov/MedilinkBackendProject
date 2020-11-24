using Medilink_Final_Project.Data;
using Medilink_Final_Project.Models.Appointment;
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

        [HttpPost]
        
        public IActionResult Send(AppointmentSendViewModel model)
        {
            if (string.IsNullOrEmpty(model.DoctorId.ToString()) || string.IsNullOrEmpty(model.PatientName) || string.IsNullOrEmpty(model.Email) || string.IsNullOrEmpty(model.Text) || model.Date == null || model.Time == null || string.IsNullOrEmpty(model.Phone))
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                Appointment appointment = new Appointment
                {

                    DoctorId = model.DoctorId,
                    PatientName = model.PatientName,
                    Phone = model.Phone,
                    Email = model.Email,
                    Date = model.Date,
                    Time = model.Time,
                    Text = model.Text
                };

                _context.Appointments.Add(appointment);
                _context.SaveChanges();

                return NoContent();
            }

            return View();
        }
    }
}
