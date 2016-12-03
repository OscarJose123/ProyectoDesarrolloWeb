﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArtesaniasMombacho.Models
{
    public class Product
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public string Price { get; set; }
        public int? CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}