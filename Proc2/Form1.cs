using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Proc2
{
    public partial class Form1 : Form
    {
        public MyThread thread1 = new MyThread();
        public MyThread thread2 = new MyThread();
        public static Form1 form;
        public int Get1() { Int32.TryParse(textBox1.Text, out int res);return res; }
        public int Get2() { Int32.TryParse(textBox3.Text, out int res); return res; }
        public int GetChoice() { if (radioButton1.Checked) return 0; else return 1; }
        public void SetColor1(Color color) { pictureBox1.Invoke(new Action(() => { pictureBox1.BackColor = color; }));}
        public void SetColor2(Color color) { pictureBox2.Invoke(new Action(() => { pictureBox2.BackColor = color; })); }
        public void Set(int value) { textBox2.Invoke(new Action(() => { textBox2.Text = value.ToString(); }));}
        public Form1()
        {
            InitializeComponent();
            form = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            thread1.Create(StrictAlternation.Proc1);
            thread2.Create(StrictAlternation.Proc2);
            thread1.Run();
            thread2.Run();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            thread1.Close();
            thread2.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            thread1.Close();
            thread2.Close();
            if (GetChoice() == 0) thread1.Create(StrictAlternation.Proc1); else thread1.Create(Peterson_sAlgorithm.Proc1);
            if (GetChoice() == 0) thread2.Create(StrictAlternation.Proc2); else thread2.Create(Peterson_sAlgorithm.Proc2);
            thread1.Run();
            thread2.Run();
        }
    }
}
