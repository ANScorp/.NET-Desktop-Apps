using System;
using System.Collections.Generic;
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

using System.IO;
using System.Windows.Forms;
using System.Threading;
using System.Xml.Linq;

namespace SYMonitor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string folderToMonitor;
        private string destinationFolder;
        private TaskScheduler uiTaskScheduler;
        private FileSystemWatcher fsw;
        private NotifyIcon ni;
        private DialogResult resultFoldertoMonitor;
        private DialogResult resultDestinationFolder;

        public MainWindow()
        {
            InitializeComponent();

            ni = new System.Windows.Forms.NotifyIcon();
            ni.Icon = new System.Drawing.Icon("Main.ico");
            ni.Visible = true;
            ni.DoubleClick +=
                delegate(object sernder, EventArgs args)
                {
                    this.Show();
                    this.WindowState = WindowState.Normal;
                };

            btnStart.IsEnabled = false;
            btnStop.IsEnabled = false;

            btnSelectFolderToMonitor.AllowDrop = true;
            btnSelectDestinationFolder.AllowDrop = true;

            btnSelectFolderToMonitor.DragOver += btnDragOver;
            btnSelectFolderToMonitor.Drop += BtnSelectFolderToMonitor_Drop;

            btnSelectDestinationFolder.DragOver += btnDragOver;
            btnSelectDestinationFolder.Drop += BtnSelectDestinationFolder_Drop;

            //var settingsFile = Directory.GetFiles(Directory.GetCurrentDirectory()).Where(name => name == "settings.xml");

            if (File.Exists("settings.xml"))
            {
                XElement settings = XElement.Load("settings.xml");
                var settingsFolderToMonitor = (string)settings.Element("BaseFolder");
                var settingsDestinationFolder = (string)settings.Element("DestinationFolder");

                if (Directory.Exists(settingsFolderToMonitor) & Directory.Exists(settingsDestinationFolder))
                {
                    folderToMonitor = settingsFolderToMonitor;
                    destinationFolder = settingsDestinationFolder;
                    lbFolderToMonitor.Content = settingsFolderToMonitor;
                    lbFolderToCopy.Content = settingsDestinationFolder;
                    btnStart.IsEnabled = true;
                    this.WindowState = WindowState.Minimized;
                    btnStart.RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Primitives.ButtonBase.ClickEvent));
                }
                else
                    System.Windows.MessageBox.Show("Файл настроек отсутствует или содержит недопустимые параметры");
            }

        }

        private bool StoreSettings(string baseFolder, string destinationFolder)
        {

            if (Directory.Exists(baseFolder) & Directory.Exists(destinationFolder))
            {
                if (!File.Exists("settings.xml"))
                {
                    XDocument settings = new XDocument(
                        new XComment("SYMonitor settings begin"),
                        new XElement("settings",
                        new XElement("BaseFolder", baseFolder),
                        new XElement("DestinationFolder", destinationFolder)
                        )
                        );
                    settings.Save("settings.xml", SaveOptions.None);

                    return true;
                }
                else
                {
                    XElement settings = XElement.Load("settings.xml");
                    var settingsFolderToMonitor = (string)settings.Element("BaseFolder");
                    var settingsDestinationFolder = (string)settings.Element("DestinationFolder");


                    if ((settingsFolderToMonitor != baseFolder) || (settingsDestinationFolder != destinationFolder))
                    {
                        settings.SetElementValue("BaseFolder", baseFolder);
                        settings.SetElementValue("DestinationFolder", destinationFolder);

                        settings.Save("settings.xml", SaveOptions.None);

                        return true;
                    }
                    
                    return false;
                }
            }
            else
                return false;
            
        }

        private void BtnSelectDestinationFolder_Drop(object sender, System.Windows.DragEventArgs e)
        {
            var files = e.Data.GetData(System.Windows.DataFormats.FileDrop) as string[];

            if (files.Length == 1)
            {
                var isDir = (File.GetAttributes(files[0]) & FileAttributes.Directory) == FileAttributes.Directory;

                if (!isDir) System.Windows.MessageBox.Show("Данная операция запрещена. Выберете каталог.", "SYMonitor");
                else
                {
                    destinationFolder = files[0];
                    lbFolderToCopy.Content = destinationFolder;

                    //check to enable the Start
                    CheckSettingsToStart();
                }


            }
            else
                System.Windows.MessageBox.Show("Данная операция запрещена. Выберете каталог.", "SYMonitor");
        }


        private void BtnSelectFolderToMonitor_Drop(object sender, System.Windows.DragEventArgs e)
        {
            var files = e.Data.GetData(System.Windows.DataFormats.FileDrop) as string[];

            if (files.Length == 1)
            {
                var isDir = (File.GetAttributes(files[0]) & FileAttributes.Directory) == FileAttributes.Directory;

                if (!isDir) System.Windows.MessageBox.Show("Данная операция запрещена. Выберете каталог.", "SYMonitor");
                else
                {
                    folderToMonitor = files[0];
                    lbFolderToMonitor.Content = folderToMonitor;

                    //check to enable the Start
                    CheckSettingsToStart();
                }


            } else
                System.Windows.MessageBox.Show("Данная операция запрещена. Выберете каталог.", "SYMonitor");

        }

        private void btnDragOver(object sender, System.Windows.DragEventArgs e)
        {
            if (e.Data.GetDataPresent(System.Windows.DataFormats.FileDrop))
            {
                e.Effects = System.Windows.DragDropEffects.Copy;
            }
        }

        protected override void OnStateChanged(EventArgs e)
        {
            if (WindowState == System.Windows.WindowState.Minimized)
                this.Hide();

            base.OnStateChanged(e);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            uiTaskScheduler = TaskScheduler.FromCurrentSynchronizationContext();
        }

        void fsw_Changed(object sender, FileSystemEventArgs e)
        {
            //System.Windows.MessageBox.Show("File: " + e.FullPath + " " + e.ChangeType);

            bool isDir = (File.GetAttributes(e.FullPath) & FileAttributes.Directory) == FileAttributes.Directory;

            if (isDir) return;

            var targetFile = System.IO.Path.Combine(destinationFolder, System.IO.Path.GetFileName(e.FullPath));

            Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    try
                    {
                        File.Copy(e.FullPath, targetFile, true);
                        break;
                    }
                    catch (Exception ex)
                    {

                    }

                    Thread.Sleep(500);
                }
            }, CancellationToken.None, TaskCreationOptions.None, uiTaskScheduler).Wait();
        }

        private void btnSelectFolderToMonitor_Click(object sender, RoutedEventArgs e)
        {
            var folderToMonitorDialog = new FolderBrowserDialog();

            resultFoldertoMonitor = folderToMonitorDialog.ShowDialog();
            if (resultFoldertoMonitor == System.Windows.Forms.DialogResult.OK)
            {
                folderToMonitor = folderToMonitorDialog.SelectedPath;
                lbFolderToMonitor.Content = folderToMonitor;
            };

            CheckSettingsToStart();
        }

        private void btnSelectDestinationFolder_Click(object sender, RoutedEventArgs e)
        {
            var destinationFolderDialog = new FolderBrowserDialog();

            resultDestinationFolder = destinationFolderDialog.ShowDialog();
            if (resultDestinationFolder == System.Windows.Forms.DialogResult.OK)
            {
                destinationFolder = destinationFolderDialog.SelectedPath;
                lbFolderToCopy.Content = destinationFolder;
            };

            CheckSettingsToStart();
        }

        private void CheckSettingsToStart()
        {
            if ((resultDestinationFolder & resultFoldertoMonitor) == System.Windows.Forms.DialogResult.OK)
            {
                btnStart.IsEnabled = true;
            }
            else
            if (folderToMonitor != null & destinationFolder != null)
            {
                btnStart.IsEnabled = true;
            }
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                FileCopy(folderToMonitor, destinationFolder);
            }, CancellationToken.None, TaskCreationOptions.LongRunning, TaskScheduler.Default);

            MainW.Title = "SYMonitor: " + folderToMonitor;

            PermanentMonitoring(folderToMonitor, destinationFolder);
            StoreSettings(folderToMonitor, destinationFolder);

            btnStart.IsEnabled = false;
            btnStop.IsEnabled = true;

            btnSelectFolderToMonitor.IsEnabled = false;
            btnSelectDestinationFolder.IsEnabled = false;

        }

        private void FileCopy(string sourceFolder, string destinationFolder)
        {
            int filesCounter = 0;

            //MainW.Title = "Копирование файлов из " + sourceFolder;

            foreach (var file in Directory.GetFiles(sourceFolder, "*.sym"))
            {
                var targetFile = System.IO.Path.Combine(destinationFolder, System.IO.Path.GetFileName(file));

                FileInfo infoSourceFile = new FileInfo(file);

                if (!File.Exists(targetFile))
                {
                    File.Copy(file, targetFile);
                    filesCounter++;
                }
                else
                {
                    FileInfo infoTargetFile = new FileInfo(targetFile);

                    if (infoSourceFile.LastWriteTime > infoTargetFile.LastWriteTime)
                    {
                        File.Copy(file, targetFile, true);
                        filesCounter++;
                    }
                }
            }

            System.Windows.MessageBox.Show("Скопированно новых файлов: " + filesCounter.ToString() + ".", "SYMonitor", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Information, System.Windows.MessageBoxResult.OK);
        }

        private void PermanentMonitoring(string sourceFolder, string destinationFolder)
        {
            fsw = new FileSystemWatcher(sourceFolder);

            fsw.IncludeSubdirectories = false;
            fsw.NotifyFilter = NotifyFilters.FileName | NotifyFilters.LastWrite;
            fsw.Filter = "*.sym";

            fsw.Changed += new FileSystemEventHandler(fsw_Changed);

            fsw.EnableRaisingEvents = true;
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            fsw.EnableRaisingEvents = false;
            MainW.Title = "SYMonitor";

            btnStop.IsEnabled = false;
            btnStart.IsEnabled = true;

            btnSelectFolderToMonitor.IsEnabled = true;
            btnSelectDestinationFolder.IsEnabled = true;
        }

        private void MainW_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ni.Visible = false;
            ni.Dispose();
        }
    }
}
