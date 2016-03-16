using CargoArrangement.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;

namespace CargoArrangement
{
    /// <summary>
    /// Interaction logic for ReportWindow.xaml
    /// </summary>
    public partial class ReportWindow : Window
    {
        private ObservableCollection<PalletItem> list;
        private MainWindow _mainWindow;
        private ObservableCollection<PalletItem> _palletList = new ObservableCollection<PalletItem>();

        public ReportWindow()
        {
            InitializeComponent();
        }

        public ReportWindow(ObservableCollection<PalletItem> list)
        {
            this._palletList = list;
            this.DataContext = this;
            ShippingDate = DateTime.Now.ToShortDateString();

            InitializeComponent();
        }

        public ReportWindow(MainWindow mainWindow)
        {
            this._mainWindow = mainWindow;
            _palletList = _mainWindow.PalletItems;
            this.DataContext = this;
            System.Diagnostics.Debug.WriteLine(palletList);

            InitializeComponent();
        }

        public ObservableCollection<PalletItem> palletList
        {
            get
            {
                return _palletList;
            }

            set
            {
                _palletList = value;
            }
        }

        public string ShippingDate { get; private set; }
    }
}
