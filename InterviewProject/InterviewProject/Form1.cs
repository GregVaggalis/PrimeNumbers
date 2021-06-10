using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterviewProject
{
    public partial class MainForm : Form
    {
        int[] numAry = new int[100];        // Initialize array

        public MainForm()
        {
            InitializeComponent();
            IntContainer.Enter += (s, e) => { IntContainer.Parent.Focus(); };       // Shift focus away from text-box even if clicked on
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FillArray(numAry);
            WriteArray(numAry);
        }

        /// <summary>
        /// This method will fill the array with number 1-100
        /// </summary>
        /// <param name="arry"> The array of numbers 1-100 </param>
        public void FillArray(int[] arry)
        {
            for (int i = 0; i < 100; i++)
            {
                arry[i] = i + 1;
            }
        }

        /// <summary>
        /// This method will write a standard list of number in a 10x10 grid
        /// </summary>
        /// <param name="arry"> The array of numbers 1-100 </param>
        public void WriteArray(int[] arry)
        {
            string prtAry = "";
            for (int i = 0; i < 100; i++)
            {
                prtAry += numAry[i].ToString() + "\t";
                if ((i + 1) % 10 == 0)                  // Finds a number divisible by 10 and adds a new-line
                {
                    prtAry += "\n";
                }
            }

            IntContainer.Text = prtAry;
        }

        private void TogglePrimes_CheckedChanged(object sender, EventArgs e)
        {
            if (TogglePrimes.Checked == true)
            {
                ColorPrimes(numAry);
            }
            else
            {
                WriteArray(numAry);
            }
        }

        /// <summary>
        /// This method will clear the text-box then appends new text with the right color
        /// Red for primes and black for non-primes
        /// </summary>
        /// <param name="x"> The array of numbers 1-100 </param>
        public void ColorPrimes(int[] x)
        {
            IntContainer.Clear();
            for (int i = 1; i <= x.Length; i++)
            {
                // 0 and 1 are non-primes
                if (i == 0 || i == 1)
                {
                    IntContainer.SelectionColor = Color.Black;      // Selects color
                    IntContainer.AppendText(i.ToString() + "\t");   // Appends newly created text
                }
                else
                {
                    // Checks to see if a new line marker is needed
                    if (i % 10 == 0)
                    {
                        if (ChkPrime(i))
                        {
                            IntContainer.SelectionColor = Color.Red;
                            IntContainer.AppendText(i.ToString() + "\n");
                        }
                        else
                        {
                            IntContainer.SelectionColor = Color.Black;
                            IntContainer.AppendText(i.ToString() + "\n");
                        }
                    }
                    else
                    {
                        if (ChkPrime(i))
                        {
                            IntContainer.SelectionColor = Color.Red;
                            IntContainer.AppendText(i.ToString() + "\t");
                        }
                        else
                        {
                            IntContainer.SelectionColor = Color.Black;
                            IntContainer.AppendText(i.ToString() + "\t");
                        }
                    }
                }

            }
        }

        /// <summary>
        /// Checks if number will be prime or not
        /// </summary>
        /// <param name="y"> Number that will be checked </param>
        /// <returns> true or false; if number is prime or not</returns>
        public bool ChkPrime(int y)
        {
            for (int i = 2; i < y; i++)
            {
                if (y % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
