﻿namespace Store.Web.Models
{
    public class Cart
    {
        //public IDictionary<int, int> Items { get; set; } = new Dictionary<int, int>();
        //public decimal Amount { get; set; }

        public int OrderId { get; }
        public int TotalCount { get; set; }
        public decimal TotalPrice { get; set; }
        public Cart (int orderId)
        {
            OrderId = orderId;
            TotalCount = 0;
            TotalPrice = 0m;
        }
    }
}
