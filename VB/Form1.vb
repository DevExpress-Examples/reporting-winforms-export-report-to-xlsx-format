Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI
Imports System.Windows.Forms
Imports System

Namespace XlsxExportExample

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
            ' Create a report.
            Dim report As XtraReport = New XtraReport() With {.Name = "Report Example"}
            ' Specify export options.
            Dim xlsxExportOptions As XlsxExportOptions = New XlsxExportOptions() With {.ExportMode = XlsxExportMode.SingleFile, .ShowGridLines = True, .FitToPrintedPageHeight = True}
            ' Specify the path for the exported XLSX file.  
            Dim xlsxExportFileName As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\Downloads\" & report.Name & ".xlsx"
            ' Export the report.
            report.ExportToXlsx(xlsxExportFileName, xlsxExportOptions)
            System.Diagnostics.Process.Start(xlsxExportFileName)
        End Sub
    End Class
End Namespace
