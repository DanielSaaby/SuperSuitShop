using System;
using System.Collections.Generic;
using System.Text;

namespace SuperSuitShop.Core.Entities
{
    public class SuperSuit
    {
        public int Id { get; set; }

        public String Name { get; set; }

        public String Type { get; set; }

        public double Price { get; set; }

        public String Description { get; set; }

        public String ImageUrl { get; set; }
    }
}
