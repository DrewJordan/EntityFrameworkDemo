using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrameworkDemo.Models
{
    public class Invoice
    {
        public int ID { get; set; }
        public decimal AmountDue { get; set; }
        public DateTime DueDate { get; set; }
        public int ClientID { get; set; }
        public int ProjectID { get; set; }

        public virtual Client Client { get; set; }
        public virtual Project Project { get; set; }
    }
}