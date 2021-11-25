
using System;

namespace Array1{
    class Program{
        static void Main(string[] args){
            int[] arr1 = new int[]{2,4,6,8};

        }
        public static void PrintArr(int[] arr){
            Console.Write("Array: ")
            foreach(int v in arr){
                Console.Write("{0} ",v);
            }
            Console.WriteLine();
        }
    }
}