using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelProcessing
{
    public partial class Form1 : Form
    {
        private string fileName;
        private string fileNameToSave;

        public Form1()
        {
            InitializeComponent();
            rBtnToTitleCase.Select();
        }

        private void btnOpenDocument_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Лист Microsoft Excel|*.xlsx";
            openFileDialog1.FilterIndex = 1;

            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
                lbFileName.Text = @fileName;
                btnProcess.Enabled = true;

            }
            
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            using (var templateFile = File.Open(@fileName, FileMode.Open, FileAccess.Read))
            {
                using (var stream = new MemoryStream())
                {
                    templateFile.CopyTo(stream);

                    using (var excelDoc = SpreadsheetDocument.Open(stream, true))
                    {
                        SheetData sheetData = excelDoc.WorkbookPart.WorksheetParts.First<WorksheetPart>().Worksheet.GetFirstChild<SheetData>();

                        var shareStringPart = excelDoc.WorkbookPart.GetPartsOfType<SharedStringTablePart>().First();

                        var sharedStringItems = shareStringPart.SharedStringTable.Elements<SharedStringItem>().ToList();

                        foreach (var item in sharedStringItems)
                        {
                            if (rBtnToTitleCase.Checked)
                            {
                                item.Text.Text = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(item.InnerText);
                            }
                            else if (rBtnToUpper.Checked)
                            {
                                item.Text.Text = Thread.CurrentThread.CurrentCulture.TextInfo.ToUpper(item.InnerText);
                            }
                        }


                    }

                    stream.Seek(0, SeekOrigin.Begin);

                    saveFileDialog1.Filter = "Лист Microsoft Excel|*.xlsx";
                    saveFileDialog1.FilterIndex = 1;

                    DialogResult result = saveFileDialog1.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        fileNameToSave = saveFileDialog1.FileName;

                        using (var fileStream = File.Create(@fileNameToSave))
                        {
                            stream.CopyTo(fileStream);
                        }

                        Process.Start("explorer.exe", @"/select, " + @fileNameToSave);

                    }

                }

            }
        }
    }
}
