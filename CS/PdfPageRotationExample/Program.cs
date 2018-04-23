#region #Reference
using DevExpress.Pdf;
// ...
#endregion #Reference

namespace PdfPageRotationExample {
#region #Code
class Program {
    static void Main(string[] args) {
        PdfDocumentProcessor pdfDocumentProcessor = new PdfDocumentProcessor();
        pdfDocumentProcessor.LoadDocument("..\\..\\docs\\TextRotate.pdf");
        int angle = 0;
        foreach (PdfPageTreeObject page in pdfDocumentProcessor.Document.Pages) {
            angle = (angle + 90) % 360;
            page.Rotate = angle;
        }
        pdfDocumentProcessor.SaveDocument("..\\..\\docs\\Rotated.pdf");
    }
}
#endregion #Code
}