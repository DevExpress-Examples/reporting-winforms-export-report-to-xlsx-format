Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI
Imports System.Windows.Forms
Imports System

Namespace XlsxExportExample
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
			' Create a report.
			Dim label As New XRLabel() With {.Text = "Some content goes here..."}
			Dim band As New DetailBand()
			band.Controls.Add(label)
			Dim report As New XtraReport() With {.Name = "Report Example"}
			report.Bands.Add(band)


			' Specify export options.
			Dim xlsxExportOptions As New XlsxExportOptions() With {
				.ExportMode = XlsxExportMode.SingleFile,
				.ShowGridLines = True,
				.FitToPrintedPageHeight = True
			}

			' Specify the path for the exported XLSX file.  
			Dim xlsxExportFileName As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\Downloads\" & report.Name & ".xlsx"

			' Export the report.
			report.ExportToXlsx(xlsxExportFileName, xlsxExportOptions)
			System.Diagnostics.Process.Start(xlsxExportFileName)
		End Sub
	End Class
End Namespace
