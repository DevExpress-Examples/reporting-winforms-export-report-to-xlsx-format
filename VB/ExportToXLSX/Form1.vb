Imports Microsoft.VisualBasic
Imports System
Imports System.Diagnostics
Imports System.Windows.Forms
Imports DevExpress.XtraPrinting
' ...

Namespace ExportToXLSX
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			' A path to export a report.
			Dim reportPath As String = "c:\Test.xlsx"

			' Create a report instance.
			Dim report As New XtraReport1()

			' Get its XLS export options.
			Dim xlsxOptions As XlsxExportOptions = report.ExportOptions.Xlsx

			' Set XLS-specific export options.
			xlsxOptions.ShowGridLines = True
			xlsxOptions.TextExportMode = TextExportMode.Value
			xlsxOptions.ExportHyperlinks = True
			xlsxOptions.SheetName = "My Sheet"

			' Export the report to XLS.
			report.ExportToXlsx(reportPath)

			' Show the result.
			StartProcess(reportPath)
		End Sub

		' Use this method if you want to automaically open
		' the created XLS file in the default program.
		Public Sub StartProcess(ByVal path As String)
			Dim process As New Process()
			Try
				process.StartInfo.FileName = path
				process.Start()
				process.WaitForInputIdle()
			Catch
			End Try
		End Sub

	End Class
End Namespace