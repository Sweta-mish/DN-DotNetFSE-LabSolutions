namespace Exercise02_FactoryMethodPattern
{
    public class PdfFactory : DocumentFactory
    {
        public override IDocument CreateDocument()
        {
            return new PdfDocument();
        }
    }
}