namespace Exercise02_FactoryMethodPattern
{
    public class ExcelFactory : DocumentFactory
    {
        public override IDocument CreateDocument()
        {
            return new ExcelDocument();
        }
    }
}