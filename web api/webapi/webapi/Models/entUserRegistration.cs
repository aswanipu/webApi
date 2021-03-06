﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webapi.Models
{
    public class entUserRegistration
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string location { get; set; }
        public string gender { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string createdDate { get; set; }
        public string lastModified { get; set; }
        public string isActive { get; set; }
    }
}