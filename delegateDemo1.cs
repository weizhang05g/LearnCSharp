
using System;
namespace DelegateTest{
  delegate int NumberChanger(int n);

  class Demo{
    public static int Num = 10;
    public static int AddNum(int n){
      Num += n;
      return Num;
    }
    public static int MultNum(int n){
      Num *= n;
      return Num;
    }
    public static int GetNum(){
      return Num;
    }
    static void Main(string[] args){
      NumberChanger nc ;
      NumberChanger nc1 = new NumberChanger(AddNum);
      NumberChanger nc2 = new NumberChanger(MultNum);
      nc = nc1;
      nc += nc2;
      nc(5);
      Console.WriteLine(GetNum());
    }
  }
  
}
