using System;
using System.Collections.Generic;

namespace csv_reader
{
    class Program
    {
        static icsv reader = new csv();
        static List<string[]> list = new List<string[]>();
        
        static void Main(string[] args)
        {
            list = reader.readFile("../../../test.csv");

            foreach (string[] line in list)
            {
                for(int i = 0; i < line.Length; i++)
                {
                    Console.Write(line[i]+" ");
                }
                Console.Write("\n");
            }

            reader.writeFile("../../../OUT/test.txt",list);
        }
    }
}
