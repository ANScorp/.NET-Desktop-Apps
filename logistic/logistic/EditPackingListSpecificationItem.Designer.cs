namespace logistic
{
    partial class EditPackingListSpecificationItem
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
            this.btnClose = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbContract = new System.Windows.Forms.Label();
            this.lbPakingList = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbSum = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbInvoiceNumber = new System.Windows.Forms.ComboBox();
            this.quantity = new System.Windows.Forms.NumericUpDown();
            this.netPerItem = new System.Windows.Forms.NumericUpDown();
            this.cbProductName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.palletNumber = new System.Windows.Forms.TextBox();
            this.seatsNumber = new System.Windows.Forms.NumericUpDown();
            this.packingWeight = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.packageType = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.itemName = new System.Windows.Forms.TextBox();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.netPerItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seatsNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packingWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnClose.Location = new System.Drawing.Point(13, 528);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(676, 60);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnClose, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lbContract, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbPakingList, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnSaveChanges, 1, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(702, 601);
            this.tableLayoutPanel1.TabIndex = 4;
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
            this.label1.Size = new System.Drawing.Size(676, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логистика: изменить упаковочный лист";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbContract
            // 
            this.lbContract.AutoSize = true;
            this.lbContract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lbContract.Location = new System.Drawing.Point(13, 55);
            this.lbContract.Name = "lbContract";
            this.lbContract.Size = new System.Drawing.Size(676, 37);
            this.lbContract.TabIndex = 4;
            this.lbContract.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPakingList
            // 
            this.lbPakingList.AutoSize = true;
            this.lbPakingList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPakingList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lbPakingList.Location = new System.Drawing.Point(13, 92);
            this.lbPakingList.Name = "lbPakingList";
            this.lbPakingList.Size = new System.Drawing.Size(676, 37);
            this.lbPakingList.TabIndex = 5;
            this.lbPakingList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbPrice, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lbSum, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.cbInvoiceNumber, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.quantity, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.netPerItem, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.cbProductName, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.palletNumber, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.seatsNumber, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.packingWeight, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.packageType, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.itemName, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(13, 132);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 10;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(676, 304);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(332, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Номер инвойса:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(332, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Наименование товара:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPrice.Location = new System.Drawing.Point(3, 79);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(332, 24);
            this.lbPrice.TabIndex = 3;
            this.lbPrice.Text = "Количество, шт.:";
            this.lbPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSum
            // 
            this.lbSum.AutoSize = true;
            this.lbSum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSum.Location = new System.Drawing.Point(3, 103);
            this.lbSum.Name = "lbSum";
            this.lbSum.Size = new System.Drawing.Size(332, 27);
            this.lbSum.TabIndex = 4;
            this.lbSum.Text = "Вес упаковки, кг:";
            this.lbSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(332, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Вес нетто за ед, кг:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbInvoiceNumber
            // 
            this.cbInvoiceNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbInvoiceNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInvoiceNumber.FormattingEnabled = true;
            this.cbInvoiceNumber.Items.AddRange(new object[] {
            "9403109800",
            "9403901000",
            "9403105800"});
            this.cbInvoiceNumber.Location = new System.Drawing.Point(341, 3);
            this.cbInvoiceNumber.Name = "cbInvoiceNumber";
            this.cbInvoiceNumber.Size = new System.Drawing.Size(332, 21);
            this.cbInvoiceNumber.TabIndex = 8;
            // 
            // quantity
            // 
            this.quantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quantity.Location = new System.Drawing.Point(341, 82);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(332, 20);
            this.quantity.TabIndex = 14;
            // 
            // netPerItem
            // 
            this.netPerItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.netPerItem.Location = new System.Drawing.Point(341, 133);
            this.netPerItem.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.netPerItem.Name = "netPerItem";
            this.netPerItem.Size = new System.Drawing.Size(332, 20);
            this.netPerItem.TabIndex = 15;
            // 
            // cbProductName
            // 
            this.cbProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProductName.FormattingEnabled = true;
            this.cbProductName.Location = new System.Drawing.Point(341, 31);
            this.cbProductName.Name = "cbProductName";
            this.cbProductName.Size = new System.Drawing.Size(332, 21);
            this.cbProductName.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 33);
            this.label2.TabIndex = 17;
            this.label2.Text = "№ поддона:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(332, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "Количество мест:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // palletNumber
            // 
            this.palletNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.palletNumber.Location = new System.Drawing.Point(341, 158);
            this.palletNumber.Multiline = true;
            this.palletNumber.Name = "palletNumber";
            this.palletNumber.Size = new System.Drawing.Size(332, 27);
            this.palletNumber.TabIndex = 19;
            // 
            // seatsNumber
            // 
            this.seatsNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seatsNumber.Location = new System.Drawing.Point(341, 191);
            this.seatsNumber.Name = "seatsNumber";
            this.seatsNumber.Size = new System.Drawing.Size(332, 20);
            this.seatsNumber.TabIndex = 20;
            // 
            // packingWeight
            // 
            this.packingWeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.packingWeight.Location = new System.Drawing.Point(341, 106);
            this.packingWeight.Name = "packingWeight";
            this.packingWeight.Size = new System.Drawing.Size(332, 20);
            this.packingWeight.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(332, 44);
            this.label6.TabIndex = 22;
            this.label6.Text = "Вид упаковки:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // packageType
            // 
            this.packageType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.packageType.Location = new System.Drawing.Point(341, 215);
            this.packageType.Multiline = true;
            this.packageType.Name = "packageType";
            this.packageType.Size = new System.Drawing.Size(332, 38);
            this.packageType.TabIndex = 23;
            this.packageType.Text = "поддон деревянный, короб картонный, стрейч";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(332, 26);
            this.label8.TabIndex = 24;
            this.label8.Text = "Наименование:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // itemName
            // 
            this.itemName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemName.Location = new System.Drawing.Point(341, 56);
            this.itemName.Multiline = true;
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(332, 20);
            this.itemName.TabIndex = 25;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnSaveChanges.Location = new System.Drawing.Point(13, 462);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(676, 60);
            this.btnSaveChanges.TabIndex = 9;
            this.btnSaveChanges.Text = "Сохранить изменения";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // EditPackingListSpecificationItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 601);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EditPackingListSpecificationItem";
            this.Text = "Изменить упаковочный лист";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.netPerItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seatsNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packingWeight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbContract;
        private System.Windows.Forms.Label lbPakingList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox cbInvoiceNumber;
        private System.Windows.Forms.NumericUpDown quantity;
        private System.Windows.Forms.NumericUpDown netPerItem;
        private System.Windows.Forms.ComboBox cbProductName;
        private System.Windows.Forms.TextBox palletNumber;
        private System.Windows.Forms.NumericUpDown seatsNumber;
        private System.Windows.Forms.NumericUpDown packingWeight;
        private System.Windows.Forms.TextBox packageType;
        private System.Windows.Forms.TextBox itemName;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbSum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
    }
}