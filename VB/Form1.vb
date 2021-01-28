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

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			' Create a report.
			Dim report As New XtraReport() With {
				.Name = "Report Example",
				.Bands = {
					New DetailBand() With {
						.Controls = {
							New XRLabel() With {.Text = "Some content goes here..."}
						}
					}
				}
			}

			' Specify export options.
			Dim xlsxExportOptions As New XlsxExportOptions() With {
				.ExportMode = XlsxExportMode.SingleFile,
				.ShowGridLines = True,
				.FitToPrintedPageHeight = True
			}

			' Specify the path for the exported XLSX file.  
			Dim xlsxExportFile As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\Downloads\" & report.Name & ".xlsx"

			' Export the report.
			report.ExportToXlsx(xlsxExportFile, xlsxExportOptions)
		End Sub
	End Class
End Namespace
