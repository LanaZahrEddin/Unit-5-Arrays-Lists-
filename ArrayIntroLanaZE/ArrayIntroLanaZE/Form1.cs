using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayIntroLanaZE
{
    public partial class Form1 : Form

    {   //global vars and consts
        const int MAX_ARRAY = 10;
        Random numGen = new Random();

        //make a new array
        int[] numArray = new int[MAX_ARRAY];

        public Form1()
        {
            InitializeComponent();
            lblAverage.Hide();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            //local variables
            int counter;
            int randomNum;

            //clear the listbox
            lstNumbers.Items.Clear();

            for (counter = 0; counter < numArray.Length; counter++)
            {
                //generate random number and add it to the array and the list
                randomNum = numGen.Next(0, 9 + 1);
                numArray[counter] = randomNum;
                lstNumbers.Items.Add(randomNum);

                //Hide the previous average
                lblAverage.Hide();

                //refresh the form
                this.Refresh();
            }

        }

        private void BtnAverage_Click(object sender, EventArgs e)
        {
            //local variables
            double average;
            double sum = 0;
            int counter;

            //calculate the sum of the numebrs in the array
            for (counter = 0; counter < numArray.Length; counter++)
            {
                sum += numArray[counter];
            }

            //calculate and display the average
            average = sum / numArray.Length;
            lblAverage.Text = "Average: " + average;
            lblAverage.Show();

        }
    }
}
