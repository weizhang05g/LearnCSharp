
using System;
using System.Collections;
using System.Collections.Generic;

namespace ListApp{
  class Program{
    static void Main(string[] args){
      List<int> l1 = new List<int>();
      l1.Add(45);
      l1.AddRange(new int[]{78,33,56,12,23,9});
      PrintList(l1);
      PrintList(new int[]{78,33,56,12,23,9});
      Console.WriteLine("has 56: {0}, Index: {1}",l1.Contains(56),l1.IndexOf(56));
      Console.Write("sort: ");
      l1.Sort();
      PrintList(l1);
    }
    static void PrintList(IEnumerable l1){
      foreach(var nItem in l1){
        Console.Write(nItem+" ");
      }
      Console.WriteLine();
    }
  }
}