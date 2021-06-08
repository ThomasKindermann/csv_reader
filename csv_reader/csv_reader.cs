using System;
using System.IO;

namespace csv_reader
{
    public class csv_reader : csv_reader_interface
    {

        private string[] line;
        public string[] readFile(string path)
        {
            using (StreamReader sr = new StreamReader("TestFile.txt"))
            {
                string line;
                // Read and display lines from the file until the end of
                // the file is reached.
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

            return null;
        }

        





    }
}
