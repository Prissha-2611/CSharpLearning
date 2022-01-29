using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
//using System;

//namespace MyFirstProgram
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello World!");
//        }
//        static float FahrenheitToCelcius(float temperatureFahrenheit)
//        {
//            var temperatureCelcius = (temperatureFahrenheit - 32) / 1.8f;
//            return temperatureCelcius;
//        }
//    }
//}

//using System;

//namespace MyFirstProgram
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello World!");
//        }
//        static float FahrenheitToCelcius(float temperatureFahrenheit)
//        {
//            float temperatureCelcius = (temperatureFahrenheit - 32) / 1.8f;
//            return temperatureCelcius;
//        }
//    }
//}

//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        var numbers = new int[] { 1, 2, 3, 4, 5 };
//        var sum = numbers.Aggregate(
//            0,
//            (total, num) => {
//                Console.WriteLine("total = {0},num = {1}", total, num);
//                return total + num;
//            }
//        );

//        Console.WriteLine(sum);
//    }
//}


//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        var numbers = new int[] { 1, 2, 3, 4, 5 };
//        var sum = numbers.Aggregate(
//            0,
//            (total, sum) => total + sum
//            );

//        Console.WriteLine(sum);
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        var numbers = new int[] { 1, 2, 3, 4, 5 };
//        var type = numbers.GetType();

//        do
//        {
//            System.Console.WriteLine(type.FullName);
//            type = type.BaseType;
//        }
//        while (type != null);

//    }
//}

//class Program
//{
//    static void Main()
//    {
//        var numbers = new int[] { 1, 2, 3, 4, 5 };
//        var type = numbers.GetType();

//        System.Console.WriteLine(type.FullName);
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        var numbers = new int[] { 1, 2, 3, 4, 5 };
//        var sum = 0;

//        for (var n = 0; n < numbers.Length; n++)
//        {
//            sum += numbers[n];
//        }

//        System.Console.WriteLine(sum);
//    }
//}

//class Program
//{
//    static int Main(string[] args)
//    {
//        Console.WriteLine("Hello, World!");

//        for (var n = 0; n < args.Length;n++)
//        {
//            Console.WriteLine("args[{0}] = {1}", n, args[n]);
//        }
//        return 0;
//    }
//}


//namespace HelloWorld
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello World!");
//        }
//    }
//}
