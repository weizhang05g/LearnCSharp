using System;
using System.Text;

class StructDemo{
  struct Name {
    public string firstname;
    public string lastname;
    public void getname(string name1,string name2){
      firstname = name1;
      lastname = name2;
    }
    public void myname(){
      Console.WriteLine("Name: {0},{1}",firstname,lastname);
    }
  }
  static void Main(string[] args){
    Name myname = new Name();
    myname.getname("W","K");
    myname.myname();
  }
}