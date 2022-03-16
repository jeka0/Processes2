using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;

namespace Proc2
{
    public class Peterson_sAlgorithm
    {
        public static Form1 form = Form1.form;
        private static Random random = new Random();
        private static int turn;
        private static int[] interested = new int[2];
        private static void enter_region(int process)
        {
            int other = 1 - process;
            interested[process] = 1;
            turn = process;
            while (turn == process && interested[other] == 1) if (process == 0) form.SetColor1(Color.Red); else form.SetColor2(Color.Red);
        }
        private static void leave_region(int process)
        {
            interested[process] = 0;
        }
        public static void Proc1()
        {
            while (true)
            {
                enter_region(0);
                form.SetColor1(Color.Green);
                Computing.Factorial();
                Thread.Sleep(1000);
                leave_region(0);
                form.SetColor1(Color.Yellow);
                Thread.Sleep(random.Next(500, 3000));
            }

        }
        public static void Proc2()
        {
            while (true)
            {
                enter_region(1);
                form.SetColor2(Color.Green);
                Computing.SoundSignal();
                leave_region(1);
                form.SetColor2(Color.Yellow);
                Thread.Sleep(random.Next(500, 3000));
            }

        }

    }
}
