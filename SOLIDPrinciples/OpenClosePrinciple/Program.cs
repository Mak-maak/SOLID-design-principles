using OpenClosePrinciple;
using static System.Console;

namespace OpenClosedPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Product apple = new Product("Apple", Color.Green, Size.Small);
            Product tree = new Product("Tree", Color.Green, Size.Small);
            Product house = new Product("House", Color.Blue, Size.Large);

            Product[] products = { apple, tree, house };

            // old
            ProductFilter pf = new ProductFilter();
            WriteLine("Green products (old):");
            foreach (Product p in pf.FilterProductByColor(products, Color.Green))
            {
                WriteLine($" - {p.Name} is green");
            }

            // new
            BetterFilter bf = new BetterFilter();
            WriteLine("\nGreen products (new):");
            foreach (Product p in bf.Filter(products, new ColorSpecification(Color.Green)))
            {
                WriteLine($" - {p.Name} is green");
            }

            // combinator
            WriteLine("\nLarge blue items");
            foreach (Product p in bf.Filter(
                products,
                new AndSpecification<Product>(
                    new ColorSpecification(Color.Blue),
                    new SizeSpecification(Size.Large)
                    )))
            {
                WriteLine($" - {p.Name} is large and blue");
            }
        }
    }
}
