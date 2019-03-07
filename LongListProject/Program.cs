﻿using System;
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
                Console.WriteLine(" Please choice between the following actions:");
                Console.WriteLine(" Create New File: Press 1");
                Console.WriteLine(" Load File: Press 2");
                Console.WriteLine(" Add new task to Tasklist: Press 3");
                Console.WriteLine(" Display Tasklist: Press 4");
                Console.WriteLine(" Save Current List: Press 5");
                Console.WriteLine(" Quit Program: Press Q");
                input = Console.ReadLine();

                if (input == "1")
                {
                    Forster = CreateFile();
                }
                else if (input == "2")
                {
                    Forster = CreateFile();
                    Console.WriteLine("Please enter the name of the file you wish you load.");
                    string LoadFileAs = Console.ReadLine();
                    string[] stringArray = System.IO.File.ReadAllLines(@"C:\Users\WWStudent\Documents\Test Folder\" + $"{LoadFileAs}.txt");
                    
                    foreach (string element in stringArray)
                    {
                        Console.WriteLine(element);
                        Forster.Add(element);
                    }
                }
                else if (input == "3")
                {
                    Console.WriteLine("Please add your task.");
                    Forster.Add(Console.ReadLine());
                }
                else if (input == "4")
                {
                    foreach (string item in Forster)
                    {
                        Console.WriteLine(item);
                    }
                }
                else if (input == "5")
                {
                    Console.WriteLine("Please name your file.");
                    string SaveFileAs = Console.ReadLine();
                    System.IO.File.WriteAllLines(@"C:\Users\WWStudent\Documents\Test Folder\" + $"{SaveFileAs}.txt", Forster); 
                }
                else if (input == "Q")
                {
                    return;
                }
            } while (input != "Q");

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

        
        // Create a directory to store files in
    }
}
