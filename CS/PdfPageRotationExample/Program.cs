using DevExpress.Pdf;
using System.Diagnostics;

namespace PdfPageRotationExample {

    class Program {
        static void Main(string[] args) {
            using (PdfDocumentProcessor pdfDocumentProcessor = new PdfDocumentProcessor()) {
                pdfDocumentProcessor.LoadDocument("..\\..\\..\\docs\\TextRotate.pdf");
                int angle = 0;
                foreach (PdfPage page in pdfDocumentProcessor.Document.Pages) {
                    angle = (angle + 90) % 360;
                    page.Rotate = angle;
                }
                pdfDocumentProcessor.SaveDocument("..\\..\\..\\docs\\Rotated.pdf");
            }
            Process.Start(new ProcessStartInfo("..\\..\\..\\docs\\Rotated.pdf") { UseShellExecute = true });
        }
    }
}