using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevexpressProject
{
    public class Orders
    {
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        [Display(Name = "Contact Name")]
        public string ContactName { get; set; }
        public string Address { get; set; }
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public DateTime OrderDate { get; set; }

    }
}
