namespace FactoryMethodPatternExample.Documents
{
    /// <summary>
    /// Represents a Word document implementation of IDocument.
    /// </summary>
    public class WordDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Opening Word document: WordDocument.docx");
        }
    }
}
