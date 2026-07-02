using System;

namespace Exercise02_FactoryMethodPattern
{
    public class WordDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Word Document Created.");
        }
    }
}