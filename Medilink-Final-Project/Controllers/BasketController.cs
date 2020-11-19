using Medilink_Final_Project.Data;
using Medilink_Final_Project.Models;
using Medilink_Final_Project.Models.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medilink_Final_Project.Controllers
{
    public class BasketController : Controller
    {
        
        private readonly AplicationDbContext _context;
        public BasketController(AplicationDbContext context)
        {
            _context = context;
            
        }

        

        public async Task<IActionResult> AddBasket(int? id)
        {
            if (id == null) return NotFound();
            Shop dbproduct = await _context.Shops.FindAsync(id);

            if (dbproduct == null) return NotFound();
            List<ShopViewModel> products;
            if (Request.Cookies["fbasket"] == null)
            {
                products = new List<ShopViewModel>();
            }
            else
            {
                products = JsonConvert.DeserializeObject<List<ShopViewModel>>(Request.Cookies["fbasket"]);
            }

            ShopViewModel existProduct = products.FirstOrDefault(p => p.Id == id);

            if (existProduct == null)
            {
                ShopViewModel newproduct = new ShopViewModel
                {
                    Id = dbproduct.Id,
                    Count = 1
                };
                products.Add(newproduct);
            }
            else
            {
                existProduct.Count++;
            }


            string fbasket = JsonConvert.SerializeObject(products);
            Response.Cookies.Append("fbasket", fbasket, new CookieOptions { MaxAge = TimeSpan.FromDays(14) });

            return RedirectToAction("Index", "Shop");
        }


        public IActionResult ProductCountPlus(int? id)
        {
            string basketProducts = Request.Cookies["fbasket"];
            List<ShopViewModel> products = JsonConvert.DeserializeObject<List<ShopViewModel>>(basketProducts);
            ShopViewModel product = products.FirstOrDefault(p => p.Id == id);
            product.Count++;
            string fbasket = JsonConvert.SerializeObject(products);
            Response.Cookies.Append("fbasket", fbasket, new CookieOptions { MaxAge = TimeSpan.FromDays(14) });

            return RedirectToAction("Index", "Basket");
        }

        public IActionResult ProductCountMinus(int? id)
        {
            string basketProduct = Request.Cookies["fbasket"];
            List<ShopViewModel> products = JsonConvert.DeserializeObject<List<ShopViewModel>>(basketProduct);
            ShopViewModel product = products.FirstOrDefault(p => p.Id == id);

            if (product.Count > 1)
            {
                product.Count--;
            }
            else
            {
                products.Remove(product);
            }

            string fbasket = JsonConvert.SerializeObject(products);
            Response.Cookies.Append("fbasket", fbasket, new CookieOptions { MaxAge = TimeSpan.FromDays(14) });

            return RedirectToAction("Index", "Basket");
        }

        public IActionResult RemoveItem(int? id)
        {
            string basketProduct = Request.Cookies["fbasket"];
            List<ShopViewModel> products = JsonConvert.DeserializeObject<List<ShopViewModel>>(basketProduct);
            ShopViewModel product = products.FirstOrDefault(p => p.Id == id);

            
                products.Remove(product);
            

            string fbasket = JsonConvert.SerializeObject(products);
            Response.Cookies.Append("fbasket", fbasket, new CookieOptions { MaxAge = TimeSpan.FromDays(14) });

            return RedirectToAction("Index", "Basket");
        }


        public async Task<IActionResult> Index()
        {
            ViewBag.BasketCount = 5;
            List<Shop> products = _context.Shops.ToList();
            foreach (Shop item in products)
            {
                ViewBag.dbProductCount = item.Count;
            }

            string fbasket = Request.Cookies["fbasket"];
            List<ShopViewModel> basketProducts = new List<ShopViewModel>();
            if (fbasket != null)
            {
                basketProducts = JsonConvert.DeserializeObject<List<ShopViewModel>>(fbasket);

                foreach (ShopViewModel basketProduct in basketProducts)
                {
                    Shop dbProduct = await _context.Shops.FindAsync(basketProduct.Id);
                    if (dbProduct != null)
                    {
                        basketProduct.Price = dbProduct.Price;
                        basketProduct.Photo = dbProduct.Photo;
                        basketProduct.Name = dbProduct.Name;
                    }

                }
            }

            return View(basketProducts);
        }
    }
}
