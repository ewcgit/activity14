using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = 0;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true){ // Red font.
                label1.ForeColor = Color.Red;
                label3.ForeColor = Color.Red;
                label4.ForeColor = Color.Red;
            }
            else if (radioButton2.Checked == true){ // Blue font.
                label1.ForeColor = Color.Blue;
                label3.ForeColor = Color.Blue;
                label4.ForeColor = Color.Blue;
            }
            else{ // Green font.
                label1.ForeColor = Color.Green;
                label3.ForeColor = Color.Green;
                label4.ForeColor = Color.Green;
            }
            if (listBox1.SelectedIndex == 0){ // Visible.
                if (checkBox1.Checked == true) {
                    label1.Visible = true;
                }
                else{
                    label1.Visible = false;
                }
                if (checkBox2.Checked == true){
                    label3.Visible = true;
                }
                else{
                    label3.Visible = false;
                }
                if (checkBox3.Checked == true)
                {
                    label4.Visible = true;
                }
                else{
                    label4.Visible = false;
                }
            }
            else{ // Invisible.
                label1.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e){
        }

        private void groupBox1_Enter(object sender, EventArgs e){
        }
    }
}