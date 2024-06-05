using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resaurant_management_windows
{
    public class Table
    {
        public string _id {  get; set; }
        public string tableName { get; set; }
        public bool isBooked { get; set; }
        public List<OrderedItem> orderedItems { get; set; }
        public int numberOfSeats { get; set; }
        public string notes { get; set; }
        public DateTime? startTime { get; set; }
        public DateTime? endTime { get; set; }
        public decimal total { get; set; }
        public bool paid { get; set; }
    }
}
