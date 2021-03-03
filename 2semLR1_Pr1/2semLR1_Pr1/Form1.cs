using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2semLR1_Pr1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            { MessageBox.Show("Please enter a name"); }
            else if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false && checkBox4.Checked == false && checkBox5.Checked == false && checkBox6.Checked == false && checkBox7.Checked == false)
            { MessageBox.Show("Please specify some service"); }
            int amount = 0;
            if (checkBox1.Checked == true) amount += 10;
            if (checkBox2.Checked == true) amount += 12;
            if (checkBox3.Checked == true) amount += 10;
            if (checkBox4.Checked == true) amount += 15;
            if (checkBox5.Checked == true) amount += 10;
            if (checkBox6.Checked == true) amount += 15;
            if (checkBox7.Checked == true) amount += 10;
            textBox3.Text = Convert.ToString(amount);
        }
    }
}
