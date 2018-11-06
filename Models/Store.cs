using System;
using System.Collections;
using System.Collections.Generic;
using System.Device.Location;

namespace storeStation.Models {
    public class Store{
        public int storeID { get; set; }
        public string name { get; set; }
        public string organization { get; set; }
        public GeoCoordinate location { get; set; }
        public ICollection<Product> products {get;set;}
        ICollection<Transaction> transactions {get;set;}
    }
    
}