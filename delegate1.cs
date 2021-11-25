
using System;

delegate int NumberChanger(int n);
namespace DelegateApp1{
    class TestDelegate{
        static int num = 0;
        public static int AddNum(int n){
            num += n;
            return num;
        }
        public static int MultNum(int n){
            num *= n;
            return num;
        }
        public static int GetNum(){
            return num;
        }
        static void Main(string[] args){
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultNum);
            
            nc1(25);
            Console.WriteLine(GetNum());
            nc2(5);
            Console.WriteLine(GetNum());
        }
    }
}