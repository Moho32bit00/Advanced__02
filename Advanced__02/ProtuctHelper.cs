using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced__02
{
    public delegate bool filter<T>( T value);
    public static  class ProtuctHelper<T>
    {
        public static List<T> SearchProducts(List<T> listofPro , filter <T> f)
        {
            List <T> result = new List<T>();
            foreach (T product in listofPro)
            {
                if (f(product))
                {
                    result.Add(product);
                }
            }
            return result;
        }
    }
    public static class FilterHelper
    {
        public static bool Cheaper_50(Product p)
        {
        return p.Price < 50;    
        }

        public static bool Clothes_under_100 (Product p)
        {
            return p.Category == "Clothing" && p.Price < 100;
        }
        public static bool in_stock(Product p)
        {
            return p.Stock > 0 ;
        }
        public static bool All_elctro(Product p)
        {
            return p.Category == "Electronics";
        }
    }
}
