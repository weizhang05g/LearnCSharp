using System;


class Shape {
  protected double width;
  protected double height;
  public  Shape(double w,double h){
    width = w;
    height = h;
  }
}
interface area {
  double getArea();
}
class Rectangle: Shape, area {
  public  Rectangle (double w, double h):base(w,h){

  }
  public double getArea() {
    return width * height;
  }
}

abstract class Abs{
  abstract public void AbsFunc();
}

class AbsInh : Abs {
  public override void AbsFunc() {
    Console.WriteLine("抽象继承");
  }
}

class Vir {
  protected int a ;
  public Vir(){
    a = 0;
  }
  public Vir(int n){
    a = n;
  }
  public virtual int geta (){
    return a;
  }
}

class VirA : Vir {
  public VirA():base(){}
  public VirA(int n):base(n){}
  public override int geta() {
    return a * 2;
  }
}
class VirB: Vir {
  public VirB():base(){}
  public VirB(int n):base(n){}
  public override int geta() {
    return a * 10;
  }
}
class GetA {
  public void PrintA (Vir v) {
    Console.WriteLine(v.geta());
  }
}
class InheritaceDemo{
  static void Main(string[] args){
    Rectangle re = new Rectangle(3,8);
    Console.WriteLine("Area: {0}",re.getArea());
    //Console.WriteLine("Width: {0}",re.width);

    AbsInh ai = new AbsInh();
    ai.AbsFunc();

    GetA mygeta = new GetA();
    VirA myvira = new VirA(2);
    VirB myvirb = new VirB(2);
    mygeta.PrintA(myvira);
    mygeta.PrintA(myvirb);

    Console.ReadKey();
  }
}