using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced__02
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public override string ToString()
        {
            return $"->Name: {Name} | Category: {Category} | Price: {Price} | Stock: {Stock}";
        }

    }
}
