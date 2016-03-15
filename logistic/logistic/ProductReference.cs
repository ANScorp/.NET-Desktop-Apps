using DocumentFormat.OpenXml.Packaging;
using Ap = DocumentFormat.OpenXml.ExtendedProperties;
using Vt = DocumentFormat.OpenXml.VariantTypes;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Wordprocessing;
using Wp = DocumentFormat.OpenXml.Drawing.Wordprocessing;
using A = DocumentFormat.OpenXml.Drawing;
using Pic = DocumentFormat.OpenXml.Drawing.Pictures;
using M = DocumentFormat.OpenXml.Math;
using Ovml = DocumentFormat.OpenXml.Vml.Office;
using V = DocumentFormat.OpenXml.Vml;
using W15 = DocumentFormat.OpenXml.Office2013.Word;
using Ds = DocumentFormat.OpenXml.CustomXmlDataProperties;

namespace logistic
{
    public class ProductReference
    {
        private Form1 frm;

        public ProductReference(Form1 form)
        {
            this.frm = form;
        }

        public ProductReference(NewDeclaration newDeclaration)
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

            DocumentSettingsPart documentSettingsPart1 = mainDocumentPart1.AddNewPart<DocumentSettingsPart>("rId3");
            GenerateDocumentSettingsPart1Content(documentSettingsPart1);

            ThemePart themePart1 = mainDocumentPart1.AddNewPart<ThemePart>("rId7");
            GenerateThemePart1Content(themePart1);

            StyleDefinitionsPart styleDefinitionsPart1 = mainDocumentPart1.AddNewPart<StyleDefinitionsPart>("rId2");
            GenerateStyleDefinitionsPart1Content(styleDefinitionsPart1);

            CustomXmlPart customXmlPart1 = mainDocumentPart1.AddNewPart<CustomXmlPart>("application/xml", "rId1");
            GenerateCustomXmlPart1Content(customXmlPart1);

            CustomXmlPropertiesPart customXmlPropertiesPart1 = customXmlPart1.AddNewPart<CustomXmlPropertiesPart>("rId1");
            GenerateCustomXmlPropertiesPart1Content(customXmlPropertiesPart1);

            FontTablePart fontTablePart1 = mainDocumentPart1.AddNewPart<FontTablePart>("rId6");
            GenerateFontTablePart1Content(fontTablePart1);

            ImagePart imagePart1 = mainDocumentPart1.AddNewPart<ImagePart>("image/jpeg", "rId5");
            GenerateImagePart1Content(imagePart1);

            WebSettingsPart webSettingsPart1 = mainDocumentPart1.AddNewPart<WebSettingsPart>("rId4");
            GenerateWebSettingsPart1Content(webSettingsPart1);

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
            totalTime1.Text = "35";
            Ap.Pages pages1 = new Ap.Pages();
            pages1.Text = "1";
            Ap.Words words1 = new Ap.Words();
            words1.Text = "419";
            Ap.Characters characters1 = new Ap.Characters();
            characters1.Text = "2389";
            Ap.Application application1 = new Ap.Application();
            application1.Text = "Microsoft Office Word";
            Ap.DocumentSecurity documentSecurity1 = new Ap.DocumentSecurity();
            documentSecurity1.Text = "0";
            Ap.Lines lines1 = new Ap.Lines();
            lines1.Text = "19";
            Ap.Paragraphs paragraphs1 = new Ap.Paragraphs();
            paragraphs1.Text = "5";
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
            vTLPSTR2.Text = "";

            vTVector2.Append(vTLPSTR2);

            titlesOfParts1.Append(vTVector2);
            Ap.Company company1 = new Ap.Company();
            company1.Text = "World";
            Ap.LinksUpToDate linksUpToDate1 = new Ap.LinksUpToDate();
            linksUpToDate1.Text = "false";
            Ap.CharactersWithSpaces charactersWithSpaces1 = new Ap.CharactersWithSpaces();
            charactersWithSpaces1.Text = "2803";
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

            Paragraph paragraph1 = new Paragraph() { RsidParagraphAddition = "00EC0405", RsidParagraphProperties = "00EC0405", RsidRunAdditionDefault = "004926AC" };

            ParagraphProperties paragraphProperties1 = new ParagraphProperties();
            Justification justification1 = new Justification() { Val = JustificationValues.Right };

            paragraphProperties1.Append(justification1);

            Run run1 = new Run();

            RunProperties runProperties1 = new RunProperties();
            NoProof noProof1 = new NoProof();
            Languages languages1 = new Languages() { EastAsia = "ru-RU" };

            runProperties1.Append(noProof1);
            runProperties1.Append(languages1);

            Drawing drawing1 = new Drawing();

            Wp.Anchor anchor1 = new Wp.Anchor() { DistanceFromTop = (UInt32Value)0U, DistanceFromBottom = (UInt32Value)0U, DistanceFromLeft = (UInt32Value)114300U, DistanceFromRight = (UInt32Value)114300U, SimplePos = false, RelativeHeight = (UInt32Value)251657728U, BehindDoc = false, Locked = false, LayoutInCell = true, AllowOverlap = true };
            Wp.SimplePosition simplePosition1 = new Wp.SimplePosition() { X = 0L, Y = 0L };

            Wp.HorizontalPosition horizontalPosition1 = new Wp.HorizontalPosition() { RelativeFrom = Wp.HorizontalRelativePositionValues.Column };
            Wp.PositionOffset positionOffset1 = new Wp.PositionOffset();
            positionOffset1.Text = "215265";

            horizontalPosition1.Append(positionOffset1);

            Wp.VerticalPosition verticalPosition1 = new Wp.VerticalPosition() { RelativeFrom = Wp.VerticalRelativePositionValues.Paragraph };
            Wp.PositionOffset positionOffset2 = new Wp.PositionOffset();
            positionOffset2.Text = "-158115";

            verticalPosition1.Append(positionOffset2);
            Wp.Extent extent1 = new Wp.Extent() { Cx = 790575L, Cy = 1095375L };
            Wp.EffectExtent effectExtent1 = new Wp.EffectExtent() { LeftEdge = 19050L, TopEdge = 0L, RightEdge = 9525L, BottomEdge = 0L };
            Wp.WrapNone wrapNone1 = new Wp.WrapNone();
            Wp.DocProperties docProperties1 = new Wp.DocProperties() { Id = (UInt32Value)2U, Name = "Рисунок 5", Description = "C:\\Documents and Settings\\Иван\\Мои документы\\Рисунок3.jpg" };

            Wp.NonVisualGraphicFrameDrawingProperties nonVisualGraphicFrameDrawingProperties1 = new Wp.NonVisualGraphicFrameDrawingProperties();

            A.GraphicFrameLocks graphicFrameLocks1 = new A.GraphicFrameLocks() { NoChangeAspect = true };
            graphicFrameLocks1.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");

            nonVisualGraphicFrameDrawingProperties1.Append(graphicFrameLocks1);

            A.Graphic graphic1 = new A.Graphic();
            graphic1.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");

            A.GraphicData graphicData1 = new A.GraphicData() { Uri = "http://schemas.openxmlformats.org/drawingml/2006/picture" };

            Pic.Picture picture1 = new Pic.Picture();
            picture1.AddNamespaceDeclaration("pic", "http://schemas.openxmlformats.org/drawingml/2006/picture");

            Pic.NonVisualPictureProperties nonVisualPictureProperties1 = new Pic.NonVisualPictureProperties();
            Pic.NonVisualDrawingProperties nonVisualDrawingProperties1 = new Pic.NonVisualDrawingProperties() { Id = (UInt32Value)0U, Name = "Рисунок 5", Description = "C:\\Documents and Settings\\Иван\\Мои документы\\Рисунок3.jpg" };

            Pic.NonVisualPictureDrawingProperties nonVisualPictureDrawingProperties1 = new Pic.NonVisualPictureDrawingProperties();
            A.PictureLocks pictureLocks1 = new A.PictureLocks() { NoChangeAspect = true, NoChangeArrowheads = true };

            nonVisualPictureDrawingProperties1.Append(pictureLocks1);

            nonVisualPictureProperties1.Append(nonVisualDrawingProperties1);
            nonVisualPictureProperties1.Append(nonVisualPictureDrawingProperties1);

            Pic.BlipFill blipFill1 = new Pic.BlipFill();
            A.Blip blip1 = new A.Blip() { Embed = "rId5", CompressionState = A.BlipCompressionValues.Print };
            A.SourceRectangle sourceRectangle1 = new A.SourceRectangle();

            A.Stretch stretch1 = new A.Stretch();
            A.FillRectangle fillRectangle1 = new A.FillRectangle();

            stretch1.Append(fillRectangle1);

            blipFill1.Append(blip1);
            blipFill1.Append(sourceRectangle1);
            blipFill1.Append(stretch1);

            Pic.ShapeProperties shapeProperties1 = new Pic.ShapeProperties() { BlackWhiteMode = A.BlackWhiteModeValues.Auto };

            A.Transform2D transform2D1 = new A.Transform2D();
            A.Offset offset1 = new A.Offset() { X = 0L, Y = 0L };
            A.Extents extents1 = new A.Extents() { Cx = 790575L, Cy = 1095375L };

            transform2D1.Append(offset1);
            transform2D1.Append(extents1);

            A.PresetGeometry presetGeometry1 = new A.PresetGeometry() { Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList1 = new A.AdjustValueList();

            presetGeometry1.Append(adjustValueList1);
            A.NoFill noFill1 = new A.NoFill();

            A.Outline outline1 = new A.Outline() { Width = 9525 };
            A.NoFill noFill2 = new A.NoFill();
            A.Miter miter1 = new A.Miter() { Limit = 800000 };
            A.HeadEnd headEnd1 = new A.HeadEnd();
            A.TailEnd tailEnd1 = new A.TailEnd();

            outline1.Append(noFill2);
            outline1.Append(miter1);
            outline1.Append(headEnd1);
            outline1.Append(tailEnd1);

            shapeProperties1.Append(transform2D1);
            shapeProperties1.Append(presetGeometry1);
            shapeProperties1.Append(noFill1);
            shapeProperties1.Append(outline1);

            picture1.Append(nonVisualPictureProperties1);
            picture1.Append(blipFill1);
            picture1.Append(shapeProperties1);

            graphicData1.Append(picture1);

            graphic1.Append(graphicData1);

            anchor1.Append(simplePosition1);
            anchor1.Append(horizontalPosition1);
            anchor1.Append(verticalPosition1);
            anchor1.Append(extent1);
            anchor1.Append(effectExtent1);
            anchor1.Append(wrapNone1);
            anchor1.Append(docProperties1);
            anchor1.Append(nonVisualGraphicFrameDrawingProperties1);
            anchor1.Append(graphic1);

            drawing1.Append(anchor1);

            run1.Append(runProperties1);
            run1.Append(drawing1);

            Run run2 = new Run() { RsidRunAddition = "008B28F1" };
            Text text1 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text1.Text = " ";

            run2.Append(text1);

            paragraph1.Append(paragraphProperties1);
            paragraph1.Append(run1);
            paragraph1.Append(run2);
            Paragraph paragraph2 = new Paragraph() { RsidParagraphMarkRevision = "00EC0405", RsidParagraphAddition = "00EC0405", RsidParagraphProperties = "00EC0405", RsidRunAdditionDefault = "00EC0405" };

            Paragraph paragraph3 = new Paragraph() { RsidParagraphAddition = "00B87C38", RsidParagraphProperties = "00494188", RsidRunAdditionDefault = "00B87C38" };

            ParagraphProperties paragraphProperties2 = new ParagraphProperties();
            ParagraphStyleId paragraphStyleId1 = new ParagraphStyleId() { Val = "a5" };

            ParagraphMarkRunProperties paragraphMarkRunProperties1 = new ParagraphMarkRunProperties();
            RunFonts runFonts1 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize1 = new FontSize() { Val = "24" };
            FontSizeComplexScript fontSizeComplexScript1 = new FontSizeComplexScript() { Val = "24" };

            paragraphMarkRunProperties1.Append(runFonts1);
            paragraphMarkRunProperties1.Append(fontSize1);
            paragraphMarkRunProperties1.Append(fontSizeComplexScript1);

            paragraphProperties2.Append(paragraphStyleId1);
            paragraphProperties2.Append(paragraphMarkRunProperties1);

            paragraph3.Append(paragraphProperties2);

            Paragraph paragraph4 = new Paragraph() { RsidParagraphAddition = "007559CE", RsidParagraphProperties = "00494188", RsidRunAdditionDefault = "007559CE" };

            ParagraphProperties paragraphProperties3 = new ParagraphProperties();
            ParagraphStyleId paragraphStyleId2 = new ParagraphStyleId() { Val = "a5" };

            ParagraphMarkRunProperties paragraphMarkRunProperties2 = new ParagraphMarkRunProperties();
            Underline underline1 = new Underline() { Val = UnderlineValues.Single };

            paragraphMarkRunProperties2.Append(underline1);

            paragraphProperties3.Append(paragraphStyleId2);
            paragraphProperties3.Append(paragraphMarkRunProperties2);

            paragraph4.Append(paragraphProperties3);

            Paragraph paragraph5 = new Paragraph() { RsidParagraphMarkRevision = "00DF74AF", RsidParagraphAddition = "0027585A", RsidParagraphProperties = "0068723D", RsidRunAdditionDefault = "00E411F2" };
            ProofError proofError1 = new ProofError() { Type = ProofingErrorValues.GrammarStart };

            Run run3 = new Run() { RsidRunProperties = "00EA11DC" };
            Text text2 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text2.Text = "№ ";

            run3.Append(text2);

            Run run4 = new Run() { RsidRunAddition = "006B2FE8" };
            Text text3 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text3.Text = " ";

            run4.Append(text3);
            ProofError proofError2 = new ProofError() { Type = ProofingErrorValues.SpellStart };

            Run run5 = new Run() { RsidRunAddition = "00F11ED0" };

            RunProperties runProperties2 = new RunProperties();
            Languages languages2 = new Languages() { Val = "en-US" };

            runProperties2.Append(languages2);
            Text text4 = new Text();
            text4.Text = frm.prodRefNumber.Text;

            run5.Append(runProperties2);
            run5.Append(text4);
            ProofError proofError3 = new ProofError() { Type = ProofingErrorValues.SpellEnd };
            ProofError proofError4 = new ProofError() { Type = ProofingErrorValues.GrammarEnd };

            Run run6 = new Run() { RsidRunProperties = "00D00670", RsidRunAddition = "00D5014F" };

            RunProperties runProperties3 = new RunProperties();
            Languages languages3 = new Languages() { Val = "uk-UA" };

            runProperties3.Append(languages3);
            Text text5 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text5.Text = " ";

            run6.Append(runProperties3);
            run6.Append(text5);

            Run run7 = new Run() { RsidRunProperties = "00D00670" };
            Text text6 = new Text();
            text6.Text = "от";

            run7.Append(text6);

            Run run8 = new Run() { RsidRunProperties = "00E411F2" };
            Text text7 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text7.Text = " ";

            run8.Append(text7);
            ProofError proofError5 = new ProofError() { Type = ProofingErrorValues.SpellStart };

            Run run9 = new Run() { RsidRunAddition = "00F11ED0" };

            RunProperties runProperties4 = new RunProperties();
            Languages languages4 = new Languages() { Val = "en-US" };

            runProperties4.Append(languages4);
            Text text8 = new Text();
            text8.Text = frm.prodRefDate.Value.ToShortDateString();

            run9.Append(runProperties4);
            run9.Append(text8);
            ProofError proofError6 = new ProofError() { Type = ProofingErrorValues.SpellEnd };

            Run run10 = new Run() { RsidRunProperties = "006D2355", RsidRunAddition = "00F11ED0" };
            Text text9 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text9.Text = " ";

            run10.Append(text9);

            Run run11 = new Run() { RsidRunProperties = "00E411F2" };
            Text text10 = new Text();
            text10.Text = "г.";

            run11.Append(text10);

            Run run12 = new Run() { RsidRunProperties = "00E411F2" };

            RunProperties runProperties5 = new RunProperties();
            Languages languages5 = new Languages() { Val = "uk-UA" };

            runProperties5.Append(languages5);
            Text text11 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text11.Text = "                         ";

            run12.Append(runProperties5);
            run12.Append(text11);

            paragraph5.Append(proofError1);
            paragraph5.Append(run3);
            paragraph5.Append(run4);
            paragraph5.Append(proofError2);
            paragraph5.Append(run5);
            paragraph5.Append(proofError3);
            paragraph5.Append(proofError4);
            paragraph5.Append(run6);
            paragraph5.Append(run7);
            paragraph5.Append(run8);
            paragraph5.Append(proofError5);
            paragraph5.Append(run9);
            paragraph5.Append(proofError6);
            paragraph5.Append(run10);
            paragraph5.Append(run11);
            paragraph5.Append(run12);

            Paragraph paragraph6 = new Paragraph() { RsidParagraphAddition = "00EA1E1B", RsidParagraphProperties = "000D2237", RsidRunAdditionDefault = "003D5F55" };

            ParagraphProperties paragraphProperties4 = new ParagraphProperties();
            ParagraphStyleId paragraphStyleId3 = new ParagraphStyleId() { Val = "a5" };

            ParagraphMarkRunProperties paragraphMarkRunProperties3 = new ParagraphMarkRunProperties();
            Bold bold1 = new Bold();
            FontSize fontSize2 = new FontSize() { Val = "24" };
            FontSizeComplexScript fontSizeComplexScript2 = new FontSizeComplexScript() { Val = "24" };

            paragraphMarkRunProperties3.Append(bold1);
            paragraphMarkRunProperties3.Append(fontSize2);
            paragraphMarkRunProperties3.Append(fontSizeComplexScript2);

            paragraphProperties4.Append(paragraphStyleId3);
            paragraphProperties4.Append(paragraphMarkRunProperties3);

            Run run13 = new Run();

            RunProperties runProperties6 = new RunProperties();
            Bold bold2 = new Bold();
            FontSize fontSize3 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript3 = new FontSizeComplexScript() { Val = "20" };
            Languages languages6 = new Languages() { Val = "uk-UA" };

            runProperties6.Append(bold2);
            runProperties6.Append(fontSize3);
            runProperties6.Append(fontSizeComplexScript3);
            runProperties6.Append(languages6);
            Text text12 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text12.Text = "                                                      ";

            run13.Append(runProperties6);
            run13.Append(text12);

            Run run14 = new Run() { RsidRunAddition = "009F528A" };

            RunProperties runProperties7 = new RunProperties();
            Bold bold3 = new Bold();
            FontSize fontSize4 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript4 = new FontSizeComplexScript() { Val = "20" };
            Languages languages7 = new Languages() { Val = "uk-UA" };

            runProperties7.Append(bold3);
            runProperties7.Append(fontSize4);
            runProperties7.Append(fontSizeComplexScript4);
            runProperties7.Append(languages7);
            Text text13 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text13.Text = "                  ";

            run14.Append(runProperties7);
            run14.Append(text13);

            Run run15 = new Run() { RsidRunAddition = "00494188" };

            RunProperties runProperties8 = new RunProperties();
            Bold bold4 = new Bold();
            FontSize fontSize5 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript5 = new FontSizeComplexScript() { Val = "20" };
            Languages languages8 = new Languages() { Val = "uk-UA" };

            runProperties8.Append(bold4);
            runProperties8.Append(fontSize5);
            runProperties8.Append(fontSizeComplexScript5);
            runProperties8.Append(languages8);
            Text text14 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text14.Text = " ";

            run15.Append(runProperties8);
            run15.Append(text14);

            Run run16 = new Run() { RsidRunProperties = "003835D0", RsidRunAddition = "005F68A3" };

            RunProperties runProperties9 = new RunProperties();
            Bold bold5 = new Bold();
            FontSize fontSize6 = new FontSize() { Val = "24" };
            FontSizeComplexScript fontSizeComplexScript6 = new FontSizeComplexScript() { Val = "24" };

            runProperties9.Append(bold5);
            runProperties9.Append(fontSize6);
            runProperties9.Append(fontSizeComplexScript6);
            Text text15 = new Text();
            text15.Text = "Производственная  справк";

            run16.Append(runProperties9);
            run16.Append(text15);

            Run run17 = new Run() { RsidRunAddition = "00C82E49" };

            RunProperties runProperties10 = new RunProperties();
            Bold bold6 = new Bold();
            FontSize fontSize7 = new FontSize() { Val = "24" };
            FontSizeComplexScript fontSizeComplexScript7 = new FontSizeComplexScript() { Val = "24" };

            runProperties10.Append(bold6);
            runProperties10.Append(fontSize7);
            runProperties10.Append(fontSizeComplexScript7);
            Text text16 = new Text();
            text16.Text = "а";

            run17.Append(runProperties10);
            run17.Append(text16);

            paragraph6.Append(paragraphProperties4);
            paragraph6.Append(run13);
            paragraph6.Append(run14);
            paragraph6.Append(run15);
            paragraph6.Append(run16);
            paragraph6.Append(run17);

            Paragraph paragraph7 = new Paragraph() { RsidParagraphMarkRevision = "007559CE", RsidParagraphAddition = "006B2FE8", RsidParagraphProperties = "000D2237", RsidRunAdditionDefault = "006B2FE8" };

            ParagraphProperties paragraphProperties5 = new ParagraphProperties();
            ParagraphStyleId paragraphStyleId4 = new ParagraphStyleId() { Val = "a5" };

            ParagraphMarkRunProperties paragraphMarkRunProperties4 = new ParagraphMarkRunProperties();
            Bold bold7 = new Bold();
            FontSize fontSize8 = new FontSize() { Val = "24" };
            FontSizeComplexScript fontSizeComplexScript8 = new FontSizeComplexScript() { Val = "24" };

            paragraphMarkRunProperties4.Append(bold7);
            paragraphMarkRunProperties4.Append(fontSize8);
            paragraphMarkRunProperties4.Append(fontSizeComplexScript8);

            paragraphProperties5.Append(paragraphStyleId4);
            paragraphProperties5.Append(paragraphMarkRunProperties4);

            paragraph7.Append(paragraphProperties5);

            Paragraph paragraph8 = new Paragraph() { RsidParagraphMarkRevision = "00CD7C94", RsidParagraphAddition = "00EC0405", RsidParagraphProperties = "00023A35", RsidRunAdditionDefault = "00EC0405" };

            ParagraphProperties paragraphProperties6 = new ParagraphProperties();
            ParagraphStyleId paragraphStyleId5 = new ParagraphStyleId() { Val = "a5" };
            Indentation indentation1 = new Indentation() { FirstLine = "567" };
            Justification justification2 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties5 = new ParagraphMarkRunProperties();
            RunFonts runFonts2 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            paragraphMarkRunProperties5.Append(runFonts2);

            paragraphProperties6.Append(paragraphStyleId5);
            paragraphProperties6.Append(indentation1);
            paragraphProperties6.Append(justification2);
            paragraphProperties6.Append(paragraphMarkRunProperties5);

            Run run18 = new Run() { RsidRunProperties = "00CD7C94" };

            RunProperties runProperties11 = new RunProperties();
            RunFonts runFonts3 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties11.Append(runFonts3);
            Text text17 = new Text();
            text17.Text = "ОО";

            run18.Append(runProperties11);
            run18.Append(text17);

            Run run19 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "008F0261" };

            RunProperties runProperties12 = new RunProperties();
            RunFonts runFonts4 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties12.Append(runFonts4);
            Text text18 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text18.Text = "О «Разек Черкассы» свидетельство о регистрации № ";

            run19.Append(runProperties12);
            run19.Append(text18);

            Run run20 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "008F0261" };

            RunProperties runProperties13 = new RunProperties();
            RunFonts runFonts5 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Languages languages9 = new Languages() { Val = "uk-UA" };

            runProperties13.Append(runFonts5);
            runProperties13.Append(languages9);
            Text text19 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text19.Text = " 36299742 от 23.12.2008 г.";

            run20.Append(runProperties13);
            run20.Append(text19);

