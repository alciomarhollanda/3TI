using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNASP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtNum1.Text);
            
            double num2 = Convert.ToDouble(txtNum2.Text);

            double soma = num1 + num2;

            MessageBox.Show("A soma dos números digitados: "+soma);
        }
    }
}
