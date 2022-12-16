using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_and_2_Zadaniy_in_Forms
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            int n;

            n = int.Parse(numericUpDown1.Text);
               
            for (int i = 0; i < n; )
            {
                if (i == n)
                {
                    textBox1.Text += ("И больше лунатиков не стало на луне"+ Environment.NewLine);
                }
                else
                {
                    textBox1.Text += ($"{n} лунатиков жили на луне" + Environment.NewLine + $"{n} лунатиков ворочались во сне" + Environment.NewLine);
                    textBox1.Text += ("Один из лунатиков упал с луны во сне" + Environment.NewLine);
                    n--;
                }
                if (n == 0)
                {
                    textBox1.Text += ("И больше лунатиков не стало на луне"+ Environment.NewLine);
                }
            }
        }
    }
}
