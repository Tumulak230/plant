﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace MoralesFiFthCRUD.ViewModels
{
    public class ProductViewModel
    {
        public int UserId { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public byte[] ProductImg { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string sellerName { get; set; }
        
        public string BuyerName { get; set; }
        public int CategoryId { get; set; }
        public bool SoldOut { get; set; }
        public decimal TotalCartPrice { get; set; }


        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        public bool IsFeatured { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string EmailId { get; set; }
        public object Name { get; internal set; }

        public int Id { get; set; }
     

    }
}