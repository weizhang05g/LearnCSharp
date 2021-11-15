
using System;

interface IPInterface{
  void IpiFunc();
}
interface MyInterface : IPInterface{
  void myFunc();
}

class MyClass : MyInterface {
  static void Main(string[] args){
    MyClass mc = new MyClass();
    mc.IpiFunc();
    mc.myFunc();
  }
  public void IpiFunc(){
    Console.WriteLine("Ipi Interface");
  }
  public void myFunc(){
    Console.WriteLine("My Interface");
  }
}