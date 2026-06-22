using FactoryMethodPatternExample.Documents;

namespace FactoryMethodPatternExample.Factories
{
    /// <summary>
    /// Declares the factory method for creating document objects.
    /// </summary>
    public abstract class DocumentFactory
    {
        /// <summary>
        /// Creates a new document instance.
        /// </summary>
        /// <returns>A concrete IDocument implementation.</returns>
        public abstract IDocument CreateDocument();
    }
}
