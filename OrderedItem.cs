using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resaurant_management_windows
{
    public class OrderedItem
    {
        public string ProductId { get; set; }
        public int Quantity { get; set; }
        public OrderedItem(string id, int quantity)
        {
            ProductId = id;
            Quantity = quantity;
        }
    }
}
