using System;

namespace TypedRefs
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 42;

            var r = __makeref(x);

            Foo(r);
        }

        static void Foo(TypedReference r)
        {
        }
    }
}
