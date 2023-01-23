using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevexpressProject
{
    public class OrderDetail
    {
        public int OrderID { get; set; }
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }  
        public int Quantity { get; set; }
        public decimal Discount { get; set; }
        [Display(Name = "Unit Price")] 
        public decimal UnitPrice { get; set; }
        public decimal Total
        {
            get { return Quantity * UnitPrice - Quantity * UnitPrice * Discount; 
            }
        }



    }
}
