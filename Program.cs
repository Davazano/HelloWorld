using System;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // print Hello mono world message
            Console.WriteLine("Hello Mono World");

            /*
             This is a multiline comment
            Another statement can be here
             */
            int age = 23;
            Console.Write("Age: ");
            Console.WriteLine(age);

            bool isRunning = true;
            Console.Write("is running: ");
            Console.WriteLine(isRunning);

            float weight = 100.12f;
            Console.Write("weight: ");
            Console.WriteLine(weight);

            Double height = 1.75;
            Console.Write("height: ");
            Console.WriteLine(height);

            char bloodGroup = 'A';
            Console.Write("bloodGroup: ");
            Console.WriteLine(bloodGroup);

            string moto = "Good thinking, good product.";
            Console.Write("moto: ");
            Console.WriteLine(moto);

            const double Pi = 3.14159;
            Console.Write("Pi: ");
            Console.WriteLine(Pi);

            Console.ReadKey(true);
        }
    }
}
