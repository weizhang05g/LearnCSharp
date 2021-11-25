
using System;

namespace ConvertSample{
    class Program{
        static void Main(string[] args){
            long num1 = 3000;
            int num2 = (int)num1;
            Console.WriteLine(num2);
            string str1 = "12";
            string str2 = "12g";
            Console.WriteLine("str->int: {0}",int.Parse(str1));
            Console.WriteLine("str->int: {0}",int.Parse(str2));
        }
    }
}