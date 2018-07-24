namespace BrokenArrayVariance
{
    class Program
    {
        static void Main(string[] args)
        {
            Apple[] apples = new[] { new Apple() };
            // Use array covariance to illustrate its broken (by design) nature.
        }
    }

    class Fruit
    {
    }

    class Apple : Fruit
    {
        public void Peel() { }
    }

    class Coconut : Fruit
    {
        public void Break() { }
    }
}
