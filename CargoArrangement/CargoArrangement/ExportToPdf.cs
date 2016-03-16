using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CargoArrangement
{
    class ExportToPdf
    {

        public Document CreateDocument(Canvas canvas, string filePath)
        {
            Document document = new Document();
            document.Info.Title = "Cargo Report";
            document.Info.Subject = "";
            document.Info.Author = "";

            Section section = document.AddSection();
            Paragraph paragraph = section.AddParagraph();
            paragraph.Format.SpaceBefore = Unit.FromCentimeter(0);

            paragraph = section.AddParagraph("Схема размещения груза в автомобиле");
            paragraph.Format.Font.Size = 16;
            paragraph.Format.Font.Name = "Times New Roman";
            paragraph.Format.Alignment = ParagraphAlignment.Center;
            paragraph.Format.Font.Color = Colors.Black;
            paragraph.Format.SpaceAfter = Unit.FromCentimeter(0);

            paragraph = section.AddParagraph("Дата отгрузки: ");
            paragraph.AddDateField();

            DefineTable(document);

            MigraDoc.DocumentObjectModel.IO.DdlWriter.WriteToFile(document, filePath);

            PdfDocumentRenderer renderer = new PdfDocumentRenderer(true, PdfSharp.Pdf.PdfFontEmbedding.Always);
            renderer.Document = document;

            renderer.RenderDocument();

            renderer.PdfDocument.Save(filePath);
            Process.Start(filePath);

            return document;
        }

        private void DefineTable(Document document)
        {
            Paragraph paragraph = document.LastSection.AddParagraph("Some text");

            Table table = new Table();
            table.Borders.Width = 0.75;

            Column column = table.AddColumn(Unit.FromCentimeter(2));
            column.Format.Alignment = ParagraphAlignment.Center;

            table.AddColumn(Unit.FromCentimeter(3));
            table.AddColumn(Unit.FromCentimeter(3));
            table.AddColumn(Unit.FromCentimeter(2));
            table.AddColumn(Unit.FromCentimeter(8));

            Row row = table.AddRow();
            Cell cell = row.Cells[0];
            cell.AddParagraph("№");
            cell = row.Cells[1];
            cell.AddParagraph("Клиент");
            row.Cells[2].AddParagraph("Размер палеты");
            row.Cells[3].AddParagraph("К-во");

            //for (var i=0; i<5; i++)
            //    table.AddRow();

            var rowContent = table.AddRow();
            rowContent.Height = Unit.FromCentimeter(22);

            table.SetEdge(0, 0, 0, 0, Edge.Box, BorderStyle.Single, 1.5, Colors.Black);
            document.LastSection.Add(table);

            document.LastSection.AddParagraph("Составил: ");

        }

    }


}
