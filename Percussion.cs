using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    abstract class Percussion : MusicalInstrument
    {
        public int Volume { get; set; }
        public Percussion(int volume)
        {
            Volume = volume;
        }
    }
}
