
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
            //Console.WriteLine("str->int: {0}",int.Parse(str2));
            int num3;
            int.TryParse(str2,out num3);
            Console.WriteLine("str->int: {0}",num3);
            string str3 = "12f";
            int num4;
            int.TryParse(str3,out num4);
            Console.WriteLine("str->int(12f): {0}",num4);
        }
    }
}