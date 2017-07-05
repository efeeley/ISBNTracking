using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
    class ISBN
    {
        //default constructor
        public ISBN() {  }

        //Attributes
        private string isbn;
        private string checkDigit;
        private int checksum;
        //private int finalDigit;

        //Methods**********************

        //Gets*************************
        //getISBN
        public string getISBN()
        {
            return this.isbn;
        }
        //getCheckDigit
        public string getCheckDigit()
        {
            return this.checkDigit;
        }
        //getCheckSum
        public int getCheckSum()
        {
            return this.checksum;
        }
        ////getFinalDigit
        //public int getFinalDigit()
        //{
        //    return this.finalDigit;
        //}

        //Sets*************************
        //setISBN
        public void setISBN(string aISBN)
        {
            this.isbn = aISBN;
        }
        //setCheckDigit
        public void setCheckDigit(string aCheckDigit)
        {
            this.checkDigit = aCheckDigit;
        }
        //setCheckSum
        public void setCheckSum(int aCheckSum)
        {
            this.checksum = aCheckSum;
        }
        ////setFinalDigit
        //public void setFinalDigit(int aFinalDigit)
        //{
        //    this.finalDigit = aFinalDigit;
        //}

        //Other************************
        //FormatInput
        public void FormatInput()
        {
            this.isbn = isbn.Replace("-", "");
            this.isbn = isbn.Replace(" ", "");
        }

        //LoadIntoArray
        //public void LoadIntoArray()
        //{
        //    //for (int currentIndex = 0; currentIndex < 9; currentIndex++)
        //    //{
        //    //    isbnArray[currentIndex] = isbn.Substring(currentIndex, 1);
        //    //}            

        //    isbnArray[0] = isbn.Substring(0, 1);
        //    isbnArray[1] = isbn.Substring(1, 1);
        //    isbnArray[2] = isbn.Substring(2, 1);
        //    isbnArray[3] = isbn.Substring(3, 1);
        //    isbnArray[4] = isbn.Substring(4, 1);
        //    isbnArray[5] = isbn.Substring(5, 1);
        //    isbnArray[6] = isbn.Substring(6, 1);
        //    isbnArray[7] = isbn.Substring(7, 1);
        //    isbnArray[8] = isbn.Substring(8, 1);
        //    isbnArray[9] = isbn.Substring(9, 1);
        //}

        ////Printing an Array
        //public void PrintArray()
        //{
        //    isbnString = isbnArray[0] + isbnArray[1];
        //}


        //CheckISBN
        public void CheckISBN()
        {
            //storing final digit
            //if (this.isbn.Length == 10)
            //{
            //    if (this.isbn.Substring(9, 1) == "X")
            //    {
            //        this.setFinalDigit(10);
            //    }
            //    else
            //    {
            //        this.setFinalDigit(Convert.ToInt32(isbn.Substring(9, 1)));
            //    }
            //}

            int total = 0;
            int multiplier = 10;
            for (int currentplace = 0; currentplace < (this.isbn.Length); currentplace++)
            {
                total = total + Convert.ToInt32(isbn.Substring(currentplace, 1)) * multiplier;
                multiplier = multiplier - 1;
            }
            this.setCheckSum(total);

            if (this.getCheckSum() % 11 != 0)
            {
                this.MakeValidISBN();
            }
            
        }

        //MakeValidISBN
        public void MakeValidISBN()
        {
            this.setCheckDigit(Convert.ToString(11 - (this.getCheckSum() % 11)));

            if (this.getCheckDigit() == "10")
            {
                this.checkDigit = checkDigit.Replace("10", "X");
            }
            
            //Console.WriteLine("Final digit: " + this.getFinalDigit());
            //Console.WriteLine("check digit: " + this.getCheckDigit());

            //if (this.getFinalDigit() == Convert.ToInt32(this.getCheckDigit()))
            //{
            //    Console.WriteLine("You have entered a valid ISBN");
            //}
            //else
            //{
            //}
        }

        //Valid ISBN Display
        public void ValidISBNDisplay()
        {
            //exporting the console commands to another method
            Console.WriteLine("You entered a valid ISBN");
            Console.ReadLine();

            
           
        }

        //Invalid ISBN Display
        public void InvalidISBNDisplay()
        {
            //exporting the console commands to another method
            Console.WriteLine("You did not enter a valid ISBN");
            MakeValidISBN();

            Console.ReadLine();

            Console.WriteLine("The correct check digit should be: " + this.getCheckDigit());
            Console.WriteLine("This would make the valid ISBN this: " +
                                this.getISBN().Substring(0, 9) + this.getCheckDigit());

            Console.ReadLine();
        }

        //Display
        public void Display()
        {
            Console.Write("Enter your ISBN: ");
            setISBN(Console.ReadLine());
            FormatInput();
            if (this.isbn.Length == 9 || this.isbn.Length == 10)
            {
                CheckISBN();

                if (this.getCheckSum() % 11 == 0)
                {
                    this.ValidISBNDisplay();
                }
                else
                {
                    this.InvalidISBNDisplay();
                }
            }
            else
            {
                Console.WriteLine("You bad. \nI close now.");
                Console.ReadLine();
            }
        }
    }
}
