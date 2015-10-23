/*
*Created by: Matthew Clement
*Created on: 23-Oct-2015
*Created for: Unit #3-14
*This program shows the running average.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunningAverage
{
    public partial class frmRunningAverage : Form
    {
        double inputNumber = 0;
        double totalNumber = 0;
        double runningAverage = 0;
        double counter = 0;

        public frmRunningAverage()
        {
            InitializeComponent();
        }

        private void btnEnterNumber_Click(object sender, EventArgs e)
        {

            inputNumber = Convert.ToDouble(this.txtNumberInput.Text);

            if (inputNumber < 100 && inputNumber > 0)
            {
                counter++;
                totalNumber = inputNumber + totalNumber;
                runningAverage = totalNumber / counter;
                this.lblAnswer.Text = Convert.ToString(runningAverage);
            }
            else if (inputNumber != -1)
            {
                MessageBox.Show("Invalid Number.");
            }

            if (inputNumber == -1)
            {
                MessageBox.Show("Program Ended.");
                this.txtNumberInput.Visible = false;
                this.btnEnterNumber.Enabled = false;
            }


        }
    }
}
