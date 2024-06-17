using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resaurant_management_windows
{
    public class Product
    {
        public string _id {  get; set; }
        public string name { get; set; }
        public float price { get; set; }
        public string description { get; set; }
        public string category { get; set; }
        public bool modify { get; set; }
        public string imageUrl { get; set; }
    }
}
