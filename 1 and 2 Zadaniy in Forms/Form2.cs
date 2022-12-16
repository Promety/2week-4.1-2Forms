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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        static double Cmn(double m, double n)
        {

            double s = 0, nf = 1, mf = 1, nm = 1;
            for (int i = 1; i <= n; i++)
                nf = nf * i;
            for (int j = 1; j <= m; j++)
                mf = mf * j;
            for (int j = 1; j <= n - m; j++)
                mf = mf * j;
            s = nf / (mf * nm);

            return s;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
          
                double m;
               
                m = double.Parse(numericUpDown1.Text);
                double n;
            
                n = double.Parse(numericUpDown2.Text);

            textBox1.Text = Cmn(m, n).ToString();
            

        }
    }
}
    
