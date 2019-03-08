using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongListProject
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> Forster = new List<string>();
            string input = " ";

            do
            {

                Console.Clear();
                Console.WriteLine(" Please choice between the following actions:");
                Console.WriteLine(" Create New File: Press 1");
                Console.WriteLine(" Load File: Press 2");
                Console.WriteLine(" Add new task to Tasklist: Press 3");
                Console.WriteLine(" Display Tasklist Page 1: Press 4"); //altered text data
                Console.WriteLine(" Save Current List: Press 5");
                Console.WriteLine(" Quit Program: Press Q");
                input = Console.ReadLine();

                if (input == "1")
                {
                    Forster = CreateFile();
                    Console.WriteLine("A new file has been created. Press any key to continue:");
                    Console.ReadKey();
                }
                else if (input == "2")
                {
                    Forster = LoadFile();
                    Console.ReadKey();
                }
                else if (input == "3")
                {
                    Console.WriteLine("Please add your task.");
                    Forster.Add(Console.ReadLine());
                    Console.WriteLine("You task has been added to the list. Press any key continue:");
                    Console.ReadKey();
                }
                else if (input == "4")
                {
                    DisplayTask(Forster);
                }
                else if (input == "5")
                {
                    Console.WriteLine("Please name your file.");
                    string SaveFileAs = Console.ReadLine();
                    System.IO.File.WriteAllLines(@"C:\Users\WWStudent\Documents\Test Folder\" + $"{SaveFileAs}.txt", Forster);
                    Console.WriteLine("Your file has been saved. Please press any key to continue:");
                    Console.ReadKey();
                }
                else if ((input != "Q") || (input == "q"))
                {
                    return;
                }
            } while ((input != "Q") || (input == "q"));

            // Should move current item to end
            // Insert a new item at position 2.
            //Console.WriteLine("\nInsert(2, \"1834\")"); tweak to add non completed item to end
            // parts.Insert(2, new Part() { PartName = "brake lever", PartId = 1834 }); use to add marker of completed to end
        }

        // Create option to create file and one to load previous made file
        
        static List<string> CreateFile()
        {
           List<string> ListFile = new List<string>();
           return ListFile;
        }

        static List<string> LoadFile()
        {
            List<string> Fresh = new List<string>();
            Console.WriteLine("Please enter the name of the file you wish you load.");
            string LoadFileAs = Console.ReadLine();
            string[] stringArray = System.IO.File.ReadAllLines(@"C:\Users\WWStudent\Documents\Test Folder\" + $"{LoadFileAs}.txt");

            foreach (string element in stringArray)
            {
                //deleted display of loaded items
                Fresh.Add(element);
            }
            Console.WriteLine($"{LoadFileAs} has been loaded. Press any key to continue:");
            return Fresh;
        }

        static void DisplayTask( List<string> Listed)
        {
            List<string> tasked = Listed; 
            char charInput = ' ';
            Console.WriteLine(); // adds a space
            Console.WriteLine($"You currently have {tasked.Count} tasks in your list.");
            Console.WriteLine();
            Console.WriteLine("  Page 1");
            Console.WriteLine("----------");


            for (int i = 0; ((i < tasked.Count) && (i < 25)); i++)
            {
                Console.WriteLine($" {i + 1}. {tasked[i]}");
            }

            if (tasked.Count > 25)
            {
                Console.WriteLine("Do you wish to view next page? Y/N");
                charInput = Convert.ToChar(Console.ReadLine());

                if ((charInput == 'Y') || (charInput == 'y'))
                {
                    Console.WriteLine("  Page 2");
                    Console.WriteLine("----------");
                    for (int i = 25; ((i < tasked.Count) && (i < 50)); i++)
                    {
                        Console.WriteLine($" {i + 1}. {tasked[i]}");
                    }
                    Console.ReadKey();

                }
                else if ((charInput == 'N') || (charInput == 'n'))
                {
                    Console.WriteLine("Returning to menu. Press any key to continue:");

                    Console.ReadKey();
                }
            }

            if ((tasked.Count > 50) && (charInput == 'Y') || (charInput == 'y'))
            {
                Console.WriteLine("Do you wish to view next page? Y/N");
                charInput = Convert.ToChar(Console.ReadLine());

                if ((charInput == 'Y') || (charInput == 'y'))
                {
                    Console.WriteLine("  Page 3");
                    Console.WriteLine("----------");

                    for (int i = 50; ((i < tasked.Count) && (i < 75)); i++)
                    {
                        Console.WriteLine($" {i + 1}. {tasked[i]}");
                    }
                    Console.ReadKey();

                }
                else if ((charInput == 'N') || (charInput == 'n'))
                {
                    Console.WriteLine("Returning to menu. Press any key to continue:");
                    Console.ReadKey();
                }

            }
            if ((tasked.Count > 75) && (charInput == 'Y') || (charInput == 'y'))
            {
                Console.WriteLine("Do you wish to view next page? Y/N");
                charInput = Convert.ToChar(Console.ReadLine());

                if ((charInput == 'Y') || (charInput == 'y'))
                {
                    Console.WriteLine("  Page 4");
                    Console.WriteLine("----------");

                    for (int i = 75; ((i < tasked.Count) && (i < 100)); i++)
                    {
                        Console.WriteLine($" {i + 1}. {tasked[i]}");
                    }
                    Console.ReadKey();
                }
                else if ((charInput == 'N') || (charInput == 'n'))
                {
                    Console.WriteLine("Returning to menu. Press any key to continue:");
                    Console.ReadKey();
                }

            }
            Console.ReadKey();
        }

        // Create a directory to store files in
    }
}
