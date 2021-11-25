
using System;
using System.Threading;

namespace InvokeApp1{
    class Progrom{

    }
    public static string TestMethod(object data){
        string datastr = data as string;
        return datastr;
    }
    public static void TestCallback(IAsyncResult data){
        Console.WriteLine(data.AsyncState);
    }
}