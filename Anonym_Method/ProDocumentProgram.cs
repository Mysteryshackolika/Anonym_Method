

namespace Anonym_Method;

public class ProDocumentProgram: DocumentProgram
{
    public override sealed void EditDcument()
    {
        Console.WriteLine("Override EditDocument");
    }

    public override sealed void SaveDocument()
    {
        Console.WriteLine("Override SaveDocument");
    }
}
