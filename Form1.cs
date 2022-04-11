using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int terms;
            double pi = 4;
            double numerator = 4;
            double denominator = 3;

            terms = Convert.ToInt32(numberOfTerms.Text); 

            for (int i = 0; i <= terms; i++)
            {
                if (i % 2 == 0)
                {
                    pi -= numerator / denominator;
                }
                else
                {
                    pi += numerator / denominator;
                }
                denominator += 2;
            }

            label2.Text = "Approxmiate value of pi after " + terms + " terms";
            label3.Text = "= " + pi;
        }
    }
}
