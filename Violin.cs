using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    internal class Violin:Stringed
    {
        public Violin(int countOfString) : base(countOfString) { }
        public override void Sound()
        {
            Console.WriteLine("Скрипка видає звук: скряб-скряб");
        }
    }
}
