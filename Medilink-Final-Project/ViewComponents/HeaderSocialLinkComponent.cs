using Medilink_Final_Project.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medilink_Final_Project.ViewComponents
{
    public class HeaderSocialLinkComponent : ViewComponent
    {
        private readonly AplicationDbContext _context;
        public HeaderSocialLinkComponent(AplicationDbContext context)
        {
            _context = context;
        }

        public ViewViewComponentResult Invoke()
        {
            var headerSocialLink = _context.SocialLinks.FirstOrDefault();

            return View(headerSocialLink);
        }
    }
}
