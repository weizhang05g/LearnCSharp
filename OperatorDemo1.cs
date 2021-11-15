
using System;

class OperA {
  public int len {
    set; get;
  }
  public OperA(int n){
    len = n;
  }
  public OperA(){
    len = 0;
  }
   
  public static OperA operator+ (OperA a,OperA b){
    OperA c = new OperA();
    c.len = a.len + b.len;
    return c;
  }
}

class OperDemo {
  static void Main(string[] args){
    OperA oa = new OperA(3);
    OperA ob = new OperA(5);
    OperA oc = oa + ob;
    Console.WriteLine("{0}",oc.len);
  }
}