using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flight_Ground_Station
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Son Uçuş")
            {
                groupBox1.Visible = true;
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                groupBox4.Visible = false;
                groupBox5.Visible = false;
                groupBox6.Visible = false;
                groupBox7.Visible = false;
                groupBox8.Visible = false;
                groupBox9.Visible = false;
                groupBox10.Visible = false;
                groupBox11.Visible = false;
                groupBox12.Visible = false;
                groupBox13.Visible = false;
                groupBox14.Visible = false;
                groupBox15.Visible = false;
                groupBox16.Visible = false;
                groupBox17.Visible = false;
                groupBox18.Visible = false;
                groupBox19.Visible = false;
                groupBox20.Visible = false;
            }
            if (comboBox1.Text == "Son 2 Uçuş")
            {
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = false;
                groupBox4.Visible = false;
                groupBox5.Visible = false;
                groupBox6.Visible = false;
                groupBox7.Visible = false;
                groupBox8.Visible = false;
                groupBox9.Visible = false;
                groupBox10.Visible = false;
                groupBox11.Visible = false;
                groupBox12.Visible = false;
                groupBox13.Visible = false;
                groupBox14.Visible = false;
                groupBox15.Visible = false;
                groupBox16.Visible = false;
                groupBox17.Visible = false;
                groupBox18.Visible = false;
                groupBox19.Visible = false;
                groupBox20.Visible = false;
            }
            if (comboBox1.Text == "Son 3 Uçuş")
            {
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                groupBox4.Visible = false;
                groupBox5.Visible = false;
                groupBox6.Visible = false;
                groupBox7.Visible = false;
                groupBox8.Visible = false;
                groupBox9.Visible = false;
                groupBox10.Visible = false;
                groupBox11.Visible = false;
                groupBox12.Visible = false;
                groupBox13.Visible = false;
                groupBox14.Visible = false;
                groupBox15.Visible = false;
                groupBox16.Visible = false;
                groupBox17.Visible = false;
                groupBox18.Visible = false;
                groupBox19.Visible = false;
                groupBox20.Visible = false;
            }
            if (comboBox1.Text == "Son 4 Uçuş")
            {
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                groupBox4.Visible = true;
                groupBox5.Visible = false;
                groupBox6.Visible = false;
                groupBox7.Visible = false;
                groupBox8.Visible = false;
                groupBox9.Visible = false;
                groupBox10.Visible = false;
                groupBox11.Visible = false;
                groupBox12.Visible = false;
                groupBox13.Visible = false;
                groupBox14.Visible = false;
                groupBox15.Visible = false;
                groupBox16.Visible = false;
                groupBox17.Visible = false;
                groupBox18.Visible = false;
                groupBox19.Visible = false;
                groupBox20.Visible = false;
            }
            if (comboBox1.Text == "Son 5 Uçuş")
            {
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                groupBox4.Visible = true;
                groupBox5.Visible = true;
                groupBox6.Visible = false;
                groupBox7.Visible = false;
                groupBox8.Visible = false;
                groupBox9.Visible = false;
                groupBox10.Visible = false;
                groupBox11.Visible = false;
                groupBox12.Visible = false;
                groupBox13.Visible = false;
                groupBox14.Visible = false;
                groupBox15.Visible = false;
                groupBox16.Visible = false;
                groupBox17.Visible = false;
                groupBox18.Visible = false;
                groupBox19.Visible = false;
                groupBox20.Visible = false;
            }
            if (comboBox1.Text == "Son 6 Uçuş")
            {
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                groupBox4.Visible = true;
                groupBox5.Visible = true;
                groupBox6.Visible = true;
                groupBox7.Visible = false;
                groupBox8.Visible = false;
                groupBox9.Visible = false;
                groupBox10.Visible = false;
                groupBox11.Visible = false;
                groupBox12.Visible = false;
                groupBox13.Visible = false;
                groupBox14.Visible = false;
                groupBox15.Visible = false;
                groupBox16.Visible = false;
                groupBox17.Visible = false;
                groupBox18.Visible = false;
                groupBox19.Visible = false;
                groupBox20.Visible = false;
            }
            if (comboBox1.Text == "Son 7 Uçuş")
            {
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                groupBox4.Visible = true;
                groupBox5.Visible = true;
                groupBox6.Visible = true;
                groupBox7.Visible = true;
                groupBox8.Visible = false;
                groupBox9.Visible = false;
                groupBox10.Visible = false;
                groupBox11.Visible = false;
                groupBox12.Visible = false;
                groupBox13.Visible = false;
                groupBox14.Visible = false;
                groupBox15.Visible = false;
                groupBox16.Visible = false;
                groupBox17.Visible = false;
                groupBox18.Visible = false;
                groupBox19.Visible = false;
                groupBox20.Visible = false;
            }
            if (comboBox1.Text == "Son 8 Uçuş")
            {
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                groupBox4.Visible = true;
                groupBox5.Visible = true;
                groupBox6.Visible = true;
                groupBox7.Visible = true;
                groupBox8.Visible = true;
                groupBox9.Visible = false;
                groupBox10.Visible = false;
                groupBox11.Visible = false;
                groupBox12.Visible = false;
                groupBox13.Visible = false;
                groupBox14.Visible = false;
                groupBox15.Visible = false;
                groupBox16.Visible = false;
                groupBox17.Visible = false;
                groupBox18.Visible = false;
                groupBox19.Visible = false;
                groupBox20.Visible = false;
            }
            if (comboBox1.Text == "Son 9 Uçuş")
            {
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                groupBox4.Visible = true;
                groupBox5.Visible = true;
                groupBox6.Visible = true;
                groupBox7.Visible = true;
                groupBox8.Visible = true;
                groupBox9.Visible = true;
                groupBox10.Visible = false;
                groupBox11.Visible = false;
                groupBox12.Visible = false;
                groupBox13.Visible = false;
                groupBox14.Visible = false;
                groupBox15.Visible = false;
                groupBox16.Visible = false;
                groupBox17.Visible = false;
                groupBox18.Visible = false;
                groupBox19.Visible = false;
                groupBox20.Visible = false;
            }
            if (comboBox1.Text == "Son 10 Uçuş")
            {
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                groupBox4.Visible = true;
                groupBox5.Visible = true;
                groupBox6.Visible = true;
                groupBox7.Visible = true;
                groupBox8.Visible = true;
                groupBox9.Visible = true;
                groupBox10.Visible = true;
                groupBox11.Visible = false;
                groupBox12.Visible = false;
                groupBox13.Visible = false;
                groupBox14.Visible = false;
                groupBox15.Visible = false;
                groupBox16.Visible = false;
                groupBox17.Visible = false;
                groupBox18.Visible = false;
                groupBox19.Visible = false;
                groupBox20.Visible = false;
            }
            if (comboBox1.Text == "Son 11 Uçuş")
            {
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                groupBox4.Visible = true;
                groupBox5.Visible = true;
                groupBox6.Visible = true;
                groupBox7.Visible = true;
                groupBox8.Visible = true;
                groupBox9.Visible = true;
                groupBox10.Visible = true;
                groupBox11.Visible = true;
                groupBox12.Visible = false;
                groupBox13.Visible = false;
                groupBox14.Visible = false;
                groupBox15.Visible = false;
                groupBox16.Visible = false;
                groupBox17.Visible = false;
                groupBox18.Visible = false;
                groupBox19.Visible = false;
                groupBox20.Visible = false;
            }
            if (comboBox1.Text == "Son 12 Uçuş")
            {
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                groupBox4.Visible = true;
                groupBox5.Visible = true;
                groupBox6.Visible = true;
                groupBox7.Visible = true;
                groupBox8.Visible = true;
                groupBox9.Visible = true;
                groupBox10.Visible = true;
                groupBox11.Visible = true;
                groupBox12.Visible = true;
                groupBox13.Visible = false;
                groupBox14.Visible = false;
                groupBox15.Visible = false;
                groupBox16.Visible = false;
                groupBox17.Visible = false;
                groupBox18.Visible = false;
                groupBox19.Visible = false;
                groupBox20.Visible = false;
            }
            if (comboBox1.Text == "Son 13 Uçuş")
            {
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                groupBox4.Visible = true;
                groupBox5.Visible = true;
                groupBox6.Visible = true;
                groupBox7.Visible = true;
                groupBox8.Visible = true;
                groupBox9.Visible = true;
                groupBox10.Visible = true;
                groupBox11.Visible = true;
                groupBox12.Visible = true;
                groupBox13.Visible = true;
                groupBox14.Visible = false;
                groupBox15.Visible = false;
                groupBox16.Visible = false;
                groupBox17.Visible = false;
                groupBox18.Visible = false;
                groupBox19.Visible = false;
                groupBox20.Visible = false;
            }
            if (comboBox1.Text == "Son 14 Uçuş")
            {
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                groupBox4.Visible = true;
                groupBox5.Visible = true;
                groupBox6.Visible = true;
                groupBox7.Visible = true;
                groupBox8.Visible = true;
                groupBox9.Visible = true;
                groupBox10.Visible = true;
                groupBox11.Visible = true;
                groupBox12.Visible = true;
                groupBox13.Visible = true;
                groupBox14.Visible = true;
                groupBox15.Visible = false;
                groupBox16.Visible = false;
                groupBox17.Visible = false;
                groupBox18.Visible = false;
                groupBox19.Visible = false;
                groupBox20.Visible = false;
            }
            if (comboBox1.Text == "Son 15 Uçuş")
            {
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                groupBox4.Visible = true;
                groupBox5.Visible = true;
                groupBox6.Visible = true;
                groupBox7.Visible = true;
                groupBox8.Visible = true;
                groupBox9.Visible = true;
                groupBox10.Visible = true;
                groupBox11.Visible = true;
                groupBox12.Visible = true;
                groupBox13.Visible = true;
                groupBox14.Visible = true;
                groupBox15.Visible = true;
                groupBox16.Visible = false;
                groupBox17.Visible = false;
                groupBox18.Visible = false;
                groupBox19.Visible = false;
                groupBox20.Visible = false;
            }
            if (comboBox1.Text == "Son 16 Uçuş")
            {
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                groupBox4.Visible = true;
                groupBox5.Visible = true;
                groupBox6.Visible = true;
                groupBox7.Visible = true;
                groupBox8.Visible = true;
                groupBox9.Visible = true;
                groupBox10.Visible = true;
                groupBox11.Visible = true;
                groupBox12.Visible = true;
                groupBox13.Visible = true;
                groupBox14.Visible = true;
                groupBox15.Visible = true;
                groupBox16.Visible = true;
                groupBox17.Visible = false;
                groupBox18.Visible = false;
                groupBox19.Visible = false;
                groupBox20.Visible = false;
            }
            if (comboBox1.Text == "Son 17 Uçuş")
            {
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                groupBox4.Visible = true;
                groupBox5.Visible = true;
                groupBox6.Visible = true;
                groupBox7.Visible = true;
                groupBox8.Visible = true;
                groupBox9.Visible = true;
                groupBox10.Visible = true;
                groupBox11.Visible = true;
                groupBox12.Visible = true;
                groupBox13.Visible = true;
                groupBox14.Visible = true;
                groupBox15.Visible = true;
                groupBox16.Visible = true;
                groupBox17.Visible = true;
                groupBox18.Visible = false;
                groupBox19.Visible = false;
                groupBox20.Visible = false;
            }
            if (comboBox1.Text == "Son 18 Uçuş")
            {
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                groupBox4.Visible = true;
                groupBox5.Visible = true;
                groupBox6.Visible = true;
                groupBox7.Visible = true;
                groupBox8.Visible = true;
                groupBox9.Visible = true;
                groupBox10.Visible = true;
                groupBox11.Visible = true;
                groupBox12.Visible = true;
                groupBox13.Visible = true;
                groupBox14.Visible = true;
                groupBox15.Visible = true;
                groupBox16.Visible = true;
                groupBox17.Visible = true;
                groupBox18.Visible = true;
                groupBox19.Visible = false;
                groupBox20.Visible = false;
            }
            if (comboBox1.Text == "Son 19 Uçuş")
            {
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                groupBox4.Visible = true;
                groupBox5.Visible = true;
                groupBox6.Visible = true;
                groupBox7.Visible = true;
                groupBox8.Visible = true;
                groupBox9.Visible = true;
                groupBox10.Visible = true;
                groupBox11.Visible = true;
                groupBox12.Visible = true;
                groupBox13.Visible = true;
                groupBox14.Visible = true;
                groupBox15.Visible = true;
                groupBox16.Visible = true;
                groupBox17.Visible = true;
                groupBox18.Visible = true;
                groupBox19.Visible = true;
                groupBox20.Visible = false;
            }
            if (comboBox1.Text == "Son 20 Uçuş")
            {
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                groupBox4.Visible = true;
                groupBox5.Visible = true;
                groupBox6.Visible = true;
                groupBox7.Visible = true;
                groupBox8.Visible = true;
                groupBox9.Visible = true;
                groupBox10.Visible = true;
                groupBox11.Visible = true;
                groupBox12.Visible = true;
                groupBox13.Visible = true;
                groupBox14.Visible = true;
                groupBox15.Visible = true;
                groupBox16.Visible = true;
                groupBox17.Visible = true;
                groupBox18.Visible = true;
                groupBox19.Visible = true;
                groupBox20.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            groupBox10.Visible = false;
            groupBox11.Visible = false;
            groupBox12.Visible = false;
            groupBox13.Visible = false;
            groupBox14.Visible = false;
            groupBox15.Visible = false;
            groupBox16.Visible = false;
            groupBox17.Visible = false;
            groupBox18.Visible = false;
            groupBox19.Visible = false;
            groupBox20.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox21.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox21.Visible = false;
        }
    }
}
