using System;
using System.Collections.Generic;

namespace Lab_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Orchestra orchestra = new Orchestra(new List<MusicalInstrument>()
            {
                new Clarinet("Zalupa"),
                new Drum(102),
                new Guitar(6),
                new Violin(4),
                new Djembe(100)
            });

            Console.WriteLine("Даний оркестр:");
            orchestra.GetOrchestra();
        }
    }
}
