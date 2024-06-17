using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resaurant_management_windows
{
    public class OrderedItem
    {
        public string _id { get; set; }
        public string productName { get; set; }
        public int quantity { get; set; }
        public float price { get; set; }
        public OrderedItem(string id, string name, int quantity, float price)
        {
            _id = id;
            productName = name;
            this.quantity = quantity;
            this.price = price;
        }
    }
}
