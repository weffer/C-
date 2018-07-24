namespace GenericVariance
{
    class Program
    {
        static void Main()
        {
            // Implement a covariant and contravariant generic interface
            // using the sample type hierarchy below.
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
