using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ClassDisposeDemo
    {
        static void Main(string[] args)
        {
            MyClass objMyClass = new MyClass();
            objMyClass.Dispose();
        }

        
    }
    class MyClass:IDisposable
    {
        ~MyClass()
        {

        }

        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }
    }
}
