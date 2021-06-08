using System;
using System.Collections.Generic;
using System.IO;

namespace csv_reader
{
    public class csv : icsv
    {
     

        private List<string[]> lines = new List<string[]>();

        public List<string[]> readFile(string path)
        {
            
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    lines.Add(line.Split(","));
                }
            }

            return lines;
        }

        public void writeFile(string path, List<string[]> input)
        {

            using (StreamWriter sw =  new StreamWriter(path)) {
                foreach (string[] line in input)
                {
                    sw.WriteLine(String.Join(",",line));
                }
            }
        }
    }
}
