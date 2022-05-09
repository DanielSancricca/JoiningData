using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoiningData
{
    class CustomerOrder
    {
        public string CustomerName { get; set; }
        public string Item { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }

        public CustomerOrder(string customerName, string item, float price, int quantity)
        {
            this.CustomerName = customerName;
            this.Item = item;
            this.Price = price;
            this.Quantity = quantity;
        }
    }
}
