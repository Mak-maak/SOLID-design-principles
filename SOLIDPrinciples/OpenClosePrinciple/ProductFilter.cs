using System.Collections.Generic;

namespace OpenClosePrinciple
{
    public class ProductFilter
    {
        public IEnumerable<Product> FilterProductBySize(IEnumerable<Product> products, Size size)
        {
            foreach (Product p in products)
                if (p.Size == size)
                    yield return p;
        }

        public IEnumerable<Product> FilterProductByColor(IEnumerable<Product> products, Color color)
        {
            foreach (Product p in products)
                if (p.Color == color)
                    yield return p;
        }

        public IEnumerable<Product> FilterProductByColorAndSize(IEnumerable<Product> products, Size size, Color color)
        {
            foreach (Product p in products)
                if (p.Size == size && p.Color == color)
                    yield return p;
        }
    }
}
