
using System;

namespace types{
    class Program{
        static void Main(string[] args){
            sbyte sb1 = 0x12;
            byte by1 = 0xFA;
            short sh1 = 125;
            ushort us1 = 256;
            int in1 = 1234;
            uint ui1 = 234;
            long lo1 = 12346;
            ulong ul1 = 23456;
            float fl1 = 98.24F;
            double do1 = 1.25E5;
            char ch1 = 'A';
            bool bo1 = true;
            dynamic dy1 = 149;
            string str1 = "langu";
            int[] ar1 = new int[]{2,4,6,8};

            Console.WriteLine("sbyte: 0x{0:X}, byte: 0x{1:X}",sb1,by1);

        }
    }
}