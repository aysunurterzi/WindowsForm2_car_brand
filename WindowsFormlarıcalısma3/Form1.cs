using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormlarıcalısma3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("AUDI");
            comboBox1.Items.Add("SUZUKI");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           if (comboBox1.Text=="AUDI")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("A1");
                comboBox2.Items.Add("A2");
                comboBox2.Items.Add("A3");
            }
           else if (comboBox1.Text == "SUZUKI")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("S1");
                comboBox2.Items.Add("S2");
                comboBox2.Items.Add("S3");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "A1")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("A1.V1");
                comboBox3.Items.Add("A1.V2");
                comboBox3.Items.Add("A1.V3");
            }
            else if (comboBox2.Text == "A2")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("A2.V1");
                comboBox3.Items.Add("A2.V2");
                comboBox3.Items.Add("A2.V3");
            }
            else if (comboBox2.Text == "A3")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("A3.V1");
                comboBox3.Items.Add("A3.V2");
                comboBox3.Items.Add("A3.V3");
            }

            if (comboBox2.Text == "S1")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("S1.V1");
                comboBox3.Items.Add("S1.V2");
                comboBox3.Items.Add("S1.V3");
            }
            else if (comboBox2.Text == "S2")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("S2.V1");
                comboBox3.Items.Add("S2.V2");
                comboBox3.Items.Add("S2.V3");
            }
            else if (comboBox2.Text == "S3")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("S3.V1");
                comboBox3.Items.Add("S3.V2");
                comboBox3.Items.Add("S3.V3");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("MARKA: " + comboBox1.Text + " | " +
                               "MODEL: " + comboBox2.Text + " | " +
                               "VERSİYON: " + comboBox3.Text + " | ");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
