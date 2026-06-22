namespace FactoryMethodPatternExample.Documents
{
    /// <summary>
    /// Defines the common document interface for the Factory Method pattern.
    /// </summary>
    public interface IDocument
    {
        /// <summary>
        /// Opens the document and performs the required display logic.
        /// </summary>
        void Open();
    }
}
