﻿namespace logistic
{
    partial class EditSpecificationItem
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbSum = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbContract = new System.Windows.Forms.Label();
            this.lbSupplement = new System.Windows.Forms.Label();
            this.lbInvoice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.productName = new System.Windows.Forms.TextBox();
            this.productCode = new System.Windows.Forms.ComboBox();
            this.Sum = new System.Windows.Forms.TextBox();
            this.quantity = new System.Windows.Forms.NumericUpDown();
            this.productPrice = new System.Windows.Forms.NumericUpDown();
            this.importedMaterials = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.importedMaterials)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnSaveChanges.Location = new System.Drawing.Point(13, 441);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(623, 60);
            this.btnSaveChanges.TabIndex = 9;
            this.btnSaveChanges.Text = "Сохранить изменения";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Наименование товара:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Код товара:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(305, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Количество, шт.:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPrice.Location = new System.Drawing.Point(3, 90);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(305, 26);
            this.lbPrice.TabIndex = 3;
            this.lbPrice.Text = "Цена, ";
            this.lbPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSum
            // 
            this.lbSum.AutoSize = true;
            this.lbSum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSum.Location = new System.Drawing.Point(3, 116);
            this.lbSum.Name = "lbSum";
            this.lbSum.Size = new System.Drawing.Size(305, 47);
            this.lbSum.TabIndex = 4;
            this.lbSum.Text = "Сумма, ";
            this.lbSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnClose.Location = new System.Drawing.Point(13, 507);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(623, 60);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbContract
            // 
            this.lbContract.AutoSize = true;
            this.lbContract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lbContract.Location = new System.Drawing.Point(13, 55);
            this.lbContract.Name = "lbContract";
            this.lbContract.Size = new System.Drawing.Size(623, 37);
            this.lbContract.TabIndex = 4;
            this.lbContract.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSupplement
            // 
            this.lbSupplement.AutoSize = true;
            this.lbSupplement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSupplement.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lbSupplement.Location = new System.Drawing.Point(13, 92);
            this.lbSupplement.Name = "lbSupplement";
            this.lbSupplement.Size = new System.Drawing.Size(623, 37);
            this.lbSupplement.TabIndex = 5;
            this.lbSupplement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbInvoice
            // 
            this.lbInvoice.AutoSize = true;
            this.lbInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lbInvoice.Location = new System.Drawing.Point(13, 129);
            this.lbInvoice.Name = "lbInvoice";
            this.lbInvoice.Size = new System.Drawing.Size(623, 37);
            this.lbInvoice.TabIndex = 6;
            this.lbInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(305, 29);
            this.label7.TabIndex = 5;
            this.label7.Text = "Удельный вес импортного сырья в стоимости товара, %:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productName
            // 
            this.productName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productName.Location = new System.Drawing.Point(314, 3);
            this.productName.Multiline = true;
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(306, 31);
            this.productName.TabIndex = 7;
            // 
            // productCode
            // 
            this.productCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productCode.FormattingEnabled = true;
            this.productCode.Items.AddRange(new object[] {
            "9403109800",
            "9403901000",
            "9403105800"});
            this.productCode.Location = new System.Drawing.Point(314, 40);
            this.productCode.Name = "productCode";
            this.productCode.Size = new System.Drawing.Size(306, 21);
            this.productCode.TabIndex = 8;
            // 
            // Sum
            // 
            this.Sum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sum.Enabled = false;
            this.Sum.Location = new System.Drawing.Point(314, 119);
            this.Sum.Multiline = true;
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(306, 41);
            this.Sum.TabIndex = 11;
            this.Sum.Text = "0";
            // 
            // quantity
            // 
            this.quantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quantity.Location = new System.Drawing.Point(314, 68);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(306, 20);
            this.quantity.TabIndex = 13;
            // 
            // productPrice
            // 
            this.productPrice.DecimalPlaces = 2;
            this.productPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productPrice.Location = new System.Drawing.Point(314, 93);
            this.productPrice.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(306, 20);
            this.productPrice.TabIndex = 14;
            // 
            // importedMaterials
            // 
            this.importedMaterials.DecimalPlaces = 2;
            this.importedMaterials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.importedMaterials.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.importedMaterials.Location = new System.Drawing.Point(314, 166);
            this.importedMaterials.Name = "importedMaterials";
            this.importedMaterials.Size = new System.Drawing.Size(306, 20);
            this.importedMaterials.TabIndex = 15;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnClose, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.lbContract, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbSupplement, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbInvoice, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnSaveChanges, 1, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(649, 580);
            this.tableLayoutPanel1.TabIndex = 3;
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
            this.label1.Size = new System.Drawing.Size(623, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логистика: изменить спецификацию";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbPrice, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lbSum, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.productName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.productCode, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.Sum, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.quantity, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.productPrice, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.importedMaterials, 1, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(13, 169);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(623, 246);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // EditSpecificationItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 580);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EditSpecificationItem";
            this.Text = "Изменить спецификацию";
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.importedMaterials)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbSum;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbContract;
        private System.Windows.Forms.Label lbSupplement;
        private System.Windows.Forms.Label lbInvoice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox productName;
        private System.Windows.Forms.ComboBox productCode;
        private System.Windows.Forms.TextBox Sum;
        private System.Windows.Forms.NumericUpDown quantity;
        private System.Windows.Forms.NumericUpDown productPrice;
        private System.Windows.Forms.NumericUpDown importedMaterials;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}