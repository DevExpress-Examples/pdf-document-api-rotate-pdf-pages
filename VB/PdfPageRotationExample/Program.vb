'#Region "#Reference"
Imports DevExpress.Pdf

' ...
'#End Region  ' #Reference
Namespace PdfPageRotationExample

'#Region "#Code"
    Friend Class Program

        Shared Sub Main(ByVal args As String())
            Dim pdfDocumentProcessor As PdfDocumentProcessor = New PdfDocumentProcessor()
            pdfDocumentProcessor.LoadDocument("..\..\docs\TextRotate.pdf")
            Dim angle As Integer = 0
            For Each page As PdfPageTreeObject In pdfDocumentProcessor.Document.Pages
                angle =(angle + 90) Mod 360
                page.Rotate = angle
            Next

            pdfDocumentProcessor.SaveDocument("..\..\docs\Rotated.pdf")
        End Sub
    End Class
'#End Region  ' #Code
End Namespace
