using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter file full path: ");
            string path = Console.ReadLine();
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    Dictionary<string, int> dictionary = new Dictionary<string, int>();
                    while (!sr.EndOfStream)
                    {
                        string[] votingRecord = sr.ReadLine().Split(',');
                        string canditate = votingRecord[0];
                        int votes = int.Parse(votingRecord[1]);

                        if (dictionary.ContainsKey(canditate))
                        {
                            dictionary[canditate] += votes;
                        }
                        else
                        {
                            dictionary[canditate] = votes;
                        }
                    }

                    foreach (KeyValuePair<string, int> item in dictionary)
                    {
                        Console.WriteLine($"{item.Key}: {item.Value}");
                    }
                        
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error");
                Console.WriteLine(e.Message);
                
            }
        }
    }
}