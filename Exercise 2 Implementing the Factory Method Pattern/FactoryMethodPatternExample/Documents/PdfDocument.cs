namespace FactoryMethodPatternExample.Documents
{
    /// <summary>
    /// Represents a PDF document implementation of IDocument.
    /// </summary>
    public class PdfDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Opening PDF document: PdfDocument.pdf");
        }
    }
}
