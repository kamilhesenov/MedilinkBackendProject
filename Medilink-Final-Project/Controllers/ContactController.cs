using Medilink_Final_Project.Data;
using Medilink_Final_Project.Models.Contact;
using Medilink_Final_Project.Models.ViewModel;
using Microsoft.AspNetCore.Identity;
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

        [Route("contact")]
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

        [HttpPost]
        [Route("contact")]
        public IActionResult Send([FromForm] ContactSendViewModel model)
        {
            if (ModelState.IsValid)
            {
                Contact contact = new Contact
                {
                    Name = model.Name,
                    Email = model.Email,
                    Message = model.Message
                };
                _context.Contacts.Add(contact);
                _context.SaveChanges();
               
                return NoContent();
            }
            return NoContent();
        }
    }
}
