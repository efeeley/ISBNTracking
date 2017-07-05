using System;
using System.Collections.Generic;
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
    class TestISBN
    {
        static void Main(string[] args)
        {
            //The program will not work properly with the last digit being X.
            //All other numbers work correctly.

            //ISBN example = new ISBN();

            //example.Display();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}