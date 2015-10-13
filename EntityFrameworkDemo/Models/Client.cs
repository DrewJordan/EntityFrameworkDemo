﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrameworkDemo.Models
{
    public class Client
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<Project> Projects { get; set; }
        public ICollection<Invoice> Invoices { get; set; } 
    }
}