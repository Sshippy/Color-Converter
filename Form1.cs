using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ColorConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBoxFirst_Enter(object sender, EventArgs e)
        {

        }

        private void radioButtonRed_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonBlue_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonYellow_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxSecond_Enter(object sender, EventArgs e)
        {

        }

        private void radioBtnRed_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioBtnBlue_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioBtnYellow_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnMix_Click(object sender, EventArgs e)
        {
            if (radioButtonRed.Checked && radioBtnBlue.Checked)
            {
                this.BackColor = Color.Purple;
            }
            else if (radioButtonRed.Checked && radioBtnYellow.Checked)
            {
                this.BackColor = Color.Orange;
            }

            else if (radioButtonBlue.Checked && radioBtnRed.Checked)
            {
                this.BackColor = Color.Green;
            }

            if (radioBtnRed.Checked && radioButtonRed.Checked)
            {
                this.BackColor = Color.Red;
            }
            else if (radioBtnYellow.Checked && radioButtonRed.Checked)
            {
                this.BackColor = Color.Orange;
            }

            else if (radioBtnBlue.Checked && radioButtonYellow.Checked)
            {
                this.BackColor = Color.Green;
            }

            if (radioButtonRed.Checked && radioBtnYellow.Checked)
            {
                this.BackColor = Color.Red;
            }
            else if (radioButtonBlue.Checked && radioBtnBlue.Checked)
            {
                this.BackColor = Color.Blue;
            }

            else if (radioButtonYellow.Checked && radioBtnRed.Checked)
            {
                this.BackColor = Color.Orange;
            }
        }
    }
}
