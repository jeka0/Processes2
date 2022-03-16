using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proc2
{
    public class Computing
    {
        public static Form1 form = Form1.form;
        public static void Factorial()
        {
            int res = 1, num = form.Get1();
            while (num != 0) { res *= num; num--; }
            form.Set(res);
        }
        public static void SoundSignal()
        {
            int num = form.Get2();
            for (int i = 0; i < num; i++) Console.Beep();
        }
    }
}
