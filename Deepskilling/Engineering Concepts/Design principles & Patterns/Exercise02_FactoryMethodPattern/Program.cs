using System;

namespace Exercise02_FactoryMethodPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DocumentFactory wordFactory = new WordFactory();
            IDocument word = wordFactory.CreateDocument();
            word.Open();

            DocumentFactory pdfFactory = new PdfFactory();
            IDocument pdf = pdfFactory.CreateDocument();
            pdf.Open();

            DocumentFactory excelFactory = new ExcelFactory();
            IDocument excel = excelFactory.CreateDocument();
            excel.Open();

            Console.WriteLine("\nFactory Method Pattern Implemented Successfully!");

            Console.ReadKey();
        }
    }
}