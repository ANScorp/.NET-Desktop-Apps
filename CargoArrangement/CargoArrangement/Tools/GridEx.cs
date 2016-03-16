using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace CargoArrangement.Tools
{
    public class GridEx : Grid
    {
        /// <summary>
        /// Overriden to automatically set the Row and Column properties of each child.
        /// This method is called when children are added or removed from the Grid.Children collection.
        /// </summary>
        protected override void OnVisualChildrenChanged(DependencyObject visualAdded, DependencyObject visualRemoved)
        {
            UpdateChildren();
            base.OnVisualChildrenChanged(visualAdded, visualRemoved);
        }

        void UpdateChildren()
        {
            //current row and column
            //columnIndex is incremented for each item to place them one after the other
            int rowIndex = 0;
            int columnIndex = 0;
            foreach (UIElement child in Children)
            {
                //happens while editing the children collection in xaml
                //if we don't handle this, the Designer throws an exception
                if (child == null)
                    continue;

                //we'll set the child's Row and Column properties depending on its attached behavior
                switch (GridEx.GetGridExBehavior(child))
                {
                    case GridExBehavior.Default:
                        //if columnIndex is below ItemsPerRow, put this item on the current row
                        //else put this item on the next row, first column
                        if (columnIndex >= ItemsPerRow)
                        {
                            rowIndex++;
                            columnIndex = 0;
                        }
                        Grid.SetRow(child, rowIndex);
                        Grid.SetColumn(child, columnIndex++);
                        break;

                    case GridExBehavior.SameRow:
                        //put this item on the same row
                        Grid.SetRow(child, rowIndex);
                        Grid.SetColumn(child, columnIndex++);
                        break;

                    case GridExBehavior.SameCell:
                        //put this item on the same row, same column (of the previous item)
                        //just make sure we don't set a negative column index (happens sometimes when editing XAML code)
                        Grid.SetRow(child, rowIndex);
                        Grid.SetColumn(child, Math.Max(0, columnIndex - 1));
                        break;

                    case GridExBehavior.NextRow:
                        //put this item on the next row, first column
                        columnIndex = 0;
                        Grid.SetRow(child, ++rowIndex);
                        Grid.SetColumn(child, columnIndex++);
                        break;

                    case GridExBehavior.Manual:
                        //don't change anything on this item
                        break;
                }
            }
        }

        /// <summary>
        /// Number of items per row.
        /// Default is 2.
        /// </summary>
        public int ItemsPerRow
        {
            get { return (int)GetValue(ItemsPerRowProperty); }
            set { SetValue(ItemsPerRowProperty, value); }
        }
        public static readonly DependencyProperty ItemsPerRowProperty = DependencyProperty.Register(
            "ItemsPerRow",
            typeof(int),
            typeof(GridEx),
            new FrameworkPropertyMetadata(2, FrameworkPropertyMetadataOptions.AffectsArrange | FrameworkPropertyMetadataOptions.AffectsMeasure, ItemsPerRow_PropertyChanged));
        static void ItemsPerRow_PropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            GridEx grid = d as GridEx;
            if (grid != null)
                grid.UpdateChildren();
        }

        protected override Size MeasureOverride(Size constraint)
        {
            //OfType<> is used to get an enumerable collection of non-null objects.
            //Children may contain null objects at design time --> they should be ignored to avoid exceptions.
            IEnumerable<UIElement> children = Children.OfType<UIElement>();
            if (children.Count() > 0)
            {
                int maxRowIndex = children.Max(child => GetRow(child));
                int maxColumnIndex = children.Max(child => GetColumn(child));

                //automatically add rows if needed
                for (int i = RowDefinitions.Count; i <= maxRowIndex; i++)
                    RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Auto) });
                //automatically add columns if needed
                for (int i = ColumnDefinitions.Count; i <= maxColumnIndex; i++)
                {
                    GridLength unitType = new GridLength(1, GridUnitType.Auto);
                    if (i == maxColumnIndex)
                        unitType = LastColumnWidth;
                    ColumnDefinitions.Add(new ColumnDefinition() { Width = unitType });
                }
            }

            return base.MeasureOverride(constraint);
        }

        /// <summary>
        /// Width of the last automatically added column.
        /// Default is "*".
        /// Note that this property will be ignored if the last column was defined manually.
        /// </summary>
        public GridLength LastColumnWidth
        {
            get { return (GridLength)GetValue(LastColumnWidthProperty); }
            set { SetValue(LastColumnWidthProperty, value); }
        }
        public static readonly DependencyProperty LastColumnWidthProperty = DependencyProperty.Register(
            "LastColumnWidth",
            typeof(GridLength),
            typeof(GridEx),
            new FrameworkPropertyMetadata(new GridLength(1, GridUnitType.Star), FrameworkPropertyMetadataOptions.AffectsArrange | FrameworkPropertyMetadataOptions.AffectsMeasure));

        /// <summary>
        /// Defines the behavior of a child item.
        /// </summary>
        public enum GridExBehavior
        {
            /// <summary>
            /// Items are added one after the other, with 2 items per row by default.
            /// </summary>
            Default,
            /// <summary>
            /// This item should be placed on the same row, next column.
            /// </summary>
            SameRow,
            /// <summary>
            /// This item should be placed on the same row, same column.
            /// </summary>
            SameCell,
            /// <summary>
            /// This item should be placed on the next row, first column.
            /// </summary>
            NextRow,
            /// <summary>
            /// This item should be ignored.
            /// Its Grid.Row and Grid.Column properties should be set manually.
            /// </summary>
            Manual
        }

        public static GridExBehavior GetGridExBehavior(DependencyObject obj)
        {
            return (GridExBehavior)obj.GetValue(GridExBehaviorProperty);
        }
        public static void SetGridExBehavior(DependencyObject obj, GridExBehavior value)
        {
            obj.SetValue(GridExBehaviorProperty, value);
        }
        public static readonly DependencyProperty GridExBehaviorProperty = DependencyProperty.RegisterAttached(
            "GridExBehavior",
            typeof(GridExBehavior),
            typeof(UIElement),
            new UIPropertyMetadata(GridExBehavior.Default, GridExBehavior_PropertyChangedCallback));
        static void GridExBehavior_PropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            GridEx grid = VisualTreeHelper.GetParent(d) as GridEx;
            if (grid != null)
                grid.UpdateChildren();
        }



    }
}
