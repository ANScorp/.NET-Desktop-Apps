using DocumentFormat.OpenXml.Packaging;
using Ap = DocumentFormat.OpenXml.ExtendedProperties;
using Vt = DocumentFormat.OpenXml.VariantTypes;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Wordprocessing;
using A = DocumentFormat.OpenXml.Drawing;
using Thm15 = DocumentFormat.OpenXml.Office2013.Theme;
using Ds = DocumentFormat.OpenXml.CustomXmlDataProperties;
using M = DocumentFormat.OpenXml.Math;
using Ovml = DocumentFormat.OpenXml.Vml.Office;
using V = DocumentFormat.OpenXml.Vml;
using W15 = DocumentFormat.OpenXml.Office2013.Word;

namespace logistic
{
    public class Invoice
    {
        private Form1 frm;
        private NewDeclaration newDeclaration;

        public Invoice(Form1 form)
        {
            this.frm = form;
        }

        public Invoice(NewDeclaration newDeclaration)
        {
            this.newDeclaration = newDeclaration;
        }

        // Creates a WordprocessingDocument.
        public void CreatePackage(string filePath)
        {
            using (WordprocessingDocument package = WordprocessingDocument.Create(filePath, WordprocessingDocumentType.Document))
            {
                CreateParts(package);
            }
        }

        // Adds child parts and generates content of the specified part.
        private void CreateParts(WordprocessingDocument document)
        {
            ExtendedFilePropertiesPart extendedFilePropertiesPart1 = document.AddNewPart<ExtendedFilePropertiesPart>("rId3");
            GenerateExtendedFilePropertiesPart1Content(extendedFilePropertiesPart1);

            MainDocumentPart mainDocumentPart1 = document.AddMainDocumentPart();
            GenerateMainDocumentPart1Content(mainDocumentPart1);

            StyleDefinitionsPart styleDefinitionsPart1 = mainDocumentPart1.AddNewPart<StyleDefinitionsPart>("rId3");
            GenerateStyleDefinitionsPart1Content(styleDefinitionsPart1);

            ThemePart themePart1 = mainDocumentPart1.AddNewPart<ThemePart>("rId7");
            GenerateThemePart1Content(themePart1);

            NumberingDefinitionsPart numberingDefinitionsPart1 = mainDocumentPart1.AddNewPart<NumberingDefinitionsPart>("rId2");
            GenerateNumberingDefinitionsPart1Content(numberingDefinitionsPart1);

            CustomXmlPart customXmlPart1 = mainDocumentPart1.AddNewPart<CustomXmlPart>("application/xml", "rId1");
            GenerateCustomXmlPart1Content(customXmlPart1);

            CustomXmlPropertiesPart customXmlPropertiesPart1 = customXmlPart1.AddNewPart<CustomXmlPropertiesPart>("rId1");
            GenerateCustomXmlPropertiesPart1Content(customXmlPropertiesPart1);

            FontTablePart fontTablePart1 = mainDocumentPart1.AddNewPart<FontTablePart>("rId6");
            GenerateFontTablePart1Content(fontTablePart1);

            WebSettingsPart webSettingsPart1 = mainDocumentPart1.AddNewPart<WebSettingsPart>("rId5");
            GenerateWebSettingsPart1Content(webSettingsPart1);

            DocumentSettingsPart documentSettingsPart1 = mainDocumentPart1.AddNewPart<DocumentSettingsPart>("rId4");
            GenerateDocumentSettingsPart1Content(documentSettingsPart1);

            SetPackageProperties(document);
        }

        // Generates content of extendedFilePropertiesPart1.
        private void GenerateExtendedFilePropertiesPart1Content(ExtendedFilePropertiesPart extendedFilePropertiesPart1)
        {
            Ap.Properties properties1 = new Ap.Properties();
            properties1.AddNamespaceDeclaration("vt", "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes");
            Ap.Template template1 = new Ap.Template();
            template1.Text = "Normal";
            Ap.TotalTime totalTime1 = new Ap.TotalTime();
            totalTime1.Text = "106";
            Ap.Pages pages1 = new Ap.Pages();
            pages1.Text = "1";
            Ap.Words words1 = new Ap.Words();
            words1.Text = "312";
            Ap.Characters characters1 = new Ap.Characters();
            characters1.Text = "1780";
            Ap.Application application1 = new Ap.Application();
            application1.Text = "Microsoft Office Word";
            Ap.DocumentSecurity documentSecurity1 = new Ap.DocumentSecurity();
            documentSecurity1.Text = "0";
            Ap.Lines lines1 = new Ap.Lines();
            lines1.Text = "14";
            Ap.Paragraphs paragraphs1 = new Ap.Paragraphs();
            paragraphs1.Text = "4";
            Ap.ScaleCrop scaleCrop1 = new Ap.ScaleCrop();
            scaleCrop1.Text = "false";

            Ap.HeadingPairs headingPairs1 = new Ap.HeadingPairs();

            Vt.VTVector vTVector1 = new Vt.VTVector() { BaseType = Vt.VectorBaseValues.Variant, Size = (UInt32Value)2U };

            Vt.Variant variant1 = new Vt.Variant();
            Vt.VTLPSTR vTLPSTR1 = new Vt.VTLPSTR();
            vTLPSTR1.Text = "Название";

            variant1.Append(vTLPSTR1);

            Vt.Variant variant2 = new Vt.Variant();
            Vt.VTInt32 vTInt321 = new Vt.VTInt32();
            vTInt321.Text = "1";

            variant2.Append(vTInt321);

            vTVector1.Append(variant1);
            vTVector1.Append(variant2);

            headingPairs1.Append(vTVector1);

            Ap.TitlesOfParts titlesOfParts1 = new Ap.TitlesOfParts();

            Vt.VTVector vTVector2 = new Vt.VTVector() { BaseType = Vt.VectorBaseValues.Lpstr, Size = (UInt32Value)1U };
            Vt.VTLPSTR vTLPSTR2 = new Vt.VTLPSTR();
            vTLPSTR2.Text = "Продавец:";

            vTVector2.Append(vTLPSTR2);

            titlesOfParts1.Append(vTVector2);
            Ap.Company company1 = new Ap.Company();
            company1.Text = "ТОО ВАМП";
            Ap.LinksUpToDate linksUpToDate1 = new Ap.LinksUpToDate();
            linksUpToDate1.Text = "false";
            Ap.CharactersWithSpaces charactersWithSpaces1 = new Ap.CharactersWithSpaces();
            charactersWithSpaces1.Text = "2088";
            Ap.SharedDocument sharedDocument1 = new Ap.SharedDocument();
            sharedDocument1.Text = "false";
            Ap.HyperlinksChanged hyperlinksChanged1 = new Ap.HyperlinksChanged();
            hyperlinksChanged1.Text = "false";
            Ap.ApplicationVersion applicationVersion1 = new Ap.ApplicationVersion();
            applicationVersion1.Text = "15.0000";

            properties1.Append(template1);
            properties1.Append(totalTime1);
            properties1.Append(pages1);
            properties1.Append(words1);
            properties1.Append(characters1);
            properties1.Append(application1);
            properties1.Append(documentSecurity1);
            properties1.Append(lines1);
            properties1.Append(paragraphs1);
            properties1.Append(scaleCrop1);
            properties1.Append(headingPairs1);
            properties1.Append(titlesOfParts1);
            properties1.Append(company1);
            properties1.Append(linksUpToDate1);
            properties1.Append(charactersWithSpaces1);
            properties1.Append(sharedDocument1);
            properties1.Append(hyperlinksChanged1);
            properties1.Append(applicationVersion1);

            extendedFilePropertiesPart1.Properties = properties1;
        }

        // Generates content of mainDocumentPart1.
        private void GenerateMainDocumentPart1Content(MainDocumentPart mainDocumentPart1)
        {
            Document document1 = new Document() { MCAttributes = new MarkupCompatibilityAttributes() { Ignorable = "w14 w15 wp14" } };
            document1.AddNamespaceDeclaration("wpc", "http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas");
            document1.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            document1.AddNamespaceDeclaration("o", "urn:schemas-microsoft-com:office:office");
            document1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            document1.AddNamespaceDeclaration("m", "http://schemas.openxmlformats.org/officeDocument/2006/math");
            document1.AddNamespaceDeclaration("v", "urn:schemas-microsoft-com:vml");
            document1.AddNamespaceDeclaration("wp14", "http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing");
            document1.AddNamespaceDeclaration("wp", "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing");
            document1.AddNamespaceDeclaration("w10", "urn:schemas-microsoft-com:office:word");
            document1.AddNamespaceDeclaration("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
            document1.AddNamespaceDeclaration("w14", "http://schemas.microsoft.com/office/word/2010/wordml");
            document1.AddNamespaceDeclaration("w15", "http://schemas.microsoft.com/office/word/2012/wordml");
            document1.AddNamespaceDeclaration("wpg", "http://schemas.microsoft.com/office/word/2010/wordprocessingGroup");
            document1.AddNamespaceDeclaration("wpi", "http://schemas.microsoft.com/office/word/2010/wordprocessingInk");
            document1.AddNamespaceDeclaration("wne", "http://schemas.microsoft.com/office/word/2006/wordml");
            document1.AddNamespaceDeclaration("wps", "http://schemas.microsoft.com/office/word/2010/wordprocessingShape");

            Body body1 = new Body();

            Table table1 = new Table();

            TableProperties tableProperties1 = new TableProperties();
            TableWidth tableWidth1 = new TableWidth() { Width = "10491", Type = TableWidthUnitValues.Dxa };
            TableIndentation tableIndentation1 = new TableIndentation() { Width = -885, Type = TableWidthUnitValues.Dxa };
            TableLayout tableLayout1 = new TableLayout() { Type = TableLayoutValues.Fixed };
            TableLook tableLook1 = new TableLook() { Val = "0000" };

            tableProperties1.Append(tableWidth1);
            tableProperties1.Append(tableIndentation1);
            tableProperties1.Append(tableLayout1);
            tableProperties1.Append(tableLook1);

            TableGrid tableGrid1 = new TableGrid();
            GridColumn gridColumn1 = new GridColumn() { Width = "426" };
            GridColumn gridColumn2 = new GridColumn() { Width = "2373" };
            GridColumn gridColumn3 = new GridColumn() { Width = "2588" };
            GridColumn gridColumn4 = new GridColumn() { Width = "1843" };
            GridColumn gridColumn5 = new GridColumn() { Width = "851" };
            GridColumn gridColumn6 = new GridColumn() { Width = "992" };
            GridColumn gridColumn7 = new GridColumn() { Width = "1418" };

            tableGrid1.Append(gridColumn1);
            tableGrid1.Append(gridColumn2);
            tableGrid1.Append(gridColumn3);
            tableGrid1.Append(gridColumn4);
            tableGrid1.Append(gridColumn5);
            tableGrid1.Append(gridColumn6);
            tableGrid1.Append(gridColumn7);

            TableRow tableRow1 = new TableRow() { RsidTableRowMarkRevision = "00064902", RsidTableRowAddition = "00ED11CF", RsidTableRowProperties = "005630D3" };

            TableRowProperties tableRowProperties1 = new TableRowProperties();
            TableRowHeight tableRowHeight1 = new TableRowHeight() { Val = (UInt32Value)707U };

            tableRowProperties1.Append(tableRowHeight1);

            TableCell tableCell1 = new TableCell();

            TableCellProperties tableCellProperties1 = new TableCellProperties();
            TableCellWidth tableCellWidth1 = new TableCellWidth() { Width = "5387", Type = TableWidthUnitValues.Dxa };
            GridSpan gridSpan1 = new GridSpan() { Val = 3 };

            TableCellBorders tableCellBorders1 = new TableCellBorders();
            TopBorder topBorder1 = new TopBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            LeftBorder leftBorder1 = new LeftBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            RightBorder rightBorder1 = new RightBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };

            tableCellBorders1.Append(topBorder1);
            tableCellBorders1.Append(leftBorder1);
            tableCellBorders1.Append(rightBorder1);

            tableCellProperties1.Append(tableCellWidth1);
            tableCellProperties1.Append(gridSpan1);
            tableCellProperties1.Append(tableCellBorders1);

            Paragraph paragraph1 = new Paragraph() { RsidParagraphMarkRevision = "00064902", RsidParagraphAddition = "00DA4F1E", RsidParagraphProperties = "00DA4F1E", RsidRunAdditionDefault = "00DA4F1E" };

            ParagraphProperties paragraphProperties1 = new ParagraphProperties();
            ParagraphStyleId paragraphStyleId1 = new ParagraphStyleId() { Val = "5" };
            Indentation indentation1 = new Indentation() { Hanging = "142" };

            ParagraphMarkRunProperties paragraphMarkRunProperties1 = new ParagraphMarkRunProperties();
            FontSize fontSize1 = new FontSize() { Val = "20" };
            Underline underline1 = new Underline() { Val = UnderlineValues.Single };

            paragraphMarkRunProperties1.Append(fontSize1);
            paragraphMarkRunProperties1.Append(underline1);

            paragraphProperties1.Append(paragraphStyleId1);
            paragraphProperties1.Append(indentation1);
            paragraphProperties1.Append(paragraphMarkRunProperties1);

            Run run1 = new Run() { RsidRunProperties = "00064902" };

            RunProperties runProperties1 = new RunProperties();
            Bold bold1 = new Bold() { Val = false };
            FontSize fontSize2 = new FontSize() { Val = "20" };

            runProperties1.Append(bold1);
            runProperties1.Append(fontSize2);
            Text text1 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text1.Text = " ";

            run1.Append(runProperties1);
            run1.Append(text1);

            Run run2 = new Run() { RsidRunProperties = "00064902" };

            RunProperties runProperties2 = new RunProperties();
            FontSize fontSize3 = new FontSize() { Val = "20" };
            Underline underline2 = new Underline() { Val = UnderlineValues.Single };

            runProperties2.Append(fontSize3);
            runProperties2.Append(underline2);
            Text text2 = new Text();
            text2.Text = "Продавец:";

            run2.Append(runProperties2);
            run2.Append(text2);

            paragraph1.Append(paragraphProperties1);
            paragraph1.Append(run1);
            paragraph1.Append(run2);

            Paragraph paragraph2 = new Paragraph() { RsidParagraphMarkRevision = "00064902", RsidParagraphAddition = "009F4D51", RsidParagraphProperties = "00DA4F1E", RsidRunAdditionDefault = "00DA4F1E" };

            ParagraphProperties paragraphProperties2 = new ParagraphProperties();
            ParagraphStyleId paragraphStyleId2 = new ParagraphStyleId() { Val = "5" };
            Indentation indentation2 = new Indentation() { Hanging = "142" };

            ParagraphMarkRunProperties paragraphMarkRunProperties2 = new ParagraphMarkRunProperties();
            FontSize fontSize4 = new FontSize() { Val = "20" };

            paragraphMarkRunProperties2.Append(fontSize4);

            paragraphProperties2.Append(paragraphStyleId2);
            paragraphProperties2.Append(indentation2);
            paragraphProperties2.Append(paragraphMarkRunProperties2);

            Run run3 = new Run() { RsidRunProperties = "00064902" };

            RunProperties runProperties3 = new RunProperties();
            FontSize fontSize5 = new FontSize() { Val = "20" };

            runProperties3.Append(fontSize5);
            Text text3 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text3.Text = " ";

            run3.Append(runProperties3);
            run3.Append(text3);

            Run run4 = new Run() { RsidRunProperties = "00064902", RsidRunAddition = "009F4D51" };

            RunProperties runProperties4 = new RunProperties();
            FontSize fontSize6 = new FontSize() { Val = "20" };

            runProperties4.Append(fontSize6);
            Text text4 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text4.Text = "ООО \" ";

            run4.Append(runProperties4);
            run4.Append(text4);
            ProofError proofError1 = new ProofError() { Type = ProofingErrorValues.SpellStart };

            Run run5 = new Run() { RsidRunProperties = "00064902", RsidRunAddition = "009F4D51" };

            RunProperties runProperties5 = new RunProperties();
            FontSize fontSize7 = new FontSize() { Val = "20" };

            runProperties5.Append(fontSize7);
            Text text5 = new Text();
            text5.Text = "Разек";

            run5.Append(runProperties5);
            run5.Append(text5);
            ProofError proofError2 = new ProofError() { Type = ProofingErrorValues.SpellEnd };

            Run run6 = new Run() { RsidRunProperties = "00064902", RsidRunAddition = "009F4D51" };

            RunProperties runProperties6 = new RunProperties();
            FontSize fontSize8 = new FontSize() { Val = "20" };

            runProperties6.Append(fontSize8);
            Text text6 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text6.Text = " Черкассы\"";

            run6.Append(runProperties6);
            run6.Append(text6);

            Run run7 = new Run() { RsidRunProperties = "00064902", RsidRunAddition = "002934E7" };
            Text text7 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text7.Text = " ";

            run7.Append(text7);

            paragraph2.Append(paragraphProperties2);
            paragraph2.Append(run3);
            paragraph2.Append(run4);
            paragraph2.Append(proofError1);
            paragraph2.Append(run5);
            paragraph2.Append(proofError2);
            paragraph2.Append(run6);
            paragraph2.Append(run7);

            Paragraph paragraph3 = new Paragraph() { RsidParagraphMarkRevision = "00064902", RsidParagraphAddition = "009F4D51", RsidParagraphProperties = "009F4D51", RsidRunAdditionDefault = "009F4D51" };

            ParagraphProperties paragraphProperties3 = new ParagraphProperties();
            ParagraphStyleId paragraphStyleId3 = new ParagraphStyleId() { Val = "5" };
            Indentation indentation3 = new Indentation() { Hanging = "142" };

            ParagraphMarkRunProperties paragraphMarkRunProperties3 = new ParagraphMarkRunProperties();
            Bold bold2 = new Bold() { Val = false };
            FontSize fontSize9 = new FontSize() { Val = "20" };

            paragraphMarkRunProperties3.Append(bold2);
            paragraphMarkRunProperties3.Append(fontSize9);

            paragraphProperties3.Append(paragraphStyleId3);
            paragraphProperties3.Append(indentation3);
            paragraphProperties3.Append(paragraphMarkRunProperties3);

            Run run8 = new Run() { RsidRunProperties = "00064902" };

            RunProperties runProperties7 = new RunProperties();
            FontSize fontSize10 = new FontSize() { Val = "20" };

            runProperties7.Append(fontSize10);
            Text text8 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text8.Text = " ";

            run8.Append(runProperties7);
            run8.Append(text8);

            Run run9 = new Run() { RsidRunProperties = "00064902" };

            RunProperties runProperties8 = new RunProperties();
            Bold bold3 = new Bold() { Val = false };
            FontSize fontSize11 = new FontSize() { Val = "20" };

            runProperties8.Append(bold3);
            runProperties8.Append(fontSize11);
            Text text9 = new Text();
            text9.Text = "18018, Украина, г. Черкассы";

            run9.Append(runProperties8);
            run9.Append(text9);

            paragraph3.Append(paragraphProperties3);
            paragraph3.Append(run8);
            paragraph3.Append(run9);

            Paragraph paragraph4 = new Paragraph() { RsidParagraphMarkRevision = "00064902", RsidParagraphAddition = "00B34BD0", RsidParagraphProperties = "009F4D51", RsidRunAdditionDefault = "009F4D51" };

            ParagraphProperties paragraphProperties4 = new ParagraphProperties();
            ParagraphStyleId paragraphStyleId4 = new ParagraphStyleId() { Val = "5" };
            Indentation indentation4 = new Indentation() { Hanging = "142" };

            ParagraphMarkRunProperties paragraphMarkRunProperties4 = new ParagraphMarkRunProperties();
            Bold bold4 = new Bold() { Val = false };
            FontSize fontSize12 = new FontSize() { Val = "20" };

            paragraphMarkRunProperties4.Append(bold4);
            paragraphMarkRunProperties4.Append(fontSize12);

            paragraphProperties4.Append(paragraphStyleId4);
            paragraphProperties4.Append(indentation4);
            paragraphProperties4.Append(paragraphMarkRunProperties4);

            Run run10 = new Run() { RsidRunProperties = "00064902" };

            RunProperties runProperties9 = new RunProperties();
            Bold bold5 = new Bold() { Val = false };
            FontSize fontSize13 = new FontSize() { Val = "20" };

            runProperties9.Append(bold5);
            runProperties9.Append(fontSize13);
            Text text10 = new Text();
            text10.Text = "просп. Химиков, 74";

            run10.Append(runProperties9);
            run10.Append(text10);

            paragraph4.Append(paragraphProperties4);
            paragraph4.Append(run10);

            tableCell1.Append(tableCellProperties1);
            tableCell1.Append(paragraph1);
            tableCell1.Append(paragraph2);
            tableCell1.Append(paragraph3);
            tableCell1.Append(paragraph4);

            TableCell tableCell2 = new TableCell();

            TableCellProperties tableCellProperties2 = new TableCellProperties();
            TableCellWidth tableCellWidth2 = new TableCellWidth() { Width = "5104", Type = TableWidthUnitValues.Dxa };
            GridSpan gridSpan2 = new GridSpan() { Val = 4 };

            TableCellBorders tableCellBorders2 = new TableCellBorders();
            TopBorder topBorder2 = new TopBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            LeftBorder leftBorder2 = new LeftBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            RightBorder rightBorder2 = new RightBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };

            tableCellBorders2.Append(topBorder2);
            tableCellBorders2.Append(leftBorder2);
            tableCellBorders2.Append(rightBorder2);

            tableCellProperties2.Append(tableCellWidth2);
            tableCellProperties2.Append(gridSpan2);
            tableCellProperties2.Append(tableCellBorders2);

            Paragraph paragraph5 = new Paragraph() { RsidParagraphMarkRevision = "00064902", RsidParagraphAddition = "00ED11CF", RsidRunAdditionDefault = "00ED11CF" };

            ParagraphProperties paragraphProperties5 = new ParagraphProperties();
            ParagraphStyleId paragraphStyleId5 = new ParagraphStyleId() { Val = "7" };

            ParagraphMarkRunProperties paragraphMarkRunProperties5 = new ParagraphMarkRunProperties();
            FontSize fontSize14 = new FontSize() { Val = "20" };
            Underline underline3 = new Underline() { Val = UnderlineValues.Single };

            paragraphMarkRunProperties5.Append(fontSize14);
            paragraphMarkRunProperties5.Append(underline3);

            paragraphProperties5.Append(paragraphStyleId5);
            paragraphProperties5.Append(paragraphMarkRunProperties5);

            Run run11 = new Run() { RsidRunProperties = "00064902" };

            RunProperties runProperties10 = new RunProperties();
            FontSize fontSize15 = new FontSize() { Val = "20" };
            Underline underline4 = new Underline() { Val = UnderlineValues.Single };

            runProperties10.Append(fontSize15);
            runProperties10.Append(underline4);
            Text text11 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text11.Text = "Покупатель:  ";

            run11.Append(runProperties10);
            run11.Append(text11);

            paragraph5.Append(paragraphProperties5);
            paragraph5.Append(run11);

            Paragraph paragraph6 = new Paragraph() { RsidParagraphMarkRevision = "00EE352A", RsidParagraphAddition = "009F4D51", RsidParagraphProperties = "006171C3", RsidRunAdditionDefault = "009F4D51" };

            ParagraphProperties paragraphProperties6 = new ParagraphProperties();
            ParagraphStyleId paragraphStyleId6 = new ParagraphStyleId() { Val = "a3" };
            Indentation indentation5 = new Indentation() { FirstLine = "0" };
            Justification justification1 = new Justification() { Val = JustificationValues.Left };

            ParagraphMarkRunProperties paragraphMarkRunProperties6 = new ParagraphMarkRunProperties();
            RunFonts runFonts1 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Bold bold6 = new Bold();
            FontSize fontSize16 = new FontSize() { Val = "20" };
            Languages languages1 = new Languages() { Val = "ru-RU", EastAsia = "ru-RU" };

            paragraphMarkRunProperties6.Append(runFonts1);
            paragraphMarkRunProperties6.Append(bold6);
            paragraphMarkRunProperties6.Append(fontSize16);
            paragraphMarkRunProperties6.Append(languages1);

            paragraphProperties6.Append(paragraphStyleId6);
            paragraphProperties6.Append(indentation5);
            paragraphProperties6.Append(justification1);
            paragraphProperties6.Append(paragraphMarkRunProperties6);

            Run run12 = new Run() { RsidRunProperties = "00EE352A" };

            RunProperties runProperties11 = new RunProperties();
            RunFonts runFonts2 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Bold bold7 = new Bold();
            FontSize fontSize17 = new FontSize() { Val = "20" };
            Languages languages2 = new Languages() { Val = "ru-RU", EastAsia = "ru-RU" };

            runProperties11.Append(runFonts2);
            runProperties11.Append(bold7);
            runProperties11.Append(fontSize17);
            runProperties11.Append(languages2);
            Text text12 = new Text();
            text12.Text = "ООО \"";

            run12.Append(runProperties11);
            run12.Append(text12);
            ProofError proofError3 = new ProofError() { Type = ProofingErrorValues.SpellStart };

            Run run13 = new Run() { RsidRunProperties = "00EE352A" };

            RunProperties runProperties12 = new RunProperties();
            RunFonts runFonts3 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Bold bold8 = new Bold();
            FontSize fontSize18 = new FontSize() { Val = "20" };
            Languages languages3 = new Languages() { Val = "ru-RU", EastAsia = "ru-RU" };

            runProperties12.Append(runFonts3);
            runProperties12.Append(bold8);
            runProperties12.Append(fontSize18);
            runProperties12.Append(languages3);
            Text text13 = new Text();
            text13.Text = "Разек";

            run13.Append(runProperties12);
            run13.Append(text13);
            ProofError proofError4 = new ProofError() { Type = ProofingErrorValues.SpellEnd };

            Run run14 = new Run() { RsidRunProperties = "00EE352A" };

            RunProperties runProperties13 = new RunProperties();
            RunFonts runFonts4 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Bold bold9 = new Bold();
            FontSize fontSize19 = new FontSize() { Val = "20" };
            Languages languages4 = new Languages() { Val = "ru-RU", EastAsia = "ru-RU" };

            runProperties13.Append(runFonts4);
            runProperties13.Append(bold9);
            runProperties13.Append(fontSize19);
            runProperties13.Append(languages4);
            Text text14 = new Text();
            text14.Text = "-Восток\"";

            run14.Append(runProperties13);
            run14.Append(text14);

            paragraph6.Append(paragraphProperties6);
            paragraph6.Append(run12);
            paragraph6.Append(proofError3);
            paragraph6.Append(run13);
            paragraph6.Append(proofError4);
            paragraph6.Append(run14);

            Paragraph paragraph7 = new Paragraph() { RsidParagraphMarkRevision = "00EE352A", RsidParagraphAddition = "009F4D51", RsidParagraphProperties = "00F2317D", RsidRunAdditionDefault = "009F4D51" };

            ParagraphProperties paragraphProperties7 = new ParagraphProperties();
            ParagraphStyleId paragraphStyleId7 = new ParagraphStyleId() { Val = "a3" };

            Tabs tabs1 = new Tabs();
            TabStop tabStop1 = new TabStop() { Val = TabStopValues.Left, Position = 4945 };

            tabs1.Append(tabStop1);
            Indentation indentation6 = new Indentation() { FirstLine = "0" };
            Justification justification2 = new Justification() { Val = JustificationValues.Left };

            ParagraphMarkRunProperties paragraphMarkRunProperties7 = new ParagraphMarkRunProperties();
            RunFonts runFonts5 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize20 = new FontSize() { Val = "20" };
            Languages languages5 = new Languages() { Val = "ru-RU", EastAsia = "ru-RU" };

            paragraphMarkRunProperties7.Append(runFonts5);
            paragraphMarkRunProperties7.Append(fontSize20);
            paragraphMarkRunProperties7.Append(languages5);

            paragraphProperties7.Append(paragraphStyleId7);
            paragraphProperties7.Append(tabs1);
            paragraphProperties7.Append(indentation6);
            paragraphProperties7.Append(justification2);
            paragraphProperties7.Append(paragraphMarkRunProperties7);

            Run run15 = new Run() { RsidRunProperties = "00EE352A" };

            RunProperties runProperties14 = new RunProperties();
            RunFonts runFonts6 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize21 = new FontSize() { Val = "20" };
            Languages languages6 = new Languages() { Val = "ru-RU", EastAsia = "ru-RU" };

            runProperties14.Append(runFonts6);
            runProperties14.Append(fontSize21);
            runProperties14.Append(languages6);
            Text text15 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text15.Text = "Россия, г. Москва ";

            run15.Append(runProperties14);
            run15.Append(text15);

            Run run16 = new Run() { RsidRunProperties = "00EE352A", RsidRunAddition = "00F2317D" };

            RunProperties runProperties15 = new RunProperties();
            RunFonts runFonts7 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize22 = new FontSize() { Val = "20" };
            Languages languages7 = new Languages() { Val = "ru-RU", EastAsia = "ru-RU" };

            runProperties15.Append(runFonts7);
            runProperties15.Append(fontSize22);
            runProperties15.Append(languages7);
            TabChar tabChar1 = new TabChar();

            run16.Append(runProperties15);
            run16.Append(tabChar1);

            paragraph7.Append(paragraphProperties7);
            paragraph7.Append(run15);
            paragraph7.Append(run16);

            Paragraph paragraph8 = new Paragraph() { RsidParagraphMarkRevision = "00EE352A", RsidParagraphAddition = "00ED11CF", RsidParagraphProperties = "006171C3", RsidRunAdditionDefault = "009F4D51" };

            ParagraphProperties paragraphProperties8 = new ParagraphProperties();
            ParagraphStyleId paragraphStyleId8 = new ParagraphStyleId() { Val = "a3" };
            Indentation indentation7 = new Indentation() { FirstLine = "0" };
            Justification justification3 = new Justification() { Val = JustificationValues.Left };

            ParagraphMarkRunProperties paragraphMarkRunProperties8 = new ParagraphMarkRunProperties();
            RunFonts runFonts8 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize23 = new FontSize() { Val = "20" };
            Languages languages8 = new Languages() { Val = "ru-RU", EastAsia = "ru-RU" };

            paragraphMarkRunProperties8.Append(runFonts8);
            paragraphMarkRunProperties8.Append(fontSize23);
            paragraphMarkRunProperties8.Append(languages8);

            paragraphProperties8.Append(paragraphStyleId8);
            paragraphProperties8.Append(indentation7);
            paragraphProperties8.Append(justification3);
            paragraphProperties8.Append(paragraphMarkRunProperties8);
            ProofError proofError5 = new ProofError() { Type = ProofingErrorValues.SpellStart };

            Run run17 = new Run() { RsidRunProperties = "00EE352A" };

            RunProperties runProperties16 = new RunProperties();
            RunFonts runFonts9 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize24 = new FontSize() { Val = "20" };
            Languages languages9 = new Languages() { Val = "ru-RU", EastAsia = "ru-RU" };

            runProperties16.Append(runFonts9);
            runProperties16.Append(fontSize24);
            runProperties16.Append(languages9);
            Text text16 = new Text();
            text16.Text = "Балакиревский";

            run17.Append(runProperties16);
            run17.Append(text16);
            ProofError proofError6 = new ProofError() { Type = ProofingErrorValues.SpellEnd };

            Run run18 = new Run() { RsidRunProperties = "00EE352A" };

            RunProperties runProperties17 = new RunProperties();
            RunFonts runFonts10 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize25 = new FontSize() { Val = "20" };
            Languages languages10 = new Languages() { Val = "ru-RU", EastAsia = "ru-RU" };

            runProperties17.Append(runFonts10);
            runProperties17.Append(fontSize25);
            runProperties17.Append(languages10);
            Text text17 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text17.Text = " ";

            run18.Append(runProperties17);
            run18.Append(text17);
            ProofError proofError7 = new ProofError() { Type = ProofingErrorValues.GrammarStart };

            Run run19 = new Run() { RsidRunProperties = "00EE352A" };

            RunProperties runProperties18 = new RunProperties();
            RunFonts runFonts11 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize26 = new FontSize() { Val = "20" };
            Languages languages11 = new Languages() { Val = "ru-RU", EastAsia = "ru-RU" };

            runProperties18.Append(runFonts11);
            runProperties18.Append(fontSize26);
            runProperties18.Append(languages11);
            Text text18 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text18.Text = "пер. ";

            run19.Append(runProperties18);
            run19.Append(text18);

            Run run20 = new Run() { RsidRunProperties = "00EE352A", RsidRunAddition = "0066404F" };

            RunProperties runProperties19 = new RunProperties();
            RunFonts runFonts12 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize27 = new FontSize() { Val = "20" };
            Languages languages12 = new Languages() { Val = "ru-RU", EastAsia = "ru-RU" };

            runProperties19.Append(runFonts12);
            runProperties19.Append(fontSize27);
            runProperties19.Append(languages12);
            Text text19 = new Text();
            text19.Text = ",";

            run20.Append(runProperties19);
            run20.Append(text19);
            ProofError proofError8 = new ProofError() { Type = ProofingErrorValues.GrammarEnd };

            Run run21 = new Run() { RsidRunProperties = "00EE352A", RsidRunAddition = "0066404F" };

            RunProperties runProperties20 = new RunProperties();
            RunFonts runFonts13 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize28 = new FontSize() { Val = "20" };
            Languages languages13 = new Languages() { Val = "ru-RU", EastAsia = "ru-RU" };

            runProperties20.Append(runFonts13);
            runProperties20.Append(fontSize28);
            runProperties20.Append(languages13);
            Text text20 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text20.Text = " ";

            run21.Append(runProperties20);
            run21.Append(text20);

            Run run22 = new Run() { RsidRunProperties = "00EE352A" };

            RunProperties runProperties21 = new RunProperties();
            RunFonts runFonts14 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize29 = new FontSize() { Val = "20" };
            Languages languages14 = new Languages() { Val = "ru-RU", EastAsia = "ru-RU" };

            runProperties21.Append(runFonts14);
            runProperties21.Append(fontSize29);
            runProperties21.Append(languages14);
            Text text21 = new Text();
            text21.Text = "д.1 А, оф. 4";

            run22.Append(runProperties21);
            run22.Append(text21);

            paragraph8.Append(paragraphProperties8);
            paragraph8.Append(proofError5);
            paragraph8.Append(run17);
            paragraph8.Append(proofError6);
            paragraph8.Append(run18);
            paragraph8.Append(proofError7);
            paragraph8.Append(run19);
            paragraph8.Append(run20);
            paragraph8.Append(proofError8);
            paragraph8.Append(run21);
            paragraph8.Append(run22);

            tableCell2.Append(tableCellProperties2);
            tableCell2.Append(paragraph5);
            tableCell2.Append(paragraph6);
            tableCell2.Append(paragraph7);
            tableCell2.Append(paragraph8);

            tableRow1.Append(tableRowProperties1);
            tableRow1.Append(tableCell1);
            tableRow1.Append(tableCell2);

            TableRow tableRow2 = new TableRow() { RsidTableRowMarkRevision = "00793308", RsidTableRowAddition = "00ED11CF", RsidTableRowProperties = "005630D3" };

            TableRowProperties tableRowProperties2 = new TableRowProperties();
            TableRowHeight tableRowHeight2 = new TableRowHeight() { Val = (UInt32Value)375U };

            tableRowProperties2.Append(tableRowHeight2);

            TableCell tableCell3 = new TableCell();

            TableCellProperties tableCellProperties3 = new TableCellProperties();
            TableCellWidth tableCellWidth3 = new TableCellWidth() { Width = "5387", Type = TableWidthUnitValues.Dxa };
            GridSpan gridSpan3 = new GridSpan() { Val = 3 };

            TableCellBorders tableCellBorders3 = new TableCellBorders();
            TopBorder topBorder3 = new TopBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            LeftBorder leftBorder3 = new LeftBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder1 = new BottomBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            RightBorder rightBorder3 = new RightBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };

            tableCellBorders3.Append(topBorder3);
            tableCellBorders3.Append(leftBorder3);
            tableCellBorders3.Append(bottomBorder1);
            tableCellBorders3.Append(rightBorder3);
            TableCellVerticalAlignment tableCellVerticalAlignment1 = new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center };

            tableCellProperties3.Append(tableCellWidth3);
            tableCellProperties3.Append(gridSpan3);
            tableCellProperties3.Append(tableCellBorders3);
            tableCellProperties3.Append(tableCellVerticalAlignment1);

            Paragraph paragraph9 = new Paragraph() { RsidParagraphMarkRevision = "009A289B", RsidParagraphAddition = "001A7106", RsidParagraphProperties = "001A7106", RsidRunAdditionDefault = "00D95925" };

            ParagraphProperties paragraphProperties9 = new ParagraphProperties();

            ParagraphMarkRunProperties paragraphMarkRunProperties9 = new ParagraphMarkRunProperties();
            Bold bold10 = new Bold();
            FontSize fontSize30 = new FontSize() { Val = "24" };
            FontSizeComplexScript fontSizeComplexScript1 = new FontSizeComplexScript() { Val = "24" };
            Underline underline5 = new Underline() { Val = UnderlineValues.Single };

            paragraphMarkRunProperties9.Append(bold10);
            paragraphMarkRunProperties9.Append(fontSize30);
            paragraphMarkRunProperties9.Append(fontSizeComplexScript1);
            paragraphMarkRunProperties9.Append(underline5);

            paragraphProperties9.Append(paragraphMarkRunProperties9);
            ProofError proofError9 = new ProofError() { Type = ProofingErrorValues.SpellStart };

            Run run23 = new Run() { RsidRunProperties = "00064902" };

            RunProperties runProperties22 = new RunProperties();
            Bold bold11 = new Bold();
            FontSize fontSize31 = new FontSize() { Val = "24" };
            FontSizeComplexScript fontSizeComplexScript2 = new FontSizeComplexScript() { Val = "24" };
            Underline underline6 = new Underline() { Val = UnderlineValues.Single };

            runProperties22.Append(bold11);
            runProperties22.Append(fontSize31);
            runProperties22.Append(fontSizeComplexScript2);
            runProperties22.Append(underline6);
            Text text22 = new Text();
            text22.Text = "Cчёт";

            run23.Append(runProperties22);
            run23.Append(text22);
            ProofError proofError10 = new ProofError() { Type = ProofingErrorValues.SpellEnd };

            Run run24 = new Run() { RsidRunAddition = "005840CA" };

            RunProperties runProperties23 = new RunProperties();
            Bold bold12 = new Bold();
            FontSize fontSize32 = new FontSize() { Val = "24" };
            FontSizeComplexScript fontSizeComplexScript3 = new FontSizeComplexScript() { Val = "24" };
            Underline underline7 = new Underline() { Val = UnderlineValues.Single };

            runProperties23.Append(bold12);
            runProperties23.Append(fontSize32);
            runProperties23.Append(fontSizeComplexScript3);
            runProperties23.Append(underline7);
            Text text23 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text23.Text = " ";

            run24.Append(runProperties23);
            run24.Append(text23);

            Run run25 = new Run() { RsidRunProperties = "00064902" };

            RunProperties runProperties24 = new RunProperties();
            Bold bold13 = new Bold();
            FontSize fontSize33 = new FontSize() { Val = "24" };
            FontSizeComplexScript fontSizeComplexScript4 = new FontSizeComplexScript() { Val = "24" };
            Underline underline8 = new Underline() { Val = UnderlineValues.Single };

            runProperties24.Append(bold13);
            runProperties24.Append(fontSize33);
            runProperties24.Append(fontSizeComplexScript4);
            runProperties24.Append(underline8);
            Text text24 = new Text();
            text24.Text = "-";

            run25.Append(runProperties24);
            run25.Append(text24);

            Run run26 = new Run() { RsidRunAddition = "005840CA" };

            RunProperties runProperties25 = new RunProperties();
            Bold bold14 = new Bold();
            FontSize fontSize34 = new FontSize() { Val = "24" };
            FontSizeComplexScript fontSizeComplexScript5 = new FontSizeComplexScript() { Val = "24" };
            Underline underline9 = new Underline() { Val = UnderlineValues.Single };

            runProperties25.Append(bold14);
            runProperties25.Append(fontSize34);
            runProperties25.Append(fontSizeComplexScript5);
            runProperties25.Append(underline9);
            Text text25 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text25.Text = " ";

            run26.Append(runProperties25);
            run26.Append(text25);

            Run run27 = new Run() { RsidRunProperties = "00064902" };

            RunProperties runProperties26 = new RunProperties();
            Bold bold15 = new Bold();
            FontSize fontSize35 = new FontSize() { Val = "24" };
            FontSizeComplexScript fontSizeComplexScript6 = new FontSizeComplexScript() { Val = "24" };
            Underline underline10 = new Underline() { Val = UnderlineValues.Single };

            runProperties26.Append(bold15);
            runProperties26.Append(fontSize35);
            runProperties26.Append(fontSizeComplexScript6);
            runProperties26.Append(underline10);
            Text text26 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text26.Text = "фактура ";

            run27.Append(runProperties26);
            run27.Append(text26);

            Run run28 = new Run() { RsidRunProperties = "00516F28", RsidRunAddition = "00826D68" };

            RunProperties runProperties27 = new RunProperties();
            Bold bold16 = new Bold();
            FontSize fontSize36 = new FontSize() { Val = "24" };
            FontSizeComplexScript fontSizeComplexScript7 = new FontSizeComplexScript() { Val = "24" };
            Underline underline11 = new Underline() { Val = UnderlineValues.Single };

            runProperties27.Append(bold16);
            runProperties27.Append(fontSize36);
            runProperties27.Append(fontSizeComplexScript7);
            runProperties27.Append(underline11);
            Text text27 = new Text();
            text27.Text = "№";

            run28.Append(runProperties27);
            run28.Append(text27);

            Run run29 = new Run() { RsidRunAddition = "00263272" };

            RunProperties runProperties28 = new RunProperties();
            Bold bold17 = new Bold();
            FontSize fontSize37 = new FontSize() { Val = "24" };
            FontSizeComplexScript fontSizeComplexScript8 = new FontSizeComplexScript() { Val = "24" };
            Underline underline12 = new Underline() { Val = UnderlineValues.Single };

            runProperties28.Append(bold17);
            runProperties28.Append(fontSize37);
            runProperties28.Append(fontSizeComplexScript8);
            runProperties28.Append(underline12);
            Text text28 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text28.Text = " ";

            run29.Append(runProperties28);
            run29.Append(text28);

            Run run30 = new Run() { RsidRunAddition = "00905DAC" };

            RunProperties runProperties29 = new RunProperties();
            Bold bold18 = new Bold();
            FontSize fontSize38 = new FontSize() { Val = "24" };
            FontSizeComplexScript fontSizeComplexScript9 = new FontSizeComplexScript() { Val = "24" };
            Underline underline13 = new Underline() { Val = UnderlineValues.Single };
            Languages languages15 = new Languages() { Val = "en-US" };

            runProperties29.Append(bold18);
            runProperties29.Append(fontSize38);
            runProperties29.Append(fontSizeComplexScript9);
            runProperties29.Append(underline13);
            runProperties29.Append(languages15);
            Text text29 = new Text();
            text29.Text = frm.invoiceNumber.Text;

            run30.Append(runProperties29);
            run30.Append(text29);

            Run run31 = new Run() { RsidRunAddition = "00655293" };

            RunProperties runProperties30 = new RunProperties();
            Bold bold19 = new Bold();
            FontSize fontSize39 = new FontSize() { Val = "24" };
            FontSizeComplexScript fontSizeComplexScript10 = new FontSizeComplexScript() { Val = "24" };
            Underline underline14 = new Underline() { Val = UnderlineValues.Single };

            runProperties30.Append(bold19);
            runProperties30.Append(fontSize39);
            runProperties30.Append(fontSizeComplexScript10);
            runProperties30.Append(underline14);
            Text text30 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text30.Text = " ";

            run31.Append(runProperties30);
            run31.Append(text30);

            Run run32 = new Run() { RsidRunProperties = "00655293", RsidRunAddition = "00826D68" };

            RunProperties runProperties31 = new RunProperties();
            Bold bold20 = new Bold();
            FontSize fontSize40 = new FontSize() { Val = "24" };
            FontSizeComplexScript fontSizeComplexScript11 = new FontSizeComplexScript() { Val = "24" };
            Underline underline15 = new Underline() { Val = UnderlineValues.Single };

            runProperties31.Append(bold20);
            runProperties31.Append(fontSize40);
            runProperties31.Append(fontSizeComplexScript11);
            runProperties31.Append(underline15);
            Text text31 = new Text();
            text31.Text = "от";

            run32.Append(runProperties31);
            run32.Append(text31);

            Run run33 = new Run() { RsidRunProperties = "00655293", RsidRunAddition = "002934E7" };

            RunProperties runProperties32 = new RunProperties();
            Bold bold21 = new Bold();
            FontSize fontSize41 = new FontSize() { Val = "24" };
            FontSizeComplexScript fontSizeComplexScript12 = new FontSizeComplexScript() { Val = "24" };
            Underline underline16 = new Underline() { Val = UnderlineValues.Single };

            runProperties32.Append(bold21);
            runProperties32.Append(fontSize41);
            runProperties32.Append(fontSizeComplexScript12);
            runProperties32.Append(underline16);
            Text text32 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text32.Text = " ";

            run33.Append(runProperties32);
            run33.Append(text32);
            ProofError proofError11 = new ProofError() { Type = ProofingErrorValues.SpellStart };

            Run run34 = new Run() { RsidRunAddition = "00905DAC" };

            RunProperties runProperties33 = new RunProperties();
            Bold bold22 = new Bold();
            FontSize fontSize42 = new FontSize() { Val = "24" };
            FontSizeComplexScript fontSizeComplexScript13 = new FontSizeComplexScript() { Val = "24" };
            Underline underline17 = new Underline() { Val = UnderlineValues.Single };
            Languages languages16 = new Languages() { Val = "en-US" };

            runProperties33.Append(bold22);
            runProperties33.Append(fontSize42);
            runProperties33.Append(fontSizeComplexScript13);
            runProperties33.Append(underline17);
            runProperties33.Append(languages16);
            Text text33 = new Text();
            text33.Text = frm.invoiceDate.Value.ToShortDateString();

            run34.Append(runProperties33);
            run34.Append(text33);
            ProofError proofError12 = new ProofError() { Type = ProofingErrorValues.SpellEnd };

            Run run35 = new Run() { RsidRunProperties = "00187144", RsidRunAddition = "00826D68" };

            RunProperties runProperties34 = new RunProperties();
            Bold bold23 = new Bold();
            FontSize fontSize43 = new FontSize() { Val = "24" };
            FontSizeComplexScript fontSizeComplexScript14 = new FontSizeComplexScript() { Val = "24" };
            Underline underline18 = new Underline() { Val = UnderlineValues.Single };

            runProperties34.Append(bold23);
            runProperties34.Append(fontSize43);
            runProperties34.Append(fontSizeComplexScript14);
            runProperties34.Append(underline18);
            Text text34 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text34.Text = " г";

            run35.Append(runProperties34);
            run35.Append(text34);

            Run run36 = new Run() { RsidRunProperties = "00187144", RsidRunAddition = "006A3FD4" };

            RunProperties runProperties35 = new RunProperties();
            Bold bold24 = new Bold();
            FontSize fontSize44 = new FontSize() { Val = "24" };
            FontSizeComplexScript fontSizeComplexScript15 = new FontSizeComplexScript() { Val = "24" };
            Underline underline19 = new Underline() { Val = UnderlineValues.Single };

            runProperties35.Append(bold24);
            runProperties35.Append(fontSize44);
            runProperties35.Append(fontSizeComplexScript15);
            runProperties35.Append(underline19);
            Text text35 = new Text();
            text35.Text = ".";

            run36.Append(runProperties35);
            run36.Append(text35);

            paragraph9.Append(paragraphProperties9);
            paragraph9.Append(proofError9);
            paragraph9.Append(run23);
            paragraph9.Append(proofError10);
            paragraph9.Append(run24);
            paragraph9.Append(run25);
            paragraph9.Append(run26);
            paragraph9.Append(run27);
            paragraph9.Append(run28);
            paragraph9.Append(run29);
            paragraph9.Append(run30);
            paragraph9.Append(run31);
            paragraph9.Append(run32);
            paragraph9.Append(run33);
            paragraph9.Append(proofError11);
            paragraph9.Append(run34);
            paragraph9.Append(proofError12);
            paragraph9.Append(run35);
            paragraph9.Append(run36);

            Paragraph paragraph10 = new Paragraph() { RsidParagraphMarkRevision = "009A289B", RsidParagraphAddition = "004B7F3A", RsidParagraphProperties = "00655293", RsidRunAdditionDefault = "004B7F3A" };

            ParagraphProperties paragraphProperties10 = new ParagraphProperties();

            ParagraphMarkRunProperties paragraphMarkRunProperties10 = new ParagraphMarkRunProperties();
            Bold bold25 = new Bold();
            FontSize fontSize45 = new FontSize() { Val = "24" };
            FontSizeComplexScript fontSizeComplexScript16 = new FontSizeComplexScript() { Val = "24" };
            Underline underline20 = new Underline() { Val = UnderlineValues.Single };

            paragraphMarkRunProperties10.Append(bold25);
            paragraphMarkRunProperties10.Append(fontSize45);
            paragraphMarkRunProperties10.Append(fontSizeComplexScript16);
            paragraphMarkRunProperties10.Append(underline20);

            paragraphProperties10.Append(paragraphMarkRunProperties10);

            paragraph10.Append(paragraphProperties10);

            tableCell3.Append(tableCellProperties3);
            tableCell3.Append(paragraph9);
            tableCell3.Append(paragraph10);

            TableCell tableCell4 = new TableCell();

            TableCellProperties tableCellProperties4 = new TableCellProperties();
            TableCellWidth tableCellWidth4 = new TableCellWidth() { Width = "5104", Type = TableWidthUnitValues.Dxa };
            GridSpan gridSpan4 = new GridSpan() { Val = 4 };

            TableCellBorders tableCellBorders4 = new TableCellBorders();
            TopBorder topBorder4 = new TopBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            LeftBorder leftBorder4 = new LeftBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder2 = new BottomBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            RightBorder rightBorder4 = new RightBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };

            tableCellBorders4.Append(topBorder4);
            tableCellBorders4.Append(leftBorder4);
            tableCellBorders4.Append(bottomBorder2);
            tableCellBorders4.Append(rightBorder4);
            TableCellVerticalAlignment tableCellVerticalAlignment2 = new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center };

            tableCellProperties4.Append(tableCellWidth4);
            tableCellProperties4.Append(gridSpan4);
            tableCellProperties4.Append(tableCellBorders4);
            tableCellProperties4.Append(tableCellVerticalAlignment2);

            Paragraph paragraph11 = new Paragraph() { RsidParagraphMarkRevision = "00064902", RsidParagraphAddition = "00ED11CF", RsidParagraphProperties = "00A848C0", RsidRunAdditionDefault = "00ED11CF" };

            ParagraphProperties paragraphProperties11 = new ParagraphProperties();

            ParagraphMarkRunProperties paragraphMarkRunProperties11 = new ParagraphMarkRunProperties();
            Bold bold26 = new Bold();
            FontSize fontSize46 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript17 = new FontSizeComplexScript() { Val = "18" };

            paragraphMarkRunProperties11.Append(bold26);
            paragraphMarkRunProperties11.Append(fontSize46);
            paragraphMarkRunProperties11.Append(fontSizeComplexScript17);

            paragraphProperties11.Append(paragraphMarkRunProperties11);

            Run run37 = new Run() { RsidRunProperties = "00064902" };

            RunProperties runProperties36 = new RunProperties();
            Bold bold27 = new Bold();
            FontSize fontSize47 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript18 = new FontSizeComplexScript() { Val = "18" };

            runProperties36.Append(bold27);
            runProperties36.Append(fontSize47);
            runProperties36.Append(fontSizeComplexScript18);
            Text text36 = new Text();
            text36.Text = "Договор";

            run37.Append(runProperties36);
            run37.Append(text36);

            Run run38 = new Run() { RsidRunProperties = "00064902", RsidRunAddition = "00E758AA" };

            RunProperties runProperties37 = new RunProperties();
            Bold bold28 = new Bold();
            FontSize fontSize48 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript19 = new FontSizeComplexScript() { Val = "18" };

            runProperties37.Append(bold28);
            runProperties37.Append(fontSize48);
            runProperties37.Append(fontSizeComplexScript19);
            Text text37 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text37.Text = " поставки";

            run38.Append(runProperties37);
            run38.Append(text37);

            Run run39 = new Run() { RsidRunProperties = "00064902" };

            RunProperties runProperties38 = new RunProperties();
            Bold bold29 = new Bold();
            FontSize fontSize49 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript20 = new FontSizeComplexScript() { Val = "18" };

            runProperties38.Append(bold29);
            runProperties38.Append(fontSize49);
            runProperties38.Append(fontSizeComplexScript20);
            Text text38 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text38.Text = " ";

            run39.Append(runProperties38);
            run39.Append(text38);

            Run run40 = new Run() { RsidRunProperties = "00064902", RsidRunAddition = "008E66B8" };

            RunProperties runProperties39 = new RunProperties();
            Bold bold30 = new Bold();
            FontSize fontSize50 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript21 = new FontSizeComplexScript() { Val = "18" };

            runProperties39.Append(bold30);
            runProperties39.Append(fontSize50);
            runProperties39.Append(fontSizeComplexScript21);
            Text text39 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text39.Text = "оборудования ";

            run40.Append(runProperties39);
            run40.Append(text39);

            Run run41 = new Run() { RsidRunProperties = "00064902" };

            RunProperties runProperties40 = new RunProperties();
            Bold bold31 = new Bold();
            FontSize fontSize51 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript22 = new FontSizeComplexScript() { Val = "18" };

            runProperties40.Append(bold31);
            runProperties40.Append(fontSize51);
            runProperties40.Append(fontSizeComplexScript22);
            Text text40 = new Text();
            text40.Text = "№";

            run41.Append(runProperties40);
            run41.Append(text40);

            Run run42 = new Run() { RsidRunProperties = "00064902", RsidRunAddition = "00E2033A" };

            RunProperties runProperties41 = new RunProperties();
            Bold bold32 = new Bold();
            FontSize fontSize52 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript23 = new FontSizeComplexScript() { Val = "18" };

            runProperties41.Append(bold32);
            runProperties41.Append(fontSize52);
            runProperties41.Append(fontSizeComplexScript23);
            Text text41 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text41.Text = " ";

            run42.Append(runProperties41);
            run42.Append(text41);
            ProofError proofError13 = new ProofError() { Type = ProofingErrorValues.SpellStart };

            Run run43 = new Run() { RsidRunAddition = "00216DB9" };

            RunProperties runProperties42 = new RunProperties();
            Bold bold33 = new Bold();
            FontSize fontSize53 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript24 = new FontSizeComplexScript() { Val = "18" };

            runProperties42.Append(bold33);
            runProperties42.Append(fontSize53);
            runProperties42.Append(fontSizeComplexScript24);
            Text text42 = new Text();
            text42.Text = frm.contractNumber.Text;

            run43.Append(runProperties42);
            run43.Append(text42);
            ProofError proofError14 = new ProofError() { Type = ProofingErrorValues.SpellEnd };

            Run run44 = new Run() { RsidRunProperties = "00064902" };

            RunProperties runProperties43 = new RunProperties();
            Bold bold34 = new Bold();
            FontSize fontSize54 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript25 = new FontSizeComplexScript() { Val = "18" };

            runProperties43.Append(bold34);
            runProperties43.Append(fontSize54);
            runProperties43.Append(fontSizeComplexScript25);
            Text text43 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text43.Text = " от";

            run44.Append(runProperties43);
            run44.Append(text43);

            Run run45 = new Run() { RsidRunAddition = "001D5D69" };

            RunProperties runProperties44 = new RunProperties();
            Bold bold35 = new Bold();
            FontSize fontSize55 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript26 = new FontSizeComplexScript() { Val = "18" };

            runProperties44.Append(bold35);
            runProperties44.Append(fontSize55);
            runProperties44.Append(fontSizeComplexScript26);
            Text text44 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text44.Text = " ";

            run45.Append(runProperties44);
            run45.Append(text44);
            ProofError proofError15 = new ProofError() { Type = ProofingErrorValues.SpellStart };

            Run run46 = new Run() { RsidRunAddition = "00216DB9" };

            RunProperties runProperties45 = new RunProperties();
            Bold bold36 = new Bold();
            FontSize fontSize56 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript27 = new FontSizeComplexScript() { Val = "18" };
            Languages languages17 = new Languages() { Val = "en-US" };

            runProperties45.Append(bold36);
            runProperties45.Append(fontSize56);
            runProperties45.Append(fontSizeComplexScript27);
            runProperties45.Append(languages17);
            Text text45 = new Text();
            text45.Text = frm.contractDate.Value.ToShortDateString();

            run46.Append(runProperties45);
            run46.Append(text45);
            ProofError proofError16 = new ProofError() { Type = ProofingErrorValues.SpellEnd };

            Run run47 = new Run() { RsidRunProperties = "00064902" };

            RunProperties runProperties46 = new RunProperties();
            Bold bold37 = new Bold();
            FontSize fontSize57 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript28 = new FontSizeComplexScript() { Val = "18" };

            runProperties46.Append(bold37);
            runProperties46.Append(fontSize57);
            runProperties46.Append(fontSizeComplexScript28);
            Text text46 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text46.Text = " г.";

            run47.Append(runProperties46);
            run47.Append(text46);

            paragraph11.Append(paragraphProperties11);
            paragraph11.Append(run37);
            paragraph11.Append(run38);
            paragraph11.Append(run39);
            paragraph11.Append(run40);
            paragraph11.Append(run41);
            paragraph11.Append(run42);
            paragraph11.Append(proofError13);
            paragraph11.Append(run43);
            paragraph11.Append(proofError14);
            paragraph11.Append(run44);
            paragraph11.Append(run45);
            paragraph11.Append(proofError15);
            paragraph11.Append(run46);
            paragraph11.Append(proofError16);
            paragraph11.Append(run47);

            Paragraph paragraph12 = new Paragraph() { RsidParagraphMarkRevision = "00216DB9", RsidParagraphAddition = "0032169B", RsidParagraphProperties = "00216DB9", RsidRunAdditionDefault = "005B4723" };

            ParagraphProperties paragraphProperties12 = new ParagraphProperties();

            ParagraphMarkRunProperties paragraphMarkRunProperties12 = new ParagraphMarkRunProperties();
            Bold bold38 = new Bold();
            FontSize fontSize58 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript29 = new FontSizeComplexScript() { Val = "18" };
            Languages languages18 = new Languages() { Val = "en-US" };

            paragraphMarkRunProperties12.Append(bold38);
            paragraphMarkRunProperties12.Append(fontSize58);
            paragraphMarkRunProperties12.Append(fontSizeComplexScript29);
            paragraphMarkRunProperties12.Append(languages18);

            paragraphProperties12.Append(paragraphMarkRunProperties12);

            Run run48 = new Run();

            RunProperties runProperties47 = new RunProperties();
            Bold bold39 = new Bold();
            FontSize fontSize59 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript30 = new FontSizeComplexScript() { Val = "18" };

            runProperties47.Append(bold39);
            runProperties47.Append(fontSize59);
            runProperties47.Append(fontSizeComplexScript30);
            Text text47 = new Text();
            text47.Text = "Приложение";

            run48.Append(runProperties47);
            run48.Append(text47);

            Run run49 = new Run() { RsidRunProperties = "00216DB9" };

            RunProperties runProperties48 = new RunProperties();
            Bold bold40 = new Bold();
            FontSize fontSize60 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript31 = new FontSizeComplexScript() { Val = "18" };
            Languages languages19 = new Languages() { Val = "en-US" };

            runProperties48.Append(bold40);
            runProperties48.Append(fontSize60);
            runProperties48.Append(fontSizeComplexScript31);
            runProperties48.Append(languages19);
            Text text48 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text48.Text = " №";

            run49.Append(runProperties48);
            run49.Append(text48);

            Run run50 = new Run() { RsidRunProperties = "00216DB9", RsidRunAddition = "00393C46" };

            RunProperties runProperties49 = new RunProperties();
            Bold bold41 = new Bold();
            FontSize fontSize61 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript32 = new FontSizeComplexScript() { Val = "18" };
            Languages languages20 = new Languages() { Val = "en-US" };

            runProperties49.Append(bold41);
            runProperties49.Append(fontSize61);
            runProperties49.Append(fontSizeComplexScript32);
            runProperties49.Append(languages20);
            Text text49 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text49.Text = " ";

            run50.Append(runProperties49);
            run50.Append(text49);

            Run run51 = new Run() { RsidRunAddition = "00216DB9" };

            RunProperties runProperties50 = new RunProperties();
            Bold bold42 = new Bold();
            FontSize fontSize62 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript33 = new FontSizeComplexScript() { Val = "18" };
            Languages languages21 = new Languages() { Val = "en-US" };

            runProperties50.Append(bold42);
            runProperties50.Append(fontSize62);
            runProperties50.Append(fontSizeComplexScript33);
            runProperties50.Append(languages21);
            Text text50 = new Text();
            text50.Text = frm.supplementNumber.Text;

            run51.Append(runProperties50);
            run51.Append(text50);

            Run run52 = new Run() { RsidRunProperties = "00216DB9", RsidRunAddition = "00096F11" };

            RunProperties runProperties51 = new RunProperties();
            Bold bold43 = new Bold();
            FontSize fontSize63 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript34 = new FontSizeComplexScript() { Val = "18" };
            Languages languages22 = new Languages() { Val = "en-US" };

            runProperties51.Append(bold43);
            runProperties51.Append(fontSize63);
            runProperties51.Append(fontSizeComplexScript34);
            runProperties51.Append(languages22);
            Text text51 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text51.Text = " ";

            run52.Append(runProperties51);
            run52.Append(text51);

            Run run53 = new Run() { RsidRunProperties = "00064902", RsidRunAddition = "00D95925" };

            RunProperties runProperties52 = new RunProperties();
            Bold bold44 = new Bold();
            FontSize fontSize64 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript35 = new FontSizeComplexScript() { Val = "18" };

            runProperties52.Append(bold44);
            runProperties52.Append(fontSize64);
            runProperties52.Append(fontSizeComplexScript35);
            Text text52 = new Text();
            text52.Text = "от";

            run53.Append(runProperties52);
            run53.Append(text52);

            Run run54 = new Run() { RsidRunProperties = "00216DB9", RsidRunAddition = "00332AB7" };

            RunProperties runProperties53 = new RunProperties();
            Bold bold45 = new Bold();
            FontSize fontSize65 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript36 = new FontSizeComplexScript() { Val = "18" };
            Languages languages23 = new Languages() { Val = "en-US" };

            runProperties53.Append(bold45);
            runProperties53.Append(fontSize65);
            runProperties53.Append(fontSizeComplexScript36);
            runProperties53.Append(languages23);
            Text text53 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text53.Text = " ";

            run54.Append(runProperties53);
            run54.Append(text53);
            ProofError proofError17 = new ProofError() { Type = ProofingErrorValues.SpellStart };

            Run run55 = new Run() { RsidRunAddition = "00216DB9" };

            RunProperties runProperties54 = new RunProperties();
            Bold bold46 = new Bold();
            FontSize fontSize66 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript37 = new FontSizeComplexScript() { Val = "18" };
            Languages languages24 = new Languages() { Val = "en-US" };

            runProperties54.Append(bold46);
            runProperties54.Append(fontSize66);
            runProperties54.Append(fontSizeComplexScript37);
            runProperties54.Append(languages24);
            Text text54 = new Text();
            text54.Text = frm.supplementDate.Value.ToShortDateString();

            run55.Append(runProperties54);
            run55.Append(text54);
            ProofError proofError18 = new ProofError() { Type = ProofingErrorValues.SpellEnd };

            Run run56 = new Run() { RsidRunProperties = "00216DB9", RsidRunAddition = "00393C46" };

            RunProperties runProperties55 = new RunProperties();
            Bold bold47 = new Bold();
            FontSize fontSize67 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript38 = new FontSizeComplexScript() { Val = "18" };
            Languages languages25 = new Languages() { Val = "en-US" };

            runProperties55.Append(bold47);
            runProperties55.Append(fontSize67);
            runProperties55.Append(fontSizeComplexScript38);
            runProperties55.Append(languages25);
            Text text55 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text55.Text = " ";

            run56.Append(runProperties55);
            run56.Append(text55);

            Run run57 = new Run() { RsidRunAddition = "00393C46" };

            RunProperties runProperties56 = new RunProperties();
            Bold bold48 = new Bold();
            FontSize fontSize68 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript39 = new FontSizeComplexScript() { Val = "18" };

            runProperties56.Append(bold48);
            runProperties56.Append(fontSize68);
            runProperties56.Append(fontSizeComplexScript39);
            Text text56 = new Text();
            text56.Text = "г";

            run57.Append(runProperties56);
            run57.Append(text56);

            Run run58 = new Run() { RsidRunProperties = "00216DB9", RsidRunAddition = "00393C46" };

            RunProperties runProperties57 = new RunProperties();
            Bold bold49 = new Bold();
            FontSize fontSize69 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript40 = new FontSizeComplexScript() { Val = "18" };
            Languages languages26 = new Languages() { Val = "en-US" };

            runProperties57.Append(bold49);
            runProperties57.Append(fontSize69);
            runProperties57.Append(fontSizeComplexScript40);
            runProperties57.Append(languages26);
            Text text57 = new Text();
            text57.Text = ".";

            run58.Append(runProperties57);
            run58.Append(text57);

            Run run59 = new Run() { RsidRunProperties = "00216DB9", RsidRunAddition = "006050C7" };

            RunProperties runProperties58 = new RunProperties();
            Bold bold50 = new Bold();
            FontSize fontSize70 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript41 = new FontSizeComplexScript() { Val = "18" };
            Languages languages27 = new Languages() { Val = "en-US" };

            runProperties58.Append(bold50);
            runProperties58.Append(fontSize70);
            runProperties58.Append(fontSizeComplexScript41);
            runProperties58.Append(languages27);
            Text text58 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text58.Text = " ";

            run59.Append(runProperties58);
            run59.Append(text58);

            Run run60 = new Run() { RsidRunProperties = "00216DB9", RsidRunAddition = "00D95925" };

            RunProperties runProperties59 = new RunProperties();
            Bold bold51 = new Bold();
            FontSize fontSize71 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript42 = new FontSizeComplexScript() { Val = "18" };
            Languages languages28 = new Languages() { Val = "en-US" };

            runProperties59.Append(bold51);
            runProperties59.Append(fontSize71);
            runProperties59.Append(fontSizeComplexScript42);
            runProperties59.Append(languages28);
            Text text59 = new Text();
            text59.Text = "(";

            run60.Append(runProperties59);
            run60.Append(text59);

            Run run61 = new Run() { RsidRunProperties = "00064902", RsidRunAddition = "00D95925" };

            RunProperties runProperties60 = new RunProperties();
            Bold bold52 = new Bold();
            FontSize fontSize72 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript43 = new FontSizeComplexScript() { Val = "18" };

            runProperties60.Append(bold52);
            runProperties60.Append(fontSize72);
            runProperties60.Append(fontSizeComplexScript43);
            Text text60 = new Text();
            text60.Text = "Спецификация";

            run61.Append(runProperties60);
            run61.Append(text60);

            Run run62 = new Run() { RsidRunProperties = "00216DB9", RsidRunAddition = "00D95925" };

            RunProperties runProperties61 = new RunProperties();
            Bold bold53 = new Bold();
            FontSize fontSize73 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript44 = new FontSizeComplexScript() { Val = "18" };
            Languages languages29 = new Languages() { Val = "en-US" };

            runProperties61.Append(bold53);
            runProperties61.Append(fontSize73);
            runProperties61.Append(fontSizeComplexScript44);
            runProperties61.Append(languages29);
            Text text61 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text61.Text = " №";

            run62.Append(runProperties61);
            run62.Append(text61);

            Run run63 = new Run() { RsidRunProperties = "00216DB9", RsidRunAddition = "00216DB9" };

            RunProperties runProperties62 = new RunProperties();
            Bold bold54 = new Bold();
            FontSize fontSize74 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript45 = new FontSizeComplexScript() { Val = "18" };
            Languages languages30 = new Languages() { Val = "en-US" };

            runProperties62.Append(bold54);
            runProperties62.Append(fontSize74);
            runProperties62.Append(fontSizeComplexScript45);
            runProperties62.Append(languages30);
            Text text62 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text62.Text = " ";

            run63.Append(runProperties62);
            run63.Append(text62);

            Run run64 = new Run() { RsidRunAddition = "00216DB9" };

            RunProperties runProperties63 = new RunProperties();
            Bold bold55 = new Bold();
            FontSize fontSize75 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript46 = new FontSizeComplexScript() { Val = "18" };
            Languages languages31 = new Languages() { Val = "en-US" };

            runProperties63.Append(bold55);
            runProperties63.Append(fontSize75);
            runProperties63.Append(fontSizeComplexScript46);
            runProperties63.Append(languages31);
            Text text63 = new Text();
            text63.Text = frm.supplementNumber.Text;

            run64.Append(runProperties63);
            run64.Append(text63);

            Run run65 = new Run() { RsidRunProperties = "00216DB9", RsidRunAddition = "00D95925" };

            RunProperties runProperties64 = new RunProperties();
            Bold bold56 = new Bold();
            FontSize fontSize76 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript47 = new FontSizeComplexScript() { Val = "18" };
            Languages languages32 = new Languages() { Val = "en-US" };

            runProperties64.Append(bold56);
            runProperties64.Append(fontSize76);
            runProperties64.Append(fontSizeComplexScript47);
            runProperties64.Append(languages32);
            Text text64 = new Text();
            text64.Text = ")";

            run65.Append(runProperties64);
            run65.Append(text64);

            paragraph12.Append(paragraphProperties12);
            paragraph12.Append(run48);
            paragraph12.Append(run49);
            paragraph12.Append(run50);
            paragraph12.Append(run51);
            paragraph12.Append(run52);
            paragraph12.Append(run53);
            paragraph12.Append(run54);
            paragraph12.Append(proofError17);
            paragraph12.Append(run55);
            paragraph12.Append(proofError18);
            paragraph12.Append(run56);
            paragraph12.Append(run57);
            paragraph12.Append(run58);
            paragraph12.Append(run59);
            paragraph12.Append(run60);
            paragraph12.Append(run61);
            paragraph12.Append(run62);
            paragraph12.Append(run63);
            paragraph12.Append(run64);
            paragraph12.Append(run65);

            tableCell4.Append(tableCellProperties4);
            tableCell4.Append(paragraph11);
            tableCell4.Append(paragraph12);

            tableRow2.Append(tableRowProperties2);
            tableRow2.Append(tableCell3);
            tableRow2.Append(tableCell4);

            TableRow tableRow3 = new TableRow() { RsidTableRowMarkRevision = "002A4F5B", RsidTableRowAddition = "006B18AD", RsidTableRowProperties = "005630D3" };

            TableRowProperties tableRowProperties3 = new TableRowProperties();
            CantSplit cantSplit1 = new CantSplit();
            TableRowHeight tableRowHeight3 = new TableRowHeight() { Val = (UInt32Value)428U };

            tableRowProperties3.Append(cantSplit1);
            tableRowProperties3.Append(tableRowHeight3);

            TableCell tableCell5 = new TableCell();

            TableCellProperties tableCellProperties5 = new TableCellProperties();
            TableCellWidth tableCellWidth5 = new TableCellWidth() { Width = "426", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders5 = new TableCellBorders();
            TopBorder topBorder5 = new TopBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            LeftBorder leftBorder5 = new LeftBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder3 = new BottomBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            RightBorder rightBorder5 = new RightBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };

            tableCellBorders5.Append(topBorder5);
            tableCellBorders5.Append(leftBorder5);
            tableCellBorders5.Append(bottomBorder3);
            tableCellBorders5.Append(rightBorder5);

            tableCellProperties5.Append(tableCellWidth5);
            tableCellProperties5.Append(tableCellBorders5);

            Paragraph paragraph13 = new Paragraph() { RsidParagraphMarkRevision = "002A4F5B", RsidParagraphAddition = "006B18AD", RsidParagraphProperties = "00E8706F", RsidRunAdditionDefault = "006B18AD" };

            ParagraphProperties paragraphProperties13 = new ParagraphProperties();
            Indentation indentation8 = new Indentation() { Start = "-108", End = "-108" };
            Justification justification4 = new Justification() { Val = JustificationValues.Center };

            ParagraphMarkRunProperties paragraphMarkRunProperties13 = new ParagraphMarkRunProperties();
            Bold bold57 = new Bold();
            FontSize fontSize77 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript48 = new FontSizeComplexScript() { Val = "18" };

            paragraphMarkRunProperties13.Append(bold57);
            paragraphMarkRunProperties13.Append(fontSize77);
            paragraphMarkRunProperties13.Append(fontSizeComplexScript48);

            paragraphProperties13.Append(indentation8);
            paragraphProperties13.Append(justification4);
            paragraphProperties13.Append(paragraphMarkRunProperties13);

            Run run66 = new Run() { RsidRunProperties = "002A4F5B" };

            RunProperties runProperties65 = new RunProperties();
            Bold bold58 = new Bold();
            FontSize fontSize78 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript49 = new FontSizeComplexScript() { Val = "18" };

            runProperties65.Append(bold58);
            runProperties65.Append(fontSize78);
            runProperties65.Append(fontSizeComplexScript49);
            Text text65 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text65.Text = "№ ";

            run66.Append(runProperties65);
            run66.Append(text65);

            paragraph13.Append(paragraphProperties13);
            paragraph13.Append(run66);

            Paragraph paragraph14 = new Paragraph() { RsidParagraphMarkRevision = "002A4F5B", RsidParagraphAddition = "006B18AD", RsidParagraphProperties = "00E8706F", RsidRunAdditionDefault = "006B18AD" };

            ParagraphProperties paragraphProperties14 = new ParagraphProperties();
            Indentation indentation9 = new Indentation() { Start = "-108", End = "-108" };
            Justification justification5 = new Justification() { Val = JustificationValues.Center };

            ParagraphMarkRunProperties paragraphMarkRunProperties14 = new ParagraphMarkRunProperties();
            Bold bold59 = new Bold();
            FontSize fontSize79 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript50 = new FontSizeComplexScript() { Val = "18" };

            paragraphMarkRunProperties14.Append(bold59);
            paragraphMarkRunProperties14.Append(fontSize79);
            paragraphMarkRunProperties14.Append(fontSizeComplexScript50);

            paragraphProperties14.Append(indentation9);
            paragraphProperties14.Append(justification5);
            paragraphProperties14.Append(paragraphMarkRunProperties14);

            Run run67 = new Run() { RsidRunProperties = "002A4F5B" };

            RunProperties runProperties66 = new RunProperties();
            Bold bold60 = new Bold();
            FontSize fontSize80 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript51 = new FontSizeComplexScript() { Val = "18" };

            runProperties66.Append(bold60);
            runProperties66.Append(fontSize80);
            runProperties66.Append(fontSizeComplexScript51);
            Text text66 = new Text();
            text66.Text = "п/п";

            run67.Append(runProperties66);
            run67.Append(text66);

            paragraph14.Append(paragraphProperties14);
            paragraph14.Append(run67);

            tableCell5.Append(tableCellProperties5);
            tableCell5.Append(paragraph13);
            tableCell5.Append(paragraph14);

            TableCell tableCell6 = new TableCell();

            TableCellProperties tableCellProperties6 = new TableCellProperties();
            TableCellWidth tableCellWidth6 = new TableCellWidth() { Width = "6804", Type = TableWidthUnitValues.Dxa };
            GridSpan gridSpan5 = new GridSpan() { Val = 3 };

            TableCellBorders tableCellBorders6 = new TableCellBorders();
            TopBorder topBorder6 = new TopBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            LeftBorder leftBorder6 = new LeftBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder4 = new BottomBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            RightBorder rightBorder6 = new RightBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };

            tableCellBorders6.Append(topBorder6);
            tableCellBorders6.Append(leftBorder6);
            tableCellBorders6.Append(bottomBorder4);
            tableCellBorders6.Append(rightBorder6);
            TableCellVerticalAlignment tableCellVerticalAlignment3 = new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center };

            tableCellProperties6.Append(tableCellWidth6);
            tableCellProperties6.Append(gridSpan5);
            tableCellProperties6.Append(tableCellBorders6);
            tableCellProperties6.Append(tableCellVerticalAlignment3);

            Paragraph paragraph15 = new Paragraph() { RsidParagraphMarkRevision = "002A4F5B", RsidParagraphAddition = "006B18AD", RsidParagraphProperties = "005630D3", RsidRunAdditionDefault = "006A3FD4" };

            ParagraphProperties paragraphProperties15 = new ParagraphProperties();
            ParagraphStyleId paragraphStyleId9 = new ParagraphStyleId() { Val = "9" };

            ParagraphMarkRunProperties paragraphMarkRunProperties15 = new ParagraphMarkRunProperties();
            FontSize fontSize81 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript52 = new FontSizeComplexScript() { Val = "18" };

            paragraphMarkRunProperties15.Append(fontSize81);
            paragraphMarkRunProperties15.Append(fontSizeComplexScript52);

            paragraphProperties15.Append(paragraphStyleId9);
            paragraphProperties15.Append(paragraphMarkRunProperties15);

            Run run68 = new Run() { RsidRunProperties = "00A75083" };

            RunProperties runProperties67 = new RunProperties();
            FontSize fontSize82 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript53 = new FontSizeComplexScript() { Val = "18" };

            runProperties67.Append(fontSize82);
            runProperties67.Append(fontSizeComplexScript53);
            Text text67 = new Text();
            text67.Text = "Наименование товар";

            run68.Append(runProperties67);
            run68.Append(text67);

            Run run69 = new Run() { RsidRunAddition = "005630D3" };

            RunProperties runProperties68 = new RunProperties();
            FontSize fontSize83 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript54 = new FontSizeComplexScript() { Val = "18" };

            runProperties68.Append(fontSize83);
            runProperties68.Append(fontSizeComplexScript54);
            Text text68 = new Text();
            text68.Text = "а";

            run69.Append(runProperties68);
            run69.Append(text68);

            Run run70 = new Run() { RsidRunProperties = "00A75083" };

            RunProperties runProperties69 = new RunProperties();
            Color color1 = new Color() { Val = "000000" };
            FontSize fontSize84 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript55 = new FontSizeComplexScript() { Val = "18" };

            runProperties69.Append(color1);
            runProperties69.Append(fontSize84);
            runProperties69.Append(fontSizeComplexScript55);
            Text text69 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text69.Text = " ";

            run70.Append(runProperties69);
            run70.Append(text69);

            paragraph15.Append(paragraphProperties15);
            paragraph15.Append(run68);
            paragraph15.Append(run69);
            paragraph15.Append(run70);

            tableCell6.Append(tableCellProperties6);
            tableCell6.Append(paragraph15);

            TableCell tableCell7 = new TableCell();

            TableCellProperties tableCellProperties7 = new TableCellProperties();
            TableCellWidth tableCellWidth7 = new TableCellWidth() { Width = "851", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders7 = new TableCellBorders();
            TopBorder topBorder7 = new TopBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            LeftBorder leftBorder7 = new LeftBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder5 = new BottomBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            RightBorder rightBorder7 = new RightBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };

            tableCellBorders7.Append(topBorder7);
            tableCellBorders7.Append(leftBorder7);
            tableCellBorders7.Append(bottomBorder5);
            tableCellBorders7.Append(rightBorder7);

            tableCellProperties7.Append(tableCellWidth7);
            tableCellProperties7.Append(tableCellBorders7);

            Paragraph paragraph16 = new Paragraph() { RsidParagraphMarkRevision = "002A4F5B", RsidParagraphAddition = "006B18AD", RsidRunAdditionDefault = "006B18AD" };

            ParagraphProperties paragraphProperties16 = new ParagraphProperties();
            Justification justification6 = new Justification() { Val = JustificationValues.Center };

            ParagraphMarkRunProperties paragraphMarkRunProperties16 = new ParagraphMarkRunProperties();
            Bold bold61 = new Bold();
            FontSize fontSize85 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript56 = new FontSizeComplexScript() { Val = "18" };

            paragraphMarkRunProperties16.Append(bold61);
            paragraphMarkRunProperties16.Append(fontSize85);
            paragraphMarkRunProperties16.Append(fontSizeComplexScript56);

            paragraphProperties16.Append(justification6);
            paragraphProperties16.Append(paragraphMarkRunProperties16);

            Run run71 = new Run() { RsidRunProperties = "002A4F5B" };

            RunProperties runProperties70 = new RunProperties();
            Bold bold62 = new Bold();
            FontSize fontSize86 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript57 = new FontSizeComplexScript() { Val = "18" };

            runProperties70.Append(bold62);
            runProperties70.Append(fontSize86);
            runProperties70.Append(fontSizeComplexScript57);
            Text text70 = new Text();
            text70.Text = "Кол-во, шт.";

            run71.Append(runProperties70);
            run71.Append(text70);

            paragraph16.Append(paragraphProperties16);
            paragraph16.Append(run71);

            tableCell7.Append(tableCellProperties7);
            tableCell7.Append(paragraph16);

            TableCell tableCell8 = new TableCell();

            TableCellProperties tableCellProperties8 = new TableCellProperties();
            TableCellWidth tableCellWidth8 = new TableCellWidth() { Width = "992", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders8 = new TableCellBorders();
            TopBorder topBorder8 = new TopBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            LeftBorder leftBorder8 = new LeftBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder6 = new BottomBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            RightBorder rightBorder8 = new RightBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };

            tableCellBorders8.Append(topBorder8);
            tableCellBorders8.Append(leftBorder8);
            tableCellBorders8.Append(bottomBorder6);
            tableCellBorders8.Append(rightBorder8);

            tableCellProperties8.Append(tableCellWidth8);
            tableCellProperties8.Append(tableCellBorders8);

            Paragraph paragraph17 = new Paragraph() { RsidParagraphMarkRevision = "002A4F5B", RsidParagraphAddition = "006B18AD", RsidRunAdditionDefault = "006B18AD" };

            ParagraphProperties paragraphProperties17 = new ParagraphProperties();
            Indentation indentation10 = new Indentation() { Start = "-108", End = "-107" };
            Justification justification7 = new Justification() { Val = JustificationValues.Center };

            ParagraphMarkRunProperties paragraphMarkRunProperties17 = new ParagraphMarkRunProperties();
            Bold bold63 = new Bold();
            FontSize fontSize87 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript58 = new FontSizeComplexScript() { Val = "18" };

            paragraphMarkRunProperties17.Append(bold63);
            paragraphMarkRunProperties17.Append(fontSize87);
            paragraphMarkRunProperties17.Append(fontSizeComplexScript58);

            paragraphProperties17.Append(indentation10);
            paragraphProperties17.Append(justification7);
            paragraphProperties17.Append(paragraphMarkRunProperties17);

            Run run72 = new Run() { RsidRunProperties = "002A4F5B" };

            RunProperties runProperties71 = new RunProperties();
            Bold bold64 = new Bold();
            FontSize fontSize88 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript59 = new FontSizeComplexScript() { Val = "18" };

            runProperties71.Append(bold64);
            runProperties71.Append(fontSize88);
            runProperties71.Append(fontSizeComplexScript59);
            Text text71 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text71.Text = "Цена, ";

            run72.Append(runProperties71);
            run72.Append(text71);

            paragraph17.Append(paragraphProperties17);
            paragraph17.Append(run72);

            Paragraph paragraph18 = new Paragraph() { RsidParagraphMarkRevision = "002A4F5B", RsidParagraphAddition = "006B18AD", RsidRunAdditionDefault = "00764403" };

            ParagraphProperties paragraphProperties18 = new ParagraphProperties();
            Indentation indentation11 = new Indentation() { Start = "-108", End = "-107" };
            Justification justification8 = new Justification() { Val = JustificationValues.Center };

            ParagraphMarkRunProperties paragraphMarkRunProperties18 = new ParagraphMarkRunProperties();
            Bold bold65 = new Bold();
            FontSize fontSize89 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript60 = new FontSizeComplexScript() { Val = "18" };

            paragraphMarkRunProperties18.Append(bold65);
            paragraphMarkRunProperties18.Append(fontSize89);
            paragraphMarkRunProperties18.Append(fontSizeComplexScript60);

            paragraphProperties18.Append(indentation11);
            paragraphProperties18.Append(justification8);
            paragraphProperties18.Append(paragraphMarkRunProperties18);

            Run run73 = new Run();

            RunProperties runProperties72 = new RunProperties();
            Bold bold66 = new Bold();
            FontSize fontSize90 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript61 = new FontSizeComplexScript() { Val = "18" };

            runProperties72.Append(bold66);
            runProperties72.Append(fontSize90);
            runProperties72.Append(fontSizeComplexScript61);
            Text text72 = new Text();
            text72.Text = "Евро";

            run73.Append(runProperties72);
            run73.Append(text72);

            Run run74 = new Run() { RsidRunProperties = "002A4F5B", RsidRunAddition = "006B18AD" };

            RunProperties runProperties73 = new RunProperties();
            Bold bold67 = new Bold();
            FontSize fontSize91 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript62 = new FontSizeComplexScript() { Val = "18" };

            runProperties73.Append(bold67);
            runProperties73.Append(fontSize91);
            runProperties73.Append(fontSizeComplexScript62);
            Text text73 = new Text();
            text73.Text = "/шт.";

            run74.Append(runProperties73);
            run74.Append(text73);

            paragraph18.Append(paragraphProperties18);
            paragraph18.Append(run73);
            paragraph18.Append(run74);

            tableCell8.Append(tableCellProperties8);
            tableCell8.Append(paragraph17);
            tableCell8.Append(paragraph18);

            TableCell tableCell9 = new TableCell();

            TableCellProperties tableCellProperties9 = new TableCellProperties();
            TableCellWidth tableCellWidth9 = new TableCellWidth() { Width = "1418", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders9 = new TableCellBorders();
            TopBorder topBorder9 = new TopBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            LeftBorder leftBorder9 = new LeftBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder7 = new BottomBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            RightBorder rightBorder9 = new RightBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };

            tableCellBorders9.Append(topBorder9);
            tableCellBorders9.Append(leftBorder9);
            tableCellBorders9.Append(bottomBorder7);
            tableCellBorders9.Append(rightBorder9);

            tableCellProperties9.Append(tableCellWidth9);
            tableCellProperties9.Append(tableCellBorders9);

            Paragraph paragraph19 = new Paragraph() { RsidParagraphMarkRevision = "002A4F5B", RsidParagraphAddition = "006B18AD", RsidParagraphProperties = "005E1870", RsidRunAdditionDefault = "006B18AD" };

            ParagraphProperties paragraphProperties19 = new ParagraphProperties();
            Indentation indentation12 = new Indentation() { Start = "-107" };
            Justification justification9 = new Justification() { Val = JustificationValues.Center };

            ParagraphMarkRunProperties paragraphMarkRunProperties19 = new ParagraphMarkRunProperties();
            Bold bold68 = new Bold();
            FontSize fontSize92 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript63 = new FontSizeComplexScript() { Val = "18" };

            paragraphMarkRunProperties19.Append(bold68);
            paragraphMarkRunProperties19.Append(fontSize92);
            paragraphMarkRunProperties19.Append(fontSizeComplexScript63);

            paragraphProperties19.Append(indentation12);
            paragraphProperties19.Append(justification9);
            paragraphProperties19.Append(paragraphMarkRunProperties19);

            Run run75 = new Run() { RsidRunProperties = "002A4F5B" };

            RunProperties runProperties74 = new RunProperties();
            Bold bold69 = new Bold();
            FontSize fontSize93 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript64 = new FontSizeComplexScript() { Val = "18" };

            runProperties74.Append(bold69);
            runProperties74.Append(fontSize93);
            runProperties74.Append(fontSizeComplexScript64);
            Text text74 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text74.Text = "Сумма, ";

            run75.Append(runProperties74);
            run75.Append(text74);

            paragraph19.Append(paragraphProperties19);
            paragraph19.Append(run75);

            Paragraph paragraph20 = new Paragraph() { RsidParagraphMarkRevision = "002A4F5B", RsidParagraphAddition = "006B18AD", RsidParagraphProperties = "00764403", RsidRunAdditionDefault = "00764403" };

            ParagraphProperties paragraphProperties20 = new ParagraphProperties();
            Indentation indentation13 = new Indentation() { Start = "-107" };
            Justification justification10 = new Justification() { Val = JustificationValues.Center };

            ParagraphMarkRunProperties paragraphMarkRunProperties20 = new ParagraphMarkRunProperties();
            Bold bold70 = new Bold();
            FontSize fontSize94 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript65 = new FontSizeComplexScript() { Val = "18" };

            paragraphMarkRunProperties20.Append(bold70);
            paragraphMarkRunProperties20.Append(fontSize94);
            paragraphMarkRunProperties20.Append(fontSizeComplexScript65);

            paragraphProperties20.Append(indentation13);
            paragraphProperties20.Append(justification10);
            paragraphProperties20.Append(paragraphMarkRunProperties20);

            Run run76 = new Run();

            RunProperties runProperties75 = new RunProperties();
            Bold bold71 = new Bold();
            FontSize fontSize95 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript66 = new FontSizeComplexScript() { Val = "18" };

            runProperties75.Append(bold71);
            runProperties75.Append(fontSize95);
            runProperties75.Append(fontSizeComplexScript66);
            Text text75 = new Text();
            text75.Text = "Евро";

            run76.Append(runProperties75);
            run76.Append(text75);

            Run run77 = new Run() { RsidRunProperties = "002A4F5B", RsidRunAddition = "007B69DF" };

            RunProperties runProperties76 = new RunProperties();
            Bold bold72 = new Bold();
            FontSize fontSize96 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript67 = new FontSizeComplexScript() { Val = "18" };

            runProperties76.Append(bold72);
            runProperties76.Append(fontSize96);
            runProperties76.Append(fontSizeComplexScript67);
            Text text76 = new Text();
            text76.Text = ".";

            run77.Append(runProperties76);
            run77.Append(text76);

            paragraph20.Append(paragraphProperties20);
            paragraph20.Append(run76);
            paragraph20.Append(run77);

            tableCell9.Append(tableCellProperties9);
            tableCell9.Append(paragraph19);
            tableCell9.Append(paragraph20);

            tableRow3.Append(tableRowProperties3);
            tableRow3.Append(tableCell5);
            tableRow3.Append(tableCell6);
            tableRow3.Append(tableCell7);
            tableRow3.Append(tableCell8);
            tableRow3.Append(tableCell9);

            TableRow tableRow4 = new TableRow() { RsidTableRowMarkRevision = "002A4F5B", RsidTableRowAddition = "0057510D", RsidTableRowProperties = "00CB7B38" };

            TableRowProperties tableRowProperties4 = new TableRowProperties();
            CantSplit cantSplit2 = new CantSplit();
            TableRowHeight tableRowHeight4 = new TableRowHeight() { Val = (UInt32Value)200U };

            tableRowProperties4.Append(cantSplit2);
            tableRowProperties4.Append(tableRowHeight4);

            TableCell tableCell10 = new TableCell();

            TableCellProperties tableCellProperties10 = new TableCellProperties();
            TableCellWidth tableCellWidth10 = new TableCellWidth() { Width = "426", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders10 = new TableCellBorders();
            LeftBorder leftBorder10 = new LeftBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder8 = new BottomBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            RightBorder rightBorder10 = new RightBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };

            tableCellBorders10.Append(leftBorder10);
            tableCellBorders10.Append(bottomBorder8);
            tableCellBorders10.Append(rightBorder10);
            TableCellVerticalAlignment tableCellVerticalAlignment4 = new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center };

            tableCellProperties10.Append(tableCellWidth10);
            tableCellProperties10.Append(tableCellBorders10);
            tableCellProperties10.Append(tableCellVerticalAlignment4);

            Paragraph paragraph21 = new Paragraph() { RsidParagraphMarkRevision = "0069054C", RsidParagraphAddition = "0057510D", RsidParagraphProperties = "0057510D", RsidRunAdditionDefault = "0069054C" };

            ParagraphProperties paragraphProperties21 = new ParagraphProperties();
            Justification justification11 = new Justification() { Val = JustificationValues.Center };

            ParagraphMarkRunProperties paragraphMarkRunProperties21 = new ParagraphMarkRunProperties();
            RunFonts runFonts15 = new RunFonts() { ComplexScript = "Arial" };
            FontSize fontSize97 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript68 = new FontSizeComplexScript() { Val = "18" };
            Languages languages33 = new Languages() { Val = "en-US" };

            paragraphMarkRunProperties21.Append(runFonts15);
            paragraphMarkRunProperties21.Append(fontSize97);
            paragraphMarkRunProperties21.Append(fontSizeComplexScript68);
            paragraphMarkRunProperties21.Append(languages33);

            paragraphProperties21.Append(justification11);
            paragraphProperties21.Append(paragraphMarkRunProperties21);

            Run run78 = new Run();

            RunProperties runProperties77 = new RunProperties();
            RunFonts runFonts16 = new RunFonts() { ComplexScript = "Arial" };
            FontSize fontSize98 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript69 = new FontSizeComplexScript() { Val = "18" };
            Languages languages34 = new Languages() { Val = "en-US" };

            runProperties77.Append(runFonts16);
            runProperties77.Append(fontSize98);
            runProperties77.Append(fontSizeComplexScript69);
            runProperties77.Append(languages34);
            Text text77 = new Text();
            text77.Text = "position";

            run78.Append(runProperties77);
            run78.Append(text77);

            paragraph21.Append(paragraphProperties21);
            paragraph21.Append(run78);

            tableCell10.Append(tableCellProperties10);
            tableCell10.Append(paragraph21);

            TableCell tableCell11 = new TableCell();

            TableCellProperties tableCellProperties11 = new TableCellProperties();
            TableCellWidth tableCellWidth11 = new TableCellWidth() { Width = "6804", Type = TableWidthUnitValues.Dxa };
            GridSpan gridSpan6 = new GridSpan() { Val = 3 };

            TableCellBorders tableCellBorders11 = new TableCellBorders();
            LeftBorder leftBorder11 = new LeftBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder9 = new BottomBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            RightBorder rightBorder11 = new RightBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };

            tableCellBorders11.Append(leftBorder11);
            tableCellBorders11.Append(bottomBorder9);
            tableCellBorders11.Append(rightBorder11);
            TableCellVerticalAlignment tableCellVerticalAlignment5 = new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center };

            tableCellProperties11.Append(tableCellWidth11);
            tableCellProperties11.Append(gridSpan6);
            tableCellProperties11.Append(tableCellBorders11);
            tableCellProperties11.Append(tableCellVerticalAlignment5);

            Paragraph paragraph22 = new Paragraph() { RsidParagraphMarkRevision = "0069054C", RsidParagraphAddition = "0057510D", RsidParagraphProperties = "0057510D", RsidRunAdditionDefault = "0069054C" };

            ParagraphProperties paragraphProperties22 = new ParagraphProperties();

            ParagraphMarkRunProperties paragraphMarkRunProperties22 = new ParagraphMarkRunProperties();
            RunFonts runFonts17 = new RunFonts() { ComplexScript = "Arial" };
            FontSize fontSize99 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript70 = new FontSizeComplexScript() { Val = "18" };
            Languages languages35 = new Languages() { Val = "en-US" };

            paragraphMarkRunProperties22.Append(runFonts17);
            paragraphMarkRunProperties22.Append(fontSize99);
            paragraphMarkRunProperties22.Append(fontSizeComplexScript70);
            paragraphMarkRunProperties22.Append(languages35);

            paragraphProperties22.Append(paragraphMarkRunProperties22);
            ProofError proofError19 = new ProofError() { Type = ProofingErrorValues.SpellStart };

            Run run79 = new Run();

            RunProperties runProperties78 = new RunProperties();
            RunFonts runFonts18 = new RunFonts() { ComplexScript = "Arial" };
            FontSize fontSize100 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript71 = new FontSizeComplexScript() { Val = "18" };
            Languages languages36 = new Languages() { Val = "en-US" };

            runProperties78.Append(runFonts18);
            runProperties78.Append(fontSize100);
            runProperties78.Append(fontSizeComplexScript71);
            runProperties78.Append(languages36);
            Text text78 = new Text();
            text78.Text = "ProductName";

            run79.Append(runProperties78);
            run79.Append(text78);
            ProofError proofError20 = new ProofError() { Type = ProofingErrorValues.SpellEnd };

            paragraph22.Append(paragraphProperties22);
            paragraph22.Append(proofError19);
            paragraph22.Append(run79);
            paragraph22.Append(proofError20);

            tableCell11.Append(tableCellProperties11);
            tableCell11.Append(paragraph22);

            TableCell tableCell12 = new TableCell();

            TableCellProperties tableCellProperties12 = new TableCellProperties();
            TableCellWidth tableCellWidth12 = new TableCellWidth() { Width = "851", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders12 = new TableCellBorders();
            LeftBorder leftBorder12 = new LeftBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder10 = new BottomBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            RightBorder rightBorder12 = new RightBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };

            tableCellBorders12.Append(leftBorder12);
            tableCellBorders12.Append(bottomBorder10);
            tableCellBorders12.Append(rightBorder12);
            TableCellVerticalAlignment tableCellVerticalAlignment6 = new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center };

            tableCellProperties12.Append(tableCellWidth12);
            tableCellProperties12.Append(tableCellBorders12);
            tableCellProperties12.Append(tableCellVerticalAlignment6);

            Paragraph paragraph23 = new Paragraph() { RsidParagraphMarkRevision = "0069054C", RsidParagraphAddition = "0057510D", RsidParagraphProperties = "0057510D", RsidRunAdditionDefault = "0069054C" };

            ParagraphProperties paragraphProperties23 = new ParagraphProperties();
            Justification justification12 = new Justification() { Val = JustificationValues.Center };

            ParagraphMarkRunProperties paragraphMarkRunProperties23 = new ParagraphMarkRunProperties();
            RunFonts runFonts19 = new RunFonts() { ComplexScript = "Arial" };
            BoldComplexScript boldComplexScript1 = new BoldComplexScript();
            FontSize fontSize101 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript72 = new FontSizeComplexScript() { Val = "18" };
            Languages languages37 = new Languages() { Val = "en-US" };

            paragraphMarkRunProperties23.Append(runFonts19);
            paragraphMarkRunProperties23.Append(boldComplexScript1);
            paragraphMarkRunProperties23.Append(fontSize101);
            paragraphMarkRunProperties23.Append(fontSizeComplexScript72);
            paragraphMarkRunProperties23.Append(languages37);

            paragraphProperties23.Append(justification12);
            paragraphProperties23.Append(paragraphMarkRunProperties23);

            Run run80 = new Run();

            RunProperties runProperties79 = new RunProperties();
            RunFonts runFonts20 = new RunFonts() { ComplexScript = "Arial" };
            BoldComplexScript boldComplexScript2 = new BoldComplexScript();
            FontSize fontSize102 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript73 = new FontSizeComplexScript() { Val = "18" };
            Languages languages38 = new Languages() { Val = "en-US" };

            runProperties79.Append(runFonts20);
            runProperties79.Append(boldComplexScript2);
            runProperties79.Append(fontSize102);
            runProperties79.Append(fontSizeComplexScript73);
            runProperties79.Append(languages38);
            Text text79 = new Text();
            text79.Text = "quantity";

            run80.Append(runProperties79);
            run80.Append(text79);

            paragraph23.Append(paragraphProperties23);
            paragraph23.Append(run80);

            tableCell12.Append(tableCellProperties12);
            tableCell12.Append(paragraph23);

            TableCell tableCell13 = new TableCell();

            TableCellProperties tableCellProperties13 = new TableCellProperties();
            TableCellWidth tableCellWidth13 = new TableCellWidth() { Width = "992", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders13 = new TableCellBorders();
            LeftBorder leftBorder13 = new LeftBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder11 = new BottomBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            RightBorder rightBorder13 = new RightBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };

            tableCellBorders13.Append(leftBorder13);
            tableCellBorders13.Append(bottomBorder11);
            tableCellBorders13.Append(rightBorder13);
            TableCellVerticalAlignment tableCellVerticalAlignment7 = new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center };

            tableCellProperties13.Append(tableCellWidth13);
            tableCellProperties13.Append(tableCellBorders13);
            tableCellProperties13.Append(tableCellVerticalAlignment7);

            Paragraph paragraph24 = new Paragraph() { RsidParagraphMarkRevision = "0069054C", RsidParagraphAddition = "0057510D", RsidParagraphProperties = "0057510D", RsidRunAdditionDefault = "0069054C" };

            ParagraphProperties paragraphProperties24 = new ParagraphProperties();
            Justification justification13 = new Justification() { Val = JustificationValues.Center };

            ParagraphMarkRunProperties paragraphMarkRunProperties24 = new ParagraphMarkRunProperties();
            RunFonts runFonts21 = new RunFonts() { ComplexScript = "Arial" };
            Color color2 = new Color() { Val = "000000" };
            FontSize fontSize103 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript74 = new FontSizeComplexScript() { Val = "18" };
            Languages languages39 = new Languages() { Val = "en-US" };

            paragraphMarkRunProperties24.Append(runFonts21);
            paragraphMarkRunProperties24.Append(color2);
            paragraphMarkRunProperties24.Append(fontSize103);
            paragraphMarkRunProperties24.Append(fontSizeComplexScript74);
            paragraphMarkRunProperties24.Append(languages39);

            paragraphProperties24.Append(justification13);
            paragraphProperties24.Append(paragraphMarkRunProperties24);
            ProofError proofError21 = new ProofError() { Type = ProofingErrorValues.SpellStart };

            Run run81 = new Run();

            RunProperties runProperties80 = new RunProperties();
            RunFonts runFonts22 = new RunFonts() { ComplexScript = "Arial" };
            Color color3 = new Color() { Val = "000000" };
            FontSize fontSize104 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript75 = new FontSizeComplexScript() { Val = "18" };
            Languages languages40 = new Languages() { Val = "en-US" };

            runProperties80.Append(runFonts22);
            runProperties80.Append(color3);
            runProperties80.Append(fontSize104);
            runProperties80.Append(fontSizeComplexScript75);
            runProperties80.Append(languages40);
            Text text80 = new Text();
            text80.Text = "ProductPrice";

            run81.Append(runProperties80);
            run81.Append(text80);
            ProofError proofError22 = new ProofError() { Type = ProofingErrorValues.SpellEnd };

            paragraph24.Append(paragraphProperties24);
            paragraph24.Append(proofError21);
            paragraph24.Append(run81);
            paragraph24.Append(proofError22);

            tableCell13.Append(tableCellProperties13);
            tableCell13.Append(paragraph24);

            TableCell tableCell14 = new TableCell();

            TableCellProperties tableCellProperties14 = new TableCellProperties();
            TableCellWidth tableCellWidth14 = new TableCellWidth() { Width = "1418", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders14 = new TableCellBorders();
            LeftBorder leftBorder14 = new LeftBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder12 = new BottomBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            RightBorder rightBorder14 = new RightBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };

            tableCellBorders14.Append(leftBorder14);
            tableCellBorders14.Append(bottomBorder12);
            tableCellBorders14.Append(rightBorder14);
            TableCellVerticalAlignment tableCellVerticalAlignment8 = new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center };

            tableCellProperties14.Append(tableCellWidth14);
            tableCellProperties14.Append(tableCellBorders14);
            tableCellProperties14.Append(tableCellVerticalAlignment8);

            Paragraph paragraph25 = new Paragraph() { RsidParagraphMarkRevision = "0069054C", RsidParagraphAddition = "0057510D", RsidParagraphProperties = "0057510D", RsidRunAdditionDefault = "0069054C" };

            ParagraphProperties paragraphProperties25 = new ParagraphProperties();
            Justification justification14 = new Justification() { Val = JustificationValues.Center };

            ParagraphMarkRunProperties paragraphMarkRunProperties25 = new ParagraphMarkRunProperties();
            RunFonts runFonts23 = new RunFonts() { ComplexScript = "Arial" };
            Color color4 = new Color() { Val = "000000" };
            FontSize fontSize105 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript76 = new FontSizeComplexScript() { Val = "18" };
            Languages languages41 = new Languages() { Val = "en-US" };

            paragraphMarkRunProperties25.Append(runFonts23);
            paragraphMarkRunProperties25.Append(color4);
            paragraphMarkRunProperties25.Append(fontSize105);
            paragraphMarkRunProperties25.Append(fontSizeComplexScript76);
            paragraphMarkRunProperties25.Append(languages41);

            paragraphProperties25.Append(justification14);
            paragraphProperties25.Append(paragraphMarkRunProperties25);
            ProofError proofError23 = new ProofError() { Type = ProofingErrorValues.SpellStart };

            Run run82 = new Run();

            RunProperties runProperties81 = new RunProperties();
            RunFonts runFonts24 = new RunFonts() { ComplexScript = "Arial" };
            Color color5 = new Color() { Val = "000000" };
            FontSize fontSize106 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript77 = new FontSizeComplexScript() { Val = "18" };
            Languages languages42 = new Languages() { Val = "en-US" };

            runProperties81.Append(runFonts24);
            runProperties81.Append(color5);
            runProperties81.Append(fontSize106);
            runProperties81.Append(fontSizeComplexScript77);
            runProperties81.Append(languages42);
            Text text81 = new Text();
            text81.Text = "TotalProductPrice";

            run82.Append(runProperties81);
            run82.Append(text81);
            ProofError proofError24 = new ProofError() { Type = ProofingErrorValues.SpellEnd };

            paragraph25.Append(paragraphProperties25);
            paragraph25.Append(proofError23);
            paragraph25.Append(run82);
            paragraph25.Append(proofError24);

            tableCell14.Append(tableCellProperties14);
            tableCell14.Append(paragraph25);

            tableRow4.Append(tableRowProperties4);
            tableRow4.Append(tableCell10);
            tableRow4.Append(tableCell11);
            tableRow4.Append(tableCell12);
            tableRow4.Append(tableCell13);
            tableRow4.Append(tableCell14);

            TableRow tableRow5 = new TableRow() { RsidTableRowMarkRevision = "002A4F5B", RsidTableRowAddition = "00195023", RsidTableRowProperties = "005630D3" };

            TableCell tableCell15 = new TableCell();

            TableCellProperties tableCellProperties15 = new TableCellProperties();
            TableCellWidth tableCellWidth15 = new TableCellWidth() { Width = "9073", Type = TableWidthUnitValues.Dxa };
            GridSpan gridSpan7 = new GridSpan() { Val = 6 };

            TableCellBorders tableCellBorders15 = new TableCellBorders();
            LeftBorder leftBorder15 = new LeftBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)6U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder13 = new BottomBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)6U, Space = (UInt32Value)0U };
            RightBorder rightBorder15 = new RightBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)6U, Space = (UInt32Value)0U };

            tableCellBorders15.Append(leftBorder15);
            tableCellBorders15.Append(bottomBorder13);
            tableCellBorders15.Append(rightBorder15);
            TableCellVerticalAlignment tableCellVerticalAlignment9 = new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center };

            tableCellProperties15.Append(tableCellWidth15);
            tableCellProperties15.Append(gridSpan7);
            tableCellProperties15.Append(tableCellBorders15);
            tableCellProperties15.Append(tableCellVerticalAlignment9);

            Paragraph paragraph26 = new Paragraph() { RsidParagraphMarkRevision = "002A4F5B", RsidParagraphAddition = "00195023", RsidParagraphProperties = "000576D8", RsidRunAdditionDefault = "00195023" };

            ParagraphProperties paragraphProperties26 = new ParagraphProperties();
            Justification justification15 = new Justification() { Val = JustificationValues.Center };

            ParagraphMarkRunProperties paragraphMarkRunProperties26 = new ParagraphMarkRunProperties();
            RunFonts runFonts25 = new RunFonts() { Ascii = "Calibri", HighAnsi = "Calibri", ComplexScript = "Calibri" };
            Color color6 = new Color() { Val = "000000" };
            FontSize fontSize107 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript78 = new FontSizeComplexScript() { Val = "18" };

            paragraphMarkRunProperties26.Append(runFonts25);
            paragraphMarkRunProperties26.Append(color6);
            paragraphMarkRunProperties26.Append(fontSize107);
            paragraphMarkRunProperties26.Append(fontSizeComplexScript78);

            paragraphProperties26.Append(justification15);
            paragraphProperties26.Append(paragraphMarkRunProperties26);

            Run run83 = new Run() { RsidRunProperties = "002A4F5B" };

            RunProperties runProperties82 = new RunProperties();
            Bold bold73 = new Bold();
            FontSize fontSize108 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript79 = new FontSizeComplexScript() { Val = "18" };

            runProperties82.Append(bold73);
            runProperties82.Append(fontSize108);
            runProperties82.Append(fontSizeComplexScript79);
            Text text82 = new Text();
            text82.Text = "ИТОГО";

            run83.Append(runProperties82);
            run83.Append(text82);

            Run run84 = new Run() { RsidRunProperties = "002A4F5B" };

            RunProperties runProperties83 = new RunProperties();
            Bold bold74 = new Bold();
            Caps caps1 = new Caps();
            FontSize fontSize109 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript80 = new FontSizeComplexScript() { Val = "18" };

            runProperties83.Append(bold74);
            runProperties83.Append(caps1);
            runProperties83.Append(fontSize109);
            runProperties83.Append(fontSizeComplexScript80);
            Text text83 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text83.Text = " к оплате:";

            run84.Append(runProperties83);
            run84.Append(text83);

            paragraph26.Append(paragraphProperties26);
            paragraph26.Append(run83);
            paragraph26.Append(run84);

            tableCell15.Append(tableCellProperties15);
            tableCell15.Append(paragraph26);

            TableCell tableCell16 = new TableCell();

            TableCellProperties tableCellProperties16 = new TableCellProperties();
            TableCellWidth tableCellWidth16 = new TableCellWidth() { Width = "1418", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders16 = new TableCellBorders();
            TopBorder topBorder10 = new TopBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            LeftBorder leftBorder16 = new LeftBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)6U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder14 = new BottomBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            RightBorder rightBorder16 = new RightBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };

            tableCellBorders16.Append(topBorder10);
            tableCellBorders16.Append(leftBorder16);
            tableCellBorders16.Append(bottomBorder14);
            tableCellBorders16.Append(rightBorder16);
            TableCellVerticalAlignment tableCellVerticalAlignment10 = new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center };

            tableCellProperties16.Append(tableCellWidth16);
            tableCellProperties16.Append(tableCellBorders16);
            tableCellProperties16.Append(tableCellVerticalAlignment10);

            Paragraph paragraph27 = new Paragraph() { RsidParagraphMarkRevision = "0069054C", RsidParagraphAddition = "00195023", RsidParagraphProperties = "0057510D", RsidRunAdditionDefault = "0069054C" };

            ParagraphProperties paragraphProperties27 = new ParagraphProperties();
            Justification justification16 = new Justification() { Val = JustificationValues.Center };

            ParagraphMarkRunProperties paragraphMarkRunProperties27 = new ParagraphMarkRunProperties();
            RunFonts runFonts26 = new RunFonts() { ComplexScript = "Arial" };
            Bold bold75 = new Bold();
            Color color7 = new Color() { Val = "000000" };
            FontSize fontSize110 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript81 = new FontSizeComplexScript() { Val = "18" };
            Languages languages43 = new Languages() { Val = "en-US" };

            paragraphMarkRunProperties27.Append(runFonts26);
            paragraphMarkRunProperties27.Append(bold75);
            paragraphMarkRunProperties27.Append(color7);
            paragraphMarkRunProperties27.Append(fontSize110);
            paragraphMarkRunProperties27.Append(fontSizeComplexScript81);
            paragraphMarkRunProperties27.Append(languages43);

            paragraphProperties27.Append(justification16);
            paragraphProperties27.Append(paragraphMarkRunProperties27);
            ProofError proofError25 = new ProofError() { Type = ProofingErrorValues.SpellStart };

            Run run85 = new Run();

            RunProperties runProperties84 = new RunProperties();
            RunFonts runFonts27 = new RunFonts() { ComplexScript = "Arial" };
            Bold bold76 = new Bold();
            Color color8 = new Color() { Val = "000000" };
            FontSize fontSize111 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript82 = new FontSizeComplexScript() { Val = "18" };
            Languages languages44 = new Languages() { Val = "en-US" };

            runProperties84.Append(runFonts27);
            runProperties84.Append(bold76);
            runProperties84.Append(color8);
            runProperties84.Append(fontSize111);
            runProperties84.Append(fontSizeComplexScript82);
            runProperties84.Append(languages44);
            Text text84 = new Text();
            text84.Text = "TotalPrice";

            run85.Append(runProperties84);
            run85.Append(text84);
            ProofError proofError26 = new ProofError() { Type = ProofingErrorValues.SpellEnd };

            paragraph27.Append(paragraphProperties27);
            paragraph27.Append(proofError25);
            paragraph27.Append(run85);
            paragraph27.Append(proofError26);

            tableCell16.Append(tableCellProperties16);
            tableCell16.Append(paragraph27);

            tableRow5.Append(tableCell15);
            tableRow5.Append(tableCell16);

            TableRow tableRow6 = new TableRow() { RsidTableRowMarkRevision = "002A4F5B", RsidTableRowAddition = "00195023", RsidTableRowProperties = "005630D3" };

            TableCell tableCell17 = new TableCell();

            TableCellProperties tableCellProperties17 = new TableCellProperties();
            TableCellWidth tableCellWidth17 = new TableCellWidth() { Width = "10491", Type = TableWidthUnitValues.Dxa };
            GridSpan gridSpan8 = new GridSpan() { Val = 7 };

            TableCellBorders tableCellBorders17 = new TableCellBorders();
            LeftBorder leftBorder17 = new LeftBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)6U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder15 = new BottomBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)6U, Space = (UInt32Value)0U };
            RightBorder rightBorder17 = new RightBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)6U, Space = (UInt32Value)0U };

            tableCellBorders17.Append(leftBorder17);
            tableCellBorders17.Append(bottomBorder15);
            tableCellBorders17.Append(rightBorder17);

            tableCellProperties17.Append(tableCellWidth17);
            tableCellProperties17.Append(gridSpan8);
            tableCellProperties17.Append(tableCellBorders17);

            Paragraph paragraph28 = new Paragraph() { RsidParagraphMarkRevision = "002A4F5B", RsidParagraphAddition = "00195023", RsidParagraphProperties = "006431E6", RsidRunAdditionDefault = "00195023" };

            ParagraphProperties paragraphProperties28 = new ParagraphProperties();
            ParagraphStyleId paragraphStyleId10 = new ParagraphStyleId() { Val = "6" };
            Justification justification17 = new Justification() { Val = JustificationValues.Left };

            ParagraphMarkRunProperties paragraphMarkRunProperties28 = new ParagraphMarkRunProperties();
            FontSize fontSize112 = new FontSize() { Val = "20" };

            paragraphMarkRunProperties28.Append(fontSize112);

            paragraphProperties28.Append(paragraphStyleId10);
            paragraphProperties28.Append(justification17);
            paragraphProperties28.Append(paragraphMarkRunProperties28);

            Run run86 = new Run();

            RunProperties runProperties85 = new RunProperties();
            FontSize fontSize113 = new FontSize() { Val = "20" };

            runProperties85.Append(fontSize113);
            Text text85 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text85.Text = "                                                      ";

            run86.Append(runProperties85);
            run86.Append(text85);

            Run run87 = new Run() { RsidRunAddition = "00793308" };

            RunProperties runProperties86 = new RunProperties();
            FontSize fontSize114 = new FontSize() { Val = "20" };
            Languages languages45 = new Languages() { Val = "en-US" };

            runProperties86.Append(fontSize114);
            runProperties86.Append(languages45);
            Text text86 = new Text();
            text86.Text = "TPI";

            run87.Append(runProperties86);
            run87.Append(text86);

            Run run88 = new Run();

            RunProperties runProperties87 = new RunProperties();
            FontSize fontSize115 = new FontSize() { Val = "20" };

            runProperties87.Append(fontSize115);
            Text text87 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text87.Text = " евро";

            run88.Append(runProperties87);
            run88.Append(text87);

            Run run89 = new Run() { RsidRunAddition = "009A289B" };

            RunProperties runProperties88 = new RunProperties();
            FontSize fontSize116 = new FontSize() { Val = "20" };

            runProperties88.Append(fontSize116);
            Text text88 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text88.Text = " ";

            run89.Append(runProperties88);
            run89.Append(text88);
            ProofError proofError27 = new ProofError() { Type = ProofingErrorValues.SpellStart };

            Run run90 = new Run() { RsidRunAddition = "006431E6" };

            RunProperties runProperties89 = new RunProperties();
            FontSize fontSize117 = new FontSize() { Val = "20" };
            Languages languages46 = new Languages() { Val = "en-US" };

            runProperties89.Append(fontSize117);
            runProperties89.Append(languages46);
            Text text89 = new Text();
            text89.Text = "TotalPriceFract";

            run90.Append(runProperties89);
            run90.Append(text89);
            ProofError proofError28 = new ProofError() { Type = ProofingErrorValues.SpellEnd };

            Run run91 = new Run();

            RunProperties runProperties90 = new RunProperties();
            FontSize fontSize118 = new FontSize() { Val = "20" };

            runProperties90.Append(fontSize118);
            Text text90 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text90.Text = " ";

            run91.Append(runProperties90);
            run91.Append(text90);
            ProofError proofError29 = new ProofError() { Type = ProofingErrorValues.SpellStart };

            Run run92 = new Run();

            RunProperties runProperties91 = new RunProperties();
            FontSize fontSize119 = new FontSize() { Val = "20" };

            runProperties91.Append(fontSize119);
            Text text91 = new Text();
            text91.Text = "евроцентов";

            run92.Append(runProperties91);
            run92.Append(text91);
            ProofError proofError30 = new ProofError() { Type = ProofingErrorValues.SpellEnd };

            Run run93 = new Run() { RsidRunProperties = "002A4F5B" };

            RunProperties runProperties92 = new RunProperties();
            FontSize fontSize120 = new FontSize() { Val = "20" };

            runProperties92.Append(fontSize120);
            Text text92 = new Text();
            text92.Text = ".";

            run93.Append(runProperties92);
            run93.Append(text92);

            Run run94 = new Run();

            RunProperties runProperties93 = new RunProperties();
            FontSize fontSize121 = new FontSize() { Val = "20" };

            runProperties93.Append(fontSize121);
            Text text93 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text93.Text = " ";

            run94.Append(runProperties93);
            run94.Append(text93);
            BookmarkStart bookmarkStart1 = new BookmarkStart() { Name = "_GoBack", Id = "0" };
            BookmarkEnd bookmarkEnd1 = new BookmarkEnd() { Id = "0" };

            paragraph28.Append(paragraphProperties28);
            paragraph28.Append(run86);
            paragraph28.Append(run87);
            paragraph28.Append(run88);
            paragraph28.Append(run89);
            paragraph28.Append(proofError27);
            paragraph28.Append(run90);
            paragraph28.Append(proofError28);
            paragraph28.Append(run91);
            paragraph28.Append(proofError29);
            paragraph28.Append(run92);
            paragraph28.Append(proofError30);
            paragraph28.Append(run93);
            paragraph28.Append(run94);
            paragraph28.Append(bookmarkStart1);
            paragraph28.Append(bookmarkEnd1);

            tableCell17.Append(tableCellProperties17);
            tableCell17.Append(paragraph28);

            tableRow6.Append(tableCell17);

            TableRow tableRow7 = new TableRow() { RsidTableRowMarkRevision = "00064902", RsidTableRowAddition = "00195023", RsidTableRowProperties = "005630D3" };

            TableCell tableCell18 = new TableCell();

            TableCellProperties tableCellProperties18 = new TableCellProperties();
            TableCellWidth tableCellWidth18 = new TableCellWidth() { Width = "2799", Type = TableWidthUnitValues.Dxa };
            GridSpan gridSpan9 = new GridSpan() { Val = 2 };

            TableCellBorders tableCellBorders18 = new TableCellBorders();
            LeftBorder leftBorder18 = new LeftBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)6U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder16 = new BottomBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)6U, Space = (UInt32Value)0U };
            RightBorder rightBorder18 = new RightBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)6U, Space = (UInt32Value)0U };

            tableCellBorders18.Append(leftBorder18);
            tableCellBorders18.Append(bottomBorder16);
            tableCellBorders18.Append(rightBorder18);
            TableCellVerticalAlignment tableCellVerticalAlignment11 = new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center };

            tableCellProperties18.Append(tableCellWidth18);
            tableCellProperties18.Append(gridSpan9);
            tableCellProperties18.Append(tableCellBorders18);
            tableCellProperties18.Append(tableCellVerticalAlignment11);

            Paragraph paragraph29 = new Paragraph() { RsidParagraphMarkRevision = "002A4F5B", RsidParagraphAddition = "00195023", RsidParagraphProperties = "00604EA9", RsidRunAdditionDefault = "00195023" };

            ParagraphProperties paragraphProperties29 = new ParagraphProperties();
            Justification justification18 = new Justification() { Val = JustificationValues.Center };

            ParagraphMarkRunProperties paragraphMarkRunProperties29 = new ParagraphMarkRunProperties();
            Bold bold77 = new Bold();
            FontSize fontSize122 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript83 = new FontSizeComplexScript() { Val = "18" };

            paragraphMarkRunProperties29.Append(bold77);
            paragraphMarkRunProperties29.Append(fontSize122);
            paragraphMarkRunProperties29.Append(fontSizeComplexScript83);

            paragraphProperties29.Append(justification18);
            paragraphProperties29.Append(paragraphMarkRunProperties29);

            Run run95 = new Run() { RsidRunProperties = "002A4F5B" };

            RunProperties runProperties94 = new RunProperties();
            Bold bold78 = new Bold();
            FontSize fontSize123 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript84 = new FontSizeComplexScript() { Val = "18" };

            runProperties94.Append(bold78);
            runProperties94.Append(fontSize123);
            runProperties94.Append(fontSizeComplexScript84);
            Text text94 = new Text();
            text94.Text = "Условия оплаты";

            run95.Append(runProperties94);
            run95.Append(text94);

            paragraph29.Append(paragraphProperties29);
            paragraph29.Append(run95);

            tableCell18.Append(tableCellProperties18);
            tableCell18.Append(paragraph29);

            TableCell tableCell19 = new TableCell();

            TableCellProperties tableCellProperties19 = new TableCellProperties();
            TableCellWidth tableCellWidth19 = new TableCellWidth() { Width = "7692", Type = TableWidthUnitValues.Dxa };
            GridSpan gridSpan10 = new GridSpan() { Val = 5 };

            TableCellBorders tableCellBorders19 = new TableCellBorders();
            TopBorder topBorder11 = new TopBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)6U, Space = (UInt32Value)0U };
            LeftBorder leftBorder19 = new LeftBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)6U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder17 = new BottomBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)6U, Space = (UInt32Value)0U };
            RightBorder rightBorder19 = new RightBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)6U, Space = (UInt32Value)0U };

            tableCellBorders19.Append(topBorder11);
            tableCellBorders19.Append(leftBorder19);
            tableCellBorders19.Append(bottomBorder17);
            tableCellBorders19.Append(rightBorder19);

            tableCellProperties19.Append(tableCellWidth19);
            tableCellProperties19.Append(gridSpan10);
            tableCellProperties19.Append(tableCellBorders19);

            Paragraph paragraph30 = new Paragraph() { RsidParagraphMarkRevision = "002A4F5B", RsidParagraphAddition = "00195023", RsidParagraphProperties = "00D95925", RsidRunAdditionDefault = "00195023" };

            ParagraphProperties paragraphProperties30 = new ParagraphProperties();

            Tabs tabs2 = new Tabs();
            TabStop tabStop2 = new TabStop() { Val = TabStopValues.Number, Position = 567 };
            TabStop tabStop3 = new TabStop() { Val = TabStopValues.Left, Position = 10206 };

            tabs2.Append(tabStop2);
            tabs2.Append(tabStop3);
            Justification justification19 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties30 = new ParagraphMarkRunProperties();
            Bold bold79 = new Bold();
            FontSize fontSize124 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript85 = new FontSizeComplexScript() { Val = "18" };

            paragraphMarkRunProperties30.Append(bold79);
            paragraphMarkRunProperties30.Append(fontSize124);
            paragraphMarkRunProperties30.Append(fontSizeComplexScript85);

            paragraphProperties30.Append(tabs2);
            paragraphProperties30.Append(justification19);
            paragraphProperties30.Append(paragraphMarkRunProperties30);

            Run run96 = new Run() { RsidRunProperties = "002A4F5B" };

            RunProperties runProperties95 = new RunProperties();
            Bold bold80 = new Bold();
            FontSize fontSize125 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript86 = new FontSizeComplexScript() { Val = "18" };

            runProperties95.Append(bold80);
            runProperties95.Append(fontSize125);
            runProperties95.Append(fontSizeComplexScript86);
            Text text95 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text95.Text = "- 100% (сто процентов) оплачиваются на основании счета-фактуры Поставщика в течение 15 (пятнадцати) банковских 6дней от даты прибытия товара на склад покупателя. Такой датой считается дата окончания таможенной очистки в стране импорта, указанная в ГТД и CMR.  ";

            run96.Append(runProperties95);
            run96.Append(text95);

            paragraph30.Append(paragraphProperties30);
            paragraph30.Append(run96);

            Paragraph paragraph31 = new Paragraph() { RsidParagraphMarkRevision = "00064902", RsidParagraphAddition = "00195023", RsidParagraphProperties = "00D95925", RsidRunAdditionDefault = "00195023" };

            ParagraphProperties paragraphProperties31 = new ParagraphProperties();

            Tabs tabs3 = new Tabs();
            TabStop tabStop4 = new TabStop() { Val = TabStopValues.Number, Position = 567 };
            TabStop tabStop5 = new TabStop() { Val = TabStopValues.Left, Position = 10206 };

            tabs3.Append(tabStop4);
            tabs3.Append(tabStop5);
            Justification justification20 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties31 = new ParagraphMarkRunProperties();
            FontSize fontSize126 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript87 = new FontSizeComplexScript() { Val = "18" };

            paragraphMarkRunProperties31.Append(fontSize126);
            paragraphMarkRunProperties31.Append(fontSizeComplexScript87);

            paragraphProperties31.Append(tabs3);
            paragraphProperties31.Append(justification20);
            paragraphProperties31.Append(paragraphMarkRunProperties31);

            Run run97 = new Run() { RsidRunProperties = "002A4F5B" };

            RunProperties runProperties96 = new RunProperties();
            FontSize fontSize127 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript88 = new FontSizeComplexScript() { Val = "18" };

            runProperties96.Append(fontSize127);
            runProperties96.Append(fontSizeComplexScript88);
            Text text96 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text96.Text = " ";

            run97.Append(runProperties96);
            run97.Append(text96);

            Run run98 = new Run() { RsidRunAddition = "00D52C2C" };

            RunProperties runProperties97 = new RunProperties();
            FontSize fontSize128 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript89 = new FontSizeComplexScript() { Val = "18" };

            runProperties97.Append(fontSize128);
            runProperties97.Append(fontSizeComplexScript89);
            Text text97 = new Text();
            text97.Text = "Комиссионные услуги банков,";

            run98.Append(runProperties97);
            run98.Append(text97);

            Run run99 = new Run() { RsidRunProperties = "002A4F5B" };

            RunProperties runProperties98 = new RunProperties();
            FontSize fontSize129 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript90 = new FontSizeComplexScript() { Val = "18" };

            runProperties98.Append(fontSize129);
            runProperties98.Append(fontSizeComplexScript90);
            Text text98 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text98.Text = " в том числе иностранных банков-корреспондентов, по перечислению денежных средств – за счет Покупателя.";

            run99.Append(runProperties98);
            run99.Append(text98);

            paragraph31.Append(paragraphProperties31);
            paragraph31.Append(run97);
            paragraph31.Append(run98);
            paragraph31.Append(run99);

            tableCell19.Append(tableCellProperties19);
            tableCell19.Append(paragraph30);
            tableCell19.Append(paragraph31);

            tableRow7.Append(tableCell18);
            tableRow7.Append(tableCell19);

            TableRow tableRow8 = new TableRow() { RsidTableRowMarkRevision = "00064902", RsidTableRowAddition = "00195023", RsidTableRowProperties = "005630D3" };

            TableCell tableCell20 = new TableCell();

            TableCellProperties tableCellProperties20 = new TableCellProperties();
            TableCellWidth tableCellWidth20 = new TableCellWidth() { Width = "2799", Type = TableWidthUnitValues.Dxa };
            GridSpan gridSpan11 = new GridSpan() { Val = 2 };

            TableCellBorders tableCellBorders20 = new TableCellBorders();
            LeftBorder leftBorder20 = new LeftBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)6U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder18 = new BottomBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)6U, Space = (UInt32Value)0U };
            RightBorder rightBorder20 = new RightBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)6U, Space = (UInt32Value)0U };

            tableCellBorders20.Append(leftBorder20);
            tableCellBorders20.Append(bottomBorder18);
            tableCellBorders20.Append(rightBorder20);

            tableCellProperties20.Append(tableCellWidth20);
            tableCellProperties20.Append(gridSpan11);
            tableCellProperties20.Append(tableCellBorders20);

            Paragraph paragraph32 = new Paragraph() { RsidParagraphMarkRevision = "00064902", RsidParagraphAddition = "00195023", RsidRunAdditionDefault = "00195023" };

            ParagraphProperties paragraphProperties32 = new ParagraphProperties();
            ParagraphStyleId paragraphStyleId11 = new ParagraphStyleId() { Val = "1" };

            ParagraphMarkRunProperties paragraphMarkRunProperties32 = new ParagraphMarkRunProperties();
            FontSize fontSize130 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript91 = new FontSizeComplexScript() { Val = "18" };
            Languages languages47 = new Languages() { Val = "ru-RU", EastAsia = "ru-RU" };

            paragraphMarkRunProperties32.Append(fontSize130);
            paragraphMarkRunProperties32.Append(fontSizeComplexScript91);
            paragraphMarkRunProperties32.Append(languages47);

            paragraphProperties32.Append(paragraphStyleId11);
            paragraphProperties32.Append(paragraphMarkRunProperties32);

            Run run100 = new Run() { RsidRunProperties = "00064902" };

            RunProperties runProperties99 = new RunProperties();
            FontSize fontSize131 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript92 = new FontSizeComplexScript() { Val = "18" };
            Languages languages48 = new Languages() { Val = "ru-RU", EastAsia = "ru-RU" };

            runProperties99.Append(fontSize131);
            runProperties99.Append(fontSizeComplexScript92);
            runProperties99.Append(languages48);
            Text text99 = new Text();
            text99.Text = "Условия поставки";

            run100.Append(runProperties99);
            run100.Append(text99);

            paragraph32.Append(paragraphProperties32);
            paragraph32.Append(run100);

            tableCell20.Append(tableCellProperties20);
            tableCell20.Append(paragraph32);

            TableCell tableCell21 = new TableCell();

            TableCellProperties tableCellProperties21 = new TableCellProperties();
            TableCellWidth tableCellWidth21 = new TableCellWidth() { Width = "7692", Type = TableWidthUnitValues.Dxa };
            GridSpan gridSpan12 = new GridSpan() { Val = 5 };

            TableCellBorders tableCellBorders21 = new TableCellBorders();
            TopBorder topBorder12 = new TopBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)6U, Space = (UInt32Value)0U };
            LeftBorder leftBorder21 = new LeftBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)6U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder19 = new BottomBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)6U, Space = (UInt32Value)0U };
            RightBorder rightBorder21 = new RightBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)6U, Space = (UInt32Value)0U };

            tableCellBorders21.Append(topBorder12);
            tableCellBorders21.Append(leftBorder21);
            tableCellBorders21.Append(bottomBorder19);
            tableCellBorders21.Append(rightBorder21);

            tableCellProperties21.Append(tableCellWidth21);
            tableCellProperties21.Append(gridSpan12);
            tableCellProperties21.Append(tableCellBorders21);

            Paragraph paragraph33 = new Paragraph() { RsidParagraphMarkRevision = "00064902", RsidParagraphAddition = "00195023", RsidParagraphProperties = "00875181", RsidRunAdditionDefault = "00195023" };

            ParagraphProperties paragraphProperties33 = new ParagraphProperties();
            Justification justification21 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties33 = new ParagraphMarkRunProperties();
            Color color9 = new Color() { Val = "FF0000" };
            FontSize fontSize132 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript93 = new FontSizeComplexScript() { Val = "18" };

            paragraphMarkRunProperties33.Append(color9);
            paragraphMarkRunProperties33.Append(fontSize132);
            paragraphMarkRunProperties33.Append(fontSizeComplexScript93);

            paragraphProperties33.Append(justification21);
            paragraphProperties33.Append(paragraphMarkRunProperties33);

            Run run101 = new Run() { RsidRunProperties = "00064902" };

            RunProperties runProperties100 = new RunProperties();
            Bold bold81 = new Bold();
            FontSize fontSize133 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript94 = new FontSizeComplexScript() { Val = "18" };

            runProperties100.Append(bold81);
            runProperties100.Append(fontSize133);
            runProperties100.Append(fontSizeComplexScript94);
            Text text100 = new Text();
            text100.Text = "EXW";

            run101.Append(runProperties100);
            run101.Append(text100);

            Run run102 = new Run() { RsidRunProperties = "00064902" };

            RunProperties runProperties101 = new RunProperties();
            FontSize fontSize134 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript95 = new FontSizeComplexScript() { Val = "18" };

            runProperties101.Append(fontSize134);
            runProperties101.Append(fontSizeComplexScript95);
            Text text101 = new Text();
            text101.Text = ", г. Черкассы, Украина (согласно правилам ИНКОТЕРМС-2010).";

            run102.Append(runProperties101);
            run102.Append(text101);

            paragraph33.Append(paragraphProperties33);
            paragraph33.Append(run101);
            paragraph33.Append(run102);

            tableCell21.Append(tableCellProperties21);
            tableCell21.Append(paragraph33);

            tableRow8.Append(tableCell20);
            tableRow8.Append(tableCell21);

            TableRow tableRow9 = new TableRow() { RsidTableRowMarkRevision = "00064902", RsidTableRowAddition = "00195023", RsidTableRowProperties = "005630D3" };

            TableCell tableCell22 = new TableCell();

            TableCellProperties tableCellProperties22 = new TableCellProperties();
            TableCellWidth tableCellWidth22 = new TableCellWidth() { Width = "2799", Type = TableWidthUnitValues.Dxa };
            GridSpan gridSpan13 = new GridSpan() { Val = 2 };

            TableCellBorders tableCellBorders22 = new TableCellBorders();
            LeftBorder leftBorder22 = new LeftBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)6U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder20 = new BottomBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)6U, Space = (UInt32Value)0U };
            RightBorder rightBorder22 = new RightBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)6U, Space = (UInt32Value)0U };

            tableCellBorders22.Append(leftBorder22);
            tableCellBorders22.Append(bottomBorder20);
            tableCellBorders22.Append(rightBorder22);

            tableCellProperties22.Append(tableCellWidth22);
            tableCellProperties22.Append(gridSpan13);
            tableCellProperties22.Append(tableCellBorders22);

            Paragraph paragraph34 = new Paragraph() { RsidParagraphMarkRevision = "00064902", RsidParagraphAddition = "00195023", RsidRunAdditionDefault = "00195023" };

            ParagraphProperties paragraphProperties34 = new ParagraphProperties();
            ParagraphStyleId paragraphStyleId12 = new ParagraphStyleId() { Val = "1" };

            ParagraphMarkRunProperties paragraphMarkRunProperties34 = new ParagraphMarkRunProperties();
            FontSize fontSize135 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript96 = new FontSizeComplexScript() { Val = "18" };
            Languages languages49 = new Languages() { Val = "ru-RU", EastAsia = "ru-RU" };

            paragraphMarkRunProperties34.Append(fontSize135);
            paragraphMarkRunProperties34.Append(fontSizeComplexScript96);
            paragraphMarkRunProperties34.Append(languages49);

            paragraphProperties34.Append(paragraphStyleId12);
            paragraphProperties34.Append(paragraphMarkRunProperties34);

            Run run103 = new Run() { RsidRunProperties = "00064902" };

            RunProperties runProperties102 = new RunProperties();
            FontSize fontSize136 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript97 = new FontSizeComplexScript() { Val = "18" };
            Languages languages50 = new Languages() { Val = "ru-RU", EastAsia = "ru-RU" };

            runProperties102.Append(fontSize136);
            runProperties102.Append(fontSizeComplexScript97);
            runProperties102.Append(languages50);
            Text text102 = new Text();
            text102.Text = "Вес нетто/брутто";

            run103.Append(runProperties102);
            run103.Append(text102);

            paragraph34.Append(paragraphProperties34);
            paragraph34.Append(run103);

            tableCell22.Append(tableCellProperties22);
            tableCell22.Append(paragraph34);

            TableCell tableCell23 = new TableCell();

            TableCellProperties tableCellProperties23 = new TableCellProperties();
            TableCellWidth tableCellWidth23 = new TableCellWidth() { Width = "7692", Type = TableWidthUnitValues.Dxa };
            GridSpan gridSpan14 = new GridSpan() { Val = 5 };

            TableCellBorders tableCellBorders23 = new TableCellBorders();
            TopBorder topBorder13 = new TopBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)6U, Space = (UInt32Value)0U };
            LeftBorder leftBorder23 = new LeftBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)6U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder21 = new BottomBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)6U, Space = (UInt32Value)0U };
            RightBorder rightBorder23 = new RightBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)6U, Space = (UInt32Value)0U };

            tableCellBorders23.Append(topBorder13);
            tableCellBorders23.Append(leftBorder23);
            tableCellBorders23.Append(bottomBorder21);
            tableCellBorders23.Append(rightBorder23);

            tableCellProperties23.Append(tableCellWidth23);
            tableCellProperties23.Append(gridSpan14);
            tableCellProperties23.Append(tableCellBorders23);

            Paragraph paragraph35 = new Paragraph() { RsidParagraphMarkRevision = "00064902", RsidParagraphAddition = "00195023", RsidParagraphProperties = "00905DAC", RsidRunAdditionDefault = "00905DAC" };

            ParagraphProperties paragraphProperties35 = new ParagraphProperties();
            Justification justification22 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties35 = new ParagraphMarkRunProperties();
            Bold bold82 = new Bold();
            FontSize fontSize137 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript98 = new FontSizeComplexScript() { Val = "18" };

            paragraphMarkRunProperties35.Append(bold82);
            paragraphMarkRunProperties35.Append(fontSize137);
            paragraphMarkRunProperties35.Append(fontSizeComplexScript98);

            paragraphProperties35.Append(justification22);
            paragraphProperties35.Append(paragraphMarkRunProperties35);

            Run run104 = new Run() { RsidRunProperties = "0040759A" };

            RunProperties runProperties103 = new RunProperties();
            Bold bold83 = new Bold();
            FontSize fontSize138 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript99 = new FontSizeComplexScript() { Val = "18" };
            Languages languages51 = new Languages() { Val = "en-US" };

            runProperties103.Append(bold83);
            runProperties103.Append(fontSize138);
            runProperties103.Append(fontSizeComplexScript99);
            runProperties103.Append(languages51);
            Text text103 = new Text();
            text103.Text = frm.gross.Value.ToString();

            run104.Append(runProperties103);
            run104.Append(text103);

            Run run105 = new Run() { RsidRunProperties = "0040759A", RsidRunAddition = "00195023" };

            RunProperties runProperties104 = new RunProperties();
            Bold bold84 = new Bold();
            FontSize fontSize139 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript100 = new FontSizeComplexScript() { Val = "18" };

            runProperties104.Append(bold84);
            runProperties104.Append(fontSize139);
            runProperties104.Append(fontSizeComplexScript100);
            Text text104 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text104.Text = " кг /";

            run105.Append(runProperties104);
            run105.Append(text104);

            Run run106 = new Run() { RsidRunProperties = "0040759A" };

            RunProperties runProperties105 = new RunProperties();
            Bold bold85 = new Bold();
            FontSize fontSize140 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript101 = new FontSizeComplexScript() { Val = "18" };
            Languages languages52 = new Languages() { Val = "en-US" };

            runProperties105.Append(bold85);
            runProperties105.Append(fontSize140);
            runProperties105.Append(fontSizeComplexScript101);
            runProperties105.Append(languages52);
            Text text105 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text105.Text = " " + frm.net.Value.ToString() + " ";

            run106.Append(runProperties105);
            run106.Append(text105);

            Run run107 = new Run() { RsidRunProperties = "0040759A", RsidRunAddition = "00195023" };

            RunProperties runProperties106 = new RunProperties();
            Bold bold86 = new Bold();
            FontSize fontSize141 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript102 = new FontSizeComplexScript() { Val = "18" };

            runProperties106.Append(bold86);
            runProperties106.Append(fontSize141);
            runProperties106.Append(fontSizeComplexScript102);
            Text text106 = new Text();
            text106.Text = "кг";

            run107.Append(runProperties106);
            run107.Append(text106);

            paragraph35.Append(paragraphProperties35);
            paragraph35.Append(run104);
            paragraph35.Append(run105);
            paragraph35.Append(run106);
            paragraph35.Append(run107);

            tableCell23.Append(tableCellProperties23);
            tableCell23.Append(paragraph35);

            tableRow9.Append(tableCell22);
            tableRow9.Append(tableCell23);

            TableRow tableRow10 = new TableRow() { RsidTableRowMarkRevision = "00064902", RsidTableRowAddition = "00195023", RsidTableRowProperties = "005630D3" };

            TableCell tableCell24 = new TableCell();

            TableCellProperties tableCellProperties24 = new TableCellProperties();
            TableCellWidth tableCellWidth24 = new TableCellWidth() { Width = "2799", Type = TableWidthUnitValues.Dxa };
            GridSpan gridSpan15 = new GridSpan() { Val = 2 };

            TableCellBorders tableCellBorders24 = new TableCellBorders();
            LeftBorder leftBorder24 = new LeftBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)6U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder22 = new BottomBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)6U, Space = (UInt32Value)0U };
            RightBorder rightBorder24 = new RightBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)6U, Space = (UInt32Value)0U };

            tableCellBorders24.Append(leftBorder24);
            tableCellBorders24.Append(bottomBorder22);
            tableCellBorders24.Append(rightBorder24);

            tableCellProperties24.Append(tableCellWidth24);
            tableCellProperties24.Append(gridSpan15);
            tableCellProperties24.Append(tableCellBorders24);

            Paragraph paragraph36 = new Paragraph() { RsidParagraphMarkRevision = "00064902", RsidParagraphAddition = "00195023", RsidRunAdditionDefault = "00195023" };

            ParagraphProperties paragraphProperties36 = new ParagraphProperties();
            ParagraphStyleId paragraphStyleId13 = new ParagraphStyleId() { Val = "1" };

            ParagraphMarkRunProperties paragraphMarkRunProperties36 = new ParagraphMarkRunProperties();
            FontSize fontSize142 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript103 = new FontSizeComplexScript() { Val = "18" };
            Languages languages53 = new Languages() { Val = "ru-RU", EastAsia = "ru-RU" };

            paragraphMarkRunProperties36.Append(fontSize142);
            paragraphMarkRunProperties36.Append(fontSizeComplexScript103);
            paragraphMarkRunProperties36.Append(languages53);

            paragraphProperties36.Append(paragraphStyleId13);
            paragraphProperties36.Append(paragraphMarkRunProperties36);

            Run run108 = new Run() { RsidRunProperties = "00064902" };

            RunProperties runProperties107 = new RunProperties();
            FontSize fontSize143 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript104 = new FontSizeComplexScript() { Val = "18" };
            Languages languages54 = new Languages() { Val = "ru-RU", EastAsia = "ru-RU" };

            runProperties107.Append(fontSize143);
            runProperties107.Append(fontSizeComplexScript104);
            runProperties107.Append(languages54);
            Text text107 = new Text();
            text107.Text = "Изготовитель";

            run108.Append(runProperties107);
            run108.Append(text107);

            paragraph36.Append(paragraphProperties36);
            paragraph36.Append(run108);

            tableCell24.Append(tableCellProperties24);
            tableCell24.Append(paragraph36);

            TableCell tableCell25 = new TableCell();

            TableCellProperties tableCellProperties25 = new TableCellProperties();
            TableCellWidth tableCellWidth25 = new TableCellWidth() { Width = "7692", Type = TableWidthUnitValues.Dxa };
            GridSpan gridSpan16 = new GridSpan() { Val = 5 };

            TableCellBorders tableCellBorders25 = new TableCellBorders();
            TopBorder topBorder14 = new TopBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)6U, Space = (UInt32Value)0U };
            LeftBorder leftBorder25 = new LeftBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)6U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder23 = new BottomBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)6U, Space = (UInt32Value)0U };
            RightBorder rightBorder25 = new RightBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)6U, Space = (UInt32Value)0U };

            tableCellBorders25.Append(topBorder14);
            tableCellBorders25.Append(leftBorder25);
            tableCellBorders25.Append(bottomBorder23);
            tableCellBorders25.Append(rightBorder25);

            tableCellProperties25.Append(tableCellWidth25);
            tableCellProperties25.Append(gridSpan16);
            tableCellProperties25.Append(tableCellBorders25);

            Paragraph paragraph37 = new Paragraph() { RsidParagraphMarkRevision = "00064902", RsidParagraphAddition = "00195023", RsidRunAdditionDefault = "00195023" };

            ParagraphProperties paragraphProperties37 = new ParagraphProperties();
            Justification justification23 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties37 = new ParagraphMarkRunProperties();
            Bold bold87 = new Bold();
            FontSize fontSize144 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript105 = new FontSizeComplexScript() { Val = "18" };

            paragraphMarkRunProperties37.Append(bold87);
            paragraphMarkRunProperties37.Append(fontSize144);
            paragraphMarkRunProperties37.Append(fontSizeComplexScript105);

            paragraphProperties37.Append(justification23);
            paragraphProperties37.Append(paragraphMarkRunProperties37);

            Run run109 = new Run() { RsidRunProperties = "00064902" };

            RunProperties runProperties108 = new RunProperties();
            Bold bold88 = new Bold();
            FontSize fontSize145 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript106 = new FontSizeComplexScript() { Val = "18" };

            runProperties108.Append(bold88);
            runProperties108.Append(fontSize145);
            runProperties108.Append(fontSizeComplexScript106);
            Text text108 = new Text();
            text108.Text = "ООО «";

            run109.Append(runProperties108);
            run109.Append(text108);
            ProofError proofError31 = new ProofError() { Type = ProofingErrorValues.SpellStart };

            Run run110 = new Run() { RsidRunProperties = "00064902" };

            RunProperties runProperties109 = new RunProperties();
            Bold bold89 = new Bold();
            FontSize fontSize146 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript107 = new FontSizeComplexScript() { Val = "18" };

            runProperties109.Append(bold89);
            runProperties109.Append(fontSize146);
            runProperties109.Append(fontSizeComplexScript107);
            Text text109 = new Text();
            text109.Text = "Разек";

            run110.Append(runProperties109);
            run110.Append(text109);
            ProofError proofError32 = new ProofError() { Type = ProofingErrorValues.SpellEnd };

            Run run111 = new Run() { RsidRunProperties = "00064902" };

            RunProperties runProperties110 = new RunProperties();
            Bold bold90 = new Bold();
            FontSize fontSize147 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript108 = new FontSizeComplexScript() { Val = "18" };

            runProperties110.Append(bold90);
            runProperties110.Append(fontSize147);
            runProperties110.Append(fontSizeComplexScript108);
            Text text110 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text110.Text = " Черкассы», г. Черкассы, Украина";

            run111.Append(runProperties110);
            run111.Append(text110);

            paragraph37.Append(paragraphProperties37);
            paragraph37.Append(run109);
            paragraph37.Append(proofError31);
            paragraph37.Append(run110);
            paragraph37.Append(proofError32);
            paragraph37.Append(run111);

            tableCell25.Append(tableCellProperties25);
            tableCell25.Append(paragraph37);

            tableRow10.Append(tableCell24);
            tableRow10.Append(tableCell25);

            TableRow tableRow11 = new TableRow() { RsidTableRowMarkRevision = "00064902", RsidTableRowAddition = "00195023", RsidTableRowProperties = "005630D3" };

            TableCell tableCell26 = new TableCell();

            TableCellProperties tableCellProperties26 = new TableCellProperties();
            TableCellWidth tableCellWidth26 = new TableCellWidth() { Width = "2799", Type = TableWidthUnitValues.Dxa };
            GridSpan gridSpan17 = new GridSpan() { Val = 2 };

            TableCellBorders tableCellBorders26 = new TableCellBorders();
            TopBorder topBorder15 = new TopBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)6U, Space = (UInt32Value)0U };
            LeftBorder leftBorder26 = new LeftBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)6U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder24 = new BottomBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)6U, Space = (UInt32Value)0U };
            RightBorder rightBorder26 = new RightBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)6U, Space = (UInt32Value)0U };

            tableCellBorders26.Append(topBorder15);
            tableCellBorders26.Append(leftBorder26);
            tableCellBorders26.Append(bottomBorder24);
            tableCellBorders26.Append(rightBorder26);

            tableCellProperties26.Append(tableCellWidth26);
            tableCellProperties26.Append(gridSpan17);
            tableCellProperties26.Append(tableCellBorders26);

            Paragraph paragraph38 = new Paragraph() { RsidParagraphMarkRevision = "00064902", RsidParagraphAddition = "00195023", RsidRunAdditionDefault = "00195023" };

            ParagraphProperties paragraphProperties38 = new ParagraphProperties();
            Justification justification24 = new Justification() { Val = JustificationValues.Center };

            ParagraphMarkRunProperties paragraphMarkRunProperties38 = new ParagraphMarkRunProperties();
            Bold bold91 = new Bold();
            FontSize fontSize148 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript109 = new FontSizeComplexScript() { Val = "18" };

            paragraphMarkRunProperties38.Append(bold91);
            paragraphMarkRunProperties38.Append(fontSize148);
            paragraphMarkRunProperties38.Append(fontSizeComplexScript109);

            paragraphProperties38.Append(justification24);
            paragraphProperties38.Append(paragraphMarkRunProperties38);

            Run run112 = new Run() { RsidRunProperties = "00064902" };

            RunProperties runProperties111 = new RunProperties();
            Bold bold92 = new Bold();
            FontSize fontSize149 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript110 = new FontSizeComplexScript() { Val = "18" };

            runProperties111.Append(bold92);
            runProperties111.Append(fontSize149);
            runProperties111.Append(fontSizeComplexScript110);
            Text text111 = new Text();
            text111.Text = "Страна происхождения";

            run112.Append(runProperties111);
            run112.Append(text111);

            paragraph38.Append(paragraphProperties38);
            paragraph38.Append(run112);

            tableCell26.Append(tableCellProperties26);
            tableCell26.Append(paragraph38);

            TableCell tableCell27 = new TableCell();

            TableCellProperties tableCellProperties27 = new TableCellProperties();
            TableCellWidth tableCellWidth27 = new TableCellWidth() { Width = "7692", Type = TableWidthUnitValues.Dxa };
            GridSpan gridSpan18 = new GridSpan() { Val = 5 };

            TableCellBorders tableCellBorders27 = new TableCellBorders();
            TopBorder topBorder16 = new TopBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)6U, Space = (UInt32Value)0U };
            LeftBorder leftBorder27 = new LeftBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)6U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder25 = new BottomBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)6U, Space = (UInt32Value)0U };
            RightBorder rightBorder27 = new RightBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)6U, Space = (UInt32Value)0U };

            tableCellBorders27.Append(topBorder16);
            tableCellBorders27.Append(leftBorder27);
            tableCellBorders27.Append(bottomBorder25);
            tableCellBorders27.Append(rightBorder27);

            tableCellProperties27.Append(tableCellWidth27);
            tableCellProperties27.Append(gridSpan18);
            tableCellProperties27.Append(tableCellBorders27);

            Paragraph paragraph39 = new Paragraph() { RsidParagraphMarkRevision = "00064902", RsidParagraphAddition = "00195023", RsidRunAdditionDefault = "00195023" };

            ParagraphProperties paragraphProperties39 = new ParagraphProperties();
            Justification justification25 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties39 = new ParagraphMarkRunProperties();
            Bold bold93 = new Bold();
            FontSize fontSize150 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript111 = new FontSizeComplexScript() { Val = "18" };

            paragraphMarkRunProperties39.Append(bold93);
            paragraphMarkRunProperties39.Append(fontSize150);
            paragraphMarkRunProperties39.Append(fontSizeComplexScript111);

            paragraphProperties39.Append(justification25);
            paragraphProperties39.Append(paragraphMarkRunProperties39);

            Run run113 = new Run() { RsidRunProperties = "00064902" };

            RunProperties runProperties112 = new RunProperties();
            Bold bold94 = new Bold();
            FontSize fontSize151 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript112 = new FontSizeComplexScript() { Val = "18" };

            runProperties112.Append(bold94);
            runProperties112.Append(fontSize151);
            runProperties112.Append(fontSizeComplexScript112);
            Text text112 = new Text();
            text112.Text = "Украина";

            run113.Append(runProperties112);
            run113.Append(text112);

            paragraph39.Append(paragraphProperties39);
            paragraph39.Append(run113);

            tableCell27.Append(tableCellProperties27);
            tableCell27.Append(paragraph39);

            tableRow11.Append(tableCell26);
            tableRow11.Append(tableCell27);

            TableRow tableRow12 = new TableRow() { RsidTableRowMarkRevision = "00064902", RsidTableRowAddition = "00195023", RsidTableRowProperties = "005630D3" };

            TableCell tableCell28 = new TableCell();

            TableCellProperties tableCellProperties28 = new TableCellProperties();
            TableCellWidth tableCellWidth28 = new TableCellWidth() { Width = "2799", Type = TableWidthUnitValues.Dxa };
            GridSpan gridSpan19 = new GridSpan() { Val = 2 };

            TableCellBorders tableCellBorders28 = new TableCellBorders();
            TopBorder topBorder17 = new TopBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)6U, Space = (UInt32Value)0U };
            LeftBorder leftBorder28 = new LeftBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)6U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder26 = new BottomBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)6U, Space = (UInt32Value)0U };
            RightBorder rightBorder28 = new RightBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)6U, Space = (UInt32Value)0U };

            tableCellBorders28.Append(topBorder17);
            tableCellBorders28.Append(leftBorder28);
            tableCellBorders28.Append(bottomBorder26);
            tableCellBorders28.Append(rightBorder28);

            tableCellProperties28.Append(tableCellWidth28);
            tableCellProperties28.Append(gridSpan19);
            tableCellProperties28.Append(tableCellBorders28);

            Paragraph paragraph40 = new Paragraph() { RsidParagraphMarkRevision = "00064902", RsidParagraphAddition = "00195023", RsidRunAdditionDefault = "00195023" };

            ParagraphProperties paragraphProperties40 = new ParagraphProperties();
            Justification justification26 = new Justification() { Val = JustificationValues.Center };

            ParagraphMarkRunProperties paragraphMarkRunProperties40 = new ParagraphMarkRunProperties();
            Bold bold95 = new Bold();
            FontSize fontSize152 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript113 = new FontSizeComplexScript() { Val = "18" };

            paragraphMarkRunProperties40.Append(bold95);
            paragraphMarkRunProperties40.Append(fontSize152);
            paragraphMarkRunProperties40.Append(fontSizeComplexScript113);

            paragraphProperties40.Append(justification26);
            paragraphProperties40.Append(paragraphMarkRunProperties40);

            Run run114 = new Run() { RsidRunProperties = "00064902" };

            RunProperties runProperties113 = new RunProperties();
            Bold bold96 = new Bold();
            FontSize fontSize153 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript114 = new FontSizeComplexScript() { Val = "18" };

            runProperties113.Append(bold96);
            runProperties113.Append(fontSize153);
            runProperties113.Append(fontSizeComplexScript114);
            Text text113 = new Text();
            text113.Text = "Отгрузка";

            run114.Append(runProperties113);
            run114.Append(text113);

            paragraph40.Append(paragraphProperties40);
            paragraph40.Append(run114);

            tableCell28.Append(tableCellProperties28);
            tableCell28.Append(paragraph40);

            TableCell tableCell29 = new TableCell();

            TableCellProperties tableCellProperties29 = new TableCellProperties();
            TableCellWidth tableCellWidth29 = new TableCellWidth() { Width = "7692", Type = TableWidthUnitValues.Dxa };
            GridSpan gridSpan20 = new GridSpan() { Val = 5 };

            TableCellBorders tableCellBorders29 = new TableCellBorders();
            TopBorder topBorder18 = new TopBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)6U, Space = (UInt32Value)0U };
            LeftBorder leftBorder29 = new LeftBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)6U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder27 = new BottomBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)6U, Space = (UInt32Value)0U };
            RightBorder rightBorder29 = new RightBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)6U, Space = (UInt32Value)0U };

            tableCellBorders29.Append(topBorder18);
            tableCellBorders29.Append(leftBorder29);
            tableCellBorders29.Append(bottomBorder27);
            tableCellBorders29.Append(rightBorder29);

            tableCellProperties29.Append(tableCellWidth29);
            tableCellProperties29.Append(gridSpan20);
            tableCellProperties29.Append(tableCellBorders29);

            Paragraph paragraph41 = new Paragraph() { RsidParagraphMarkRevision = "00064902", RsidParagraphAddition = "00195023", RsidParagraphProperties = "00082A3D", RsidRunAdditionDefault = "00195023" };

            ParagraphProperties paragraphProperties41 = new ParagraphProperties();
            Justification justification27 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties41 = new ParagraphMarkRunProperties();
            Bold bold97 = new Bold();
            FontSize fontSize154 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript115 = new FontSizeComplexScript() { Val = "18" };

            paragraphMarkRunProperties41.Append(bold97);
            paragraphMarkRunProperties41.Append(fontSize154);
            paragraphMarkRunProperties41.Append(fontSizeComplexScript115);

            paragraphProperties41.Append(justification27);
            paragraphProperties41.Append(paragraphMarkRunProperties41);

            Run run115 = new Run() { RsidRunProperties = "00064902" };

            RunProperties runProperties114 = new RunProperties();
            FontSize fontSize155 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript116 = new FontSizeComplexScript() { Val = "18" };

            runProperties114.Append(fontSize155);
            runProperties114.Append(fontSizeComplexScript116);
            Text text114 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text114.Text = " Согласно условиям договора поставки оборудования ";

            run115.Append(runProperties114);
            run115.Append(text114);

            Run run116 = new Run();

            RunProperties runProperties115 = new RunProperties();
            RunFonts runFonts28 = new RunFonts() { ComplexScript = "Arial" };
            BoldComplexScript boldComplexScript3 = new BoldComplexScript();
            FontSize fontSize156 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript117 = new FontSizeComplexScript() { Val = "18" };

            runProperties115.Append(runFonts28);
            runProperties115.Append(boldComplexScript3);
            runProperties115.Append(fontSize156);
            runProperties115.Append(fontSizeComplexScript117);
            Text text115 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text115.Text = "№ ";

            run116.Append(runProperties115);
            run116.Append(text115);

            Run run117 = new Run() { RsidRunAddition = "0040759A" };

            RunProperties runProperties116 = new RunProperties();
            RunFonts runFonts29 = new RunFonts() { ComplexScript = "Arial" };
            BoldComplexScript boldComplexScript4 = new BoldComplexScript();
            FontSize fontSize157 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript118 = new FontSizeComplexScript() { Val = "18" };
            Languages languages55 = new Languages() { Val = "en-US" };

            runProperties116.Append(runFonts29);
            runProperties116.Append(boldComplexScript4);
            runProperties116.Append(fontSize157);
            runProperties116.Append(fontSizeComplexScript118);
            runProperties116.Append(languages55);
            Text text116 = new Text();
            text116.Text = frm.contractNumber.Text;

            run117.Append(runProperties116);
            run117.Append(text116);

            Run run118 = new Run();

            RunProperties runProperties117 = new RunProperties();
            RunFonts runFonts30 = new RunFonts() { ComplexScript = "Arial" };
            BoldComplexScript boldComplexScript5 = new BoldComplexScript();
            FontSize fontSize158 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript119 = new FontSizeComplexScript() { Val = "18" };

            runProperties117.Append(runFonts30);
            runProperties117.Append(boldComplexScript5);
            runProperties117.Append(fontSize158);
            runProperties117.Append(fontSizeComplexScript119);
            Text text117 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text117.Text = " от ";

            run118.Append(runProperties117);
            run118.Append(text117);
            ProofError proofError33 = new ProofError() { Type = ProofingErrorValues.SpellStart };

            Run run119 = new Run() { RsidRunAddition = "0040759A" };

            RunProperties runProperties118 = new RunProperties();
            RunFonts runFonts31 = new RunFonts() { ComplexScript = "Arial" };
            BoldComplexScript boldComplexScript6 = new BoldComplexScript();
            FontSize fontSize159 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript120 = new FontSizeComplexScript() { Val = "18" };
            Languages languages56 = new Languages() { Val = "en-US" };

            runProperties118.Append(runFonts31);
            runProperties118.Append(boldComplexScript6);
            runProperties118.Append(fontSize159);
            runProperties118.Append(fontSizeComplexScript120);
            runProperties118.Append(languages56);
            Text text118 = new Text();
            text118.Text = frm.contractDate.Value.ToShortDateString();

            run119.Append(runProperties118);
            run119.Append(text118);
            ProofError proofError34 = new ProofError() { Type = ProofingErrorValues.SpellEnd };

            Run run120 = new Run();

            RunProperties runProperties119 = new RunProperties();
            RunFonts runFonts32 = new RunFonts() { ComplexScript = "Arial" };
            BoldComplexScript boldComplexScript7 = new BoldComplexScript();
            FontSize fontSize160 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript121 = new FontSizeComplexScript() { Val = "18" };

            runProperties119.Append(runFonts32);
            runProperties119.Append(boldComplexScript7);
            runProperties119.Append(fontSize160);
            runProperties119.Append(fontSizeComplexScript121);
            Text text119 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text119.Text = " г.";

            run120.Append(runProperties119);
            run120.Append(text119);

            Run run121 = new Run() { RsidRunProperties = "00064902" };

            RunProperties runProperties120 = new RunProperties();
            FontSize fontSize161 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript122 = new FontSizeComplexScript() { Val = "18" };

            runProperties120.Append(fontSize161);
            runProperties120.Append(fontSizeComplexScript122);
            Text text120 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text120.Text = "  ";

            run121.Append(runProperties120);
            run121.Append(text120);

            Run run122 = new Run() { RsidRunProperties = "00064902" };

            RunProperties runProperties121 = new RunProperties();
            Bold bold98 = new Bold();
            Italic italic1 = new Italic();
            FontSize fontSize162 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript123 = new FontSizeComplexScript() { Val = "18" };

            runProperties121.Append(bold98);
            runProperties121.Append(italic1);
            runProperties121.Append(fontSize162);
            runProperties121.Append(fontSizeComplexScript123);
            Text text121 = new Text();
            text121.Text = "(";

            run122.Append(runProperties121);
            run122.Append(text121);

            Run run123 = new Run() { RsidRunAddition = "00082A3D" };

            RunProperties runProperties122 = new RunProperties();
            Bold bold99 = new Bold();
            Italic italic2 = new Italic();
            FontSize fontSize163 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript124 = new FontSizeComplexScript() { Val = "18" };
            Languages languages57 = new Languages() { Val = "en-US" };

            runProperties122.Append(bold99);
            runProperties122.Append(italic2);
            runProperties122.Append(fontSize163);
            runProperties122.Append(fontSizeComplexScript124);
            runProperties122.Append(languages57);
            Text text122 = new Text();
            text122.Text = "OF" + frm.offerNumber.Text;

            run123.Append(runProperties122);
            run123.Append(text122);

            Run run124 = new Run() { RsidRunProperties = "00064902" };

            RunProperties runProperties123 = new RunProperties();
            Bold bold100 = new Bold();
            Italic italic3 = new Italic();
            FontSize fontSize164 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript125 = new FontSizeComplexScript() { Val = "18" };

            runProperties123.Append(bold100);
            runProperties123.Append(italic3);
            runProperties123.Append(fontSize164);
            runProperties123.Append(fontSizeComplexScript125);
            Text text123 = new Text();
            text123.Text = ")";

            run124.Append(runProperties123);
            run124.Append(text123);

            paragraph41.Append(paragraphProperties41);
            paragraph41.Append(run115);
            paragraph41.Append(run116);
            paragraph41.Append(run117);
            paragraph41.Append(run118);
            paragraph41.Append(proofError33);
            paragraph41.Append(run119);
            paragraph41.Append(proofError34);
            paragraph41.Append(run120);
            paragraph41.Append(run121);
            paragraph41.Append(run122);
            paragraph41.Append(run123);
            paragraph41.Append(run124);

            tableCell29.Append(tableCellProperties29);
            tableCell29.Append(paragraph41);

            tableRow12.Append(tableCell28);
            tableRow12.Append(tableCell29);

            TableRow tableRow13 = new TableRow() { RsidTableRowMarkRevision = "00064902", RsidTableRowAddition = "00195023", RsidTableRowProperties = "005630D3" };

            TableCell tableCell30 = new TableCell();

            TableCellProperties tableCellProperties30 = new TableCellProperties();
            TableCellWidth tableCellWidth30 = new TableCellWidth() { Width = "2799", Type = TableWidthUnitValues.Dxa };
            GridSpan gridSpan21 = new GridSpan() { Val = 2 };

            TableCellBorders tableCellBorders30 = new TableCellBorders();
            TopBorder topBorder19 = new TopBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)6U, Space = (UInt32Value)0U };
            LeftBorder leftBorder30 = new LeftBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)6U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder28 = new BottomBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)6U, Space = (UInt32Value)0U };
            RightBorder rightBorder30 = new RightBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)6U, Space = (UInt32Value)0U };

            tableCellBorders30.Append(topBorder19);
            tableCellBorders30.Append(leftBorder30);
            tableCellBorders30.Append(bottomBorder28);
            tableCellBorders30.Append(rightBorder30);

            tableCellProperties30.Append(tableCellWidth30);
            tableCellProperties30.Append(gridSpan21);
            tableCellProperties30.Append(tableCellBorders30);

            Paragraph paragraph42 = new Paragraph() { RsidParagraphMarkRevision = "00064902", RsidParagraphAddition = "00195023", RsidRunAdditionDefault = "00195023" };

            ParagraphProperties paragraphProperties42 = new ParagraphProperties();
            Justification justification28 = new Justification() { Val = JustificationValues.Center };

            ParagraphMarkRunProperties paragraphMarkRunProperties42 = new ParagraphMarkRunProperties();
            Bold bold101 = new Bold();
            FontSize fontSize165 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript126 = new FontSizeComplexScript() { Val = "18" };

            paragraphMarkRunProperties42.Append(bold101);
            paragraphMarkRunProperties42.Append(fontSize165);
            paragraphMarkRunProperties42.Append(fontSizeComplexScript126);

            paragraphProperties42.Append(justification28);
            paragraphProperties42.Append(paragraphMarkRunProperties42);

            Run run125 = new Run() { RsidRunProperties = "00064902" };

            RunProperties runProperties124 = new RunProperties();
            Bold bold102 = new Bold();
            FontSize fontSize166 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript127 = new FontSizeComplexScript() { Val = "18" };

            runProperties124.Append(bold102);
            runProperties124.Append(fontSize166);
            runProperties124.Append(fontSizeComplexScript127);
            Text text124 = new Text();
            text124.Text = "Прочие условия";

            run125.Append(runProperties124);
            run125.Append(text124);

            paragraph42.Append(paragraphProperties42);
            paragraph42.Append(run125);

            tableCell30.Append(tableCellProperties30);
            tableCell30.Append(paragraph42);

            TableCell tableCell31 = new TableCell();

            TableCellProperties tableCellProperties31 = new TableCellProperties();
            TableCellWidth tableCellWidth31 = new TableCellWidth() { Width = "7692", Type = TableWidthUnitValues.Dxa };
            GridSpan gridSpan22 = new GridSpan() { Val = 5 };

            TableCellBorders tableCellBorders31 = new TableCellBorders();
            TopBorder topBorder20 = new TopBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)6U, Space = (UInt32Value)0U };
            LeftBorder leftBorder31 = new LeftBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)6U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder29 = new BottomBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)6U, Space = (UInt32Value)0U };
            RightBorder rightBorder31 = new RightBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)6U, Space = (UInt32Value)0U };

            tableCellBorders31.Append(topBorder20);
            tableCellBorders31.Append(leftBorder31);
            tableCellBorders31.Append(bottomBorder29);
            tableCellBorders31.Append(rightBorder31);

            tableCellProperties31.Append(tableCellWidth31);
            tableCellProperties31.Append(gridSpan22);
            tableCellProperties31.Append(tableCellBorders31);

            Paragraph paragraph43 = new Paragraph() { RsidParagraphMarkRevision = "00064902", RsidParagraphAddition = "00195023", RsidParagraphProperties = "00C81DD2", RsidRunAdditionDefault = "00195023" };

            ParagraphProperties paragraphProperties43 = new ParagraphProperties();
            Justification justification29 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties43 = new ParagraphMarkRunProperties();
            FontSize fontSize167 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript128 = new FontSizeComplexScript() { Val = "18" };

            paragraphMarkRunProperties43.Append(fontSize167);
            paragraphMarkRunProperties43.Append(fontSizeComplexScript128);

            paragraphProperties43.Append(justification29);
            paragraphProperties43.Append(paragraphMarkRunProperties43);

            Run run126 = new Run() { RsidRunProperties = "000F06AD" };

            RunProperties runProperties125 = new RunProperties();
            FontSize fontSize168 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript129 = new FontSizeComplexScript() { Val = "18" };

            runProperties125.Append(fontSize168);
            runProperties125.Append(fontSizeComplexScript129);
            Text text125 = new Text();
            text125.Text = "Поставляется в разобранном виде для удобства транспортировки.";

            run126.Append(runProperties125);
            run126.Append(text125);

            paragraph43.Append(paragraphProperties43);
            paragraph43.Append(run126);

            tableCell31.Append(tableCellProperties31);
            tableCell31.Append(paragraph43);

            tableRow13.Append(tableCell30);
            tableRow13.Append(tableCell31);

            TableRow tableRow14 = new TableRow() { RsidTableRowMarkRevision = "00064902", RsidTableRowAddition = "00195023", RsidTableRowProperties = "005630D3" };

            TableCell tableCell32 = new TableCell();

            TableCellProperties tableCellProperties32 = new TableCellProperties();
            TableCellWidth tableCellWidth32 = new TableCellWidth() { Width = "2799", Type = TableWidthUnitValues.Dxa };
            GridSpan gridSpan23 = new GridSpan() { Val = 2 };

            TableCellBorders tableCellBorders32 = new TableCellBorders();
            TopBorder topBorder21 = new TopBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)6U, Space = (UInt32Value)0U };
            LeftBorder leftBorder32 = new LeftBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)6U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder30 = new BottomBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            RightBorder rightBorder32 = new RightBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)6U, Space = (UInt32Value)0U };

            tableCellBorders32.Append(topBorder21);
            tableCellBorders32.Append(leftBorder32);
            tableCellBorders32.Append(bottomBorder30);
            tableCellBorders32.Append(rightBorder32);

            tableCellProperties32.Append(tableCellWidth32);
            tableCellProperties32.Append(gridSpan23);
            tableCellProperties32.Append(tableCellBorders32);

            Paragraph paragraph44 = new Paragraph() { RsidParagraphMarkRevision = "00064902", RsidParagraphAddition = "00195023", RsidRunAdditionDefault = "00195023" };

            ParagraphProperties paragraphProperties44 = new ParagraphProperties();
            Justification justification30 = new Justification() { Val = JustificationValues.Center };

            ParagraphMarkRunProperties paragraphMarkRunProperties44 = new ParagraphMarkRunProperties();
            Bold bold103 = new Bold();
            FontSize fontSize169 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript130 = new FontSizeComplexScript() { Val = "18" };

            paragraphMarkRunProperties44.Append(bold103);
            paragraphMarkRunProperties44.Append(fontSize169);
            paragraphMarkRunProperties44.Append(fontSizeComplexScript130);

            paragraphProperties44.Append(justification30);
            paragraphProperties44.Append(paragraphMarkRunProperties44);

            Run run127 = new Run() { RsidRunProperties = "00064902" };

            RunProperties runProperties126 = new RunProperties();
            Bold bold104 = new Bold();
            FontSize fontSize170 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript131 = new FontSizeComplexScript() { Val = "18" };

            runProperties126.Append(bold104);
            runProperties126.Append(fontSize170);
            runProperties126.Append(fontSizeComplexScript131);
            Text text126 = new Text();
            text126.Text = "Получатель";

            run127.Append(runProperties126);
            run127.Append(text126);

            paragraph44.Append(paragraphProperties44);
            paragraph44.Append(run127);

            tableCell32.Append(tableCellProperties32);
            tableCell32.Append(paragraph44);

            TableCell tableCell33 = new TableCell();

            TableCellProperties tableCellProperties33 = new TableCellProperties();
            TableCellWidth tableCellWidth33 = new TableCellWidth() { Width = "7692", Type = TableWidthUnitValues.Dxa };
            GridSpan gridSpan24 = new GridSpan() { Val = 5 };

            TableCellBorders tableCellBorders33 = new TableCellBorders();
            TopBorder topBorder22 = new TopBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)6U, Space = (UInt32Value)0U };
            LeftBorder leftBorder33 = new LeftBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)6U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder31 = new BottomBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            RightBorder rightBorder33 = new RightBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)6U, Space = (UInt32Value)0U };

            tableCellBorders33.Append(topBorder22);
            tableCellBorders33.Append(leftBorder33);
            tableCellBorders33.Append(bottomBorder31);
            tableCellBorders33.Append(rightBorder33);
            TableCellVerticalAlignment tableCellVerticalAlignment12 = new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Bottom };

            tableCellProperties33.Append(tableCellWidth33);
            tableCellProperties33.Append(gridSpan24);
            tableCellProperties33.Append(tableCellBorders33);
            tableCellProperties33.Append(tableCellVerticalAlignment12);

            Paragraph paragraph45 = new Paragraph() { RsidParagraphMarkRevision = "00EE352A", RsidParagraphAddition = "00195023", RsidRunAdditionDefault = "00195023" };

            ParagraphProperties paragraphProperties45 = new ParagraphProperties();
            ParagraphStyleId paragraphStyleId14 = new ParagraphStyleId() { Val = "a3" };
            Indentation indentation14 = new Indentation() { FirstLine = "0" };
            Justification justification31 = new Justification() { Val = JustificationValues.Left };

            ParagraphMarkRunProperties paragraphMarkRunProperties45 = new ParagraphMarkRunProperties();
            FontSize fontSize171 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript132 = new FontSizeComplexScript() { Val = "18" };
            Languages languages58 = new Languages() { Val = "ru-RU", EastAsia = "ru-RU" };

            paragraphMarkRunProperties45.Append(fontSize171);
            paragraphMarkRunProperties45.Append(fontSizeComplexScript132);
            paragraphMarkRunProperties45.Append(languages58);

            paragraphProperties45.Append(paragraphStyleId14);
            paragraphProperties45.Append(indentation14);
            paragraphProperties45.Append(justification31);
            paragraphProperties45.Append(paragraphMarkRunProperties45);

            Run run128 = new Run() { RsidRunProperties = "00EE352A" };

            RunProperties runProperties127 = new RunProperties();
            RunFonts runFonts33 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Bold bold105 = new Bold();
            FontSize fontSize172 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript133 = new FontSizeComplexScript() { Val = "18" };
            Languages languages59 = new Languages() { Val = "ru-RU", EastAsia = "ru-RU" };

            runProperties127.Append(runFonts33);
            runProperties127.Append(bold105);
            runProperties127.Append(fontSize172);
            runProperties127.Append(fontSizeComplexScript133);
            runProperties127.Append(languages59);
            Text text127 = new Text();
            text127.Text = "ООО \"";

            run128.Append(runProperties127);
            run128.Append(text127);
            ProofError proofError35 = new ProofError() { Type = ProofingErrorValues.SpellStart };

            Run run129 = new Run() { RsidRunProperties = "00EE352A" };

            RunProperties runProperties128 = new RunProperties();
            RunFonts runFonts34 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Bold bold106 = new Bold();
            FontSize fontSize173 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript134 = new FontSizeComplexScript() { Val = "18" };
            Languages languages60 = new Languages() { Val = "ru-RU", EastAsia = "ru-RU" };

            runProperties128.Append(runFonts34);
            runProperties128.Append(bold106);
            runProperties128.Append(fontSize173);
            runProperties128.Append(fontSizeComplexScript134);
            runProperties128.Append(languages60);
            Text text128 = new Text();
            text128.Text = "Разек";

            run129.Append(runProperties128);
            run129.Append(text128);
            ProofError proofError36 = new ProofError() { Type = ProofingErrorValues.SpellEnd };

            Run run130 = new Run() { RsidRunProperties = "00EE352A" };

            RunProperties runProperties129 = new RunProperties();
            RunFonts runFonts35 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Bold bold107 = new Bold();
            FontSize fontSize174 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript135 = new FontSizeComplexScript() { Val = "18" };
            Languages languages61 = new Languages() { Val = "ru-RU", EastAsia = "ru-RU" };

            runProperties129.Append(runFonts35);
            runProperties129.Append(bold107);
            runProperties129.Append(fontSize174);
            runProperties129.Append(fontSizeComplexScript135);
            runProperties129.Append(languages61);
            Text text129 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text129.Text = "-Восток\", ";

            run130.Append(runProperties129);
            run130.Append(text129);

            Run run131 = new Run() { RsidRunProperties = "00EE352A" };

            RunProperties runProperties130 = new RunProperties();
            RunFonts runFonts36 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize175 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript136 = new FontSizeComplexScript() { Val = "18" };
            Languages languages62 = new Languages() { Val = "ru-RU", EastAsia = "ru-RU" };

            runProperties130.Append(runFonts36);
            runProperties130.Append(fontSize175);
            runProperties130.Append(fontSizeComplexScript136);
            runProperties130.Append(languages62);
            Text text130 = new Text();
            text130.Text = "Россия, г. Москва,";

            run131.Append(runProperties130);
            run131.Append(text130);

            Run run132 = new Run() { RsidRunProperties = "00EE352A" };

            RunProperties runProperties131 = new RunProperties();
            RunFonts runFonts37 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Bold bold108 = new Bold();
            FontSize fontSize176 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript137 = new FontSizeComplexScript() { Val = "18" };
            Languages languages63 = new Languages() { Val = "ru-RU", EastAsia = "ru-RU" };

            runProperties131.Append(runFonts37);
            runProperties131.Append(bold108);
            runProperties131.Append(fontSize176);
            runProperties131.Append(fontSizeComplexScript137);
            runProperties131.Append(languages63);
            Text text131 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text131.Text = " ";

            run132.Append(runProperties131);
            run132.Append(text131);
            ProofError proofError37 = new ProofError() { Type = ProofingErrorValues.SpellStart };

            Run run133 = new Run() { RsidRunProperties = "00EE352A" };

            RunProperties runProperties132 = new RunProperties();
            RunFonts runFonts38 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize177 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript138 = new FontSizeComplexScript() { Val = "18" };
            Languages languages64 = new Languages() { Val = "ru-RU", EastAsia = "ru-RU" };

            runProperties132.Append(runFonts38);
            runProperties132.Append(fontSize177);
            runProperties132.Append(fontSizeComplexScript138);
            runProperties132.Append(languages64);
            Text text132 = new Text();
            text132.Text = "Балакиревский";

            run133.Append(runProperties132);
            run133.Append(text132);
            ProofError proofError38 = new ProofError() { Type = ProofingErrorValues.SpellEnd };

            Run run134 = new Run() { RsidRunProperties = "00EE352A" };

            RunProperties runProperties133 = new RunProperties();
            RunFonts runFonts39 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize178 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript139 = new FontSizeComplexScript() { Val = "18" };
            Languages languages65 = new Languages() { Val = "ru-RU", EastAsia = "ru-RU" };

            runProperties133.Append(runFonts39);
            runProperties133.Append(fontSize178);
            runProperties133.Append(fontSizeComplexScript139);
            runProperties133.Append(languages65);
            Text text133 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text133.Text = " пер., д.1 А, оф. 4";

            run134.Append(runProperties133);
            run134.Append(text133);

            paragraph45.Append(paragraphProperties45);
            paragraph45.Append(run128);
            paragraph45.Append(proofError35);
            paragraph45.Append(run129);
            paragraph45.Append(proofError36);
            paragraph45.Append(run130);
            paragraph45.Append(run131);
            paragraph45.Append(run132);
            paragraph45.Append(proofError37);
            paragraph45.Append(run133);
            paragraph45.Append(proofError38);
            paragraph45.Append(run134);

            tableCell33.Append(tableCellProperties33);
            tableCell33.Append(paragraph45);

            tableRow14.Append(tableCell32);
            tableRow14.Append(tableCell33);

            TableRow tableRow15 = new TableRow() { RsidTableRowMarkRevision = "00064902", RsidTableRowAddition = "00195023", RsidTableRowProperties = "005630D3" };

            TableRowProperties tableRowProperties5 = new TableRowProperties();
            CantSplit cantSplit3 = new CantSplit();

            tableRowProperties5.Append(cantSplit3);

            TableCell tableCell34 = new TableCell();

            TableCellProperties tableCellProperties34 = new TableCellProperties();
            TableCellWidth tableCellWidth34 = new TableCellWidth() { Width = "2799", Type = TableWidthUnitValues.Dxa };
            GridSpan gridSpan25 = new GridSpan() { Val = 2 };
            VerticalMerge verticalMerge1 = new VerticalMerge() { Val = MergedCellValues.Restart };

            TableCellBorders tableCellBorders34 = new TableCellBorders();
            LeftBorder leftBorder34 = new LeftBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder32 = new BottomBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            RightBorder rightBorder34 = new RightBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };

            tableCellBorders34.Append(leftBorder34);
            tableCellBorders34.Append(bottomBorder32);
            tableCellBorders34.Append(rightBorder34);

            tableCellProperties34.Append(tableCellWidth34);
            tableCellProperties34.Append(gridSpan25);
            tableCellProperties34.Append(verticalMerge1);
            tableCellProperties34.Append(tableCellBorders34);

            Paragraph paragraph46 = new Paragraph() { RsidParagraphMarkRevision = "00064902", RsidParagraphAddition = "00195023", RsidRunAdditionDefault = "00195023" };

            ParagraphProperties paragraphProperties46 = new ParagraphProperties();
            Justification justification32 = new Justification() { Val = JustificationValues.Center };

            ParagraphMarkRunProperties paragraphMarkRunProperties46 = new ParagraphMarkRunProperties();
            Bold bold109 = new Bold();
            FontSize fontSize179 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript140 = new FontSizeComplexScript() { Val = "18" };

            paragraphMarkRunProperties46.Append(bold109);
            paragraphMarkRunProperties46.Append(fontSize179);
            paragraphMarkRunProperties46.Append(fontSizeComplexScript140);

            paragraphProperties46.Append(justification32);
            paragraphProperties46.Append(paragraphMarkRunProperties46);

            paragraph46.Append(paragraphProperties46);

            tableCell34.Append(tableCellProperties34);
            tableCell34.Append(paragraph46);

            TableCell tableCell35 = new TableCell();

            TableCellProperties tableCellProperties35 = new TableCellProperties();
            TableCellWidth tableCellWidth35 = new TableCellWidth() { Width = "7692", Type = TableWidthUnitValues.Dxa };
            GridSpan gridSpan26 = new GridSpan() { Val = 5 };

            TableCellBorders tableCellBorders35 = new TableCellBorders();
            LeftBorder leftBorder35 = new LeftBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder33 = new BottomBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            RightBorder rightBorder35 = new RightBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };

            tableCellBorders35.Append(leftBorder35);
            tableCellBorders35.Append(bottomBorder33);
            tableCellBorders35.Append(rightBorder35);

            tableCellProperties35.Append(tableCellWidth35);
            tableCellProperties35.Append(gridSpan26);
            tableCellProperties35.Append(tableCellBorders35);

            Paragraph paragraph47 = new Paragraph() { RsidParagraphMarkRevision = "00064902", RsidParagraphAddition = "00195023", RsidRunAdditionDefault = "00195023" };

            ParagraphProperties paragraphProperties47 = new ParagraphProperties();
            Justification justification33 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties47 = new ParagraphMarkRunProperties();
            Bold bold110 = new Bold();
            FontSize fontSize180 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript141 = new FontSizeComplexScript() { Val = "18" };

            paragraphMarkRunProperties47.Append(bold110);
            paragraphMarkRunProperties47.Append(fontSize180);
            paragraphMarkRunProperties47.Append(fontSizeComplexScript141);

            paragraphProperties47.Append(justification33);
            paragraphProperties47.Append(paragraphMarkRunProperties47);

            Run run135 = new Run() { RsidRunProperties = "00064902" };

            RunProperties runProperties134 = new RunProperties();
            Bold bold111 = new Bold();
            FontSize fontSize181 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript142 = new FontSizeComplexScript() { Val = "18" };

            runProperties134.Append(bold111);
            runProperties134.Append(fontSize181);
            runProperties134.Append(fontSizeComplexScript142);
            Text text134 = new Text();
            text134.Text = "Оплату произвести по реквизитам:";

            run135.Append(runProperties134);
            run135.Append(text134);

            paragraph47.Append(paragraphProperties47);
            paragraph47.Append(run135);

            tableCell35.Append(tableCellProperties35);
            tableCell35.Append(paragraph47);

            tableRow15.Append(tableRowProperties5);
            tableRow15.Append(tableCell34);
            tableRow15.Append(tableCell35);

            TableRow tableRow16 = new TableRow() { RsidTableRowMarkRevision = "00793308", RsidTableRowAddition = "00195023", RsidTableRowProperties = "005630D3" };

            TableRowProperties tableRowProperties6 = new TableRowProperties();
            CantSplit cantSplit4 = new CantSplit();
            TableRowHeight tableRowHeight5 = new TableRowHeight() { Val = (UInt32Value)1804U };

            tableRowProperties6.Append(cantSplit4);
            tableRowProperties6.Append(tableRowHeight5);

            TableCell tableCell36 = new TableCell();

            TableCellProperties tableCellProperties36 = new TableCellProperties();
            TableCellWidth tableCellWidth36 = new TableCellWidth() { Width = "2799", Type = TableWidthUnitValues.Dxa };
            GridSpan gridSpan27 = new GridSpan() { Val = 2 };
            VerticalMerge verticalMerge2 = new VerticalMerge();

            TableCellBorders tableCellBorders36 = new TableCellBorders();
            TopBorder topBorder23 = new TopBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            LeftBorder leftBorder36 = new LeftBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder34 = new BottomBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            RightBorder rightBorder36 = new RightBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };

            tableCellBorders36.Append(topBorder23);
            tableCellBorders36.Append(leftBorder36);
            tableCellBorders36.Append(bottomBorder34);
            tableCellBorders36.Append(rightBorder36);

            tableCellProperties36.Append(tableCellWidth36);
            tableCellProperties36.Append(gridSpan27);
            tableCellProperties36.Append(verticalMerge2);
            tableCellProperties36.Append(tableCellBorders36);

            Paragraph paragraph48 = new Paragraph() { RsidParagraphMarkRevision = "00064902", RsidParagraphAddition = "00195023", RsidRunAdditionDefault = "00195023" };

            ParagraphProperties paragraphProperties48 = new ParagraphProperties();
            Justification justification34 = new Justification() { Val = JustificationValues.Center };

            ParagraphMarkRunProperties paragraphMarkRunProperties48 = new ParagraphMarkRunProperties();
            Bold bold112 = new Bold();
            FontSize fontSize182 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript143 = new FontSizeComplexScript() { Val = "18" };

            paragraphMarkRunProperties48.Append(bold112);
            paragraphMarkRunProperties48.Append(fontSize182);
            paragraphMarkRunProperties48.Append(fontSizeComplexScript143);

            paragraphProperties48.Append(justification34);
            paragraphProperties48.Append(paragraphMarkRunProperties48);

            paragraph48.Append(paragraphProperties48);

            tableCell36.Append(tableCellProperties36);
            tableCell36.Append(paragraph48);

            TableCell tableCell37 = new TableCell();

            TableCellProperties tableCellProperties37 = new TableCellProperties();
            TableCellWidth tableCellWidth37 = new TableCellWidth() { Width = "7692", Type = TableWidthUnitValues.Dxa };
            GridSpan gridSpan28 = new GridSpan() { Val = 5 };

            TableCellBorders tableCellBorders37 = new TableCellBorders();
            TopBorder topBorder24 = new TopBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            LeftBorder leftBorder37 = new LeftBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder35 = new BottomBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            RightBorder rightBorder37 = new RightBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };

            tableCellBorders37.Append(topBorder24);
            tableCellBorders37.Append(leftBorder37);
            tableCellBorders37.Append(bottomBorder35);
            tableCellBorders37.Append(rightBorder37);

            tableCellProperties37.Append(tableCellWidth37);
            tableCellProperties37.Append(gridSpan28);
            tableCellProperties37.Append(tableCellBorders37);

            Paragraph paragraph49 = new Paragraph() { RsidParagraphMarkRevision = "00064902", RsidParagraphAddition = "00195023", RsidParagraphProperties = "00BA3E61", RsidRunAdditionDefault = "00195023" };

            ParagraphProperties paragraphProperties49 = new ParagraphProperties();
            Indentation indentation15 = new Indentation() { Start = "34" };
            Justification justification35 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties49 = new ParagraphMarkRunProperties();
            FontSize fontSize183 = new FontSize() { Val = "16" };
            FontSizeComplexScript fontSizeComplexScript144 = new FontSizeComplexScript() { Val = "16" };

            paragraphMarkRunProperties49.Append(fontSize183);
            paragraphMarkRunProperties49.Append(fontSizeComplexScript144);

            paragraphProperties49.Append(indentation15);
            paragraphProperties49.Append(justification35);
            paragraphProperties49.Append(paragraphMarkRunProperties49);

            Run run136 = new Run() { RsidRunProperties = "00064902" };

            RunProperties runProperties135 = new RunProperties();
            FontSize fontSize184 = new FontSize() { Val = "16" };
            FontSizeComplexScript fontSizeComplexScript145 = new FontSizeComplexScript() { Val = "16" };

            runProperties135.Append(fontSize184);
            runProperties135.Append(fontSizeComplexScript145);
            Text text135 = new Text();
            text135.Text = "Получатель и его счёт:";

            run136.Append(runProperties135);
            run136.Append(text135);

            paragraph49.Append(paragraphProperties49);
            paragraph49.Append(run136);

            Paragraph paragraph50 = new Paragraph() { RsidParagraphMarkRevision = "007B5DEC", RsidParagraphAddition = "00195023", RsidParagraphProperties = "001D5D69", RsidRunAdditionDefault = "00195023" };

            ParagraphProperties paragraphProperties50 = new ParagraphProperties();
            Justification justification36 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties50 = new ParagraphMarkRunProperties();
            RunFonts runFonts40 = new RunFonts() { ComplexScript = "Arial" };
            Bold bold113 = new Bold();
            FontSize fontSize185 = new FontSize() { Val = "18" };

            paragraphMarkRunProperties50.Append(runFonts40);
            paragraphMarkRunProperties50.Append(bold113);
            paragraphMarkRunProperties50.Append(fontSize185);

            paragraphProperties50.Append(justification36);
            paragraphProperties50.Append(paragraphMarkRunProperties50);

            Run run137 = new Run() { RsidRunProperties = "007B5DEC" };

            RunProperties runProperties136 = new RunProperties();
            RunFonts runFonts41 = new RunFonts() { ComplexScript = "Arial" };
            Bold bold114 = new Bold();
            FontSize fontSize186 = new FontSize() { Val = "18" };

            runProperties136.Append(runFonts41);
            runProperties136.Append(bold114);
            runProperties136.Append(fontSize186);
            Text text136 = new Text();
            text136.Text = "ООО “";

            run137.Append(runProperties136);
            run137.Append(text136);
            ProofError proofError39 = new ProofError() { Type = ProofingErrorValues.SpellStart };

            Run run138 = new Run() { RsidRunProperties = "007B5DEC" };

            RunProperties runProperties137 = new RunProperties();
            RunFonts runFonts42 = new RunFonts() { ComplexScript = "Arial" };
            Bold bold115 = new Bold();
            FontSize fontSize187 = new FontSize() { Val = "18" };

            runProperties137.Append(runFonts42);
            runProperties137.Append(bold115);
            runProperties137.Append(fontSize187);
            Text text137 = new Text();
            text137.Text = "Разек";

            run138.Append(runProperties137);
            run138.Append(text137);
            ProofError proofError40 = new ProofError() { Type = ProofingErrorValues.SpellEnd };

            Run run139 = new Run() { RsidRunProperties = "007B5DEC" };

            RunProperties runProperties138 = new RunProperties();
            RunFonts runFonts43 = new RunFonts() { ComplexScript = "Arial" };
            Bold bold116 = new Bold();
            FontSize fontSize188 = new FontSize() { Val = "18" };

            runProperties138.Append(runFonts43);
            runProperties138.Append(bold116);
            runProperties138.Append(fontSize188);
            Text text138 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text138.Text = " Черкассы”";

            run139.Append(runProperties138);
            run139.Append(text138);

            paragraph50.Append(paragraphProperties50);
            paragraph50.Append(run137);
            paragraph50.Append(proofError39);
            paragraph50.Append(run138);
            paragraph50.Append(proofError40);
            paragraph50.Append(run139);

            Paragraph paragraph51 = new Paragraph() { RsidParagraphMarkRevision = "007B5DEC", RsidParagraphAddition = "00195023", RsidParagraphProperties = "001D5D69", RsidRunAdditionDefault = "00195023" };

            ParagraphProperties paragraphProperties51 = new ParagraphProperties();

            ParagraphMarkRunProperties paragraphMarkRunProperties51 = new ParagraphMarkRunProperties();
            FontSize fontSize189 = new FontSize() { Val = "18" };

            paragraphMarkRunProperties51.Append(fontSize189);

            paragraphProperties51.Append(paragraphMarkRunProperties51);

            Run run140 = new Run() { RsidRunProperties = "007B5DEC" };

            RunProperties runProperties139 = new RunProperties();
            RunFonts runFonts44 = new RunFonts() { ComplexScript = "Arial" };
            Bold bold117 = new Bold();
            FontSize fontSize190 = new FontSize() { Val = "18" };

            runProperties139.Append(runFonts44);
            runProperties139.Append(bold117);
            runProperties139.Append(fontSize190);
            Text text139 = new Text();
            text139.Text = "Адрес юридический";

            run140.Append(runProperties139);
            run140.Append(text139);

            Run run141 = new Run() { RsidRunProperties = "007B5DEC" };

            RunProperties runProperties140 = new RunProperties();
            FontSize fontSize191 = new FontSize() { Val = "18" };

            runProperties140.Append(fontSize191);
            Text text140 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text140.Text = ": Украина, 18018, Черкассы, проспект Химиков 74 ";

            run141.Append(runProperties140);
            run141.Append(text140);

            paragraph51.Append(paragraphProperties51);
            paragraph51.Append(run140);
            paragraph51.Append(run141);

            Paragraph paragraph52 = new Paragraph() { RsidParagraphMarkRevision = "001D5D69", RsidParagraphAddition = "00195023", RsidParagraphProperties = "001D5D69", RsidRunAdditionDefault = "00195023" };

            ParagraphProperties paragraphProperties52 = new ParagraphProperties();

            ParagraphMarkRunProperties paragraphMarkRunProperties52 = new ParagraphMarkRunProperties();
            FontSize fontSize192 = new FontSize() { Val = "18" };

            paragraphMarkRunProperties52.Append(fontSize192);

            paragraphProperties52.Append(paragraphMarkRunProperties52);

            Run run142 = new Run() { RsidRunProperties = "007B5DEC" };

            RunProperties runProperties141 = new RunProperties();
            RunFonts runFonts45 = new RunFonts() { ComplexScript = "Arial" };
            Bold bold118 = new Bold();
            FontSize fontSize193 = new FontSize() { Val = "18" };

            runProperties141.Append(runFonts45);
            runProperties141.Append(bold118);
            runProperties141.Append(fontSize193);
            Text text141 = new Text();
            text141.Text = "Код ЕДРПОУ";

            run142.Append(runProperties141);
            run142.Append(text141);

            Run run143 = new Run() { RsidRunProperties = "007B5DEC" };

            RunProperties runProperties142 = new RunProperties();
            FontSize fontSize194 = new FontSize() { Val = "18" };

            runProperties142.Append(fontSize194);
            Text text142 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text142.Text = ": ";

            run143.Append(runProperties142);
            run143.Append(text142);

            Run run144 = new Run() { RsidRunProperties = "007B5DEC" };

            RunProperties runProperties143 = new RunProperties();
            FontSize fontSize195 = new FontSize() { Val = "18" };
            Languages languages66 = new Languages() { Val = "uk-UA" };

            runProperties143.Append(fontSize195);
            runProperties143.Append(languages66);
            Text text143 = new Text();
            text143.Text = "36299742";

            run144.Append(runProperties143);
            run144.Append(text143);

            paragraph52.Append(paragraphProperties52);
            paragraph52.Append(run142);
            paragraph52.Append(run143);
            paragraph52.Append(run144);

            Paragraph paragraph53 = new Paragraph() { RsidParagraphMarkRevision = "007B5DEC", RsidParagraphAddition = "00195023", RsidParagraphProperties = "001D5D69", RsidRunAdditionDefault = "00195023" };

            ParagraphProperties paragraphProperties53 = new ParagraphProperties();

            ParagraphMarkRunProperties paragraphMarkRunProperties53 = new ParagraphMarkRunProperties();
            RunFonts runFonts46 = new RunFonts() { ComplexScript = "Arial" };
            BoldComplexScript boldComplexScript8 = new BoldComplexScript();
            FontSize fontSize196 = new FontSize() { Val = "18" };

            paragraphMarkRunProperties53.Append(runFonts46);
            paragraphMarkRunProperties53.Append(boldComplexScript8);
            paragraphMarkRunProperties53.Append(fontSize196);

            paragraphProperties53.Append(paragraphMarkRunProperties53);

            Run run145 = new Run() { RsidRunProperties = "007B5DEC" };

            RunProperties runProperties144 = new RunProperties();
            RunFonts runFonts47 = new RunFonts() { ComplexScript = "Arial" };
            Bold bold119 = new Bold();
            FontSize fontSize197 = new FontSize() { Val = "18" };

            runProperties144.Append(runFonts47);
            runProperties144.Append(bold119);
            runProperties144.Append(fontSize197);
            Text text144 = new Text();
            text144.Text = "Банковские реквизиты";

            run145.Append(runProperties144);
            run145.Append(text144);

            Run run146 = new Run() { RsidRunProperties = "007B5DEC" };

            RunProperties runProperties145 = new RunProperties();
            RunFonts runFonts48 = new RunFonts() { ComplexScript = "Arial" };
            BoldComplexScript boldComplexScript9 = new BoldComplexScript();
            FontSize fontSize198 = new FontSize() { Val = "18" };

            runProperties145.Append(runFonts48);
            runProperties145.Append(boldComplexScript9);
            runProperties145.Append(fontSize198);
            Text text145 = new Text();
            text145.Text = ":";

            run146.Append(runProperties145);
            run146.Append(text145);

            paragraph53.Append(paragraphProperties53);
            paragraph53.Append(run145);
            paragraph53.Append(run146);

            Paragraph paragraph54 = new Paragraph() { RsidParagraphMarkRevision = "007B5DEC", RsidParagraphAddition = "00195023", RsidParagraphProperties = "001D5D69", RsidRunAdditionDefault = "00195023" };

            ParagraphProperties paragraphProperties54 = new ParagraphProperties();

            ParagraphMarkRunProperties paragraphMarkRunProperties54 = new ParagraphMarkRunProperties();
            FontSize fontSize199 = new FontSize() { Val = "18" };

            paragraphMarkRunProperties54.Append(fontSize199);

            paragraphProperties54.Append(paragraphMarkRunProperties54);

            Run run147 = new Run() { RsidRunProperties = "007B5DEC" };

            RunProperties runProperties146 = new RunProperties();
            FontSize fontSize200 = new FontSize() { Val = "18" };

            runProperties146.Append(fontSize200);
            Text text146 = new Text();
            text146.Text = "Банк-корреспондент:";

            run147.Append(runProperties146);
            run147.Append(text146);

            paragraph54.Append(paragraphProperties54);
            paragraph54.Append(run147);

            Paragraph paragraph55 = new Paragraph() { RsidParagraphMarkRevision = "001D5D69", RsidParagraphAddition = "00195023", RsidParagraphProperties = "001D5D69", RsidRunAdditionDefault = "00195023" };

            ParagraphProperties paragraphProperties55 = new ParagraphProperties();

            ParagraphMarkRunProperties paragraphMarkRunProperties55 = new ParagraphMarkRunProperties();
            FontSize fontSize201 = new FontSize() { Val = "18" };
            Languages languages67 = new Languages() { Val = "en-US" };

            paragraphMarkRunProperties55.Append(fontSize201);
            paragraphMarkRunProperties55.Append(languages67);

            paragraphProperties55.Append(paragraphMarkRunProperties55);

            Run run148 = new Run() { RsidRunProperties = "001D5D69" };

            RunProperties runProperties147 = new RunProperties();
            FontSize fontSize202 = new FontSize() { Val = "18" };
            Languages languages68 = new Languages() { Val = "en-US" };

            runProperties147.Append(fontSize202);
            runProperties147.Append(languages68);
            Text text147 = new Text();
            text147.Text = "Commerzbank";

            run148.Append(runProperties147);
            run148.Append(text147);

            paragraph55.Append(paragraphProperties55);
            paragraph55.Append(run148);

            Paragraph paragraph56 = new Paragraph() { RsidParagraphMarkRevision = "001D5D69", RsidParagraphAddition = "00195023", RsidParagraphProperties = "001D5D69", RsidRunAdditionDefault = "00195023" };

            ParagraphProperties paragraphProperties56 = new ParagraphProperties();

            ParagraphMarkRunProperties paragraphMarkRunProperties56 = new ParagraphMarkRunProperties();
            RunFonts runFonts49 = new RunFonts() { ComplexScript = "Arial" };
            FontSize fontSize203 = new FontSize() { Val = "18" };
            Languages languages69 = new Languages() { Val = "en-US" };

            paragraphMarkRunProperties56.Append(runFonts49);
            paragraphMarkRunProperties56.Append(fontSize203);
            paragraphMarkRunProperties56.Append(languages69);

            paragraphProperties56.Append(paragraphMarkRunProperties56);

            Run run149 = new Run() { RsidRunProperties = "001D5D69" };

            RunProperties runProperties148 = new RunProperties();
            FontSize fontSize204 = new FontSize() { Val = "18" };
            Languages languages70 = new Languages() { Val = "en-US" };

            runProperties148.Append(fontSize204);
            runProperties148.Append(languages70);
            Text text148 = new Text();
            text148.Text = "Frankfurt am Main, Germany";

            run149.Append(runProperties148);
            run149.Append(text148);

            Run run150 = new Run() { RsidRunProperties = "001D5D69" };

            RunProperties runProperties149 = new RunProperties();
            FontSize fontSize205 = new FontSize() { Val = "18" };
            Languages languages71 = new Languages() { Val = "en-US" };

            runProperties149.Append(fontSize205);
            runProperties149.Append(languages71);
            Break break1 = new Break();
            Text text149 = new Text();
            text149.Text = "SWIFT CODE: COBADEFF";

            run150.Append(runProperties149);
            run150.Append(break1);
            run150.Append(text149);

            paragraph56.Append(paragraphProperties56);
            paragraph56.Append(run149);
            paragraph56.Append(run150);

            Paragraph paragraph57 = new Paragraph() { RsidParagraphMarkRevision = "00A46D18", RsidParagraphAddition = "00195023", RsidParagraphProperties = "001D5D69", RsidRunAdditionDefault = "00195023" };

            ParagraphProperties paragraphProperties57 = new ParagraphProperties();

            ParagraphMarkRunProperties paragraphMarkRunProperties57 = new ParagraphMarkRunProperties();
            Bold bold120 = new Bold();
            FontSize fontSize206 = new FontSize() { Val = "18" };

            paragraphMarkRunProperties57.Append(bold120);
            paragraphMarkRunProperties57.Append(fontSize206);

            paragraphProperties57.Append(paragraphMarkRunProperties57);

            Run run151 = new Run() { RsidRunProperties = "007B5DEC" };

            RunProperties runProperties150 = new RunProperties();
            Bold bold121 = new Bold();
            FontSize fontSize207 = new FontSize() { Val = "18" };

            runProperties150.Append(bold121);
            runProperties150.Append(fontSize207);
            Text text150 = new Text();
            text150.Text = "Банк";

            run151.Append(runProperties150);
            run151.Append(text150);

            Run run152 = new Run() { RsidRunProperties = "00A46D18" };

            RunProperties runProperties151 = new RunProperties();
            Bold bold122 = new Bold();
            FontSize fontSize208 = new FontSize() { Val = "18" };

            runProperties151.Append(bold122);
            runProperties151.Append(fontSize208);
            Text text151 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text151.Text = " ";

            run152.Append(runProperties151);
            run152.Append(text151);

            Run run153 = new Run() { RsidRunProperties = "007B5DEC" };

            RunProperties runProperties152 = new RunProperties();
            Bold bold123 = new Bold();
            FontSize fontSize209 = new FontSize() { Val = "18" };

            runProperties152.Append(bold123);
            runProperties152.Append(fontSize209);
            Text text152 = new Text();
            text152.Text = "получателя";

            run153.Append(runProperties152);
            run153.Append(text152);

            Run run154 = new Run() { RsidRunProperties = "00A46D18" };

            RunProperties runProperties153 = new RunProperties();
            Bold bold124 = new Bold();
            FontSize fontSize210 = new FontSize() { Val = "18" };

            runProperties153.Append(bold124);
            runProperties153.Append(fontSize210);
            Text text153 = new Text();
            text153.Text = ":";

            run154.Append(runProperties153);
            run154.Append(text153);

            paragraph57.Append(paragraphProperties57);
            paragraph57.Append(run151);
            paragraph57.Append(run152);
            paragraph57.Append(run153);
            paragraph57.Append(run154);

            Paragraph paragraph58 = new Paragraph() { RsidParagraphMarkRevision = "00A46D18", RsidParagraphAddition = "00195023", RsidParagraphProperties = "001D5D69", RsidRunAdditionDefault = "00195023" };

            ParagraphProperties paragraphProperties58 = new ParagraphProperties();

            ParagraphMarkRunProperties paragraphMarkRunProperties58 = new ParagraphMarkRunProperties();
            FontSize fontSize211 = new FontSize() { Val = "18" };

            paragraphMarkRunProperties58.Append(fontSize211);

            paragraphProperties58.Append(paragraphMarkRunProperties58);

            Run run155 = new Run() { RsidRunProperties = "007B5DEC" };

            RunProperties runProperties154 = new RunProperties();
            FontSize fontSize212 = new FontSize() { Val = "18" };

            runProperties154.Append(fontSize212);
            Text text154 = new Text();
            text154.Text = "РJSC";

            run155.Append(runProperties154);
            run155.Append(text154);

            Run run156 = new Run() { RsidRunProperties = "00A46D18" };

            RunProperties runProperties155 = new RunProperties();
            FontSize fontSize213 = new FontSize() { Val = "18" };

            runProperties155.Append(fontSize213);
            Text text155 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text155.Text = " «";

            run156.Append(runProperties155);
            run156.Append(text155);
            ProofError proofError41 = new ProofError() { Type = ProofingErrorValues.SpellStart };

            Run run157 = new Run() { RsidRunProperties = "007B5DEC" };

            RunProperties runProperties156 = new RunProperties();
            FontSize fontSize214 = new FontSize() { Val = "18" };

            runProperties156.Append(fontSize214);
            Text text156 = new Text();
            text156.Text = "Bank";

            run157.Append(runProperties156);
            run157.Append(text156);
            ProofError proofError42 = new ProofError() { Type = ProofingErrorValues.SpellEnd };

            Run run158 = new Run() { RsidRunProperties = "00A46D18" };

            RunProperties runProperties157 = new RunProperties();
            FontSize fontSize215 = new FontSize() { Val = "18" };

            runProperties157.Append(fontSize215);
            Text text157 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text157.Text = " ";

            run158.Append(runProperties157);
            run158.Append(text157);
            ProofError proofError43 = new ProofError() { Type = ProofingErrorValues.SpellStart };

            Run run159 = new Run() { RsidRunProperties = "007B5DEC" };

            RunProperties runProperties158 = new RunProperties();
            FontSize fontSize216 = new FontSize() { Val = "18" };

            runProperties158.Append(fontSize216);
            Text text158 = new Text();
            text158.Text = "Vostok";

            run159.Append(runProperties158);
            run159.Append(text158);
            ProofError proofError44 = new ProofError() { Type = ProofingErrorValues.SpellEnd };

            Run run160 = new Run() { RsidRunProperties = "00A46D18" };

            RunProperties runProperties159 = new RunProperties();
            FontSize fontSize217 = new FontSize() { Val = "18" };

            runProperties159.Append(fontSize217);
            Text text159 = new Text();
            text159.Text = "»,";

            run160.Append(runProperties159);
            run160.Append(text159);

            paragraph58.Append(paragraphProperties58);
            paragraph58.Append(run155);
            paragraph58.Append(run156);
            paragraph58.Append(proofError41);
            paragraph58.Append(run157);
            paragraph58.Append(proofError42);
            paragraph58.Append(run158);
            paragraph58.Append(proofError43);
            paragraph58.Append(run159);
            paragraph58.Append(proofError44);
            paragraph58.Append(run160);

            Paragraph paragraph59 = new Paragraph() { RsidParagraphMarkRevision = "001D5D69", RsidParagraphAddition = "00195023", RsidParagraphProperties = "001D5D69", RsidRunAdditionDefault = "00195023" };

            ParagraphProperties paragraphProperties59 = new ParagraphProperties();

            ParagraphMarkRunProperties paragraphMarkRunProperties59 = new ParagraphMarkRunProperties();
            FontSize fontSize218 = new FontSize() { Val = "18" };
            Languages languages72 = new Languages() { Val = "en-US" };

            paragraphMarkRunProperties59.Append(fontSize218);
            paragraphMarkRunProperties59.Append(languages72);

            paragraphProperties59.Append(paragraphMarkRunProperties59);

            Run run161 = new Run() { RsidRunProperties = "001D5D69" };

            RunProperties runProperties160 = new RunProperties();
            FontSize fontSize219 = new FontSize() { Val = "18" };
            Languages languages73 = new Languages() { Val = "en-US" };

            runProperties160.Append(fontSize219);
            runProperties160.Append(languages73);
            Text text160 = new Text();
            text160.Text = "Dnepropetrovsk, Ukraine";

            run161.Append(runProperties160);
            run161.Append(text160);

            paragraph59.Append(paragraphProperties59);
            paragraph59.Append(run161);

            Paragraph paragraph60 = new Paragraph() { RsidParagraphMarkRevision = "00905DAC", RsidParagraphAddition = "00195023", RsidParagraphProperties = "001D5D69", RsidRunAdditionDefault = "00195023" };

            ParagraphProperties paragraphProperties60 = new ParagraphProperties();

            ParagraphMarkRunProperties paragraphMarkRunProperties60 = new ParagraphMarkRunProperties();
            FontSize fontSize220 = new FontSize() { Val = "18" };
            Languages languages74 = new Languages() { Val = "en-US" };

            paragraphMarkRunProperties60.Append(fontSize220);
            paragraphMarkRunProperties60.Append(languages74);

            paragraphProperties60.Append(paragraphMarkRunProperties60);

            Run run162 = new Run() { RsidRunProperties = "001D5D69" };

            RunProperties runProperties161 = new RunProperties();
            FontSize fontSize221 = new FontSize() { Val = "18" };
            Languages languages75 = new Languages() { Val = "en-US" };

            runProperties161.Append(fontSize221);
            runProperties161.Append(languages75);
            Text text161 = new Text();
            text161.Text = "SWIFT CODE: ACJCUA2N";

            run162.Append(runProperties161);
            run162.Append(text161);

            paragraph60.Append(paragraphProperties60);
            paragraph60.Append(run162);

            Paragraph paragraph61 = new Paragraph() { RsidParagraphMarkRevision = "001D5D69", RsidParagraphAddition = "00195023", RsidParagraphProperties = "001D5D69", RsidRunAdditionDefault = "00195023" };

            ParagraphProperties paragraphProperties61 = new ParagraphProperties();

            ParagraphMarkRunProperties paragraphMarkRunProperties61 = new ParagraphMarkRunProperties();
            Bold bold125 = new Bold();
            FontSize fontSize222 = new FontSize() { Val = "18" };
            Languages languages76 = new Languages() { Val = "en-US" };

            paragraphMarkRunProperties61.Append(bold125);
            paragraphMarkRunProperties61.Append(fontSize222);
            paragraphMarkRunProperties61.Append(languages76);

            paragraphProperties61.Append(paragraphMarkRunProperties61);

            Run run163 = new Run() { RsidRunProperties = "007B5DEC" };

            RunProperties runProperties162 = new RunProperties();
            Bold bold126 = new Bold();
            FontSize fontSize223 = new FontSize() { Val = "18" };

            runProperties162.Append(bold126);
            runProperties162.Append(fontSize223);
            Text text162 = new Text();
            text162.Text = "Получатель";

            run163.Append(runProperties162);
            run163.Append(text162);

            Run run164 = new Run() { RsidRunProperties = "001D5D69" };

            RunProperties runProperties163 = new RunProperties();
            Bold bold127 = new Bold();
            FontSize fontSize224 = new FontSize() { Val = "18" };
            Languages languages77 = new Languages() { Val = "en-US" };

            runProperties163.Append(bold127);
            runProperties163.Append(fontSize224);
            runProperties163.Append(languages77);
            Text text163 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text163.Text = " ";

            run164.Append(runProperties163);
            run164.Append(text163);

            paragraph61.Append(paragraphProperties61);
            paragraph61.Append(run163);
            paragraph61.Append(run164);

            Paragraph paragraph62 = new Paragraph() { RsidParagraphMarkRevision = "001D5D69", RsidParagraphAddition = "00195023", RsidParagraphProperties = "001D5D69", RsidRunAdditionDefault = "00195023" };

            ParagraphProperties paragraphProperties62 = new ParagraphProperties();

            ParagraphMarkRunProperties paragraphMarkRunProperties62 = new ParagraphMarkRunProperties();
            FontSize fontSize225 = new FontSize() { Val = "18" };
            Languages languages78 = new Languages() { Val = "en-US" };

            paragraphMarkRunProperties62.Append(fontSize225);
            paragraphMarkRunProperties62.Append(languages78);

            paragraphProperties62.Append(paragraphMarkRunProperties62);

            Run run165 = new Run() { RsidRunProperties = "001D5D69" };

            RunProperties runProperties164 = new RunProperties();
            FontSize fontSize226 = new FontSize() { Val = "18" };
            Languages languages79 = new Languages() { Val = "en-US" };

            runProperties164.Append(fontSize226);
            runProperties164.Append(languages79);
            Text text164 = new Text();
            text164.Text = "Account N26008010193962";

            run165.Append(runProperties164);
            run165.Append(text164);

            paragraph62.Append(paragraphProperties62);
            paragraph62.Append(run165);

            Paragraph paragraph63 = new Paragraph() { RsidParagraphMarkRevision = "001D5D69", RsidParagraphAddition = "00195023", RsidParagraphProperties = "001D5D69", RsidRunAdditionDefault = "00195023" };

            ParagraphProperties paragraphProperties63 = new ParagraphProperties();

            ParagraphMarkRunProperties paragraphMarkRunProperties63 = new ParagraphMarkRunProperties();
            FontSize fontSize227 = new FontSize() { Val = "18" };
            Languages languages80 = new Languages() { Val = "en-US" };

            paragraphMarkRunProperties63.Append(fontSize227);
            paragraphMarkRunProperties63.Append(languages80);

            paragraphProperties63.Append(paragraphMarkRunProperties63);

            Run run166 = new Run() { RsidRunProperties = "001D5D69" };

            RunProperties runProperties165 = new RunProperties();
            FontSize fontSize228 = new FontSize() { Val = "18" };
            Languages languages81 = new Languages() { Val = "en-US" };

            runProperties165.Append(fontSize228);
            runProperties165.Append(languages81);
            Text text165 = new Text();
            text165.Text = "“";

            run166.Append(runProperties165);
            run166.Append(text165);
            ProofError proofError45 = new ProofError() { Type = ProofingErrorValues.SpellStart };

            Run run167 = new Run() { RsidRunProperties = "001D5D69" };

            RunProperties runProperties166 = new RunProperties();
            FontSize fontSize229 = new FontSize() { Val = "18" };
            Languages languages82 = new Languages() { Val = "en-US" };

            runProperties166.Append(fontSize229);
            runProperties166.Append(languages82);
            Text text166 = new Text();
            text166.Text = "Rasec";

            run167.Append(runProperties166);
            run167.Append(text166);
            ProofError proofError46 = new ProofError() { Type = ProofingErrorValues.SpellEnd };

            Run run168 = new Run() { RsidRunProperties = "001D5D69" };

            RunProperties runProperties167 = new RunProperties();
            FontSize fontSize230 = new FontSize() { Val = "18" };
            Languages languages83 = new Languages() { Val = "en-US" };

            runProperties167.Append(fontSize230);
            runProperties167.Append(languages83);
            Text text167 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text167.Text = " ";

            run168.Append(runProperties167);
            run168.Append(text167);
            ProofError proofError47 = new ProofError() { Type = ProofingErrorValues.SpellStart };

            Run run169 = new Run() { RsidRunProperties = "001D5D69" };

            RunProperties runProperties168 = new RunProperties();
            FontSize fontSize231 = new FontSize() { Val = "18" };
            Languages languages84 = new Languages() { Val = "en-US" };

            runProperties168.Append(fontSize231);
            runProperties168.Append(languages84);
            Text text168 = new Text();
            text168.Text = "Cerkasy";

            run169.Append(runProperties168);
            run169.Append(text168);
            ProofError proofError48 = new ProofError() { Type = ProofingErrorValues.SpellEnd };

            Run run170 = new Run() { RsidRunProperties = "001D5D69" };

            RunProperties runProperties169 = new RunProperties();
            FontSize fontSize232 = new FontSize() { Val = "18" };
            Languages languages85 = new Languages() { Val = "en-US" };

            runProperties169.Append(fontSize232);
            runProperties169.Append(languages85);
            Text text169 = new Text();
            text169.Text = "” LLC";

            run170.Append(runProperties169);
            run170.Append(text169);

            paragraph63.Append(paragraphProperties63);
            paragraph63.Append(run166);
            paragraph63.Append(proofError45);
            paragraph63.Append(run167);
            paragraph63.Append(proofError46);
            paragraph63.Append(run168);
            paragraph63.Append(proofError47);
            paragraph63.Append(run169);
            paragraph63.Append(proofError48);
            paragraph63.Append(run170);

            Paragraph paragraph64 = new Paragraph() { RsidParagraphMarkRevision = "00905DAC", RsidParagraphAddition = "00195023", RsidParagraphProperties = "001D5D69", RsidRunAdditionDefault = "00195023" };

            ParagraphProperties paragraphProperties64 = new ParagraphProperties();

            ParagraphMarkRunProperties paragraphMarkRunProperties64 = new ParagraphMarkRunProperties();
            FontSize fontSize233 = new FontSize() { Val = "18" };
            Languages languages86 = new Languages() { Val = "en-US" };

            paragraphMarkRunProperties64.Append(fontSize233);
            paragraphMarkRunProperties64.Append(languages86);

            paragraphProperties64.Append(paragraphMarkRunProperties64);
            ProofError proofError49 = new ProofError() { Type = ProofingErrorValues.SpellStart };

            Run run171 = new Run() { RsidRunProperties = "001D5D69" };

            RunProperties runProperties170 = new RunProperties();
            FontSize fontSize234 = new FontSize() { Val = "18" };
            Languages languages87 = new Languages() { Val = "en-US" };

            runProperties170.Append(fontSize234);
            runProperties170.Append(languages87);
            Text text170 = new Text();
            text170.Text = "Cerkasy";

            run171.Append(runProperties170);
            run171.Append(text170);
            ProofError proofError50 = new ProofError() { Type = ProofingErrorValues.SpellEnd };

            Run run172 = new Run() { RsidRunProperties = "001D5D69" };

            RunProperties runProperties171 = new RunProperties();
            FontSize fontSize235 = new FontSize() { Val = "18" };
            Languages languages88 = new Languages() { Val = "en-US" };

            runProperties171.Append(fontSize235);
            runProperties171.Append(languages88);
            Text text171 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text171.Text = " , Ukraine";

            run172.Append(runProperties171);
            run172.Append(text171);

            paragraph64.Append(paragraphProperties64);
            paragraph64.Append(proofError49);
            paragraph64.Append(run171);
            paragraph64.Append(proofError50);
            paragraph64.Append(run172);

            tableCell37.Append(tableCellProperties37);
            tableCell37.Append(paragraph49);
            tableCell37.Append(paragraph50);
            tableCell37.Append(paragraph51);
            tableCell37.Append(paragraph52);
            tableCell37.Append(paragraph53);
            tableCell37.Append(paragraph54);
            tableCell37.Append(paragraph55);
            tableCell37.Append(paragraph56);
            tableCell37.Append(paragraph57);
            tableCell37.Append(paragraph58);
            tableCell37.Append(paragraph59);
            tableCell37.Append(paragraph60);
            tableCell37.Append(paragraph61);
            tableCell37.Append(paragraph62);
            tableCell37.Append(paragraph63);
            tableCell37.Append(paragraph64);

            tableRow16.Append(tableRowProperties6);
            tableRow16.Append(tableCell36);
            tableRow16.Append(tableCell37);

            table1.Append(tableProperties1);
            table1.Append(tableGrid1);
            table1.Append(tableRow1);
            table1.Append(tableRow2);
            table1.Append(tableRow3);
            table1.Append(tableRow4);
            table1.Append(tableRow5);
            table1.Append(tableRow6);
            table1.Append(tableRow7);
            table1.Append(tableRow8);
            table1.Append(tableRow9);
            table1.Append(tableRow10);
            table1.Append(tableRow11);
            table1.Append(tableRow12);
            table1.Append(tableRow13);
            table1.Append(tableRow14);
            table1.Append(tableRow15);
            table1.Append(tableRow16);

            Paragraph paragraph65 = new Paragraph() { RsidParagraphMarkRevision = "001D5D69", RsidParagraphAddition = "00487986", RsidParagraphProperties = "006171C3", RsidRunAdditionDefault = "00487986" };

            ParagraphProperties paragraphProperties65 = new ParagraphProperties();
            Justification justification37 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties65 = new ParagraphMarkRunProperties();
            Languages languages89 = new Languages() { Val = "en-US" };

            paragraphMarkRunProperties65.Append(languages89);

            paragraphProperties65.Append(justification37);
            paragraphProperties65.Append(paragraphMarkRunProperties65);

            paragraph65.Append(paragraphProperties65);

            Paragraph paragraph66 = new Paragraph() { RsidParagraphMarkRevision = "001D5D69", RsidParagraphAddition = "00075819", RsidParagraphProperties = "006171C3", RsidRunAdditionDefault = "00075819" };

            ParagraphProperties paragraphProperties66 = new ParagraphProperties();
            Justification justification38 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties66 = new ParagraphMarkRunProperties();
            Languages languages90 = new Languages() { Val = "en-US" };

            paragraphMarkRunProperties66.Append(languages90);

            paragraphProperties66.Append(justification38);
            paragraphProperties66.Append(paragraphMarkRunProperties66);

            paragraph66.Append(paragraphProperties66);

            Paragraph paragraph67 = new Paragraph() { RsidParagraphMarkRevision = "001D5D69", RsidParagraphAddition = "00075819", RsidParagraphProperties = "006171C3", RsidRunAdditionDefault = "00075819" };

            ParagraphProperties paragraphProperties67 = new ParagraphProperties();
            Justification justification39 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties67 = new ParagraphMarkRunProperties();
            Languages languages91 = new Languages() { Val = "en-US" };

            paragraphMarkRunProperties67.Append(languages91);

            paragraphProperties67.Append(justification39);
            paragraphProperties67.Append(paragraphMarkRunProperties67);

            paragraph67.Append(paragraphProperties67);

            Paragraph paragraph68 = new Paragraph() { RsidParagraphMarkRevision = "001D5D69", RsidParagraphAddition = "00075819", RsidParagraphProperties = "006171C3", RsidRunAdditionDefault = "00075819" };

            ParagraphProperties paragraphProperties68 = new ParagraphProperties();
            Justification justification40 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties68 = new ParagraphMarkRunProperties();
            Languages languages92 = new Languages() { Val = "en-US" };

            paragraphMarkRunProperties68.Append(languages92);

            paragraphProperties68.Append(justification40);
            paragraphProperties68.Append(paragraphMarkRunProperties68);

            paragraph68.Append(paragraphProperties68);

            Table table2 = new Table();

            TableProperties tableProperties2 = new TableProperties();
            TableWidth tableWidth2 = new TableWidth() { Width = "0", Type = TableWidthUnitValues.Auto };
            TableIndentation tableIndentation2 = new TableIndentation() { Width = 959, Type = TableWidthUnitValues.Dxa };
            TableLook tableLook2 = new TableLook() { Val = "01E0" };

            tableProperties2.Append(tableWidth2);
            tableProperties2.Append(tableIndentation2);
            tableProperties2.Append(tableLook2);

            TableGrid tableGrid2 = new TableGrid();
            GridColumn gridColumn8 = new GridColumn() { Width = "3176" };
            GridColumn gridColumn9 = new GridColumn() { Width = "4177" };

            tableGrid2.Append(gridColumn8);
            tableGrid2.Append(gridColumn9);

            TableRow tableRow17 = new TableRow() { RsidTableRowMarkRevision = "00064902", RsidTableRowAddition = "00483103" };

            TableRowProperties tableRowProperties7 = new TableRowProperties();
            TableRowHeight tableRowHeight6 = new TableRowHeight() { Val = (UInt32Value)497U };

            tableRowProperties7.Append(tableRowHeight6);

            TableCell tableCell38 = new TableCell();

            TableCellProperties tableCellProperties38 = new TableCellProperties();
            TableCellWidth tableCellWidth38 = new TableCellWidth() { Width = "3305", Type = TableWidthUnitValues.Dxa };

            tableCellProperties38.Append(tableCellWidth38);

            Paragraph paragraph69 = new Paragraph() { RsidParagraphMarkRevision = "00064902", RsidParagraphAddition = "00483103", RsidParagraphProperties = "006C0B40", RsidRunAdditionDefault = "00483103" };

            ParagraphProperties paragraphProperties69 = new ParagraphProperties();
            Justification justification41 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties69 = new ParagraphMarkRunProperties();
            RunFonts runFonts50 = new RunFonts() { ComplexScript = "Arial" };
            BoldComplexScript boldComplexScript10 = new BoldComplexScript();
            FontSize fontSize236 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript146 = new FontSizeComplexScript() { Val = "18" };

            paragraphMarkRunProperties69.Append(runFonts50);
            paragraphMarkRunProperties69.Append(boldComplexScript10);
            paragraphMarkRunProperties69.Append(fontSize236);
            paragraphMarkRunProperties69.Append(fontSizeComplexScript146);

            paragraphProperties69.Append(justification41);
            paragraphProperties69.Append(paragraphMarkRunProperties69);

            Run run173 = new Run() { RsidRunProperties = "00064902" };

            RunProperties runProperties172 = new RunProperties();
            RunFonts runFonts51 = new RunFonts() { ComplexScript = "Arial" };
            BoldComplexScript boldComplexScript11 = new BoldComplexScript();
            FontSize fontSize237 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript147 = new FontSizeComplexScript() { Val = "18" };

            runProperties172.Append(runFonts51);
            runProperties172.Append(boldComplexScript11);
            runProperties172.Append(fontSize237);
            runProperties172.Append(fontSizeComplexScript147);
            Text text172 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text172.Text = "Генеральный директор                               ";

            run173.Append(runProperties172);
            run173.Append(text172);

            paragraph69.Append(paragraphProperties69);
            paragraph69.Append(run173);

            tableCell38.Append(tableCellProperties38);
            tableCell38.Append(paragraph69);

            TableCell tableCell39 = new TableCell();

            TableCellProperties tableCellProperties39 = new TableCellProperties();
            TableCellWidth tableCellWidth39 = new TableCellWidth() { Width = "4264", Type = TableWidthUnitValues.Dxa };

            tableCellProperties39.Append(tableCellWidth39);

            Paragraph paragraph70 = new Paragraph() { RsidParagraphMarkRevision = "00064902", RsidParagraphAddition = "00483103", RsidParagraphProperties = "006C0B40", RsidRunAdditionDefault = "00483103" };

            ParagraphProperties paragraphProperties70 = new ParagraphProperties();
            Justification justification42 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties70 = new ParagraphMarkRunProperties();
            RunFonts runFonts52 = new RunFonts() { ComplexScript = "Arial" };
            BoldComplexScript boldComplexScript12 = new BoldComplexScript();
            FontSize fontSize238 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript148 = new FontSizeComplexScript() { Val = "18" };

            paragraphMarkRunProperties70.Append(runFonts52);
            paragraphMarkRunProperties70.Append(boldComplexScript12);
            paragraphMarkRunProperties70.Append(fontSize238);
            paragraphMarkRunProperties70.Append(fontSizeComplexScript148);

            paragraphProperties70.Append(justification42);
            paragraphProperties70.Append(paragraphMarkRunProperties70);

            Run run174 = new Run() { RsidRunProperties = "00064902" };

            RunProperties runProperties173 = new RunProperties();
            RunFonts runFonts53 = new RunFonts() { ComplexScript = "Arial" };
            FontSize fontSize239 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript149 = new FontSizeComplexScript() { Val = "18" };

            runProperties173.Append(runFonts53);
            runProperties173.Append(fontSize239);
            runProperties173.Append(fontSizeComplexScript149);
            Text text173 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text173.Text = "                      Марк Рауль Огюст Сандре";

            run174.Append(runProperties173);
            run174.Append(text173);

            paragraph70.Append(paragraphProperties70);
            paragraph70.Append(run174);

            tableCell39.Append(tableCellProperties39);
            tableCell39.Append(paragraph70);

            tableRow17.Append(tableRowProperties7);
            tableRow17.Append(tableCell38);
            tableRow17.Append(tableCell39);

            TableRow tableRow18 = new TableRow() { RsidTableRowMarkRevision = "00064902", RsidTableRowAddition = "00487986" };

            TableRowProperties tableRowProperties8 = new TableRowProperties();
            TableRowHeight tableRowHeight7 = new TableRowHeight() { Val = (UInt32Value)286U };

            tableRowProperties8.Append(tableRowHeight7);

            TableCell tableCell40 = new TableCell();

            TableCellProperties tableCellProperties40 = new TableCellProperties();
            TableCellWidth tableCellWidth40 = new TableCellWidth() { Width = "3305", Type = TableWidthUnitValues.Dxa };

            tableCellProperties40.Append(tableCellWidth40);

            Paragraph paragraph71 = new Paragraph() { RsidParagraphMarkRevision = "00064902", RsidParagraphAddition = "006A67EE", RsidParagraphProperties = "00D27020", RsidRunAdditionDefault = "006A67EE" };

            ParagraphProperties paragraphProperties71 = new ParagraphProperties();
            Indentation indentation16 = new Indentation() { End = "-335" };
            Justification justification43 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties71 = new ParagraphMarkRunProperties();
            FontSize fontSize240 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript150 = new FontSizeComplexScript() { Val = "18" };

            paragraphMarkRunProperties71.Append(fontSize240);
            paragraphMarkRunProperties71.Append(fontSizeComplexScript150);

            paragraphProperties71.Append(indentation16);
            paragraphProperties71.Append(justification43);
            paragraphProperties71.Append(paragraphMarkRunProperties71);

            paragraph71.Append(paragraphProperties71);

            Paragraph paragraph72 = new Paragraph() { RsidParagraphMarkRevision = "00064902", RsidParagraphAddition = "006A67EE", RsidParagraphProperties = "00D27020", RsidRunAdditionDefault = "006A67EE" };

            ParagraphProperties paragraphProperties72 = new ParagraphProperties();
            Indentation indentation17 = new Indentation() { End = "-335" };
            Justification justification44 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties72 = new ParagraphMarkRunProperties();
            FontSize fontSize241 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript151 = new FontSizeComplexScript() { Val = "18" };

            paragraphMarkRunProperties72.Append(fontSize241);
            paragraphMarkRunProperties72.Append(fontSizeComplexScript151);

            paragraphProperties72.Append(indentation17);
            paragraphProperties72.Append(justification44);
            paragraphProperties72.Append(paragraphMarkRunProperties72);

            paragraph72.Append(paragraphProperties72);

            Paragraph paragraph73 = new Paragraph() { RsidParagraphMarkRevision = "00064902", RsidParagraphAddition = "00D27020", RsidParagraphProperties = "00D27020", RsidRunAdditionDefault = "00487986" };

            ParagraphProperties paragraphProperties73 = new ParagraphProperties();
            Indentation indentation18 = new Indentation() { End = "-335" };
            Justification justification45 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties73 = new ParagraphMarkRunProperties();
            FontSize fontSize242 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript152 = new FontSizeComplexScript() { Val = "18" };

            paragraphMarkRunProperties73.Append(fontSize242);
            paragraphMarkRunProperties73.Append(fontSizeComplexScript152);

            paragraphProperties73.Append(indentation18);
            paragraphProperties73.Append(justification45);
            paragraphProperties73.Append(paragraphMarkRunProperties73);

            Run run175 = new Run() { RsidRunProperties = "00064902" };

            RunProperties runProperties174 = new RunProperties();
            FontSize fontSize243 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript153 = new FontSizeComplexScript() { Val = "18" };

            runProperties174.Append(fontSize243);
            runProperties174.Append(fontSizeComplexScript153);
            Text text174 = new Text();
            text174.Text = "Главны";

            run175.Append(runProperties174);
            run175.Append(text174);

            Run run176 = new Run() { RsidRunProperties = "00064902", RsidRunAddition = "00D27020" };

            RunProperties runProperties175 = new RunProperties();
            FontSize fontSize244 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript154 = new FontSizeComplexScript() { Val = "18" };

            runProperties175.Append(fontSize244);
            runProperties175.Append(fontSizeComplexScript154);
            Text text175 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text175.Text = "й бухгалтер          ";

            run176.Append(runProperties175);
            run176.Append(text175);

            paragraph73.Append(paragraphProperties73);
            paragraph73.Append(run175);
            paragraph73.Append(run176);

            Paragraph paragraph74 = new Paragraph() { RsidParagraphMarkRevision = "00064902", RsidParagraphAddition = "00487986", RsidParagraphProperties = "00D27020", RsidRunAdditionDefault = "00487986" };

            ParagraphProperties paragraphProperties74 = new ParagraphProperties();
            Justification justification46 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties74 = new ParagraphMarkRunProperties();
            FontSize fontSize245 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript155 = new FontSizeComplexScript() { Val = "18" };

            paragraphMarkRunProperties74.Append(fontSize245);
            paragraphMarkRunProperties74.Append(fontSizeComplexScript155);

            paragraphProperties74.Append(justification46);
            paragraphProperties74.Append(paragraphMarkRunProperties74);

            Run run177 = new Run() { RsidRunProperties = "00064902" };

            RunProperties runProperties176 = new RunProperties();
            FontSize fontSize246 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript156 = new FontSizeComplexScript() { Val = "18" };

            runProperties176.Append(fontSize246);
            runProperties176.Append(fontSizeComplexScript156);
            Text text176 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text176.Text = "                                    ";

            run177.Append(runProperties176);
            run177.Append(text176);

            paragraph74.Append(paragraphProperties74);
            paragraph74.Append(run177);

            tableCell40.Append(tableCellProperties40);
            tableCell40.Append(paragraph71);
            tableCell40.Append(paragraph72);
            tableCell40.Append(paragraph73);
            tableCell40.Append(paragraph74);

            TableCell tableCell41 = new TableCell();

            TableCellProperties tableCellProperties41 = new TableCellProperties();
            TableCellWidth tableCellWidth41 = new TableCellWidth() { Width = "4264", Type = TableWidthUnitValues.Dxa };

            tableCellProperties41.Append(tableCellWidth41);

            Paragraph paragraph75 = new Paragraph() { RsidParagraphMarkRevision = "00064902", RsidParagraphAddition = "006A67EE", RsidParagraphProperties = "00D27020", RsidRunAdditionDefault = "006A67EE" };

            ParagraphProperties paragraphProperties75 = new ParagraphProperties();
            Indentation indentation19 = new Indentation() { Start = "1973", End = "-335", Hanging = "992" };
            Justification justification47 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties75 = new ParagraphMarkRunProperties();
            FontSize fontSize247 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript157 = new FontSizeComplexScript() { Val = "18" };

            paragraphMarkRunProperties75.Append(fontSize247);
            paragraphMarkRunProperties75.Append(fontSizeComplexScript157);

            paragraphProperties75.Append(indentation19);
            paragraphProperties75.Append(justification47);
            paragraphProperties75.Append(paragraphMarkRunProperties75);

            paragraph75.Append(paragraphProperties75);

            Paragraph paragraph76 = new Paragraph() { RsidParagraphMarkRevision = "00064902", RsidParagraphAddition = "006A67EE", RsidParagraphProperties = "00D27020", RsidRunAdditionDefault = "006A67EE" };

            ParagraphProperties paragraphProperties76 = new ParagraphProperties();
            Indentation indentation20 = new Indentation() { Start = "1973", End = "-335", Hanging = "992" };
            Justification justification48 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties76 = new ParagraphMarkRunProperties();
            FontSize fontSize248 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript158 = new FontSizeComplexScript() { Val = "18" };

            paragraphMarkRunProperties76.Append(fontSize248);
            paragraphMarkRunProperties76.Append(fontSizeComplexScript158);

            paragraphProperties76.Append(indentation20);
            paragraphProperties76.Append(justification48);
            paragraphProperties76.Append(paragraphMarkRunProperties76);

            paragraph76.Append(paragraphProperties76);

            Paragraph paragraph77 = new Paragraph() { RsidParagraphMarkRevision = "00064902", RsidParagraphAddition = "00BA3E61", RsidParagraphProperties = "00D27020", RsidRunAdditionDefault = "00D27020" };

            ParagraphProperties paragraphProperties77 = new ParagraphProperties();
            Indentation indentation21 = new Indentation() { Start = "1973", End = "-335", Hanging = "992" };
            Justification justification49 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties77 = new ParagraphMarkRunProperties();
            FontSize fontSize249 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript159 = new FontSizeComplexScript() { Val = "18" };

            paragraphMarkRunProperties77.Append(fontSize249);
            paragraphMarkRunProperties77.Append(fontSizeComplexScript159);

            paragraphProperties77.Append(indentation21);
            paragraphProperties77.Append(justification49);
            paragraphProperties77.Append(paragraphMarkRunProperties77);

            Run run178 = new Run() { RsidRunProperties = "00064902" };

            RunProperties runProperties177 = new RunProperties();
            FontSize fontSize250 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript160 = new FontSizeComplexScript() { Val = "18" };

            runProperties177.Append(fontSize250);
            runProperties177.Append(fontSizeComplexScript160);
            Text text177 = new Text();
            text177.Text = "А.А. Бражник";

            run178.Append(runProperties177);
            run178.Append(text177);

            Run run179 = new Run() { RsidRunProperties = "00064902", RsidRunAddition = "00AD6AD5" };

            RunProperties runProperties178 = new RunProperties();
            FontSize fontSize251 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript161 = new FontSizeComplexScript() { Val = "18" };

            runProperties178.Append(fontSize251);
            runProperties178.Append(fontSizeComplexScript161);
            Text text178 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text178.Text = " ";

            run179.Append(runProperties178);
            run179.Append(text178);

            paragraph77.Append(paragraphProperties77);
            paragraph77.Append(run178);
            paragraph77.Append(run179);

            Paragraph paragraph78 = new Paragraph() { RsidParagraphMarkRevision = "00064902", RsidParagraphAddition = "00BA3E61", RsidParagraphProperties = "006C0B40", RsidRunAdditionDefault = "00BA3E61" };

            ParagraphProperties paragraphProperties78 = new ParagraphProperties();
            Indentation indentation22 = new Indentation() { Start = "1973", End = "-335" };
            Justification justification50 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties78 = new ParagraphMarkRunProperties();
            FontSize fontSize252 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript162 = new FontSizeComplexScript() { Val = "18" };

            paragraphMarkRunProperties78.Append(fontSize252);
            paragraphMarkRunProperties78.Append(fontSizeComplexScript162);

            paragraphProperties78.Append(indentation22);
            paragraphProperties78.Append(justification50);
            paragraphProperties78.Append(paragraphMarkRunProperties78);

            paragraph78.Append(paragraphProperties78);

            Paragraph paragraph79 = new Paragraph() { RsidParagraphMarkRevision = "00064902", RsidParagraphAddition = "00487986", RsidParagraphProperties = "00D27020", RsidRunAdditionDefault = "00487986" };

            ParagraphProperties paragraphProperties79 = new ParagraphProperties();
            Indentation indentation23 = new Indentation() { End = "-335" };
            Justification justification51 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties79 = new ParagraphMarkRunProperties();
            FontSize fontSize253 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript163 = new FontSizeComplexScript() { Val = "18" };

            paragraphMarkRunProperties79.Append(fontSize253);
            paragraphMarkRunProperties79.Append(fontSizeComplexScript163);

            paragraphProperties79.Append(indentation23);
            paragraphProperties79.Append(justification51);
            paragraphProperties79.Append(paragraphMarkRunProperties79);

            paragraph79.Append(paragraphProperties79);

            tableCell41.Append(tableCellProperties41);
            tableCell41.Append(paragraph75);
            tableCell41.Append(paragraph76);
            tableCell41.Append(paragraph77);
            tableCell41.Append(paragraph78);
            tableCell41.Append(paragraph79);

            tableRow18.Append(tableRowProperties8);
            tableRow18.Append(tableCell40);
            tableRow18.Append(tableCell41);

            table2.Append(tableProperties2);
            table2.Append(tableGrid2);
            table2.Append(tableRow17);
            table2.Append(tableRow18);

            Paragraph paragraph80 = new Paragraph() { RsidParagraphMarkRevision = "00064902", RsidParagraphAddition = "00487986", RsidParagraphProperties = "00AD6AD5", RsidRunAdditionDefault = "00487986" };

            ParagraphProperties paragraphProperties80 = new ParagraphProperties();
            Justification justification52 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties80 = new ParagraphMarkRunProperties();
            FontSize fontSize254 = new FontSize() { Val = "24" };
            FontSizeComplexScript fontSizeComplexScript164 = new FontSizeComplexScript() { Val = "24" };

            paragraphMarkRunProperties80.Append(fontSize254);
            paragraphMarkRunProperties80.Append(fontSizeComplexScript164);

            paragraphProperties80.Append(justification52);
            paragraphProperties80.Append(paragraphMarkRunProperties80);

            paragraph80.Append(paragraphProperties80);

            SectionProperties sectionProperties1 = new SectionProperties() { RsidRPr = "00064902", RsidR = "00487986", RsidSect = "00075819" };
            PageSize pageSize1 = new PageSize() { Width = (UInt32Value)11906U, Height = (UInt32Value)16838U };
            PageMargin pageMargin1 = new PageMargin() { Top = 709, Right = (UInt32Value)1797U, Bottom = 142, Left = (UInt32Value)1797U, Header = (UInt32Value)720U, Footer = (UInt32Value)720U, Gutter = (UInt32Value)0U };
            Columns columns1 = new Columns() { Space = "720" };

            sectionProperties1.Append(pageSize1);
            sectionProperties1.Append(pageMargin1);
            sectionProperties1.Append(columns1);

            body1.Append(table1);
            body1.Append(paragraph65);
            body1.Append(paragraph66);
            body1.Append(paragraph67);
            body1.Append(paragraph68);
            body1.Append(table2);
            body1.Append(paragraph80);
            body1.Append(sectionProperties1);

            document1.Append(body1);

            mainDocumentPart1.Document = document1;
        }

        // Generates content of styleDefinitionsPart1.
        private void GenerateStyleDefinitionsPart1Content(StyleDefinitionsPart styleDefinitionsPart1)
        {
            Styles styles1 = new Styles() { MCAttributes = new MarkupCompatibilityAttributes() { Ignorable = "w14 w15" } };
            styles1.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            styles1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            styles1.AddNamespaceDeclaration("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
            styles1.AddNamespaceDeclaration("w14", "http://schemas.microsoft.com/office/word/2010/wordml");
            styles1.AddNamespaceDeclaration("w15", "http://schemas.microsoft.com/office/word/2012/wordml");

            DocDefaults docDefaults1 = new DocDefaults();

            RunPropertiesDefault runPropertiesDefault1 = new RunPropertiesDefault();

            RunPropertiesBaseStyle runPropertiesBaseStyle1 = new RunPropertiesBaseStyle();
            RunFonts runFonts54 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman", EastAsia = "Times New Roman", ComplexScript = "Times New Roman" };
            Languages languages93 = new Languages() { Val = "ru-RU", EastAsia = "ru-RU", Bidi = "ar-SA" };

            runPropertiesBaseStyle1.Append(runFonts54);
            runPropertiesBaseStyle1.Append(languages93);

            runPropertiesDefault1.Append(runPropertiesBaseStyle1);
            ParagraphPropertiesDefault paragraphPropertiesDefault1 = new ParagraphPropertiesDefault();

            docDefaults1.Append(runPropertiesDefault1);
            docDefaults1.Append(paragraphPropertiesDefault1);

            LatentStyles latentStyles1 = new LatentStyles() { DefaultLockedState = false, DefaultUiPriority = 0, DefaultSemiHidden = false, DefaultUnhideWhenUsed = false, DefaultPrimaryStyle = false, Count = 371 };
            LatentStyleExceptionInfo latentStyleExceptionInfo1 = new LatentStyleExceptionInfo() { Name = "Normal", PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo2 = new LatentStyleExceptionInfo() { Name = "heading 1", PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo3 = new LatentStyleExceptionInfo() { Name = "heading 2", PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo4 = new LatentStyleExceptionInfo() { Name = "heading 3", PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo5 = new LatentStyleExceptionInfo() { Name = "heading 4", PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo6 = new LatentStyleExceptionInfo() { Name = "heading 5", PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo7 = new LatentStyleExceptionInfo() { Name = "heading 6", PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo8 = new LatentStyleExceptionInfo() { Name = "heading 7", PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo9 = new LatentStyleExceptionInfo() { Name = "heading 8", PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo10 = new LatentStyleExceptionInfo() { Name = "heading 9", PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo11 = new LatentStyleExceptionInfo() { Name = "caption", SemiHidden = true, UnhideWhenUsed = true, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo12 = new LatentStyleExceptionInfo() { Name = "Title", PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo13 = new LatentStyleExceptionInfo() { Name = "Subtitle", PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo14 = new LatentStyleExceptionInfo() { Name = "Strong", PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo15 = new LatentStyleExceptionInfo() { Name = "Emphasis", PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo16 = new LatentStyleExceptionInfo() { Name = "Normal Table", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo17 = new LatentStyleExceptionInfo() { Name = "Table Simple 1", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo18 = new LatentStyleExceptionInfo() { Name = "Table Simple 2", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo19 = new LatentStyleExceptionInfo() { Name = "Table Simple 3", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo20 = new LatentStyleExceptionInfo() { Name = "Table Classic 1", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo21 = new LatentStyleExceptionInfo() { Name = "Table Classic 2", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo22 = new LatentStyleExceptionInfo() { Name = "Table Classic 3", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo23 = new LatentStyleExceptionInfo() { Name = "Table Classic 4", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo24 = new LatentStyleExceptionInfo() { Name = "Table Colorful 1", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo25 = new LatentStyleExceptionInfo() { Name = "Table Colorful 2", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo26 = new LatentStyleExceptionInfo() { Name = "Table Colorful 3", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo27 = new LatentStyleExceptionInfo() { Name = "Table Columns 1", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo28 = new LatentStyleExceptionInfo() { Name = "Table Columns 2", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo29 = new LatentStyleExceptionInfo() { Name = "Table Columns 3", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo30 = new LatentStyleExceptionInfo() { Name = "Table Columns 4", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo31 = new LatentStyleExceptionInfo() { Name = "Table Columns 5", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo32 = new LatentStyleExceptionInfo() { Name = "Table Grid 1", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo33 = new LatentStyleExceptionInfo() { Name = "Table Grid 2", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo34 = new LatentStyleExceptionInfo() { Name = "Table Grid 3", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo35 = new LatentStyleExceptionInfo() { Name = "Table Grid 4", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo36 = new LatentStyleExceptionInfo() { Name = "Table Grid 5", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo37 = new LatentStyleExceptionInfo() { Name = "Table Grid 6", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo38 = new LatentStyleExceptionInfo() { Name = "Table Grid 7", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo39 = new LatentStyleExceptionInfo() { Name = "Table Grid 8", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo40 = new LatentStyleExceptionInfo() { Name = "Table List 1", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo41 = new LatentStyleExceptionInfo() { Name = "Table List 2", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo42 = new LatentStyleExceptionInfo() { Name = "Table List 3", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo43 = new LatentStyleExceptionInfo() { Name = "Table List 4", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo44 = new LatentStyleExceptionInfo() { Name = "Table List 5", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo45 = new LatentStyleExceptionInfo() { Name = "Table List 6", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo46 = new LatentStyleExceptionInfo() { Name = "Table List 7", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo47 = new LatentStyleExceptionInfo() { Name = "Table List 8", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo48 = new LatentStyleExceptionInfo() { Name = "Table 3D effects 1", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo49 = new LatentStyleExceptionInfo() { Name = "Table 3D effects 2", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo50 = new LatentStyleExceptionInfo() { Name = "Table 3D effects 3", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo51 = new LatentStyleExceptionInfo() { Name = "Table Contemporary", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo52 = new LatentStyleExceptionInfo() { Name = "Table Elegant", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo53 = new LatentStyleExceptionInfo() { Name = "Table Professional", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo54 = new LatentStyleExceptionInfo() { Name = "Table Subtle 1", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo55 = new LatentStyleExceptionInfo() { Name = "Table Subtle 2", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo56 = new LatentStyleExceptionInfo() { Name = "Table Web 1", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo57 = new LatentStyleExceptionInfo() { Name = "Table Web 2", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo58 = new LatentStyleExceptionInfo() { Name = "Table Web 3", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo59 = new LatentStyleExceptionInfo() { Name = "Table Theme", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo60 = new LatentStyleExceptionInfo() { Name = "Placeholder Text", UiPriority = 99, SemiHidden = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo61 = new LatentStyleExceptionInfo() { Name = "No Spacing", UiPriority = 1, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo62 = new LatentStyleExceptionInfo() { Name = "Light Shading", UiPriority = 60 };
            LatentStyleExceptionInfo latentStyleExceptionInfo63 = new LatentStyleExceptionInfo() { Name = "Light List", UiPriority = 61 };
            LatentStyleExceptionInfo latentStyleExceptionInfo64 = new LatentStyleExceptionInfo() { Name = "Light Grid", UiPriority = 62 };
            LatentStyleExceptionInfo latentStyleExceptionInfo65 = new LatentStyleExceptionInfo() { Name = "Medium Shading 1", UiPriority = 63 };
            LatentStyleExceptionInfo latentStyleExceptionInfo66 = new LatentStyleExceptionInfo() { Name = "Medium Shading 2", UiPriority = 64 };
            LatentStyleExceptionInfo latentStyleExceptionInfo67 = new LatentStyleExceptionInfo() { Name = "Medium List 1", UiPriority = 65 };
            LatentStyleExceptionInfo latentStyleExceptionInfo68 = new LatentStyleExceptionInfo() { Name = "Medium List 2", UiPriority = 66 };
            LatentStyleExceptionInfo latentStyleExceptionInfo69 = new LatentStyleExceptionInfo() { Name = "Medium Grid 1", UiPriority = 67 };
            LatentStyleExceptionInfo latentStyleExceptionInfo70 = new LatentStyleExceptionInfo() { Name = "Medium Grid 2", UiPriority = 68 };
            LatentStyleExceptionInfo latentStyleExceptionInfo71 = new LatentStyleExceptionInfo() { Name = "Medium Grid 3", UiPriority = 69 };
            LatentStyleExceptionInfo latentStyleExceptionInfo72 = new LatentStyleExceptionInfo() { Name = "Dark List", UiPriority = 70 };
            LatentStyleExceptionInfo latentStyleExceptionInfo73 = new LatentStyleExceptionInfo() { Name = "Colorful Shading", UiPriority = 71 };
            LatentStyleExceptionInfo latentStyleExceptionInfo74 = new LatentStyleExceptionInfo() { Name = "Colorful List", UiPriority = 72 };
            LatentStyleExceptionInfo latentStyleExceptionInfo75 = new LatentStyleExceptionInfo() { Name = "Colorful Grid", UiPriority = 73 };
            LatentStyleExceptionInfo latentStyleExceptionInfo76 = new LatentStyleExceptionInfo() { Name = "Light Shading Accent 1", UiPriority = 60 };
            LatentStyleExceptionInfo latentStyleExceptionInfo77 = new LatentStyleExceptionInfo() { Name = "Light List Accent 1", UiPriority = 61 };
            LatentStyleExceptionInfo latentStyleExceptionInfo78 = new LatentStyleExceptionInfo() { Name = "Light Grid Accent 1", UiPriority = 62 };
            LatentStyleExceptionInfo latentStyleExceptionInfo79 = new LatentStyleExceptionInfo() { Name = "Medium Shading 1 Accent 1", UiPriority = 63 };
            LatentStyleExceptionInfo latentStyleExceptionInfo80 = new LatentStyleExceptionInfo() { Name = "Medium Shading 2 Accent 1", UiPriority = 64 };
            LatentStyleExceptionInfo latentStyleExceptionInfo81 = new LatentStyleExceptionInfo() { Name = "Medium List 1 Accent 1", UiPriority = 65 };
            LatentStyleExceptionInfo latentStyleExceptionInfo82 = new LatentStyleExceptionInfo() { Name = "Revision", UiPriority = 99, SemiHidden = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo83 = new LatentStyleExceptionInfo() { Name = "List Paragraph", UiPriority = 34, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo84 = new LatentStyleExceptionInfo() { Name = "Quote", UiPriority = 29, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo85 = new LatentStyleExceptionInfo() { Name = "Intense Quote", UiPriority = 30, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo86 = new LatentStyleExceptionInfo() { Name = "Medium List 2 Accent 1", UiPriority = 66 };
            LatentStyleExceptionInfo latentStyleExceptionInfo87 = new LatentStyleExceptionInfo() { Name = "Medium Grid 1 Accent 1", UiPriority = 67 };
            LatentStyleExceptionInfo latentStyleExceptionInfo88 = new LatentStyleExceptionInfo() { Name = "Medium Grid 2 Accent 1", UiPriority = 68 };
            LatentStyleExceptionInfo latentStyleExceptionInfo89 = new LatentStyleExceptionInfo() { Name = "Medium Grid 3 Accent 1", UiPriority = 69 };
            LatentStyleExceptionInfo latentStyleExceptionInfo90 = new LatentStyleExceptionInfo() { Name = "Dark List Accent 1", UiPriority = 70 };
            LatentStyleExceptionInfo latentStyleExceptionInfo91 = new LatentStyleExceptionInfo() { Name = "Colorful Shading Accent 1", UiPriority = 71 };
            LatentStyleExceptionInfo latentStyleExceptionInfo92 = new LatentStyleExceptionInfo() { Name = "Colorful List Accent 1", UiPriority = 72 };
            LatentStyleExceptionInfo latentStyleExceptionInfo93 = new LatentStyleExceptionInfo() { Name = "Colorful Grid Accent 1", UiPriority = 73 };
            LatentStyleExceptionInfo latentStyleExceptionInfo94 = new LatentStyleExceptionInfo() { Name = "Light Shading Accent 2", UiPriority = 60 };
            LatentStyleExceptionInfo latentStyleExceptionInfo95 = new LatentStyleExceptionInfo() { Name = "Light List Accent 2", UiPriority = 61 };
            LatentStyleExceptionInfo latentStyleExceptionInfo96 = new LatentStyleExceptionInfo() { Name = "Light Grid Accent 2", UiPriority = 62 };
            LatentStyleExceptionInfo latentStyleExceptionInfo97 = new LatentStyleExceptionInfo() { Name = "Medium Shading 1 Accent 2", UiPriority = 63 };
            LatentStyleExceptionInfo latentStyleExceptionInfo98 = new LatentStyleExceptionInfo() { Name = "Medium Shading 2 Accent 2", UiPriority = 64 };
            LatentStyleExceptionInfo latentStyleExceptionInfo99 = new LatentStyleExceptionInfo() { Name = "Medium List 1 Accent 2", UiPriority = 65 };
            LatentStyleExceptionInfo latentStyleExceptionInfo100 = new LatentStyleExceptionInfo() { Name = "Medium List 2 Accent 2", UiPriority = 66 };
            LatentStyleExceptionInfo latentStyleExceptionInfo101 = new LatentStyleExceptionInfo() { Name = "Medium Grid 1 Accent 2", UiPriority = 67 };
            LatentStyleExceptionInfo latentStyleExceptionInfo102 = new LatentStyleExceptionInfo() { Name = "Medium Grid 2 Accent 2", UiPriority = 68 };
            LatentStyleExceptionInfo latentStyleExceptionInfo103 = new LatentStyleExceptionInfo() { Name = "Medium Grid 3 Accent 2", UiPriority = 69 };
            LatentStyleExceptionInfo latentStyleExceptionInfo104 = new LatentStyleExceptionInfo() { Name = "Dark List Accent 2", UiPriority = 70 };
            LatentStyleExceptionInfo latentStyleExceptionInfo105 = new LatentStyleExceptionInfo() { Name = "Colorful Shading Accent 2", UiPriority = 71 };
            LatentStyleExceptionInfo latentStyleExceptionInfo106 = new LatentStyleExceptionInfo() { Name = "Colorful List Accent 2", UiPriority = 72 };
            LatentStyleExceptionInfo latentStyleExceptionInfo107 = new LatentStyleExceptionInfo() { Name = "Colorful Grid Accent 2", UiPriority = 73 };
            LatentStyleExceptionInfo latentStyleExceptionInfo108 = new LatentStyleExceptionInfo() { Name = "Light Shading Accent 3", UiPriority = 60 };
            LatentStyleExceptionInfo latentStyleExceptionInfo109 = new LatentStyleExceptionInfo() { Name = "Light List Accent 3", UiPriority = 61 };
            LatentStyleExceptionInfo latentStyleExceptionInfo110 = new LatentStyleExceptionInfo() { Name = "Light Grid Accent 3", UiPriority = 62 };
            LatentStyleExceptionInfo latentStyleExceptionInfo111 = new LatentStyleExceptionInfo() { Name = "Medium Shading 1 Accent 3", UiPriority = 63 };
            LatentStyleExceptionInfo latentStyleExceptionInfo112 = new LatentStyleExceptionInfo() { Name = "Medium Shading 2 Accent 3", UiPriority = 64 };
            LatentStyleExceptionInfo latentStyleExceptionInfo113 = new LatentStyleExceptionInfo() { Name = "Medium List 1 Accent 3", UiPriority = 65 };
            LatentStyleExceptionInfo latentStyleExceptionInfo114 = new LatentStyleExceptionInfo() { Name = "Medium List 2 Accent 3", UiPriority = 66 };
            LatentStyleExceptionInfo latentStyleExceptionInfo115 = new LatentStyleExceptionInfo() { Name = "Medium Grid 1 Accent 3", UiPriority = 67 };
            LatentStyleExceptionInfo latentStyleExceptionInfo116 = new LatentStyleExceptionInfo() { Name = "Medium Grid 2 Accent 3", UiPriority = 68 };
            LatentStyleExceptionInfo latentStyleExceptionInfo117 = new LatentStyleExceptionInfo() { Name = "Medium Grid 3 Accent 3", UiPriority = 69 };
            LatentStyleExceptionInfo latentStyleExceptionInfo118 = new LatentStyleExceptionInfo() { Name = "Dark List Accent 3", UiPriority = 70 };
            LatentStyleExceptionInfo latentStyleExceptionInfo119 = new LatentStyleExceptionInfo() { Name = "Colorful Shading Accent 3", UiPriority = 71 };
            LatentStyleExceptionInfo latentStyleExceptionInfo120 = new LatentStyleExceptionInfo() { Name = "Colorful List Accent 3", UiPriority = 72 };
            LatentStyleExceptionInfo latentStyleExceptionInfo121 = new LatentStyleExceptionInfo() { Name = "Colorful Grid Accent 3", UiPriority = 73 };
            LatentStyleExceptionInfo latentStyleExceptionInfo122 = new LatentStyleExceptionInfo() { Name = "Light Shading Accent 4", UiPriority = 60 };
            LatentStyleExceptionInfo latentStyleExceptionInfo123 = new LatentStyleExceptionInfo() { Name = "Light List Accent 4", UiPriority = 61 };
            LatentStyleExceptionInfo latentStyleExceptionInfo124 = new LatentStyleExceptionInfo() { Name = "Light Grid Accent 4", UiPriority = 62 };
            LatentStyleExceptionInfo latentStyleExceptionInfo125 = new LatentStyleExceptionInfo() { Name = "Medium Shading 1 Accent 4", UiPriority = 63 };
            LatentStyleExceptionInfo latentStyleExceptionInfo126 = new LatentStyleExceptionInfo() { Name = "Medium Shading 2 Accent 4", UiPriority = 64 };
            LatentStyleExceptionInfo latentStyleExceptionInfo127 = new LatentStyleExceptionInfo() { Name = "Medium List 1 Accent 4", UiPriority = 65 };
            LatentStyleExceptionInfo latentStyleExceptionInfo128 = new LatentStyleExceptionInfo() { Name = "Medium List 2 Accent 4", UiPriority = 66 };
            LatentStyleExceptionInfo latentStyleExceptionInfo129 = new LatentStyleExceptionInfo() { Name = "Medium Grid 1 Accent 4", UiPriority = 67 };
            LatentStyleExceptionInfo latentStyleExceptionInfo130 = new LatentStyleExceptionInfo() { Name = "Medium Grid 2 Accent 4", UiPriority = 68 };
            LatentStyleExceptionInfo latentStyleExceptionInfo131 = new LatentStyleExceptionInfo() { Name = "Medium Grid 3 Accent 4", UiPriority = 69 };
            LatentStyleExceptionInfo latentStyleExceptionInfo132 = new LatentStyleExceptionInfo() { Name = "Dark List Accent 4", UiPriority = 70 };
            LatentStyleExceptionInfo latentStyleExceptionInfo133 = new LatentStyleExceptionInfo() { Name = "Colorful Shading Accent 4", UiPriority = 71 };
            LatentStyleExceptionInfo latentStyleExceptionInfo134 = new LatentStyleExceptionInfo() { Name = "Colorful List Accent 4", UiPriority = 72 };
            LatentStyleExceptionInfo latentStyleExceptionInfo135 = new LatentStyleExceptionInfo() { Name = "Colorful Grid Accent 4", UiPriority = 73 };
            LatentStyleExceptionInfo latentStyleExceptionInfo136 = new LatentStyleExceptionInfo() { Name = "Light Shading Accent 5", UiPriority = 60 };
            LatentStyleExceptionInfo latentStyleExceptionInfo137 = new LatentStyleExceptionInfo() { Name = "Light List Accent 5", UiPriority = 61 };
            LatentStyleExceptionInfo latentStyleExceptionInfo138 = new LatentStyleExceptionInfo() { Name = "Light Grid Accent 5", UiPriority = 62 };
            LatentStyleExceptionInfo latentStyleExceptionInfo139 = new LatentStyleExceptionInfo() { Name = "Medium Shading 1 Accent 5", UiPriority = 63 };
            LatentStyleExceptionInfo latentStyleExceptionInfo140 = new LatentStyleExceptionInfo() { Name = "Medium Shading 2 Accent 5", UiPriority = 64 };
            LatentStyleExceptionInfo latentStyleExceptionInfo141 = new LatentStyleExceptionInfo() { Name = "Medium List 1 Accent 5", UiPriority = 65 };
            LatentStyleExceptionInfo latentStyleExceptionInfo142 = new LatentStyleExceptionInfo() { Name = "Medium List 2 Accent 5", UiPriority = 66 };
            LatentStyleExceptionInfo latentStyleExceptionInfo143 = new LatentStyleExceptionInfo() { Name = "Medium Grid 1 Accent 5", UiPriority = 67 };
            LatentStyleExceptionInfo latentStyleExceptionInfo144 = new LatentStyleExceptionInfo() { Name = "Medium Grid 2 Accent 5", UiPriority = 68 };
            LatentStyleExceptionInfo latentStyleExceptionInfo145 = new LatentStyleExceptionInfo() { Name = "Medium Grid 3 Accent 5", UiPriority = 69 };
            LatentStyleExceptionInfo latentStyleExceptionInfo146 = new LatentStyleExceptionInfo() { Name = "Dark List Accent 5", UiPriority = 70 };
            LatentStyleExceptionInfo latentStyleExceptionInfo147 = new LatentStyleExceptionInfo() { Name = "Colorful Shading Accent 5", UiPriority = 71 };
            LatentStyleExceptionInfo latentStyleExceptionInfo148 = new LatentStyleExceptionInfo() { Name = "Colorful List Accent 5", UiPriority = 72 };
            LatentStyleExceptionInfo latentStyleExceptionInfo149 = new LatentStyleExceptionInfo() { Name = "Colorful Grid Accent 5", UiPriority = 73 };
            LatentStyleExceptionInfo latentStyleExceptionInfo150 = new LatentStyleExceptionInfo() { Name = "Light Shading Accent 6", UiPriority = 60 };
            LatentStyleExceptionInfo latentStyleExceptionInfo151 = new LatentStyleExceptionInfo() { Name = "Light List Accent 6", UiPriority = 61 };
            LatentStyleExceptionInfo latentStyleExceptionInfo152 = new LatentStyleExceptionInfo() { Name = "Light Grid Accent 6", UiPriority = 62 };
            LatentStyleExceptionInfo latentStyleExceptionInfo153 = new LatentStyleExceptionInfo() { Name = "Medium Shading 1 Accent 6", UiPriority = 63 };
            LatentStyleExceptionInfo latentStyleExceptionInfo154 = new LatentStyleExceptionInfo() { Name = "Medium Shading 2 Accent 6", UiPriority = 64 };
            LatentStyleExceptionInfo latentStyleExceptionInfo155 = new LatentStyleExceptionInfo() { Name = "Medium List 1 Accent 6", UiPriority = 65 };
            LatentStyleExceptionInfo latentStyleExceptionInfo156 = new LatentStyleExceptionInfo() { Name = "Medium List 2 Accent 6", UiPriority = 66 };
            LatentStyleExceptionInfo latentStyleExceptionInfo157 = new LatentStyleExceptionInfo() { Name = "Medium Grid 1 Accent 6", UiPriority = 67 };
            LatentStyleExceptionInfo latentStyleExceptionInfo158 = new LatentStyleExceptionInfo() { Name = "Medium Grid 2 Accent 6", UiPriority = 68 };
            LatentStyleExceptionInfo latentStyleExceptionInfo159 = new LatentStyleExceptionInfo() { Name = "Medium Grid 3 Accent 6", UiPriority = 69 };
            LatentStyleExceptionInfo latentStyleExceptionInfo160 = new LatentStyleExceptionInfo() { Name = "Dark List Accent 6", UiPriority = 70 };
            LatentStyleExceptionInfo latentStyleExceptionInfo161 = new LatentStyleExceptionInfo() { Name = "Colorful Shading Accent 6", UiPriority = 71 };
            LatentStyleExceptionInfo latentStyleExceptionInfo162 = new LatentStyleExceptionInfo() { Name = "Colorful List Accent 6", UiPriority = 72 };
            LatentStyleExceptionInfo latentStyleExceptionInfo163 = new LatentStyleExceptionInfo() { Name = "Colorful Grid Accent 6", UiPriority = 73 };
            LatentStyleExceptionInfo latentStyleExceptionInfo164 = new LatentStyleExceptionInfo() { Name = "Subtle Emphasis", UiPriority = 19, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo165 = new LatentStyleExceptionInfo() { Name = "Intense Emphasis", UiPriority = 21, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo166 = new LatentStyleExceptionInfo() { Name = "Subtle Reference", UiPriority = 31, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo167 = new LatentStyleExceptionInfo() { Name = "Intense Reference", UiPriority = 32, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo168 = new LatentStyleExceptionInfo() { Name = "Book Title", UiPriority = 33, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo169 = new LatentStyleExceptionInfo() { Name = "Bibliography", UiPriority = 37, SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo170 = new LatentStyleExceptionInfo() { Name = "TOC Heading", UiPriority = 39, SemiHidden = true, UnhideWhenUsed = true, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo171 = new LatentStyleExceptionInfo() { Name = "Plain Table 1", UiPriority = 41 };
            LatentStyleExceptionInfo latentStyleExceptionInfo172 = new LatentStyleExceptionInfo() { Name = "Plain Table 2", UiPriority = 42 };
            LatentStyleExceptionInfo latentStyleExceptionInfo173 = new LatentStyleExceptionInfo() { Name = "Plain Table 3", UiPriority = 43 };
            LatentStyleExceptionInfo latentStyleExceptionInfo174 = new LatentStyleExceptionInfo() { Name = "Plain Table 4", UiPriority = 44 };
            LatentStyleExceptionInfo latentStyleExceptionInfo175 = new LatentStyleExceptionInfo() { Name = "Plain Table 5", UiPriority = 45 };
            LatentStyleExceptionInfo latentStyleExceptionInfo176 = new LatentStyleExceptionInfo() { Name = "Grid Table Light", UiPriority = 40 };
            LatentStyleExceptionInfo latentStyleExceptionInfo177 = new LatentStyleExceptionInfo() { Name = "Grid Table 1 Light", UiPriority = 46 };
            LatentStyleExceptionInfo latentStyleExceptionInfo178 = new LatentStyleExceptionInfo() { Name = "Grid Table 2", UiPriority = 47 };
            LatentStyleExceptionInfo latentStyleExceptionInfo179 = new LatentStyleExceptionInfo() { Name = "Grid Table 3", UiPriority = 48 };
            LatentStyleExceptionInfo latentStyleExceptionInfo180 = new LatentStyleExceptionInfo() { Name = "Grid Table 4", UiPriority = 49 };
            LatentStyleExceptionInfo latentStyleExceptionInfo181 = new LatentStyleExceptionInfo() { Name = "Grid Table 5 Dark", UiPriority = 50 };
            LatentStyleExceptionInfo latentStyleExceptionInfo182 = new LatentStyleExceptionInfo() { Name = "Grid Table 6 Colorful", UiPriority = 51 };
            LatentStyleExceptionInfo latentStyleExceptionInfo183 = new LatentStyleExceptionInfo() { Name = "Grid Table 7 Colorful", UiPriority = 52 };
            LatentStyleExceptionInfo latentStyleExceptionInfo184 = new LatentStyleExceptionInfo() { Name = "Grid Table 1 Light Accent 1", UiPriority = 46 };
            LatentStyleExceptionInfo latentStyleExceptionInfo185 = new LatentStyleExceptionInfo() { Name = "Grid Table 2 Accent 1", UiPriority = 47 };
            LatentStyleExceptionInfo latentStyleExceptionInfo186 = new LatentStyleExceptionInfo() { Name = "Grid Table 3 Accent 1", UiPriority = 48 };
            LatentStyleExceptionInfo latentStyleExceptionInfo187 = new LatentStyleExceptionInfo() { Name = "Grid Table 4 Accent 1", UiPriority = 49 };
            LatentStyleExceptionInfo latentStyleExceptionInfo188 = new LatentStyleExceptionInfo() { Name = "Grid Table 5 Dark Accent 1", UiPriority = 50 };
            LatentStyleExceptionInfo latentStyleExceptionInfo189 = new LatentStyleExceptionInfo() { Name = "Grid Table 6 Colorful Accent 1", UiPriority = 51 };
            LatentStyleExceptionInfo latentStyleExceptionInfo190 = new LatentStyleExceptionInfo() { Name = "Grid Table 7 Colorful Accent 1", UiPriority = 52 };
            LatentStyleExceptionInfo latentStyleExceptionInfo191 = new LatentStyleExceptionInfo() { Name = "Grid Table 1 Light Accent 2", UiPriority = 46 };
            LatentStyleExceptionInfo latentStyleExceptionInfo192 = new LatentStyleExceptionInfo() { Name = "Grid Table 2 Accent 2", UiPriority = 47 };
            LatentStyleExceptionInfo latentStyleExceptionInfo193 = new LatentStyleExceptionInfo() { Name = "Grid Table 3 Accent 2", UiPriority = 48 };
            LatentStyleExceptionInfo latentStyleExceptionInfo194 = new LatentStyleExceptionInfo() { Name = "Grid Table 4 Accent 2", UiPriority = 49 };
            LatentStyleExceptionInfo latentStyleExceptionInfo195 = new LatentStyleExceptionInfo() { Name = "Grid Table 5 Dark Accent 2", UiPriority = 50 };
            LatentStyleExceptionInfo latentStyleExceptionInfo196 = new LatentStyleExceptionInfo() { Name = "Grid Table 6 Colorful Accent 2", UiPriority = 51 };
            LatentStyleExceptionInfo latentStyleExceptionInfo197 = new LatentStyleExceptionInfo() { Name = "Grid Table 7 Colorful Accent 2", UiPriority = 52 };
            LatentStyleExceptionInfo latentStyleExceptionInfo198 = new LatentStyleExceptionInfo() { Name = "Grid Table 1 Light Accent 3", UiPriority = 46 };
            LatentStyleExceptionInfo latentStyleExceptionInfo199 = new LatentStyleExceptionInfo() { Name = "Grid Table 2 Accent 3", UiPriority = 47 };
            LatentStyleExceptionInfo latentStyleExceptionInfo200 = new LatentStyleExceptionInfo() { Name = "Grid Table 3 Accent 3", UiPriority = 48 };
            LatentStyleExceptionInfo latentStyleExceptionInfo201 = new LatentStyleExceptionInfo() { Name = "Grid Table 4 Accent 3", UiPriority = 49 };
            LatentStyleExceptionInfo latentStyleExceptionInfo202 = new LatentStyleExceptionInfo() { Name = "Grid Table 5 Dark Accent 3", UiPriority = 50 };
            LatentStyleExceptionInfo latentStyleExceptionInfo203 = new LatentStyleExceptionInfo() { Name = "Grid Table 6 Colorful Accent 3", UiPriority = 51 };
            LatentStyleExceptionInfo latentStyleExceptionInfo204 = new LatentStyleExceptionInfo() { Name = "Grid Table 7 Colorful Accent 3", UiPriority = 52 };
            LatentStyleExceptionInfo latentStyleExceptionInfo205 = new LatentStyleExceptionInfo() { Name = "Grid Table 1 Light Accent 4", UiPriority = 46 };
            LatentStyleExceptionInfo latentStyleExceptionInfo206 = new LatentStyleExceptionInfo() { Name = "Grid Table 2 Accent 4", UiPriority = 47 };
            LatentStyleExceptionInfo latentStyleExceptionInfo207 = new LatentStyleExceptionInfo() { Name = "Grid Table 3 Accent 4", UiPriority = 48 };
            LatentStyleExceptionInfo latentStyleExceptionInfo208 = new LatentStyleExceptionInfo() { Name = "Grid Table 4 Accent 4", UiPriority = 49 };
            LatentStyleExceptionInfo latentStyleExceptionInfo209 = new LatentStyleExceptionInfo() { Name = "Grid Table 5 Dark Accent 4", UiPriority = 50 };
            LatentStyleExceptionInfo latentStyleExceptionInfo210 = new LatentStyleExceptionInfo() { Name = "Grid Table 6 Colorful Accent 4", UiPriority = 51 };
            LatentStyleExceptionInfo latentStyleExceptionInfo211 = new LatentStyleExceptionInfo() { Name = "Grid Table 7 Colorful Accent 4", UiPriority = 52 };
            LatentStyleExceptionInfo latentStyleExceptionInfo212 = new LatentStyleExceptionInfo() { Name = "Grid Table 1 Light Accent 5", UiPriority = 46 };
            LatentStyleExceptionInfo latentStyleExceptionInfo213 = new LatentStyleExceptionInfo() { Name = "Grid Table 2 Accent 5", UiPriority = 47 };
            LatentStyleExceptionInfo latentStyleExceptionInfo214 = new LatentStyleExceptionInfo() { Name = "Grid Table 3 Accent 5", UiPriority = 48 };
            LatentStyleExceptionInfo latentStyleExceptionInfo215 = new LatentStyleExceptionInfo() { Name = "Grid Table 4 Accent 5", UiPriority = 49 };
            LatentStyleExceptionInfo latentStyleExceptionInfo216 = new LatentStyleExceptionInfo() { Name = "Grid Table 5 Dark Accent 5", UiPriority = 50 };
            LatentStyleExceptionInfo latentStyleExceptionInfo217 = new LatentStyleExceptionInfo() { Name = "Grid Table 6 Colorful Accent 5", UiPriority = 51 };
            LatentStyleExceptionInfo latentStyleExceptionInfo218 = new LatentStyleExceptionInfo() { Name = "Grid Table 7 Colorful Accent 5", UiPriority = 52 };
            LatentStyleExceptionInfo latentStyleExceptionInfo219 = new LatentStyleExceptionInfo() { Name = "Grid Table 1 Light Accent 6", UiPriority = 46 };
            LatentStyleExceptionInfo latentStyleExceptionInfo220 = new LatentStyleExceptionInfo() { Name = "Grid Table 2 Accent 6", UiPriority = 47 };
            LatentStyleExceptionInfo latentStyleExceptionInfo221 = new LatentStyleExceptionInfo() { Name = "Grid Table 3 Accent 6", UiPriority = 48 };
            LatentStyleExceptionInfo latentStyleExceptionInfo222 = new LatentStyleExceptionInfo() { Name = "Grid Table 4 Accent 6", UiPriority = 49 };
            LatentStyleExceptionInfo latentStyleExceptionInfo223 = new LatentStyleExceptionInfo() { Name = "Grid Table 5 Dark Accent 6", UiPriority = 50 };
            LatentStyleExceptionInfo latentStyleExceptionInfo224 = new LatentStyleExceptionInfo() { Name = "Grid Table 6 Colorful Accent 6", UiPriority = 51 };
            LatentStyleExceptionInfo latentStyleExceptionInfo225 = new LatentStyleExceptionInfo() { Name = "Grid Table 7 Colorful Accent 6", UiPriority = 52 };
            LatentStyleExceptionInfo latentStyleExceptionInfo226 = new LatentStyleExceptionInfo() { Name = "List Table 1 Light", UiPriority = 46 };
            LatentStyleExceptionInfo latentStyleExceptionInfo227 = new LatentStyleExceptionInfo() { Name = "List Table 2", UiPriority = 47 };
            LatentStyleExceptionInfo latentStyleExceptionInfo228 = new LatentStyleExceptionInfo() { Name = "List Table 3", UiPriority = 48 };
            LatentStyleExceptionInfo latentStyleExceptionInfo229 = new LatentStyleExceptionInfo() { Name = "List Table 4", UiPriority = 49 };
            LatentStyleExceptionInfo latentStyleExceptionInfo230 = new LatentStyleExceptionInfo() { Name = "List Table 5 Dark", UiPriority = 50 };
            LatentStyleExceptionInfo latentStyleExceptionInfo231 = new LatentStyleExceptionInfo() { Name = "List Table 6 Colorful", UiPriority = 51 };
            LatentStyleExceptionInfo latentStyleExceptionInfo232 = new LatentStyleExceptionInfo() { Name = "List Table 7 Colorful", UiPriority = 52 };
            LatentStyleExceptionInfo latentStyleExceptionInfo233 = new LatentStyleExceptionInfo() { Name = "List Table 1 Light Accent 1", UiPriority = 46 };
            LatentStyleExceptionInfo latentStyleExceptionInfo234 = new LatentStyleExceptionInfo() { Name = "List Table 2 Accent 1", UiPriority = 47 };
            LatentStyleExceptionInfo latentStyleExceptionInfo235 = new LatentStyleExceptionInfo() { Name = "List Table 3 Accent 1", UiPriority = 48 };
            LatentStyleExceptionInfo latentStyleExceptionInfo236 = new LatentStyleExceptionInfo() { Name = "List Table 4 Accent 1", UiPriority = 49 };
            LatentStyleExceptionInfo latentStyleExceptionInfo237 = new LatentStyleExceptionInfo() { Name = "List Table 5 Dark Accent 1", UiPriority = 50 };
            LatentStyleExceptionInfo latentStyleExceptionInfo238 = new LatentStyleExceptionInfo() { Name = "List Table 6 Colorful Accent 1", UiPriority = 51 };
            LatentStyleExceptionInfo latentStyleExceptionInfo239 = new LatentStyleExceptionInfo() { Name = "List Table 7 Colorful Accent 1", UiPriority = 52 };
            LatentStyleExceptionInfo latentStyleExceptionInfo240 = new LatentStyleExceptionInfo() { Name = "List Table 1 Light Accent 2", UiPriority = 46 };
            LatentStyleExceptionInfo latentStyleExceptionInfo241 = new LatentStyleExceptionInfo() { Name = "List Table 2 Accent 2", UiPriority = 47 };
            LatentStyleExceptionInfo latentStyleExceptionInfo242 = new LatentStyleExceptionInfo() { Name = "List Table 3 Accent 2", UiPriority = 48 };
            LatentStyleExceptionInfo latentStyleExceptionInfo243 = new LatentStyleExceptionInfo() { Name = "List Table 4 Accent 2", UiPriority = 49 };
            LatentStyleExceptionInfo latentStyleExceptionInfo244 = new LatentStyleExceptionInfo() { Name = "List Table 5 Dark Accent 2", UiPriority = 50 };
            LatentStyleExceptionInfo latentStyleExceptionInfo245 = new LatentStyleExceptionInfo() { Name = "List Table 6 Colorful Accent 2", UiPriority = 51 };
            LatentStyleExceptionInfo latentStyleExceptionInfo246 = new LatentStyleExceptionInfo() { Name = "List Table 7 Colorful Accent 2", UiPriority = 52 };
            LatentStyleExceptionInfo latentStyleExceptionInfo247 = new LatentStyleExceptionInfo() { Name = "List Table 1 Light Accent 3", UiPriority = 46 };
            LatentStyleExceptionInfo latentStyleExceptionInfo248 = new LatentStyleExceptionInfo() { Name = "List Table 2 Accent 3", UiPriority = 47 };
            LatentStyleExceptionInfo latentStyleExceptionInfo249 = new LatentStyleExceptionInfo() { Name = "List Table 3 Accent 3", UiPriority = 48 };
            LatentStyleExceptionInfo latentStyleExceptionInfo250 = new LatentStyleExceptionInfo() { Name = "List Table 4 Accent 3", UiPriority = 49 };
            LatentStyleExceptionInfo latentStyleExceptionInfo251 = new LatentStyleExceptionInfo() { Name = "List Table 5 Dark Accent 3", UiPriority = 50 };
            LatentStyleExceptionInfo latentStyleExceptionInfo252 = new LatentStyleExceptionInfo() { Name = "List Table 6 Colorful Accent 3", UiPriority = 51 };
            LatentStyleExceptionInfo latentStyleExceptionInfo253 = new LatentStyleExceptionInfo() { Name = "List Table 7 Colorful Accent 3", UiPriority = 52 };
            LatentStyleExceptionInfo latentStyleExceptionInfo254 = new LatentStyleExceptionInfo() { Name = "List Table 1 Light Accent 4", UiPriority = 46 };
            LatentStyleExceptionInfo latentStyleExceptionInfo255 = new LatentStyleExceptionInfo() { Name = "List Table 2 Accent 4", UiPriority = 47 };
            LatentStyleExceptionInfo latentStyleExceptionInfo256 = new LatentStyleExceptionInfo() { Name = "List Table 3 Accent 4", UiPriority = 48 };
            LatentStyleExceptionInfo latentStyleExceptionInfo257 = new LatentStyleExceptionInfo() { Name = "List Table 4 Accent 4", UiPriority = 49 };
            LatentStyleExceptionInfo latentStyleExceptionInfo258 = new LatentStyleExceptionInfo() { Name = "List Table 5 Dark Accent 4", UiPriority = 50 };
            LatentStyleExceptionInfo latentStyleExceptionInfo259 = new LatentStyleExceptionInfo() { Name = "List Table 6 Colorful Accent 4", UiPriority = 51 };
            LatentStyleExceptionInfo latentStyleExceptionInfo260 = new LatentStyleExceptionInfo() { Name = "List Table 7 Colorful Accent 4", UiPriority = 52 };
            LatentStyleExceptionInfo latentStyleExceptionInfo261 = new LatentStyleExceptionInfo() { Name = "List Table 1 Light Accent 5", UiPriority = 46 };
            LatentStyleExceptionInfo latentStyleExceptionInfo262 = new LatentStyleExceptionInfo() { Name = "List Table 2 Accent 5", UiPriority = 47 };
            LatentStyleExceptionInfo latentStyleExceptionInfo263 = new LatentStyleExceptionInfo() { Name = "List Table 3 Accent 5", UiPriority = 48 };
            LatentStyleExceptionInfo latentStyleExceptionInfo264 = new LatentStyleExceptionInfo() { Name = "List Table 4 Accent 5", UiPriority = 49 };
            LatentStyleExceptionInfo latentStyleExceptionInfo265 = new LatentStyleExceptionInfo() { Name = "List Table 5 Dark Accent 5", UiPriority = 50 };
            LatentStyleExceptionInfo latentStyleExceptionInfo266 = new LatentStyleExceptionInfo() { Name = "List Table 6 Colorful Accent 5", UiPriority = 51 };
            LatentStyleExceptionInfo latentStyleExceptionInfo267 = new LatentStyleExceptionInfo() { Name = "List Table 7 Colorful Accent 5", UiPriority = 52 };
            LatentStyleExceptionInfo latentStyleExceptionInfo268 = new LatentStyleExceptionInfo() { Name = "List Table 1 Light Accent 6", UiPriority = 46 };
            LatentStyleExceptionInfo latentStyleExceptionInfo269 = new LatentStyleExceptionInfo() { Name = "List Table 2 Accent 6", UiPriority = 47 };
            LatentStyleExceptionInfo latentStyleExceptionInfo270 = new LatentStyleExceptionInfo() { Name = "List Table 3 Accent 6", UiPriority = 48 };
            LatentStyleExceptionInfo latentStyleExceptionInfo271 = new LatentStyleExceptionInfo() { Name = "List Table 4 Accent 6", UiPriority = 49 };
            LatentStyleExceptionInfo latentStyleExceptionInfo272 = new LatentStyleExceptionInfo() { Name = "List Table 5 Dark Accent 6", UiPriority = 50 };
            LatentStyleExceptionInfo latentStyleExceptionInfo273 = new LatentStyleExceptionInfo() { Name = "List Table 6 Colorful Accent 6", UiPriority = 51 };
            LatentStyleExceptionInfo latentStyleExceptionInfo274 = new LatentStyleExceptionInfo() { Name = "List Table 7 Colorful Accent 6", UiPriority = 52 };

            latentStyles1.Append(latentStyleExceptionInfo1);
            latentStyles1.Append(latentStyleExceptionInfo2);
            latentStyles1.Append(latentStyleExceptionInfo3);
            latentStyles1.Append(latentStyleExceptionInfo4);
            latentStyles1.Append(latentStyleExceptionInfo5);
            latentStyles1.Append(latentStyleExceptionInfo6);
            latentStyles1.Append(latentStyleExceptionInfo7);
            latentStyles1.Append(latentStyleExceptionInfo8);
            latentStyles1.Append(latentStyleExceptionInfo9);
            latentStyles1.Append(latentStyleExceptionInfo10);
            latentStyles1.Append(latentStyleExceptionInfo11);
            latentStyles1.Append(latentStyleExceptionInfo12);
            latentStyles1.Append(latentStyleExceptionInfo13);
            latentStyles1.Append(latentStyleExceptionInfo14);
            latentStyles1.Append(latentStyleExceptionInfo15);
            latentStyles1.Append(latentStyleExceptionInfo16);
            latentStyles1.Append(latentStyleExceptionInfo17);
            latentStyles1.Append(latentStyleExceptionInfo18);
            latentStyles1.Append(latentStyleExceptionInfo19);
            latentStyles1.Append(latentStyleExceptionInfo20);
            latentStyles1.Append(latentStyleExceptionInfo21);
            latentStyles1.Append(latentStyleExceptionInfo22);
            latentStyles1.Append(latentStyleExceptionInfo23);
            latentStyles1.Append(latentStyleExceptionInfo24);
            latentStyles1.Append(latentStyleExceptionInfo25);
            latentStyles1.Append(latentStyleExceptionInfo26);
            latentStyles1.Append(latentStyleExceptionInfo27);
            latentStyles1.Append(latentStyleExceptionInfo28);
            latentStyles1.Append(latentStyleExceptionInfo29);
            latentStyles1.Append(latentStyleExceptionInfo30);
            latentStyles1.Append(latentStyleExceptionInfo31);
            latentStyles1.Append(latentStyleExceptionInfo32);
            latentStyles1.Append(latentStyleExceptionInfo33);
            latentStyles1.Append(latentStyleExceptionInfo34);
            latentStyles1.Append(latentStyleExceptionInfo35);
            latentStyles1.Append(latentStyleExceptionInfo36);
            latentStyles1.Append(latentStyleExceptionInfo37);
            latentStyles1.Append(latentStyleExceptionInfo38);
            latentStyles1.Append(latentStyleExceptionInfo39);
            latentStyles1.Append(latentStyleExceptionInfo40);
            latentStyles1.Append(latentStyleExceptionInfo41);
            latentStyles1.Append(latentStyleExceptionInfo42);
            latentStyles1.Append(latentStyleExceptionInfo43);
            latentStyles1.Append(latentStyleExceptionInfo44);
            latentStyles1.Append(latentStyleExceptionInfo45);
            latentStyles1.Append(latentStyleExceptionInfo46);
            latentStyles1.Append(latentStyleExceptionInfo47);
            latentStyles1.Append(latentStyleExceptionInfo48);
            latentStyles1.Append(latentStyleExceptionInfo49);
            latentStyles1.Append(latentStyleExceptionInfo50);
            latentStyles1.Append(latentStyleExceptionInfo51);
            latentStyles1.Append(latentStyleExceptionInfo52);
            latentStyles1.Append(latentStyleExceptionInfo53);
            latentStyles1.Append(latentStyleExceptionInfo54);
            latentStyles1.Append(latentStyleExceptionInfo55);
            latentStyles1.Append(latentStyleExceptionInfo56);
            latentStyles1.Append(latentStyleExceptionInfo57);
            latentStyles1.Append(latentStyleExceptionInfo58);
            latentStyles1.Append(latentStyleExceptionInfo59);
            latentStyles1.Append(latentStyleExceptionInfo60);
            latentStyles1.Append(latentStyleExceptionInfo61);
            latentStyles1.Append(latentStyleExceptionInfo62);
            latentStyles1.Append(latentStyleExceptionInfo63);
            latentStyles1.Append(latentStyleExceptionInfo64);
            latentStyles1.Append(latentStyleExceptionInfo65);
            latentStyles1.Append(latentStyleExceptionInfo66);
            latentStyles1.Append(latentStyleExceptionInfo67);
            latentStyles1.Append(latentStyleExceptionInfo68);
            latentStyles1.Append(latentStyleExceptionInfo69);
            latentStyles1.Append(latentStyleExceptionInfo70);
            latentStyles1.Append(latentStyleExceptionInfo71);
            latentStyles1.Append(latentStyleExceptionInfo72);
            latentStyles1.Append(latentStyleExceptionInfo73);
            latentStyles1.Append(latentStyleExceptionInfo74);
            latentStyles1.Append(latentStyleExceptionInfo75);
            latentStyles1.Append(latentStyleExceptionInfo76);
            latentStyles1.Append(latentStyleExceptionInfo77);
            latentStyles1.Append(latentStyleExceptionInfo78);
            latentStyles1.Append(latentStyleExceptionInfo79);
            latentStyles1.Append(latentStyleExceptionInfo80);
            latentStyles1.Append(latentStyleExceptionInfo81);
            latentStyles1.Append(latentStyleExceptionInfo82);
            latentStyles1.Append(latentStyleExceptionInfo83);
            latentStyles1.Append(latentStyleExceptionInfo84);
            latentStyles1.Append(latentStyleExceptionInfo85);
            latentStyles1.Append(latentStyleExceptionInfo86);
            latentStyles1.Append(latentStyleExceptionInfo87);
            latentStyles1.Append(latentStyleExceptionInfo88);
            latentStyles1.Append(latentStyleExceptionInfo89);
            latentStyles1.Append(latentStyleExceptionInfo90);
            latentStyles1.Append(latentStyleExceptionInfo91);
            latentStyles1.Append(latentStyleExceptionInfo92);
            latentStyles1.Append(latentStyleExceptionInfo93);
            latentStyles1.Append(latentStyleExceptionInfo94);
            latentStyles1.Append(latentStyleExceptionInfo95);
            latentStyles1.Append(latentStyleExceptionInfo96);
            latentStyles1.Append(latentStyleExceptionInfo97);
            latentStyles1.Append(latentStyleExceptionInfo98);
            latentStyles1.Append(latentStyleExceptionInfo99);
            latentStyles1.Append(latentStyleExceptionInfo100);
            latentStyles1.Append(latentStyleExceptionInfo101);
            latentStyles1.Append(latentStyleExceptionInfo102);
            latentStyles1.Append(latentStyleExceptionInfo103);
            latentStyles1.Append(latentStyleExceptionInfo104);
            latentStyles1.Append(latentStyleExceptionInfo105);
            latentStyles1.Append(latentStyleExceptionInfo106);
            latentStyles1.Append(latentStyleExceptionInfo107);
            latentStyles1.Append(latentStyleExceptionInfo108);
            latentStyles1.Append(latentStyleExceptionInfo109);
            latentStyles1.Append(latentStyleExceptionInfo110);
            latentStyles1.Append(latentStyleExceptionInfo111);
            latentStyles1.Append(latentStyleExceptionInfo112);
            latentStyles1.Append(latentStyleExceptionInfo113);
            latentStyles1.Append(latentStyleExceptionInfo114);
            latentStyles1.Append(latentStyleExceptionInfo115);
            latentStyles1.Append(latentStyleExceptionInfo116);
            latentStyles1.Append(latentStyleExceptionInfo117);
            latentStyles1.Append(latentStyleExceptionInfo118);
            latentStyles1.Append(latentStyleExceptionInfo119);
            latentStyles1.Append(latentStyleExceptionInfo120);
            latentStyles1.Append(latentStyleExceptionInfo121);
            latentStyles1.Append(latentStyleExceptionInfo122);
            latentStyles1.Append(latentStyleExceptionInfo123);
            latentStyles1.Append(latentStyleExceptionInfo124);
            latentStyles1.Append(latentStyleExceptionInfo125);
            latentStyles1.Append(latentStyleExceptionInfo126);
            latentStyles1.Append(latentStyleExceptionInfo127);
            latentStyles1.Append(latentStyleExceptionInfo128);
            latentStyles1.Append(latentStyleExceptionInfo129);
            latentStyles1.Append(latentStyleExceptionInfo130);
            latentStyles1.Append(latentStyleExceptionInfo131);
            latentStyles1.Append(latentStyleExceptionInfo132);
            latentStyles1.Append(latentStyleExceptionInfo133);
            latentStyles1.Append(latentStyleExceptionInfo134);
            latentStyles1.Append(latentStyleExceptionInfo135);
            latentStyles1.Append(latentStyleExceptionInfo136);
            latentStyles1.Append(latentStyleExceptionInfo137);
            latentStyles1.Append(latentStyleExceptionInfo138);
            latentStyles1.Append(latentStyleExceptionInfo139);
            latentStyles1.Append(latentStyleExceptionInfo140);
            latentStyles1.Append(latentStyleExceptionInfo141);
            latentStyles1.Append(latentStyleExceptionInfo142);
            latentStyles1.Append(latentStyleExceptionInfo143);
            latentStyles1.Append(latentStyleExceptionInfo144);
            latentStyles1.Append(latentStyleExceptionInfo145);
            latentStyles1.Append(latentStyleExceptionInfo146);
            latentStyles1.Append(latentStyleExceptionInfo147);
            latentStyles1.Append(latentStyleExceptionInfo148);
            latentStyles1.Append(latentStyleExceptionInfo149);
            latentStyles1.Append(latentStyleExceptionInfo150);
            latentStyles1.Append(latentStyleExceptionInfo151);
            latentStyles1.Append(latentStyleExceptionInfo152);
            latentStyles1.Append(latentStyleExceptionInfo153);
            latentStyles1.Append(latentStyleExceptionInfo154);
            latentStyles1.Append(latentStyleExceptionInfo155);
            latentStyles1.Append(latentStyleExceptionInfo156);
            latentStyles1.Append(latentStyleExceptionInfo157);
            latentStyles1.Append(latentStyleExceptionInfo158);
            latentStyles1.Append(latentStyleExceptionInfo159);
            latentStyles1.Append(latentStyleExceptionInfo160);
            latentStyles1.Append(latentStyleExceptionInfo161);
            latentStyles1.Append(latentStyleExceptionInfo162);
            latentStyles1.Append(latentStyleExceptionInfo163);
            latentStyles1.Append(latentStyleExceptionInfo164);
            latentStyles1.Append(latentStyleExceptionInfo165);
            latentStyles1.Append(latentStyleExceptionInfo166);
            latentStyles1.Append(latentStyleExceptionInfo167);
            latentStyles1.Append(latentStyleExceptionInfo168);
            latentStyles1.Append(latentStyleExceptionInfo169);
            latentStyles1.Append(latentStyleExceptionInfo170);
            latentStyles1.Append(latentStyleExceptionInfo171);
            latentStyles1.Append(latentStyleExceptionInfo172);
            latentStyles1.Append(latentStyleExceptionInfo173);
            latentStyles1.Append(latentStyleExceptionInfo174);
            latentStyles1.Append(latentStyleExceptionInfo175);
            latentStyles1.Append(latentStyleExceptionInfo176);
            latentStyles1.Append(latentStyleExceptionInfo177);
            latentStyles1.Append(latentStyleExceptionInfo178);
            latentStyles1.Append(latentStyleExceptionInfo179);
            latentStyles1.Append(latentStyleExceptionInfo180);
            latentStyles1.Append(latentStyleExceptionInfo181);
            latentStyles1.Append(latentStyleExceptionInfo182);
            latentStyles1.Append(latentStyleExceptionInfo183);
            latentStyles1.Append(latentStyleExceptionInfo184);
            latentStyles1.Append(latentStyleExceptionInfo185);
            latentStyles1.Append(latentStyleExceptionInfo186);
            latentStyles1.Append(latentStyleExceptionInfo187);
            latentStyles1.Append(latentStyleExceptionInfo188);
            latentStyles1.Append(latentStyleExceptionInfo189);
            latentStyles1.Append(latentStyleExceptionInfo190);
            latentStyles1.Append(latentStyleExceptionInfo191);
            latentStyles1.Append(latentStyleExceptionInfo192);
            latentStyles1.Append(latentStyleExceptionInfo193);
            latentStyles1.Append(latentStyleExceptionInfo194);
            latentStyles1.Append(latentStyleExceptionInfo195);
            latentStyles1.Append(latentStyleExceptionInfo196);
            latentStyles1.Append(latentStyleExceptionInfo197);
            latentStyles1.Append(latentStyleExceptionInfo198);
            latentStyles1.Append(latentStyleExceptionInfo199);
            latentStyles1.Append(latentStyleExceptionInfo200);
            latentStyles1.Append(latentStyleExceptionInfo201);
            latentStyles1.Append(latentStyleExceptionInfo202);
            latentStyles1.Append(latentStyleExceptionInfo203);
            latentStyles1.Append(latentStyleExceptionInfo204);
            latentStyles1.Append(latentStyleExceptionInfo205);
            latentStyles1.Append(latentStyleExceptionInfo206);
            latentStyles1.Append(latentStyleExceptionInfo207);
            latentStyles1.Append(latentStyleExceptionInfo208);
            latentStyles1.Append(latentStyleExceptionInfo209);
            latentStyles1.Append(latentStyleExceptionInfo210);
            latentStyles1.Append(latentStyleExceptionInfo211);
            latentStyles1.Append(latentStyleExceptionInfo212);
            latentStyles1.Append(latentStyleExceptionInfo213);
            latentStyles1.Append(latentStyleExceptionInfo214);
            latentStyles1.Append(latentStyleExceptionInfo215);
            latentStyles1.Append(latentStyleExceptionInfo216);
            latentStyles1.Append(latentStyleExceptionInfo217);
            latentStyles1.Append(latentStyleExceptionInfo218);
            latentStyles1.Append(latentStyleExceptionInfo219);
            latentStyles1.Append(latentStyleExceptionInfo220);
            latentStyles1.Append(latentStyleExceptionInfo221);
            latentStyles1.Append(latentStyleExceptionInfo222);
            latentStyles1.Append(latentStyleExceptionInfo223);
            latentStyles1.Append(latentStyleExceptionInfo224);
            latentStyles1.Append(latentStyleExceptionInfo225);
            latentStyles1.Append(latentStyleExceptionInfo226);
            latentStyles1.Append(latentStyleExceptionInfo227);
            latentStyles1.Append(latentStyleExceptionInfo228);
            latentStyles1.Append(latentStyleExceptionInfo229);
            latentStyles1.Append(latentStyleExceptionInfo230);
            latentStyles1.Append(latentStyleExceptionInfo231);
            latentStyles1.Append(latentStyleExceptionInfo232);
            latentStyles1.Append(latentStyleExceptionInfo233);
            latentStyles1.Append(latentStyleExceptionInfo234);
            latentStyles1.Append(latentStyleExceptionInfo235);
            latentStyles1.Append(latentStyleExceptionInfo236);
            latentStyles1.Append(latentStyleExceptionInfo237);
            latentStyles1.Append(latentStyleExceptionInfo238);
            latentStyles1.Append(latentStyleExceptionInfo239);
            latentStyles1.Append(latentStyleExceptionInfo240);
            latentStyles1.Append(latentStyleExceptionInfo241);
            latentStyles1.Append(latentStyleExceptionInfo242);
            latentStyles1.Append(latentStyleExceptionInfo243);
            latentStyles1.Append(latentStyleExceptionInfo244);
            latentStyles1.Append(latentStyleExceptionInfo245);
            latentStyles1.Append(latentStyleExceptionInfo246);
            latentStyles1.Append(latentStyleExceptionInfo247);
            latentStyles1.Append(latentStyleExceptionInfo248);
            latentStyles1.Append(latentStyleExceptionInfo249);
            latentStyles1.Append(latentStyleExceptionInfo250);
            latentStyles1.Append(latentStyleExceptionInfo251);
            latentStyles1.Append(latentStyleExceptionInfo252);
            latentStyles1.Append(latentStyleExceptionInfo253);
            latentStyles1.Append(latentStyleExceptionInfo254);
            latentStyles1.Append(latentStyleExceptionInfo255);
            latentStyles1.Append(latentStyleExceptionInfo256);
            latentStyles1.Append(latentStyleExceptionInfo257);
            latentStyles1.Append(latentStyleExceptionInfo258);
            latentStyles1.Append(latentStyleExceptionInfo259);
            latentStyles1.Append(latentStyleExceptionInfo260);
            latentStyles1.Append(latentStyleExceptionInfo261);
            latentStyles1.Append(latentStyleExceptionInfo262);
            latentStyles1.Append(latentStyleExceptionInfo263);
            latentStyles1.Append(latentStyleExceptionInfo264);
            latentStyles1.Append(latentStyleExceptionInfo265);
            latentStyles1.Append(latentStyleExceptionInfo266);
            latentStyles1.Append(latentStyleExceptionInfo267);
            latentStyles1.Append(latentStyleExceptionInfo268);
            latentStyles1.Append(latentStyleExceptionInfo269);
            latentStyles1.Append(latentStyleExceptionInfo270);
            latentStyles1.Append(latentStyleExceptionInfo271);
            latentStyles1.Append(latentStyleExceptionInfo272);
            latentStyles1.Append(latentStyleExceptionInfo273);
            latentStyles1.Append(latentStyleExceptionInfo274);

            Style style1 = new Style() { Type = StyleValues.Paragraph, StyleId = "a", Default = true };
            StyleName styleName1 = new StyleName() { Val = "Normal" };
            PrimaryStyle primaryStyle1 = new PrimaryStyle();

            style1.Append(styleName1);
            style1.Append(primaryStyle1);

            Style style2 = new Style() { Type = StyleValues.Paragraph, StyleId = "1" };
            StyleName styleName2 = new StyleName() { Val = "heading 1" };
            BasedOn basedOn1 = new BasedOn() { Val = "a" };
            NextParagraphStyle nextParagraphStyle1 = new NextParagraphStyle() { Val = "a" };
            LinkedStyle linkedStyle1 = new LinkedStyle() { Val = "10" };
            PrimaryStyle primaryStyle2 = new PrimaryStyle();

            StyleParagraphProperties styleParagraphProperties1 = new StyleParagraphProperties();
            KeepNext keepNext1 = new KeepNext();
            Justification justification53 = new Justification() { Val = JustificationValues.Center };
            OutlineLevel outlineLevel1 = new OutlineLevel() { Val = 0 };

            styleParagraphProperties1.Append(keepNext1);
            styleParagraphProperties1.Append(justification53);
            styleParagraphProperties1.Append(outlineLevel1);

            StyleRunProperties styleRunProperties1 = new StyleRunProperties();
            Bold bold128 = new Bold();
            FontSize fontSize255 = new FontSize() { Val = "22" };
            Languages languages94 = new Languages() { Val = "uk-UA", EastAsia = "x-none" };

            styleRunProperties1.Append(bold128);
            styleRunProperties1.Append(fontSize255);
            styleRunProperties1.Append(languages94);

            style2.Append(styleName2);
            style2.Append(basedOn1);
            style2.Append(nextParagraphStyle1);
            style2.Append(linkedStyle1);
            style2.Append(primaryStyle2);
            style2.Append(styleParagraphProperties1);
            style2.Append(styleRunProperties1);

            Style style3 = new Style() { Type = StyleValues.Paragraph, StyleId = "2" };
            StyleName styleName3 = new StyleName() { Val = "heading 2" };
            BasedOn basedOn2 = new BasedOn() { Val = "a" };
            NextParagraphStyle nextParagraphStyle2 = new NextParagraphStyle() { Val = "a" };
            PrimaryStyle primaryStyle3 = new PrimaryStyle();

            StyleParagraphProperties styleParagraphProperties2 = new StyleParagraphProperties();
            KeepNext keepNext2 = new KeepNext();
            OutlineLevel outlineLevel2 = new OutlineLevel() { Val = 1 };

            styleParagraphProperties2.Append(keepNext2);
            styleParagraphProperties2.Append(outlineLevel2);

            StyleRunProperties styleRunProperties2 = new StyleRunProperties();
            Bold bold129 = new Bold();
            SnapToGrid snapToGrid1 = new SnapToGrid() { Val = false };
            Color color10 = new Color() { Val = "000000" };

            styleRunProperties2.Append(bold129);
            styleRunProperties2.Append(snapToGrid1);
            styleRunProperties2.Append(color10);

            style3.Append(styleName3);
            style3.Append(basedOn2);
            style3.Append(nextParagraphStyle2);
            style3.Append(primaryStyle3);
            style3.Append(styleParagraphProperties2);
            style3.Append(styleRunProperties2);

            Style style4 = new Style() { Type = StyleValues.Paragraph, StyleId = "3" };
            StyleName styleName4 = new StyleName() { Val = "heading 3" };
            BasedOn basedOn3 = new BasedOn() { Val = "a" };
            NextParagraphStyle nextParagraphStyle3 = new NextParagraphStyle() { Val = "a" };
            PrimaryStyle primaryStyle4 = new PrimaryStyle();

            StyleParagraphProperties styleParagraphProperties3 = new StyleParagraphProperties();
            KeepNext keepNext3 = new KeepNext();
            Justification justification54 = new Justification() { Val = JustificationValues.Both };
            OutlineLevel outlineLevel3 = new OutlineLevel() { Val = 2 };

            styleParagraphProperties3.Append(keepNext3);
            styleParagraphProperties3.Append(justification54);
            styleParagraphProperties3.Append(outlineLevel3);

            StyleRunProperties styleRunProperties3 = new StyleRunProperties();
            FontSize fontSize256 = new FontSize() { Val = "24" };

            styleRunProperties3.Append(fontSize256);

            style4.Append(styleName4);
            style4.Append(basedOn3);
            style4.Append(nextParagraphStyle3);
            style4.Append(primaryStyle4);
            style4.Append(styleParagraphProperties3);
            style4.Append(styleRunProperties3);

            Style style5 = new Style() { Type = StyleValues.Paragraph, StyleId = "4" };
            StyleName styleName5 = new StyleName() { Val = "heading 4" };
            BasedOn basedOn4 = new BasedOn() { Val = "a" };
            NextParagraphStyle nextParagraphStyle4 = new NextParagraphStyle() { Val = "a" };
            PrimaryStyle primaryStyle5 = new PrimaryStyle();

            StyleParagraphProperties styleParagraphProperties4 = new StyleParagraphProperties();
            KeepNext keepNext4 = new KeepNext();
            OutlineLevel outlineLevel4 = new OutlineLevel() { Val = 3 };

            styleParagraphProperties4.Append(keepNext4);
            styleParagraphProperties4.Append(outlineLevel4);

            StyleRunProperties styleRunProperties4 = new StyleRunProperties();
            FontSize fontSize257 = new FontSize() { Val = "24" };
            Languages languages95 = new Languages() { Val = "en-US" };

            styleRunProperties4.Append(fontSize257);
            styleRunProperties4.Append(languages95);

            style5.Append(styleName5);
            style5.Append(basedOn4);
            style5.Append(nextParagraphStyle4);
            style5.Append(primaryStyle5);
            style5.Append(styleParagraphProperties4);
            style5.Append(styleRunProperties4);

            Style style6 = new Style() { Type = StyleValues.Paragraph, StyleId = "5" };
            StyleName styleName6 = new StyleName() { Val = "heading 5" };
            BasedOn basedOn5 = new BasedOn() { Val = "a" };
            NextParagraphStyle nextParagraphStyle5 = new NextParagraphStyle() { Val = "a" };
            PrimaryStyle primaryStyle6 = new PrimaryStyle();

            StyleParagraphProperties styleParagraphProperties5 = new StyleParagraphProperties();
            KeepNext keepNext5 = new KeepNext();
            OutlineLevel outlineLevel5 = new OutlineLevel() { Val = 4 };

            styleParagraphProperties5.Append(keepNext5);
            styleParagraphProperties5.Append(outlineLevel5);

            StyleRunProperties styleRunProperties5 = new StyleRunProperties();
            Bold bold130 = new Bold();
            FontSize fontSize258 = new FontSize() { Val = "22" };

            styleRunProperties5.Append(bold130);
            styleRunProperties5.Append(fontSize258);

            style6.Append(styleName6);
            style6.Append(basedOn5);
            style6.Append(nextParagraphStyle5);
            style6.Append(primaryStyle6);
            style6.Append(styleParagraphProperties5);
            style6.Append(styleRunProperties5);

            Style style7 = new Style() { Type = StyleValues.Paragraph, StyleId = "6" };
            StyleName styleName7 = new StyleName() { Val = "heading 6" };
            BasedOn basedOn6 = new BasedOn() { Val = "a" };
            NextParagraphStyle nextParagraphStyle6 = new NextParagraphStyle() { Val = "a" };
            PrimaryStyle primaryStyle7 = new PrimaryStyle();

            StyleParagraphProperties styleParagraphProperties6 = new StyleParagraphProperties();
            KeepNext keepNext6 = new KeepNext();
            Justification justification55 = new Justification() { Val = JustificationValues.Center };
            OutlineLevel outlineLevel6 = new OutlineLevel() { Val = 5 };

            styleParagraphProperties6.Append(keepNext6);
            styleParagraphProperties6.Append(justification55);
            styleParagraphProperties6.Append(outlineLevel6);

            StyleRunProperties styleRunProperties6 = new StyleRunProperties();
            Bold bold131 = new Bold();
            FontSize fontSize259 = new FontSize() { Val = "24" };

            styleRunProperties6.Append(bold131);
            styleRunProperties6.Append(fontSize259);

            style7.Append(styleName7);
            style7.Append(basedOn6);
            style7.Append(nextParagraphStyle6);
            style7.Append(primaryStyle7);
            style7.Append(styleParagraphProperties6);
            style7.Append(styleRunProperties6);

            Style style8 = new Style() { Type = StyleValues.Paragraph, StyleId = "7" };
            StyleName styleName8 = new StyleName() { Val = "heading 7" };
            BasedOn basedOn7 = new BasedOn() { Val = "a" };
            NextParagraphStyle nextParagraphStyle7 = new NextParagraphStyle() { Val = "a" };
            PrimaryStyle primaryStyle8 = new PrimaryStyle();

            StyleParagraphProperties styleParagraphProperties7 = new StyleParagraphProperties();
            KeepNext keepNext7 = new KeepNext();
            OutlineLevel outlineLevel7 = new OutlineLevel() { Val = 6 };

            styleParagraphProperties7.Append(keepNext7);
            styleParagraphProperties7.Append(outlineLevel7);

            StyleRunProperties styleRunProperties7 = new StyleRunProperties();
            Bold bold132 = new Bold();
            FontSize fontSize260 = new FontSize() { Val = "24" };

            styleRunProperties7.Append(bold132);
            styleRunProperties7.Append(fontSize260);

            style8.Append(styleName8);
            style8.Append(basedOn7);
            style8.Append(nextParagraphStyle7);
            style8.Append(primaryStyle8);
            style8.Append(styleParagraphProperties7);
            style8.Append(styleRunProperties7);

            Style style9 = new Style() { Type = StyleValues.Paragraph, StyleId = "8" };
            StyleName styleName9 = new StyleName() { Val = "heading 8" };
            BasedOn basedOn8 = new BasedOn() { Val = "a" };
            NextParagraphStyle nextParagraphStyle8 = new NextParagraphStyle() { Val = "a" };
            PrimaryStyle primaryStyle9 = new PrimaryStyle();

            StyleParagraphProperties styleParagraphProperties8 = new StyleParagraphProperties();
            KeepNext keepNext8 = new KeepNext();
            Indentation indentation24 = new Indentation() { FirstLine = "851" };
            Justification justification56 = new Justification() { Val = JustificationValues.Both };
            OutlineLevel outlineLevel8 = new OutlineLevel() { Val = 7 };

            styleParagraphProperties8.Append(keepNext8);
            styleParagraphProperties8.Append(indentation24);
            styleParagraphProperties8.Append(justification56);
            styleParagraphProperties8.Append(outlineLevel8);

            StyleRunProperties styleRunProperties8 = new StyleRunProperties();
            FontSize fontSize261 = new FontSize() { Val = "28" };

            styleRunProperties8.Append(fontSize261);

            style9.Append(styleName9);
            style9.Append(basedOn8);
            style9.Append(nextParagraphStyle8);
            style9.Append(primaryStyle9);
            style9.Append(styleParagraphProperties8);
            style9.Append(styleRunProperties8);

            Style style10 = new Style() { Type = StyleValues.Paragraph, StyleId = "9" };
            StyleName styleName10 = new StyleName() { Val = "heading 9" };
            BasedOn basedOn9 = new BasedOn() { Val = "a" };
            NextParagraphStyle nextParagraphStyle9 = new NextParagraphStyle() { Val = "a" };
            PrimaryStyle primaryStyle10 = new PrimaryStyle();

            StyleParagraphProperties styleParagraphProperties9 = new StyleParagraphProperties();
            KeepNext keepNext9 = new KeepNext();
            Justification justification57 = new Justification() { Val = JustificationValues.Center };
            OutlineLevel outlineLevel9 = new OutlineLevel() { Val = 8 };

            styleParagraphProperties9.Append(keepNext9);
            styleParagraphProperties9.Append(justification57);
            styleParagraphProperties9.Append(outlineLevel9);

            StyleRunProperties styleRunProperties9 = new StyleRunProperties();
            Bold bold133 = new Bold();

            styleRunProperties9.Append(bold133);

            style10.Append(styleName10);
            style10.Append(basedOn9);
            style10.Append(nextParagraphStyle9);
            style10.Append(primaryStyle10);
            style10.Append(styleParagraphProperties9);
            style10.Append(styleRunProperties9);

            Style style11 = new Style() { Type = StyleValues.Character, StyleId = "a0", Default = true };
            StyleName styleName11 = new StyleName() { Val = "Default Paragraph Font" };
            UIPriority uIPriority1 = new UIPriority() { Val = 1 };
            SemiHidden semiHidden1 = new SemiHidden();
            UnhideWhenUsed unhideWhenUsed1 = new UnhideWhenUsed();

            style11.Append(styleName11);
            style11.Append(uIPriority1);
            style11.Append(semiHidden1);
            style11.Append(unhideWhenUsed1);

            Style style12 = new Style() { Type = StyleValues.Table, StyleId = "a1", Default = true };
            StyleName styleName12 = new StyleName() { Val = "Normal Table" };
            UIPriority uIPriority2 = new UIPriority() { Val = 99 };
            SemiHidden semiHidden2 = new SemiHidden();
            UnhideWhenUsed unhideWhenUsed2 = new UnhideWhenUsed();

            StyleTableProperties styleTableProperties1 = new StyleTableProperties();
            TableIndentation tableIndentation3 = new TableIndentation() { Width = 0, Type = TableWidthUnitValues.Dxa };

            TableCellMarginDefault tableCellMarginDefault1 = new TableCellMarginDefault();
            TopMargin topMargin1 = new TopMargin() { Width = "0", Type = TableWidthUnitValues.Dxa };
            TableCellLeftMargin tableCellLeftMargin1 = new TableCellLeftMargin() { Width = 108, Type = TableWidthValues.Dxa };
            BottomMargin bottomMargin1 = new BottomMargin() { Width = "0", Type = TableWidthUnitValues.Dxa };
            TableCellRightMargin tableCellRightMargin1 = new TableCellRightMargin() { Width = 108, Type = TableWidthValues.Dxa };

            tableCellMarginDefault1.Append(topMargin1);
            tableCellMarginDefault1.Append(tableCellLeftMargin1);
            tableCellMarginDefault1.Append(bottomMargin1);
            tableCellMarginDefault1.Append(tableCellRightMargin1);

            styleTableProperties1.Append(tableIndentation3);
            styleTableProperties1.Append(tableCellMarginDefault1);

            style12.Append(styleName12);
            style12.Append(uIPriority2);
            style12.Append(semiHidden2);
            style12.Append(unhideWhenUsed2);
            style12.Append(styleTableProperties1);

            Style style13 = new Style() { Type = StyleValues.Numbering, StyleId = "a2", Default = true };
            StyleName styleName13 = new StyleName() { Val = "No List" };
            UIPriority uIPriority3 = new UIPriority() { Val = 99 };
            SemiHidden semiHidden3 = new SemiHidden();
            UnhideWhenUsed unhideWhenUsed3 = new UnhideWhenUsed();

            style13.Append(styleName13);
            style13.Append(uIPriority3);
            style13.Append(semiHidden3);
            style13.Append(unhideWhenUsed3);

            Style style14 = new Style() { Type = StyleValues.Paragraph, StyleId = "a3" };
            StyleName styleName14 = new StyleName() { Val = "Body Text Indent" };
            BasedOn basedOn10 = new BasedOn() { Val = "a" };
            LinkedStyle linkedStyle2 = new LinkedStyle() { Val = "a4" };

            StyleParagraphProperties styleParagraphProperties10 = new StyleParagraphProperties();
            Indentation indentation25 = new Indentation() { FirstLine = "567" };
            Justification justification58 = new Justification() { Val = JustificationValues.Both };

            styleParagraphProperties10.Append(indentation25);
            styleParagraphProperties10.Append(justification58);

            StyleRunProperties styleRunProperties10 = new StyleRunProperties();
            RunFonts runFonts55 = new RunFonts() { Ascii = "Times New Roman CYR", HighAnsi = "Times New Roman CYR" };
            FontSize fontSize262 = new FontSize() { Val = "24" };
            Languages languages96 = new Languages() { Val = "x-none", EastAsia = "x-none" };

            styleRunProperties10.Append(runFonts55);
            styleRunProperties10.Append(fontSize262);
            styleRunProperties10.Append(languages96);

            style14.Append(styleName14);
            style14.Append(basedOn10);
            style14.Append(linkedStyle2);
            style14.Append(styleParagraphProperties10);
            style14.Append(styleRunProperties10);

            Style style15 = new Style() { Type = StyleValues.Paragraph, StyleId = "a5" };
            StyleName styleName15 = new StyleName() { Val = "Balloon Text" };
            BasedOn basedOn11 = new BasedOn() { Val = "a" };
            SemiHidden semiHidden4 = new SemiHidden();
            Rsid rsid1 = new Rsid() { Val = "00CF095F" };

            StyleRunProperties styleRunProperties11 = new StyleRunProperties();
            RunFonts runFonts56 = new RunFonts() { Ascii = "Tahoma", HighAnsi = "Tahoma", ComplexScript = "Tahoma" };
            FontSize fontSize263 = new FontSize() { Val = "16" };
            FontSizeComplexScript fontSizeComplexScript165 = new FontSizeComplexScript() { Val = "16" };

            styleRunProperties11.Append(runFonts56);
            styleRunProperties11.Append(fontSize263);
            styleRunProperties11.Append(fontSizeComplexScript165);

            style15.Append(styleName15);
            style15.Append(basedOn11);
            style15.Append(semiHidden4);
            style15.Append(rsid1);
            style15.Append(styleRunProperties11);

            Style style16 = new Style() { Type = StyleValues.Table, StyleId = "a6" };
            StyleName styleName16 = new StyleName() { Val = "Table Grid" };
            BasedOn basedOn12 = new BasedOn() { Val = "a1" };
            Rsid rsid2 = new Rsid() { Val = "00487986" };

            StyleTableProperties styleTableProperties2 = new StyleTableProperties();

            TableBorders tableBorders1 = new TableBorders();
            TopBorder topBorder25 = new TopBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            LeftBorder leftBorder38 = new LeftBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder36 = new BottomBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            RightBorder rightBorder38 = new RightBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            InsideHorizontalBorder insideHorizontalBorder1 = new InsideHorizontalBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            InsideVerticalBorder insideVerticalBorder1 = new InsideVerticalBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };

            tableBorders1.Append(topBorder25);
            tableBorders1.Append(leftBorder38);
            tableBorders1.Append(bottomBorder36);
            tableBorders1.Append(rightBorder38);
            tableBorders1.Append(insideHorizontalBorder1);
            tableBorders1.Append(insideVerticalBorder1);

            styleTableProperties2.Append(tableBorders1);

            style16.Append(styleName16);
            style16.Append(basedOn12);
            style16.Append(rsid2);
            style16.Append(styleTableProperties2);

            Style style17 = new Style() { Type = StyleValues.Paragraph, StyleId = "a7" };
            StyleName styleName17 = new StyleName() { Val = "No Spacing" };
            UIPriority uIPriority4 = new UIPriority() { Val = 1 };
            PrimaryStyle primaryStyle11 = new PrimaryStyle();
            Rsid rsid3 = new Rsid() { Val = "00A848C0" };

            style17.Append(styleName17);
            style17.Append(uIPriority4);
            style17.Append(primaryStyle11);
            style17.Append(rsid3);

            Style style18 = new Style() { Type = StyleValues.Character, StyleId = "10", CustomStyle = true };
            StyleName styleName18 = new StyleName() { Val = "Заголовок 1 Знак" };
            LinkedStyle linkedStyle3 = new LinkedStyle() { Val = "1" };
            Rsid rsid4 = new Rsid() { Val = "00A07F81" };

            StyleRunProperties styleRunProperties12 = new StyleRunProperties();
            Bold bold134 = new Bold();
            FontSize fontSize264 = new FontSize() { Val = "22" };
            Languages languages97 = new Languages() { Val = "uk-UA" };

            styleRunProperties12.Append(bold134);
            styleRunProperties12.Append(fontSize264);
            styleRunProperties12.Append(languages97);

            style18.Append(styleName18);
            style18.Append(linkedStyle3);
            style18.Append(rsid4);
            style18.Append(styleRunProperties12);

            Style style19 = new Style() { Type = StyleValues.Character, StyleId = "a4", CustomStyle = true };
            StyleName styleName19 = new StyleName() { Val = "Основной текст с отступом Знак" };
            LinkedStyle linkedStyle4 = new LinkedStyle() { Val = "a3" };
            Rsid rsid5 = new Rsid() { Val = "00A07F81" };

            StyleRunProperties styleRunProperties13 = new StyleRunProperties();
            RunFonts runFonts57 = new RunFonts() { Ascii = "Times New Roman CYR", HighAnsi = "Times New Roman CYR" };
            FontSize fontSize265 = new FontSize() { Val = "24" };

            styleRunProperties13.Append(runFonts57);
            styleRunProperties13.Append(fontSize265);

            style19.Append(styleName19);
            style19.Append(linkedStyle4);
            style19.Append(rsid5);
            style19.Append(styleRunProperties13);

            styles1.Append(docDefaults1);
            styles1.Append(latentStyles1);
            styles1.Append(style1);
            styles1.Append(style2);
            styles1.Append(style3);
            styles1.Append(style4);
            styles1.Append(style5);
            styles1.Append(style6);
            styles1.Append(style7);
            styles1.Append(style8);
            styles1.Append(style9);
            styles1.Append(style10);
            styles1.Append(style11);
            styles1.Append(style12);
            styles1.Append(style13);
            styles1.Append(style14);
            styles1.Append(style15);
            styles1.Append(style16);
            styles1.Append(style17);
            styles1.Append(style18);
            styles1.Append(style19);

            styleDefinitionsPart1.Styles = styles1;
        }

        // Generates content of themePart1.
        private void GenerateThemePart1Content(ThemePart themePart1)
        {
            A.Theme theme1 = new A.Theme() { Name = "Тема Office" };
            theme1.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");

            A.ThemeElements themeElements1 = new A.ThemeElements();

            A.ColorScheme colorScheme1 = new A.ColorScheme() { Name = "Стандартная" };

            A.Dark1Color dark1Color1 = new A.Dark1Color();
            A.SystemColor systemColor1 = new A.SystemColor() { Val = A.SystemColorValues.WindowText, LastColor = "000000" };

            dark1Color1.Append(systemColor1);

            A.Light1Color light1Color1 = new A.Light1Color();
            A.SystemColor systemColor2 = new A.SystemColor() { Val = A.SystemColorValues.Window, LastColor = "FFFFFF" };

            light1Color1.Append(systemColor2);

            A.Dark2Color dark2Color1 = new A.Dark2Color();
            A.RgbColorModelHex rgbColorModelHex1 = new A.RgbColorModelHex() { Val = "44546A" };

            dark2Color1.Append(rgbColorModelHex1);

            A.Light2Color light2Color1 = new A.Light2Color();
            A.RgbColorModelHex rgbColorModelHex2 = new A.RgbColorModelHex() { Val = "E7E6E6" };

            light2Color1.Append(rgbColorModelHex2);

            A.Accent1Color accent1Color1 = new A.Accent1Color();
            A.RgbColorModelHex rgbColorModelHex3 = new A.RgbColorModelHex() { Val = "5B9BD5" };

            accent1Color1.Append(rgbColorModelHex3);

            A.Accent2Color accent2Color1 = new A.Accent2Color();
            A.RgbColorModelHex rgbColorModelHex4 = new A.RgbColorModelHex() { Val = "ED7D31" };

            accent2Color1.Append(rgbColorModelHex4);

            A.Accent3Color accent3Color1 = new A.Accent3Color();
            A.RgbColorModelHex rgbColorModelHex5 = new A.RgbColorModelHex() { Val = "A5A5A5" };

            accent3Color1.Append(rgbColorModelHex5);

            A.Accent4Color accent4Color1 = new A.Accent4Color();
            A.RgbColorModelHex rgbColorModelHex6 = new A.RgbColorModelHex() { Val = "FFC000" };

            accent4Color1.Append(rgbColorModelHex6);

            A.Accent5Color accent5Color1 = new A.Accent5Color();
            A.RgbColorModelHex rgbColorModelHex7 = new A.RgbColorModelHex() { Val = "4472C4" };

            accent5Color1.Append(rgbColorModelHex7);

            A.Accent6Color accent6Color1 = new A.Accent6Color();
            A.RgbColorModelHex rgbColorModelHex8 = new A.RgbColorModelHex() { Val = "70AD47" };

            accent6Color1.Append(rgbColorModelHex8);

            A.Hyperlink hyperlink1 = new A.Hyperlink();
            A.RgbColorModelHex rgbColorModelHex9 = new A.RgbColorModelHex() { Val = "0563C1" };

            hyperlink1.Append(rgbColorModelHex9);

            A.FollowedHyperlinkColor followedHyperlinkColor1 = new A.FollowedHyperlinkColor();
            A.RgbColorModelHex rgbColorModelHex10 = new A.RgbColorModelHex() { Val = "954F72" };

            followedHyperlinkColor1.Append(rgbColorModelHex10);

            colorScheme1.Append(dark1Color1);
            colorScheme1.Append(light1Color1);
            colorScheme1.Append(dark2Color1);
            colorScheme1.Append(light2Color1);
            colorScheme1.Append(accent1Color1);
            colorScheme1.Append(accent2Color1);
            colorScheme1.Append(accent3Color1);
            colorScheme1.Append(accent4Color1);
            colorScheme1.Append(accent5Color1);
            colorScheme1.Append(accent6Color1);
            colorScheme1.Append(hyperlink1);
            colorScheme1.Append(followedHyperlinkColor1);

            A.FontScheme fontScheme1 = new A.FontScheme() { Name = "Стандартная" };

            A.MajorFont majorFont1 = new A.MajorFont();
            A.LatinFont latinFont1 = new A.LatinFont() { Typeface = "Calibri Light", Panose = "020F0302020204030204" };
            A.EastAsianFont eastAsianFont1 = new A.EastAsianFont() { Typeface = "" };
            A.ComplexScriptFont complexScriptFont1 = new A.ComplexScriptFont() { Typeface = "" };
            A.SupplementalFont supplementalFont1 = new A.SupplementalFont() { Script = "Jpan", Typeface = "ＭＳ ゴシック" };
            A.SupplementalFont supplementalFont2 = new A.SupplementalFont() { Script = "Hang", Typeface = "맑은 고딕" };
            A.SupplementalFont supplementalFont3 = new A.SupplementalFont() { Script = "Hans", Typeface = "宋体" };
            A.SupplementalFont supplementalFont4 = new A.SupplementalFont() { Script = "Hant", Typeface = "新細明體" };
            A.SupplementalFont supplementalFont5 = new A.SupplementalFont() { Script = "Arab", Typeface = "Times New Roman" };
            A.SupplementalFont supplementalFont6 = new A.SupplementalFont() { Script = "Hebr", Typeface = "Times New Roman" };
            A.SupplementalFont supplementalFont7 = new A.SupplementalFont() { Script = "Thai", Typeface = "Angsana New" };
            A.SupplementalFont supplementalFont8 = new A.SupplementalFont() { Script = "Ethi", Typeface = "Nyala" };
            A.SupplementalFont supplementalFont9 = new A.SupplementalFont() { Script = "Beng", Typeface = "Vrinda" };
            A.SupplementalFont supplementalFont10 = new A.SupplementalFont() { Script = "Gujr", Typeface = "Shruti" };
            A.SupplementalFont supplementalFont11 = new A.SupplementalFont() { Script = "Khmr", Typeface = "MoolBoran" };
            A.SupplementalFont supplementalFont12 = new A.SupplementalFont() { Script = "Knda", Typeface = "Tunga" };
            A.SupplementalFont supplementalFont13 = new A.SupplementalFont() { Script = "Guru", Typeface = "Raavi" };
            A.SupplementalFont supplementalFont14 = new A.SupplementalFont() { Script = "Cans", Typeface = "Euphemia" };
            A.SupplementalFont supplementalFont15 = new A.SupplementalFont() { Script = "Cher", Typeface = "Plantagenet Cherokee" };
            A.SupplementalFont supplementalFont16 = new A.SupplementalFont() { Script = "Yiii", Typeface = "Microsoft Yi Baiti" };
            A.SupplementalFont supplementalFont17 = new A.SupplementalFont() { Script = "Tibt", Typeface = "Microsoft Himalaya" };
            A.SupplementalFont supplementalFont18 = new A.SupplementalFont() { Script = "Thaa", Typeface = "MV Boli" };
            A.SupplementalFont supplementalFont19 = new A.SupplementalFont() { Script = "Deva", Typeface = "Mangal" };
            A.SupplementalFont supplementalFont20 = new A.SupplementalFont() { Script = "Telu", Typeface = "Gautami" };
            A.SupplementalFont supplementalFont21 = new A.SupplementalFont() { Script = "Taml", Typeface = "Latha" };
            A.SupplementalFont supplementalFont22 = new A.SupplementalFont() { Script = "Syrc", Typeface = "Estrangelo Edessa" };
            A.SupplementalFont supplementalFont23 = new A.SupplementalFont() { Script = "Orya", Typeface = "Kalinga" };
            A.SupplementalFont supplementalFont24 = new A.SupplementalFont() { Script = "Mlym", Typeface = "Kartika" };
            A.SupplementalFont supplementalFont25 = new A.SupplementalFont() { Script = "Laoo", Typeface = "DokChampa" };
            A.SupplementalFont supplementalFont26 = new A.SupplementalFont() { Script = "Sinh", Typeface = "Iskoola Pota" };
            A.SupplementalFont supplementalFont27 = new A.SupplementalFont() { Script = "Mong", Typeface = "Mongolian Baiti" };
            A.SupplementalFont supplementalFont28 = new A.SupplementalFont() { Script = "Viet", Typeface = "Times New Roman" };
            A.SupplementalFont supplementalFont29 = new A.SupplementalFont() { Script = "Uigh", Typeface = "Microsoft Uighur" };
            A.SupplementalFont supplementalFont30 = new A.SupplementalFont() { Script = "Geor", Typeface = "Sylfaen" };

            majorFont1.Append(latinFont1);
            majorFont1.Append(eastAsianFont1);
            majorFont1.Append(complexScriptFont1);
            majorFont1.Append(supplementalFont1);
            majorFont1.Append(supplementalFont2);
            majorFont1.Append(supplementalFont3);
            majorFont1.Append(supplementalFont4);
            majorFont1.Append(supplementalFont5);
            majorFont1.Append(supplementalFont6);
            majorFont1.Append(supplementalFont7);
            majorFont1.Append(supplementalFont8);
            majorFont1.Append(supplementalFont9);
            majorFont1.Append(supplementalFont10);
            majorFont1.Append(supplementalFont11);
            majorFont1.Append(supplementalFont12);
            majorFont1.Append(supplementalFont13);
            majorFont1.Append(supplementalFont14);
            majorFont1.Append(supplementalFont15);
            majorFont1.Append(supplementalFont16);
            majorFont1.Append(supplementalFont17);
            majorFont1.Append(supplementalFont18);
            majorFont1.Append(supplementalFont19);
            majorFont1.Append(supplementalFont20);
            majorFont1.Append(supplementalFont21);
            majorFont1.Append(supplementalFont22);
            majorFont1.Append(supplementalFont23);
            majorFont1.Append(supplementalFont24);
            majorFont1.Append(supplementalFont25);
            majorFont1.Append(supplementalFont26);
            majorFont1.Append(supplementalFont27);
            majorFont1.Append(supplementalFont28);
            majorFont1.Append(supplementalFont29);
            majorFont1.Append(supplementalFont30);

            A.MinorFont minorFont1 = new A.MinorFont();
            A.LatinFont latinFont2 = new A.LatinFont() { Typeface = "Calibri", Panose = "020F0502020204030204" };
            A.EastAsianFont eastAsianFont2 = new A.EastAsianFont() { Typeface = "" };
            A.ComplexScriptFont complexScriptFont2 = new A.ComplexScriptFont() { Typeface = "" };
            A.SupplementalFont supplementalFont31 = new A.SupplementalFont() { Script = "Jpan", Typeface = "ＭＳ 明朝" };
            A.SupplementalFont supplementalFont32 = new A.SupplementalFont() { Script = "Hang", Typeface = "맑은 고딕" };
            A.SupplementalFont supplementalFont33 = new A.SupplementalFont() { Script = "Hans", Typeface = "宋体" };
            A.SupplementalFont supplementalFont34 = new A.SupplementalFont() { Script = "Hant", Typeface = "新細明體" };
            A.SupplementalFont supplementalFont35 = new A.SupplementalFont() { Script = "Arab", Typeface = "Arial" };
            A.SupplementalFont supplementalFont36 = new A.SupplementalFont() { Script = "Hebr", Typeface = "Arial" };
            A.SupplementalFont supplementalFont37 = new A.SupplementalFont() { Script = "Thai", Typeface = "Cordia New" };
            A.SupplementalFont supplementalFont38 = new A.SupplementalFont() { Script = "Ethi", Typeface = "Nyala" };
            A.SupplementalFont supplementalFont39 = new A.SupplementalFont() { Script = "Beng", Typeface = "Vrinda" };
            A.SupplementalFont supplementalFont40 = new A.SupplementalFont() { Script = "Gujr", Typeface = "Shruti" };
            A.SupplementalFont supplementalFont41 = new A.SupplementalFont() { Script = "Khmr", Typeface = "DaunPenh" };
            A.SupplementalFont supplementalFont42 = new A.SupplementalFont() { Script = "Knda", Typeface = "Tunga" };
            A.SupplementalFont supplementalFont43 = new A.SupplementalFont() { Script = "Guru", Typeface = "Raavi" };
            A.SupplementalFont supplementalFont44 = new A.SupplementalFont() { Script = "Cans", Typeface = "Euphemia" };
            A.SupplementalFont supplementalFont45 = new A.SupplementalFont() { Script = "Cher", Typeface = "Plantagenet Cherokee" };
            A.SupplementalFont supplementalFont46 = new A.SupplementalFont() { Script = "Yiii", Typeface = "Microsoft Yi Baiti" };
            A.SupplementalFont supplementalFont47 = new A.SupplementalFont() { Script = "Tibt", Typeface = "Microsoft Himalaya" };
            A.SupplementalFont supplementalFont48 = new A.SupplementalFont() { Script = "Thaa", Typeface = "MV Boli" };
            A.SupplementalFont supplementalFont49 = new A.SupplementalFont() { Script = "Deva", Typeface = "Mangal" };
            A.SupplementalFont supplementalFont50 = new A.SupplementalFont() { Script = "Telu", Typeface = "Gautami" };
            A.SupplementalFont supplementalFont51 = new A.SupplementalFont() { Script = "Taml", Typeface = "Latha" };
            A.SupplementalFont supplementalFont52 = new A.SupplementalFont() { Script = "Syrc", Typeface = "Estrangelo Edessa" };
            A.SupplementalFont supplementalFont53 = new A.SupplementalFont() { Script = "Orya", Typeface = "Kalinga" };
            A.SupplementalFont supplementalFont54 = new A.SupplementalFont() { Script = "Mlym", Typeface = "Kartika" };
            A.SupplementalFont supplementalFont55 = new A.SupplementalFont() { Script = "Laoo", Typeface = "DokChampa" };
            A.SupplementalFont supplementalFont56 = new A.SupplementalFont() { Script = "Sinh", Typeface = "Iskoola Pota" };
            A.SupplementalFont supplementalFont57 = new A.SupplementalFont() { Script = "Mong", Typeface = "Mongolian Baiti" };
            A.SupplementalFont supplementalFont58 = new A.SupplementalFont() { Script = "Viet", Typeface = "Arial" };
            A.SupplementalFont supplementalFont59 = new A.SupplementalFont() { Script = "Uigh", Typeface = "Microsoft Uighur" };
            A.SupplementalFont supplementalFont60 = new A.SupplementalFont() { Script = "Geor", Typeface = "Sylfaen" };

            minorFont1.Append(latinFont2);
            minorFont1.Append(eastAsianFont2);
            minorFont1.Append(complexScriptFont2);
            minorFont1.Append(supplementalFont31);
            minorFont1.Append(supplementalFont32);
            minorFont1.Append(supplementalFont33);
            minorFont1.Append(supplementalFont34);
            minorFont1.Append(supplementalFont35);
            minorFont1.Append(supplementalFont36);
            minorFont1.Append(supplementalFont37);
            minorFont1.Append(supplementalFont38);
            minorFont1.Append(supplementalFont39);
            minorFont1.Append(supplementalFont40);
            minorFont1.Append(supplementalFont41);
            minorFont1.Append(supplementalFont42);
            minorFont1.Append(supplementalFont43);
            minorFont1.Append(supplementalFont44);
            minorFont1.Append(supplementalFont45);
            minorFont1.Append(supplementalFont46);
            minorFont1.Append(supplementalFont47);
            minorFont1.Append(supplementalFont48);
            minorFont1.Append(supplementalFont49);
            minorFont1.Append(supplementalFont50);
            minorFont1.Append(supplementalFont51);
            minorFont1.Append(supplementalFont52);
            minorFont1.Append(supplementalFont53);
            minorFont1.Append(supplementalFont54);
            minorFont1.Append(supplementalFont55);
            minorFont1.Append(supplementalFont56);
            minorFont1.Append(supplementalFont57);
            minorFont1.Append(supplementalFont58);
            minorFont1.Append(supplementalFont59);
            minorFont1.Append(supplementalFont60);

            fontScheme1.Append(majorFont1);
            fontScheme1.Append(minorFont1);

            A.FormatScheme formatScheme1 = new A.FormatScheme() { Name = "Стандартная" };

            A.FillStyleList fillStyleList1 = new A.FillStyleList();

            A.SolidFill solidFill1 = new A.SolidFill();
            A.SchemeColor schemeColor1 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };

            solidFill1.Append(schemeColor1);

            A.GradientFill gradientFill1 = new A.GradientFill() { RotateWithShape = true };

            A.GradientStopList gradientStopList1 = new A.GradientStopList();

            A.GradientStop gradientStop1 = new A.GradientStop() { Position = 0 };

            A.SchemeColor schemeColor2 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.LuminanceModulation luminanceModulation1 = new A.LuminanceModulation() { Val = 110000 };
            A.SaturationModulation saturationModulation1 = new A.SaturationModulation() { Val = 105000 };
            A.Tint tint1 = new A.Tint() { Val = 67000 };

            schemeColor2.Append(luminanceModulation1);
            schemeColor2.Append(saturationModulation1);
            schemeColor2.Append(tint1);

            gradientStop1.Append(schemeColor2);

            A.GradientStop gradientStop2 = new A.GradientStop() { Position = 50000 };

            A.SchemeColor schemeColor3 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.LuminanceModulation luminanceModulation2 = new A.LuminanceModulation() { Val = 105000 };
            A.SaturationModulation saturationModulation2 = new A.SaturationModulation() { Val = 103000 };
            A.Tint tint2 = new A.Tint() { Val = 73000 };

            schemeColor3.Append(luminanceModulation2);
            schemeColor3.Append(saturationModulation2);
            schemeColor3.Append(tint2);

            gradientStop2.Append(schemeColor3);

            A.GradientStop gradientStop3 = new A.GradientStop() { Position = 100000 };

            A.SchemeColor schemeColor4 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.LuminanceModulation luminanceModulation3 = new A.LuminanceModulation() { Val = 105000 };
            A.SaturationModulation saturationModulation3 = new A.SaturationModulation() { Val = 109000 };
            A.Tint tint3 = new A.Tint() { Val = 81000 };

            schemeColor4.Append(luminanceModulation3);
            schemeColor4.Append(saturationModulation3);
            schemeColor4.Append(tint3);

            gradientStop3.Append(schemeColor4);

            gradientStopList1.Append(gradientStop1);
            gradientStopList1.Append(gradientStop2);
            gradientStopList1.Append(gradientStop3);
            A.LinearGradientFill linearGradientFill1 = new A.LinearGradientFill() { Angle = 5400000, Scaled = false };

            gradientFill1.Append(gradientStopList1);
            gradientFill1.Append(linearGradientFill1);

            A.GradientFill gradientFill2 = new A.GradientFill() { RotateWithShape = true };

            A.GradientStopList gradientStopList2 = new A.GradientStopList();

            A.GradientStop gradientStop4 = new A.GradientStop() { Position = 0 };

            A.SchemeColor schemeColor5 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.SaturationModulation saturationModulation4 = new A.SaturationModulation() { Val = 103000 };
            A.LuminanceModulation luminanceModulation4 = new A.LuminanceModulation() { Val = 102000 };
            A.Tint tint4 = new A.Tint() { Val = 94000 };

            schemeColor5.Append(saturationModulation4);
            schemeColor5.Append(luminanceModulation4);
            schemeColor5.Append(tint4);

            gradientStop4.Append(schemeColor5);

            A.GradientStop gradientStop5 = new A.GradientStop() { Position = 50000 };

            A.SchemeColor schemeColor6 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.SaturationModulation saturationModulation5 = new A.SaturationModulation() { Val = 110000 };
            A.LuminanceModulation luminanceModulation5 = new A.LuminanceModulation() { Val = 100000 };
            A.Shade shade1 = new A.Shade() { Val = 100000 };

            schemeColor6.Append(saturationModulation5);
            schemeColor6.Append(luminanceModulation5);
            schemeColor6.Append(shade1);

            gradientStop5.Append(schemeColor6);

            A.GradientStop gradientStop6 = new A.GradientStop() { Position = 100000 };

            A.SchemeColor schemeColor7 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.LuminanceModulation luminanceModulation6 = new A.LuminanceModulation() { Val = 99000 };
            A.SaturationModulation saturationModulation6 = new A.SaturationModulation() { Val = 120000 };
            A.Shade shade2 = new A.Shade() { Val = 78000 };

            schemeColor7.Append(luminanceModulation6);
            schemeColor7.Append(saturationModulation6);
            schemeColor7.Append(shade2);

            gradientStop6.Append(schemeColor7);

            gradientStopList2.Append(gradientStop4);
            gradientStopList2.Append(gradientStop5);
            gradientStopList2.Append(gradientStop6);
            A.LinearGradientFill linearGradientFill2 = new A.LinearGradientFill() { Angle = 5400000, Scaled = false };

            gradientFill2.Append(gradientStopList2);
            gradientFill2.Append(linearGradientFill2);

            fillStyleList1.Append(solidFill1);
            fillStyleList1.Append(gradientFill1);
            fillStyleList1.Append(gradientFill2);

            A.LineStyleList lineStyleList1 = new A.LineStyleList();

            A.Outline outline1 = new A.Outline() { Width = 6350, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            A.SolidFill solidFill2 = new A.SolidFill();
            A.SchemeColor schemeColor8 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };

            solidFill2.Append(schemeColor8);
            A.PresetDash presetDash1 = new A.PresetDash() { Val = A.PresetLineDashValues.Solid };
            A.Miter miter1 = new A.Miter() { Limit = 800000 };

            outline1.Append(solidFill2);
            outline1.Append(presetDash1);
            outline1.Append(miter1);

            A.Outline outline2 = new A.Outline() { Width = 12700, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            A.SolidFill solidFill3 = new A.SolidFill();
            A.SchemeColor schemeColor9 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };

            solidFill3.Append(schemeColor9);
            A.PresetDash presetDash2 = new A.PresetDash() { Val = A.PresetLineDashValues.Solid };
            A.Miter miter2 = new A.Miter() { Limit = 800000 };

            outline2.Append(solidFill3);
            outline2.Append(presetDash2);
            outline2.Append(miter2);

            A.Outline outline3 = new A.Outline() { Width = 19050, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            A.SolidFill solidFill4 = new A.SolidFill();
            A.SchemeColor schemeColor10 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };

            solidFill4.Append(schemeColor10);
            A.PresetDash presetDash3 = new A.PresetDash() { Val = A.PresetLineDashValues.Solid };
            A.Miter miter3 = new A.Miter() { Limit = 800000 };

            outline3.Append(solidFill4);
            outline3.Append(presetDash3);
            outline3.Append(miter3);

            lineStyleList1.Append(outline1);
            lineStyleList1.Append(outline2);
            lineStyleList1.Append(outline3);

            A.EffectStyleList effectStyleList1 = new A.EffectStyleList();

            A.EffectStyle effectStyle1 = new A.EffectStyle();
            A.EffectList effectList1 = new A.EffectList();

            effectStyle1.Append(effectList1);

            A.EffectStyle effectStyle2 = new A.EffectStyle();
            A.EffectList effectList2 = new A.EffectList();

            effectStyle2.Append(effectList2);

            A.EffectStyle effectStyle3 = new A.EffectStyle();

            A.EffectList effectList3 = new A.EffectList();

            A.OuterShadow outerShadow1 = new A.OuterShadow() { BlurRadius = 57150L, Distance = 19050L, Direction = 5400000, Alignment = A.RectangleAlignmentValues.Center, RotateWithShape = false };

            A.RgbColorModelHex rgbColorModelHex11 = new A.RgbColorModelHex() { Val = "000000" };
            A.Alpha alpha1 = new A.Alpha() { Val = 63000 };

            rgbColorModelHex11.Append(alpha1);

            outerShadow1.Append(rgbColorModelHex11);

            effectList3.Append(outerShadow1);

            effectStyle3.Append(effectList3);

            effectStyleList1.Append(effectStyle1);
            effectStyleList1.Append(effectStyle2);
            effectStyleList1.Append(effectStyle3);

            A.BackgroundFillStyleList backgroundFillStyleList1 = new A.BackgroundFillStyleList();

            A.SolidFill solidFill5 = new A.SolidFill();
            A.SchemeColor schemeColor11 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };

            solidFill5.Append(schemeColor11);

            A.SolidFill solidFill6 = new A.SolidFill();

            A.SchemeColor schemeColor12 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Tint tint5 = new A.Tint() { Val = 95000 };
            A.SaturationModulation saturationModulation7 = new A.SaturationModulation() { Val = 170000 };

            schemeColor12.Append(tint5);
            schemeColor12.Append(saturationModulation7);

            solidFill6.Append(schemeColor12);

            A.GradientFill gradientFill3 = new A.GradientFill() { RotateWithShape = true };

            A.GradientStopList gradientStopList3 = new A.GradientStopList();

            A.GradientStop gradientStop7 = new A.GradientStop() { Position = 0 };

            A.SchemeColor schemeColor13 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Tint tint6 = new A.Tint() { Val = 93000 };
            A.SaturationModulation saturationModulation8 = new A.SaturationModulation() { Val = 150000 };
            A.Shade shade3 = new A.Shade() { Val = 98000 };
            A.LuminanceModulation luminanceModulation7 = new A.LuminanceModulation() { Val = 102000 };

            schemeColor13.Append(tint6);
            schemeColor13.Append(saturationModulation8);
            schemeColor13.Append(shade3);
            schemeColor13.Append(luminanceModulation7);

            gradientStop7.Append(schemeColor13);

            A.GradientStop gradientStop8 = new A.GradientStop() { Position = 50000 };

            A.SchemeColor schemeColor14 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Tint tint7 = new A.Tint() { Val = 98000 };
            A.SaturationModulation saturationModulation9 = new A.SaturationModulation() { Val = 130000 };
            A.Shade shade4 = new A.Shade() { Val = 90000 };
            A.LuminanceModulation luminanceModulation8 = new A.LuminanceModulation() { Val = 103000 };

            schemeColor14.Append(tint7);
            schemeColor14.Append(saturationModulation9);
            schemeColor14.Append(shade4);
            schemeColor14.Append(luminanceModulation8);

            gradientStop8.Append(schemeColor14);

            A.GradientStop gradientStop9 = new A.GradientStop() { Position = 100000 };

            A.SchemeColor schemeColor15 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Shade shade5 = new A.Shade() { Val = 63000 };
            A.SaturationModulation saturationModulation10 = new A.SaturationModulation() { Val = 120000 };

            schemeColor15.Append(shade5);
            schemeColor15.Append(saturationModulation10);

            gradientStop9.Append(schemeColor15);

            gradientStopList3.Append(gradientStop7);
            gradientStopList3.Append(gradientStop8);
            gradientStopList3.Append(gradientStop9);
            A.LinearGradientFill linearGradientFill3 = new A.LinearGradientFill() { Angle = 5400000, Scaled = false };

            gradientFill3.Append(gradientStopList3);
            gradientFill3.Append(linearGradientFill3);

            backgroundFillStyleList1.Append(solidFill5);
            backgroundFillStyleList1.Append(solidFill6);
            backgroundFillStyleList1.Append(gradientFill3);

            formatScheme1.Append(fillStyleList1);
            formatScheme1.Append(lineStyleList1);
            formatScheme1.Append(effectStyleList1);
            formatScheme1.Append(backgroundFillStyleList1);

            themeElements1.Append(colorScheme1);
            themeElements1.Append(fontScheme1);
            themeElements1.Append(formatScheme1);
            A.ObjectDefaults objectDefaults1 = new A.ObjectDefaults();
            A.ExtraColorSchemeList extraColorSchemeList1 = new A.ExtraColorSchemeList();

            A.OfficeStyleSheetExtensionList officeStyleSheetExtensionList1 = new A.OfficeStyleSheetExtensionList();

            A.OfficeStyleSheetExtension officeStyleSheetExtension1 = new A.OfficeStyleSheetExtension() { Uri = "{05A4C25C-085E-4340-85A3-A5531E510DB2}" };

            Thm15.ThemeFamily themeFamily1 = new Thm15.ThemeFamily() { Name = "Office Theme", Id = "{62F939B6-93AF-4DB8-9C6B-D6C7DFDC589F}", Vid = "{4A3C46E8-61CC-4603-A589-7422A47A8E4A}" };
            themeFamily1.AddNamespaceDeclaration("thm15", "http://schemas.microsoft.com/office/thememl/2012/main");

            officeStyleSheetExtension1.Append(themeFamily1);

            officeStyleSheetExtensionList1.Append(officeStyleSheetExtension1);

            theme1.Append(themeElements1);
            theme1.Append(objectDefaults1);
            theme1.Append(extraColorSchemeList1);
            theme1.Append(officeStyleSheetExtensionList1);

            themePart1.Theme = theme1;
        }

        // Generates content of numberingDefinitionsPart1.
        private void GenerateNumberingDefinitionsPart1Content(NumberingDefinitionsPart numberingDefinitionsPart1)
        {
            Numbering numbering1 = new Numbering() { MCAttributes = new MarkupCompatibilityAttributes() { Ignorable = "w14 w15 wp14" } };
            numbering1.AddNamespaceDeclaration("wpc", "http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas");
            numbering1.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            numbering1.AddNamespaceDeclaration("o", "urn:schemas-microsoft-com:office:office");
            numbering1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            numbering1.AddNamespaceDeclaration("m", "http://schemas.openxmlformats.org/officeDocument/2006/math");
            numbering1.AddNamespaceDeclaration("v", "urn:schemas-microsoft-com:vml");
            numbering1.AddNamespaceDeclaration("wp14", "http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing");
            numbering1.AddNamespaceDeclaration("wp", "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing");
            numbering1.AddNamespaceDeclaration("w10", "urn:schemas-microsoft-com:office:word");
            numbering1.AddNamespaceDeclaration("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
            numbering1.AddNamespaceDeclaration("w14", "http://schemas.microsoft.com/office/word/2010/wordml");
            numbering1.AddNamespaceDeclaration("w15", "http://schemas.microsoft.com/office/word/2012/wordml");
            numbering1.AddNamespaceDeclaration("wpg", "http://schemas.microsoft.com/office/word/2010/wordprocessingGroup");
            numbering1.AddNamespaceDeclaration("wpi", "http://schemas.microsoft.com/office/word/2010/wordprocessingInk");
            numbering1.AddNamespaceDeclaration("wne", "http://schemas.microsoft.com/office/word/2006/wordml");
            numbering1.AddNamespaceDeclaration("wps", "http://schemas.microsoft.com/office/word/2010/wordprocessingShape");

            AbstractNum abstractNum1 = new AbstractNum() { AbstractNumberId = 0 };
            abstractNum1.SetAttribute(new OpenXmlAttribute("w15", "restartNumberingAfterBreak", "http://schemas.microsoft.com/office/word/2012/wordml", "0"));
            Nsid nsid1 = new Nsid() { Val = "04561765" };
            MultiLevelType multiLevelType1 = new MultiLevelType() { Val = MultiLevelValues.SingleLevel };
            TemplateCode templateCode1 = new TemplateCode() { Val = "0419000F" };

            Level level1 = new Level() { LevelIndex = 0 };
            StartNumberingValue startNumberingValue1 = new StartNumberingValue() { Val = 1 };
            NumberingFormat numberingFormat1 = new NumberingFormat() { Val = NumberFormatValues.Decimal };
            LevelText levelText1 = new LevelText() { Val = "%1." };
            LevelJustification levelJustification1 = new LevelJustification() { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties1 = new PreviousParagraphProperties();

            Tabs tabs4 = new Tabs();
            TabStop tabStop6 = new TabStop() { Val = TabStopValues.Number, Position = 360 };

            tabs4.Append(tabStop6);
            Indentation indentation26 = new Indentation() { Start = "360", Hanging = "360" };

            previousParagraphProperties1.Append(tabs4);
            previousParagraphProperties1.Append(indentation26);

            level1.Append(startNumberingValue1);
            level1.Append(numberingFormat1);
            level1.Append(levelText1);
            level1.Append(levelJustification1);
            level1.Append(previousParagraphProperties1);

            abstractNum1.Append(nsid1);
            abstractNum1.Append(multiLevelType1);
            abstractNum1.Append(templateCode1);
            abstractNum1.Append(level1);

            AbstractNum abstractNum2 = new AbstractNum() { AbstractNumberId = 1 };
            abstractNum2.SetAttribute(new OpenXmlAttribute("w15", "restartNumberingAfterBreak", "http://schemas.microsoft.com/office/word/2012/wordml", "0"));
            Nsid nsid2 = new Nsid() { Val = "04A31573" };
            MultiLevelType multiLevelType2 = new MultiLevelType() { Val = MultiLevelValues.SingleLevel };
            TemplateCode templateCode2 = new TemplateCode() { Val = "0419000F" };

            Level level2 = new Level() { LevelIndex = 0 };
            StartNumberingValue startNumberingValue2 = new StartNumberingValue() { Val = 1 };
            NumberingFormat numberingFormat2 = new NumberingFormat() { Val = NumberFormatValues.Decimal };
            LevelText levelText2 = new LevelText() { Val = "%1." };
            LevelJustification levelJustification2 = new LevelJustification() { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties2 = new PreviousParagraphProperties();

            Tabs tabs5 = new Tabs();
            TabStop tabStop7 = new TabStop() { Val = TabStopValues.Number, Position = 360 };

            tabs5.Append(tabStop7);
            Indentation indentation27 = new Indentation() { Start = "360", Hanging = "360" };

            previousParagraphProperties2.Append(tabs5);
            previousParagraphProperties2.Append(indentation27);

            level2.Append(startNumberingValue2);
            level2.Append(numberingFormat2);
            level2.Append(levelText2);
            level2.Append(levelJustification2);
            level2.Append(previousParagraphProperties2);

            abstractNum2.Append(nsid2);
            abstractNum2.Append(multiLevelType2);
            abstractNum2.Append(templateCode2);
            abstractNum2.Append(level2);

            AbstractNum abstractNum3 = new AbstractNum() { AbstractNumberId = 2 };
            abstractNum3.SetAttribute(new OpenXmlAttribute("w15", "restartNumberingAfterBreak", "http://schemas.microsoft.com/office/word/2012/wordml", "0"));
            Nsid nsid3 = new Nsid() { Val = "05C20CCA" };
            MultiLevelType multiLevelType3 = new MultiLevelType() { Val = MultiLevelValues.SingleLevel };
            TemplateCode templateCode3 = new TemplateCode() { Val = "0419000F" };

            Level level3 = new Level() { LevelIndex = 0 };
            StartNumberingValue startNumberingValue3 = new StartNumberingValue() { Val = 1 };
            NumberingFormat numberingFormat3 = new NumberingFormat() { Val = NumberFormatValues.Decimal };
            LevelText levelText3 = new LevelText() { Val = "%1." };
            LevelJustification levelJustification3 = new LevelJustification() { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties3 = new PreviousParagraphProperties();

            Tabs tabs6 = new Tabs();
            TabStop tabStop8 = new TabStop() { Val = TabStopValues.Number, Position = 360 };

            tabs6.Append(tabStop8);
            Indentation indentation28 = new Indentation() { Start = "360", Hanging = "360" };

            previousParagraphProperties3.Append(tabs6);
            previousParagraphProperties3.Append(indentation28);

            level3.Append(startNumberingValue3);
            level3.Append(numberingFormat3);
            level3.Append(levelText3);
            level3.Append(levelJustification3);
            level3.Append(previousParagraphProperties3);

            abstractNum3.Append(nsid3);
            abstractNum3.Append(multiLevelType3);
            abstractNum3.Append(templateCode3);
            abstractNum3.Append(level3);

            AbstractNum abstractNum4 = new AbstractNum() { AbstractNumberId = 3 };
            abstractNum4.SetAttribute(new OpenXmlAttribute("w15", "restartNumberingAfterBreak", "http://schemas.microsoft.com/office/word/2012/wordml", "0"));
            Nsid nsid4 = new Nsid() { Val = "0B195E4E" };
            MultiLevelType multiLevelType4 = new MultiLevelType() { Val = MultiLevelValues.Multilevel };
            TemplateCode templateCode4 = new TemplateCode() { Val = "4F44411C" };

            Level level4 = new Level() { LevelIndex = 0 };
            StartNumberingValue startNumberingValue4 = new StartNumberingValue() { Val = 10 };
            NumberingFormat numberingFormat4 = new NumberingFormat() { Val = NumberFormatValues.Decimal };
            LevelText levelText4 = new LevelText() { Val = "" };
            LevelJustification levelJustification4 = new LevelJustification() { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties4 = new PreviousParagraphProperties();

            Tabs tabs7 = new Tabs();
            TabStop tabStop9 = new TabStop() { Val = TabStopValues.Number, Position = 360 };

            tabs7.Append(tabStop9);
            Indentation indentation29 = new Indentation() { Start = "360", Hanging = "360" };

            previousParagraphProperties4.Append(tabs7);
            previousParagraphProperties4.Append(indentation29);

            NumberingSymbolRunProperties numberingSymbolRunProperties1 = new NumberingSymbolRunProperties();
            RunFonts runFonts58 = new RunFonts() { Hint = FontTypeHintValues.Default };

            numberingSymbolRunProperties1.Append(runFonts58);

            level4.Append(startNumberingValue4);
            level4.Append(numberingFormat4);
            level4.Append(levelText4);
            level4.Append(levelJustification4);
            level4.Append(previousParagraphProperties4);
            level4.Append(numberingSymbolRunProperties1);

            Level level5 = new Level() { LevelIndex = 1 };
            StartNumberingValue startNumberingValue5 = new StartNumberingValue() { Val = 5 };
            NumberingFormat numberingFormat5 = new NumberingFormat() { Val = NumberFormatValues.Decimal };
            IsLegalNumberingStyle isLegalNumberingStyle1 = new IsLegalNumberingStyle();
            LevelText levelText5 = new LevelText() { Val = "%1.%2." };
            LevelJustification levelJustification5 = new LevelJustification() { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties5 = new PreviousParagraphProperties();

            Tabs tabs8 = new Tabs();
            TabStop tabStop10 = new TabStop() { Val = TabStopValues.Number, Position = 840 };

            tabs8.Append(tabStop10);
            Indentation indentation30 = new Indentation() { Start = "840", Hanging = "480" };

            previousParagraphProperties5.Append(tabs8);
            previousParagraphProperties5.Append(indentation30);

            NumberingSymbolRunProperties numberingSymbolRunProperties2 = new NumberingSymbolRunProperties();
            RunFonts runFonts59 = new RunFonts() { Hint = FontTypeHintValues.Default };

            numberingSymbolRunProperties2.Append(runFonts59);

            level5.Append(startNumberingValue5);
            level5.Append(numberingFormat5);
            level5.Append(isLegalNumberingStyle1);
            level5.Append(levelText5);
            level5.Append(levelJustification5);
            level5.Append(previousParagraphProperties5);
            level5.Append(numberingSymbolRunProperties2);

            Level level6 = new Level() { LevelIndex = 2 };
            StartNumberingValue startNumberingValue6 = new StartNumberingValue() { Val = 1 };
            NumberingFormat numberingFormat6 = new NumberingFormat() { Val = NumberFormatValues.Decimal };
            IsLegalNumberingStyle isLegalNumberingStyle2 = new IsLegalNumberingStyle();
            LevelText levelText6 = new LevelText() { Val = "%1.%2.%3." };
            LevelJustification levelJustification6 = new LevelJustification() { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties6 = new PreviousParagraphProperties();

            Tabs tabs9 = new Tabs();
            TabStop tabStop11 = new TabStop() { Val = TabStopValues.Number, Position = 1440 };

            tabs9.Append(tabStop11);
            Indentation indentation31 = new Indentation() { Start = "1440", Hanging = "720" };

            previousParagraphProperties6.Append(tabs9);
            previousParagraphProperties6.Append(indentation31);

            NumberingSymbolRunProperties numberingSymbolRunProperties3 = new NumberingSymbolRunProperties();
            RunFonts runFonts60 = new RunFonts() { Hint = FontTypeHintValues.Default };

            numberingSymbolRunProperties3.Append(runFonts60);

            level6.Append(startNumberingValue6);
            level6.Append(numberingFormat6);
            level6.Append(isLegalNumberingStyle2);
            level6.Append(levelText6);
            level6.Append(levelJustification6);
            level6.Append(previousParagraphProperties6);
            level6.Append(numberingSymbolRunProperties3);

            Level level7 = new Level() { LevelIndex = 3 };
            StartNumberingValue startNumberingValue7 = new StartNumberingValue() { Val = 1 };
            NumberingFormat numberingFormat7 = new NumberingFormat() { Val = NumberFormatValues.Decimal };
            IsLegalNumberingStyle isLegalNumberingStyle3 = new IsLegalNumberingStyle();
            LevelText levelText7 = new LevelText() { Val = "%1.%2.%3.%4." };
            LevelJustification levelJustification7 = new LevelJustification() { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties7 = new PreviousParagraphProperties();

            Tabs tabs10 = new Tabs();
            TabStop tabStop12 = new TabStop() { Val = TabStopValues.Number, Position = 1800 };

            tabs10.Append(tabStop12);
            Indentation indentation32 = new Indentation() { Start = "1800", Hanging = "720" };

            previousParagraphProperties7.Append(tabs10);
            previousParagraphProperties7.Append(indentation32);

            NumberingSymbolRunProperties numberingSymbolRunProperties4 = new NumberingSymbolRunProperties();
            RunFonts runFonts61 = new RunFonts() { Hint = FontTypeHintValues.Default };

            numberingSymbolRunProperties4.Append(runFonts61);

            level7.Append(startNumberingValue7);
            level7.Append(numberingFormat7);
            level7.Append(isLegalNumberingStyle3);
            level7.Append(levelText7);
            level7.Append(levelJustification7);
            level7.Append(previousParagraphProperties7);
            level7.Append(numberingSymbolRunProperties4);

            Level level8 = new Level() { LevelIndex = 4 };
            StartNumberingValue startNumberingValue8 = new StartNumberingValue() { Val = 1 };
            NumberingFormat numberingFormat8 = new NumberingFormat() { Val = NumberFormatValues.Decimal };
            IsLegalNumberingStyle isLegalNumberingStyle4 = new IsLegalNumberingStyle();
            LevelText levelText8 = new LevelText() { Val = "%1.%2.%3.%4.%5." };
            LevelJustification levelJustification8 = new LevelJustification() { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties8 = new PreviousParagraphProperties();

            Tabs tabs11 = new Tabs();
            TabStop tabStop13 = new TabStop() { Val = TabStopValues.Number, Position = 2520 };

            tabs11.Append(tabStop13);
            Indentation indentation33 = new Indentation() { Start = "2520", Hanging = "1080" };

            previousParagraphProperties8.Append(tabs11);
            previousParagraphProperties8.Append(indentation33);

            NumberingSymbolRunProperties numberingSymbolRunProperties5 = new NumberingSymbolRunProperties();
            RunFonts runFonts62 = new RunFonts() { Hint = FontTypeHintValues.Default };

            numberingSymbolRunProperties5.Append(runFonts62);

            level8.Append(startNumberingValue8);
            level8.Append(numberingFormat8);
            level8.Append(isLegalNumberingStyle4);
            level8.Append(levelText8);
            level8.Append(levelJustification8);
            level8.Append(previousParagraphProperties8);
            level8.Append(numberingSymbolRunProperties5);

            Level level9 = new Level() { LevelIndex = 5 };
            StartNumberingValue startNumberingValue9 = new StartNumberingValue() { Val = 1 };
            NumberingFormat numberingFormat9 = new NumberingFormat() { Val = NumberFormatValues.Decimal };
            IsLegalNumberingStyle isLegalNumberingStyle5 = new IsLegalNumberingStyle();
            LevelText levelText9 = new LevelText() { Val = "%1.%2.%3.%4.%5.%6." };
            LevelJustification levelJustification9 = new LevelJustification() { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties9 = new PreviousParagraphProperties();

            Tabs tabs12 = new Tabs();
            TabStop tabStop14 = new TabStop() { Val = TabStopValues.Number, Position = 2880 };

            tabs12.Append(tabStop14);
            Indentation indentation34 = new Indentation() { Start = "2880", Hanging = "1080" };

            previousParagraphProperties9.Append(tabs12);
            previousParagraphProperties9.Append(indentation34);

            NumberingSymbolRunProperties numberingSymbolRunProperties6 = new NumberingSymbolRunProperties();
            RunFonts runFonts63 = new RunFonts() { Hint = FontTypeHintValues.Default };

            numberingSymbolRunProperties6.Append(runFonts63);

            level9.Append(startNumberingValue9);
            level9.Append(numberingFormat9);
            level9.Append(isLegalNumberingStyle5);
            level9.Append(levelText9);
            level9.Append(levelJustification9);
            level9.Append(previousParagraphProperties9);
            level9.Append(numberingSymbolRunProperties6);

            Level level10 = new Level() { LevelIndex = 6 };
            StartNumberingValue startNumberingValue10 = new StartNumberingValue() { Val = 1 };
            NumberingFormat numberingFormat10 = new NumberingFormat() { Val = NumberFormatValues.Decimal };
            IsLegalNumberingStyle isLegalNumberingStyle6 = new IsLegalNumberingStyle();
            LevelText levelText10 = new LevelText() { Val = "%1.%2.%3.%4.%5.%6.%7." };
            LevelJustification levelJustification10 = new LevelJustification() { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties10 = new PreviousParagraphProperties();

            Tabs tabs13 = new Tabs();
            TabStop tabStop15 = new TabStop() { Val = TabStopValues.Number, Position = 3600 };

            tabs13.Append(tabStop15);
            Indentation indentation35 = new Indentation() { Start = "3600", Hanging = "1440" };

            previousParagraphProperties10.Append(tabs13);
            previousParagraphProperties10.Append(indentation35);

            NumberingSymbolRunProperties numberingSymbolRunProperties7 = new NumberingSymbolRunProperties();
            RunFonts runFonts64 = new RunFonts() { Hint = FontTypeHintValues.Default };

            numberingSymbolRunProperties7.Append(runFonts64);

            level10.Append(startNumberingValue10);
            level10.Append(numberingFormat10);
            level10.Append(isLegalNumberingStyle6);
            level10.Append(levelText10);
            level10.Append(levelJustification10);
            level10.Append(previousParagraphProperties10);
            level10.Append(numberingSymbolRunProperties7);

            Level level11 = new Level() { LevelIndex = 7 };
            StartNumberingValue startNumberingValue11 = new StartNumberingValue() { Val = 1 };
            NumberingFormat numberingFormat11 = new NumberingFormat() { Val = NumberFormatValues.Decimal };
            IsLegalNumberingStyle isLegalNumberingStyle7 = new IsLegalNumberingStyle();
            LevelText levelText11 = new LevelText() { Val = "%1.%2.%3.%4.%5.%6.%7.%8." };
            LevelJustification levelJustification11 = new LevelJustification() { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties11 = new PreviousParagraphProperties();

            Tabs tabs14 = new Tabs();
            TabStop tabStop16 = new TabStop() { Val = TabStopValues.Number, Position = 3960 };

            tabs14.Append(tabStop16);
            Indentation indentation36 = new Indentation() { Start = "3960", Hanging = "1440" };

            previousParagraphProperties11.Append(tabs14);
            previousParagraphProperties11.Append(indentation36);

            NumberingSymbolRunProperties numberingSymbolRunProperties8 = new NumberingSymbolRunProperties();
            RunFonts runFonts65 = new RunFonts() { Hint = FontTypeHintValues.Default };

            numberingSymbolRunProperties8.Append(runFonts65);

            level11.Append(startNumberingValue11);
            level11.Append(numberingFormat11);
            level11.Append(isLegalNumberingStyle7);
            level11.Append(levelText11);
            level11.Append(levelJustification11);
            level11.Append(previousParagraphProperties11);
            level11.Append(numberingSymbolRunProperties8);

            Level level12 = new Level() { LevelIndex = 8 };
            StartNumberingValue startNumberingValue12 = new StartNumberingValue() { Val = 1 };
            NumberingFormat numberingFormat12 = new NumberingFormat() { Val = NumberFormatValues.Decimal };
            IsLegalNumberingStyle isLegalNumberingStyle8 = new IsLegalNumberingStyle();
            LevelText levelText12 = new LevelText() { Val = "%1.%2.%3.%4.%5.%6.%7.%8.%9." };
            LevelJustification levelJustification12 = new LevelJustification() { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties12 = new PreviousParagraphProperties();

            Tabs tabs15 = new Tabs();
            TabStop tabStop17 = new TabStop() { Val = TabStopValues.Number, Position = 4680 };

            tabs15.Append(tabStop17);
            Indentation indentation37 = new Indentation() { Start = "4680", Hanging = "1800" };

            previousParagraphProperties12.Append(tabs15);
            previousParagraphProperties12.Append(indentation37);

            NumberingSymbolRunProperties numberingSymbolRunProperties9 = new NumberingSymbolRunProperties();
            RunFonts runFonts66 = new RunFonts() { Hint = FontTypeHintValues.Default };

            numberingSymbolRunProperties9.Append(runFonts66);

            level12.Append(startNumberingValue12);
            level12.Append(numberingFormat12);
            level12.Append(isLegalNumberingStyle8);
            level12.Append(levelText12);
            level12.Append(levelJustification12);
            level12.Append(previousParagraphProperties12);
            level12.Append(numberingSymbolRunProperties9);

            abstractNum4.Append(nsid4);
            abstractNum4.Append(multiLevelType4);
            abstractNum4.Append(templateCode4);
            abstractNum4.Append(level4);
            abstractNum4.Append(level5);
            abstractNum4.Append(level6);
            abstractNum4.Append(level7);
            abstractNum4.Append(level8);
            abstractNum4.Append(level9);
            abstractNum4.Append(level10);
            abstractNum4.Append(level11);
            abstractNum4.Append(level12);

            AbstractNum abstractNum5 = new AbstractNum() { AbstractNumberId = 4 };
            abstractNum5.SetAttribute(new OpenXmlAttribute("w15", "restartNumberingAfterBreak", "http://schemas.microsoft.com/office/word/2012/wordml", "0"));
            Nsid nsid5 = new Nsid() { Val = "0C746749" };
            MultiLevelType multiLevelType5 = new MultiLevelType() { Val = MultiLevelValues.SingleLevel };
            TemplateCode templateCode5 = new TemplateCode() { Val = "2B7ECF5A" };

            Level level13 = new Level() { LevelIndex = 0 };
            StartNumberingValue startNumberingValue13 = new StartNumberingValue() { Val = 7 };
            NumberingFormat numberingFormat13 = new NumberingFormat() { Val = NumberFormatValues.Bullet };
            LevelText levelText13 = new LevelText() { Val = "-" };
            LevelJustification levelJustification13 = new LevelJustification() { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties13 = new PreviousParagraphProperties();

            Tabs tabs16 = new Tabs();
            TabStop tabStop18 = new TabStop() { Val = TabStopValues.Number, Position = 1069 };

            tabs16.Append(tabStop18);
            Indentation indentation38 = new Indentation() { Start = "1069", Hanging = "360" };

            previousParagraphProperties13.Append(tabs16);
            previousParagraphProperties13.Append(indentation38);

            NumberingSymbolRunProperties numberingSymbolRunProperties10 = new NumberingSymbolRunProperties();
            RunFonts runFonts67 = new RunFonts() { Hint = FontTypeHintValues.Default };

            numberingSymbolRunProperties10.Append(runFonts67);

            level13.Append(startNumberingValue13);
            level13.Append(numberingFormat13);
            level13.Append(levelText13);
            level13.Append(levelJustification13);
            level13.Append(previousParagraphProperties13);
            level13.Append(numberingSymbolRunProperties10);

            abstractNum5.Append(nsid5);
            abstractNum5.Append(multiLevelType5);
            abstractNum5.Append(templateCode5);
            abstractNum5.Append(level13);

            AbstractNum abstractNum6 = new AbstractNum() { AbstractNumberId = 5 };
            abstractNum6.SetAttribute(new OpenXmlAttribute("w15", "restartNumberingAfterBreak", "http://schemas.microsoft.com/office/word/2012/wordml", "0"));
            Nsid nsid6 = new Nsid() { Val = "10D6103B" };
            MultiLevelType multiLevelType6 = new MultiLevelType() { Val = MultiLevelValues.Multilevel };
            TemplateCode templateCode6 = new TemplateCode() { Val = "B9DA523E" };

            Level level14 = new Level() { LevelIndex = 0 };
            StartNumberingValue startNumberingValue14 = new StartNumberingValue() { Val = 1 };
            NumberingFormat numberingFormat14 = new NumberingFormat() { Val = NumberFormatValues.Decimal };
            LevelText levelText14 = new LevelText() { Val = "%1." };
            LevelJustification levelJustification14 = new LevelJustification() { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties14 = new PreviousParagraphProperties();

            Tabs tabs17 = new Tabs();
            TabStop tabStop19 = new TabStop() { Val = TabStopValues.Number, Position = 405 };

            tabs17.Append(tabStop19);
            Indentation indentation39 = new Indentation() { Start = "405", Hanging = "405" };

            previousParagraphProperties14.Append(tabs17);
            previousParagraphProperties14.Append(indentation39);

            NumberingSymbolRunProperties numberingSymbolRunProperties11 = new NumberingSymbolRunProperties();
            RunFonts runFonts68 = new RunFonts() { Hint = FontTypeHintValues.Default };

            numberingSymbolRunProperties11.Append(runFonts68);

            level14.Append(startNumberingValue14);
            level14.Append(numberingFormat14);
            level14.Append(levelText14);
            level14.Append(levelJustification14);
            level14.Append(previousParagraphProperties14);
            level14.Append(numberingSymbolRunProperties11);

            Level level15 = new Level() { LevelIndex = 1 };
            StartNumberingValue startNumberingValue15 = new StartNumberingValue() { Val = 1 };
            NumberingFormat numberingFormat15 = new NumberingFormat() { Val = NumberFormatValues.Decimal };
            LevelText levelText15 = new LevelText() { Val = "%1.%2." };
            LevelJustification levelJustification15 = new LevelJustification() { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties15 = new PreviousParagraphProperties();

            Tabs tabs18 = new Tabs();
            TabStop tabStop20 = new TabStop() { Val = TabStopValues.Number, Position = 972 };

            tabs18.Append(tabStop20);
            Indentation indentation40 = new Indentation() { Start = "972", Hanging = "405" };

            previousParagraphProperties15.Append(tabs18);
            previousParagraphProperties15.Append(indentation40);

            NumberingSymbolRunProperties numberingSymbolRunProperties12 = new NumberingSymbolRunProperties();
            RunFonts runFonts69 = new RunFonts() { Hint = FontTypeHintValues.Default };
            Bold bold135 = new Bold() { Val = false };

            numberingSymbolRunProperties12.Append(runFonts69);
            numberingSymbolRunProperties12.Append(bold135);

            level15.Append(startNumberingValue15);
            level15.Append(numberingFormat15);
            level15.Append(levelText15);
            level15.Append(levelJustification15);
            level15.Append(previousParagraphProperties15);
            level15.Append(numberingSymbolRunProperties12);

            Level level16 = new Level() { LevelIndex = 2 };
            StartNumberingValue startNumberingValue16 = new StartNumberingValue() { Val = 1 };
            NumberingFormat numberingFormat16 = new NumberingFormat() { Val = NumberFormatValues.Decimal };
            LevelText levelText16 = new LevelText() { Val = "%1.%2.%3." };
            LevelJustification levelJustification16 = new LevelJustification() { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties16 = new PreviousParagraphProperties();

            Tabs tabs19 = new Tabs();
            TabStop tabStop21 = new TabStop() { Val = TabStopValues.Number, Position = 1854 };

            tabs19.Append(tabStop21);
            Indentation indentation41 = new Indentation() { Start = "1854", Hanging = "720" };

            previousParagraphProperties16.Append(tabs19);
            previousParagraphProperties16.Append(indentation41);

            NumberingSymbolRunProperties numberingSymbolRunProperties13 = new NumberingSymbolRunProperties();
            RunFonts runFonts70 = new RunFonts() { Hint = FontTypeHintValues.Default };

            numberingSymbolRunProperties13.Append(runFonts70);

            level16.Append(startNumberingValue16);
            level16.Append(numberingFormat16);
            level16.Append(levelText16);
            level16.Append(levelJustification16);
            level16.Append(previousParagraphProperties16);
            level16.Append(numberingSymbolRunProperties13);

            Level level17 = new Level() { LevelIndex = 3 };
            StartNumberingValue startNumberingValue17 = new StartNumberingValue() { Val = 1 };
            NumberingFormat numberingFormat17 = new NumberingFormat() { Val = NumberFormatValues.Decimal };
            LevelText levelText17 = new LevelText() { Val = "%1.%2.%3.%4." };
            LevelJustification levelJustification17 = new LevelJustification() { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties17 = new PreviousParagraphProperties();

            Tabs tabs20 = new Tabs();
            TabStop tabStop22 = new TabStop() { Val = TabStopValues.Number, Position = 2421 };

            tabs20.Append(tabStop22);
            Indentation indentation42 = new Indentation() { Start = "2421", Hanging = "720" };

            previousParagraphProperties17.Append(tabs20);
            previousParagraphProperties17.Append(indentation42);

            NumberingSymbolRunProperties numberingSymbolRunProperties14 = new NumberingSymbolRunProperties();
            RunFonts runFonts71 = new RunFonts() { Hint = FontTypeHintValues.Default };

            numberingSymbolRunProperties14.Append(runFonts71);

            level17.Append(startNumberingValue17);
            level17.Append(numberingFormat17);
            level17.Append(levelText17);
            level17.Append(levelJustification17);
            level17.Append(previousParagraphProperties17);
            level17.Append(numberingSymbolRunProperties14);

            Level level18 = new Level() { LevelIndex = 4 };
            StartNumberingValue startNumberingValue18 = new StartNumberingValue() { Val = 1 };
            NumberingFormat numberingFormat18 = new NumberingFormat() { Val = NumberFormatValues.Decimal };
            LevelText levelText18 = new LevelText() { Val = "%1.%2.%3.%4.%5." };
            LevelJustification levelJustification18 = new LevelJustification() { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties18 = new PreviousParagraphProperties();

            Tabs tabs21 = new Tabs();
            TabStop tabStop23 = new TabStop() { Val = TabStopValues.Number, Position = 3348 };

            tabs21.Append(tabStop23);
            Indentation indentation43 = new Indentation() { Start = "3348", Hanging = "1080" };

            previousParagraphProperties18.Append(tabs21);
            previousParagraphProperties18.Append(indentation43);

            NumberingSymbolRunProperties numberingSymbolRunProperties15 = new NumberingSymbolRunProperties();
            RunFonts runFonts72 = new RunFonts() { Hint = FontTypeHintValues.Default };

            numberingSymbolRunProperties15.Append(runFonts72);

            level18.Append(startNumberingValue18);
            level18.Append(numberingFormat18);
            level18.Append(levelText18);
            level18.Append(levelJustification18);
            level18.Append(previousParagraphProperties18);
            level18.Append(numberingSymbolRunProperties15);

            Level level19 = new Level() { LevelIndex = 5 };
            StartNumberingValue startNumberingValue19 = new StartNumberingValue() { Val = 1 };
            NumberingFormat numberingFormat19 = new NumberingFormat() { Val = NumberFormatValues.Decimal };
            LevelText levelText19 = new LevelText() { Val = "%1.%2.%3.%4.%5.%6." };
            LevelJustification levelJustification19 = new LevelJustification() { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties19 = new PreviousParagraphProperties();

            Tabs tabs22 = new Tabs();
            TabStop tabStop24 = new TabStop() { Val = TabStopValues.Number, Position = 3915 };

            tabs22.Append(tabStop24);
            Indentation indentation44 = new Indentation() { Start = "3915", Hanging = "1080" };

            previousParagraphProperties19.Append(tabs22);
            previousParagraphProperties19.Append(indentation44);

            NumberingSymbolRunProperties numberingSymbolRunProperties16 = new NumberingSymbolRunProperties();
            RunFonts runFonts73 = new RunFonts() { Hint = FontTypeHintValues.Default };

            numberingSymbolRunProperties16.Append(runFonts73);

            level19.Append(startNumberingValue19);
            level19.Append(numberingFormat19);
            level19.Append(levelText19);
            level19.Append(levelJustification19);
            level19.Append(previousParagraphProperties19);
            level19.Append(numberingSymbolRunProperties16);

            Level level20 = new Level() { LevelIndex = 6 };
            StartNumberingValue startNumberingValue20 = new StartNumberingValue() { Val = 1 };
            NumberingFormat numberingFormat20 = new NumberingFormat() { Val = NumberFormatValues.Decimal };
            LevelText levelText20 = new LevelText() { Val = "%1.%2.%3.%4.%5.%6.%7." };
            LevelJustification levelJustification20 = new LevelJustification() { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties20 = new PreviousParagraphProperties();

            Tabs tabs23 = new Tabs();
            TabStop tabStop25 = new TabStop() { Val = TabStopValues.Number, Position = 4842 };

            tabs23.Append(tabStop25);
            Indentation indentation45 = new Indentation() { Start = "4842", Hanging = "1440" };

            previousParagraphProperties20.Append(tabs23);
            previousParagraphProperties20.Append(indentation45);

            NumberingSymbolRunProperties numberingSymbolRunProperties17 = new NumberingSymbolRunProperties();
            RunFonts runFonts74 = new RunFonts() { Hint = FontTypeHintValues.Default };

            numberingSymbolRunProperties17.Append(runFonts74);

            level20.Append(startNumberingValue20);
            level20.Append(numberingFormat20);
            level20.Append(levelText20);
            level20.Append(levelJustification20);
            level20.Append(previousParagraphProperties20);
            level20.Append(numberingSymbolRunProperties17);

            Level level21 = new Level() { LevelIndex = 7 };
            StartNumberingValue startNumberingValue21 = new StartNumberingValue() { Val = 1 };
            NumberingFormat numberingFormat21 = new NumberingFormat() { Val = NumberFormatValues.Decimal };
            LevelText levelText21 = new LevelText() { Val = "%1.%2.%3.%4.%5.%6.%7.%8." };
            LevelJustification levelJustification21 = new LevelJustification() { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties21 = new PreviousParagraphProperties();

            Tabs tabs24 = new Tabs();
            TabStop tabStop26 = new TabStop() { Val = TabStopValues.Number, Position = 5409 };

            tabs24.Append(tabStop26);
            Indentation indentation46 = new Indentation() { Start = "5409", Hanging = "1440" };

            previousParagraphProperties21.Append(tabs24);
            previousParagraphProperties21.Append(indentation46);

            NumberingSymbolRunProperties numberingSymbolRunProperties18 = new NumberingSymbolRunProperties();
            RunFonts runFonts75 = new RunFonts() { Hint = FontTypeHintValues.Default };

            numberingSymbolRunProperties18.Append(runFonts75);

            level21.Append(startNumberingValue21);
            level21.Append(numberingFormat21);
            level21.Append(levelText21);
            level21.Append(levelJustification21);
            level21.Append(previousParagraphProperties21);
            level21.Append(numberingSymbolRunProperties18);

            Level level22 = new Level() { LevelIndex = 8 };
            StartNumberingValue startNumberingValue22 = new StartNumberingValue() { Val = 1 };
            NumberingFormat numberingFormat22 = new NumberingFormat() { Val = NumberFormatValues.Decimal };
            LevelText levelText22 = new LevelText() { Val = "%1.%2.%3.%4.%5.%6.%7.%8.%9." };
            LevelJustification levelJustification22 = new LevelJustification() { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties22 = new PreviousParagraphProperties();

            Tabs tabs25 = new Tabs();
            TabStop tabStop27 = new TabStop() { Val = TabStopValues.Number, Position = 6336 };

            tabs25.Append(tabStop27);
            Indentation indentation47 = new Indentation() { Start = "6336", Hanging = "1800" };

            previousParagraphProperties22.Append(tabs25);
            previousParagraphProperties22.Append(indentation47);

            NumberingSymbolRunProperties numberingSymbolRunProperties19 = new NumberingSymbolRunProperties();
            RunFonts runFonts76 = new RunFonts() { Hint = FontTypeHintValues.Default };

            numberingSymbolRunProperties19.Append(runFonts76);

            level22.Append(startNumberingValue22);
            level22.Append(numberingFormat22);
            level22.Append(levelText22);
            level22.Append(levelJustification22);
            level22.Append(previousParagraphProperties22);
            level22.Append(numberingSymbolRunProperties19);

            abstractNum6.Append(nsid6);
            abstractNum6.Append(multiLevelType6);
            abstractNum6.Append(templateCode6);
            abstractNum6.Append(level14);
            abstractNum6.Append(level15);
            abstractNum6.Append(level16);
            abstractNum6.Append(level17);
            abstractNum6.Append(level18);
            abstractNum6.Append(level19);
            abstractNum6.Append(level20);
            abstractNum6.Append(level21);
            abstractNum6.Append(level22);

            AbstractNum abstractNum7 = new AbstractNum() { AbstractNumberId = 6 };
            abstractNum7.SetAttribute(new OpenXmlAttribute("w15", "restartNumberingAfterBreak", "http://schemas.microsoft.com/office/word/2012/wordml", "0"));
            Nsid nsid7 = new Nsid() { Val = "1FA94F35" };
            MultiLevelType multiLevelType7 = new MultiLevelType() { Val = MultiLevelValues.SingleLevel };
            TemplateCode templateCode7 = new TemplateCode() { Val = "0419000F" };

            Level level23 = new Level() { LevelIndex = 0 };
            StartNumberingValue startNumberingValue23 = new StartNumberingValue() { Val = 1 };
            NumberingFormat numberingFormat23 = new NumberingFormat() { Val = NumberFormatValues.Decimal };
            LevelText levelText23 = new LevelText() { Val = "%1." };
            LevelJustification levelJustification23 = new LevelJustification() { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties23 = new PreviousParagraphProperties();

            Tabs tabs26 = new Tabs();
            TabStop tabStop28 = new TabStop() { Val = TabStopValues.Number, Position = 360 };

            tabs26.Append(tabStop28);
            Indentation indentation48 = new Indentation() { Start = "360", Hanging = "360" };

            previousParagraphProperties23.Append(tabs26);
            previousParagraphProperties23.Append(indentation48);

            level23.Append(startNumberingValue23);
            level23.Append(numberingFormat23);
            level23.Append(levelText23);
            level23.Append(levelJustification23);
            level23.Append(previousParagraphProperties23);

            abstractNum7.Append(nsid7);
            abstractNum7.Append(multiLevelType7);
            abstractNum7.Append(templateCode7);
            abstractNum7.Append(level23);

            AbstractNum abstractNum8 = new AbstractNum() { AbstractNumberId = 7 };
            abstractNum8.SetAttribute(new OpenXmlAttribute("w15", "restartNumberingAfterBreak", "http://schemas.microsoft.com/office/word/2012/wordml", "0"));
            Nsid nsid8 = new Nsid() { Val = "3742171F" };
            MultiLevelType multiLevelType8 = new MultiLevelType() { Val = MultiLevelValues.SingleLevel };
            TemplateCode templateCode8 = new TemplateCode() { Val = "52B2F148" };

            Level level24 = new Level() { LevelIndex = 0 };
            StartNumberingValue startNumberingValue24 = new StartNumberingValue() { Val = 7 };
            NumberingFormat numberingFormat24 = new NumberingFormat() { Val = NumberFormatValues.Bullet };
            LevelText levelText24 = new LevelText() { Val = "-" };
            LevelJustification levelJustification24 = new LevelJustification() { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties24 = new PreviousParagraphProperties();

            Tabs tabs27 = new Tabs();
            TabStop tabStop29 = new TabStop() { Val = TabStopValues.Number, Position = 1069 };

            tabs27.Append(tabStop29);
            Indentation indentation49 = new Indentation() { Start = "1069", Hanging = "360" };

            previousParagraphProperties24.Append(tabs27);
            previousParagraphProperties24.Append(indentation49);

            NumberingSymbolRunProperties numberingSymbolRunProperties20 = new NumberingSymbolRunProperties();
            RunFonts runFonts77 = new RunFonts() { Hint = FontTypeHintValues.Default };

            numberingSymbolRunProperties20.Append(runFonts77);

            level24.Append(startNumberingValue24);
            level24.Append(numberingFormat24);
            level24.Append(levelText24);
            level24.Append(levelJustification24);
            level24.Append(previousParagraphProperties24);
            level24.Append(numberingSymbolRunProperties20);

            abstractNum8.Append(nsid8);
            abstractNum8.Append(multiLevelType8);
            abstractNum8.Append(templateCode8);
            abstractNum8.Append(level24);

            AbstractNum abstractNum9 = new AbstractNum() { AbstractNumberId = 8 };
            abstractNum9.SetAttribute(new OpenXmlAttribute("w15", "restartNumberingAfterBreak", "http://schemas.microsoft.com/office/word/2012/wordml", "0"));
            Nsid nsid9 = new Nsid() { Val = "3894426F" };
            MultiLevelType multiLevelType9 = new MultiLevelType() { Val = MultiLevelValues.SingleLevel };
            TemplateCode templateCode9 = new TemplateCode() { Val = "D690D41C" };

            Level level25 = new Level() { LevelIndex = 0 };
            StartNumberingValue startNumberingValue25 = new StartNumberingValue() { Val = 4 };
            NumberingFormat numberingFormat25 = new NumberingFormat() { Val = NumberFormatValues.Bullet };
            LevelText levelText25 = new LevelText() { Val = "-" };
            LevelJustification levelJustification25 = new LevelJustification() { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties25 = new PreviousParagraphProperties();

            Tabs tabs28 = new Tabs();
            TabStop tabStop30 = new TabStop() { Val = TabStopValues.Number, Position = 360 };

            tabs28.Append(tabStop30);
            Indentation indentation50 = new Indentation() { Start = "360", Hanging = "360" };

            previousParagraphProperties25.Append(tabs28);
            previousParagraphProperties25.Append(indentation50);

            NumberingSymbolRunProperties numberingSymbolRunProperties21 = new NumberingSymbolRunProperties();
            RunFonts runFonts78 = new RunFonts() { Hint = FontTypeHintValues.Default };

            numberingSymbolRunProperties21.Append(runFonts78);

            level25.Append(startNumberingValue25);
            level25.Append(numberingFormat25);
            level25.Append(levelText25);
            level25.Append(levelJustification25);
            level25.Append(previousParagraphProperties25);
            level25.Append(numberingSymbolRunProperties21);

            abstractNum9.Append(nsid9);
            abstractNum9.Append(multiLevelType9);
            abstractNum9.Append(templateCode9);
            abstractNum9.Append(level25);

            AbstractNum abstractNum10 = new AbstractNum() { AbstractNumberId = 9 };
            abstractNum10.SetAttribute(new OpenXmlAttribute("w15", "restartNumberingAfterBreak", "http://schemas.microsoft.com/office/word/2012/wordml", "0"));
            Nsid nsid10 = new Nsid() { Val = "448F6882" };
            MultiLevelType multiLevelType10 = new MultiLevelType() { Val = MultiLevelValues.SingleLevel };
            TemplateCode templateCode10 = new TemplateCode() { Val = "E9A4BB50" };

            Level level26 = new Level() { LevelIndex = 0 };
            StartNumberingValue startNumberingValue26 = new StartNumberingValue() { Val = 1 };
            NumberingFormat numberingFormat26 = new NumberingFormat() { Val = NumberFormatValues.Bullet };
            LevelText levelText26 = new LevelText() { Val = "Ш" };
            LevelJustification levelJustification26 = new LevelJustification() { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties26 = new PreviousParagraphProperties();

            Tabs tabs29 = new Tabs();
            TabStop tabStop31 = new TabStop() { Val = TabStopValues.Number, Position = 360 };

            tabs29.Append(tabStop31);
            Indentation indentation51 = new Indentation() { Start = "360", Hanging = "360" };

            previousParagraphProperties26.Append(tabs29);
            previousParagraphProperties26.Append(indentation51);

            NumberingSymbolRunProperties numberingSymbolRunProperties22 = new NumberingSymbolRunProperties();
            RunFonts runFonts79 = new RunFonts() { Hint = FontTypeHintValues.Default, Ascii = "Wingdings", HighAnsi = "Wingdings" };

            numberingSymbolRunProperties22.Append(runFonts79);

            level26.Append(startNumberingValue26);
            level26.Append(numberingFormat26);
            level26.Append(levelText26);
            level26.Append(levelJustification26);
            level26.Append(previousParagraphProperties26);
            level26.Append(numberingSymbolRunProperties22);

            abstractNum10.Append(nsid10);
            abstractNum10.Append(multiLevelType10);
            abstractNum10.Append(templateCode10);
            abstractNum10.Append(level26);

            AbstractNum abstractNum11 = new AbstractNum() { AbstractNumberId = 10 };
            abstractNum11.SetAttribute(new OpenXmlAttribute("w15", "restartNumberingAfterBreak", "http://schemas.microsoft.com/office/word/2012/wordml", "0"));
            Nsid nsid11 = new Nsid() { Val = "45174814" };
            MultiLevelType multiLevelType11 = new MultiLevelType() { Val = MultiLevelValues.Multilevel };
            TemplateCode templateCode11 = new TemplateCode() { Val = "D1FE8630" };

            Level level27 = new Level() { LevelIndex = 0 };
            StartNumberingValue startNumberingValue27 = new StartNumberingValue() { Val = 1 };
            NumberingFormat numberingFormat27 = new NumberingFormat() { Val = NumberFormatValues.Decimal };
            LevelText levelText27 = new LevelText() { Val = "%1." };
            LevelJustification levelJustification27 = new LevelJustification() { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties27 = new PreviousParagraphProperties();

            Tabs tabs30 = new Tabs();
            TabStop tabStop32 = new TabStop() { Val = TabStopValues.Number, Position = 360 };

            tabs30.Append(tabStop32);
            Indentation indentation52 = new Indentation() { Start = "360", Hanging = "360" };

            previousParagraphProperties27.Append(tabs30);
            previousParagraphProperties27.Append(indentation52);

            NumberingSymbolRunProperties numberingSymbolRunProperties23 = new NumberingSymbolRunProperties();
            RunFonts runFonts80 = new RunFonts() { Hint = FontTypeHintValues.Default };

            numberingSymbolRunProperties23.Append(runFonts80);

            level27.Append(startNumberingValue27);
            level27.Append(numberingFormat27);
            level27.Append(levelText27);
            level27.Append(levelJustification27);
            level27.Append(previousParagraphProperties27);
            level27.Append(numberingSymbolRunProperties23);

            Level level28 = new Level() { LevelIndex = 1 };
            StartNumberingValue startNumberingValue28 = new StartNumberingValue() { Val = 1 };
            NumberingFormat numberingFormat28 = new NumberingFormat() { Val = NumberFormatValues.Decimal };
            IsLegalNumberingStyle isLegalNumberingStyle9 = new IsLegalNumberingStyle();
            LevelText levelText28 = new LevelText() { Val = "%1.%2." };
            LevelJustification levelJustification28 = new LevelJustification() { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties28 = new PreviousParagraphProperties();

            Tabs tabs31 = new Tabs();
            TabStop tabStop33 = new TabStop() { Val = TabStopValues.Number, Position = 435 };

            tabs31.Append(tabStop33);
            Indentation indentation53 = new Indentation() { Start = "435", Hanging = "435" };

            previousParagraphProperties28.Append(tabs31);
            previousParagraphProperties28.Append(indentation53);

            NumberingSymbolRunProperties numberingSymbolRunProperties24 = new NumberingSymbolRunProperties();
            RunFonts runFonts81 = new RunFonts() { Hint = FontTypeHintValues.Default };

            numberingSymbolRunProperties24.Append(runFonts81);

            level28.Append(startNumberingValue28);
            level28.Append(numberingFormat28);
            level28.Append(isLegalNumberingStyle9);
            level28.Append(levelText28);
            level28.Append(levelJustification28);
            level28.Append(previousParagraphProperties28);
            level28.Append(numberingSymbolRunProperties24);

            Level level29 = new Level() { LevelIndex = 2 };
            StartNumberingValue startNumberingValue29 = new StartNumberingValue() { Val = 1 };
            NumberingFormat numberingFormat29 = new NumberingFormat() { Val = NumberFormatValues.Decimal };
            IsLegalNumberingStyle isLegalNumberingStyle10 = new IsLegalNumberingStyle();
            LevelText levelText29 = new LevelText() { Val = "%1.%2.%3." };
            LevelJustification levelJustification29 = new LevelJustification() { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties29 = new PreviousParagraphProperties();

            Tabs tabs32 = new Tabs();
            TabStop tabStop34 = new TabStop() { Val = TabStopValues.Number, Position = 720 };

            tabs32.Append(tabStop34);
            Indentation indentation54 = new Indentation() { Start = "720", Hanging = "720" };

            previousParagraphProperties29.Append(tabs32);
            previousParagraphProperties29.Append(indentation54);

            NumberingSymbolRunProperties numberingSymbolRunProperties25 = new NumberingSymbolRunProperties();
            RunFonts runFonts82 = new RunFonts() { Hint = FontTypeHintValues.Default };

            numberingSymbolRunProperties25.Append(runFonts82);

            level29.Append(startNumberingValue29);
            level29.Append(numberingFormat29);
            level29.Append(isLegalNumberingStyle10);
            level29.Append(levelText29);
            level29.Append(levelJustification29);
            level29.Append(previousParagraphProperties29);
            level29.Append(numberingSymbolRunProperties25);

            Level level30 = new Level() { LevelIndex = 3 };
            StartNumberingValue startNumberingValue30 = new StartNumberingValue() { Val = 1 };
            NumberingFormat numberingFormat30 = new NumberingFormat() { Val = NumberFormatValues.Decimal };
            IsLegalNumberingStyle isLegalNumberingStyle11 = new IsLegalNumberingStyle();
            LevelText levelText30 = new LevelText() { Val = "%1.%2.%3.%4." };
            LevelJustification levelJustification30 = new LevelJustification() { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties30 = new PreviousParagraphProperties();

            Tabs tabs33 = new Tabs();
            TabStop tabStop35 = new TabStop() { Val = TabStopValues.Number, Position = 720 };

            tabs33.Append(tabStop35);
            Indentation indentation55 = new Indentation() { Start = "720", Hanging = "720" };

            previousParagraphProperties30.Append(tabs33);
            previousParagraphProperties30.Append(indentation55);

            NumberingSymbolRunProperties numberingSymbolRunProperties26 = new NumberingSymbolRunProperties();
            RunFonts runFonts83 = new RunFonts() { Hint = FontTypeHintValues.Default };

            numberingSymbolRunProperties26.Append(runFonts83);

            level30.Append(startNumberingValue30);
            level30.Append(numberingFormat30);
            level30.Append(isLegalNumberingStyle11);
            level30.Append(levelText30);
            level30.Append(levelJustification30);
            level30.Append(previousParagraphProperties30);
            level30.Append(numberingSymbolRunProperties26);

            Level level31 = new Level() { LevelIndex = 4 };
            StartNumberingValue startNumberingValue31 = new StartNumberingValue() { Val = 1 };
            NumberingFormat numberingFormat31 = new NumberingFormat() { Val = NumberFormatValues.Decimal };
            IsLegalNumberingStyle isLegalNumberingStyle12 = new IsLegalNumberingStyle();
            LevelText levelText31 = new LevelText() { Val = "%1.%2.%3.%4.%5." };
            LevelJustification levelJustification31 = new LevelJustification() { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties31 = new PreviousParagraphProperties();

            Tabs tabs34 = new Tabs();
            TabStop tabStop36 = new TabStop() { Val = TabStopValues.Number, Position = 1080 };

            tabs34.Append(tabStop36);
            Indentation indentation56 = new Indentation() { Start = "1080", Hanging = "1080" };

            previousParagraphProperties31.Append(tabs34);
            previousParagraphProperties31.Append(indentation56);

            NumberingSymbolRunProperties numberingSymbolRunProperties27 = new NumberingSymbolRunProperties();
            RunFonts runFonts84 = new RunFonts() { Hint = FontTypeHintValues.Default };

            numberingSymbolRunProperties27.Append(runFonts84);

            level31.Append(startNumberingValue31);
            level31.Append(numberingFormat31);
            level31.Append(isLegalNumberingStyle12);
            level31.Append(levelText31);
            level31.Append(levelJustification31);
            level31.Append(previousParagraphProperties31);
            level31.Append(numberingSymbolRunProperties27);

            Level level32 = new Level() { LevelIndex = 5 };
            StartNumberingValue startNumberingValue32 = new StartNumberingValue() { Val = 1 };
            NumberingFormat numberingFormat32 = new NumberingFormat() { Val = NumberFormatValues.Decimal };
            IsLegalNumberingStyle isLegalNumberingStyle13 = new IsLegalNumberingStyle();
            LevelText levelText32 = new LevelText() { Val = "%1.%2.%3.%4.%5.%6." };
            LevelJustification levelJustification32 = new LevelJustification() { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties32 = new PreviousParagraphProperties();

            Tabs tabs35 = new Tabs();
            TabStop tabStop37 = new TabStop() { Val = TabStopValues.Number, Position = 1080 };

            tabs35.Append(tabStop37);
            Indentation indentation57 = new Indentation() { Start = "1080", Hanging = "1080" };

            previousParagraphProperties32.Append(tabs35);
            previousParagraphProperties32.Append(indentation57);

            NumberingSymbolRunProperties numberingSymbolRunProperties28 = new NumberingSymbolRunProperties();
            RunFonts runFonts85 = new RunFonts() { Hint = FontTypeHintValues.Default };

            numberingSymbolRunProperties28.Append(runFonts85);

            level32.Append(startNumberingValue32);
            level32.Append(numberingFormat32);
            level32.Append(isLegalNumberingStyle13);
            level32.Append(levelText32);
            level32.Append(levelJustification32);
            level32.Append(previousParagraphProperties32);
            level32.Append(numberingSymbolRunProperties28);

            Level level33 = new Level() { LevelIndex = 6 };
            StartNumberingValue startNumberingValue33 = new StartNumberingValue() { Val = 1 };
            NumberingFormat numberingFormat33 = new NumberingFormat() { Val = NumberFormatValues.Decimal };
            IsLegalNumberingStyle isLegalNumberingStyle14 = new IsLegalNumberingStyle();
            LevelText levelText33 = new LevelText() { Val = "%1.%2.%3.%4.%5.%6.%7." };
            LevelJustification levelJustification33 = new LevelJustification() { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties33 = new PreviousParagraphProperties();

            Tabs tabs36 = new Tabs();
            TabStop tabStop38 = new TabStop() { Val = TabStopValues.Number, Position = 1440 };

            tabs36.Append(tabStop38);
            Indentation indentation58 = new Indentation() { Start = "1440", Hanging = "1440" };

            previousParagraphProperties33.Append(tabs36);
            previousParagraphProperties33.Append(indentation58);

            NumberingSymbolRunProperties numberingSymbolRunProperties29 = new NumberingSymbolRunProperties();
            RunFonts runFonts86 = new RunFonts() { Hint = FontTypeHintValues.Default };

            numberingSymbolRunProperties29.Append(runFonts86);

            level33.Append(startNumberingValue33);
            level33.Append(numberingFormat33);
            level33.Append(isLegalNumberingStyle14);
            level33.Append(levelText33);
            level33.Append(levelJustification33);
            level33.Append(previousParagraphProperties33);
            level33.Append(numberingSymbolRunProperties29);

            Level level34 = new Level() { LevelIndex = 7 };
            StartNumberingValue startNumberingValue34 = new StartNumberingValue() { Val = 1 };
            NumberingFormat numberingFormat34 = new NumberingFormat() { Val = NumberFormatValues.Decimal };
            IsLegalNumberingStyle isLegalNumberingStyle15 = new IsLegalNumberingStyle();
            LevelText levelText34 = new LevelText() { Val = "%1.%2.%3.%4.%5.%6.%7.%8." };
            LevelJustification levelJustification34 = new LevelJustification() { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties34 = new PreviousParagraphProperties();

            Tabs tabs37 = new Tabs();
            TabStop tabStop39 = new TabStop() { Val = TabStopValues.Number, Position = 1440 };

            tabs37.Append(tabStop39);
            Indentation indentation59 = new Indentation() { Start = "1440", Hanging = "1440" };

            previousParagraphProperties34.Append(tabs37);
            previousParagraphProperties34.Append(indentation59);

            NumberingSymbolRunProperties numberingSymbolRunProperties30 = new NumberingSymbolRunProperties();
            RunFonts runFonts87 = new RunFonts() { Hint = FontTypeHintValues.Default };

            numberingSymbolRunProperties30.Append(runFonts87);

            level34.Append(startNumberingValue34);
            level34.Append(numberingFormat34);
            level34.Append(isLegalNumberingStyle15);
            level34.Append(levelText34);
            level34.Append(levelJustification34);
            level34.Append(previousParagraphProperties34);
            level34.Append(numberingSymbolRunProperties30);

            Level level35 = new Level() { LevelIndex = 8 };
            StartNumberingValue startNumberingValue35 = new StartNumberingValue() { Val = 1 };
            NumberingFormat numberingFormat35 = new NumberingFormat() { Val = NumberFormatValues.Decimal };
            IsLegalNumberingStyle isLegalNumberingStyle16 = new IsLegalNumberingStyle();
            LevelText levelText35 = new LevelText() { Val = "%1.%2.%3.%4.%5.%6.%7.%8.%9." };
            LevelJustification levelJustification35 = new LevelJustification() { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties35 = new PreviousParagraphProperties();

            Tabs tabs38 = new Tabs();
            TabStop tabStop40 = new TabStop() { Val = TabStopValues.Number, Position = 1800 };

            tabs38.Append(tabStop40);
            Indentation indentation60 = new Indentation() { Start = "1800", Hanging = "1800" };

            previousParagraphProperties35.Append(tabs38);
            previousParagraphProperties35.Append(indentation60);

            NumberingSymbolRunProperties numberingSymbolRunProperties31 = new NumberingSymbolRunProperties();
            RunFonts runFonts88 = new RunFonts() { Hint = FontTypeHintValues.Default };

            numberingSymbolRunProperties31.Append(runFonts88);

            level35.Append(startNumberingValue35);
            level35.Append(numberingFormat35);
            level35.Append(isLegalNumberingStyle16);
            level35.Append(levelText35);
            level35.Append(levelJustification35);
            level35.Append(previousParagraphProperties35);
            level35.Append(numberingSymbolRunProperties31);

            abstractNum11.Append(nsid11);
            abstractNum11.Append(multiLevelType11);
            abstractNum11.Append(templateCode11);
            abstractNum11.Append(level27);
            abstractNum11.Append(level28);
            abstractNum11.Append(level29);
            abstractNum11.Append(level30);
            abstractNum11.Append(level31);
            abstractNum11.Append(level32);
            abstractNum11.Append(level33);
            abstractNum11.Append(level34);
            abstractNum11.Append(level35);

            AbstractNum abstractNum12 = new AbstractNum() { AbstractNumberId = 11 };
            abstractNum12.SetAttribute(new OpenXmlAttribute("w15", "restartNumberingAfterBreak", "http://schemas.microsoft.com/office/word/2012/wordml", "0"));
            Nsid nsid12 = new Nsid() { Val = "4E962847" };
            MultiLevelType multiLevelType12 = new MultiLevelType() { Val = MultiLevelValues.SingleLevel };
            TemplateCode templateCode12 = new TemplateCode() { Val = "0419000F" };

            Level level36 = new Level() { LevelIndex = 0 };
            StartNumberingValue startNumberingValue36 = new StartNumberingValue() { Val = 1 };
            NumberingFormat numberingFormat36 = new NumberingFormat() { Val = NumberFormatValues.Decimal };
            LevelText levelText36 = new LevelText() { Val = "%1." };
            LevelJustification levelJustification36 = new LevelJustification() { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties36 = new PreviousParagraphProperties();

            Tabs tabs39 = new Tabs();
            TabStop tabStop41 = new TabStop() { Val = TabStopValues.Number, Position = 360 };

            tabs39.Append(tabStop41);
            Indentation indentation61 = new Indentation() { Start = "360", Hanging = "360" };

            previousParagraphProperties36.Append(tabs39);
            previousParagraphProperties36.Append(indentation61);

            level36.Append(startNumberingValue36);
            level36.Append(numberingFormat36);
            level36.Append(levelText36);
            level36.Append(levelJustification36);
            level36.Append(previousParagraphProperties36);

            abstractNum12.Append(nsid12);
            abstractNum12.Append(multiLevelType12);
            abstractNum12.Append(templateCode12);
            abstractNum12.Append(level36);

            AbstractNum abstractNum13 = new AbstractNum() { AbstractNumberId = 12 };
            abstractNum13.SetAttribute(new OpenXmlAttribute("w15", "restartNumberingAfterBreak", "http://schemas.microsoft.com/office/word/2012/wordml", "0"));
            Nsid nsid13 = new Nsid() { Val = "55D50BFB" };
            MultiLevelType multiLevelType13 = new MultiLevelType() { Val = MultiLevelValues.SingleLevel };
            TemplateCode templateCode13 = new TemplateCode() { Val = "9D8EF344" };

            Level level37 = new Level() { LevelIndex = 0 };
            StartNumberingValue startNumberingValue37 = new StartNumberingValue() { Val = 1 };
            NumberingFormat numberingFormat37 = new NumberingFormat() { Val = NumberFormatValues.Decimal };
            LevelText levelText37 = new LevelText() { Val = "%1." };
            LevelJustification levelJustification37 = new LevelJustification() { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties37 = new PreviousParagraphProperties();

            Tabs tabs40 = new Tabs();
            TabStop tabStop42 = new TabStop() { Val = TabStopValues.Number, Position = 801 };

            tabs40.Append(tabStop42);
            Indentation indentation62 = new Indentation() { Start = "801", Hanging = "375" };

            previousParagraphProperties37.Append(tabs40);
            previousParagraphProperties37.Append(indentation62);

            NumberingSymbolRunProperties numberingSymbolRunProperties32 = new NumberingSymbolRunProperties();
            RunFonts runFonts89 = new RunFonts() { Hint = FontTypeHintValues.Default };

            numberingSymbolRunProperties32.Append(runFonts89);

            level37.Append(startNumberingValue37);
            level37.Append(numberingFormat37);
            level37.Append(levelText37);
            level37.Append(levelJustification37);
            level37.Append(previousParagraphProperties37);
            level37.Append(numberingSymbolRunProperties32);

            abstractNum13.Append(nsid13);
            abstractNum13.Append(multiLevelType13);
            abstractNum13.Append(templateCode13);
            abstractNum13.Append(level37);

            AbstractNum abstractNum14 = new AbstractNum() { AbstractNumberId = 13 };
            abstractNum14.SetAttribute(new OpenXmlAttribute("w15", "restartNumberingAfterBreak", "http://schemas.microsoft.com/office/word/2012/wordml", "0"));
            Nsid nsid14 = new Nsid() { Val = "57663DF1" };
            MultiLevelType multiLevelType14 = new MultiLevelType() { Val = MultiLevelValues.SingleLevel };
            TemplateCode templateCode14 = new TemplateCode() { Val = "04190001" };

            Level level38 = new Level() { LevelIndex = 0 };
            StartNumberingValue startNumberingValue38 = new StartNumberingValue() { Val = 1 };
            NumberingFormat numberingFormat38 = new NumberingFormat() { Val = NumberFormatValues.Bullet };
            LevelText levelText38 = new LevelText() { Val = "·" };
            LevelJustification levelJustification38 = new LevelJustification() { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties38 = new PreviousParagraphProperties();

            Tabs tabs41 = new Tabs();
            TabStop tabStop43 = new TabStop() { Val = TabStopValues.Number, Position = 360 };

            tabs41.Append(tabStop43);
            Indentation indentation63 = new Indentation() { Start = "360", Hanging = "360" };

            previousParagraphProperties38.Append(tabs41);
            previousParagraphProperties38.Append(indentation63);

            NumberingSymbolRunProperties numberingSymbolRunProperties33 = new NumberingSymbolRunProperties();
            RunFonts runFonts90 = new RunFonts() { Hint = FontTypeHintValues.Default, Ascii = "Symbol", HighAnsi = "Symbol" };

            numberingSymbolRunProperties33.Append(runFonts90);

            level38.Append(startNumberingValue38);
            level38.Append(numberingFormat38);
            level38.Append(levelText38);
            level38.Append(levelJustification38);
            level38.Append(previousParagraphProperties38);
            level38.Append(numberingSymbolRunProperties33);

            abstractNum14.Append(nsid14);
            abstractNum14.Append(multiLevelType14);
            abstractNum14.Append(templateCode14);
            abstractNum14.Append(level38);

            AbstractNum abstractNum15 = new AbstractNum() { AbstractNumberId = 14 };
            abstractNum15.SetAttribute(new OpenXmlAttribute("w15", "restartNumberingAfterBreak", "http://schemas.microsoft.com/office/word/2012/wordml", "0"));
            Nsid nsid15 = new Nsid() { Val = "5BC71D70" };
            MultiLevelType multiLevelType15 = new MultiLevelType() { Val = MultiLevelValues.SingleLevel };
            TemplateCode templateCode15 = new TemplateCode() { Val = "0419000F" };

            Level level39 = new Level() { LevelIndex = 0 };
            StartNumberingValue startNumberingValue39 = new StartNumberingValue() { Val = 1 };
            NumberingFormat numberingFormat39 = new NumberingFormat() { Val = NumberFormatValues.Decimal };
            LevelText levelText39 = new LevelText() { Val = "%1." };
            LevelJustification levelJustification39 = new LevelJustification() { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties39 = new PreviousParagraphProperties();

            Tabs tabs42 = new Tabs();
            TabStop tabStop44 = new TabStop() { Val = TabStopValues.Number, Position = 360 };

            tabs42.Append(tabStop44);
            Indentation indentation64 = new Indentation() { Start = "360", Hanging = "360" };

            previousParagraphProperties39.Append(tabs42);
            previousParagraphProperties39.Append(indentation64);

            level39.Append(startNumberingValue39);
            level39.Append(numberingFormat39);
            level39.Append(levelText39);
            level39.Append(levelJustification39);
            level39.Append(previousParagraphProperties39);

            abstractNum15.Append(nsid15);
            abstractNum15.Append(multiLevelType15);
            abstractNum15.Append(templateCode15);
            abstractNum15.Append(level39);

            AbstractNum abstractNum16 = new AbstractNum() { AbstractNumberId = 15 };
            abstractNum16.SetAttribute(new OpenXmlAttribute("w15", "restartNumberingAfterBreak", "http://schemas.microsoft.com/office/word/2012/wordml", "0"));
            Nsid nsid16 = new Nsid() { Val = "69F65DF7" };
            MultiLevelType multiLevelType16 = new MultiLevelType() { Val = MultiLevelValues.SingleLevel };
            TemplateCode templateCode16 = new TemplateCode() { Val = "0419000F" };

            Level level40 = new Level() { LevelIndex = 0 };
            StartNumberingValue startNumberingValue40 = new StartNumberingValue() { Val = 1 };
            NumberingFormat numberingFormat40 = new NumberingFormat() { Val = NumberFormatValues.Decimal };
            LevelText levelText40 = new LevelText() { Val = "%1." };
            LevelJustification levelJustification40 = new LevelJustification() { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties40 = new PreviousParagraphProperties();

            Tabs tabs43 = new Tabs();
            TabStop tabStop45 = new TabStop() { Val = TabStopValues.Number, Position = 360 };

            tabs43.Append(tabStop45);
            Indentation indentation65 = new Indentation() { Start = "360", Hanging = "360" };

            previousParagraphProperties40.Append(tabs43);
            previousParagraphProperties40.Append(indentation65);

            level40.Append(startNumberingValue40);
            level40.Append(numberingFormat40);
            level40.Append(levelText40);
            level40.Append(levelJustification40);
            level40.Append(previousParagraphProperties40);

            abstractNum16.Append(nsid16);
            abstractNum16.Append(multiLevelType16);
            abstractNum16.Append(templateCode16);
            abstractNum16.Append(level40);

            AbstractNum abstractNum17 = new AbstractNum() { AbstractNumberId = 16 };
            abstractNum17.SetAttribute(new OpenXmlAttribute("w15", "restartNumberingAfterBreak", "http://schemas.microsoft.com/office/word/2012/wordml", "0"));
            Nsid nsid17 = new Nsid() { Val = "6E98078E" };
            MultiLevelType multiLevelType17 = new MultiLevelType() { Val = MultiLevelValues.SingleLevel };
            TemplateCode templateCode17 = new TemplateCode() { Val = "0419000F" };

            Level level41 = new Level() { LevelIndex = 0 };
            StartNumberingValue startNumberingValue41 = new StartNumberingValue() { Val = 1 };
            NumberingFormat numberingFormat41 = new NumberingFormat() { Val = NumberFormatValues.Decimal };
            LevelText levelText41 = new LevelText() { Val = "%1." };
            LevelJustification levelJustification41 = new LevelJustification() { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties41 = new PreviousParagraphProperties();

            Tabs tabs44 = new Tabs();
            TabStop tabStop46 = new TabStop() { Val = TabStopValues.Number, Position = 360 };

            tabs44.Append(tabStop46);
            Indentation indentation66 = new Indentation() { Start = "360", Hanging = "360" };

            previousParagraphProperties41.Append(tabs44);
            previousParagraphProperties41.Append(indentation66);

            level41.Append(startNumberingValue41);
            level41.Append(numberingFormat41);
            level41.Append(levelText41);
            level41.Append(levelJustification41);
            level41.Append(previousParagraphProperties41);

            abstractNum17.Append(nsid17);
            abstractNum17.Append(multiLevelType17);
            abstractNum17.Append(templateCode17);
            abstractNum17.Append(level41);

            AbstractNum abstractNum18 = new AbstractNum() { AbstractNumberId = 17 };
            abstractNum18.SetAttribute(new OpenXmlAttribute("w15", "restartNumberingAfterBreak", "http://schemas.microsoft.com/office/word/2012/wordml", "0"));
            Nsid nsid18 = new Nsid() { Val = "6EB67A8A" };
            MultiLevelType multiLevelType18 = new MultiLevelType() { Val = MultiLevelValues.SingleLevel };
            TemplateCode templateCode18 = new TemplateCode() { Val = "0419000F" };

            Level level42 = new Level() { LevelIndex = 0 };
            StartNumberingValue startNumberingValue42 = new StartNumberingValue() { Val = 1 };
            NumberingFormat numberingFormat42 = new NumberingFormat() { Val = NumberFormatValues.Decimal };
            LevelText levelText42 = new LevelText() { Val = "%1." };
            LevelJustification levelJustification42 = new LevelJustification() { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties42 = new PreviousParagraphProperties();

            Tabs tabs45 = new Tabs();
            TabStop tabStop47 = new TabStop() { Val = TabStopValues.Number, Position = 360 };

            tabs45.Append(tabStop47);
            Indentation indentation67 = new Indentation() { Start = "360", Hanging = "360" };

            previousParagraphProperties42.Append(tabs45);
            previousParagraphProperties42.Append(indentation67);

            level42.Append(startNumberingValue42);
            level42.Append(numberingFormat42);
            level42.Append(levelText42);
            level42.Append(levelJustification42);
            level42.Append(previousParagraphProperties42);

            abstractNum18.Append(nsid18);
            abstractNum18.Append(multiLevelType18);
            abstractNum18.Append(templateCode18);
            abstractNum18.Append(level42);

            AbstractNum abstractNum19 = new AbstractNum() { AbstractNumberId = 18 };
            abstractNum19.SetAttribute(new OpenXmlAttribute("w15", "restartNumberingAfterBreak", "http://schemas.microsoft.com/office/word/2012/wordml", "0"));
            Nsid nsid19 = new Nsid() { Val = "70FE1A44" };
            MultiLevelType multiLevelType19 = new MultiLevelType() { Val = MultiLevelValues.SingleLevel };
            TemplateCode templateCode19 = new TemplateCode() { Val = "0419000F" };

            Level level43 = new Level() { LevelIndex = 0 };
            StartNumberingValue startNumberingValue43 = new StartNumberingValue() { Val = 1 };
            NumberingFormat numberingFormat43 = new NumberingFormat() { Val = NumberFormatValues.Decimal };
            LevelText levelText43 = new LevelText() { Val = "%1." };
            LevelJustification levelJustification43 = new LevelJustification() { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties43 = new PreviousParagraphProperties();

            Tabs tabs46 = new Tabs();
            TabStop tabStop48 = new TabStop() { Val = TabStopValues.Number, Position = 360 };

            tabs46.Append(tabStop48);
            Indentation indentation68 = new Indentation() { Start = "360", Hanging = "360" };

            previousParagraphProperties43.Append(tabs46);
            previousParagraphProperties43.Append(indentation68);

            level43.Append(startNumberingValue43);
            level43.Append(numberingFormat43);
            level43.Append(levelText43);
            level43.Append(levelJustification43);
            level43.Append(previousParagraphProperties43);

            abstractNum19.Append(nsid19);
            abstractNum19.Append(multiLevelType19);
            abstractNum19.Append(templateCode19);
            abstractNum19.Append(level43);

            AbstractNum abstractNum20 = new AbstractNum() { AbstractNumberId = 19 };
            abstractNum20.SetAttribute(new OpenXmlAttribute("w15", "restartNumberingAfterBreak", "http://schemas.microsoft.com/office/word/2012/wordml", "0"));
            Nsid nsid20 = new Nsid() { Val = "7C9D6ABD" };
            MultiLevelType multiLevelType20 = new MultiLevelType() { Val = MultiLevelValues.SingleLevel };
            TemplateCode templateCode20 = new TemplateCode() { Val = "56E4C6F2" };

            Level level44 = new Level() { LevelIndex = 0 };
            StartNumberingValue startNumberingValue44 = new StartNumberingValue() { Val = 22 };
            NumberingFormat numberingFormat44 = new NumberingFormat() { Val = NumberFormatValues.Bullet };
            LevelText levelText44 = new LevelText() { Val = "-" };
            LevelJustification levelJustification44 = new LevelJustification() { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties44 = new PreviousParagraphProperties();

            Tabs tabs47 = new Tabs();
            TabStop tabStop49 = new TabStop() { Val = TabStopValues.Number, Position = 360 };

            tabs47.Append(tabStop49);
            Indentation indentation69 = new Indentation() { Start = "360", Hanging = "360" };

            previousParagraphProperties44.Append(tabs47);
            previousParagraphProperties44.Append(indentation69);

            NumberingSymbolRunProperties numberingSymbolRunProperties34 = new NumberingSymbolRunProperties();
            RunFonts runFonts91 = new RunFonts() { Hint = FontTypeHintValues.Default };

            numberingSymbolRunProperties34.Append(runFonts91);

            level44.Append(startNumberingValue44);
            level44.Append(numberingFormat44);
            level44.Append(levelText44);
            level44.Append(levelJustification44);
            level44.Append(previousParagraphProperties44);
            level44.Append(numberingSymbolRunProperties34);

            abstractNum20.Append(nsid20);
            abstractNum20.Append(multiLevelType20);
            abstractNum20.Append(templateCode20);
            abstractNum20.Append(level44);

            AbstractNum abstractNum21 = new AbstractNum() { AbstractNumberId = 20 };
            abstractNum21.SetAttribute(new OpenXmlAttribute("w15", "restartNumberingAfterBreak", "http://schemas.microsoft.com/office/word/2012/wordml", "0"));
            Nsid nsid21 = new Nsid() { Val = "7D4F03EE" };
            MultiLevelType multiLevelType21 = new MultiLevelType() { Val = MultiLevelValues.SingleLevel };
            TemplateCode templateCode21 = new TemplateCode() { Val = "ED0A4B72" };

            Level level45 = new Level() { LevelIndex = 0 };
            StartNumberingValue startNumberingValue45 = new StartNumberingValue() { Val = 2 };
            NumberingFormat numberingFormat45 = new NumberingFormat() { Val = NumberFormatValues.Bullet };
            LevelText levelText45 = new LevelText() { Val = "-" };
            LevelJustification levelJustification45 = new LevelJustification() { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties45 = new PreviousParagraphProperties();

            Tabs tabs48 = new Tabs();
            TabStop tabStop50 = new TabStop() { Val = TabStopValues.Number, Position = 600 };

            tabs48.Append(tabStop50);
            Indentation indentation70 = new Indentation() { Start = "600", Hanging = "360" };

            previousParagraphProperties45.Append(tabs48);
            previousParagraphProperties45.Append(indentation70);

            NumberingSymbolRunProperties numberingSymbolRunProperties35 = new NumberingSymbolRunProperties();
            RunFonts runFonts92 = new RunFonts() { Hint = FontTypeHintValues.Default };

            numberingSymbolRunProperties35.Append(runFonts92);

            level45.Append(startNumberingValue45);
            level45.Append(numberingFormat45);
            level45.Append(levelText45);
            level45.Append(levelJustification45);
            level45.Append(previousParagraphProperties45);
            level45.Append(numberingSymbolRunProperties35);

            abstractNum21.Append(nsid21);
            abstractNum21.Append(multiLevelType21);
            abstractNum21.Append(templateCode21);
            abstractNum21.Append(level45);

            AbstractNum abstractNum22 = new AbstractNum() { AbstractNumberId = 21 };
            abstractNum22.SetAttribute(new OpenXmlAttribute("w15", "restartNumberingAfterBreak", "http://schemas.microsoft.com/office/word/2012/wordml", "0"));
            Nsid nsid22 = new Nsid() { Val = "7E0F55C3" };
            MultiLevelType multiLevelType22 = new MultiLevelType() { Val = MultiLevelValues.SingleLevel };
            TemplateCode templateCode22 = new TemplateCode() { Val = "0419000F" };

            Level level46 = new Level() { LevelIndex = 0 };
            StartNumberingValue startNumberingValue46 = new StartNumberingValue() { Val = 1 };
            NumberingFormat numberingFormat46 = new NumberingFormat() { Val = NumberFormatValues.Decimal };
            LevelText levelText46 = new LevelText() { Val = "%1." };
            LevelJustification levelJustification46 = new LevelJustification() { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties46 = new PreviousParagraphProperties();

            Tabs tabs49 = new Tabs();
            TabStop tabStop51 = new TabStop() { Val = TabStopValues.Number, Position = 360 };

            tabs49.Append(tabStop51);
            Indentation indentation71 = new Indentation() { Start = "360", Hanging = "360" };

            previousParagraphProperties46.Append(tabs49);
            previousParagraphProperties46.Append(indentation71);

            level46.Append(startNumberingValue46);
            level46.Append(numberingFormat46);
            level46.Append(levelText46);
            level46.Append(levelJustification46);
            level46.Append(previousParagraphProperties46);

            abstractNum22.Append(nsid22);
            abstractNum22.Append(multiLevelType22);
            abstractNum22.Append(templateCode22);
            abstractNum22.Append(level46);

            AbstractNum abstractNum23 = new AbstractNum() { AbstractNumberId = 22 };
            abstractNum23.SetAttribute(new OpenXmlAttribute("w15", "restartNumberingAfterBreak", "http://schemas.microsoft.com/office/word/2012/wordml", "0"));
            Nsid nsid23 = new Nsid() { Val = "7F00658D" };
            MultiLevelType multiLevelType23 = new MultiLevelType() { Val = MultiLevelValues.SingleLevel };
            TemplateCode templateCode23 = new TemplateCode() { Val = "0419000F" };

            Level level47 = new Level() { LevelIndex = 0 };
            StartNumberingValue startNumberingValue47 = new StartNumberingValue() { Val = 1 };
            NumberingFormat numberingFormat47 = new NumberingFormat() { Val = NumberFormatValues.Decimal };
            LevelText levelText47 = new LevelText() { Val = "%1." };
            LevelJustification levelJustification47 = new LevelJustification() { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties47 = new PreviousParagraphProperties();

            Tabs tabs50 = new Tabs();
            TabStop tabStop52 = new TabStop() { Val = TabStopValues.Number, Position = 360 };

            tabs50.Append(tabStop52);
            Indentation indentation72 = new Indentation() { Start = "360", Hanging = "360" };

            previousParagraphProperties47.Append(tabs50);
            previousParagraphProperties47.Append(indentation72);

            level47.Append(startNumberingValue47);
            level47.Append(numberingFormat47);
            level47.Append(levelText47);
            level47.Append(levelJustification47);
            level47.Append(previousParagraphProperties47);

            abstractNum23.Append(nsid23);
            abstractNum23.Append(multiLevelType23);
            abstractNum23.Append(templateCode23);
            abstractNum23.Append(level47);

            NumberingInstance numberingInstance1 = new NumberingInstance() { NumberID = 1 };
            AbstractNumId abstractNumId1 = new AbstractNumId() { Val = 20 };

            numberingInstance1.Append(abstractNumId1);

            NumberingInstance numberingInstance2 = new NumberingInstance() { NumberID = 2 };
            AbstractNumId abstractNumId2 = new AbstractNumId() { Val = 7 };

            numberingInstance2.Append(abstractNumId2);

            NumberingInstance numberingInstance3 = new NumberingInstance() { NumberID = 3 };
            AbstractNumId abstractNumId3 = new AbstractNumId() { Val = 4 };

            numberingInstance3.Append(abstractNumId3);

            NumberingInstance numberingInstance4 = new NumberingInstance() { NumberID = 4 };
            AbstractNumId abstractNumId4 = new AbstractNumId() { Val = 16 };

            numberingInstance4.Append(abstractNumId4);

            NumberingInstance numberingInstance5 = new NumberingInstance() { NumberID = 5 };
            AbstractNumId abstractNumId5 = new AbstractNumId() { Val = 0 };

            numberingInstance5.Append(abstractNumId5);

            NumberingInstance numberingInstance6 = new NumberingInstance() { NumberID = 6 };
            AbstractNumId abstractNumId6 = new AbstractNumId() { Val = 10 };

            numberingInstance6.Append(abstractNumId6);

            NumberingInstance numberingInstance7 = new NumberingInstance() { NumberID = 7 };
            AbstractNumId abstractNumId7 = new AbstractNumId() { Val = 3 };

            numberingInstance7.Append(abstractNumId7);

            NumberingInstance numberingInstance8 = new NumberingInstance() { NumberID = 8 };
            AbstractNumId abstractNumId8 = new AbstractNumId() { Val = 1 };

            numberingInstance8.Append(abstractNumId8);

            NumberingInstance numberingInstance9 = new NumberingInstance() { NumberID = 9 };
            AbstractNumId abstractNumId9 = new AbstractNumId() { Val = 13 };

            numberingInstance9.Append(abstractNumId9);

            NumberingInstance numberingInstance10 = new NumberingInstance() { NumberID = 10 };
            AbstractNumId abstractNumId10 = new AbstractNumId() { Val = 22 };

            numberingInstance10.Append(abstractNumId10);

            NumberingInstance numberingInstance11 = new NumberingInstance() { NumberID = 11 };
            AbstractNumId abstractNumId11 = new AbstractNumId() { Val = 12 };

            numberingInstance11.Append(abstractNumId11);

            NumberingInstance numberingInstance12 = new NumberingInstance() { NumberID = 12 };
            AbstractNumId abstractNumId12 = new AbstractNumId() { Val = 2 };

            numberingInstance12.Append(abstractNumId12);

            NumberingInstance numberingInstance13 = new NumberingInstance() { NumberID = 13 };
            AbstractNumId abstractNumId13 = new AbstractNumId() { Val = 15 };

            numberingInstance13.Append(abstractNumId13);

            NumberingInstance numberingInstance14 = new NumberingInstance() { NumberID = 14 };
            AbstractNumId abstractNumId14 = new AbstractNumId() { Val = 14 };

            numberingInstance14.Append(abstractNumId14);

            NumberingInstance numberingInstance15 = new NumberingInstance() { NumberID = 15 };
            AbstractNumId abstractNumId15 = new AbstractNumId() { Val = 21 };

            numberingInstance15.Append(abstractNumId15);

            NumberingInstance numberingInstance16 = new NumberingInstance() { NumberID = 16 };
            AbstractNumId abstractNumId16 = new AbstractNumId() { Val = 11 };

            numberingInstance16.Append(abstractNumId16);

            NumberingInstance numberingInstance17 = new NumberingInstance() { NumberID = 17 };
            AbstractNumId abstractNumId17 = new AbstractNumId() { Val = 8 };

            numberingInstance17.Append(abstractNumId17);

            NumberingInstance numberingInstance18 = new NumberingInstance() { NumberID = 18 };
            AbstractNumId abstractNumId18 = new AbstractNumId() { Val = 9 };

            numberingInstance18.Append(abstractNumId18);

            NumberingInstance numberingInstance19 = new NumberingInstance() { NumberID = 19 };
            AbstractNumId abstractNumId19 = new AbstractNumId() { Val = 19 };

            numberingInstance19.Append(abstractNumId19);

            NumberingInstance numberingInstance20 = new NumberingInstance() { NumberID = 20 };
            AbstractNumId abstractNumId20 = new AbstractNumId() { Val = 18 };

            numberingInstance20.Append(abstractNumId20);

            NumberingInstance numberingInstance21 = new NumberingInstance() { NumberID = 21 };
            AbstractNumId abstractNumId21 = new AbstractNumId() { Val = 6 };

            numberingInstance21.Append(abstractNumId21);

            NumberingInstance numberingInstance22 = new NumberingInstance() { NumberID = 22 };
            AbstractNumId abstractNumId22 = new AbstractNumId() { Val = 17 };

            numberingInstance22.Append(abstractNumId22);

            NumberingInstance numberingInstance23 = new NumberingInstance() { NumberID = 23 };
            AbstractNumId abstractNumId23 = new AbstractNumId() { Val = 5 };

            numberingInstance23.Append(abstractNumId23);

            numbering1.Append(abstractNum1);
            numbering1.Append(abstractNum2);
            numbering1.Append(abstractNum3);
            numbering1.Append(abstractNum4);
            numbering1.Append(abstractNum5);
            numbering1.Append(abstractNum6);
            numbering1.Append(abstractNum7);
            numbering1.Append(abstractNum8);
            numbering1.Append(abstractNum9);
            numbering1.Append(abstractNum10);
            numbering1.Append(abstractNum11);
            numbering1.Append(abstractNum12);
            numbering1.Append(abstractNum13);
            numbering1.Append(abstractNum14);
            numbering1.Append(abstractNum15);
            numbering1.Append(abstractNum16);
            numbering1.Append(abstractNum17);
            numbering1.Append(abstractNum18);
            numbering1.Append(abstractNum19);
            numbering1.Append(abstractNum20);
            numbering1.Append(abstractNum21);
            numbering1.Append(abstractNum22);
            numbering1.Append(abstractNum23);
            numbering1.Append(numberingInstance1);
            numbering1.Append(numberingInstance2);
            numbering1.Append(numberingInstance3);
            numbering1.Append(numberingInstance4);
            numbering1.Append(numberingInstance5);
            numbering1.Append(numberingInstance6);
            numbering1.Append(numberingInstance7);
            numbering1.Append(numberingInstance8);
            numbering1.Append(numberingInstance9);
            numbering1.Append(numberingInstance10);
            numbering1.Append(numberingInstance11);
            numbering1.Append(numberingInstance12);
            numbering1.Append(numberingInstance13);
            numbering1.Append(numberingInstance14);
            numbering1.Append(numberingInstance15);
            numbering1.Append(numberingInstance16);
            numbering1.Append(numberingInstance17);
            numbering1.Append(numberingInstance18);
            numbering1.Append(numberingInstance19);
            numbering1.Append(numberingInstance20);
            numbering1.Append(numberingInstance21);
            numbering1.Append(numberingInstance22);
            numbering1.Append(numberingInstance23);

            numberingDefinitionsPart1.Numbering = numbering1;
        }

        // Generates content of customXmlPart1.
        private void GenerateCustomXmlPart1Content(CustomXmlPart customXmlPart1)
        {
            System.Xml.XmlTextWriter writer = new System.Xml.XmlTextWriter(customXmlPart1.GetStream(System.IO.FileMode.Create), System.Text.Encoding.UTF8);
            writer.WriteRaw("<b:Sources SelectedStyle=\"\\APA.XSL\" StyleName=\"APA\" xmlns:b=\"http://schemas.openxmlformats.org/officeDocument/2006/bibliography\" xmlns=\"http://schemas.openxmlformats.org/officeDocument/2006/bibliography\"></b:Sources>\r\n");
            writer.Flush();
            writer.Close();
        }

        // Generates content of customXmlPropertiesPart1.
        private void GenerateCustomXmlPropertiesPart1Content(CustomXmlPropertiesPart customXmlPropertiesPart1)
        {
            Ds.DataStoreItem dataStoreItem1 = new Ds.DataStoreItem() { ItemId = "{54EF6F7C-3FC0-4764-883A-7F9912A57A56}" };
            dataStoreItem1.AddNamespaceDeclaration("ds", "http://schemas.openxmlformats.org/officeDocument/2006/customXml");

            Ds.SchemaReferences schemaReferences1 = new Ds.SchemaReferences();
            Ds.SchemaReference schemaReference1 = new Ds.SchemaReference() { Uri = "http://schemas.openxmlformats.org/officeDocument/2006/bibliography" };

            schemaReferences1.Append(schemaReference1);

            dataStoreItem1.Append(schemaReferences1);

            customXmlPropertiesPart1.DataStoreItem = dataStoreItem1;
        }

        // Generates content of fontTablePart1.
        private void GenerateFontTablePart1Content(FontTablePart fontTablePart1)
        {
            Fonts fonts1 = new Fonts() { MCAttributes = new MarkupCompatibilityAttributes() { Ignorable = "w14 w15" } };
            fonts1.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            fonts1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            fonts1.AddNamespaceDeclaration("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
            fonts1.AddNamespaceDeclaration("w14", "http://schemas.microsoft.com/office/word/2010/wordml");
            fonts1.AddNamespaceDeclaration("w15", "http://schemas.microsoft.com/office/word/2012/wordml");

            Font font1 = new Font() { Name = "Times New Roman" };
            Panose1Number panose1Number1 = new Panose1Number() { Val = "02020603050405020304" };
            FontCharSet fontCharSet1 = new FontCharSet() { Val = "CC" };
            FontFamily fontFamily1 = new FontFamily() { Val = FontFamilyValues.Roman };
            Pitch pitch1 = new Pitch() { Val = FontPitchValues.Variable };
            FontSignature fontSignature1 = new FontSignature() { UnicodeSignature0 = "E0002AFF", UnicodeSignature1 = "C0007841", UnicodeSignature2 = "00000009", UnicodeSignature3 = "00000000", CodePageSignature0 = "000001FF", CodePageSignature1 = "00000000" };

            font1.Append(panose1Number1);
            font1.Append(fontCharSet1);
            font1.Append(fontFamily1);
            font1.Append(pitch1);
            font1.Append(fontSignature1);

            Font font2 = new Font() { Name = "Wingdings" };
            Panose1Number panose1Number2 = new Panose1Number() { Val = "05000000000000000000" };
            FontCharSet fontCharSet2 = new FontCharSet() { Val = "02" };
            FontFamily fontFamily2 = new FontFamily() { Val = FontFamilyValues.Auto };
            Pitch pitch2 = new Pitch() { Val = FontPitchValues.Variable };
            FontSignature fontSignature2 = new FontSignature() { UnicodeSignature0 = "00000000", UnicodeSignature1 = "10000000", UnicodeSignature2 = "00000000", UnicodeSignature3 = "00000000", CodePageSignature0 = "80000000", CodePageSignature1 = "00000000" };

            font2.Append(panose1Number2);
            font2.Append(fontCharSet2);
            font2.Append(fontFamily2);
            font2.Append(pitch2);
            font2.Append(fontSignature2);

            Font font3 = new Font() { Name = "Symbol" };
            Panose1Number panose1Number3 = new Panose1Number() { Val = "05050102010706020507" };
            FontCharSet fontCharSet3 = new FontCharSet() { Val = "02" };
            FontFamily fontFamily3 = new FontFamily() { Val = FontFamilyValues.Roman };
            Pitch pitch3 = new Pitch() { Val = FontPitchValues.Variable };
            FontSignature fontSignature3 = new FontSignature() { UnicodeSignature0 = "00000000", UnicodeSignature1 = "10000000", UnicodeSignature2 = "00000000", UnicodeSignature3 = "00000000", CodePageSignature0 = "80000000", CodePageSignature1 = "00000000" };

            font3.Append(panose1Number3);
            font3.Append(fontCharSet3);
            font3.Append(fontFamily3);
            font3.Append(pitch3);
            font3.Append(fontSignature3);

            Font font4 = new Font() { Name = "Times New Roman CYR" };
            Panose1Number panose1Number4 = new Panose1Number() { Val = "02020603050405020304" };
            FontCharSet fontCharSet4 = new FontCharSet() { Val = "CC" };
            FontFamily fontFamily4 = new FontFamily() { Val = FontFamilyValues.Roman };
            Pitch pitch4 = new Pitch() { Val = FontPitchValues.Variable };
            FontSignature fontSignature4 = new FontSignature() { UnicodeSignature0 = "E0002AFF", UnicodeSignature1 = "C0007841", UnicodeSignature2 = "00000009", UnicodeSignature3 = "00000000", CodePageSignature0 = "000001FF", CodePageSignature1 = "00000000" };

            font4.Append(panose1Number4);
            font4.Append(fontCharSet4);
            font4.Append(fontFamily4);
            font4.Append(pitch4);
            font4.Append(fontSignature4);

            Font font5 = new Font() { Name = "Tahoma" };
            Panose1Number panose1Number5 = new Panose1Number() { Val = "020B0604030504040204" };
            FontCharSet fontCharSet5 = new FontCharSet() { Val = "00" };
            FontFamily fontFamily5 = new FontFamily() { Val = FontFamilyValues.Swiss };
            NotTrueType notTrueType1 = new NotTrueType();
            Pitch pitch5 = new Pitch() { Val = FontPitchValues.Variable };
            FontSignature fontSignature5 = new FontSignature() { UnicodeSignature0 = "00000003", UnicodeSignature1 = "00000000", UnicodeSignature2 = "00000000", UnicodeSignature3 = "00000000", CodePageSignature0 = "00000001", CodePageSignature1 = "00000000" };

            font5.Append(panose1Number5);
            font5.Append(fontCharSet5);
            font5.Append(fontFamily5);
            font5.Append(notTrueType1);
            font5.Append(pitch5);
            font5.Append(fontSignature5);

            Font font6 = new Font() { Name = "Arial" };
            Panose1Number panose1Number6 = new Panose1Number() { Val = "020B0604020202020204" };
            FontCharSet fontCharSet6 = new FontCharSet() { Val = "CC" };
            FontFamily fontFamily6 = new FontFamily() { Val = FontFamilyValues.Swiss };
            Pitch pitch6 = new Pitch() { Val = FontPitchValues.Variable };
            FontSignature fontSignature6 = new FontSignature() { UnicodeSignature0 = "E0002AFF", UnicodeSignature1 = "C0007843", UnicodeSignature2 = "00000009", UnicodeSignature3 = "00000000", CodePageSignature0 = "000001FF", CodePageSignature1 = "00000000" };

            font6.Append(panose1Number6);
            font6.Append(fontCharSet6);
            font6.Append(fontFamily6);
            font6.Append(pitch6);
            font6.Append(fontSignature6);

            Font font7 = new Font() { Name = "Calibri" };
            Panose1Number panose1Number7 = new Panose1Number() { Val = "020F0502020204030204" };
            FontCharSet fontCharSet7 = new FontCharSet() { Val = "CC" };
            FontFamily fontFamily7 = new FontFamily() { Val = FontFamilyValues.Swiss };
            Pitch pitch7 = new Pitch() { Val = FontPitchValues.Variable };
            FontSignature fontSignature7 = new FontSignature() { UnicodeSignature0 = "E00002FF", UnicodeSignature1 = "4000ACFF", UnicodeSignature2 = "00000001", UnicodeSignature3 = "00000000", CodePageSignature0 = "0000019F", CodePageSignature1 = "00000000" };

            font7.Append(panose1Number7);
            font7.Append(fontCharSet7);
            font7.Append(fontFamily7);
            font7.Append(pitch7);
            font7.Append(fontSignature7);

            Font font8 = new Font() { Name = "Calibri Light" };
            Panose1Number panose1Number8 = new Panose1Number() { Val = "020F0302020204030204" };
            FontCharSet fontCharSet8 = new FontCharSet() { Val = "CC" };
            FontFamily fontFamily8 = new FontFamily() { Val = FontFamilyValues.Swiss };
            Pitch pitch8 = new Pitch() { Val = FontPitchValues.Variable };
            FontSignature fontSignature8 = new FontSignature() { UnicodeSignature0 = "A00002EF", UnicodeSignature1 = "4000207B", UnicodeSignature2 = "00000000", UnicodeSignature3 = "00000000", CodePageSignature0 = "0000019F", CodePageSignature1 = "00000000" };

            font8.Append(panose1Number8);
            font8.Append(fontCharSet8);
            font8.Append(fontFamily8);
            font8.Append(pitch8);
            font8.Append(fontSignature8);

            fonts1.Append(font1);
            fonts1.Append(font2);
            fonts1.Append(font3);
            fonts1.Append(font4);
            fonts1.Append(font5);
            fonts1.Append(font6);
            fonts1.Append(font7);
            fonts1.Append(font8);

            fontTablePart1.Fonts = fonts1;
        }

        // Generates content of webSettingsPart1.
        private void GenerateWebSettingsPart1Content(WebSettingsPart webSettingsPart1)
        {
            WebSettings webSettings1 = new WebSettings() { MCAttributes = new MarkupCompatibilityAttributes() { Ignorable = "w14 w15" } };
            webSettings1.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            webSettings1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            webSettings1.AddNamespaceDeclaration("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
            webSettings1.AddNamespaceDeclaration("w14", "http://schemas.microsoft.com/office/word/2010/wordml");
            webSettings1.AddNamespaceDeclaration("w15", "http://schemas.microsoft.com/office/word/2012/wordml");

            Divs divs1 = new Divs();

            Div div1 = new Div() { Id = "1680504368" };
            BodyDiv bodyDiv1 = new BodyDiv() { Val = true };
            LeftMarginDiv leftMarginDiv1 = new LeftMarginDiv() { Val = "0" };
            RightMarginDiv rightMarginDiv1 = new RightMarginDiv() { Val = "0" };
            TopMarginDiv topMarginDiv1 = new TopMarginDiv() { Val = "0" };
            BottomMarginDiv bottomMarginDiv1 = new BottomMarginDiv() { Val = "0" };

            DivBorder divBorder1 = new DivBorder();
            TopBorder topBorder26 = new TopBorder() { Val = BorderValues.None, Color = "auto", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder39 = new LeftBorder() { Val = BorderValues.None, Color = "auto", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder37 = new BottomBorder() { Val = BorderValues.None, Color = "auto", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder39 = new RightBorder() { Val = BorderValues.None, Color = "auto", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            divBorder1.Append(topBorder26);
            divBorder1.Append(leftBorder39);
            divBorder1.Append(bottomBorder37);
            divBorder1.Append(rightBorder39);

            div1.Append(bodyDiv1);
            div1.Append(leftMarginDiv1);
            div1.Append(rightMarginDiv1);
            div1.Append(topMarginDiv1);
            div1.Append(bottomMarginDiv1);
            div1.Append(divBorder1);

            Div div2 = new Div() { Id = "1712991887" };
            BodyDiv bodyDiv2 = new BodyDiv() { Val = true };
            LeftMarginDiv leftMarginDiv2 = new LeftMarginDiv() { Val = "0" };
            RightMarginDiv rightMarginDiv2 = new RightMarginDiv() { Val = "0" };
            TopMarginDiv topMarginDiv2 = new TopMarginDiv() { Val = "0" };
            BottomMarginDiv bottomMarginDiv2 = new BottomMarginDiv() { Val = "0" };

            DivBorder divBorder2 = new DivBorder();
            TopBorder topBorder27 = new TopBorder() { Val = BorderValues.None, Color = "auto", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder40 = new LeftBorder() { Val = BorderValues.None, Color = "auto", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder38 = new BottomBorder() { Val = BorderValues.None, Color = "auto", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder40 = new RightBorder() { Val = BorderValues.None, Color = "auto", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            divBorder2.Append(topBorder27);
            divBorder2.Append(leftBorder40);
            divBorder2.Append(bottomBorder38);
            divBorder2.Append(rightBorder40);

            div2.Append(bodyDiv2);
            div2.Append(leftMarginDiv2);
            div2.Append(rightMarginDiv2);
            div2.Append(topMarginDiv2);
            div2.Append(bottomMarginDiv2);
            div2.Append(divBorder2);

            divs1.Append(div1);
            divs1.Append(div2);
            OptimizeForBrowser optimizeForBrowser1 = new OptimizeForBrowser();

            webSettings1.Append(divs1);
            webSettings1.Append(optimizeForBrowser1);

            webSettingsPart1.WebSettings = webSettings1;
        }

        // Generates content of documentSettingsPart1.
        private void GenerateDocumentSettingsPart1Content(DocumentSettingsPart documentSettingsPart1)
        {
            Settings settings1 = new Settings() { MCAttributes = new MarkupCompatibilityAttributes() { Ignorable = "w14 w15" } };
            settings1.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            settings1.AddNamespaceDeclaration("o", "urn:schemas-microsoft-com:office:office");
            settings1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            settings1.AddNamespaceDeclaration("m", "http://schemas.openxmlformats.org/officeDocument/2006/math");
            settings1.AddNamespaceDeclaration("v", "urn:schemas-microsoft-com:vml");
            settings1.AddNamespaceDeclaration("w10", "urn:schemas-microsoft-com:office:word");
            settings1.AddNamespaceDeclaration("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
            settings1.AddNamespaceDeclaration("w14", "http://schemas.microsoft.com/office/word/2010/wordml");
            settings1.AddNamespaceDeclaration("w15", "http://schemas.microsoft.com/office/word/2012/wordml");
            settings1.AddNamespaceDeclaration("sl", "http://schemas.openxmlformats.org/schemaLibrary/2006/main");
            Zoom zoom1 = new Zoom() { Percent = "100" };
            EmbedSystemFonts embedSystemFonts1 = new EmbedSystemFonts();
            ProofState proofState1 = new ProofState() { Spelling = ProofingStateValues.Clean, Grammar = ProofingStateValues.Clean };
            StylePaneFormatFilter stylePaneFormatFilter1 = new StylePaneFormatFilter() { Val = "3F01", AllStyles = true, CustomStyles = false, LatentStyles = false, StylesInUse = false, HeadingStyles = false, NumberingStyles = false, TableStyles = false, DirectFormattingOnRuns = true, DirectFormattingOnParagraphs = true, DirectFormattingOnNumbering = true, DirectFormattingOnTables = true, ClearFormatting = true, Top3HeadingStyles = true, VisibleStyles = false, AlternateStyleNames = false };
            DefaultTabStop defaultTabStop1 = new DefaultTabStop() { Val = 720 };
            DisplayHorizontalDrawingGrid displayHorizontalDrawingGrid1 = new DisplayHorizontalDrawingGrid() { Val = 0 };
            DisplayVerticalDrawingGrid displayVerticalDrawingGrid1 = new DisplayVerticalDrawingGrid() { Val = 0 };
            DoNotUseMarginsForDrawingGridOrigin doNotUseMarginsForDrawingGridOrigin1 = new DoNotUseMarginsForDrawingGridOrigin();
            NoPunctuationKerning noPunctuationKerning1 = new NoPunctuationKerning();
            CharacterSpacingControl characterSpacingControl1 = new CharacterSpacingControl() { Val = CharacterSpacingValues.DoNotCompress };

            Compatibility compatibility1 = new Compatibility();
            CompatibilitySetting compatibilitySetting1 = new CompatibilitySetting() { Name = CompatSettingNameValues.CompatibilityMode, Uri = "http://schemas.microsoft.com/office/word", Val = "15" };
            CompatibilitySetting compatibilitySetting2 = new CompatibilitySetting() { Name = CompatSettingNameValues.OverrideTableStyleFontSizeAndJustification, Uri = "http://schemas.microsoft.com/office/word", Val = "1" };
            CompatibilitySetting compatibilitySetting3 = new CompatibilitySetting() { Name = CompatSettingNameValues.EnableOpenTypeFeatures, Uri = "http://schemas.microsoft.com/office/word", Val = "1" };
            CompatibilitySetting compatibilitySetting4 = new CompatibilitySetting() { Name = CompatSettingNameValues.DoNotFlipMirrorIndents, Uri = "http://schemas.microsoft.com/office/word", Val = "1" };
            CompatibilitySetting compatibilitySetting5 = new CompatibilitySetting() { Name = CompatSettingNameValues.DifferentiateMultirowTableHeaders, Uri = "http://schemas.microsoft.com/office/word", Val = "1" };

            compatibility1.Append(compatibilitySetting1);
            compatibility1.Append(compatibilitySetting2);
            compatibility1.Append(compatibilitySetting3);
            compatibility1.Append(compatibilitySetting4);
            compatibility1.Append(compatibilitySetting5);

            Rsids rsids1 = new Rsids();
            RsidRoot rsidRoot1 = new RsidRoot() { Val = "00D365E7" };
            Rsid rsid6 = new Rsid() { Val = "00005BCC" };
            Rsid rsid7 = new Rsid() { Val = "00007A62" };
            Rsid rsid8 = new Rsid() { Val = "0003034E" };
            Rsid rsid9 = new Rsid() { Val = "00037BF7" };
            Rsid rsid10 = new Rsid() { Val = "000576D8" };
            Rsid rsid11 = new Rsid() { Val = "00060D37" };
            Rsid rsid12 = new Rsid() { Val = "00061745" };
            Rsid rsid13 = new Rsid() { Val = "000622F3" };
            Rsid rsid14 = new Rsid() { Val = "00064902" };
            Rsid rsid15 = new Rsid() { Val = "0006740F" };
            Rsid rsid16 = new Rsid() { Val = "00070967" };
            Rsid rsid17 = new Rsid() { Val = "00070A99" };
            Rsid rsid18 = new Rsid() { Val = "0007365E" };
            Rsid rsid19 = new Rsid() { Val = "00074323" };
            Rsid rsid20 = new Rsid() { Val = "000754D3" };
            Rsid rsid21 = new Rsid() { Val = "00075819" };
            Rsid rsid22 = new Rsid() { Val = "00076295" };
            Rsid rsid23 = new Rsid() { Val = "00082A3D" };
            Rsid rsid24 = new Rsid() { Val = "00086E50" };
            Rsid rsid25 = new Rsid() { Val = "0009005F" };
            Rsid rsid26 = new Rsid() { Val = "0009129D" };
            Rsid rsid27 = new Rsid() { Val = "00096F11" };
            Rsid rsid28 = new Rsid() { Val = "000A416B" };
            Rsid rsid29 = new Rsid() { Val = "000A499B" };
            Rsid rsid30 = new Rsid() { Val = "000A591A" };
            Rsid rsid31 = new Rsid() { Val = "000C2D60" };
            Rsid rsid32 = new Rsid() { Val = "000C7B17" };
            Rsid rsid33 = new Rsid() { Val = "000D0931" };
            Rsid rsid34 = new Rsid() { Val = "000D37FC" };
            Rsid rsid35 = new Rsid() { Val = "000D64A5" };
            Rsid rsid36 = new Rsid() { Val = "000E531B" };
            Rsid rsid37 = new Rsid() { Val = "000F06AD" };
            Rsid rsid38 = new Rsid() { Val = "001022BA" };
            Rsid rsid39 = new Rsid() { Val = "001027CB" };
            Rsid rsid40 = new Rsid() { Val = "00103228" };
            Rsid rsid41 = new Rsid() { Val = "00125215" };
            Rsid rsid42 = new Rsid() { Val = "001255BB" };
            Rsid rsid43 = new Rsid() { Val = "00127F60" };
            Rsid rsid44 = new Rsid() { Val = "00134FE3" };
            Rsid rsid45 = new Rsid() { Val = "001427D0" };
            Rsid rsid46 = new Rsid() { Val = "00147943" };
            Rsid rsid47 = new Rsid() { Val = "0016256E" };
            Rsid rsid48 = new Rsid() { Val = "0017078F" };
            Rsid rsid49 = new Rsid() { Val = "001807A0" };
            Rsid rsid50 = new Rsid() { Val = "00180BCE" };
            Rsid rsid51 = new Rsid() { Val = "00187144" };
            Rsid rsid52 = new Rsid() { Val = "00192B8D" };
            Rsid rsid53 = new Rsid() { Val = "00195023" };
            Rsid rsid54 = new Rsid() { Val = "001974F3" };
            Rsid rsid55 = new Rsid() { Val = "001A6BCD" };
            Rsid rsid56 = new Rsid() { Val = "001A7106" };
            Rsid rsid57 = new Rsid() { Val = "001A777A" };
            Rsid rsid58 = new Rsid() { Val = "001B74B2" };
            Rsid rsid59 = new Rsid() { Val = "001C5488" };
            Rsid rsid60 = new Rsid() { Val = "001D5D69" };
            Rsid rsid61 = new Rsid() { Val = "00216DB9" };
            Rsid rsid62 = new Rsid() { Val = "00223150" };
            Rsid rsid63 = new Rsid() { Val = "00234103" };
            Rsid rsid64 = new Rsid() { Val = "00240FA2" };
            Rsid rsid65 = new Rsid() { Val = "002505D3" };
            Rsid rsid66 = new Rsid() { Val = "0025080B" };
            Rsid rsid67 = new Rsid() { Val = "00255797" };
            Rsid rsid68 = new Rsid() { Val = "00263272" };
            Rsid rsid69 = new Rsid() { Val = "00264BE7" };
            Rsid rsid70 = new Rsid() { Val = "002673EB" };
            Rsid rsid71 = new Rsid() { Val = "00270996" };
            Rsid rsid72 = new Rsid() { Val = "00270C79" };
            Rsid rsid73 = new Rsid() { Val = "00271777" };
            Rsid rsid74 = new Rsid() { Val = "00272FEA" };
            Rsid rsid75 = new Rsid() { Val = "00280B61" };
            Rsid rsid76 = new Rsid() { Val = "00286B31" };
            Rsid rsid77 = new Rsid() { Val = "002934E7" };
            Rsid rsid78 = new Rsid() { Val = "00293657" };
            Rsid rsid79 = new Rsid() { Val = "0029756A" };
            Rsid rsid80 = new Rsid() { Val = "002A4B6F" };
            Rsid rsid81 = new Rsid() { Val = "002A4F5B" };
            Rsid rsid82 = new Rsid() { Val = "002B5AB0" };
            Rsid rsid83 = new Rsid() { Val = "002C1CAD" };
            Rsid rsid84 = new Rsid() { Val = "002D2251" };
            Rsid rsid85 = new Rsid() { Val = "002F3249" };
            Rsid rsid86 = new Rsid() { Val = "002F3564" };
            Rsid rsid87 = new Rsid() { Val = "002F6BA8" };
            Rsid rsid88 = new Rsid() { Val = "002F6CEA" };
            Rsid rsid89 = new Rsid() { Val = "00307BFA" };
            Rsid rsid90 = new Rsid() { Val = "00310C71" };
            Rsid rsid91 = new Rsid() { Val = "0032169B" };
            Rsid rsid92 = new Rsid() { Val = "00327475" };
            Rsid rsid93 = new Rsid() { Val = "00332AB7" };
            Rsid rsid94 = new Rsid() { Val = "00333D76" };
            Rsid rsid95 = new Rsid() { Val = "00344872" };
            Rsid rsid96 = new Rsid() { Val = "00345DEA" };
            Rsid rsid97 = new Rsid() { Val = "00347F05" };
            Rsid rsid98 = new Rsid() { Val = "00374507" };
            Rsid rsid99 = new Rsid() { Val = "00381093" };
            Rsid rsid100 = new Rsid() { Val = "003825F6" };
            Rsid rsid101 = new Rsid() { Val = "00385BA6" };
            Rsid rsid102 = new Rsid() { Val = "003923FB" };
            Rsid rsid103 = new Rsid() { Val = "003938FC" };
            Rsid rsid104 = new Rsid() { Val = "00393C46" };
            Rsid rsid105 = new Rsid() { Val = "00395737" };
            Rsid rsid106 = new Rsid() { Val = "003A6356" };
            Rsid rsid107 = new Rsid() { Val = "003B62C1" };
            Rsid rsid108 = new Rsid() { Val = "003C3DDF" };
            Rsid rsid109 = new Rsid() { Val = "003C79AB" };
            Rsid rsid110 = new Rsid() { Val = "003C7C65" };
            Rsid rsid111 = new Rsid() { Val = "003E6832" };
            Rsid rsid112 = new Rsid() { Val = "004010B0" };
            Rsid rsid113 = new Rsid() { Val = "0040156C" };
            Rsid rsid114 = new Rsid() { Val = "00404DDD" };
            Rsid rsid115 = new Rsid() { Val = "0040759A" };
            Rsid rsid116 = new Rsid() { Val = "004119E9" };
            Rsid rsid117 = new Rsid() { Val = "004218A6" };
            Rsid rsid118 = new Rsid() { Val = "00437B28" };
            Rsid rsid119 = new Rsid() { Val = "004443CC" };
            Rsid rsid120 = new Rsid() { Val = "00462896" };
            Rsid rsid121 = new Rsid() { Val = "00463284" };
            Rsid rsid122 = new Rsid() { Val = "004652BD" };
            Rsid rsid123 = new Rsid() { Val = "004726C2" };
            Rsid rsid124 = new Rsid() { Val = "00482DEE" };
            Rsid rsid125 = new Rsid() { Val = "00483103" };
            Rsid rsid126 = new Rsid() { Val = "00486CDB" };
            Rsid rsid127 = new Rsid() { Val = "00487986" };
            Rsid rsid128 = new Rsid() { Val = "00491361" };
            Rsid rsid129 = new Rsid() { Val = "00494A2B" };
            Rsid rsid130 = new Rsid() { Val = "00495BF7" };
            Rsid rsid131 = new Rsid() { Val = "004A75B4" };
            Rsid rsid132 = new Rsid() { Val = "004B5715" };
            Rsid rsid133 = new Rsid() { Val = "004B7F3A" };
            Rsid rsid134 = new Rsid() { Val = "004C252E" };
            Rsid rsid135 = new Rsid() { Val = "004C2845" };
            Rsid rsid136 = new Rsid() { Val = "004C5937" };
            Rsid rsid137 = new Rsid() { Val = "004C6F0C" };
            Rsid rsid138 = new Rsid() { Val = "004E6E34" };
            Rsid rsid139 = new Rsid() { Val = "004E77D6" };
            Rsid rsid140 = new Rsid() { Val = "004F39CA" };
            Rsid rsid141 = new Rsid() { Val = "00502040" };
            Rsid rsid142 = new Rsid() { Val = "00511625" };
            Rsid rsid143 = new Rsid() { Val = "0051251A" };
            Rsid rsid144 = new Rsid() { Val = "0051398F" };
            Rsid rsid145 = new Rsid() { Val = "00516F28" };
            Rsid rsid146 = new Rsid() { Val = "00524634" };
            Rsid rsid147 = new Rsid() { Val = "00530052" };
            Rsid rsid148 = new Rsid() { Val = "00537BB1" };
            Rsid rsid149 = new Rsid() { Val = "00540726" };
            Rsid rsid150 = new Rsid() { Val = "00544F76" };
            Rsid rsid151 = new Rsid() { Val = "005479C4" };
            Rsid rsid152 = new Rsid() { Val = "00553997" };
            Rsid rsid153 = new Rsid() { Val = "005630D3" };
            Rsid rsid154 = new Rsid() { Val = "00571BA3" };
            Rsid rsid155 = new Rsid() { Val = "0057510D" };
            Rsid rsid156 = new Rsid() { Val = "0058155C" };
            Rsid rsid157 = new Rsid() { Val = "00582E94" };
            Rsid rsid158 = new Rsid() { Val = "00583BD1" };
            Rsid rsid159 = new Rsid() { Val = "005840CA" };
            Rsid rsid160 = new Rsid() { Val = "005A599C" };
            Rsid rsid161 = new Rsid() { Val = "005B1A83" };
            Rsid rsid162 = new Rsid() { Val = "005B4723" };
            Rsid rsid163 = new Rsid() { Val = "005B5351" };
            Rsid rsid164 = new Rsid() { Val = "005C79E4" };
            Rsid rsid165 = new Rsid() { Val = "005E1870" };
            Rsid rsid166 = new Rsid() { Val = "005E346A" };
            Rsid rsid167 = new Rsid() { Val = "00604EA9" };
            Rsid rsid168 = new Rsid() { Val = "006050C7" };
            Rsid rsid169 = new Rsid() { Val = "00615ADA" };
            Rsid rsid170 = new Rsid() { Val = "00615E58" };
            Rsid rsid171 = new Rsid() { Val = "0061663A" };
            Rsid rsid172 = new Rsid() { Val = "006171C3" };
            Rsid rsid173 = new Rsid() { Val = "0062150B" };
            Rsid rsid174 = new Rsid() { Val = "0062170D" };
            Rsid rsid175 = new Rsid() { Val = "006228F9" };
            Rsid rsid176 = new Rsid() { Val = "006265B5" };
            Rsid rsid177 = new Rsid() { Val = "00627C6C" };
            Rsid rsid178 = new Rsid() { Val = "00640EAD" };
            Rsid rsid179 = new Rsid() { Val = "006431E6" };
            Rsid rsid180 = new Rsid() { Val = "00655293" };
            Rsid rsid181 = new Rsid() { Val = "0066404F" };
            Rsid rsid182 = new Rsid() { Val = "006677C5" };
            Rsid rsid183 = new Rsid() { Val = "00667F93" };
            Rsid rsid184 = new Rsid() { Val = "00684E3C" };
            Rsid rsid185 = new Rsid() { Val = "00686A02" };
            Rsid rsid186 = new Rsid() { Val = "0069054C" };
            Rsid rsid187 = new Rsid() { Val = "006A3FD4" };
            Rsid rsid188 = new Rsid() { Val = "006A54B9" };
            Rsid rsid189 = new Rsid() { Val = "006A67EE" };
            Rsid rsid190 = new Rsid() { Val = "006A79D7" };
            Rsid rsid191 = new Rsid() { Val = "006B18AD" };
            Rsid rsid192 = new Rsid() { Val = "006B19C9" };
            Rsid rsid193 = new Rsid() { Val = "006B683B" };
            Rsid rsid194 = new Rsid() { Val = "006C0B40" };
            Rsid rsid195 = new Rsid() { Val = "006C56C8" };
            Rsid rsid196 = new Rsid() { Val = "006D0B8D" };
            Rsid rsid197 = new Rsid() { Val = "006D2368" };
            Rsid rsid198 = new Rsid() { Val = "006D3CA8" };
            Rsid rsid199 = new Rsid() { Val = "006D49E7" };
            Rsid rsid200 = new Rsid() { Val = "006D6C07" };
            Rsid rsid201 = new Rsid() { Val = "006D7028" };
            Rsid rsid202 = new Rsid() { Val = "006E089B" };
            Rsid rsid203 = new Rsid() { Val = "006F65FA" };
            Rsid rsid204 = new Rsid() { Val = "00714E13" };
            Rsid rsid205 = new Rsid() { Val = "00721614" };
            Rsid rsid206 = new Rsid() { Val = "00723383" };
            Rsid rsid207 = new Rsid() { Val = "00723936" };
            Rsid rsid208 = new Rsid() { Val = "00732264" };
            Rsid rsid209 = new Rsid() { Val = "0073408E" };
            Rsid rsid210 = new Rsid() { Val = "0073752F" };
            Rsid rsid211 = new Rsid() { Val = "0074088D" };
            Rsid rsid212 = new Rsid() { Val = "00743142" };
            Rsid rsid213 = new Rsid() { Val = "00754760" };
            Rsid rsid214 = new Rsid() { Val = "0076287F" };
            Rsid rsid215 = new Rsid() { Val = "00764403" };
            Rsid rsid216 = new Rsid() { Val = "0077284C" };
            Rsid rsid217 = new Rsid() { Val = "00793308" };
            Rsid rsid218 = new Rsid() { Val = "00793782" };
            Rsid rsid219 = new Rsid() { Val = "007959EE" };
            Rsid rsid220 = new Rsid() { Val = "007A68CB" };
            Rsid rsid221 = new Rsid() { Val = "007B69DF" };
            Rsid rsid222 = new Rsid() { Val = "007E3E47" };
            Rsid rsid223 = new Rsid() { Val = "007F1EB5" };
            Rsid rsid224 = new Rsid() { Val = "007F3EF9" };
            Rsid rsid225 = new Rsid() { Val = "008026F3" };
            Rsid rsid226 = new Rsid() { Val = "00817F9B" };
            Rsid rsid227 = new Rsid() { Val = "00825107" };
            Rsid rsid228 = new Rsid() { Val = "00826D68" };
            Rsid rsid229 = new Rsid() { Val = "00833FC7" };
            Rsid rsid230 = new Rsid() { Val = "00844EA3" };
            Rsid rsid231 = new Rsid() { Val = "00856A78" };
            Rsid rsid232 = new Rsid() { Val = "0085751B" };
            Rsid rsid233 = new Rsid() { Val = "00873929" };
            Rsid rsid234 = new Rsid() { Val = "00875181" };
            Rsid rsid235 = new Rsid() { Val = "0087570F" };
            Rsid rsid236 = new Rsid() { Val = "0089150D" };
            Rsid rsid237 = new Rsid() { Val = "008A1557" };
            Rsid rsid238 = new Rsid() { Val = "008A524E" };
            Rsid rsid239 = new Rsid() { Val = "008A7366" };
            Rsid rsid240 = new Rsid() { Val = "008B5C0A" };
            Rsid rsid241 = new Rsid() { Val = "008C291D" };
            Rsid rsid242 = new Rsid() { Val = "008C4DE8" };
            Rsid rsid243 = new Rsid() { Val = "008D4CB9" };
            Rsid rsid244 = new Rsid() { Val = "008E66B8" };
            Rsid rsid245 = new Rsid() { Val = "0090054E" };
            Rsid rsid246 = new Rsid() { Val = "00905DAC" };
            Rsid rsid247 = new Rsid() { Val = "0091494D" };
            Rsid rsid248 = new Rsid() { Val = "009155EC" };
            Rsid rsid249 = new Rsid() { Val = "00922E5D" };
            Rsid rsid250 = new Rsid() { Val = "00923794" };
            Rsid rsid251 = new Rsid() { Val = "00935ADE" };
            Rsid rsid252 = new Rsid() { Val = "00942589" };
            Rsid rsid253 = new Rsid() { Val = "0094445A" };
            Rsid rsid254 = new Rsid() { Val = "0095724E" };
            Rsid rsid255 = new Rsid() { Val = "00957E0E" };
            Rsid rsid256 = new Rsid() { Val = "0097153F" };
            Rsid rsid257 = new Rsid() { Val = "00974D02" };
            Rsid rsid258 = new Rsid() { Val = "00982A19" };
            Rsid rsid259 = new Rsid() { Val = "00983957" };
            Rsid rsid260 = new Rsid() { Val = "00984403" };
            Rsid rsid261 = new Rsid() { Val = "00985D26" };
            Rsid rsid262 = new Rsid() { Val = "0099387F" };
            Rsid rsid263 = new Rsid() { Val = "00997272" };
            Rsid rsid264 = new Rsid() { Val = "009A289B" };
            Rsid rsid265 = new Rsid() { Val = "009A4B49" };
            Rsid rsid266 = new Rsid() { Val = "009B32F6" };
            Rsid rsid267 = new Rsid() { Val = "009B4AD0" };
            Rsid rsid268 = new Rsid() { Val = "009B7320" };
            Rsid rsid269 = new Rsid() { Val = "009D0504" };
            Rsid rsid270 = new Rsid() { Val = "009D0A1E" };
            Rsid rsid271 = new Rsid() { Val = "009D768B" };
            Rsid rsid272 = new Rsid() { Val = "009E25D7" };
            Rsid rsid273 = new Rsid() { Val = "009E455F" };
            Rsid rsid274 = new Rsid() { Val = "009F1B49" };
            Rsid rsid275 = new Rsid() { Val = "009F1ED4" };
            Rsid rsid276 = new Rsid() { Val = "009F4D51" };
            Rsid rsid277 = new Rsid() { Val = "00A00411" };
            Rsid rsid278 = new Rsid() { Val = "00A037C9" };
            Rsid rsid279 = new Rsid() { Val = "00A07F81" };
            Rsid rsid280 = new Rsid() { Val = "00A142EE" };
            Rsid rsid281 = new Rsid() { Val = "00A15211" };
            Rsid rsid282 = new Rsid() { Val = "00A1774C" };
            Rsid rsid283 = new Rsid() { Val = "00A32623" };
            Rsid rsid284 = new Rsid() { Val = "00A52493" };
            Rsid rsid285 = new Rsid() { Val = "00A8050F" };
            Rsid rsid286 = new Rsid() { Val = "00A848C0" };
            Rsid rsid287 = new Rsid() { Val = "00A92557" };
            Rsid rsid288 = new Rsid() { Val = "00A93904" };
            Rsid rsid289 = new Rsid() { Val = "00A94676" };
            Rsid rsid290 = new Rsid() { Val = "00A96AC3" };
            Rsid rsid291 = new Rsid() { Val = "00AA22F2" };
            Rsid rsid292 = new Rsid() { Val = "00AA2674" };
            Rsid rsid293 = new Rsid() { Val = "00AA496A" };
            Rsid rsid294 = new Rsid() { Val = "00AA5505" };
            Rsid rsid295 = new Rsid() { Val = "00AA5B4D" };
            Rsid rsid296 = new Rsid() { Val = "00AB7B0F" };
            Rsid rsid297 = new Rsid() { Val = "00AC7AFD" };
            Rsid rsid298 = new Rsid() { Val = "00AD2779" };
            Rsid rsid299 = new Rsid() { Val = "00AD6AD5" };
            Rsid rsid300 = new Rsid() { Val = "00AE38A7" };
            Rsid rsid301 = new Rsid() { Val = "00AF177C" };
            Rsid rsid302 = new Rsid() { Val = "00AF4A90" };
            Rsid rsid303 = new Rsid() { Val = "00AF51F1" };
            Rsid rsid304 = new Rsid() { Val = "00B03E44" };
            Rsid rsid305 = new Rsid() { Val = "00B04515" };
            Rsid rsid306 = new Rsid() { Val = "00B04A5B" };
            Rsid rsid307 = new Rsid() { Val = "00B06AF7" };
            Rsid rsid308 = new Rsid() { Val = "00B15711" };
            Rsid rsid309 = new Rsid() { Val = "00B27D63" };
            Rsid rsid310 = new Rsid() { Val = "00B33144" };
            Rsid rsid311 = new Rsid() { Val = "00B34122" };
            Rsid rsid312 = new Rsid() { Val = "00B34BD0" };
            Rsid rsid313 = new Rsid() { Val = "00B5092E" };
            Rsid rsid314 = new Rsid() { Val = "00B823D7" };
            Rsid rsid315 = new Rsid() { Val = "00B84BDF" };
            Rsid rsid316 = new Rsid() { Val = "00B86A35" };
            Rsid rsid317 = new Rsid() { Val = "00BA3D67" };
            Rsid rsid318 = new Rsid() { Val = "00BA3E61" };
            Rsid rsid319 = new Rsid() { Val = "00BC4C88" };
            Rsid rsid320 = new Rsid() { Val = "00BC4EA1" };
            Rsid rsid321 = new Rsid() { Val = "00BC63E2" };
            Rsid rsid322 = new Rsid() { Val = "00BD48AC" };
            Rsid rsid323 = new Rsid() { Val = "00BE4419" };
            Rsid rsid324 = new Rsid() { Val = "00BF089B" };
            Rsid rsid325 = new Rsid() { Val = "00BF08CC" };
            Rsid rsid326 = new Rsid() { Val = "00C003D8" };
            Rsid rsid327 = new Rsid() { Val = "00C03233" };
            Rsid rsid328 = new Rsid() { Val = "00C06F28" };
            Rsid rsid329 = new Rsid() { Val = "00C2012F" };
            Rsid rsid330 = new Rsid() { Val = "00C2188D" };
            Rsid rsid331 = new Rsid() { Val = "00C31F63" };
            Rsid rsid332 = new Rsid() { Val = "00C45EBF" };
            Rsid rsid333 = new Rsid() { Val = "00C517D7" };
            Rsid rsid334 = new Rsid() { Val = "00C539AF" };
            Rsid rsid335 = new Rsid() { Val = "00C6741E" };
            Rsid rsid336 = new Rsid() { Val = "00C731A7" };
            Rsid rsid337 = new Rsid() { Val = "00C74B11" };
            Rsid rsid338 = new Rsid() { Val = "00C74DFD" };
            Rsid rsid339 = new Rsid() { Val = "00C76514" };
            Rsid rsid340 = new Rsid() { Val = "00C81822" };
            Rsid rsid341 = new Rsid() { Val = "00C81DD2" };
            Rsid rsid342 = new Rsid() { Val = "00C90402" };
            Rsid rsid343 = new Rsid() { Val = "00CB194D" };
            Rsid rsid344 = new Rsid() { Val = "00CB5ABC" };
            Rsid rsid345 = new Rsid() { Val = "00CB68DB" };
            Rsid rsid346 = new Rsid() { Val = "00CB7B38" };
            Rsid rsid347 = new Rsid() { Val = "00CC1DF0" };
            Rsid rsid348 = new Rsid() { Val = "00CC6CCD" };
            Rsid rsid349 = new Rsid() { Val = "00CE2435" };
            Rsid rsid350 = new Rsid() { Val = "00CF095F" };
            Rsid rsid351 = new Rsid() { Val = "00CF24E0" };
            Rsid rsid352 = new Rsid() { Val = "00CF3B72" };
            Rsid rsid353 = new Rsid() { Val = "00D12697" };
            Rsid rsid354 = new Rsid() { Val = "00D1596B" };
            Rsid rsid355 = new Rsid() { Val = "00D203AC" };
            Rsid rsid356 = new Rsid() { Val = "00D25648" };
            Rsid rsid357 = new Rsid() { Val = "00D25D95" };
            Rsid rsid358 = new Rsid() { Val = "00D27020" };
            Rsid rsid359 = new Rsid() { Val = "00D270EE" };
            Rsid rsid360 = new Rsid() { Val = "00D27B0B" };
            Rsid rsid361 = new Rsid() { Val = "00D34E48" };
            Rsid rsid362 = new Rsid() { Val = "00D36052" };
            Rsid rsid363 = new Rsid() { Val = "00D365E7" };
            Rsid rsid364 = new Rsid() { Val = "00D52C2C" };
            Rsid rsid365 = new Rsid() { Val = "00D53949" };
            Rsid rsid366 = new Rsid() { Val = "00D548A4" };
            Rsid rsid367 = new Rsid() { Val = "00D62C62" };
            Rsid rsid368 = new Rsid() { Val = "00D76DA5" };
            Rsid rsid369 = new Rsid() { Val = "00D807AB" };
            Rsid rsid370 = new Rsid() { Val = "00D854D3" };
            Rsid rsid371 = new Rsid() { Val = "00D8775B" };
            Rsid rsid372 = new Rsid() { Val = "00D87A4A" };
            Rsid rsid373 = new Rsid() { Val = "00D95212" };
            Rsid rsid374 = new Rsid() { Val = "00D95925" };
            Rsid rsid375 = new Rsid() { Val = "00DA08C7" };
            Rsid rsid376 = new Rsid() { Val = "00DA4F1E" };
            Rsid rsid377 = new Rsid() { Val = "00DA566A" };
            Rsid rsid378 = new Rsid() { Val = "00DA5E78" };
            Rsid rsid379 = new Rsid() { Val = "00DA706F" };
            Rsid rsid380 = new Rsid() { Val = "00DB1D4D" };
            Rsid rsid381 = new Rsid() { Val = "00DC2274" };
            Rsid rsid382 = new Rsid() { Val = "00DC2B54" };
            Rsid rsid383 = new Rsid() { Val = "00DC7A47" };
            Rsid rsid384 = new Rsid() { Val = "00DD33A2" };
            Rsid rsid385 = new Rsid() { Val = "00DD416B" };
            Rsid rsid386 = new Rsid() { Val = "00DD5668" };
            Rsid rsid387 = new Rsid() { Val = "00DF1740" };
            Rsid rsid388 = new Rsid() { Val = "00DF1EF6" };
            Rsid rsid389 = new Rsid() { Val = "00DF2316" };
            Rsid rsid390 = new Rsid() { Val = "00DF2E83" };
            Rsid rsid391 = new Rsid() { Val = "00DF5A3F" };
            Rsid rsid392 = new Rsid() { Val = "00E16E88" };
            Rsid rsid393 = new Rsid() { Val = "00E2033A" };
            Rsid rsid394 = new Rsid() { Val = "00E31A3D" };
            Rsid rsid395 = new Rsid() { Val = "00E4262A" };
            Rsid rsid396 = new Rsid() { Val = "00E4584F" };
            Rsid rsid397 = new Rsid() { Val = "00E6116F" };
            Rsid rsid398 = new Rsid() { Val = "00E62F33" };
            Rsid rsid399 = new Rsid() { Val = "00E67E59" };
            Rsid rsid400 = new Rsid() { Val = "00E71EB7" };
            Rsid rsid401 = new Rsid() { Val = "00E744C7" };
            Rsid rsid402 = new Rsid() { Val = "00E758AA" };
            Rsid rsid403 = new Rsid() { Val = "00E81630" };
            Rsid rsid404 = new Rsid() { Val = "00E8706F" };
            Rsid rsid405 = new Rsid() { Val = "00E91F01" };
            Rsid rsid406 = new Rsid() { Val = "00E941D1" };
            Rsid rsid407 = new Rsid() { Val = "00EC1494" };
            Rsid rsid408 = new Rsid() { Val = "00EC5586" };
            Rsid rsid409 = new Rsid() { Val = "00ED11CF" };
            Rsid rsid410 = new Rsid() { Val = "00ED6592" };
            Rsid rsid411 = new Rsid() { Val = "00EE352A" };
            Rsid rsid412 = new Rsid() { Val = "00EF30A8" };
            Rsid rsid413 = new Rsid() { Val = "00EF476A" };
            Rsid rsid414 = new Rsid() { Val = "00EF7E06" };
            Rsid rsid415 = new Rsid() { Val = "00F04185" };
            Rsid rsid416 = new Rsid() { Val = "00F04530" };
            Rsid rsid417 = new Rsid() { Val = "00F14A38" };
            Rsid rsid418 = new Rsid() { Val = "00F20904" };
            Rsid rsid419 = new Rsid() { Val = "00F20F31" };
            Rsid rsid420 = new Rsid() { Val = "00F2317D" };
            Rsid rsid421 = new Rsid() { Val = "00F25F10" };
            Rsid rsid422 = new Rsid() { Val = "00F26D05" };
            Rsid rsid423 = new Rsid() { Val = "00F27EAD" };
            Rsid rsid424 = new Rsid() { Val = "00F3404F" };
            Rsid rsid425 = new Rsid() { Val = "00F431CE" };
            Rsid rsid426 = new Rsid() { Val = "00F51926" };
            Rsid rsid427 = new Rsid() { Val = "00F577FD" };
            Rsid rsid428 = new Rsid() { Val = "00F65395" };
            Rsid rsid429 = new Rsid() { Val = "00F66039" };
            Rsid rsid430 = new Rsid() { Val = "00F710B6" };
            Rsid rsid431 = new Rsid() { Val = "00F72FCD" };
            Rsid rsid432 = new Rsid() { Val = "00F74D4A" };
            Rsid rsid433 = new Rsid() { Val = "00F84E2D" };
            Rsid rsid434 = new Rsid() { Val = "00F94ED7" };
            Rsid rsid435 = new Rsid() { Val = "00FA19FE" };
            Rsid rsid436 = new Rsid() { Val = "00FA4E8B" };
            Rsid rsid437 = new Rsid() { Val = "00FA4F97" };
            Rsid rsid438 = new Rsid() { Val = "00FB0534" };
            Rsid rsid439 = new Rsid() { Val = "00FB1B0D" };
            Rsid rsid440 = new Rsid() { Val = "00FB50D7" };
            Rsid rsid441 = new Rsid() { Val = "00FB5210" };
            Rsid rsid442 = new Rsid() { Val = "00FC25A2" };
            Rsid rsid443 = new Rsid() { Val = "00FC765B" };
            Rsid rsid444 = new Rsid() { Val = "00FC7BE2" };
            Rsid rsid445 = new Rsid() { Val = "00FD1477" };
            Rsid rsid446 = new Rsid() { Val = "00FD454B" };
            Rsid rsid447 = new Rsid() { Val = "00FE5869" };
            Rsid rsid448 = new Rsid() { Val = "00FF12C1" };

            rsids1.Append(rsidRoot1);
            rsids1.Append(rsid6);
            rsids1.Append(rsid7);
            rsids1.Append(rsid8);
            rsids1.Append(rsid9);
            rsids1.Append(rsid10);
            rsids1.Append(rsid11);
            rsids1.Append(rsid12);
            rsids1.Append(rsid13);
            rsids1.Append(rsid14);
            rsids1.Append(rsid15);
            rsids1.Append(rsid16);
            rsids1.Append(rsid17);
            rsids1.Append(rsid18);
            rsids1.Append(rsid19);
            rsids1.Append(rsid20);
            rsids1.Append(rsid21);
            rsids1.Append(rsid22);
            rsids1.Append(rsid23);
            rsids1.Append(rsid24);
            rsids1.Append(rsid25);
            rsids1.Append(rsid26);
            rsids1.Append(rsid27);
            rsids1.Append(rsid28);
            rsids1.Append(rsid29);
            rsids1.Append(rsid30);
            rsids1.Append(rsid31);
            rsids1.Append(rsid32);
            rsids1.Append(rsid33);
            rsids1.Append(rsid34);
            rsids1.Append(rsid35);
            rsids1.Append(rsid36);
            rsids1.Append(rsid37);
            rsids1.Append(rsid38);
            rsids1.Append(rsid39);
            rsids1.Append(rsid40);
            rsids1.Append(rsid41);
            rsids1.Append(rsid42);
            rsids1.Append(rsid43);
            rsids1.Append(rsid44);
            rsids1.Append(rsid45);
            rsids1.Append(rsid46);
            rsids1.Append(rsid47);
            rsids1.Append(rsid48);
            rsids1.Append(rsid49);
            rsids1.Append(rsid50);
            rsids1.Append(rsid51);
            rsids1.Append(rsid52);
            rsids1.Append(rsid53);
            rsids1.Append(rsid54);
            rsids1.Append(rsid55);
            rsids1.Append(rsid56);
            rsids1.Append(rsid57);
            rsids1.Append(rsid58);
            rsids1.Append(rsid59);
            rsids1.Append(rsid60);
            rsids1.Append(rsid61);
            rsids1.Append(rsid62);
            rsids1.Append(rsid63);
            rsids1.Append(rsid64);
            rsids1.Append(rsid65);
            rsids1.Append(rsid66);
            rsids1.Append(rsid67);
            rsids1.Append(rsid68);
            rsids1.Append(rsid69);
            rsids1.Append(rsid70);
            rsids1.Append(rsid71);
            rsids1.Append(rsid72);
            rsids1.Append(rsid73);
            rsids1.Append(rsid74);
            rsids1.Append(rsid75);
            rsids1.Append(rsid76);
            rsids1.Append(rsid77);
            rsids1.Append(rsid78);
            rsids1.Append(rsid79);
            rsids1.Append(rsid80);
            rsids1.Append(rsid81);
            rsids1.Append(rsid82);
            rsids1.Append(rsid83);
            rsids1.Append(rsid84);
            rsids1.Append(rsid85);
            rsids1.Append(rsid86);
            rsids1.Append(rsid87);
            rsids1.Append(rsid88);
            rsids1.Append(rsid89);
            rsids1.Append(rsid90);
            rsids1.Append(rsid91);
            rsids1.Append(rsid92);
            rsids1.Append(rsid93);
            rsids1.Append(rsid94);
            rsids1.Append(rsid95);
            rsids1.Append(rsid96);
            rsids1.Append(rsid97);
            rsids1.Append(rsid98);
            rsids1.Append(rsid99);
            rsids1.Append(rsid100);
            rsids1.Append(rsid101);
            rsids1.Append(rsid102);
            rsids1.Append(rsid103);
            rsids1.Append(rsid104);
            rsids1.Append(rsid105);
            rsids1.Append(rsid106);
            rsids1.Append(rsid107);
            rsids1.Append(rsid108);
            rsids1.Append(rsid109);
            rsids1.Append(rsid110);
            rsids1.Append(rsid111);
            rsids1.Append(rsid112);
            rsids1.Append(rsid113);
            rsids1.Append(rsid114);
            rsids1.Append(rsid115);
            rsids1.Append(rsid116);
            rsids1.Append(rsid117);
            rsids1.Append(rsid118);
            rsids1.Append(rsid119);
            rsids1.Append(rsid120);
            rsids1.Append(rsid121);
            rsids1.Append(rsid122);
            rsids1.Append(rsid123);
            rsids1.Append(rsid124);
            rsids1.Append(rsid125);
            rsids1.Append(rsid126);
            rsids1.Append(rsid127);
            rsids1.Append(rsid128);
            rsids1.Append(rsid129);
            rsids1.Append(rsid130);
            rsids1.Append(rsid131);
            rsids1.Append(rsid132);
            rsids1.Append(rsid133);
            rsids1.Append(rsid134);
            rsids1.Append(rsid135);
            rsids1.Append(rsid136);
            rsids1.Append(rsid137);
            rsids1.Append(rsid138);
            rsids1.Append(rsid139);
            rsids1.Append(rsid140);
            rsids1.Append(rsid141);
            rsids1.Append(rsid142);
            rsids1.Append(rsid143);
            rsids1.Append(rsid144);
            rsids1.Append(rsid145);
            rsids1.Append(rsid146);
            rsids1.Append(rsid147);
            rsids1.Append(rsid148);
            rsids1.Append(rsid149);
            rsids1.Append(rsid150);
            rsids1.Append(rsid151);
            rsids1.Append(rsid152);
            rsids1.Append(rsid153);
            rsids1.Append(rsid154);
            rsids1.Append(rsid155);
            rsids1.Append(rsid156);
            rsids1.Append(rsid157);
            rsids1.Append(rsid158);
            rsids1.Append(rsid159);
            rsids1.Append(rsid160);
            rsids1.Append(rsid161);
            rsids1.Append(rsid162);
            rsids1.Append(rsid163);
            rsids1.Append(rsid164);
            rsids1.Append(rsid165);
            rsids1.Append(rsid166);
            rsids1.Append(rsid167);
            rsids1.Append(rsid168);
            rsids1.Append(rsid169);
            rsids1.Append(rsid170);
            rsids1.Append(rsid171);
            rsids1.Append(rsid172);
            rsids1.Append(rsid173);
            rsids1.Append(rsid174);
            rsids1.Append(rsid175);
            rsids1.Append(rsid176);
            rsids1.Append(rsid177);
            rsids1.Append(rsid178);
            rsids1.Append(rsid179);
            rsids1.Append(rsid180);
            rsids1.Append(rsid181);
            rsids1.Append(rsid182);
            rsids1.Append(rsid183);
            rsids1.Append(rsid184);
            rsids1.Append(rsid185);
            rsids1.Append(rsid186);
            rsids1.Append(rsid187);
            rsids1.Append(rsid188);
            rsids1.Append(rsid189);
            rsids1.Append(rsid190);
            rsids1.Append(rsid191);
            rsids1.Append(rsid192);
            rsids1.Append(rsid193);
            rsids1.Append(rsid194);
            rsids1.Append(rsid195);
            rsids1.Append(rsid196);
            rsids1.Append(rsid197);
            rsids1.Append(rsid198);
            rsids1.Append(rsid199);
            rsids1.Append(rsid200);
            rsids1.Append(rsid201);
            rsids1.Append(rsid202);
            rsids1.Append(rsid203);
            rsids1.Append(rsid204);
            rsids1.Append(rsid205);
            rsids1.Append(rsid206);
            rsids1.Append(rsid207);
            rsids1.Append(rsid208);
            rsids1.Append(rsid209);
            rsids1.Append(rsid210);
            rsids1.Append(rsid211);
            rsids1.Append(rsid212);
            rsids1.Append(rsid213);
            rsids1.Append(rsid214);
            rsids1.Append(rsid215);
            rsids1.Append(rsid216);
            rsids1.Append(rsid217);
            rsids1.Append(rsid218);
            rsids1.Append(rsid219);
            rsids1.Append(rsid220);
            rsids1.Append(rsid221);
            rsids1.Append(rsid222);
            rsids1.Append(rsid223);
            rsids1.Append(rsid224);
            rsids1.Append(rsid225);
            rsids1.Append(rsid226);
            rsids1.Append(rsid227);
            rsids1.Append(rsid228);
            rsids1.Append(rsid229);
            rsids1.Append(rsid230);
            rsids1.Append(rsid231);
            rsids1.Append(rsid232);
            rsids1.Append(rsid233);
            rsids1.Append(rsid234);
            rsids1.Append(rsid235);
            rsids1.Append(rsid236);
            rsids1.Append(rsid237);
            rsids1.Append(rsid238);
            rsids1.Append(rsid239);
            rsids1.Append(rsid240);
            rsids1.Append(rsid241);
            rsids1.Append(rsid242);
            rsids1.Append(rsid243);
            rsids1.Append(rsid244);
            rsids1.Append(rsid245);
            rsids1.Append(rsid246);
            rsids1.Append(rsid247);
            rsids1.Append(rsid248);
            rsids1.Append(rsid249);
            rsids1.Append(rsid250);
            rsids1.Append(rsid251);
            rsids1.Append(rsid252);
            rsids1.Append(rsid253);
            rsids1.Append(rsid254);
            rsids1.Append(rsid255);
            rsids1.Append(rsid256);
            rsids1.Append(rsid257);
            rsids1.Append(rsid258);
            rsids1.Append(rsid259);
            rsids1.Append(rsid260);
            rsids1.Append(rsid261);
            rsids1.Append(rsid262);
            rsids1.Append(rsid263);
            rsids1.Append(rsid264);
            rsids1.Append(rsid265);
            rsids1.Append(rsid266);
            rsids1.Append(rsid267);
            rsids1.Append(rsid268);
            rsids1.Append(rsid269);
            rsids1.Append(rsid270);
            rsids1.Append(rsid271);
            rsids1.Append(rsid272);
            rsids1.Append(rsid273);
            rsids1.Append(rsid274);
            rsids1.Append(rsid275);
            rsids1.Append(rsid276);
            rsids1.Append(rsid277);
            rsids1.Append(rsid278);
            rsids1.Append(rsid279);
            rsids1.Append(rsid280);
            rsids1.Append(rsid281);
            rsids1.Append(rsid282);
            rsids1.Append(rsid283);
            rsids1.Append(rsid284);
            rsids1.Append(rsid285);
            rsids1.Append(rsid286);
            rsids1.Append(rsid287);
            rsids1.Append(rsid288);
            rsids1.Append(rsid289);
            rsids1.Append(rsid290);
            rsids1.Append(rsid291);
            rsids1.Append(rsid292);
            rsids1.Append(rsid293);
            rsids1.Append(rsid294);
            rsids1.Append(rsid295);
            rsids1.Append(rsid296);
            rsids1.Append(rsid297);
            rsids1.Append(rsid298);
            rsids1.Append(rsid299);
            rsids1.Append(rsid300);
            rsids1.Append(rsid301);
            rsids1.Append(rsid302);
            rsids1.Append(rsid303);
            rsids1.Append(rsid304);
            rsids1.Append(rsid305);
            rsids1.Append(rsid306);
            rsids1.Append(rsid307);
            rsids1.Append(rsid308);
            rsids1.Append(rsid309);
            rsids1.Append(rsid310);
            rsids1.Append(rsid311);
            rsids1.Append(rsid312);
            rsids1.Append(rsid313);
            rsids1.Append(rsid314);
            rsids1.Append(rsid315);
            rsids1.Append(rsid316);
            rsids1.Append(rsid317);
            rsids1.Append(rsid318);
            rsids1.Append(rsid319);
            rsids1.Append(rsid320);
            rsids1.Append(rsid321);
            rsids1.Append(rsid322);
            rsids1.Append(rsid323);
            rsids1.Append(rsid324);
            rsids1.Append(rsid325);
            rsids1.Append(rsid326);
            rsids1.Append(rsid327);
            rsids1.Append(rsid328);
            rsids1.Append(rsid329);
            rsids1.Append(rsid330);
            rsids1.Append(rsid331);
            rsids1.Append(rsid332);
            rsids1.Append(rsid333);
            rsids1.Append(rsid334);
            rsids1.Append(rsid335);
            rsids1.Append(rsid336);
            rsids1.Append(rsid337);
            rsids1.Append(rsid338);
            rsids1.Append(rsid339);
            rsids1.Append(rsid340);
            rsids1.Append(rsid341);
            rsids1.Append(rsid342);
            rsids1.Append(rsid343);
            rsids1.Append(rsid344);
            rsids1.Append(rsid345);
            rsids1.Append(rsid346);
            rsids1.Append(rsid347);
            rsids1.Append(rsid348);
            rsids1.Append(rsid349);
            rsids1.Append(rsid350);
            rsids1.Append(rsid351);
            rsids1.Append(rsid352);
            rsids1.Append(rsid353);
            rsids1.Append(rsid354);
            rsids1.Append(rsid355);
            rsids1.Append(rsid356);
            rsids1.Append(rsid357);
            rsids1.Append(rsid358);
            rsids1.Append(rsid359);
            rsids1.Append(rsid360);
            rsids1.Append(rsid361);
            rsids1.Append(rsid362);
            rsids1.Append(rsid363);
            rsids1.Append(rsid364);
            rsids1.Append(rsid365);
            rsids1.Append(rsid366);
            rsids1.Append(rsid367);
            rsids1.Append(rsid368);
            rsids1.Append(rsid369);
            rsids1.Append(rsid370);
            rsids1.Append(rsid371);
            rsids1.Append(rsid372);
            rsids1.Append(rsid373);
            rsids1.Append(rsid374);
            rsids1.Append(rsid375);
            rsids1.Append(rsid376);
            rsids1.Append(rsid377);
            rsids1.Append(rsid378);
            rsids1.Append(rsid379);
            rsids1.Append(rsid380);
            rsids1.Append(rsid381);
            rsids1.Append(rsid382);
            rsids1.Append(rsid383);
            rsids1.Append(rsid384);
            rsids1.Append(rsid385);
            rsids1.Append(rsid386);
            rsids1.Append(rsid387);
            rsids1.Append(rsid388);
            rsids1.Append(rsid389);
            rsids1.Append(rsid390);
            rsids1.Append(rsid391);
            rsids1.Append(rsid392);
            rsids1.Append(rsid393);
            rsids1.Append(rsid394);
            rsids1.Append(rsid395);
            rsids1.Append(rsid396);
            rsids1.Append(rsid397);
            rsids1.Append(rsid398);
            rsids1.Append(rsid399);
            rsids1.Append(rsid400);
            rsids1.Append(rsid401);
            rsids1.Append(rsid402);
            rsids1.Append(rsid403);
            rsids1.Append(rsid404);
            rsids1.Append(rsid405);
            rsids1.Append(rsid406);
            rsids1.Append(rsid407);
            rsids1.Append(rsid408);
            rsids1.Append(rsid409);
            rsids1.Append(rsid410);
            rsids1.Append(rsid411);
            rsids1.Append(rsid412);
            rsids1.Append(rsid413);
            rsids1.Append(rsid414);
            rsids1.Append(rsid415);
            rsids1.Append(rsid416);
            rsids1.Append(rsid417);
            rsids1.Append(rsid418);
            rsids1.Append(rsid419);
            rsids1.Append(rsid420);
            rsids1.Append(rsid421);
            rsids1.Append(rsid422);
            rsids1.Append(rsid423);
            rsids1.Append(rsid424);
            rsids1.Append(rsid425);
            rsids1.Append(rsid426);
            rsids1.Append(rsid427);
            rsids1.Append(rsid428);
            rsids1.Append(rsid429);
            rsids1.Append(rsid430);
            rsids1.Append(rsid431);
            rsids1.Append(rsid432);
            rsids1.Append(rsid433);
            rsids1.Append(rsid434);
            rsids1.Append(rsid435);
            rsids1.Append(rsid436);
            rsids1.Append(rsid437);
            rsids1.Append(rsid438);
            rsids1.Append(rsid439);
            rsids1.Append(rsid440);
            rsids1.Append(rsid441);
            rsids1.Append(rsid442);
            rsids1.Append(rsid443);
            rsids1.Append(rsid444);
            rsids1.Append(rsid445);
            rsids1.Append(rsid446);
            rsids1.Append(rsid447);
            rsids1.Append(rsid448);

            M.MathProperties mathProperties1 = new M.MathProperties();
            M.MathFont mathFont1 = new M.MathFont() { Val = "Cambria Math" };
            M.BreakBinary breakBinary1 = new M.BreakBinary() { Val = M.BreakBinaryOperatorValues.Before };
            M.BreakBinarySubtraction breakBinarySubtraction1 = new M.BreakBinarySubtraction() { Val = M.BreakBinarySubtractionValues.MinusMinus };
            M.SmallFraction smallFraction1 = new M.SmallFraction() { Val = M.BooleanValues.Zero };
            M.DisplayDefaults displayDefaults1 = new M.DisplayDefaults();
            M.LeftMargin leftMargin1 = new M.LeftMargin() { Val = (UInt32Value)0U };
            M.RightMargin rightMargin1 = new M.RightMargin() { Val = (UInt32Value)0U };
            M.DefaultJustification defaultJustification1 = new M.DefaultJustification() { Val = M.JustificationValues.CenterGroup };
            M.WrapIndent wrapIndent1 = new M.WrapIndent() { Val = (UInt32Value)1440U };
            M.IntegralLimitLocation integralLimitLocation1 = new M.IntegralLimitLocation() { Val = M.LimitLocationValues.SubscriptSuperscript };
            M.NaryLimitLocation naryLimitLocation1 = new M.NaryLimitLocation() { Val = M.LimitLocationValues.UnderOver };

            mathProperties1.Append(mathFont1);
            mathProperties1.Append(breakBinary1);
            mathProperties1.Append(breakBinarySubtraction1);
            mathProperties1.Append(smallFraction1);
            mathProperties1.Append(displayDefaults1);
            mathProperties1.Append(leftMargin1);
            mathProperties1.Append(rightMargin1);
            mathProperties1.Append(defaultJustification1);
            mathProperties1.Append(wrapIndent1);
            mathProperties1.Append(integralLimitLocation1);
            mathProperties1.Append(naryLimitLocation1);
            ThemeFontLanguages themeFontLanguages1 = new ThemeFontLanguages() { Val = "ru-RU" };
            ColorSchemeMapping colorSchemeMapping1 = new ColorSchemeMapping() { Background1 = ColorSchemeIndexValues.Light1, Text1 = ColorSchemeIndexValues.Dark1, Background2 = ColorSchemeIndexValues.Light2, Text2 = ColorSchemeIndexValues.Dark2, Accent1 = ColorSchemeIndexValues.Accent1, Accent2 = ColorSchemeIndexValues.Accent2, Accent3 = ColorSchemeIndexValues.Accent3, Accent4 = ColorSchemeIndexValues.Accent4, Accent5 = ColorSchemeIndexValues.Accent5, Accent6 = ColorSchemeIndexValues.Accent6, Hyperlink = ColorSchemeIndexValues.Hyperlink, FollowedHyperlink = ColorSchemeIndexValues.FollowedHyperlink };
            DoNotIncludeSubdocsInStats doNotIncludeSubdocsInStats1 = new DoNotIncludeSubdocsInStats();

            ShapeDefaults shapeDefaults1 = new ShapeDefaults();
            Ovml.ShapeDefaults shapeDefaults2 = new Ovml.ShapeDefaults() { Extension = V.ExtensionHandlingBehaviorValues.Edit, MaxShapeId = 1026 };

            Ovml.ShapeLayout shapeLayout1 = new Ovml.ShapeLayout() { Extension = V.ExtensionHandlingBehaviorValues.Edit };
            Ovml.ShapeIdMap shapeIdMap1 = new Ovml.ShapeIdMap() { Extension = V.ExtensionHandlingBehaviorValues.Edit, Data = "1" };

            shapeLayout1.Append(shapeIdMap1);

            shapeDefaults1.Append(shapeDefaults2);
            shapeDefaults1.Append(shapeLayout1);
            DecimalSymbol decimalSymbol1 = new DecimalSymbol() { Val = "," };
            ListSeparator listSeparator1 = new ListSeparator() { Val = ";" };
            W15.ChartTrackingRefBased chartTrackingRefBased1 = new W15.ChartTrackingRefBased();
            W15.PersistentDocumentId persistentDocumentId1 = new W15.PersistentDocumentId() { Val = "{84943AD5-CAC4-49DA-BA66-B3437F680CD9}" };

            settings1.Append(zoom1);
            settings1.Append(embedSystemFonts1);
            settings1.Append(proofState1);
            settings1.Append(stylePaneFormatFilter1);
            settings1.Append(defaultTabStop1);
            settings1.Append(displayHorizontalDrawingGrid1);
            settings1.Append(displayVerticalDrawingGrid1);
            settings1.Append(doNotUseMarginsForDrawingGridOrigin1);
            settings1.Append(noPunctuationKerning1);
            settings1.Append(characterSpacingControl1);
            settings1.Append(compatibility1);
            settings1.Append(rsids1);
            settings1.Append(mathProperties1);
            settings1.Append(themeFontLanguages1);
            settings1.Append(colorSchemeMapping1);
            settings1.Append(doNotIncludeSubdocsInStats1);
            settings1.Append(shapeDefaults1);
            settings1.Append(decimalSymbol1);
            settings1.Append(listSeparator1);
            settings1.Append(chartTrackingRefBased1);
            settings1.Append(persistentDocumentId1);

            documentSettingsPart1.Settings = settings1;
        }

        private void SetPackageProperties(OpenXmlPackage document)
        {
            document.PackageProperties.Creator = "Владимир Тищенко";
            document.PackageProperties.Title = "Продавец:";
            document.PackageProperties.Subject = "";
            document.PackageProperties.Keywords = "";
            document.PackageProperties.Revision = "23";
            document.PackageProperties.Created = System.Xml.XmlConvert.ToDateTime("2015-09-14T07:23:00Z", System.Xml.XmlDateTimeSerializationMode.RoundtripKind);
            document.PackageProperties.Modified = System.Xml.XmlConvert.ToDateTime("2015-09-14T11:34:00Z", System.Xml.XmlDateTimeSerializationMode.RoundtripKind);
            document.PackageProperties.LastModifiedBy = "Александр Недопака";
            document.PackageProperties.LastPrinted = System.Xml.XmlConvert.ToDateTime("2015-07-23T12:16:00Z", System.Xml.XmlDateTimeSerializationMode.RoundtripKind);
        }


    }
}
