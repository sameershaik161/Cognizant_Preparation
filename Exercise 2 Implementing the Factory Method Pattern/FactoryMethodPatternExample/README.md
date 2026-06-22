# FactoryMethodPatternExample

This project demonstrates the Factory Method design pattern using a simple document management system in C# and .NET 8.

## Project Structure

FactoryMethodPatternExample
├── Documents
│   ├── IDocument.cs
│   ├── WordDocument.cs
│   ├── PdfDocument.cs
│   └── ExcelDocument.cs
├── Factories
│   ├── DocumentFactory.cs
│   ├── WordDocumentFactory.cs
│   ├── PdfDocumentFactory.cs
│   └── ExcelDocumentFactory.cs
├── Program.cs
└── FactoryMethodPatternExample.csproj

## What this project demonstrates

- `IDocument` is the common interface for document objects.
- `WordDocument`, `PdfDocument`, and `ExcelDocument` are concrete implementations of `IDocument`.
- `DocumentFactory` is the abstract creator class that declares the factory method `CreateDocument()`.
- `WordDocumentFactory`, `PdfDocumentFactory`, and `ExcelDocumentFactory` are concrete creators that override `CreateDocument()` to produce specific document types.
- `Program.cs` is the client code that uses the factories to create documents without depending on concrete classes directly.

## Files explained

### Documents/IDocument.cs
Defines the `IDocument` interface with one method:
- `void Open()`

### Documents/WordDocument.cs
A concrete document class that implements `IDocument`.
When `Open()` is called, it prints an appropriate message for a Word document.

### Documents/PdfDocument.cs
A concrete document class that implements `IDocument`.
When `Open()` is called, it prints an appropriate message for a PDF document.

### Documents/ExcelDocument.cs
A concrete document class that implements `IDocument`.
When `Open()` is called, it prints an appropriate message for an Excel document.

### Factories/DocumentFactory.cs
The abstract creator class in the Factory Method pattern.
It declares the factory method:
- `public abstract IDocument CreateDocument();`

### Factories/WordDocumentFactory.cs
A concrete factory that creates `WordDocument` objects.

### Factories/PdfDocumentFactory.cs
A concrete factory that creates `PdfDocument` objects.

### Factories/ExcelDocumentFactory.cs
A concrete factory that creates `ExcelDocument` objects.

### Program.cs
Client code that demonstrates how to use each factory:
1. Create `WordDocumentFactory`, `PdfDocumentFactory`, and `ExcelDocumentFactory`.
2. Use each factory to create a document.
3. Call `Open()` on each created document.
4. Print the document type and result.

## How to run the project

1. Open the project folder in Visual Studio 2022 or another editor that supports .NET 8.
2. Build the solution.
3. Run the console app.

Or use the command line:

```powershell
cd "c:\Users\Shiva\OneDrive\Desktop\cts\Design principles & Patterns\Exercise 2 Implementing the Factory Method Pattern\FactoryMethodPatternExample"
dotnet run
```

## Expected output

```text
Created document: WordDocument
Opening Word document: WordDocument.docx

Created document: PdfDocument
Opening PDF document: PdfDocument.pdf

Created document: ExcelDocument
Opening Excel document: ExcelDocument.xlsx

All documents created and opened successfully.
```

## Why use the Factory Method pattern?

- It separates the code that creates objects from the code that uses them.
- It allows adding new document types without changing the client code.
- It improves maintainability by centralizing object creation logic in factory classes.

## Notes

This implementation follows C# coding standards with namespaces, comments, and proper access modifiers.
