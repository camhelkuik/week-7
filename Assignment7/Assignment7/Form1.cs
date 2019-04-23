using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Assignment7
{
    public partial class Form1 : Form
    {
        List<int> numbers = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Bubble Sort - Cameron Helkuik";
        }

        private void btnAddNumber_Click(object sender, EventArgs e)
        {
            var newNumber = int.Parse(txtNumber.Text.ToString());
            numbers.Add(newNumber);

            txtNumber.Text = "";
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            txtList.Text = string.Join(", ", numbers);
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            int temp;
            int numberOfSwaps = 0;
            var count = numbers.ToArray();

            for ( int x = 0; x < count.Length - 1; x++)
            {
                for ( int i = 0; i < count.Length - x - 1; i++)
                {
                    if (count[i] > count[i + 1])
                    {
                        temp = count[i + 1];
                        count[i + 1] = count[i];
                        count[i] = temp;

                        numberOfSwaps++;
                    }
                }

                //check number of swaps, if 0 no need to keep going, else reset the number of swaps
                if (numberOfSwaps == 0)
                {
                    break;
                }
                else
                {
                    numberOfSwaps = 0;
                }
            }

            txtList.Text = string.Join(", ", count);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtList.Text = "";
            numbers.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
