
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
            Console.WriteLine("substring(2,4): {0}",lan.Substring(2,4));
            string lan2 = lan.Insert(4,"XXX");
            Console.WriteLine("Insert: {0} ## {1}", lan2,lan);
            string lan3 = lan.Remove(2,4);
            Console.WriteLine("Remove(2,4) {0} ## {1}", lan3, lan);

            string lan4 = lan.Replace('a','X');
            Console.WriteLine("Replace(a,X): {0} ## {1}", lan4, lan);

            string[] saar1 = lan.Split(' ');
            Console.WriteLine("Split( ): {0} && {1} && {2} ## {3}", sarr1[0],sarr1[1],sarr1[2],lan);
        }
    }
}