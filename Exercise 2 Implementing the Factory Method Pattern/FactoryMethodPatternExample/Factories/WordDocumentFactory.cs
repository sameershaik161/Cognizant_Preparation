using FactoryMethodPatternExample.Documents;

namespace FactoryMethodPatternExample.Factories
{
    /// <summary>
    /// Concrete factory that creates WordDocument instances.
    /// </summary>
    public sealed class WordDocumentFactory : DocumentFactory
    {
        public override IDocument CreateDocument()
        {
            return new WordDocument();
        }
    }
}
