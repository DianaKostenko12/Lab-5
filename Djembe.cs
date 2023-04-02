using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    internal class Djembe:Percussion
    {
        public Djembe(int volume):base(volume) { }
        public override void Sound()
        {
            Console.WriteLine("Джембе видає звук: дун-дун");
        }
    }
}
