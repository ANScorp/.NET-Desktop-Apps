using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Xps.Packaging;
using Microsoft.Win32;
using System.Windows.Markup;
using System.Xml;
using System.Xml.Linq;
using System.Windows.Xps.Serialization;
using CargoArrangement.Models;
using System.Windows.Threading;
using System.Collections;
using System.Runtime.InteropServices;

namespace CargoArrangement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool captured = false;
        private double x_shape, x_canvas, y_shape, y_canvas;

        UIElement source = null;
        private BoxAdorner _overlayElement;

        public ObservableCollection<PalletItem> PalletItems = new ObservableCollection<PalletItem>();
        static int id = 0;
        private int addedRowIndex;
        private Point _startPoint;
        private bool _isDragging;
        private double sourceLeft;
        private double sourceTop;
        private Canvas canvas;

        public MainWindow()
        {
            InitializeComponent();

            dgvPallets.ItemsSource = PalletItems;
            dgvPallets.DataContext = PalletItems;
            dgvPallets.CanUserAddRows = false;
            dgvPallets.CanUserSortColumns = true;

            dgvPallets.ColumnWidth = DataGridLength.Auto;

            dgvPallets.AutoGeneratingColumn += dgvPallets_AutoGeneratingCollumn;
            dgvPallets.InitializingNewItem += dgvPallet_RowAdded;
            dgvPallets.SelectionMode = DataGridSelectionMode.Single;
            dgvPallets.SelectionUnit = DataGridSelectionUnit.FullRow;

            //dgvPallets.IsSynchronizedWithCurrentItem = true;

            //canvas.PreviewMouseMove += new MouseEventHandler(Canvas_PreviewMouseMove);
            //canvas.PreviewMouseLeftButtonDown += new MouseButtonEventHandler(Canvas_PreviewMouseLeftButtonDown);
            //canvas.PreviewMouseLeftButtonUp += new MouseButtonEventHandler(Canvas_PreviewMouaeLeftButtonUp);

            //this.PreviewKeyDown += new KeyEventHandler(Canvas_PreviewKeyDown);

            //canvas.RenderTransform = new ScaleTransform();

            //canvas.MouseWheel += (sender, e) =>
            //{
            //    double scaleRate = 1.1;
            //    var mycanvas = (Canvas)sender;
            //    var scaleTransform = (ScaleTransform)mycanvas.RenderTransform;

            //    if (e.Delta > 0)
            //    {
            //        scaleTransform.ScaleX *= scaleRate;
            //        scaleTransform.ScaleY *= scaleRate;
            //        scrollViewer.Width *= scaleRate;
            //        scrollViewer.Height *= scaleRate;

            //    }
            //    else
            //    {
            //        scaleTransform.ScaleX /= scaleRate;
            //        scaleTransform.ScaleY /= scaleRate;
            //        scrollViewer.Width /= scaleRate;
            //        scrollViewer.Height /= scaleRate;
            //    }

            //    mycanvas.LayoutTransform = scaleTransform;
            //    mycanvas.UpdateLayout();
            //};

            //cbSortCriteria.ItemsSource = Enum.GetValues(typeof(SortCriteria)).Cast<SortCriteria>();
            canvas = CreateNewCanvas("canvas0");

            btnClearCanvas.Click += btnClearCanvas_Click;
                //{
                //    var childrenToRemove = myStackPanel.Children.OfType<Border>();
                    
                //    foreach (var child in childrenToRemove)
                //    {
                //        myStackPanel.Children.Remove(child);
                //    }

                //    canvas = CreateNewCanvas("canvas0");
                //};
        }

        [DllImport("User32.dll")]
        private static extern bool SetCursorPos(int x, int y);

        private void btnClearCanvas_Click(object sender, RoutedEventArgs e)
        {
            List<Border> childrenToRemove = myStackPanel.Children.OfType<Border>().ToList();

            var canvasList = GetCollection<Canvas>(myStackPanel);

            foreach (var item in canvasList)
            {
                NameScope.GetNameScope(this).UnregisterName(item.Name);
            }

            for (var i = 0; i < childrenToRemove.Count(); i++)
            {
                myStackPanel.Children.Remove(childrenToRemove[i]);
            }


            canvas = CreateNewCanvas("canvas0");
        }

       

        private void shape_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (captured)
            {
                DragFinished(false);
                e.Handled = true;
            }
            Mouse.Capture(null);
            captured = false;
        }

        private void DragFinished(bool canceled)
        {
            Mouse.Capture(null);

            if (_isDragging)
            {
                AdornerLayer.GetAdornerLayer(_overlayElement.AdornedElement).Remove(_overlayElement);

                if (!canceled)
                {
                    Canvas.SetTop(source, sourceTop + _overlayElement.TopOffset);
                    Canvas.SetLeft(source, sourceLeft + _overlayElement.LeftOffset);
                }
                _overlayElement = null;
            }

            _isDragging = false;
            captured = false;
        }      

 
        private void shape_MouseMove(object sender, MouseEventArgs e)
        {
            if (captured)
            {
                double x = e.GetPosition(canvas).X;
                double y = e.GetPosition(canvas).Y;

                if ((_isDragging == false) && ((Math.Abs(x - _startPoint.X) > SystemParameters.MinimumHorizontalDragDistance) ||
                    (Math.Abs(y - _startPoint.Y) > SystemParameters.MinimumVerticalDragDistance)))
                {
                    DragStarted();
                }
                if (_isDragging)
                {
                    DragMoved();

                }

                //if ((y_canvas + _overlayElement.Height > canvas.Height) || (x_canvas + _overlayElement.Width > canvas.Width) || (y_canvas < 0) || (x_canvas < 0))
                //{
                //    return;
                //}

                //if ((y_shape + y <= 0) || (x_shape + x <= 0))
                //{
                //    return;
                //}

                //if ((y_canvas + _overlayElement.ActualHeight > canvas.ActualHeight) || (x_canvas + _overlayElement.ActualWidth > canvas.ActualWidth) || (y_canvas < 0) || (x_canvas < 0))
                //{
                //    return;
                //}

                //DragStarted();
                //x_shape += x - x_canvas;
                //Canvas.SetLeft(source, x_shape);
                //x_canvas = x;
                //y_shape += y - y_canvas;
                //Canvas.SetTop(source, y_shape);
                //y_canvas = y;
                System.Diagnostics.Debug.WriteLine("MouseMove executed again.");
            }
        }

        private void DragMoved()
        {
            Point currentPosition = Mouse.GetPosition(canvas);

            CheckSnapping(currentPosition);

            //_overlayElement.LeftOffset = currentPosition.X - _startPoint.X;
            //_overlayElement.TopOffset = currentPosition.Y - _startPoint.Y;
        }

        private void CheckSnapping(Point currentPosition)
        {
            IEnumerable<PalletItemControl> boxes = canvas.Children.OfType<PalletItemControl>();

            var boxPointsList = new List<Point>();
            var adornerPointList = new List<Point>();
            double adornerTop = 0, adornerLeft = 0, adornerBottom = 0, adornerRight = 0;

            var X_overlay = sourceLeft + _overlayElement.LeftOffset;
            var Y_overlay = sourceTop + _overlayElement.TopOffset;
            System.Diagnostics.Debug.WriteLine("X adorner element: " + X_overlay.ToString() + " Y adorner element: " + Y_overlay.ToString());

            foreach (var box in boxes)
            {
                if (box.Tag == (source as PalletItemControl).Tag)
                {
                    continue;
                }

                var boxTop = Canvas.GetTop(box);
                var boxLeft = Canvas.GetLeft(box);
                var boxBottom = Canvas.GetBottom(box);
                var boxRight = Canvas.GetRight(box);

                var boxTopLeft = new Point(boxLeft, boxTop);
                var boxTopRight = new Point(boxRight, boxTop);
                var boxBottomLeft = new Point(boxLeft, boxBottom);
                var boxBottomRight = new Point(boxRight, boxBottom);

                boxPointsList.Add(boxTopLeft);
                boxPointsList.Add(boxTopRight);
                boxPointsList.Add(boxBottomLeft);
                boxPointsList.Add(boxBottomRight);
               
            }

            adornerTop = sourceTop + _overlayElement.TopOffset;
            adornerLeft = sourceLeft + _overlayElement.LeftOffset;
            adornerBottom = adornerTop + _overlayElement.Height;
            adornerRight = adornerLeft + _overlayElement.Width;

            var adornerTopLeft = new Point(adornerLeft, adornerTop);
            var adornerTopRight = new Point(adornerRight, adornerTop);
            var adornerBottomLeft = new Point(adornerLeft, adornerBottom);
            var adornerBottomRight = new Point(adornerRight, adornerBottom);

            adornerPointList.Add(adornerTopLeft);
            adornerPointList.Add(adornerTopRight);
            adornerPointList.Add(adornerBottomLeft);
            adornerPointList.Add(adornerBottomRight);

            foreach (var boxPoint in boxPointsList)
            {
                //var distance = Math.Sqrt(Math.Pow(item.X - boxPoint.X, 2) + Math.Pow(item.Y - boxPoint.Y, 2));

                var distanceToUpperLeftCorner = Math.Sqrt(Math.Pow(adornerLeft - boxPoint.X, 2) + Math.Pow(adornerTop - boxPoint.Y, 2));
                var distanceToUpperRightCorner = Math.Sqrt(Math.Pow(adornerRight - boxPoint.X, 2) + Math.Pow(adornerTop - boxPoint.Y, 2));
                var distanceToBottomLeftCorner = Math.Sqrt(Math.Pow(adornerLeft - boxPoint.X, 2) + Math.Pow(adornerBottom - boxPoint.Y, 2));
                var distanceToBottomRightCorner = Math.Sqrt(Math.Pow(adornerRight - boxPoint.X, 2) + Math.Pow(adornerBottom - boxPoint.Y, 2));

                if (distanceToUpperLeftCorner < 100)
                {
                    //currentPosition.X = boxPoint.X;
                    //currentPosition.Y = boxPoint.Y;

                    _overlayElement.LeftOffset = boxPoint.X - _startPoint.X;
                    _overlayElement.TopOffset = boxPoint.Y - _startPoint.Y;

                    //Point rel = (VisualTreeHelper.GetParent(source) as Canvas).TranslatePoint(new Point(boxPoint.X, boxPoint.Y), mainWindow);
                    //SetCursorPos((int)mainWindow.Left + (int)(boxPoint.X - _startPoint.X), (int)mainWindow.Top + (int)(boxPoint.Y - _startPoint.Y));

                    Point rel = source.PointToScreen(new Point((int)_overlayElement.LeftOffset, (int)_overlayElement.TopOffset));

                    SetCursorPos((int)rel.X, (int)rel.Y);

                    

                    System.Diagnostics.Debug.WriteLine("X: " + currentPosition.X.ToString() + " Y: " + currentPosition.Y.ToString());
                    break;

                }
                else if (distanceToUpperRightCorner < 100)
                {
                    _overlayElement.LeftOffset = boxPoint.X - _startPoint.X;
                    _overlayElement.TopOffset = boxPoint.Y - _startPoint.Y;
                    break;

                }
                else if (distanceToBottomLeftCorner < 100)
                {
                    _overlayElement.LeftOffset = boxPoint.X - _startPoint.X;
                    _overlayElement.TopOffset = boxPoint.Y - _startPoint.Y;
                    break;

                }
                else if (distanceToBottomRightCorner < 100)
                {
                    _overlayElement.LeftOffset = boxPoint.X - _startPoint.X;
                    _overlayElement.TopOffset = boxPoint.Y - _startPoint.Y;
                    break;

                }
                else
                {
                    _overlayElement.LeftOffset = currentPosition.X - _startPoint.X;
                    _overlayElement.TopOffset = currentPosition.Y - _startPoint.Y;
                    //return;
                }

            }


        }

        private void DragStarted()
        {
            _isDragging = true;
            sourceLeft = Canvas.GetLeft(source);
            sourceTop = Canvas.GetTop(source);

            _overlayElement = new BoxAdorner(source);
            AdornerLayer layer = AdornerLayer.GetAdornerLayer(source);
            layer.Add(_overlayElement);

            //source.Visibility = Visibility.Hidden;
        }

        private void shape_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            source = (UIElement)sender;
            if (Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl) ||
                Keyboard.IsKeyDown(Key.LeftAlt) || Keyboard.IsKeyDown(Key.RightAlt))
            {
                return;
            }

            Mouse.Capture(source);

            captured = true;

            canvas = VisualTreeHelper.GetParent(source) as Canvas;
            _startPoint = e.GetPosition(canvas);
            e.Handled = true;

            x_shape = Canvas.GetLeft(source);
            x_canvas = e.GetPosition(canvas).X;
            y_shape = Canvas.GetTop(source);
            y_canvas = e.GetPosition(canvas).Y;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            PalletItems.Add(new PalletItem() { ID = ++id, OrderNumber = orderNumber.Text, ClientName = clientName.Text, PartName = partName.Text, Width = Convert.ToInt32(width.Text), Depth = Convert.ToInt32(height.Text), Quantity = Convert.ToInt32(quantity.Text), Color = (Color)color.SelectedColor, PackageType = package.SelectedIndex });
        }

        private void dgvPallet_RowAdded(object sender, InitializingNewItemEventArgs e)
        {
            addedRowIndex = dgvPallets.Items.Count - 1;
            dgvPallets.SelectedIndex = addedRowIndex;
        }


        public static readonly DependencyProperty CellTemplateSelectorProperty =
        DependencyProperty.Register("Selector", typeof(PropertyDataTemplateSelector), typeof(DataGrid),
        new FrameworkPropertyMetadata(null));

        private void dgvPallets_AutoGeneratingCollumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            e.Column.Width = new DataGridLength(1, DataGridLengthUnitType.Star);

            switch (e.PropertyName)
            {
                case "OrderNumber":
                    e.Column.Header = "Номер заказа";
                    break;

                case "ClientName":
                    e.Column.Header = "Клиент";
                    break;

                case "PartName":
                    e.Column.Header = "Наименование";
                    break;

                case "Depth":
                    e.Column.Header = "Глубина";
                    DataGridTemplateColumn templateDepthColumn = new DataGridTemplateColumn();
                    templateDepthColumn.Header = e.Column.Header;
                    templateDepthColumn.CellTemplate = (DataTemplate)Resources["DepthDataTemplate"];
                    e.Column = templateDepthColumn;
                    break;

                case "Width":
                    e.Column.Header = "Ширина";
                    DataGridTemplateColumn templateWidthColumn = new DataGridTemplateColumn();
                    templateWidthColumn.Header = e.Column.Header;
                    templateWidthColumn.CellTemplate = (DataTemplate)Resources["WidthDataTemplate"];
                    e.Column = templateWidthColumn;
                    break;

                case "Quantity":
                    e.Column.Header = "Количество";
                    DataGridTemplateColumn templateQunatityColumn = new DataGridTemplateColumn();
                    templateQunatityColumn.Header = e.Column.Header;
                    templateQunatityColumn.CellTemplate = (DataTemplate)Resources["NumberDataTemplate"];
                    e.Column = templateQunatityColumn;
                    break;

                case "Color":
                    e.Column.Header = "Цвет";
                    DataGridTemplateColumn templateColumn = new DataGridTemplateColumn();
                    templateColumn.Header = e.Column.Header;
                    templateColumn.CellTemplate = (DataTemplate)Resources["ColorDataTemplate"];
                    templateColumn.CellEditingTemplate = (DataTemplate)Resources["ColorDataTemplate"];
                    e.Column = templateColumn;
                    break;

                case "PackageType":
                    e.Column.Header = "Упаковка";
                    DataGridTemplateColumn templatePackageColumn = new DataGridTemplateColumn();
                    templatePackageColumn.Header = e.Column.Header;
                    templatePackageColumn.CellTemplate = (DataTemplate)Resources["PackageDataTemplate"];
                    e.Column = templatePackageColumn;
                    break;

                case "PlacesNumber":
                    e.Cancel = true;
                    break;
            }

            dgvPallets.SelectedIndex = 0;
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            var itemToRemove = (PalletItem)dgvPallets.SelectedItem;
            PalletItems.Remove(itemToRemove);
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            var id = 0;
            canvas.Children.Clear();
            ObservableCollection<PalletItem> boxes;
            var selectedSortMethod = cbSortCriteria.SelectedIndex;

            var newContainer = new Packer(Convert.ToInt32(canvas.Width), Convert.ToInt32(canvas.Height));
            boxes = newContainer.Fit(PalletItems, (SortCriteria)selectedSortMethod);

            for (var n = 0; n < boxes.Count; n++)
            {
                var palletItem = boxes[n];

                if (boxes[n].Fit != null)
                {

                    var rect = new PalletItemControl()
                    {
                        Stroke = Brushes.Black,
                        PalletColor = new SolidColorBrush(boxes[n].Color),
                        Width = Convert.ToDouble(boxes[n].Width),
                        Height = Convert.ToDouble(boxes[n].Depth),
                        OrderNumberText = boxes[n].OrderNumber,
                        PalletNameText = boxes[n].PartName,
                        PalletCountText = boxes[n].Quantity.ToString(),
                    };

                    //Canvas.SetZIndex(rect, 13);
                    Canvas.SetLeft(rect, boxes[n].Fit.X);
                    Canvas.SetTop(rect, boxes[n].Fit.Y);
                    rect.Tag = id++;

                    var containerNumber = "canvas" + boxes[n].Fit.ContainerNumber.ToString();

                    if ((Canvas)myStackPanel.FindName(containerNumber) == null)
                    {
                        ///Here create new canvas if necessary
                        //CreateNewCanvas(containerNumber);

                        Canvas newCanvas = new Canvas();
                        newCanvas.Name = containerNumber;
                        RegisterName(containerNumber, newCanvas);
                        newCanvas.Background = new SolidColorBrush(Colors.White);
                        newCanvas.Width = 2400;
                        newCanvas.Height = 13600;
                        newCanvas.SnapsToDevicePixels = true;
                        newCanvas.UseLayoutRounding = true;
                        newCanvas.HorizontalAlignment = HorizontalAlignment.Center;
                        newCanvas.VerticalAlignment = VerticalAlignment.Center;

                        Border border = new Border();
                        border.BorderBrush = new SolidColorBrush(Colors.Black);
                        border.BorderThickness = new Thickness(10);
                        border.Child = newCanvas;

                        myStackPanel.Children.Add(border);
                        System.Diagnostics.Debug.WriteLine("New canvas is created");
                        System.Diagnostics.Debug.WriteLine(containerNumber.ToString());


                    }

                    var canvasDestination = myStackPanel.FindName(containerNumber) as Canvas;

                    canvasDestination.Children.Add(rect);

                    //canvas.Children.Add(rect);

                    rect.MouseLeftButtonDown += new MouseButtonEventHandler(shape_MouseLeftButtonDown);
                    rect.MouseMove += new MouseEventHandler(shape_MouseMove);
                    rect.MouseLeftButtonUp += new MouseButtonEventHandler(shape_MouseLeftButtonUp);
                }
            }

        }

        private Canvas CreateNewCanvas(string containerNumber)
        {
            Canvas newCanvas = new Canvas();
            newCanvas.Name = containerNumber;
            RegisterName(containerNumber, newCanvas);
            newCanvas.Background = new SolidColorBrush(Colors.White);
            newCanvas.Width = 2400;
            newCanvas.Height = 13600;
            newCanvas.SnapsToDevicePixels = true;
            newCanvas.UseLayoutRounding = true;
            newCanvas.HorizontalAlignment = HorizontalAlignment.Center;
            newCanvas.VerticalAlignment = VerticalAlignment.Center;

            Border border = new Border();
            border.BorderBrush = new SolidColorBrush(Colors.Black);
            border.BorderThickness = new Thickness(10);
            border.Child = newCanvas;

            myStackPanel.Children.Add(border);

            return newCanvas;
        }

        private void btnAddShape_Click(object sender, RoutedEventArgs e)
        {
            if (dgvPallets.SelectedItems.Count == 0)
            {
                return;
            }

            PalletItem item = (PalletItem)dgvPallets.SelectedItem;

            var rect = new PalletItemControl()
            {
                Stroke = Brushes.Black,
                PalletColor = new SolidColorBrush(item.Color),
                Width = Convert.ToDouble(item.Width),
                Height = Convert.ToDouble(item.Depth),
                PalletNameText = item.PartName,
                PalletCountText = 2.ToString()
            };

            Canvas.SetLeft(rect, 100);
            double canvasTop = 0.0;
            if (canvas.Children.Count > 0)
            {
                var lastChildIndex = canvas.Children.Count - 1;
                var lastChild = canvas.Children[lastChildIndex] as FrameworkElement;
                if (lastChild != null)
                    canvasTop = Canvas.GetTop(lastChild) + lastChild.Height + 1;
            }
            Canvas.SetTop(rect, canvasTop);
            rect.Tag = id++;
            canvas.Children.Add(rect);
            rect.MouseLeftButtonDown += new MouseButtonEventHandler(shape_MouseLeftButtonDown);
            rect.MouseMove += new MouseEventHandler(shape_MouseMove);
            rect.MouseLeftButtonUp += new MouseButtonEventHandler(shape_MouseLeftButtonUp);
        }

        private void btnSaveReportClick(object sender, RoutedEventArgs e)
        {
            //Canvas can = CloneUsingXaml(canvas) as Canvas;
            //can.Name = null;

            IEnumerable<Canvas> canvasList = GetCollection<Canvas>(myStackPanel);
            List<Canvas> clonedCanvasXaml = new List<Canvas>();


            foreach (var canvas in canvasList)
            {
                Canvas cloned = CloneUsingXaml(canvas) as Canvas;
                cloned.Name = null;
                clonedCanvasXaml.Add(cloned);
            }

            System.Diagnostics.Debug.WriteLine("Cloned canvas count: " + clonedCanvasXaml.Count());
            System.Diagnostics.Debug.WriteLine("Canvas0: " + clonedCanvasXaml[0].Width.ToString());

            //myStackPanel.Children.Add(can);
            var myList = MakeAItemsLists();

            System.Diagnostics.Debug.WriteLine("myList count: " + myList.Count.ToString());

            //SaveFileDialog dialog = new SaveFileDialog();
            //dialog.FileName = "Схема_" + DateTime.Now.ToShortDateString();
            //dialog.Filter = "Pdf files (.pdf)|*.pdf";
            //var dialogResult = dialog.ShowDialog();
            //if (dialogResult == true)
            //{
            //    //ExportToPdf(myList[0], clonedCanvasXaml[0], @dialog.FileName);

            //    var i = 0;
            //    foreach (var item in myList)
            //    {
            //        ExportToPdf(item, clonedCanvasXaml[i], @dialog.FileName + i.ToString());
            //        i++;
            //    }
            //    //new ExportToPdf().CreateDocument(canvas, @dialog.FileName);
            //}

            System.Windows.Forms.FolderBrowserDialog dialog = new System.Windows.Forms.FolderBrowserDialog();
            var dialogResult = dialog.ShowDialog();
            if (dialogResult == System.Windows.Forms.DialogResult.OK)
            {
                var i = 0;
                foreach (var item in myList)
                {
                    ExportToPdf(item, clonedCanvasXaml[i], @dialog.SelectedPath + "/" + DateTime.Now.ToShortDateString() + "_" + i.ToString() + ".pdf");
                    i++;
                }
            }
        }

        private void ExportToPdf(ObservableCollection<PalletItem> list, Canvas repCanvas, string filePath)
        {

            var myDoc = new ReportWindow(list);
            myDoc.canvasPlaceholder.Child = repCanvas;
            myDoc.Show();

            myDoc.report.PageWidth = PrintLayout.A4.Size.Width;
            myDoc.report.PageHeight = PrintLayout.A4.Size.Height;
            myDoc.report.PagePadding = PrintLayout.A4.Margin;
            myDoc.report.ColumnWidth = PrintLayout.A4.ColumnWidth;

            //var myStream = FlowDocumentToXPS(myDoc.report, 96 * 8.27, 96 * 11.69);

            //var pdfXpsDoc = PdfSharp.Xps.XpsModel.XpsDocument.Open(myStream);
            //PdfSharp.Xps.XpsConverter.Convert(pdfXpsDoc, filePath, 0);
            //System.Diagnostics.Process.Start(filePath);

        }


        private List<ObservableCollection<PalletItem>> MakeAItemsLists()
        {

            IEnumerable<Canvas> canvasList = GetCollection<Canvas>(myStackPanel);
            List<ObservableCollection<PalletItem>> listOfPallets = new List<ObservableCollection<PalletItem>>();

            //GetAllCanvases();
            System.Diagnostics.Debug.WriteLine("!!!Making an item list per canvas START BLOCK!!!");
            System.Diagnostics.Debug.WriteLine("Canvas count: " + canvasList.Count());

            foreach (Canvas canvasItem in canvasList)
            {
                IEnumerable<PalletItemControl> boxes = canvasItem.Children.OfType<PalletItemControl>();
                System.Diagnostics.Debug.WriteLine("New Container: ");

                listOfPallets.Add(new ObservableCollection<PalletItem>());

                foreach (var palletItem in PalletItems)
                {
                    listOfPallets.Last().Add(new PalletItem() { OrderNumber = palletItem.OrderNumber, ClientName = palletItem.ClientName, PartName = palletItem.PartName, Width = palletItem.Width, Depth = palletItem.Depth, Quantity = 0, PlacesNumber = 0, Color = palletItem.Color });

                    foreach (PalletItemControl box in boxes)
                    {
                        if ((box.PalletNameText == listOfPallets.Last().LastOrDefault().PartName) && 
                            (box.OrderNumberText == listOfPallets.Last().LastOrDefault().OrderNumber))
                        {
                            listOfPallets.Last().Last().Quantity += Convert.ToInt32(box.PalletCountText);
                            listOfPallets.Last().Last().PlacesNumber++;
                        }
                    }

                    if (listOfPallets.Last().Last().Quantity == 0)
                    {
                        listOfPallets.Last().Remove(listOfPallets.Last().Last());
                    }

                }
                
            }


            ///Debug info
            ///
            foreach (var item in listOfPallets)
            {
                System.Diagnostics.Debug.WriteLine("New Container: ");

                foreach (var pallet in item)
                {
                    System.Diagnostics.Debug.WriteLine("OrderNumber: " + pallet.OrderNumber + " PartName: " + pallet.PartName + " Width: " + pallet.Width + " Depth: " + pallet.Depth + " Quantity: " + pallet.Quantity);
                }
            }

            System.Diagnostics.Debug.WriteLine("!!!Making an item list per canvas END BLOCK!!!");

            return listOfPallets;

        }


        public static List<T> GetCollection<T>(object parent) where T : DependencyObject
        {
            List<T> logicalCollection = new List<T>();
            GetLogicalChildCollection(parent as DependencyObject, logicalCollection);
            return logicalCollection;
        }
        private static void GetLogicalChildCollection<T>(DependencyObject parent, List<T> logicalCollection) where T : DependencyObject
        {
            IEnumerable children = LogicalTreeHelper.GetChildren(parent);
            foreach (object child in children)
            {
                if (child is DependencyObject)
                {
                    DependencyObject depChild = child as DependencyObject;
                    if (child is T)
                    {
                        logicalCollection.Add(child as T);
                    }
                    GetLogicalChildCollection(depChild, logicalCollection);
                }
            }
        }

        private void SaveXPS(MemoryStream stream, string filePath)
        {
            FileStream file = new FileStream(@filePath, FileMode.Create, FileAccess.Write);
            stream.WriteTo(file);
            file.Close();
        }

        private MemoryStream FlowDocumentToXPS(FlowDocument flowDocument, double width, double height)
        {
            MemoryStream stream = new MemoryStream();
            Dispatcher.CurrentDispatcher.Invoke(DispatcherPriority.SystemIdle,
                new DispatcherOperationCallback(arg => null), null);

            using (Package package = Package.Open(stream, FileMode.Create, FileAccess.ReadWrite))
            {
                using (XpsDocument xpsDoc = new XpsDocument(package, CompressionOption.NotCompressed))
                {
                    XpsSerializationManager rsm = new XpsSerializationManager(new XpsPackagingPolicy(xpsDoc), false);

                    DynamicDocumentPaginator paginator = (DynamicDocumentPaginator)((IDocumentPaginatorSource)flowDocument).DocumentPaginator;
                    paginator.PageSize = new System.Windows.Size(width, height);
                    rsm.SaveAsXaml(paginator);
                    rsm.Commit();
                }
            }
            stream.Position = 0;

            return stream;
        }

        private void ExportToPng(Canvas canvas, string pathToFile)
        {
            Rect bounds = VisualTreeHelper.GetDescendantBounds(canvas);
            double dpi = 300d;

            RenderTargetBitmap rtb = new RenderTargetBitmap((int)bounds.Width * 3, (int)bounds.Height * 3, dpi, dpi, System.Windows.Media.PixelFormats.Default);

            DrawingVisual dv = new DrawingVisual();
            using (DrawingContext dc = dv.RenderOpen())
            {
                VisualBrush vb = new VisualBrush(canvas);
                dc.DrawRectangle(vb, null, new Rect(new Point(), bounds.Size));
            }

            rtb.Render(dv);

            BitmapEncoder pngEncoder = new PngBitmapEncoder();
            pngEncoder.Frames.Add(BitmapFrame.Create(rtb));

            try
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream();

                pngEncoder.Save(ms);
                ms.Close();

                System.IO.File.WriteAllBytes(@pathToFile, ms.ToArray());
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.ToString(), "Ошибка");
            }
        }

        private Object CloneUsingXaml(Object obj)
        {
            string xaml = XamlWriter.Save(obj);
            var doc = ParseString(xaml);

            return XamlReader.Load(new XmlTextReader(new StringReader(doc)));

        }

        private string ParseString(string xaml)
        {
            System.Xml.Linq.XDocument doc = System.Xml.Linq.XDocument.Parse(xaml);

            doc.Root.Descendants().Attributes("Name").Remove();

            //doc.Save(@"C: \Users\anedopaka\Desktop\xaml.xml", SaveOptions.DisableFormatting);

            System.Diagnostics.Debug.WriteLine("New canvas created: " + doc.ToString(SaveOptions.None));

            return doc.ToString(SaveOptions.DisableFormatting);
        }
    }

    

}
