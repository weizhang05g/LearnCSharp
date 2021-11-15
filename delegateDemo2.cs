
using System;
using System.IO;

namespace DelegateApp2{
  class PrintString{
    static FileStream fs;
    static StreamWriter sw;
    public delegate void printString(string str);
    public static void send(printString ps){
      ps("Hello Delegate");
    }
    public static void WriteToScreen(string str){
      Console.WriteLine(str);
    }
    public static void WriteToFile(string str){
      fs = new FileStream("message.txt",FileMode.Append,FileAccess.Write);
      sw = new StreamWriter(fs);
      sw.WriteLine(str);
      sw.Flush();
      sw.Close();
      fs.Close();
    }
    static void Main(string[] args){
      printString ps1 = new printString(WriteToScreen);
      printString ps2 = new printString(WriteToFile);
      send(ps1);
      send(ps2);
      
    }
  }
}