namespace FactoryMethodPatternExample.Documents
{
    /// <summary>
    /// Represents an Excel document implementation of IDocument.
    /// </summary>
    public class ExcelDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Opening Excel document: ExcelDocument.xlsx");
        }
    }
}
