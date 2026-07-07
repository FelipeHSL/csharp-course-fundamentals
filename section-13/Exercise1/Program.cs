using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Exercise1.Entities;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<LogRecord> set = new HashSet<LogRecord>();
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        
                        string[] line = sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime instante = DateTime.Parse(line[1]);
                        set.Add(new LogRecord{UserName = name, Instante = instante});
                        
                    }

                    Console.WriteLine("Total Users: " +set.Count);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
