using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GradeLedger
{
    class Program
    {
        static void Main(string[] args)
        {
            Title();
        }
        public static void Title()
        {
            string number;

            Console.WriteLine("Welcome to the Grade Ledger!");
            Console.WriteLine("1. View Current Grades.");
            Console.WriteLine("2. view the average class score.");
            Console.WriteLine("3. Add a grade");
            Console.WriteLine("4. Edit grades");
            Console.WriteLine("5. view top Student");
            Console.WriteLine("6. view bottom Student");
            Console.WriteLine("7. Remove Student");
            Console.WriteLine("8. Exit the Ledger");
            Console.Write("Please choose a vaild number:  ");
            number = Console.ReadLine().ToLower();
            Console.Clear();

            switch (number)
            {
                case "1":
                    {
                        Console.WriteLine("The current grades are");
                        Console.WriteLine(" press 'enter' to return to the Title");
                        Console.ReadLine();
                        Title();
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("The average class score is...."); 
                        Console.WriteLine("Press 'enter' to return to the Title");
                        Console.ReadLine();
                        Title();
                        break;
                    }
                case "3":
                    {
                        double grade;
                        Console.WriteLine("Type in the grade youd like to enter");
                        Console.WriteLine("Use only whole or decimal numbers");
                        Console.Write("grade: ");
                        double.TryParse(Console.ReadLine(), out grade);

                        Console.WriteLine("Press 'enter' to return to the Title");
                        Console.ReadLine();
                        Title();
                        break;

                    }
                case "4":
                    {
                        double edit;
                        Console.WriteLine("Here is where you edit the grades!");
                        Console.Write("Remove which grade: ");
                        double.TryParse(Console.ReadLine());
                        Console.WriteLine("Press 'enter' to return to the Title");
                        Console.ReadLine();
                        Title();
                        break;
                    }
                case "5":
                    {
                        Console.WriteLine("The top student is" );
                        Console.WriteLine("");
                        Console.WriteLine("Press 'enter' to return to the Title");
                        Console.ReadLine();
                        Title();
                        break;
                    }
                case "6":
                    {
                        Console.WriteLine("The Bottom Student is ");
                        Console.WriteLine("");
                        Console.WriteLine("Press 'enter' to return to the Title");
                        Console.ReadLine();
                        Title();
                        break;
                    }
                case "7":
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("Press 'enter' to return to the Title");
                        Console.ReadLine();
                        Title();
                        break;
                    }
                case "8":
                case "exit":
                    {
                        Console.Write("8");
                        Console.ReadLine();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("That is an invalid choice please try again");
                        Title();
                        break;
                    }


            }
        }
        public static void Grade();

            
    }
}
