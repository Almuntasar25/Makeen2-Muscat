﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAcademyShope.model
{
    public class Category
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? description { get; set; }


        public List<Product> products = new List<Product>();

    }
}
