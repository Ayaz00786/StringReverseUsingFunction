using System;
using System.Collections.Generic;
using System.Text;

namespace StringReverseUsingFunction
{
    internal class Class1
    {
        public static void reverse()
        {
            Console.WriteLine("Enter a String Data:");
            string data= Console.ReadLine();

            char[] charArr = data.ToCharArray();

            string reverse = "";
            int length = data.Length - 1;

            while (length >= 0)
            {
                reverse += data[length];
                length--;
            }

            Console.WriteLine("\nReverse String Will Be: {0} ",reverse);

            Console.WriteLine();
            Console.ReadLine();
        }
        

    }
}