            Run run21 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "003B163E" };

            RunProperties runProperties14 = new RunProperties();
            RunFonts runFonts6 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Languages languages10 = new Languages() { Val = "uk-UA" };

            runProperties14.Append(runFonts6);
            runProperties14.Append(languages10);
            Text text20 = new Text();
            text20.Text = ",";

            run21.Append(runProperties14);
            run21.Append(text20);

            Run run22 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "008F0261" };

            RunProperties runProperties15 = new RunProperties();
            RunFonts runFonts7 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Languages languages11 = new Languages() { Val = "uk-UA" };

            runProperties15.Append(runFonts7);
            runProperties15.Append(languages11);
            Text text21 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text21.Text = "  юридический/";

            run22.Append(runProperties15);
            run22.Append(text21);

            Run run23 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "008F0261" };

            RunProperties runProperties16 = new RunProperties();
            RunFonts runFonts8 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties16.Append(runFonts8);
            Text text22 = new Text();
            text22.Text = "почтовый";

            run23.Append(runProperties16);
            run23.Append(text22);

            Run run24 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "008F0261" };

            RunProperties runProperties17 = new RunProperties();
            RunFonts runFonts9 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Languages languages12 = new Languages() { Val = "uk-UA" };

            runProperties17.Append(runFonts9);
            runProperties17.Append(languages12);
            Text text23 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text23.Text = " адрес";

            run24.Append(runProperties17);
            run24.Append(text23);

            Run run25 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "003B163E" };

            RunProperties runProperties18 = new RunProperties();
            RunFonts runFonts10 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Languages languages13 = new Languages() { Val = "uk-UA" };

            runProperties18.Append(runFonts10);
            runProperties18.Append(languages13);
            Text text24 = new Text();
            text24.Text = ":";

            run25.Append(runProperties18);
            run25.Append(text24);

            Run run26 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "008F0261" };

            RunProperties runProperties19 = new RunProperties();
            RunFonts runFonts11 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Languages languages14 = new Languages() { Val = "uk-UA" };

            runProperties19.Append(runFonts11);
            runProperties19.Append(languages14);
            Text text25 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text25.Text = "  г. ";

            run26.Append(runProperties19);
            run26.Append(text25);
            ProofError proofError7 = new ProofError() { Type = ProofingErrorValues.SpellStart };

            Run run27 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "008F0261" };

            RunProperties runProperties20 = new RunProperties();
            RunFonts runFonts12 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Languages languages15 = new Languages() { Val = "uk-UA" };

            runProperties20.Append(runFonts12);
            runProperties20.Append(languages15);
            Text text26 = new Text();
            text26.Text = "Черкассы";

            run27.Append(runProperties20);
            run27.Append(text26);
            ProofError proofError8 = new ProofError() { Type = ProofingErrorValues.SpellEnd };

            Run run28 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "008F0261" };

            RunProperties runProperties21 = new RunProperties();
            RunFonts runFonts13 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Languages languages16 = new Languages() { Val = "uk-UA" };

            runProperties21.Append(runFonts13);
            runProperties21.Append(languages16);
            Text text27 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text27.Text = " ";

            run28.Append(runProperties21);
            run28.Append(text27);

            Run run29 = new Run() { RsidRunProperties = "00CD7C94" };

            RunProperties runProperties22 = new RunProperties();
            RunFonts runFonts14 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties22.Append(runFonts14);
            Text text28 = new Text();
            text28.Text = "пр.";

            run29.Append(runProperties22);
            run29.Append(text28);

            Run run30 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "00573061" };

            RunProperties runProperties23 = new RunProperties();
            RunFonts runFonts15 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties23.Append(runFonts15);
            Text text29 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text29.Text = " ";

            run30.Append(runProperties23);
            run30.Append(text29);

            Run run31 = new Run() { RsidRunProperties = "00CD7C94" };

            RunProperties runProperties24 = new RunProperties();
            RunFonts runFonts16 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties24.Append(runFonts16);
            Text text30 = new Text();
            text30.Text = "Химиков 74, является филиалом французской группы «";

            run31.Append(runProperties24);
            run31.Append(text30);
            ProofError proofError9 = new ProofError() { Type = ProofingErrorValues.SpellStart };

            Run run32 = new Run() { RsidRunProperties = "00CD7C94" };

            RunProperties runProperties25 = new RunProperties();
            RunFonts runFonts17 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties25.Append(runFonts17);
            Text text31 = new Text();
            text31.Text = "Rasec";

            run32.Append(runProperties25);
            run32.Append(text31);
            ProofError proofError10 = new ProofError() { Type = ProofingErrorValues.SpellEnd };

            Run run33 = new Run() { RsidRunProperties = "00CD7C94" };

            RunProperties runProperties26 = new RunProperties();
            RunFonts runFonts18 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties26.Append(runFonts18);
            Text text32 = new Text();
            text32.Text = "» по изготовлению стеллажного оборудования для магазинов и супермаркетов. Открыти";

            run33.Append(runProperties26);
            run33.Append(text32);

            Run run34 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "00256BCC" };

            RunProperties runProperties27 = new RunProperties();
            RunFonts runFonts19 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties27.Append(runFonts19);
            Text text33 = new Text();
            text33.Text = "е";

            run34.Append(runProperties27);
            run34.Append(text33);

            Run run35 = new Run() { RsidRunProperties = "00CD7C94" };

            RunProperties runProperties28 = new RunProperties();
            RunFonts runFonts20 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties28.Append(runFonts20);
            Text text34 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text34.Text = " завода было произведено в 2011 г. Основные рынки сбыта страны Евросоюза и СНГ. Рабочие площади завода составляют первая линия – 7 тыс. м";

            run35.Append(runProperties28);
            run35.Append(text34);

            Run run36 = new Run() { RsidRunProperties = "00CD7C94" };

            RunProperties runProperties29 = new RunProperties();
            RunFonts runFonts21 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            VerticalTextAlignment verticalTextAlignment1 = new VerticalTextAlignment() { Val = VerticalPositionValues.Superscript };

            runProperties29.Append(runFonts21);
            runProperties29.Append(verticalTextAlignment1);
            Text text35 = new Text();
            text35.Text = "2";

            run36.Append(runProperties29);
            run36.Append(text35);

            Run run37 = new Run() { RsidRunProperties = "00CD7C94" };

            RunProperties runProperties30 = new RunProperties();
            RunFonts runFonts22 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties30.Append(runFonts22);
            Text text36 = new Text();
            text36.Text = ", вторая линия – 3 тыс. м";

            run37.Append(runProperties30);
            run37.Append(text36);

            Run run38 = new Run() { RsidRunProperties = "00CD7C94" };

            RunProperties runProperties31 = new RunProperties();
            RunFonts runFonts23 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            VerticalTextAlignment verticalTextAlignment2 = new VerticalTextAlignment() { Val = VerticalPositionValues.Superscript };

            runProperties31.Append(runFonts23);
            runProperties31.Append(verticalTextAlignment2);
            Text text37 = new Text();
            text37.Text = "2";

            run38.Append(runProperties31);
            run38.Append(text37);

            Run run39 = new Run() { RsidRunAddition = "00F11ED0" };

            RunProperties runProperties32 = new RunProperties();
            RunFonts runFonts24 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties32.Append(runFonts24);
            Text text38 = new Text();
            text38.Text = ".";

            run39.Append(runProperties32);
            run39.Append(text38);

            paragraph8.Append(paragraphProperties6);
            paragraph8.Append(run18);
            paragraph8.Append(run19);
            paragraph8.Append(run20);
            paragraph8.Append(run21);
            paragraph8.Append(run22);
            paragraph8.Append(run23);
            paragraph8.Append(run24);
            paragraph8.Append(run25);
            paragraph8.Append(run26);
            paragraph8.Append(proofError7);
            paragraph8.Append(run27);
            paragraph8.Append(proofError8);
            paragraph8.Append(run28);
            paragraph8.Append(run29);
            paragraph8.Append(run30);
            paragraph8.Append(run31);
            paragraph8.Append(proofError9);
            paragraph8.Append(run32);
            paragraph8.Append(proofError10);
            paragraph8.Append(run33);
            paragraph8.Append(run34);
            paragraph8.Append(run35);
            paragraph8.Append(run36);
            paragraph8.Append(run37);
            paragraph8.Append(run38);
            paragraph8.Append(run39);

            Paragraph paragraph9 = new Paragraph() { RsidParagraphMarkRevision = "00CD7C94", RsidParagraphAddition = "00CA4C21", RsidParagraphProperties = "00023A35", RsidRunAdditionDefault = "00245293" };

            ParagraphProperties paragraphProperties7 = new ParagraphProperties();
            ParagraphStyleId paragraphStyleId6 = new ParagraphStyleId() { Val = "a5" };
            Indentation indentation2 = new Indentation() { FirstLine = "567" };
            Justification justification3 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties6 = new ParagraphMarkRunProperties();
            RunFonts runFonts25 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            paragraphMarkRunProperties6.Append(runFonts25);

            paragraphProperties7.Append(paragraphStyleId6);
            paragraphProperties7.Append(indentation2);
            paragraphProperties7.Append(justification3);
            paragraphProperties7.Append(paragraphMarkRunProperties6);

            Run run40 = new Run() { RsidRunProperties = "00CD7C94" };

            RunProperties runProperties33 = new RunProperties();
            RunFonts runFonts26 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties33.Append(runFonts26);
            Text text39 = new Text();
            text39.Text = "Производственн";

            run40.Append(runProperties33);
            run40.Append(text39);

            Run run41 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "000D2237" };

            RunProperties runProperties34 = new RunProperties();
            RunFonts runFonts27 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties34.Append(runFonts27);
            Text text40 = new Text();
            text40.Text = "ы";

            run41.Append(runProperties34);
            run41.Append(text40);

            Run run42 = new Run() { RsidRunProperties = "00CD7C94" };

            RunProperties runProperties35 = new RunProperties();
            RunFonts runFonts28 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties35.Append(runFonts28);
            Text text41 = new Text();
            text41.Text = "е помещения и часть оборудования находится в аренде. Арендодатель ООО «Разек А5 Украина» г. Киев. Основным";

            run42.Append(runProperties35);
            run42.Append(text41);

            Run run43 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "00B4541D" };

            RunProperties runProperties36 = new RunProperties();
            RunFonts runFonts29 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties36.Append(runFonts29);
            Text text42 = new Text();
            text42.Text = "и";

            run43.Append(runProperties36);
            run43.Append(text42);

            Run run44 = new Run() { RsidRunProperties = "00CD7C94" };

            RunProperties runProperties37 = new RunProperties();
            RunFonts runFonts30 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties37.Append(runFonts30);
            Text text43 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text43.Text = " ";

            run44.Append(runProperties37);
            run44.Append(text43);

            Run run45 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "00B4541D" };

            RunProperties runProperties38 = new RunProperties();
            RunFonts runFonts31 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties38.Append(runFonts31);
            Text text44 = new Text();
            text44.Text = "компонентами и материалами";

            run45.Append(runProperties38);
            run45.Append(text44);

            Run run46 = new Run() { RsidRunProperties = "00CD7C94" };

            RunProperties runProperties39 = new RunProperties();
            RunFonts runFonts32 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties39.Append(runFonts32);
            Text text45 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text45.Text = " для изготовления ";

            run46.Append(runProperties39);
            run46.Append(text45);

            Run run47 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "006C5B07" };

            RunProperties runProperties40 = new RunProperties();
            RunFonts runFonts33 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties40.Append(runFonts33);
            Text text46 = new Text();
            text46.Text = "кассовых боксов";

            run47.Append(runProperties40);
            run47.Append(text46);

            Run run48 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "00816EC5" };

            RunProperties runProperties41 = new RunProperties();
            RunFonts runFonts34 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties41.Append(runFonts34);
            Text text47 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text47.Text = " ";

            run48.Append(runProperties41);
            run48.Append(text47);

            Run run49 = new Run() { RsidRunProperties = "00CD7C94" };

            RunProperties runProperties42 = new RunProperties();
            RunFonts runFonts35 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties42.Append(runFonts35);
            Text text48 = new Text();
            text48.Text = "является:";

            run49.Append(runProperties42);
            run49.Append(text48);

            paragraph9.Append(paragraphProperties7);
            paragraph9.Append(run40);
            paragraph9.Append(run41);
            paragraph9.Append(run42);
            paragraph9.Append(run43);
            paragraph9.Append(run44);
            paragraph9.Append(run45);
            paragraph9.Append(run46);
            paragraph9.Append(run47);
            paragraph9.Append(run48);
            paragraph9.Append(run49);

            Paragraph paragraph10 = new Paragraph() { RsidParagraphMarkRevision = "00D62A67", RsidParagraphAddition = "00FC35A8", RsidParagraphProperties = "00D510B6", RsidRunAdditionDefault = "00D510B6" };

            ParagraphProperties paragraphProperties8 = new ParagraphProperties();
            ParagraphStyleId paragraphStyleId7 = new ParagraphStyleId() { Val = "a5" };
            Justification justification4 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties7 = new ParagraphMarkRunProperties();
            RunFonts runFonts36 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            paragraphMarkRunProperties7.Append(runFonts36);

            paragraphProperties8.Append(paragraphStyleId7);
            paragraphProperties8.Append(justification4);
            paragraphProperties8.Append(paragraphMarkRunProperties7);

            Run run50 = new Run() { RsidRunProperties = "00CD7C94" };

            RunProperties runProperties43 = new RunProperties();
            RunFonts runFonts37 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties43.Append(runFonts37);
            Text text49 = new Text();
            text49.Text = "- лист стальной холоднокатаный толщиной –";

            run50.Append(runProperties43);
            run50.Append(text49);

            Run run51 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "0099734D" };

            RunProperties runProperties44 = new RunProperties();
            RunFonts runFonts38 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties44.Append(runFonts38);
            Text text50 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text50.Text = " ";

            run51.Append(runProperties44);
            run51.Append(text50);

            Run run52 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "009B23E2" };

            RunProperties runProperties45 = new RunProperties();
            RunFonts runFonts39 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Languages languages17 = new Languages() { Val = "uk-UA" };

            runProperties45.Append(runFonts39);
            runProperties45.Append(languages17);
            Text text51 = new Text();
            text51.Text = "1.2";

            run52.Append(runProperties45);
            run52.Append(text51);

            Run run53 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "00F326C6" };

            RunProperties runProperties46 = new RunProperties();
            RunFonts runFonts40 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Languages languages18 = new Languages() { Val = "uk-UA" };

            runProperties46.Append(runFonts40);
            runProperties46.Append(languages18);
            Text text52 = new Text();
            text52.Text = ";";

            run53.Append(runProperties46);
            run53.Append(text52);

            Run run54 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "009B23E2" };

            RunProperties runProperties47 = new RunProperties();
            RunFonts runFonts41 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Languages languages19 = new Languages() { Val = "uk-UA" };

            runProperties47.Append(runFonts41);
            runProperties47.Append(languages19);
            Text text53 = new Text();
            text53.Text = "1.5";

            run54.Append(runProperties47);
            run54.Append(text53);

            Run run55 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "00F326C6" };

            RunProperties runProperties48 = new RunProperties();
            RunFonts runFonts42 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Languages languages20 = new Languages() { Val = "uk-UA" };

            runProperties48.Append(runFonts42);
            runProperties48.Append(languages20);
            Text text54 = new Text();
            text54.Text = ";";

            run55.Append(runProperties48);
            run55.Append(text54);

            Run run56 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "009B23E2" };

            RunProperties runProperties49 = new RunProperties();
            RunFonts runFonts43 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Languages languages21 = new Languages() { Val = "uk-UA" };

            runProperties49.Append(runFonts43);
            runProperties49.Append(languages21);
            Text text55 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text55.Text = " 2";

            run56.Append(runProperties49);
            run56.Append(text55);

            Run run57 = new Run() { RsidRunProperties = "00CD7C94" };

            RunProperties runProperties50 = new RunProperties();
            RunFonts runFonts44 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties50.Append(runFonts44);
            Text text56 = new Text();
            text56.Text = "мм, производства «Запорожсталь», Украина";

            run57.Append(runProperties50);
            run57.Append(text56);

            Run run58 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "00FC35A8" };

            RunProperties runProperties51 = new RunProperties();
            RunFonts runFonts45 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties51.Append(runFonts45);
            Text text57 = new Text();
            text57.Text = ";";

            run58.Append(runProperties51);
            run58.Append(text57);

            paragraph10.Append(paragraphProperties8);
            paragraph10.Append(run50);
            paragraph10.Append(run51);
            paragraph10.Append(run52);
            paragraph10.Append(run53);
            paragraph10.Append(run54);
            paragraph10.Append(run55);
            paragraph10.Append(run56);
            paragraph10.Append(run57);
            paragraph10.Append(run58);

            Paragraph paragraph11 = new Paragraph() { RsidParagraphMarkRevision = "00CD7C94", RsidParagraphAddition = "00883326", RsidParagraphProperties = "00D510B6", RsidRunAdditionDefault = "00983E59" };

            ParagraphProperties paragraphProperties9 = new ParagraphProperties();
            ParagraphStyleId paragraphStyleId8 = new ParagraphStyleId() { Val = "a5" };
            Justification justification5 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties8 = new ParagraphMarkRunProperties();
            RunFonts runFonts46 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            paragraphMarkRunProperties8.Append(runFonts46);

            paragraphProperties9.Append(paragraphStyleId8);
            paragraphProperties9.Append(justification5);
            paragraphProperties9.Append(paragraphMarkRunProperties8);

            Run run59 = new Run() { RsidRunProperties = "00CD7C94" };

            RunProperties runProperties52 = new RunProperties();
            RunFonts runFonts47 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties52.Append(runFonts47);
            Text text58 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text58.Text = "- ролик и ";

            run59.Append(runProperties52);
            run59.Append(text58);
            ProofError proofError11 = new ProofError() { Type = ProofingErrorValues.SpellStart };

            Run run60 = new Run() { RsidRunProperties = "00CD7C94" };

            RunProperties runProperties53 = new RunProperties();
            RunFonts runFonts48 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties53.Append(runFonts48);
            Text text59 = new Text();
            text59.Text = "натяжытель";

            run60.Append(runProperties53);
            run60.Append(text59);
            ProofError proofError12 = new ProofError() { Type = ProofingErrorValues.SpellEnd };

            Run run61 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "00FC35A8" };

            RunProperties runProperties54 = new RunProperties();
            RunFonts runFonts49 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties54.Append(runFonts49);
            Text text60 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text60.Text = " специальный производств";

            run61.Append(runProperties54);
            run61.Append(text60);

            Run run62 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "00096A98" };

            RunProperties runProperties55 = new RunProperties();
            RunFonts runFonts50 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties55.Append(runFonts50);
            Text text61 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text61.Text = "а ";

            run62.Append(runProperties55);
            run62.Append(text61);

            Run run63 = new Run() { RsidRunAddition = "00C42493" };

            RunProperties runProperties56 = new RunProperties();
            RunFonts runFonts51 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties56.Append(runFonts51);
            Text text62 = new Text();
            text62.Text = "«";

            run63.Append(runProperties56);
            run63.Append(text62);
            ProofError proofError13 = new ProofError() { Type = ProofingErrorValues.SpellStart };

            Run run64 = new Run() { RsidRunAddition = "001F102B" };

            RunProperties runProperties57 = new RunProperties();
            RunFonts runFonts52 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties57.Append(runFonts52);
            Text text63 = new Text();
            text63.Text = "Юникон";

            run64.Append(runProperties57);
            run64.Append(text63);
            ProofError proofError14 = new ProofError() { Type = ProofingErrorValues.SpellEnd };

            Run run65 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "000A57E8" };

            RunProperties runProperties58 = new RunProperties();
            RunFonts runFonts53 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties58.Append(runFonts53);
            Text text64 = new Text();
            text64.Text = "»";

            run65.Append(runProperties58);
            run65.Append(text64);

            Run run66 = new Run() { RsidRunAddition = "00141321" };

            RunProperties runProperties59 = new RunProperties();
            RunFonts runFonts54 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties59.Append(runFonts54);
            Text text65 = new Text();
            text65.Text = "-";

            run66.Append(runProperties59);
            run66.Append(text65);

            Run run67 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "00141321" };

            RunProperties runProperties60 = new RunProperties();
            RunFonts runFonts55 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties60.Append(runFonts55);
            Text text66 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text66.Text = " ";

            run67.Append(runProperties60);
            run67.Append(text66);

            Run run68 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "00F326C6" };

            RunProperties runProperties61 = new RunProperties();
            RunFonts runFonts56 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties61.Append(runFonts56);
            Text text67 = new Text();
            text67.Text = "ЧЕРКАССЫ";

            run68.Append(runProperties61);
            run68.Append(text67);

            Run run69 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "00883326" };

            RunProperties runProperties62 = new RunProperties();
            RunFonts runFonts57 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties62.Append(runFonts57);
            Text text68 = new Text();
            text68.Text = ", Украина;";

            run69.Append(runProperties62);
            run69.Append(text68);

            paragraph11.Append(paragraphProperties9);
            paragraph11.Append(run59);
            paragraph11.Append(proofError11);
            paragraph11.Append(run60);
            paragraph11.Append(proofError12);
            paragraph11.Append(run61);
            paragraph11.Append(run62);
            paragraph11.Append(run63);
            paragraph11.Append(proofError13);
            paragraph11.Append(run64);
            paragraph11.Append(proofError14);
            paragraph11.Append(run65);
            paragraph11.Append(run66);
            paragraph11.Append(run67);
            paragraph11.Append(run68);
            paragraph11.Append(run69);

            Paragraph paragraph12 = new Paragraph() { RsidParagraphMarkRevision = "00CD7C94", RsidParagraphAddition = "00752D82", RsidParagraphProperties = "00752D82", RsidRunAdditionDefault = "00B03991" };

            ParagraphProperties paragraphProperties10 = new ParagraphProperties();
            ParagraphStyleId paragraphStyleId9 = new ParagraphStyleId() { Val = "a5" };
            Justification justification6 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties9 = new ParagraphMarkRunProperties();
            RunFonts runFonts58 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            paragraphMarkRunProperties9.Append(runFonts58);

            paragraphProperties10.Append(paragraphStyleId9);
            paragraphProperties10.Append(justification6);
            paragraphProperties10.Append(paragraphMarkRunProperties9);

            Run run70 = new Run() { RsidRunProperties = "00CD7C94" };

            RunProperties runProperties63 = new RunProperties();
            RunFonts runFonts59 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties63.Append(runFonts59);
            Text text69 = new Text();
            text69.Text = "-";

            run70.Append(runProperties63);
            run70.Append(text69);

            Run run71 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "00AD49FB" };

            RunProperties runProperties64 = new RunProperties();
            RunFonts runFonts60 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties64.Append(runFonts60);
            Text text70 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text70.Text = "лента конвейерная бесконечная, ";

            run71.Append(runProperties64);
            run71.Append(text70);

            Run run72 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "009B6A1E" };

            RunProperties runProperties65 = new RunProperties();
            RunFonts runFonts61 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties65.Append(runFonts61);
            Text text71 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text71.Text = "краска порошковая, производства Турция, ";

            run72.Append(runProperties65);
            run72.Append(text71);

            Run run73 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "006C5B07" };

            RunProperties runProperties66 = new RunProperties();
            RunFonts runFonts62 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties66.Append(runFonts62);
            Text text72 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text72.Text = "лист стальной н/ж, ";

            run73.Append(runProperties66);
            run73.Append(text72);

            Run run74 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "006A2123" };

            RunProperties runProperties67 = new RunProperties();
            RunFonts runFonts63 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties67.Append(runFonts63);
            Text text73 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text73.Text = "электротехнические изделия, декоративные и защитные элементы из ";

            run74.Append(runProperties67);
            run74.Append(text73);

            Run run75 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "00E8001D" };

            RunProperties runProperties68 = new RunProperties();
            RunFonts runFonts64 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties68.Append(runFonts64);
            Text text74 = new Text();
            text74.Text = "пластика, части общего назначения";

            run75.Append(runProperties68);
            run75.Append(text74);

            Run run76 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "00F326C6" };

            RunProperties runProperties69 = new RunProperties();
            RunFonts runFonts65 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties69.Append(runFonts65);
            Text text75 = new Text();
            text75.Text = ",";

            run76.Append(runProperties69);
            run76.Append(text75);

            Run run77 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "006A2123" };

            RunProperties runProperties70 = new RunProperties();
            RunFonts runFonts66 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties70.Append(runFonts66);
            Text text76 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text76.Text = " ";

            run77.Append(runProperties70);
            run77.Append(text76);

            Run run78 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "007A7C31" };

            RunProperties runProperties71 = new RunProperties();
            RunFonts runFonts67 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties71.Append(runFonts67);
            Text text77 = new Text();
            text77.Text = "прочие материалы и комплектующие неизвестного производства";

            run78.Append(runProperties71);
            run78.Append(text77);

            Run run79 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "00804FCC" };

            RunProperties runProperties72 = new RunProperties();
            RunFonts runFonts68 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties72.Append(runFonts68);
            Text text78 = new Text();
            text78.Text = ":";

            run79.Append(runProperties72);
            run79.Append(text78);

            paragraph12.Append(paragraphProperties10);
            paragraph12.Append(run70);
            paragraph12.Append(run71);
            paragraph12.Append(run72);
            paragraph12.Append(run73);
            paragraph12.Append(run74);
            paragraph12.Append(run75);
            paragraph12.Append(run76);
            paragraph12.Append(run77);
            paragraph12.Append(run78);
            paragraph12.Append(run79);

            Paragraph paragraph13 = new Paragraph() { RsidParagraphMarkRevision = "00CD7C94", RsidParagraphAddition = "00E8001D", RsidParagraphProperties = "002E164D", RsidRunAdditionDefault = "00E8001D" };

            ParagraphProperties paragraphProperties11 = new ParagraphProperties();
            ParagraphStyleId paragraphStyleId10 = new ParagraphStyleId() { Val = "a5" };
            Justification justification7 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties10 = new ParagraphMarkRunProperties();
            RunFonts runFonts69 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            paragraphMarkRunProperties10.Append(runFonts69);

            paragraphProperties11.Append(paragraphStyleId10);
            paragraphProperties11.Append(justification7);
            paragraphProperties11.Append(paragraphMarkRunProperties10);

            Run run80 = new Run() { RsidRunProperties = "00CD7C94" };

            RunProperties runProperties73 = new RunProperties();
            RunFonts runFonts70 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties73.Append(runFonts70);
            Text text79 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text79.Text = "При производстве кассовых боксов производственные ";

            run80.Append(runProperties73);
            run80.Append(text79);

            Run run81 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "00F326C6" };

            RunProperties runProperties74 = new RunProperties();
            RunFonts runFonts71 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties74.Append(runFonts71);
            Text text80 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text80.Text = "затраты и материалы, ";

            run81.Append(runProperties74);
            run81.Append(text80);

            Run run82 = new Run() { RsidRunProperties = "00CD7C94" };

            RunProperties runProperties75 = new RunProperties();
            RunFonts runFonts72 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties75.Append(runFonts72);
            Text text81 = new Text();
            text81.Text = "Украина";

            run82.Append(runProperties75);
            run82.Append(text81);

            Run run83 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "00F326C6" };

            RunProperties runProperties76 = new RunProperties();
            RunFonts runFonts73 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties76.Append(runFonts73);
            Text text82 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text82.Text = ", ";

            run83.Append(runProperties76);
            run83.Append(text82);

            Run run84 = new Run() { RsidRunProperties = "00CD7C94" };

            RunProperties runProperties77 = new RunProperties();
            RunFonts runFonts74 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties77.Append(runFonts74);
            Text text83 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text83.Text = "составили; ";

            run84.Append(runProperties77);
            run84.Append(text83);

            paragraph13.Append(paragraphProperties11);
            paragraph13.Append(run80);
            paragraph13.Append(run81);
            paragraph13.Append(run82);
            paragraph13.Append(run83);
            paragraph13.Append(run84);

            Paragraph paragraph14 = new Paragraph() { RsidParagraphMarkRevision = "006D2355", RsidParagraphAddition = "00753423", RsidParagraphProperties = "00210CF3", RsidRunAdditionDefault = "006D2355" };

            ParagraphProperties paragraphProperties12 = new ParagraphProperties();
            ParagraphStyleId paragraphStyleId11 = new ParagraphStyleId() { Val = "a5" };
            Justification justification8 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties11 = new ParagraphMarkRunProperties();
            RunFonts runFonts75 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize9 = new FontSize() { Val = "24" };
            FontSizeComplexScript fontSizeComplexScript9 = new FontSizeComplexScript() { Val = "24" };

            paragraphMarkRunProperties11.Append(runFonts75);
            paragraphMarkRunProperties11.Append(fontSize9);
            paragraphMarkRunProperties11.Append(fontSizeComplexScript9);

            paragraphProperties12.Append(paragraphStyleId11);
            paragraphProperties12.Append(justification8);
            paragraphProperties12.Append(paragraphMarkRunProperties11);

            Run run85 = new Run();

            RunProperties runProperties78 = new RunProperties();
            RunFonts runFonts76 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize10 = new FontSize() { Val = "24" };
            FontSizeComplexScript fontSizeComplexScript10 = new FontSizeComplexScript() { Val = "24" };
            Languages languages22 = new Languages() { Val = "en-US" };

            runProperties78.Append(runFonts76);
            runProperties78.Append(fontSize10);
            runProperties78.Append(fontSizeComplexScript10);
            runProperties78.Append(languages22);
            Text text84 = new Text();
            text84.Text = "National";

            run85.Append(runProperties78);
            run85.Append(text84);

            paragraph14.Append(paragraphProperties12);
            paragraph14.Append(run85);

            Paragraph paragraph15 = new Paragraph() { RsidParagraphMarkRevision = "00CD7C94", RsidParagraphAddition = "00E8001D", RsidParagraphProperties = "002E164D", RsidRunAdditionDefault = "00E411F2" };

            ParagraphProperties paragraphProperties13 = new ParagraphProperties();
            ParagraphStyleId paragraphStyleId12 = new ParagraphStyleId() { Val = "a5" };
            Justification justification9 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties12 = new ParagraphMarkRunProperties();
            RunFonts runFonts77 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            paragraphMarkRunProperties12.Append(runFonts77);

            paragraphProperties13.Append(paragraphStyleId12);
            paragraphProperties13.Append(justification9);
            paragraphProperties13.Append(paragraphMarkRunProperties12);

            Run run86 = new Run() { RsidRunProperties = "00CD7C94" };

            RunProperties runProperties79 = new RunProperties();
            RunFonts runFonts78 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties79.Append(runFonts78);
            Text text85 = new Text();
            text85.Text = "Материалы";

            run86.Append(runProperties79);
            run86.Append(text85);

            Run run87 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "009F528A" };

            RunProperties runProperties80 = new RunProperties();
            RunFonts runFonts79 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties80.Append(runFonts79);
            Text text86 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text86.Text = " и комплектующие элементы неизвестного происхождения, и ";

            run87.Append(runProperties80);
            run87.Append(text86);

            Run run88 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "00F7283C" };

            RunProperties runProperties81 = new RunProperties();
            RunFonts runFonts80 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties81.Append(runFonts80);
            Text text87 = new Text();
            text87.Text = "приравненных";

            run88.Append(runProperties81);
            run88.Append(text87);

            Run run89 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "009F528A" };

            RunProperties runProperties82 = new RunProperties();
            RunFonts runFonts81 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties82.Append(runFonts81);
            Text text88 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text88.Text = " к ним ";

            run89.Append(runProperties82);
            run89.Append(text88);

            Run run90 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "00F7283C" };

            RunProperties runProperties83 = new RunProperties();
            RunFonts runFonts82 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties83.Append(runFonts82);
            Text text89 = new Text();
            text89.Text = "использованные";

            run90.Append(runProperties83);
            run90.Append(text89);

            Run run91 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "009F528A" };

            RunProperties runProperties84 = new RunProperties();
            RunFonts runFonts83 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties84.Append(runFonts83);
            Text text90 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text90.Text = " при производстве составили;";

            run91.Append(runProperties84);
            run91.Append(text90);

            paragraph15.Append(paragraphProperties13);
            paragraph15.Append(run86);
            paragraph15.Append(run87);
            paragraph15.Append(run88);
            paragraph15.Append(run89);
            paragraph15.Append(run90);
            paragraph15.Append(run91);

            Paragraph paragraph16 = new Paragraph() { RsidParagraphMarkRevision = "00F7283C", RsidParagraphAddition = "003C1C49", RsidParagraphProperties = "003C1C49", RsidRunAdditionDefault = "006D2355" };

            ParagraphProperties paragraphProperties14 = new ParagraphProperties();
            ParagraphStyleId paragraphStyleId13 = new ParagraphStyleId() { Val = "a5" };
            Justification justification10 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties13 = new ParagraphMarkRunProperties();
            RunFonts runFonts84 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize11 = new FontSize() { Val = "24" };
            FontSizeComplexScript fontSizeComplexScript11 = new FontSizeComplexScript() { Val = "24" };

            paragraphMarkRunProperties13.Append(runFonts84);
            paragraphMarkRunProperties13.Append(fontSize11);
            paragraphMarkRunProperties13.Append(fontSizeComplexScript11);

            paragraphProperties14.Append(paragraphStyleId13);
            paragraphProperties14.Append(justification10);
            paragraphProperties14.Append(paragraphMarkRunProperties13);
            ProofError proofError15 = new ProofError() { Type = ProofingErrorValues.SpellStart };

            Run run92 = new Run() { RsidRunProperties = "006D2355" };

            RunProperties runProperties85 = new RunProperties();
            RunFonts runFonts85 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize12 = new FontSize() { Val = "24" };
            FontSizeComplexScript fontSizeComplexScript12 = new FontSizeComplexScript() { Val = "24" };
            Languages languages23 = new Languages() { Val = "en-US" };

            runProperties85.Append(runFonts85);
            runProperties85.Append(fontSize12);
            runProperties85.Append(fontSizeComplexScript12);
            runProperties85.Append(languages23);
            Text text91 = new Text();
            text91.Text = "ImportedMaterials";

            run92.Append(runProperties85);
            run92.Append(text91);
            ProofError proofError16 = new ProofError() { Type = ProofingErrorValues.SpellEnd };

            paragraph16.Append(paragraphProperties14);
            paragraph16.Append(proofError15);
            paragraph16.Append(run92);
            paragraph16.Append(proofError16);

            Paragraph paragraph17 = new Paragraph() { RsidParagraphMarkRevision = "00D42F29", RsidParagraphAddition = "00E411F2", RsidParagraphProperties = "00E411F2", RsidRunAdditionDefault = "00A8186D" };

            ParagraphProperties paragraphProperties15 = new ParagraphProperties();
            ParagraphStyleId paragraphStyleId14 = new ParagraphStyleId() { Val = "a5" };
            Justification justification11 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties14 = new ParagraphMarkRunProperties();
            RunFonts runFonts86 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Languages languages24 = new Languages() { Val = "en-US" };

            paragraphMarkRunProperties14.Append(runFonts86);
            paragraphMarkRunProperties14.Append(languages24);

            paragraphProperties15.Append(paragraphStyleId14);
            paragraphProperties15.Append(justification11);
            paragraphProperties15.Append(paragraphMarkRunProperties14);

            Run run93 = new Run() { RsidRunProperties = "00CD7C94" };

            RunProperties runProperties86 = new RunProperties();
            RunFonts runFonts87 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties86.Append(runFonts87);
            Text text92 = new Text();
            text92.Text = "согл";

            run93.Append(runProperties86);
            run93.Append(text92);

            Run run94 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "00E411F2" };

            RunProperties runProperties87 = new RunProperties();
            RunFonts runFonts88 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties87.Append(runFonts88);
            Text text93 = new Text();
            text93.Text = "асно счёт";

            run94.Append(runProperties87);
            run94.Append(text93);

            Run run95 = new Run() { RsidRunAddition = "00DF74AF" };

            RunProperties runProperties88 = new RunProperties();
            RunFonts runFonts89 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Languages languages25 = new Languages() { Val = "uk-UA" };

            runProperties88.Append(runFonts89);
            runProperties88.Append(languages25);
            Text text94 = new Text();
            text94.Text = "а";

            run95.Append(runProperties88);
            run95.Append(text94);

            Run run96 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "00E411F2" };

            RunProperties runProperties89 = new RunProperties();
            RunFonts runFonts90 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties89.Append(runFonts90);
            Text text95 = new Text();
            text95.Text = "-фактур";

            run96.Append(runProperties89);
            run96.Append(text95);

            Run run97 = new Run() { RsidRunAddition = "003C1C49" };

            RunProperties runProperties90 = new RunProperties();
            RunFonts runFonts91 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Languages languages26 = new Languages() { Val = "uk-UA" };

            runProperties90.Append(runFonts91);
            runProperties90.Append(languages26);
            Text text96 = new Text();
            text96.Text = "ы";

            run97.Append(runProperties90);
            run97.Append(text96);

            Run run98 = new Run() { RsidRunAddition = "00D945CF" };

            RunProperties runProperties91 = new RunProperties();
            RunFonts runFonts92 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties91.Append(runFonts92);
            Text text97 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text97.Text = " ";

            run98.Append(runProperties91);
            run98.Append(text97);

            Run run99 = new Run() { RsidRunProperties = "00D00670", RsidRunAddition = "00C45339" };

            RunProperties runProperties92 = new RunProperties();
            RunFonts runFonts93 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties92.Append(runFonts93);
            Text text98 = new Text();
            text98.Text = "№";

            run99.Append(runProperties92);
            run99.Append(text98);

            Run run100 = new Run() { RsidRunProperties = "00D00670", RsidRunAddition = "002504C3" };

            RunProperties runProperties93 = new RunProperties();
            RunFonts runFonts94 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties93.Append(runFonts94);
            Text text99 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text99.Text = " ";

            run100.Append(runProperties93);
            run100.Append(text99);
            ProofError proofError17 = new ProofError() { Type = ProofingErrorValues.SpellStart };

            Run run101 = new Run() { RsidRunAddition = "004E3C9D" };

            RunProperties runProperties94 = new RunProperties();
            RunFonts runFonts95 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Languages languages27 = new Languages() { Val = "en-US" };

            runProperties94.Append(runFonts95);
            runProperties94.Append(languages27);
            Text text100 = new Text();
            text100.Text = frm.invoiceNumber.Text;

            run101.Append(runProperties94);
            run101.Append(text100);
            ProofError proofError18 = new ProofError() { Type = ProofingErrorValues.SpellEnd };

            Run run102 = new Run() { RsidRunProperties = "00D00670", RsidRunAddition = "002504C3" };

            RunProperties runProperties95 = new RunProperties();
            RunFonts runFonts96 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties95.Append(runFonts96);
            Text text101 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text101.Text = " ";

            run102.Append(runProperties95);
            run102.Append(text101);

            Run run103 = new Run() { RsidRunProperties = "00D00670", RsidRunAddition = "003758A3" };

            RunProperties runProperties96 = new RunProperties();
            RunFonts runFonts97 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Languages languages28 = new Languages() { Val = "uk-UA" };

            runProperties96.Append(runFonts97);
            runProperties96.Append(languages28);
            Text text102 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text102.Text = "от ";

            run103.Append(runProperties96);
            run103.Append(text102);
            ProofError proofError19 = new ProofError() { Type = ProofingErrorValues.SpellStart };

            Run run104 = new Run() { RsidRunAddition = "004E3C9D" };

            RunProperties runProperties97 = new RunProperties();
            RunFonts runFonts98 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Languages languages29 = new Languages() { Val = "en-US" };

            runProperties97.Append(runFonts98);
            runProperties97.Append(languages29);
            Text text103 = new Text();
            text103.Text = frm.invoiceDate.Value.ToShortDateString();

            run104.Append(runProperties97);
            run104.Append(text103);
            ProofError proofError20 = new ProofError() { Type = ProofingErrorValues.SpellEnd };

            Run run105 = new Run() { RsidRunProperties = "004E3C9D", RsidRunAddition = "004E3C9D" };

            RunProperties runProperties98 = new RunProperties();
            RunFonts runFonts99 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties98.Append(runFonts99);
            Text text104 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text104.Text = " ";

            run105.Append(runProperties98);
            run105.Append(text104);

            Run run106 = new Run() { RsidRunProperties = "00D00670", RsidRunAddition = "00E26F4A" };

            RunProperties runProperties99 = new RunProperties();
            RunFonts runFonts100 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Languages languages30 = new Languages() { Val = "uk-UA" };

            runProperties99.Append(runFonts100);
            runProperties99.Append(languages30);
            Text text105 = new Text();
            text105.Text = "г";

            run106.Append(runProperties99);
            run106.Append(text105);

            Run run107 = new Run() { RsidRunProperties = "00D00670", RsidRunAddition = "003C1C49" };

            RunProperties runProperties100 = new RunProperties();
            RunFonts runFonts101 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Languages languages31 = new Languages() { Val = "uk-UA" };

            runProperties100.Append(runFonts101);
            runProperties100.Append(languages31);
            Text text106 = new Text();
            text106.Text = ".";

            run107.Append(runProperties100);
            run107.Append(text106);

            Run run108 = new Run() { RsidRunProperties = "00D00670", RsidRunAddition = "00753423" };

            RunProperties runProperties101 = new RunProperties();
            RunFonts runFonts102 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Languages languages32 = new Languages() { Val = "uk-UA" };

            runProperties101.Append(runFonts102);
            runProperties101.Append(languages32);
            Text text107 = new Text();
            text107.Text = ",";

            run108.Append(runProperties101);
            run108.Append(text107);

            Run run109 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "00447D6C" };

            RunProperties runProperties102 = new RunProperties();
            RunFonts runFonts103 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties102.Append(runFonts103);
            Text text108 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text108.Text = " к";

            run109.Append(runProperties102);
            run109.Append(text108);

            Run run110 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "000A4FF3" };

            RunProperties runProperties103 = new RunProperties();
            RunFonts runFonts104 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties103.Append(runFonts104);
            Text text109 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text109.Text = " ";

            run110.Append(runProperties103);
            run110.Append(text109);

            Run run111 = new Run() { RsidRunAddition = "00115F46" };

            RunProperties runProperties104 = new RunProperties();
            RunFonts runFonts105 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties104.Append(runFonts105);
            Text text110 = new Text();
            text110.Text = "п";

            run111.Append(runProperties104);
            run111.Append(text110);
            BookmarkStart bookmarkStart1 = new BookmarkStart() { Name = "_GoBack", Id = "0" };
            BookmarkEnd bookmarkEnd1 = new BookmarkEnd() { Id = "0" };

            Run run112 = new Run() { RsidRunAddition = "00115F46" };

            RunProperties runProperties105 = new RunProperties();
            RunFonts runFonts106 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties105.Append(runFonts106);
            Text text111 = new Text();
            text111.Text = "риложени";

            run112.Append(runProperties105);
            run112.Append(text111);

            Run run113 = new Run() { RsidRunAddition = "003C1C49" };

            RunProperties runProperties106 = new RunProperties();
            RunFonts runFonts107 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties106.Append(runFonts107);
            Text text112 = new Text();
            text112.Text = "ю";

            run113.Append(runProperties106);
            run113.Append(text112);

            Run run114 = new Run() { RsidRunAddition = "00890F88" };

            RunProperties runProperties107 = new RunProperties();
            RunFonts runFonts108 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties107.Append(runFonts108);
            Text text113 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text113.Text = " ";

            run114.Append(runProperties107);
            run114.Append(text113);

            Run run115 = new Run() { RsidRunProperties = "00D42F29", RsidRunAddition = "00890F88" };

            RunProperties runProperties108 = new RunProperties();
            RunFonts runFonts109 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Languages languages33 = new Languages() { Val = "en-US" };

            runProperties108.Append(runFonts109);
            runProperties108.Append(languages33);
            Text text114 = new Text();
            text114.Text = "№";

            run115.Append(runProperties108);
            run115.Append(text114);

            Run run116 = new Run() { RsidRunProperties = "00D42F29", RsidRunAddition = "00560F5B" };

            RunProperties runProperties109 = new RunProperties();
            RunFonts runFonts110 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Languages languages34 = new Languages() { Val = "en-US" };

            runProperties109.Append(runFonts110);
            runProperties109.Append(languages34);
            Text text115 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text115.Text = " ";

            run116.Append(runProperties109);
            run116.Append(text115);

            Run run117 = new Run() { RsidRunAddition = "004E3C9D" };

            RunProperties runProperties110 = new RunProperties();
            RunFonts runFonts111 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Languages languages35 = new Languages() { Val = "en-US" };

            runProperties110.Append(runFonts111);
            runProperties110.Append(languages35);
            Text text116 = new Text();
            text116.Text = frm.supplementNumber.Text;

            run117.Append(runProperties110);
            run117.Append(text116);

            Run run118 = new Run() { RsidRunProperties = "00D42F29", RsidRunAddition = "00323FE9" };

            RunProperties runProperties111 = new RunProperties();
            RunFonts runFonts112 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Languages languages36 = new Languages() { Val = "en-US" };

            runProperties111.Append(runFonts112);
            runProperties111.Append(languages36);
            Text text117 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text117.Text = " ";

            run118.Append(runProperties111);
            run118.Append(text117);

            Run run119 = new Run() { RsidRunAddition = "00C84067" };

            RunProperties runProperties112 = new RunProperties();
            RunFonts runFonts113 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Languages languages37 = new Languages() { Val = "uk-UA" };

            runProperties112.Append(runFonts113);
            runProperties112.Append(languages37);
            Text text118 = new Text();
            text118.Text = "от";

            run119.Append(runProperties112);
            run119.Append(text118);

            Run run120 = new Run() { RsidRunAddition = "00DF74AF" };

            RunProperties runProperties113 = new RunProperties();
            RunFonts runFonts114 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Languages languages38 = new Languages() { Val = "uk-UA" };

            runProperties113.Append(runFonts114);
            runProperties113.Append(languages38);
            Text text119 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text119.Text = " ";

            run120.Append(runProperties113);
            run120.Append(text119);
            ProofError proofError21 = new ProofError() { Type = ProofingErrorValues.SpellStart };

            Run run121 = new Run() { RsidRunAddition = "004E3C9D" };

            RunProperties runProperties114 = new RunProperties();
            RunFonts runFonts115 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Languages languages39 = new Languages() { Val = "en-US" };

            runProperties114.Append(runFonts115);
            runProperties114.Append(languages39);
            Text text120 = new Text();
            text120.Text = frm.supplementDate.Value.ToShortDateString();

            run121.Append(runProperties114);
            run121.Append(text120);
            ProofError proofError22 = new ProofError() { Type = ProofingErrorValues.SpellEnd };

            Run run122 = new Run() { RsidRunProperties = "00D42F29", RsidRunAddition = "004E3C9D" };

            RunProperties runProperties115 = new RunProperties();
            RunFonts runFonts116 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Languages languages40 = new Languages() { Val = "en-US" };

            runProperties115.Append(runFonts116);
            runProperties115.Append(languages40);
            Text text121 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text121.Text = " ";

            run122.Append(runProperties115);
            run122.Append(text121);

            Run run123 = new Run() { RsidRunAddition = "00C84067" };

            RunProperties runProperties116 = new RunProperties();
            RunFonts runFonts117 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Languages languages41 = new Languages() { Val = "uk-UA" };

            runProperties116.Append(runFonts117);
            runProperties116.Append(languages41);
            Text text122 = new Text();
            text122.Text = "г";

            run123.Append(runProperties116);
            run123.Append(text122);

            Run run124 = new Run() { RsidRunAddition = "003C1C49" };

            RunProperties runProperties117 = new RunProperties();
            RunFonts runFonts118 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Languages languages42 = new Languages() { Val = "uk-UA" };

            runProperties117.Append(runFonts118);
            runProperties117.Append(languages42);
            Text text123 = new Text();
            text123.Text = ".,";

            run124.Append(runProperties117);
            run124.Append(text123);

            Run run125 = new Run() { RsidRunAddition = "00C84067" };

            RunProperties runProperties118 = new RunProperties();
            RunFonts runFonts119 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Languages languages43 = new Languages() { Val = "uk-UA" };

            runProperties118.Append(runFonts119);
            runProperties118.Append(languages43);
            Text text124 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text124.Text = " ";

            run125.Append(runProperties118);
            run125.Append(text124);

            Run run126 = new Run() { RsidRunProperties = "001C4D15", RsidRunAddition = "00E411F2" };

            RunProperties runProperties119 = new RunProperties();
            RunFonts runFonts120 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties119.Append(runFonts120);
            Text text125 = new Text();
            text125.Text = "д";

            run126.Append(runProperties119);
            run126.Append(text125);

            Run run127 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "00E411F2" };

            RunProperties runProperties120 = new RunProperties();
            RunFonts runFonts121 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties120.Append(runFonts121);
            Text text126 = new Text();
            text126.Text = "оговор";

            run127.Append(runProperties120);
            run127.Append(text126);

            Run run128 = new Run() { RsidRunAddition = "00753423" };

            RunProperties runProperties121 = new RunProperties();
            RunFonts runFonts122 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Languages languages44 = new Languages() { Val = "uk-UA" };

            runProperties121.Append(runFonts122);
            runProperties121.Append(languages44);
            Text text127 = new Text();
            text127.Text = "а";

            run128.Append(runProperties121);
            run128.Append(text127);

            Run run129 = new Run() { RsidRunProperties = "00D42F29", RsidRunAddition = "00E411F2" };

            RunProperties runProperties122 = new RunProperties();
            RunFonts runFonts123 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Languages languages45 = new Languages() { Val = "en-US" };

            runProperties122.Append(runFonts123);
            runProperties122.Append(languages45);
            Text text128 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text128.Text = " ";

            run129.Append(runProperties122);
            run129.Append(text128);

            Run run130 = new Run() { RsidRunProperties = "00D42F29", RsidRunAddition = "00E411F2" };

            RunProperties runProperties123 = new RunProperties();
            RunFonts runFonts124 = new RunFonts() { ComplexScript = "Arial" };
            Bold bold8 = new Bold();
            Caps caps1 = new Caps();
            Languages languages46 = new Languages() { Val = "en-US" };

            runProperties123.Append(runFonts124);
            runProperties123.Append(bold8);
            runProperties123.Append(caps1);
            runProperties123.Append(languages46);
            Text text129 = new Text();
            text129.Text = "№";

            run130.Append(runProperties123);
            run130.Append(text129);

            Run run131 = new Run() { RsidRunProperties = "00D42F29", RsidRunAddition = "00E411F2" };

            RunProperties runProperties124 = new RunProperties();
            RunFonts runFonts125 = new RunFonts() { ComplexScript = "Arial" };
            Bold bold9 = new Bold();
            Languages languages47 = new Languages() { Val = "en-US" };

            runProperties124.Append(runFonts125);
            runProperties124.Append(bold9);
            runProperties124.Append(languages47);
            Text text130 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text130.Text = " ";

            run131.Append(runProperties124);
            run131.Append(text130);

            Run run132 = new Run() { RsidRunAddition = "004E3C9D" };

            RunProperties runProperties125 = new RunProperties();
            RunFonts runFonts126 = new RunFonts() { ComplexScript = "Arial" };
            Bold bold10 = new Bold();
            Languages languages48 = new Languages() { Val = "en-US" };

            runProperties125.Append(runFonts126);
            runProperties125.Append(bold10);
            runProperties125.Append(languages48);
            Text text131 = new Text();
            text131.Text = frm.contractNumber.Text;

            run132.Append(runProperties125);
            run132.Append(text131);

            Run run133 = new Run() { RsidRunProperties = "00D42F29", RsidRunAddition = "00E411F2" };

            RunProperties runProperties126 = new RunProperties();
            RunFonts runFonts127 = new RunFonts() { ComplexScript = "Arial" };
            Bold bold11 = new Bold();
            Languages languages49 = new Languages() { Val = "en-US" };

            runProperties126.Append(runFonts127);
            runProperties126.Append(bold11);
            runProperties126.Append(languages49);
            Text text132 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text132.Text = " ";

            run133.Append(runProperties126);
            run133.Append(text132);

            Run run134 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "00E411F2" };

            RunProperties runProperties127 = new RunProperties();
            RunFonts runFonts128 = new RunFonts() { ComplexScript = "Arial" };
            Bold bold12 = new Bold();

            runProperties127.Append(runFonts128);
            runProperties127.Append(bold12);
            Text text133 = new Text();
            text133.Text = "от";

            run134.Append(runProperties127);
            run134.Append(text133);

            Run run135 = new Run() { RsidRunProperties = "00D42F29", RsidRunAddition = "00E411F2" };

            RunProperties runProperties128 = new RunProperties();
            RunFonts runFonts129 = new RunFonts() { ComplexScript = "Arial" };
            Bold bold13 = new Bold();
            Languages languages50 = new Languages() { Val = "en-US" };

            runProperties128.Append(runFonts129);
            runProperties128.Append(bold13);
            runProperties128.Append(languages50);
            Text text134 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text134.Text = " ";

            run135.Append(runProperties128);
            run135.Append(text134);
            ProofError proofError23 = new ProofError() { Type = ProofingErrorValues.SpellStart };

            Run run136 = new Run() { RsidRunAddition = "004E3C9D" };

            RunProperties runProperties129 = new RunProperties();
            RunFonts runFonts130 = new RunFonts() { ComplexScript = "Arial" };
            Bold bold14 = new Bold();
            Languages languages51 = new Languages() { Val = "en-US" };

            runProperties129.Append(runFonts130);
            runProperties129.Append(bold14);
            runProperties129.Append(languages51);
            Text text135 = new Text();
            text135.Text = frm.contractDate.Value.ToShortDateString();

            run136.Append(runProperties129);
            run136.Append(text135);
            ProofError proofError24 = new ProofError() { Type = ProofingErrorValues.SpellEnd };

            Run run137 = new Run() { RsidRunProperties = "00D42F29", RsidRunAddition = "004E3C9D" };

            RunProperties runProperties130 = new RunProperties();
            RunFonts runFonts131 = new RunFonts() { ComplexScript = "Arial" };
            Bold bold15 = new Bold();
            Languages languages52 = new Languages() { Val = "en-US" };

            runProperties130.Append(runFonts131);
            runProperties130.Append(bold15);
            runProperties130.Append(languages52);
            Text text136 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text136.Text = " ";

            run137.Append(runProperties130);
            run137.Append(text136);

            Run run138 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "00E411F2" };

            RunProperties runProperties131 = new RunProperties();
            RunFonts runFonts132 = new RunFonts() { ComplexScript = "Arial" };
            Bold bold16 = new Bold();

            runProperties131.Append(runFonts132);
            runProperties131.Append(bold16);
            Text text137 = new Text();
            text137.Text = "г";

            run138.Append(runProperties131);
            run138.Append(text137);

            Run run139 = new Run() { RsidRunProperties = "00D42F29", RsidRunAddition = "00E411F2" };

            RunProperties runProperties132 = new RunProperties();
            RunFonts runFonts133 = new RunFonts() { ComplexScript = "Arial" };
            Bold bold17 = new Bold();
            Languages languages53 = new Languages() { Val = "en-US" };

            runProperties132.Append(runFonts133);
            runProperties132.Append(bold17);
            runProperties132.Append(languages53);
            Text text138 = new Text();
            text138.Text = ".";

            run139.Append(runProperties132);
            run139.Append(text138);

            Run run140 = new Run() { RsidRunProperties = "00D42F29", RsidRunAddition = "00E411F2" };

            RunProperties runProperties133 = new RunProperties();
            RunFonts runFonts134 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Languages languages54 = new Languages() { Val = "en-US" };

            runProperties133.Append(runFonts134);
            runProperties133.Append(languages54);
            Text text139 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text139.Text = " ";

            run140.Append(runProperties133);
            run140.Append(text139);

            paragraph17.Append(paragraphProperties15);
            paragraph17.Append(run93);
            paragraph17.Append(run94);
            paragraph17.Append(run95);
            paragraph17.Append(run96);
            paragraph17.Append(run97);
            paragraph17.Append(run98);
            paragraph17.Append(run99);
            paragraph17.Append(run100);
            paragraph17.Append(proofError17);
            paragraph17.Append(run101);
            paragraph17.Append(proofError18);
            paragraph17.Append(run102);
            paragraph17.Append(run103);
            paragraph17.Append(proofError19);
            paragraph17.Append(run104);
            paragraph17.Append(proofError20);
            paragraph17.Append(run105);
            paragraph17.Append(run106);
            paragraph17.Append(run107);
            paragraph17.Append(run108);
            paragraph17.Append(run109);
            paragraph17.Append(run110);
            paragraph17.Append(run111);
            paragraph17.Append(bookmarkStart1);
            paragraph17.Append(bookmarkEnd1);
            paragraph17.Append(run112);
            paragraph17.Append(run113);
            paragraph17.Append(run114);
            paragraph17.Append(run115);
            paragraph17.Append(run116);
            paragraph17.Append(run117);
            paragraph17.Append(run118);
            paragraph17.Append(run119);
            paragraph17.Append(run120);
            paragraph17.Append(proofError21);
            paragraph17.Append(run121);
            paragraph17.Append(proofError22);
            paragraph17.Append(run122);
            paragraph17.Append(run123);
            paragraph17.Append(run124);
            paragraph17.Append(run125);
            paragraph17.Append(run126);
            paragraph17.Append(run127);
            paragraph17.Append(run128);
            paragraph17.Append(run129);
            paragraph17.Append(run130);
            paragraph17.Append(run131);
            paragraph17.Append(run132);
            paragraph17.Append(run133);
            paragraph17.Append(run134);
            paragraph17.Append(run135);
            paragraph17.Append(proofError23);
            paragraph17.Append(run136);
            paragraph17.Append(proofError24);
            paragraph17.Append(run137);
            paragraph17.Append(run138);
            paragraph17.Append(run139);
            paragraph17.Append(run140);

            Paragraph paragraph18 = new Paragraph() { RsidParagraphMarkRevision = "00CD7C94", RsidParagraphAddition = "008F0261", RsidParagraphProperties = "0016379A", RsidRunAdditionDefault = "008F0261" };

            ParagraphProperties paragraphProperties16 = new ParagraphProperties();
            ParagraphStyleId paragraphStyleId15 = new ParagraphStyleId() { Val = "a5" };
            Justification justification12 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties15 = new ParagraphMarkRunProperties();
            RunFonts runFonts135 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            paragraphMarkRunProperties15.Append(runFonts135);

            paragraphProperties16.Append(paragraphStyleId15);
            paragraphProperties16.Append(justification12);
            paragraphProperties16.Append(paragraphMarkRunProperties15);

            Run run141 = new Run() { RsidRunProperties = "00CD7C94" };

            RunProperties runProperties134 = new RunProperties();
            RunFonts runFonts136 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties134.Append(runFonts136);
            Text text140 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text140.Text = "На предприятии работает – ";

            run141.Append(runProperties134);
            run141.Append(text140);

            Run run142 = new Run() { RsidRunProperties = "00D62A67", RsidRunAddition = "00A27412" };

            RunProperties runProperties135 = new RunProperties();
            RunFonts runFonts137 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties135.Append(runFonts137);
            Text text141 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text141.Text = "60 ";

            run142.Append(runProperties135);
            run142.Append(text141);

            Run run143 = new Run() { RsidRunProperties = "00CD7C94" };

            RunProperties runProperties136 = new RunProperties();
            RunFonts runFonts138 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties136.Append(runFonts138);
            Text text142 = new Text();
            text142.Text = "человек.";

            run143.Append(runProperties136);
            run143.Append(text142);

            paragraph18.Append(paragraphProperties16);
            paragraph18.Append(run141);
            paragraph18.Append(run142);
            paragraph18.Append(run143);

            Paragraph paragraph19 = new Paragraph() { RsidParagraphMarkRevision = "00CD7C94", RsidParagraphAddition = "009E068D", RsidParagraphProperties = "0016379A", RsidRunAdditionDefault = "008F0261" };

            ParagraphProperties paragraphProperties17 = new ParagraphProperties();
            ParagraphStyleId paragraphStyleId16 = new ParagraphStyleId() { Val = "a5" };
            Justification justification13 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties16 = new ParagraphMarkRunProperties();
            RunFonts runFonts139 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            paragraphMarkRunProperties16.Append(runFonts139);

            paragraphProperties17.Append(paragraphStyleId16);
            paragraphProperties17.Append(justification13);
            paragraphProperties17.Append(paragraphMarkRunProperties16);

            Run run144 = new Run() { RsidRunProperties = "00CD7C94" };

            RunProperties runProperties137 = new RunProperties();
            RunFonts runFonts140 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties137.Append(runFonts140);
            Text text143 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text143.Text = "Краткая технология изготовления: ";

            run144.Append(runProperties137);
            run144.Append(text143);

            Run run145 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "006C5B07" };

            RunProperties runProperties138 = new RunProperties();
            RunFonts runFonts141 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties138.Append(runFonts141);
            Text text144 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text144.Text = "все ";

            run145.Append(runProperties138);
            run145.Append(text144);

            Run run146 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "006A2123" };

            RunProperties runProperties139 = new RunProperties();
            RunFonts runFonts142 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties139.Append(runFonts142);
            Text text145 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text145.Text = "металлические ";

            run146.Append(runProperties139);
            run146.Append(text145);

            Run run147 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "006C5B07" };

            RunProperties runProperties140 = new RunProperties();
            RunFonts runFonts143 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties140.Append(runFonts143);
            Text text146 = new Text();
            text146.Text = "детали";

            run147.Append(runProperties140);
            run147.Append(text146);

            Run run148 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "00514BFD" };

            RunProperties runProperties141 = new RunProperties();
            RunFonts runFonts144 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties141.Append(runFonts144);
            Text text147 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text147.Text = " кассовых боксов";

            run148.Append(runProperties141);
            run148.Append(text147);

            Run run149 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "006A4990" };

            RunProperties runProperties142 = new RunProperties();
            RunFonts runFonts145 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties142.Append(runFonts145);
            Text text148 = new Text();
            text148.Text = ",";

            run149.Append(runProperties142);
            run149.Append(text148);

            Run run150 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "00867D76" };

            RunProperties runProperties143 = new RunProperties();
            RunFonts runFonts146 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties143.Append(runFonts146);
            Text text149 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text149.Text = " ";

            run150.Append(runProperties143);
            run150.Append(text149);

            Run run151 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "006A2123" };

            RunProperties runProperties144 = new RunProperties();
            RunFonts runFonts147 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties144.Append(runFonts147);
            Text text150 = new Text();
            text150.Text = "в т.ч. детали из нержавеющей стали";

            run151.Append(runProperties144);
            run151.Append(text150);

            Run run152 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "006C5B07" };

            RunProperties runProperties145 = new RunProperties();
            RunFonts runFonts148 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties145.Append(runFonts148);
            Text text151 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text151.Text = " (";

            run152.Append(runProperties145);
            run152.Append(text151);

            Run run153 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "00816EC5" };

            RunProperties runProperties146 = new RunProperties();
            RunFonts runFonts149 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties146.Append(runFonts149);
            Text text152 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text152.Text = "стенки, ";

            run153.Append(runProperties146);
            run153.Append(text152);

            Run run154 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "00FF6A47" };

            RunProperties runProperties147 = new RunProperties();
            RunFonts runFonts150 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties147.Append(runFonts150);
            Text text153 = new Text();
            text153.Text = "тумба";

            run154.Append(runProperties147);
            run154.Append(text153);

            Run run155 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "00867D76" };

            RunProperties runProperties148 = new RunProperties();
            RunFonts runFonts151 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties148.Append(runFonts151);
            Text text154 = new Text();
            text154.Text = ",";

            run155.Append(runProperties148);
            run155.Append(text154);

            Run run156 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "0025751E" };

            RunProperties runProperties149 = new RunProperties();
            RunFonts runFonts152 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties149.Append(runFonts152);
            Text text155 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text155.Text = " ";

            run156.Append(runProperties149);
            run156.Append(text155);

            Run run157 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "00816EC5" };

            RunProperties runProperties150 = new RunProperties();
            RunFonts runFonts153 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties150.Append(runFonts153);
            Text text156 = new Text();
            text156.Text = "вставки, полки";

            run157.Append(runProperties150);
            run157.Append(text156);

            Run run158 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "006C5B07" };

            RunProperties runProperties151 = new RunProperties();
            RunFonts runFonts154 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties151.Append(runFonts154);
            Text text157 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text157.Text = ", ";

            run158.Append(runProperties151);
            run158.Append(text157);

            Run run159 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "00FF6A47" };

            RunProperties runProperties152 = new RunProperties();
            RunFonts runFonts155 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties152.Append(runFonts155);
            Text text158 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text158.Text = "ящики, ";

            run159.Append(runProperties152);
            run159.Append(text158);

            Run run160 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "006C5B07" };

            RunProperties runProperties153 = new RunProperties();
            RunFonts runFonts156 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties153.Append(runFonts156);
            Text text159 = new Text();
            text159.Text = "рабочее место кассира,";

            run160.Append(runProperties153);
            run160.Append(text159);

            Run run161 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "00816EC5" };

            RunProperties runProperties154 = new RunProperties();
            RunFonts runFonts157 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties154.Append(runFonts157);
            Text text160 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text160.Text = " ";

            run161.Append(runProperties154);
            run161.Append(text160);

            Run run162 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "00932A9F" };

            RunProperties runProperties155 = new RunProperties();
            RunFonts runFonts158 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties155.Append(runFonts158);
            Text text161 = new Text();
            text161.Text = "подставка под ноги";

            run162.Append(runProperties155);
            run162.Append(text161);

            Run run163 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "006A2123" };

            RunProperties runProperties156 = new RunProperties();
            RunFonts runFonts159 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties156.Append(runFonts159);
            Text text162 = new Text();
            text162.Text = ", накопитель";

            run163.Append(runProperties156);
            run163.Append(text162);

            Run run164 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "006C5B07" };

            RunProperties runProperties157 = new RunProperties();
            RunFonts runFonts160 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties157.Append(runFonts160);
            Text text163 = new Text();
            text163.Text = ")";

            run164.Append(runProperties157);
            run164.Append(text163);

            Run run165 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "002C4588" };

            RunProperties runProperties158 = new RunProperties();
            RunFonts runFonts161 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties158.Append(runFonts161);
            Text text164 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text164.Text = ", ";

            run165.Append(runProperties158);
            run165.Append(text164);

            Run run166 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "00816EC5" };

            RunProperties runProperties159 = new RunProperties();
            RunFonts runFonts162 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties159.Append(runFonts162);
            Text text165 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text165.Text = " ";

            run166.Append(runProperties159);
            run166.Append(text165);

            Run run167 = new Run() { RsidRunProperties = "00CD7C94" };

            RunProperties runProperties160 = new RunProperties();
            RunFonts runFonts163 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties160.Append(runFonts163);
            Text text166 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text166.Text = "вырезаются из листового металла ";

            run167.Append(runProperties160);
            run167.Append(text166);

            Run run168 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "004C42DA" };

            RunProperties runProperties161 = new RunProperties();
            RunFonts runFonts164 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties161.Append(runFonts164);
            Text text167 = new Text();
            text167.Text = "на";

            run168.Append(runProperties161);
            run168.Append(text167);

            Run run169 = new Run() { RsidRunProperties = "00CD7C94" };

            RunProperties runProperties162 = new RunProperties();
            RunFonts runFonts165 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties162.Append(runFonts165);
            Text text168 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text168.Text = " ";

            run169.Append(runProperties162);
            run169.Append(text168);

            Run run170 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "002C4588" };

            RunProperties runProperties163 = new RunProperties();
            RunFonts runFonts166 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties163.Append(runFonts166);
            Text text169 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text169.Text = "верстате ";

            run170.Append(runProperties163);
            run170.Append(text169);

            Run run171 = new Run() { RsidRunProperties = "00CD7C94" };

            RunProperties runProperties164 = new RunProperties();
            RunFonts runFonts167 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties164.Append(runFonts167);
            Text text170 = new Text();
            text170.Text = "лазерно";

            run171.Append(runProperties164);
            run171.Append(text170);

            Run run172 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "002C4588" };

            RunProperties runProperties165 = new RunProperties();
            RunFonts runFonts168 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties165.Append(runFonts168);
            Text text171 = new Text();
            text171.Text = "й резки";

            run172.Append(runProperties165);
            run172.Append(text171);

            Run run173 = new Run() { RsidRunProperties = "00CD7C94" };

            RunProperties runProperties166 = new RunProperties();
            RunFonts runFonts169 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties166.Append(runFonts169);
            Text text172 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text172.Text = " ";

            run173.Append(runProperties166);
            run173.Append(text172);

            Run run174 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "00572D70" };

            RunProperties runProperties167 = new RunProperties();
            RunFonts runFonts170 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties167.Append(runFonts170);
            Text text173 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text173.Text = "с программным управлением ";

            run174.Append(runProperties167);
            run174.Append(text173);

            Run run175 = new Run() { RsidRunProperties = "00CD7C94" };

            RunProperties runProperties168 = new RunProperties();
            RunFonts runFonts171 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties168.Append(runFonts171);
            Text text174 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text174.Text = " «T";

            run175.Append(runProperties168);
            run175.Append(text174);

            Run run176 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "00572D70" };

            RunProperties runProperties169 = new RunProperties();
            RunFonts runFonts172 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Languages languages55 = new Languages() { Val = "en-US" };

            runProperties169.Append(runFonts172);
            runProperties169.Append(languages55);
            Text text175 = new Text();
            text175.Text = "RUMATIC";

            run176.Append(runProperties169);
            run176.Append(text175);

            Run run177 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "00572D70" };

            RunProperties runProperties170 = new RunProperties();
            RunFonts runFonts173 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties170.Append(runFonts173);
            Text text176 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text176.Text = " ";

            run177.Append(runProperties170);
            run177.Append(text176);

            Run run178 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "00572D70" };

            RunProperties runProperties171 = new RunProperties();
            RunFonts runFonts174 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Languages languages56 = new Languages() { Val = "en-US" };

            runProperties171.Append(runFonts174);
            runProperties171.Append(languages56);
            Text text177 = new Text();
            text177.Text = "TCL";

            run178.Append(runProperties171);
            run178.Append(text177);

            Run run179 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "00572D70" };

            RunProperties runProperties172 = new RunProperties();
            RunFonts runFonts175 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties172.Append(runFonts175);
            Text text178 = new Text();
            text178.Text = "-2530";

            run179.Append(runProperties172);
            run179.Append(text178);

            Run run180 = new Run() { RsidRunProperties = "00CD7C94" };

            RunProperties runProperties173 = new RunProperties();
            RunFonts runFonts176 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties173.Append(runFonts176);
            Text text179 = new Text();
            text179.Text = "», форм";

            run180.Append(runProperties173);
            run180.Append(text179);

            Run run181 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "00816EC5" };

            RunProperties runProperties174 = new RunProperties();
            RunFonts runFonts177 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties174.Append(runFonts177);
            Text text180 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text180.Text = "ование и гибка деталей производится ";

            run181.Append(runProperties174);
            run181.Append(text180);

            Run run182 = new Run() { RsidRunProperties = "00CD7C94" };

            RunProperties runProperties175 = new RunProperties();
            RunFonts runFonts178 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties175.Append(runFonts178);
            Text text181 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text181.Text = " ";

            run182.Append(runProperties175);
            run182.Append(text181);

            Run run183 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "00816EC5" };

            RunProperties runProperties176 = new RunProperties();
            RunFonts runFonts179 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties176.Append(runFonts179);
            Text text182 = new Text();
            text182.Text = "на листогибочных прессах «";

            run183.Append(runProperties176);
            run183.Append(text182);

            Run run184 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "00816EC5" };

            RunProperties runProperties177 = new RunProperties();
            RunFonts runFonts180 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Languages languages57 = new Languages() { Val = "en-US" };

            runProperties177.Append(runFonts180);
            runProperties177.Append(languages57);
            Text text183 = new Text();
            text183.Text = "Amada";

            run184.Append(runProperties177);
            run184.Append(text183);

            Run run185 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "00816EC5" };

            RunProperties runProperties178 = new RunProperties();
            RunFonts runFonts181 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties178.Append(runFonts181);
            Text text184 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text184.Text = " ";

            run185.Append(runProperties178);
            run185.Append(text184);
            ProofError proofError25 = new ProofError() { Type = ProofingErrorValues.SpellStart };

            Run run186 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "00816EC5" };

            RunProperties runProperties179 = new RunProperties();
            RunFonts runFonts182 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Languages languages58 = new Languages() { Val = "en-US" };

            runProperties179.Append(runFonts182);
            runProperties179.Append(languages58);
            Text text185 = new Text();
            text185.Text = "Promecam";

            run186.Append(runProperties179);
            run186.Append(text185);
            ProofError proofError26 = new ProofError() { Type = ProofingErrorValues.SpellEnd };

            Run run187 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "00816EC5" };

            RunProperties runProperties180 = new RunProperties();
            RunFonts runFonts183 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties180.Append(runFonts183);
            Text text186 = new Text();
            text186.Text = "».";

            run187.Append(runProperties180);
            run187.Append(text186);

            Run run188 = new Run() { RsidRunProperties = "00CD7C94" };

            RunProperties runProperties181 = new RunProperties();
            RunFonts runFonts184 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties181.Append(runFonts184);
            Text text187 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text187.Text = " Все детали";

            run188.Append(runProperties181);
            run188.Append(text187);

            Run run189 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "006C5B07" };

            RunProperties runProperties182 = new RunProperties();
            RunFonts runFonts185 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties182.Append(runFonts185);
            Text text188 = new Text();
            text188.Text = ", кроме деталей из металла н/ж,";

            run189.Append(runProperties182);
            run189.Append(text188);

            Run run190 = new Run() { RsidRunProperties = "00CD7C94" };

            RunProperties runProperties183 = new RunProperties();
            RunFonts runFonts186 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties183.Append(runFonts186);
            Text text189 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text189.Text = " окрашиваются на линии порошковой окраски «";

            run190.Append(runProperties183);
            run190.Append(text189);

            Run run191 = new Run() { RsidRunProperties = "00CD7C94" };

            RunProperties runProperties184 = new RunProperties();
            RunFonts runFonts187 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Languages languages59 = new Languages() { Val = "uk-UA" };

            runProperties184.Append(runFonts187);
            runProperties184.Append(languages59);
            Text text190 = new Text();
            text190.Text = "Ide";

            run191.Append(runProperties184);
            run191.Append(text190);

            Run run192 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "004C42DA" };

            RunProperties runProperties185 = new RunProperties();
            RunFonts runFonts188 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Languages languages60 = new Languages() { Val = "uk-UA" };

            runProperties185.Append(runFonts188);
            runProperties185.Append(languages60);
            Text text191 = new Text();
            text191.Text = "а";

            run192.Append(runProperties185);
            run192.Append(text191);

            Run run193 = new Run() { RsidRunProperties = "00CD7C94" };

            RunProperties runProperties186 = new RunProperties();
            RunFonts runFonts189 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Languages languages61 = new Languages() { Val = "uk-UA" };

            runProperties186.Append(runFonts189);
            runProperties186.Append(languages61);
            Text text192 = new Text();
            text192.Text = "l line»";

            run193.Append(runProperties186);
            run193.Append(text192);

            Run run194 = new Run() { RsidRunProperties = "00CD7C94" };

            RunProperties runProperties187 = new RunProperties();
            RunFonts runFonts190 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties187.Append(runFonts190);
            Text text193 = new Text();
            text193.Text = ".";

            run194.Append(runProperties187);
            run194.Append(text193);

            Run run195 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "009E068D" };

            RunProperties runProperties188 = new RunProperties();
            RunFonts runFonts191 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties188.Append(runFonts191);
            Text text194 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text194.Text = " ";

            run195.Append(runProperties188);
            run195.Append(text194);

            Run run196 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "003B7D73" };

            RunProperties runProperties189 = new RunProperties();
            RunFonts runFonts192 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties189.Append(runFonts192);
            Text text195 = new Text();
            text195.Text = "Сборка и соединение деталей кассов";

            run196.Append(runProperties189);
            run196.Append(text195);

            Run run197 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "00347B7D" };

            RunProperties runProperties190 = new RunProperties();
            RunFonts runFonts193 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties190.Append(runFonts193);
            Text text196 = new Text();
            text196.Text = "ых";

            run197.Append(runProperties190);
            run197.Append(text196);

            Run run198 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "003B7D73" };

            RunProperties runProperties191 = new RunProperties();
            RunFonts runFonts194 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties191.Append(runFonts194);
            Text text197 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text197.Text = " бокс";

            run198.Append(runProperties191);
            run198.Append(text197);

            Run run199 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "00347B7D" };

            RunProperties runProperties192 = new RunProperties();
            RunFonts runFonts195 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties192.Append(runFonts195);
            Text text198 = new Text();
            text198.Text = "ов";

            run199.Append(runProperties192);
            run199.Append(text198);

            Run run200 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "003B7D73" };

            RunProperties runProperties193 = new RunProperties();
            RunFonts runFonts196 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties193.Append(runFonts196);
            Text text199 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text199.Text = ", в т.ч. установка ";

            run200.Append(runProperties193);
            run200.Append(text199);

            Run run201 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "00A4235F" };

            RunProperties runProperties194 = new RunProperties();
            RunFonts runFonts197 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties194.Append(runFonts197);
            Text text200 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text200.Text = "двигателя привода ленты, установка электротехнических изделий, защитных и декоративных элементов из пластика, ";

            run201.Append(runProperties194);
            run201.Append(text200);

            Run run202 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "003B7D73" };

            RunProperties runProperties195 = new RunProperties();
            RunFonts runFonts198 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties195.Append(runFonts198);
            Text text201 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text201.Text = "ролика натяжного, ленты конвейерной ";

            run202.Append(runProperties195);
            run202.Append(text201);

            Run run203 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "009E068D" };

            RunProperties runProperties196 = new RunProperties();
            RunFonts runFonts199 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties196.Append(runFonts199);
            Text text202 = new Text();
            text202.Text = "производится с помощью";

            run203.Append(runProperties196);
            run203.Append(text202);

            Run run204 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "006A2123" };

            RunProperties runProperties197 = new RunProperties();
            RunFonts runFonts200 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties197.Append(runFonts200);
            Text text203 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text203.Text = " ";

            run204.Append(runProperties197);
            run204.Append(text203);

            Run run205 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "006C5B07" };

            RunProperties runProperties198 = new RunProperties();
            RunFonts runFonts201 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties198.Append(runFonts201);
            Text text204 = new Text();
            text204.Text = "винтов, болтов";

            run205.Append(runProperties198);
            run205.Append(text204);

            Run run206 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "003B7D73" };

            RunProperties runProperties199 = new RunProperties();
            RunFonts runFonts202 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties199.Append(runFonts202);
            Text text205 = new Text();
            text205.Text = ",";

            run206.Append(runProperties199);
            run206.Append(text205);

            Run run207 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "006C5B07" };

            RunProperties runProperties200 = new RunProperties();
            RunFonts runFonts203 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties200.Append(runFonts203);
            Text text206 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text206.Text = " ";

            run207.Append(runProperties200);
            run207.Append(text206);

            Run run208 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "00A4235F" };

            RunProperties runProperties201 = new RunProperties();
            RunFonts runFonts204 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties201.Append(runFonts204);
            Text text207 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text207.Text = "саморезов, ";

            run208.Append(runProperties201);
            run208.Append(text207);

            Run run209 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "009E068D" };

            RunProperties runProperties202 = new RunProperties();
            RunFonts runFonts205 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties202.Append(runFonts205);
            Text text208 = new Text();
            text208.Text = "заклёпок";

            run209.Append(runProperties202);
            run209.Append(text208);

            Run run210 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "003B7D73" };

            RunProperties runProperties203 = new RunProperties();
            RunFonts runFonts206 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties203.Append(runFonts206);
            Text text209 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text209.Text = " и сварки";

            run210.Append(runProperties203);
            run210.Append(text209);

            Run run211 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "00023A35" };

            RunProperties runProperties204 = new RunProperties();
            RunFonts runFonts207 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties204.Append(runFonts207);
            Text text210 = new Text();
            text210.Text = ".";

            run211.Append(runProperties204);
            run211.Append(text210);

            paragraph19.Append(paragraphProperties17);
            paragraph19.Append(run144);
            paragraph19.Append(run145);
            paragraph19.Append(run146);
            paragraph19.Append(run147);
            paragraph19.Append(run148);
            paragraph19.Append(run149);
            paragraph19.Append(run150);
            paragraph19.Append(run151);
            paragraph19.Append(run152);
            paragraph19.Append(run153);
            paragraph19.Append(run154);
            paragraph19.Append(run155);
            paragraph19.Append(run156);
            paragraph19.Append(run157);
            paragraph19.Append(run158);
            paragraph19.Append(run159);
            paragraph19.Append(run160);
            paragraph19.Append(run161);
            paragraph19.Append(run162);
            paragraph19.Append(run163);
            paragraph19.Append(run164);
            paragraph19.Append(run165);
            paragraph19.Append(run166);
            paragraph19.Append(run167);
            paragraph19.Append(run168);
            paragraph19.Append(run169);
            paragraph19.Append(run170);
            paragraph19.Append(run171);
            paragraph19.Append(run172);
            paragraph19.Append(run173);
            paragraph19.Append(run174);
            paragraph19.Append(run175);
            paragraph19.Append(run176);
            paragraph19.Append(run177);
            paragraph19.Append(run178);
            paragraph19.Append(run179);
            paragraph19.Append(run180);
            paragraph19.Append(run181);
            paragraph19.Append(run182);
            paragraph19.Append(run183);
            paragraph19.Append(run184);
            paragraph19.Append(run185);
            paragraph19.Append(proofError25);
            paragraph19.Append(run186);
            paragraph19.Append(proofError26);
            paragraph19.Append(run187);
            paragraph19.Append(run188);
            paragraph19.Append(run189);
            paragraph19.Append(run190);
            paragraph19.Append(run191);
            paragraph19.Append(run192);
            paragraph19.Append(run193);
            paragraph19.Append(run194);
            paragraph19.Append(run195);
            paragraph19.Append(run196);
            paragraph19.Append(run197);
            paragraph19.Append(run198);
            paragraph19.Append(run199);
            paragraph19.Append(run200);
            paragraph19.Append(run201);
            paragraph19.Append(run202);
            paragraph19.Append(run203);
            paragraph19.Append(run204);
            paragraph19.Append(run205);
            paragraph19.Append(run206);
            paragraph19.Append(run207);
            paragraph19.Append(run208);
            paragraph19.Append(run209);
            paragraph19.Append(run210);
            paragraph19.Append(run211);

            Paragraph paragraph20 = new Paragraph() { RsidParagraphAddition = "00EA1E1B", RsidParagraphProperties = "00C82E49", RsidRunAdditionDefault = "0025751E" };

            ParagraphProperties paragraphProperties18 = new ParagraphProperties();
            ParagraphStyleId paragraphStyleId17 = new ParagraphStyleId() { Val = "a5" };
            Indentation indentation3 = new Indentation() { FirstLine = "567" };
            Justification justification14 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties17 = new ParagraphMarkRunProperties();
            RunFonts runFonts208 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            paragraphMarkRunProperties17.Append(runFonts208);

            paragraphProperties18.Append(paragraphStyleId17);
            paragraphProperties18.Append(indentation3);
            paragraphProperties18.Append(justification14);
            paragraphProperties18.Append(paragraphMarkRunProperties17);

            Run run212 = new Run() { RsidRunProperties = "00CD7C94" };

            RunProperties runProperties205 = new RunProperties();
            RunFonts runFonts209 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties205.Append(runFonts209);
            Text text211 = new Text();
            text211.Text = "Крышк";

            run212.Append(runProperties205);
            run212.Append(text211);

            Run run213 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "00FC1142" };

            RunProperties runProperties206 = new RunProperties();
            RunFonts runFonts210 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties206.Append(runFonts210);
            Text text212 = new Text();
            text212.Text = "и";

            run213.Append(runProperties206);
            run213.Append(text212);

            Run run214 = new Run() { RsidRunProperties = "00CD7C94" };

            RunProperties runProperties207 = new RunProperties();
            RunFonts runFonts211 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties207.Append(runFonts211);
            Text text213 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text213.Text = " столешниц ";

            run214.Append(runProperties207);
            run214.Append(text213);

            Run run215 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "00FF6A47" };

            RunProperties runProperties208 = new RunProperties();
            RunFonts runFonts212 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties208.Append(runFonts212);
            Text text214 = new Text();
            text214.Text = "тумб кассов";

            run215.Append(runProperties208);
            run215.Append(text214);

            Run run216 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "00FC1142" };

            RunProperties runProperties209 = new RunProperties();
            RunFonts runFonts213 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties209.Append(runFonts213);
            Text text215 = new Text();
            text215.Text = "ых";

            run216.Append(runProperties209);
            run216.Append(text215);

            Run run217 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "00FF6A47" };

            RunProperties runProperties210 = new RunProperties();
            RunFonts runFonts214 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties210.Append(runFonts214);
            Text text216 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text216.Text = " бокс";

            run217.Append(runProperties210);
            run217.Append(text216);

            Run run218 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "00FC1142" };

            RunProperties runProperties211 = new RunProperties();
            RunFonts runFonts215 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties211.Append(runFonts215);
            Text text217 = new Text();
            text217.Text = "ов";

            run218.Append(runProperties211);
            run218.Append(text217);

            Run run219 = new Run() { RsidRunProperties = "00D62A67", RsidRunAddition = "00CA2948" };

            RunProperties runProperties212 = new RunProperties();
            RunFonts runFonts216 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties212.Append(runFonts216);
            Text text218 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text218.Text = " ";

            run219.Append(runProperties212);
            run219.Append(text218);

            Run run220 = new Run() { RsidRunProperties = "00CD7C94" };

            RunProperties runProperties213 = new RunProperties();
            RunFonts runFonts217 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties213.Append(runFonts217);
            Text text219 = new Text();
            text219.Text = "выреза";

            run220.Append(runProperties213);
            run220.Append(text219);

            Run run221 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "00FC1142" };

            RunProperties runProperties214 = new RunProperties();
            RunFonts runFonts218 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties214.Append(runFonts218);
            Text text220 = new Text();
            text220.Text = "ю";

            run221.Append(runProperties214);
            run221.Append(text220);

            Run run222 = new Run() { RsidRunProperties = "00CD7C94" };

            RunProperties runProperties215 = new RunProperties();
            RunFonts runFonts219 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties215.Append(runFonts219);
            Text text221 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text221.Text = "тся на деревообрабатывающем ";

            run222.Append(runProperties215);
            run222.Append(text221);

            Run run223 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "00912DE1" };

            RunProperties runProperties216 = new RunProperties();
            RunFonts runFonts220 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties216.Append(runFonts220);
            Text text222 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text222.Text = "центре ";

            run223.Append(runProperties216);
            run223.Append(text222);

            Run run224 = new Run() { RsidRunProperties = "00CD7C94" };

            RunProperties runProperties217 = new RunProperties();
            RunFonts runFonts221 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties217.Append(runFonts221);
            Text text223 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text223.Text = "с цифровым программным управлением ";

            run224.Append(runProperties217);
            run224.Append(text223);

            Run run225 = new Run() { RsidRunProperties = "00CD7C94" };

            RunProperties runProperties218 = new RunProperties();
            RunFonts runFonts222 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            BoldComplexScript boldComplexScript1 = new BoldComplexScript();
            Color color1 = new Color() { Val = "000000" };

            runProperties218.Append(runFonts222);
            runProperties218.Append(boldComplexScript1);
            runProperties218.Append(color1);
            Text text224 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text224.Text = "марки ";

            run225.Append(runProperties218);
            run225.Append(text224);

            Run run226 = new Run() { RsidRunProperties = "00CD7C94" };

            RunProperties runProperties219 = new RunProperties();
            RunFonts runFonts223 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            BoldComplexScript boldComplexScript2 = new BoldComplexScript();
            Color color2 = new Color() { Val = "000000" };
            Languages languages62 = new Languages() { Val = "en-US" };

            runProperties219.Append(runFonts223);
            runProperties219.Append(boldComplexScript2);
            runProperties219.Append(color2);
            runProperties219.Append(languages62);
            Text text225 = new Text();
            text225.Text = "MORBIDELLI";

            run226.Append(runProperties219);
            run226.Append(text225);

            Run run227 = new Run() { RsidRunAddition = "002D19ED" };

            RunProperties runProperties220 = new RunProperties();
            RunFonts runFonts224 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            BoldComplexScript boldComplexScript3 = new BoldComplexScript();
            Color color3 = new Color() { Val = "000000" };

            runProperties220.Append(runFonts224);
            runProperties220.Append(boldComplexScript3);
            runProperties220.Append(color3);
            Text text226 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text226.Text = ", тип ";

            run227.Append(runProperties220);
            run227.Append(text226);

            Run run228 = new Run() { RsidRunProperties = "00CD7C94" };

            RunProperties runProperties221 = new RunProperties();
            RunFonts runFonts225 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            BoldComplexScript boldComplexScript4 = new BoldComplexScript();
            Color color4 = new Color() { Val = "000000" };
            Languages languages63 = new Languages() { Val = "en-US" };

            runProperties221.Append(runFonts225);
            runProperties221.Append(boldComplexScript4);
            runProperties221.Append(color4);
            runProperties221.Append(languages63);
            Text text227 = new Text();
            text227.Text = "AUTHOR";

            run228.Append(runProperties221);
            run228.Append(text227);

            Run run229 = new Run() { RsidRunProperties = "00CD7C94" };

            RunProperties runProperties222 = new RunProperties();
            RunFonts runFonts226 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            BoldComplexScript boldComplexScript5 = new BoldComplexScript();
            Color color5 = new Color() { Val = "000000" };

            runProperties222.Append(runFonts226);
            runProperties222.Append(boldComplexScript5);
            runProperties222.Append(color5);
            Text text228 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text228.Text = " 600 ";

            run229.Append(runProperties222);
            run229.Append(text228);

            Run run230 = new Run() { RsidRunProperties = "00CD7C94" };

            RunProperties runProperties223 = new RunProperties();
            RunFonts runFonts227 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            BoldComplexScript boldComplexScript6 = new BoldComplexScript();
            Color color6 = new Color() { Val = "000000" };
            Languages languages64 = new Languages() { Val = "en-US" };

            runProperties223.Append(runFonts227);
            runProperties223.Append(boldComplexScript6);
            runProperties223.Append(color6);
            runProperties223.Append(languages64);
            Text text229 = new Text();
            text229.Text = "KL";

            run230.Append(runProperties223);
            run230.Append(text229);

            Run run231 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "00912DE1" };

            RunProperties runProperties224 = new RunProperties();
            RunFonts runFonts228 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            BoldComplexScript boldComplexScript7 = new BoldComplexScript();
            Color color7 = new Color() { Val = "000000" };

            runProperties224.Append(runFonts228);
            runProperties224.Append(boldComplexScript7);
            runProperties224.Append(color7);
            Text text230 = new Text();
            text230.Text = ",";

            run231.Append(runProperties224);
            run231.Append(text230);

            Run run232 = new Run() { RsidRunProperties = "00CD7C94" };

            RunProperties runProperties225 = new RunProperties();
            RunFonts runFonts229 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties225.Append(runFonts229);
            Text text231 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text231.Text = " из ";

            run232.Append(runProperties225);
            run232.Append(text231);

            Run run233 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "00912DE1" };

            RunProperties runProperties226 = new RunProperties();
            RunFonts runFonts230 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties226.Append(runFonts230);
            Text text232 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text232.Text = "ламинированного ";

            run233.Append(runProperties226);
            run233.Append(text232);

            Run run234 = new Run() { RsidRunProperties = "00CD7C94" };

            RunProperties runProperties227 = new RunProperties();
            RunFonts runFonts231 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties227.Append(runFonts231);
            Text text233 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text233.Text = "ДСП. ";

            run234.Append(runProperties227);
            run234.Append(text233);

            Run run235 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "00912DE1" };

            RunProperties runProperties228 = new RunProperties();
            RunFonts runFonts232 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties228.Append(runFonts232);
            Text text234 = new Text();
            text234.Text = "О";

            run235.Append(runProperties228);
            run235.Append(text234);

            Run run236 = new Run() { RsidRunProperties = "00CD7C94" };

            RunProperties runProperties229 = new RunProperties();
            RunFonts runFonts233 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties229.Append(runFonts233);
            Text text235 = new Text();
            text235.Text = "кантовк";

            run236.Append(runProperties229);
            run236.Append(text235);

            Run run237 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "00912DE1" };

            RunProperties runProperties230 = new RunProperties();
            RunFonts runFonts234 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties230.Append(runFonts234);
            Text text236 = new Text();
            text236.Text = "а ДСП производится на сборочном участке";

            run237.Append(runProperties230);
            run237.Append(text236);

            Run run238 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "00CD7C94" };

            RunProperties runProperties231 = new RunProperties();
            RunFonts runFonts235 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties231.Append(runFonts235);
            Text text237 = new Text();
            text237.Text = ".";

            run238.Append(runProperties231);
            run238.Append(text237);

            paragraph20.Append(paragraphProperties18);
            paragraph20.Append(run212);
            paragraph20.Append(run213);
            paragraph20.Append(run214);
            paragraph20.Append(run215);
            paragraph20.Append(run216);
            paragraph20.Append(run217);
            paragraph20.Append(run218);
            paragraph20.Append(run219);
            paragraph20.Append(run220);
            paragraph20.Append(run221);
            paragraph20.Append(run222);
            paragraph20.Append(run223);
            paragraph20.Append(run224);
            paragraph20.Append(run225);
            paragraph20.Append(run226);
            paragraph20.Append(run227);
            paragraph20.Append(run228);
            paragraph20.Append(run229);
            paragraph20.Append(run230);
            paragraph20.Append(run231);
            paragraph20.Append(run232);
            paragraph20.Append(run233);
            paragraph20.Append(run234);
            paragraph20.Append(run235);
            paragraph20.Append(run236);
            paragraph20.Append(run237);
            paragraph20.Append(run238);

            Paragraph paragraph21 = new Paragraph() { RsidParagraphAddition = "006348E0", RsidParagraphProperties = "005141AE", RsidRunAdditionDefault = "006348E0" };

            ParagraphProperties paragraphProperties19 = new ParagraphProperties();
            ParagraphStyleId paragraphStyleId18 = new ParagraphStyleId() { Val = "a5" };
            Indentation indentation4 = new Indentation() { FirstLine = "567" };

            ParagraphMarkRunProperties paragraphMarkRunProperties18 = new ParagraphMarkRunProperties();
            RunFonts runFonts236 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            paragraphMarkRunProperties18.Append(runFonts236);

            paragraphProperties19.Append(paragraphStyleId18);
            paragraphProperties19.Append(indentation4);
            paragraphProperties19.Append(paragraphMarkRunProperties18);

            Run run239 = new Run();

            RunProperties runProperties232 = new RunProperties();
            RunFonts runFonts237 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties232.Append(runFonts237);
            Text text238 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text238.Text = "                            ";

            run239.Append(runProperties232);
            run239.Append(text238);

            Run run240 = new Run() { RsidRunProperties = "00CD7C94", RsidRunAddition = "00C47553" };

            RunProperties runProperties233 = new RunProperties();
            RunFonts runFonts238 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties233.Append(runFonts238);
            Text text239 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text239.Text = "                                                                               ";

            run240.Append(runProperties233);
            run240.Append(text239);

            paragraph21.Append(paragraphProperties19);
            paragraph21.Append(run239);
            paragraph21.Append(run240);

            Paragraph paragraph22 = new Paragraph() { RsidParagraphAddition = "00EC5864", RsidParagraphProperties = "006348E0", RsidRunAdditionDefault = "00C47553" };

            ParagraphProperties paragraphProperties20 = new ParagraphProperties();
            ParagraphStyleId paragraphStyleId19 = new ParagraphStyleId() { Val = "a5" };
            Indentation indentation5 = new Indentation() { FirstLine = "567" };

            ParagraphMarkRunProperties paragraphMarkRunProperties19 = new ParagraphMarkRunProperties();
            RunFonts runFonts239 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            paragraphMarkRunProperties19.Append(runFonts239);

            paragraphProperties20.Append(paragraphStyleId19);
            paragraphProperties20.Append(indentation5);
            paragraphProperties20.Append(paragraphMarkRunProperties19);

            Run run241 = new Run() { RsidRunProperties = "00DA5D9D" };

            RunProperties runProperties234 = new RunProperties();
            RunFonts runFonts240 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties234.Append(runFonts240);
            Text text240 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text240.Text = " ";

            run241.Append(runProperties234);
            run241.Append(text240);

            Run run242 = new Run() { RsidRunProperties = "00DA5D9D", RsidRunAddition = "006348E0" };

            RunProperties runProperties235 = new RunProperties();
            RunFonts runFonts241 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties235.Append(runFonts241);
            Text text241 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text241.Text = "                  ";

            run242.Append(runProperties235);
            run242.Append(text241);

            paragraph22.Append(paragraphProperties20);
            paragraph22.Append(run241);
            paragraph22.Append(run242);

            Paragraph paragraph23 = new Paragraph() { RsidParagraphAddition = "00EC5864", RsidParagraphProperties = "00EC5864", RsidRunAdditionDefault = "00EC5864" };

            ParagraphProperties paragraphProperties21 = new ParagraphProperties();
            ParagraphStyleId paragraphStyleId20 = new ParagraphStyleId() { Val = "a5" };

            ParagraphMarkRunProperties paragraphMarkRunProperties20 = new ParagraphMarkRunProperties();
            RunFonts runFonts242 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            paragraphMarkRunProperties20.Append(runFonts242);

            paragraphProperties21.Append(paragraphStyleId20);
            paragraphProperties21.Append(paragraphMarkRunProperties20);

            paragraph23.Append(paragraphProperties21);

            Paragraph paragraph24 = new Paragraph() { RsidParagraphMarkRevision = "006D2355", RsidParagraphAddition = "007559CE", RsidParagraphProperties = "006348E0", RsidRunAdditionDefault = "00EC5864" };

            ParagraphProperties paragraphProperties22 = new ParagraphProperties();
            ParagraphStyleId paragraphStyleId21 = new ParagraphStyleId() { Val = "a5" };
            Indentation indentation6 = new Indentation() { FirstLine = "567" };

            ParagraphMarkRunProperties paragraphMarkRunProperties21 = new ParagraphMarkRunProperties();
            RunFonts runFonts243 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            paragraphMarkRunProperties21.Append(runFonts243);

            paragraphProperties22.Append(paragraphStyleId21);
            paragraphProperties22.Append(indentation6);
            paragraphProperties22.Append(paragraphMarkRunProperties21);

            Run run243 = new Run();

            RunProperties runProperties236 = new RunProperties();
            RunFonts runFonts244 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties236.Append(runFonts244);
            Text text242 = new Text();
            text242.Text = "Менеджер ВЭД";

            run243.Append(runProperties236);
            run243.Append(text242);

            Run run244 = new Run() { RsidRunProperties = "00DA5D9D", RsidRunAddition = "006348E0" };

            RunProperties runProperties237 = new RunProperties();
            RunFonts runFonts245 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties237.Append(runFonts245);
            Text text243 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text243.Text = " ";

            run244.Append(runProperties237);
            run244.Append(text243);

            Run run245 = new Run();

            RunProperties runProperties238 = new RunProperties();
            RunFonts runFonts246 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties238.Append(runFonts246);
            TabChar tabChar1 = new TabChar();

            run245.Append(runProperties238);
            run245.Append(tabChar1);

            Run run246 = new Run();

            RunProperties runProperties239 = new RunProperties();
            RunFonts runFonts247 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties239.Append(runFonts247);
            TabChar tabChar2 = new TabChar();

            run246.Append(runProperties239);
            run246.Append(tabChar2);

            Run run247 = new Run();

            RunProperties runProperties240 = new RunProperties();
            RunFonts runFonts248 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties240.Append(runFonts248);
            TabChar tabChar3 = new TabChar();

            run247.Append(runProperties240);
            run247.Append(tabChar3);

            Run run248 = new Run();

            RunProperties runProperties241 = new RunProperties();
            RunFonts runFonts249 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties241.Append(runFonts249);
            TabChar tabChar4 = new TabChar();

            run248.Append(runProperties241);
            run248.Append(tabChar4);

            Run run249 = new Run();

            RunProperties runProperties242 = new RunProperties();
            RunFonts runFonts250 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties242.Append(runFonts250);
            TabChar tabChar5 = new TabChar();

            run249.Append(runProperties242);
            run249.Append(tabChar5);

            Run run250 = new Run();

            RunProperties runProperties243 = new RunProperties();
            RunFonts runFonts251 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties243.Append(runFonts251);
            TabChar tabChar6 = new TabChar();

            run250.Append(runProperties243);
            run250.Append(tabChar6);

            Run run251 = new Run() { RsidRunProperties = "00DA5D9D", RsidRunAddition = "006348E0" };

            RunProperties runProperties244 = new RunProperties();
            RunFonts runFonts252 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };

            runProperties244.Append(runFonts252);
            Text text244 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text244.Text = "                                   ";

            run251.Append(runProperties244);
            run251.Append(text244);
            ProofError proofError27 = new ProofError() { Type = ProofingErrorValues.SpellStart };

            Run run252 = new Run() { RsidRunAddition = "00E37BE8" };

            RunProperties runProperties245 = new RunProperties();
            RunFonts runFonts253 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Languages languages65 = new Languages() { Val = "en-US" };

            runProperties245.Append(runFonts253);
            runProperties245.Append(languages65);
            Text text245 = new Text();
            text245.Text = frm.authPerson.Text;

            run252.Append(runProperties245);
            run252.Append(text245);
            ProofError proofError28 = new ProofError() { Type = ProofingErrorValues.SpellEnd };

            paragraph24.Append(paragraphProperties22);
            paragraph24.Append(run243);
            paragraph24.Append(run244);
            paragraph24.Append(run245);
            paragraph24.Append(run246);
            paragraph24.Append(run247);
            paragraph24.Append(run248);
            paragraph24.Append(run249);
            paragraph24.Append(run250);
            paragraph24.Append(run251);
            paragraph24.Append(proofError27);
            paragraph24.Append(run252);
            paragraph24.Append(proofError28);

            SectionProperties sectionProperties1 = new SectionProperties() { RsidRPr = "006D2355", RsidR = "007559CE", RsidSect = "007D2EE0" };
            PageSize pageSize1 = new PageSize() { Width = (UInt32Value)11906U, Height = (UInt32Value)16838U };
            PageMargin pageMargin1 = new PageMargin() { Top = 709, Right = (UInt32Value)850U, Bottom = 709, Left = (UInt32Value)1701U, Header = (UInt32Value)708U, Footer = (UInt32Value)708U, Gutter = (UInt32Value)0U };
            Columns columns1 = new Columns() { Space = "708" };
            DocGrid docGrid1 = new DocGrid() { LinePitch = 360 };

            sectionProperties1.Append(pageSize1);
            sectionProperties1.Append(pageMargin1);
            sectionProperties1.Append(columns1);
            sectionProperties1.Append(docGrid1);

            body1.Append(paragraph1);
            body1.Append(paragraph2);
            body1.Append(paragraph3);
            body1.Append(paragraph4);
            body1.Append(paragraph5);
            body1.Append(paragraph6);
            body1.Append(paragraph7);
            body1.Append(paragraph8);
            body1.Append(paragraph9);
            body1.Append(paragraph10);
            body1.Append(paragraph11);
            body1.Append(paragraph12);
            body1.Append(paragraph13);
            body1.Append(paragraph14);
            body1.Append(paragraph15);
            body1.Append(paragraph16);
            body1.Append(paragraph17);
            body1.Append(paragraph18);
            body1.Append(paragraph19);
            body1.Append(paragraph20);
            body1.Append(paragraph21);
            body1.Append(paragraph22);
            body1.Append(paragraph23);
            body1.Append(paragraph24);
            body1.Append(sectionProperties1);

            document1.Append(body1);

            mainDocumentPart1.Document = document1;
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
            ProofState proofState1 = new ProofState() { Spelling = ProofingStateValues.Clean, Grammar = ProofingStateValues.Clean };
            DefaultTabStop defaultTabStop1 = new DefaultTabStop() { Val = 708 };
            HyphenationZone hyphenationZone1 = new HyphenationZone() { Val = "425" };
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
            RsidRoot rsidRoot1 = new RsidRoot() { Val = "00EC0405" };
            Rsid rsid1 = new Rsid() { Val = "000014CB" };
            Rsid rsid2 = new Rsid() { Val = "000041C6" };
            Rsid rsid3 = new Rsid() { Val = "000057B3" };
            Rsid rsid4 = new Rsid() { Val = "000077F6" };
            Rsid rsid5 = new Rsid() { Val = "00023552" };
            Rsid rsid6 = new Rsid() { Val = "00023A35" };
            Rsid rsid7 = new Rsid() { Val = "00042325" };
            Rsid rsid8 = new Rsid() { Val = "0004513C" };
            Rsid rsid9 = new Rsid() { Val = "00061D5A" };
            Rsid rsid10 = new Rsid() { Val = "00063C28" };
            Rsid rsid11 = new Rsid() { Val = "000661A3" };
            Rsid rsid12 = new Rsid() { Val = "0006732C" };
            Rsid rsid13 = new Rsid() { Val = "0006777B" };
            Rsid rsid14 = new Rsid() { Val = "0008462A" };
            Rsid rsid15 = new Rsid() { Val = "0008641C" };
            Rsid rsid16 = new Rsid() { Val = "00096A98" };
            Rsid rsid17 = new Rsid() { Val = "000A2450" };
            Rsid rsid18 = new Rsid() { Val = "000A4FF3" };
            Rsid rsid19 = new Rsid() { Val = "000A57E8" };
            Rsid rsid20 = new Rsid() { Val = "000B4766" };
            Rsid rsid21 = new Rsid() { Val = "000B6731" };
            Rsid rsid22 = new Rsid() { Val = "000C6931" };
            Rsid rsid23 = new Rsid() { Val = "000D2237" };
            Rsid rsid24 = new Rsid() { Val = "000D241D" };
            Rsid rsid25 = new Rsid() { Val = "000D39FA" };
            Rsid rsid26 = new Rsid() { Val = "000D7EE1" };
            Rsid rsid27 = new Rsid() { Val = "000E2A1A" };
            Rsid rsid28 = new Rsid() { Val = "000E40C2" };
            Rsid rsid29 = new Rsid() { Val = "000E54E9" };
            Rsid rsid30 = new Rsid() { Val = "000F578C" };
            Rsid rsid31 = new Rsid() { Val = "00101CA2" };
            Rsid rsid32 = new Rsid() { Val = "001072FB" };
            Rsid rsid33 = new Rsid() { Val = "00115F46" };
            Rsid rsid34 = new Rsid() { Val = "0011615C" };
            Rsid rsid35 = new Rsid() { Val = "001178F7" };
            Rsid rsid36 = new Rsid() { Val = "00125C68" };
            Rsid rsid37 = new Rsid() { Val = "0012774E" };
            Rsid rsid38 = new Rsid() { Val = "001411AE" };
            Rsid rsid39 = new Rsid() { Val = "00141321" };
            Rsid rsid40 = new Rsid() { Val = "00147B9C" };
            Rsid rsid41 = new Rsid() { Val = "0015015B" };
            Rsid rsid42 = new Rsid() { Val = "00150803" };
            Rsid rsid43 = new Rsid() { Val = "00151A3E" };
            Rsid rsid44 = new Rsid() { Val = "00151AF2" };
            Rsid rsid45 = new Rsid() { Val = "00157C35" };
            Rsid rsid46 = new Rsid() { Val = "0016379A" };
            Rsid rsid47 = new Rsid() { Val = "0016556F" };
            Rsid rsid48 = new Rsid() { Val = "00166610" };
            Rsid rsid49 = new Rsid() { Val = "001676AB" };
            Rsid rsid50 = new Rsid() { Val = "00173EEC" };
            Rsid rsid51 = new Rsid() { Val = "00174BEF" };
            Rsid rsid52 = new Rsid() { Val = "00176BA0" };
            Rsid rsid53 = new Rsid() { Val = "00181E91" };
            Rsid rsid54 = new Rsid() { Val = "00190DB1" };
            Rsid rsid55 = new Rsid() { Val = "00194133" };
            Rsid rsid56 = new Rsid() { Val = "00195521" };
            Rsid rsid57 = new Rsid() { Val = "0019723E" };
            Rsid rsid58 = new Rsid() { Val = "001A49BC" };
            Rsid rsid59 = new Rsid() { Val = "001B1428" };
            Rsid rsid60 = new Rsid() { Val = "001B47D8" };
            Rsid rsid61 = new Rsid() { Val = "001C166E" };
            Rsid rsid62 = new Rsid() { Val = "001C4D15" };
            Rsid rsid63 = new Rsid() { Val = "001C64DC" };
            Rsid rsid64 = new Rsid() { Val = "001D0D2C" };
            Rsid rsid65 = new Rsid() { Val = "001D7E71" };
            Rsid rsid66 = new Rsid() { Val = "001E405A" };
            Rsid rsid67 = new Rsid() { Val = "001F102B" };
            Rsid rsid68 = new Rsid() { Val = "00210CF3" };
            Rsid rsid69 = new Rsid() { Val = "00212FB2" };
            Rsid rsid70 = new Rsid() { Val = "002134C2" };
            Rsid rsid71 = new Rsid() { Val = "0022042F" };
            Rsid rsid72 = new Rsid() { Val = "002238D4" };
            Rsid rsid73 = new Rsid() { Val = "00232AF7" };
            Rsid rsid74 = new Rsid() { Val = "002341EE" };
            Rsid rsid75 = new Rsid() { Val = "00245293" };
            Rsid rsid76 = new Rsid() { Val = "00245BAA" };
            Rsid rsid77 = new Rsid() { Val = "002504C3" };
            Rsid rsid78 = new Rsid() { Val = "002504FD" };
            Rsid rsid79 = new Rsid() { Val = "00250615" };
            Rsid rsid80 = new Rsid() { Val = "002512BC" };
            Rsid rsid81 = new Rsid() { Val = "00253F90" };
            Rsid rsid82 = new Rsid() { Val = "002568D5" };
            Rsid rsid83 = new Rsid() { Val = "00256BCC" };
            Rsid rsid84 = new Rsid() { Val = "0025751E" };
            Rsid rsid85 = new Rsid() { Val = "0027585A" };
            Rsid rsid86 = new Rsid() { Val = "00285B03" };
            Rsid rsid87 = new Rsid() { Val = "00295453" };
            Rsid rsid88 = new Rsid() { Val = "002A63AB" };
            Rsid rsid89 = new Rsid() { Val = "002B0461" };
            Rsid rsid90 = new Rsid() { Val = "002B09B3" };
            Rsid rsid91 = new Rsid() { Val = "002B3B11" };
            Rsid rsid92 = new Rsid() { Val = "002B6B7A" };
            Rsid rsid93 = new Rsid() { Val = "002C4588" };
            Rsid rsid94 = new Rsid() { Val = "002C5181" };
            Rsid rsid95 = new Rsid() { Val = "002C5DE9" };
            Rsid rsid96 = new Rsid() { Val = "002C5F83" };
            Rsid rsid97 = new Rsid() { Val = "002D19ED" };
            Rsid rsid98 = new Rsid() { Val = "002D685E" };
            Rsid rsid99 = new Rsid() { Val = "002E164D" };
            Rsid rsid100 = new Rsid() { Val = "002E24F9" };
            Rsid rsid101 = new Rsid() { Val = "002E2E51" };
            Rsid rsid102 = new Rsid() { Val = "002E34A7" };
            Rsid rsid103 = new Rsid() { Val = "002E46E3" };
            Rsid rsid104 = new Rsid() { Val = "002E727F" };
            Rsid rsid105 = new Rsid() { Val = "002F1A6C" };
            Rsid rsid106 = new Rsid() { Val = "002F3F66" };
            Rsid rsid107 = new Rsid() { Val = "002F73EE" };
            Rsid rsid108 = new Rsid() { Val = "0031065D" };
            Rsid rsid109 = new Rsid() { Val = "003158FF" };
            Rsid rsid110 = new Rsid() { Val = "003215E5" };
            Rsid rsid111 = new Rsid() { Val = "00323FE9" };
            Rsid rsid112 = new Rsid() { Val = "003360AF" };
            Rsid rsid113 = new Rsid() { Val = "00342D77" };
            Rsid rsid114 = new Rsid() { Val = "00347A2D" };
            Rsid rsid115 = new Rsid() { Val = "00347B7D" };
            Rsid rsid116 = new Rsid() { Val = "0035212E" };
            Rsid rsid117 = new Rsid() { Val = "003578E1" };
            Rsid rsid118 = new Rsid() { Val = "003658BC" };
            Rsid rsid119 = new Rsid() { Val = "00367303" };
            Rsid rsid120 = new Rsid() { Val = "003713F9" };
            Rsid rsid121 = new Rsid() { Val = "003758A3" };
            Rsid rsid122 = new Rsid() { Val = "00376CE0" };
            Rsid rsid123 = new Rsid() { Val = "0038021E" };
            Rsid rsid124 = new Rsid() { Val = "003835D0" };
            Rsid rsid125 = new Rsid() { Val = "003A029E" };
            Rsid rsid126 = new Rsid() { Val = "003A0836" };
            Rsid rsid127 = new Rsid() { Val = "003A1652" };
            Rsid rsid128 = new Rsid() { Val = "003A4051" };
            Rsid rsid129 = new Rsid() { Val = "003B0A4A" };
            Rsid rsid130 = new Rsid() { Val = "003B163E" };
            Rsid rsid131 = new Rsid() { Val = "003B437B" };
            Rsid rsid132 = new Rsid() { Val = "003B5B0D" };
            Rsid rsid133 = new Rsid() { Val = "003B7D73" };
            Rsid rsid134 = new Rsid() { Val = "003C1C49" };
            Rsid rsid135 = new Rsid() { Val = "003C40AD" };
            Rsid rsid136 = new Rsid() { Val = "003C49A2" };
            Rsid rsid137 = new Rsid() { Val = "003D3E10" };
            Rsid rsid138 = new Rsid() { Val = "003D4AAA" };
            Rsid rsid139 = new Rsid() { Val = "003D5F55" };
            Rsid rsid140 = new Rsid() { Val = "003E22B5" };
            Rsid rsid141 = new Rsid() { Val = "003E7413" };
            Rsid rsid142 = new Rsid() { Val = "003E7C65" };
            Rsid rsid143 = new Rsid() { Val = "003F3DDF" };
            Rsid rsid144 = new Rsid() { Val = "003F4F66" };
            Rsid rsid145 = new Rsid() { Val = "003F7184" };
            Rsid rsid146 = new Rsid() { Val = "00400B07" };
            Rsid rsid147 = new Rsid() { Val = "00403626" };
            Rsid rsid148 = new Rsid() { Val = "00403E01" };
            Rsid rsid149 = new Rsid() { Val = "00412C38" };
            Rsid rsid150 = new Rsid() { Val = "00417103" };
            Rsid rsid151 = new Rsid() { Val = "0042197C" };
            Rsid rsid152 = new Rsid() { Val = "004334B4" };
            Rsid rsid153 = new Rsid() { Val = "00447D6C" };
            Rsid rsid154 = new Rsid() { Val = "004515C7" };
            Rsid rsid155 = new Rsid() { Val = "004538E5" };
            Rsid rsid156 = new Rsid() { Val = "00470825" };
            Rsid rsid157 = new Rsid() { Val = "0047146C" };
            Rsid rsid158 = new Rsid() { Val = "004731D3" };
            Rsid rsid159 = new Rsid() { Val = "0047477F" };
            Rsid rsid160 = new Rsid() { Val = "004750B0" };
            Rsid rsid161 = new Rsid() { Val = "00481B10" };
            Rsid rsid162 = new Rsid() { Val = "00487FCC" };
            Rsid rsid163 = new Rsid() { Val = "004926AC" };
            Rsid rsid164 = new Rsid() { Val = "00494188" };
            Rsid rsid165 = new Rsid() { Val = "00496449" };
            Rsid rsid166 = new Rsid() { Val = "004A064D" };
            Rsid rsid167 = new Rsid() { Val = "004A1468" };
            Rsid rsid168 = new Rsid() { Val = "004A740B" };
            Rsid rsid169 = new Rsid() { Val = "004A7876" };
            Rsid rsid170 = new Rsid() { Val = "004B74D9" };
            Rsid rsid171 = new Rsid() { Val = "004C3C0A" };
            Rsid rsid172 = new Rsid() { Val = "004C42DA" };
            Rsid rsid173 = new Rsid() { Val = "004C46F6" };
            Rsid rsid174 = new Rsid() { Val = "004C6425" };
            Rsid rsid175 = new Rsid() { Val = "004C6FBB" };
            Rsid rsid176 = new Rsid() { Val = "004C7A3B" };
            Rsid rsid177 = new Rsid() { Val = "004D6076" };
            Rsid rsid178 = new Rsid() { Val = "004D6CB6" };
            Rsid rsid179 = new Rsid() { Val = "004E3C9D" };
            Rsid rsid180 = new Rsid() { Val = "004F15F3" };
            Rsid rsid181 = new Rsid() { Val = "004F7CB3" };
            Rsid rsid182 = new Rsid() { Val = "00507836" };
            Rsid rsid183 = new Rsid() { Val = "00512EF7" };
            Rsid rsid184 = new Rsid() { Val = "005141AE" };
            Rsid rsid185 = new Rsid() { Val = "00514BFD" };
            Rsid rsid186 = new Rsid() { Val = "00517D1A" };
            Rsid rsid187 = new Rsid() { Val = "005200A2" };
            Rsid rsid188 = new Rsid() { Val = "00521B74" };
            Rsid rsid189 = new Rsid() { Val = "00526C3A" };
            Rsid rsid190 = new Rsid() { Val = "00544D89" };
            Rsid rsid191 = new Rsid() { Val = "005512E2" };
            Rsid rsid192 = new Rsid() { Val = "005523F5" };
            Rsid rsid193 = new Rsid() { Val = "00557EB9" };
            Rsid rsid194 = new Rsid() { Val = "005604B4" };
            Rsid rsid195 = new Rsid() { Val = "00560F5B" };
            Rsid rsid196 = new Rsid() { Val = "00572D70" };
            Rsid rsid197 = new Rsid() { Val = "00573061" };
            Rsid rsid198 = new Rsid() { Val = "00574CCD" };
            Rsid rsid199 = new Rsid() { Val = "00575639" };
            Rsid rsid200 = new Rsid() { Val = "00583A75" };
            Rsid rsid201 = new Rsid() { Val = "00585F73" };
            Rsid rsid202 = new Rsid() { Val = "005A339D" };
            Rsid rsid203 = new Rsid() { Val = "005A4E01" };
            Rsid rsid204 = new Rsid() { Val = "005B207A" };
            Rsid rsid205 = new Rsid() { Val = "005B393B" };
            Rsid rsid206 = new Rsid() { Val = "005B437A" };
            Rsid rsid207 = new Rsid() { Val = "005B513C" };
            Rsid rsid208 = new Rsid() { Val = "005C20E0" };
            Rsid rsid209 = new Rsid() { Val = "005D34BD" };
            Rsid rsid210 = new Rsid() { Val = "005D3967" };
            Rsid rsid211 = new Rsid() { Val = "005D5C94" };
            Rsid rsid212 = new Rsid() { Val = "005D79AC" };
            Rsid rsid213 = new Rsid() { Val = "005E73DB" };
            Rsid rsid214 = new Rsid() { Val = "005F3BD8" };
            Rsid rsid215 = new Rsid() { Val = "005F68A3" };
            Rsid rsid216 = new Rsid() { Val = "00606D50" };
            Rsid rsid217 = new Rsid() { Val = "0061399A" };
            Rsid rsid218 = new Rsid() { Val = "00621A70" };
            Rsid rsid219 = new Rsid() { Val = "0062404C" };
            Rsid rsid220 = new Rsid() { Val = "00625F0E" };
            Rsid rsid221 = new Rsid() { Val = "006348E0" };
            Rsid rsid222 = new Rsid() { Val = "00635003" };
            Rsid rsid223 = new Rsid() { Val = "00635695" };
            Rsid rsid224 = new Rsid() { Val = "00635BA1" };
            Rsid rsid225 = new Rsid() { Val = "00635EDD" };
            Rsid rsid226 = new Rsid() { Val = "00643E46" };
            Rsid rsid227 = new Rsid() { Val = "006536DB" };
            Rsid rsid228 = new Rsid() { Val = "006544E1" };
            Rsid rsid229 = new Rsid() { Val = "00655854" };
            Rsid rsid230 = new Rsid() { Val = "00657C27" };
            Rsid rsid231 = new Rsid() { Val = "00663E35" };
            Rsid rsid232 = new Rsid() { Val = "00684C3A" };
            Rsid rsid233 = new Rsid() { Val = "00686ED6" };
            Rsid rsid234 = new Rsid() { Val = "0068723D" };
            Rsid rsid235 = new Rsid() { Val = "00693B33" };
            Rsid rsid236 = new Rsid() { Val = "00694076" };
            Rsid rsid237 = new Rsid() { Val = "00694F27" };
            Rsid rsid238 = new Rsid() { Val = "006A1CC8" };
            Rsid rsid239 = new Rsid() { Val = "006A2123" };
            Rsid rsid240 = new Rsid() { Val = "006A4990" };
            Rsid rsid241 = new Rsid() { Val = "006B2FE8" };
            Rsid rsid242 = new Rsid() { Val = "006C5B07" };
            Rsid rsid243 = new Rsid() { Val = "006D1858" };
            Rsid rsid244 = new Rsid() { Val = "006D1E6B" };
            Rsid rsid245 = new Rsid() { Val = "006D2355" };
            Rsid rsid246 = new Rsid() { Val = "006D33DF" };
            Rsid rsid247 = new Rsid() { Val = "006D530B" };
            Rsid rsid248 = new Rsid() { Val = "006D762B" };
            Rsid rsid249 = new Rsid() { Val = "006D7D90" };
            Rsid rsid250 = new Rsid() { Val = "006E5F20" };
            Rsid rsid251 = new Rsid() { Val = "006F4897" };
            Rsid rsid252 = new Rsid() { Val = "006F5190" };
            Rsid rsid253 = new Rsid() { Val = "00701D09" };
            Rsid rsid254 = new Rsid() { Val = "007060A7" };
            Rsid rsid255 = new Rsid() { Val = "007161CA" };
            Rsid rsid256 = new Rsid() { Val = "0071730D" };
            Rsid rsid257 = new Rsid() { Val = "00721367" };
            Rsid rsid258 = new Rsid() { Val = "00723BBE" };
            Rsid rsid259 = new Rsid() { Val = "00724881" };
            Rsid rsid260 = new Rsid() { Val = "00725AD9" };
            Rsid rsid261 = new Rsid() { Val = "00730EFF" };
            Rsid rsid262 = new Rsid() { Val = "0073158E" };
            Rsid rsid263 = new Rsid() { Val = "007353F0" };
            Rsid rsid264 = new Rsid() { Val = "0074507D" };
            Rsid rsid265 = new Rsid() { Val = "00750B27" };
            Rsid rsid266 = new Rsid() { Val = "00751C74" };
            Rsid rsid267 = new Rsid() { Val = "00752062" };
            Rsid rsid268 = new Rsid() { Val = "00752D82" };
            Rsid rsid269 = new Rsid() { Val = "00753423" };
            Rsid rsid270 = new Rsid() { Val = "007559CE" };
            Rsid rsid271 = new Rsid() { Val = "007650D3" };
            Rsid rsid272 = new Rsid() { Val = "007820B1" };
            Rsid rsid273 = new Rsid() { Val = "007857DD" };
            Rsid rsid274 = new Rsid() { Val = "007915EA" };
            Rsid rsid275 = new Rsid() { Val = "007A7C31" };
            Rsid rsid276 = new Rsid() { Val = "007B3322" };
            Rsid rsid277 = new Rsid() { Val = "007B3B43" };
            Rsid rsid278 = new Rsid() { Val = "007B4D41" };
            Rsid rsid279 = new Rsid() { Val = "007B6DD2" };
            Rsid rsid280 = new Rsid() { Val = "007D2EE0" };
            Rsid rsid281 = new Rsid() { Val = "007D6BBF" };
            Rsid rsid282 = new Rsid() { Val = "007E403A" };
            Rsid rsid283 = new Rsid() { Val = "007E588E" };
            Rsid rsid284 = new Rsid() { Val = "007F3092" };
            Rsid rsid285 = new Rsid() { Val = "007F50A7" };
            Rsid rsid286 = new Rsid() { Val = "007F6772" };
            Rsid rsid287 = new Rsid() { Val = "0080260B" };
            Rsid rsid288 = new Rsid() { Val = "00804FCC" };
            Rsid rsid289 = new Rsid() { Val = "00814A58" };
            Rsid rsid290 = new Rsid() { Val = "00816362" };
            Rsid rsid291 = new Rsid() { Val = "00816EC5" };
            Rsid rsid292 = new Rsid() { Val = "00820704" };
            Rsid rsid293 = new Rsid() { Val = "008251DB" };
            Rsid rsid294 = new Rsid() { Val = "00830BA7" };
            Rsid rsid295 = new Rsid() { Val = "00834296" };
            Rsid rsid296 = new Rsid() { Val = "00836DC9" };
            Rsid rsid297 = new Rsid() { Val = "00840105" };
            Rsid rsid298 = new Rsid() { Val = "00844CC9" };
            Rsid rsid299 = new Rsid() { Val = "00852B42" };
            Rsid rsid300 = new Rsid() { Val = "0086033A" };
            Rsid rsid301 = new Rsid() { Val = "00867D76" };
            Rsid rsid302 = new Rsid() { Val = "00883326" };
            Rsid rsid303 = new Rsid() { Val = "008840E7" };
            Rsid rsid304 = new Rsid() { Val = "008869F8" };
            Rsid rsid305 = new Rsid() { Val = "00890F88" };
            Rsid rsid306 = new Rsid() { Val = "0089358B" };
            Rsid rsid307 = new Rsid() { Val = "00897EE9" };
            Rsid rsid308 = new Rsid() { Val = "008A3837" };
            Rsid rsid309 = new Rsid() { Val = "008B0090" };
            Rsid rsid310 = new Rsid() { Val = "008B0D3C" };
            Rsid rsid311 = new Rsid() { Val = "008B28F1" };
            Rsid rsid312 = new Rsid() { Val = "008B7951" };
            Rsid rsid313 = new Rsid() { Val = "008C3DC3" };
            Rsid rsid314 = new Rsid() { Val = "008C5888" };
            Rsid rsid315 = new Rsid() { Val = "008D218C" };
            Rsid rsid316 = new Rsid() { Val = "008D4718" };
            Rsid rsid317 = new Rsid() { Val = "008D7C37" };
            Rsid rsid318 = new Rsid() { Val = "008E4EAF" };
            Rsid rsid319 = new Rsid() { Val = "008F0261" };
            Rsid rsid320 = new Rsid() { Val = "00912DE1" };
            Rsid rsid321 = new Rsid() { Val = "00921D7F" };
            Rsid rsid322 = new Rsid() { Val = "00924836" };
            Rsid rsid323 = new Rsid() { Val = "009249B2" };
            Rsid rsid324 = new Rsid() { Val = "00926011" };
            Rsid rsid325 = new Rsid() { Val = "009275FE" };
            Rsid rsid326 = new Rsid() { Val = "00932A9F" };
            Rsid rsid327 = new Rsid() { Val = "00935D0F" };
            Rsid rsid328 = new Rsid() { Val = "0094012D" };
            Rsid rsid329 = new Rsid() { Val = "00943533" };
            Rsid rsid330 = new Rsid() { Val = "00943F8C" };
            Rsid rsid331 = new Rsid() { Val = "00946352" };
            Rsid rsid332 = new Rsid() { Val = "00950D5C" };
            Rsid rsid333 = new Rsid() { Val = "0095296F" };
            Rsid rsid334 = new Rsid() { Val = "00953EDC" };
            Rsid rsid335 = new Rsid() { Val = "009543E9" };
            Rsid rsid336 = new Rsid() { Val = "00957631" };
            Rsid rsid337 = new Rsid() { Val = "00962A47" };
            Rsid rsid338 = new Rsid() { Val = "00971E6B" };
            Rsid rsid339 = new Rsid() { Val = "0097528B" };
            Rsid rsid340 = new Rsid() { Val = "00983E59" };
            Rsid rsid341 = new Rsid() { Val = "009935FF" };
            Rsid rsid342 = new Rsid() { Val = "0099734D" };
            Rsid rsid343 = new Rsid() { Val = "009A10B5" };
            Rsid rsid344 = new Rsid() { Val = "009A1880" };
            Rsid rsid345 = new Rsid() { Val = "009A5CFC" };
            Rsid rsid346 = new Rsid() { Val = "009A6812" };
            Rsid rsid347 = new Rsid() { Val = "009A71B8" };
            Rsid rsid348 = new Rsid() { Val = "009A780A" };
            Rsid rsid349 = new Rsid() { Val = "009B23E2" };
            Rsid rsid350 = new Rsid() { Val = "009B67B9" };
            Rsid rsid351 = new Rsid() { Val = "009B6A1E" };
            Rsid rsid352 = new Rsid() { Val = "009C5B3F" };
            Rsid rsid353 = new Rsid() { Val = "009C667C" };
            Rsid rsid354 = new Rsid() { Val = "009E068D" };
            Rsid rsid355 = new Rsid() { Val = "009E2982" };
            Rsid rsid356 = new Rsid() { Val = "009F0B64" };
            Rsid rsid357 = new Rsid() { Val = "009F4BE3" };
            Rsid rsid358 = new Rsid() { Val = "009F528A" };
            Rsid rsid359 = new Rsid() { Val = "00A005B5" };
            Rsid rsid360 = new Rsid() { Val = "00A067CA" };
            Rsid rsid361 = new Rsid() { Val = "00A069CA" };
            Rsid rsid362 = new Rsid() { Val = "00A075ED" };
            Rsid rsid363 = new Rsid() { Val = "00A10F08" };
            Rsid rsid364 = new Rsid() { Val = "00A12349" };
            Rsid rsid365 = new Rsid() { Val = "00A261FF" };
            Rsid rsid366 = new Rsid() { Val = "00A27412" };
            Rsid rsid367 = new Rsid() { Val = "00A30CE6" };
            Rsid rsid368 = new Rsid() { Val = "00A336FB" };
            Rsid rsid369 = new Rsid() { Val = "00A373B1" };
            Rsid rsid370 = new Rsid() { Val = "00A4235F" };
            Rsid rsid371 = new Rsid() { Val = "00A4308F" };
            Rsid rsid372 = new Rsid() { Val = "00A50209" };
            Rsid rsid373 = new Rsid() { Val = "00A52956" };
            Rsid rsid374 = new Rsid() { Val = "00A5737C" };
            Rsid rsid375 = new Rsid() { Val = "00A64C8A" };
            Rsid rsid376 = new Rsid() { Val = "00A8186D" };
            Rsid rsid377 = new Rsid() { Val = "00A81E95" };
            Rsid rsid378 = new Rsid() { Val = "00A83DEC" };
            Rsid rsid379 = new Rsid() { Val = "00A91B69" };
            Rsid rsid380 = new Rsid() { Val = "00A91DB9" };
            Rsid rsid381 = new Rsid() { Val = "00A96364" };
            Rsid rsid382 = new Rsid() { Val = "00A97C87" };
            Rsid rsid383 = new Rsid() { Val = "00AA00B8" };
            Rsid rsid384 = new Rsid() { Val = "00AA2057" };
            Rsid rsid385 = new Rsid() { Val = "00AC6850" };
            Rsid rsid386 = new Rsid() { Val = "00AC68A1" };
            Rsid rsid387 = new Rsid() { Val = "00AD1AF7" };
            Rsid rsid388 = new Rsid() { Val = "00AD49FB" };
            Rsid rsid389 = new Rsid() { Val = "00AE02AC" };
            Rsid rsid390 = new Rsid() { Val = "00AE48C5" };
            Rsid rsid391 = new Rsid() { Val = "00AE5875" };
            Rsid rsid392 = new Rsid() { Val = "00AE7375" };
            Rsid rsid393 = new Rsid() { Val = "00AF530A" };
            Rsid rsid394 = new Rsid() { Val = "00AF63A9" };
            Rsid rsid395 = new Rsid() { Val = "00B03991" };
            Rsid rsid396 = new Rsid() { Val = "00B11204" };
            Rsid rsid397 = new Rsid() { Val = "00B120FE" };
            Rsid rsid398 = new Rsid() { Val = "00B2167F" };
            Rsid rsid399 = new Rsid() { Val = "00B327E7" };
            Rsid rsid400 = new Rsid() { Val = "00B36B0B" };
            Rsid rsid401 = new Rsid() { Val = "00B4541D" };
            Rsid rsid402 = new Rsid() { Val = "00B52224" };
            Rsid rsid403 = new Rsid() { Val = "00B578A0" };
            Rsid rsid404 = new Rsid() { Val = "00B7561F" };
            Rsid rsid405 = new Rsid() { Val = "00B85C2F" };
            Rsid rsid406 = new Rsid() { Val = "00B87C38" };
            Rsid rsid407 = new Rsid() { Val = "00B87F4B" };
            Rsid rsid408 = new Rsid() { Val = "00B93FD5" };
            Rsid rsid409 = new Rsid() { Val = "00BA1D81" };
            Rsid rsid410 = new Rsid() { Val = "00BA33AA" };
            Rsid rsid411 = new Rsid() { Val = "00BB3BE3" };
            Rsid rsid412 = new Rsid() { Val = "00BB65FF" };
            Rsid rsid413 = new Rsid() { Val = "00BC69A3" };
            Rsid rsid414 = new Rsid() { Val = "00BD30CE" };
            Rsid rsid415 = new Rsid() { Val = "00BD406A" };
            Rsid rsid416 = new Rsid() { Val = "00BE1890" };
            Rsid rsid417 = new Rsid() { Val = "00BF15F3" };
            Rsid rsid418 = new Rsid() { Val = "00BF4209" };
            Rsid rsid419 = new Rsid() { Val = "00C003CC" };
            Rsid rsid420 = new Rsid() { Val = "00C10CA4" };
            Rsid rsid421 = new Rsid() { Val = "00C160A7" };
            Rsid rsid422 = new Rsid() { Val = "00C26920" };
            Rsid rsid423 = new Rsid() { Val = "00C324F5" };
            Rsid rsid424 = new Rsid() { Val = "00C35AEA" };
            Rsid rsid425 = new Rsid() { Val = "00C35FEF" };
            Rsid rsid426 = new Rsid() { Val = "00C41310" };
            Rsid rsid427 = new Rsid() { Val = "00C4211E" };
            Rsid rsid428 = new Rsid() { Val = "00C42493" };
            Rsid rsid429 = new Rsid() { Val = "00C426B6" };
            Rsid rsid430 = new Rsid() { Val = "00C42C64" };
            Rsid rsid431 = new Rsid() { Val = "00C44797" };
            Rsid rsid432 = new Rsid() { Val = "00C45339" };
            Rsid rsid433 = new Rsid() { Val = "00C47553" };
            Rsid rsid434 = new Rsid() { Val = "00C521B4" };
            Rsid rsid435 = new Rsid() { Val = "00C5367A" };
            Rsid rsid436 = new Rsid() { Val = "00C54C9F" };
            Rsid rsid437 = new Rsid() { Val = "00C55142" };
            Rsid rsid438 = new Rsid() { Val = "00C57AFC" };
            Rsid rsid439 = new Rsid() { Val = "00C60DE9" };
            Rsid rsid440 = new Rsid() { Val = "00C6258F" };
            Rsid rsid441 = new Rsid() { Val = "00C7373B" };
            Rsid rsid442 = new Rsid() { Val = "00C7455D" };
            Rsid rsid443 = new Rsid() { Val = "00C82E49" };
            Rsid rsid444 = new Rsid() { Val = "00C84067" };
            Rsid rsid445 = new Rsid() { Val = "00C87BD4" };
            Rsid rsid446 = new Rsid() { Val = "00C9301B" };
            Rsid rsid447 = new Rsid() { Val = "00C94286" };
            Rsid rsid448 = new Rsid() { Val = "00C96565" };
            Rsid rsid449 = new Rsid() { Val = "00CA1D0E" };
            Rsid rsid450 = new Rsid() { Val = "00CA2948" };
            Rsid rsid451 = new Rsid() { Val = "00CA4C21" };
            Rsid rsid452 = new Rsid() { Val = "00CD507F" };
            Rsid rsid453 = new Rsid() { Val = "00CD661A" };
            Rsid rsid454 = new Rsid() { Val = "00CD7C94" };
            Rsid rsid455 = new Rsid() { Val = "00CE3667" };
            Rsid rsid456 = new Rsid() { Val = "00CE54CB" };
            Rsid rsid457 = new Rsid() { Val = "00CF7D46" };
            Rsid rsid458 = new Rsid() { Val = "00D00670" };
            Rsid rsid459 = new Rsid() { Val = "00D0483D" };
            Rsid rsid460 = new Rsid() { Val = "00D05152" };
            Rsid rsid461 = new Rsid() { Val = "00D06F9D" };
            Rsid rsid462 = new Rsid() { Val = "00D1215E" };
            Rsid rsid463 = new Rsid() { Val = "00D1657A" };
            Rsid rsid464 = new Rsid() { Val = "00D169AE" };
            Rsid rsid465 = new Rsid() { Val = "00D250B3" };
            Rsid rsid466 = new Rsid() { Val = "00D26176" };
            Rsid rsid467 = new Rsid() { Val = "00D30BA9" };
            Rsid rsid468 = new Rsid() { Val = "00D32B5D" };
            Rsid rsid469 = new Rsid() { Val = "00D42AC8" };
            Rsid rsid470 = new Rsid() { Val = "00D42DF0" };
            Rsid rsid471 = new Rsid() { Val = "00D42F29" };
            Rsid rsid472 = new Rsid() { Val = "00D4747A" };
            Rsid rsid473 = new Rsid() { Val = "00D50081" };
            Rsid rsid474 = new Rsid() { Val = "00D5014F" };
            Rsid rsid475 = new Rsid() { Val = "00D508B6" };
            Rsid rsid476 = new Rsid() { Val = "00D510B6" };
            Rsid rsid477 = new Rsid() { Val = "00D515BF" };
            Rsid rsid478 = new Rsid() { Val = "00D563D9" };
            Rsid rsid479 = new Rsid() { Val = "00D5785E" };
            Rsid rsid480 = new Rsid() { Val = "00D62A67" };
            Rsid rsid481 = new Rsid() { Val = "00D62C06" };
            Rsid rsid482 = new Rsid() { Val = "00D6373B" };
            Rsid rsid483 = new Rsid() { Val = "00D67A57" };
            Rsid rsid484 = new Rsid() { Val = "00D744DB" };
            Rsid rsid485 = new Rsid() { Val = "00D7705C" };
            Rsid rsid486 = new Rsid() { Val = "00D807C5" };
            Rsid rsid487 = new Rsid() { Val = "00D82970" };
            Rsid rsid488 = new Rsid() { Val = "00D87F05" };
            Rsid rsid489 = new Rsid() { Val = "00D945CF" };
            Rsid rsid490 = new Rsid() { Val = "00DA5D9D" };
            Rsid rsid491 = new Rsid() { Val = "00DB00EA" };
            Rsid rsid492 = new Rsid() { Val = "00DB4DD0" };
            Rsid rsid493 = new Rsid() { Val = "00DC1ADB" };
            Rsid rsid494 = new Rsid() { Val = "00DC1C2C" };
            Rsid rsid495 = new Rsid() { Val = "00DC2575" };
            Rsid rsid496 = new Rsid() { Val = "00DC40D2" };
            Rsid rsid497 = new Rsid() { Val = "00DC66A8" };
            Rsid rsid498 = new Rsid() { Val = "00DD0FBE" };
            Rsid rsid499 = new Rsid() { Val = "00DD77E0" };
            Rsid rsid500 = new Rsid() { Val = "00DE61B8" };
            Rsid rsid501 = new Rsid() { Val = "00DF1AA4" };
            Rsid rsid502 = new Rsid() { Val = "00DF74AF" };
            Rsid rsid503 = new Rsid() { Val = "00E01BCB" };
            Rsid rsid504 = new Rsid() { Val = "00E03684" };
            Rsid rsid505 = new Rsid() { Val = "00E04D73" };
            Rsid rsid506 = new Rsid() { Val = "00E06CBC" };
            Rsid rsid507 = new Rsid() { Val = "00E26F4A" };
            Rsid rsid508 = new Rsid() { Val = "00E27F0D" };
            Rsid rsid509 = new Rsid() { Val = "00E35E75" };
            Rsid rsid510 = new Rsid() { Val = "00E37BE8" };
            Rsid rsid511 = new Rsid() { Val = "00E411F2" };
            Rsid rsid512 = new Rsid() { Val = "00E4747C" };
            Rsid rsid513 = new Rsid() { Val = "00E53C6D" };
            Rsid rsid514 = new Rsid() { Val = "00E5768A" };
            Rsid rsid515 = new Rsid() { Val = "00E8001D" };
            Rsid rsid516 = new Rsid() { Val = "00E8181C" };
            Rsid rsid517 = new Rsid() { Val = "00E828A9" };
            Rsid rsid518 = new Rsid() { Val = "00E84318" };
            Rsid rsid519 = new Rsid() { Val = "00E862C2" };
            Rsid rsid520 = new Rsid() { Val = "00E86FCD" };
            Rsid rsid521 = new Rsid() { Val = "00E954B9" };
            Rsid rsid522 = new Rsid() { Val = "00EA11DC" };
            Rsid rsid523 = new Rsid() { Val = "00EA1310" };
            Rsid rsid524 = new Rsid() { Val = "00EA1E1B" };
            Rsid rsid525 = new Rsid() { Val = "00EB52E8" };
            Rsid rsid526 = new Rsid() { Val = "00EB546B" };
            Rsid rsid527 = new Rsid() { Val = "00EB5ABA" };
            Rsid rsid528 = new Rsid() { Val = "00EC0405" };
            Rsid rsid529 = new Rsid() { Val = "00EC4C7B" };
            Rsid rsid530 = new Rsid() { Val = "00EC5864" };
            Rsid rsid531 = new Rsid() { Val = "00EC7B27" };
            Rsid rsid532 = new Rsid() { Val = "00ED0A5F" };
            Rsid rsid533 = new Rsid() { Val = "00ED15CE" };
            Rsid rsid534 = new Rsid() { Val = "00EE11CF" };
            Rsid rsid535 = new Rsid() { Val = "00EE6F8E" };
            Rsid rsid536 = new Rsid() { Val = "00EF5231" };
            Rsid rsid537 = new Rsid() { Val = "00EF5527" };
            Rsid rsid538 = new Rsid() { Val = "00EF5DF9" };
            Rsid rsid539 = new Rsid() { Val = "00F01BC0" };
            Rsid rsid540 = new Rsid() { Val = "00F01F8F" };
            Rsid rsid541 = new Rsid() { Val = "00F03731" };
            Rsid rsid542 = new Rsid() { Val = "00F0627A" };
            Rsid rsid543 = new Rsid() { Val = "00F11ED0" };
            Rsid rsid544 = new Rsid() { Val = "00F13CF7" };
            Rsid rsid545 = new Rsid() { Val = "00F2225C" };
            Rsid rsid546 = new Rsid() { Val = "00F2394F" };
            Rsid rsid547 = new Rsid() { Val = "00F326C6" };
            Rsid rsid548 = new Rsid() { Val = "00F336E5" };
            Rsid rsid549 = new Rsid() { Val = "00F35AF5" };
            Rsid rsid550 = new Rsid() { Val = "00F36528" };
            Rsid rsid551 = new Rsid() { Val = "00F41DF7" };
            Rsid rsid552 = new Rsid() { Val = "00F4392E" };
            Rsid rsid553 = new Rsid() { Val = "00F46A0F" };
            Rsid rsid554 = new Rsid() { Val = "00F54DBC" };
            Rsid rsid555 = new Rsid() { Val = "00F564CF" };
            Rsid rsid556 = new Rsid() { Val = "00F67213" };
            Rsid rsid557 = new Rsid() { Val = "00F7283C" };
            Rsid rsid558 = new Rsid() { Val = "00F8505D" };
            Rsid rsid559 = new Rsid() { Val = "00F87FE3" };
            Rsid rsid560 = new Rsid() { Val = "00F9768B" };
            Rsid rsid561 = new Rsid() { Val = "00FB07A8" };
            Rsid rsid562 = new Rsid() { Val = "00FC1142" };
            Rsid rsid563 = new Rsid() { Val = "00FC2BEF" };
            Rsid rsid564 = new Rsid() { Val = "00FC35A8" };
            Rsid rsid565 = new Rsid() { Val = "00FC4238" };
            Rsid rsid566 = new Rsid() { Val = "00FF6A47" };

            rsids1.Append(rsidRoot1);
            rsids1.Append(rsid1);
            rsids1.Append(rsid2);
            rsids1.Append(rsid3);
            rsids1.Append(rsid4);
            rsids1.Append(rsid5);
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
            rsids1.Append(rsid449);
            rsids1.Append(rsid450);
            rsids1.Append(rsid451);
            rsids1.Append(rsid452);
            rsids1.Append(rsid453);
            rsids1.Append(rsid454);
            rsids1.Append(rsid455);
            rsids1.Append(rsid456);
            rsids1.Append(rsid457);
            rsids1.Append(rsid458);
            rsids1.Append(rsid459);
            rsids1.Append(rsid460);
            rsids1.Append(rsid461);
            rsids1.Append(rsid462);
            rsids1.Append(rsid463);
            rsids1.Append(rsid464);
            rsids1.Append(rsid465);
            rsids1.Append(rsid466);
            rsids1.Append(rsid467);
            rsids1.Append(rsid468);
            rsids1.Append(rsid469);
            rsids1.Append(rsid470);
            rsids1.Append(rsid471);
            rsids1.Append(rsid472);
            rsids1.Append(rsid473);
            rsids1.Append(rsid474);
            rsids1.Append(rsid475);
            rsids1.Append(rsid476);
            rsids1.Append(rsid477);
            rsids1.Append(rsid478);
            rsids1.Append(rsid479);
            rsids1.Append(rsid480);
            rsids1.Append(rsid481);
            rsids1.Append(rsid482);
            rsids1.Append(rsid483);
            rsids1.Append(rsid484);
            rsids1.Append(rsid485);
            rsids1.Append(rsid486);
            rsids1.Append(rsid487);
            rsids1.Append(rsid488);
            rsids1.Append(rsid489);
            rsids1.Append(rsid490);
            rsids1.Append(rsid491);
            rsids1.Append(rsid492);
            rsids1.Append(rsid493);
            rsids1.Append(rsid494);
            rsids1.Append(rsid495);
            rsids1.Append(rsid496);
            rsids1.Append(rsid497);
            rsids1.Append(rsid498);
            rsids1.Append(rsid499);
            rsids1.Append(rsid500);
            rsids1.Append(rsid501);
            rsids1.Append(rsid502);
            rsids1.Append(rsid503);
            rsids1.Append(rsid504);
            rsids1.Append(rsid505);
            rsids1.Append(rsid506);
            rsids1.Append(rsid507);
            rsids1.Append(rsid508);
            rsids1.Append(rsid509);
            rsids1.Append(rsid510);
            rsids1.Append(rsid511);
            rsids1.Append(rsid512);
            rsids1.Append(rsid513);
            rsids1.Append(rsid514);
            rsids1.Append(rsid515);
            rsids1.Append(rsid516);
            rsids1.Append(rsid517);
            rsids1.Append(rsid518);
            rsids1.Append(rsid519);
            rsids1.Append(rsid520);
            rsids1.Append(rsid521);
            rsids1.Append(rsid522);
            rsids1.Append(rsid523);
            rsids1.Append(rsid524);
            rsids1.Append(rsid525);
            rsids1.Append(rsid526);
            rsids1.Append(rsid527);
            rsids1.Append(rsid528);
            rsids1.Append(rsid529);
            rsids1.Append(rsid530);
            rsids1.Append(rsid531);
            rsids1.Append(rsid532);
            rsids1.Append(rsid533);
            rsids1.Append(rsid534);
            rsids1.Append(rsid535);
            rsids1.Append(rsid536);
            rsids1.Append(rsid537);
            rsids1.Append(rsid538);
            rsids1.Append(rsid539);
            rsids1.Append(rsid540);
            rsids1.Append(rsid541);
            rsids1.Append(rsid542);
            rsids1.Append(rsid543);
            rsids1.Append(rsid544);
            rsids1.Append(rsid545);
            rsids1.Append(rsid546);
            rsids1.Append(rsid547);
            rsids1.Append(rsid548);
            rsids1.Append(rsid549);
            rsids1.Append(rsid550);
            rsids1.Append(rsid551);
            rsids1.Append(rsid552);
            rsids1.Append(rsid553);
            rsids1.Append(rsid554);
            rsids1.Append(rsid555);
            rsids1.Append(rsid556);
            rsids1.Append(rsid557);
            rsids1.Append(rsid558);
            rsids1.Append(rsid559);
            rsids1.Append(rsid560);
            rsids1.Append(rsid561);
            rsids1.Append(rsid562);
            rsids1.Append(rsid563);
            rsids1.Append(rsid564);
            rsids1.Append(rsid565);
            rsids1.Append(rsid566);

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

            ShapeDefaults shapeDefaults1 = new ShapeDefaults();
            Ovml.ShapeDefaults shapeDefaults2 = new Ovml.ShapeDefaults() { Extension = V.ExtensionHandlingBehaviorValues.Edit, MaxShapeId = 1026 };

            Ovml.ShapeLayout shapeLayout1 = new Ovml.ShapeLayout() { Extension = V.ExtensionHandlingBehaviorValues.Edit };
            Ovml.ShapeIdMap shapeIdMap1 = new Ovml.ShapeIdMap() { Extension = V.ExtensionHandlingBehaviorValues.Edit, Data = "1" };

            shapeLayout1.Append(shapeIdMap1);

            shapeDefaults1.Append(shapeDefaults2);
            shapeDefaults1.Append(shapeLayout1);
            DecimalSymbol decimalSymbol1 = new DecimalSymbol() { Val = "," };
            ListSeparator listSeparator1 = new ListSeparator() { Val = ";" };
            W15.PersistentDocumentId persistentDocumentId1 = new W15.PersistentDocumentId() { Val = "{7691745C-7BD1-42C0-9E90-0350273AF345}" };

            settings1.Append(zoom1);
            settings1.Append(proofState1);
            settings1.Append(defaultTabStop1);
            settings1.Append(hyphenationZone1);
            settings1.Append(characterSpacingControl1);
            settings1.Append(compatibility1);
            settings1.Append(rsids1);
            settings1.Append(mathProperties1);
            settings1.Append(themeFontLanguages1);
            settings1.Append(colorSchemeMapping1);
            settings1.Append(shapeDefaults1);
            settings1.Append(decimalSymbol1);
            settings1.Append(listSeparator1);
            settings1.Append(persistentDocumentId1);

            documentSettingsPart1.Settings = settings1;
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
            A.RgbColorModelHex rgbColorModelHex1 = new A.RgbColorModelHex() { Val = "1F497D" };

            dark2Color1.Append(rgbColorModelHex1);

            A.Light2Color light2Color1 = new A.Light2Color();
            A.RgbColorModelHex rgbColorModelHex2 = new A.RgbColorModelHex() { Val = "EEECE1" };

            light2Color1.Append(rgbColorModelHex2);

            A.Accent1Color accent1Color1 = new A.Accent1Color();
            A.RgbColorModelHex rgbColorModelHex3 = new A.RgbColorModelHex() { Val = "4F81BD" };

            accent1Color1.Append(rgbColorModelHex3);

            A.Accent2Color accent2Color1 = new A.Accent2Color();
            A.RgbColorModelHex rgbColorModelHex4 = new A.RgbColorModelHex() { Val = "C0504D" };

            accent2Color1.Append(rgbColorModelHex4);

            A.Accent3Color accent3Color1 = new A.Accent3Color();
            A.RgbColorModelHex rgbColorModelHex5 = new A.RgbColorModelHex() { Val = "9BBB59" };

            accent3Color1.Append(rgbColorModelHex5);

            A.Accent4Color accent4Color1 = new A.Accent4Color();
            A.RgbColorModelHex rgbColorModelHex6 = new A.RgbColorModelHex() { Val = "8064A2" };

            accent4Color1.Append(rgbColorModelHex6);

            A.Accent5Color accent5Color1 = new A.Accent5Color();
            A.RgbColorModelHex rgbColorModelHex7 = new A.RgbColorModelHex() { Val = "4BACC6" };

            accent5Color1.Append(rgbColorModelHex7);

            A.Accent6Color accent6Color1 = new A.Accent6Color();
            A.RgbColorModelHex rgbColorModelHex8 = new A.RgbColorModelHex() { Val = "F79646" };

            accent6Color1.Append(rgbColorModelHex8);

            A.Hyperlink hyperlink1 = new A.Hyperlink();
            A.RgbColorModelHex rgbColorModelHex9 = new A.RgbColorModelHex() { Val = "0000FF" };

            hyperlink1.Append(rgbColorModelHex9);

            A.FollowedHyperlinkColor followedHyperlinkColor1 = new A.FollowedHyperlinkColor();
            A.RgbColorModelHex rgbColorModelHex10 = new A.RgbColorModelHex() { Val = "800080" };

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
            A.LatinFont latinFont1 = new A.LatinFont() { Typeface = "Cambria" };
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

            A.MinorFont minorFont1 = new A.MinorFont();
            A.LatinFont latinFont2 = new A.LatinFont() { Typeface = "Calibri" };
            A.EastAsianFont eastAsianFont2 = new A.EastAsianFont() { Typeface = "" };
            A.ComplexScriptFont complexScriptFont2 = new A.ComplexScriptFont() { Typeface = "" };
            A.SupplementalFont supplementalFont30 = new A.SupplementalFont() { Script = "Jpan", Typeface = "ＭＳ 明朝" };
            A.SupplementalFont supplementalFont31 = new A.SupplementalFont() { Script = "Hang", Typeface = "맑은 고딕" };
            A.SupplementalFont supplementalFont32 = new A.SupplementalFont() { Script = "Hans", Typeface = "宋体" };
            A.SupplementalFont supplementalFont33 = new A.SupplementalFont() { Script = "Hant", Typeface = "新細明體" };
            A.SupplementalFont supplementalFont34 = new A.SupplementalFont() { Script = "Arab", Typeface = "Arial" };
            A.SupplementalFont supplementalFont35 = new A.SupplementalFont() { Script = "Hebr", Typeface = "Arial" };
            A.SupplementalFont supplementalFont36 = new A.SupplementalFont() { Script = "Thai", Typeface = "Cordia New" };
            A.SupplementalFont supplementalFont37 = new A.SupplementalFont() { Script = "Ethi", Typeface = "Nyala" };
            A.SupplementalFont supplementalFont38 = new A.SupplementalFont() { Script = "Beng", Typeface = "Vrinda" };
            A.SupplementalFont supplementalFont39 = new A.SupplementalFont() { Script = "Gujr", Typeface = "Shruti" };
            A.SupplementalFont supplementalFont40 = new A.SupplementalFont() { Script = "Khmr", Typeface = "DaunPenh" };
            A.SupplementalFont supplementalFont41 = new A.SupplementalFont() { Script = "Knda", Typeface = "Tunga" };
            A.SupplementalFont supplementalFont42 = new A.SupplementalFont() { Script = "Guru", Typeface = "Raavi" };
            A.SupplementalFont supplementalFont43 = new A.SupplementalFont() { Script = "Cans", Typeface = "Euphemia" };
            A.SupplementalFont supplementalFont44 = new A.SupplementalFont() { Script = "Cher", Typeface = "Plantagenet Cherokee" };
            A.SupplementalFont supplementalFont45 = new A.SupplementalFont() { Script = "Yiii", Typeface = "Microsoft Yi Baiti" };
            A.SupplementalFont supplementalFont46 = new A.SupplementalFont() { Script = "Tibt", Typeface = "Microsoft Himalaya" };
            A.SupplementalFont supplementalFont47 = new A.SupplementalFont() { Script = "Thaa", Typeface = "MV Boli" };
            A.SupplementalFont supplementalFont48 = new A.SupplementalFont() { Script = "Deva", Typeface = "Mangal" };
            A.SupplementalFont supplementalFont49 = new A.SupplementalFont() { Script = "Telu", Typeface = "Gautami" };
            A.SupplementalFont supplementalFont50 = new A.SupplementalFont() { Script = "Taml", Typeface = "Latha" };
            A.SupplementalFont supplementalFont51 = new A.SupplementalFont() { Script = "Syrc", Typeface = "Estrangelo Edessa" };
            A.SupplementalFont supplementalFont52 = new A.SupplementalFont() { Script = "Orya", Typeface = "Kalinga" };
            A.SupplementalFont supplementalFont53 = new A.SupplementalFont() { Script = "Mlym", Typeface = "Kartika" };
            A.SupplementalFont supplementalFont54 = new A.SupplementalFont() { Script = "Laoo", Typeface = "DokChampa" };
            A.SupplementalFont supplementalFont55 = new A.SupplementalFont() { Script = "Sinh", Typeface = "Iskoola Pota" };
            A.SupplementalFont supplementalFont56 = new A.SupplementalFont() { Script = "Mong", Typeface = "Mongolian Baiti" };
            A.SupplementalFont supplementalFont57 = new A.SupplementalFont() { Script = "Viet", Typeface = "Arial" };
            A.SupplementalFont supplementalFont58 = new A.SupplementalFont() { Script = "Uigh", Typeface = "Microsoft Uighur" };

            minorFont1.Append(latinFont2);
            minorFont1.Append(eastAsianFont2);
            minorFont1.Append(complexScriptFont2);
            minorFont1.Append(supplementalFont30);
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
            A.Tint tint1 = new A.Tint() { Val = 50000 };
            A.SaturationModulation saturationModulation1 = new A.SaturationModulation() { Val = 300000 };

            schemeColor2.Append(tint1);
            schemeColor2.Append(saturationModulation1);

            gradientStop1.Append(schemeColor2);

            A.GradientStop gradientStop2 = new A.GradientStop() { Position = 35000 };

            A.SchemeColor schemeColor3 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Tint tint2 = new A.Tint() { Val = 37000 };
            A.SaturationModulation saturationModulation2 = new A.SaturationModulation() { Val = 300000 };

            schemeColor3.Append(tint2);
            schemeColor3.Append(saturationModulation2);

            gradientStop2.Append(schemeColor3);

            A.GradientStop gradientStop3 = new A.GradientStop() { Position = 100000 };

            A.SchemeColor schemeColor4 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Tint tint3 = new A.Tint() { Val = 15000 };
            A.SaturationModulation saturationModulation3 = new A.SaturationModulation() { Val = 350000 };

            schemeColor4.Append(tint3);
            schemeColor4.Append(saturationModulation3);

            gradientStop3.Append(schemeColor4);

            gradientStopList1.Append(gradientStop1);
            gradientStopList1.Append(gradientStop2);
            gradientStopList1.Append(gradientStop3);
            A.LinearGradientFill linearGradientFill1 = new A.LinearGradientFill() { Angle = 16200000, Scaled = true };

            gradientFill1.Append(gradientStopList1);
            gradientFill1.Append(linearGradientFill1);

            A.GradientFill gradientFill2 = new A.GradientFill() { RotateWithShape = true };

            A.GradientStopList gradientStopList2 = new A.GradientStopList();

            A.GradientStop gradientStop4 = new A.GradientStop() { Position = 0 };

            A.SchemeColor schemeColor5 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Shade shade1 = new A.Shade() { Val = 51000 };
            A.SaturationModulation saturationModulation4 = new A.SaturationModulation() { Val = 130000 };

            schemeColor5.Append(shade1);
            schemeColor5.Append(saturationModulation4);

            gradientStop4.Append(schemeColor5);

            A.GradientStop gradientStop5 = new A.GradientStop() { Position = 80000 };

            A.SchemeColor schemeColor6 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Shade shade2 = new A.Shade() { Val = 93000 };
            A.SaturationModulation saturationModulation5 = new A.SaturationModulation() { Val = 130000 };

            schemeColor6.Append(shade2);
            schemeColor6.Append(saturationModulation5);

            gradientStop5.Append(schemeColor6);

            A.GradientStop gradientStop6 = new A.GradientStop() { Position = 100000 };

            A.SchemeColor schemeColor7 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Shade shade3 = new A.Shade() { Val = 94000 };
            A.SaturationModulation saturationModulation6 = new A.SaturationModulation() { Val = 135000 };

            schemeColor7.Append(shade3);
            schemeColor7.Append(saturationModulation6);

            gradientStop6.Append(schemeColor7);

            gradientStopList2.Append(gradientStop4);
            gradientStopList2.Append(gradientStop5);
            gradientStopList2.Append(gradientStop6);
            A.LinearGradientFill linearGradientFill2 = new A.LinearGradientFill() { Angle = 16200000, Scaled = false };

            gradientFill2.Append(gradientStopList2);
            gradientFill2.Append(linearGradientFill2);

            fillStyleList1.Append(solidFill1);
            fillStyleList1.Append(gradientFill1);
            fillStyleList1.Append(gradientFill2);

            A.LineStyleList lineStyleList1 = new A.LineStyleList();

            A.Outline outline2 = new A.Outline() { Width = 9525, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            A.SolidFill solidFill2 = new A.SolidFill();

            A.SchemeColor schemeColor8 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Shade shade4 = new A.Shade() { Val = 95000 };
            A.SaturationModulation saturationModulation7 = new A.SaturationModulation() { Val = 105000 };

            schemeColor8.Append(shade4);
            schemeColor8.Append(saturationModulation7);

            solidFill2.Append(schemeColor8);
            A.PresetDash presetDash1 = new A.PresetDash() { Val = A.PresetLineDashValues.Solid };

            outline2.Append(solidFill2);
            outline2.Append(presetDash1);

            A.Outline outline3 = new A.Outline() { Width = 25400, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            A.SolidFill solidFill3 = new A.SolidFill();
            A.SchemeColor schemeColor9 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };

            solidFill3.Append(schemeColor9);
            A.PresetDash presetDash2 = new A.PresetDash() { Val = A.PresetLineDashValues.Solid };

            outline3.Append(solidFill3);
            outline3.Append(presetDash2);

            A.Outline outline4 = new A.Outline() { Width = 38100, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            A.SolidFill solidFill4 = new A.SolidFill();
            A.SchemeColor schemeColor10 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };

            solidFill4.Append(schemeColor10);
            A.PresetDash presetDash3 = new A.PresetDash() { Val = A.PresetLineDashValues.Solid };

            outline4.Append(solidFill4);
            outline4.Append(presetDash3);

            lineStyleList1.Append(outline2);
            lineStyleList1.Append(outline3);
            lineStyleList1.Append(outline4);

            A.EffectStyleList effectStyleList1 = new A.EffectStyleList();

            A.EffectStyle effectStyle1 = new A.EffectStyle();

            A.EffectList effectList1 = new A.EffectList();

            A.OuterShadow outerShadow1 = new A.OuterShadow() { BlurRadius = 40000L, Distance = 20000L, Direction = 5400000, RotateWithShape = false };

            A.RgbColorModelHex rgbColorModelHex11 = new A.RgbColorModelHex() { Val = "000000" };
            A.Alpha alpha1 = new A.Alpha() { Val = 38000 };

            rgbColorModelHex11.Append(alpha1);

            outerShadow1.Append(rgbColorModelHex11);

            effectList1.Append(outerShadow1);

            effectStyle1.Append(effectList1);

            A.EffectStyle effectStyle2 = new A.EffectStyle();

            A.EffectList effectList2 = new A.EffectList();

            A.OuterShadow outerShadow2 = new A.OuterShadow() { BlurRadius = 40000L, Distance = 23000L, Direction = 5400000, RotateWithShape = false };

            A.RgbColorModelHex rgbColorModelHex12 = new A.RgbColorModelHex() { Val = "000000" };
            A.Alpha alpha2 = new A.Alpha() { Val = 35000 };

            rgbColorModelHex12.Append(alpha2);

            outerShadow2.Append(rgbColorModelHex12);

            effectList2.Append(outerShadow2);

            effectStyle2.Append(effectList2);

            A.EffectStyle effectStyle3 = new A.EffectStyle();

            A.EffectList effectList3 = new A.EffectList();

            A.OuterShadow outerShadow3 = new A.OuterShadow() { BlurRadius = 40000L, Distance = 23000L, Direction = 5400000, RotateWithShape = false };

            A.RgbColorModelHex rgbColorModelHex13 = new A.RgbColorModelHex() { Val = "000000" };
            A.Alpha alpha3 = new A.Alpha() { Val = 35000 };

            rgbColorModelHex13.Append(alpha3);

            outerShadow3.Append(rgbColorModelHex13);

            effectList3.Append(outerShadow3);

            A.Scene3DType scene3DType1 = new A.Scene3DType();

            A.Camera camera1 = new A.Camera() { Preset = A.PresetCameraValues.OrthographicFront };
            A.Rotation rotation1 = new A.Rotation() { Latitude = 0, Longitude = 0, Revolution = 0 };

            camera1.Append(rotation1);

            A.LightRig lightRig1 = new A.LightRig() { Rig = A.LightRigValues.ThreePoints, Direction = A.LightRigDirectionValues.Top };
            A.Rotation rotation2 = new A.Rotation() { Latitude = 0, Longitude = 0, Revolution = 1200000 };

            lightRig1.Append(rotation2);

            scene3DType1.Append(camera1);
            scene3DType1.Append(lightRig1);

            A.Shape3DType shape3DType1 = new A.Shape3DType();
            A.BevelTop bevelTop1 = new A.BevelTop() { Width = 63500L, Height = 25400L };

            shape3DType1.Append(bevelTop1);

            effectStyle3.Append(effectList3);
            effectStyle3.Append(scene3DType1);
            effectStyle3.Append(shape3DType1);

            effectStyleList1.Append(effectStyle1);
            effectStyleList1.Append(effectStyle2);
            effectStyleList1.Append(effectStyle3);

            A.BackgroundFillStyleList backgroundFillStyleList1 = new A.BackgroundFillStyleList();

            A.SolidFill solidFill5 = new A.SolidFill();
            A.SchemeColor schemeColor11 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };

            solidFill5.Append(schemeColor11);

            A.GradientFill gradientFill3 = new A.GradientFill() { RotateWithShape = true };

            A.GradientStopList gradientStopList3 = new A.GradientStopList();

            A.GradientStop gradientStop7 = new A.GradientStop() { Position = 0 };

            A.SchemeColor schemeColor12 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Tint tint4 = new A.Tint() { Val = 40000 };
            A.SaturationModulation saturationModulation8 = new A.SaturationModulation() { Val = 350000 };

            schemeColor12.Append(tint4);
            schemeColor12.Append(saturationModulation8);

            gradientStop7.Append(schemeColor12);

            A.GradientStop gradientStop8 = new A.GradientStop() { Position = 40000 };

            A.SchemeColor schemeColor13 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Tint tint5 = new A.Tint() { Val = 45000 };
            A.Shade shade5 = new A.Shade() { Val = 99000 };
            A.SaturationModulation saturationModulation9 = new A.SaturationModulation() { Val = 350000 };

            schemeColor13.Append(tint5);
            schemeColor13.Append(shade5);
            schemeColor13.Append(saturationModulation9);

            gradientStop8.Append(schemeColor13);

            A.GradientStop gradientStop9 = new A.GradientStop() { Position = 100000 };

            A.SchemeColor schemeColor14 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Shade shade6 = new A.Shade() { Val = 20000 };
            A.SaturationModulation saturationModulation10 = new A.SaturationModulation() { Val = 255000 };

            schemeColor14.Append(shade6);
            schemeColor14.Append(saturationModulation10);

            gradientStop9.Append(schemeColor14);

            gradientStopList3.Append(gradientStop7);
            gradientStopList3.Append(gradientStop8);
            gradientStopList3.Append(gradientStop9);

            A.PathGradientFill pathGradientFill1 = new A.PathGradientFill() { Path = A.PathShadeValues.Circle };
            A.FillToRectangle fillToRectangle1 = new A.FillToRectangle() { Left = 50000, Top = -80000, Right = 50000, Bottom = 180000 };

            pathGradientFill1.Append(fillToRectangle1);

            gradientFill3.Append(gradientStopList3);
            gradientFill3.Append(pathGradientFill1);

            A.GradientFill gradientFill4 = new A.GradientFill() { RotateWithShape = true };

            A.GradientStopList gradientStopList4 = new A.GradientStopList();

            A.GradientStop gradientStop10 = new A.GradientStop() { Position = 0 };

            A.SchemeColor schemeColor15 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Tint tint6 = new A.Tint() { Val = 80000 };
            A.SaturationModulation saturationModulation11 = new A.SaturationModulation() { Val = 300000 };

            schemeColor15.Append(tint6);
            schemeColor15.Append(saturationModulation11);

            gradientStop10.Append(schemeColor15);

            A.GradientStop gradientStop11 = new A.GradientStop() { Position = 100000 };

            A.SchemeColor schemeColor16 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Shade shade7 = new A.Shade() { Val = 30000 };
            A.SaturationModulation saturationModulation12 = new A.SaturationModulation() { Val = 200000 };

            schemeColor16.Append(shade7);
            schemeColor16.Append(saturationModulation12);

            gradientStop11.Append(schemeColor16);

            gradientStopList4.Append(gradientStop10);
            gradientStopList4.Append(gradientStop11);

            A.PathGradientFill pathGradientFill2 = new A.PathGradientFill() { Path = A.PathShadeValues.Circle };
            A.FillToRectangle fillToRectangle2 = new A.FillToRectangle() { Left = 50000, Top = 50000, Right = 50000, Bottom = 50000 };

            pathGradientFill2.Append(fillToRectangle2);

            gradientFill4.Append(gradientStopList4);
            gradientFill4.Append(pathGradientFill2);

            backgroundFillStyleList1.Append(solidFill5);
            backgroundFillStyleList1.Append(gradientFill3);
            backgroundFillStyleList1.Append(gradientFill4);

            formatScheme1.Append(fillStyleList1);
            formatScheme1.Append(lineStyleList1);
            formatScheme1.Append(effectStyleList1);
            formatScheme1.Append(backgroundFillStyleList1);

            themeElements1.Append(colorScheme1);
            themeElements1.Append(fontScheme1);
            themeElements1.Append(formatScheme1);
            A.ObjectDefaults objectDefaults1 = new A.ObjectDefaults();
            A.ExtraColorSchemeList extraColorSchemeList1 = new A.ExtraColorSchemeList();

            theme1.Append(themeElements1);
            theme1.Append(objectDefaults1);
            theme1.Append(extraColorSchemeList1);

            themePart1.Theme = theme1;
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
            RunFonts runFonts254 = new RunFonts() { Ascii = "Calibri", HighAnsi = "Calibri", EastAsia = "Calibri", ComplexScript = "Times New Roman" };
            Languages languages66 = new Languages() { Val = "ru-RU", EastAsia = "ru-RU", Bidi = "ar-SA" };

            runPropertiesBaseStyle1.Append(runFonts254);
            runPropertiesBaseStyle1.Append(languages66);

            runPropertiesDefault1.Append(runPropertiesBaseStyle1);
            ParagraphPropertiesDefault paragraphPropertiesDefault1 = new ParagraphPropertiesDefault();

            docDefaults1.Append(runPropertiesDefault1);
            docDefaults1.Append(paragraphPropertiesDefault1);

            LatentStyles latentStyles1 = new LatentStyles() { DefaultLockedState = false, DefaultUiPriority = 99, DefaultSemiHidden = false, DefaultUnhideWhenUsed = false, DefaultPrimaryStyle = false, Count = 371 };
            LatentStyleExceptionInfo latentStyleExceptionInfo1 = new LatentStyleExceptionInfo() { Name = "Normal", UiPriority = 0, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo2 = new LatentStyleExceptionInfo() { Name = "heading 1", UiPriority = 9, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo3 = new LatentStyleExceptionInfo() { Name = "heading 2", UiPriority = 9, SemiHidden = true, UnhideWhenUsed = true, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo4 = new LatentStyleExceptionInfo() { Name = "heading 3", UiPriority = 9, SemiHidden = true, UnhideWhenUsed = true, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo5 = new LatentStyleExceptionInfo() { Name = "heading 4", UiPriority = 9, SemiHidden = true, UnhideWhenUsed = true, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo6 = new LatentStyleExceptionInfo() { Name = "heading 5", UiPriority = 9, SemiHidden = true, UnhideWhenUsed = true, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo7 = new LatentStyleExceptionInfo() { Name = "heading 6", UiPriority = 9, SemiHidden = true, UnhideWhenUsed = true, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo8 = new LatentStyleExceptionInfo() { Name = "heading 7", UiPriority = 9, SemiHidden = true, UnhideWhenUsed = true, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo9 = new LatentStyleExceptionInfo() { Name = "heading 8", UiPriority = 9, SemiHidden = true, UnhideWhenUsed = true, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo10 = new LatentStyleExceptionInfo() { Name = "heading 9", UiPriority = 9, SemiHidden = true, UnhideWhenUsed = true, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo11 = new LatentStyleExceptionInfo() { Name = "index 1", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo12 = new LatentStyleExceptionInfo() { Name = "index 2", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo13 = new LatentStyleExceptionInfo() { Name = "index 3", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo14 = new LatentStyleExceptionInfo() { Name = "index 4", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo15 = new LatentStyleExceptionInfo() { Name = "index 5", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo16 = new LatentStyleExceptionInfo() { Name = "index 6", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo17 = new LatentStyleExceptionInfo() { Name = "index 7", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo18 = new LatentStyleExceptionInfo() { Name = "index 8", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo19 = new LatentStyleExceptionInfo() { Name = "index 9", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo20 = new LatentStyleExceptionInfo() { Name = "toc 1", UiPriority = 39, SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo21 = new LatentStyleExceptionInfo() { Name = "toc 2", UiPriority = 39, SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo22 = new LatentStyleExceptionInfo() { Name = "toc 3", UiPriority = 39, SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo23 = new LatentStyleExceptionInfo() { Name = "toc 4", UiPriority = 39, SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo24 = new LatentStyleExceptionInfo() { Name = "toc 5", UiPriority = 39, SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo25 = new LatentStyleExceptionInfo() { Name = "toc 6", UiPriority = 39, SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo26 = new LatentStyleExceptionInfo() { Name = "toc 7", UiPriority = 39, SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo27 = new LatentStyleExceptionInfo() { Name = "toc 8", UiPriority = 39, SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo28 = new LatentStyleExceptionInfo() { Name = "toc 9", UiPriority = 39, SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo29 = new LatentStyleExceptionInfo() { Name = "Normal Indent", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo30 = new LatentStyleExceptionInfo() { Name = "footnote text", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo31 = new LatentStyleExceptionInfo() { Name = "annotation text", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo32 = new LatentStyleExceptionInfo() { Name = "header", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo33 = new LatentStyleExceptionInfo() { Name = "footer", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo34 = new LatentStyleExceptionInfo() { Name = "index heading", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo35 = new LatentStyleExceptionInfo() { Name = "caption", UiPriority = 35, SemiHidden = true, UnhideWhenUsed = true, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo36 = new LatentStyleExceptionInfo() { Name = "table of figures", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo37 = new LatentStyleExceptionInfo() { Name = "envelope address", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo38 = new LatentStyleExceptionInfo() { Name = "envelope return", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo39 = new LatentStyleExceptionInfo() { Name = "footnote reference", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo40 = new LatentStyleExceptionInfo() { Name = "annotation reference", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo41 = new LatentStyleExceptionInfo() { Name = "line number", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo42 = new LatentStyleExceptionInfo() { Name = "page number", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo43 = new LatentStyleExceptionInfo() { Name = "endnote reference", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo44 = new LatentStyleExceptionInfo() { Name = "endnote text", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo45 = new LatentStyleExceptionInfo() { Name = "table of authorities", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo46 = new LatentStyleExceptionInfo() { Name = "macro", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo47 = new LatentStyleExceptionInfo() { Name = "toa heading", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo48 = new LatentStyleExceptionInfo() { Name = "List", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo49 = new LatentStyleExceptionInfo() { Name = "List Bullet", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo50 = new LatentStyleExceptionInfo() { Name = "List Number", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo51 = new LatentStyleExceptionInfo() { Name = "List 2", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo52 = new LatentStyleExceptionInfo() { Name = "List 3", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo53 = new LatentStyleExceptionInfo() { Name = "List 4", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo54 = new LatentStyleExceptionInfo() { Name = "List 5", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo55 = new LatentStyleExceptionInfo() { Name = "List Bullet 2", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo56 = new LatentStyleExceptionInfo() { Name = "List Bullet 3", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo57 = new LatentStyleExceptionInfo() { Name = "List Bullet 4", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo58 = new LatentStyleExceptionInfo() { Name = "List Bullet 5", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo59 = new LatentStyleExceptionInfo() { Name = "List Number 2", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo60 = new LatentStyleExceptionInfo() { Name = "List Number 3", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo61 = new LatentStyleExceptionInfo() { Name = "List Number 4", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo62 = new LatentStyleExceptionInfo() { Name = "List Number 5", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo63 = new LatentStyleExceptionInfo() { Name = "Title", UiPriority = 10, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo64 = new LatentStyleExceptionInfo() { Name = "Closing", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo65 = new LatentStyleExceptionInfo() { Name = "Signature", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo66 = new LatentStyleExceptionInfo() { Name = "Default Paragraph Font", UiPriority = 1, SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo67 = new LatentStyleExceptionInfo() { Name = "Body Text", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo68 = new LatentStyleExceptionInfo() { Name = "Body Text Indent", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo69 = new LatentStyleExceptionInfo() { Name = "List Continue", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo70 = new LatentStyleExceptionInfo() { Name = "List Continue 2", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo71 = new LatentStyleExceptionInfo() { Name = "List Continue 3", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo72 = new LatentStyleExceptionInfo() { Name = "List Continue 4", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo73 = new LatentStyleExceptionInfo() { Name = "List Continue 5", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo74 = new LatentStyleExceptionInfo() { Name = "Message Header", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo75 = new LatentStyleExceptionInfo() { Name = "Subtitle", UiPriority = 11, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo76 = new LatentStyleExceptionInfo() { Name = "Salutation", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo77 = new LatentStyleExceptionInfo() { Name = "Date", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo78 = new LatentStyleExceptionInfo() { Name = "Body Text First Indent", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo79 = new LatentStyleExceptionInfo() { Name = "Body Text First Indent 2", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo80 = new LatentStyleExceptionInfo() { Name = "Note Heading", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo81 = new LatentStyleExceptionInfo() { Name = "Body Text 2", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo82 = new LatentStyleExceptionInfo() { Name = "Body Text 3", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo83 = new LatentStyleExceptionInfo() { Name = "Body Text Indent 2", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo84 = new LatentStyleExceptionInfo() { Name = "Body Text Indent 3", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo85 = new LatentStyleExceptionInfo() { Name = "Block Text", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo86 = new LatentStyleExceptionInfo() { Name = "Hyperlink", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo87 = new LatentStyleExceptionInfo() { Name = "FollowedHyperlink", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo88 = new LatentStyleExceptionInfo() { Name = "Strong", UiPriority = 22, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo89 = new LatentStyleExceptionInfo() { Name = "Emphasis", UiPriority = 20, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo90 = new LatentStyleExceptionInfo() { Name = "Document Map", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo91 = new LatentStyleExceptionInfo() { Name = "Plain Text", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo92 = new LatentStyleExceptionInfo() { Name = "E-mail Signature", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo93 = new LatentStyleExceptionInfo() { Name = "HTML Top of Form", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo94 = new LatentStyleExceptionInfo() { Name = "HTML Bottom of Form", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo95 = new LatentStyleExceptionInfo() { Name = "Normal (Web)", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo96 = new LatentStyleExceptionInfo() { Name = "HTML Acronym", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo97 = new LatentStyleExceptionInfo() { Name = "HTML Address", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo98 = new LatentStyleExceptionInfo() { Name = "HTML Cite", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo99 = new LatentStyleExceptionInfo() { Name = "HTML Code", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo100 = new LatentStyleExceptionInfo() { Name = "HTML Definition", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo101 = new LatentStyleExceptionInfo() { Name = "HTML Keyboard", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo102 = new LatentStyleExceptionInfo() { Name = "HTML Preformatted", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo103 = new LatentStyleExceptionInfo() { Name = "HTML Sample", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo104 = new LatentStyleExceptionInfo() { Name = "HTML Typewriter", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo105 = new LatentStyleExceptionInfo() { Name = "HTML Variable", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo106 = new LatentStyleExceptionInfo() { Name = "Normal Table", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo107 = new LatentStyleExceptionInfo() { Name = "annotation subject", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo108 = new LatentStyleExceptionInfo() { Name = "No List", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo109 = new LatentStyleExceptionInfo() { Name = "Outline List 1", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo110 = new LatentStyleExceptionInfo() { Name = "Outline List 2", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo111 = new LatentStyleExceptionInfo() { Name = "Outline List 3", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo112 = new LatentStyleExceptionInfo() { Name = "Table Simple 1", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo113 = new LatentStyleExceptionInfo() { Name = "Table Simple 2", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo114 = new LatentStyleExceptionInfo() { Name = "Table Simple 3", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo115 = new LatentStyleExceptionInfo() { Name = "Table Classic 1", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo116 = new LatentStyleExceptionInfo() { Name = "Table Classic 2", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo117 = new LatentStyleExceptionInfo() { Name = "Table Classic 3", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo118 = new LatentStyleExceptionInfo() { Name = "Table Classic 4", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo119 = new LatentStyleExceptionInfo() { Name = "Table Colorful 1", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo120 = new LatentStyleExceptionInfo() { Name = "Table Colorful 2", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo121 = new LatentStyleExceptionInfo() { Name = "Table Colorful 3", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo122 = new LatentStyleExceptionInfo() { Name = "Table Columns 1", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo123 = new LatentStyleExceptionInfo() { Name = "Table Columns 2", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo124 = new LatentStyleExceptionInfo() { Name = "Table Columns 3", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo125 = new LatentStyleExceptionInfo() { Name = "Table Columns 4", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo126 = new LatentStyleExceptionInfo() { Name = "Table Columns 5", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo127 = new LatentStyleExceptionInfo() { Name = "Table Grid 1", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo128 = new LatentStyleExceptionInfo() { Name = "Table Grid 2", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo129 = new LatentStyleExceptionInfo() { Name = "Table Grid 3", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo130 = new LatentStyleExceptionInfo() { Name = "Table Grid 4", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo131 = new LatentStyleExceptionInfo() { Name = "Table Grid 5", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo132 = new LatentStyleExceptionInfo() { Name = "Table Grid 6", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo133 = new LatentStyleExceptionInfo() { Name = "Table Grid 7", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo134 = new LatentStyleExceptionInfo() { Name = "Table Grid 8", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo135 = new LatentStyleExceptionInfo() { Name = "Table List 1", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo136 = new LatentStyleExceptionInfo() { Name = "Table List 2", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo137 = new LatentStyleExceptionInfo() { Name = "Table List 3", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo138 = new LatentStyleExceptionInfo() { Name = "Table List 4", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo139 = new LatentStyleExceptionInfo() { Name = "Table List 5", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo140 = new LatentStyleExceptionInfo() { Name = "Table List 6", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo141 = new LatentStyleExceptionInfo() { Name = "Table List 7", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo142 = new LatentStyleExceptionInfo() { Name = "Table List 8", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo143 = new LatentStyleExceptionInfo() { Name = "Table 3D effects 1", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo144 = new LatentStyleExceptionInfo() { Name = "Table 3D effects 2", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo145 = new LatentStyleExceptionInfo() { Name = "Table 3D effects 3", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo146 = new LatentStyleExceptionInfo() { Name = "Table Contemporary", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo147 = new LatentStyleExceptionInfo() { Name = "Table Elegant", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo148 = new LatentStyleExceptionInfo() { Name = "Table Professional", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo149 = new LatentStyleExceptionInfo() { Name = "Table Subtle 1", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo150 = new LatentStyleExceptionInfo() { Name = "Table Subtle 2", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo151 = new LatentStyleExceptionInfo() { Name = "Table Web 1", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo152 = new LatentStyleExceptionInfo() { Name = "Table Web 2", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo153 = new LatentStyleExceptionInfo() { Name = "Table Web 3", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo154 = new LatentStyleExceptionInfo() { Name = "Balloon Text", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo155 = new LatentStyleExceptionInfo() { Name = "Table Grid", UiPriority = 59 };
            LatentStyleExceptionInfo latentStyleExceptionInfo156 = new LatentStyleExceptionInfo() { Name = "Table Theme", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo157 = new LatentStyleExceptionInfo() { Name = "Placeholder Text", SemiHidden = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo158 = new LatentStyleExceptionInfo() { Name = "No Spacing", UiPriority = 1, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo159 = new LatentStyleExceptionInfo() { Name = "Light Shading", UiPriority = 60 };
            LatentStyleExceptionInfo latentStyleExceptionInfo160 = new LatentStyleExceptionInfo() { Name = "Light List", UiPriority = 61 };
            LatentStyleExceptionInfo latentStyleExceptionInfo161 = new LatentStyleExceptionInfo() { Name = "Light Grid", UiPriority = 62 };
            LatentStyleExceptionInfo latentStyleExceptionInfo162 = new LatentStyleExceptionInfo() { Name = "Medium Shading 1", UiPriority = 63 };
            LatentStyleExceptionInfo latentStyleExceptionInfo163 = new LatentStyleExceptionInfo() { Name = "Medium Shading 2", UiPriority = 64 };
            LatentStyleExceptionInfo latentStyleExceptionInfo164 = new LatentStyleExceptionInfo() { Name = "Medium List 1", UiPriority = 65 };
            LatentStyleExceptionInfo latentStyleExceptionInfo165 = new LatentStyleExceptionInfo() { Name = "Medium List 2", UiPriority = 66 };
            LatentStyleExceptionInfo latentStyleExceptionInfo166 = new LatentStyleExceptionInfo() { Name = "Medium Grid 1", UiPriority = 67 };
            LatentStyleExceptionInfo latentStyleExceptionInfo167 = new LatentStyleExceptionInfo() { Name = "Medium Grid 2", UiPriority = 68 };
            LatentStyleExceptionInfo latentStyleExceptionInfo168 = new LatentStyleExceptionInfo() { Name = "Medium Grid 3", UiPriority = 69 };
            LatentStyleExceptionInfo latentStyleExceptionInfo169 = new LatentStyleExceptionInfo() { Name = "Dark List", UiPriority = 70 };
            LatentStyleExceptionInfo latentStyleExceptionInfo170 = new LatentStyleExceptionInfo() { Name = "Colorful Shading", UiPriority = 71 };
            LatentStyleExceptionInfo latentStyleExceptionInfo171 = new LatentStyleExceptionInfo() { Name = "Colorful List", UiPriority = 72 };
            LatentStyleExceptionInfo latentStyleExceptionInfo172 = new LatentStyleExceptionInfo() { Name = "Colorful Grid", UiPriority = 73 };
            LatentStyleExceptionInfo latentStyleExceptionInfo173 = new LatentStyleExceptionInfo() { Name = "Light Shading Accent 1", UiPriority = 60 };
            LatentStyleExceptionInfo latentStyleExceptionInfo174 = new LatentStyleExceptionInfo() { Name = "Light List Accent 1", UiPriority = 61 };
            LatentStyleExceptionInfo latentStyleExceptionInfo175 = new LatentStyleExceptionInfo() { Name = "Light Grid Accent 1", UiPriority = 62 };
            LatentStyleExceptionInfo latentStyleExceptionInfo176 = new LatentStyleExceptionInfo() { Name = "Medium Shading 1 Accent 1", UiPriority = 63 };
            LatentStyleExceptionInfo latentStyleExceptionInfo177 = new LatentStyleExceptionInfo() { Name = "Medium Shading 2 Accent 1", UiPriority = 64 };
            LatentStyleExceptionInfo latentStyleExceptionInfo178 = new LatentStyleExceptionInfo() { Name = "Medium List 1 Accent 1", UiPriority = 65 };
            LatentStyleExceptionInfo latentStyleExceptionInfo179 = new LatentStyleExceptionInfo() { Name = "Revision", SemiHidden = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo180 = new LatentStyleExceptionInfo() { Name = "List Paragraph", UiPriority = 34, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo181 = new LatentStyleExceptionInfo() { Name = "Quote", UiPriority = 29, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo182 = new LatentStyleExceptionInfo() { Name = "Intense Quote", UiPriority = 30, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo183 = new LatentStyleExceptionInfo() { Name = "Medium List 2 Accent 1", UiPriority = 66 };
            LatentStyleExceptionInfo latentStyleExceptionInfo184 = new LatentStyleExceptionInfo() { Name = "Medium Grid 1 Accent 1", UiPriority = 67 };
            LatentStyleExceptionInfo latentStyleExceptionInfo185 = new LatentStyleExceptionInfo() { Name = "Medium Grid 2 Accent 1", UiPriority = 68 };
            LatentStyleExceptionInfo latentStyleExceptionInfo186 = new LatentStyleExceptionInfo() { Name = "Medium Grid 3 Accent 1", UiPriority = 69 };
            LatentStyleExceptionInfo latentStyleExceptionInfo187 = new LatentStyleExceptionInfo() { Name = "Dark List Accent 1", UiPriority = 70 };
            LatentStyleExceptionInfo latentStyleExceptionInfo188 = new LatentStyleExceptionInfo() { Name = "Colorful Shading Accent 1", UiPriority = 71 };
            LatentStyleExceptionInfo latentStyleExceptionInfo189 = new LatentStyleExceptionInfo() { Name = "Colorful List Accent 1", UiPriority = 72 };
            LatentStyleExceptionInfo latentStyleExceptionInfo190 = new LatentStyleExceptionInfo() { Name = "Colorful Grid Accent 1", UiPriority = 73 };
            LatentStyleExceptionInfo latentStyleExceptionInfo191 = new LatentStyleExceptionInfo() { Name = "Light Shading Accent 2", UiPriority = 60 };
            LatentStyleExceptionInfo latentStyleExceptionInfo192 = new LatentStyleExceptionInfo() { Name = "Light List Accent 2", UiPriority = 61 };
            LatentStyleExceptionInfo latentStyleExceptionInfo193 = new LatentStyleExceptionInfo() { Name = "Light Grid Accent 2", UiPriority = 62 };
            LatentStyleExceptionInfo latentStyleExceptionInfo194 = new LatentStyleExceptionInfo() { Name = "Medium Shading 1 Accent 2", UiPriority = 63 };
            LatentStyleExceptionInfo latentStyleExceptionInfo195 = new LatentStyleExceptionInfo() { Name = "Medium Shading 2 Accent 2", UiPriority = 64 };
            LatentStyleExceptionInfo latentStyleExceptionInfo196 = new LatentStyleExceptionInfo() { Name = "Medium List 1 Accent 2", UiPriority = 65 };
            LatentStyleExceptionInfo latentStyleExceptionInfo197 = new LatentStyleExceptionInfo() { Name = "Medium List 2 Accent 2", UiPriority = 66 };
            LatentStyleExceptionInfo latentStyleExceptionInfo198 = new LatentStyleExceptionInfo() { Name = "Medium Grid 1 Accent 2", UiPriority = 67 };
            LatentStyleExceptionInfo latentStyleExceptionInfo199 = new LatentStyleExceptionInfo() { Name = "Medium Grid 2 Accent 2", UiPriority = 68 };
            LatentStyleExceptionInfo latentStyleExceptionInfo200 = new LatentStyleExceptionInfo() { Name = "Medium Grid 3 Accent 2", UiPriority = 69 };
            LatentStyleExceptionInfo latentStyleExceptionInfo201 = new LatentStyleExceptionInfo() { Name = "Dark List Accent 2", UiPriority = 70 };
            LatentStyleExceptionInfo latentStyleExceptionInfo202 = new LatentStyleExceptionInfo() { Name = "Colorful Shading Accent 2", UiPriority = 71 };
            LatentStyleExceptionInfo latentStyleExceptionInfo203 = new LatentStyleExceptionInfo() { Name = "Colorful List Accent 2", UiPriority = 72 };
            LatentStyleExceptionInfo latentStyleExceptionInfo204 = new LatentStyleExceptionInfo() { Name = "Colorful Grid Accent 2", UiPriority = 73 };
            LatentStyleExceptionInfo latentStyleExceptionInfo205 = new LatentStyleExceptionInfo() { Name = "Light Shading Accent 3", UiPriority = 60 };
            LatentStyleExceptionInfo latentStyleExceptionInfo206 = new LatentStyleExceptionInfo() { Name = "Light List Accent 3", UiPriority = 61 };
            LatentStyleExceptionInfo latentStyleExceptionInfo207 = new LatentStyleExceptionInfo() { Name = "Light Grid Accent 3", UiPriority = 62 };
            LatentStyleExceptionInfo latentStyleExceptionInfo208 = new LatentStyleExceptionInfo() { Name = "Medium Shading 1 Accent 3", UiPriority = 63 };
            LatentStyleExceptionInfo latentStyleExceptionInfo209 = new LatentStyleExceptionInfo() { Name = "Medium Shading 2 Accent 3", UiPriority = 64 };
            LatentStyleExceptionInfo latentStyleExceptionInfo210 = new LatentStyleExceptionInfo() { Name = "Medium List 1 Accent 3", UiPriority = 65 };
            LatentStyleExceptionInfo latentStyleExceptionInfo211 = new LatentStyleExceptionInfo() { Name = "Medium List 2 Accent 3", UiPriority = 66 };
            LatentStyleExceptionInfo latentStyleExceptionInfo212 = new LatentStyleExceptionInfo() { Name = "Medium Grid 1 Accent 3", UiPriority = 67 };
            LatentStyleExceptionInfo latentStyleExceptionInfo213 = new LatentStyleExceptionInfo() { Name = "Medium Grid 2 Accent 3", UiPriority = 68 };
            LatentStyleExceptionInfo latentStyleExceptionInfo214 = new LatentStyleExceptionInfo() { Name = "Medium Grid 3 Accent 3", UiPriority = 69 };
            LatentStyleExceptionInfo latentStyleExceptionInfo215 = new LatentStyleExceptionInfo() { Name = "Dark List Accent 3", UiPriority = 70 };
            LatentStyleExceptionInfo latentStyleExceptionInfo216 = new LatentStyleExceptionInfo() { Name = "Colorful Shading Accent 3", UiPriority = 71 };
            LatentStyleExceptionInfo latentStyleExceptionInfo217 = new LatentStyleExceptionInfo() { Name = "Colorful List Accent 3", UiPriority = 72 };
            LatentStyleExceptionInfo latentStyleExceptionInfo218 = new LatentStyleExceptionInfo() { Name = "Colorful Grid Accent 3", UiPriority = 73 };
            LatentStyleExceptionInfo latentStyleExceptionInfo219 = new LatentStyleExceptionInfo() { Name = "Light Shading Accent 4", UiPriority = 60 };
            LatentStyleExceptionInfo latentStyleExceptionInfo220 = new LatentStyleExceptionInfo() { Name = "Light List Accent 4", UiPriority = 61 };
            LatentStyleExceptionInfo latentStyleExceptionInfo221 = new LatentStyleExceptionInfo() { Name = "Light Grid Accent 4", UiPriority = 62 };
            LatentStyleExceptionInfo latentStyleExceptionInfo222 = new LatentStyleExceptionInfo() { Name = "Medium Shading 1 Accent 4", UiPriority = 63 };
            LatentStyleExceptionInfo latentStyleExceptionInfo223 = new LatentStyleExceptionInfo() { Name = "Medium Shading 2 Accent 4", UiPriority = 64 };
            LatentStyleExceptionInfo latentStyleExceptionInfo224 = new LatentStyleExceptionInfo() { Name = "Medium List 1 Accent 4", UiPriority = 65 };
            LatentStyleExceptionInfo latentStyleExceptionInfo225 = new LatentStyleExceptionInfo() { Name = "Medium List 2 Accent 4", UiPriority = 66 };
            LatentStyleExceptionInfo latentStyleExceptionInfo226 = new LatentStyleExceptionInfo() { Name = "Medium Grid 1 Accent 4", UiPriority = 67 };
            LatentStyleExceptionInfo latentStyleExceptionInfo227 = new LatentStyleExceptionInfo() { Name = "Medium Grid 2 Accent 4", UiPriority = 68 };
            LatentStyleExceptionInfo latentStyleExceptionInfo228 = new LatentStyleExceptionInfo() { Name = "Medium Grid 3 Accent 4", UiPriority = 69 };
            LatentStyleExceptionInfo latentStyleExceptionInfo229 = new LatentStyleExceptionInfo() { Name = "Dark List Accent 4", UiPriority = 70 };
            LatentStyleExceptionInfo latentStyleExceptionInfo230 = new LatentStyleExceptionInfo() { Name = "Colorful Shading Accent 4", UiPriority = 71 };
            LatentStyleExceptionInfo latentStyleExceptionInfo231 = new LatentStyleExceptionInfo() { Name = "Colorful List Accent 4", UiPriority = 72 };
            LatentStyleExceptionInfo latentStyleExceptionInfo232 = new LatentStyleExceptionInfo() { Name = "Colorful Grid Accent 4", UiPriority = 73 };
            LatentStyleExceptionInfo latentStyleExceptionInfo233 = new LatentStyleExceptionInfo() { Name = "Light Shading Accent 5", UiPriority = 60 };
            LatentStyleExceptionInfo latentStyleExceptionInfo234 = new LatentStyleExceptionInfo() { Name = "Light List Accent 5", UiPriority = 61 };
            LatentStyleExceptionInfo latentStyleExceptionInfo235 = new LatentStyleExceptionInfo() { Name = "Light Grid Accent 5", UiPriority = 62 };
            LatentStyleExceptionInfo latentStyleExceptionInfo236 = new LatentStyleExceptionInfo() { Name = "Medium Shading 1 Accent 5", UiPriority = 63 };
            LatentStyleExceptionInfo latentStyleExceptionInfo237 = new LatentStyleExceptionInfo() { Name = "Medium Shading 2 Accent 5", UiPriority = 64 };
            LatentStyleExceptionInfo latentStyleExceptionInfo238 = new LatentStyleExceptionInfo() { Name = "Medium List 1 Accent 5", UiPriority = 65 };
            LatentStyleExceptionInfo latentStyleExceptionInfo239 = new LatentStyleExceptionInfo() { Name = "Medium List 2 Accent 5", UiPriority = 66 };
            LatentStyleExceptionInfo latentStyleExceptionInfo240 = new LatentStyleExceptionInfo() { Name = "Medium Grid 1 Accent 5", UiPriority = 67 };
            LatentStyleExceptionInfo latentStyleExceptionInfo241 = new LatentStyleExceptionInfo() { Name = "Medium Grid 2 Accent 5", UiPriority = 68 };
            LatentStyleExceptionInfo latentStyleExceptionInfo242 = new LatentStyleExceptionInfo() { Name = "Medium Grid 3 Accent 5", UiPriority = 69 };
            LatentStyleExceptionInfo latentStyleExceptionInfo243 = new LatentStyleExceptionInfo() { Name = "Dark List Accent 5", UiPriority = 70 };
            LatentStyleExceptionInfo latentStyleExceptionInfo244 = new LatentStyleExceptionInfo() { Name = "Colorful Shading Accent 5", UiPriority = 71 };
            LatentStyleExceptionInfo latentStyleExceptionInfo245 = new LatentStyleExceptionInfo() { Name = "Colorful List Accent 5", UiPriority = 72 };
            LatentStyleExceptionInfo latentStyleExceptionInfo246 = new LatentStyleExceptionInfo() { Name = "Colorful Grid Accent 5", UiPriority = 73 };
            LatentStyleExceptionInfo latentStyleExceptionInfo247 = new LatentStyleExceptionInfo() { Name = "Light Shading Accent 6", UiPriority = 60 };
            LatentStyleExceptionInfo latentStyleExceptionInfo248 = new LatentStyleExceptionInfo() { Name = "Light List Accent 6", UiPriority = 61 };
            LatentStyleExceptionInfo latentStyleExceptionInfo249 = new LatentStyleExceptionInfo() { Name = "Light Grid Accent 6", UiPriority = 62 };
            LatentStyleExceptionInfo latentStyleExceptionInfo250 = new LatentStyleExceptionInfo() { Name = "Medium Shading 1 Accent 6", UiPriority = 63 };
            LatentStyleExceptionInfo latentStyleExceptionInfo251 = new LatentStyleExceptionInfo() { Name = "Medium Shading 2 Accent 6", UiPriority = 64 };
            LatentStyleExceptionInfo latentStyleExceptionInfo252 = new LatentStyleExceptionInfo() { Name = "Medium List 1 Accent 6", UiPriority = 65 };
            LatentStyleExceptionInfo latentStyleExceptionInfo253 = new LatentStyleExceptionInfo() { Name = "Medium List 2 Accent 6", UiPriority = 66 };
            LatentStyleExceptionInfo latentStyleExceptionInfo254 = new LatentStyleExceptionInfo() { Name = "Medium Grid 1 Accent 6", UiPriority = 67 };
            LatentStyleExceptionInfo latentStyleExceptionInfo255 = new LatentStyleExceptionInfo() { Name = "Medium Grid 2 Accent 6", UiPriority = 68 };
            LatentStyleExceptionInfo latentStyleExceptionInfo256 = new LatentStyleExceptionInfo() { Name = "Medium Grid 3 Accent 6", UiPriority = 69 };
            LatentStyleExceptionInfo latentStyleExceptionInfo257 = new LatentStyleExceptionInfo() { Name = "Dark List Accent 6", UiPriority = 70 };
            LatentStyleExceptionInfo latentStyleExceptionInfo258 = new LatentStyleExceptionInfo() { Name = "Colorful Shading Accent 6", UiPriority = 71 };
            LatentStyleExceptionInfo latentStyleExceptionInfo259 = new LatentStyleExceptionInfo() { Name = "Colorful List Accent 6", UiPriority = 72 };
            LatentStyleExceptionInfo latentStyleExceptionInfo260 = new LatentStyleExceptionInfo() { Name = "Colorful Grid Accent 6", UiPriority = 73 };
            LatentStyleExceptionInfo latentStyleExceptionInfo261 = new LatentStyleExceptionInfo() { Name = "Subtle Emphasis", UiPriority = 19, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo262 = new LatentStyleExceptionInfo() { Name = "Intense Emphasis", UiPriority = 21, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo263 = new LatentStyleExceptionInfo() { Name = "Subtle Reference", UiPriority = 31, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo264 = new LatentStyleExceptionInfo() { Name = "Intense Reference", UiPriority = 32, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo265 = new LatentStyleExceptionInfo() { Name = "Book Title", UiPriority = 33, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo266 = new LatentStyleExceptionInfo() { Name = "Bibliography", UiPriority = 37, SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo267 = new LatentStyleExceptionInfo() { Name = "TOC Heading", UiPriority = 39, SemiHidden = true, UnhideWhenUsed = true, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo268 = new LatentStyleExceptionInfo() { Name = "Plain Table 1", UiPriority = 41 };
            LatentStyleExceptionInfo latentStyleExceptionInfo269 = new LatentStyleExceptionInfo() { Name = "Plain Table 2", UiPriority = 42 };
            LatentStyleExceptionInfo latentStyleExceptionInfo270 = new LatentStyleExceptionInfo() { Name = "Plain Table 3", UiPriority = 43 };
            LatentStyleExceptionInfo latentStyleExceptionInfo271 = new LatentStyleExceptionInfo() { Name = "Plain Table 4", UiPriority = 44 };
            LatentStyleExceptionInfo latentStyleExceptionInfo272 = new LatentStyleExceptionInfo() { Name = "Plain Table 5", UiPriority = 45 };
            LatentStyleExceptionInfo latentStyleExceptionInfo273 = new LatentStyleExceptionInfo() { Name = "Grid Table Light", UiPriority = 40 };
            LatentStyleExceptionInfo latentStyleExceptionInfo274 = new LatentStyleExceptionInfo() { Name = "Grid Table 1 Light", UiPriority = 46 };
            LatentStyleExceptionInfo latentStyleExceptionInfo275 = new LatentStyleExceptionInfo() { Name = "Grid Table 2", UiPriority = 47 };
            LatentStyleExceptionInfo latentStyleExceptionInfo276 = new LatentStyleExceptionInfo() { Name = "Grid Table 3", UiPriority = 48 };
            LatentStyleExceptionInfo latentStyleExceptionInfo277 = new LatentStyleExceptionInfo() { Name = "Grid Table 4", UiPriority = 49 };
            LatentStyleExceptionInfo latentStyleExceptionInfo278 = new LatentStyleExceptionInfo() { Name = "Grid Table 5 Dark", UiPriority = 50 };
            LatentStyleExceptionInfo latentStyleExceptionInfo279 = new LatentStyleExceptionInfo() { Name = "Grid Table 6 Colorful", UiPriority = 51 };
            LatentStyleExceptionInfo latentStyleExceptionInfo280 = new LatentStyleExceptionInfo() { Name = "Grid Table 7 Colorful", UiPriority = 52 };
            LatentStyleExceptionInfo latentStyleExceptionInfo281 = new LatentStyleExceptionInfo() { Name = "Grid Table 1 Light Accent 1", UiPriority = 46 };
            LatentStyleExceptionInfo latentStyleExceptionInfo282 = new LatentStyleExceptionInfo() { Name = "Grid Table 2 Accent 1", UiPriority = 47 };
            LatentStyleExceptionInfo latentStyleExceptionInfo283 = new LatentStyleExceptionInfo() { Name = "Grid Table 3 Accent 1", UiPriority = 48 };
            LatentStyleExceptionInfo latentStyleExceptionInfo284 = new LatentStyleExceptionInfo() { Name = "Grid Table 4 Accent 1", UiPriority = 49 };
            LatentStyleExceptionInfo latentStyleExceptionInfo285 = new LatentStyleExceptionInfo() { Name = "Grid Table 5 Dark Accent 1", UiPriority = 50 };
            LatentStyleExceptionInfo latentStyleExceptionInfo286 = new LatentStyleExceptionInfo() { Name = "Grid Table 6 Colorful Accent 1", UiPriority = 51 };
            LatentStyleExceptionInfo latentStyleExceptionInfo287 = new LatentStyleExceptionInfo() { Name = "Grid Table 7 Colorful Accent 1", UiPriority = 52 };
            LatentStyleExceptionInfo latentStyleExceptionInfo288 = new LatentStyleExceptionInfo() { Name = "Grid Table 1 Light Accent 2", UiPriority = 46 };
            LatentStyleExceptionInfo latentStyleExceptionInfo289 = new LatentStyleExceptionInfo() { Name = "Grid Table 2 Accent 2", UiPriority = 47 };
            LatentStyleExceptionInfo latentStyleExceptionInfo290 = new LatentStyleExceptionInfo() { Name = "Grid Table 3 Accent 2", UiPriority = 48 };
            LatentStyleExceptionInfo latentStyleExceptionInfo291 = new LatentStyleExceptionInfo() { Name = "Grid Table 4 Accent 2", UiPriority = 49 };
            LatentStyleExceptionInfo latentStyleExceptionInfo292 = new LatentStyleExceptionInfo() { Name = "Grid Table 5 Dark Accent 2", UiPriority = 50 };
            LatentStyleExceptionInfo latentStyleExceptionInfo293 = new LatentStyleExceptionInfo() { Name = "Grid Table 6 Colorful Accent 2", UiPriority = 51 };
            LatentStyleExceptionInfo latentStyleExceptionInfo294 = new LatentStyleExceptionInfo() { Name = "Grid Table 7 Colorful Accent 2", UiPriority = 52 };
            LatentStyleExceptionInfo latentStyleExceptionInfo295 = new LatentStyleExceptionInfo() { Name = "Grid Table 1 Light Accent 3", UiPriority = 46 };
            LatentStyleExceptionInfo latentStyleExceptionInfo296 = new LatentStyleExceptionInfo() { Name = "Grid Table 2 Accent 3", UiPriority = 47 };
            LatentStyleExceptionInfo latentStyleExceptionInfo297 = new LatentStyleExceptionInfo() { Name = "Grid Table 3 Accent 3", UiPriority = 48 };
            LatentStyleExceptionInfo latentStyleExceptionInfo298 = new LatentStyleExceptionInfo() { Name = "Grid Table 4 Accent 3", UiPriority = 49 };
            LatentStyleExceptionInfo latentStyleExceptionInfo299 = new LatentStyleExceptionInfo() { Name = "Grid Table 5 Dark Accent 3", UiPriority = 50 };
            LatentStyleExceptionInfo latentStyleExceptionInfo300 = new LatentStyleExceptionInfo() { Name = "Grid Table 6 Colorful Accent 3", UiPriority = 51 };
            LatentStyleExceptionInfo latentStyleExceptionInfo301 = new LatentStyleExceptionInfo() { Name = "Grid Table 7 Colorful Accent 3", UiPriority = 52 };
            LatentStyleExceptionInfo latentStyleExceptionInfo302 = new LatentStyleExceptionInfo() { Name = "Grid Table 1 Light Accent 4", UiPriority = 46 };
            LatentStyleExceptionInfo latentStyleExceptionInfo303 = new LatentStyleExceptionInfo() { Name = "Grid Table 2 Accent 4", UiPriority = 47 };
            LatentStyleExceptionInfo latentStyleExceptionInfo304 = new LatentStyleExceptionInfo() { Name = "Grid Table 3 Accent 4", UiPriority = 48 };
            LatentStyleExceptionInfo latentStyleExceptionInfo305 = new LatentStyleExceptionInfo() { Name = "Grid Table 4 Accent 4", UiPriority = 49 };
            LatentStyleExceptionInfo latentStyleExceptionInfo306 = new LatentStyleExceptionInfo() { Name = "Grid Table 5 Dark Accent 4", UiPriority = 50 };
            LatentStyleExceptionInfo latentStyleExceptionInfo307 = new LatentStyleExceptionInfo() { Name = "Grid Table 6 Colorful Accent 4", UiPriority = 51 };
            LatentStyleExceptionInfo latentStyleExceptionInfo308 = new LatentStyleExceptionInfo() { Name = "Grid Table 7 Colorful Accent 4", UiPriority = 52 };
            LatentStyleExceptionInfo latentStyleExceptionInfo309 = new LatentStyleExceptionInfo() { Name = "Grid Table 1 Light Accent 5", UiPriority = 46 };
            LatentStyleExceptionInfo latentStyleExceptionInfo310 = new LatentStyleExceptionInfo() { Name = "Grid Table 2 Accent 5", UiPriority = 47 };
            LatentStyleExceptionInfo latentStyleExceptionInfo311 = new LatentStyleExceptionInfo() { Name = "Grid Table 3 Accent 5", UiPriority = 48 };
            LatentStyleExceptionInfo latentStyleExceptionInfo312 = new LatentStyleExceptionInfo() { Name = "Grid Table 4 Accent 5", UiPriority = 49 };
            LatentStyleExceptionInfo latentStyleExceptionInfo313 = new LatentStyleExceptionInfo() { Name = "Grid Table 5 Dark Accent 5", UiPriority = 50 };
            LatentStyleExceptionInfo latentStyleExceptionInfo314 = new LatentStyleExceptionInfo() { Name = "Grid Table 6 Colorful Accent 5", UiPriority = 51 };
            LatentStyleExceptionInfo latentStyleExceptionInfo315 = new LatentStyleExceptionInfo() { Name = "Grid Table 7 Colorful Accent 5", UiPriority = 52 };
            LatentStyleExceptionInfo latentStyleExceptionInfo316 = new LatentStyleExceptionInfo() { Name = "Grid Table 1 Light Accent 6", UiPriority = 46 };
            LatentStyleExceptionInfo latentStyleExceptionInfo317 = new LatentStyleExceptionInfo() { Name = "Grid Table 2 Accent 6", UiPriority = 47 };
            LatentStyleExceptionInfo latentStyleExceptionInfo318 = new LatentStyleExceptionInfo() { Name = "Grid Table 3 Accent 6", UiPriority = 48 };
            LatentStyleExceptionInfo latentStyleExceptionInfo319 = new LatentStyleExceptionInfo() { Name = "Grid Table 4 Accent 6", UiPriority = 49 };
            LatentStyleExceptionInfo latentStyleExceptionInfo320 = new LatentStyleExceptionInfo() { Name = "Grid Table 5 Dark Accent 6", UiPriority = 50 };
            LatentStyleExceptionInfo latentStyleExceptionInfo321 = new LatentStyleExceptionInfo() { Name = "Grid Table 6 Colorful Accent 6", UiPriority = 51 };
            LatentStyleExceptionInfo latentStyleExceptionInfo322 = new LatentStyleExceptionInfo() { Name = "Grid Table 7 Colorful Accent 6", UiPriority = 52 };
            LatentStyleExceptionInfo latentStyleExceptionInfo323 = new LatentStyleExceptionInfo() { Name = "List Table 1 Light", UiPriority = 46 };
            LatentStyleExceptionInfo latentStyleExceptionInfo324 = new LatentStyleExceptionInfo() { Name = "List Table 2", UiPriority = 47 };
            LatentStyleExceptionInfo latentStyleExceptionInfo325 = new LatentStyleExceptionInfo() { Name = "List Table 3", UiPriority = 48 };
            LatentStyleExceptionInfo latentStyleExceptionInfo326 = new LatentStyleExceptionInfo() { Name = "List Table 4", UiPriority = 49 };
            LatentStyleExceptionInfo latentStyleExceptionInfo327 = new LatentStyleExceptionInfo() { Name = "List Table 5 Dark", UiPriority = 50 };
            LatentStyleExceptionInfo latentStyleExceptionInfo328 = new LatentStyleExceptionInfo() { Name = "List Table 6 Colorful", UiPriority = 51 };
            LatentStyleExceptionInfo latentStyleExceptionInfo329 = new LatentStyleExceptionInfo() { Name = "List Table 7 Colorful", UiPriority = 52 };
            LatentStyleExceptionInfo latentStyleExceptionInfo330 = new LatentStyleExceptionInfo() { Name = "List Table 1 Light Accent 1", UiPriority = 46 };
            LatentStyleExceptionInfo latentStyleExceptionInfo331 = new LatentStyleExceptionInfo() { Name = "List Table 2 Accent 1", UiPriority = 47 };
            LatentStyleExceptionInfo latentStyleExceptionInfo332 = new LatentStyleExceptionInfo() { Name = "List Table 3 Accent 1", UiPriority = 48 };
            LatentStyleExceptionInfo latentStyleExceptionInfo333 = new LatentStyleExceptionInfo() { Name = "List Table 4 Accent 1", UiPriority = 49 };
            LatentStyleExceptionInfo latentStyleExceptionInfo334 = new LatentStyleExceptionInfo() { Name = "List Table 5 Dark Accent 1", UiPriority = 50 };
            LatentStyleExceptionInfo latentStyleExceptionInfo335 = new LatentStyleExceptionInfo() { Name = "List Table 6 Colorful Accent 1", UiPriority = 51 };
            LatentStyleExceptionInfo latentStyleExceptionInfo336 = new LatentStyleExceptionInfo() { Name = "List Table 7 Colorful Accent 1", UiPriority = 52 };
            LatentStyleExceptionInfo latentStyleExceptionInfo337 = new LatentStyleExceptionInfo() { Name = "List Table 1 Light Accent 2", UiPriority = 46 };
            LatentStyleExceptionInfo latentStyleExceptionInfo338 = new LatentStyleExceptionInfo() { Name = "List Table 2 Accent 2", UiPriority = 47 };
            LatentStyleExceptionInfo latentStyleExceptionInfo339 = new LatentStyleExceptionInfo() { Name = "List Table 3 Accent 2", UiPriority = 48 };
            LatentStyleExceptionInfo latentStyleExceptionInfo340 = new LatentStyleExceptionInfo() { Name = "List Table 4 Accent 2", UiPriority = 49 };
            LatentStyleExceptionInfo latentStyleExceptionInfo341 = new LatentStyleExceptionInfo() { Name = "List Table 5 Dark Accent 2", UiPriority = 50 };
            LatentStyleExceptionInfo latentStyleExceptionInfo342 = new LatentStyleExceptionInfo() { Name = "List Table 6 Colorful Accent 2", UiPriority = 51 };
            LatentStyleExceptionInfo latentStyleExceptionInfo343 = new LatentStyleExceptionInfo() { Name = "List Table 7 Colorful Accent 2", UiPriority = 52 };
            LatentStyleExceptionInfo latentStyleExceptionInfo344 = new LatentStyleExceptionInfo() { Name = "List Table 1 Light Accent 3", UiPriority = 46 };
            LatentStyleExceptionInfo latentStyleExceptionInfo345 = new LatentStyleExceptionInfo() { Name = "List Table 2 Accent 3", UiPriority = 47 };
            LatentStyleExceptionInfo latentStyleExceptionInfo346 = new LatentStyleExceptionInfo() { Name = "List Table 3 Accent 3", UiPriority = 48 };
            LatentStyleExceptionInfo latentStyleExceptionInfo347 = new LatentStyleExceptionInfo() { Name = "List Table 4 Accent 3", UiPriority = 49 };
            LatentStyleExceptionInfo latentStyleExceptionInfo348 = new LatentStyleExceptionInfo() { Name = "List Table 5 Dark Accent 3", UiPriority = 50 };
            LatentStyleExceptionInfo latentStyleExceptionInfo349 = new LatentStyleExceptionInfo() { Name = "List Table 6 Colorful Accent 3", UiPriority = 51 };
            LatentStyleExceptionInfo latentStyleExceptionInfo350 = new LatentStyleExceptionInfo() { Name = "List Table 7 Colorful Accent 3", UiPriority = 52 };
            LatentStyleExceptionInfo latentStyleExceptionInfo351 = new LatentStyleExceptionInfo() { Name = "List Table 1 Light Accent 4", UiPriority = 46 };
            LatentStyleExceptionInfo latentStyleExceptionInfo352 = new LatentStyleExceptionInfo() { Name = "List Table 2 Accent 4", UiPriority = 47 };
            LatentStyleExceptionInfo latentStyleExceptionInfo353 = new LatentStyleExceptionInfo() { Name = "List Table 3 Accent 4", UiPriority = 48 };
            LatentStyleExceptionInfo latentStyleExceptionInfo354 = new LatentStyleExceptionInfo() { Name = "List Table 4 Accent 4", UiPriority = 49 };
            LatentStyleExceptionInfo latentStyleExceptionInfo355 = new LatentStyleExceptionInfo() { Name = "List Table 5 Dark Accent 4", UiPriority = 50 };
            LatentStyleExceptionInfo latentStyleExceptionInfo356 = new LatentStyleExceptionInfo() { Name = "List Table 6 Colorful Accent 4", UiPriority = 51 };
            LatentStyleExceptionInfo latentStyleExceptionInfo357 = new LatentStyleExceptionInfo() { Name = "List Table 7 Colorful Accent 4", UiPriority = 52 };
            LatentStyleExceptionInfo latentStyleExceptionInfo358 = new LatentStyleExceptionInfo() { Name = "List Table 1 Light Accent 5", UiPriority = 46 };
            LatentStyleExceptionInfo latentStyleExceptionInfo359 = new LatentStyleExceptionInfo() { Name = "List Table 2 Accent 5", UiPriority = 47 };
            LatentStyleExceptionInfo latentStyleExceptionInfo360 = new LatentStyleExceptionInfo() { Name = "List Table 3 Accent 5", UiPriority = 48 };
            LatentStyleExceptionInfo latentStyleExceptionInfo361 = new LatentStyleExceptionInfo() { Name = "List Table 4 Accent 5", UiPriority = 49 };
            LatentStyleExceptionInfo latentStyleExceptionInfo362 = new LatentStyleExceptionInfo() { Name = "List Table 5 Dark Accent 5", UiPriority = 50 };
            LatentStyleExceptionInfo latentStyleExceptionInfo363 = new LatentStyleExceptionInfo() { Name = "List Table 6 Colorful Accent 5", UiPriority = 51 };
            LatentStyleExceptionInfo latentStyleExceptionInfo364 = new LatentStyleExceptionInfo() { Name = "List Table 7 Colorful Accent 5", UiPriority = 52 };
            LatentStyleExceptionInfo latentStyleExceptionInfo365 = new LatentStyleExceptionInfo() { Name = "List Table 1 Light Accent 6", UiPriority = 46 };
            LatentStyleExceptionInfo latentStyleExceptionInfo366 = new LatentStyleExceptionInfo() { Name = "List Table 2 Accent 6", UiPriority = 47 };
            LatentStyleExceptionInfo latentStyleExceptionInfo367 = new LatentStyleExceptionInfo() { Name = "List Table 3 Accent 6", UiPriority = 48 };
            LatentStyleExceptionInfo latentStyleExceptionInfo368 = new LatentStyleExceptionInfo() { Name = "List Table 4 Accent 6", UiPriority = 49 };
            LatentStyleExceptionInfo latentStyleExceptionInfo369 = new LatentStyleExceptionInfo() { Name = "List Table 5 Dark Accent 6", UiPriority = 50 };
            LatentStyleExceptionInfo latentStyleExceptionInfo370 = new LatentStyleExceptionInfo() { Name = "List Table 6 Colorful Accent 6", UiPriority = 51 };
            LatentStyleExceptionInfo latentStyleExceptionInfo371 = new LatentStyleExceptionInfo() { Name = "List Table 7 Colorful Accent 6", UiPriority = 52 };

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
            latentStyles1.Append(latentStyleExceptionInfo275);
            latentStyles1.Append(latentStyleExceptionInfo276);
            latentStyles1.Append(latentStyleExceptionInfo277);
            latentStyles1.Append(latentStyleExceptionInfo278);
            latentStyles1.Append(latentStyleExceptionInfo279);
            latentStyles1.Append(latentStyleExceptionInfo280);
            latentStyles1.Append(latentStyleExceptionInfo281);
            latentStyles1.Append(latentStyleExceptionInfo282);
            latentStyles1.Append(latentStyleExceptionInfo283);
            latentStyles1.Append(latentStyleExceptionInfo284);
            latentStyles1.Append(latentStyleExceptionInfo285);
            latentStyles1.Append(latentStyleExceptionInfo286);
            latentStyles1.Append(latentStyleExceptionInfo287);
            latentStyles1.Append(latentStyleExceptionInfo288);
            latentStyles1.Append(latentStyleExceptionInfo289);
            latentStyles1.Append(latentStyleExceptionInfo290);
            latentStyles1.Append(latentStyleExceptionInfo291);
            latentStyles1.Append(latentStyleExceptionInfo292);
            latentStyles1.Append(latentStyleExceptionInfo293);
            latentStyles1.Append(latentStyleExceptionInfo294);
            latentStyles1.Append(latentStyleExceptionInfo295);
            latentStyles1.Append(latentStyleExceptionInfo296);
            latentStyles1.Append(latentStyleExceptionInfo297);
            latentStyles1.Append(latentStyleExceptionInfo298);
            latentStyles1.Append(latentStyleExceptionInfo299);
            latentStyles1.Append(latentStyleExceptionInfo300);
            latentStyles1.Append(latentStyleExceptionInfo301);
            latentStyles1.Append(latentStyleExceptionInfo302);
            latentStyles1.Append(latentStyleExceptionInfo303);
            latentStyles1.Append(latentStyleExceptionInfo304);
            latentStyles1.Append(latentStyleExceptionInfo305);
            latentStyles1.Append(latentStyleExceptionInfo306);
            latentStyles1.Append(latentStyleExceptionInfo307);
            latentStyles1.Append(latentStyleExceptionInfo308);
            latentStyles1.Append(latentStyleExceptionInfo309);
            latentStyles1.Append(latentStyleExceptionInfo310);
            latentStyles1.Append(latentStyleExceptionInfo311);
            latentStyles1.Append(latentStyleExceptionInfo312);
            latentStyles1.Append(latentStyleExceptionInfo313);
            latentStyles1.Append(latentStyleExceptionInfo314);
            latentStyles1.Append(latentStyleExceptionInfo315);
            latentStyles1.Append(latentStyleExceptionInfo316);
            latentStyles1.Append(latentStyleExceptionInfo317);
            latentStyles1.Append(latentStyleExceptionInfo318);
            latentStyles1.Append(latentStyleExceptionInfo319);
            latentStyles1.Append(latentStyleExceptionInfo320);
            latentStyles1.Append(latentStyleExceptionInfo321);
            latentStyles1.Append(latentStyleExceptionInfo322);
            latentStyles1.Append(latentStyleExceptionInfo323);
            latentStyles1.Append(latentStyleExceptionInfo324);
            latentStyles1.Append(latentStyleExceptionInfo325);
            latentStyles1.Append(latentStyleExceptionInfo326);
            latentStyles1.Append(latentStyleExceptionInfo327);
            latentStyles1.Append(latentStyleExceptionInfo328);
            latentStyles1.Append(latentStyleExceptionInfo329);
            latentStyles1.Append(latentStyleExceptionInfo330);
            latentStyles1.Append(latentStyleExceptionInfo331);
            latentStyles1.Append(latentStyleExceptionInfo332);
            latentStyles1.Append(latentStyleExceptionInfo333);
            latentStyles1.Append(latentStyleExceptionInfo334);
            latentStyles1.Append(latentStyleExceptionInfo335);
            latentStyles1.Append(latentStyleExceptionInfo336);
            latentStyles1.Append(latentStyleExceptionInfo337);
            latentStyles1.Append(latentStyleExceptionInfo338);
            latentStyles1.Append(latentStyleExceptionInfo339);
            latentStyles1.Append(latentStyleExceptionInfo340);
            latentStyles1.Append(latentStyleExceptionInfo341);
            latentStyles1.Append(latentStyleExceptionInfo342);
            latentStyles1.Append(latentStyleExceptionInfo343);
            latentStyles1.Append(latentStyleExceptionInfo344);
            latentStyles1.Append(latentStyleExceptionInfo345);
            latentStyles1.Append(latentStyleExceptionInfo346);
            latentStyles1.Append(latentStyleExceptionInfo347);
            latentStyles1.Append(latentStyleExceptionInfo348);
            latentStyles1.Append(latentStyleExceptionInfo349);
            latentStyles1.Append(latentStyleExceptionInfo350);
            latentStyles1.Append(latentStyleExceptionInfo351);
            latentStyles1.Append(latentStyleExceptionInfo352);
            latentStyles1.Append(latentStyleExceptionInfo353);
            latentStyles1.Append(latentStyleExceptionInfo354);
            latentStyles1.Append(latentStyleExceptionInfo355);
            latentStyles1.Append(latentStyleExceptionInfo356);
            latentStyles1.Append(latentStyleExceptionInfo357);
            latentStyles1.Append(latentStyleExceptionInfo358);
            latentStyles1.Append(latentStyleExceptionInfo359);
            latentStyles1.Append(latentStyleExceptionInfo360);
            latentStyles1.Append(latentStyleExceptionInfo361);
            latentStyles1.Append(latentStyleExceptionInfo362);
            latentStyles1.Append(latentStyleExceptionInfo363);
            latentStyles1.Append(latentStyleExceptionInfo364);
            latentStyles1.Append(latentStyleExceptionInfo365);
            latentStyles1.Append(latentStyleExceptionInfo366);
            latentStyles1.Append(latentStyleExceptionInfo367);
            latentStyles1.Append(latentStyleExceptionInfo368);
            latentStyles1.Append(latentStyleExceptionInfo369);
            latentStyles1.Append(latentStyleExceptionInfo370);
            latentStyles1.Append(latentStyleExceptionInfo371);

            Style style1 = new Style() { Type = StyleValues.Paragraph, StyleId = "a", Default = true };
            StyleName styleName1 = new StyleName() { Val = "Normal" };
            PrimaryStyle primaryStyle1 = new PrimaryStyle();
            Rsid rsid567 = new Rsid() { Val = "009F0B64" };

            StyleParagraphProperties styleParagraphProperties1 = new StyleParagraphProperties();
            SpacingBetweenLines spacingBetweenLines1 = new SpacingBetweenLines() { After = "200", Line = "276", LineRule = LineSpacingRuleValues.Auto };

            styleParagraphProperties1.Append(spacingBetweenLines1);

            StyleRunProperties styleRunProperties1 = new StyleRunProperties();
            FontSize fontSize13 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript13 = new FontSizeComplexScript() { Val = "22" };
            Languages languages67 = new Languages() { EastAsia = "en-US" };

            styleRunProperties1.Append(fontSize13);
            styleRunProperties1.Append(fontSizeComplexScript13);
            styleRunProperties1.Append(languages67);

            style1.Append(styleName1);
            style1.Append(primaryStyle1);
            style1.Append(rsid567);
            style1.Append(styleParagraphProperties1);
            style1.Append(styleRunProperties1);

            Style style2 = new Style() { Type = StyleValues.Paragraph, StyleId = "1" };
            StyleName styleName2 = new StyleName() { Val = "heading 1" };
            BasedOn basedOn1 = new BasedOn() { Val = "a" };
            NextParagraphStyle nextParagraphStyle1 = new NextParagraphStyle() { Val = "a" };
            LinkedStyle linkedStyle1 = new LinkedStyle() { Val = "10" };
            UIPriority uIPriority1 = new UIPriority() { Val = 9 };
            PrimaryStyle primaryStyle2 = new PrimaryStyle();
            Rsid rsid568 = new Rsid() { Val = "000D2237" };

            StyleParagraphProperties styleParagraphProperties2 = new StyleParagraphProperties();
            KeepNext keepNext1 = new KeepNext();
            SpacingBetweenLines spacingBetweenLines2 = new SpacingBetweenLines() { Before = "240", After = "60" };
            OutlineLevel outlineLevel1 = new OutlineLevel() { Val = 0 };

            styleParagraphProperties2.Append(keepNext1);
            styleParagraphProperties2.Append(spacingBetweenLines2);
            styleParagraphProperties2.Append(outlineLevel1);

            StyleRunProperties styleRunProperties2 = new StyleRunProperties();
            RunFonts runFonts255 = new RunFonts() { Ascii = "Cambria", HighAnsi = "Cambria", EastAsia = "Times New Roman" };
            Bold bold18 = new Bold();
            BoldComplexScript boldComplexScript8 = new BoldComplexScript();
            Kern kern1 = new Kern() { Val = (UInt32Value)32U };
            FontSize fontSize14 = new FontSize() { Val = "32" };
            FontSizeComplexScript fontSizeComplexScript14 = new FontSizeComplexScript() { Val = "32" };

            styleRunProperties2.Append(runFonts255);
            styleRunProperties2.Append(bold18);
            styleRunProperties2.Append(boldComplexScript8);
            styleRunProperties2.Append(kern1);
            styleRunProperties2.Append(fontSize14);
            styleRunProperties2.Append(fontSizeComplexScript14);

            style2.Append(styleName2);
            style2.Append(basedOn1);
            style2.Append(nextParagraphStyle1);
            style2.Append(linkedStyle1);
            style2.Append(uIPriority1);
            style2.Append(primaryStyle2);
            style2.Append(rsid568);
            style2.Append(styleParagraphProperties2);
            style2.Append(styleRunProperties2);

            Style style3 = new Style() { Type = StyleValues.Paragraph, StyleId = "2" };
            StyleName styleName3 = new StyleName() { Val = "heading 2" };
            BasedOn basedOn2 = new BasedOn() { Val = "a" };
            NextParagraphStyle nextParagraphStyle2 = new NextParagraphStyle() { Val = "a" };
            LinkedStyle linkedStyle2 = new LinkedStyle() { Val = "20" };
            UIPriority uIPriority2 = new UIPriority() { Val = 9 };
            UnhideWhenUsed unhideWhenUsed1 = new UnhideWhenUsed();
            PrimaryStyle primaryStyle3 = new PrimaryStyle();
            Rsid rsid569 = new Rsid() { Val = "000D2237" };

            StyleParagraphProperties styleParagraphProperties3 = new StyleParagraphProperties();
            KeepNext keepNext2 = new KeepNext();
            SpacingBetweenLines spacingBetweenLines3 = new SpacingBetweenLines() { Before = "240", After = "60" };
            OutlineLevel outlineLevel2 = new OutlineLevel() { Val = 1 };

            styleParagraphProperties3.Append(keepNext2);
            styleParagraphProperties3.Append(spacingBetweenLines3);
            styleParagraphProperties3.Append(outlineLevel2);

            StyleRunProperties styleRunProperties3 = new StyleRunProperties();
            RunFonts runFonts256 = new RunFonts() { Ascii = "Cambria", HighAnsi = "Cambria", EastAsia = "Times New Roman" };
            Bold bold19 = new Bold();
            BoldComplexScript boldComplexScript9 = new BoldComplexScript();
            Italic italic1 = new Italic();
            ItalicComplexScript italicComplexScript1 = new ItalicComplexScript();
            FontSize fontSize15 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript15 = new FontSizeComplexScript() { Val = "28" };

            styleRunProperties3.Append(runFonts256);
            styleRunProperties3.Append(bold19);
            styleRunProperties3.Append(boldComplexScript9);
            styleRunProperties3.Append(italic1);
            styleRunProperties3.Append(italicComplexScript1);
            styleRunProperties3.Append(fontSize15);
            styleRunProperties3.Append(fontSizeComplexScript15);

            style3.Append(styleName3);
            style3.Append(basedOn2);
            style3.Append(nextParagraphStyle2);
            style3.Append(linkedStyle2);
            style3.Append(uIPriority2);
            style3.Append(unhideWhenUsed1);
            style3.Append(primaryStyle3);
            style3.Append(rsid569);
            style3.Append(styleParagraphProperties3);
            style3.Append(styleRunProperties3);

            Style style4 = new Style() { Type = StyleValues.Character, StyleId = "a0", Default = true };
            StyleName styleName4 = new StyleName() { Val = "Default Paragraph Font" };
            UIPriority uIPriority3 = new UIPriority() { Val = 1 };
            SemiHidden semiHidden1 = new SemiHidden();
            UnhideWhenUsed unhideWhenUsed2 = new UnhideWhenUsed();

            style4.Append(styleName4);
            style4.Append(uIPriority3);
            style4.Append(semiHidden1);
            style4.Append(unhideWhenUsed2);

            Style style5 = new Style() { Type = StyleValues.Table, StyleId = "a1", Default = true };
            StyleName styleName5 = new StyleName() { Val = "Normal Table" };
            UIPriority uIPriority4 = new UIPriority() { Val = 99 };
            SemiHidden semiHidden2 = new SemiHidden();
            UnhideWhenUsed unhideWhenUsed3 = new UnhideWhenUsed();

            StyleTableProperties styleTableProperties1 = new StyleTableProperties();
            TableIndentation tableIndentation1 = new TableIndentation() { Width = 0, Type = TableWidthUnitValues.Dxa };

            TableCellMarginDefault tableCellMarginDefault1 = new TableCellMarginDefault();
            TopMargin topMargin1 = new TopMargin() { Width = "0", Type = TableWidthUnitValues.Dxa };
            TableCellLeftMargin tableCellLeftMargin1 = new TableCellLeftMargin() { Width = 108, Type = TableWidthValues.Dxa };
            BottomMargin bottomMargin1 = new BottomMargin() { Width = "0", Type = TableWidthUnitValues.Dxa };
            TableCellRightMargin tableCellRightMargin1 = new TableCellRightMargin() { Width = 108, Type = TableWidthValues.Dxa };

            tableCellMarginDefault1.Append(topMargin1);
            tableCellMarginDefault1.Append(tableCellLeftMargin1);
            tableCellMarginDefault1.Append(bottomMargin1);
            tableCellMarginDefault1.Append(tableCellRightMargin1);

            styleTableProperties1.Append(tableIndentation1);
            styleTableProperties1.Append(tableCellMarginDefault1);

            style5.Append(styleName5);
            style5.Append(uIPriority4);
            style5.Append(semiHidden2);
            style5.Append(unhideWhenUsed3);
            style5.Append(styleTableProperties1);

            Style style6 = new Style() { Type = StyleValues.Numbering, StyleId = "a2", Default = true };
            StyleName styleName6 = new StyleName() { Val = "No List" };
            UIPriority uIPriority5 = new UIPriority() { Val = 99 };
            SemiHidden semiHidden3 = new SemiHidden();
            UnhideWhenUsed unhideWhenUsed4 = new UnhideWhenUsed();

            style6.Append(styleName6);
            style6.Append(uIPriority5);
            style6.Append(semiHidden3);
            style6.Append(unhideWhenUsed4);

            Style style7 = new Style() { Type = StyleValues.Paragraph, StyleId = "a3" };
            StyleName styleName7 = new StyleName() { Val = "Balloon Text" };
            BasedOn basedOn3 = new BasedOn() { Val = "a" };
            LinkedStyle linkedStyle3 = new LinkedStyle() { Val = "a4" };
            UIPriority uIPriority6 = new UIPriority() { Val = 99 };
            SemiHidden semiHidden4 = new SemiHidden();
            UnhideWhenUsed unhideWhenUsed5 = new UnhideWhenUsed();
            Rsid rsid570 = new Rsid() { Val = "00256BCC" };

            StyleParagraphProperties styleParagraphProperties4 = new StyleParagraphProperties();
            SpacingBetweenLines spacingBetweenLines4 = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };

            styleParagraphProperties4.Append(spacingBetweenLines4);

            StyleRunProperties styleRunProperties4 = new StyleRunProperties();
            RunFonts runFonts257 = new RunFonts() { Ascii = "Tahoma", HighAnsi = "Tahoma", ComplexScript = "Tahoma" };
            FontSize fontSize16 = new FontSize() { Val = "16" };
            FontSizeComplexScript fontSizeComplexScript16 = new FontSizeComplexScript() { Val = "16" };

            styleRunProperties4.Append(runFonts257);
            styleRunProperties4.Append(fontSize16);
            styleRunProperties4.Append(fontSizeComplexScript16);

            style7.Append(styleName7);
            style7.Append(basedOn3);
            style7.Append(linkedStyle3);
            style7.Append(uIPriority6);
            style7.Append(semiHidden4);
            style7.Append(unhideWhenUsed5);
            style7.Append(rsid570);
            style7.Append(styleParagraphProperties4);
            style7.Append(styleRunProperties4);

            Style style8 = new Style() { Type = StyleValues.Character, StyleId = "a4", CustomStyle = true };
            StyleName styleName8 = new StyleName() { Val = "Текст выноски Знак" };
            BasedOn basedOn4 = new BasedOn() { Val = "a0" };
            LinkedStyle linkedStyle4 = new LinkedStyle() { Val = "a3" };
            UIPriority uIPriority7 = new UIPriority() { Val = 99 };
            SemiHidden semiHidden5 = new SemiHidden();
            Rsid rsid571 = new Rsid() { Val = "00256BCC" };

            StyleRunProperties styleRunProperties5 = new StyleRunProperties();
            RunFonts runFonts258 = new RunFonts() { Ascii = "Tahoma", HighAnsi = "Tahoma", ComplexScript = "Tahoma" };
            FontSize fontSize17 = new FontSize() { Val = "16" };
            FontSizeComplexScript fontSizeComplexScript17 = new FontSizeComplexScript() { Val = "16" };

            styleRunProperties5.Append(runFonts258);
            styleRunProperties5.Append(fontSize17);
            styleRunProperties5.Append(fontSizeComplexScript17);

            style8.Append(styleName8);
            style8.Append(basedOn4);
            style8.Append(linkedStyle4);
            style8.Append(uIPriority7);
            style8.Append(semiHidden5);
            style8.Append(rsid571);
            style8.Append(styleRunProperties5);

            Style style9 = new Style() { Type = StyleValues.Paragraph, StyleId = "a5" };
            StyleName styleName9 = new StyleName() { Val = "No Spacing" };
            UIPriority uIPriority8 = new UIPriority() { Val = 1 };
            PrimaryStyle primaryStyle4 = new PrimaryStyle();
            Rsid rsid572 = new Rsid() { Val = "000D2237" };

            StyleRunProperties styleRunProperties6 = new StyleRunProperties();
            FontSize fontSize18 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript18 = new FontSizeComplexScript() { Val = "22" };
            Languages languages68 = new Languages() { EastAsia = "en-US" };

            styleRunProperties6.Append(fontSize18);
            styleRunProperties6.Append(fontSizeComplexScript18);
            styleRunProperties6.Append(languages68);

            style9.Append(styleName9);
            style9.Append(uIPriority8);
            style9.Append(primaryStyle4);
            style9.Append(rsid572);
            style9.Append(styleRunProperties6);

            Style style10 = new Style() { Type = StyleValues.Character, StyleId = "10", CustomStyle = true };
            StyleName styleName10 = new StyleName() { Val = "Заголовок 1 Знак" };
            BasedOn basedOn5 = new BasedOn() { Val = "a0" };
            LinkedStyle linkedStyle5 = new LinkedStyle() { Val = "1" };
            UIPriority uIPriority9 = new UIPriority() { Val = 9 };
            Rsid rsid573 = new Rsid() { Val = "000D2237" };

            StyleRunProperties styleRunProperties7 = new StyleRunProperties();
            RunFonts runFonts259 = new RunFonts() { Ascii = "Cambria", HighAnsi = "Cambria", EastAsia = "Times New Roman", ComplexScript = "Times New Roman" };
            Bold bold20 = new Bold();
            BoldComplexScript boldComplexScript10 = new BoldComplexScript();
            Kern kern2 = new Kern() { Val = (UInt32Value)32U };
            FontSize fontSize19 = new FontSize() { Val = "32" };
            FontSizeComplexScript fontSizeComplexScript19 = new FontSizeComplexScript() { Val = "32" };
            Languages languages69 = new Languages() { EastAsia = "en-US" };

            styleRunProperties7.Append(runFonts259);
            styleRunProperties7.Append(bold20);
            styleRunProperties7.Append(boldComplexScript10);
            styleRunProperties7.Append(kern2);
            styleRunProperties7.Append(fontSize19);
            styleRunProperties7.Append(fontSizeComplexScript19);
            styleRunProperties7.Append(languages69);

            style10.Append(styleName10);
            style10.Append(basedOn5);
            style10.Append(linkedStyle5);
            style10.Append(uIPriority9);
            style10.Append(rsid573);
            style10.Append(styleRunProperties7);

            Style style11 = new Style() { Type = StyleValues.Character, StyleId = "20", CustomStyle = true };
            StyleName styleName11 = new StyleName() { Val = "Заголовок 2 Знак" };
            BasedOn basedOn6 = new BasedOn() { Val = "a0" };
            LinkedStyle linkedStyle6 = new LinkedStyle() { Val = "2" };
            UIPriority uIPriority10 = new UIPriority() { Val = 9 };
            Rsid rsid574 = new Rsid() { Val = "000D2237" };

            StyleRunProperties styleRunProperties8 = new StyleRunProperties();
            RunFonts runFonts260 = new RunFonts() { Ascii = "Cambria", HighAnsi = "Cambria", EastAsia = "Times New Roman", ComplexScript = "Times New Roman" };
            Bold bold21 = new Bold();
            BoldComplexScript boldComplexScript11 = new BoldComplexScript();
            Italic italic2 = new Italic();
            ItalicComplexScript italicComplexScript2 = new ItalicComplexScript();
            FontSize fontSize20 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript20 = new FontSizeComplexScript() { Val = "28" };
            Languages languages70 = new Languages() { EastAsia = "en-US" };

            styleRunProperties8.Append(runFonts260);
            styleRunProperties8.Append(bold21);
            styleRunProperties8.Append(boldComplexScript11);
            styleRunProperties8.Append(italic2);
            styleRunProperties8.Append(italicComplexScript2);
            styleRunProperties8.Append(fontSize20);
            styleRunProperties8.Append(fontSizeComplexScript20);
            styleRunProperties8.Append(languages70);

            style11.Append(styleName11);
            style11.Append(basedOn6);
            style11.Append(linkedStyle6);
            style11.Append(uIPriority10);
            style11.Append(rsid574);
            style11.Append(styleRunProperties8);

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

            styleDefinitionsPart1.Styles = styles1;
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
            Ds.DataStoreItem dataStoreItem1 = new Ds.DataStoreItem() { ItemId = "{7BAA5262-02F5-4BEA-B1F0-059CEDA831EA}" };
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

            Font font1 = new Font() { Name = "Calibri" };
            Panose1Number panose1Number1 = new Panose1Number() { Val = "020F0502020204030204" };
            FontCharSet fontCharSet1 = new FontCharSet() { Val = "CC" };
            FontFamily fontFamily1 = new FontFamily() { Val = FontFamilyValues.Swiss };
            Pitch pitch1 = new Pitch() { Val = FontPitchValues.Variable };
            FontSignature fontSignature1 = new FontSignature() { UnicodeSignature0 = "E00002FF", UnicodeSignature1 = "4000ACFF", UnicodeSignature2 = "00000001", UnicodeSignature3 = "00000000", CodePageSignature0 = "0000019F", CodePageSignature1 = "00000000" };

            font1.Append(panose1Number1);
            font1.Append(fontCharSet1);
            font1.Append(fontFamily1);
            font1.Append(pitch1);
            font1.Append(fontSignature1);

            Font font2 = new Font() { Name = "Times New Roman" };
            Panose1Number panose1Number2 = new Panose1Number() { Val = "02020603050405020304" };
            FontCharSet fontCharSet2 = new FontCharSet() { Val = "CC" };
            FontFamily fontFamily2 = new FontFamily() { Val = FontFamilyValues.Roman };
            Pitch pitch2 = new Pitch() { Val = FontPitchValues.Variable };
            FontSignature fontSignature2 = new FontSignature() { UnicodeSignature0 = "E0002AFF", UnicodeSignature1 = "C0007841", UnicodeSignature2 = "00000009", UnicodeSignature3 = "00000000", CodePageSignature0 = "000001FF", CodePageSignature1 = "00000000" };

            font2.Append(panose1Number2);
            font2.Append(fontCharSet2);
            font2.Append(fontFamily2);
            font2.Append(pitch2);
            font2.Append(fontSignature2);

            Font font3 = new Font() { Name = "Cambria" };
            Panose1Number panose1Number3 = new Panose1Number() { Val = "02040503050406030204" };
            FontCharSet fontCharSet3 = new FontCharSet() { Val = "CC" };
            FontFamily fontFamily3 = new FontFamily() { Val = FontFamilyValues.Roman };
            Pitch pitch3 = new Pitch() { Val = FontPitchValues.Variable };
            FontSignature fontSignature3 = new FontSignature() { UnicodeSignature0 = "E00002FF", UnicodeSignature1 = "400004FF", UnicodeSignature2 = "00000000", UnicodeSignature3 = "00000000", CodePageSignature0 = "0000019F", CodePageSignature1 = "00000000" };

            font3.Append(panose1Number3);
            font3.Append(fontCharSet3);
            font3.Append(fontFamily3);
            font3.Append(pitch3);
            font3.Append(fontSignature3);

            Font font4 = new Font() { Name = "Tahoma" };
            Panose1Number panose1Number4 = new Panose1Number() { Val = "020B0604030504040204" };
            FontCharSet fontCharSet4 = new FontCharSet() { Val = "CC" };
            FontFamily fontFamily4 = new FontFamily() { Val = FontFamilyValues.Swiss };
            NotTrueType notTrueType1 = new NotTrueType();
            Pitch pitch4 = new Pitch() { Val = FontPitchValues.Variable };
            FontSignature fontSignature4 = new FontSignature() { UnicodeSignature0 = "00000201", UnicodeSignature1 = "00000000", UnicodeSignature2 = "00000000", UnicodeSignature3 = "00000000", CodePageSignature0 = "00000004", CodePageSignature1 = "00000000" };

            font4.Append(panose1Number4);
            font4.Append(fontCharSet4);
            font4.Append(fontFamily4);
            font4.Append(notTrueType1);
            font4.Append(pitch4);
            font4.Append(fontSignature4);

            Font font5 = new Font() { Name = "Arial" };
            Panose1Number panose1Number5 = new Panose1Number() { Val = "020B0604020202020204" };
            FontCharSet fontCharSet5 = new FontCharSet() { Val = "CC" };
            FontFamily fontFamily5 = new FontFamily() { Val = FontFamilyValues.Swiss };
            Pitch pitch5 = new Pitch() { Val = FontPitchValues.Variable };
            FontSignature fontSignature5 = new FontSignature() { UnicodeSignature0 = "E0002AFF", UnicodeSignature1 = "C0007843", UnicodeSignature2 = "00000009", UnicodeSignature3 = "00000000", CodePageSignature0 = "000001FF", CodePageSignature1 = "00000000" };

            font5.Append(panose1Number5);
            font5.Append(fontCharSet5);
            font5.Append(fontFamily5);
            font5.Append(pitch5);
            font5.Append(fontSignature5);

            fonts1.Append(font1);
            fonts1.Append(font2);
            fonts1.Append(font3);
            fonts1.Append(font4);
            fonts1.Append(font5);

            fontTablePart1.Fonts = fonts1;
        }

        // Generates content of imagePart1.
        private void GenerateImagePart1Content(ImagePart imagePart1)
        {
            System.IO.Stream data = GetBinaryDataStream(imagePart1Data);
            imagePart1.FeedData(data);
            data.Close();
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
            OptimizeForBrowser optimizeForBrowser1 = new OptimizeForBrowser();
            RelyOnVML relyOnVML1 = new RelyOnVML();
            AllowPNG allowPNG1 = new AllowPNG();

            webSettings1.Append(optimizeForBrowser1);
            webSettings1.Append(relyOnVML1);
            webSettings1.Append(allowPNG1);

            webSettingsPart1.WebSettings = webSettings1;
        }

        private void SetPackageProperties(OpenXmlPackage document)
        {
            document.PackageProperties.Creator = "User";
            document.PackageProperties.Title = "";
            document.PackageProperties.Subject = "";
            document.PackageProperties.Keywords = "";
            document.PackageProperties.Revision = "12";
            document.PackageProperties.Created = System.Xml.XmlConvert.ToDateTime("2015-09-14T07:14:00Z", System.Xml.XmlDateTimeSerializationMode.RoundtripKind);
            document.PackageProperties.Modified = System.Xml.XmlConvert.ToDateTime("2015-09-14T11:08:00Z", System.Xml.XmlDateTimeSerializationMode.RoundtripKind);
            document.PackageProperties.LastModifiedBy = "Александр Недопака";
            document.PackageProperties.LastPrinted = System.Xml.XmlConvert.ToDateTime("2015-02-02T07:07:00Z", System.Xml.XmlDateTimeSerializationMode.RoundtripKind);
        }

        #region Binary Data
        private string imagePart1Data = "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";
        private NewDeclaration newDeclaration;

        private System.IO.Stream GetBinaryDataStream(string base64String)
        {
            return new System.IO.MemoryStream(System.Convert.FromBase64String(base64String));
        }

        #endregion

    }
}

