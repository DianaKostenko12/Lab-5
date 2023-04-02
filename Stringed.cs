using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    abstract class Stringed:MusicalInstrument
    {
        public int CountOfString { get; set; }
        public Stringed(int countOfString)
        {
            CountOfString = countOfString;
        }
    }
}
