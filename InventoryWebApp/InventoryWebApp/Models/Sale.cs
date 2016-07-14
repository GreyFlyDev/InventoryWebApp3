using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventoryWebApp.Models
{
    public class Sale
    {
        public int SaleId { get; set; }

        public int QuantityPurchase { get; set; }
        public decimal SalePrice { get; set; }
        public decimal TotalSalePrice { get; set; }
        public DateTime SaleDate { get; set; }

        public int ProductId { get; set; }
        public string UserId { get; set; }
    }
}