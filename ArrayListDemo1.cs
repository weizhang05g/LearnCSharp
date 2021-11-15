
using System;
using System.Collections;

namespace CollectionApplication{
  class Program{
    static void Main(string[] args){
      ArrayList a1 = new ArrayList();
      a1.Add(45);
      a1.Add(78);
      a1.Add(33);
      a1.Add(56);
      a1.Add(12);
      a1.Add(23);
      a1.Add(9);

      Console.WriteLine("Capacity: {0}",a1.Capacity);
      Console.WriteLine("Count: {0}",a1.Count);

      Console.WriteLine("Content: ");
      foreach(int nItem in a1){
        Console.Write(nItem + " ");
      }
      Console.WriteLine();

      Console.Write("Sorted Content: ");
      a1.Sort();
      foreach(int nItem in a1){
        Console.Write(nItem + " ");
      }
      Console.WriteLine();
      a1.AddRange(new int[]{333,334,335});
      Console.Write(@"AddRange[333,334,335: ");
      foreach(int nItem in a1){
        Console.Write(nItem + " ");
      }
      Console.WriteLine();
      Console.WriteLine("has 33: {0}, Index :{1}",a1.Contains(33),a1.IndexOf(33));

      Console.Write("add 1(22),delete 45,delete(3): ");
      a1.Insert(1,22);
      a1.Remove(45);
      a1.RemoveAt(3);
      foreach(int nItem in a1){
        Console.Write(nItem + " ");
      }
      Console.WriteLine();
      a1.Clear();
      Console.WriteLine("clear: {0}",a1.Count);

    }
  }
}