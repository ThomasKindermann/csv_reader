using System;
using System.Collections.Generic;
namespace csv_reader
{
    public interface icsv
    {

        public List<string[]> readFile(string path);

        public void writeFile(string path, List<string[]> input);


    }
}
