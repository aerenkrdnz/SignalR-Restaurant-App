﻿using SignalR.EntityLayer.Entities;
using SignalRApi.EntityLayer.Entities;

namespace SignalRApi.Models
{
    public class ResultBasketListWithProducts
    {
        public int BasketID { get; set; }
        public decimal Price { get; set; }
        public decimal Count { get; set; }
        public decimal TotalPrice { get; set; }

        //Relational Property
        public string ProductName { get; set; }
        public int ProductID { get; set; }
        public int MenuTableID { get; set; }
    }
}
