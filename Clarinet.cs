using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    internal class Clarinet : Spiritual
    {
        public Clarinet(string material) : base(material) { }

        public override void Sound()
        {
            Console.WriteLine("Кларнет видає звук: Ту-ту-ту");
        }
    }
}
