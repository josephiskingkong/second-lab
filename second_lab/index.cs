using System;
using System.Collections.Generic;

namespace second_lab
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
                    HTML HTMLDoc = new HTML("HTML", "Genius..", "HTML keywords", "HTML Theme...", "C:/User/DungeonMaster/index.html", ".html",
                        "JavaScript, CSS, PHP etc.");
                    HTMLDoc.InfoOut();
                    break;
                case 2:
                    TXT TXTDoc = new TXT("TXT", "Realy bad boy..", "TXT keywords", "TXT Theme...", "C:/User/BROOO/nudes.txt", ".txt",
                        "MacOS, Windows, Ubuntu, Linux etc.");
                    TXTDoc.InfoOut();
                    break;
                case 3:
                    Word WordDoc = new Word("Word", "Realy bad boy.. again...", "Word keywords", "Word Theme...", "C:/User/GodLover/Pray.word", ".word",
                        "Arial", "Special WORD PROPERTY -90% ONLY NOW");
                    WordDoc.InfoOut();
                    break;
                case 4:
                    Excel ExcelDoc = new Excel("Excel", "Mimimimicrosoft", "Excel keywords", "Ecxel Theme...", "C:/User/letmedie/mylasttable.xls", ".xls",
                        999, 999);
                    ExcelDoc.InfoOut();
                    break;
                case 5:
                    PDF PDFDoc = new PDF("PDF", "who are you bro?", "PDF keywords", "PDF Theme...", "C:/User/letmedie/iAmDIFFERENT", ".pdf",
                        ".txt, .word, .ptx, .pptx etc.");
                    PDFDoc.InfoOut();
                    break;
                default:
                    Console.WriteLine("Invalid option selected. Please try again");
                    break;
            }
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
