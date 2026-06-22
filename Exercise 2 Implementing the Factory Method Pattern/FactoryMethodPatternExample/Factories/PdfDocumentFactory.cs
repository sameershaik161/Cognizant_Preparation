using FactoryMethodPatternExample.Documents;

namespace FactoryMethodPatternExample.Factories
{
    /// <summary>
    /// Concrete factory that creates PdfDocument instances.
    /// </summary>
    public sealed class PdfDocumentFactory : DocumentFactory
    {
        public override IDocument CreateDocument()
        {
            return new PdfDocument();
        }
    }
}
