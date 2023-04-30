using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shakespeare_s_monkey_that_wrote_the_hamlet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void loopIt()
        {
            string charsToWrite = "abcdefghijklmnopqrstuvwxyz";
            textBox1.Clear();
            Random random = new Random();
            for (int i = 0; i < 515; i++)
            {
                textBox1.AppendText(charsToWrite[random.Next(0, 12)].ToString());
            }

            if (textBox1.Text == textBox3.Text)
            {
                MessageBox.Show("Match!!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loopIt();
        }
    }
}
