
using System;

namespace String1{
    class Program{
        static void Main(string[] args){
            string lan = "this is a string sample.";
            Console.WriteLine("{0}",lan);
            Console.WriteLine("length: {0}, index3: {1}, find\"str\": {2}",
            lan.Length,lan[3],lan.IndexOf("str"));
            Console.WriteLine("Upper: {0}",lan.ToUpper());
            
            string lan1 = lan.Trim();
            Console.WriteLine("trim: {0} {1}",lan1,lan.Trim());
            char[] carr1 = lan1.ToCharArray();
            foreach(char v in carr1){
                Console.Write("\'{0}\' ",v);
            }
            Console.WriteLine();
        }
    }
}