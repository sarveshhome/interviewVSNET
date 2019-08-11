using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class TupleVsAnonymousType
    {
        static void Main(string[] args)
        {
            string str = "Shashi Ranjan Pravat 9871355123";
            string strFirstName = "";
            string strMiddleName = "";
            string strLastName = "";
            double phoneNumer = 0;
            ManuplateParseData(str, out strFirstName, out strMiddleName,out strLastName,out phoneNumer);
            Console.WriteLine("FirstName :" + strFirstName);
            Console.WriteLine("MiddleName :" + strMiddleName);
            Console.WriteLine("LastName :" + strLastName);
            Console.WriteLine("Phone Numer : " + phoneNumer);

            Console.ReadLine();
        }
        static void ManuplateParseData(string strData,out string strFirstName,out string strMiddleName,out string strLastName,out double phoneNumber)
        {
            string[] ArrData = new string[3];
            ArrData = strData.Split(' ');
            strFirstName = ArrData[0];
            strMiddleName = ArrData[1];
            strLastName = ArrData[2];
            phoneNumber = Convert.ToDouble(ArrData[3]);
        }

    }
}
