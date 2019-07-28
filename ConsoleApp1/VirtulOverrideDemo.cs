using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class VirtulOverrideDemo
    {
        static void Main(string[] args)
        {
            int x = -12;
            x -= -21;
            //x = x - (-21);
            Console.WriteLine(x);
            //A obj = new A();
            //B obj = new B();
            A obj = new B();
            obj.f1(); obj.f2(); obj.f3();
            Console.ReadKey();

        }
    }
    class A
    {
        public void f1() { Console.WriteLine(" f1 of A"); }
        public virtual void f2() { Console.WriteLine(" f2 of A"); }
        public virtual void f3() { Console.WriteLine(" f3 of A"); }
    }
    class B : A
    {
        new public void f1()
        {
            Console.WriteLine(" f1 of B");
        }
        public override void f2()
        {
            Console.WriteLine(" f2 of B");
        }
        public new void f3() { Console.WriteLine(" f3 of B"); }
    }
}
    