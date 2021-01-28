using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using System.Windows.Forms;
using System;

namespace XlsxExportExample {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Create a report.
            XtraReport report = new XtraReport() {
                Name = "Report Example",
                Bands = {
                    new DetailBand() {
                        Controls = {
                            new XRLabel() {
                                Text = "Some content goes here...",
                            }
                        }
                    }
                }
            };

            // Specify export options.
            XlsxExportOptions xlsxExportOptions = new XlsxExportOptions() {
                ExportMode = XlsxExportMode.SingleFile,
                ShowGridLines = true,
                FitToPrintedPageHeight = true
            };

            // Specify the path for the exported XLSX file.  
            string xlsxExportFile =
                Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) +
                @"\Downloads\" +
                report.Name +
                ".xlsx";

            // Export the report.
            report.ExportToXlsx(xlsxExportFile, xlsxExportOptions);
        }
    }
}
