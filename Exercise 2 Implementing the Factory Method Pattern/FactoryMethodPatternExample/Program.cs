using FactoryMethodPatternExample.Documents;
using FactoryMethodPatternExample.Factories;

namespace FactoryMethodPatternExample
{
    /// <summary>
    /// Demonstrates the Factory Method pattern using a document management example.
    /// </summary>
    internal static class Program
    {
        private static void Main()
        {
            DocumentFactory[] factories = new DocumentFactory[]
            {
                new WordDocumentFactory(),
                new PdfDocumentFactory(),
                new ExcelDocumentFactory(),
            };

            foreach (DocumentFactory factory in factories)
            {
                IDocument document = factory.CreateDocument();
                Console.WriteLine($"Created document: {document.GetType().Name}");
                document.Open();
                Console.WriteLine();
            }

            Console.WriteLine("All documents created and opened successfully.");
        }
    }
}
