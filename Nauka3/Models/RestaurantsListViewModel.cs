﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nauka3.Models
{
    public class RestaurantsListViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int CountOfReviews{ get; set; }
    }
}