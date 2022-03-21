using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PraktikumWeek5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains(textBoxInput.Text))
            {
                MessageBox.Show("Input Kembar");
            }
            else
            {
               listBox1.Items.Add(textBoxInput.Text.ToString());
            }
            textBoxInput.Text = "";
        }
        private void checkBoxAktif_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAktif.Checked == true)
            {
                radioButtonRed.Enabled = true;
                radioButtonBlue.Enabled = true;
            }
            else
            {
                radioButtonRed.Enabled = false;
                radioButtonBlue.Enabled = false;
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelOutput.Text = listBox1.SelectedItem.ToString();
        }

        private void radioButtonRed_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAktif.Checked == true)
            {
                if (radioButtonRed.Checked == true)
                {
                    labelOutput.ForeColor = Color.Red;
                }
            }
        }

        private void radioButtonBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAktif.Checked == true)
            {
                if (radioButtonBlue.Checked == true)
                {
                    labelOutput.ForeColor = Color.Blue;
                }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            labelOutput.Text = "";
            listBox1.Items.Clear();
        }
    }
}
