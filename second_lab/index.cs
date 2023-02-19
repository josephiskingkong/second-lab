using System;
using System.Collections.Generic;

namespace SingletonOutputData
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu.Instance.DisplayMenuOptions();

            // Select and execute the corresponding action
            switch (Menu.Instance.GetUserMenuInput())
            {
                case 1:
                    DisplayHTMLData();
                    break;
                case 2:
                    DisplayTXTData();
                    break;
                case 3:
                    DisplayWordData();
                    break;
                case 4:
                    DisplayExcelData();
                    break;
                case 5:
                    DisplayPDFData();
                    break;
                default:
                    Console.WriteLine("Invalid option selected. Please try again");
                    break;
            }
        }

        // Displays data related to HTML class
        private static void DisplayHTMLData()
        {
            Console.WriteLine("HTML (HyperText Markup Language) is the standard markup language for creating web pages and web applications.");
        }

        // Displays data related to TXT class
        private static void DisplayTXTData()
        {
            Console.WriteLine("TXT files are plain text files stored in the text file format. It contains unformatted text and is viewable in any text editor.");
        }

        // Displays data related to Word class
        private static void DisplayWordData()
        {
            Console.WriteLine("Microsoft Word is a word processing application from Microsoft Office. It enables users to create, modify, view and print documents.");
        }

        // Displays data related to Excel class
        private static void DisplayExcelData()
        {
            Console.WriteLine("Microsoft Excel is a spreadsheet application from Microsoft Office. It enables users to create, manage and store complex data in tabular formats with formulas and calculations.");
        }

        // Displays data related to PDF class
        private static void DisplayPDFData()
        {
            Console.WriteLine("The Portable Document Format (PDF) is an open standard for document exchange developed by Adobe Systems. It allows users to display a document exactly as the author intended, regardless of the software and hardware used.");
        }

        // Menu singleton class
        public sealed class Menu
        {
            // Private constructor
            private Menu() { }

            // Private instance field
            private static Menu _instance = null;

            // Access to/creation of instance
            public static Menu Instance
            {
                get
                {
                    if (_instance == null)
                    {
                        _instance = new Menu();
                    }
                    return _instance;
                }
            }

            // Method to display menu options
            public void DisplayMenuOptions()
            {
                Console.WriteLine("Please select one of the following options (enter the corresponding number):");
                Console.WriteLine("1. HTML");
                Console.WriteLine("2. TXT");
                Console.WriteLine("3. Word");
                Console.WriteLine("4. Excel");
                Console.WriteLine("5. PDF");
            }

            // Method to get user menu input
            public int GetUserMenuInput()
            {
                string inputString = Console.ReadLine();
                int inputNumber;
                bool result = Int32.TryParse(inputString, out inputNumber);
                if (result && inputNumber > 0 && inputNumber <= 5)
                {
                    return inputNumber;
                }
                else
                {
                    return -1;
                }
            }
        }

    }
}
