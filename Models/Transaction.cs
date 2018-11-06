using System;
using System.Collections.Generic;

namespace storeStation.Models{
    class Transaction{
        public int transactionID { get; set; }
        public DateTime timestamp { get; set; }
        public float totalValue { get; set; }
        public ICollection<Product> productList { get; set; }
    }
    
}