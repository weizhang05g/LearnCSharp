using System;

  class Demo{
    static void Main(string[] args){
      int[] arr1 = new int[]{3,6,6,7,5,2,8};
      foreach(int v in arr1)
      {
        Console.Write("{0} ",v);
      }
      Console.WriteLine();
      Array.Sort(arr1);
      foreach(int v in arr1){
        Console.Write("{0} ",v);
      }
      Console.ReadKey();
    }
  }

