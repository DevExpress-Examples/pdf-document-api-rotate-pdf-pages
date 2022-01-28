Imports DevExpress.Pdf

Namespace PdfPageRotationExample

    Friend Class Program

        Shared Sub Main(ByVal args As String())
            Using pdfDocumentProcessor As PdfDocumentProcessor = New PdfDocumentProcessor()
                pdfDocumentProcessor.LoadDocument("..\..\docs\TextRotate.pdf")
                Dim angle As Integer = 0
                For Each page As PdfPage In pdfDocumentProcessor.Document.Pages
                    angle =(angle + 90) Mod 360
                    page.Rotate = angle
                Next

                pdfDocumentProcessor.SaveDocument("..\..\docs\Rotated.pdf")
            End Using
        End Sub
    End Class
End Namespace
