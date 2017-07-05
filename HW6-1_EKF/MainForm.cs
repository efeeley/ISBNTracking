using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/**************************************
 * Name: Elisabeth Feeley
 * Date: Weeks 6-10
 * Assignment: Make an Object-Oriented ISBN checker
 * Resource: 
 *      -http://docs.oracle.com/javase/tutorial/java/data/manipstrings.html
 *       the Replace method in string class(yes I know it is java).
**************************************/

namespace HW6_1_EKF
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void xCheckButton_Click(object sender, EventArgs e)
        {
            //start the ISBN constructer
            ISBN gui = new ISBN();

            //take user input and make it the isbn
            gui.setISBN(xISBNTextBox.Text);
            gui.FormatInput();

            //check the ISBN
            gui.CheckISBN();

            //Display Results
            xResultsTextBox.Text = gui.getISBN();
            
            if (gui.getCheckSum() % 11 == 0)
            {
                xResultsTextBox.Text = "You have entered a valid ISBN.";
            }
            else
            {
                xResultsTextBox.Text = "You have not entered a valid ISBN." + Environment.NewLine +
                                        Environment.NewLine + 
                                        "The correct check digit should be:" + gui.getCheckDigit() + 
                                        Environment.NewLine + "This would make the correct ISBN this:" + 
                                        gui.getISBN().Substring(0,9) + gui.getCheckDigit();
            }
            
        }

        private void xAboutLabel_Click(object sender, EventArgs e)
        {
            About aboutme = new About();
            aboutme.Show();
        }

        private void xHelpLabel_Click(object sender, EventArgs e)
        {
            Help helpme = new Help();
            helpme.Show();
        }
    }
}
