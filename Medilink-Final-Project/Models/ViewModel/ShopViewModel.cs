using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medilink_Final_Project.Models.ViewModel
{
    public class ShopViewModel
    {
        public int Id { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        public BannerViewModel BannerViewModel { get; set; }
        public List<Shop> Shops { get; set; }
        public int DbCount { get; set; }
    }
}
