using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventoryManagementSystem.Models
{
    public class Transaction
    {
        private int _transactionID;
        private DateTime _transactionDate;
        private int _productId;
        private String _transactionType;
        private int _qty;
        private int _updatedBy;

        public Transaction(int transactionID, DateTime transactionDate, int productId, string transactionType, int qty, int updatedBy)
        {
            TransactionID = transactionID;
            TransactionDate = transactionDate;
            ProductId = productId;
            TransactionType = transactionType;
            Qty = qty;
            UpdatedBy = updatedBy;
        }

        public int TransactionID { get => _transactionID; set => _transactionID = value; }
        public DateTime TransactionDate { get => _transactionDate; set => _transactionDate = value; }
        public int ProductId { get => _productId; set => _productId = value; }
        public string TransactionType { get => _transactionType; set => _transactionType = value; }
        public int Qty { get => _qty; set => _qty = value; }
        public int UpdatedBy { get => _updatedBy; set => _updatedBy = value; }
    }
}