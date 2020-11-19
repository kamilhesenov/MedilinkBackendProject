using Medilink_Final_Project.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medilink_Final_Project.ViewComponents
{
    public class HeaderViewBagComponent : ViewComponent
    {
        public  ViewViewComponentResult Invoke()
        {
            List<ShopViewModel> products = JsonConvert.DeserializeObject<List<ShopViewModel>>(Request.Cookies["fbasket"]);
              ViewBag.BasketCount = products.Count;

            return View();
         }
    }
}
