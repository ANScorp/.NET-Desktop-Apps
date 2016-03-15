using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logistic
{
    public class Export
    {
        private SqlConnection connection;
        private string connectionString = ConfigurationManager.ConnectionStrings["logistic.Properties.Settings.dbalextestConnectionString"].ConnectionString;

        private string thisContractNumber;
        private DateTime thisContractDate;

        private class SupplementItem
        {
            public string SupplementNumber { get; set; }
            public DateTime SupplementDate { get; set; }
            public int OfferNumber { get; set; }
        }

        private class InvoiceItem
        {
            public int InvoiceID { get; set; }
            public string InvoiceNumber { get; set; }
            public DateTime InvoiceDate { get; set; }
        }

        private class ProductItem
        {
            public string ProductName { get; set; }
            public Int64 ProductCode { get; set; }
            public int Quantity { get; set; }
            public decimal ProductPrice { get; set; }
            public decimal Sum { get; set; }
            public decimal ImportedMaterials { get; set; }

        }

        private class PackingListItem
        {
            public int ItemOfferNumber { get; set; }
            public string ItemName { get; set; }
            public string PackageType { get; set; }
            public int Quantity { get; set; }
            public int PackingWeight { get; set; }
            public int NetPerItem { get; set; }
            public int Net { get; set; }
            public int Gross { get; set; }
            public string PalletNumber { get; set; }
            public int SeatsNumber { get; set; }
        }

        public void CreateDeclarationDocument(int insertedDeclarationID, string destinationFolder)
        {
            string prodRefNumber;
            DateTime prodRefDate;
            string productList;
            string currency;
            string authPerson;

            string packingListNumber;
            DateTime packingListDate;

            int productAmount;
            int totalGross;
            int totalNet;
            int totalSeatsNumber;

            List<SupplementItem> SupplementItems;
            List<InvoiceItem> InvoiceItems;
            List<ProductItem> ProductItems;
            try
            {
                string queryProductAmount = "SELECT SUM(a.Quantity) FROM Specifications a " +
                    "INNER JOIN Invoices b ON a.InvoiceID = b.InvoiceID " +
                    "WHERE b.DeclarationID = @DeclarationID";

                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(queryProductAmount, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    connection.Open();

                    command.Parameters.AddWithValue("@DeclarationID", insertedDeclarationID);

                    productAmount = Convert.ToInt32(command.ExecuteScalar());

                }

                string queryPackingListDeclaration = "SELECT SUM(Gross) as TotalGross, SUM(Net) as TotalNet, SUM(SeatsNumber) as TotalSeatsNumber FROM PackingListSpecification a " +
                    "INNER JOIN Invoices b ON a.InvoiceID = b.InvoiceID " +
                    "WHERE b.DeclarationID = @DeclarationID";

                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(queryPackingListDeclaration, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {

                    command.Parameters.AddWithValue("@DeclarationID", insertedDeclarationID);

                    DataTable productsAmountTable = new DataTable();
                    adapter.Fill(productsAmountTable);

                    //if (productsAmountTable.Rows.Count == 1)
                    //{
                    totalGross = productsAmountTable.Rows[0].Field<int>("TotalGross");
                    totalNet = productsAmountTable.Rows[0].Field<int>("TotalNet");
                    totalSeatsNumber = productsAmountTable.Rows[0].Field<int>("TotalSeatsNumber");
                    //}
                }

                string queryContract = "SELECT a.ContractNumber, a.ContractDate, a.ProdRef, a.ProdRefDate, a.ProductList, a.Currency, a.AuthPerson, b.PackingListNumber, b.PackingListDate FROM Declaration a " +
                   "INNER JOIN PackingList b ON a.DeclarationID = b.DeclarationID " +
                    "WHERE a.DeclarationID = @DeclarationID";

                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(queryContract, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {

                    command.Parameters.AddWithValue("@DeclarationID", insertedDeclarationID);

                    DataTable contractTable = new DataTable();
                    adapter.Fill(contractTable);

                    //if (contractTable.Rows.Count == 1)
                    //{
                    this.thisContractNumber = contractTable.Rows[0].Field<string>("ContractNumber");
                    this.thisContractDate = contractTable.Rows[0].Field<DateTime>("ContractDate");
                    prodRefNumber = contractTable.Rows[0].Field<string>("ProdRef");
                    prodRefDate = contractTable.Rows[0].Field<DateTime>("ProdRefDate");
                    productList = contractTable.Rows[0].Field<string>("ProductList");
                    currency = contractTable.Rows[0].Field<string>("Currency");
                    authPerson = contractTable.Rows[0].Field<string>("AuthPerson");

                    packingListNumber = contractTable.Rows[0].Field<string>("PackingListNumber");
                    packingListDate = contractTable.Rows[0].Field<DateTime>("PackingListDate");

                    //}
                }

                string queryInvoices = "SELECT a.InvoiceNumber, a.InvoiceDate FROM Invoices a " +
                   "WHERE a.DeclarationID = @DeclarationID";

                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(queryInvoices, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {

                    command.Parameters.AddWithValue("@DeclarationID", insertedDeclarationID);

                    DataTable invoicesTable = new DataTable();
                    adapter.Fill(invoicesTable);

                    InvoiceItems = invoicesTable.AsEnumerable()
                        .Select(row => new InvoiceItem
                        {
                            InvoiceNumber = row.Field<string>("InvoiceNumber"),
                            InvoiceDate = row.Field<DateTime>("InvoiceDate")
                        }).ToList();

                }

                string querySupplements = "SELECT a.SupplementNumber, a.SupplementDate FROM Supplements a " +
                   "WHERE a.DeclarationID = @DeclarationID";

                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(querySupplements, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {

                    command.Parameters.AddWithValue("@DeclarationID", insertedDeclarationID);

                    DataTable supplementsTable = new DataTable();
                    adapter.Fill(supplementsTable);

                    SupplementItems = supplementsTable.AsEnumerable()
                        .Select(row => new SupplementItem
                        {
                            SupplementNumber = row.Field<string>("SupplementNumber"),
                            SupplementDate = row.Field<DateTime>("SupplementDate")
                        }).ToList();

                }

                string queryProducts = "SELECT a.ProductName, a.ProductCode, a.Quantity, a.ProductPrice, a.Sum, a.ImportedMaterials FROM Specifications a " +
                    "INNER JOIN Invoices b ON a.InvoiceID = b.InvoiceID " +
                    "WHERE b.DeclarationID = @DeclarationID";

                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(queryProducts, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {

                    command.Parameters.AddWithValue("@DeclarationID", insertedDeclarationID);

                    DataTable productsTable = new DataTable();
                    adapter.Fill(productsTable);

                    ProductItems = productsTable.AsEnumerable()
                        .Select(row => new ProductItem
                        {
                            ProductName = row.Field<string>("ProductName"),
                            ProductCode = row.Field<Int64>("ProductCode"),
                            Quantity = row.Field<int>("Quantity"),
                            ProductPrice = row.Field<decimal>("ProductPrice"),
                            Sum = row.Field<decimal>("Sum"),
                            ImportedMaterials = row.Field<decimal>("ImportedMaterials")
                        }).ToList();

                }

                //ParseTemplate
                using (var templateFile = File.Open(@"templates\Заява_ТПП_tmpl.docx", FileMode.Open, FileAccess.Read))
                {
                    using (var stream = new MemoryStream())
                    {
                        templateFile.CopyTo(stream);

                        using (var wordDoc = WordprocessingDocument.Open(stream, true))
                        {
                            //Get all content controls
                            List<SdtElement> sdtList = wordDoc.MainDocumentPart.Document.Descendants<SdtElement>().ToList();

                            //SdtBlock sdtA = null;

                            foreach (SdtElement sdt in sdtList)
                            {

                                switch (sdt.SdtProperties.GetFirstChild<Tag>().Val.Value)
                                {
                                    case "DeclarationYear":
                                        sdt.Descendants<Text>().FirstOrDefault().Text = DateTime.Now.Year.ToString();
                                        break;

                                    case "ProductsTable":
                                        Table theTable = sdt.Descendants<Table>().Single();

                                        TableRow theRow = theTable.Elements<TableRow>().Last();

                                        foreach (var item in ProductItems)
                                        {
                                            TableRow rowCopy = (TableRow)theRow.CloneNode(true);
                                            rowCopy.Descendants<TableCell>().ElementAt(0).Descendants<Text>().FirstOrDefault().Text = item.ProductName.ToString();
                                            rowCopy.Descendants<TableCell>().ElementAt(1).Descendants<Text>().FirstOrDefault().Text = item.ProductCode.ToString();
                                            rowCopy.Descendants<TableCell>().ElementAt(2).Descendants<Text>().FirstOrDefault().Text = "менее " + Math.Ceiling(item.ImportedMaterials).ToString() + "%";
                                            //rowCopy.Descendants<TableCell>().ElementAt(2).Append(new Paragraph
                                            //    (new Run(new Text("менее " + Math.Ceiling(item.ImportedMaterials).ToString() + "%"))));
                                            theTable.AppendChild(rowCopy);

                                        }

                                        theTable.RemoveChild(theRow);
                                        break;

                                    case "Amount":
                                        sdt.Descendants<Text>().FirstOrDefault().Text = productAmount.ToString();
                                        break;

                                    case "Gross":
                                        sdt.Descendants<Text>().FirstOrDefault().Text = totalGross.ToString();
                                        break;

                                    case "Net":
                                        sdt.Descendants<Text>().FirstOrDefault().Text = totalNet.ToString();
                                        break;

                                    case "Seats":
                                        sdt.Descendants<Text>().FirstOrDefault().Text = totalSeatsNumber.ToString();
                                        break;

                                    case "ContractNumber":
                                        sdt.Descendants<Text>().FirstOrDefault().Text = thisContractNumber.ToString();
                                        break;

                                    case "ContractDate":
                                        sdt.Descendants<Text>().FirstOrDefault().Text = thisContractDate.ToShortDateString();
                                        break;

                                    case "Supplements":
                                        sdt.Descendants<Text>().FirstOrDefault().Text = "";

                                        foreach (var item in SupplementItems)
                                        {
                                            sdt.Descendants<Text>().FirstOrDefault().Text += "№ " + item.SupplementNumber.ToString() + " от " + item.SupplementDate.ToShortDateString() + " г., ";
                                        }

                                        sdt.Descendants<Text>().FirstOrDefault().Text = sdt.Descendants<Text>().FirstOrDefault().Text.Remove(sdt.Descendants<Text>().FirstOrDefault().Text.Length - 2);
                                        break;

                                    case "Invoices":
                                        sdt.Descendants<Text>().FirstOrDefault().Text = "";

                                        foreach (var item in InvoiceItems)
                                        {
                                            sdt.Descendants<Text>().FirstOrDefault().Text += "№ " + item.InvoiceNumber.ToString() + " от " + item.InvoiceDate.ToShortDateString() + " г., ";
                                        }

                                        sdt.Descendants<Text>().FirstOrDefault().Text = sdt.Descendants<Text>().FirstOrDefault().Text.Remove(sdt.Descendants<Text>().FirstOrDefault().Text.Length - 2);
                                        break;

                                    case "PackingList":
                                        sdt.Descendants<Text>().FirstOrDefault().Text = "№ " + packingListNumber + " от " + packingListDate.ToShortDateString() + " г.";
                                        break;

                                    case "ProdRef":
                                        sdt.Descendants<Text>().FirstOrDefault().Text = "№ " + prodRefNumber.ToString() + " от " + prodRefDate.ToShortDateString() + " г.";
                                        break;

                                    case "ProductList":
                                        sdt.Descendants<Text>().FirstOrDefault().Text = productList;
                                        break;

                                    case "AuthPerson":
                                        sdt.Descendants<Text>().FirstOrDefault().Text = authPerson;
                                        break;
                                }

                                //OpenXmlElement contentBlock = sdtA.GetFirstChild<SdtContentBlock>();
                                //OpenXmlElement parent = sdtA.Parent;
                                //OpenXmlElementList elements = contentBlock.ChildElements;
                                //var contentBlockcontent = new SdtContentBlock(contentBlock.OuterXml);
                                //foreach (OpenXmlElement elem in elements)
                                //{

                                //    string text = parent.FirstChild.InnerText;
                                //    parent.Append((OpenXmlElement)elem.Clone());
                                //}

                                //sdtA.Remove();

                                wordDoc.MainDocumentPart.Document.Save();
                            }


                        }

                        stream.Seek(0, SeekOrigin.Begin);

                        var outPath = destinationFolder + @"\Заява_ТПП_" + Regex.Replace(thisContractNumber, @"/", "_") + "_" + DateTime.Now.ToString("dd-MM-yyyy-H-mm-ss") + ".docx";

                        using (var fileStream = File.Create(outPath))
                        {
                            stream.CopyTo(fileStream);
                        }

                    }

                }
            }
            catch (Exception ex)
            {
                Log(ex);
                MessageBox.Show("Недостаточно данных для формирования Заявки-декларации. Проверте введенную информацию.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, (MessageBoxOptions)0x40000);
                return;
            }
        }

        public void CreateProdRefDocument(int insertedDeclarationID, string destinationFolder)
        {
            string prodRefNumber;
            DateTime prodRefDate;
            string authPerson;
            
            List<InvoiceItem> InvoiceItems;
            List<SupplementItem> SupplementItems;
            List<ProductItem> ProductItems;

            try
            {
                string queryContract = "SELECT a.ContractNumber, a.ContractDate, a.ProdRef, a.ProdRefDate, a.AuthPerson FROM Declaration a " +
                   "WHERE a.DeclarationID = @DeclarationID";

                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(queryContract, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {

                    command.Parameters.AddWithValue("@DeclarationID", insertedDeclarationID);

                    DataTable contractTable = new DataTable();
                    adapter.Fill(contractTable);

                    this.thisContractNumber = contractTable.Rows[0].Field<string>("ContractNumber");
                    this.thisContractDate = contractTable.Rows[0].Field<DateTime>("ContractDate");
                    prodRefNumber = contractTable.Rows[0].Field<string>("ProdRef");
                    prodRefDate = contractTable.Rows[0].Field<DateTime>("ProdRefDate");
                    authPerson = contractTable.Rows[0].Field<string>("AuthPerson");

                }

                string queryInvoices = "SELECT a.InvoiceNumber, a.InvoiceDate FROM Invoices a " +
                   "WHERE a.DeclarationID = @DeclarationID";

                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(queryInvoices, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {

                    command.Parameters.AddWithValue("@DeclarationID", insertedDeclarationID);

                    DataTable invoicesTable = new DataTable();
                    adapter.Fill(invoicesTable);

                    InvoiceItems = invoicesTable.AsEnumerable()
                        .Select(row => new InvoiceItem
                        {
                            InvoiceNumber = row.Field<string>("InvoiceNumber"),
                            InvoiceDate = row.Field<DateTime>("InvoiceDate")
                        }).ToList();

                }

                string querySupplements = "SELECT a.SupplementNumber, a.SupplementDate FROM Supplements a " +
                   "WHERE a.DeclarationID = @DeclarationID";

                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(querySupplements, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {

                    command.Parameters.AddWithValue("@DeclarationID", insertedDeclarationID);

                    DataTable supplementsTable = new DataTable();
                    adapter.Fill(supplementsTable);

                    SupplementItems = supplementsTable.AsEnumerable()
                        .Select(row => new SupplementItem
                        {
                            SupplementNumber = row.Field<string>("SupplementNumber"),
                            SupplementDate = row.Field<DateTime>("SupplementDate")
                        }).ToList();

                }

                string queryProducts = "SELECT a.ProductName, a.ProductCode, a.Quantity, a.ProductPrice, a.Sum, a.ImportedMaterials FROM Specifications a " +
                    "INNER JOIN Invoices b ON a.InvoiceID = b.InvoiceID " +
                    "WHERE b.DeclarationID = @DeclarationID";

                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(queryProducts, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {

                    command.Parameters.AddWithValue("@DeclarationID", insertedDeclarationID);

                    DataTable productsTable = new DataTable();
                    adapter.Fill(productsTable);

                    ProductItems = productsTable.AsEnumerable()
                        .Select(row => new ProductItem
                        {
                            ProductName = row.Field<string>("ProductName"),
                            ProductCode = row.Field<Int64>("ProductCode"),
                            Quantity = row.Field<int>("Quantity"),
                            ProductPrice = row.Field<decimal>("ProductPrice"),
                            Sum = row.Field<decimal>("Sum"),
                            ImportedMaterials = row.Field<decimal>("ImportedMaterials")
                        }).ToList();

                }

                //ParseTemplate
                using (var templateFile = File.Open(@"templates\ПС_ТПП_tmpl.docx", FileMode.Open, FileAccess.Read))
                {
                    using (var stream = new MemoryStream())
                    {
                        templateFile.CopyTo(stream);

                        using (var wordDoc = WordprocessingDocument.Open(stream, true))
                        {
                            //Get all content controls
                            List<SdtElement> sdtList = wordDoc.MainDocumentPart.Document.Descendants<SdtElement>().ToList();

                            //SdtBlock sdtA = null;

                            foreach (SdtElement sdt in sdtList)
                            {

                                switch (sdt.SdtProperties.GetFirstChild<Tag>().Val.Value)
                                {

                                    case "NationalMaterials":
                                        //styles = sdt.Descendants<RunProperties>().First().CloneNode(true);
                                        sdt.Descendants<Paragraph>().Single().Remove();

                                        foreach (var item in ProductItems)
                                        {
                                            Paragraph para = sdt.AppendChild(new Paragraph());
                                            Run run = para.AppendChild(new Run());
                                            run.AppendChild(new Text("- " + ((decimal)100.00 - item.ImportedMaterials).ToString() + "% от общей себестоимости 1 ед. " + item.ProductName.ToString() + ";"));
                                        }

                                        break;

                                    case "ImportedMaterials":
                                        //styles = sdt.Descendants<RunProperties>().First().CloneNode(true);
                                        sdt.Descendants<Paragraph>().Single().Remove();

                                        foreach (var item in ProductItems)
                                        {
                                            Paragraph para = sdt.AppendChild(new Paragraph());
                                            Run run = para.AppendChild(new Run());
                                            run.AppendChild(new Text("- " + item.ImportedMaterials.ToString() + "% от общей себестоимости 1 ед. " + item.ProductName.ToString() + ";"));
                                        }

                                        break;

                                    case "Contract":
                                        sdt.Descendants<Text>().FirstOrDefault().Text = "№ " + thisContractNumber + " от " + thisContractDate.ToShortDateString() + " г.";
                                        break;

                                    case "Supplements":
                                        sdt.Descendants<Text>().FirstOrDefault().Text = "";

                                        foreach (var item in SupplementItems)
                                        {
                                            sdt.Descendants<Text>().FirstOrDefault().Text += "№ " + item.SupplementNumber.ToString() + " от ";
                                            sdt.Descendants<Text>().FirstOrDefault().Text += item.SupplementDate.ToShortDateString() + " г. ";
                                        }
                                        break;

                                    case "Invoices":
                                        sdt.Descendants<Text>().FirstOrDefault().Text = "";

                                        foreach (var item in InvoiceItems)
                                        {
                                            sdt.Descendants<Text>().FirstOrDefault().Text += "№ " + item.InvoiceNumber.ToString() + " от ";
                                            sdt.Descendants<Text>().FirstOrDefault().Text += item.InvoiceDate.ToShortDateString() + " г. ";
                                        }
                                        break;

                                    case "ProdRef":
                                        sdt.Descendants<Text>().FirstOrDefault().Text = "№ " + prodRefNumber.ToString() + " от " + prodRefDate.ToShortDateString() + " г.";
                                        break;

                                    case "AuthPerson":
                                        sdt.Descendants<Text>().FirstOrDefault().Text = authPerson;
                                        break;
                                }

                                //OpenXmlElement contentBlock = sdtA.GetFirstChild<SdtContentBlock>();
                                //OpenXmlElement parent = sdtA.Parent;
                                //OpenXmlElementList elements = contentBlock.ChildElements;
                                //var contentBlockcontent = new SdtContentBlock(contentBlock.OuterXml);
                                //foreach (OpenXmlElement elem in elements)
                                //{

                                //    string text = parent.FirstChild.InnerText;
                                //    parent.Append((OpenXmlElement)elem.Clone());
                                //}

                                //sdtA.Remove();

                                wordDoc.MainDocumentPart.Document.Save();
                            }


                        }

                        stream.Seek(0, SeekOrigin.Begin);

                        var outPath = destinationFolder + @"\ПС_ТПП_" + Regex.Replace(thisContractNumber, @"/", "_") + "_" + DateTime.Now.ToString("dd-MM-yyyy-H-mm-ss") + ".docx";

                        using (var fileStream = File.Create(outPath))
                        {
                            stream.CopyTo(fileStream);
                        }

                    }

                }
            }
            catch (Exception ex)
            {
                Log(ex);
                MessageBox.Show("Недостаточно информации для формирования Производственной справки. Проверте введенную информацию.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, (MessageBoxOptions)0x40000);
                return;
            }
        }

        public void CreateInvoiceDocument(int insertedDeclarationID, string destinationFolder)
        {
            List<InvoiceItem> InvoiceItems;
            List<SupplementItem> SupplementItems;
            List<ProductItem> ProductItems;

            decimal totalPrice;
            int totalGross;
            int totalNet;

            string thisContractCurrency;
            string templatePath;

            try
            {
                string queryContract = "SELECT a.ContractNumber, a.ContractDate, a.Currency FROM Declaration a " +
                   "WHERE a.DeclarationID = @DeclarationID";

                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(queryContract, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {

                    command.Parameters.AddWithValue("@DeclarationID", insertedDeclarationID);

                    DataTable contractTable = new DataTable();
                    adapter.Fill(contractTable);

                    this.thisContractNumber = contractTable.Rows[0].Field<string>("ContractNumber");
                    this.thisContractDate = contractTable.Rows[0].Field<DateTime>("ContractDate");
                    thisContractCurrency = contractTable.Rows[0].Field<string>("Currency");

                }

                string queryInvoices = "SELECT a.InvoiceID, a.InvoiceNumber, a.InvoiceDate FROM Invoices a " +
                   "WHERE a.DeclarationID = @DeclarationID";

                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(queryInvoices, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {

                    command.Parameters.AddWithValue("@DeclarationID", insertedDeclarationID);

                    DataTable invoicesTable = new DataTable();
                    adapter.Fill(invoicesTable);

                    InvoiceItems = invoicesTable.AsEnumerable()
                        .Select(row => new InvoiceItem
                        {
                            InvoiceID = row.Field<int>("InvoiceID"),
                            InvoiceNumber = row.Field<string>("InvoiceNumber"),
                            InvoiceDate = row.Field<DateTime>("InvoiceDate")
                        }).ToList();

                }

                if (thisContractCurrency == "RUR")
                {
                    templatePath = @"templates\RUR\СФ_tmpl.docx";
                }
                else
                    templatePath = @"templates\EUR\СФ_tmpl.docx";

                foreach (var item in InvoiceItems)
                {
                    var invoiceID = item.InvoiceID;

                    string querySupplements = "SELECT a.SupplementNumber, a.SupplementDate, a.OfferNumber FROM Supplements a " +
                        "INNER JOIN Invoices b ON a.SupplementID = b.SupplementID " +
                        "WHERE b.InvoiceID = @InvoiceID";

                    using (connection = new SqlConnection(connectionString))
                    using (SqlCommand command = new SqlCommand(querySupplements, connection))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {

                        command.Parameters.AddWithValue("@InvoiceID", invoiceID);

                        DataTable supplementsTable = new DataTable();
                        adapter.Fill(supplementsTable);

                        SupplementItems = supplementsTable.AsEnumerable()
                            .Select(row => new SupplementItem
                            {
                                SupplementNumber = row.Field<string>("SupplementNumber"),
                                SupplementDate = row.Field<DateTime>("SupplementDate"),
                                OfferNumber = row.Field<int>("OfferNumber")
                            }).ToList();
                    }

                    string queryProducts = "SELECT a.ProductName, a.ProductCode, a.Quantity, a.ProductPrice, a.Sum FROM Specifications a " +
                    "INNER JOIN Invoices b ON a.InvoiceID = b.InvoiceID " +
                    "WHERE b.InvoiceID = @InvoiceID";

                    using (connection = new SqlConnection(connectionString))
                    using (SqlCommand command = new SqlCommand(queryProducts, connection))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {

                        command.Parameters.AddWithValue("@InvoiceID", invoiceID);

                        DataTable productsTable = new DataTable();
                        adapter.Fill(productsTable);

                        ProductItems = productsTable.AsEnumerable()
                            .Select(row => new ProductItem
                            {
                                ProductName = row.Field<string>("ProductName"),
                                Quantity = row.Field<int>("Quantity"),
                                ProductPrice = row.Field<decimal>("ProductPrice"),
                                Sum = row.Field<decimal>("Sum")
                            }).ToList();

                    }


                    string queryTotalPrice = "SELECT SUM(a.SUM) FROM Specifications a " +
                    "INNER JOIN Invoices b ON a.InvoiceID = b.InvoiceID " +
                    "WHERE b.InvoiceID = @InvoiceID";

                    using (connection = new SqlConnection(connectionString))
                    using (SqlCommand command = new SqlCommand(queryTotalPrice, connection))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        connection.Open();

                        command.Parameters.AddWithValue("@InvoiceID", invoiceID);

                        totalPrice = Convert.ToDecimal(command.ExecuteScalar());

                    }


                    string queryPackingListDeclaration = "SELECT SUM(Gross) as TotalGross, SUM(Net) as TotalNet FROM PackingListSpecification a " +
                    "INNER JOIN Invoices b ON a.InvoiceID = b.InvoiceID " +
                    "WHERE b.InvoiceID = @InvoiceID";

                    using (connection = new SqlConnection(connectionString))
                    using (SqlCommand command = new SqlCommand(queryPackingListDeclaration, connection))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {

                        command.Parameters.AddWithValue("@InvoiceID", invoiceID);

                        DataTable productsAmountTable = new DataTable();
                        adapter.Fill(productsAmountTable);

                        totalGross = productsAmountTable.Rows[0].Field<int>("TotalGross");
                        totalNet = productsAmountTable.Rows[0].Field<int>("TotalNet");

                    }


                    //Start parsing template

                    using (var templateFile = File.Open(templatePath, FileMode.Open, FileAccess.Read))
                    {
                        using (var stream = new MemoryStream())
                        {
                            templateFile.CopyTo(stream);

                            using (var wordDoc = WordprocessingDocument.Open(stream, true))
                            {
                                //Get all content controls
                                List<SdtElement> sdtList = wordDoc.MainDocumentPart.Document.Descendants<SdtElement>().ToList();


                                //Inserting products to table
                                Table theTable = wordDoc.MainDocumentPart.Document.Body.Elements<Table>().First();

                                TableRow theRow = theTable.Elements<TableRow>().ElementAt(3);

                                int i = 1;
                                foreach (var productItem in ProductItems)
                                {
                                    TableRow rowCopy = (TableRow)theRow.CloneNode(true);
                                    rowCopy.Descendants<TableCell>().ElementAt(0).Descendants<Text>().FirstOrDefault().Text = i.ToString();
                                    rowCopy.Descendants<TableCell>().ElementAt(1).Descendants<Text>().FirstOrDefault().Text = productItem.ProductName.ToString();
                                    rowCopy.Descendants<TableCell>().ElementAt(2).Descendants<Text>().FirstOrDefault().Text = productItem.Quantity.ToString();
                                    rowCopy.Descendants<TableCell>().ElementAt(3).Descendants<Text>().FirstOrDefault().Text = productItem.ProductPrice.ToString("0.00");
                                    rowCopy.Descendants<TableCell>().ElementAt(4).Descendants<Text>().FirstOrDefault().Text = productItem.Sum.ToString("0.00");
                                    //theTable.AppendChild(rowCopy);
                                    theTable.InsertAfter(rowCopy, theTable.Elements<TableRow>().ElementAt(2 + i));
                                    i++;
                                }

                                theTable.RemoveChild(theRow);

                                //Working with SdtElements
                                foreach (SdtElement sdt in sdtList)
                                {

                                    switch (sdt.SdtProperties.GetFirstChild<Tag>().Val.Value)
                                    {
                                        case "Invoice":
                                            sdt.Descendants<Text>().FirstOrDefault().Text = "";
                                            sdt.Descendants<Text>().FirstOrDefault().Text += "№ " + item.InvoiceNumber.ToString() + " от ";
                                            sdt.Descendants<Text>().FirstOrDefault().Text += item.InvoiceDate.ToShortDateString() + " г. ";
                                            break;

                                        case "Contract":
                                            sdt.Descendants<Text>().FirstOrDefault().Text = "№ " + thisContractNumber.ToString() + " от " + thisContractDate.ToShortDateString() + " г.";
                                            break;

                                        case "Supplement":
                                            sdt.Descendants<Text>().FirstOrDefault().Text = "";

                                            foreach (var supplement in SupplementItems)
                                            {
                                                sdt.Descendants<Text>().FirstOrDefault().Text += "№ " + supplement.SupplementNumber.ToString() + " от ";
                                                sdt.Descendants<Text>().FirstOrDefault().Text += supplement.SupplementDate.ToShortDateString() + " г. ";
                                            }

                                            break;

                                        case "SpecificationNumber":
                                            sdt.Descendants<Text>().FirstOrDefault().Text = SupplementItems[0].SupplementNumber.ToString();
                                            break;

                                        case "OfferNumber":
                                            sdt.Descendants<Text>().FirstOrDefault().Text = "OF" + SupplementItems[0].OfferNumber.ToString();
                                            break;

                                        case "TotalPrice":
                                            sdt.Descendants<Text>().FirstOrDefault().Text = totalPrice.ToString("0.00");
                                            break;

                                        case "TotalPriceInt":
                                            sdt.Descendants<Text>().FirstOrDefault().Text = Math.Truncate(totalPrice).ToString();
                                            break;

                                        case "TotalPriceFract":
                                            sdt.Descendants<Text>().FirstOrDefault().Text = Convert.ToInt32((totalPrice - Math.Truncate(totalPrice)) * 100).ToString();
                                            break;

                                        case "Gross":
                                            sdt.Descendants<Text>().FirstOrDefault().Text = totalGross.ToString();
                                            break;

                                        case "Net":
                                            sdt.Descendants<Text>().FirstOrDefault().Text = totalNet.ToString();
                                            break;

                                    }


                                    wordDoc.MainDocumentPart.Document.Save();
                                }


                            }

                            stream.Seek(0, SeekOrigin.Begin);

                            var outPath = destinationFolder + @"\СФ_" + Regex.Replace(thisContractNumber, @"/", "_") + "_№_" + Regex.Replace(item.InvoiceNumber, @"/", "_") + "_" + item.InvoiceDate.ToString("dd-MM-yyyy") + "_" + DateTime.Now.ToString("dd-MM-yyyy-H-mm-ss") + ".docx";

                            using (var fileStream = File.Create(outPath))
                            {
                                stream.CopyTo(fileStream);
                            }

                        }
                    }
                    //End
                    SupplementItems.Clear();
                    ProductItems.Clear();
                }
            }
            catch (Exception ex)
            {
                Log(ex);
                MessageBox.Show("Недостаточно информации для формирования Инвойсов. Проверте введенную информацию.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, (MessageBoxOptions)0x40000);
                return;
            }
        }

        public void CreatePackingListDocument(int insertedDeclarationID, string destinationFolder)
        {
            string packingListNumber;
            DateTime packingListDate;
            string authPerson;
            List<InvoiceItem> InvoiceItems;
            List<PackingListItem> PackingListItems;

            int totalGross;
            int totalNet;
            int totalPalletsNumber;
            int totalSeatsNumber;

            try
            {
                string queryPackingListDeclaration = "SELECT SUM(Quantity) as TotalPallets, SUM(Gross) as TotalGross, SUM(Net) as TotalNet, SUM(SeatsNumber) as TotalSeatsNumber FROM PackingListSpecification a " +
                    "INNER JOIN Invoices b ON a.InvoiceID = b.InvoiceID " +
                    "WHERE b.DeclarationID = @DeclarationID";

                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(queryPackingListDeclaration, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {

                    command.Parameters.AddWithValue("@DeclarationID", insertedDeclarationID);

                    DataTable productsAmountTable = new DataTable();
                    adapter.Fill(productsAmountTable);

                    totalPalletsNumber = productsAmountTable.Rows[0].Field<int>("TotalPallets");
                    totalGross = productsAmountTable.Rows[0].Field<int>("TotalGross");
                    totalNet = productsAmountTable.Rows[0].Field<int>("TotalNet");
                    totalSeatsNumber = productsAmountTable.Rows[0].Field<int>("TotalSeatsNumber");

                }

                string queryContract = "SELECT a.ContractNumber, a.ContractDate FROM Declaration a " +
                   "WHERE a.DeclarationID = @DeclarationID";

                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(queryContract, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {

                    command.Parameters.AddWithValue("@DeclarationID", insertedDeclarationID);

                    DataTable contractTable = new DataTable();
                    adapter.Fill(contractTable);

                    if (contractTable.Rows.Count == 1)
                    {
                        this.thisContractNumber = contractTable.Rows[0].Field<string>("ContractNumber");
                        this.thisContractDate = contractTable.Rows[0].Field<DateTime>("ContractDate");
                    }
                }

                string queryInvoices = "SELECT a.InvoiceNumber, a.InvoiceDate FROM Invoices a " +
                   "WHERE a.DeclarationID = @DeclarationID";

                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(queryInvoices, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {

                    command.Parameters.AddWithValue("@DeclarationID", insertedDeclarationID);

                    DataTable invoicesTable = new DataTable();
                    adapter.Fill(invoicesTable);

                    InvoiceItems = invoicesTable.AsEnumerable()
                        .Select(row => new InvoiceItem
                        {
                            InvoiceNumber = row.Field<string>("InvoiceNumber"),
                            InvoiceDate = row.Field<DateTime>("InvoiceDate")
                        }).ToList();

                }

                string queryPackingListSpecification = "SELECT a.OfferNumber, b.ItemName, b.PackageType, b.Quantity, b.PackingWeight, b.NetPerItem, b.Net, b.Gross, b.PalletNumber, b.SeatsNumber FROM PackingListSpecification b " +
                    "INNER JOIN Invoices c ON b.InvoiceID = c.InvoiceID " +
                    "INNER JOIN Supplements a ON a.SupplementID = c.SupplementID " +
                    "WHERE c.DeclarationID = @DeclarationID";

                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(queryPackingListSpecification, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {

                    command.Parameters.AddWithValue("@DeclarationID", insertedDeclarationID);

                    DataTable packingListSpecificationTable = new DataTable();
                    adapter.Fill(packingListSpecificationTable);

                    PackingListItems = packingListSpecificationTable.AsEnumerable()
                        .Select(row => new PackingListItem
                        {
                            ItemOfferNumber = row.Field<int>("OfferNumber"),
                            ItemName = row.Field<string>("ItemName"),
                            PackageType = row.Field<string>("PackageType"),
                            Quantity = row.Field<int>("Quantity"),
                            PackingWeight = row.Field<int>("PackingWeight"),
                            NetPerItem = row.Field<int>("NetPerItem"),
                            Net = row.Field<int>("Net"),
                            Gross = row.Field<int>("Gross"),
                            PalletNumber = row.Field<string>("PalletNumber"),
                            SeatsNumber = row.Field<int>("SeatsNumber")

                        }).ToList();

                }

                string queryPackingList = "SELECT a.PackingListNumber, a.PackingListDate, a.CheckedPerson FROM PackingList a " +
                    "INNER JOIN PackingListSpecification b ON a.PackingListID = b.PackingListID " +
                    "WHERE a.DeclarationID = @DeclarationID";

                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(queryPackingList, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {

                    command.Parameters.AddWithValue("@DeclarationID", insertedDeclarationID);

                    DataTable packinListTable = new DataTable();
                    adapter.Fill(packinListTable);

                    packingListNumber = packinListTable.Rows[0].Field<string>("PackingListNumber");
                    packingListDate = packinListTable.Rows[0].Field<DateTime>("PackingListDate");
                    authPerson = packinListTable.Rows[0].Field<string>("CheckedPerson");

                }

                //ParseTemplate
                using (var templateFile = File.Open(@"templates\УЛ_tmpl.docx", FileMode.Open, FileAccess.Read))
                {
                    using (var stream = new MemoryStream())
                    {
                        templateFile.CopyTo(stream);

                        using (var wordDoc = WordprocessingDocument.Open(stream, true))
                        {
                            //Get all content controls
                            List<SdtElement> sdtList = wordDoc.MainDocumentPart.Document.Descendants<SdtElement>().ToList();

                            //Inserting products to table
                            Table theTable = wordDoc.MainDocumentPart.Document.Body.Elements<Table>().First();

                            TableRow theRow = theTable.Elements<TableRow>().ElementAt(7);

                            int i = 1;
                            foreach (var item in PackingListItems)
                            {
                                TableRow rowCopy = (TableRow)theRow.CloneNode(true);
                                rowCopy.Descendants<TableCell>().ElementAt(0).Descendants<Text>().FirstOrDefault().Text = i.ToString() + " (OF" + item.ItemOfferNumber.ToString() + ")";
                                rowCopy.Descendants<TableCell>().ElementAt(1).Descendants<Text>().FirstOrDefault().Text = item.ItemName;
                                rowCopy.Descendants<TableCell>().ElementAt(2).Descendants<Text>().FirstOrDefault().Text = item.PackageType;
                                rowCopy.Descendants<TableCell>().ElementAt(3).Descendants<Text>().FirstOrDefault().Text = item.Quantity.ToString();
                                rowCopy.Descendants<TableCell>().ElementAt(5).Descendants<Text>().FirstOrDefault().Text = item.PackingWeight.ToString();
                                rowCopy.Descendants<TableCell>().ElementAt(6).Descendants<Text>().FirstOrDefault().Text = item.NetPerItem.ToString();
                                rowCopy.Descendants<TableCell>().ElementAt(7).Descendants<Text>().FirstOrDefault().Text = item.Net.ToString();
                                rowCopy.Descendants<TableCell>().ElementAt(8).Descendants<Text>().FirstOrDefault().Text = item.Gross.ToString();
                                rowCopy.Descendants<TableCell>().ElementAt(9).Descendants<Text>().FirstOrDefault().Text = item.PalletNumber;
                                rowCopy.Descendants<TableCell>().ElementAt(10).Descendants<Text>().FirstOrDefault().Text = item.SeatsNumber.ToString();
                                //theTable.AppendChild(rowCopy);
                                theTable.InsertAfter(rowCopy, theTable.Elements<TableRow>().ElementAt(6 + i));
                                i++;
                            }

                            theTable.RemoveChild(theRow);

                            //Working with SdtElements
                            foreach (SdtElement sdt in sdtList)
                            {

                                switch (sdt.SdtProperties.GetFirstChild<Tag>().Val.Value)
                                {
                                    case "PackingListNumber":
                                        sdt.Descendants<Text>().FirstOrDefault().Text = "УПАКОВОЧНЫЙ ЛИСТ № " + packingListNumber + " от " + packingListDate.ToShortDateString() + " г.";
                                        break;

                                    case "Invoices":
                                        sdt.Descendants<Text>().FirstOrDefault().Text = "";
                                        foreach (var invoiceItem in InvoiceItems)
                                        {
                                            sdt.Descendants<Text>().FirstOrDefault().Text += "№ " + invoiceItem.InvoiceNumber + " от " + invoiceItem.InvoiceDate.ToShortDateString() + " г., ";
                                        }
                                        sdt.Descendants<Text>().FirstOrDefault().Text = sdt.Descendants<Text>().FirstOrDefault().Text.Remove(sdt.Descendants<Text>().FirstOrDefault().Text.Length - 2);
                                        break;

                                    case "ContractNumber":
                                        sdt.Descendants<Text>().FirstOrDefault().Text = "№ " + thisContractNumber.ToString() + " от " + thisContractDate.ToShortDateString() + " г.";
                                        break;

                                    case "TotalNet":
                                        sdt.Descendants<Text>().FirstOrDefault().Text = totalNet.ToString();
                                        break;

                                    case "TotalGross":
                                        sdt.Descendants<Text>().FirstOrDefault().Text = totalGross.ToString();
                                        break;

                                    case "TotalPalletsNumber":
                                        sdt.Descendants<Text>().FirstOrDefault().Text = totalPalletsNumber.ToString();
                                        break;

                                    case "TotalSeatsNumber":
                                        sdt.Descendants<Text>().FirstOrDefault().Text = totalSeatsNumber.ToString();
                                        break;

                                    case "AuthPerson":
                                        sdt.Descendants<Text>().FirstOrDefault().Text = authPerson;
                                        break;

                                }


                                wordDoc.MainDocumentPart.Document.Save();
                            }

                        }

                        stream.Seek(0, SeekOrigin.Begin);

                        var outPath = destinationFolder + @"\УЛ_" + Regex.Replace(thisContractNumber, @"/", "_") + "_" + DateTime.Now.ToString("dd-MM-yyyy-H-mm-ss") + ".docx";

                        using (var fileStream = File.Create(outPath))
                        {
                            stream.CopyTo(fileStream);
                        }

                    }

                }
            }
            catch (Exception ex)
            {
                Log(ex);
                MessageBox.Show("Недостаточно данных для формирования Упаковочного листа. Проверте введенную информацию.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, (MessageBoxOptions)0x40000);
                return;
            }
        }

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }

            return "Local IP Address Not Found!";
        }

        private void Log(Exception ex)
        {
            var logPath = @"logistic.log";

            using (var stream = new MemoryStream())
            {
                if (File.Exists(logPath))
                {
                    using (StreamWriter sw = File.AppendText(logPath))
                    {
                        sw.WriteLine(DateTime.Now.ToString("dd/MM/yyyy H:mm:ss") + " IP: " + GetLocalIPAddress() + " Machine Name: " + Environment.MachineName + " Exception: " + ex);
                    }

                }
                else
                {
                    using (StreamWriter sw = File.CreateText(logPath))
                    {
                        sw.WriteLine(DateTime.Now.ToString("dd/MM/yyyy H:mm:ss") + " IP: " + GetLocalIPAddress() + " Machine Name: " + Environment.MachineName + " Exception: " + ex);
                    }
                }

            }
            
        }
    }
}
