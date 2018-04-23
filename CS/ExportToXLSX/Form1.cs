using System;
using System.Diagnostics;
using System.Windows.Forms;
using DevExpress.XtraPrinting;
// ...

namespace ExportToXLSX {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            // A path to export a report.
            string reportPath = "c:\\Test.xlsx";

            // Create a report instance.
            XtraReport1 report = new XtraReport1();

            // Get its XLS export options.
            XlsxExportOptions xlsxOptions = report.ExportOptions.Xlsx;

            // Set XLS-specific export options.
            xlsxOptions.ShowGridLines = true;
            xlsxOptions.TextExportMode = TextExportMode.Value;
            xlsxOptions.ExportHyperlinks = true;
            xlsxOptions.SheetName = "My Sheet";

            // Export the report to XLS.
            report.ExportToXlsx(reportPath);

            // Show the result.
            StartProcess(reportPath);
        }

        // Use this method if you want to automaically open
        // the created XLS file in the default program.
        public void StartProcess(string path) {
            Process process = new Process();
            try {
                process.StartInfo.FileName = path;
                process.Start();
                process.WaitForInputIdle();
            }
            catch { }
        }

    }
}