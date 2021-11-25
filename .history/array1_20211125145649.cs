
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

            PrintArr1(arr2);
            Console.WriteLine("Lenght: {0} {1} {2}", arr2.Length,arr2.GetLength(0),arr2.GetLength(1));
            Console.WriteLine("Rank: {0}",arr2.Rank);

            int[][] arr3 = {
                new int[]{2,4},
                new int[]{1,3,5,7}
            };
            PrintArr3(arr3);
        }
        public static void PrintArr(int[] arr){
            Console.Write("Array: ");
            foreach(int v in arr){
                Console.Write("{0} ",v);
            }
            Console.WriteLine();
        }
        public static void PrintArr1(int[,] arr){
            //int n = arr.Rank;
            Console.WriteLine("Array: ");
            for(int i = 0;i< arr.GetLength(0); i++){
                for(int t = 0 ; t < arr.GetLength(1); t++){
                    Console.Write("{0} ", arr[i,t]);
                }
                Console.WriteLine();
            }
        }
        public static void PrintArr3(int[][] arr){
            Console.WriteLine("Array[][]:");
            for(int i = 0;i < arr.Length;i++){
                for(int j = 0 ; j < arr[i].Length; j++){
                    Console.Write("{0} ",arr[i][j]);
                }
                Console.WriteLine();
            }
        }

    }
}