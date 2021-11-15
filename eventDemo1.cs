
using System;

namespace SimpleEvent{
  public class EventTest{
    private int value;
    public delegate void NumManipulationHandler(int n);
    public event NumManipulationHandler ChangeNum;
    protected virtual void OnNumChanged(int n){
      if(ChangeNum != null){
        ChangeNum(n);
      }else{
        Console.WriteLine("event not fire");
        Console.ReadKey();
      }
    }
    public EventTest(){
      SetValue(5);
    }
    public void SetValue(int n){
      if(value != n){
        value = n;
        OnNumChanged(n);
      }
    }
  } // End Class EventTest
  public class subscribEvent{
    public void printf(int n){
      Console.WriteLine("event fire {0}",n);
      Console.ReadKey();
    }
  }
    public class subscribEvent2{
    public void printf2(int n){
      Console.WriteLine("event fire 2 {0}",n*2);
      Console.ReadKey();
    }
  }
  public class MainClass{
    public static void Main(){
      EventTest e = new EventTest();
      subscribEvent se = new subscribEvent();
      subscribEvent2 se2 = new subscribEvent2();
      e.ChangeNum += new EventTest.NumManipulationHandler(se.printf);
      e.ChangeNum += se2.printf2;
      e.SetValue(7);
    }

  }
} // End namespace SimpleEvent