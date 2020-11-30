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


        //public async Task<IActionResult> AddBasket(int? id)
        //{
        //    if (id == null) return NotFound();
        //    if (!User.Identity.IsAuthenticated)
        //    {
        //        return RedirectToAction("Login", "Account");
        //    }

        //    if (User.Identity.IsAuthenticated)
        //    {
        //        Shop dbproduct = await _context.Shops.FindAsync(id);
        //        if (dbproduct == null) return NotFound();
        //    }

        //    Shop product = await _context.Shops.FindAsync(id);
        //    if (product == null) return NotFound();
        //    List<ShopViewModel> products;
        //    if (Request.Cookies["basket"] == null)
        //    {
        //        products = new List<ShopViewModel>();
        //    }
        //    else
        //    {
        //        products = JsonConvert.DeserializeObject<List<ShopViewModel>>(Request.Cookies["basket"]);
        //    }
        //    ShopViewModel existProduct = products.FirstOrDefault(p => p.Id == id && p.UserName == User.Identity.Name);
        //    if (existProduct == null)
        //    {
        //        ShopViewModel newProduct = new ShopViewModel
        //        {
        //            Id = product.Id,
        //            Count = 1,
        //            UserName = User.Identity.Name
        //        };
        //        products.Add(newProduct);
        //    }
        //    else
        //    {
        //        if(existProduct.Count < product.Count)
        //        {
        //            existProduct.Count++;
        //        }
        //    }

        //    string basket2 = JsonConvert.SerializeObject(products);
        //    Response.Cookies.Append("basket", basket2, new CookieOptions { MaxAge = TimeSpan.FromDays(30) });

        //    if (Request.Headers["X-Request-With"] == "XMLHttpRequest")
        //    {
        //        return RedirectToAction("Basket");
        //    }
        //    return Json(products.Where(p => p.UserName == User.Identity.Name).Count());
        //}


        //public async Task<IActionResult> AddBasket(int? id)
        //{
        //    if (id == null) return NotFound();
        //    Shop dbproduct = await _context.Shops.FindAsync(id);

        //    if (dbproduct == null) return NotFound();
        //    List<ShopViewModel> products;
        //    if (Request.Cookies["fbasket"] == null)
        //    {
        //        products = new List<ShopViewModel>();
        //    }
        //    else
        //    {
        //        products = JsonConvert.DeserializeObject<List<ShopViewModel>>(Request.Cookies["fbasket"]);
        //    }

        //    ShopViewModel existProduct = products.FirstOrDefault(p => p.Id == id);

        //    if (existProduct == null)
        //    {
        //        ShopViewModel newproduct = new ShopViewModel
        //        {
        //            Id = dbproduct.Id,
        //            Count = 1
        //        };
        //        products.Add(newproduct);
        //    }
        //    else
        //    {
        //        existProduct.Count++;
        //    }


        //    string fbasket = JsonConvert.SerializeObject(products);
        //    Response.Cookies.Append("fbasket", fbasket, new CookieOptions { MaxAge = TimeSpan.FromDays(14) });

        //    return Json(products.Count());
        //}

        [Route("basket")]
        public async Task<IActionResult> Index()
        {


            string fbasket = Request.Cookies["basket"];
            List<BasketViewModel> basketProducts = new List<BasketViewModel>();
            if (fbasket != null)
            {
                basketProducts = JsonConvert.DeserializeObject<List<BasketViewModel>>(fbasket);

                foreach (BasketViewModel basketProduct in basketProducts)
                {
                    Shop dbProduct = await _context.Shops.FindAsync(basketProduct.Id);
                    if (dbProduct != null)
                    {
                        basketProduct.Price = dbProduct.Price;
                        basketProduct.Photo = dbProduct.Photo;
                        basketProduct.Name = dbProduct.Name;
                        basketProduct.DbCount = dbProduct.Count;
                    }

                }
            }

            return View(basketProducts.Where(x=>x.UserName == User.Identity.Name));

        }

        public async Task<IActionResult> AddBasket(int? id)
        {
            if (id == null) return NotFound();
            if (User.Identity.IsAuthenticated)
            {
                Shop product = await _context.Shops.FindAsync(id);
                if (product == null) return NotFound();

                List<BasketViewModel> products;
                string existBasket = Request.Cookies["basket"];
                if (existBasket == null)
                {
                    products = new List<BasketViewModel>();
                }
                else
                {
                    products = JsonConvert.DeserializeObject<List<BasketViewModel>>(existBasket);
                }

                BasketViewModel existProduct = products.FirstOrDefault(p => p.Id == id && p.UserName == User.Identity.Name);
                if (existProduct == null)
                {
                    BasketViewModel newProduct = new BasketViewModel
                    {
                        Id = product.Id,
                        Count = 1,
                        UserName = User.Identity.Name

                    };
                    products.Add(newProduct);
                }
                else
                {
                    if (product.Count > existProduct.Count)
                    {
                        existProduct.Count++;
                    }
                }
                

                string basket = JsonConvert.SerializeObject(products);
                Response.Cookies.Append("basket", basket, new CookieOptions { MaxAge = TimeSpan.FromDays(14) });
                return RedirectToAction("Index","Shop");

            }
            return RedirectToAction("Login", "Account");
        }


        public IActionResult ProductCountPlus(int? id)
        {
            string basketProducts = Request.Cookies["basket"];
            List<BasketViewModel> products = JsonConvert.DeserializeObject<List<BasketViewModel>>(basketProducts);
            BasketViewModel product = products.FirstOrDefault(p => p.Id == id);
            product.Count++;
            string fbasket = JsonConvert.SerializeObject(products);
            Response.Cookies.Append("basket", fbasket, new CookieOptions { MaxAge = TimeSpan.FromDays(14) });

            return RedirectToAction("Index", "Basket");
        }

        public IActionResult ProductCountMinus(int? id)
        {
            string basketProduct = Request.Cookies["basket"];
            List<BasketViewModel> products = JsonConvert.DeserializeObject<List<BasketViewModel>>(basketProduct);
            BasketViewModel product = products.FirstOrDefault(p => p.Id == id);

            if (product.Count > 1)
            {
                product.Count--;
            }
            else
            {
                products.Remove(product);
            }

            string fbasket = JsonConvert.SerializeObject(products);
            Response.Cookies.Append("basket", fbasket, new CookieOptions { MaxAge = TimeSpan.FromDays(14) });

            return RedirectToAction("Index", "Basket");
        }

        public IActionResult RemoveItem(int? id)
        {
            string basketProduct = Request.Cookies["basket"];
            List<BasketViewModel> products = JsonConvert.DeserializeObject<List<BasketViewModel>>(basketProduct);
            BasketViewModel product = products.FirstOrDefault(p => p.Id == id);
             
            products.Remove(product);
            
            string fbasket = JsonConvert.SerializeObject(products);
            Response.Cookies.Append("basket", fbasket, new CookieOptions { MaxAge = TimeSpan.FromDays(14) });

            if (HttpContext.Request.Headers["x-requested-with"] != "XMLHttpRequest")
            {
                return RedirectToAction("Index", "Basket");
            }
                
            return RedirectToAction("Index", "Basket");
        }


        
    }
}
