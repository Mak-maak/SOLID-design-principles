namespace LiskovSubstitutionPrinciple
{
    class Program
    {
        static public int Area(Rectangle r) => r.Width * r.Height;

        static void Main(string[] args)
        {
            Rectangle rc = new Rectangle(2,3);
            System.Console.WriteLine($"{rc} has a area {Area(rc)}");

            Rectangle sq = new Square();
            sq.Width = 4;
            System.Console.WriteLine($"{sq} has a area {Area(sq)}");
        }
    }
}
