using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventoryManagementSystem.Models
{
    public class ProductMaster
    { 
        private int _productId;
        private string _productName;
        private long _availableQty;

        public ProductMaster(int productId, string productName, long availableQty)
        {
            ProductId = productId;
            ProductName = productName;
            AvailableQty = availableQty;
        }

        public int ProductId { get => _productId; set => _productId = value; }
        public string ProductName { get => _productName; set => _productName = value; }
        public long AvailableQty { get => _availableQty; set => _availableQty = value; }
    }
}