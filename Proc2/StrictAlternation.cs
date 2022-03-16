using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;

namespace Proc2
{
    public class StrictAlternation
    {
        public static Form1 form = Form1.form;
        private static Random random = new Random();
        static int turn = 0;
        public static void Proc1()
        {
            while (true)
            {
                while (turn != 0) form.SetColor1(Color.Red);
                form.SetColor1(Color.Green);
                Computing.Factorial();
                Thread.Sleep(1000);
                turn = 1;
                form.SetColor1(Color.Yellow);
                Thread.Sleep(random.Next(1000,3000));
            }

        }
        public static void Proc2()
        {
            while (true)
            {
                while (turn != 1) form.SetColor2(Color.Red);
                form.SetColor2(Color.Green);
                Computing.SoundSignal();
                turn = 0;
                form.SetColor2(Color.Yellow);
                Thread.Sleep(random.Next(500, 3000));
            }

        }
    }
}
