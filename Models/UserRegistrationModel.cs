﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DynamicWeb.Models
{
    public class UserRegistrationModel
    {
        
        public UserRegistrationModel()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public string name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
    }
}