//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

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

namespace logistic
{
    public class Declaration
    {
        private Form1 frm;
        private NewDeclaration declarationFrm;

        public Declaration(Form1 form)
        {
            this.frm = form;
        }

        public Declaration(NewDeclaration form)
        {
            this.declarationFrm = form;
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

            StylesWithEffectsPart stylesWithEffectsPart1 = mainDocumentPart1.AddNewPart<StylesWithEffectsPart>("rId3");
            GenerateStylesWithEffectsPart1Content(stylesWithEffectsPart1);

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
            template1.Text = "Normal.dotm";
            Ap.TotalTime totalTime1 = new Ap.TotalTime();
            totalTime1.Text = "16";
            Ap.Pages pages1 = new Ap.Pages();
            pages1.Text = "1";
            Ap.Words words1 = new Ap.Words();
            words1.Text = "260";
            Ap.Characters characters1 = new Ap.Characters();
            characters1.Text = "2872";
            Ap.Application application1 = new Ap.Application();
            application1.Text = "Microsoft Office Word";
            Ap.DocumentSecurity documentSecurity1 = new Ap.DocumentSecurity();
            documentSecurity1.Text = "0";
            Ap.Lines lines1 = new Ap.Lines();
            lines1.Text = "23";
            Ap.Paragraphs paragraphs1 = new Ap.Paragraphs();
            paragraphs1.Text = "6";
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
            vTLPSTR2.Text = "___________2006 г В______________________________________";

            vTVector2.Append(vTLPSTR2);

            titlesOfParts1.Append(vTVector2);
            Ap.Company company1 = new Ap.Company();
            company1.Text = "Microsoft";
            Ap.LinksUpToDate linksUpToDate1 = new Ap.LinksUpToDate();
            linksUpToDate1.Text = "false";
            Ap.CharactersWithSpaces charactersWithSpaces1 = new Ap.CharactersWithSpaces();
            charactersWithSpaces1.Text = "3126";
            Ap.SharedDocument sharedDocument1 = new Ap.SharedDocument();
            sharedDocument1.Text = "false";
            Ap.HyperlinksChanged hyperlinksChanged1 = new Ap.HyperlinksChanged();
            hyperlinksChanged1.Text = "false";
            Ap.ApplicationVersion applicationVersion1 = new Ap.ApplicationVersion();
            applicationVersion1.Text = "14.0000";

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
            Document document1 = new Document() { MCAttributes = new MarkupCompatibilityAttributes() { Ignorable = "w14 wp14" } };
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
            document1.AddNamespaceDeclaration("wpg", "http://schemas.microsoft.com/office/word/2010/wordprocessingGroup");
            document1.AddNamespaceDeclaration("wpi", "http://schemas.microsoft.com/office/word/2010/wordprocessingInk");
            document1.AddNamespaceDeclaration("wne", "http://schemas.microsoft.com/office/word/2006/wordml");
            document1.AddNamespaceDeclaration("wps", "http://schemas.microsoft.com/office/word/2010/wordprocessingShape");

            Body body1 = new Body();

            Paragraph paragraph1 = new Paragraph() { RsidParagraphMarkRevision = "00793DB6", RsidParagraphAddition = "007C0D8C", RsidParagraphProperties = "00BA3008", RsidRunAdditionDefault = "00BA3008" };

            ParagraphProperties paragraphProperties1 = new ParagraphProperties();
            Justification justification1 = new Justification() { Val = JustificationValues.Center };

            ParagraphMarkRunProperties paragraphMarkRunProperties1 = new ParagraphMarkRunProperties();
            FontSize fontSize1 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript1 = new FontSizeComplexScript() { Val = "22" };

            paragraphMarkRunProperties1.Append(fontSize1);
            paragraphMarkRunProperties1.Append(fontSizeComplexScript1);

            paragraphProperties1.Append(justification1);
            paragraphProperties1.Append(paragraphMarkRunProperties1);

            Run run1 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties1 = new RunProperties();
            FontSize fontSize2 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript2 = new FontSizeComplexScript() { Val = "22" };

            runProperties1.Append(fontSize2);
            runProperties1.Append(fontSizeComplexScript2);
            Text text1 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text1.Text = "                                                                                                                        ";

            run1.Append(runProperties1);
            run1.Append(text1);

            Run run2 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties2 = new RunProperties();
            FontSize fontSize3 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript3 = new FontSizeComplexScript() { Val = "22" };
            Languages languages1 = new Languages() { Val = "uk-UA" };

            runProperties2.Append(fontSize3);
            runProperties2.Append(fontSizeComplexScript3);
            runProperties2.Append(languages1);
            TabChar tabChar1 = new TabChar();

            run2.Append(runProperties2);
            run2.Append(tabChar1);

            Run run3 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "002F61BE" };

            RunProperties runProperties3 = new RunProperties();
            FontSize fontSize4 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript4 = new FontSizeComplexScript() { Val = "22" };
            Languages languages2 = new Languages() { Val = "uk-UA" };

            runProperties3.Append(fontSize4);
            runProperties3.Append(fontSizeComplexScript4);
            runProperties3.Append(languages2);
            Text text2 = new Text();
            text2.Text = "Ф-7.5/7-01";

            run3.Append(runProperties3);
            run3.Append(text2);

            paragraph1.Append(paragraphProperties1);
            paragraph1.Append(run1);
            paragraph1.Append(run2);
            paragraph1.Append(run3);

            Paragraph paragraph2 = new Paragraph() { RsidParagraphMarkRevision = "00E051D4", RsidParagraphAddition = "00692F95", RsidParagraphProperties = "00692F95", RsidRunAdditionDefault = "001C7A11" };

            ParagraphProperties paragraphProperties2 = new ParagraphProperties();

            ParagraphMarkRunProperties paragraphMarkRunProperties2 = new ParagraphMarkRunProperties();
            Italic italic1 = new Italic();
            FontSize fontSize5 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript5 = new FontSizeComplexScript() { Val = "22" };
            Underline underline1 = new Underline() { Val = UnderlineValues.Single };
            Languages languages3 = new Languages() { Val = "uk-UA" };

            paragraphMarkRunProperties2.Append(italic1);
            paragraphMarkRunProperties2.Append(fontSize5);
            paragraphMarkRunProperties2.Append(fontSizeComplexScript5);
            paragraphMarkRunProperties2.Append(underline1);
            paragraphMarkRunProperties2.Append(languages3);

            paragraphProperties2.Append(paragraphMarkRunProperties2);

            Run run4 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties4 = new RunProperties();
            FontSize fontSize6 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript6 = new FontSizeComplexScript() { Val = "22" };

            runProperties4.Append(fontSize6);
            runProperties4.Append(fontSizeComplexScript6);
            Text text3 = new Text();
            text3.Text = "Регистрационный";

            run4.Append(runProperties4);
            run4.Append(text3);

            Run run5 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties5 = new RunProperties();
            FontSize fontSize7 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript7 = new FontSizeComplexScript() { Val = "22" };
            Languages languages4 = new Languages() { Val = "uk-UA" };

            runProperties5.Append(fontSize7);
            runProperties5.Append(fontSizeComplexScript7);
            runProperties5.Append(languages4);
            Text text4 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text4.Text = " ";

            run5.Append(runProperties5);
            run5.Append(text4);

            Run run6 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "00692F95" };

            RunProperties runProperties6 = new RunProperties();
            FontSize fontSize8 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript8 = new FontSizeComplexScript() { Val = "22" };
            Languages languages5 = new Languages() { Val = "uk-UA" };

            runProperties6.Append(fontSize8);
            runProperties6.Append(fontSizeComplexScript8);
            runProperties6.Append(languages5);
            Text text5 = new Text();
            text5.Text = "№";

            run6.Append(runProperties6);
            run6.Append(text5);

            Run run7 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "008855BE" };

            RunProperties runProperties7 = new RunProperties();
            FontSize fontSize9 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript9 = new FontSizeComplexScript() { Val = "22" };
            Languages languages6 = new Languages() { Val = "uk-UA" };

            runProperties7.Append(fontSize9);
            runProperties7.Append(fontSizeComplexScript9);
            runProperties7.Append(languages6);
            Text text6 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text6.Text = " ";

            run7.Append(runProperties7);
            run7.Append(text6);

            Run run8 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "00DD56E3" };

            RunProperties runProperties8 = new RunProperties();
            FontSize fontSize10 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript10 = new FontSizeComplexScript() { Val = "22" };
            Languages languages7 = new Languages() { Val = "uk-UA" };

            runProperties8.Append(fontSize10);
            runProperties8.Append(fontSizeComplexScript10);
            runProperties8.Append(languages7);
            Text text7 = new Text();
            text7.Text = "_________";

            run8.Append(runProperties8);
            run8.Append(text7);

            Run run9 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "00816A83" };

            RunProperties runProperties9 = new RunProperties();
            FontSize fontSize11 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript11 = new FontSizeComplexScript() { Val = "22" };
            Languages languages8 = new Languages() { Val = "uk-UA" };

            runProperties9.Append(fontSize11);
            runProperties9.Append(fontSizeComplexScript11);
            runProperties9.Append(languages8);
            Text text8 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text8.Text = "     ";

            run9.Append(runProperties9);
            run9.Append(text8);

            Run run10 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "00692F95" };

            RunProperties runProperties10 = new RunProperties();
            FontSize fontSize12 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript12 = new FontSizeComplexScript() { Val = "22" };
            Languages languages9 = new Languages() { Val = "uk-UA" };

            runProperties10.Append(fontSize12);
            runProperties10.Append(fontSizeComplexScript12);
            runProperties10.Append(languages9);
            Text text9 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text9.Text = "   ";

            run10.Append(runProperties10);
            run10.Append(text9);

            Run run11 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "00816A83" };

            RunProperties runProperties11 = new RunProperties();
            FontSize fontSize13 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript13 = new FontSizeComplexScript() { Val = "22" };
            Languages languages10 = new Languages() { Val = "uk-UA" };

            runProperties11.Append(fontSize13);
            runProperties11.Append(fontSizeComplexScript13);
            runProperties11.Append(languages10);
            Text text10 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text10.Text = "    ";

            run11.Append(runProperties11);
            run11.Append(text10);

            Run run12 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "00DD56E3" };

            RunProperties runProperties12 = new RunProperties();
            FontSize fontSize14 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript14 = new FontSizeComplexScript() { Val = "22" };
            Languages languages11 = new Languages() { Val = "uk-UA" };

            runProperties12.Append(fontSize14);
            runProperties12.Append(fontSizeComplexScript14);
            runProperties12.Append(languages11);
            Text text11 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text11.Text = "   ";

            run12.Append(runProperties12);
            run12.Append(text11);

            Run run13 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties13 = new RunProperties();
            FontSize fontSize15 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript15 = new FontSizeComplexScript() { Val = "22" };
            Languages languages12 = new Languages() { Val = "uk-UA" };

            runProperties13.Append(fontSize15);
            runProperties13.Append(fontSizeComplexScript15);
            runProperties13.Append(languages12);
            Text text12 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text12.Text = " ";

            run13.Append(runProperties13);
            run13.Append(text12);

            Run run14 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "00BA0D5E" };

            RunProperties runProperties14 = new RunProperties();
            FontSize fontSize16 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript16 = new FontSizeComplexScript() { Val = "22" };

            runProperties14.Append(fontSize16);
            runProperties14.Append(fontSizeComplexScript16);
            Text text13 = new Text();
            text13.Text = "в";

            run14.Append(runProperties14);
            run14.Append(text13);

            Run run15 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "00816A83" };

            RunProperties runProperties15 = new RunProperties();
            FontSize fontSize17 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript17 = new FontSizeComplexScript() { Val = "22" };
            Languages languages13 = new Languages() { Val = "uk-UA" };

            runProperties15.Append(fontSize17);
            runProperties15.Append(fontSizeComplexScript17);
            runProperties15.Append(languages13);
            Text text14 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text14.Text = " ";

            run15.Append(runProperties15);
            run15.Append(text14);

            Run run16 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "00692F95" };

            RunProperties runProperties16 = new RunProperties();
            FontSize fontSize18 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript18 = new FontSizeComplexScript() { Val = "22" };

            runProperties16.Append(fontSize18);
            runProperties16.Append(fontSizeComplexScript18);
            Text text15 = new Text();
            text15.Text = "Черкас";

            run16.Append(runProperties16);
            run16.Append(text15);

            Run run17 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties17 = new RunProperties();
            FontSize fontSize19 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript19 = new FontSizeComplexScript() { Val = "22" };

            runProperties17.Append(fontSize19);
            runProperties17.Append(fontSizeComplexScript19);
            Text text16 = new Text();
            text16.Text = "с";

            run17.Append(runProperties17);
            run17.Append(text16);

            Run run18 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "00692F95" };

            RunProperties runProperties18 = new RunProperties();
            FontSize fontSize20 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript20 = new FontSizeComplexScript() { Val = "22" };

            runProperties18.Append(fontSize20);
            runProperties18.Append(fontSizeComplexScript20);
            Text text17 = new Text();
            text17.Text = "ку";

            run18.Append(runProperties18);
            run18.Append(text17);

            Run run19 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties19 = new RunProperties();
            FontSize fontSize21 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript21 = new FontSizeComplexScript() { Val = "22" };

            runProperties19.Append(fontSize21);
            runProperties19.Append(fontSizeComplexScript21);
            Text text18 = new Text();
            text18.Text = "ю";

            run19.Append(runProperties19);
            run19.Append(text18);

            Run run20 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "00692F95" };

            RunProperties runProperties20 = new RunProperties();
            FontSize fontSize22 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript22 = new FontSizeComplexScript() { Val = "22" };
            Languages languages14 = new Languages() { Val = "uk-UA" };

            runProperties20.Append(fontSize22);
            runProperties20.Append(fontSizeComplexScript22);
            runProperties20.Append(languages14);
            Text text19 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text19.Text = " ";

            run20.Append(runProperties20);
            run20.Append(text19);

            Run run21 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "00692F95" };

            RunProperties runProperties21 = new RunProperties();
            FontSize fontSize23 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript23 = new FontSizeComplexScript() { Val = "22" };

            runProperties21.Append(fontSize23);
            runProperties21.Append(fontSizeComplexScript23);
            Text text20 = new Text();
            text20.Text = "Торгово-пром";

            run21.Append(runProperties21);
            run21.Append(text20);

            Run run22 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties22 = new RunProperties();
            FontSize fontSize24 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript24 = new FontSizeComplexScript() { Val = "22" };

            runProperties22.Append(fontSize24);
            runProperties22.Append(fontSizeComplexScript24);
            Text text21 = new Text();
            text21.Text = "ышленную";

            run22.Append(runProperties22);
            run22.Append(text21);

            Run run23 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "00692F95" };

            RunProperties runProperties23 = new RunProperties();
            FontSize fontSize25 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript25 = new FontSizeComplexScript() { Val = "22" };
            Languages languages15 = new Languages() { Val = "uk-UA" };

            runProperties23.Append(fontSize25);
            runProperties23.Append(fontSizeComplexScript25);
            runProperties23.Append(languages15);
            Text text22 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text22.Text = " палату";

            run23.Append(runProperties23);
            run23.Append(text22);

            paragraph2.Append(paragraphProperties2);
            paragraph2.Append(run4);
            paragraph2.Append(run5);
            paragraph2.Append(run6);
            paragraph2.Append(run7);
            paragraph2.Append(run8);
            paragraph2.Append(run9);
            paragraph2.Append(run10);
            paragraph2.Append(run11);
            paragraph2.Append(run12);
            paragraph2.Append(run13);
            paragraph2.Append(run14);
            paragraph2.Append(run15);
            paragraph2.Append(run16);
            paragraph2.Append(run17);
            paragraph2.Append(run18);
            paragraph2.Append(run19);
            paragraph2.Append(run20);
            paragraph2.Append(run21);
            paragraph2.Append(run22);
            paragraph2.Append(run23);

            Paragraph paragraph3 = new Paragraph() { RsidParagraphMarkRevision = "00E051D4", RsidParagraphAddition = "002C2D29", RsidParagraphProperties = "00BA3008", RsidRunAdditionDefault = "00692F95" };

            ParagraphProperties paragraphProperties3 = new ParagraphProperties();
            ParagraphStyleId paragraphStyleId1 = new ParagraphStyleId() { Val = "a3" };

            Tabs tabs1 = new Tabs();
            TabStop tabStop1 = new TabStop() { Val = TabStopValues.Left, Position = 708 };

            tabs1.Append(tabStop1);

            ParagraphMarkRunProperties paragraphMarkRunProperties3 = new ParagraphMarkRunProperties();
            FontSize fontSize26 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript26 = new FontSizeComplexScript() { Val = "22" };
            Languages languages16 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties3.Append(fontSize26);
            paragraphMarkRunProperties3.Append(fontSizeComplexScript26);
            paragraphMarkRunProperties3.Append(languages16);

            paragraphProperties3.Append(paragraphStyleId1);
            paragraphProperties3.Append(tabs1);
            paragraphProperties3.Append(paragraphMarkRunProperties3);

            Run run24 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties24 = new RunProperties();
            FontSize fontSize27 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript27 = new FontSizeComplexScript() { Val = "22" };

            runProperties24.Append(fontSize27);
            runProperties24.Append(fontSizeComplexScript27);
            Text text23 = new Text();
            text23.Text = "“___”";

            run24.Append(runProperties24);
            run24.Append(text23);

            Run run25 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "00816A83" };

            RunProperties runProperties25 = new RunProperties();
            FontSize fontSize28 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript28 = new FontSizeComplexScript() { Val = "22" };
            Languages languages17 = new Languages() { Val = "ru-RU" };

            runProperties25.Append(fontSize28);
            runProperties25.Append(fontSizeComplexScript28);
            runProperties25.Append(languages17);
            Text text24 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text24.Text = " ";

            run25.Append(runProperties25);
            run25.Append(text24);

            Run run26 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties26 = new RunProperties();
            FontSize fontSize29 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript29 = new FontSizeComplexScript() { Val = "22" };

            runProperties26.Append(fontSize29);
            runProperties26.Append(fontSizeComplexScript29);
            Text text25 = new Text();
            text25.Text = "________________";

            run26.Append(runProperties26);
            run26.Append(text25);

            Run run27 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "00816A83" };

            RunProperties runProperties27 = new RunProperties();
            FontSize fontSize30 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript30 = new FontSizeComplexScript() { Val = "22" };
            Languages languages18 = new Languages() { Val = "ru-RU" };

            runProperties27.Append(fontSize30);
            runProperties27.Append(fontSizeComplexScript30);
            runProperties27.Append(languages18);
            Text text26 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text26.Text = " ";

            run27.Append(runProperties27);
            run27.Append(text26);

            Run run28 = new Run() { RsidRunAddition = "0029344B" };

            RunProperties runProperties28 = new RunProperties();
            FontSize fontSize31 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript31 = new FontSizeComplexScript() { Val = "22" };
            Languages languages19 = new Languages() { Val = "en-US" };

            runProperties28.Append(fontSize31);
            runProperties28.Append(fontSizeComplexScript31);
            runProperties28.Append(languages19);
            Text text27 = new Text();
            text27.Text = frm.contractDate.Value.Year.ToString();

            run28.Append(runProperties28);
            run28.Append(text27);

            Run run29 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "008855BE" };

            RunProperties runProperties29 = new RunProperties();
            FontSize fontSize32 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript32 = new FontSizeComplexScript() { Val = "22" };

            runProperties29.Append(fontSize32);
            runProperties29.Append(fontSizeComplexScript32);
            Text text28 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text28.Text = " ";

            run29.Append(runProperties29);
            run29.Append(text28);

            Run run30 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties30 = new RunProperties();
            FontSize fontSize33 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript33 = new FontSizeComplexScript() { Val = "22" };

            runProperties30.Append(fontSize33);
            runProperties30.Append(fontSizeComplexScript33);
            Text text29 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text29.Text = "р.                                                ";

            run30.Append(runProperties30);
            run30.Append(text29);

            paragraph3.Append(paragraphProperties3);
            paragraph3.Append(run24);
            paragraph3.Append(run25);
            paragraph3.Append(run26);
            paragraph3.Append(run27);
            paragraph3.Append(run28);
            paragraph3.Append(run29);
            paragraph3.Append(run30);

            Paragraph paragraph4 = new Paragraph() { RsidParagraphMarkRevision = "00E051D4", RsidParagraphAddition = "00092ACE", RsidParagraphProperties = "002C2D29", RsidRunAdditionDefault = "00092ACE" };

            ParagraphProperties paragraphProperties4 = new ParagraphProperties();
            AutoSpaceDE autoSpaceDE1 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN1 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent1 = new AdjustRightIndent() { Val = false };
            Justification justification2 = new Justification() { Val = JustificationValues.Center };

            ParagraphMarkRunProperties paragraphMarkRunProperties4 = new ParagraphMarkRunProperties();
            Bold bold1 = new Bold();
            FontSize fontSize34 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript34 = new FontSizeComplexScript() { Val = "22" };

            paragraphMarkRunProperties4.Append(bold1);
            paragraphMarkRunProperties4.Append(fontSize34);
            paragraphMarkRunProperties4.Append(fontSizeComplexScript34);

            paragraphProperties4.Append(autoSpaceDE1);
            paragraphProperties4.Append(autoSpaceDN1);
            paragraphProperties4.Append(adjustRightIndent1);
            paragraphProperties4.Append(justification2);
            paragraphProperties4.Append(paragraphMarkRunProperties4);

            Run run31 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties31 = new RunProperties();
            Bold bold2 = new Bold();
            FontSize fontSize35 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript35 = new FontSizeComplexScript() { Val = "22" };

            runProperties31.Append(bold2);
            runProperties31.Append(fontSize35);
            runProperties31.Append(fontSizeComplexScript35);
            Text text30 = new Text();
            text30.Text = "ЗАЯВКА-ДЕКЛАРАЦИЯ";

            run31.Append(runProperties31);
            run31.Append(text30);

            paragraph4.Append(paragraphProperties4);
            paragraph4.Append(run31);

            Paragraph paragraph5 = new Paragraph() { RsidParagraphMarkRevision = "00E051D4", RsidParagraphAddition = "00632930", RsidParagraphProperties = "00092ACE", RsidRunAdditionDefault = "00632930" };

            ParagraphProperties paragraphProperties5 = new ParagraphProperties();
            AutoSpaceDE autoSpaceDE2 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN2 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent2 = new AdjustRightIndent() { Val = false };

            ParagraphMarkRunProperties paragraphMarkRunProperties5 = new ParagraphMarkRunProperties();
            Bold bold3 = new Bold();
            FontSize fontSize36 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript36 = new FontSizeComplexScript() { Val = "22" };

            paragraphMarkRunProperties5.Append(bold3);
            paragraphMarkRunProperties5.Append(fontSize36);
            paragraphMarkRunProperties5.Append(fontSizeComplexScript36);

            paragraphProperties5.Append(autoSpaceDE2);
            paragraphProperties5.Append(autoSpaceDN2);
            paragraphProperties5.Append(adjustRightIndent2);
            paragraphProperties5.Append(paragraphMarkRunProperties5);

            paragraph5.Append(paragraphProperties5);

            Paragraph paragraph6 = new Paragraph() { RsidParagraphMarkRevision = "00E051D4", RsidParagraphAddition = "00E456A8", RsidParagraphProperties = "00AE2D12", RsidRunAdditionDefault = "00E456A8" };

            ParagraphProperties paragraphProperties6 = new ParagraphProperties();

            ParagraphMarkRunProperties paragraphMarkRunProperties6 = new ParagraphMarkRunProperties();
            FontSize fontSize37 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript37 = new FontSizeComplexScript() { Val = "22" };

            paragraphMarkRunProperties6.Append(fontSize37);
            paragraphMarkRunProperties6.Append(fontSizeComplexScript37);

            paragraphProperties6.Append(paragraphMarkRunProperties6);

            Run run32 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties32 = new RunProperties();
            Italic italic2 = new Italic();
            FontSize fontSize38 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript38 = new FontSizeComplexScript() { Val = "22" };
            Languages languages20 = new Languages() { Val = "uk-UA" };

            runProperties32.Append(italic2);
            runProperties32.Append(fontSize38);
            runProperties32.Append(fontSizeComplexScript38);
            runProperties32.Append(languages20);
            Text text31 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text31.Text = "  ";

            run32.Append(runProperties32);
            run32.Append(text31);

            Run run33 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties33 = new RunProperties();
            FontSize fontSize39 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript39 = new FontSizeComplexScript() { Val = "22" };

            runProperties33.Append(fontSize39);
            runProperties33.Append(fontSizeComplexScript39);
            Text text32 = new Text();
            text32.Text = "Экспортер (наименование, почтовый адрес, для физических лиц – данные паспорта)";

            run33.Append(runProperties33);
            run33.Append(text32);

            paragraph6.Append(paragraphProperties6);
            paragraph6.Append(run32);
            paragraph6.Append(run33);

            Paragraph paragraph7 = new Paragraph() { RsidParagraphMarkRevision = "00E051D4", RsidParagraphAddition = "00E456A8", RsidParagraphProperties = "00AE2D12", RsidRunAdditionDefault = "00E456A8" };

            ParagraphProperties paragraphProperties7 = new ParagraphProperties();

            ParagraphMarkRunProperties paragraphMarkRunProperties7 = new ParagraphMarkRunProperties();
            Bold bold4 = new Bold();
            FontSize fontSize40 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript40 = new FontSizeComplexScript() { Val = "22" };
            Underline underline2 = new Underline() { Val = UnderlineValues.Single };

            paragraphMarkRunProperties7.Append(bold4);
            paragraphMarkRunProperties7.Append(fontSize40);
            paragraphMarkRunProperties7.Append(fontSizeComplexScript40);
            paragraphMarkRunProperties7.Append(underline2);

            paragraphProperties7.Append(paragraphMarkRunProperties7);

            Run run34 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties34 = new RunProperties();
            Bold bold5 = new Bold();
            FontSize fontSize41 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript41 = new FontSizeComplexScript() { Val = "22" };
            Languages languages21 = new Languages() { Val = "uk-UA" };

            runProperties34.Append(bold5);
            runProperties34.Append(fontSize41);
            runProperties34.Append(fontSizeComplexScript41);
            runProperties34.Append(languages21);
            Text text33 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text33.Text = "  ";

            run34.Append(runProperties34);
            run34.Append(text33);

            Run run35 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "0005359F" };

            RunProperties runProperties35 = new RunProperties();
            Bold bold6 = new Bold();
            FontSize fontSize42 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript42 = new FontSizeComplexScript() { Val = "22" };
            Underline underline3 = new Underline() { Val = UnderlineValues.Single };

            runProperties35.Append(bold6);
            runProperties35.Append(fontSize42);
            runProperties35.Append(fontSizeComplexScript42);
            runProperties35.Append(underline3);
            Text text34 = new Text();
            text34.Text = "ООО «";

            run35.Append(runProperties35);
            run35.Append(text34);

            Run run36 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "00D03D18" };

            RunProperties runProperties36 = new RunProperties();
            Bold bold7 = new Bold();
            FontSize fontSize43 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript43 = new FontSizeComplexScript() { Val = "22" };
            Underline underline4 = new Underline() { Val = UnderlineValues.Single };

            runProperties36.Append(bold7);
            runProperties36.Append(fontSize43);
            runProperties36.Append(fontSizeComplexScript43);
            runProperties36.Append(underline4);
            Text text35 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text35.Text = "Разек ";

            run36.Append(runProperties36);
            run36.Append(text35);

            Run run37 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "0005359F" };

            RunProperties runProperties37 = new RunProperties();
            Bold bold8 = new Bold();
            FontSize fontSize44 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript44 = new FontSizeComplexScript() { Val = "22" };
            Underline underline5 = new Underline() { Val = UnderlineValues.Single };

            runProperties37.Append(bold8);
            runProperties37.Append(fontSize44);
            runProperties37.Append(fontSizeComplexScript44);
            runProperties37.Append(underline5);
            Text text36 = new Text();
            text36.Text = "Черкасс";

            run37.Append(runProperties37);
            run37.Append(text36);

            Run run38 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "00D03D18" };

            RunProperties runProperties38 = new RunProperties();
            Bold bold9 = new Bold();
            FontSize fontSize45 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript45 = new FontSizeComplexScript() { Val = "22" };
            Underline underline6 = new Underline() { Val = UnderlineValues.Single };

            runProperties38.Append(bold9);
            runProperties38.Append(fontSize45);
            runProperties38.Append(fontSizeComplexScript45);
            runProperties38.Append(underline6);
            Text text37 = new Text();
            text37.Text = "ы";

            run38.Append(runProperties38);
            run38.Append(text37);

            Run run39 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "0005359F" };

            RunProperties runProperties39 = new RunProperties();
            Bold bold10 = new Bold();
            FontSize fontSize46 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript46 = new FontSizeComplexScript() { Val = "22" };
            Underline underline7 = new Underline() { Val = UnderlineValues.Single };

            runProperties39.Append(bold10);
            runProperties39.Append(fontSize46);
            runProperties39.Append(fontSizeComplexScript46);
            runProperties39.Append(underline7);
            Text text38 = new Text();
            text38.Text = "»";

            run39.Append(runProperties39);
            run39.Append(text38);

            Run run40 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "00D03D18" };

            RunProperties runProperties40 = new RunProperties();
            Bold bold11 = new Bold();
            FontSize fontSize47 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript47 = new FontSizeComplexScript() { Val = "22" };
            Underline underline8 = new Underline() { Val = UnderlineValues.Single };

            runProperties40.Append(bold11);
            runProperties40.Append(fontSize47);
            runProperties40.Append(fontSizeComplexScript47);
            runProperties40.Append(underline8);
            Text text39 = new Text();
            text39.Text = ",";

            run40.Append(runProperties40);
            run40.Append(text39);

            Run run41 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "0005359F" };

            RunProperties runProperties41 = new RunProperties();
            Bold bold12 = new Bold();
            FontSize fontSize48 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript48 = new FontSizeComplexScript() { Val = "22" };
            Underline underline9 = new Underline() { Val = UnderlineValues.Single };

            runProperties41.Append(bold12);
            runProperties41.Append(fontSize48);
            runProperties41.Append(fontSizeComplexScript48);
            runProperties41.Append(underline9);
            Text text40 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text40.Text = " Украина, ";

            run41.Append(runProperties41);
            run41.Append(text40);

            OpenXmlUnknownElement openXmlUnknownElement1 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<w:smartTag w:uri=\"urn:schemas-microsoft-com:office:smarttags\" w:element=\"metricconverter\" xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\"><w:smartTagPr><w:attr w:name=\"ProductID\" w:val=\"18018, г\" /></w:smartTagPr><w:r w:rsidR=\"0005359F\" w:rsidRPr=\"00E051D4\"><w:rPr><w:b /><w:sz w:val=\"22\" /><w:szCs w:val=\"22\" /><w:u w:val=\"single\" /></w:rPr><w:t>180</w:t></w:r><w:r w:rsidR=\"00D03D18\" w:rsidRPr=\"00E051D4\"><w:rPr><w:b /><w:sz w:val=\"22\" /><w:szCs w:val=\"22\" /><w:u w:val=\"single\" /></w:rPr><w:t>18</w:t></w:r><w:r w:rsidR=\"0005359F\" w:rsidRPr=\"00E051D4\"><w:rPr><w:b /><w:sz w:val=\"22\" /><w:szCs w:val=\"22\" /><w:u w:val=\"single\" /></w:rPr><w:t>, г</w:t></w:r></w:smartTag>");

            Run run42 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "0005359F" };

            RunProperties runProperties42 = new RunProperties();
            Bold bold13 = new Bold();
            FontSize fontSize49 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript49 = new FontSizeComplexScript() { Val = "22" };
            Underline underline10 = new Underline() { Val = UnderlineValues.Single };

            runProperties42.Append(bold13);
            runProperties42.Append(fontSize49);
            runProperties42.Append(fontSizeComplexScript49);
            runProperties42.Append(underline10);
            Text text41 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text41.Text = ". Черкассы, ";

            run42.Append(runProperties42);
            run42.Append(text41);

            Run run43 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "00D03D18" };

            RunProperties runProperties43 = new RunProperties();
            Bold bold14 = new Bold();
            FontSize fontSize50 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript50 = new FontSizeComplexScript() { Val = "22" };
            Underline underline11 = new Underline() { Val = UnderlineValues.Single };

            runProperties43.Append(bold14);
            runProperties43.Append(fontSize50);
            runProperties43.Append(fontSizeComplexScript50);
            runProperties43.Append(underline11);
            Text text42 = new Text();
            text42.Text = "просп";

            run43.Append(runProperties43);
            run43.Append(text42);

            Run run44 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "0005359F" };

            RunProperties runProperties44 = new RunProperties();
            Bold bold15 = new Bold();
            FontSize fontSize51 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript51 = new FontSizeComplexScript() { Val = "22" };
            Underline underline12 = new Underline() { Val = UnderlineValues.Single };

            runProperties44.Append(bold15);
            runProperties44.Append(fontSize51);
            runProperties44.Append(fontSizeComplexScript51);
            runProperties44.Append(underline12);
            Text text43 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text43.Text = ". ";

            run44.Append(runProperties44);
            run44.Append(text43);

            Run run45 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "00D03D18" };

            RunProperties runProperties45 = new RunProperties();
            Bold bold16 = new Bold();
            FontSize fontSize52 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript52 = new FontSizeComplexScript() { Val = "22" };
            Underline underline13 = new Underline() { Val = UnderlineValues.Single };

            runProperties45.Append(bold16);
            runProperties45.Append(fontSize52);
            runProperties45.Append(fontSizeComplexScript52);
            runProperties45.Append(underline13);
            Text text44 = new Text();
            text44.Text = "Химиков";

            run45.Append(runProperties45);
            run45.Append(text44);

            Run run46 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "0005359F" };

            RunProperties runProperties46 = new RunProperties();
            Bold bold17 = new Bold();
            FontSize fontSize53 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript53 = new FontSizeComplexScript() { Val = "22" };
            Underline underline14 = new Underline() { Val = UnderlineValues.Single };

            runProperties46.Append(bold17);
            runProperties46.Append(fontSize53);
            runProperties46.Append(fontSizeComplexScript53);
            runProperties46.Append(underline14);
            Text text45 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text45.Text = ", ";

            run46.Append(runProperties46);
            run46.Append(text45);

            Run run47 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "00D03D18" };

            RunProperties runProperties47 = new RunProperties();
            Bold bold18 = new Bold();
            FontSize fontSize54 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript54 = new FontSizeComplexScript() { Val = "22" };
            Underline underline15 = new Underline() { Val = UnderlineValues.Single };

            runProperties47.Append(bold18);
            runProperties47.Append(fontSize54);
            runProperties47.Append(fontSizeComplexScript54);
            runProperties47.Append(underline15);
            Text text46 = new Text();
            text46.Text = "74";

            run47.Append(runProperties47);
            run47.Append(text46);

            paragraph7.Append(paragraphProperties7);
            paragraph7.Append(run34);
            paragraph7.Append(run35);
            paragraph7.Append(run36);
            paragraph7.Append(run37);
            paragraph7.Append(run38);
            paragraph7.Append(run39);
            paragraph7.Append(run40);
            paragraph7.Append(run41);
            paragraph7.Append(openXmlUnknownElement1);
            paragraph7.Append(run42);
            paragraph7.Append(run43);
            paragraph7.Append(run44);
            paragraph7.Append(run45);
            paragraph7.Append(run46);
            paragraph7.Append(run47);

            Paragraph paragraph8 = new Paragraph() { RsidParagraphMarkRevision = "00E051D4", RsidParagraphAddition = "00E456A8", RsidParagraphProperties = "00AE2D12", RsidRunAdditionDefault = "00E456A8" };

            ParagraphProperties paragraphProperties8 = new ParagraphProperties();

            ParagraphMarkRunProperties paragraphMarkRunProperties8 = new ParagraphMarkRunProperties();
            FontSize fontSize55 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript55 = new FontSizeComplexScript() { Val = "22" };

            paragraphMarkRunProperties8.Append(fontSize55);
            paragraphMarkRunProperties8.Append(fontSizeComplexScript55);

            paragraphProperties8.Append(paragraphMarkRunProperties8);

            paragraph8.Append(paragraphProperties8);

            Paragraph paragraph9 = new Paragraph() { RsidParagraphMarkRevision = "00E051D4", RsidParagraphAddition = "00E456A8", RsidParagraphProperties = "00AE2D12", RsidRunAdditionDefault = "00E456A8" };

            ParagraphProperties paragraphProperties9 = new ParagraphProperties();

            ParagraphMarkRunProperties paragraphMarkRunProperties9 = new ParagraphMarkRunProperties();
            FontSize fontSize56 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript56 = new FontSizeComplexScript() { Val = "22" };

            paragraphMarkRunProperties9.Append(fontSize56);
            paragraphMarkRunProperties9.Append(fontSizeComplexScript56);

            paragraphProperties9.Append(paragraphMarkRunProperties9);

            Run run48 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties48 = new RunProperties();
            FontSize fontSize57 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript57 = new FontSizeComplexScript() { Val = "22" };

            runProperties48.Append(fontSize57);
            runProperties48.Append(fontSizeComplexScript57);
            Text text47 = new Text();
            text47.Text = "Грузоотправитель (наименование, почтовый адрес, для физических лиц – данные паспорта)";

            run48.Append(runProperties48);
            run48.Append(text47);

            paragraph9.Append(paragraphProperties9);
            paragraph9.Append(run48);

            Paragraph paragraph10 = new Paragraph() { RsidParagraphMarkRevision = "00E051D4", RsidParagraphAddition = "00E81903", RsidParagraphProperties = "00AE2D12", RsidRunAdditionDefault = "0005359F" };

            ParagraphProperties paragraphProperties10 = new ParagraphProperties();

            ParagraphMarkRunProperties paragraphMarkRunProperties10 = new ParagraphMarkRunProperties();
            Bold bold19 = new Bold();
            FontSize fontSize58 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript58 = new FontSizeComplexScript() { Val = "22" };
            Languages languages22 = new Languages() { Val = "uk-UA" };

            paragraphMarkRunProperties10.Append(bold19);
            paragraphMarkRunProperties10.Append(fontSize58);
            paragraphMarkRunProperties10.Append(fontSizeComplexScript58);
            paragraphMarkRunProperties10.Append(languages22);

            paragraphProperties10.Append(paragraphMarkRunProperties10);

            Run run49 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties49 = new RunProperties();
            FontSize fontSize59 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript59 = new FontSizeComplexScript() { Val = "22" };
            Languages languages23 = new Languages() { Val = "uk-UA" };

            runProperties49.Append(fontSize59);
            runProperties49.Append(fontSizeComplexScript59);
            runProperties49.Append(languages23);
            Text text48 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text48.Text = "  ";

            run49.Append(runProperties49);
            run49.Append(text48);

            Run run50 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "00D03D18" };

            RunProperties runProperties50 = new RunProperties();
            Bold bold20 = new Bold();
            FontSize fontSize60 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript60 = new FontSizeComplexScript() { Val = "22" };
            Underline underline16 = new Underline() { Val = UnderlineValues.Single };

            runProperties50.Append(bold20);
            runProperties50.Append(fontSize60);
            runProperties50.Append(fontSizeComplexScript60);
            runProperties50.Append(underline16);
            Text text49 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text49.Text = "ООО «Разек Черкассы», Украина, ";

            run50.Append(runProperties50);
            run50.Append(text49);

            OpenXmlUnknownElement openXmlUnknownElement2 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<w:smartTag w:uri=\"urn:schemas-microsoft-com:office:smarttags\" w:element=\"metricconverter\" xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\"><w:smartTagPr><w:attr w:name=\"ProductID\" w:val=\"18018, г\" /></w:smartTagPr><w:r w:rsidR=\"00D03D18\" w:rsidRPr=\"00E051D4\"><w:rPr><w:b /><w:sz w:val=\"22\" /><w:szCs w:val=\"22\" /><w:u w:val=\"single\" /></w:rPr><w:t>18018, г</w:t></w:r></w:smartTag>");

            Run run51 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "00D03D18" };

            RunProperties runProperties51 = new RunProperties();
            Bold bold21 = new Bold();
            FontSize fontSize61 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript61 = new FontSizeComplexScript() { Val = "22" };
            Underline underline17 = new Underline() { Val = UnderlineValues.Single };

            runProperties51.Append(bold21);
            runProperties51.Append(fontSize61);
            runProperties51.Append(fontSizeComplexScript61);
            runProperties51.Append(underline17);
            Text text50 = new Text();
            text50.Text = ". Черкассы, просп. Химиков, 74";

            run51.Append(runProperties51);
            run51.Append(text50);

            Run run52 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "00632930" };

            RunProperties runProperties52 = new RunProperties();
            FontSize fontSize62 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript62 = new FontSizeComplexScript() { Val = "22" };

            runProperties52.Append(fontSize62);
            runProperties52.Append(fontSizeComplexScript62);
            Text text51 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text51.Text = "          ";

            run52.Append(runProperties52);
            run52.Append(text51);

            paragraph10.Append(paragraphProperties10);
            paragraph10.Append(run49);
            paragraph10.Append(run50);
            paragraph10.Append(openXmlUnknownElement2);
            paragraph10.Append(run51);
            paragraph10.Append(run52);

            Paragraph paragraph11 = new Paragraph() { RsidParagraphMarkRevision = "00E051D4", RsidParagraphAddition = "00092ACE", RsidParagraphProperties = "00092ACE", RsidRunAdditionDefault = "00092ACE" };

            ParagraphProperties paragraphProperties11 = new ParagraphProperties();
            AutoSpaceDE autoSpaceDE3 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN3 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent3 = new AdjustRightIndent() { Val = false };

            ParagraphMarkRunProperties paragraphMarkRunProperties11 = new ParagraphMarkRunProperties();
            FontSize fontSize63 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript63 = new FontSizeComplexScript() { Val = "22" };

            paragraphMarkRunProperties11.Append(fontSize63);
            paragraphMarkRunProperties11.Append(fontSizeComplexScript63);

            paragraphProperties11.Append(autoSpaceDE3);
            paragraphProperties11.Append(autoSpaceDN3);
            paragraphProperties11.Append(adjustRightIndent3);
            paragraphProperties11.Append(paragraphMarkRunProperties11);

            Run run53 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties53 = new RunProperties();
            FontSize fontSize64 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript64 = new FontSizeComplexScript() { Val = "22" };

            runProperties53.Append(fontSize64);
            runProperties53.Append(fontSizeComplexScript64);
            Text text52 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text52.Text = "Экспортер/грузоотправитель просит выдать ";

            run53.Append(runProperties53);
            run53.Append(text52);

            Run run54 = new Run() { RsidRunProperties = "008E7ECF" };

            RunProperties runProperties54 = new RunProperties();
            FontSize fontSize65 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript65 = new FontSizeComplexScript() { Val = "22" };

            runProperties54.Append(fontSize65);
            runProperties54.Append(fontSizeComplexScript65);
            Text text53 = new Text();
            text53.Text = "сертификат";

            run54.Append(runProperties54);
            run54.Append(text53);

            Run run55 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "00070A9B" };

            RunProperties runProperties55 = new RunProperties();
            FontSize fontSize66 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript66 = new FontSizeComplexScript() { Val = "22" };
            Languages languages24 = new Languages() { Val = "uk-UA" };

            runProperties55.Append(fontSize66);
            runProperties55.Append(fontSizeComplexScript66);
            runProperties55.Append(languages24);
            Text text54 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text54.Text = " ";

            run55.Append(runProperties55);
            run55.Append(text54);

            Run run56 = new Run() { RsidRunProperties = "00EA33FB" };

            RunProperties runProperties56 = new RunProperties();
            FontSize fontSize67 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript67 = new FontSizeComplexScript() { Val = "22" };

            runProperties56.Append(fontSize67);
            runProperties56.Append(fontSizeComplexScript67);
            Text text55 = new Text();
            text55.Text = "(";

            run56.Append(runProperties56);
            run56.Append(text55);

            Run run57 = new Run() { RsidRunProperties = "0025754E", RsidRunAddition = "00701FB6" };

            RunProperties runProperties57 = new RunProperties();
            FontSize fontSize68 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript68 = new FontSizeComplexScript() { Val = "22" };

            runProperties57.Append(fontSize68);
            runProperties57.Append(fontSizeComplexScript68);
            Text text56 = new Text();
            text56.Text = "заключение";

            run57.Append(runProperties57);
            run57.Append(text56);

            Run run58 = new Run() { RsidRunProperties = "00EA33FB" };

            RunProperties runProperties58 = new RunProperties();
            FontSize fontSize69 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript69 = new FontSizeComplexScript() { Val = "22" };

            runProperties58.Append(fontSize69);
            runProperties58.Append(fontSizeComplexScript69);
            Text text57 = new Text();
            text57.Text = ")";

            run58.Append(runProperties58);
            run58.Append(text57);

            Run run59 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties59 = new RunProperties();
            FontSize fontSize70 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript70 = new FontSizeComplexScript() { Val = "22" };

            runProperties59.Append(fontSize70);
            runProperties59.Append(fontSizeComplexScript70);
            Text text58 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text58.Text = " происхождения ";

            run59.Append(runProperties59);
            run59.Append(text58);
            ProofError proofError1 = new ProofError() { Type = ProofingErrorValues.GrammarStart };

            Run run60 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties60 = new RunProperties();
            FontSize fontSize71 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript71 = new FontSizeComplexScript() { Val = "22" };

            runProperties60.Append(fontSize71);
            runProperties60.Append(fontSizeComplexScript71);
            Text text59 = new Text();
            text59.Text = "на";

            run60.Append(runProperties60);
            run60.Append(text59);
            ProofError proofError2 = new ProofError() { Type = ProofingErrorValues.GrammarEnd };

            Run run61 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "001D4268" };

            RunProperties runProperties61 = new RunProperties();
            FontSize fontSize72 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript72 = new FontSizeComplexScript() { Val = "22" };

            runProperties61.Append(fontSize72);
            runProperties61.Append(fontSizeComplexScript72);
            Text text60 = new Text();
            text60.Text = ":";

            run61.Append(runProperties61);
            run61.Append(text60);

            paragraph11.Append(paragraphProperties11);
            paragraph11.Append(run53);
            paragraph11.Append(run54);
            paragraph11.Append(run55);
            paragraph11.Append(run56);
            paragraph11.Append(run57);
            paragraph11.Append(run58);
            paragraph11.Append(run59);
            paragraph11.Append(proofError1);
            paragraph11.Append(run60);
            paragraph11.Append(proofError2);
            paragraph11.Append(run61);

            Paragraph paragraph12 = new Paragraph() { RsidParagraphMarkRevision = "00E051D4", RsidParagraphAddition = "00BE5A2A", RsidParagraphProperties = "00092ACE", RsidRunAdditionDefault = "00BE5A2A" };

            ParagraphProperties paragraphProperties12 = new ParagraphProperties();
            AutoSpaceDE autoSpaceDE4 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN4 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent4 = new AdjustRightIndent() { Val = false };

            ParagraphMarkRunProperties paragraphMarkRunProperties12 = new ParagraphMarkRunProperties();
            FontSize fontSize73 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript73 = new FontSizeComplexScript() { Val = "22" };

            paragraphMarkRunProperties12.Append(fontSize73);
            paragraphMarkRunProperties12.Append(fontSizeComplexScript73);

            paragraphProperties12.Append(autoSpaceDE4);
            paragraphProperties12.Append(autoSpaceDN4);
            paragraphProperties12.Append(adjustRightIndent4);
            paragraphProperties12.Append(paragraphMarkRunProperties12);

            paragraph12.Append(paragraphProperties12);

            Table table1 = new Table();

            TableProperties tableProperties1 = new TableProperties();
            TableWidth tableWidth1 = new TableWidth() { Width = "10080", Type = TableWidthUnitValues.Dxa };
            TableIndentation tableIndentation1 = new TableIndentation() { Width = 108, Type = TableWidthUnitValues.Dxa };

            TableBorders tableBorders1 = new TableBorders();
            TopBorder topBorder1 = new TopBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            LeftBorder leftBorder1 = new LeftBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder1 = new BottomBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            RightBorder rightBorder1 = new RightBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            InsideHorizontalBorder insideHorizontalBorder1 = new InsideHorizontalBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            InsideVerticalBorder insideVerticalBorder1 = new InsideVerticalBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };

            tableBorders1.Append(topBorder1);
            tableBorders1.Append(leftBorder1);
            tableBorders1.Append(bottomBorder1);
            tableBorders1.Append(rightBorder1);
            tableBorders1.Append(insideHorizontalBorder1);
            tableBorders1.Append(insideVerticalBorder1);
            TableLook tableLook1 = new TableLook() { Val = "0000" };

            tableProperties1.Append(tableWidth1);
            tableProperties1.Append(tableIndentation1);
            tableProperties1.Append(tableBorders1);
            tableProperties1.Append(tableLook1);

            TableGrid tableGrid1 = new TableGrid();
            GridColumn gridColumn1 = new GridColumn() { Width = "5387" };
            GridColumn gridColumn2 = new GridColumn() { Width = "1993" };
            GridColumn gridColumn3 = new GridColumn() { Width = "2700" };

            tableGrid1.Append(gridColumn1);
            tableGrid1.Append(gridColumn2);
            tableGrid1.Append(gridColumn3);

            TableRow tableRow1 = new TableRow() { RsidTableRowMarkRevision = "00E051D4", RsidTableRowAddition = "00632930", RsidTableRowProperties = "00FC3B8F" };

            TableRowProperties tableRowProperties1 = new TableRowProperties();
            TableRowHeight tableRowHeight1 = new TableRowHeight() { Val = (UInt32Value)788U };

            tableRowProperties1.Append(tableRowHeight1);

            TableCell tableCell1 = new TableCell();

            TableCellProperties tableCellProperties1 = new TableCellProperties();
            TableCellWidth tableCellWidth1 = new TableCellWidth() { Width = "5387", Type = TableWidthUnitValues.Dxa };
            TableCellVerticalAlignment tableCellVerticalAlignment1 = new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center };

            tableCellProperties1.Append(tableCellWidth1);
            tableCellProperties1.Append(tableCellVerticalAlignment1);

            Paragraph paragraph13 = new Paragraph() { RsidParagraphMarkRevision = "00E051D4", RsidParagraphAddition = "00632930", RsidParagraphProperties = "00DC5409", RsidRunAdditionDefault = "00F17A99" };

            ParagraphProperties paragraphProperties13 = new ParagraphProperties();
            AutoSpaceDE autoSpaceDE5 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN5 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent5 = new AdjustRightIndent() { Val = false };
            Justification justification3 = new Justification() { Val = JustificationValues.Center };

            ParagraphMarkRunProperties paragraphMarkRunProperties13 = new ParagraphMarkRunProperties();
            Bold bold22 = new Bold();
            FontSize fontSize74 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript74 = new FontSizeComplexScript() { Val = "22" };
            Languages languages25 = new Languages() { Val = "uk-UA" };

            paragraphMarkRunProperties13.Append(bold22);
            paragraphMarkRunProperties13.Append(fontSize74);
            paragraphMarkRunProperties13.Append(fontSizeComplexScript74);
            paragraphMarkRunProperties13.Append(languages25);

            paragraphProperties13.Append(autoSpaceDE5);
            paragraphProperties13.Append(autoSpaceDN5);
            paragraphProperties13.Append(adjustRightIndent5);
            paragraphProperties13.Append(justification3);
            paragraphProperties13.Append(paragraphMarkRunProperties13);

            Run run62 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties62 = new RunProperties();
            Bold bold23 = new Bold();
            FontSize fontSize75 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript75 = new FontSizeComplexScript() { Val = "22" };

            runProperties62.Append(bold23);
            runProperties62.Append(fontSize75);
            runProperties62.Append(fontSizeComplexScript75);
            Text text61 = new Text();
            text61.Text = "Наименование товара";

            run62.Append(runProperties62);
            run62.Append(text61);

            paragraph13.Append(paragraphProperties13);
            paragraph13.Append(run62);

            tableCell1.Append(tableCellProperties1);
            tableCell1.Append(paragraph13);

            TableCell tableCell2 = new TableCell();

            TableCellProperties tableCellProperties2 = new TableCellProperties();
            TableCellWidth tableCellWidth2 = new TableCellWidth() { Width = "1993", Type = TableWidthUnitValues.Dxa };
            TableCellVerticalAlignment tableCellVerticalAlignment2 = new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center };

            tableCellProperties2.Append(tableCellWidth2);
            tableCellProperties2.Append(tableCellVerticalAlignment2);

            Paragraph paragraph14 = new Paragraph() { RsidParagraphMarkRevision = "00E051D4", RsidParagraphAddition = "00632930", RsidParagraphProperties = "00BA2AE9", RsidRunAdditionDefault = "00F17A99" };

            ParagraphProperties paragraphProperties14 = new ParagraphProperties();
            AutoSpaceDE autoSpaceDE6 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN6 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent6 = new AdjustRightIndent() { Val = false };
            Justification justification4 = new Justification() { Val = JustificationValues.Center };

            ParagraphMarkRunProperties paragraphMarkRunProperties14 = new ParagraphMarkRunProperties();
            Bold bold24 = new Bold();
            FontSize fontSize76 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript76 = new FontSizeComplexScript() { Val = "22" };

            paragraphMarkRunProperties14.Append(bold24);
            paragraphMarkRunProperties14.Append(fontSize76);
            paragraphMarkRunProperties14.Append(fontSizeComplexScript76);

            paragraphProperties14.Append(autoSpaceDE6);
            paragraphProperties14.Append(autoSpaceDN6);
            paragraphProperties14.Append(adjustRightIndent6);
            paragraphProperties14.Append(justification4);
            paragraphProperties14.Append(paragraphMarkRunProperties14);

            Run run63 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties63 = new RunProperties();
            Bold bold25 = new Bold();
            FontSize fontSize77 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript77 = new FontSizeComplexScript() { Val = "22" };

            runProperties63.Append(bold25);
            runProperties63.Append(fontSize77);
            runProperties63.Append(fontSizeComplexScript77);
            Text text62 = new Text();
            text62.Text = "Код товара";

            run63.Append(runProperties63);
            run63.Append(text62);

            paragraph14.Append(paragraphProperties14);
            paragraph14.Append(run63);

            tableCell2.Append(tableCellProperties2);
            tableCell2.Append(paragraph14);

            TableCell tableCell3 = new TableCell();

            TableCellProperties tableCellProperties3 = new TableCellProperties();
            TableCellWidth tableCellWidth3 = new TableCellWidth() { Width = "2700", Type = TableWidthUnitValues.Dxa };
            TableCellVerticalAlignment tableCellVerticalAlignment3 = new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center };

            tableCellProperties3.Append(tableCellWidth3);
            tableCellProperties3.Append(tableCellVerticalAlignment3);

            Paragraph paragraph15 = new Paragraph() { RsidParagraphMarkRevision = "00E051D4", RsidParagraphAddition = "00632930", RsidParagraphProperties = "00DC5409", RsidRunAdditionDefault = "00F17A99" };

            ParagraphProperties paragraphProperties15 = new ParagraphProperties();
            AutoSpaceDE autoSpaceDE7 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN7 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent7 = new AdjustRightIndent() { Val = false };
            Justification justification5 = new Justification() { Val = JustificationValues.Center };

            ParagraphMarkRunProperties paragraphMarkRunProperties15 = new ParagraphMarkRunProperties();
            Bold bold26 = new Bold();
            FontSize fontSize78 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript78 = new FontSizeComplexScript() { Val = "22" };

            paragraphMarkRunProperties15.Append(bold26);
            paragraphMarkRunProperties15.Append(fontSize78);
            paragraphMarkRunProperties15.Append(fontSizeComplexScript78);

            paragraphProperties15.Append(autoSpaceDE7);
            paragraphProperties15.Append(autoSpaceDN7);
            paragraphProperties15.Append(adjustRightIndent7);
            paragraphProperties15.Append(justification5);
            paragraphProperties15.Append(paragraphMarkRunProperties15);

            Run run64 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties64 = new RunProperties();
            Bold bold27 = new Bold();
            FontSize fontSize79 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript79 = new FontSizeComplexScript() { Val = "22" };

            runProperties64.Append(bold27);
            runProperties64.Append(fontSize79);
            runProperties64.Append(fontSizeComplexScript79);
            Text text63 = new Text();
            text63.Text = "Уд";

            run64.Append(runProperties64);
            run64.Append(text63);

            Run run65 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "00070A9B" };

            RunProperties runProperties65 = new RunProperties();
            Bold bold28 = new Bold();
            FontSize fontSize80 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript80 = new FontSizeComplexScript() { Val = "22" };

            runProperties65.Append(bold28);
            runProperties65.Append(fontSize80);
            runProperties65.Append(fontSizeComplexScript80);
            Text text64 = new Text();
            text64.Text = "ельный";

            run65.Append(runProperties65);
            run65.Append(text64);

            Run run66 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "002C2D29" };

            RunProperties runProperties66 = new RunProperties();
            Bold bold29 = new Bold();
            FontSize fontSize81 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript81 = new FontSizeComplexScript() { Val = "22" };

            runProperties66.Append(bold29);
            runProperties66.Append(fontSize81);
            runProperties66.Append(fontSizeComplexScript81);
            Text text65 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text65.Text = " ";

            run66.Append(runProperties66);
            run66.Append(text65);

            Run run67 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties67 = new RunProperties();
            Bold bold30 = new Bold();
            FontSize fontSize82 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript82 = new FontSizeComplexScript() { Val = "22" };

            runProperties67.Append(bold30);
            runProperties67.Append(fontSize82);
            runProperties67.Append(fontSizeComplexScript82);
            Text text66 = new Text();
            text66.Text = "вес имп";

            run67.Append(runProperties67);
            run67.Append(text66);

            Run run68 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "00070A9B" };

            RunProperties runProperties68 = new RunProperties();
            Bold bold31 = new Bold();
            FontSize fontSize83 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript83 = new FontSizeComplexScript() { Val = "22" };

            runProperties68.Append(bold31);
            runProperties68.Append(fontSize83);
            runProperties68.Append(fontSizeComplexScript83);
            Text text67 = new Text();
            text67.Text = "ортного";

            run68.Append(runProperties68);
            run68.Append(text67);

            Run run69 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties69 = new RunProperties();
            Bold bold32 = new Bold();
            FontSize fontSize84 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript84 = new FontSizeComplexScript() { Val = "22" };

            runProperties69.Append(bold32);
            runProperties69.Append(fontSize84);
            runProperties69.Append(fontSizeComplexScript84);
            Text text68 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text68.Text = " сырья в стоимости товара";

            run69.Append(runProperties69);
            run69.Append(text68);

            Run run70 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "00070A9B" };

            RunProperties runProperties70 = new RunProperties();
            Bold bold33 = new Bold();
            FontSize fontSize85 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript85 = new FontSizeComplexScript() { Val = "22" };

            runProperties70.Append(bold33);
            runProperties70.Append(fontSize85);
            runProperties70.Append(fontSizeComplexScript85);
            Text text69 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text69.Text = ", ";

            run70.Append(runProperties70);
            run70.Append(text69);

            Run run71 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties71 = new RunProperties();
            Bold bold34 = new Bold();
            FontSize fontSize86 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript86 = new FontSizeComplexScript() { Val = "22" };

            runProperties71.Append(bold34);
            runProperties71.Append(fontSize86);
            runProperties71.Append(fontSizeComplexScript86);
            Text text70 = new Text();
            text70.Text = "%";

            run71.Append(runProperties71);
            run71.Append(text70);

            paragraph15.Append(paragraphProperties15);
            paragraph15.Append(run64);
            paragraph15.Append(run65);
            paragraph15.Append(run66);
            paragraph15.Append(run67);
            paragraph15.Append(run68);
            paragraph15.Append(run69);
            paragraph15.Append(run70);
            paragraph15.Append(run71);

            tableCell3.Append(tableCellProperties3);
            tableCell3.Append(paragraph15);

            tableRow1.Append(tableRowProperties1);
            tableRow1.Append(tableCell1);
            tableRow1.Append(tableCell2);
            tableRow1.Append(tableCell3);

            TableRow tableRow2 = new TableRow() { RsidTableRowMarkRevision = "00E051D4", RsidTableRowAddition = "00151B89", RsidTableRowProperties = "0007106F" };

            TableRowProperties tableRowProperties2 = new TableRowProperties();
            TableRowHeight tableRowHeight2 = new TableRowHeight() { Val = (UInt32Value)255U };

            tableRowProperties2.Append(tableRowHeight2);

            TableCell tableCell4 = new TableCell();

            TableCellProperties tableCellProperties4 = new TableCellProperties();
            TableCellWidth tableCellWidth4 = new TableCellWidth() { Width = "5387", Type = TableWidthUnitValues.Dxa };

            tableCellProperties4.Append(tableCellWidth4);

            Paragraph paragraph16 = new Paragraph() { RsidParagraphAddition = "00151B89", RsidRunAdditionDefault = "00151B89" };

            ParagraphProperties paragraphProperties16 = new ParagraphProperties();
            ParagraphStyleId paragraphStyleId2 = new ParagraphStyleId() { Val = "a6" };
            Justification justification6 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties16 = new ParagraphMarkRunProperties();
            RunFonts runFonts1 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Bold bold35 = new Bold();
            FontSize fontSize87 = new FontSize() { Val = "24" };
            FontSizeComplexScript fontSizeComplexScript87 = new FontSizeComplexScript() { Val = "24" };
            Languages languages26 = new Languages() { Val = "en-US" };

            paragraphMarkRunProperties16.Append(runFonts1);
            paragraphMarkRunProperties16.Append(bold35);
            paragraphMarkRunProperties16.Append(fontSize87);
            paragraphMarkRunProperties16.Append(fontSizeComplexScript87);
            paragraphMarkRunProperties16.Append(languages26);

            paragraphProperties16.Append(paragraphStyleId2);
            paragraphProperties16.Append(justification6);
            paragraphProperties16.Append(paragraphMarkRunProperties16);
            ProofError proofError3 = new ProofError() { Type = ProofingErrorValues.SpellStart };

            Run run72 = new Run();

            RunProperties runProperties72 = new RunProperties();
            RunFonts runFonts2 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize88 = new FontSize() { Val = "24" };
            FontSizeComplexScript fontSizeComplexScript88 = new FontSizeComplexScript() { Val = "24" };
            Languages languages27 = new Languages() { Val = "en-US" };

            runProperties72.Append(runFonts2);
            runProperties72.Append(fontSize88);
            runProperties72.Append(fontSizeComplexScript88);
            runProperties72.Append(languages27);
            Text text71 = new Text();
            text71.Text = "ProductName";

            run72.Append(runProperties72);
            run72.Append(text71);
            ProofError proofError4 = new ProofError() { Type = ProofingErrorValues.SpellEnd };

            paragraph16.Append(paragraphProperties16);
            paragraph16.Append(proofError3);
            paragraph16.Append(run72);
            paragraph16.Append(proofError4);

            tableCell4.Append(tableCellProperties4);
            tableCell4.Append(paragraph16);

            TableCell tableCell5 = new TableCell();

            TableCellProperties tableCellProperties5 = new TableCellProperties();
            TableCellWidth tableCellWidth5 = new TableCellWidth() { Width = "1993", Type = TableWidthUnitValues.Dxa };
            TableCellVerticalAlignment tableCellVerticalAlignment4 = new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center };

            tableCellProperties5.Append(tableCellWidth5);
            tableCellProperties5.Append(tableCellVerticalAlignment4);

            Paragraph paragraph17 = new Paragraph() { RsidParagraphAddition = "00151B89", RsidRunAdditionDefault = "00151B89" };

            ParagraphProperties paragraphProperties17 = new ParagraphProperties();
            AutoSpaceDE autoSpaceDE8 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN8 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent8 = new AdjustRightIndent() { Val = false };
            Justification justification7 = new Justification() { Val = JustificationValues.Center };

            ParagraphMarkRunProperties paragraphMarkRunProperties17 = new ParagraphMarkRunProperties();
            FontSize fontSize89 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript89 = new FontSizeComplexScript() { Val = "22" };
            Languages languages28 = new Languages() { Val = "en-US" };

            paragraphMarkRunProperties17.Append(fontSize89);
            paragraphMarkRunProperties17.Append(fontSizeComplexScript89);
            paragraphMarkRunProperties17.Append(languages28);

            paragraphProperties17.Append(autoSpaceDE8);
            paragraphProperties17.Append(autoSpaceDN8);
            paragraphProperties17.Append(adjustRightIndent8);
            paragraphProperties17.Append(justification7);
            paragraphProperties17.Append(paragraphMarkRunProperties17);
            ProofError proofError5 = new ProofError() { Type = ProofingErrorValues.SpellStart };

            Run run73 = new Run();

            RunProperties runProperties73 = new RunProperties();
            FontSize fontSize90 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript90 = new FontSizeComplexScript() { Val = "22" };
            Languages languages29 = new Languages() { Val = "en-US" };

            runProperties73.Append(fontSize90);
            runProperties73.Append(fontSizeComplexScript90);
            runProperties73.Append(languages29);
            Text text72 = new Text();
            text72.Text = "ProductCode";

            run73.Append(runProperties73);
            run73.Append(text72);
            ProofError proofError6 = new ProofError() { Type = ProofingErrorValues.SpellEnd };

            paragraph17.Append(paragraphProperties17);
            paragraph17.Append(proofError5);
            paragraph17.Append(run73);
            paragraph17.Append(proofError6);

            tableCell5.Append(tableCellProperties5);
            tableCell5.Append(paragraph17);

            TableCell tableCell6 = new TableCell();

            TableCellProperties tableCellProperties6 = new TableCellProperties();
            TableCellWidth tableCellWidth6 = new TableCellWidth() { Width = "2700", Type = TableWidthUnitValues.Dxa };
            TableCellVerticalAlignment tableCellVerticalAlignment5 = new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center };

            tableCellProperties6.Append(tableCellWidth6);
            tableCellProperties6.Append(tableCellVerticalAlignment5);

            Paragraph paragraph18 = new Paragraph() { RsidParagraphAddition = "00151B89", RsidRunAdditionDefault = "00151B89" };

            ParagraphProperties paragraphProperties18 = new ParagraphProperties();
            AutoSpaceDE autoSpaceDE9 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN9 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent9 = new AdjustRightIndent() { Val = false };
            Justification justification8 = new Justification() { Val = JustificationValues.Center };

            ParagraphMarkRunProperties paragraphMarkRunProperties18 = new ParagraphMarkRunProperties();
            FontSize fontSize91 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript91 = new FontSizeComplexScript() { Val = "22" };
            Languages languages30 = new Languages() { Val = "en-US" };

            paragraphMarkRunProperties18.Append(fontSize91);
            paragraphMarkRunProperties18.Append(fontSizeComplexScript91);
            paragraphMarkRunProperties18.Append(languages30);

            paragraphProperties18.Append(autoSpaceDE9);
            paragraphProperties18.Append(autoSpaceDN9);
            paragraphProperties18.Append(adjustRightIndent9);
            paragraphProperties18.Append(justification8);
            paragraphProperties18.Append(paragraphMarkRunProperties18);
            ProofError proofError7 = new ProofError() { Type = ProofingErrorValues.SpellStart };

            Run run74 = new Run();

            RunProperties runProperties74 = new RunProperties();
            FontSize fontSize92 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript92 = new FontSizeComplexScript() { Val = "22" };
            Languages languages31 = new Languages() { Val = "en-US" };

            runProperties74.Append(fontSize92);
            runProperties74.Append(fontSizeComplexScript92);
            runProperties74.Append(languages31);
            Text text73 = new Text();
            text73.Text = "WeightImportedMaterials";

            run74.Append(runProperties74);
            run74.Append(text73);
            ProofError proofError8 = new ProofError() { Type = ProofingErrorValues.SpellEnd };

            paragraph18.Append(paragraphProperties18);
            paragraph18.Append(proofError7);
            paragraph18.Append(run74);
            paragraph18.Append(proofError8);

            tableCell6.Append(tableCellProperties6);
            tableCell6.Append(paragraph18);

            tableRow2.Append(tableRowProperties2);
            tableRow2.Append(tableCell4);
            tableRow2.Append(tableCell5);
            tableRow2.Append(tableCell6);

            table1.Append(tableProperties1);
            table1.Append(tableGrid1);
            table1.Append(tableRow1);
            table1.Append(tableRow2);

            Paragraph paragraph19 = new Paragraph() { RsidParagraphMarkRevision = "00E051D4", RsidParagraphAddition = "00805438", RsidParagraphProperties = "00092ACE", RsidRunAdditionDefault = "00805438" };

            ParagraphProperties paragraphProperties19 = new ParagraphProperties();
            AutoSpaceDE autoSpaceDE10 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN10 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent10 = new AdjustRightIndent() { Val = false };

            ParagraphMarkRunProperties paragraphMarkRunProperties19 = new ParagraphMarkRunProperties();
            FontSize fontSize93 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript93 = new FontSizeComplexScript() { Val = "22" };

            paragraphMarkRunProperties19.Append(fontSize93);
            paragraphMarkRunProperties19.Append(fontSizeComplexScript93);

            paragraphProperties19.Append(autoSpaceDE10);
            paragraphProperties19.Append(autoSpaceDN10);
            paragraphProperties19.Append(adjustRightIndent10);
            paragraphProperties19.Append(paragraphMarkRunProperties19);

            paragraph19.Append(paragraphProperties19);

            Paragraph paragraph20 = new Paragraph() { RsidParagraphMarkRevision = "00E051D4", RsidParagraphAddition = "006B3263", RsidParagraphProperties = "00092ACE", RsidRunAdditionDefault = "00092ACE" };

            ParagraphProperties paragraphProperties20 = new ParagraphProperties();
            AutoSpaceDE autoSpaceDE11 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN11 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent11 = new AdjustRightIndent() { Val = false };

            ParagraphMarkRunProperties paragraphMarkRunProperties20 = new ParagraphMarkRunProperties();
            FontSize fontSize94 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript94 = new FontSizeComplexScript() { Val = "22" };

            paragraphMarkRunProperties20.Append(fontSize94);
            paragraphMarkRunProperties20.Append(fontSizeComplexScript94);

            paragraphProperties20.Append(autoSpaceDE11);
            paragraphProperties20.Append(autoSpaceDN11);
            paragraphProperties20.Append(adjustRightIndent11);
            paragraphProperties20.Append(paragraphMarkRunProperties20);

            Run run75 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties75 = new RunProperties();
            FontSize fontSize95 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript95 = new FontSizeComplexScript() { Val = "22" };

            runProperties75.Append(fontSize95);
            runProperties75.Append(fontSizeComplexScript95);
            Text text74 = new Text();
            text74.Text = "Количество товара";

            run75.Append(runProperties75);
            run75.Append(text74);

            Run run76 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "00F21375" };

            RunProperties runProperties76 = new RunProperties();
            FontSize fontSize96 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript96 = new FontSizeComplexScript() { Val = "22" };

            runProperties76.Append(fontSize96);
            runProperties76.Append(fontSizeComplexScript96);
            Text text75 = new Text();
            text75.Text = ";";

            run76.Append(runProperties76);
            run76.Append(text75);

            Run run77 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "006B3263" };

            RunProperties runProperties77 = new RunProperties();
            FontSize fontSize97 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript97 = new FontSizeComplexScript() { Val = "22" };

            runProperties77.Append(fontSize97);
            runProperties77.Append(fontSizeComplexScript97);
            Text text76 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text76.Text = "  ";

            run77.Append(runProperties77);
            run77.Append(text76);

            paragraph20.Append(paragraphProperties20);
            paragraph20.Append(run75);
            paragraph20.Append(run76);
            paragraph20.Append(run77);

            Paragraph paragraph21 = new Paragraph() { RsidParagraphMarkRevision = "008E7ECF", RsidParagraphAddition = "003B0660", RsidParagraphProperties = "00092ACE", RsidRunAdditionDefault = "00092ACE" };

            ParagraphProperties paragraphProperties21 = new ParagraphProperties();
            AutoSpaceDE autoSpaceDE12 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN12 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent12 = new AdjustRightIndent() { Val = false };

            ParagraphMarkRunProperties paragraphMarkRunProperties21 = new ParagraphMarkRunProperties();
            Bold bold36 = new Bold();
            FontSize fontSize98 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript98 = new FontSizeComplexScript() { Val = "22" };
            Underline underline18 = new Underline() { Val = UnderlineValues.Single };

            paragraphMarkRunProperties21.Append(bold36);
            paragraphMarkRunProperties21.Append(fontSize98);
            paragraphMarkRunProperties21.Append(fontSizeComplexScript98);
            paragraphMarkRunProperties21.Append(underline18);

            paragraphProperties21.Append(autoSpaceDE12);
            paragraphProperties21.Append(autoSpaceDN12);
            paragraphProperties21.Append(adjustRightIndent12);
            paragraphProperties21.Append(paragraphMarkRunProperties21);

            Run run78 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties78 = new RunProperties();
            FontSize fontSize99 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript99 = new FontSizeComplexScript() { Val = "22" };

            runProperties78.Append(fontSize99);
            runProperties78.Append(fontSizeComplexScript99);
            Text text77 = new Text();
            text77.Text = "/";

            run78.Append(runProperties78);
            run78.Append(text77);

            Run run79 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "004D0D13" };

            RunProperties runProperties79 = new RunProperties();
            FontSize fontSize100 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript100 = new FontSizeComplexScript() { Val = "22" };

            runProperties79.Append(fontSize100);
            runProperties79.Append(fontSizeComplexScript100);
            Text text78 = new Text();
            text78.Text = "шт";

            run79.Append(runProperties79);
            run79.Append(text78);

            Run run80 = new Run() { RsidRunProperties = "005B6319", RsidRunAddition = "004D0D13" };

            RunProperties runProperties80 = new RunProperties();
            FontSize fontSize101 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript101 = new FontSizeComplexScript() { Val = "22" };

            runProperties80.Append(fontSize101);
            runProperties80.Append(fontSizeComplexScript101);
            Text text79 = new Text();
            text79.Text = ".";

            run80.Append(runProperties80);
            run80.Append(text79);

            Run run81 = new Run() { RsidRunProperties = "005B6319" };

            RunProperties runProperties81 = new RunProperties();
            Bold bold37 = new Bold();
            FontSize fontSize102 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript102 = new FontSizeComplexScript() { Val = "22" };

            runProperties81.Append(bold37);
            runProperties81.Append(fontSize102);
            runProperties81.Append(fontSizeComplexScript102);
            Text text80 = new Text();
            text80.Text = "/";

            run81.Append(runProperties81);
            run81.Append(text80);

            Run run82 = new Run() { RsidRunProperties = "008E7ECF", RsidRunAddition = "008E7ECF" };
            Text text81 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text81.Text = " ";

            run82.Append(text81);

            Run run83 = new Run() { RsidRunAddition = "00F815AE" };

            RunProperties runProperties82 = new RunProperties();
            Bold bold38 = new Bold();
            FontSize fontSize103 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript103 = new FontSizeComplexScript() { Val = "22" };
            Languages languages32 = new Languages() { Val = "en-US" };

            runProperties82.Append(bold38);
            runProperties82.Append(fontSize103);
            runProperties82.Append(fontSizeComplexScript103);
            runProperties82.Append(languages32);
            Text text82 = new Text();
            text82.Text = frm.productAmount.Value.ToString();

            run83.Append(runProperties82);
            run83.Append(text82);

            Run run84 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "006908B3" };

            RunProperties runProperties83 = new RunProperties();
            FontSize fontSize104 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript104 = new FontSizeComplexScript() { Val = "22" };

            runProperties83.Append(fontSize104);
            runProperties83.Append(fontSizeComplexScript104);
            Text text83 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text83.Text = "     ";

            run84.Append(runProperties83);
            run84.Append(text83);

            Run run85 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "00324107" };

            RunProperties runProperties84 = new RunProperties();
            FontSize fontSize105 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript105 = new FontSizeComplexScript() { Val = "22" };

            runProperties84.Append(fontSize105);
            runProperties84.Append(fontSizeComplexScript105);
            Text text84 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text84.Text = "                        ";

            run85.Append(runProperties84);
            run85.Append(text84);

            Run run86 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "006908B3" };

            RunProperties runProperties85 = new RunProperties();
            FontSize fontSize106 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript106 = new FontSizeComplexScript() { Val = "22" };

            runProperties85.Append(fontSize106);
            runProperties85.Append(fontSizeComplexScript106);
            Text text85 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text85.Text = " ";

            run86.Append(runProperties85);
            run86.Append(text85);

            Run run87 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "00E81903" };

            RunProperties runProperties86 = new RunProperties();
            FontSize fontSize107 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript107 = new FontSizeComplexScript() { Val = "22" };

            runProperties86.Append(fontSize107);
            runProperties86.Append(fontSizeComplexScript107);
            Text text86 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text86.Text = "     ";

            run87.Append(runProperties86);
            run87.Append(text86);
            ProofError proofError9 = new ProofError() { Type = ProofingErrorValues.SpellStart };

            Run run88 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties87 = new RunProperties();
            FontSize fontSize108 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript108 = new FontSizeComplexScript() { Val = "22" };

            runProperties87.Append(fontSize108);
            runProperties87.Append(fontSizeComplexScript108);
            Text text87 = new Text();
            text87.Text = "ве";

            run88.Append(runProperties87);
            run88.Append(text87);
            ProofError proofError10 = new ProofError() { Type = ProofingErrorValues.GrammarStart };

            Run run89 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties88 = new RunProperties();
            FontSize fontSize109 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript109 = new FontSizeComplexScript() { Val = "22" };

            runProperties88.Append(fontSize109);
            runProperties88.Append(fontSizeComplexScript109);
            Text text88 = new Text();
            text88.Text = "c";

            run89.Append(runProperties88);
            run89.Append(text88);
            ProofError proofError11 = new ProofError() { Type = ProofingErrorValues.SpellEnd };
            ProofError proofError12 = new ProofError() { Type = ProofingErrorValues.GrammarEnd };

            Run run90 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties89 = new RunProperties();
            FontSize fontSize110 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript110 = new FontSizeComplexScript() { Val = "22" };

            runProperties89.Append(fontSize110);
            runProperties89.Append(fontSizeComplexScript110);
            Text text89 = new Text();
            text89.Text = "/кг/:";

            run90.Append(runProperties89);
            run90.Append(text89);

            Run run91 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "00E81903" };

            RunProperties runProperties90 = new RunProperties();
            FontSize fontSize111 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript111 = new FontSizeComplexScript() { Val = "22" };

            runProperties90.Append(fontSize111);
            runProperties90.Append(fontSizeComplexScript111);
            Text text90 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text90.Text = " ";

            run91.Append(runProperties90);
            run91.Append(text90);

            Run run92 = new Run() { RsidRunProperties = "009163DB" };

            RunProperties runProperties91 = new RunProperties();
            Bold bold39 = new Bold();
            FontSize fontSize112 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript112 = new FontSizeComplexScript() { Val = "22" };
            Underline underline19 = new Underline() { Val = UnderlineValues.Single };

            runProperties91.Append(bold39);
            runProperties91.Append(fontSize112);
            runProperties91.Append(fontSizeComplexScript112);
            runProperties91.Append(underline19);
            Text text91 = new Text();
            text91.Text = "бр";

            run92.Append(runProperties91);
            run92.Append(text91);

            Run run93 = new Run() { RsidRunProperties = "009163DB", RsidRunAddition = "00E81903" };

            RunProperties runProperties92 = new RunProperties();
            Bold bold40 = new Bold();
            FontSize fontSize113 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript113 = new FontSizeComplexScript() { Val = "22" };
            Underline underline20 = new Underline() { Val = UnderlineValues.Single };

            runProperties92.Append(bold40);
            runProperties92.Append(fontSize113);
            runProperties92.Append(fontSizeComplexScript113);
            runProperties92.Append(underline20);
            Text text92 = new Text();
            text92.Text = "утто";

            run93.Append(runProperties92);
            run93.Append(text92);

            Run run94 = new Run() { RsidRunProperties = "009163DB", RsidRunAddition = "004D0D13" };

            RunProperties runProperties93 = new RunProperties();
            Bold bold41 = new Bold();
            FontSize fontSize114 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript114 = new FontSizeComplexScript() { Val = "22" };

            runProperties93.Append(bold41);
            runProperties93.Append(fontSize114);
            runProperties93.Append(fontSizeComplexScript114);
            Text text93 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text93.Text = " ";

            run94.Append(runProperties93);
            run94.Append(text93);

            Run run95 = new Run() { RsidRunAddition = "008E7ECF" };

            RunProperties runProperties94 = new RunProperties();
            Bold bold42 = new Bold();
            FontSize fontSize115 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript115 = new FontSizeComplexScript() { Val = "22" };
            Underline underline21 = new Underline() { Val = UnderlineValues.Single };
            Languages languages33 = new Languages() { Val = "en-US" };

            runProperties94.Append(bold42);
            runProperties94.Append(fontSize115);
            runProperties94.Append(fontSizeComplexScript115);
            runProperties94.Append(underline21);
            runProperties94.Append(languages33);
            Text text94 = new Text();
            text94.Text = frm.gross.Value.ToString();

            run95.Append(runProperties94);
            run95.Append(text94);

            Run run96 = new Run() { RsidRunProperties = "009163DB", RsidRunAddition = "003F422E" };

            RunProperties runProperties95 = new RunProperties();
            Bold bold43 = new Bold();
            FontSize fontSize116 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript116 = new FontSizeComplexScript() { Val = "22" };

            runProperties95.Append(bold43);
            runProperties95.Append(fontSize116);
            runProperties95.Append(fontSizeComplexScript116);
            Text text95 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text95.Text = "        ";

            run96.Append(runProperties95);
            run96.Append(text95);

            Run run97 = new Run() { RsidRunProperties = "009163DB", RsidRunAddition = "00F1161F" };

            RunProperties runProperties96 = new RunProperties();
            Bold bold44 = new Bold();
            FontSize fontSize117 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript117 = new FontSizeComplexScript() { Val = "22" };
            Underline underline22 = new Underline() { Val = UnderlineValues.Single };

            runProperties96.Append(bold44);
            runProperties96.Append(fontSize117);
            runProperties96.Append(fontSizeComplexScript117);
            runProperties96.Append(underline22);
            Text text96 = new Text();
            text96.Text = "нетто";

            run97.Append(runProperties96);
            run97.Append(text96);

            Run run98 = new Run() { RsidRunProperties = "009163DB", RsidRunAddition = "001765C2" };

            RunProperties runProperties97 = new RunProperties();
            Bold bold45 = new Bold();
            FontSize fontSize118 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript118 = new FontSizeComplexScript() { Val = "22" };
            Underline underline23 = new Underline() { Val = UnderlineValues.Single };

            runProperties97.Append(bold45);
            runProperties97.Append(fontSize118);
            runProperties97.Append(fontSizeComplexScript118);
            runProperties97.Append(underline23);
            Text text97 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text97.Text = " ";

            run98.Append(runProperties97);
            run98.Append(text97);

            Run run99 = new Run() { RsidRunProperties = "009163DB", RsidRunAddition = "00E9495F" };

            RunProperties runProperties98 = new RunProperties();
            Bold bold46 = new Bold();
            FontSize fontSize119 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript119 = new FontSizeComplexScript() { Val = "22" };

            runProperties98.Append(bold46);
            runProperties98.Append(fontSize119);
            runProperties98.Append(fontSizeComplexScript119);
            Text text98 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text98.Text = " ";

            run99.Append(runProperties98);
            run99.Append(text98);

            Run run100 = new Run() { RsidRunProperties = "009163DB", RsidRunAddition = "00272440" };

            RunProperties runProperties99 = new RunProperties();
            Bold bold47 = new Bold();
            FontSize fontSize120 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript120 = new FontSizeComplexScript() { Val = "22" };

            runProperties99.Append(bold47);
            runProperties99.Append(fontSize120);
            runProperties99.Append(fontSizeComplexScript120);
            Text text99 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text99.Text = "  ";

            run100.Append(runProperties99);
            run100.Append(text99);

            Run run101 = new Run() { RsidRunAddition = "008E7ECF" };

            RunProperties runProperties100 = new RunProperties();
            Bold bold48 = new Bold();
            FontSize fontSize121 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript121 = new FontSizeComplexScript() { Val = "22" };
            Underline underline24 = new Underline() { Val = UnderlineValues.Single };
            Languages languages34 = new Languages() { Val = "en-US" };

            runProperties100.Append(bold48);
            runProperties100.Append(fontSize121);
            runProperties100.Append(fontSizeComplexScript121);
            runProperties100.Append(underline24);
            runProperties100.Append(languages34);
            Text text100 = new Text();
            text100.Text = frm.net.Value.ToString();

            run101.Append(runProperties100);
            run101.Append(text100);

            paragraph21.Append(paragraphProperties21);
            paragraph21.Append(run78);
            paragraph21.Append(run79);
            paragraph21.Append(run80);
            paragraph21.Append(run81);
            paragraph21.Append(run82);
            paragraph21.Append(run83);
            paragraph21.Append(run84);
            paragraph21.Append(run85);
            paragraph21.Append(run86);
            paragraph21.Append(run87);
            paragraph21.Append(proofError9);
            paragraph21.Append(run88);
            paragraph21.Append(proofError10);
            paragraph21.Append(run89);
            paragraph21.Append(proofError11);
            paragraph21.Append(proofError12);
            paragraph21.Append(run90);
            paragraph21.Append(run91);
            paragraph21.Append(run92);
            paragraph21.Append(run93);
            paragraph21.Append(run94);
            paragraph21.Append(run95);
            paragraph21.Append(run96);
            paragraph21.Append(run97);
            paragraph21.Append(run98);
            paragraph21.Append(run99);
            paragraph21.Append(run100);
            paragraph21.Append(run101);

            Paragraph paragraph22 = new Paragraph() { RsidParagraphMarkRevision = "006D1423", RsidParagraphAddition = "00EC7250", RsidParagraphProperties = "00092ACE", RsidRunAdditionDefault = "00EC7250" };

            ParagraphProperties paragraphProperties22 = new ParagraphProperties();
            AutoSpaceDE autoSpaceDE13 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN13 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent13 = new AdjustRightIndent() { Val = false };

            ParagraphMarkRunProperties paragraphMarkRunProperties22 = new ParagraphMarkRunProperties();
            FontSize fontSize122 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript122 = new FontSizeComplexScript() { Val = "22" };
            Languages languages35 = new Languages() { Val = "uk-UA" };

            paragraphMarkRunProperties22.Append(fontSize122);
            paragraphMarkRunProperties22.Append(fontSizeComplexScript122);
            paragraphMarkRunProperties22.Append(languages35);

            paragraphProperties22.Append(autoSpaceDE13);
            paragraphProperties22.Append(autoSpaceDN13);
            paragraphProperties22.Append(adjustRightIndent13);
            paragraphProperties22.Append(paragraphMarkRunProperties22);

            paragraph22.Append(paragraphProperties22);

            Paragraph paragraph23 = new Paragraph() { RsidParagraphMarkRevision = "00E051D4", RsidParagraphAddition = "00812181", RsidParagraphProperties = "00092ACE", RsidRunAdditionDefault = "00092ACE" };

            ParagraphProperties paragraphProperties23 = new ParagraphProperties();
            AutoSpaceDE autoSpaceDE14 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN14 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent14 = new AdjustRightIndent() { Val = false };

            ParagraphMarkRunProperties paragraphMarkRunProperties23 = new ParagraphMarkRunProperties();
            FontSize fontSize123 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript123 = new FontSizeComplexScript() { Val = "22" };

            paragraphMarkRunProperties23.Append(fontSize123);
            paragraphMarkRunProperties23.Append(fontSizeComplexScript123);

            paragraphProperties23.Append(autoSpaceDE14);
            paragraphProperties23.Append(autoSpaceDN14);
            paragraphProperties23.Append(adjustRightIndent14);
            paragraphProperties23.Append(paragraphMarkRunProperties23);

            Run run102 = new Run() { RsidRunProperties = "00987422" };

            RunProperties runProperties101 = new RunProperties();
            FontSize fontSize124 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript124 = new FontSizeComplexScript() { Val = "22" };

            runProperties101.Append(fontSize124);
            runProperties101.Append(fontSizeComplexScript124);
            Text text101 = new Text();
            text101.Text = "количество мест";

            run102.Append(runProperties101);
            run102.Append(text101);

            Run run103 = new Run() { RsidRunProperties = "00987422", RsidRunAddition = "00F17A99" };

            RunProperties runProperties102 = new RunProperties();
            FontSize fontSize125 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript125 = new FontSizeComplexScript() { Val = "22" };

            runProperties102.Append(fontSize125);
            runProperties102.Append(fontSizeComplexScript125);
            Text text102 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text102.Text = " ";

            run103.Append(runProperties102);
            run103.Append(text102);

            Run run104 = new Run() { RsidRunAddition = "00B344A1" };

            RunProperties runProperties103 = new RunProperties();
            Bold bold49 = new Bold();
            FontSize fontSize126 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript126 = new FontSizeComplexScript() { Val = "22" };
            Underline underline25 = new Underline() { Val = UnderlineValues.Single };
            Languages languages36 = new Languages() { Val = "en-US" };

            runProperties103.Append(bold49);
            runProperties103.Append(fontSize126);
            runProperties103.Append(fontSizeComplexScript126);
            runProperties103.Append(underline25);
            runProperties103.Append(languages36);
            Text text103 = new Text();
            text103.Text = frm.seats.Value.ToString();

            run104.Append(runProperties103);
            run104.Append(text103);

            Run run105 = new Run() { RsidRunAddition = "006D1423" };

            RunProperties runProperties104 = new RunProperties();
            FontSize fontSize127 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript127 = new FontSizeComplexScript() { Val = "22" };

            runProperties104.Append(fontSize127);
            runProperties104.Append(fontSizeComplexScript127);
            Text text104 = new Text();
            text104.Text = "(под";

            run105.Append(runProperties104);
            run105.Append(text104);
            BookmarkStart bookmarkStart1 = new BookmarkStart() { Name = "_GoBack", Id = "0" };
            BookmarkEnd bookmarkEnd1 = new BookmarkEnd() { Id = "0" };

            Run run106 = new Run() { RsidRunAddition = "006D1423" };

            RunProperties runProperties105 = new RunProperties();
            FontSize fontSize128 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript128 = new FontSizeComplexScript() { Val = "22" };

            runProperties105.Append(fontSize128);
            runProperties105.Append(fontSizeComplexScript128);
            Text text105 = new Text();
            text105.Text = "дон дерев.,";

            run106.Append(runProperties105);
            run106.Append(text105);

            Run run107 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "00A92F57" };

            RunProperties runProperties106 = new RunProperties();
            FontSize fontSize129 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript129 = new FontSizeComplexScript() { Val = "22" };

            runProperties106.Append(fontSize129);
            runProperties106.Append(fontSizeComplexScript129);
            Text text106 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text106.Text = " кар";

            run107.Append(runProperties106);
            run107.Append(text106);

            Run run108 = new Run() { RsidRunAddition = "006D1423" };

            RunProperties runProperties107 = new RunProperties();
            FontSize fontSize130 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript130 = new FontSizeComplexScript() { Val = "22" };

            runProperties107.Append(fontSize130);
            runProperties107.Append(fontSizeComplexScript130);
            Text text107 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text107.Text = "тон, плёнка ";

            run108.Append(runProperties107);
            run108.Append(text107);
            ProofError proofError13 = new ProofError() { Type = ProofingErrorValues.SpellStart };

            Run run109 = new Run() { RsidRunAddition = "006D1423" };

            RunProperties runProperties108 = new RunProperties();
            FontSize fontSize131 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript131 = new FontSizeComplexScript() { Val = "22" };

            runProperties108.Append(fontSize131);
            runProperties108.Append(fontSizeComplexScript131);
            Text text108 = new Text();
            text108.Text = "пузырч";

            run109.Append(runProperties108);
            run109.Append(text108);
            ProofError proofError14 = new ProofError() { Type = ProofingErrorValues.SpellEnd };

            Run run110 = new Run() { RsidRunAddition = "006D1423" };

            RunProperties runProperties109 = new RunProperties();
            FontSize fontSize132 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript132 = new FontSizeComplexScript() { Val = "22" };

            runProperties109.Append(fontSize132);
            runProperties109.Append(fontSizeComplexScript132);
            Text text109 = new Text();
            text109.Text = ".,";

            run110.Append(runProperties109);
            run110.Append(text109);

            Run run111 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "00A92F57" };

            RunProperties runProperties110 = new RunProperties();
            FontSize fontSize133 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript133 = new FontSizeComplexScript() { Val = "22" };

            runProperties110.Append(fontSize133);
            runProperties110.Append(fontSizeComplexScript133);
            Text text110 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text110.Text = " ";

            run111.Append(runProperties110);
            run111.Append(text110);
            ProofError proofError15 = new ProofError() { Type = ProofingErrorValues.SpellStart };

            Run run112 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "00A92F57" };

            RunProperties runProperties111 = new RunProperties();
            FontSize fontSize134 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript134 = new FontSizeComplexScript() { Val = "22" };

            runProperties111.Append(fontSize134);
            runProperties111.Append(fontSizeComplexScript134);
            Text text111 = new Text();
            text111.Text = "стрейч";

            run112.Append(runProperties111);
            run112.Append(text111);
            ProofError proofError16 = new ProofError() { Type = ProofingErrorValues.SpellEnd };

            Run run113 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "00A92F57" };

            RunProperties runProperties112 = new RunProperties();
            FontSize fontSize135 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript135 = new FontSizeComplexScript() { Val = "22" };

            runProperties112.Append(fontSize135);
            runProperties112.Append(fontSizeComplexScript135);
            Text text112 = new Text();
            text112.Text = ")";

            run113.Append(runProperties112);
            run113.Append(text112);

            Run run114 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "00070A9B" };

            RunProperties runProperties113 = new RunProperties();
            FontSize fontSize136 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript136 = new FontSizeComplexScript() { Val = "22" };

            runProperties113.Append(fontSize136);
            runProperties113.Append(fontSizeComplexScript136);
            Text text113 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text113.Text = "      ";

            run114.Append(runProperties113);
            run114.Append(text113);
            ProofError proofError17 = new ProofError() { Type = ProofingErrorValues.GrammarStart };

            Run run115 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "00E81903" };

            RunProperties runProperties114 = new RunProperties();
            FontSize fontSize137 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript137 = new FontSizeComplexScript() { Val = "22" };

            runProperties114.Append(fontSize137);
            runProperties114.Append(fontSizeComplexScript137);
            Text text114 = new Text();
            text114.Text = "транспорт";

            run115.Append(runProperties114);
            run115.Append(text114);
            ProofError proofError18 = new ProofError() { Type = ProofingErrorValues.GrammarEnd };

            Run run116 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "00816A83" };

            RunProperties runProperties115 = new RunProperties();
            FontSize fontSize138 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript138 = new FontSizeComplexScript() { Val = "22" };

            runProperties115.Append(fontSize138);
            runProperties115.Append(fontSizeComplexScript138);
            Text text115 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text115.Text = "    ";

            run116.Append(runProperties115);
            run116.Append(text115);

            Run run117 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "008855BE" };

            RunProperties runProperties116 = new RunProperties();
            Bold bold50 = new Bold();
            FontSize fontSize139 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript139 = new FontSizeComplexScript() { Val = "22" };
            Underline underline26 = new Underline() { Val = UnderlineValues.Single };

            runProperties116.Append(bold50);
            runProperties116.Append(fontSize139);
            runProperties116.Append(fontSizeComplexScript139);
            runProperties116.Append(underline26);
            Text text116 = new Text();
            text116.Text = "а/м";

            run117.Append(runProperties116);
            run117.Append(text116);

            paragraph23.Append(paragraphProperties23);
            paragraph23.Append(run102);
            paragraph23.Append(run103);
            paragraph23.Append(run104);
            paragraph23.Append(run105);
            paragraph23.Append(bookmarkStart1);
            paragraph23.Append(bookmarkEnd1);
            paragraph23.Append(run106);
            paragraph23.Append(run107);
            paragraph23.Append(run108);
            paragraph23.Append(proofError13);
            paragraph23.Append(run109);
            paragraph23.Append(proofError14);
            paragraph23.Append(run110);
            paragraph23.Append(run111);
            paragraph23.Append(proofError15);
            paragraph23.Append(run112);
            paragraph23.Append(proofError16);
            paragraph23.Append(run113);
            paragraph23.Append(run114);
            paragraph23.Append(proofError17);
            paragraph23.Append(run115);
            paragraph23.Append(proofError18);
            paragraph23.Append(run116);
            paragraph23.Append(run117);

            Paragraph paragraph24 = new Paragraph() { RsidParagraphMarkRevision = "00E051D4", RsidParagraphAddition = "00F960F0", RsidParagraphProperties = "00092ACE", RsidRunAdditionDefault = "00812181" };

            ParagraphProperties paragraphProperties24 = new ParagraphProperties();
            AutoSpaceDE autoSpaceDE15 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN15 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent15 = new AdjustRightIndent() { Val = false };

            ParagraphMarkRunProperties paragraphMarkRunProperties24 = new ParagraphMarkRunProperties();
            FontSize fontSize140 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript140 = new FontSizeComplexScript() { Val = "22" };

            paragraphMarkRunProperties24.Append(fontSize140);
            paragraphMarkRunProperties24.Append(fontSizeComplexScript140);

            paragraphProperties24.Append(autoSpaceDE15);
            paragraphProperties24.Append(autoSpaceDN15);
            paragraphProperties24.Append(adjustRightIndent15);
            paragraphProperties24.Append(paragraphMarkRunProperties24);

            Run run118 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties117 = new RunProperties();
            FontSize fontSize141 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript141 = new FontSizeComplexScript() { Val = "22" };

            runProperties117.Append(fontSize141);
            runProperties117.Append(fontSizeComplexScript141);
            Text text117 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text117.Text = "        ";

            run118.Append(runProperties117);
            run118.Append(text117);

            Run run119 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "005D6C24" };

            RunProperties runProperties118 = new RunProperties();
            FontSize fontSize142 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript142 = new FontSizeComplexScript() { Val = "22" };

            runProperties118.Append(fontSize142);
            runProperties118.Append(fontSizeComplexScript142);
            Text text118 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text118.Text = " ";

            run119.Append(runProperties118);
            run119.Append(text118);

            Run run120 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties119 = new RunProperties();
            FontSize fontSize143 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript143 = new FontSizeComplexScript() { Val = "22" };

            runProperties119.Append(fontSize143);
            runProperties119.Append(fontSizeComplexScript143);
            Text text119 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text119.Text = "                  ";

            run120.Append(runProperties119);
            run120.Append(text119);

            Run run121 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "003F422E" };

            RunProperties runProperties120 = new RunProperties();
            FontSize fontSize144 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript144 = new FontSizeComplexScript() { Val = "22" };

            runProperties120.Append(fontSize144);
            runProperties120.Append(fontSizeComplexScript144);
            Text text120 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text120.Text = "                                            ";

            run121.Append(runProperties120);
            run121.Append(text120);

            Run run122 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "00816A83" };

            RunProperties runProperties121 = new RunProperties();
            FontSize fontSize145 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript145 = new FontSizeComplexScript() { Val = "22" };

            runProperties121.Append(fontSize145);
            runProperties121.Append(fontSizeComplexScript145);
            Text text121 = new Text();
            text121.Text = "(";

            run122.Append(runProperties121);
            run122.Append(text121);

            Run run123 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "00092ACE" };

            RunProperties runProperties122 = new RunProperties();
            FontSize fontSize146 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript146 = new FontSizeComplexScript() { Val = "22" };

            runProperties122.Append(fontSize146);
            runProperties122.Append(fontSizeComplexScript146);
            Text text122 = new Text();
            text122.Text = "в";

            run123.Append(runProperties122);
            run123.Append(text122);

            Run run124 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "00816A83" };

            RunProperties runProperties123 = new RunProperties();
            FontSize fontSize147 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript147 = new FontSizeComplexScript() { Val = "22" };

            runProperties123.Append(fontSize147);
            runProperties123.Append(fontSizeComplexScript147);
            Text text123 = new Text();
            text123.Text = "ид упаковки)";

            run124.Append(runProperties123);
            run124.Append(text123);

            paragraph24.Append(paragraphProperties24);
            paragraph24.Append(run118);
            paragraph24.Append(run119);
            paragraph24.Append(run120);
            paragraph24.Append(run121);
            paragraph24.Append(run122);
            paragraph24.Append(run123);
            paragraph24.Append(run124);

            Paragraph paragraph25 = new Paragraph() { RsidParagraphAddition = "00EC7250", RsidParagraphProperties = "00092ACE", RsidRunAdditionDefault = "00EC7250" };

            ParagraphProperties paragraphProperties25 = new ParagraphProperties();
            AutoSpaceDE autoSpaceDE16 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN16 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent16 = new AdjustRightIndent() { Val = false };

            ParagraphMarkRunProperties paragraphMarkRunProperties25 = new ParagraphMarkRunProperties();
            FontSize fontSize148 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript148 = new FontSizeComplexScript() { Val = "22" };

            paragraphMarkRunProperties25.Append(fontSize148);
            paragraphMarkRunProperties25.Append(fontSizeComplexScript148);

            paragraphProperties25.Append(autoSpaceDE16);
            paragraphProperties25.Append(autoSpaceDN16);
            paragraphProperties25.Append(adjustRightIndent16);
            paragraphProperties25.Append(paragraphMarkRunProperties25);

            paragraph25.Append(paragraphProperties25);

            Paragraph paragraph26 = new Paragraph() { RsidParagraphMarkRevision = "00E051D4", RsidParagraphAddition = "00092ACE", RsidParagraphProperties = "00092ACE", RsidRunAdditionDefault = "00092ACE" };

            ParagraphProperties paragraphProperties26 = new ParagraphProperties();
            AutoSpaceDE autoSpaceDE17 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN17 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent17 = new AdjustRightIndent() { Val = false };

            ParagraphMarkRunProperties paragraphMarkRunProperties26 = new ParagraphMarkRunProperties();
            FontSize fontSize149 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript149 = new FontSizeComplexScript() { Val = "22" };

            paragraphMarkRunProperties26.Append(fontSize149);
            paragraphMarkRunProperties26.Append(fontSizeComplexScript149);

            paragraphProperties26.Append(autoSpaceDE17);
            paragraphProperties26.Append(autoSpaceDN17);
            paragraphProperties26.Append(adjustRightIndent17);
            paragraphProperties26.Append(paragraphMarkRunProperties26);

            Run run125 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties124 = new RunProperties();
            FontSize fontSize150 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript150 = new FontSizeComplexScript() { Val = "22" };

            runProperties124.Append(fontSize150);
            runProperties124.Append(fontSizeComplexScript150);
            Text text124 = new Text();
            text124.Text = "Про";

            run125.Append(runProperties124);
            run125.Append(text124);

            Run run126 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "00070A9B" };

            RunProperties runProperties125 = new RunProperties();
            FontSize fontSize151 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript151 = new FontSizeComplexScript() { Val = "22" };

            runProperties125.Append(fontSize151);
            runProperties125.Append(fontSizeComplexScript151);
            Text text125 = new Text();
            text125.Text = "дукция направляется по адресу (";

            run126.Append(runProperties125);
            run126.Append(text125);

            Run run127 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties126 = new RunProperties();
            FontSize fontSize152 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript152 = new FontSizeComplexScript() { Val = "22" };

            runProperties126.Append(fontSize152);
            runProperties126.Append(fontSizeComplexScript152);
            Text text126 = new Text();
            text126.Text = "грузополучатель, его наименование, почтовый";

            run127.Append(runProperties126);
            run127.Append(text126);

            Run run128 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "00816A83" };

            RunProperties runProperties127 = new RunProperties();
            FontSize fontSize153 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript153 = new FontSizeComplexScript() { Val = "22" };

            runProperties127.Append(fontSize153);
            runProperties127.Append(fontSizeComplexScript153);
            Text text127 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text127.Text = " адрес)";

            run128.Append(runProperties127);
            run128.Append(text127);

            paragraph26.Append(paragraphProperties26);
            paragraph26.Append(run125);
            paragraph26.Append(run126);
            paragraph26.Append(run127);
            paragraph26.Append(run128);

            Paragraph paragraph27 = new Paragraph() { RsidParagraphMarkRevision = "00E051D4", RsidParagraphAddition = "00246E1F", RsidParagraphProperties = "000369C6", RsidRunAdditionDefault = "008855BE" };

            ParagraphProperties paragraphProperties27 = new ParagraphProperties();
            Justification justification9 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties27 = new ParagraphMarkRunProperties();
            Bold bold51 = new Bold();
            FontSize fontSize154 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript154 = new FontSizeComplexScript() { Val = "22" };
            Underline underline27 = new Underline() { Val = UnderlineValues.Single };

            paragraphMarkRunProperties27.Append(bold51);
            paragraphMarkRunProperties27.Append(fontSize154);
            paragraphMarkRunProperties27.Append(fontSizeComplexScript154);
            paragraphMarkRunProperties27.Append(underline27);

            paragraphProperties27.Append(justification9);
            paragraphProperties27.Append(paragraphMarkRunProperties27);

            Run run129 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties128 = new RunProperties();
            Bold bold52 = new Bold();
            FontSize fontSize155 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript155 = new FontSizeComplexScript() { Val = "22" };
            Underline underline28 = new Underline() { Val = UnderlineValues.Single };

            runProperties128.Append(bold52);
            runProperties128.Append(fontSize155);
            runProperties128.Append(fontSizeComplexScript155);
            runProperties128.Append(underline28);
            Text text128 = new Text();
            text128.Text = "ООО «";

            run129.Append(runProperties128);
            run129.Append(text128);

            Run run130 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "00C5315E" };

            RunProperties runProperties129 = new RunProperties();
            Bold bold53 = new Bold();
            FontSize fontSize156 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript156 = new FontSizeComplexScript() { Val = "22" };
            Underline underline29 = new Underline() { Val = UnderlineValues.Single };

            runProperties129.Append(bold53);
            runProperties129.Append(fontSize156);
            runProperties129.Append(fontSizeComplexScript156);
            runProperties129.Append(underline29);
            Text text129 = new Text();
            text129.Text = "Разек";

            run130.Append(runProperties129);
            run130.Append(text129);

            Run run131 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties130 = new RunProperties();
            Bold bold54 = new Bold();
            FontSize fontSize157 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript157 = new FontSizeComplexScript() { Val = "22" };
            Underline underline30 = new Underline() { Val = UnderlineValues.Single };

            runProperties130.Append(bold54);
            runProperties130.Append(fontSize157);
            runProperties130.Append(fontSizeComplexScript157);
            runProperties130.Append(underline30);
            Text text130 = new Text();
            text130.Text = "-";

            run131.Append(runProperties130);
            run131.Append(text130);

            Run run132 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "00C5315E" };

            RunProperties runProperties131 = new RunProperties();
            Bold bold55 = new Bold();
            FontSize fontSize158 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript158 = new FontSizeComplexScript() { Val = "22" };
            Underline underline31 = new Underline() { Val = UnderlineValues.Single };

            runProperties131.Append(bold55);
            runProperties131.Append(fontSize158);
            runProperties131.Append(fontSizeComplexScript158);
            runProperties131.Append(underline31);
            Text text131 = new Text();
            text131.Text = "Восток";

            run132.Append(runProperties131);
            run132.Append(text131);

            Run run133 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties132 = new RunProperties();
            Bold bold56 = new Bold();
            FontSize fontSize159 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript159 = new FontSizeComplexScript() { Val = "22" };
            Underline underline32 = new Underline() { Val = UnderlineValues.Single };

            runProperties132.Append(bold56);
            runProperties132.Append(fontSize159);
            runProperties132.Append(fontSizeComplexScript159);
            runProperties132.Append(underline32);
            Text text132 = new Text();
            text132.Text = "»";

            run133.Append(runProperties132);
            run133.Append(text132);

            Run run134 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "00C5315E" };

            RunProperties runProperties133 = new RunProperties();
            Bold bold57 = new Bold();
            FontSize fontSize160 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript160 = new FontSizeComplexScript() { Val = "22" };
            Underline underline33 = new Underline() { Val = UnderlineValues.Single };

            runProperties133.Append(bold57);
            runProperties133.Append(fontSize160);
            runProperties133.Append(fontSizeComplexScript160);
            runProperties133.Append(underline33);
            Text text133 = new Text();
            text133.Text = ",";

            run134.Append(runProperties133);
            run134.Append(text133);

            Run run135 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties134 = new RunProperties();
            Bold bold58 = new Bold();
            FontSize fontSize161 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript161 = new FontSizeComplexScript() { Val = "22" };
            Underline underline34 = new Underline() { Val = UnderlineValues.Single };

            runProperties134.Append(bold58);
            runProperties134.Append(fontSize161);
            runProperties134.Append(fontSizeComplexScript161);
            runProperties134.Append(underline34);
            Text text134 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text134.Text = " ";

            run135.Append(runProperties134);
            run135.Append(text134);

            Run run136 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "00C5315E" };

            RunProperties runProperties135 = new RunProperties();
            Bold bold59 = new Bold();
            FontSize fontSize162 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript162 = new FontSizeComplexScript() { Val = "22" };
            Underline underline35 = new Underline() { Val = UnderlineValues.Single };

            runProperties135.Append(bold59);
            runProperties135.Append(fontSize162);
            runProperties135.Append(fontSizeComplexScript162);
            runProperties135.Append(underline35);
            Text text135 = new Text();
            text135.Text = "Россия";

            run136.Append(runProperties135);
            run136.Append(text135);

            Run run137 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties136 = new RunProperties();
            Bold bold60 = new Bold();
            FontSize fontSize163 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript163 = new FontSizeComplexScript() { Val = "22" };
            Underline underline36 = new Underline() { Val = UnderlineValues.Single };

            runProperties136.Append(bold60);
            runProperties136.Append(fontSize163);
            runProperties136.Append(fontSizeComplexScript163);
            runProperties136.Append(underline36);
            Text text136 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text136.Text = ", г. ";

            run137.Append(runProperties136);
            run137.Append(text136);

            Run run138 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "00C5315E" };

            RunProperties runProperties137 = new RunProperties();
            Bold bold61 = new Bold();
            FontSize fontSize164 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript164 = new FontSizeComplexScript() { Val = "22" };
            Underline underline37 = new Underline() { Val = UnderlineValues.Single };

            runProperties137.Append(bold61);
            runProperties137.Append(fontSize164);
            runProperties137.Append(fontSizeComplexScript164);
            runProperties137.Append(underline37);
            Text text137 = new Text();
            text137.Text = "Москва";

            run138.Append(runProperties137);
            run138.Append(text137);

            Run run139 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties138 = new RunProperties();
            Bold bold62 = new Bold();
            FontSize fontSize165 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript165 = new FontSizeComplexScript() { Val = "22" };
            Underline underline38 = new Underline() { Val = UnderlineValues.Single };

            runProperties138.Append(bold62);
            runProperties138.Append(fontSize165);
            runProperties138.Append(fontSizeComplexScript165);
            runProperties138.Append(underline38);
            Text text138 = new Text();
            text138.Text = ",";

            run139.Append(runProperties138);
            run139.Append(text138);

            Run run140 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties139 = new RunProperties();
            FontSize fontSize166 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript166 = new FontSizeComplexScript() { Val = "22" };
            Underline underline39 = new Underline() { Val = UnderlineValues.Single };

            runProperties139.Append(fontSize166);
            runProperties139.Append(fontSizeComplexScript166);
            runProperties139.Append(underline39);
            Text text139 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text139.Text = " ";

            run140.Append(runProperties139);
            run140.Append(text139);

            Run run141 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "00C5315E" };

            RunProperties runProperties140 = new RunProperties();
            Bold bold63 = new Bold();
            FontSize fontSize167 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript167 = new FontSizeComplexScript() { Val = "22" };
            Underline underline40 = new Underline() { Val = UnderlineValues.Single };

            runProperties140.Append(bold63);
            runProperties140.Append(fontSize167);
            runProperties140.Append(fontSizeComplexScript167);
            runProperties140.Append(underline40);
            Text text140 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text140.Text = "Балакиревский пер., д. ";

            run141.Append(runProperties140);
            run141.Append(text140);

            Run run142 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties141 = new RunProperties();
            Bold bold64 = new Bold();
            FontSize fontSize168 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript168 = new FontSizeComplexScript() { Val = "22" };
            Underline underline41 = new Underline() { Val = UnderlineValues.Single };

            runProperties141.Append(bold64);
            runProperties141.Append(fontSize168);
            runProperties141.Append(fontSizeComplexScript168);
            runProperties141.Append(underline41);
            Text text141 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text141.Text = " 1";

            run142.Append(runProperties141);
            run142.Append(text141);

            Run run143 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "00C5315E" };

            RunProperties runProperties142 = new RunProperties();
            Bold bold65 = new Bold();
            FontSize fontSize169 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript169 = new FontSizeComplexScript() { Val = "22" };
            Underline underline42 = new Underline() { Val = UnderlineValues.Single };

            runProperties142.Append(bold65);
            runProperties142.Append(fontSize169);
            runProperties142.Append(fontSizeComplexScript169);
            runProperties142.Append(underline42);
            Text text142 = new Text();
            text142.Text = "А";

            run143.Append(runProperties142);
            run143.Append(text142);

            Run run144 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties143 = new RunProperties();
            Bold bold66 = new Bold();
            FontSize fontSize170 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript170 = new FontSizeComplexScript() { Val = "22" };
            Underline underline43 = new Underline() { Val = UnderlineValues.Single };

            runProperties143.Append(bold66);
            runProperties143.Append(fontSize170);
            runProperties143.Append(fontSizeComplexScript170);
            runProperties143.Append(underline43);
            Text text143 = new Text();
            text143.Text = ",";

            run144.Append(runProperties143);
            run144.Append(text143);

            Run run145 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "00B65077" };

            RunProperties runProperties144 = new RunProperties();
            Bold bold67 = new Bold();
            FontSize fontSize171 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript171 = new FontSizeComplexScript() { Val = "22" };
            Underline underline44 = new Underline() { Val = UnderlineValues.Single };

            runProperties144.Append(bold67);
            runProperties144.Append(fontSize171);
            runProperties144.Append(fontSizeComplexScript171);
            runProperties144.Append(underline44);
            Text text144 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text144.Text = " ";

            run145.Append(runProperties144);
            run145.Append(text144);

            Run run146 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "00C5315E" };

            RunProperties runProperties145 = new RunProperties();
            Bold bold68 = new Bold();
            FontSize fontSize172 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript172 = new FontSizeComplexScript() { Val = "22" };
            Underline underline45 = new Underline() { Val = UnderlineValues.Single };

            runProperties145.Append(bold68);
            runProperties145.Append(fontSize172);
            runProperties145.Append(fontSizeComplexScript172);
            runProperties145.Append(underline45);
            Text text145 = new Text();
            text145.Text = "оф";

            run146.Append(runProperties145);
            run146.Append(text145);

            Run run147 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties146 = new RunProperties();
            Bold bold69 = new Bold();
            FontSize fontSize173 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript173 = new FontSizeComplexScript() { Val = "22" };
            Underline underline46 = new Underline() { Val = UnderlineValues.Single };

            runProperties146.Append(bold69);
            runProperties146.Append(fontSize173);
            runProperties146.Append(fontSizeComplexScript173);
            runProperties146.Append(underline46);
            Text text146 = new Text();
            text146.Text = ".";

            run147.Append(runProperties146);
            run147.Append(text146);

            Run run148 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "000D6BAE" };

            RunProperties runProperties147 = new RunProperties();
            Bold bold70 = new Bold();
            FontSize fontSize174 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript174 = new FontSizeComplexScript() { Val = "22" };
            Underline underline47 = new Underline() { Val = UnderlineValues.Single };

            runProperties147.Append(bold70);
            runProperties147.Append(fontSize174);
            runProperties147.Append(fontSizeComplexScript174);
            runProperties147.Append(underline47);
            Text text147 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text147.Text = " ";

            run148.Append(runProperties147);
            run148.Append(text147);

            Run run149 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "00C5315E" };

            RunProperties runProperties148 = new RunProperties();
            Bold bold71 = new Bold();
            FontSize fontSize175 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript175 = new FontSizeComplexScript() { Val = "22" };
            Underline underline48 = new Underline() { Val = UnderlineValues.Single };

            runProperties148.Append(bold71);
            runProperties148.Append(fontSize175);
            runProperties148.Append(fontSizeComplexScript175);
            runProperties148.Append(underline48);
            Text text148 = new Text();
            text148.Text = "4";

            run149.Append(runProperties148);
            run149.Append(text148);

            paragraph27.Append(paragraphProperties27);
            paragraph27.Append(run129);
            paragraph27.Append(run130);
            paragraph27.Append(run131);
            paragraph27.Append(run132);
            paragraph27.Append(run133);
            paragraph27.Append(run134);
            paragraph27.Append(run135);
            paragraph27.Append(run136);
            paragraph27.Append(run137);
            paragraph27.Append(run138);
            paragraph27.Append(run139);
            paragraph27.Append(run140);
            paragraph27.Append(run141);
            paragraph27.Append(run142);
            paragraph27.Append(run143);
            paragraph27.Append(run144);
            paragraph27.Append(run145);
            paragraph27.Append(run146);
            paragraph27.Append(run147);
            paragraph27.Append(run148);
            paragraph27.Append(run149);

            Paragraph paragraph28 = new Paragraph() { RsidParagraphMarkRevision = "00E051D4", RsidParagraphAddition = "00926E84", RsidParagraphProperties = "000369C6", RsidRunAdditionDefault = "00926E84" };

            ParagraphProperties paragraphProperties28 = new ParagraphProperties();
            Justification justification10 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties28 = new ParagraphMarkRunProperties();
            Bold bold72 = new Bold();
            FontSize fontSize176 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript176 = new FontSizeComplexScript() { Val = "22" };
            Underline underline49 = new Underline() { Val = UnderlineValues.Single };

            paragraphMarkRunProperties28.Append(bold72);
            paragraphMarkRunProperties28.Append(fontSize176);
            paragraphMarkRunProperties28.Append(fontSizeComplexScript176);
            paragraphMarkRunProperties28.Append(underline49);

            paragraphProperties28.Append(justification10);
            paragraphProperties28.Append(paragraphMarkRunProperties28);

            paragraph28.Append(paragraphProperties28);

            Table table2 = new Table();

            TableProperties tableProperties2 = new TableProperties();
            TableWidth tableWidth2 = new TableWidth() { Width = "10740", Type = TableWidthUnitValues.Dxa };
            TableLook tableLook2 = new TableLook() { Val = "01E0" };

            tableProperties2.Append(tableWidth2);
            tableProperties2.Append(tableLook2);

            TableGrid tableGrid2 = new TableGrid();
            GridColumn gridColumn4 = new GridColumn() { Width = "10740" };

            tableGrid2.Append(gridColumn4);

            TableRow tableRow3 = new TableRow() { RsidTableRowMarkRevision = "00E051D4", RsidTableRowAddition = "00A13B37", RsidTableRowProperties = "005C4F3A" };

            TableRowProperties tableRowProperties3 = new TableRowProperties();
            TableRowHeight tableRowHeight3 = new TableRowHeight() { Val = (UInt32Value)2519U };

            tableRowProperties3.Append(tableRowHeight3);

            TableCell tableCell7 = new TableCell();

            TableCellProperties tableCellProperties7 = new TableCellProperties();
            TableCellWidth tableCellWidth7 = new TableCellWidth() { Width = "10740", Type = TableWidthUnitValues.Dxa };

            tableCellProperties7.Append(tableCellWidth7);

            Paragraph paragraph29 = new Paragraph() { RsidParagraphMarkRevision = "00BC4AB2", RsidParagraphAddition = "00E23013", RsidParagraphProperties = "002C48A4", RsidRunAdditionDefault = "00837ABE" };

            ParagraphProperties paragraphProperties29 = new ParagraphProperties();
            AutoSpaceDE autoSpaceDE18 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN18 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent18 = new AdjustRightIndent() { Val = false };
            Indentation indentation1 = new Indentation() { End = "-649" };

            ParagraphMarkRunProperties paragraphMarkRunProperties29 = new ParagraphMarkRunProperties();
            Bold bold73 = new Bold();
            FontSize fontSize177 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript177 = new FontSizeComplexScript() { Val = "22" };
            Underline underline50 = new Underline() { Val = UnderlineValues.Single };

            paragraphMarkRunProperties29.Append(bold73);
            paragraphMarkRunProperties29.Append(fontSize177);
            paragraphMarkRunProperties29.Append(fontSizeComplexScript177);
            paragraphMarkRunProperties29.Append(underline50);

            paragraphProperties29.Append(autoSpaceDE18);
            paragraphProperties29.Append(autoSpaceDN18);
            paragraphProperties29.Append(adjustRightIndent18);
            paragraphProperties29.Append(indentation1);
            paragraphProperties29.Append(paragraphMarkRunProperties29);

            Run run150 = new Run();

            RunProperties runProperties149 = new RunProperties();
            FontSize fontSize178 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript178 = new FontSizeComplexScript() { Val = "22" };

            runProperties149.Append(fontSize178);
            runProperties149.Append(fontSizeComplexScript178);
            Text text149 = new Text();
            text149.Text = "Согласно контракту";

            run150.Append(runProperties149);
            run150.Append(text149);

            Run run151 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "00E23013" };

            RunProperties runProperties150 = new RunProperties();
            FontSize fontSize179 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript179 = new FontSizeComplexScript() { Val = "22" };

            runProperties150.Append(fontSize179);
            runProperties150.Append(fontSizeComplexScript179);
            Text text150 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text150.Text = " ";

            run151.Append(runProperties150);
            run151.Append(text150);

            Run run152 = new Run() { RsidRunAddition = "00BC4AB2" };

            RunProperties runProperties151 = new RunProperties();
            FontSize fontSize180 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript180 = new FontSizeComplexScript() { Val = "22" };

            runProperties151.Append(fontSize180);
            runProperties151.Append(fontSizeComplexScript180);
            Text text151 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text151.Text = " ";

            run152.Append(runProperties151);
            run152.Append(text151);

            Run run153 = new Run() { RsidRunProperties = "001138C7" };

            RunProperties runProperties152 = new RunProperties();
            Bold bold74 = new Bold();
            Italic italic3 = new Italic();
            FontSize fontSize181 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript181 = new FontSizeComplexScript() { Val = "22" };
            Underline underline51 = new Underline() { Val = UnderlineValues.Single };

            runProperties152.Append(bold74);
            runProperties152.Append(italic3);
            runProperties152.Append(fontSize181);
            runProperties152.Append(fontSizeComplexScript181);
            runProperties152.Append(underline51);
            Text text152 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text152.Text = "№ ";

            run153.Append(runProperties152);
            run153.Append(text152);

            Run run154 = new Run() { RsidRunAddition = "003D3E55" };

            RunProperties runProperties153 = new RunProperties();
            Bold bold75 = new Bold();
            Italic italic4 = new Italic();
            FontSize fontSize182 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript182 = new FontSizeComplexScript() { Val = "22" };
            Underline underline52 = new Underline() { Val = UnderlineValues.Single };
            Languages languages37 = new Languages() { Val = "en-US" };

            runProperties153.Append(bold75);
            runProperties153.Append(italic4);
            runProperties153.Append(fontSize182);
            runProperties153.Append(fontSizeComplexScript182);
            runProperties153.Append(underline52);
            runProperties153.Append(languages37);
            Text text153 = new Text();
            text153.Text = frm.contractNumber.Text;

            run154.Append(runProperties153);
            run154.Append(text153);

            Run run155 = new Run();

            RunProperties runProperties154 = new RunProperties();
            Bold bold76 = new Bold();
            Italic italic5 = new Italic();
            FontSize fontSize183 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript183 = new FontSizeComplexScript() { Val = "22" };
            Underline underline53 = new Underline() { Val = UnderlineValues.Single };

            runProperties154.Append(bold76);
            runProperties154.Append(italic5);
            runProperties154.Append(fontSize183);
            runProperties154.Append(fontSizeComplexScript183);
            runProperties154.Append(underline53);
            Text text154 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text154.Text = " ";

            run155.Append(runProperties154);
            run155.Append(text154);

            Run run156 = new Run() { RsidRunProperties = "001138C7" };

            RunProperties runProperties155 = new RunProperties();
            Bold bold77 = new Bold();
            Italic italic6 = new Italic();
            FontSize fontSize184 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript184 = new FontSizeComplexScript() { Val = "22" };
            Underline underline54 = new Underline() { Val = UnderlineValues.Single };

            runProperties155.Append(bold77);
            runProperties155.Append(italic6);
            runProperties155.Append(fontSize184);
            runProperties155.Append(fontSizeComplexScript184);
            runProperties155.Append(underline54);
            Text text155 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text155.Text = "от ";

            run156.Append(runProperties155);
            run156.Append(text155);
            ProofError proofError19 = new ProofError() { Type = ProofingErrorValues.SpellStart };

            Run run157 = new Run() { RsidRunAddition = "003D3E55" };

            RunProperties runProperties156 = new RunProperties();
            Bold bold78 = new Bold();
            Italic italic7 = new Italic();
            FontSize fontSize185 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript185 = new FontSizeComplexScript() { Val = "22" };
            Underline underline55 = new Underline() { Val = UnderlineValues.Single };
            Languages languages38 = new Languages() { Val = "en-US" };

            runProperties156.Append(bold78);
            runProperties156.Append(italic7);
            runProperties156.Append(fontSize185);
            runProperties156.Append(fontSizeComplexScript185);
            runProperties156.Append(underline55);
            runProperties156.Append(languages38);
            Text text156 = new Text();
            text156.Text = frm.contractDate.Value.ToShortDateString();

            run157.Append(runProperties156);
            run157.Append(text156);
            ProofError proofError20 = new ProofError() { Type = ProofingErrorValues.SpellEnd };

            Run run158 = new Run() { RsidRunProperties = "001138C7" };

            RunProperties runProperties157 = new RunProperties();
            Bold bold79 = new Bold();
            Italic italic8 = new Italic();
            FontSize fontSize186 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript186 = new FontSizeComplexScript() { Val = "22" };
            Underline underline56 = new Underline() { Val = UnderlineValues.Single };

            runProperties157.Append(bold79);
            runProperties157.Append(italic8);
            runProperties157.Append(fontSize186);
            runProperties157.Append(fontSizeComplexScript186);
            runProperties157.Append(underline56);
            Text text157 = new Text();
            text157.Text = ".";

            run158.Append(runProperties157);
            run158.Append(text157);

            paragraph29.Append(paragraphProperties29);
            paragraph29.Append(run150);
            paragraph29.Append(run151);
            paragraph29.Append(run152);
            paragraph29.Append(run153);
            paragraph29.Append(run154);
            paragraph29.Append(run155);
            paragraph29.Append(run156);
            paragraph29.Append(proofError19);
            paragraph29.Append(run157);
            paragraph29.Append(proofError20);
            paragraph29.Append(run158);

            Paragraph paragraph30 = new Paragraph() { RsidParagraphMarkRevision = "00E051D4", RsidParagraphAddition = "00E23013", RsidParagraphProperties = "002C48A4", RsidRunAdditionDefault = "00E23013" };

            ParagraphProperties paragraphProperties30 = new ParagraphProperties();
            AutoSpaceDE autoSpaceDE19 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN19 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent19 = new AdjustRightIndent() { Val = false };
            Indentation indentation2 = new Indentation() { End = "-649" };

            ParagraphMarkRunProperties paragraphMarkRunProperties30 = new ParagraphMarkRunProperties();
            Bold bold80 = new Bold();
            BoldComplexScript boldComplexScript1 = new BoldComplexScript();
            FontSize fontSize187 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript187 = new FontSizeComplexScript() { Val = "22" };

            paragraphMarkRunProperties30.Append(bold80);
            paragraphMarkRunProperties30.Append(boldComplexScript1);
            paragraphMarkRunProperties30.Append(fontSize187);
            paragraphMarkRunProperties30.Append(fontSizeComplexScript187);

            paragraphProperties30.Append(autoSpaceDE19);
            paragraphProperties30.Append(autoSpaceDN19);
            paragraphProperties30.Append(adjustRightIndent19);
            paragraphProperties30.Append(indentation2);
            paragraphProperties30.Append(paragraphMarkRunProperties30);

            Run run159 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties158 = new RunProperties();
            FontSize fontSize188 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript188 = new FontSizeComplexScript() { Val = "22" };

            runProperties158.Append(fontSize188);
            runProperties158.Append(fontSizeComplexScript188);
            Text text158 = new Text();
            text158.Text = "с предприятием (наименование, почтовый адрес";

            run159.Append(runProperties158);
            run159.Append(text158);

            Run run160 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties159 = new RunProperties();
            BoldComplexScript boldComplexScript2 = new BoldComplexScript();
            FontSize fontSize189 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript189 = new FontSizeComplexScript() { Val = "22" };

            runProperties159.Append(boldComplexScript2);
            runProperties159.Append(fontSize189);
            runProperties159.Append(fontSizeComplexScript189);
            Text text159 = new Text();
            text159.Text = ")";

            run160.Append(runProperties159);
            run160.Append(text159);

            Run run161 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties160 = new RunProperties();
            Bold bold81 = new Bold();
            BoldComplexScript boldComplexScript3 = new BoldComplexScript();
            FontSize fontSize190 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript190 = new FontSizeComplexScript() { Val = "22" };

            runProperties160.Append(bold81);
            runProperties160.Append(boldComplexScript3);
            runProperties160.Append(fontSize190);
            runProperties160.Append(fontSizeComplexScript190);
            Text text160 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text160.Text = " ";

            run161.Append(runProperties160);
            run161.Append(text160);

            Run run162 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties161 = new RunProperties();
            Bold bold82 = new Bold();
            FontSize fontSize191 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript191 = new FontSizeComplexScript() { Val = "22" };
            Underline underline57 = new Underline() { Val = UnderlineValues.Single };

            runProperties161.Append(bold82);
            runProperties161.Append(fontSize191);
            runProperties161.Append(fontSizeComplexScript191);
            runProperties161.Append(underline57);
            Text text161 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text161.Text = " ООО «Разек";

            run162.Append(runProperties161);
            run162.Append(text161);

            Run run163 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "004D0D13" };

            RunProperties runProperties162 = new RunProperties();
            Bold bold83 = new Bold();
            FontSize fontSize192 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript192 = new FontSizeComplexScript() { Val = "22" };
            Underline underline58 = new Underline() { Val = UnderlineValues.Single };

            runProperties162.Append(bold83);
            runProperties162.Append(fontSize192);
            runProperties162.Append(fontSizeComplexScript192);
            runProperties162.Append(underline58);
            Text text162 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text162.Text = " ";

            run163.Append(runProperties162);
            run163.Append(text162);

            Run run164 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties163 = new RunProperties();
            Bold bold84 = new Bold();
            FontSize fontSize193 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript193 = new FontSizeComplexScript() { Val = "22" };
            Underline underline59 = new Underline() { Val = UnderlineValues.Single };

            runProperties163.Append(bold84);
            runProperties163.Append(fontSize193);
            runProperties163.Append(fontSizeComplexScript193);
            runProperties163.Append(underline59);
            Text text163 = new Text();
            text163.Text = "-";

            run164.Append(runProperties163);
            run164.Append(text163);

            Run run165 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "004D0D13" };

            RunProperties runProperties164 = new RunProperties();
            Bold bold85 = new Bold();
            FontSize fontSize194 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript194 = new FontSizeComplexScript() { Val = "22" };
            Underline underline60 = new Underline() { Val = UnderlineValues.Single };

            runProperties164.Append(bold85);
            runProperties164.Append(fontSize194);
            runProperties164.Append(fontSizeComplexScript194);
            runProperties164.Append(underline60);
            Text text164 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text164.Text = " ";

            run165.Append(runProperties164);
            run165.Append(text164);

            Run run166 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties165 = new RunProperties();
            Bold bold86 = new Bold();
            FontSize fontSize195 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript195 = new FontSizeComplexScript() { Val = "22" };
            Underline underline61 = new Underline() { Val = UnderlineValues.Single };

            runProperties165.Append(bold86);
            runProperties165.Append(fontSize195);
            runProperties165.Append(fontSizeComplexScript195);
            runProperties165.Append(underline61);
            Text text165 = new Text();
            text165.Text = "Восток»";

            run166.Append(runProperties165);
            run166.Append(text165);

            Run run167 = new Run() { RsidRunProperties = "00E712AD", RsidRunAddition = "00BC4AB2" };

            RunProperties runProperties166 = new RunProperties();
            Bold bold87 = new Bold();
            FontSize fontSize196 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript196 = new FontSizeComplexScript() { Val = "22" };

            runProperties166.Append(bold87);
            runProperties166.Append(fontSize196);
            runProperties166.Append(fontSizeComplexScript196);
            Text text166 = new Text();
            text166.Text = "_____________________________";

            run167.Append(runProperties166);
            run167.Append(text166);

            Run run168 = new Run() { RsidRunProperties = "00E712AD", RsidRunAddition = "00E712AD" };

            RunProperties runProperties167 = new RunProperties();
            Bold bold88 = new Bold();
            FontSize fontSize197 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript197 = new FontSizeComplexScript() { Val = "22" };

            runProperties167.Append(bold88);
            runProperties167.Append(fontSize197);
            runProperties167.Append(fontSizeComplexScript197);
            Text text167 = new Text();
            text167.Text = "_";

            run168.Append(runProperties167);
            run168.Append(text167);

            paragraph30.Append(paragraphProperties30);
            paragraph30.Append(run159);
            paragraph30.Append(run160);
            paragraph30.Append(run161);
            paragraph30.Append(run162);
            paragraph30.Append(run163);
            paragraph30.Append(run164);
            paragraph30.Append(run165);
            paragraph30.Append(run166);
            paragraph30.Append(run167);
            paragraph30.Append(run168);

            Paragraph paragraph31 = new Paragraph() { RsidParagraphMarkRevision = "00C07ED7", RsidParagraphAddition = "00766E08", RsidParagraphProperties = "002C48A4", RsidRunAdditionDefault = "00E23013" };

            ParagraphProperties paragraphProperties31 = new ParagraphProperties();
            ParagraphStyleId paragraphStyleId3 = new ParagraphStyleId() { Val = "2" };
            Indentation indentation3 = new Indentation() { End = "-649" };

            ParagraphMarkRunProperties paragraphMarkRunProperties31 = new ParagraphMarkRunProperties();
            RunFonts runFonts3 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Bold bold89 = new Bold();
            FontSize fontSize198 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript198 = new FontSizeComplexScript() { Val = "22" };
            Underline underline62 = new Underline() { Val = UnderlineValues.Single };
            Languages languages39 = new Languages() { Val = "uk-UA" };

            paragraphMarkRunProperties31.Append(runFonts3);
            paragraphMarkRunProperties31.Append(bold89);
            paragraphMarkRunProperties31.Append(fontSize198);
            paragraphMarkRunProperties31.Append(fontSizeComplexScript198);
            paragraphMarkRunProperties31.Append(underline62);
            paragraphMarkRunProperties31.Append(languages39);

            paragraphProperties31.Append(paragraphStyleId3);
            paragraphProperties31.Append(indentation3);
            paragraphProperties31.Append(paragraphMarkRunProperties31);

            Run run169 = new Run() { RsidRunProperties = "001138C7" };

            RunProperties runProperties168 = new RunProperties();
            RunFonts runFonts4 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Bold bold90 = new Bold();
            FontSize fontSize199 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript199 = new FontSizeComplexScript() { Val = "22" };
            Underline underline63 = new Underline() { Val = UnderlineValues.Single };
            Languages languages40 = new Languages() { Val = "ru-RU", EastAsia = "ru-RU" };

            runProperties168.Append(runFonts4);
            runProperties168.Append(bold90);
            runProperties168.Append(fontSize199);
            runProperties168.Append(fontSizeComplexScript199);
            runProperties168.Append(underline63);
            runProperties168.Append(languages40);
            Text text168 = new Text();
            text168.Text = "Счёт";

            run169.Append(runProperties168);
            run169.Append(text168);

            Run run170 = new Run() { RsidRunAddition = "00F7632A" };

            RunProperties runProperties169 = new RunProperties();
            RunFonts runFonts5 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Bold bold91 = new Bold();
            FontSize fontSize200 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript200 = new FontSizeComplexScript() { Val = "22" };
            Underline underline64 = new Underline() { Val = UnderlineValues.Single };
            Languages languages41 = new Languages() { Val = "ru-RU", EastAsia = "ru-RU" };

            runProperties169.Append(runFonts5);
            runProperties169.Append(bold91);
            runProperties169.Append(fontSize200);
            runProperties169.Append(fontSizeComplexScript200);
            runProperties169.Append(underline64);
            runProperties169.Append(languages41);
            Text text169 = new Text();
            text169.Text = "а";

            run170.Append(runProperties169);
            run170.Append(text169);

            Run run171 = new Run() { RsidRunProperties = "003E531E", RsidRunAddition = "00F24082" };

            RunProperties runProperties170 = new RunProperties();
            RunFonts runFonts6 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Bold bold92 = new Bold();
            FontSize fontSize201 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript201 = new FontSizeComplexScript() { Val = "22" };
            Underline underline65 = new Underline() { Val = UnderlineValues.Single };
            Languages languages42 = new Languages() { Val = "en-US", EastAsia = "ru-RU" };

            runProperties170.Append(runFonts6);
            runProperties170.Append(bold92);
            runProperties170.Append(fontSize201);
            runProperties170.Append(fontSizeComplexScript201);
            runProperties170.Append(underline65);
            runProperties170.Append(languages42);
            Text text170 = new Text();
            text170.Text = "-";

            run171.Append(runProperties170);
            run171.Append(text170);

            Run run172 = new Run() { RsidRunProperties = "001138C7", RsidRunAddition = "00F24082" };

            RunProperties runProperties171 = new RunProperties();
            RunFonts runFonts7 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Bold bold93 = new Bold();
            FontSize fontSize202 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript202 = new FontSizeComplexScript() { Val = "22" };
            Underline underline66 = new Underline() { Val = UnderlineValues.Single };
            Languages languages43 = new Languages() { Val = "ru-RU", EastAsia = "ru-RU" };

            runProperties171.Append(runFonts7);
            runProperties171.Append(bold93);
            runProperties171.Append(fontSize202);
            runProperties171.Append(fontSizeComplexScript202);
            runProperties171.Append(underline66);
            runProperties171.Append(languages43);
            Text text171 = new Text();
            text171.Text = "фактур";

            run172.Append(runProperties171);
            run172.Append(text171);

            Run run173 = new Run() { RsidRunAddition = "00F7632A" };

            RunProperties runProperties172 = new RunProperties();
            RunFonts runFonts8 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Bold bold94 = new Bold();
            FontSize fontSize203 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript203 = new FontSizeComplexScript() { Val = "22" };
            Underline underline67 = new Underline() { Val = UnderlineValues.Single };
            Languages languages44 = new Languages() { Val = "uk-UA", EastAsia = "ru-RU" };

            runProperties172.Append(runFonts8);
            runProperties172.Append(bold94);
            runProperties172.Append(fontSize203);
            runProperties172.Append(fontSizeComplexScript203);
            runProperties172.Append(underline67);
            runProperties172.Append(languages44);
            Text text172 = new Text();
            text172.Text = "ы";

            run173.Append(runProperties172);
            run173.Append(text172);

            Run run174 = new Run() { RsidRunProperties = "003E531E" };

            RunProperties runProperties173 = new RunProperties();
            RunFonts runFonts9 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Bold bold95 = new Bold();
            FontSize fontSize204 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript204 = new FontSizeComplexScript() { Val = "22" };
            Underline underline68 = new Underline() { Val = UnderlineValues.Single };
            Languages languages45 = new Languages() { Val = "en-US", EastAsia = "ru-RU" };

            runProperties173.Append(runFonts9);
            runProperties173.Append(bold95);
            runProperties173.Append(fontSize204);
            runProperties173.Append(fontSizeComplexScript204);
            runProperties173.Append(underline68);
            runProperties173.Append(languages45);
            Text text173 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text173.Text = " ";

            run174.Append(runProperties173);
            run174.Append(text173);

            Run run175 = new Run() { RsidRunProperties = "003E531E", RsidRunAddition = "002A47F5" };

            RunProperties runProperties174 = new RunProperties();
            RunFonts runFonts10 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Bold bold96 = new Bold();
            FontSize fontSize205 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript205 = new FontSizeComplexScript() { Val = "22" };
            Underline underline69 = new Underline() { Val = UnderlineValues.Single };
            Languages languages46 = new Languages() { Val = "en-US", EastAsia = "ru-RU" };

            runProperties174.Append(runFonts10);
            runProperties174.Append(bold96);
            runProperties174.Append(fontSize205);
            runProperties174.Append(fontSizeComplexScript205);
            runProperties174.Append(underline69);
            runProperties174.Append(languages46);
            Text text174 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text174.Text = " ";

            run175.Append(runProperties174);
            run175.Append(text174);

            Run run176 = new Run() { RsidRunProperties = "003E531E", RsidRunAddition = "008527E6" };

            RunProperties runProperties175 = new RunProperties();
            RunFonts runFonts11 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Bold bold97 = new Bold();
            FontSize fontSize206 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript206 = new FontSizeComplexScript() { Val = "22" };
            Underline underline70 = new Underline() { Val = UnderlineValues.Single };
            Languages languages47 = new Languages() { Val = "en-US", EastAsia = "ru-RU" };

            runProperties175.Append(runFonts11);
            runProperties175.Append(bold97);
            runProperties175.Append(fontSize206);
            runProperties175.Append(fontSizeComplexScript206);
            runProperties175.Append(underline70);
            runProperties175.Append(languages47);
            Text text175 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text175.Text = " ";

            run176.Append(runProperties175);
            run176.Append(text175);

            Run run177 = new Run() { RsidRunProperties = "003E531E", RsidRunAddition = "00B734B2" };

            RunProperties runProperties176 = new RunProperties();
            RunFonts runFonts12 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Bold bold98 = new Bold();
            FontSize fontSize207 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript207 = new FontSizeComplexScript() { Val = "22" };
            Underline underline71 = new Underline() { Val = UnderlineValues.Single };
            Languages languages48 = new Languages() { Val = "en-US", EastAsia = "ru-RU" };

            runProperties176.Append(runFonts12);
            runProperties176.Append(bold98);
            runProperties176.Append(fontSize207);
            runProperties176.Append(fontSizeComplexScript207);
            runProperties176.Append(underline71);
            runProperties176.Append(languages48);
            Text text176 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text176.Text = " ";

            run177.Append(runProperties176);
            run177.Append(text176);

            Run run178 = new Run() { RsidRunProperties = "00BA4107", RsidRunAddition = "00FC3B8F" };

            RunProperties runProperties177 = new RunProperties();
            RunFonts runFonts13 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Bold bold99 = new Bold();
            Underline underline72 = new Underline() { Val = UnderlineValues.Single };

            runProperties177.Append(runFonts13);
            runProperties177.Append(bold99);
            runProperties177.Append(underline72);
            Text text177 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text177.Text = " ";

            run178.Append(runProperties177);
            run178.Append(text177);

            Run run179 = new Run() { RsidRunProperties = "00C07ED7", RsidRunAddition = "00C07ED7" };

            RunProperties runProperties178 = new RunProperties();
            RunFonts runFonts14 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Bold bold100 = new Bold();
            Underline underline73 = new Underline() { Val = UnderlineValues.Single };

            runProperties178.Append(runFonts14);
            runProperties178.Append(bold100);
            runProperties178.Append(underline73);
            Text text178 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text178.Text = "№ ";

            run179.Append(runProperties178);
            run179.Append(text178);

            Run run180 = new Run() { RsidRunAddition = "003E531E" };

            RunProperties runProperties179 = new RunProperties();
            RunFonts runFonts15 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Bold bold101 = new Bold();
            Underline underline74 = new Underline() { Val = UnderlineValues.Single };
            Languages languages49 = new Languages() { Val = "en-US" };

            runProperties179.Append(runFonts15);
            runProperties179.Append(bold101);
            runProperties179.Append(underline74);
            runProperties179.Append(languages49);
            Text text179 = new Text();
            text179.Text = frm.invoiceNumber.Text;

            run180.Append(runProperties179);
            run180.Append(text179);

            Run run181 = new Run() { RsidRunProperties = "00C07ED7", RsidRunAddition = "00C07ED7" };

            RunProperties runProperties180 = new RunProperties();
            RunFonts runFonts16 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Bold bold102 = new Bold();
            Underline underline75 = new Underline() { Val = UnderlineValues.Single };

            runProperties180.Append(runFonts16);
            runProperties180.Append(bold102);
            runProperties180.Append(underline75);
            Text text180 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text180.Text = " ";

            run181.Append(runProperties180);
            run181.Append(text180);

            Run run182 = new Run() { RsidRunProperties = "00C07ED7", RsidRunAddition = "00C07ED7" };

            RunProperties runProperties181 = new RunProperties();
            RunFonts runFonts17 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Bold bold103 = new Bold();
            Underline underline76 = new Underline() { Val = UnderlineValues.Single };
            Languages languages50 = new Languages() { Val = "uk-UA" };

            runProperties181.Append(runFonts17);
            runProperties181.Append(bold103);
            runProperties181.Append(underline76);
            runProperties181.Append(languages50);
            Text text181 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text181.Text = " от ";

            run182.Append(runProperties181);
            run182.Append(text181);
            ProofError proofError21 = new ProofError() { Type = ProofingErrorValues.SpellStart };

            Run run183 = new Run() { RsidRunAddition = "003E531E" };

            RunProperties runProperties182 = new RunProperties();
            RunFonts runFonts18 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Bold bold104 = new Bold();
            Underline underline77 = new Underline() { Val = UnderlineValues.Single };
            Languages languages51 = new Languages() { Val = "en-US" };

            runProperties182.Append(runFonts18);
            runProperties182.Append(bold104);
            runProperties182.Append(underline77);
            runProperties182.Append(languages51);
            Text text182 = new Text();
            text182.Text = frm.invoiceDate.Value.ToShortDateString();

            run183.Append(runProperties182);
            run183.Append(text182);
            ProofError proofError22 = new ProofError() { Type = ProofingErrorValues.SpellEnd };

            Run run184 = new Run() { RsidRunProperties = "00C07ED7", RsidRunAddition = "00E712AD" };

            RunProperties runProperties183 = new RunProperties();
            RunFonts runFonts19 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Bold bold105 = new Bold();
            FontSize fontSize208 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript208 = new FontSizeComplexScript() { Val = "22" };
            Underline underline78 = new Underline() { Val = UnderlineValues.Single };
            Languages languages52 = new Languages() { Val = "uk-UA" };

            runProperties183.Append(runFonts19);
            runProperties183.Append(bold105);
            runProperties183.Append(fontSize208);
            runProperties183.Append(fontSizeComplexScript208);
            runProperties183.Append(underline78);
            runProperties183.Append(languages52);
            Text text183 = new Text();
            text183.Text = "_____________________________________";

            run184.Append(runProperties183);
            run184.Append(text183);

            paragraph31.Append(paragraphProperties31);
            paragraph31.Append(run169);
            paragraph31.Append(run170);
            paragraph31.Append(run171);
            paragraph31.Append(run172);
            paragraph31.Append(run173);
            paragraph31.Append(run174);
            paragraph31.Append(run175);
            paragraph31.Append(run176);
            paragraph31.Append(run177);
            paragraph31.Append(run178);
            paragraph31.Append(run179);
            paragraph31.Append(run180);
            paragraph31.Append(run181);
            paragraph31.Append(run182);
            paragraph31.Append(proofError21);
            paragraph31.Append(run183);
            paragraph31.Append(proofError22);
            paragraph31.Append(run184);

            Paragraph paragraph32 = new Paragraph() { RsidParagraphMarkRevision = "001138C7", RsidParagraphAddition = "00E23013", RsidParagraphProperties = "002C48A4", RsidRunAdditionDefault = "00E23013" };

            ParagraphProperties paragraphProperties32 = new ParagraphProperties();
            ParagraphStyleId paragraphStyleId4 = new ParagraphStyleId() { Val = "2" };
            Indentation indentation4 = new Indentation() { End = "-649" };

            ParagraphMarkRunProperties paragraphMarkRunProperties32 = new ParagraphMarkRunProperties();
            RunFonts runFonts20 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize209 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript209 = new FontSizeComplexScript() { Val = "22" };
            Languages languages53 = new Languages() { Val = "ru-RU", EastAsia = "ru-RU" };

            paragraphMarkRunProperties32.Append(runFonts20);
            paragraphMarkRunProperties32.Append(fontSize209);
            paragraphMarkRunProperties32.Append(fontSizeComplexScript209);
            paragraphMarkRunProperties32.Append(languages53);

            paragraphProperties32.Append(paragraphStyleId4);
            paragraphProperties32.Append(indentation4);
            paragraphProperties32.Append(paragraphMarkRunProperties32);

            Run run185 = new Run() { RsidRunProperties = "00E712AD" };

            RunProperties runProperties184 = new RunProperties();
            RunFonts runFonts21 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize210 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript210 = new FontSizeComplexScript() { Val = "22" };
            Languages languages54 = new Languages() { Val = "ru-RU", EastAsia = "ru-RU" };

            runProperties184.Append(runFonts21);
            runProperties184.Append(fontSize210);
            runProperties184.Append(fontSizeComplexScript210);
            runProperties184.Append(languages54);
            Text text184 = new Text();
            text184.Text = "Документы,";

            run185.Append(runProperties184);
            run185.Append(text184);

            Run run186 = new Run() { RsidRunProperties = "001138C7" };

            RunProperties runProperties185 = new RunProperties();
            RunFonts runFonts22 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize211 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript211 = new FontSizeComplexScript() { Val = "22" };
            Languages languages55 = new Languages() { Val = "ru-RU", EastAsia = "ru-RU" };

            runProperties185.Append(runFonts22);
            runProperties185.Append(fontSize211);
            runProperties185.Append(fontSizeComplexScript211);
            runProperties185.Append(languages55);
            Text text185 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text185.Text = " предъявленные при оформлении сертификата: ";

            run186.Append(runProperties185);
            run186.Append(text185);

            paragraph32.Append(paragraphProperties32);
            paragraph32.Append(run185);
            paragraph32.Append(run186);

            Paragraph paragraph33 = new Paragraph() { RsidParagraphMarkRevision = "00150E79", RsidParagraphAddition = "00E23013", RsidParagraphProperties = "002C48A4", RsidRunAdditionDefault = "00E23013" };

            ParagraphProperties paragraphProperties33 = new ParagraphProperties();
            ParagraphStyleId paragraphStyleId5 = new ParagraphStyleId() { Val = "2" };
            Indentation indentation5 = new Indentation() { End = "-649" };

            ParagraphMarkRunProperties paragraphMarkRunProperties33 = new ParagraphMarkRunProperties();
            RunFonts runFonts23 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Bold bold106 = new Bold();
            Italic italic9 = new Italic();
            FontSize fontSize212 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript212 = new FontSizeComplexScript() { Val = "22" };
            Languages languages56 = new Languages() { Val = "en-US", EastAsia = "ru-RU" };

            paragraphMarkRunProperties33.Append(runFonts23);
            paragraphMarkRunProperties33.Append(bold106);
            paragraphMarkRunProperties33.Append(italic9);
            paragraphMarkRunProperties33.Append(fontSize212);
            paragraphMarkRunProperties33.Append(fontSizeComplexScript212);
            paragraphMarkRunProperties33.Append(languages56);

            paragraphProperties33.Append(paragraphStyleId5);
            paragraphProperties33.Append(indentation5);
            paragraphProperties33.Append(paragraphMarkRunProperties33);

            Run run187 = new Run() { RsidRunProperties = "00150E79" };

            RunProperties runProperties186 = new RunProperties();
            RunFonts runFonts24 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Bold bold107 = new Bold();
            Italic italic10 = new Italic();
            FontSize fontSize213 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript213 = new FontSizeComplexScript() { Val = "22" };
            Languages languages57 = new Languages() { Val = "en-US", EastAsia = "ru-RU" };

            runProperties186.Append(runFonts24);
            runProperties186.Append(bold107);
            runProperties186.Append(italic10);
            runProperties186.Append(fontSize213);
            runProperties186.Append(fontSizeComplexScript213);
            runProperties186.Append(languages57);
            Text text186 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text186.Text = "1. ";

            run187.Append(runProperties186);
            run187.Append(text186);

            Run run188 = new Run() { RsidRunProperties = "00E712AD" };

            RunProperties runProperties187 = new RunProperties();
            RunFonts runFonts25 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Bold bold108 = new Bold();
            Italic italic11 = new Italic();
            FontSize fontSize214 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript214 = new FontSizeComplexScript() { Val = "22" };
            Underline underline79 = new Underline() { Val = UnderlineValues.Single };
            Languages languages58 = new Languages() { Val = "ru-RU", EastAsia = "ru-RU" };

            runProperties187.Append(runFonts25);
            runProperties187.Append(bold108);
            runProperties187.Append(italic11);
            runProperties187.Append(fontSize214);
            runProperties187.Append(fontSizeComplexScript214);
            runProperties187.Append(underline79);
            runProperties187.Append(languages58);
            Text text187 = new Text();
            text187.Text = "Договор";

            run188.Append(runProperties187);
            run188.Append(text187);

            Run run189 = new Run() { RsidRunProperties = "00150E79" };

            RunProperties runProperties188 = new RunProperties();
            RunFonts runFonts26 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Bold bold109 = new Bold();
            Italic italic12 = new Italic();
            FontSize fontSize215 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript215 = new FontSizeComplexScript() { Val = "22" };
            Underline underline80 = new Underline() { Val = UnderlineValues.Single };
            Languages languages59 = new Languages() { Val = "en-US", EastAsia = "ru-RU" };

            runProperties188.Append(runFonts26);
            runProperties188.Append(bold109);
            runProperties188.Append(italic12);
            runProperties188.Append(fontSize215);
            runProperties188.Append(fontSizeComplexScript215);
            runProperties188.Append(underline80);
            runProperties188.Append(languages59);
            Text text188 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text188.Text = " № ";

            run189.Append(runProperties188);
            run189.Append(text188);

            Run run190 = new Run() { RsidRunAddition = "002D2ADE" };

            RunProperties runProperties189 = new RunProperties();
            RunFonts runFonts27 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Bold bold110 = new Bold();
            Italic italic13 = new Italic();
            FontSize fontSize216 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript216 = new FontSizeComplexScript() { Val = "22" };
            Underline underline81 = new Underline() { Val = UnderlineValues.Single };
            Languages languages60 = new Languages() { Val = "en-US", EastAsia = "ru-RU" };

            runProperties189.Append(runFonts27);
            runProperties189.Append(bold110);
            runProperties189.Append(italic13);
            runProperties189.Append(fontSize216);
            runProperties189.Append(fontSizeComplexScript216);
            runProperties189.Append(underline81);
            runProperties189.Append(languages60);
            Text text189 = new Text();
            text189.Text = frm.contractNumber.Text;

            run190.Append(runProperties189);
            run190.Append(text189);

            Run run191 = new Run() { RsidRunProperties = "00150E79", RsidRunAddition = "00837ABE" };

            RunProperties runProperties190 = new RunProperties();
            RunFonts runFonts28 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Bold bold111 = new Bold();
            Italic italic14 = new Italic();
            FontSize fontSize217 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript217 = new FontSizeComplexScript() { Val = "22" };
            Underline underline82 = new Underline() { Val = UnderlineValues.Single };
            Languages languages61 = new Languages() { Val = "en-US", EastAsia = "ru-RU" };

            runProperties190.Append(runFonts28);
            runProperties190.Append(bold111);
            runProperties190.Append(italic14);
            runProperties190.Append(fontSize217);
            runProperties190.Append(fontSizeComplexScript217);
            runProperties190.Append(underline82);
            runProperties190.Append(languages61);
            Text text190 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text190.Text = " ";

            run191.Append(runProperties190);
            run191.Append(text190);

            Run run192 = new Run() { RsidRunProperties = "00E712AD" };

            RunProperties runProperties191 = new RunProperties();
            RunFonts runFonts29 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Bold bold112 = new Bold();
            Italic italic15 = new Italic();
            FontSize fontSize218 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript218 = new FontSizeComplexScript() { Val = "22" };
            Underline underline83 = new Underline() { Val = UnderlineValues.Single };
            Languages languages62 = new Languages() { Val = "ru-RU", EastAsia = "ru-RU" };

            runProperties191.Append(runFonts29);
            runProperties191.Append(bold112);
            runProperties191.Append(italic15);
            runProperties191.Append(fontSize218);
            runProperties191.Append(fontSizeComplexScript218);
            runProperties191.Append(underline83);
            runProperties191.Append(languages62);
            Text text191 = new Text();
            text191.Text = "от";

            run192.Append(runProperties191);
            run192.Append(text191);

            Run run193 = new Run() { RsidRunProperties = "00150E79" };

            RunProperties runProperties192 = new RunProperties();
            RunFonts runFonts30 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Bold bold113 = new Bold();
            Italic italic16 = new Italic();
            FontSize fontSize219 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript219 = new FontSizeComplexScript() { Val = "22" };
            Underline underline84 = new Underline() { Val = UnderlineValues.Single };
            Languages languages63 = new Languages() { Val = "en-US", EastAsia = "ru-RU" };

            runProperties192.Append(runFonts30);
            runProperties192.Append(bold113);
            runProperties192.Append(italic16);
            runProperties192.Append(fontSize219);
            runProperties192.Append(fontSizeComplexScript219);
            runProperties192.Append(underline84);
            runProperties192.Append(languages63);
            Text text192 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text192.Text = " ";

            run193.Append(runProperties192);
            run193.Append(text192);

            Run run194 = new Run() { RsidRunAddition = "002D2ADE" };

            RunProperties runProperties193 = new RunProperties();
            RunFonts runFonts31 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Bold bold114 = new Bold();
            Italic italic17 = new Italic();
            FontSize fontSize220 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript220 = new FontSizeComplexScript() { Val = "22" };
            Underline underline85 = new Underline() { Val = UnderlineValues.Single };
            Languages languages64 = new Languages() { Val = "en-US", EastAsia = "ru-RU" };

            runProperties193.Append(runFonts31);
            runProperties193.Append(bold114);
            runProperties193.Append(italic17);
            runProperties193.Append(fontSize220);
            runProperties193.Append(fontSizeComplexScript220);
            runProperties193.Append(underline85);
            runProperties193.Append(languages64);
            Text text193 = new Text();
            text193.Text = frm.contractDate.Value.ToShortDateString();

            run194.Append(runProperties193);
            run194.Append(text193);

            Run run195 = new Run() { RsidRunProperties = "00150E79", RsidRunAddition = "00E712AD" };

            RunProperties runProperties194 = new RunProperties();
            RunFonts runFonts32 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Bold bold115 = new Bold();
            Italic italic18 = new Italic();
            FontSize fontSize221 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript221 = new FontSizeComplexScript() { Val = "22" };
            Languages languages65 = new Languages() { Val = "en-US", EastAsia = "ru-RU" };

            runProperties194.Append(runFonts32);
            runProperties194.Append(bold115);
            runProperties194.Append(italic18);
            runProperties194.Append(fontSize221);
            runProperties194.Append(fontSizeComplexScript221);
            runProperties194.Append(languages65);
            Text text194 = new Text();
            text194.Text = "_";

            run195.Append(runProperties194);
            run195.Append(text194);

            Run run196 = new Run() { RsidRunProperties = "00150E79", RsidRunAddition = "00797B85" };

            RunProperties runProperties195 = new RunProperties();
            RunFonts runFonts33 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Bold bold116 = new Bold();
            Italic italic19 = new Italic();
            FontSize fontSize222 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript222 = new FontSizeComplexScript() { Val = "22" };
            Languages languages66 = new Languages() { Val = "en-US", EastAsia = "ru-RU" };

            runProperties195.Append(runFonts33);
            runProperties195.Append(bold116);
            runProperties195.Append(italic19);
            runProperties195.Append(fontSize222);
            runProperties195.Append(fontSizeComplexScript222);
            runProperties195.Append(languages66);
            Text text195 = new Text();
            text195.Text = "_";

            run196.Append(runProperties195);
            run196.Append(text195);

            Run run197 = new Run() { RsidRunProperties = "00150E79", RsidRunAddition = "00BC4AB2" };

            RunProperties runProperties196 = new RunProperties();
            RunFonts runFonts34 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Bold bold117 = new Bold();
            Italic italic20 = new Italic();
            FontSize fontSize223 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript223 = new FontSizeComplexScript() { Val = "22" };
            Languages languages67 = new Languages() { Val = "en-US", EastAsia = "ru-RU" };

            runProperties196.Append(runFonts34);
            runProperties196.Append(bold117);
            runProperties196.Append(italic20);
            runProperties196.Append(fontSize223);
            runProperties196.Append(fontSizeComplexScript223);
            runProperties196.Append(languages67);
            Text text196 = new Text();
            text196.Text = "________________________________________________________________";

            run197.Append(runProperties196);
            run197.Append(text196);

            paragraph33.Append(paragraphProperties33);
            paragraph33.Append(run187);
            paragraph33.Append(run188);
            paragraph33.Append(run189);
            paragraph33.Append(run190);
            paragraph33.Append(run191);
            paragraph33.Append(run192);
            paragraph33.Append(run193);
            paragraph33.Append(run194);
            paragraph33.Append(run195);
            paragraph33.Append(run196);
            paragraph33.Append(run197);

            Paragraph paragraph34 = new Paragraph() { RsidParagraphMarkRevision = "00E712AD", RsidParagraphAddition = "00766E08", RsidParagraphProperties = "002C48A4", RsidRunAdditionDefault = "00E23013" };

            ParagraphProperties paragraphProperties34 = new ParagraphProperties();
            AutoSpaceDE autoSpaceDE20 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN20 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent20 = new AdjustRightIndent() { Val = false };
            Indentation indentation6 = new Indentation() { End = "-649" };

            ParagraphMarkRunProperties paragraphMarkRunProperties34 = new ParagraphMarkRunProperties();
            Italic italic21 = new Italic();
            FontSize fontSize224 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript224 = new FontSizeComplexScript() { Val = "22" };
            Languages languages68 = new Languages() { Val = "uk-UA" };

            paragraphMarkRunProperties34.Append(italic21);
            paragraphMarkRunProperties34.Append(fontSize224);
            paragraphMarkRunProperties34.Append(fontSizeComplexScript224);
            paragraphMarkRunProperties34.Append(languages68);

            paragraphProperties34.Append(autoSpaceDE20);
            paragraphProperties34.Append(autoSpaceDN20);
            paragraphProperties34.Append(adjustRightIndent20);
            paragraphProperties34.Append(indentation6);
            paragraphProperties34.Append(paragraphMarkRunProperties34);

            Run run198 = new Run() { RsidRunProperties = "00150E79" };

            RunProperties runProperties197 = new RunProperties();
            Bold bold118 = new Bold();
            Italic italic22 = new Italic();
            FontSize fontSize225 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript225 = new FontSizeComplexScript() { Val = "22" };
            Languages languages69 = new Languages() { Val = "en-US" };

            runProperties197.Append(bold118);
            runProperties197.Append(italic22);
            runProperties197.Append(fontSize225);
            runProperties197.Append(fontSizeComplexScript225);
            runProperties197.Append(languages69);
            Text text197 = new Text();
            text197.Text = "2.";

            run198.Append(runProperties197);
            run198.Append(text197);

            Run run199 = new Run() { RsidRunProperties = "00150E79" };

            RunProperties runProperties198 = new RunProperties();
            Bold bold119 = new Bold();
            Italic italic23 = new Italic();
            FontSize fontSize226 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript226 = new FontSizeComplexScript() { Val = "22" };
            Underline underline86 = new Underline() { Val = UnderlineValues.Single };
            Languages languages70 = new Languages() { Val = "en-US" };

            runProperties198.Append(bold119);
            runProperties198.Append(italic23);
            runProperties198.Append(fontSize226);
            runProperties198.Append(fontSizeComplexScript226);
            runProperties198.Append(underline86);
            runProperties198.Append(languages70);
            Text text198 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text198.Text = " ";

            run199.Append(runProperties198);
            run199.Append(text198);
            ProofError proofError23 = new ProofError() { Type = ProofingErrorValues.SpellStart };

            Run run200 = new Run() { RsidRunAddition = "00C21B19" };

            RunProperties runProperties199 = new RunProperties();
            Bold bold120 = new Bold();
            Italic italic24 = new Italic();
            FontSize fontSize227 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript227 = new FontSizeComplexScript() { Val = "22" };
            Underline underline87 = new Underline() { Val = UnderlineValues.Single };

            runProperties199.Append(bold120);
            runProperties199.Append(italic24);
            runProperties199.Append(fontSize227);
            runProperties199.Append(fontSizeComplexScript227);
            runProperties199.Append(underline87);
            Text text199 = new Text();
            text199.Text = "Приложени";

            run200.Append(runProperties199);
            run200.Append(text199);
            ProofError proofError24 = new ProofError() { Type = ProofingErrorValues.SpellEnd };

            Run run201 = new Run() { RsidRunAddition = "00C21B19" };

            RunProperties runProperties200 = new RunProperties();
            Bold bold121 = new Bold();
            Italic italic25 = new Italic();
            FontSize fontSize228 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript228 = new FontSizeComplexScript() { Val = "22" };
            Underline underline88 = new Underline() { Val = UnderlineValues.Single };
            Languages languages71 = new Languages() { Val = "uk-UA" };

            runProperties200.Append(bold121);
            runProperties200.Append(italic25);
            runProperties200.Append(fontSize228);
            runProperties200.Append(fontSizeComplexScript228);
            runProperties200.Append(underline88);
            runProperties200.Append(languages71);
            Text text200 = new Text();
            text200.Text = "е";

            run201.Append(runProperties200);
            run201.Append(text200);

            Run run202 = new Run() { RsidRunProperties = "00150E79", RsidRunAddition = "00147B53" };

            RunProperties runProperties201 = new RunProperties();
            Bold bold122 = new Bold();
            Italic italic26 = new Italic();
            FontSize fontSize229 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript229 = new FontSizeComplexScript() { Val = "22" };
            Underline underline89 = new Underline() { Val = UnderlineValues.Single };
            Languages languages72 = new Languages() { Val = "en-US" };

            runProperties201.Append(bold122);
            runProperties201.Append(italic26);
            runProperties201.Append(fontSize229);
            runProperties201.Append(fontSizeComplexScript229);
            runProperties201.Append(underline89);
            runProperties201.Append(languages72);
            Text text201 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text201.Text = " ";

            run202.Append(runProperties201);
            run202.Append(text201);

            Run run203 = new Run() { RsidRunProperties = "00150E79", RsidRunAddition = "00AE02F1" };

            RunProperties runProperties202 = new RunProperties();
            Bold bold123 = new Bold();
            Italic italic27 = new Italic();
            FontSize fontSize230 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript230 = new FontSizeComplexScript() { Val = "22" };
            Underline underline90 = new Underline() { Val = UnderlineValues.Single };
            Languages languages73 = new Languages() { Val = "en-US" };

            runProperties202.Append(bold123);
            runProperties202.Append(italic27);
            runProperties202.Append(fontSize230);
            runProperties202.Append(fontSizeComplexScript230);
            runProperties202.Append(underline90);
            runProperties202.Append(languages73);
            Text text202 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text202.Text = " ";

            run203.Append(runProperties202);
            run203.Append(text202);

            Run run204 = new Run() { RsidRunProperties = "00150E79", RsidRunAddition = "008A5EDC" };

            RunProperties runProperties203 = new RunProperties();
            Bold bold124 = new Bold();
            Italic italic28 = new Italic();
            FontSize fontSize231 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript231 = new FontSizeComplexScript() { Val = "22" };
            Underline underline91 = new Underline() { Val = UnderlineValues.Single };
            Languages languages74 = new Languages() { Val = "en-US" };

            runProperties203.Append(bold124);
            runProperties203.Append(italic28);
            runProperties203.Append(fontSize231);
            runProperties203.Append(fontSizeComplexScript231);
            runProperties203.Append(underline91);
            runProperties203.Append(languages74);
            Text text203 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text203.Text = " ";

            run204.Append(runProperties203);
            run204.Append(text203);

            Run run205 = new Run() { RsidRunProperties = "00150E79", RsidRunAddition = "00C07ED7" };

            RunProperties runProperties204 = new RunProperties();
            Bold bold125 = new Bold();
            Underline underline92 = new Underline() { Val = UnderlineValues.Single };
            Languages languages75 = new Languages() { Val = "en-US" };

            runProperties204.Append(bold125);
            runProperties204.Append(underline92);
            runProperties204.Append(languages75);
            Text text204 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text204.Text = "№ ";

            run205.Append(runProperties204);
            run205.Append(text204);

            Run run206 = new Run() { RsidRunAddition = "00150E79" };

            RunProperties runProperties205 = new RunProperties();
            Bold bold126 = new Bold();
            Underline underline93 = new Underline() { Val = UnderlineValues.Single };
            Languages languages76 = new Languages() { Val = "en-US" };

            runProperties205.Append(bold126);
            runProperties205.Append(underline93);
            runProperties205.Append(languages76);
            Text text205 = new Text();
            text205.Text = frm.supplementNumber.Text;

            run206.Append(runProperties205);
            run206.Append(text205);

            Run run207 = new Run() { RsidRunProperties = "00150E79", RsidRunAddition = "00C07ED7" };

            RunProperties runProperties206 = new RunProperties();
            Bold bold127 = new Bold();
            Underline underline94 = new Underline() { Val = UnderlineValues.Single };
            Languages languages77 = new Languages() { Val = "en-US" };

            runProperties206.Append(bold127);
            runProperties206.Append(underline94);
            runProperties206.Append(languages77);
            Text text206 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text206.Text = " ";

            run207.Append(runProperties206);
            run207.Append(text206);

            Run run208 = new Run() { RsidRunProperties = "00C07ED7", RsidRunAddition = "00C07ED7" };

            RunProperties runProperties207 = new RunProperties();
            Bold bold128 = new Bold();
            Underline underline95 = new Underline() { Val = UnderlineValues.Single };
            Languages languages78 = new Languages() { Val = "uk-UA" };

            runProperties207.Append(bold128);
            runProperties207.Append(underline95);
            runProperties207.Append(languages78);
            Text text207 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text207.Text = "от ";

            run208.Append(runProperties207);
            run208.Append(text207);
            ProofError proofError25 = new ProofError() { Type = ProofingErrorValues.SpellStart };

            Run run209 = new Run() { RsidRunAddition = "00150E79" };

            RunProperties runProperties208 = new RunProperties();
            Bold bold129 = new Bold();
            Underline underline96 = new Underline() { Val = UnderlineValues.Single };
            Languages languages79 = new Languages() { Val = "en-US" };

            runProperties208.Append(bold129);
            runProperties208.Append(underline96);
            runProperties208.Append(languages79);
            Text text208 = new Text();
            text208.Text = frm.supplementDate.Value.ToShortDateString();

            run209.Append(runProperties208);
            run209.Append(text208);
            ProofError proofError26 = new ProofError() { Type = ProofingErrorValues.SpellEnd };

            Run run210 = new Run() { RsidRunProperties = "00C07ED7", RsidRunAddition = "00E712AD" };

            RunProperties runProperties209 = new RunProperties();
            Bold bold130 = new Bold();
            Italic italic29 = new Italic();
            FontSize fontSize232 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript232 = new FontSizeComplexScript() { Val = "22" };
            Underline underline97 = new Underline() { Val = UnderlineValues.Single };
            Languages languages80 = new Languages() { Val = "uk-UA" };

            runProperties209.Append(bold130);
            runProperties209.Append(italic29);
            runProperties209.Append(fontSize232);
            runProperties209.Append(fontSizeComplexScript232);
            runProperties209.Append(underline97);
            runProperties209.Append(languages80);
            Text text209 = new Text();
            text209.Text = "_______________________________________";

            run210.Append(runProperties209);
            run210.Append(text209);

            paragraph34.Append(paragraphProperties34);
            paragraph34.Append(run198);
            paragraph34.Append(run199);
            paragraph34.Append(proofError23);
            paragraph34.Append(run200);
            paragraph34.Append(proofError24);
            paragraph34.Append(run201);
            paragraph34.Append(run202);
            paragraph34.Append(run203);
            paragraph34.Append(run204);
            paragraph34.Append(run205);
            paragraph34.Append(run206);
            paragraph34.Append(run207);
            paragraph34.Append(run208);
            paragraph34.Append(proofError25);
            paragraph34.Append(run209);
            paragraph34.Append(proofError26);
            paragraph34.Append(run210);

            Paragraph paragraph35 = new Paragraph() { RsidParagraphMarkRevision = "00E712AD", RsidParagraphAddition = "00F023C0", RsidParagraphProperties = "002C48A4", RsidRunAdditionDefault = "005421AC" };

            ParagraphProperties paragraphProperties35 = new ParagraphProperties();
            AutoSpaceDE autoSpaceDE21 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN21 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent21 = new AdjustRightIndent() { Val = false };
            Indentation indentation7 = new Indentation() { End = "-649" };

            ParagraphMarkRunProperties paragraphMarkRunProperties35 = new ParagraphMarkRunProperties();
            Bold bold131 = new Bold();
            Italic italic30 = new Italic();
            FontSize fontSize233 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript233 = new FontSizeComplexScript() { Val = "22" };
            Underline underline98 = new Underline() { Val = UnderlineValues.Single };
            Languages languages81 = new Languages() { Val = "uk-UA" };

            paragraphMarkRunProperties35.Append(bold131);
            paragraphMarkRunProperties35.Append(italic30);
            paragraphMarkRunProperties35.Append(fontSize233);
            paragraphMarkRunProperties35.Append(fontSizeComplexScript233);
            paragraphMarkRunProperties35.Append(underline98);
            paragraphMarkRunProperties35.Append(languages81);

            paragraphProperties35.Append(autoSpaceDE21);
            paragraphProperties35.Append(autoSpaceDN21);
            paragraphProperties35.Append(adjustRightIndent21);
            paragraphProperties35.Append(indentation7);
            paragraphProperties35.Append(paragraphMarkRunProperties35);

            Run run211 = new Run() { RsidRunProperties = "00E712AD" };

            RunProperties runProperties210 = new RunProperties();
            Bold bold132 = new Bold();
            Italic italic31 = new Italic();
            FontSize fontSize234 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript234 = new FontSizeComplexScript() { Val = "22" };

            runProperties210.Append(bold132);
            runProperties210.Append(italic31);
            runProperties210.Append(fontSize234);
            runProperties210.Append(fontSizeComplexScript234);
            Text text210 = new Text();
            text210.Text = "3";

            run211.Append(runProperties210);
            run211.Append(text210);

            Run run212 = new Run() { RsidRunProperties = "00E712AD", RsidRunAddition = "00E23013" };

            RunProperties runProperties211 = new RunProperties();
            Bold bold133 = new Bold();
            Italic italic32 = new Italic();
            FontSize fontSize235 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript235 = new FontSizeComplexScript() { Val = "22" };

            runProperties211.Append(bold133);
            runProperties211.Append(italic32);
            runProperties211.Append(fontSize235);
            runProperties211.Append(fontSizeComplexScript235);
            Text text211 = new Text();
            text211.Text = ".";

            run212.Append(runProperties211);
            run212.Append(text211);

            Run run213 = new Run() { RsidRunProperties = "00E712AD", RsidRunAddition = "00E23013" };

            RunProperties runProperties212 = new RunProperties();
            Bold bold134 = new Bold();
            Italic italic33 = new Italic();
            FontSize fontSize236 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript236 = new FontSizeComplexScript() { Val = "22" };
            Underline underline99 = new Underline() { Val = UnderlineValues.Single };

            runProperties212.Append(bold134);
            runProperties212.Append(italic33);
            runProperties212.Append(fontSize236);
            runProperties212.Append(fontSizeComplexScript236);
            runProperties212.Append(underline99);
            Text text212 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text212.Text = " Счет";

            run213.Append(runProperties212);
            run213.Append(text212);

            Run run214 = new Run() { RsidRunProperties = "00E712AD", RsidRunAddition = "00F24082" };

            RunProperties runProperties213 = new RunProperties();
            Bold bold135 = new Bold();
            Italic italic34 = new Italic();
            FontSize fontSize237 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript237 = new FontSizeComplexScript() { Val = "22" };
            Underline underline100 = new Underline() { Val = UnderlineValues.Single };

            runProperties213.Append(bold135);
            runProperties213.Append(italic34);
            runProperties213.Append(fontSize237);
            runProperties213.Append(fontSizeComplexScript237);
            runProperties213.Append(underline100);
            Text text213 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text213.Text = " – фактур";

            run214.Append(runProperties213);
            run214.Append(text213);

            Run run215 = new Run() { RsidRunAddition = "00C21B19" };

            RunProperties runProperties214 = new RunProperties();
            Bold bold136 = new Bold();
            Italic italic35 = new Italic();
            FontSize fontSize238 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript238 = new FontSizeComplexScript() { Val = "22" };
            Underline underline101 = new Underline() { Val = UnderlineValues.Single };

            runProperties214.Append(bold136);
            runProperties214.Append(italic35);
            runProperties214.Append(fontSize238);
            runProperties214.Append(fontSizeComplexScript238);
            runProperties214.Append(underline101);
            Text text214 = new Text();
            text214.Text = "а";

            run215.Append(runProperties214);
            run215.Append(text214);

            Run run216 = new Run() { RsidRunProperties = "00E712AD", RsidRunAddition = "008C1A85" };

            RunProperties runProperties215 = new RunProperties();
            Bold bold137 = new Bold();
            Italic italic36 = new Italic();
            FontSize fontSize239 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript239 = new FontSizeComplexScript() { Val = "22" };
            Underline underline102 = new Underline() { Val = UnderlineValues.Single };

            runProperties215.Append(bold137);
            runProperties215.Append(italic36);
            runProperties215.Append(fontSize239);
            runProperties215.Append(fontSizeComplexScript239);
            runProperties215.Append(underline102);
            Text text215 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text215.Text = " ";

            run216.Append(runProperties215);
            run216.Append(text215);

            Run run217 = new Run() { RsidRunProperties = "00C07ED7", RsidRunAddition = "0086714C" };

            RunProperties runProperties216 = new RunProperties();
            Bold bold138 = new Bold();
            Italic italic37 = new Italic();
            FontSize fontSize240 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript240 = new FontSizeComplexScript() { Val = "22" };
            Underline underline103 = new Underline() { Val = UnderlineValues.Single };

            runProperties216.Append(bold138);
            runProperties216.Append(italic37);
            runProperties216.Append(fontSize240);
            runProperties216.Append(fontSizeComplexScript240);
            runProperties216.Append(underline103);
            Text text216 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text216.Text = " ";

            run217.Append(runProperties216);
            run217.Append(text216);

            Run run218 = new Run() { RsidRunProperties = "00C07ED7", RsidRunAddition = "00C07ED7" };

            RunProperties runProperties217 = new RunProperties();
            Bold bold139 = new Bold();
            Underline underline104 = new Underline() { Val = UnderlineValues.Single };

            runProperties217.Append(bold139);
            runProperties217.Append(underline104);
            Text text217 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text217.Text = "№ ";

            run218.Append(runProperties217);
            run218.Append(text217);

            Run run219 = new Run() { RsidRunAddition = "003E531E" };

            RunProperties runProperties218 = new RunProperties();
            Bold bold140 = new Bold();
            Underline underline105 = new Underline() { Val = UnderlineValues.Single };
            Languages languages82 = new Languages() { Val = "en-US" };

            runProperties218.Append(bold140);
            runProperties218.Append(underline105);
            runProperties218.Append(languages82);
            Text text218 = new Text();
            text218.Text = frm.invoiceNumber.Text;

            run219.Append(runProperties218);
            run219.Append(text218);

            Run run220 = new Run() { RsidRunProperties = "00C07ED7", RsidRunAddition = "00C07ED7" };

            RunProperties runProperties219 = new RunProperties();
            Bold bold141 = new Bold();
            Underline underline106 = new Underline() { Val = UnderlineValues.Single };

            runProperties219.Append(bold141);
            runProperties219.Append(underline106);
            Text text219 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text219.Text = " ";

            run220.Append(runProperties219);
            run220.Append(text219);

            Run run221 = new Run() { RsidRunProperties = "00C07ED7", RsidRunAddition = "00C07ED7" };

            RunProperties runProperties220 = new RunProperties();
            Bold bold142 = new Bold();
            Underline underline107 = new Underline() { Val = UnderlineValues.Single };
            Languages languages83 = new Languages() { Val = "uk-UA" };

            runProperties220.Append(bold142);
            runProperties220.Append(underline107);
            runProperties220.Append(languages83);
            Text text220 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text220.Text = " от ";

            run221.Append(runProperties220);
            run221.Append(text220);
            ProofError proofError27 = new ProofError() { Type = ProofingErrorValues.SpellStart };

            Run run222 = new Run() { RsidRunAddition = "003E531E" };

            RunProperties runProperties221 = new RunProperties();
            Bold bold143 = new Bold();
            Underline underline108 = new Underline() { Val = UnderlineValues.Single };
            Languages languages84 = new Languages() { Val = "en-US" };

            runProperties221.Append(bold143);
            runProperties221.Append(underline108);
            runProperties221.Append(languages84);
            Text text221 = new Text();
            text221.Text = frm.invoiceDate.Value.ToShortDateString();

            run222.Append(runProperties221);
            run222.Append(text221);
            ProofError proofError28 = new ProofError() { Type = ProofingErrorValues.SpellEnd };

            Run run223 = new Run() { RsidRunProperties = "00E712AD", RsidRunAddition = "00E712AD" };

            RunProperties runProperties222 = new RunProperties();
            Bold bold144 = new Bold();
            Italic italic38 = new Italic();
            FontSize fontSize241 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript241 = new FontSizeComplexScript() { Val = "22" };
            Languages languages85 = new Languages() { Val = "uk-UA" };

            runProperties222.Append(bold144);
            runProperties222.Append(italic38);
            runProperties222.Append(fontSize241);
            runProperties222.Append(fontSizeComplexScript241);
            runProperties222.Append(languages85);
            Text text222 = new Text();
            text222.Text = "___________________________________";

            run223.Append(runProperties222);
            run223.Append(text222);

            paragraph35.Append(paragraphProperties35);
            paragraph35.Append(run211);
            paragraph35.Append(run212);
            paragraph35.Append(run213);
            paragraph35.Append(run214);
            paragraph35.Append(run215);
            paragraph35.Append(run216);
            paragraph35.Append(run217);
            paragraph35.Append(run218);
            paragraph35.Append(run219);
            paragraph35.Append(run220);
            paragraph35.Append(run221);
            paragraph35.Append(proofError27);
            paragraph35.Append(run222);
            paragraph35.Append(proofError28);
            paragraph35.Append(run223);

            Paragraph paragraph36 = new Paragraph() { RsidParagraphMarkRevision = "00E712AD", RsidParagraphAddition = "00E23013", RsidParagraphProperties = "002C48A4", RsidRunAdditionDefault = "00E23013" };

            ParagraphProperties paragraphProperties36 = new ParagraphProperties();
            AutoSpaceDE autoSpaceDE22 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN22 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent22 = new AdjustRightIndent() { Val = false };
            Indentation indentation8 = new Indentation() { End = "-649" };

            ParagraphMarkRunProperties paragraphMarkRunProperties36 = new ParagraphMarkRunProperties();
            Bold bold145 = new Bold();
            Italic italic39 = new Italic();
            FontSize fontSize242 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript242 = new FontSizeComplexScript() { Val = "22" };

            paragraphMarkRunProperties36.Append(bold145);
            paragraphMarkRunProperties36.Append(italic39);
            paragraphMarkRunProperties36.Append(fontSize242);
            paragraphMarkRunProperties36.Append(fontSizeComplexScript242);

            paragraphProperties36.Append(autoSpaceDE22);
            paragraphProperties36.Append(autoSpaceDN22);
            paragraphProperties36.Append(adjustRightIndent22);
            paragraphProperties36.Append(indentation8);
            paragraphProperties36.Append(paragraphMarkRunProperties36);

            Run run224 = new Run() { RsidRunProperties = "007D7C37" };

            RunProperties runProperties223 = new RunProperties();
            Bold bold146 = new Bold();
            Italic italic40 = new Italic();
            FontSize fontSize243 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript243 = new FontSizeComplexScript() { Val = "22" };
            Languages languages86 = new Languages() { Val = "en-US" };

            runProperties223.Append(bold146);
            runProperties223.Append(italic40);
            runProperties223.Append(fontSize243);
            runProperties223.Append(fontSizeComplexScript243);
            runProperties223.Append(languages86);
            Text text223 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text223.Text = "4. ";

            run224.Append(runProperties223);
            run224.Append(text223);
            ProofError proofError29 = new ProofError() { Type = ProofingErrorValues.GrammarStart };

            Run run225 = new Run() { RsidRunProperties = "00E712AD" };

            RunProperties runProperties224 = new RunProperties();
            Bold bold147 = new Bold();
            Italic italic41 = new Italic();
            FontSize fontSize244 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript244 = new FontSizeComplexScript() { Val = "22" };
            Underline underline109 = new Underline() { Val = UnderlineValues.Single };

            runProperties224.Append(bold147);
            runProperties224.Append(italic41);
            runProperties224.Append(fontSize244);
            runProperties224.Append(fontSizeComplexScript244);
            runProperties224.Append(underline109);
            Text text224 = new Text();
            text224.Text = "Упаковочный";

            run225.Append(runProperties224);
            run225.Append(text224);

            Run run226 = new Run() { RsidRunProperties = "007D7C37", RsidRunAddition = "00271012" };

            RunProperties runProperties225 = new RunProperties();
            Bold bold148 = new Bold();
            Italic italic42 = new Italic();
            FontSize fontSize245 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript245 = new FontSizeComplexScript() { Val = "22" };
            Underline underline110 = new Underline() { Val = UnderlineValues.Single };
            Languages languages87 = new Languages() { Val = "en-US" };

            runProperties225.Append(bold148);
            runProperties225.Append(italic42);
            runProperties225.Append(fontSize245);
            runProperties225.Append(fontSizeComplexScript245);
            runProperties225.Append(underline110);
            runProperties225.Append(languages87);
            Text text225 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text225.Text = " ";

            run226.Append(runProperties225);
            run226.Append(text225);

            Run run227 = new Run() { RsidRunProperties = "007D7C37" };

            RunProperties runProperties226 = new RunProperties();
            Bold bold149 = new Bold();
            Italic italic43 = new Italic();
            FontSize fontSize246 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript246 = new FontSizeComplexScript() { Val = "22" };
            Underline underline111 = new Underline() { Val = UnderlineValues.Single };
            Languages languages88 = new Languages() { Val = "en-US" };

            runProperties226.Append(bold149);
            runProperties226.Append(italic43);
            runProperties226.Append(fontSize246);
            runProperties226.Append(fontSizeComplexScript246);
            runProperties226.Append(underline111);
            runProperties226.Append(languages88);
            Text text226 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text226.Text = " ";

            run227.Append(runProperties226);
            run227.Append(text226);

            Run run228 = new Run() { RsidRunProperties = "00E712AD" };

            RunProperties runProperties227 = new RunProperties();
            Bold bold150 = new Bold();
            Italic italic44 = new Italic();
            FontSize fontSize247 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript247 = new FontSizeComplexScript() { Val = "22" };
            Underline underline112 = new Underline() { Val = UnderlineValues.Single };

            runProperties227.Append(bold150);
            runProperties227.Append(italic44);
            runProperties227.Append(fontSize247);
            runProperties227.Append(fontSizeComplexScript247);
            runProperties227.Append(underline112);
            Text text227 = new Text();
            text227.Text = "лист";

            run228.Append(runProperties227);
            run228.Append(text227);
            ProofError proofError30 = new ProofError() { Type = ProofingErrorValues.GrammarEnd };

            Run run229 = new Run() { RsidRunProperties = "007D7C37" };

            RunProperties runProperties228 = new RunProperties();
            Bold bold151 = new Bold();
            Italic italic45 = new Italic();
            FontSize fontSize248 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript248 = new FontSizeComplexScript() { Val = "22" };
            Underline underline113 = new Underline() { Val = UnderlineValues.Single };
            Languages languages89 = new Languages() { Val = "en-US" };

            runProperties228.Append(bold151);
            runProperties228.Append(italic45);
            runProperties228.Append(fontSize248);
            runProperties228.Append(fontSizeComplexScript248);
            runProperties228.Append(underline113);
            runProperties228.Append(languages89);
            Text text228 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text228.Text = "  №";

            run229.Append(runProperties228);
            run229.Append(text228);

            Run run230 = new Run() { RsidRunProperties = "007D7C37", RsidRunAddition = "00837ABE" };

            RunProperties runProperties229 = new RunProperties();
            Bold bold152 = new Bold();
            Italic italic46 = new Italic();
            FontSize fontSize249 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript249 = new FontSizeComplexScript() { Val = "22" };
            Underline underline114 = new Underline() { Val = UnderlineValues.Single };
            Languages languages90 = new Languages() { Val = "en-US" };

            runProperties229.Append(bold152);
            runProperties229.Append(italic46);
            runProperties229.Append(fontSize249);
            runProperties229.Append(fontSizeComplexScript249);
            runProperties229.Append(underline114);
            runProperties229.Append(languages90);
            Text text229 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text229.Text = " ";

            run230.Append(runProperties229);
            run230.Append(text229);
            ProofError proofError31 = new ProofError() { Type = ProofingErrorValues.SpellStart };

            Run run231 = new Run() { RsidRunAddition = "007D7C37" };

            RunProperties runProperties230 = new RunProperties();
            Bold bold153 = new Bold();
            Italic italic47 = new Italic();
            FontSize fontSize250 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript250 = new FontSizeComplexScript() { Val = "22" };
            Underline underline115 = new Underline() { Val = UnderlineValues.Single };
            Languages languages91 = new Languages() { Val = "en-US" };

            runProperties230.Append(bold153);
            runProperties230.Append(italic47);
            runProperties230.Append(fontSize250);
            runProperties230.Append(fontSizeComplexScript250);
            runProperties230.Append(underline115);
            runProperties230.Append(languages91);
            Text text230 = new Text();
            text230.Text = frm.packingListNumber.Text;

            run231.Append(runProperties230);
            run231.Append(text230);
            ProofError proofError32 = new ProofError() { Type = ProofingErrorValues.SpellEnd };

            Run run232 = new Run() { RsidRunProperties = "007D7C37", RsidRunAddition = "00837ABE" };

            RunProperties runProperties231 = new RunProperties();
            Bold bold154 = new Bold();
            Italic italic48 = new Italic();
            FontSize fontSize251 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript251 = new FontSizeComplexScript() { Val = "22" };
            Underline underline116 = new Underline() { Val = UnderlineValues.Single };
            Languages languages92 = new Languages() { Val = "en-US" };

            runProperties231.Append(bold154);
            runProperties231.Append(italic48);
            runProperties231.Append(fontSize251);
            runProperties231.Append(fontSizeComplexScript251);
            runProperties231.Append(underline116);
            runProperties231.Append(languages92);
            Text text231 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text231.Text = "  ";

            run232.Append(runProperties231);
            run232.Append(text231);

            Run run233 = new Run() { RsidRunProperties = "00E712AD", RsidRunAddition = "00111393" };

            RunProperties runProperties232 = new RunProperties();
            Bold bold155 = new Bold();
            Italic italic49 = new Italic();
            FontSize fontSize252 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript252 = new FontSizeComplexScript() { Val = "22" };
            Underline underline117 = new Underline() { Val = UnderlineValues.Single };

            runProperties232.Append(bold155);
            runProperties232.Append(italic49);
            runProperties232.Append(fontSize252);
            runProperties232.Append(fontSizeComplexScript252);
            runProperties232.Append(underline117);
            Text text232 = new Text();
            text232.Text = "от";

            run233.Append(runProperties232);
            run233.Append(text232);

            Run run234 = new Run() { RsidRunProperties = "007D7C37", RsidRunAddition = "004253C2" };

            RunProperties runProperties233 = new RunProperties();
            Bold bold156 = new Bold();
            Italic italic50 = new Italic();
            FontSize fontSize253 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript253 = new FontSizeComplexScript() { Val = "22" };
            Underline underline118 = new Underline() { Val = UnderlineValues.Single };
            Languages languages93 = new Languages() { Val = "en-US" };

            runProperties233.Append(bold156);
            runProperties233.Append(italic50);
            runProperties233.Append(fontSize253);
            runProperties233.Append(fontSizeComplexScript253);
            runProperties233.Append(underline118);
            runProperties233.Append(languages93);
            Text text233 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text233.Text = " ";

            run234.Append(runProperties233);
            run234.Append(text233);

            Run run235 = new Run() { RsidRunAddition = "007D7C37" };

            RunProperties runProperties234 = new RunProperties();
            Bold bold157 = new Bold();
            Italic italic51 = new Italic();
            FontSize fontSize254 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript254 = new FontSizeComplexScript() { Val = "22" };
            Underline underline119 = new Underline() { Val = UnderlineValues.Single };
            Languages languages94 = new Languages() { Val = "en-US" };

            runProperties234.Append(bold157);
            runProperties234.Append(italic51);
            runProperties234.Append(fontSize254);
            runProperties234.Append(fontSizeComplexScript254);
            runProperties234.Append(underline119);
            runProperties234.Append(languages94);
            Text text234 = new Text();
            text234.Text = frm.packingListDate.Value.ToShortDateString();

            run235.Append(runProperties234);
            run235.Append(text234);

            Run run236 = new Run() { RsidRunProperties = "007D7C37", RsidRunAddition = "00BC4AB2" };

            RunProperties runProperties235 = new RunProperties();
            Bold bold158 = new Bold();
            Italic italic52 = new Italic();
            FontSize fontSize255 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript255 = new FontSizeComplexScript() { Val = "22" };
            Languages languages95 = new Languages() { Val = "en-US" };

            runProperties235.Append(bold158);
            runProperties235.Append(italic52);
            runProperties235.Append(fontSize255);
            runProperties235.Append(fontSizeComplexScript255);
            runProperties235.Append(languages95);
            Text text235 = new Text();
            text235.Text = "___________________________________________";

            run236.Append(runProperties235);
            run236.Append(text235);

            Run run237 = new Run() { RsidRunProperties = "007D7C37", RsidRunAddition = "00E712AD" };

            RunProperties runProperties236 = new RunProperties();
            Bold bold159 = new Bold();
            Italic italic53 = new Italic();
            FontSize fontSize256 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript256 = new FontSizeComplexScript() { Val = "22" };
            Languages languages96 = new Languages() { Val = "en-US" };

            runProperties236.Append(bold159);
            runProperties236.Append(italic53);
            runProperties236.Append(fontSize256);
            runProperties236.Append(fontSizeComplexScript256);
            runProperties236.Append(languages96);
            Text text236 = new Text();
            text236.Text = "___";

            run237.Append(runProperties236);
            run237.Append(text236);

            Run run238 = new Run() { RsidRunProperties = "007D7C37", RsidRunAddition = "00BC4AB2" };

            RunProperties runProperties237 = new RunProperties();
            Bold bold160 = new Bold();
            Italic italic54 = new Italic();
            FontSize fontSize257 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript257 = new FontSizeComplexScript() { Val = "22" };
            Languages languages97 = new Languages() { Val = "en-US" };

            runProperties237.Append(bold160);
            runProperties237.Append(italic54);
            runProperties237.Append(fontSize257);
            runProperties237.Append(fontSizeComplexScript257);
            runProperties237.Append(languages97);
            Text text237 = new Text();
            text237.Text = "____";

            run238.Append(runProperties237);
            run238.Append(text237);

            Run run239 = new Run() { RsidRunProperties = "007D7C37", RsidRunAddition = "00797B85" };

            RunProperties runProperties238 = new RunProperties();
            Bold bold161 = new Bold();
            Italic italic55 = new Italic();
            FontSize fontSize258 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript258 = new FontSizeComplexScript() { Val = "22" };
            Languages languages98 = new Languages() { Val = "en-US" };

            runProperties238.Append(bold161);
            runProperties238.Append(italic55);
            runProperties238.Append(fontSize258);
            runProperties238.Append(fontSizeComplexScript258);
            runProperties238.Append(languages98);
            Text text238 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text238.Text = " ";

            run239.Append(runProperties238);
            run239.Append(text238);

            Run run240 = new Run() { RsidRunProperties = "007D7C37", RsidRunAddition = "002C48A4" };

            RunProperties runProperties239 = new RunProperties();
            Bold bold162 = new Bold();
            Italic italic56 = new Italic();
            FontSize fontSize259 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript259 = new FontSizeComplexScript() { Val = "22" };
            Languages languages99 = new Languages() { Val = "en-US" };

            runProperties239.Append(bold162);
            runProperties239.Append(italic56);
            runProperties239.Append(fontSize259);
            runProperties239.Append(fontSizeComplexScript259);
            runProperties239.Append(languages99);
            Text text239 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text239.Text = "                 ";

            run240.Append(runProperties239);
            run240.Append(text239);

            Run run241 = new Run() { RsidRunProperties = "007D7C37" };

            RunProperties runProperties240 = new RunProperties();
            Bold bold163 = new Bold();
            Italic italic57 = new Italic();
            FontSize fontSize260 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript260 = new FontSizeComplexScript() { Val = "22" };
            Languages languages100 = new Languages() { Val = "en-US" };

            runProperties240.Append(bold163);
            runProperties240.Append(italic57);
            runProperties240.Append(fontSize260);
            runProperties240.Append(fontSizeComplexScript260);
            runProperties240.Append(languages100);
            Text text240 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text240.Text = " ";

            run241.Append(runProperties240);
            run241.Append(text240);

            Run run242 = new Run() { RsidRunProperties = "007D7C37", RsidRunAddition = "006F5A99" };

            RunProperties runProperties241 = new RunProperties();
            Bold bold164 = new Bold();
            Italic italic58 = new Italic();
            FontSize fontSize261 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript261 = new FontSizeComplexScript() { Val = "22" };
            Languages languages101 = new Languages() { Val = "en-US" };

            runProperties241.Append(bold164);
            runProperties241.Append(italic58);
            runProperties241.Append(fontSize261);
            runProperties241.Append(fontSizeComplexScript261);
            runProperties241.Append(languages101);
            Text text241 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text241.Text = "5. ";

            run242.Append(runProperties241);
            run242.Append(text241);

            Run run243 = new Run() { RsidRunProperties = "00E712AD" };

            RunProperties runProperties242 = new RunProperties();
            Bold bold165 = new Bold();
            Italic italic59 = new Italic();
            FontSize fontSize262 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript262 = new FontSizeComplexScript() { Val = "22" };
            Underline underline120 = new Underline() { Val = UnderlineValues.Single };

            runProperties242.Append(bold165);
            runProperties242.Append(italic59);
            runProperties242.Append(fontSize262);
            runProperties242.Append(fontSizeComplexScript262);
            runProperties242.Append(underline120);
            Text text242 = new Text();
            text242.Text = "Паспорта";

            run243.Append(runProperties242);
            run243.Append(text242);

            Run run244 = new Run() { RsidRunProperties = "00E712AD", RsidRunAddition = "00BC4AB2" };

            RunProperties runProperties243 = new RunProperties();
            Bold bold166 = new Bold();
            Italic italic60 = new Italic();
            FontSize fontSize263 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript263 = new FontSizeComplexScript() { Val = "22" };

            runProperties243.Append(bold166);
            runProperties243.Append(italic60);
            runProperties243.Append(fontSize263);
            runProperties243.Append(fontSizeComplexScript263);
            Text text243 = new Text();
            text243.Text = "___________________________________________________________________";

            run244.Append(runProperties243);
            run244.Append(text243);

            Run run245 = new Run() { RsidRunAddition = "00E712AD" };

            RunProperties runProperties244 = new RunProperties();
            Bold bold167 = new Bold();
            Italic italic61 = new Italic();
            FontSize fontSize264 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript264 = new FontSizeComplexScript() { Val = "22" };

            runProperties244.Append(bold167);
            runProperties244.Append(italic61);
            runProperties244.Append(fontSize264);
            runProperties244.Append(fontSizeComplexScript264);
            Text text244 = new Text();
            text244.Text = "_____________";

            run245.Append(runProperties244);
            run245.Append(text244);

            Run run246 = new Run() { RsidRunProperties = "00E712AD", RsidRunAddition = "00BC4AB2" };

            RunProperties runProperties245 = new RunProperties();
            Bold bold168 = new Bold();
            Italic italic62 = new Italic();
            FontSize fontSize265 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript265 = new FontSizeComplexScript() { Val = "22" };

            runProperties245.Append(bold168);
            runProperties245.Append(italic62);
            runProperties245.Append(fontSize265);
            runProperties245.Append(fontSizeComplexScript265);
            Text text245 = new Text();
            text245.Text = "__";

            run246.Append(runProperties245);
            run246.Append(text245);

            paragraph36.Append(paragraphProperties36);
            paragraph36.Append(run224);
            paragraph36.Append(proofError29);
            paragraph36.Append(run225);
            paragraph36.Append(run226);
            paragraph36.Append(run227);
            paragraph36.Append(run228);
            paragraph36.Append(proofError30);
            paragraph36.Append(run229);
            paragraph36.Append(run230);
            paragraph36.Append(proofError31);
            paragraph36.Append(run231);
            paragraph36.Append(proofError32);
            paragraph36.Append(run232);
            paragraph36.Append(run233);
            paragraph36.Append(run234);
            paragraph36.Append(run235);
            paragraph36.Append(run236);
            paragraph36.Append(run237);
            paragraph36.Append(run238);
            paragraph36.Append(run239);
            paragraph36.Append(run240);
            paragraph36.Append(run241);
            paragraph36.Append(run242);
            paragraph36.Append(run243);
            paragraph36.Append(run244);
            paragraph36.Append(run245);
            paragraph36.Append(run246);

            Paragraph paragraph37 = new Paragraph() { RsidParagraphMarkRevision = "00E712AD", RsidParagraphAddition = "008B376E", RsidParagraphProperties = "002C48A4", RsidRunAdditionDefault = "006F5A99" };

            ParagraphProperties paragraphProperties37 = new ParagraphProperties();
            AutoSpaceDE autoSpaceDE23 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN23 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent23 = new AdjustRightIndent() { Val = false };
            Indentation indentation9 = new Indentation() { End = "-649" };

            ParagraphMarkRunProperties paragraphMarkRunProperties37 = new ParagraphMarkRunProperties();
            Bold bold169 = new Bold();
            Italic italic63 = new Italic();
            FontSize fontSize266 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript266 = new FontSizeComplexScript() { Val = "22" };
            Underline underline121 = new Underline() { Val = UnderlineValues.Single };

            paragraphMarkRunProperties37.Append(bold169);
            paragraphMarkRunProperties37.Append(italic63);
            paragraphMarkRunProperties37.Append(fontSize266);
            paragraphMarkRunProperties37.Append(fontSizeComplexScript266);
            paragraphMarkRunProperties37.Append(underline121);

            paragraphProperties37.Append(autoSpaceDE23);
            paragraphProperties37.Append(autoSpaceDN23);
            paragraphProperties37.Append(adjustRightIndent23);
            paragraphProperties37.Append(indentation9);
            paragraphProperties37.Append(paragraphMarkRunProperties37);

            Run run247 = new Run() { RsidRunProperties = "00E712AD" };

            RunProperties runProperties246 = new RunProperties();
            Bold bold170 = new Bold();
            Italic italic64 = new Italic();
            FontSize fontSize267 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript267 = new FontSizeComplexScript() { Val = "22" };

            runProperties246.Append(bold170);
            runProperties246.Append(italic64);
            runProperties246.Append(fontSize267);
            runProperties246.Append(fontSizeComplexScript267);
            Text text246 = new Text();
            text246.Text = "6";

            run247.Append(runProperties246);
            run247.Append(text246);

            Run run248 = new Run() { RsidRunProperties = "00E712AD", RsidRunAddition = "00E23013" };

            RunProperties runProperties247 = new RunProperties();
            Bold bold171 = new Bold();
            Italic italic65 = new Italic();
            FontSize fontSize268 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript268 = new FontSizeComplexScript() { Val = "22" };

            runProperties247.Append(bold171);
            runProperties247.Append(italic65);
            runProperties247.Append(fontSize268);
            runProperties247.Append(fontSizeComplexScript268);
            Text text247 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text247.Text = ". ";

            run248.Append(runProperties247);
            run248.Append(text247);

            Run run249 = new Run() { RsidRunProperties = "00E712AD", RsidRunAddition = "00E23013" };

            RunProperties runProperties248 = new RunProperties();
            Bold bold172 = new Bold();
            Italic italic66 = new Italic();
            FontSize fontSize269 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript269 = new FontSizeComplexScript() { Val = "22" };
            Underline underline122 = new Underline() { Val = UnderlineValues.Single };

            runProperties248.Append(bold172);
            runProperties248.Append(italic66);
            runProperties248.Append(fontSize269);
            runProperties248.Append(fontSizeComplexScript269);
            runProperties248.Append(underline122);
            Text text248 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text248.Text = "Калькуляции ";

            run249.Append(runProperties248);
            run249.Append(text248);

            Run run250 = new Run() { RsidRunProperties = "00E712AD", RsidRunAddition = "008B376E" };

            RunProperties runProperties249 = new RunProperties();
            Bold bold173 = new Bold();
            Italic italic67 = new Italic();
            FontSize fontSize270 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript270 = new FontSizeComplexScript() { Val = "22" };
            Underline underline123 = new Underline() { Val = UnderlineValues.Single };

            runProperties249.Append(bold173);
            runProperties249.Append(italic67);
            runProperties249.Append(fontSize270);
            runProperties249.Append(fontSizeComplexScript270);
            runProperties249.Append(underline123);
            Text text249 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text249.Text = " ";

            run250.Append(runProperties249);
            run250.Append(text249);

            Run run251 = new Run() { RsidRunProperties = "00E712AD", RsidRunAddition = "00AE2D12" };

            RunProperties runProperties250 = new RunProperties();
            Bold bold174 = new Bold();
            Italic italic68 = new Italic();
            FontSize fontSize271 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript271 = new FontSizeComplexScript() { Val = "22" };
            Underline underline124 = new Underline() { Val = UnderlineValues.Single };

            runProperties250.Append(bold174);
            runProperties250.Append(italic68);
            runProperties250.Append(fontSize271);
            runProperties250.Append(fontSizeComplexScript271);
            runProperties250.Append(underline124);
            Text text250 = new Text();
            text250.Text = "себестоимости продукции";

            run251.Append(runProperties250);
            run251.Append(text250);

            Run run252 = new Run() { RsidRunProperties = "00E712AD", RsidRunAddition = "00AE2D12" };

            RunProperties runProperties251 = new RunProperties();
            Bold bold175 = new Bold();
            Italic italic69 = new Italic();
            FontSize fontSize272 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript272 = new FontSizeComplexScript() { Val = "22" };

            runProperties251.Append(bold175);
            runProperties251.Append(italic69);
            runProperties251.Append(fontSize272);
            runProperties251.Append(fontSizeComplexScript272);
            Text text251 = new Text();
            text251.Text = "_____________";

            run252.Append(runProperties251);
            run252.Append(text251);

            Run run253 = new Run() { RsidRunProperties = "00E712AD", RsidRunAddition = "008B376E" };

            RunProperties runProperties252 = new RunProperties();
            Bold bold176 = new Bold();
            Italic italic70 = new Italic();
            FontSize fontSize273 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript273 = new FontSizeComplexScript() { Val = "22" };

            runProperties252.Append(bold176);
            runProperties252.Append(italic70);
            runProperties252.Append(fontSize273);
            runProperties252.Append(fontSizeComplexScript273);
            Text text252 = new Text();
            text252.Text = "_________________________________________";

            run253.Append(runProperties252);
            run253.Append(text252);

            paragraph37.Append(paragraphProperties37);
            paragraph37.Append(run247);
            paragraph37.Append(run248);
            paragraph37.Append(run249);
            paragraph37.Append(run250);
            paragraph37.Append(run251);
            paragraph37.Append(run252);
            paragraph37.Append(run253);

            Paragraph paragraph38 = new Paragraph() { RsidParagraphMarkRevision = "00E051D4", RsidParagraphAddition = "00196FCC", RsidParagraphProperties = "001F040D", RsidRunAdditionDefault = "006F5A99" };

            ParagraphProperties paragraphProperties38 = new ParagraphProperties();
            AutoSpaceDE autoSpaceDE24 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN24 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent24 = new AdjustRightIndent() { Val = false };
            Indentation indentation10 = new Indentation() { End = "-649" };

            ParagraphMarkRunProperties paragraphMarkRunProperties38 = new ParagraphMarkRunProperties();
            Bold bold177 = new Bold();
            FontSize fontSize274 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript274 = new FontSizeComplexScript() { Val = "22" };

            paragraphMarkRunProperties38.Append(bold177);
            paragraphMarkRunProperties38.Append(fontSize274);
            paragraphMarkRunProperties38.Append(fontSizeComplexScript274);

            paragraphProperties38.Append(autoSpaceDE24);
            paragraphProperties38.Append(autoSpaceDN24);
            paragraphProperties38.Append(adjustRightIndent24);
            paragraphProperties38.Append(indentation10);
            paragraphProperties38.Append(paragraphMarkRunProperties38);

            Run run254 = new Run() { RsidRunProperties = "00E712AD" };

            RunProperties runProperties253 = new RunProperties();
            Bold bold178 = new Bold();
            Italic italic71 = new Italic();
            FontSize fontSize275 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript275 = new FontSizeComplexScript() { Val = "22" };

            runProperties253.Append(bold178);
            runProperties253.Append(italic71);
            runProperties253.Append(fontSize275);
            runProperties253.Append(fontSizeComplexScript275);
            Text text253 = new Text();
            text253.Text = "7";

            run254.Append(runProperties253);
            run254.Append(text253);

            Run run255 = new Run() { RsidRunProperties = "00E712AD", RsidRunAddition = "00E23013" };

            RunProperties runProperties254 = new RunProperties();
            Bold bold179 = new Bold();
            Italic italic72 = new Italic();
            FontSize fontSize276 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript276 = new FontSizeComplexScript() { Val = "22" };

            runProperties254.Append(bold179);
            runProperties254.Append(italic72);
            runProperties254.Append(fontSize276);
            runProperties254.Append(fontSizeComplexScript276);
            Text text254 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text254.Text = ". ";

            run255.Append(runProperties254);
            run255.Append(text254);

            Run run256 = new Run() { RsidRunProperties = "00E712AD", RsidRunAddition = "002A47F5" };

            RunProperties runProperties255 = new RunProperties();
            Bold bold180 = new Bold();
            Italic italic73 = new Italic();
            FontSize fontSize277 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript277 = new FontSizeComplexScript() { Val = "22" };
            Underline underline125 = new Underline() { Val = UnderlineValues.Single };

            runProperties255.Append(bold180);
            runProperties255.Append(italic73);
            runProperties255.Append(fontSize277);
            runProperties255.Append(fontSizeComplexScript277);
            runProperties255.Append(underline125);
            Text text255 = new Text();
            text255.Text = "Производственная справка  №";

            run256.Append(runProperties255);
            run256.Append(text255);

            Run run257 = new Run() { RsidRunProperties = "00E712AD", RsidRunAddition = "008D6276" };

            RunProperties runProperties256 = new RunProperties();
            Bold bold181 = new Bold();
            Italic italic74 = new Italic();
            FontSize fontSize278 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript278 = new FontSizeComplexScript() { Val = "22" };
            Underline underline126 = new Underline() { Val = UnderlineValues.Single };

            runProperties256.Append(bold181);
            runProperties256.Append(italic74);
            runProperties256.Append(fontSize278);
            runProperties256.Append(fontSizeComplexScript278);
            runProperties256.Append(underline126);
            Text text256 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text256.Text = " ";

            run257.Append(runProperties256);
            run257.Append(text256);
            ProofError proofError33 = new ProofError() { Type = ProofingErrorValues.SpellStart };

            Run run258 = new Run() { RsidRunAddition = "001F040D" };

            RunProperties runProperties257 = new RunProperties();
            Bold bold182 = new Bold();
            Italic italic75 = new Italic();
            FontSize fontSize279 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript279 = new FontSizeComplexScript() { Val = "22" };
            Underline underline127 = new Underline() { Val = UnderlineValues.Single };
            Languages languages102 = new Languages() { Val = "en-US" };

            runProperties257.Append(bold182);
            runProperties257.Append(italic75);
            runProperties257.Append(fontSize279);
            runProperties257.Append(fontSizeComplexScript279);
            runProperties257.Append(underline127);
            runProperties257.Append(languages102);
            Text text257 = new Text();
            text257.Text = frm.prodRefNumber.Text;

            run258.Append(runProperties257);
            run258.Append(text257);
            ProofError proofError34 = new ProofError() { Type = ProofingErrorValues.SpellEnd };

            Run run259 = new Run() { RsidRunProperties = "00E712AD", RsidRunAddition = "00D32723" };

            RunProperties runProperties258 = new RunProperties();
            Bold bold183 = new Bold();
            Italic italic76 = new Italic();
            FontSize fontSize280 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript280 = new FontSizeComplexScript() { Val = "22" };
            Underline underline128 = new Underline() { Val = UnderlineValues.Single };

            runProperties258.Append(bold183);
            runProperties258.Append(italic76);
            runProperties258.Append(fontSize280);
            runProperties258.Append(fontSizeComplexScript280);
            runProperties258.Append(underline128);
            Text text258 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text258.Text = " ";

            run259.Append(runProperties258);
            run259.Append(text258);

            Run run260 = new Run() { RsidRunProperties = "00E712AD", RsidRunAddition = "00E23013" };

            RunProperties runProperties259 = new RunProperties();
            Bold bold184 = new Bold();
            Italic italic77 = new Italic();
            FontSize fontSize281 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript281 = new FontSizeComplexScript() { Val = "22" };
            Underline underline129 = new Underline() { Val = UnderlineValues.Single };

            runProperties259.Append(bold184);
            runProperties259.Append(italic77);
            runProperties259.Append(fontSize281);
            runProperties259.Append(fontSizeComplexScript281);
            runProperties259.Append(underline129);
            Text text259 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text259.Text = "от ";

            run260.Append(runProperties259);
            run260.Append(text259);
            ProofError proofError35 = new ProofError() { Type = ProofingErrorValues.SpellStart };

            Run run261 = new Run() { RsidRunAddition = "001F040D" };

            RunProperties runProperties260 = new RunProperties();
            Bold bold185 = new Bold();
            Italic italic78 = new Italic();
            FontSize fontSize282 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript282 = new FontSizeComplexScript() { Val = "22" };
            Underline underline130 = new Underline() { Val = UnderlineValues.Single };
            Languages languages103 = new Languages() { Val = "en-US" };

            runProperties260.Append(bold185);
            runProperties260.Append(italic78);
            runProperties260.Append(fontSize282);
            runProperties260.Append(fontSizeComplexScript282);
            runProperties260.Append(underline130);
            runProperties260.Append(languages103);
            Text text260 = new Text();
            text260.Text = frm.prodRefDate.Value.ToShortDateString();

            run261.Append(runProperties260);
            run261.Append(text260);
            ProofError proofError36 = new ProofError() { Type = ProofingErrorValues.SpellEnd };

            Run run262 = new Run() { RsidRunProperties = "00E712AD", RsidRunAddition = "00BC4AB2" };

            RunProperties runProperties261 = new RunProperties();
            Bold bold186 = new Bold();
            Italic italic79 = new Italic();
            FontSize fontSize283 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript283 = new FontSizeComplexScript() { Val = "22" };

            runProperties261.Append(bold186);
            runProperties261.Append(italic79);
            runProperties261.Append(fontSize283);
            runProperties261.Append(fontSizeComplexScript283);
            Text text261 = new Text();
            text261.Text = "____________________________________";

            run262.Append(runProperties261);
            run262.Append(text261);

            Run run263 = new Run() { RsidRunAddition = "00E712AD" };

            RunProperties runProperties262 = new RunProperties();
            Bold bold187 = new Bold();
            Italic italic80 = new Italic();
            FontSize fontSize284 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript284 = new FontSizeComplexScript() { Val = "22" };

            runProperties262.Append(bold187);
            runProperties262.Append(italic80);
            runProperties262.Append(fontSize284);
            runProperties262.Append(fontSizeComplexScript284);
            Text text262 = new Text();
            text262.Text = "___";

            run263.Append(runProperties262);
            run263.Append(text262);

            Run run264 = new Run() { RsidRunProperties = "00E712AD", RsidRunAddition = "00BC4AB2" };

            RunProperties runProperties263 = new RunProperties();
            Bold bold188 = new Bold();
            Italic italic81 = new Italic();
            FontSize fontSize285 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript285 = new FontSizeComplexScript() { Val = "22" };

            runProperties263.Append(bold188);
            runProperties263.Append(italic81);
            runProperties263.Append(fontSize285);
            runProperties263.Append(fontSizeComplexScript285);
            Text text263 = new Text();
            text263.Text = "____";

            run264.Append(runProperties263);
            run264.Append(text263);

            paragraph38.Append(paragraphProperties38);
            paragraph38.Append(run254);
            paragraph38.Append(run255);
            paragraph38.Append(run256);
            paragraph38.Append(run257);
            paragraph38.Append(proofError33);
            paragraph38.Append(run258);
            paragraph38.Append(proofError34);
            paragraph38.Append(run259);
            paragraph38.Append(run260);
            paragraph38.Append(proofError35);
            paragraph38.Append(run261);
            paragraph38.Append(proofError36);
            paragraph38.Append(run262);
            paragraph38.Append(run263);
            paragraph38.Append(run264);

            tableCell7.Append(tableCellProperties7);
            tableCell7.Append(paragraph29);
            tableCell7.Append(paragraph30);
            tableCell7.Append(paragraph31);
            tableCell7.Append(paragraph32);
            tableCell7.Append(paragraph33);
            tableCell7.Append(paragraph34);
            tableCell7.Append(paragraph35);
            tableCell7.Append(paragraph36);
            tableCell7.Append(paragraph37);
            tableCell7.Append(paragraph38);

            tableRow3.Append(tableRowProperties3);
            tableRow3.Append(tableCell7);

            table2.Append(tableProperties2);
            table2.Append(tableGrid2);
            table2.Append(tableRow3);

            Paragraph paragraph39 = new Paragraph() { RsidParagraphMarkRevision = "00E051D4", RsidParagraphAddition = "00472260", RsidParagraphProperties = "006D47A7", RsidRunAdditionDefault = "00747EC9" };

            ParagraphProperties paragraphProperties39 = new ParagraphProperties();
            AutoSpaceDE autoSpaceDE25 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN25 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent25 = new AdjustRightIndent() { Val = false };
            Indentation indentation11 = new Indentation() { End = "-94" };
            Justification justification11 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties39 = new ParagraphMarkRunProperties();
            Bold bold189 = new Bold();
            FontSize fontSize286 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript286 = new FontSizeComplexScript() { Val = "22" };
            Underline underline131 = new Underline() { Val = UnderlineValues.Single };

            paragraphMarkRunProperties39.Append(bold189);
            paragraphMarkRunProperties39.Append(fontSize286);
            paragraphMarkRunProperties39.Append(fontSizeComplexScript286);
            paragraphMarkRunProperties39.Append(underline131);

            paragraphProperties39.Append(autoSpaceDE25);
            paragraphProperties39.Append(autoSpaceDN25);
            paragraphProperties39.Append(adjustRightIndent25);
            paragraphProperties39.Append(indentation11);
            paragraphProperties39.Append(justification11);
            paragraphProperties39.Append(paragraphMarkRunProperties39);

            Run run265 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties264 = new RunProperties();
            Bold bold190 = new Bold();
            FontSize fontSize287 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript287 = new FontSizeComplexScript() { Val = "22" };

            runProperties264.Append(bold190);
            runProperties264.Append(fontSize287);
            runProperties264.Append(fontSizeComplexScript287);
            Text text264 = new Text();
            text264.Text = "8.";

            run265.Append(runProperties264);
            run265.Append(text264);

            Run run266 = new Run() { RsidRunAddition = "00EC7250" };

            RunProperties runProperties265 = new RunProperties();
            Bold bold191 = new Bold();
            FontSize fontSize288 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript288 = new FontSizeComplexScript() { Val = "22" };

            runProperties265.Append(bold191);
            runProperties265.Append(fontSize288);
            runProperties265.Append(fontSizeComplexScript288);
            Text text265 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text265.Text = " ";

            run266.Append(runProperties265);
            run266.Append(text265);

            Run run267 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties266 = new RunProperties();
            Bold bold192 = new Bold();
            FontSize fontSize289 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript289 = new FontSizeComplexScript() { Val = "22" };
            Underline underline132 = new Underline() { Val = UnderlineValues.Single };

            runProperties266.Append(bold192);
            runProperties266.Append(fontSize289);
            runProperties266.Append(fontSizeComplexScript289);
            runProperties266.Append(underline132);
            Text text266 = new Text();
            text266.Text = "Экспертное заключение опредиляющае код товара № К-661 от 15.10.2013г.";

            run267.Append(runProperties266);
            run267.Append(text266);

            Run run268 = new Run() { RsidRunProperties = "00E712AD" };

            RunProperties runProperties267 = new RunProperties();
            Bold bold193 = new Bold();
            FontSize fontSize290 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript290 = new FontSizeComplexScript() { Val = "22" };

            runProperties267.Append(bold193);
            runProperties267.Append(fontSize290);
            runProperties267.Append(fontSizeComplexScript290);
            Text text267 = new Text();
            text267.Text = "_____________________";

            run268.Append(runProperties267);
            run268.Append(text267);

            Run run269 = new Run() { RsidRunProperties = "00E712AD", RsidRunAddition = "006D47A7" };

            RunProperties runProperties268 = new RunProperties();
            Bold bold194 = new Bold();
            FontSize fontSize291 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript291 = new FontSizeComplexScript() { Val = "22" };

            runProperties268.Append(bold194);
            runProperties268.Append(fontSize291);
            runProperties268.Append(fontSizeComplexScript291);
            Text text268 = new Text();
            text268.Text = "__";

            run269.Append(runProperties268);
            run269.Append(text268);

            Run run270 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties269 = new RunProperties();
            Bold bold195 = new Bold();
            FontSize fontSize292 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript292 = new FontSizeComplexScript() { Val = "22" };
            Underline underline133 = new Underline() { Val = UnderlineValues.Single };

            runProperties269.Append(bold195);
            runProperties269.Append(fontSize292);
            runProperties269.Append(fontSizeComplexScript292);
            runProperties269.Append(underline133);
            Text text269 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text269.Text = " ";

            run270.Append(runProperties269);
            run270.Append(text269);

            paragraph39.Append(paragraphProperties39);
            paragraph39.Append(run265);
            paragraph39.Append(run266);
            paragraph39.Append(run267);
            paragraph39.Append(run268);
            paragraph39.Append(run269);
            paragraph39.Append(run270);

            Paragraph paragraph40 = new Paragraph() { RsidParagraphMarkRevision = "00E051D4", RsidParagraphAddition = "00C47F9D", RsidParagraphProperties = "006B3263", RsidRunAdditionDefault = "001670B4" };

            ParagraphProperties paragraphProperties40 = new ParagraphProperties();
            AutoSpaceDE autoSpaceDE26 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN26 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent26 = new AdjustRightIndent() { Val = false };
            Justification justification12 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties40 = new ParagraphMarkRunProperties();
            Bold bold196 = new Bold();
            FontSize fontSize293 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript293 = new FontSizeComplexScript() { Val = "22" };
            Underline underline134 = new Underline() { Val = UnderlineValues.Single };

            paragraphMarkRunProperties40.Append(bold196);
            paragraphMarkRunProperties40.Append(fontSize293);
            paragraphMarkRunProperties40.Append(fontSizeComplexScript293);
            paragraphMarkRunProperties40.Append(underline134);

            paragraphProperties40.Append(autoSpaceDE26);
            paragraphProperties40.Append(autoSpaceDN26);
            paragraphProperties40.Append(adjustRightIndent26);
            paragraphProperties40.Append(justification12);
            paragraphProperties40.Append(paragraphMarkRunProperties40);

            Run run271 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties270 = new RunProperties();
            Bold bold197 = new Bold();
            FontSize fontSize294 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript294 = new FontSizeComplexScript() { Val = "22" };

            runProperties270.Append(bold197);
            runProperties270.Append(fontSize294);
            runProperties270.Append(fontSizeComplexScript294);
            Text text270 = new Text();
            text270.Text = "9.";

            run271.Append(runProperties270);
            run271.Append(text270);

            Run run272 = new Run() { RsidRunAddition = "00EC7250" };

            RunProperties runProperties271 = new RunProperties();
            Bold bold198 = new Bold();
            FontSize fontSize295 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript295 = new FontSizeComplexScript() { Val = "22" };

            runProperties271.Append(bold198);
            runProperties271.Append(fontSize295);
            runProperties271.Append(fontSizeComplexScript295);
            Text text271 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text271.Text = " ";

            run272.Append(runProperties271);
            run272.Append(text271);

            Run run273 = new Run() { RsidRunAddition = "006D1423" };

            RunProperties runProperties272 = new RunProperties();
            Bold bold199 = new Bold();
            FontSize fontSize296 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript296 = new FontSizeComplexScript() { Val = "22" };
            Underline underline135 = new Underline() { Val = UnderlineValues.Single };

            runProperties272.Append(bold199);
            runProperties272.Append(fontSize296);
            runProperties272.Append(fontSizeComplexScript296);
            runProperties272.Append(underline135);
            Text text272 = new Text();
            text272.Text = "Копия договора";

            run273.Append(runProperties272);
            run273.Append(text272);

            Run run274 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "000B69EC" };

            RunProperties runProperties273 = new RunProperties();
            Bold bold200 = new Bold();
            FontSize fontSize297 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript297 = new FontSizeComplexScript() { Val = "22" };
            Underline underline136 = new Underline() { Val = UnderlineValues.Single };

            runProperties273.Append(bold200);
            runProperties273.Append(fontSize297);
            runProperties273.Append(fontSizeComplexScript297);
            runProperties273.Append(underline136);
            Text text273 = new Text();
            text273.Text = ".";

            run274.Append(runProperties273);
            run274.Append(text273);

            Run run275 = new Run() { RsidRunAddition = "006D1423" };

            RunProperties runProperties274 = new RunProperties();
            Bold bold201 = new Bold();
            FontSize fontSize298 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript298 = new FontSizeComplexScript() { Val = "22" };
            Underline underline137 = new Underline() { Val = UnderlineValues.Single };

            runProperties274.Append(bold201);
            runProperties274.Append(fontSize298);
            runProperties274.Append(fontSizeComplexScript298);
            runProperties274.Append(underline137);
            Text text274 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text274.Text = " ";

            run275.Append(runProperties274);
            run275.Append(text274);

            Run run276 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "000B69EC" };

            RunProperties runProperties275 = new RunProperties();
            Bold bold202 = new Bold();
            FontSize fontSize299 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript299 = new FontSizeComplexScript() { Val = "22" };
            Underline underline138 = new Underline() { Val = UnderlineValues.Single };

            runProperties275.Append(bold202);
            runProperties275.Append(fontSize299);
            runProperties275.Append(fontSizeComplexScript299);
            runProperties275.Append(underline138);
            Text text275 = new Text();
            text275.Text = "Номер и дату договора просим указать в сертификате происхождения.";

            run276.Append(runProperties275);
            run276.Append(text275);

            Run run277 = new Run() { RsidRunAddition = "00BC4AB2" };

            RunProperties runProperties276 = new RunProperties();
            Bold bold203 = new Bold();
            FontSize fontSize300 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript300 = new FontSizeComplexScript() { Val = "22" };
            Underline underline139 = new Underline() { Val = UnderlineValues.Single };

            runProperties276.Append(bold203);
            runProperties276.Append(fontSize300);
            runProperties276.Append(fontSizeComplexScript300);
            runProperties276.Append(underline139);
            Text text276 = new Text();
            text276.Text = "___________";

            run277.Append(runProperties276);
            run277.Append(text276);

            paragraph40.Append(paragraphProperties40);
            paragraph40.Append(run271);
            paragraph40.Append(run272);
            paragraph40.Append(run273);
            paragraph40.Append(run274);
            paragraph40.Append(run275);
            paragraph40.Append(run276);
            paragraph40.Append(run277);

            Paragraph paragraph41 = new Paragraph() { RsidParagraphMarkRevision = "00766E08", RsidParagraphAddition = "00472260", RsidParagraphProperties = "006B3263", RsidRunAdditionDefault = "00092ACE" };

            ParagraphProperties paragraphProperties41 = new ParagraphProperties();
            AutoSpaceDE autoSpaceDE27 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN27 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent27 = new AdjustRightIndent() { Val = false };
            Justification justification13 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties41 = new ParagraphMarkRunProperties();
            Bold bold204 = new Bold();
            Underline underline140 = new Underline() { Val = UnderlineValues.Single };

            paragraphMarkRunProperties41.Append(bold204);
            paragraphMarkRunProperties41.Append(underline140);

            paragraphProperties41.Append(autoSpaceDE27);
            paragraphProperties41.Append(autoSpaceDN27);
            paragraphProperties41.Append(adjustRightIndent27);
            paragraphProperties41.Append(justification13);
            paragraphProperties41.Append(paragraphMarkRunProperties41);

            Run run278 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties277 = new RunProperties();
            FontSize fontSize301 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript301 = new FontSizeComplexScript() { Val = "22" };

            runProperties277.Append(fontSize301);
            runProperties277.Append(fontSizeComplexScript301);
            Text text277 = new Text();
            text277.Text = "Товары изготовлены предприятием (наименование, адрес, страна)";

            run278.Append(runProperties277);
            run278.Append(text277);

            Run run279 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "000C4846" };

            RunProperties runProperties278 = new RunProperties();
            FontSize fontSize302 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript302 = new FontSizeComplexScript() { Val = "22" };

            runProperties278.Append(fontSize302);
            runProperties278.Append(fontSizeComplexScript302);
            Text text278 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text278.Text = ": ";

            run279.Append(runProperties278);
            run279.Append(text278);
            ProofError proofError37 = new ProofError() { Type = ProofingErrorValues.SpellStart };
            ProofError proofError38 = new ProofError() { Type = ProofingErrorValues.GrammarStart };

            Run run280 = new Run() { RsidRunAddition = "00151B89" };

            RunProperties runProperties279 = new RunProperties();
            Bold bold205 = new Bold();
            Underline underline141 = new Underline() { Val = UnderlineValues.Single };
            Languages languages104 = new Languages() { Val = "en-US" };

            runProperties279.Append(bold205);
            runProperties279.Append(underline141);
            runProperties279.Append(languages104);
            Text text279 = new Text();
            text279.Text = frm.productList.Text;

            run280.Append(runProperties279);
            run280.Append(text279);
            ProofError proofError39 = new ProofError() { Type = ProofingErrorValues.SpellEnd };

            Run run281 = new Run() { RsidRunProperties = "00766E08", RsidRunAddition = "006D47A7" };

            RunProperties runProperties280 = new RunProperties();
            Bold bold206 = new Bold();
            Underline underline142 = new Underline() { Val = UnderlineValues.Single };

            runProperties280.Append(bold206);
            runProperties280.Append(underline142);
            Text text280 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text280.Text = " ";

            run281.Append(runProperties280);
            run281.Append(text280);

            Run run282 = new Run() { RsidRunProperties = "00766E08", RsidRunAddition = "009B60CD" };

            RunProperties runProperties281 = new RunProperties();
            Bold bold207 = new Bold();
            Underline underline143 = new Underline() { Val = UnderlineValues.Single };

            runProperties281.Append(bold207);
            runProperties281.Append(underline143);
            Text text281 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text281.Text = " ";

            run282.Append(runProperties281);
            run282.Append(text281);

            Run run283 = new Run() { RsidRunProperties = "00766E08", RsidRunAddition = "00246B2E" };

            RunProperties runProperties282 = new RunProperties();
            Bold bold208 = new Bold();
            Underline underline144 = new Underline() { Val = UnderlineValues.Single };

            runProperties282.Append(bold208);
            runProperties282.Append(underline144);
            Text text282 = new Text();
            text282.Text = "-";

            run283.Append(runProperties282);
            run283.Append(text282);
            ProofError proofError40 = new ProofError() { Type = ProofingErrorValues.GrammarEnd };

            Run run284 = new Run() { RsidRunProperties = "00766E08", RsidRunAddition = "00EC7250" };

            RunProperties runProperties283 = new RunProperties();
            Bold bold209 = new Bold();
            Underline underline145 = new Underline() { Val = UnderlineValues.Single };

            runProperties283.Append(bold209);
            runProperties283.Append(underline145);
            Text text283 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text283.Text = " ";

            run284.Append(runProperties283);
            run284.Append(text283);

            Run run285 = new Run() { RsidRunProperties = "00766E08", RsidRunAddition = "0090734F" };

            RunProperties runProperties284 = new RunProperties();
            Bold bold210 = new Bold();
            Underline underline146 = new Underline() { Val = UnderlineValues.Single };

            runProperties284.Append(bold210);
            runProperties284.Append(underline146);
            Text text284 = new Text();
            text284.Text = "ООО";

            run285.Append(runProperties284);
            run285.Append(text284);

            Run run286 = new Run() { RsidRunProperties = "00766E08", RsidRunAddition = "00DF0137" };

            RunProperties runProperties285 = new RunProperties();
            Bold bold211 = new Bold();
            Underline underline147 = new Underline() { Val = UnderlineValues.Single };

            runProperties285.Append(bold211);
            runProperties285.Append(underline147);
            Text text285 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text285.Text = " «";

            run286.Append(runProperties285);
            run286.Append(text285);
            ProofError proofError41 = new ProofError() { Type = ProofingErrorValues.SpellStart };

            Run run287 = new Run() { RsidRunProperties = "00766E08", RsidRunAddition = "0090734F" };

            RunProperties runProperties286 = new RunProperties();
            Bold bold212 = new Bold();
            Underline underline148 = new Underline() { Val = UnderlineValues.Single };

            runProperties286.Append(bold212);
            runProperties286.Append(underline148);
            Text text286 = new Text();
            text286.Text = "Разек";

            run287.Append(runProperties286);
            run287.Append(text286);
            ProofError proofError42 = new ProofError() { Type = ProofingErrorValues.SpellEnd };

            Run run288 = new Run() { RsidRunProperties = "00766E08", RsidRunAddition = "0090734F" };

            RunProperties runProperties287 = new RunProperties();
            Bold bold213 = new Bold();
            Underline underline149 = new Underline() { Val = UnderlineValues.Single };

            runProperties287.Append(bold213);
            runProperties287.Append(underline149);
            Text text287 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text287.Text = " Черкассы";

            run288.Append(runProperties287);
            run288.Append(text287);

            Run run289 = new Run() { RsidRunProperties = "00766E08", RsidRunAddition = "00DF0137" };

            RunProperties runProperties288 = new RunProperties();
            Bold bold214 = new Bold();
            Underline underline150 = new Underline() { Val = UnderlineValues.Single };

            runProperties288.Append(bold214);
            runProperties288.Append(underline150);
            Text text288 = new Text();
            text288.Text = "», г. Черкассы";

            run289.Append(runProperties288);
            run289.Append(text288);

            Run run290 = new Run() { RsidRunProperties = "00766E08", RsidRunAddition = "0005359F" };

            RunProperties runProperties289 = new RunProperties();
            Bold bold215 = new Bold();
            Underline underline151 = new Underline() { Val = UnderlineValues.Single };

            runProperties289.Append(bold215);
            runProperties289.Append(underline151);
            Text text289 = new Text();
            text289.Text = ".";

            run290.Append(runProperties289);
            run290.Append(text289);

            paragraph41.Append(paragraphProperties41);
            paragraph41.Append(run278);
            paragraph41.Append(run279);
            paragraph41.Append(proofError37);
            paragraph41.Append(proofError38);
            paragraph41.Append(run280);
            paragraph41.Append(proofError39);
            paragraph41.Append(run281);
            paragraph41.Append(run282);
            paragraph41.Append(run283);
            paragraph41.Append(proofError40);
            paragraph41.Append(run284);
            paragraph41.Append(run285);
            paragraph41.Append(run286);
            paragraph41.Append(proofError41);
            paragraph41.Append(run287);
            paragraph41.Append(proofError42);
            paragraph41.Append(run288);
            paragraph41.Append(run289);
            paragraph41.Append(run290);

            Paragraph paragraph42 = new Paragraph() { RsidParagraphMarkRevision = "00766E08", RsidParagraphAddition = "00EC7250", RsidParagraphProperties = "006B3263", RsidRunAdditionDefault = "00EC7250" };

            ParagraphProperties paragraphProperties42 = new ParagraphProperties();
            AutoSpaceDE autoSpaceDE28 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN28 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent28 = new AdjustRightIndent() { Val = false };
            Justification justification14 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties42 = new ParagraphMarkRunProperties();
            Bold bold216 = new Bold();
            Underline underline152 = new Underline() { Val = UnderlineValues.Single };

            paragraphMarkRunProperties42.Append(bold216);
            paragraphMarkRunProperties42.Append(underline152);

            paragraphProperties42.Append(autoSpaceDE28);
            paragraphProperties42.Append(autoSpaceDN28);
            paragraphProperties42.Append(adjustRightIndent28);
            paragraphProperties42.Append(justification14);
            paragraphProperties42.Append(paragraphMarkRunProperties42);

            paragraph42.Append(paragraphProperties42);

            Paragraph paragraph43 = new Paragraph() { RsidParagraphMarkRevision = "00E051D4", RsidParagraphAddition = "00C47F9D", RsidParagraphProperties = "006B3263", RsidRunAdditionDefault = "00092ACE" };

            ParagraphProperties paragraphProperties43 = new ParagraphProperties();
            AutoSpaceDE autoSpaceDE29 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN29 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent29 = new AdjustRightIndent() { Val = false };
            Justification justification15 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties43 = new ParagraphMarkRunProperties();
            FontSize fontSize303 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript303 = new FontSizeComplexScript() { Val = "22" };

            paragraphMarkRunProperties43.Append(fontSize303);
            paragraphMarkRunProperties43.Append(fontSizeComplexScript303);

            paragraphProperties43.Append(autoSpaceDE29);
            paragraphProperties43.Append(autoSpaceDN29);
            paragraphProperties43.Append(adjustRightIndent29);
            paragraphProperties43.Append(justification15);
            paragraphProperties43.Append(paragraphMarkRunProperties43);

            Run run291 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties290 = new RunProperties();
            FontSize fontSize304 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript304 = new FontSizeComplexScript() { Val = "22" };

            runProperties290.Append(fontSize304);
            runProperties290.Append(fontSizeComplexScript304);
            Text text290 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text290.Text = "Заказчик заявляет, что данные, указанные выше, являются достоверными, товары происходят ";

            run291.Append(runProperties290);
            run291.Append(text290);

            paragraph43.Append(paragraphProperties43);
            paragraph43.Append(run291);

            Paragraph paragraph44 = new Paragraph() { RsidParagraphMarkRevision = "00E051D4", RsidParagraphAddition = "00F17A99", RsidParagraphProperties = "006B3263", RsidRunAdditionDefault = "00092ACE" };

            ParagraphProperties paragraphProperties44 = new ParagraphProperties();
            AutoSpaceDE autoSpaceDE30 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN30 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent30 = new AdjustRightIndent() { Val = false };
            Justification justification16 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties44 = new ParagraphMarkRunProperties();
            FontSize fontSize305 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript305 = new FontSizeComplexScript() { Val = "22" };

            paragraphMarkRunProperties44.Append(fontSize305);
            paragraphMarkRunProperties44.Append(fontSizeComplexScript305);

            paragraphProperties44.Append(autoSpaceDE30);
            paragraphProperties44.Append(autoSpaceDN30);
            paragraphProperties44.Append(adjustRightIndent30);
            paragraphProperties44.Append(justification16);
            paragraphProperties44.Append(paragraphMarkRunProperties44);
            ProofError proofError43 = new ProofError() { Type = ProofingErrorValues.SpellStart };

            Run run292 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties291 = new RunProperties();
            FontSize fontSize306 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript306 = new FontSizeComplexScript() { Val = "22" };

            runProperties291.Append(fontSize306);
            runProperties291.Append(fontSizeComplexScript306);
            Text text291 = new Text();
            text291.Text = "из";

            run292.Append(runProperties291);
            run292.Append(text291);

            Run run293 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "00F92B85" };

            RunProperties runProperties292 = new RunProperties();
            FontSize fontSize307 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript307 = new FontSizeComplexScript() { Val = "22" };

            runProperties292.Append(fontSize307);
            runProperties292.Append(fontSizeComplexScript307);
            Text text292 = new Text();
            text292.Text = "____";

            run293.Append(runProperties292);
            run293.Append(text292);

            Run run294 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "00F92B85" };

            RunProperties runProperties293 = new RunProperties();
            Bold bold217 = new Bold();
            FontSize fontSize308 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript308 = new FontSizeComplexScript() { Val = "22" };
            Underline underline153 = new Underline() { Val = UnderlineValues.Single };

            runProperties293.Append(bold217);
            runProperties293.Append(fontSize308);
            runProperties293.Append(fontSizeComplexScript308);
            runProperties293.Append(underline153);
            Text text293 = new Text();
            text293.Text = "Украины";

            run294.Append(runProperties293);
            run294.Append(text293);
            ProofError proofError44 = new ProofError() { Type = ProofingErrorValues.SpellEnd };

            Run run295 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties294 = new RunProperties();
            FontSize fontSize309 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript309 = new FontSizeComplexScript() { Val = "22" };

            runProperties294.Append(fontSize309);
            runProperties294.Append(fontSizeComplexScript309);
            Text text294 = new Text();
            text294.Text = "_";

            run295.Append(runProperties294);
            run295.Append(text294);

            Run run296 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "007C0D8C" };

            RunProperties runProperties295 = new RunProperties();
            FontSize fontSize310 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript310 = new FontSizeComplexScript() { Val = "22" };

            runProperties295.Append(fontSize310);
            runProperties295.Append(fontSizeComplexScript310);
            Text text295 = new Text();
            text295.Text = "___";

            run296.Append(runProperties295);
            run296.Append(text295);

            Run run297 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "00F17A99" };

            RunProperties runProperties296 = new RunProperties();
            FontSize fontSize311 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript311 = new FontSizeComplexScript() { Val = "22" };

            runProperties296.Append(fontSize311);
            runProperties296.Append(fontSizeComplexScript311);
            Text text296 = new Text();
            text296.Text = "_";

            run297.Append(runProperties296);
            run297.Append(text296);

            Run run298 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties297 = new RunProperties();
            FontSize fontSize312 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript312 = new FontSizeComplexScript() { Val = "22" };

            runProperties297.Append(fontSize312);
            runProperties297.Append(fontSizeComplexScript312);
            Text text297 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text297.Text = " и";

            run298.Append(runProperties297);
            run298.Append(text297);

            Run run299 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "00F17A99" };

            RunProperties runProperties298 = new RunProperties();
            FontSize fontSize313 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript313 = new FontSizeComplexScript() { Val = "22" };

            runProperties298.Append(fontSize313);
            runProperties298.Append(fontSizeComplexScript313);
            Text text298 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text298.Text = " ";

            run299.Append(runProperties298);
            run299.Append(text298);

            Run run300 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties299 = new RunProperties();
            FontSize fontSize314 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript314 = new FontSizeComplexScript() { Val = "22" };

            runProperties299.Append(fontSize314);
            runProperties299.Append(fontSizeComplexScript314);
            Text text299 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text299.Text = "отвечают требованиям к происхождению товара. ";

            run300.Append(runProperties299);
            run300.Append(text299);

            paragraph44.Append(paragraphProperties44);
            paragraph44.Append(proofError43);
            paragraph44.Append(run292);
            paragraph44.Append(run293);
            paragraph44.Append(run294);
            paragraph44.Append(proofError44);
            paragraph44.Append(run295);
            paragraph44.Append(run296);
            paragraph44.Append(run297);
            paragraph44.Append(run298);
            paragraph44.Append(run299);
            paragraph44.Append(run300);

            Paragraph paragraph45 = new Paragraph() { RsidParagraphMarkRevision = "00E051D4", RsidParagraphAddition = "00C47F9D", RsidParagraphProperties = "00BA3008", RsidRunAdditionDefault = "00F16C70" };

            ParagraphProperties paragraphProperties45 = new ParagraphProperties();
            AutoSpaceDE autoSpaceDE31 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN31 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent31 = new AdjustRightIndent() { Val = false };

            ParagraphMarkRunProperties paragraphMarkRunProperties45 = new ParagraphMarkRunProperties();
            FontSize fontSize315 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript315 = new FontSizeComplexScript() { Val = "22" };

            paragraphMarkRunProperties45.Append(fontSize315);
            paragraphMarkRunProperties45.Append(fontSizeComplexScript315);

            paragraphProperties45.Append(autoSpaceDE31);
            paragraphProperties45.Append(autoSpaceDN31);
            paragraphProperties45.Append(adjustRightIndent31);
            paragraphProperties45.Append(paragraphMarkRunProperties45);

            Run run301 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties300 = new RunProperties();
            FontSize fontSize316 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript316 = new FontSizeComplexScript() { Val = "22" };

            runProperties300.Append(fontSize316);
            runProperties300.Append(fontSizeComplexScript316);
            Text text300 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text300.Text = "   ";

            run301.Append(runProperties300);
            run301.Append(text300);

            Run run302 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "00F17A99" };

            RunProperties runProperties301 = new RunProperties();
            FontSize fontSize317 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript317 = new FontSizeComplexScript() { Val = "22" };

            runProperties301.Append(fontSize317);
            runProperties301.Append(fontSizeComplexScript317);
            Text text301 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text301.Text = "  ";

            run302.Append(runProperties301);
            run302.Append(text301);

            Run run303 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties302 = new RunProperties();
            FontSize fontSize318 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript318 = new FontSizeComplexScript() { Val = "22" };

            runProperties302.Append(fontSize318);
            runProperties302.Append(fontSizeComplexScript318);
            Text text302 = new Text();
            text302.Text = "(страна происхождения)";

            run303.Append(runProperties302);
            run303.Append(text302);

            paragraph45.Append(paragraphProperties45);
            paragraph45.Append(run301);
            paragraph45.Append(run302);
            paragraph45.Append(run303);

            Paragraph paragraph46 = new Paragraph() { RsidParagraphMarkRevision = "00E051D4", RsidParagraphAddition = "006D47A7", RsidParagraphProperties = "00BA3008", RsidRunAdditionDefault = "006D47A7" };

            ParagraphProperties paragraphProperties46 = new ParagraphProperties();
            AutoSpaceDE autoSpaceDE32 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN32 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent32 = new AdjustRightIndent() { Val = false };

            ParagraphMarkRunProperties paragraphMarkRunProperties46 = new ParagraphMarkRunProperties();
            FontSize fontSize319 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript319 = new FontSizeComplexScript() { Val = "22" };

            paragraphMarkRunProperties46.Append(fontSize319);
            paragraphMarkRunProperties46.Append(fontSizeComplexScript319);

            paragraphProperties46.Append(autoSpaceDE32);
            paragraphProperties46.Append(autoSpaceDN32);
            paragraphProperties46.Append(adjustRightIndent32);
            paragraphProperties46.Append(paragraphMarkRunProperties46);

            paragraph46.Append(paragraphProperties46);

            Paragraph paragraph47 = new Paragraph() { RsidParagraphMarkRevision = "00E051D4", RsidParagraphAddition = "00472260", RsidParagraphProperties = "00BA3008", RsidRunAdditionDefault = "00D02ED9" };

            ParagraphProperties paragraphProperties47 = new ParagraphProperties();
            AutoSpaceDE autoSpaceDE33 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN33 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent33 = new AdjustRightIndent() { Val = false };

            ParagraphMarkRunProperties paragraphMarkRunProperties47 = new ParagraphMarkRunProperties();
            FontSize fontSize320 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript320 = new FontSizeComplexScript() { Val = "22" };

            paragraphMarkRunProperties47.Append(fontSize320);
            paragraphMarkRunProperties47.Append(fontSizeComplexScript320);

            paragraphProperties47.Append(autoSpaceDE33);
            paragraphProperties47.Append(autoSpaceDN33);
            paragraphProperties47.Append(adjustRightIndent33);
            paragraphProperties47.Append(paragraphMarkRunProperties47);

            Run run304 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties303 = new RunProperties();
            FontSize fontSize321 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript321 = new FontSizeComplexScript() { Val = "22" };

            runProperties303.Append(fontSize321);
            runProperties303.Append(fontSizeComplexScript321);
            Text text303 = new Text();
            text303.Text = "Срок исполнения заявки:";

            run304.Append(runProperties303);
            run304.Append(text303);

            paragraph47.Append(paragraphProperties47);
            paragraph47.Append(run304);

            Paragraph paragraph48 = new Paragraph() { RsidParagraphMarkRevision = "00793DB6", RsidParagraphAddition = "005B61C9", RsidParagraphProperties = "00472260", RsidRunAdditionDefault = "00FF22C9" };

            ParagraphProperties paragraphProperties48 = new ParagraphProperties();
            AutoSpaceDE autoSpaceDE34 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN34 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent34 = new AdjustRightIndent() { Val = false };
            Indentation indentation12 = new Indentation() { End = "-469" };

            ParagraphMarkRunProperties paragraphMarkRunProperties48 = new ParagraphMarkRunProperties();
            FontSize fontSize322 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript322 = new FontSizeComplexScript() { Val = "22" };

            paragraphMarkRunProperties48.Append(fontSize322);
            paragraphMarkRunProperties48.Append(fontSizeComplexScript322);

            paragraphProperties48.Append(autoSpaceDE34);
            paragraphProperties48.Append(autoSpaceDN34);
            paragraphProperties48.Append(adjustRightIndent34);
            paragraphProperties48.Append(indentation12);
            paragraphProperties48.Append(paragraphMarkRunProperties48);

            Run run305 = new Run() { RsidRunProperties = "00793DB6" };

            RunProperties runProperties304 = new RunProperties();
            FontSize fontSize323 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript323 = new FontSizeComplexScript() { Val = "22" };

            runProperties304.Append(fontSize323);
            runProperties304.Append(fontSizeComplexScript323);
            Text text304 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text304.Text = " ";

            run305.Append(runProperties304);
            run305.Append(text304);

            Run run306 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "00D02ED9" };

            RunProperties runProperties305 = new RunProperties();
            FontSize fontSize324 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript324 = new FontSizeComplexScript() { Val = "22" };

            runProperties305.Append(fontSize324);
            runProperties305.Append(fontSizeComplexScript324);
            Text text305 = new Text();
            text305.Text = "Обыкновенный ⁪";

            run306.Append(runProperties305);
            run306.Append(text305);

            Run run307 = new Run() { RsidRunProperties = "00793DB6", RsidRunAddition = "002020AD" };

            RunProperties runProperties306 = new RunProperties();
            FontSize fontSize325 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript325 = new FontSizeComplexScript() { Val = "22" };

            runProperties306.Append(fontSize325);
            runProperties306.Append(fontSizeComplexScript325);
            Text text306 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text306.Text = " ";

            run307.Append(runProperties306);
            run307.Append(text306);

            Run run308 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "001D6DE5" };

            RunProperties runProperties307 = new RunProperties();
            FontSize fontSize326 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript326 = new FontSizeComplexScript() { Val = "22" };

            runProperties307.Append(fontSize326);
            runProperties307.Append(fontSizeComplexScript326);
            Text text307 = new Text();
            text307.Text = "■";

            run308.Append(runProperties307);
            run308.Append(text307);

            Run run309 = new Run() { RsidRunProperties = "00E051D4", RsidRunAddition = "00D02ED9" };

            RunProperties runProperties308 = new RunProperties();
            FontSize fontSize327 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript327 = new FontSizeComplexScript() { Val = "22" };

            runProperties308.Append(fontSize327);
            runProperties308.Append(fontSizeComplexScript327);
            Text text308 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text308.Text = " Срочно (на протяжении 1 рабочего дня) ⁪ В экспресс-режиме (на протяжении 3 часов)  ";

            run309.Append(runProperties308);
            run309.Append(text308);

            paragraph48.Append(paragraphProperties48);
            paragraph48.Append(run305);
            paragraph48.Append(run306);
            paragraph48.Append(run307);
            paragraph48.Append(run308);
            paragraph48.Append(run309);

            Paragraph paragraph49 = new Paragraph() { RsidParagraphAddition = "00EC7250", RsidParagraphProperties = "00BF61DD", RsidRunAdditionDefault = "00EC7250" };

            ParagraphProperties paragraphProperties49 = new ParagraphProperties();
            Justification justification17 = new Justification() { Val = JustificationValues.Center };

            ParagraphMarkRunProperties paragraphMarkRunProperties49 = new ParagraphMarkRunProperties();
            FontSize fontSize328 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript328 = new FontSizeComplexScript() { Val = "22" };

            paragraphMarkRunProperties49.Append(fontSize328);
            paragraphMarkRunProperties49.Append(fontSizeComplexScript328);

            paragraphProperties49.Append(justification17);
            paragraphProperties49.Append(paragraphMarkRunProperties49);

            paragraph49.Append(paragraphProperties49);

            Paragraph paragraph50 = new Paragraph() { RsidParagraphMarkRevision = "004254E6", RsidParagraphAddition = "00BF61DD", RsidParagraphProperties = "00BF61DD", RsidRunAdditionDefault = "008B376E" };

            ParagraphProperties paragraphProperties50 = new ParagraphProperties();
            Justification justification18 = new Justification() { Val = JustificationValues.Center };

            ParagraphMarkRunProperties paragraphMarkRunProperties50 = new ParagraphMarkRunProperties();
            Bold bold218 = new Bold();
            FontSize fontSize329 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript329 = new FontSizeComplexScript() { Val = "22" };

            paragraphMarkRunProperties50.Append(bold218);
            paragraphMarkRunProperties50.Append(fontSize329);
            paragraphMarkRunProperties50.Append(fontSizeComplexScript329);

            paragraphProperties50.Append(justification18);
            paragraphProperties50.Append(paragraphMarkRunProperties50);

            Run run310 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties309 = new RunProperties();
            FontSize fontSize330 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript330 = new FontSizeComplexScript() { Val = "22" };

            runProperties309.Append(fontSize330);
            runProperties309.Append(fontSizeComplexScript330);
            Text text309 = new Text();
            text309.Text = "Руководитель предприятия (";

            run310.Append(runProperties309);
            run310.Append(text309);

            Run run311 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties310 = new RunProperties();
            Bold bold219 = new Bold();
            FontSize fontSize331 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript331 = new FontSizeComplexScript() { Val = "22" };
            Underline underline154 = new Underline() { Val = UnderlineValues.Single };

            runProperties310.Append(bold219);
            runProperties310.Append(fontSize331);
            runProperties310.Append(fontSizeComplexScript331);
            runProperties310.Append(underline154);
            Text text310 = new Text();
            text310.Text = "уполномоченная особа";

            run311.Append(runProperties310);
            run311.Append(text310);

            Run run312 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties311 = new RunProperties();
            FontSize fontSize332 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript332 = new FontSizeComplexScript() { Val = "22" };

            runProperties311.Append(fontSize332);
            runProperties311.Append(fontSizeComplexScript332);
            Text text311 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text311.Text = ")                      ";

            run312.Append(runProperties311);
            run312.Append(text311);

            Run run313 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties312 = new RunProperties();
            Bold bold220 = new Bold();
            FontSize fontSize333 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript333 = new FontSizeComplexScript() { Val = "22" };
            Underline underline155 = new Underline() { Val = UnderlineValues.Single };

            runProperties312.Append(bold220);
            runProperties312.Append(fontSize333);
            runProperties312.Append(fontSizeComplexScript333);
            runProperties312.Append(underline155);
            Text text312 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text312.Text = "_________________ ";

            run313.Append(runProperties312);
            run313.Append(text312);

            Run run314 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties313 = new RunProperties();
            Bold bold221 = new Bold();
            FontSize fontSize334 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript334 = new FontSizeComplexScript() { Val = "22" };

            runProperties313.Append(bold221);
            runProperties313.Append(fontSize334);
            runProperties313.Append(fontSizeComplexScript334);
            Text text313 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text313.Text = "    ";

            run314.Append(runProperties313);
            run314.Append(text313);
            ProofError proofError45 = new ProofError() { Type = ProofingErrorValues.SpellStart };

            Run run315 = new Run() { RsidRunAddition = "00AF701D" };

            RunProperties runProperties314 = new RunProperties();
            FontSize fontSize335 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript335 = new FontSizeComplexScript() { Val = "22" };
            Languages languages105 = new Languages() { Val = "en-US" };

            runProperties314.Append(fontSize335);
            runProperties314.Append(fontSizeComplexScript335);
            runProperties314.Append(languages105);
            Text text314 = new Text();
            text314.Text = frm.authPerson.SelectedItem.ToString();

            run315.Append(runProperties314);
            run315.Append(text314);
            ProofError proofError46 = new ProofError() { Type = ProofingErrorValues.SpellEnd };

            paragraph50.Append(paragraphProperties50);
            paragraph50.Append(run310);
            paragraph50.Append(run311);
            paragraph50.Append(run312);
            paragraph50.Append(run313);
            paragraph50.Append(run314);
            paragraph50.Append(proofError45);
            paragraph50.Append(run315);
            paragraph50.Append(proofError46);

            Paragraph paragraph51 = new Paragraph() { RsidParagraphMarkRevision = "00E051D4", RsidParagraphAddition = "008B376E", RsidParagraphProperties = "008B376E", RsidRunAdditionDefault = "008B376E" };

            ParagraphProperties paragraphProperties51 = new ParagraphProperties();
            AutoSpaceDE autoSpaceDE35 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN35 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent35 = new AdjustRightIndent() { Val = false };

            ParagraphMarkRunProperties paragraphMarkRunProperties51 = new ParagraphMarkRunProperties();
            FontSize fontSize336 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript336 = new FontSizeComplexScript() { Val = "22" };

            paragraphMarkRunProperties51.Append(fontSize336);
            paragraphMarkRunProperties51.Append(fontSizeComplexScript336);

            paragraphProperties51.Append(autoSpaceDE35);
            paragraphProperties51.Append(autoSpaceDN35);
            paragraphProperties51.Append(adjustRightIndent35);
            paragraphProperties51.Append(paragraphMarkRunProperties51);

            paragraph51.Append(paragraphProperties51);

            Paragraph paragraph52 = new Paragraph() { RsidParagraphMarkRevision = "00E051D4", RsidParagraphAddition = "00D52429", RsidParagraphProperties = "00D02ED9", RsidRunAdditionDefault = "008B376E" };

            ParagraphProperties paragraphProperties52 = new ParagraphProperties();
            AutoSpaceDE autoSpaceDE36 = new AutoSpaceDE() { Val = false };
            AutoSpaceDN autoSpaceDN36 = new AutoSpaceDN() { Val = false };
            AdjustRightIndent adjustRightIndent36 = new AdjustRightIndent() { Val = false };

            ParagraphMarkRunProperties paragraphMarkRunProperties52 = new ParagraphMarkRunProperties();
            FontSize fontSize337 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript337 = new FontSizeComplexScript() { Val = "22" };

            paragraphMarkRunProperties52.Append(fontSize337);
            paragraphMarkRunProperties52.Append(fontSizeComplexScript337);

            paragraphProperties52.Append(autoSpaceDE36);
            paragraphProperties52.Append(autoSpaceDN36);
            paragraphProperties52.Append(adjustRightIndent36);
            paragraphProperties52.Append(paragraphMarkRunProperties52);

            Run run316 = new Run() { RsidRunProperties = "00E051D4" };

            RunProperties runProperties315 = new RunProperties();
            FontSize fontSize338 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript338 = new FontSizeComplexScript() { Val = "22" };

            runProperties315.Append(fontSize338);
            runProperties315.Append(fontSizeComplexScript338);
            Text text315 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text315.Text = "              М.П.                                                                                                (Ф.И.О, подпись)                     ";

            run316.Append(runProperties315);
            run316.Append(text315);

            paragraph52.Append(paragraphProperties52);
            paragraph52.Append(run316);

            SectionProperties sectionProperties1 = new SectionProperties() { RsidRPr = "00E051D4", RsidR = "00D52429", RsidSect = "00E712AD" };
            PageSize pageSize1 = new PageSize() { Width = (UInt32Value)12240U, Height = (UInt32Value)15840U };
            PageMargin pageMargin1 = new PageMargin() { Top = 568, Right = (UInt32Value)616U, Bottom = 180, Left = (UInt32Value)1418U, Header = (UInt32Value)720U, Footer = (UInt32Value)720U, Gutter = (UInt32Value)0U };
            Columns columns1 = new Columns() { Space = "720" };
            NoEndnote noEndnote1 = new NoEndnote();

            sectionProperties1.Append(pageSize1);
            sectionProperties1.Append(pageMargin1);
            sectionProperties1.Append(columns1);
            sectionProperties1.Append(noEndnote1);

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
            body1.Append(table1);
            body1.Append(paragraph19);
            body1.Append(paragraph20);
            body1.Append(paragraph21);
            body1.Append(paragraph22);
            body1.Append(paragraph23);
            body1.Append(paragraph24);
            body1.Append(paragraph25);
            body1.Append(paragraph26);
            body1.Append(paragraph27);
            body1.Append(paragraph28);
            body1.Append(table2);
            body1.Append(paragraph39);
            body1.Append(paragraph40);
            body1.Append(paragraph41);
            body1.Append(paragraph42);
            body1.Append(paragraph43);
            body1.Append(paragraph44);
            body1.Append(paragraph45);
            body1.Append(paragraph46);
            body1.Append(paragraph47);
            body1.Append(paragraph48);
            body1.Append(paragraph49);
            body1.Append(paragraph50);
            body1.Append(paragraph51);
            body1.Append(paragraph52);
            body1.Append(sectionProperties1);

            document1.Append(body1);

            mainDocumentPart1.Document = document1;
        }

        // Generates content of stylesWithEffectsPart1.
        private void GenerateStylesWithEffectsPart1Content(StylesWithEffectsPart stylesWithEffectsPart1)
        {
            Styles styles1 = new Styles() { MCAttributes = new MarkupCompatibilityAttributes() { Ignorable = "w14 wp14" } };
            styles1.AddNamespaceDeclaration("wpc", "http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas");
            styles1.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            styles1.AddNamespaceDeclaration("o", "urn:schemas-microsoft-com:office:office");
            styles1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            styles1.AddNamespaceDeclaration("m", "http://schemas.openxmlformats.org/officeDocument/2006/math");
            styles1.AddNamespaceDeclaration("v", "urn:schemas-microsoft-com:vml");
            styles1.AddNamespaceDeclaration("wp14", "http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing");
            styles1.AddNamespaceDeclaration("wp", "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing");
            styles1.AddNamespaceDeclaration("w10", "urn:schemas-microsoft-com:office:word");
            styles1.AddNamespaceDeclaration("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
            styles1.AddNamespaceDeclaration("w14", "http://schemas.microsoft.com/office/word/2010/wordml");
            styles1.AddNamespaceDeclaration("wpg", "http://schemas.microsoft.com/office/word/2010/wordprocessingGroup");
            styles1.AddNamespaceDeclaration("wpi", "http://schemas.microsoft.com/office/word/2010/wordprocessingInk");
            styles1.AddNamespaceDeclaration("wne", "http://schemas.microsoft.com/office/word/2006/wordml");
            styles1.AddNamespaceDeclaration("wps", "http://schemas.microsoft.com/office/word/2010/wordprocessingShape");

            DocDefaults docDefaults1 = new DocDefaults();

            RunPropertiesDefault runPropertiesDefault1 = new RunPropertiesDefault();

            RunPropertiesBaseStyle runPropertiesBaseStyle1 = new RunPropertiesBaseStyle();
            RunFonts runFonts35 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman", EastAsia = "Times New Roman", ComplexScript = "Times New Roman" };
            Languages languages106 = new Languages() { Val = "ru-RU", EastAsia = "ru-RU", Bidi = "ar-SA" };

            runPropertiesBaseStyle1.Append(runFonts35);
            runPropertiesBaseStyle1.Append(languages106);

            runPropertiesDefault1.Append(runPropertiesBaseStyle1);
            ParagraphPropertiesDefault paragraphPropertiesDefault1 = new ParagraphPropertiesDefault();

            docDefaults1.Append(runPropertiesDefault1);
            docDefaults1.Append(paragraphPropertiesDefault1);

            LatentStyles latentStyles1 = new LatentStyles() { DefaultLockedState = false, DefaultUiPriority = 0, DefaultSemiHidden = false, DefaultUnhideWhenUsed = false, DefaultPrimaryStyle = false, Count = 267 };
            LatentStyleExceptionInfo latentStyleExceptionInfo1 = new LatentStyleExceptionInfo() { Name = "Normal", PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo2 = new LatentStyleExceptionInfo() { Name = "heading 1", PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo3 = new LatentStyleExceptionInfo() { Name = "heading 2", SemiHidden = true, UnhideWhenUsed = true, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo4 = new LatentStyleExceptionInfo() { Name = "heading 3", SemiHidden = true, UnhideWhenUsed = true, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo5 = new LatentStyleExceptionInfo() { Name = "heading 4", SemiHidden = true, UnhideWhenUsed = true, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo6 = new LatentStyleExceptionInfo() { Name = "heading 5", PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo7 = new LatentStyleExceptionInfo() { Name = "heading 6", SemiHidden = true, UnhideWhenUsed = true, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo8 = new LatentStyleExceptionInfo() { Name = "heading 7", SemiHidden = true, UnhideWhenUsed = true, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo9 = new LatentStyleExceptionInfo() { Name = "heading 8", SemiHidden = true, UnhideWhenUsed = true, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo10 = new LatentStyleExceptionInfo() { Name = "heading 9", SemiHidden = true, UnhideWhenUsed = true, PrimaryStyle = true };
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

            Style style1 = new Style() { Type = StyleValues.Paragraph, StyleId = "a", Default = true };
            StyleName styleName1 = new StyleName() { Val = "Normal" };
            PrimaryStyle primaryStyle1 = new PrimaryStyle();

            StyleRunProperties styleRunProperties1 = new StyleRunProperties();
            FontSize fontSize339 = new FontSize() { Val = "24" };
            FontSizeComplexScript fontSizeComplexScript339 = new FontSizeComplexScript() { Val = "24" };

            styleRunProperties1.Append(fontSize339);
            styleRunProperties1.Append(fontSizeComplexScript339);

            style1.Append(styleName1);
            style1.Append(primaryStyle1);
            style1.Append(styleRunProperties1);

            Style style2 = new Style() { Type = StyleValues.Paragraph, StyleId = "5" };
            StyleName styleName2 = new StyleName() { Val = "heading 5" };
            BasedOn basedOn1 = new BasedOn() { Val = "a" };
            NextParagraphStyle nextParagraphStyle1 = new NextParagraphStyle() { Val = "a" };
            PrimaryStyle primaryStyle2 = new PrimaryStyle();
            Rsid rsid1 = new Rsid() { Val = "00E456A8" };

            StyleParagraphProperties styleParagraphProperties1 = new StyleParagraphProperties();
            SpacingBetweenLines spacingBetweenLines1 = new SpacingBetweenLines() { Before = "240", After = "60" };
            OutlineLevel outlineLevel1 = new OutlineLevel() { Val = 4 };

            styleParagraphProperties1.Append(spacingBetweenLines1);
            styleParagraphProperties1.Append(outlineLevel1);

            StyleRunProperties styleRunProperties2 = new StyleRunProperties();
            Bold bold222 = new Bold();
            BoldComplexScript boldComplexScript4 = new BoldComplexScript();
            Italic italic82 = new Italic();
            ItalicComplexScript italicComplexScript1 = new ItalicComplexScript();
            FontSize fontSize340 = new FontSize() { Val = "26" };
            FontSizeComplexScript fontSizeComplexScript340 = new FontSizeComplexScript() { Val = "26" };

            styleRunProperties2.Append(bold222);
            styleRunProperties2.Append(boldComplexScript4);
            styleRunProperties2.Append(italic82);
            styleRunProperties2.Append(italicComplexScript1);
            styleRunProperties2.Append(fontSize340);
            styleRunProperties2.Append(fontSizeComplexScript340);

            style2.Append(styleName2);
            style2.Append(basedOn1);
            style2.Append(nextParagraphStyle1);
            style2.Append(primaryStyle2);
            style2.Append(rsid1);
            style2.Append(styleParagraphProperties1);
            style2.Append(styleRunProperties2);

            Style style3 = new Style() { Type = StyleValues.Character, StyleId = "a0", Default = true };
            StyleName styleName3 = new StyleName() { Val = "Default Paragraph Font" };
            UIPriority uIPriority1 = new UIPriority() { Val = 1 };
            SemiHidden semiHidden1 = new SemiHidden();
            UnhideWhenUsed unhideWhenUsed1 = new UnhideWhenUsed();

            style3.Append(styleName3);
            style3.Append(uIPriority1);
            style3.Append(semiHidden1);
            style3.Append(unhideWhenUsed1);

            Style style4 = new Style() { Type = StyleValues.Table, StyleId = "a1", Default = true };
            StyleName styleName4 = new StyleName() { Val = "Normal Table" };
            UIPriority uIPriority2 = new UIPriority() { Val = 99 };
            SemiHidden semiHidden2 = new SemiHidden();
            UnhideWhenUsed unhideWhenUsed2 = new UnhideWhenUsed();

            StyleTableProperties styleTableProperties1 = new StyleTableProperties();
            TableIndentation tableIndentation2 = new TableIndentation() { Width = 0, Type = TableWidthUnitValues.Dxa };

            TableCellMarginDefault tableCellMarginDefault1 = new TableCellMarginDefault();
            TopMargin topMargin1 = new TopMargin() { Width = "0", Type = TableWidthUnitValues.Dxa };
            TableCellLeftMargin tableCellLeftMargin1 = new TableCellLeftMargin() { Width = 108, Type = TableWidthValues.Dxa };
            BottomMargin bottomMargin1 = new BottomMargin() { Width = "0", Type = TableWidthUnitValues.Dxa };
            TableCellRightMargin tableCellRightMargin1 = new TableCellRightMargin() { Width = 108, Type = TableWidthValues.Dxa };

            tableCellMarginDefault1.Append(topMargin1);
            tableCellMarginDefault1.Append(tableCellLeftMargin1);
            tableCellMarginDefault1.Append(bottomMargin1);
            tableCellMarginDefault1.Append(tableCellRightMargin1);

            styleTableProperties1.Append(tableIndentation2);
            styleTableProperties1.Append(tableCellMarginDefault1);

            style4.Append(styleName4);
            style4.Append(uIPriority2);
            style4.Append(semiHidden2);
            style4.Append(unhideWhenUsed2);
            style4.Append(styleTableProperties1);

            Style style5 = new Style() { Type = StyleValues.Numbering, StyleId = "a2", Default = true };
            StyleName styleName5 = new StyleName() { Val = "No List" };
            UIPriority uIPriority3 = new UIPriority() { Val = 99 };
            SemiHidden semiHidden3 = new SemiHidden();
            UnhideWhenUsed unhideWhenUsed3 = new UnhideWhenUsed();

            style5.Append(styleName5);
            style5.Append(uIPriority3);
            style5.Append(semiHidden3);
            style5.Append(unhideWhenUsed3);

            Style style6 = new Style() { Type = StyleValues.Paragraph, StyleId = "a3" };
            StyleName styleName6 = new StyleName() { Val = "footer" };
            BasedOn basedOn2 = new BasedOn() { Val = "a" };
            Rsid rsid2 = new Rsid() { Val = "00692F95" };

            StyleParagraphProperties styleParagraphProperties2 = new StyleParagraphProperties();

            Tabs tabs2 = new Tabs();
            TabStop tabStop2 = new TabStop() { Val = TabStopValues.Center, Position = 4677 };
            TabStop tabStop3 = new TabStop() { Val = TabStopValues.Right, Position = 9355 };

            tabs2.Append(tabStop2);
            tabs2.Append(tabStop3);

            styleParagraphProperties2.Append(tabs2);

            StyleRunProperties styleRunProperties3 = new StyleRunProperties();
            FontSize fontSize341 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript341 = new FontSizeComplexScript() { Val = "28" };
            Languages languages107 = new Languages() { Val = "uk-UA" };

            styleRunProperties3.Append(fontSize341);
            styleRunProperties3.Append(fontSizeComplexScript341);
            styleRunProperties3.Append(languages107);

            style6.Append(styleName6);
            style6.Append(basedOn2);
            style6.Append(rsid2);
            style6.Append(styleParagraphProperties2);
            style6.Append(styleRunProperties3);

            Style style7 = new Style() { Type = StyleValues.Paragraph, StyleId = "2" };
            StyleName styleName7 = new StyleName() { Val = "Body Text 2" };
            BasedOn basedOn3 = new BasedOn() { Val = "a" };
            LinkedStyle linkedStyle1 = new LinkedStyle() { Val = "20" };
            Rsid rsid3 = new Rsid() { Val = "008855BE" };

            StyleRunProperties styleRunProperties4 = new StyleRunProperties();
            RunFonts runFonts36 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial" };
            FontSize fontSize342 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript342 = new FontSizeComplexScript() { Val = "20" };
            Languages languages108 = new Languages() { Val = "x-none", EastAsia = "x-none" };

            styleRunProperties4.Append(runFonts36);
            styleRunProperties4.Append(fontSize342);
            styleRunProperties4.Append(fontSizeComplexScript342);
            styleRunProperties4.Append(languages108);

            style7.Append(styleName7);
            style7.Append(basedOn3);
            style7.Append(linkedStyle1);
            style7.Append(rsid3);
            style7.Append(styleRunProperties4);

            Style style8 = new Style() { Type = StyleValues.Paragraph, StyleId = "a4" };
            StyleName styleName8 = new StyleName() { Val = "Balloon Text" };
            BasedOn basedOn4 = new BasedOn() { Val = "a" };
            SemiHidden semiHidden4 = new SemiHidden();
            Rsid rsid4 = new Rsid() { Val = "00F92B85" };

            StyleRunProperties styleRunProperties5 = new StyleRunProperties();
            RunFonts runFonts37 = new RunFonts() { Ascii = "Tahoma", HighAnsi = "Tahoma", ComplexScript = "Tahoma" };
            FontSize fontSize343 = new FontSize() { Val = "16" };
            FontSizeComplexScript fontSizeComplexScript343 = new FontSizeComplexScript() { Val = "16" };

            styleRunProperties5.Append(runFonts37);
            styleRunProperties5.Append(fontSize343);
            styleRunProperties5.Append(fontSizeComplexScript343);

            style8.Append(styleName8);
            style8.Append(basedOn4);
            style8.Append(semiHidden4);
            style8.Append(rsid4);
            style8.Append(styleRunProperties5);

            Style style9 = new Style() { Type = StyleValues.Table, StyleId = "a5" };
            StyleName styleName9 = new StyleName() { Val = "Table Grid" };
            BasedOn basedOn5 = new BasedOn() { Val = "a1" };
            Rsid rsid5 = new Rsid() { Val = "00A13B37" };

            StyleTableProperties styleTableProperties2 = new StyleTableProperties();

            TableBorders tableBorders2 = new TableBorders();
            TopBorder topBorder2 = new TopBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            LeftBorder leftBorder2 = new LeftBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder2 = new BottomBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            RightBorder rightBorder2 = new RightBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            InsideHorizontalBorder insideHorizontalBorder2 = new InsideHorizontalBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            InsideVerticalBorder insideVerticalBorder2 = new InsideVerticalBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };

            tableBorders2.Append(topBorder2);
            tableBorders2.Append(leftBorder2);
            tableBorders2.Append(bottomBorder2);
            tableBorders2.Append(rightBorder2);
            tableBorders2.Append(insideHorizontalBorder2);
            tableBorders2.Append(insideVerticalBorder2);

            styleTableProperties2.Append(tableBorders2);

            style9.Append(styleName9);
            style9.Append(basedOn5);
            style9.Append(rsid5);
            style9.Append(styleTableProperties2);

            Style style10 = new Style() { Type = StyleValues.Character, StyleId = "20", CustomStyle = true };
            StyleName styleName10 = new StyleName() { Val = "Основной текст 2 Знак" };
            LinkedStyle linkedStyle2 = new LinkedStyle() { Val = "2" };
            Rsid rsid6 = new Rsid() { Val = "00E23013" };

            StyleRunProperties styleRunProperties6 = new StyleRunProperties();
            RunFonts runFonts38 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial" };
            FontSize fontSize344 = new FontSize() { Val = "28" };

            styleRunProperties6.Append(runFonts38);
            styleRunProperties6.Append(fontSize344);

            style10.Append(styleName10);
            style10.Append(linkedStyle2);
            style10.Append(rsid6);
            style10.Append(styleRunProperties6);

            Style style11 = new Style() { Type = StyleValues.Paragraph, StyleId = "a6" };
            StyleName styleName11 = new StyleName() { Val = "No Spacing" };
            UIPriority uIPriority4 = new UIPriority() { Val = 1 };
            PrimaryStyle primaryStyle3 = new PrimaryStyle();
            Rsid rsid7 = new Rsid() { Val = "006D0A4B" };

            StyleRunProperties styleRunProperties7 = new StyleRunProperties();
            RunFonts runFonts39 = new RunFonts() { Ascii = "Calibri", HighAnsi = "Calibri", EastAsia = "Calibri" };
            FontSize fontSize345 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript344 = new FontSizeComplexScript() { Val = "22" };
            Languages languages109 = new Languages() { EastAsia = "en-US" };

            styleRunProperties7.Append(runFonts39);
            styleRunProperties7.Append(fontSize345);
            styleRunProperties7.Append(fontSizeComplexScript344);
            styleRunProperties7.Append(languages109);

            style11.Append(styleName11);
            style11.Append(uIPriority4);
            style11.Append(primaryStyle3);
            style11.Append(rsid7);
            style11.Append(styleRunProperties7);

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

            stylesWithEffectsPart1.Styles = styles1;
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

        // Generates content of styleDefinitionsPart1.
        private void GenerateStyleDefinitionsPart1Content(StyleDefinitionsPart styleDefinitionsPart1)
        {
            Styles styles2 = new Styles() { MCAttributes = new MarkupCompatibilityAttributes() { Ignorable = "w14" } };
            styles2.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            styles2.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            styles2.AddNamespaceDeclaration("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
            styles2.AddNamespaceDeclaration("w14", "http://schemas.microsoft.com/office/word/2010/wordml");

            DocDefaults docDefaults2 = new DocDefaults();

            RunPropertiesDefault runPropertiesDefault2 = new RunPropertiesDefault();

            RunPropertiesBaseStyle runPropertiesBaseStyle2 = new RunPropertiesBaseStyle();
            RunFonts runFonts40 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman", EastAsia = "Times New Roman", ComplexScript = "Times New Roman" };
            Languages languages110 = new Languages() { Val = "ru-RU", EastAsia = "ru-RU", Bidi = "ar-SA" };

            runPropertiesBaseStyle2.Append(runFonts40);
            runPropertiesBaseStyle2.Append(languages110);

            runPropertiesDefault2.Append(runPropertiesBaseStyle2);
            ParagraphPropertiesDefault paragraphPropertiesDefault2 = new ParagraphPropertiesDefault();

            docDefaults2.Append(runPropertiesDefault2);
            docDefaults2.Append(paragraphPropertiesDefault2);

            LatentStyles latentStyles2 = new LatentStyles() { DefaultLockedState = false, DefaultUiPriority = 0, DefaultSemiHidden = false, DefaultUnhideWhenUsed = false, DefaultPrimaryStyle = false, Count = 267 };
            LatentStyleExceptionInfo latentStyleExceptionInfo171 = new LatentStyleExceptionInfo() { Name = "Normal", PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo172 = new LatentStyleExceptionInfo() { Name = "heading 1", PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo173 = new LatentStyleExceptionInfo() { Name = "heading 2", SemiHidden = true, UnhideWhenUsed = true, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo174 = new LatentStyleExceptionInfo() { Name = "heading 3", SemiHidden = true, UnhideWhenUsed = true, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo175 = new LatentStyleExceptionInfo() { Name = "heading 4", SemiHidden = true, UnhideWhenUsed = true, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo176 = new LatentStyleExceptionInfo() { Name = "heading 5", PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo177 = new LatentStyleExceptionInfo() { Name = "heading 6", SemiHidden = true, UnhideWhenUsed = true, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo178 = new LatentStyleExceptionInfo() { Name = "heading 7", SemiHidden = true, UnhideWhenUsed = true, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo179 = new LatentStyleExceptionInfo() { Name = "heading 8", SemiHidden = true, UnhideWhenUsed = true, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo180 = new LatentStyleExceptionInfo() { Name = "heading 9", SemiHidden = true, UnhideWhenUsed = true, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo181 = new LatentStyleExceptionInfo() { Name = "caption", SemiHidden = true, UnhideWhenUsed = true, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo182 = new LatentStyleExceptionInfo() { Name = "Title", PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo183 = new LatentStyleExceptionInfo() { Name = "Subtitle", PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo184 = new LatentStyleExceptionInfo() { Name = "Strong", PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo185 = new LatentStyleExceptionInfo() { Name = "Emphasis", PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo186 = new LatentStyleExceptionInfo() { Name = "Normal Table", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo187 = new LatentStyleExceptionInfo() { Name = "Table Simple 1", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo188 = new LatentStyleExceptionInfo() { Name = "Table Simple 2", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo189 = new LatentStyleExceptionInfo() { Name = "Table Simple 3", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo190 = new LatentStyleExceptionInfo() { Name = "Table Classic 1", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo191 = new LatentStyleExceptionInfo() { Name = "Table Classic 2", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo192 = new LatentStyleExceptionInfo() { Name = "Table Classic 3", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo193 = new LatentStyleExceptionInfo() { Name = "Table Classic 4", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo194 = new LatentStyleExceptionInfo() { Name = "Table Colorful 1", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo195 = new LatentStyleExceptionInfo() { Name = "Table Colorful 2", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo196 = new LatentStyleExceptionInfo() { Name = "Table Colorful 3", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo197 = new LatentStyleExceptionInfo() { Name = "Table Columns 1", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo198 = new LatentStyleExceptionInfo() { Name = "Table Columns 2", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo199 = new LatentStyleExceptionInfo() { Name = "Table Columns 3", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo200 = new LatentStyleExceptionInfo() { Name = "Table Columns 4", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo201 = new LatentStyleExceptionInfo() { Name = "Table Columns 5", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo202 = new LatentStyleExceptionInfo() { Name = "Table Grid 1", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo203 = new LatentStyleExceptionInfo() { Name = "Table Grid 2", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo204 = new LatentStyleExceptionInfo() { Name = "Table Grid 3", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo205 = new LatentStyleExceptionInfo() { Name = "Table Grid 4", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo206 = new LatentStyleExceptionInfo() { Name = "Table Grid 5", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo207 = new LatentStyleExceptionInfo() { Name = "Table Grid 6", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo208 = new LatentStyleExceptionInfo() { Name = "Table Grid 7", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo209 = new LatentStyleExceptionInfo() { Name = "Table Grid 8", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo210 = new LatentStyleExceptionInfo() { Name = "Table List 1", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo211 = new LatentStyleExceptionInfo() { Name = "Table List 2", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo212 = new LatentStyleExceptionInfo() { Name = "Table List 3", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo213 = new LatentStyleExceptionInfo() { Name = "Table List 4", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo214 = new LatentStyleExceptionInfo() { Name = "Table List 5", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo215 = new LatentStyleExceptionInfo() { Name = "Table List 6", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo216 = new LatentStyleExceptionInfo() { Name = "Table List 7", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo217 = new LatentStyleExceptionInfo() { Name = "Table List 8", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo218 = new LatentStyleExceptionInfo() { Name = "Table 3D effects 1", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo219 = new LatentStyleExceptionInfo() { Name = "Table 3D effects 2", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo220 = new LatentStyleExceptionInfo() { Name = "Table 3D effects 3", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo221 = new LatentStyleExceptionInfo() { Name = "Table Contemporary", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo222 = new LatentStyleExceptionInfo() { Name = "Table Elegant", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo223 = new LatentStyleExceptionInfo() { Name = "Table Professional", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo224 = new LatentStyleExceptionInfo() { Name = "Table Subtle 1", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo225 = new LatentStyleExceptionInfo() { Name = "Table Subtle 2", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo226 = new LatentStyleExceptionInfo() { Name = "Table Web 1", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo227 = new LatentStyleExceptionInfo() { Name = "Table Web 2", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo228 = new LatentStyleExceptionInfo() { Name = "Table Web 3", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo229 = new LatentStyleExceptionInfo() { Name = "Table Theme", SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo230 = new LatentStyleExceptionInfo() { Name = "Placeholder Text", UiPriority = 99, SemiHidden = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo231 = new LatentStyleExceptionInfo() { Name = "No Spacing", UiPriority = 1, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo232 = new LatentStyleExceptionInfo() { Name = "Light Shading", UiPriority = 60 };
            LatentStyleExceptionInfo latentStyleExceptionInfo233 = new LatentStyleExceptionInfo() { Name = "Light List", UiPriority = 61 };
            LatentStyleExceptionInfo latentStyleExceptionInfo234 = new LatentStyleExceptionInfo() { Name = "Light Grid", UiPriority = 62 };
            LatentStyleExceptionInfo latentStyleExceptionInfo235 = new LatentStyleExceptionInfo() { Name = "Medium Shading 1", UiPriority = 63 };
            LatentStyleExceptionInfo latentStyleExceptionInfo236 = new LatentStyleExceptionInfo() { Name = "Medium Shading 2", UiPriority = 64 };
            LatentStyleExceptionInfo latentStyleExceptionInfo237 = new LatentStyleExceptionInfo() { Name = "Medium List 1", UiPriority = 65 };
            LatentStyleExceptionInfo latentStyleExceptionInfo238 = new LatentStyleExceptionInfo() { Name = "Medium List 2", UiPriority = 66 };
            LatentStyleExceptionInfo latentStyleExceptionInfo239 = new LatentStyleExceptionInfo() { Name = "Medium Grid 1", UiPriority = 67 };
            LatentStyleExceptionInfo latentStyleExceptionInfo240 = new LatentStyleExceptionInfo() { Name = "Medium Grid 2", UiPriority = 68 };
            LatentStyleExceptionInfo latentStyleExceptionInfo241 = new LatentStyleExceptionInfo() { Name = "Medium Grid 3", UiPriority = 69 };
            LatentStyleExceptionInfo latentStyleExceptionInfo242 = new LatentStyleExceptionInfo() { Name = "Dark List", UiPriority = 70 };
            LatentStyleExceptionInfo latentStyleExceptionInfo243 = new LatentStyleExceptionInfo() { Name = "Colorful Shading", UiPriority = 71 };
            LatentStyleExceptionInfo latentStyleExceptionInfo244 = new LatentStyleExceptionInfo() { Name = "Colorful List", UiPriority = 72 };
            LatentStyleExceptionInfo latentStyleExceptionInfo245 = new LatentStyleExceptionInfo() { Name = "Colorful Grid", UiPriority = 73 };
            LatentStyleExceptionInfo latentStyleExceptionInfo246 = new LatentStyleExceptionInfo() { Name = "Light Shading Accent 1", UiPriority = 60 };
            LatentStyleExceptionInfo latentStyleExceptionInfo247 = new LatentStyleExceptionInfo() { Name = "Light List Accent 1", UiPriority = 61 };
            LatentStyleExceptionInfo latentStyleExceptionInfo248 = new LatentStyleExceptionInfo() { Name = "Light Grid Accent 1", UiPriority = 62 };
            LatentStyleExceptionInfo latentStyleExceptionInfo249 = new LatentStyleExceptionInfo() { Name = "Medium Shading 1 Accent 1", UiPriority = 63 };
            LatentStyleExceptionInfo latentStyleExceptionInfo250 = new LatentStyleExceptionInfo() { Name = "Medium Shading 2 Accent 1", UiPriority = 64 };
            LatentStyleExceptionInfo latentStyleExceptionInfo251 = new LatentStyleExceptionInfo() { Name = "Medium List 1 Accent 1", UiPriority = 65 };
            LatentStyleExceptionInfo latentStyleExceptionInfo252 = new LatentStyleExceptionInfo() { Name = "Revision", UiPriority = 99, SemiHidden = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo253 = new LatentStyleExceptionInfo() { Name = "List Paragraph", UiPriority = 34, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo254 = new LatentStyleExceptionInfo() { Name = "Quote", UiPriority = 29, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo255 = new LatentStyleExceptionInfo() { Name = "Intense Quote", UiPriority = 30, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo256 = new LatentStyleExceptionInfo() { Name = "Medium List 2 Accent 1", UiPriority = 66 };
            LatentStyleExceptionInfo latentStyleExceptionInfo257 = new LatentStyleExceptionInfo() { Name = "Medium Grid 1 Accent 1", UiPriority = 67 };
            LatentStyleExceptionInfo latentStyleExceptionInfo258 = new LatentStyleExceptionInfo() { Name = "Medium Grid 2 Accent 1", UiPriority = 68 };
            LatentStyleExceptionInfo latentStyleExceptionInfo259 = new LatentStyleExceptionInfo() { Name = "Medium Grid 3 Accent 1", UiPriority = 69 };
            LatentStyleExceptionInfo latentStyleExceptionInfo260 = new LatentStyleExceptionInfo() { Name = "Dark List Accent 1", UiPriority = 70 };
            LatentStyleExceptionInfo latentStyleExceptionInfo261 = new LatentStyleExceptionInfo() { Name = "Colorful Shading Accent 1", UiPriority = 71 };
            LatentStyleExceptionInfo latentStyleExceptionInfo262 = new LatentStyleExceptionInfo() { Name = "Colorful List Accent 1", UiPriority = 72 };
            LatentStyleExceptionInfo latentStyleExceptionInfo263 = new LatentStyleExceptionInfo() { Name = "Colorful Grid Accent 1", UiPriority = 73 };
            LatentStyleExceptionInfo latentStyleExceptionInfo264 = new LatentStyleExceptionInfo() { Name = "Light Shading Accent 2", UiPriority = 60 };
            LatentStyleExceptionInfo latentStyleExceptionInfo265 = new LatentStyleExceptionInfo() { Name = "Light List Accent 2", UiPriority = 61 };
            LatentStyleExceptionInfo latentStyleExceptionInfo266 = new LatentStyleExceptionInfo() { Name = "Light Grid Accent 2", UiPriority = 62 };
            LatentStyleExceptionInfo latentStyleExceptionInfo267 = new LatentStyleExceptionInfo() { Name = "Medium Shading 1 Accent 2", UiPriority = 63 };
            LatentStyleExceptionInfo latentStyleExceptionInfo268 = new LatentStyleExceptionInfo() { Name = "Medium Shading 2 Accent 2", UiPriority = 64 };
            LatentStyleExceptionInfo latentStyleExceptionInfo269 = new LatentStyleExceptionInfo() { Name = "Medium List 1 Accent 2", UiPriority = 65 };
            LatentStyleExceptionInfo latentStyleExceptionInfo270 = new LatentStyleExceptionInfo() { Name = "Medium List 2 Accent 2", UiPriority = 66 };
            LatentStyleExceptionInfo latentStyleExceptionInfo271 = new LatentStyleExceptionInfo() { Name = "Medium Grid 1 Accent 2", UiPriority = 67 };
            LatentStyleExceptionInfo latentStyleExceptionInfo272 = new LatentStyleExceptionInfo() { Name = "Medium Grid 2 Accent 2", UiPriority = 68 };
            LatentStyleExceptionInfo latentStyleExceptionInfo273 = new LatentStyleExceptionInfo() { Name = "Medium Grid 3 Accent 2", UiPriority = 69 };
            LatentStyleExceptionInfo latentStyleExceptionInfo274 = new LatentStyleExceptionInfo() { Name = "Dark List Accent 2", UiPriority = 70 };
            LatentStyleExceptionInfo latentStyleExceptionInfo275 = new LatentStyleExceptionInfo() { Name = "Colorful Shading Accent 2", UiPriority = 71 };
            LatentStyleExceptionInfo latentStyleExceptionInfo276 = new LatentStyleExceptionInfo() { Name = "Colorful List Accent 2", UiPriority = 72 };
            LatentStyleExceptionInfo latentStyleExceptionInfo277 = new LatentStyleExceptionInfo() { Name = "Colorful Grid Accent 2", UiPriority = 73 };
            LatentStyleExceptionInfo latentStyleExceptionInfo278 = new LatentStyleExceptionInfo() { Name = "Light Shading Accent 3", UiPriority = 60 };
            LatentStyleExceptionInfo latentStyleExceptionInfo279 = new LatentStyleExceptionInfo() { Name = "Light List Accent 3", UiPriority = 61 };
            LatentStyleExceptionInfo latentStyleExceptionInfo280 = new LatentStyleExceptionInfo() { Name = "Light Grid Accent 3", UiPriority = 62 };
            LatentStyleExceptionInfo latentStyleExceptionInfo281 = new LatentStyleExceptionInfo() { Name = "Medium Shading 1 Accent 3", UiPriority = 63 };
            LatentStyleExceptionInfo latentStyleExceptionInfo282 = new LatentStyleExceptionInfo() { Name = "Medium Shading 2 Accent 3", UiPriority = 64 };
            LatentStyleExceptionInfo latentStyleExceptionInfo283 = new LatentStyleExceptionInfo() { Name = "Medium List 1 Accent 3", UiPriority = 65 };
            LatentStyleExceptionInfo latentStyleExceptionInfo284 = new LatentStyleExceptionInfo() { Name = "Medium List 2 Accent 3", UiPriority = 66 };
            LatentStyleExceptionInfo latentStyleExceptionInfo285 = new LatentStyleExceptionInfo() { Name = "Medium Grid 1 Accent 3", UiPriority = 67 };
            LatentStyleExceptionInfo latentStyleExceptionInfo286 = new LatentStyleExceptionInfo() { Name = "Medium Grid 2 Accent 3", UiPriority = 68 };
            LatentStyleExceptionInfo latentStyleExceptionInfo287 = new LatentStyleExceptionInfo() { Name = "Medium Grid 3 Accent 3", UiPriority = 69 };
            LatentStyleExceptionInfo latentStyleExceptionInfo288 = new LatentStyleExceptionInfo() { Name = "Dark List Accent 3", UiPriority = 70 };
            LatentStyleExceptionInfo latentStyleExceptionInfo289 = new LatentStyleExceptionInfo() { Name = "Colorful Shading Accent 3", UiPriority = 71 };
            LatentStyleExceptionInfo latentStyleExceptionInfo290 = new LatentStyleExceptionInfo() { Name = "Colorful List Accent 3", UiPriority = 72 };
            LatentStyleExceptionInfo latentStyleExceptionInfo291 = new LatentStyleExceptionInfo() { Name = "Colorful Grid Accent 3", UiPriority = 73 };
            LatentStyleExceptionInfo latentStyleExceptionInfo292 = new LatentStyleExceptionInfo() { Name = "Light Shading Accent 4", UiPriority = 60 };
            LatentStyleExceptionInfo latentStyleExceptionInfo293 = new LatentStyleExceptionInfo() { Name = "Light List Accent 4", UiPriority = 61 };
            LatentStyleExceptionInfo latentStyleExceptionInfo294 = new LatentStyleExceptionInfo() { Name = "Light Grid Accent 4", UiPriority = 62 };
            LatentStyleExceptionInfo latentStyleExceptionInfo295 = new LatentStyleExceptionInfo() { Name = "Medium Shading 1 Accent 4", UiPriority = 63 };
            LatentStyleExceptionInfo latentStyleExceptionInfo296 = new LatentStyleExceptionInfo() { Name = "Medium Shading 2 Accent 4", UiPriority = 64 };
            LatentStyleExceptionInfo latentStyleExceptionInfo297 = new LatentStyleExceptionInfo() { Name = "Medium List 1 Accent 4", UiPriority = 65 };
            LatentStyleExceptionInfo latentStyleExceptionInfo298 = new LatentStyleExceptionInfo() { Name = "Medium List 2 Accent 4", UiPriority = 66 };
            LatentStyleExceptionInfo latentStyleExceptionInfo299 = new LatentStyleExceptionInfo() { Name = "Medium Grid 1 Accent 4", UiPriority = 67 };
            LatentStyleExceptionInfo latentStyleExceptionInfo300 = new LatentStyleExceptionInfo() { Name = "Medium Grid 2 Accent 4", UiPriority = 68 };
            LatentStyleExceptionInfo latentStyleExceptionInfo301 = new LatentStyleExceptionInfo() { Name = "Medium Grid 3 Accent 4", UiPriority = 69 };
            LatentStyleExceptionInfo latentStyleExceptionInfo302 = new LatentStyleExceptionInfo() { Name = "Dark List Accent 4", UiPriority = 70 };
            LatentStyleExceptionInfo latentStyleExceptionInfo303 = new LatentStyleExceptionInfo() { Name = "Colorful Shading Accent 4", UiPriority = 71 };
            LatentStyleExceptionInfo latentStyleExceptionInfo304 = new LatentStyleExceptionInfo() { Name = "Colorful List Accent 4", UiPriority = 72 };
            LatentStyleExceptionInfo latentStyleExceptionInfo305 = new LatentStyleExceptionInfo() { Name = "Colorful Grid Accent 4", UiPriority = 73 };
            LatentStyleExceptionInfo latentStyleExceptionInfo306 = new LatentStyleExceptionInfo() { Name = "Light Shading Accent 5", UiPriority = 60 };
            LatentStyleExceptionInfo latentStyleExceptionInfo307 = new LatentStyleExceptionInfo() { Name = "Light List Accent 5", UiPriority = 61 };
            LatentStyleExceptionInfo latentStyleExceptionInfo308 = new LatentStyleExceptionInfo() { Name = "Light Grid Accent 5", UiPriority = 62 };
            LatentStyleExceptionInfo latentStyleExceptionInfo309 = new LatentStyleExceptionInfo() { Name = "Medium Shading 1 Accent 5", UiPriority = 63 };
            LatentStyleExceptionInfo latentStyleExceptionInfo310 = new LatentStyleExceptionInfo() { Name = "Medium Shading 2 Accent 5", UiPriority = 64 };
            LatentStyleExceptionInfo latentStyleExceptionInfo311 = new LatentStyleExceptionInfo() { Name = "Medium List 1 Accent 5", UiPriority = 65 };
            LatentStyleExceptionInfo latentStyleExceptionInfo312 = new LatentStyleExceptionInfo() { Name = "Medium List 2 Accent 5", UiPriority = 66 };
            LatentStyleExceptionInfo latentStyleExceptionInfo313 = new LatentStyleExceptionInfo() { Name = "Medium Grid 1 Accent 5", UiPriority = 67 };
            LatentStyleExceptionInfo latentStyleExceptionInfo314 = new LatentStyleExceptionInfo() { Name = "Medium Grid 2 Accent 5", UiPriority = 68 };
            LatentStyleExceptionInfo latentStyleExceptionInfo315 = new LatentStyleExceptionInfo() { Name = "Medium Grid 3 Accent 5", UiPriority = 69 };
            LatentStyleExceptionInfo latentStyleExceptionInfo316 = new LatentStyleExceptionInfo() { Name = "Dark List Accent 5", UiPriority = 70 };
            LatentStyleExceptionInfo latentStyleExceptionInfo317 = new LatentStyleExceptionInfo() { Name = "Colorful Shading Accent 5", UiPriority = 71 };
            LatentStyleExceptionInfo latentStyleExceptionInfo318 = new LatentStyleExceptionInfo() { Name = "Colorful List Accent 5", UiPriority = 72 };
            LatentStyleExceptionInfo latentStyleExceptionInfo319 = new LatentStyleExceptionInfo() { Name = "Colorful Grid Accent 5", UiPriority = 73 };
            LatentStyleExceptionInfo latentStyleExceptionInfo320 = new LatentStyleExceptionInfo() { Name = "Light Shading Accent 6", UiPriority = 60 };
            LatentStyleExceptionInfo latentStyleExceptionInfo321 = new LatentStyleExceptionInfo() { Name = "Light List Accent 6", UiPriority = 61 };
            LatentStyleExceptionInfo latentStyleExceptionInfo322 = new LatentStyleExceptionInfo() { Name = "Light Grid Accent 6", UiPriority = 62 };
            LatentStyleExceptionInfo latentStyleExceptionInfo323 = new LatentStyleExceptionInfo() { Name = "Medium Shading 1 Accent 6", UiPriority = 63 };
            LatentStyleExceptionInfo latentStyleExceptionInfo324 = new LatentStyleExceptionInfo() { Name = "Medium Shading 2 Accent 6", UiPriority = 64 };
            LatentStyleExceptionInfo latentStyleExceptionInfo325 = new LatentStyleExceptionInfo() { Name = "Medium List 1 Accent 6", UiPriority = 65 };
            LatentStyleExceptionInfo latentStyleExceptionInfo326 = new LatentStyleExceptionInfo() { Name = "Medium List 2 Accent 6", UiPriority = 66 };
            LatentStyleExceptionInfo latentStyleExceptionInfo327 = new LatentStyleExceptionInfo() { Name = "Medium Grid 1 Accent 6", UiPriority = 67 };
            LatentStyleExceptionInfo latentStyleExceptionInfo328 = new LatentStyleExceptionInfo() { Name = "Medium Grid 2 Accent 6", UiPriority = 68 };
            LatentStyleExceptionInfo latentStyleExceptionInfo329 = new LatentStyleExceptionInfo() { Name = "Medium Grid 3 Accent 6", UiPriority = 69 };
            LatentStyleExceptionInfo latentStyleExceptionInfo330 = new LatentStyleExceptionInfo() { Name = "Dark List Accent 6", UiPriority = 70 };
            LatentStyleExceptionInfo latentStyleExceptionInfo331 = new LatentStyleExceptionInfo() { Name = "Colorful Shading Accent 6", UiPriority = 71 };
            LatentStyleExceptionInfo latentStyleExceptionInfo332 = new LatentStyleExceptionInfo() { Name = "Colorful List Accent 6", UiPriority = 72 };
            LatentStyleExceptionInfo latentStyleExceptionInfo333 = new LatentStyleExceptionInfo() { Name = "Colorful Grid Accent 6", UiPriority = 73 };
            LatentStyleExceptionInfo latentStyleExceptionInfo334 = new LatentStyleExceptionInfo() { Name = "Subtle Emphasis", UiPriority = 19, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo335 = new LatentStyleExceptionInfo() { Name = "Intense Emphasis", UiPriority = 21, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo336 = new LatentStyleExceptionInfo() { Name = "Subtle Reference", UiPriority = 31, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo337 = new LatentStyleExceptionInfo() { Name = "Intense Reference", UiPriority = 32, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo338 = new LatentStyleExceptionInfo() { Name = "Book Title", UiPriority = 33, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo339 = new LatentStyleExceptionInfo() { Name = "Bibliography", UiPriority = 37, SemiHidden = true, UnhideWhenUsed = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo340 = new LatentStyleExceptionInfo() { Name = "TOC Heading", UiPriority = 39, SemiHidden = true, UnhideWhenUsed = true, PrimaryStyle = true };

            latentStyles2.Append(latentStyleExceptionInfo171);
            latentStyles2.Append(latentStyleExceptionInfo172);
            latentStyles2.Append(latentStyleExceptionInfo173);
            latentStyles2.Append(latentStyleExceptionInfo174);
            latentStyles2.Append(latentStyleExceptionInfo175);
            latentStyles2.Append(latentStyleExceptionInfo176);
            latentStyles2.Append(latentStyleExceptionInfo177);
            latentStyles2.Append(latentStyleExceptionInfo178);
            latentStyles2.Append(latentStyleExceptionInfo179);
            latentStyles2.Append(latentStyleExceptionInfo180);
            latentStyles2.Append(latentStyleExceptionInfo181);
            latentStyles2.Append(latentStyleExceptionInfo182);
            latentStyles2.Append(latentStyleExceptionInfo183);
            latentStyles2.Append(latentStyleExceptionInfo184);
            latentStyles2.Append(latentStyleExceptionInfo185);
            latentStyles2.Append(latentStyleExceptionInfo186);
            latentStyles2.Append(latentStyleExceptionInfo187);
            latentStyles2.Append(latentStyleExceptionInfo188);
            latentStyles2.Append(latentStyleExceptionInfo189);
            latentStyles2.Append(latentStyleExceptionInfo190);
            latentStyles2.Append(latentStyleExceptionInfo191);
            latentStyles2.Append(latentStyleExceptionInfo192);
            latentStyles2.Append(latentStyleExceptionInfo193);
            latentStyles2.Append(latentStyleExceptionInfo194);
            latentStyles2.Append(latentStyleExceptionInfo195);
            latentStyles2.Append(latentStyleExceptionInfo196);
            latentStyles2.Append(latentStyleExceptionInfo197);
            latentStyles2.Append(latentStyleExceptionInfo198);
            latentStyles2.Append(latentStyleExceptionInfo199);
            latentStyles2.Append(latentStyleExceptionInfo200);
            latentStyles2.Append(latentStyleExceptionInfo201);
            latentStyles2.Append(latentStyleExceptionInfo202);
            latentStyles2.Append(latentStyleExceptionInfo203);
            latentStyles2.Append(latentStyleExceptionInfo204);
            latentStyles2.Append(latentStyleExceptionInfo205);
            latentStyles2.Append(latentStyleExceptionInfo206);
            latentStyles2.Append(latentStyleExceptionInfo207);
            latentStyles2.Append(latentStyleExceptionInfo208);
            latentStyles2.Append(latentStyleExceptionInfo209);
            latentStyles2.Append(latentStyleExceptionInfo210);
            latentStyles2.Append(latentStyleExceptionInfo211);
            latentStyles2.Append(latentStyleExceptionInfo212);
            latentStyles2.Append(latentStyleExceptionInfo213);
            latentStyles2.Append(latentStyleExceptionInfo214);
            latentStyles2.Append(latentStyleExceptionInfo215);
            latentStyles2.Append(latentStyleExceptionInfo216);
            latentStyles2.Append(latentStyleExceptionInfo217);
            latentStyles2.Append(latentStyleExceptionInfo218);
            latentStyles2.Append(latentStyleExceptionInfo219);
            latentStyles2.Append(latentStyleExceptionInfo220);
            latentStyles2.Append(latentStyleExceptionInfo221);
            latentStyles2.Append(latentStyleExceptionInfo222);
            latentStyles2.Append(latentStyleExceptionInfo223);
            latentStyles2.Append(latentStyleExceptionInfo224);
            latentStyles2.Append(latentStyleExceptionInfo225);
            latentStyles2.Append(latentStyleExceptionInfo226);
            latentStyles2.Append(latentStyleExceptionInfo227);
            latentStyles2.Append(latentStyleExceptionInfo228);
            latentStyles2.Append(latentStyleExceptionInfo229);
            latentStyles2.Append(latentStyleExceptionInfo230);
            latentStyles2.Append(latentStyleExceptionInfo231);
            latentStyles2.Append(latentStyleExceptionInfo232);
            latentStyles2.Append(latentStyleExceptionInfo233);
            latentStyles2.Append(latentStyleExceptionInfo234);
            latentStyles2.Append(latentStyleExceptionInfo235);
            latentStyles2.Append(latentStyleExceptionInfo236);
            latentStyles2.Append(latentStyleExceptionInfo237);
            latentStyles2.Append(latentStyleExceptionInfo238);
            latentStyles2.Append(latentStyleExceptionInfo239);
            latentStyles2.Append(latentStyleExceptionInfo240);
            latentStyles2.Append(latentStyleExceptionInfo241);
            latentStyles2.Append(latentStyleExceptionInfo242);
            latentStyles2.Append(latentStyleExceptionInfo243);
            latentStyles2.Append(latentStyleExceptionInfo244);
            latentStyles2.Append(latentStyleExceptionInfo245);
            latentStyles2.Append(latentStyleExceptionInfo246);
            latentStyles2.Append(latentStyleExceptionInfo247);
            latentStyles2.Append(latentStyleExceptionInfo248);
            latentStyles2.Append(latentStyleExceptionInfo249);
            latentStyles2.Append(latentStyleExceptionInfo250);
            latentStyles2.Append(latentStyleExceptionInfo251);
            latentStyles2.Append(latentStyleExceptionInfo252);
            latentStyles2.Append(latentStyleExceptionInfo253);
            latentStyles2.Append(latentStyleExceptionInfo254);
            latentStyles2.Append(latentStyleExceptionInfo255);
            latentStyles2.Append(latentStyleExceptionInfo256);
            latentStyles2.Append(latentStyleExceptionInfo257);
            latentStyles2.Append(latentStyleExceptionInfo258);
            latentStyles2.Append(latentStyleExceptionInfo259);
            latentStyles2.Append(latentStyleExceptionInfo260);
            latentStyles2.Append(latentStyleExceptionInfo261);
            latentStyles2.Append(latentStyleExceptionInfo262);
            latentStyles2.Append(latentStyleExceptionInfo263);
            latentStyles2.Append(latentStyleExceptionInfo264);
            latentStyles2.Append(latentStyleExceptionInfo265);
            latentStyles2.Append(latentStyleExceptionInfo266);
            latentStyles2.Append(latentStyleExceptionInfo267);
            latentStyles2.Append(latentStyleExceptionInfo268);
            latentStyles2.Append(latentStyleExceptionInfo269);
            latentStyles2.Append(latentStyleExceptionInfo270);
            latentStyles2.Append(latentStyleExceptionInfo271);
            latentStyles2.Append(latentStyleExceptionInfo272);
            latentStyles2.Append(latentStyleExceptionInfo273);
            latentStyles2.Append(latentStyleExceptionInfo274);
            latentStyles2.Append(latentStyleExceptionInfo275);
            latentStyles2.Append(latentStyleExceptionInfo276);
            latentStyles2.Append(latentStyleExceptionInfo277);
            latentStyles2.Append(latentStyleExceptionInfo278);
            latentStyles2.Append(latentStyleExceptionInfo279);
            latentStyles2.Append(latentStyleExceptionInfo280);
            latentStyles2.Append(latentStyleExceptionInfo281);
            latentStyles2.Append(latentStyleExceptionInfo282);
            latentStyles2.Append(latentStyleExceptionInfo283);
            latentStyles2.Append(latentStyleExceptionInfo284);
            latentStyles2.Append(latentStyleExceptionInfo285);
            latentStyles2.Append(latentStyleExceptionInfo286);
            latentStyles2.Append(latentStyleExceptionInfo287);
            latentStyles2.Append(latentStyleExceptionInfo288);
            latentStyles2.Append(latentStyleExceptionInfo289);
            latentStyles2.Append(latentStyleExceptionInfo290);
            latentStyles2.Append(latentStyleExceptionInfo291);
            latentStyles2.Append(latentStyleExceptionInfo292);
            latentStyles2.Append(latentStyleExceptionInfo293);
            latentStyles2.Append(latentStyleExceptionInfo294);
            latentStyles2.Append(latentStyleExceptionInfo295);
            latentStyles2.Append(latentStyleExceptionInfo296);
            latentStyles2.Append(latentStyleExceptionInfo297);
            latentStyles2.Append(latentStyleExceptionInfo298);
            latentStyles2.Append(latentStyleExceptionInfo299);
            latentStyles2.Append(latentStyleExceptionInfo300);
            latentStyles2.Append(latentStyleExceptionInfo301);
            latentStyles2.Append(latentStyleExceptionInfo302);
            latentStyles2.Append(latentStyleExceptionInfo303);
            latentStyles2.Append(latentStyleExceptionInfo304);
            latentStyles2.Append(latentStyleExceptionInfo305);
            latentStyles2.Append(latentStyleExceptionInfo306);
            latentStyles2.Append(latentStyleExceptionInfo307);
            latentStyles2.Append(latentStyleExceptionInfo308);
            latentStyles2.Append(latentStyleExceptionInfo309);
            latentStyles2.Append(latentStyleExceptionInfo310);
            latentStyles2.Append(latentStyleExceptionInfo311);
            latentStyles2.Append(latentStyleExceptionInfo312);
            latentStyles2.Append(latentStyleExceptionInfo313);
            latentStyles2.Append(latentStyleExceptionInfo314);
            latentStyles2.Append(latentStyleExceptionInfo315);
            latentStyles2.Append(latentStyleExceptionInfo316);
            latentStyles2.Append(latentStyleExceptionInfo317);
            latentStyles2.Append(latentStyleExceptionInfo318);
            latentStyles2.Append(latentStyleExceptionInfo319);
            latentStyles2.Append(latentStyleExceptionInfo320);
            latentStyles2.Append(latentStyleExceptionInfo321);
            latentStyles2.Append(latentStyleExceptionInfo322);
            latentStyles2.Append(latentStyleExceptionInfo323);
            latentStyles2.Append(latentStyleExceptionInfo324);
            latentStyles2.Append(latentStyleExceptionInfo325);
            latentStyles2.Append(latentStyleExceptionInfo326);
            latentStyles2.Append(latentStyleExceptionInfo327);
            latentStyles2.Append(latentStyleExceptionInfo328);
            latentStyles2.Append(latentStyleExceptionInfo329);
            latentStyles2.Append(latentStyleExceptionInfo330);
            latentStyles2.Append(latentStyleExceptionInfo331);
            latentStyles2.Append(latentStyleExceptionInfo332);
            latentStyles2.Append(latentStyleExceptionInfo333);
            latentStyles2.Append(latentStyleExceptionInfo334);
            latentStyles2.Append(latentStyleExceptionInfo335);
            latentStyles2.Append(latentStyleExceptionInfo336);
            latentStyles2.Append(latentStyleExceptionInfo337);
            latentStyles2.Append(latentStyleExceptionInfo338);
            latentStyles2.Append(latentStyleExceptionInfo339);
            latentStyles2.Append(latentStyleExceptionInfo340);

            Style style12 = new Style() { Type = StyleValues.Paragraph, StyleId = "a", Default = true };
            StyleName styleName12 = new StyleName() { Val = "Normal" };
            PrimaryStyle primaryStyle4 = new PrimaryStyle();

            StyleRunProperties styleRunProperties8 = new StyleRunProperties();
            FontSize fontSize346 = new FontSize() { Val = "24" };
            FontSizeComplexScript fontSizeComplexScript345 = new FontSizeComplexScript() { Val = "24" };

            styleRunProperties8.Append(fontSize346);
            styleRunProperties8.Append(fontSizeComplexScript345);

            style12.Append(styleName12);
            style12.Append(primaryStyle4);
            style12.Append(styleRunProperties8);

            Style style13 = new Style() { Type = StyleValues.Paragraph, StyleId = "5" };
            StyleName styleName13 = new StyleName() { Val = "heading 5" };
            BasedOn basedOn6 = new BasedOn() { Val = "a" };
            NextParagraphStyle nextParagraphStyle2 = new NextParagraphStyle() { Val = "a" };
            PrimaryStyle primaryStyle5 = new PrimaryStyle();
            Rsid rsid8 = new Rsid() { Val = "00E456A8" };

            StyleParagraphProperties styleParagraphProperties3 = new StyleParagraphProperties();
            SpacingBetweenLines spacingBetweenLines2 = new SpacingBetweenLines() { Before = "240", After = "60" };
            OutlineLevel outlineLevel2 = new OutlineLevel() { Val = 4 };

            styleParagraphProperties3.Append(spacingBetweenLines2);
            styleParagraphProperties3.Append(outlineLevel2);

            StyleRunProperties styleRunProperties9 = new StyleRunProperties();
            Bold bold223 = new Bold();
            BoldComplexScript boldComplexScript5 = new BoldComplexScript();
            Italic italic83 = new Italic();
            ItalicComplexScript italicComplexScript2 = new ItalicComplexScript();
            FontSize fontSize347 = new FontSize() { Val = "26" };
            FontSizeComplexScript fontSizeComplexScript346 = new FontSizeComplexScript() { Val = "26" };

            styleRunProperties9.Append(bold223);
            styleRunProperties9.Append(boldComplexScript5);
            styleRunProperties9.Append(italic83);
            styleRunProperties9.Append(italicComplexScript2);
            styleRunProperties9.Append(fontSize347);
            styleRunProperties9.Append(fontSizeComplexScript346);

            style13.Append(styleName13);
            style13.Append(basedOn6);
            style13.Append(nextParagraphStyle2);
            style13.Append(primaryStyle5);
            style13.Append(rsid8);
            style13.Append(styleParagraphProperties3);
            style13.Append(styleRunProperties9);

            Style style14 = new Style() { Type = StyleValues.Character, StyleId = "a0", Default = true };
            StyleName styleName14 = new StyleName() { Val = "Default Paragraph Font" };
            UIPriority uIPriority5 = new UIPriority() { Val = 1 };
            SemiHidden semiHidden5 = new SemiHidden();
            UnhideWhenUsed unhideWhenUsed4 = new UnhideWhenUsed();

            style14.Append(styleName14);
            style14.Append(uIPriority5);
            style14.Append(semiHidden5);
            style14.Append(unhideWhenUsed4);

            Style style15 = new Style() { Type = StyleValues.Table, StyleId = "a1", Default = true };
            StyleName styleName15 = new StyleName() { Val = "Normal Table" };
            UIPriority uIPriority6 = new UIPriority() { Val = 99 };
            SemiHidden semiHidden6 = new SemiHidden();
            UnhideWhenUsed unhideWhenUsed5 = new UnhideWhenUsed();

            StyleTableProperties styleTableProperties3 = new StyleTableProperties();
            TableIndentation tableIndentation3 = new TableIndentation() { Width = 0, Type = TableWidthUnitValues.Dxa };

            TableCellMarginDefault tableCellMarginDefault2 = new TableCellMarginDefault();
            TopMargin topMargin2 = new TopMargin() { Width = "0", Type = TableWidthUnitValues.Dxa };
            TableCellLeftMargin tableCellLeftMargin2 = new TableCellLeftMargin() { Width = 108, Type = TableWidthValues.Dxa };
            BottomMargin bottomMargin2 = new BottomMargin() { Width = "0", Type = TableWidthUnitValues.Dxa };
            TableCellRightMargin tableCellRightMargin2 = new TableCellRightMargin() { Width = 108, Type = TableWidthValues.Dxa };

            tableCellMarginDefault2.Append(topMargin2);
            tableCellMarginDefault2.Append(tableCellLeftMargin2);
            tableCellMarginDefault2.Append(bottomMargin2);
            tableCellMarginDefault2.Append(tableCellRightMargin2);

            styleTableProperties3.Append(tableIndentation3);
            styleTableProperties3.Append(tableCellMarginDefault2);

            style15.Append(styleName15);
            style15.Append(uIPriority6);
            style15.Append(semiHidden6);
            style15.Append(unhideWhenUsed5);
            style15.Append(styleTableProperties3);

            Style style16 = new Style() { Type = StyleValues.Numbering, StyleId = "a2", Default = true };
            StyleName styleName16 = new StyleName() { Val = "No List" };
            UIPriority uIPriority7 = new UIPriority() { Val = 99 };
            SemiHidden semiHidden7 = new SemiHidden();
            UnhideWhenUsed unhideWhenUsed6 = new UnhideWhenUsed();

            style16.Append(styleName16);
            style16.Append(uIPriority7);
            style16.Append(semiHidden7);
            style16.Append(unhideWhenUsed6);

            Style style17 = new Style() { Type = StyleValues.Paragraph, StyleId = "a3" };
            StyleName styleName17 = new StyleName() { Val = "footer" };
            BasedOn basedOn7 = new BasedOn() { Val = "a" };
            Rsid rsid9 = new Rsid() { Val = "00692F95" };

            StyleParagraphProperties styleParagraphProperties4 = new StyleParagraphProperties();

            Tabs tabs3 = new Tabs();
            TabStop tabStop4 = new TabStop() { Val = TabStopValues.Center, Position = 4677 };
            TabStop tabStop5 = new TabStop() { Val = TabStopValues.Right, Position = 9355 };

            tabs3.Append(tabStop4);
            tabs3.Append(tabStop5);

            styleParagraphProperties4.Append(tabs3);

            StyleRunProperties styleRunProperties10 = new StyleRunProperties();
            FontSize fontSize348 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript347 = new FontSizeComplexScript() { Val = "28" };
            Languages languages111 = new Languages() { Val = "uk-UA" };

            styleRunProperties10.Append(fontSize348);
            styleRunProperties10.Append(fontSizeComplexScript347);
            styleRunProperties10.Append(languages111);

            style17.Append(styleName17);
            style17.Append(basedOn7);
            style17.Append(rsid9);
            style17.Append(styleParagraphProperties4);
            style17.Append(styleRunProperties10);

            Style style18 = new Style() { Type = StyleValues.Paragraph, StyleId = "2" };
            StyleName styleName18 = new StyleName() { Val = "Body Text 2" };
            BasedOn basedOn8 = new BasedOn() { Val = "a" };
            LinkedStyle linkedStyle3 = new LinkedStyle() { Val = "20" };
            Rsid rsid10 = new Rsid() { Val = "008855BE" };

            StyleRunProperties styleRunProperties11 = new StyleRunProperties();
            RunFonts runFonts41 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial" };
            FontSize fontSize349 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript348 = new FontSizeComplexScript() { Val = "20" };
            Languages languages112 = new Languages() { Val = "x-none", EastAsia = "x-none" };

            styleRunProperties11.Append(runFonts41);
            styleRunProperties11.Append(fontSize349);
            styleRunProperties11.Append(fontSizeComplexScript348);
            styleRunProperties11.Append(languages112);

            style18.Append(styleName18);
            style18.Append(basedOn8);
            style18.Append(linkedStyle3);
            style18.Append(rsid10);
            style18.Append(styleRunProperties11);

            Style style19 = new Style() { Type = StyleValues.Paragraph, StyleId = "a4" };
            StyleName styleName19 = new StyleName() { Val = "Balloon Text" };
            BasedOn basedOn9 = new BasedOn() { Val = "a" };
            SemiHidden semiHidden8 = new SemiHidden();
            Rsid rsid11 = new Rsid() { Val = "00F92B85" };

            StyleRunProperties styleRunProperties12 = new StyleRunProperties();
            RunFonts runFonts42 = new RunFonts() { Ascii = "Tahoma", HighAnsi = "Tahoma", ComplexScript = "Tahoma" };
            FontSize fontSize350 = new FontSize() { Val = "16" };
            FontSizeComplexScript fontSizeComplexScript349 = new FontSizeComplexScript() { Val = "16" };

            styleRunProperties12.Append(runFonts42);
            styleRunProperties12.Append(fontSize350);
            styleRunProperties12.Append(fontSizeComplexScript349);

            style19.Append(styleName19);
            style19.Append(basedOn9);
            style19.Append(semiHidden8);
            style19.Append(rsid11);
            style19.Append(styleRunProperties12);

            Style style20 = new Style() { Type = StyleValues.Table, StyleId = "a5" };
            StyleName styleName20 = new StyleName() { Val = "Table Grid" };
            BasedOn basedOn10 = new BasedOn() { Val = "a1" };
            Rsid rsid12 = new Rsid() { Val = "00A13B37" };

            StyleTableProperties styleTableProperties4 = new StyleTableProperties();

            TableBorders tableBorders3 = new TableBorders();
            TopBorder topBorder3 = new TopBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            LeftBorder leftBorder3 = new LeftBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder3 = new BottomBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            RightBorder rightBorder3 = new RightBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            InsideHorizontalBorder insideHorizontalBorder3 = new InsideHorizontalBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            InsideVerticalBorder insideVerticalBorder3 = new InsideVerticalBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };

            tableBorders3.Append(topBorder3);
            tableBorders3.Append(leftBorder3);
            tableBorders3.Append(bottomBorder3);
            tableBorders3.Append(rightBorder3);
            tableBorders3.Append(insideHorizontalBorder3);
            tableBorders3.Append(insideVerticalBorder3);

            styleTableProperties4.Append(tableBorders3);

            style20.Append(styleName20);
            style20.Append(basedOn10);
            style20.Append(rsid12);
            style20.Append(styleTableProperties4);

            Style style21 = new Style() { Type = StyleValues.Character, StyleId = "20", CustomStyle = true };
            StyleName styleName21 = new StyleName() { Val = "Основной текст 2 Знак" };
            LinkedStyle linkedStyle4 = new LinkedStyle() { Val = "2" };
            Rsid rsid13 = new Rsid() { Val = "00E23013" };

            StyleRunProperties styleRunProperties13 = new StyleRunProperties();
            RunFonts runFonts43 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial" };
            FontSize fontSize351 = new FontSize() { Val = "28" };

            styleRunProperties13.Append(runFonts43);
            styleRunProperties13.Append(fontSize351);

            style21.Append(styleName21);
            style21.Append(linkedStyle4);
            style21.Append(rsid13);
            style21.Append(styleRunProperties13);

            Style style22 = new Style() { Type = StyleValues.Paragraph, StyleId = "a6" };
            StyleName styleName22 = new StyleName() { Val = "No Spacing" };
            UIPriority uIPriority8 = new UIPriority() { Val = 1 };
            PrimaryStyle primaryStyle6 = new PrimaryStyle();
            Rsid rsid14 = new Rsid() { Val = "006D0A4B" };

            StyleRunProperties styleRunProperties14 = new StyleRunProperties();
            RunFonts runFonts44 = new RunFonts() { Ascii = "Calibri", HighAnsi = "Calibri", EastAsia = "Calibri" };
            FontSize fontSize352 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript350 = new FontSizeComplexScript() { Val = "22" };
            Languages languages113 = new Languages() { EastAsia = "en-US" };

            styleRunProperties14.Append(runFonts44);
            styleRunProperties14.Append(fontSize352);
            styleRunProperties14.Append(fontSizeComplexScript350);
            styleRunProperties14.Append(languages113);

            style22.Append(styleName22);
            style22.Append(uIPriority8);
            style22.Append(primaryStyle6);
            style22.Append(rsid14);
            style22.Append(styleRunProperties14);

            styles2.Append(docDefaults2);
            styles2.Append(latentStyles2);
            styles2.Append(style12);
            styles2.Append(style13);
            styles2.Append(style14);
            styles2.Append(style15);
            styles2.Append(style16);
            styles2.Append(style17);
            styles2.Append(style18);
            styles2.Append(style19);
            styles2.Append(style20);
            styles2.Append(style21);
            styles2.Append(style22);

            styleDefinitionsPart1.Styles = styles2;
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
            Ds.DataStoreItem dataStoreItem1 = new Ds.DataStoreItem() { ItemId = "{ED812939-8E66-4778-AEB2-FD6C97A9BC43}" };
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
            Fonts fonts1 = new Fonts() { MCAttributes = new MarkupCompatibilityAttributes() { Ignorable = "w14" } };
            fonts1.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            fonts1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            fonts1.AddNamespaceDeclaration("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
            fonts1.AddNamespaceDeclaration("w14", "http://schemas.microsoft.com/office/word/2010/wordml");

            Font font1 = new Font() { Name = "Times New Roman" };
            Panose1Number panose1Number1 = new Panose1Number() { Val = "02020603050405020304" };
            FontCharSet fontCharSet1 = new FontCharSet() { Val = "CC" };
            FontFamily fontFamily1 = new FontFamily() { Val = FontFamilyValues.Roman };
            Pitch pitch1 = new Pitch() { Val = FontPitchValues.Variable };
            FontSignature fontSignature1 = new FontSignature() { UnicodeSignature0 = "E0002EFF", UnicodeSignature1 = "C0007843", UnicodeSignature2 = "00000009", UnicodeSignature3 = "00000000", CodePageSignature0 = "000001FF", CodePageSignature1 = "00000000" };

            font1.Append(panose1Number1);
            font1.Append(fontCharSet1);
            font1.Append(fontFamily1);
            font1.Append(pitch1);
            font1.Append(fontSignature1);

            Font font2 = new Font() { Name = "Arial" };
            Panose1Number panose1Number2 = new Panose1Number() { Val = "020B0604020202020204" };
            FontCharSet fontCharSet2 = new FontCharSet() { Val = "CC" };
            FontFamily fontFamily2 = new FontFamily() { Val = FontFamilyValues.Swiss };
            Pitch pitch2 = new Pitch() { Val = FontPitchValues.Variable };
            FontSignature fontSignature2 = new FontSignature() { UnicodeSignature0 = "E0002EFF", UnicodeSignature1 = "C0007843", UnicodeSignature2 = "00000009", UnicodeSignature3 = "00000000", CodePageSignature0 = "000001FF", CodePageSignature1 = "00000000" };

            font2.Append(panose1Number2);
            font2.Append(fontCharSet2);
            font2.Append(fontFamily2);
            font2.Append(pitch2);
            font2.Append(fontSignature2);

            Font font3 = new Font() { Name = "Tahoma" };
            Panose1Number panose1Number3 = new Panose1Number() { Val = "020B0604030504040204" };
            FontCharSet fontCharSet3 = new FontCharSet() { Val = "00" };
            FontFamily fontFamily3 = new FontFamily() { Val = FontFamilyValues.Swiss };
            NotTrueType notTrueType1 = new NotTrueType();
            Pitch pitch3 = new Pitch() { Val = FontPitchValues.Variable };
            FontSignature fontSignature3 = new FontSignature() { UnicodeSignature0 = "00000003", UnicodeSignature1 = "00000000", UnicodeSignature2 = "00000000", UnicodeSignature3 = "00000000", CodePageSignature0 = "00000001", CodePageSignature1 = "00000000" };

            font3.Append(panose1Number3);
            font3.Append(fontCharSet3);
            font3.Append(fontFamily3);
            font3.Append(notTrueType1);
            font3.Append(pitch3);
            font3.Append(fontSignature3);

            Font font4 = new Font() { Name = "Calibri" };
            Panose1Number panose1Number4 = new Panose1Number() { Val = "020F0502020204030204" };
            FontCharSet fontCharSet4 = new FontCharSet() { Val = "CC" };
            FontFamily fontFamily4 = new FontFamily() { Val = FontFamilyValues.Swiss };
            Pitch pitch4 = new Pitch() { Val = FontPitchValues.Variable };
            FontSignature fontSignature4 = new FontSignature() { UnicodeSignature0 = "E00002FF", UnicodeSignature1 = "4000ACFF", UnicodeSignature2 = "00000001", UnicodeSignature3 = "00000000", CodePageSignature0 = "0000019F", CodePageSignature1 = "00000000" };

            font4.Append(panose1Number4);
            font4.Append(fontCharSet4);
            font4.Append(fontFamily4);
            font4.Append(pitch4);
            font4.Append(fontSignature4);

            Font font5 = new Font() { Name = "Calibri Light" };
            Panose1Number panose1Number5 = new Panose1Number() { Val = "020F0302020204030204" };
            FontCharSet fontCharSet5 = new FontCharSet() { Val = "CC" };
            FontFamily fontFamily5 = new FontFamily() { Val = FontFamilyValues.Swiss };
            Pitch pitch5 = new Pitch() { Val = FontPitchValues.Variable };
            FontSignature fontSignature5 = new FontSignature() { UnicodeSignature0 = "A00002EF", UnicodeSignature1 = "4000207B", UnicodeSignature2 = "00000000", UnicodeSignature3 = "00000000", CodePageSignature0 = "0000019F", CodePageSignature1 = "00000000" };

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

        // Generates content of webSettingsPart1.
        private void GenerateWebSettingsPart1Content(WebSettingsPart webSettingsPart1)
        {
            WebSettings webSettings1 = new WebSettings() { MCAttributes = new MarkupCompatibilityAttributes() { Ignorable = "w14" } };
            webSettings1.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            webSettings1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            webSettings1.AddNamespaceDeclaration("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
            webSettings1.AddNamespaceDeclaration("w14", "http://schemas.microsoft.com/office/word/2010/wordml");

            Divs divs1 = new Divs();

            Div div1 = new Div() { Id = "307394769" };
            BodyDiv bodyDiv1 = new BodyDiv() { Val = true };
            LeftMarginDiv leftMarginDiv1 = new LeftMarginDiv() { Val = "0" };
            RightMarginDiv rightMarginDiv1 = new RightMarginDiv() { Val = "0" };
            TopMarginDiv topMarginDiv1 = new TopMarginDiv() { Val = "0" };
            BottomMarginDiv bottomMarginDiv1 = new BottomMarginDiv() { Val = "0" };

            DivBorder divBorder1 = new DivBorder();
            TopBorder topBorder4 = new TopBorder() { Val = BorderValues.None, Color = "auto", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder4 = new LeftBorder() { Val = BorderValues.None, Color = "auto", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder4 = new BottomBorder() { Val = BorderValues.None, Color = "auto", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder4 = new RightBorder() { Val = BorderValues.None, Color = "auto", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            divBorder1.Append(topBorder4);
            divBorder1.Append(leftBorder4);
            divBorder1.Append(bottomBorder4);
            divBorder1.Append(rightBorder4);

            div1.Append(bodyDiv1);
            div1.Append(leftMarginDiv1);
            div1.Append(rightMarginDiv1);
            div1.Append(topMarginDiv1);
            div1.Append(bottomMarginDiv1);
            div1.Append(divBorder1);

            Div div2 = new Div() { Id = "467354799" };
            BodyDiv bodyDiv2 = new BodyDiv() { Val = true };
            LeftMarginDiv leftMarginDiv2 = new LeftMarginDiv() { Val = "0" };
            RightMarginDiv rightMarginDiv2 = new RightMarginDiv() { Val = "0" };
            TopMarginDiv topMarginDiv2 = new TopMarginDiv() { Val = "0" };
            BottomMarginDiv bottomMarginDiv2 = new BottomMarginDiv() { Val = "0" };

            DivBorder divBorder2 = new DivBorder();
            TopBorder topBorder5 = new TopBorder() { Val = BorderValues.None, Color = "auto", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder5 = new LeftBorder() { Val = BorderValues.None, Color = "auto", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder5 = new BottomBorder() { Val = BorderValues.None, Color = "auto", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder5 = new RightBorder() { Val = BorderValues.None, Color = "auto", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            divBorder2.Append(topBorder5);
            divBorder2.Append(leftBorder5);
            divBorder2.Append(bottomBorder5);
            divBorder2.Append(rightBorder5);

            div2.Append(bodyDiv2);
            div2.Append(leftMarginDiv2);
            div2.Append(rightMarginDiv2);
            div2.Append(topMarginDiv2);
            div2.Append(bottomMarginDiv2);
            div2.Append(divBorder2);

            Div div3 = new Div() { Id = "482822126" };
            BodyDiv bodyDiv3 = new BodyDiv() { Val = true };
            LeftMarginDiv leftMarginDiv3 = new LeftMarginDiv() { Val = "0" };
            RightMarginDiv rightMarginDiv3 = new RightMarginDiv() { Val = "0" };
            TopMarginDiv topMarginDiv3 = new TopMarginDiv() { Val = "0" };
            BottomMarginDiv bottomMarginDiv3 = new BottomMarginDiv() { Val = "0" };

            DivBorder divBorder3 = new DivBorder();
            TopBorder topBorder6 = new TopBorder() { Val = BorderValues.None, Color = "auto", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder6 = new LeftBorder() { Val = BorderValues.None, Color = "auto", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder6 = new BottomBorder() { Val = BorderValues.None, Color = "auto", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder6 = new RightBorder() { Val = BorderValues.None, Color = "auto", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            divBorder3.Append(topBorder6);
            divBorder3.Append(leftBorder6);
            divBorder3.Append(bottomBorder6);
            divBorder3.Append(rightBorder6);

            div3.Append(bodyDiv3);
            div3.Append(leftMarginDiv3);
            div3.Append(rightMarginDiv3);
            div3.Append(topMarginDiv3);
            div3.Append(bottomMarginDiv3);
            div3.Append(divBorder3);

            Div div4 = new Div() { Id = "964578615" };
            BodyDiv bodyDiv4 = new BodyDiv() { Val = true };
            LeftMarginDiv leftMarginDiv4 = new LeftMarginDiv() { Val = "0" };
            RightMarginDiv rightMarginDiv4 = new RightMarginDiv() { Val = "0" };
            TopMarginDiv topMarginDiv4 = new TopMarginDiv() { Val = "0" };
            BottomMarginDiv bottomMarginDiv4 = new BottomMarginDiv() { Val = "0" };

            DivBorder divBorder4 = new DivBorder();
            TopBorder topBorder7 = new TopBorder() { Val = BorderValues.None, Color = "auto", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder7 = new LeftBorder() { Val = BorderValues.None, Color = "auto", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder7 = new BottomBorder() { Val = BorderValues.None, Color = "auto", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder7 = new RightBorder() { Val = BorderValues.None, Color = "auto", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            divBorder4.Append(topBorder7);
            divBorder4.Append(leftBorder7);
            divBorder4.Append(bottomBorder7);
            divBorder4.Append(rightBorder7);

            div4.Append(bodyDiv4);
            div4.Append(leftMarginDiv4);
            div4.Append(rightMarginDiv4);
            div4.Append(topMarginDiv4);
            div4.Append(bottomMarginDiv4);
            div4.Append(divBorder4);

            Div div5 = new Div() { Id = "1138382657" };
            BodyDiv bodyDiv5 = new BodyDiv() { Val = true };
            LeftMarginDiv leftMarginDiv5 = new LeftMarginDiv() { Val = "0" };
            RightMarginDiv rightMarginDiv5 = new RightMarginDiv() { Val = "0" };
            TopMarginDiv topMarginDiv5 = new TopMarginDiv() { Val = "0" };
            BottomMarginDiv bottomMarginDiv5 = new BottomMarginDiv() { Val = "0" };

            DivBorder divBorder5 = new DivBorder();
            TopBorder topBorder8 = new TopBorder() { Val = BorderValues.None, Color = "auto", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder8 = new LeftBorder() { Val = BorderValues.None, Color = "auto", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder8 = new BottomBorder() { Val = BorderValues.None, Color = "auto", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder8 = new RightBorder() { Val = BorderValues.None, Color = "auto", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            divBorder5.Append(topBorder8);
            divBorder5.Append(leftBorder8);
            divBorder5.Append(bottomBorder8);
            divBorder5.Append(rightBorder8);

            div5.Append(bodyDiv5);
            div5.Append(leftMarginDiv5);
            div5.Append(rightMarginDiv5);
            div5.Append(topMarginDiv5);
            div5.Append(bottomMarginDiv5);
            div5.Append(divBorder5);

            Div div6 = new Div() { Id = "1423718471" };
            BodyDiv bodyDiv6 = new BodyDiv() { Val = true };
            LeftMarginDiv leftMarginDiv6 = new LeftMarginDiv() { Val = "0" };
            RightMarginDiv rightMarginDiv6 = new RightMarginDiv() { Val = "0" };
            TopMarginDiv topMarginDiv6 = new TopMarginDiv() { Val = "0" };
            BottomMarginDiv bottomMarginDiv6 = new BottomMarginDiv() { Val = "0" };

            DivBorder divBorder6 = new DivBorder();
            TopBorder topBorder9 = new TopBorder() { Val = BorderValues.None, Color = "auto", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder9 = new LeftBorder() { Val = BorderValues.None, Color = "auto", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder9 = new BottomBorder() { Val = BorderValues.None, Color = "auto", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder9 = new RightBorder() { Val = BorderValues.None, Color = "auto", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            divBorder6.Append(topBorder9);
            divBorder6.Append(leftBorder9);
            divBorder6.Append(bottomBorder9);
            divBorder6.Append(rightBorder9);

            div6.Append(bodyDiv6);
            div6.Append(leftMarginDiv6);
            div6.Append(rightMarginDiv6);
            div6.Append(topMarginDiv6);
            div6.Append(bottomMarginDiv6);
            div6.Append(divBorder6);

            Div div7 = new Div() { Id = "1587377466" };
            BodyDiv bodyDiv7 = new BodyDiv() { Val = true };
            LeftMarginDiv leftMarginDiv7 = new LeftMarginDiv() { Val = "0" };
            RightMarginDiv rightMarginDiv7 = new RightMarginDiv() { Val = "0" };
            TopMarginDiv topMarginDiv7 = new TopMarginDiv() { Val = "0" };
            BottomMarginDiv bottomMarginDiv7 = new BottomMarginDiv() { Val = "0" };

            DivBorder divBorder7 = new DivBorder();
            TopBorder topBorder10 = new TopBorder() { Val = BorderValues.None, Color = "auto", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder10 = new LeftBorder() { Val = BorderValues.None, Color = "auto", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder10 = new BottomBorder() { Val = BorderValues.None, Color = "auto", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder10 = new RightBorder() { Val = BorderValues.None, Color = "auto", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            divBorder7.Append(topBorder10);
            divBorder7.Append(leftBorder10);
            divBorder7.Append(bottomBorder10);
            divBorder7.Append(rightBorder10);

            div7.Append(bodyDiv7);
            div7.Append(leftMarginDiv7);
            div7.Append(rightMarginDiv7);
            div7.Append(topMarginDiv7);
            div7.Append(bottomMarginDiv7);
            div7.Append(divBorder7);

            divs1.Append(div1);
            divs1.Append(div2);
            divs1.Append(div3);
            divs1.Append(div4);
            divs1.Append(div5);
            divs1.Append(div6);
            divs1.Append(div7);
            OptimizeForBrowser optimizeForBrowser1 = new OptimizeForBrowser();

            webSettings1.Append(divs1);
            webSettings1.Append(optimizeForBrowser1);

            webSettingsPart1.WebSettings = webSettings1;
        }

        // Generates content of documentSettingsPart1.
        private void GenerateDocumentSettingsPart1Content(DocumentSettingsPart documentSettingsPart1)
        {
            Settings settings1 = new Settings() { MCAttributes = new MarkupCompatibilityAttributes() { Ignorable = "w14" } };
            settings1.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            settings1.AddNamespaceDeclaration("o", "urn:schemas-microsoft-com:office:office");
            settings1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            settings1.AddNamespaceDeclaration("m", "http://schemas.openxmlformats.org/officeDocument/2006/math");
            settings1.AddNamespaceDeclaration("v", "urn:schemas-microsoft-com:vml");
            settings1.AddNamespaceDeclaration("w10", "urn:schemas-microsoft-com:office:word");
            settings1.AddNamespaceDeclaration("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
            settings1.AddNamespaceDeclaration("w14", "http://schemas.microsoft.com/office/word/2010/wordml");
            settings1.AddNamespaceDeclaration("sl", "http://schemas.openxmlformats.org/schemaLibrary/2006/main");
            Zoom zoom1 = new Zoom() { Percent = "120" };
            ProofState proofState1 = new ProofState() { Spelling = ProofingStateValues.Clean, Grammar = ProofingStateValues.Clean };
            StylePaneFormatFilter stylePaneFormatFilter1 = new StylePaneFormatFilter() { Val = "3F01", AllStyles = true, CustomStyles = false, LatentStyles = false, StylesInUse = false, HeadingStyles = false, NumberingStyles = false, TableStyles = false, DirectFormattingOnRuns = true, DirectFormattingOnParagraphs = true, DirectFormattingOnNumbering = true, DirectFormattingOnTables = true, ClearFormatting = true, Top3HeadingStyles = true, VisibleStyles = false, AlternateStyleNames = false };
            DefaultTabStop defaultTabStop1 = new DefaultTabStop() { Val = 708 };
            HyphenationZone hyphenationZone1 = new HyphenationZone() { Val = "425" };
            NoPunctuationKerning noPunctuationKerning1 = new NoPunctuationKerning();
            CharacterSpacingControl characterSpacingControl1 = new CharacterSpacingControl() { Val = CharacterSpacingValues.DoNotCompress };

            Compatibility compatibility1 = new Compatibility();
            CompatibilitySetting compatibilitySetting1 = new CompatibilitySetting() { Name = CompatSettingNameValues.CompatibilityMode, Uri = "http://schemas.microsoft.com/office/word", Val = "14" };
            CompatibilitySetting compatibilitySetting2 = new CompatibilitySetting() { Name = CompatSettingNameValues.OverrideTableStyleFontSizeAndJustification, Uri = "http://schemas.microsoft.com/office/word", Val = "1" };
            CompatibilitySetting compatibilitySetting3 = new CompatibilitySetting() { Name = CompatSettingNameValues.EnableOpenTypeFeatures, Uri = "http://schemas.microsoft.com/office/word", Val = "1" };
            CompatibilitySetting compatibilitySetting4 = new CompatibilitySetting() { Name = CompatSettingNameValues.DoNotFlipMirrorIndents, Uri = "http://schemas.microsoft.com/office/word", Val = "1" };

            compatibility1.Append(compatibilitySetting1);
            compatibility1.Append(compatibilitySetting2);
            compatibility1.Append(compatibilitySetting3);
            compatibility1.Append(compatibilitySetting4);

            Rsids rsids1 = new Rsids();
            RsidRoot rsidRoot1 = new RsidRoot() { Val = "00FE4911" };
            Rsid rsid15 = new Rsid() { Val = "0000019B" };
            Rsid rsid16 = new Rsid() { Val = "00000B39" };
            Rsid rsid17 = new Rsid() { Val = "000022EB" };
            Rsid rsid18 = new Rsid() { Val = "00002375" };
            Rsid rsid19 = new Rsid() { Val = "000027D6" };
            Rsid rsid20 = new Rsid() { Val = "00003F25" };
            Rsid rsid21 = new Rsid() { Val = "00015A47" };
            Rsid rsid22 = new Rsid() { Val = "00020BFE" };
            Rsid rsid23 = new Rsid() { Val = "00027B13" };
            Rsid rsid24 = new Rsid() { Val = "00027BB2" };
            Rsid rsid25 = new Rsid() { Val = "00031885" };
            Rsid rsid26 = new Rsid() { Val = "00032879" };
            Rsid rsid27 = new Rsid() { Val = "0003343E" };
            Rsid rsid28 = new Rsid() { Val = "000369C6" };
            Rsid rsid29 = new Rsid() { Val = "0005141E" };
            Rsid rsid30 = new Rsid() { Val = "00051891" };
            Rsid rsid31 = new Rsid() { Val = "0005359F" };
            Rsid rsid32 = new Rsid() { Val = "00062D1A" };
            Rsid rsid33 = new Rsid() { Val = "00063175" };
            Rsid rsid34 = new Rsid() { Val = "000658D9" };
            Rsid rsid35 = new Rsid() { Val = "00066D99" };
            Rsid rsid36 = new Rsid() { Val = "00070A9B" };
            Rsid rsid37 = new Rsid() { Val = "0007106F" };
            Rsid rsid38 = new Rsid() { Val = "0007259A" };
            Rsid rsid39 = new Rsid() { Val = "00074E58" };
            Rsid rsid40 = new Rsid() { Val = "000801E4" };
            Rsid rsid41 = new Rsid() { Val = "00084C33" };
            Rsid rsid42 = new Rsid() { Val = "000853DA" };
            Rsid rsid43 = new Rsid() { Val = "00092ACE" };
            Rsid rsid44 = new Rsid() { Val = "00093F71" };
            Rsid rsid45 = new Rsid() { Val = "0009526C" };
            Rsid rsid46 = new Rsid() { Val = "00095BA6" };
            Rsid rsid47 = new Rsid() { Val = "000A1AA8" };
            Rsid rsid48 = new Rsid() { Val = "000A7E26" };
            Rsid rsid49 = new Rsid() { Val = "000B69EC" };
            Rsid rsid50 = new Rsid() { Val = "000C2D0C" };
            Rsid rsid51 = new Rsid() { Val = "000C36CD" };
            Rsid rsid52 = new Rsid() { Val = "000C3770" };
            Rsid rsid53 = new Rsid() { Val = "000C4846" };
            Rsid rsid54 = new Rsid() { Val = "000C78DC" };
            Rsid rsid55 = new Rsid() { Val = "000D0712" };
            Rsid rsid56 = new Rsid() { Val = "000D15C1" };
            Rsid rsid57 = new Rsid() { Val = "000D32E1" };
            Rsid rsid58 = new Rsid() { Val = "000D4493" };
            Rsid rsid59 = new Rsid() { Val = "000D49E3" };
            Rsid rsid60 = new Rsid() { Val = "000D4EF0" };
            Rsid rsid61 = new Rsid() { Val = "000D6BAE" };
            Rsid rsid62 = new Rsid() { Val = "000E0439" };
            Rsid rsid63 = new Rsid() { Val = "000E25DA" };
            Rsid rsid64 = new Rsid() { Val = "000E3309" };
            Rsid rsid65 = new Rsid() { Val = "000E4131" };
            Rsid rsid66 = new Rsid() { Val = "000E4D79" };
            Rsid rsid67 = new Rsid() { Val = "000F58FF" };
            Rsid rsid68 = new Rsid() { Val = "000F72A6" };
            Rsid rsid69 = new Rsid() { Val = "00100DB0" };
            Rsid rsid70 = new Rsid() { Val = "00100F37" };
            Rsid rsid71 = new Rsid() { Val = "00101DD2" };
            Rsid rsid72 = new Rsid() { Val = "00104FB3" };
            Rsid rsid73 = new Rsid() { Val = "001061E0" };
            Rsid rsid74 = new Rsid() { Val = "00111393" };
            Rsid rsid75 = new Rsid() { Val = "00112863" };
            Rsid rsid76 = new Rsid() { Val = "001138C7" };
            Rsid rsid77 = new Rsid() { Val = "001160B1" };
            Rsid rsid78 = new Rsid() { Val = "0012139F" };
            Rsid rsid79 = new Rsid() { Val = "001253F2" };
            Rsid rsid80 = new Rsid() { Val = "001259DF" };
            Rsid rsid81 = new Rsid() { Val = "00125A40" };
            Rsid rsid82 = new Rsid() { Val = "001352A8" };
            Rsid rsid83 = new Rsid() { Val = "00143B19" };
            Rsid rsid84 = new Rsid() { Val = "00147B53" };
            Rsid rsid85 = new Rsid() { Val = "00150E79" };
            Rsid rsid86 = new Rsid() { Val = "00151B89" };
            Rsid rsid87 = new Rsid() { Val = "00157C3F" };
            Rsid rsid88 = new Rsid() { Val = "0016530A" };
            Rsid rsid89 = new Rsid() { Val = "00166DDA" };
            Rsid rsid90 = new Rsid() { Val = "001670B4" };
            Rsid rsid91 = new Rsid() { Val = "001706B7" };
            Rsid rsid92 = new Rsid() { Val = "001757CE" };
            Rsid rsid93 = new Rsid() { Val = "00176473" };
            Rsid rsid94 = new Rsid() { Val = "001765C2" };
            Rsid rsid95 = new Rsid() { Val = "00177814" };
            Rsid rsid96 = new Rsid() { Val = "0018154E" };
            Rsid rsid97 = new Rsid() { Val = "0018413F" };
            Rsid rsid98 = new Rsid() { Val = "001861CC" };
            Rsid rsid99 = new Rsid() { Val = "0019619D" };
            Rsid rsid100 = new Rsid() { Val = "00196FCC" };
            Rsid rsid101 = new Rsid() { Val = "001A2883" };
            Rsid rsid102 = new Rsid() { Val = "001B10A2" };
            Rsid rsid103 = new Rsid() { Val = "001B2DD2" };
            Rsid rsid104 = new Rsid() { Val = "001B4437" };
            Rsid rsid105 = new Rsid() { Val = "001C7A11" };
            Rsid rsid106 = new Rsid() { Val = "001D24DE" };
            Rsid rsid107 = new Rsid() { Val = "001D4268" };
            Rsid rsid108 = new Rsid() { Val = "001D50A4" };
            Rsid rsid109 = new Rsid() { Val = "001D6DE5" };
            Rsid rsid110 = new Rsid() { Val = "001E2668" };
            Rsid rsid111 = new Rsid() { Val = "001E3EED" };
            Rsid rsid112 = new Rsid() { Val = "001E4BE8" };
            Rsid rsid113 = new Rsid() { Val = "001F040D" };
            Rsid rsid114 = new Rsid() { Val = "001F0B29" };
            Rsid rsid115 = new Rsid() { Val = "001F0FC3" };
            Rsid rsid116 = new Rsid() { Val = "001F26CA" };
            Rsid rsid117 = new Rsid() { Val = "001F5164" };
            Rsid rsid118 = new Rsid() { Val = "00201933" };
            Rsid rsid119 = new Rsid() { Val = "00201E13" };
            Rsid rsid120 = new Rsid() { Val = "002020AD" };
            Rsid rsid121 = new Rsid() { Val = "00204104" };
            Rsid rsid122 = new Rsid() { Val = "002041A2" };
            Rsid rsid123 = new Rsid() { Val = "00211052" };
            Rsid rsid124 = new Rsid() { Val = "00213D11" };
            Rsid rsid125 = new Rsid() { Val = "00216D9A" };
            Rsid rsid126 = new Rsid() { Val = "00217E8A" };
            Rsid rsid127 = new Rsid() { Val = "00222133" };
            Rsid rsid128 = new Rsid() { Val = "00223C47" };
            Rsid rsid129 = new Rsid() { Val = "00227E23" };
            Rsid rsid130 = new Rsid() { Val = "0023259A" };
            Rsid rsid131 = new Rsid() { Val = "002335B2" };
            Rsid rsid132 = new Rsid() { Val = "0023513C" };
            Rsid rsid133 = new Rsid() { Val = "00237041" };
            Rsid rsid134 = new Rsid() { Val = "00240337" };
            Rsid rsid135 = new Rsid() { Val = "00240EF2" };
            Rsid rsid136 = new Rsid() { Val = "00246B2E" };
            Rsid rsid137 = new Rsid() { Val = "00246E1F" };
            Rsid rsid138 = new Rsid() { Val = "0025272B" };
            Rsid rsid139 = new Rsid() { Val = "002560F6" };
            Rsid rsid140 = new Rsid() { Val = "0025754E" };
            Rsid rsid141 = new Rsid() { Val = "00261622" };
            Rsid rsid142 = new Rsid() { Val = "00263348" };
            Rsid rsid143 = new Rsid() { Val = "00271012" };
            Rsid rsid144 = new Rsid() { Val = "00272440" };
            Rsid rsid145 = new Rsid() { Val = "0027312D" };
            Rsid rsid146 = new Rsid() { Val = "002740A4" };
            Rsid rsid147 = new Rsid() { Val = "00277B6E" };
            Rsid rsid148 = new Rsid() { Val = "00280690" };
            Rsid rsid149 = new Rsid() { Val = "0029344B" };
            Rsid rsid150 = new Rsid() { Val = "00293C99" };
            Rsid rsid151 = new Rsid() { Val = "002954AF" };
            Rsid rsid152 = new Rsid() { Val = "002A07DF" };
            Rsid rsid153 = new Rsid() { Val = "002A4208" };
            Rsid rsid154 = new Rsid() { Val = "002A4233" };
            Rsid rsid155 = new Rsid() { Val = "002A47F5" };
            Rsid rsid156 = new Rsid() { Val = "002A6FDD" };
            Rsid rsid157 = new Rsid() { Val = "002B3ED9" };
            Rsid rsid158 = new Rsid() { Val = "002B5950" };
            Rsid rsid159 = new Rsid() { Val = "002C10E9" };
            Rsid rsid160 = new Rsid() { Val = "002C1699" };
            Rsid rsid161 = new Rsid() { Val = "002C1D99" };
            Rsid rsid162 = new Rsid() { Val = "002C209E" };
            Rsid rsid163 = new Rsid() { Val = "002C2D29" };
            Rsid rsid164 = new Rsid() { Val = "002C48A4" };
            Rsid rsid165 = new Rsid() { Val = "002C53AC" };
            Rsid rsid166 = new Rsid() { Val = "002C54DE" };
            Rsid rsid167 = new Rsid() { Val = "002C5690" };
            Rsid rsid168 = new Rsid() { Val = "002D18A7" };
            Rsid rsid169 = new Rsid() { Val = "002D2ADE" };
            Rsid rsid170 = new Rsid() { Val = "002D6BF6" };
            Rsid rsid171 = new Rsid() { Val = "002E694F" };
            Rsid rsid172 = new Rsid() { Val = "002F61BE" };
            Rsid rsid173 = new Rsid() { Val = "0030046B" };
            Rsid rsid174 = new Rsid() { Val = "00302841" };
            Rsid rsid175 = new Rsid() { Val = "0031270E" };
            Rsid rsid176 = new Rsid() { Val = "0031764F" };
            Rsid rsid177 = new Rsid() { Val = "0032001D" };
            Rsid rsid178 = new Rsid() { Val = "003217BB" };
            Rsid rsid179 = new Rsid() { Val = "00324107" };
            Rsid rsid180 = new Rsid() { Val = "00324F22" };
            Rsid rsid181 = new Rsid() { Val = "0032695A" };
            Rsid rsid182 = new Rsid() { Val = "0032745B" };
            Rsid rsid183 = new Rsid() { Val = "00330443" };
            Rsid rsid184 = new Rsid() { Val = "003344B8" };
            Rsid rsid185 = new Rsid() { Val = "003353C3" };
            Rsid rsid186 = new Rsid() { Val = "00336A66" };
            Rsid rsid187 = new Rsid() { Val = "00336A85" };
            Rsid rsid188 = new Rsid() { Val = "00337A59" };
            Rsid rsid189 = new Rsid() { Val = "003409E6" };
            Rsid rsid190 = new Rsid() { Val = "00341E2B" };
            Rsid rsid191 = new Rsid() { Val = "00343AA1" };
            Rsid rsid192 = new Rsid() { Val = "0035635F" };
            Rsid rsid193 = new Rsid() { Val = "00356BCF" };
            Rsid rsid194 = new Rsid() { Val = "00360E10" };
            Rsid rsid195 = new Rsid() { Val = "00364115" };
            Rsid rsid196 = new Rsid() { Val = "003679C6" };
            Rsid rsid197 = new Rsid() { Val = "003709CA" };
            Rsid rsid198 = new Rsid() { Val = "00374BEF" };
            Rsid rsid199 = new Rsid() { Val = "003753BC" };
            Rsid rsid200 = new Rsid() { Val = "00380CCB" };
            Rsid rsid201 = new Rsid() { Val = "00381DBD" };
            Rsid rsid202 = new Rsid() { Val = "003823E9" };
            Rsid rsid203 = new Rsid() { Val = "003828D3" };
            Rsid rsid204 = new Rsid() { Val = "00387BBA" };
            Rsid rsid205 = new Rsid() { Val = "00394BF7" };
            Rsid rsid206 = new Rsid() { Val = "003A4507" };
            Rsid rsid207 = new Rsid() { Val = "003B0660" };
            Rsid rsid208 = new Rsid() { Val = "003B24EA" };
            Rsid rsid209 = new Rsid() { Val = "003C35DE" };
            Rsid rsid210 = new Rsid() { Val = "003D2A54" };
            Rsid rsid211 = new Rsid() { Val = "003D3929" };
            Rsid rsid212 = new Rsid() { Val = "003D3E55" };
            Rsid rsid213 = new Rsid() { Val = "003D63A0" };
            Rsid rsid214 = new Rsid() { Val = "003E078B" };
            Rsid rsid215 = new Rsid() { Val = "003E193E" };
            Rsid rsid216 = new Rsid() { Val = "003E35DA" };
            Rsid rsid217 = new Rsid() { Val = "003E3941" };
            Rsid rsid218 = new Rsid() { Val = "003E531E" };
            Rsid rsid219 = new Rsid() { Val = "003E69B8" };
            Rsid rsid220 = new Rsid() { Val = "003E76BC" };
            Rsid rsid221 = new Rsid() { Val = "003F054C" };
            Rsid rsid222 = new Rsid() { Val = "003F1E7A" };
            Rsid rsid223 = new Rsid() { Val = "003F422E" };
            Rsid rsid224 = new Rsid() { Val = "003F4CFC" };
            Rsid rsid225 = new Rsid() { Val = "003F605F" };
            Rsid rsid226 = new Rsid() { Val = "004027C0" };
            Rsid rsid227 = new Rsid() { Val = "00403833" };
            Rsid rsid228 = new Rsid() { Val = "00406F25" };
            Rsid rsid229 = new Rsid() { Val = "00410509" };
            Rsid rsid230 = new Rsid() { Val = "00415019" };
            Rsid rsid231 = new Rsid() { Val = "004156C0" };
            Rsid rsid232 = new Rsid() { Val = "00416615" };
            Rsid rsid233 = new Rsid() { Val = "004244F2" };
            Rsid rsid234 = new Rsid() { Val = "00424CA3" };
            Rsid rsid235 = new Rsid() { Val = "004253C2" };
            Rsid rsid236 = new Rsid() { Val = "004254E6" };
            Rsid rsid237 = new Rsid() { Val = "00427B71" };
            Rsid rsid238 = new Rsid() { Val = "00427DF9" };
            Rsid rsid239 = new Rsid() { Val = "00430254" };
            Rsid rsid240 = new Rsid() { Val = "0043361D" };
            Rsid rsid241 = new Rsid() { Val = "004423FE" };
            Rsid rsid242 = new Rsid() { Val = "004438B9" };
            Rsid rsid243 = new Rsid() { Val = "004512A4" };
            Rsid rsid244 = new Rsid() { Val = "00452D86" };
            Rsid rsid245 = new Rsid() { Val = "00470BFA" };
            Rsid rsid246 = new Rsid() { Val = "00472260" };
            Rsid rsid247 = new Rsid() { Val = "004816CC" };
            Rsid rsid248 = new Rsid() { Val = "00492075" };
            Rsid rsid249 = new Rsid() { Val = "00496900" };
            Rsid rsid250 = new Rsid() { Val = "004A45AF" };
            Rsid rsid251 = new Rsid() { Val = "004B5969" };
            Rsid rsid252 = new Rsid() { Val = "004B5A8E" };
            Rsid rsid253 = new Rsid() { Val = "004B67D5" };
            Rsid rsid254 = new Rsid() { Val = "004C0685" };
            Rsid rsid255 = new Rsid() { Val = "004C62AE" };
            Rsid rsid256 = new Rsid() { Val = "004C69F1" };
            Rsid rsid257 = new Rsid() { Val = "004D0D13" };
            Rsid rsid258 = new Rsid() { Val = "004D3464" };
            Rsid rsid259 = new Rsid() { Val = "004E69F0" };
            Rsid rsid260 = new Rsid() { Val = "004F00E2" };
            Rsid rsid261 = new Rsid() { Val = "004F58ED" };
            Rsid rsid262 = new Rsid() { Val = "004F74CB" };
            Rsid rsid263 = new Rsid() { Val = "00501B67" };
            Rsid rsid264 = new Rsid() { Val = "00502BEA" };
            Rsid rsid265 = new Rsid() { Val = "00503FC3" };
            Rsid rsid266 = new Rsid() { Val = "005166A5" };
            Rsid rsid267 = new Rsid() { Val = "00520006" };
            Rsid rsid268 = new Rsid() { Val = "005279FF" };
            Rsid rsid269 = new Rsid() { Val = "00532BBD" };
            Rsid rsid270 = new Rsid() { Val = "005360F4" };
            Rsid rsid271 = new Rsid() { Val = "005421AC" };
            Rsid rsid272 = new Rsid() { Val = "00544BF4" };
            Rsid rsid273 = new Rsid() { Val = "005456D5" };
            Rsid rsid274 = new Rsid() { Val = "005458BD" };
            Rsid rsid275 = new Rsid() { Val = "00551751" };
            Rsid rsid276 = new Rsid() { Val = "0055585B" };
            Rsid rsid277 = new Rsid() { Val = "00565F81" };
            Rsid rsid278 = new Rsid() { Val = "005700F8" };
            Rsid rsid279 = new Rsid() { Val = "00572C05" };
            Rsid rsid280 = new Rsid() { Val = "005752C7" };
            Rsid rsid281 = new Rsid() { Val = "00577A66" };
            Rsid rsid282 = new Rsid() { Val = "00584BB9" };
            Rsid rsid283 = new Rsid() { Val = "00592E89" };
            Rsid rsid284 = new Rsid() { Val = "00593700" };
            Rsid rsid285 = new Rsid() { Val = "005A45E3" };
            Rsid rsid286 = new Rsid() { Val = "005B61C9" };
            Rsid rsid287 = new Rsid() { Val = "005B6319" };
            Rsid rsid288 = new Rsid() { Val = "005C09BF" };
            Rsid rsid289 = new Rsid() { Val = "005C4ADF" };
            Rsid rsid290 = new Rsid() { Val = "005C4F3A" };
            Rsid rsid291 = new Rsid() { Val = "005C5AEB" };
            Rsid rsid292 = new Rsid() { Val = "005C7FE6" };
            Rsid rsid293 = new Rsid() { Val = "005D39BF" };
            Rsid rsid294 = new Rsid() { Val = "005D4743" };
            Rsid rsid295 = new Rsid() { Val = "005D59CA" };
            Rsid rsid296 = new Rsid() { Val = "005D5BE3" };
            Rsid rsid297 = new Rsid() { Val = "005D6C24" };
            Rsid rsid298 = new Rsid() { Val = "005D7AFB" };
            Rsid rsid299 = new Rsid() { Val = "005E11DC" };
            Rsid rsid300 = new Rsid() { Val = "005E19DA" };
            Rsid rsid301 = new Rsid() { Val = "005F1586" };
            Rsid rsid302 = new Rsid() { Val = "005F2B4C" };
            Rsid rsid303 = new Rsid() { Val = "005F7737" };
            Rsid rsid304 = new Rsid() { Val = "00605C12" };
            Rsid rsid305 = new Rsid() { Val = "006069B2" };
            Rsid rsid306 = new Rsid() { Val = "0061006C" };
            Rsid rsid307 = new Rsid() { Val = "0061052B" };
            Rsid rsid308 = new Rsid() { Val = "00610B2D" };
            Rsid rsid309 = new Rsid() { Val = "006158C0" };
            Rsid rsid310 = new Rsid() { Val = "00623569" };
            Rsid rsid311 = new Rsid() { Val = "00630792" };
            Rsid rsid312 = new Rsid() { Val = "00632930" };
            Rsid rsid313 = new Rsid() { Val = "006341A3" };
            Rsid rsid314 = new Rsid() { Val = "00636791" };
            Rsid rsid315 = new Rsid() { Val = "006447C4" };
            Rsid rsid316 = new Rsid() { Val = "00644FD8" };
            Rsid rsid317 = new Rsid() { Val = "006529C0" };
            Rsid rsid318 = new Rsid() { Val = "00655736" };
            Rsid rsid319 = new Rsid() { Val = "00655E59" };
            Rsid rsid320 = new Rsid() { Val = "00656A03" };
            Rsid rsid321 = new Rsid() { Val = "00673B95" };
            Rsid rsid322 = new Rsid() { Val = "00677127" };
            Rsid rsid323 = new Rsid() { Val = "00680242" };
            Rsid rsid324 = new Rsid() { Val = "006815B0" };
            Rsid rsid325 = new Rsid() { Val = "00682BCD" };
            Rsid rsid326 = new Rsid() { Val = "006857D8" };
            Rsid rsid327 = new Rsid() { Val = "00686BD3" };
            Rsid rsid328 = new Rsid() { Val = "006908B3" };
            Rsid rsid329 = new Rsid() { Val = "00690D35" };
            Rsid rsid330 = new Rsid() { Val = "00692F95" };
            Rsid rsid331 = new Rsid() { Val = "00693C6C" };
            Rsid rsid332 = new Rsid() { Val = "006952FB" };
            Rsid rsid333 = new Rsid() { Val = "006959FF" };
            Rsid rsid334 = new Rsid() { Val = "00696681" };
            Rsid rsid335 = new Rsid() { Val = "00696D50" };
            Rsid rsid336 = new Rsid() { Val = "006A77C9" };
            Rsid rsid337 = new Rsid() { Val = "006B3263" };
            Rsid rsid338 = new Rsid() { Val = "006B3A32" };
            Rsid rsid339 = new Rsid() { Val = "006B5ED0" };
            Rsid rsid340 = new Rsid() { Val = "006B6281" };
            Rsid rsid341 = new Rsid() { Val = "006C1369" };
            Rsid rsid342 = new Rsid() { Val = "006C526C" };
            Rsid rsid343 = new Rsid() { Val = "006C6B3F" };
            Rsid rsid344 = new Rsid() { Val = "006D0A4B" };
            Rsid rsid345 = new Rsid() { Val = "006D1423" };
            Rsid rsid346 = new Rsid() { Val = "006D3F89" };
            Rsid rsid347 = new Rsid() { Val = "006D47A7" };
            Rsid rsid348 = new Rsid() { Val = "006D635D" };
            Rsid rsid349 = new Rsid() { Val = "006D796E" };
            Rsid rsid350 = new Rsid() { Val = "006E11A4" };
            Rsid rsid351 = new Rsid() { Val = "006F07B5" };
            Rsid rsid352 = new Rsid() { Val = "006F1DFE" };
            Rsid rsid353 = new Rsid() { Val = "006F4111" };
            Rsid rsid354 = new Rsid() { Val = "006F4D25" };
            Rsid rsid355 = new Rsid() { Val = "006F5A99" };
            Rsid rsid356 = new Rsid() { Val = "006F61F0" };
            Rsid rsid357 = new Rsid() { Val = "006F6DF2" };
            Rsid rsid358 = new Rsid() { Val = "00700B61" };
            Rsid rsid359 = new Rsid() { Val = "00701FB6" };
            Rsid rsid360 = new Rsid() { Val = "00705D88" };
            Rsid rsid361 = new Rsid() { Val = "007110BB" };
            Rsid rsid362 = new Rsid() { Val = "00715DBF" };
            Rsid rsid363 = new Rsid() { Val = "00720F7C" };
            Rsid rsid364 = new Rsid() { Val = "00726462" };
            Rsid rsid365 = new Rsid() { Val = "00732FDF" };
            Rsid rsid366 = new Rsid() { Val = "00737712" };
            Rsid rsid367 = new Rsid() { Val = "00740B4D" };
            Rsid rsid368 = new Rsid() { Val = "007435C2" };
            Rsid rsid369 = new Rsid() { Val = "00747EC9" };
            Rsid rsid370 = new Rsid() { Val = "0075761A" };
            Rsid rsid371 = new Rsid() { Val = "007621C5" };
            Rsid rsid372 = new Rsid() { Val = "00766E08" };
            Rsid rsid373 = new Rsid() { Val = "00766E62" };
            Rsid rsid374 = new Rsid() { Val = "00771387" };
            Rsid rsid375 = new Rsid() { Val = "00780C22" };
            Rsid rsid376 = new Rsid() { Val = "0078197C" };
            Rsid rsid377 = new Rsid() { Val = "0078457C" };
            Rsid rsid378 = new Rsid() { Val = "007906F8" };
            Rsid rsid379 = new Rsid() { Val = "007916ED" };
            Rsid rsid380 = new Rsid() { Val = "00792CCD" };
            Rsid rsid381 = new Rsid() { Val = "007934C8" };
            Rsid rsid382 = new Rsid() { Val = "00793DB6" };
            Rsid rsid383 = new Rsid() { Val = "00797B85" };
            Rsid rsid384 = new Rsid() { Val = "007A0A73" };
            Rsid rsid385 = new Rsid() { Val = "007A3A6B" };
            Rsid rsid386 = new Rsid() { Val = "007A3EE0" };
            Rsid rsid387 = new Rsid() { Val = "007A6957" };
            Rsid rsid388 = new Rsid() { Val = "007A7587" };
            Rsid rsid389 = new Rsid() { Val = "007B3AAD" };
            Rsid rsid390 = new Rsid() { Val = "007C0D8C" };
            Rsid rsid391 = new Rsid() { Val = "007C12D6" };
            Rsid rsid392 = new Rsid() { Val = "007C32FC" };
            Rsid rsid393 = new Rsid() { Val = "007C3EB2" };
            Rsid rsid394 = new Rsid() { Val = "007C59EE" };
            Rsid rsid395 = new Rsid() { Val = "007D3015" };
            Rsid rsid396 = new Rsid() { Val = "007D3BA8" };
            Rsid rsid397 = new Rsid() { Val = "007D5234" };
            Rsid rsid398 = new Rsid() { Val = "007D7C37" };
            Rsid rsid399 = new Rsid() { Val = "007E0DB7" };
            Rsid rsid400 = new Rsid() { Val = "007F098F" };
            Rsid rsid401 = new Rsid() { Val = "007F140F" };
            Rsid rsid402 = new Rsid() { Val = "007F3261" };
            Rsid rsid403 = new Rsid() { Val = "007F3A19" };
            Rsid rsid404 = new Rsid() { Val = "007F63B7" };
            Rsid rsid405 = new Rsid() { Val = "007F689A" };
            Rsid rsid406 = new Rsid() { Val = "00800009" };
            Rsid rsid407 = new Rsid() { Val = "008014BC" };
            Rsid rsid408 = new Rsid() { Val = "00805438" };
            Rsid rsid409 = new Rsid() { Val = "00812181" };
            Rsid rsid410 = new Rsid() { Val = "00816A83" };
            Rsid rsid411 = new Rsid() { Val = "00820DDF" };
            Rsid rsid412 = new Rsid() { Val = "0082291E" };
            Rsid rsid413 = new Rsid() { Val = "008245CB" };
            Rsid rsid414 = new Rsid() { Val = "00834F56" };
            Rsid rsid415 = new Rsid() { Val = "00836A6D" };
            Rsid rsid416 = new Rsid() { Val = "00836C3E" };
            Rsid rsid417 = new Rsid() { Val = "00837ABE" };
            Rsid rsid418 = new Rsid() { Val = "00840AFD" };
            Rsid rsid419 = new Rsid() { Val = "00852432" };
            Rsid rsid420 = new Rsid() { Val = "008527E6" };
            Rsid rsid421 = new Rsid() { Val = "00853592" };
            Rsid rsid422 = new Rsid() { Val = "008578F4" };
            Rsid rsid423 = new Rsid() { Val = "00862B5A" };
            Rsid rsid424 = new Rsid() { Val = "008638CA" };
            Rsid rsid425 = new Rsid() { Val = "0086714C" };
            Rsid rsid426 = new Rsid() { Val = "0087389D" };
            Rsid rsid427 = new Rsid() { Val = "00877585" };
            Rsid rsid428 = new Rsid() { Val = "008823AB" };
            Rsid rsid429 = new Rsid() { Val = "008825E2" };
            Rsid rsid430 = new Rsid() { Val = "008855BE" };
            Rsid rsid431 = new Rsid() { Val = "00886074" };
            Rsid rsid432 = new Rsid() { Val = "00891957" };
            Rsid rsid433 = new Rsid() { Val = "008A15F7" };
            Rsid rsid434 = new Rsid() { Val = "008A252A" };
            Rsid rsid435 = new Rsid() { Val = "008A5EDC" };
            Rsid rsid436 = new Rsid() { Val = "008B376E" };
            Rsid rsid437 = new Rsid() { Val = "008B540F" };
            Rsid rsid438 = new Rsid() { Val = "008B5CC0" };
            Rsid rsid439 = new Rsid() { Val = "008B7C0B" };
            Rsid rsid440 = new Rsid() { Val = "008C1A85" };
            Rsid rsid441 = new Rsid() { Val = "008C30C2" };
            Rsid rsid442 = new Rsid() { Val = "008D4814" };
            Rsid rsid443 = new Rsid() { Val = "008D4E5C" };
            Rsid rsid444 = new Rsid() { Val = "008D5669" };
            Rsid rsid445 = new Rsid() { Val = "008D6276" };
            Rsid rsid446 = new Rsid() { Val = "008D6288" };
            Rsid rsid447 = new Rsid() { Val = "008E030F" };
            Rsid rsid448 = new Rsid() { Val = "008E5825" };
            Rsid rsid449 = new Rsid() { Val = "008E7ECF" };
            Rsid rsid450 = new Rsid() { Val = "008F0F32" };
            Rsid rsid451 = new Rsid() { Val = "008F6C4B" };
            Rsid rsid452 = new Rsid() { Val = "009053DF" };
            Rsid rsid453 = new Rsid() { Val = "0090734F" };
            Rsid rsid454 = new Rsid() { Val = "00913FF3" };
            Rsid rsid455 = new Rsid() { Val = "00915CF3" };
            Rsid rsid456 = new Rsid() { Val = "009163DB" };
            Rsid rsid457 = new Rsid() { Val = "00917832" };
            Rsid rsid458 = new Rsid() { Val = "00922C31" };
            Rsid rsid459 = new Rsid() { Val = "0092374C" };
            Rsid rsid460 = new Rsid() { Val = "00926E84" };
            Rsid rsid461 = new Rsid() { Val = "009303F9" };
            Rsid rsid462 = new Rsid() { Val = "00945BAF" };
            Rsid rsid463 = new Rsid() { Val = "00946C27" };
            Rsid rsid464 = new Rsid() { Val = "00947710" };
            Rsid rsid465 = new Rsid() { Val = "009503D1" };
            Rsid rsid466 = new Rsid() { Val = "00951583" };
            Rsid rsid467 = new Rsid() { Val = "00973838" };
            Rsid rsid468 = new Rsid() { Val = "00975C27" };
            Rsid rsid469 = new Rsid() { Val = "00976A55" };
            Rsid rsid470 = new Rsid() { Val = "00980EA8" };
            Rsid rsid471 = new Rsid() { Val = "009829E1" };
            Rsid rsid472 = new Rsid() { Val = "00983DC6" };
            Rsid rsid473 = new Rsid() { Val = "00987422" };
            Rsid rsid474 = new Rsid() { Val = "0099100D" };
            Rsid rsid475 = new Rsid() { Val = "009930C2" };
            Rsid rsid476 = new Rsid() { Val = "009935D3" };
            Rsid rsid477 = new Rsid() { Val = "009A0DB7" };
            Rsid rsid478 = new Rsid() { Val = "009A304A" };
            Rsid rsid479 = new Rsid() { Val = "009A7C6E" };
            Rsid rsid480 = new Rsid() { Val = "009B60CD" };
            Rsid rsid481 = new Rsid() { Val = "009B6FFD" };
            Rsid rsid482 = new Rsid() { Val = "009C45D1" };
            Rsid rsid483 = new Rsid() { Val = "009C7828" };
            Rsid rsid484 = new Rsid() { Val = "009C78F5" };
            Rsid rsid485 = new Rsid() { Val = "009D3BB5" };
            Rsid rsid486 = new Rsid() { Val = "009D50EA" };
            Rsid rsid487 = new Rsid() { Val = "009D7751" };
            Rsid rsid488 = new Rsid() { Val = "009E5D9F" };
            Rsid rsid489 = new Rsid() { Val = "009F164C" };
            Rsid rsid490 = new Rsid() { Val = "009F19E6" };
            Rsid rsid491 = new Rsid() { Val = "00A038FE" };
            Rsid rsid492 = new Rsid() { Val = "00A05A15" };
            Rsid rsid493 = new Rsid() { Val = "00A07003" };
            Rsid rsid494 = new Rsid() { Val = "00A13B37" };
            Rsid rsid495 = new Rsid() { Val = "00A140F8" };
            Rsid rsid496 = new Rsid() { Val = "00A154DD" };
            Rsid rsid497 = new Rsid() { Val = "00A17B84" };
            Rsid rsid498 = new Rsid() { Val = "00A2098A" };
            Rsid rsid499 = new Rsid() { Val = "00A2408C" };
            Rsid rsid500 = new Rsid() { Val = "00A26E97" };
            Rsid rsid501 = new Rsid() { Val = "00A272BE" };
            Rsid rsid502 = new Rsid() { Val = "00A30419" };
            Rsid rsid503 = new Rsid() { Val = "00A32369" };
            Rsid rsid504 = new Rsid() { Val = "00A41F1F" };
            Rsid rsid505 = new Rsid() { Val = "00A43736" };
            Rsid rsid506 = new Rsid() { Val = "00A625DD" };
            Rsid rsid507 = new Rsid() { Val = "00A62B90" };
            Rsid rsid508 = new Rsid() { Val = "00A65223" };
            Rsid rsid509 = new Rsid() { Val = "00A67DCB" };
            Rsid rsid510 = new Rsid() { Val = "00A7384E" };
            Rsid rsid511 = new Rsid() { Val = "00A763CD" };
            Rsid rsid512 = new Rsid() { Val = "00A765E6" };
            Rsid rsid513 = new Rsid() { Val = "00A76777" };
            Rsid rsid514 = new Rsid() { Val = "00A806DC" };
            Rsid rsid515 = new Rsid() { Val = "00A81B99" };
            Rsid rsid516 = new Rsid() { Val = "00A82B0F" };
            Rsid rsid517 = new Rsid() { Val = "00A83CE2" };
            Rsid rsid518 = new Rsid() { Val = "00A86566" };
            Rsid rsid519 = new Rsid() { Val = "00A903CE" };
            Rsid rsid520 = new Rsid() { Val = "00A92F57" };
            Rsid rsid521 = new Rsid() { Val = "00A939D5" };
            Rsid rsid522 = new Rsid() { Val = "00A94200" };
            Rsid rsid523 = new Rsid() { Val = "00A95D18" };
            Rsid rsid524 = new Rsid() { Val = "00AA4C98" };
            Rsid rsid525 = new Rsid() { Val = "00AA6D8D" };
            Rsid rsid526 = new Rsid() { Val = "00AB418D" };
            Rsid rsid527 = new Rsid() { Val = "00AB6F05" };
            Rsid rsid528 = new Rsid() { Val = "00AC2657" };
            Rsid rsid529 = new Rsid() { Val = "00AC2D05" };
            Rsid rsid530 = new Rsid() { Val = "00AC42DE" };
            Rsid rsid531 = new Rsid() { Val = "00AC449C" };
            Rsid rsid532 = new Rsid() { Val = "00AC73A5" };
            Rsid rsid533 = new Rsid() { Val = "00AD260F" };
            Rsid rsid534 = new Rsid() { Val = "00AD2DD7" };
            Rsid rsid535 = new Rsid() { Val = "00AE02F1" };
            Rsid rsid536 = new Rsid() { Val = "00AE0560" };
            Rsid rsid537 = new Rsid() { Val = "00AE2522" };
            Rsid rsid538 = new Rsid() { Val = "00AE2D12" };
            Rsid rsid539 = new Rsid() { Val = "00AE3B36" };
            Rsid rsid540 = new Rsid() { Val = "00AE568E" };
            Rsid rsid541 = new Rsid() { Val = "00AF0AB1" };
            Rsid rsid542 = new Rsid() { Val = "00AF2D03" };
            Rsid rsid543 = new Rsid() { Val = "00AF701D" };
            Rsid rsid544 = new Rsid() { Val = "00B00069" };
            Rsid rsid545 = new Rsid() { Val = "00B00888" };
            Rsid rsid546 = new Rsid() { Val = "00B05763" };
            Rsid rsid547 = new Rsid() { Val = "00B07D69" };
            Rsid rsid548 = new Rsid() { Val = "00B134D2" };
            Rsid rsid549 = new Rsid() { Val = "00B13A1C" };
            Rsid rsid550 = new Rsid() { Val = "00B1623F" };
            Rsid rsid551 = new Rsid() { Val = "00B17130" };
            Rsid rsid552 = new Rsid() { Val = "00B21122" };
            Rsid rsid553 = new Rsid() { Val = "00B344A1" };
            Rsid rsid554 = new Rsid() { Val = "00B41B85" };
            Rsid rsid555 = new Rsid() { Val = "00B46F20" };
            Rsid rsid556 = new Rsid() { Val = "00B50FC0" };
            Rsid rsid557 = new Rsid() { Val = "00B54238" };
            Rsid rsid558 = new Rsid() { Val = "00B5562C" };
            Rsid rsid559 = new Rsid() { Val = "00B6030D" };
            Rsid rsid560 = new Rsid() { Val = "00B60BB2" };
            Rsid rsid561 = new Rsid() { Val = "00B625C4" };
            Rsid rsid562 = new Rsid() { Val = "00B65077" };
            Rsid rsid563 = new Rsid() { Val = "00B67323" };
            Rsid rsid564 = new Rsid() { Val = "00B709D8" };
            Rsid rsid565 = new Rsid() { Val = "00B722E2" };
            Rsid rsid566 = new Rsid() { Val = "00B734B2" };
            Rsid rsid567 = new Rsid() { Val = "00B73649" };
            Rsid rsid568 = new Rsid() { Val = "00B76ADD" };
            Rsid rsid569 = new Rsid() { Val = "00B837BF" };
            Rsid rsid570 = new Rsid() { Val = "00B91C50" };
            Rsid rsid571 = new Rsid() { Val = "00BA0122" };
            Rsid rsid572 = new Rsid() { Val = "00BA0D5E" };
            Rsid rsid573 = new Rsid() { Val = "00BA0FB7" };
            Rsid rsid574 = new Rsid() { Val = "00BA1E13" };
            Rsid rsid575 = new Rsid() { Val = "00BA2AE9" };
            Rsid rsid576 = new Rsid() { Val = "00BA3008" };
            Rsid rsid577 = new Rsid() { Val = "00BA4107" };
            Rsid rsid578 = new Rsid() { Val = "00BA4D52" };
            Rsid rsid579 = new Rsid() { Val = "00BA5AA3" };
            Rsid rsid580 = new Rsid() { Val = "00BB3079" };
            Rsid rsid581 = new Rsid() { Val = "00BB6E54" };
            Rsid rsid582 = new Rsid() { Val = "00BC14CC" };
            Rsid rsid583 = new Rsid() { Val = "00BC4AB2" };
            Rsid rsid584 = new Rsid() { Val = "00BC50D7" };
            Rsid rsid585 = new Rsid() { Val = "00BD0C10" };
            Rsid rsid586 = new Rsid() { Val = "00BD2F25" };
            Rsid rsid587 = new Rsid() { Val = "00BD3FF2" };
            Rsid rsid588 = new Rsid() { Val = "00BD4376" };
            Rsid rsid589 = new Rsid() { Val = "00BE0D43" };
            Rsid rsid590 = new Rsid() { Val = "00BE1BC9" };
            Rsid rsid591 = new Rsid() { Val = "00BE5A2A" };
            Rsid rsid592 = new Rsid() { Val = "00BE720C" };
            Rsid rsid593 = new Rsid() { Val = "00BF2624" };
            Rsid rsid594 = new Rsid() { Val = "00BF61DD" };
            Rsid rsid595 = new Rsid() { Val = "00BF6DFE" };
            Rsid rsid596 = new Rsid() { Val = "00C003BD" };
            Rsid rsid597 = new Rsid() { Val = "00C00AF5" };
            Rsid rsid598 = new Rsid() { Val = "00C07ED7" };
            Rsid rsid599 = new Rsid() { Val = "00C1116E" };
            Rsid rsid600 = new Rsid() { Val = "00C218BB" };
            Rsid rsid601 = new Rsid() { Val = "00C21B19" };
            Rsid rsid602 = new Rsid() { Val = "00C2289C" };
            Rsid rsid603 = new Rsid() { Val = "00C24219" };
            Rsid rsid604 = new Rsid() { Val = "00C34F71" };
            Rsid rsid605 = new Rsid() { Val = "00C43E05" };
            Rsid rsid606 = new Rsid() { Val = "00C46FFE" };
            Rsid rsid607 = new Rsid() { Val = "00C47F9D" };
            Rsid rsid608 = new Rsid() { Val = "00C50083" };
            Rsid rsid609 = new Rsid() { Val = "00C5315E" };
            Rsid rsid610 = new Rsid() { Val = "00C53A10" };
            Rsid rsid611 = new Rsid() { Val = "00C5718E" };
            Rsid rsid612 = new Rsid() { Val = "00C574C6" };
            Rsid rsid613 = new Rsid() { Val = "00C63D84" };
            Rsid rsid614 = new Rsid() { Val = "00C65A9F" };
            Rsid rsid615 = new Rsid() { Val = "00C7052E" };
            Rsid rsid616 = new Rsid() { Val = "00C73387" };
            Rsid rsid617 = new Rsid() { Val = "00C745E7" };
            Rsid rsid618 = new Rsid() { Val = "00C81245" };
            Rsid rsid619 = new Rsid() { Val = "00C82039" };
            Rsid rsid620 = new Rsid() { Val = "00C948CA" };
            Rsid rsid621 = new Rsid() { Val = "00CA7A34" };
            Rsid rsid622 = new Rsid() { Val = "00CB159C" };
            Rsid rsid623 = new Rsid() { Val = "00CB32E9" };
            Rsid rsid624 = new Rsid() { Val = "00CB3F3A" };
            Rsid rsid625 = new Rsid() { Val = "00CB5E66" };
            Rsid rsid626 = new Rsid() { Val = "00CC4600" };
            Rsid rsid627 = new Rsid() { Val = "00CD05D3" };
            Rsid rsid628 = new Rsid() { Val = "00CD23FE" };
            Rsid rsid629 = new Rsid() { Val = "00CE1EF5" };
            Rsid rsid630 = new Rsid() { Val = "00CE23B8" };
            Rsid rsid631 = new Rsid() { Val = "00CE3433" };
            Rsid rsid632 = new Rsid() { Val = "00CF4D94" };
            Rsid rsid633 = new Rsid() { Val = "00CF5E5B" };
            Rsid rsid634 = new Rsid() { Val = "00D02ED9" };
            Rsid rsid635 = new Rsid() { Val = "00D03D18" };
            Rsid rsid636 = new Rsid() { Val = "00D172BE" };
            Rsid rsid637 = new Rsid() { Val = "00D17880" };
            Rsid rsid638 = new Rsid() { Val = "00D20AAE" };
            Rsid rsid639 = new Rsid() { Val = "00D213E3" };
            Rsid rsid640 = new Rsid() { Val = "00D2226A" };
            Rsid rsid641 = new Rsid() { Val = "00D32723" };
            Rsid rsid642 = new Rsid() { Val = "00D4101B" };
            Rsid rsid643 = new Rsid() { Val = "00D45491" };
            Rsid rsid644 = new Rsid() { Val = "00D47575" };
            Rsid rsid645 = new Rsid() { Val = "00D50700" };
            Rsid rsid646 = new Rsid() { Val = "00D51328" };
            Rsid rsid647 = new Rsid() { Val = "00D52429" };
            Rsid rsid648 = new Rsid() { Val = "00D55CAD" };
            Rsid rsid649 = new Rsid() { Val = "00D56949" };
            Rsid rsid650 = new Rsid() { Val = "00D61E7B" };
            Rsid rsid651 = new Rsid() { Val = "00D70B9F" };
            Rsid rsid652 = new Rsid() { Val = "00D82EFA" };
            Rsid rsid653 = new Rsid() { Val = "00D836AA" };
            Rsid rsid654 = new Rsid() { Val = "00D87B2D" };
            Rsid rsid655 = new Rsid() { Val = "00D87CFB" };
            Rsid rsid656 = new Rsid() { Val = "00D930C9" };
            Rsid rsid657 = new Rsid() { Val = "00D93F2F" };
            Rsid rsid658 = new Rsid() { Val = "00D94BBF" };
            Rsid rsid659 = new Rsid() { Val = "00D952C1" };
            Rsid rsid660 = new Rsid() { Val = "00D95708" };
            Rsid rsid661 = new Rsid() { Val = "00D97846" };
            Rsid rsid662 = new Rsid() { Val = "00DA0A63" };
            Rsid rsid663 = new Rsid() { Val = "00DA5B5B" };
            Rsid rsid664 = new Rsid() { Val = "00DC0ED7" };
            Rsid rsid665 = new Rsid() { Val = "00DC0FEE" };
            Rsid rsid666 = new Rsid() { Val = "00DC2269" };
            Rsid rsid667 = new Rsid() { Val = "00DC5409" };
            Rsid rsid668 = new Rsid() { Val = "00DC5D5D" };
            Rsid rsid669 = new Rsid() { Val = "00DD1847" };
            Rsid rsid670 = new Rsid() { Val = "00DD56E3" };
            Rsid rsid671 = new Rsid() { Val = "00DE0079" };
            Rsid rsid672 = new Rsid() { Val = "00DE6B10" };
            Rsid rsid673 = new Rsid() { Val = "00DE77E4" };
            Rsid rsid674 = new Rsid() { Val = "00DF0137" };
            Rsid rsid675 = new Rsid() { Val = "00E047C9" };
            Rsid rsid676 = new Rsid() { Val = "00E051D4" };
            Rsid rsid677 = new Rsid() { Val = "00E05B38" };
            Rsid rsid678 = new Rsid() { Val = "00E07688" };
            Rsid rsid679 = new Rsid() { Val = "00E12228" };
            Rsid rsid680 = new Rsid() { Val = "00E167D7" };
            Rsid rsid681 = new Rsid() { Val = "00E215F5" };
            Rsid rsid682 = new Rsid() { Val = "00E21EA2" };
            Rsid rsid683 = new Rsid() { Val = "00E23013" };
            Rsid rsid684 = new Rsid() { Val = "00E24322" };
            Rsid rsid685 = new Rsid() { Val = "00E255F4" };
            Rsid rsid686 = new Rsid() { Val = "00E25621" };
            Rsid rsid687 = new Rsid() { Val = "00E30A93" };
            Rsid rsid688 = new Rsid() { Val = "00E30D4A" };
            Rsid rsid689 = new Rsid() { Val = "00E3282C" };
            Rsid rsid690 = new Rsid() { Val = "00E336F3" };
            Rsid rsid691 = new Rsid() { Val = "00E36172" };
            Rsid rsid692 = new Rsid() { Val = "00E44838" };
            Rsid rsid693 = new Rsid() { Val = "00E456A8" };
            Rsid rsid694 = new Rsid() { Val = "00E46BF6" };
            Rsid rsid695 = new Rsid() { Val = "00E56CF0" };
            Rsid rsid696 = new Rsid() { Val = "00E65CDB" };
            Rsid rsid697 = new Rsid() { Val = "00E712AD" };
            Rsid rsid698 = new Rsid() { Val = "00E73F17" };
            Rsid rsid699 = new Rsid() { Val = "00E75091" };
            Rsid rsid700 = new Rsid() { Val = "00E752C2" };
            Rsid rsid701 = new Rsid() { Val = "00E76D65" };
            Rsid rsid702 = new Rsid() { Val = "00E77B33" };
            Rsid rsid703 = new Rsid() { Val = "00E81903" };
            Rsid rsid704 = new Rsid() { Val = "00E84C47" };
            Rsid rsid705 = new Rsid() { Val = "00E863DC" };
            Rsid rsid706 = new Rsid() { Val = "00E9495F" };
            Rsid rsid707 = new Rsid() { Val = "00E95242" };
            Rsid rsid708 = new Rsid() { Val = "00E97E68" };
            Rsid rsid709 = new Rsid() { Val = "00EA2DA4" };
            Rsid rsid710 = new Rsid() { Val = "00EA33FB" };
            Rsid rsid711 = new Rsid() { Val = "00EA594E" };
            Rsid rsid712 = new Rsid() { Val = "00EA7443" };
            Rsid rsid713 = new Rsid() { Val = "00EB27F5" };
            Rsid rsid714 = new Rsid() { Val = "00EC4B6C" };
            Rsid rsid715 = new Rsid() { Val = "00EC7250" };
            Rsid rsid716 = new Rsid() { Val = "00EC7B2C" };
            Rsid rsid717 = new Rsid() { Val = "00ED3A7C" };
            Rsid rsid718 = new Rsid() { Val = "00ED4E1F" };
            Rsid rsid719 = new Rsid() { Val = "00ED60F4" };
            Rsid rsid720 = new Rsid() { Val = "00EF3502" };
            Rsid rsid721 = new Rsid() { Val = "00EF5285" };
            Rsid rsid722 = new Rsid() { Val = "00EF68EF" };
            Rsid rsid723 = new Rsid() { Val = "00EF6E2E" };
            Rsid rsid724 = new Rsid() { Val = "00F005E2" };
            Rsid rsid725 = new Rsid() { Val = "00F023C0" };
            Rsid rsid726 = new Rsid() { Val = "00F062DA" };
            Rsid rsid727 = new Rsid() { Val = "00F1161F" };
            Rsid rsid728 = new Rsid() { Val = "00F125C9" };
            Rsid rsid729 = new Rsid() { Val = "00F12866" };
            Rsid rsid730 = new Rsid() { Val = "00F12C33" };
            Rsid rsid731 = new Rsid() { Val = "00F16C70" };
            Rsid rsid732 = new Rsid() { Val = "00F1752B" };
            Rsid rsid733 = new Rsid() { Val = "00F177DB" };
            Rsid rsid734 = new Rsid() { Val = "00F17A99" };
            Rsid rsid735 = new Rsid() { Val = "00F21375" };
            Rsid rsid736 = new Rsid() { Val = "00F2304C" };
            Rsid rsid737 = new Rsid() { Val = "00F24082" };
            Rsid rsid738 = new Rsid() { Val = "00F251BB" };
            Rsid rsid739 = new Rsid() { Val = "00F27432" };
            Rsid rsid740 = new Rsid() { Val = "00F35C42" };
            Rsid rsid741 = new Rsid() { Val = "00F40F72" };
            Rsid rsid742 = new Rsid() { Val = "00F43579" };
            Rsid rsid743 = new Rsid() { Val = "00F45F2A" };
            Rsid rsid744 = new Rsid() { Val = "00F468EC" };
            Rsid rsid745 = new Rsid() { Val = "00F52ED7" };
            Rsid rsid746 = new Rsid() { Val = "00F53CAB" };
            Rsid rsid747 = new Rsid() { Val = "00F63B24" };
            Rsid rsid748 = new Rsid() { Val = "00F66BBA" };
            Rsid rsid749 = new Rsid() { Val = "00F679FC" };
            Rsid rsid750 = new Rsid() { Val = "00F71535" };
            Rsid rsid751 = new Rsid() { Val = "00F72448" };
            Rsid rsid752 = new Rsid() { Val = "00F7632A" };
            Rsid rsid753 = new Rsid() { Val = "00F7768B" };
            Rsid rsid754 = new Rsid() { Val = "00F815AE" };
            Rsid rsid755 = new Rsid() { Val = "00F81A50" };
            Rsid rsid756 = new Rsid() { Val = "00F83F13" };
            Rsid rsid757 = new Rsid() { Val = "00F850CA" };
            Rsid rsid758 = new Rsid() { Val = "00F8530D" };
            Rsid rsid759 = new Rsid() { Val = "00F91623" };
            Rsid rsid760 = new Rsid() { Val = "00F92B85" };
            Rsid rsid761 = new Rsid() { Val = "00F9301C" };
            Rsid rsid762 = new Rsid() { Val = "00F960F0" };
            Rsid rsid763 = new Rsid() { Val = "00FA1B16" };
            Rsid rsid764 = new Rsid() { Val = "00FA2CDA" };
            Rsid rsid765 = new Rsid() { Val = "00FA2DF1" };
            Rsid rsid766 = new Rsid() { Val = "00FA3130" };
            Rsid rsid767 = new Rsid() { Val = "00FA746C" };
            Rsid rsid768 = new Rsid() { Val = "00FB7AB4" };
            Rsid rsid769 = new Rsid() { Val = "00FC0E63" };
            Rsid rsid770 = new Rsid() { Val = "00FC3B8F" };
            Rsid rsid771 = new Rsid() { Val = "00FC4CC1" };
            Rsid rsid772 = new Rsid() { Val = "00FC5B8B" };
            Rsid rsid773 = new Rsid() { Val = "00FD0595" };
            Rsid rsid774 = new Rsid() { Val = "00FD1229" };
            Rsid rsid775 = new Rsid() { Val = "00FD41F6" };
            Rsid rsid776 = new Rsid() { Val = "00FD452B" };
            Rsid rsid777 = new Rsid() { Val = "00FD7AA4" };
            Rsid rsid778 = new Rsid() { Val = "00FE29D8" };
            Rsid rsid779 = new Rsid() { Val = "00FE2BBC" };
            Rsid rsid780 = new Rsid() { Val = "00FE4911" };
            Rsid rsid781 = new Rsid() { Val = "00FF22C9" };

            rsids1.Append(rsidRoot1);
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
            rsids1.Append(rsid567);
            rsids1.Append(rsid568);
            rsids1.Append(rsid569);
            rsids1.Append(rsid570);
            rsids1.Append(rsid571);
            rsids1.Append(rsid572);
            rsids1.Append(rsid573);
            rsids1.Append(rsid574);
            rsids1.Append(rsid575);
            rsids1.Append(rsid576);
            rsids1.Append(rsid577);
            rsids1.Append(rsid578);
            rsids1.Append(rsid579);
            rsids1.Append(rsid580);
            rsids1.Append(rsid581);
            rsids1.Append(rsid582);
            rsids1.Append(rsid583);
            rsids1.Append(rsid584);
            rsids1.Append(rsid585);
            rsids1.Append(rsid586);
            rsids1.Append(rsid587);
            rsids1.Append(rsid588);
            rsids1.Append(rsid589);
            rsids1.Append(rsid590);
            rsids1.Append(rsid591);
            rsids1.Append(rsid592);
            rsids1.Append(rsid593);
            rsids1.Append(rsid594);
            rsids1.Append(rsid595);
            rsids1.Append(rsid596);
            rsids1.Append(rsid597);
            rsids1.Append(rsid598);
            rsids1.Append(rsid599);
            rsids1.Append(rsid600);
            rsids1.Append(rsid601);
            rsids1.Append(rsid602);
            rsids1.Append(rsid603);
            rsids1.Append(rsid604);
            rsids1.Append(rsid605);
            rsids1.Append(rsid606);
            rsids1.Append(rsid607);
            rsids1.Append(rsid608);
            rsids1.Append(rsid609);
            rsids1.Append(rsid610);
            rsids1.Append(rsid611);
            rsids1.Append(rsid612);
            rsids1.Append(rsid613);
            rsids1.Append(rsid614);
            rsids1.Append(rsid615);
            rsids1.Append(rsid616);
            rsids1.Append(rsid617);
            rsids1.Append(rsid618);
            rsids1.Append(rsid619);
            rsids1.Append(rsid620);
            rsids1.Append(rsid621);
            rsids1.Append(rsid622);
            rsids1.Append(rsid623);
            rsids1.Append(rsid624);
            rsids1.Append(rsid625);
            rsids1.Append(rsid626);
            rsids1.Append(rsid627);
            rsids1.Append(rsid628);
            rsids1.Append(rsid629);
            rsids1.Append(rsid630);
            rsids1.Append(rsid631);
            rsids1.Append(rsid632);
            rsids1.Append(rsid633);
            rsids1.Append(rsid634);
            rsids1.Append(rsid635);
            rsids1.Append(rsid636);
            rsids1.Append(rsid637);
            rsids1.Append(rsid638);
            rsids1.Append(rsid639);
            rsids1.Append(rsid640);
            rsids1.Append(rsid641);
            rsids1.Append(rsid642);
            rsids1.Append(rsid643);
            rsids1.Append(rsid644);
            rsids1.Append(rsid645);
            rsids1.Append(rsid646);
            rsids1.Append(rsid647);
            rsids1.Append(rsid648);
            rsids1.Append(rsid649);
            rsids1.Append(rsid650);
            rsids1.Append(rsid651);
            rsids1.Append(rsid652);
            rsids1.Append(rsid653);
            rsids1.Append(rsid654);
            rsids1.Append(rsid655);
            rsids1.Append(rsid656);
            rsids1.Append(rsid657);
            rsids1.Append(rsid658);
            rsids1.Append(rsid659);
            rsids1.Append(rsid660);
            rsids1.Append(rsid661);
            rsids1.Append(rsid662);
            rsids1.Append(rsid663);
            rsids1.Append(rsid664);
            rsids1.Append(rsid665);
            rsids1.Append(rsid666);
            rsids1.Append(rsid667);
            rsids1.Append(rsid668);
            rsids1.Append(rsid669);
            rsids1.Append(rsid670);
            rsids1.Append(rsid671);
            rsids1.Append(rsid672);
            rsids1.Append(rsid673);
            rsids1.Append(rsid674);
            rsids1.Append(rsid675);
            rsids1.Append(rsid676);
            rsids1.Append(rsid677);
            rsids1.Append(rsid678);
            rsids1.Append(rsid679);
            rsids1.Append(rsid680);
            rsids1.Append(rsid681);
            rsids1.Append(rsid682);
            rsids1.Append(rsid683);
            rsids1.Append(rsid684);
            rsids1.Append(rsid685);
            rsids1.Append(rsid686);
            rsids1.Append(rsid687);
            rsids1.Append(rsid688);
            rsids1.Append(rsid689);
            rsids1.Append(rsid690);
            rsids1.Append(rsid691);
            rsids1.Append(rsid692);
            rsids1.Append(rsid693);
            rsids1.Append(rsid694);
            rsids1.Append(rsid695);
            rsids1.Append(rsid696);
            rsids1.Append(rsid697);
            rsids1.Append(rsid698);
            rsids1.Append(rsid699);
            rsids1.Append(rsid700);
            rsids1.Append(rsid701);
            rsids1.Append(rsid702);
            rsids1.Append(rsid703);
            rsids1.Append(rsid704);
            rsids1.Append(rsid705);
            rsids1.Append(rsid706);
            rsids1.Append(rsid707);
            rsids1.Append(rsid708);
            rsids1.Append(rsid709);
            rsids1.Append(rsid710);
            rsids1.Append(rsid711);
            rsids1.Append(rsid712);
            rsids1.Append(rsid713);
            rsids1.Append(rsid714);
            rsids1.Append(rsid715);
            rsids1.Append(rsid716);
            rsids1.Append(rsid717);
            rsids1.Append(rsid718);
            rsids1.Append(rsid719);
            rsids1.Append(rsid720);
            rsids1.Append(rsid721);
            rsids1.Append(rsid722);
            rsids1.Append(rsid723);
            rsids1.Append(rsid724);
            rsids1.Append(rsid725);
            rsids1.Append(rsid726);
            rsids1.Append(rsid727);
            rsids1.Append(rsid728);
            rsids1.Append(rsid729);
            rsids1.Append(rsid730);
            rsids1.Append(rsid731);
            rsids1.Append(rsid732);
            rsids1.Append(rsid733);
            rsids1.Append(rsid734);
            rsids1.Append(rsid735);
            rsids1.Append(rsid736);
            rsids1.Append(rsid737);
            rsids1.Append(rsid738);
            rsids1.Append(rsid739);
            rsids1.Append(rsid740);
            rsids1.Append(rsid741);
            rsids1.Append(rsid742);
            rsids1.Append(rsid743);
            rsids1.Append(rsid744);
            rsids1.Append(rsid745);
            rsids1.Append(rsid746);
            rsids1.Append(rsid747);
            rsids1.Append(rsid748);
            rsids1.Append(rsid749);
            rsids1.Append(rsid750);
            rsids1.Append(rsid751);
            rsids1.Append(rsid752);
            rsids1.Append(rsid753);
            rsids1.Append(rsid754);
            rsids1.Append(rsid755);
            rsids1.Append(rsid756);
            rsids1.Append(rsid757);
            rsids1.Append(rsid758);
            rsids1.Append(rsid759);
            rsids1.Append(rsid760);
            rsids1.Append(rsid761);
            rsids1.Append(rsid762);
            rsids1.Append(rsid763);
            rsids1.Append(rsid764);
            rsids1.Append(rsid765);
            rsids1.Append(rsid766);
            rsids1.Append(rsid767);
            rsids1.Append(rsid768);
            rsids1.Append(rsid769);
            rsids1.Append(rsid770);
            rsids1.Append(rsid771);
            rsids1.Append(rsid772);
            rsids1.Append(rsid773);
            rsids1.Append(rsid774);
            rsids1.Append(rsid775);
            rsids1.Append(rsid776);
            rsids1.Append(rsid777);
            rsids1.Append(rsid778);
            rsids1.Append(rsid779);
            rsids1.Append(rsid780);
            rsids1.Append(rsid781);

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

            OpenXmlUnknownElement openXmlUnknownElement3 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<w:smartTagType w:namespaceuri=\"urn:schemas-microsoft-com:office:smarttags\" w:name=\"metricconverter\" xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\" />");

            ShapeDefaults shapeDefaults1 = new ShapeDefaults();
            Ovml.ShapeDefaults shapeDefaults2 = new Ovml.ShapeDefaults() { Extension = V.ExtensionHandlingBehaviorValues.Edit, MaxShapeId = 1026 };

            Ovml.ShapeLayout shapeLayout1 = new Ovml.ShapeLayout() { Extension = V.ExtensionHandlingBehaviorValues.Edit };
            Ovml.ShapeIdMap shapeIdMap1 = new Ovml.ShapeIdMap() { Extension = V.ExtensionHandlingBehaviorValues.Edit, Data = "1" };

            shapeLayout1.Append(shapeIdMap1);

            shapeDefaults1.Append(shapeDefaults2);
            shapeDefaults1.Append(shapeLayout1);
            DecimalSymbol decimalSymbol1 = new DecimalSymbol() { Val = "," };
            ListSeparator listSeparator1 = new ListSeparator() { Val = ";" };

            settings1.Append(zoom1);
            settings1.Append(proofState1);
            settings1.Append(stylePaneFormatFilter1);
            settings1.Append(defaultTabStop1);
            settings1.Append(hyphenationZone1);
            settings1.Append(noPunctuationKerning1);
            settings1.Append(characterSpacingControl1);
            settings1.Append(compatibility1);
            settings1.Append(rsids1);
            settings1.Append(mathProperties1);
            settings1.Append(themeFontLanguages1);
            settings1.Append(colorSchemeMapping1);
            settings1.Append(doNotIncludeSubdocsInStats1);
            settings1.Append(openXmlUnknownElement3);
            settings1.Append(shapeDefaults1);
            settings1.Append(decimalSymbol1);
            settings1.Append(listSeparator1);

            documentSettingsPart1.Settings = settings1;
        }

        private void SetPackageProperties(OpenXmlPackage document)
        {
            document.PackageProperties.Creator = "Customer";
            document.PackageProperties.Title = "___________2006 г В______________________________________";
            document.PackageProperties.Revision = "9";
            document.PackageProperties.Created = System.Xml.XmlConvert.ToDateTime("2015-09-13T12:12:00Z", System.Xml.XmlDateTimeSerializationMode.RoundtripKind);
            document.PackageProperties.Modified = System.Xml.XmlConvert.ToDateTime("2015-09-13T12:32:00Z", System.Xml.XmlDateTimeSerializationMode.RoundtripKind);
            document.PackageProperties.LastModifiedBy = "Alex";
            document.PackageProperties.LastPrinted = System.Xml.XmlConvert.ToDateTime("2015-08-20T12:21:00Z", System.Xml.XmlDateTimeSerializationMode.RoundtripKind);
        }


    }
}

