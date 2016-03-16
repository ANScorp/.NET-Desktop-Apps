using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;

namespace FileChecker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string folderToCheck = @"\\Srv-konstr\dxf";

        public MainWindow()
        {
            InitializeComponent();

            btnStart.IsEnabled = true;
            btnFolderToCheck.IsEnabled = true;

            btnFolderToCheck.Click += btnFolderToCheck_Click;


            btnStart.Click += btnStart_Click;

        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            fileCheck();
        }

        private void fileCheck()
        {
            int missingFilesCounter = 0;
            var codesToCheck = GetList();

            foreach (var line in codesToCheck)
            {
                DirectoryInfo di = new DirectoryInfo(folderToCheck);
                bool exist = di.EnumerateFiles(line + "*.dxf").Any();
                if (!exist)
                {
                    rtbMissing.AppendText(line + "\n");
                    missingFilesCounter++;
                }
            }

            System.Windows.MessageBox.Show("Поиск успешно завершон. Отсутсвует файлов: " + missingFilesCounter.ToString());

        }

        private List<string> GetList()
        {
            string txt = new TextRange(rtbCodes.Document.ContentStart, rtbCodes.Document.ContentEnd).Text;
            List<string> codesToCheck = new List<string>();

            foreach (string line in txt.Split(new string[] { "\r\n", "\n"}, StringSplitOptions.None))
            {
                codesToCheck.Add(line);
            }

            return codesToCheck;

        }

        private void btnFolderToCheck_Click(object sender, RoutedEventArgs e)
        {
            var folderToCheckDialog = new FolderBrowserDialog();

            var resultFoldertoCheck = folderToCheckDialog.ShowDialog();
            if (resultFoldertoCheck == System.Windows.Forms.DialogResult.OK)
            {
                folderToCheck = @folderToCheckDialog.SelectedPath;
                btnStart.IsEnabled = true;
            };

        }

        
    }
}
