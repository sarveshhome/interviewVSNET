using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class uncheckeddemo
    {
        static void Main(string[] args)
        {
            const int a = 2147483647;
            const int b = 2147483647;

            //int c =a + b; //The operation overflows at compile time in checked mode 
            //bypass this behaviour by unchecked
            int c = unchecked(a + b);
            Console.WriteLine(c);
        }
    }
}
