using System;
using System.Collections.Generic;

namespace CheckMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello welcome to Generics Problem");
            int output = Maximum.MaxIntNum(2, 5, 7,9);
            Console.WriteLine(output);

            //double output = FloatValue.MaxIntNum(1.6, 3.2, 9.8, 71.2);
            //Console.WriteLine(output);

            string output = StringValue.MaxString("AC", "MO", "PZ","ZA");
            Console.WriteLine(output);
        }


    }

    
}