using System;
using System.Collections;
using System.ComponentModel;

namespace Chapter01.CSharp1
{
    [Description("Listing 1.05")]
    class ArrayListSort
    {
        class ProductNameComparer : IComparer
        {
            public int Compare(object x, object y)
            {
                Product first = (Product)x;
                Product seconde = (Product)y;
                return first.Name.CompareTo(seconde.Name);
            }
        }
        static void Main()
        {
            ArrayList products = Product.GetSampleProducts();
            products.Sort(new ProductNameComparer());
            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }
        }
    }
}
