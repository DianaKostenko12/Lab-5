using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    internal class Drum:Percussion
    {
        public Drum(int volume):base(volume) { }
        public override void Sound()
        {
            Console.WriteLine("Барабан видає звук: бам-бам");
        }
    }
}
