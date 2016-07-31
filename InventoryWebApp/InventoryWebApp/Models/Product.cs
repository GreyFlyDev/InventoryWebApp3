﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventoryWebApp.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        public string ProductName { get; set;}
        public int Quantity { get; set; }
        public decimal SalePrice { get; set; }
        public decimal PurchasePricePerUnit { get; set; }
        public decimal TotalInvestmentPerUnit { get; set; }
        public int NumberOfSales { get; set; }
        public decimal InvestmentProgress { get; set; }
        public DateTime DateAdded { get; set; }

        public string UserId { get; set; }
    }
}