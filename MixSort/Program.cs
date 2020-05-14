using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixSort
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] file1 = File.ReadAllLines(@"C:\Users\kaviya\source\repos\MixSort\textfile\File11.txt");
            string[] file2 = File.ReadAllLines(@"C:\Users\kaviya\source\repos\MixSort\textfile\File12.txt");
            var myList = new List<string>();
            myList.AddRange(file1);
            myList.AddRange(file2);
            string[] File3 = myList.ToArray();
            Console.WriteLine("The contents of the files before sorting the alphabets");
            foreach (string files1 in File3)
            {
                Console.WriteLine(files1);
            }
            Array.Sort(File3);
            Console.WriteLine("The contents of the files after sorting the alphabets");
            foreach (string files in File3)
            {
                Console.WriteLine(files);
            }
            Console.ReadLine();

        }
    }
}
