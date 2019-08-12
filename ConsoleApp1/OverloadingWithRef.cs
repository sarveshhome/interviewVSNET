using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class OverloadingWithRef
    {
        static void Main(string[] args)
        {
            string Name= "Tarun";
            Student objStudent = new Student();

            objStudent.profile(ref Name, "Goa");
            objStudent.profile(Name, "Shimla");            
        }
    }
    class Student
    {
        static Student()
        {

        }
        public string profile(string Name, string Address)
        {
            return "";
        }
        public string profile(ref string Name, string Address)
        {
            Name = "Hina";
            return "";
        }
        //public string profile(out string Name, string Address)
        //{
        //    Name = "Ta";
        //    return "";
        //}

    }
}
