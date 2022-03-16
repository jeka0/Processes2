using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proc2
{
    public class StrictAlternation
    {
        public static Interface1 i1;
        public static Interface2 i2;
        static int turn = 0;
        public static void Proc1()
        {
            while (true)
            {
                while (turn != 0) ;
                Factorial();
                turn = 1;
            }

        }
        public static void Factorial()
        {
            int res = 1, num = i1.Get1();
            while (num != 0) { res *= num;num--; }
            i1.Set(res);
        }
        public static void SoundSignal()
        {
            int num = i2.Get2();
            for (int i = 0; i < num; i++) Console.Beep();
        }
        public static void Proc2()
        {
            while (true)
            {
                while (turn != 1) ;
                SoundSignal();
                turn = 0;
            }

        }
    }
}
