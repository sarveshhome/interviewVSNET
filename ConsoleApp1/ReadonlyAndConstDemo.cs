using System;

namespace ConsoleApp1
{
    class ReadonlyAndConstDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Sample objsample = new Sample("sarvesh");
            Console.WriteLine(objsample.ToString());
            Sample objsample2 = new Sample("Tarun");
            Console.WriteLine(objsample2.ToString());
            Console.ReadLine();

        }
    }
    public class Sample
    {
        private readonly string ro;
        private const double PI=3.14 ;
        public Sample()
        {
            // PI = 3.14159;//Error: The left-hand side of an assignment must be a variable, property or indexer 
            ro = "set";
        }

        public Sample(string value) 
        {
           // PI = 3.14159;// Error:  The left-hand side of an assignment must be a variable, property or indexer 

             ro = value; 
        }
        public override string ToString() => ro;
    }
}
