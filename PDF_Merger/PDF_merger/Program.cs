using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

internal class PdfMerger
{
    static void Main()
    {
        string[] files =
            {
                "D:\\BOOK\\Computer_book\\c#\\NotesC sharp\\Notes - Section 1 - Course Fundamentals.pdf",
                "D:\\BOOK\\Computer_book\\c#\\NotesC sharp\\Notes - Section 2 - C# Language Basics.pdf",
                "D:\\BOOK\\Computer_book\\c#\\NotesC sharp\\Notes - Section 4 - OOP Basics.pdf",
                "D:\\BOOK\\Computer_book\\c#\\NotesC sharp\\Notes - Section 5 - Fields.pdf",
                "D:\\BOOK\\Computer_book\\c#\\NotesC sharp\\Notes - Section 6 - Methods.pdf",
                "D:\\BOOK\\Computer_book\\c#\\NotesC sharp\\Notes - Section 7 - Type Conversion.pdf",
                "D:\\BOOK\\Computer_book\\c#\\NotesC sharp\\Notes - Section 8 - Constructors.pdf",
                "D:\\BOOK\\Computer_book\\c#\\NotesC sharp\\Notes - Section 9 - Properties.pdf",
                "D:\\BOOK\\Computer_book\\c#\\NotesC sharp\\Notes - Section 10 - Inheritance, Hiding and Overriding.pdf",
                "D:\\BOOK\\Computer_book\\c#\\NotesC sharp\\Notes - Section 11 - Abstract Classes and Interfaces.pdf" ,
                "D:\\BOOK\\Computer_book\\c#\\NotesC sharp\\Notes - Section 12 - Namespaces.pdf" ,
                "D:\\BOOK\\Computer_book\\c#\\NotesC sharp\\Notes - Section 13 - Partial and Static Classes, Enumerations.pdf" ,
                "D:\\BOOK\\Computer_book\\c#\\NotesC sharp\\Notes - Section 14 - Structs.pdf" ,
                "D:\\BOOK\\Computer_book\\c#\\NotesC sharp\\Notes - Section 15 - System.Object Class.pdf" ,
                "D:\\BOOK\\Computer_book\\c#\\NotesC sharp\\Notes - Section 16 - Generics.pdf" ,
                "D:\\BOOK\\Computer_book\\c#\\NotesC sharp\\Notes - Section 17 - Handling Null.pdf" ,
                "D:\\BOOK\\Computer_book\\c#\\NotesC sharp\\Notes - Section 18 - Extension Methods and Pattern Matching.pdf" ,
                "D:\\BOOK\\Computer_book\\c#\\NotesC sharp\\Notes - Section 19 - GC, Destructors, IDisposable.pdf" ,
                "D:\\BOOK\\Computer_book\\c#\\NotesC sharp\\Notes - Section 20 - Delegates and Events.pdf" ,
                "D:\\BOOK\\Computer_book\\c#\\NotesC sharp\\Notes - Section 21 - Arrays.pdf" ,
                "D:\\BOOK\\Computer_book\\c#\\NotesC sharp\\Notes - Section 22 - Collections.pdf" ,
                "D:\\BOOK\\Computer_book\\c#\\NotesC sharp\\Notes - Section 23 - Anonymous Types.pdf" ,
                "D:\\BOOK\\Computer_book\\c#\\NotesC sharp\\Notes - Section 24 - Tuples.pdf" ,
                "D:\\BOOK\\Computer_book\\c#\\NotesC sharp\\Notes - Section 25 - LINQ.pdf" ,
                "D:\\BOOK\\Computer_book\\c#\\NotesC sharp\\Notes - Section 26 - String, DateTime.pdf" ,
                "D:\\BOOK\\Computer_book\\c#\\NotesC sharp\\Notes - Section 27 - IO, Serialization, Encoding.pdf" ,
                "D:\\BOOK\\Computer_book\\c#\\NotesC sharp\\Notes - Section 28 - Exception Handling.pdf" ,
                "D:\\BOOK\\Computer_book\\c#\\NotesC sharp\\Notes - Section 30 - C# 9 and 10.pdf" ,
                "D:\\BOOK\\Computer_book\\c#\\NotesC sharp\\Notes - Section 31 - Threading.pdf" ,
                "D:\\BOOK\\Computer_book\\c#\\NotesC sharp\\Notes - Section 32 - Tasks.pdf" ,
                "D:\\BOOK\\Computer_book\\c#\\NotesC sharp\\Notes - Section 33 - Async and Await.pdf" ,
                "D:\\BOOK\\Computer_book\\c#\\NotesC sharp\\Notes - Section 34 - C# 11 New Fratures.pdf" ,
                "D:\\BOOK\\Computer_book\\c#\\NotesC sharp\\Notes - Section 35 - C# 12 New Features.pdf"

            };

                    PdfDocument output = new PdfDocument();

                    foreach (string file in files)
                    {
                        PdfDocument input = PdfReader.Open(file, PdfDocumentOpenMode.Import);

                        for (int i = 0; i < input.PageCount; i++)
                        {
                            output.AddPage(input.Pages[i]);
                        }
                    }

                    output.Save("D:\\BOOK\\Computer_book\\c#\\NotesC sharp\\C#Notes.pdf");
    }
}