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
    public partial class Form1 : Form, Interface1, Interface2
    {
        public int Get1() { Int32.TryParse(textBox1.Text, out int res);return res; }
        public int Get2() { Int32.TryParse(textBox3.Text, out int res); return res; }
        public void Set(int value) { textBox2.Invoke(new Action(() => { textBox2.Text = value.ToString(); }));}
        /*private void ChangeText(TextBox textBox)
        {
            textBox2.BeginInvoke();
        }*/
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StrictAlternation.i1 = this;
            StrictAlternation.i2 = this;
            Thread thread1 = new Thread(StrictAlternation.Proc1);
            Thread thread2 = new Thread(StrictAlternation.Proc2);
            thread1.Start();
            thread2.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           StrictAlternation.Factorial();
           StrictAlternation.SoundSignal();
        }
    }
}
