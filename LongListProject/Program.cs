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

            
            // Create an IF loop that determines if Forster file exists, if not, create list

            List<string> Forster = new List<string>();
            char Another = 'N';

            do
            {
                Console.WriteLine($" Please type the task you wish to add to the list.");
                Forster.Add(Console.ReadLine());
                Console.WriteLine($" New task added. Do you wish to add another? Y/N");
                Another = Convert.ToChar(Console.ReadLine());

            } while (Another == 'Y');

            foreach (string item in Forster)
            {
                Console.WriteLine(item);
            }

            System.IO.File.WriteAllLines(@"C:\Users\WWStudent\Documents\Test Folder\ForsterList.txt", Forster);

            // Should move current item to end
            // Insert a new item at position 2.
            //Console.WriteLine("\nInsert(2, \"1834\")");
            // parts.Insert(2, new Part() { PartName = "brake lever", PartId = 1834 });
        }

        // Create a directory to store files in
    }
}
