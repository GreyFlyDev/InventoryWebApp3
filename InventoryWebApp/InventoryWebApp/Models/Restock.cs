using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventoryWebApp.Models
{
    public class Restock
    {
        public int RestockId { get; set; }

        public int Quantity { get; set; }
        public decimal PurchasePricePerUnit { get; set; }
        public decimal TotalInvestment { get; set; }
        public DateTime RestockDate { get; set; }

        public int ProductId { get; set; }
        public string UserId { get; set; }
    }
}