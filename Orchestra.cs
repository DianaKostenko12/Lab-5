using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    internal class Orchestra
    {
        public List<MusicalInstrument> MusicalInstrumentList { get;set; }
        public Orchestra(List<MusicalInstrument> musicalInstrumentList)
        {
            MusicalInstrumentList = musicalInstrumentList;
        }
        public void GetOrchestra()
        {
            foreach (var instrument in MusicalInstrumentList)
            {
                instrument.Sound();
            }
        }
    }
}
