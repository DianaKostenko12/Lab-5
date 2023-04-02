using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    abstract class Spiritual:MusicalInstrument
    {
        public string MaterialOfInstrument { get; set; }
        public Spiritual(string materialOfInstrument)
        {
            MaterialOfInstrument = materialOfInstrument;
        }
    }
}
