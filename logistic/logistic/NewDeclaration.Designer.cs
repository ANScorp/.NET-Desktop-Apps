namespace logistic
{
    partial class NewDeclaration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contractNumber = new System.Windows.Forms.TextBox();
            this.contractDate = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.supplementNumber = new System.Windows.Forms.TextBox();
            this.supplementDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddSupplement = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.offerNumber = new System.Windows.Forms.TextBox();
            this.lstSupplements = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lbContract = new System.Windows.Forms.Label();
            this.btnGoToInvoice = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.invoiceNumber = new System.Windows.Forms.TextBox();
            this.invoiceDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddInvoice = new System.Windows.Forms.Button();
            this.lstInvoices = new System.Windows.Forms.ListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lbContractInvoice = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.cbSupplementToInvoice = new System.Windows.Forms.ComboBox();
            this.btnInvoicesToPackList = new System.Windows.Forms.Button();
            this.btnAddSpecification = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.packingListNumber = new System.Windows.Forms.TextBox();
            this.packingListDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddPackList = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.lbContractPackList = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.checkedPerson = new System.Windows.Forms.ComboBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.prodRefNumber = new System.Windows.Forms.TextBox();
            this.btnMakeReport = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.prodRefDate = new System.Windows.Forms.DateTimePicker();
            this.authPerson = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnAddContract = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.productList = new System.Windows.Forms.TextBox();
            this.currency = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 44);
            this.label2.TabIndex = 0;
            this.label2.Text = "Номер договора:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Дата договора:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contractNumber
            // 
            this.contractNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contractNumber.Location = new System.Drawing.Point(256, 3);
            this.contractNumber.Multiline = true;
            this.contractNumber.Name = "contractNumber";
            this.contractNumber.Size = new System.Drawing.Size(248, 38);
            this.contractNumber.TabIndex = 0;
            // 
            // contractDate
            // 
            this.contractDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contractDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.contractDate.Location = new System.Drawing.Point(256, 47);
            this.contractDate.Name = "contractDate";
            this.contractDate.Size = new System.Drawing.Size(248, 20);
            this.contractDate.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(513, 450);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Добавить приложения";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.supplementNumber, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.supplementDate, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnAddSupplement, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.label12, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.offerNumber, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.lstSupplements, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.label13, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.label18, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbContract, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnGoToInvoice, 1, 7);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 9;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(507, 444);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 35);
            this.label4.TabIndex = 0;
            this.label4.Text = "Номер приложения:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Дата приложения:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // supplementNumber
            // 
            this.supplementNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.supplementNumber.Location = new System.Drawing.Point(256, 42);
            this.supplementNumber.Multiline = true;
            this.supplementNumber.Name = "supplementNumber";
            this.supplementNumber.Size = new System.Drawing.Size(248, 29);
            this.supplementNumber.TabIndex = 2;
            // 
            // supplementDate
            // 
            this.supplementDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.supplementDate.Location = new System.Drawing.Point(256, 77);
            this.supplementDate.Name = "supplementDate";
            this.supplementDate.Size = new System.Drawing.Size(248, 20);
            this.supplementDate.TabIndex = 3;
            // 
            // btnAddSupplement
            // 
            this.btnAddSupplement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddSupplement.Location = new System.Drawing.Point(256, 134);
            this.btnAddSupplement.Name = "btnAddSupplement";
            this.btnAddSupplement.Size = new System.Drawing.Size(248, 39);
            this.btnAddSupplement.TabIndex = 4;
            this.btnAddSupplement.Text = "Добавить приложение";
            this.btnAddSupplement.UseVisualStyleBackColor = true;
            this.btnAddSupplement.Click += new System.EventHandler(this.btnAddSupplement_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Location = new System.Drawing.Point(3, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(247, 32);
            this.label12.TabIndex = 6;
            this.label12.Text = "ОФ:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // offerNumber
            // 
            this.offerNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.offerNumber.Location = new System.Drawing.Point(256, 102);
            this.offerNumber.Multiline = true;
            this.offerNumber.Name = "offerNumber";
            this.offerNumber.Size = new System.Drawing.Size(248, 26);
            this.offerNumber.TabIndex = 9;
            // 
            // lstSupplements
            // 
            this.lstSupplements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSupplements.FormattingEnabled = true;
            this.lstSupplements.Location = new System.Drawing.Point(256, 179);
            this.lstSupplements.Name = "lstSupplements";
            this.lstSupplements.Size = new System.Drawing.Size(248, 74);
            this.lstSupplements.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Location = new System.Drawing.Point(3, 176);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(247, 80);
            this.label13.TabIndex = 18;
            this.label13.Text = "Прикрепленные приложения:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Location = new System.Drawing.Point(3, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(247, 39);
            this.label18.TabIndex = 19;
            this.label18.Text = "К договору:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbContract
            // 
            this.lbContract.AutoSize = true;
            this.lbContract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbContract.Location = new System.Drawing.Point(256, 0);
            this.lbContract.Name = "lbContract";
            this.lbContract.Size = new System.Drawing.Size(248, 39);
            this.lbContract.TabIndex = 20;
            this.lbContract.Text = "Необходимо добавить договор";
            this.lbContract.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGoToInvoice
            // 
            this.btnGoToInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGoToInvoice.Enabled = false;
            this.btnGoToInvoice.Location = new System.Drawing.Point(256, 279);
            this.btnGoToInvoice.Name = "btnGoToInvoice";
            this.btnGoToInvoice.Size = new System.Drawing.Size(248, 47);
            this.btnGoToInvoice.TabIndex = 21;
            this.btnGoToInvoice.Text = "Далее";
            this.btnGoToInvoice.UseVisualStyleBackColor = true;
            this.btnGoToInvoice.Click += new System.EventHandler(this.btnGoToInvoice_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(513, 450);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Добавить инвойсы";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.invoiceNumber, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.invoiceDate, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.btnAddInvoice, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.lstInvoices, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this.label15, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.label19, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lbContractInvoice, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label20, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.cbSupplementToInvoice, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.btnInvoicesToPackList, 1, 8);
            this.tableLayoutPanel4.Controls.Add(this.btnAddSpecification, 1, 6);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 10;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(507, 444);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(247, 37);
            this.label6.TabIndex = 0;
            this.label6.Text = "Номер инвойса:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(247, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Дата инвойса:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // invoiceNumber
            // 
            this.invoiceNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.invoiceNumber.Location = new System.Drawing.Point(256, 76);
            this.invoiceNumber.Multiline = true;
            this.invoiceNumber.Name = "invoiceNumber";
            this.invoiceNumber.Size = new System.Drawing.Size(248, 31);
            this.invoiceNumber.TabIndex = 2;
            // 
            // invoiceDate
            // 
            this.invoiceDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.invoiceDate.Location = new System.Drawing.Point(256, 113);
            this.invoiceDate.Name = "invoiceDate";
            this.invoiceDate.Size = new System.Drawing.Size(248, 20);
            this.invoiceDate.TabIndex = 3;
            // 
            // btnAddInvoice
            // 
            this.btnAddInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddInvoice.Location = new System.Drawing.Point(256, 138);
            this.btnAddInvoice.Name = "btnAddInvoice";
            this.btnAddInvoice.Size = new System.Drawing.Size(248, 45);
            this.btnAddInvoice.TabIndex = 4;
            this.btnAddInvoice.Text = "Добавить инвойс";
            this.btnAddInvoice.UseVisualStyleBackColor = true;
            this.btnAddInvoice.Click += new System.EventHandler(this.btnAddInvoice_Click);
            // 
            // lstInvoices
            // 
            this.lstInvoices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstInvoices.FormattingEnabled = true;
            this.lstInvoices.Location = new System.Drawing.Point(256, 189);
            this.lstInvoices.Name = "lstInvoices";
            this.lstInvoices.Size = new System.Drawing.Size(248, 86);
            this.lstInvoices.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Location = new System.Drawing.Point(3, 186);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(247, 92);
            this.label15.TabIndex = 6;
            this.label15.Text = "Прикрепленные инвойсы:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Location = new System.Drawing.Point(3, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(247, 46);
            this.label19.TabIndex = 7;
            this.label19.Text = "К договору:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbContractInvoice
            // 
            this.lbContractInvoice.AutoSize = true;
            this.lbContractInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbContractInvoice.Location = new System.Drawing.Point(256, 0);
            this.lbContractInvoice.Name = "lbContractInvoice";
            this.lbContractInvoice.Size = new System.Drawing.Size(248, 46);
            this.lbContractInvoice.TabIndex = 8;
            this.lbContractInvoice.Text = "Необходимо добавить договор";
            this.lbContractInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label20.Location = new System.Drawing.Point(3, 46);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(247, 27);
            this.label20.TabIndex = 9;
            this.label20.Text = "Согласно приложения:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbSupplementToInvoice
            // 
            this.cbSupplementToInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbSupplementToInvoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSupplementToInvoice.FormattingEnabled = true;
            this.cbSupplementToInvoice.Location = new System.Drawing.Point(256, 49);
            this.cbSupplementToInvoice.Name = "cbSupplementToInvoice";
            this.cbSupplementToInvoice.Size = new System.Drawing.Size(248, 21);
            this.cbSupplementToInvoice.TabIndex = 10;
            // 
            // btnInvoicesToPackList
            // 
            this.btnInvoicesToPackList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInvoicesToPackList.Enabled = false;
            this.btnInvoicesToPackList.Location = new System.Drawing.Point(256, 352);
            this.btnInvoicesToPackList.Name = "btnInvoicesToPackList";
            this.btnInvoicesToPackList.Size = new System.Drawing.Size(248, 45);
            this.btnInvoicesToPackList.TabIndex = 11;
            this.btnInvoicesToPackList.Text = "Далее";
            this.btnInvoicesToPackList.UseVisualStyleBackColor = true;
            this.btnInvoicesToPackList.Click += new System.EventHandler(this.btnInvoicesToPackList_Click);
            // 
            // btnAddSpecification
            // 
            this.btnAddSpecification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddSpecification.Location = new System.Drawing.Point(256, 281);
            this.btnAddSpecification.Name = "btnAddSpecification";
            this.btnAddSpecification.Size = new System.Drawing.Size(248, 45);
            this.btnAddSpecification.TabIndex = 12;
            this.btnAddSpecification.Text = "Добавить спецификацию";
            this.btnAddSpecification.UseVisualStyleBackColor = true;
            this.btnAddSpecification.Click += new System.EventHandler(this.btnAddSpecification_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tableLayoutPanel5);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(513, 450);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Добавить упаковочный лист";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.packingListNumber, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.packingListDate, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.btnAddPackList, 1, 5);
            this.tableLayoutPanel5.Controls.Add(this.label21, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.lbContractPackList, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label14, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.checkedPerson, 1, 3);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 7;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(507, 444);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(247, 60);
            this.label8.TabIndex = 0;
            this.label8.Text = "Номер упаковочного листа:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(3, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(247, 29);
            this.label9.TabIndex = 1;
            this.label9.Text = "Дата упаковочного листа:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // packingListNumber
            // 
            this.packingListNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.packingListNumber.Location = new System.Drawing.Point(256, 104);
            this.packingListNumber.Multiline = true;
            this.packingListNumber.Name = "packingListNumber";
            this.packingListNumber.Size = new System.Drawing.Size(248, 54);
            this.packingListNumber.TabIndex = 2;
            // 
            // packingListDate
            // 
            this.packingListDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.packingListDate.Location = new System.Drawing.Point(256, 164);
            this.packingListDate.Name = "packingListDate";
            this.packingListDate.Size = new System.Drawing.Size(248, 20);
            this.packingListDate.TabIndex = 3;
            // 
            // btnAddPackList
            // 
            this.btnAddPackList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddPackList.Location = new System.Drawing.Point(256, 258);
            this.btnAddPackList.Name = "btnAddPackList";
            this.btnAddPackList.Size = new System.Drawing.Size(248, 77);
            this.btnAddPackList.TabIndex = 4;
            this.btnAddPackList.Text = "Добавить упаковочный лист";
            this.btnAddPackList.UseVisualStyleBackColor = true;
            this.btnAddPackList.Click += new System.EventHandler(this.btnAddPackList_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label21.Location = new System.Drawing.Point(3, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(247, 101);
            this.label21.TabIndex = 5;
            this.label21.Text = "К договору:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbContractPackList
            // 
            this.lbContractPackList.AutoSize = true;
            this.lbContractPackList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbContractPackList.Location = new System.Drawing.Point(256, 0);
            this.lbContractPackList.Name = "lbContractPackList";
            this.lbContractPackList.Size = new System.Drawing.Size(248, 101);
            this.lbContractPackList.TabIndex = 6;
            this.lbContractPackList.Text = "Необходимо добавить договор";
            this.lbContractPackList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Location = new System.Drawing.Point(3, 190);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(247, 28);
            this.label14.TabIndex = 7;
            this.label14.Text = "Проверил:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkedPerson
            // 
            this.checkedPerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedPerson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.checkedPerson.FormattingEnabled = true;
            this.checkedPerson.Items.AddRange(new object[] {
            "Панченко А.А."});
            this.checkedPerson.Location = new System.Drawing.Point(256, 193);
            this.checkedPerson.Name = "checkedPerson";
            this.checkedPerson.Size = new System.Drawing.Size(248, 21);
            this.checkedPerson.TabIndex = 8;
            // 
            // prodRefNumber
            // 
            this.prodRefNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prodRefNumber.Location = new System.Drawing.Point(256, 76);
            this.prodRefNumber.Multiline = true;
            this.prodRefNumber.Name = "prodRefNumber";
            this.prodRefNumber.Size = new System.Drawing.Size(248, 38);
            this.prodRefNumber.TabIndex = 9;
            // 
            // btnMakeReport
            // 
            this.btnMakeReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMakeReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMakeReport.Location = new System.Drawing.Point(13, 540);
            this.btnMakeReport.Name = "btnMakeReport";
            this.btnMakeReport.Size = new System.Drawing.Size(521, 60);
            this.btnMakeReport.TabIndex = 0;
            this.btnMakeReport.Text = "Сформировать";
            this.btnMakeReport.UseVisualStyleBackColor = true;
            this.btnMakeReport.Click += new System.EventHandler(this.btnMakeReport_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.WindowText;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnMakeReport, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnClose, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(547, 679);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(521, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логистика";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(13, 58);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(521, 476);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(513, 450);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Общие";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.contractNumber, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.contractDate, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.prodRefNumber, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.prodRefDate, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.authPerson, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.label17, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.btnAddContract, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.label16, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.productList, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.currency, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.label22, 0, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 10;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(507, 444);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(3, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(247, 44);
            this.label10.TabIndex = 17;
            this.label10.Text = "Номер производственной справки:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(3, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(247, 25);
            this.label11.TabIndex = 18;
            this.label11.Text = "Дата производственной справки:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prodRefDate
            // 
            this.prodRefDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prodRefDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.prodRefDate.Location = new System.Drawing.Point(256, 120);
            this.prodRefDate.Name = "prodRefDate";
            this.prodRefDate.Size = new System.Drawing.Size(248, 20);
            this.prodRefDate.TabIndex = 10;
            // 
            // authPerson
            // 
            this.authPerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.authPerson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.authPerson.FormattingEnabled = true;
            this.authPerson.Items.AddRange(new object[] {
            "В.А. Кузьменко",
            "И.А. Луненко",
            "Е.Н. Безнос"});
            this.authPerson.Location = new System.Drawing.Point(256, 232);
            this.authPerson.Name = "authPerson";
            this.authPerson.Size = new System.Drawing.Size(248, 21);
            this.authPerson.TabIndex = 16;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Location = new System.Drawing.Point(3, 229);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(247, 26);
            this.label17.TabIndex = 31;
            this.label17.Text = "Уполномоченная особа:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddContract
            // 
            this.btnAddContract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddContract.Location = new System.Drawing.Point(256, 285);
            this.btnAddContract.Name = "btnAddContract";
            this.btnAddContract.Size = new System.Drawing.Size(248, 45);
            this.btnAddContract.TabIndex = 36;
            this.btnAddContract.Text = "Далее";
            this.btnAddContract.UseVisualStyleBackColor = true;
            this.btnAddContract.Click += new System.EventHandler(this.btnAddContract_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Location = new System.Drawing.Point(3, 142);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(247, 58);
            this.label16.TabIndex = 37;
            this.label16.Text = "Краткое наименование товаров:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productList
            // 
            this.productList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productList.Location = new System.Drawing.Point(256, 145);
            this.productList.Multiline = true;
            this.productList.Name = "productList";
            this.productList.Size = new System.Drawing.Size(248, 52);
            this.productList.TabIndex = 38;
            this.productList.Text = "Кассовые боксы Омега Руло, Альфа Бак, ПОК";
            // 
            // currency
            // 
            this.currency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.currency.FormattingEnabled = true;
            this.currency.Items.AddRange(new object[] {
            "RUR",
            "EUR"});
            this.currency.Location = new System.Drawing.Point(256, 203);
            this.currency.Name = "currency";
            this.currency.Size = new System.Drawing.Size(248, 21);
            this.currency.TabIndex = 39;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label22.Location = new System.Drawing.Point(3, 200);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(247, 29);
            this.label22.TabIndex = 40;
            this.label22.Text = "Валюта:";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnClose.Location = new System.Drawing.Point(13, 606);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(521, 60);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // NewDeclaration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 679);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "NewDeclaration";
            this.Text = "Новая заявка-декларация";
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox contractNumber;
        public System.Windows.Forms.DateTimePicker contractDate;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        public System.Windows.Forms.TextBox prodRefNumber;
        private System.Windows.Forms.Button btnMakeReport;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.DateTimePicker prodRefDate;
        public System.Windows.Forms.ComboBox authPerson;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox supplementNumber;
        private System.Windows.Forms.DateTimePicker supplementDate;
        private System.Windows.Forms.Button btnAddSupplement;
        private System.Windows.Forms.ListBox lstSupplements;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox invoiceNumber;
        private System.Windows.Forms.DateTimePicker invoiceDate;
        private System.Windows.Forms.Button btnAddInvoice;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAddPackList;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox offerNumber;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnAddContract;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox productList;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lbContract;
        private System.Windows.Forms.Button btnGoToInvoice;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lbContractInvoice;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cbSupplementToInvoice;
        private System.Windows.Forms.Button btnInvoicesToPackList;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lbContractPackList;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddSpecification;
        public System.Windows.Forms.ListBox lstInvoices;
        public System.Windows.Forms.ComboBox currency;
        private System.Windows.Forms.Label label22;
        public System.Windows.Forms.TextBox packingListNumber;
        public System.Windows.Forms.DateTimePicker packingListDate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox checkedPerson;
    }
}