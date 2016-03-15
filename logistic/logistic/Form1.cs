using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logistic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            authPerson.SelectedIndex = 0;
            contractNumber.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string folderName = folderBrowserDialog1.SelectedPath;

                //ThreadStart t = delegate { new Declaration(this).CreatePackage(@folderName + @"\Заява_ТПП_" + DateTime.Now.ToString("dd-MM-yyyy-H-mm-ss") + ".docx"); };
                //Thread newThread = new Thread(t);
                //newThread.Start();

                var uiTaskScheduler = TaskScheduler.FromCurrentSynchronizationContext();

                Task taskA = Task.Factory.StartNew(() =>
                {
                    new Declaration(this).CreatePackage(@folderName + @"\Заява_ТПП_" + DateTime.Now.ToString("dd-MM-yyyy-H-mm-ss") + ".docx");
                }, CancellationToken.None, TaskCreationOptions.None, uiTaskScheduler);

                Task taskB = Task.Factory.StartNew(() =>
                {
                    new Supplement(this).CreatePackage(@folderName + @"\Приложение_" + supplementNumber.Text + "_" + DateTime.Now.ToString("dd-MM-yyyy-H-mm-ss") + ".docx");
                }, CancellationToken.None, TaskCreationOptions.None, uiTaskScheduler);

                Task taskC = Task.Factory.StartNew(() =>
                {
                    new ProductReference(this).CreatePackage(@folderName + @"\ПС_ТПП_" + contractNumber.Text + "_" + DateTime.Now.ToString("dd-MM-yyyy-H-mm-ss") + ".docx");
                }, CancellationToken.None, TaskCreationOptions.None, uiTaskScheduler);

                Task taskD = Task.Factory.StartNew(() =>
                {
                    new Invoice(this).CreatePackage(@folderName + @"\СФ_" + contractNumber.Text + "_" + DateTime.Now.ToString("dd-MM-yyyy-H-mm-ss") + ".docx");
                }, CancellationToken.None, TaskCreationOptions.None, uiTaskScheduler);

                Task taskE = Task.Factory.StartNew(() =>
                {
                    new PackingList(this).CreatePackage(@folderName + @"\Упаковочный_Лист_" + contractNumber.Text + "_" + DateTime.Now.ToString("dd-MM-yyyy-H-mm-ss") + ".xlsx");
                }, CancellationToken.None, TaskCreationOptions.None, uiTaskScheduler);

                
                Process.Start(@folderName);

            }
        }
    }
}
