using System;

namespace Exercise02_FactoryMethodPattern
{
    public class ExcelDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Excel Document Created.");
        }
    }
}