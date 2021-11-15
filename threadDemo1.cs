
using System;
using System.Threading;

namespace ThreadApp1{
  class Program{
    public static void CallToThread1(){
      Console.WriteLine("{0} starts",Thread.CurrentThread.ManagedThreadId);
      Thread.Sleep(3000);
      Console.WriteLine("{0} ends", Thread.CurrentThread.ManagedThreadId);
    }
    public static void CallToThread(object state){
      Console.WriteLine("{0} starts",Thread.CurrentThread.ManagedThreadId);
      Thread.Sleep(3000);
      Console.WriteLine("{0} ends", Thread.CurrentThread.ManagedThreadId);
    }
    static void Main(string[] args){
      Thread th = new Thread(CallToThread1);
      th.Start();
      th.Join();

      ThreadPool.QueueUserWorkItem(CallToThread);
      ThreadPool.QueueUserWorkItem(CallToThread);
      ThreadPool.QueueUserWorkItem(CallToThread);

      Console.WriteLine("Main Ends");
      //Console.ReadKey();
    }
  }
}