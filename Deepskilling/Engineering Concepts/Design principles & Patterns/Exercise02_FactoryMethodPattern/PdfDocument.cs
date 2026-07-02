using System;

namespace Exercise02_FactoryMethodPattern
{
    public class PdfDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("PDF Document Created.");
        }
    }
}
