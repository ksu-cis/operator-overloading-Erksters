using System;

namespace VectorMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fun with vectors");

            Vector3 one = new Vector3(1, 2, 3);
            Vector3 two = new Vector3(2, 3, 4);

            Console.WriteLine($"Adding two vectos {Vector3.Add(one , two)}");
            Console.WriteLine($"With Operator overloading {Vector3.Add(one , two)}");

            //one.Add(two);

            Console.WriteLine($"With a class method {one}");
            Console.WriteLine($"Veector Scaling {one * 10} ");
            Console.WriteLine($"Vector Comparison {one == two}");
            Console.WriteLine($"Vector Comparison again {one == new Vector3(5, 4 ,3 )}");

        }
    }
}
