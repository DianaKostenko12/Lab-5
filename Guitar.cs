using System;

namespace Lab_5
{
    internal class Guitar:Stringed
    {
        public Guitar(int countOfString) : base(countOfString) { }
        public override void Sound()
        {
            Console.WriteLine("Гiтара видає звук: бринь-бринь");
        }
    }
}
