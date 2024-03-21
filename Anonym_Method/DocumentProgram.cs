namespace Anonym_Method;

public class DocumentProgram : IEditDocument, ISaveDocument
{
    public virtual void EditDcument()
    {
        Console.WriteLine("Editdocument");
    }

    public virtual void SaveDocument()
    {
        Console.WriteLine("SaveDocument");
    }

    public void Open_Document()
    {
        Console.WriteLine("Document Opened");
    }
}
