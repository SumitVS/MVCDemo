﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCDemo.Models;

namespace MVCDemo.ViewModels
{
    public class DynamicDDLViewModel
    {
        public List<Country> Countries { get; set; }
        public List<State> States { get; set; }
        public List<City> Cities { get; set; }
    }
}