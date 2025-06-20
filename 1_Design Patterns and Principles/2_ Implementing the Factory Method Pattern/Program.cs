using System;

// Product Interface
public interface IDocument
{
    void Open();
}

// Concrete Products
public class WordDocument : IDocument
{
    public void Open()
    {
        Console.WriteLine("Opening Word document...");
    }
}

public class PdfDocument : IDocument
{
    public void Open()
    {
        Console.WriteLine("Opening PDF document...");
    }
}

public class ExcelDocument : IDocument
{
    public void Open()
    {
        Console.WriteLine("Opening Excel document...");
    }
}

// Abstract Factory
public abstract class DocumentFactory
{
    public abstract IDocument CreateDocument();
}

// Concrete Factories
public class WordFactory : DocumentFactory
{
    public override IDocument CreateDocument()
    {
        return new WordDocument();
    }
}

public class PdfFactory : DocumentFactory
{
    public override IDocument CreateDocument()
    {
        return new PdfDocument();
    }
}

public class ExcelFactory : DocumentFactory
{
    public override IDocument CreateDocument()
    {
        return new ExcelDocument();
    }
}

// Client / Test
class Program
{
    static void Main(string[] args)
    {
        // Word document
        DocumentFactory wordFactory = new WordFactory();
        IDocument wordDoc = wordFactory.CreateDocument();
        wordDoc.Open();

        // PDF document
        DocumentFactory pdfFactory = new PdfFactory();
        IDocument pdfDoc = pdfFactory.CreateDocument();
        pdfDoc.Open();

        // Excel document
        DocumentFactory excelFactory = new ExcelFactory();
        IDocument excelDoc = excelFactory.CreateDocument();
        excelDoc.Open();
    }
}

