
using System;

namespace Array1{
    class Program{
        static void Main(string[] args){
            int[] arr1 = new int[]{2,4,6,8};
            PrintArr(arr1);
            Console.WriteLine("Length: {0}", arr1.Length);

            int[,] arr2 = new int[,]{
                {2,4,6,8},
                {1,3,5,7}
            };
            PrintArr(arr2);
        }
        public static void PrintArr(int[] arr){
            Console.Write("Array: ");
            foreach(int v in arr){
                Console.Write("{0} ",v);
            }
            Console.WriteLine();
        }
        public static void PrintArr1(int[,] arr){
            int n = arr.Rank;
            for(int i = 0;i< arr.GetLength(0))
        }

    }
}