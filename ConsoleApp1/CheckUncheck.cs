using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    #region Description Max and Min Value
    /*
                Name					Value									 Type
                Int32.MaxValue	    2147483647	   	        			             int
                Int32.MinValue	    -2147483648	        			                 int
                Int16.MaxValue	    32767				        			         short
                Int16.MinValue	    -32768				        			         short
                Byte.MaxValue	    255					        			         byte
                Byte.MinValue	    0						        		       	 byte
                Char.MaxValue	    65535 '\uffff'		        			         char
                Char.MinValue	    0 '\0'					        		       	 char
                Double.MaxValue	1.7976931348623157E+308	  double 

         */
    #endregion
    class CheckUncheck
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 2147483647;
                int b = 2147483647;

                //int c = a + b; //output : -2

                int c = checked(a + b); //System.OverflowException: 'Arithmetic operation resulted in an overflow.'

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

            }
        }
       
    }

}
