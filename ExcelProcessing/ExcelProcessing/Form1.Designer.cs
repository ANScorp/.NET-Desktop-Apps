namespace ExcelProcessing
{
    partial class Form1
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnOpenDocument = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.lbFileName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.rBtnToTitleCase = new System.Windows.Forms.RadioButton();
            this.rBtnToUpper = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Controls.Add(this.btnOpenDocument, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnProcess, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbFileName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(432, 366);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnOpenDocument
            // 
            this.btnOpenDocument.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpenDocument.Location = new System.Drawing.Point(13, 13);
            this.btnOpenDocument.Name = "btnOpenDocument";
            this.btnOpenDocument.Size = new System.Drawing.Size(406, 132);
            this.btnOpenDocument.TabIndex = 0;
            this.btnOpenDocument.Text = "Открыть документ";
            this.btnOpenDocument.UseVisualStyleBackColor = true;
            this.btnOpenDocument.Click += new System.EventHandler(this.btnOpenDocument_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProcess.Enabled = false;
            this.btnProcess.Location = new System.Drawing.Point(13, 221);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(406, 132);
            this.btnProcess.TabIndex = 1;
            this.btnProcess.Text = "Обработать";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // lbFileName
            // 
            this.lbFileName.AutoSize = true;
            this.lbFileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbFileName.Location = new System.Drawing.Point(13, 148);
            this.lbFileName.Name = "lbFileName";
            this.lbFileName.Size = new System.Drawing.Size(406, 20);
            this.lbFileName.TabIndex = 2;
            this.lbFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(13, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 44);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Опции";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.rBtnToTitleCase, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.rBtnToUpper, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(400, 25);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // rBtnToTitleCase
            // 
            this.rBtnToTitleCase.AutoSize = true;
            this.rBtnToTitleCase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rBtnToTitleCase.Location = new System.Drawing.Point(3, 3);
            this.rBtnToTitleCase.Name = "rBtnToTitleCase";
            this.rBtnToTitleCase.Size = new System.Drawing.Size(194, 19);
            this.rBtnToTitleCase.TabIndex = 0;
            this.rBtnToTitleCase.TabStop = true;
            this.rBtnToTitleCase.Text = "Первая буква прописная";
            this.rBtnToTitleCase.UseVisualStyleBackColor = true;
            // 
            // rBtnToUpper
            // 
            this.rBtnToUpper.AutoSize = true;
            this.rBtnToUpper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rBtnToUpper.Location = new System.Drawing.Point(203, 3);
            this.rBtnToUpper.Name = "rBtnToUpper";
            this.rBtnToUpper.Size = new System.Drawing.Size(194, 19);
            this.rBtnToUpper.TabIndex = 1;
            this.rBtnToUpper.TabStop = true;
            this.rBtnToUpper.Text = "Все прописные";
            this.rBtnToUpper.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 366);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Excel: обработка текста";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnOpenDocument;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Label lbFileName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton rBtnToTitleCase;
        private System.Windows.Forms.RadioButton rBtnToUpper;
    }
}

