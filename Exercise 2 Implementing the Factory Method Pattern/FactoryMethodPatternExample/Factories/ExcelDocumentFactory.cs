using FactoryMethodPatternExample.Documents;

namespace FactoryMethodPatternExample.Factories
{
    /// <summary>
    /// Concrete factory that creates ExcelDocument instances.
    /// </summary>
    public sealed class ExcelDocumentFactory : DocumentFactory
    {
        public override IDocument CreateDocument()
        {
            return new ExcelDocument();
        }
    }
}
