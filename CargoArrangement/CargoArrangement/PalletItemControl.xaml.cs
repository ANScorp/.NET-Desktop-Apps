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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CargoArrangement
{
    /// <summary>
    /// Interaction logic for PalletItemControl.xaml
    /// </summary>
    public partial class PalletItemControl : UserControl
    {
        static int counter = 0;
        public PalletItemControl()
        {
            InitializeComponent();
            this.Name += counter.ToString();
            counter++;

            PalletName.MouseDoubleClick += PalletName_MouseDoubleClick;
            OrderNumber.MouseDoubleClick += OrderNumber_MouseDoubleClick;
        }

        void OrderNumber_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            editOrderNumber = new TextBox()
            {
                HorizontalContentAlignment = HorizontalAlignment.Center,
                VerticalContentAlignment = VerticalAlignment.Center,
                FontSize = 32,
                Background = PalletColor,
                BorderBrush = Brushes.Transparent,
                BorderThickness = new Thickness(1, 0, 1, 0),
                Text = OrderNumber.Content.ToString()
            };

            vbOrderNumber = new Viewbox()
            {
                Stretch = Stretch.Uniform
            };

            OrderNumber.Content = "";

            Grid.SetRow(vbOrderNumber, 1);

            Grid.SetRow(editOrderNumber, 1);

            pallet.Children.Add(vbOrderNumber);
            vbOrderNumber.Child = editOrderNumber;

            editOrderNumber.Focus();
            editOrderNumber.SelectAll();

            editOrderNumber.KeyDown += new KeyEventHandler(editOrderNumber_KeyDown);
        }

        private void editOrderNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                OrderNumberText = editOrderNumber.Text;
                pallet.Children.Remove(vbOrderNumber);
            }
        }

        private void PalletName_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            editPalletName = new TextBox()
            {
                HorizontalContentAlignment = HorizontalAlignment.Center,
                VerticalContentAlignment = VerticalAlignment.Center,
                FontSize = 32,
                Background = PalletColor,
                BorderBrush = Brushes.Transparent,
                BorderThickness = new Thickness(1, 0, 1, 0),
                Text = PalletName.Content.ToString()
            };

            vbPalletName = new Viewbox()
            {
                Stretch = Stretch.Uniform
            };

            PalletName.Content = "";

            Grid.SetRow(vbPalletName, 3);

            Grid.SetRow(editPalletName, 3);

            pallet.Children.Add(vbPalletName);
            vbPalletName.Child = editPalletName;

            editPalletName.Focus();
            editPalletName.SelectAll();

            editPalletName.KeyDown += new KeyEventHandler(editPalletName_KeyDown);
        }

        private void editPalletName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                PalletNameText = editPalletName.Text;
                pallet.Children.Remove(vbPalletName);
            }
        }

        public string OrderNumberText
        {
            get { return this.OrderNumber.Content.ToString(); }
            set { this.OrderNumber.Content = value; }
        }

        public Brush PalletColor
        {
            get { return this.PalletBox.Fill; }
            set { this.PalletBox.Fill = value; }
        }

        public Brush Stroke
        {
            get { return (Brush)this.PalletBox.Stroke; }
            set { this.PalletBox.Stroke = value; }
        }

        public string PalletNameText
        {
            get { return this.PalletName.Content.ToString(); }
            set { this.PalletName.Content = value; }
        }

        public string PalletCountText
        {
            get { return this.PalletCount.Content.ToString(); }
            set { this.PalletCount.Content = value;}
        }

        static private TextBox editPalletCount;
        static private TextBox editPalletName;
        static private TextBox editOrderNumber;

        private Viewbox vbPalletCount;
        private Viewbox vbPalletName;
        private Viewbox vbOrderNumber;

        private void PalletCount_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            editPalletCount = new TextBox()
            {
                HorizontalContentAlignment = HorizontalAlignment.Center,
                VerticalContentAlignment = VerticalAlignment.Center,
                FontSize = 32,
                Background = PalletColor,
                BorderBrush = Brushes.Transparent,
                BorderThickness = new Thickness(1, 0, 1, 0),
                Text = PalletCount.Content.ToString()
            };

            vbPalletCount = new Viewbox()
            {
                Stretch = Stretch.Uniform
            };

            PalletCount.Content = "";

            Grid.SetRow(vbPalletCount, 5);

            Grid.SetRow(editPalletCount, 5);

            pallet.Children.Add(vbPalletCount);
            vbPalletCount.Child = editPalletCount;

            editPalletCount.Focus();
            editPalletCount.SelectAll();

            editPalletCount.KeyDown += new KeyEventHandler(editPalletCount_KeyDown);

        }

        private void editPalletCount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                PalletCountText = editPalletCount.Text;
                pallet.Children.Remove(vbPalletCount);
            }
        }

    }
}
