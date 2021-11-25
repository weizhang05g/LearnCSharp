
using System;
using System.Threading;

namespace InvokeApp1{
    public delegate string MyDelegate(object data);
    class Progrom{
        static void Main(string[] args){
            MyDelegate mydelegate = new MyDelegate(TestMethod);
            IAsyncResult result = MyDelegate.BeginInvoke("Thread Param", TestCallback, "Callback Param");
            string resultstr = mydelegate.EndInvoke(result);
            Console.WriteLine(resultstr);
        }
        public static string TestMethod(object data){
            string datastr = data as string;
            return datastr;
        }
        public static void TestCallback(IAsyncResult data){
            Console.WriteLine(data.AsyncState);
        }
    }

}