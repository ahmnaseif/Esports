﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ESports.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
    }

}