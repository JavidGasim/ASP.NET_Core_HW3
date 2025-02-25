﻿using System.Runtime.InteropServices;

namespace ASP.NET_Core_HW3.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Discount { get; set; }
        public int Price { get; set; }
        public string ImgLink { get; set; }
    }
}
