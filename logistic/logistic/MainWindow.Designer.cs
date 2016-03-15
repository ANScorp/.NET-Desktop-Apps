namespace logistic
{
    partial class MainWindow
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.NewDeclaration = new System.Windows.Forms.Button();
            this.ShowDeclarations = new System.Windows.Forms.Button();
            this.QuickReport = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.NewDeclaration, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ShowDeclarations, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.QuickReport, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(508, 320);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // NewDeclaration
            // 
            this.NewDeclaration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewDeclaration.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewDeclaration.Location = new System.Drawing.Point(23, 23);
            this.NewDeclaration.Name = "NewDeclaration";
            this.NewDeclaration.Size = new System.Drawing.Size(462, 87);
            this.NewDeclaration.TabIndex = 0;
            this.NewDeclaration.Text = "Добавить заявку";
            this.NewDeclaration.UseVisualStyleBackColor = true;
            this.NewDeclaration.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShowDeclarations
            // 
            this.ShowDeclarations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShowDeclarations.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowDeclarations.Location = new System.Drawing.Point(23, 116);
            this.ShowDeclarations.Name = "ShowDeclarations";
            this.ShowDeclarations.Size = new System.Drawing.Size(462, 87);
            this.ShowDeclarations.TabIndex = 1;
            this.ShowDeclarations.Text = "Просмотреть заявки";
            this.ShowDeclarations.UseVisualStyleBackColor = true;
            this.ShowDeclarations.Click += new System.EventHandler(this.ShowDeclarations_Click);
            // 
            // QuickReport
            // 
            this.QuickReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuickReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuickReport.Location = new System.Drawing.Point(23, 209);
            this.QuickReport.Name = "QuickReport";
            this.QuickReport.Size = new System.Drawing.Size(462, 87);
            this.QuickReport.TabIndex = 2;
            this.QuickReport.Text = "Быстро сформировать";
            this.QuickReport.UseVisualStyleBackColor = true;
            this.QuickReport.Click += new System.EventHandler(this.button3_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(508, 320);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button NewDeclaration;
        private System.Windows.Forms.Button ShowDeclarations;
        private System.Windows.Forms.Button QuickReport;
    }
}