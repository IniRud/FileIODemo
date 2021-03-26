using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIODemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\iniak\OneDrive\Desktop\localDAL\trial.txt";

            //string[] lines = File.ReadAllLines(filePath);

            List<string> lines = new List<string>();
            List<Person> people = new List<Person>();

            lines = File.ReadAllLines(filePath).ToList();

            foreach (string line in lines)
            {
                string[] items = line.Split(',');
                Person p = new Person(items[0], items[1], items[2]);
                people.Add(p);
            }

            List<string> outContents = new List<string>();
            foreach (Person p in people)
            {
                Console.WriteLine(p);
                outContents.Add(p.ToString());
            }

            string outFile = @"C:\Users\iniak\OneDrive\Desktop\localDAL\outFile.txt";
            File.WriteAllLines(outFile, outContents);

            //lines = File.ReadAllLines(filePath).ToList();

            //foreach (string line in lines)
            //{
            //    Console.WriteLine(line);
            //}
            //lines.Add("calgary, alberta, www.ab.ca");
            //File.WriteAllLines(filePath, lines);

            Console.ReadLine();
        }
    }
}
