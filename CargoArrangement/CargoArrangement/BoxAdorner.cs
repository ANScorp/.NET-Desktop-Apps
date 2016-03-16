using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace CargoArrangement
{
    public class BoxAdorner : Adorner
    {
        // Be sure to call the base class constructor.
        public BoxAdorner(UIElement adornedElement)
            : base(adornedElement)
        {
            VisualBrush _brush = new VisualBrush(adornedElement);

            _child = new Rectangle();
            _child.Width = adornedElement.RenderSize.Width;
            _child.Height = adornedElement.RenderSize.Height;


            DoubleAnimation animation = new DoubleAnimation(0.1, 1, new Duration(TimeSpan.FromSeconds(1)));
            animation.AutoReverse = true;
            animation.RepeatBehavior = RepeatBehavior.Forever;
            _brush.BeginAnimation(Brush.OpacityProperty, animation);

            _child.Fill = _brush;

        }

        // A common way to implement an adorner's rendering behavior is to override the OnRender
        // method, which is called by the layout subsystem as part of a rendering pass.
        protected override void OnRender(DrawingContext drawingContext)
        {
            // Get a rectangle that represents the desired size of the rendered element
            // after the rendering pass.  This will be used to draw at the corners of the 
            // adorned element.
            adornedElementRect = new Rect(this.AdornedElement.DesiredSize);

            // Some arbitrary drawing implements.
            SolidColorBrush renderBrush = new SolidColorBrush(Colors.Black);
            renderBrush.Opacity = 0.2;
            Pen renderPen = new Pen(new SolidColorBrush(Colors.Black), 1.5);
            double renderRadius = 50.0;

            // Just draw a circle at each corner.
            drawingContext.DrawRectangle(renderBrush, renderPen, adornedElementRect);
            drawingContext.DrawEllipse(renderBrush, renderPen, adornedElementRect.TopLeft, renderRadius, renderRadius);
            drawingContext.DrawEllipse(renderBrush, renderPen, adornedElementRect.TopRight, renderRadius, renderRadius);
            drawingContext.DrawEllipse(renderBrush, renderPen, adornedElementRect.BottomLeft, renderRadius, renderRadius);
            drawingContext.DrawEllipse(renderBrush, renderPen, adornedElementRect.BottomRight, renderRadius, renderRadius);
        }

        protected override Size MeasureOverride(Size constraint)
        {
            _child.Measure(constraint);
            return _child.RenderSize;
        }

        protected override Size ArrangeOverride(Size finalSize)
        {
            _child.Arrange(new Rect(finalSize));
            return finalSize;
        }

        protected override Visual GetVisualChild(int index)
        {
            return _child;
        }

        protected override int VisualChildrenCount
        {
            get
            {
                return 1;
            }
        }

        public double LeftOffset
        {
            get
            {
                return _leftOffset;
            }
            set
            {
                _leftOffset = value;
                UpdatePosition();
            }
        }

        public double TopOffset
        {
            get
            {
                return _topOffset;
            }
            set
            {
                _topOffset = value;
                UpdatePosition();

            }
        }

        public Rect adornedElementRect;

        private void UpdatePosition()
        {
            AdornerLayer adornerLayer = this.Parent as AdornerLayer;
            if (adornerLayer != null)
            {
                adornerLayer.Update(AdornedElement);
            }
        }

        public override GeneralTransform GetDesiredTransform(GeneralTransform transform)
        {
            GeneralTransformGroup result = new GeneralTransformGroup();
            result.Children.Add(new TranslateTransform(_leftOffset, _topOffset));
            result.Children.Add(base.GetDesiredTransform(transform));
            return result;
        }

        private Rectangle _child = null;
        private double _leftOffset = 0;
        private double _topOffset = 0;

        /// This part is for clip the adorner element to bounds

        /// <summary>
        /// Calls OnOffsetXChanged method of the instance, notifies of the depencency property value changes.
        /// </summary>
        /// <param name="d">Dependency object, the change occures on.</param>
        /// <param name="e">Property change details, such as old value and new value.</param>
        private static void OnOffsetXChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            BoxAdorner instance = (BoxAdorner)d;
            instance.OnOffsetXChanged(e);
        }
        /// <summary>
        /// Raises OffsetXChanged event.
        /// </summary>
        /// <param name="e">Property change details, such as old value and new value.</param>
        private void OnOffsetXChanged(DependencyPropertyChangedEventArgs e)
        {
            _leftOffset = (double)e.NewValue;

            if (OffsetXChanged != null)
            {
                OffsetXChanged(this, e);
            }
        }
        /// <summary>
        /// Calls OnOffsetYChanged method of the instance, notifies of the depencency property value changes.
        /// </summary>
        /// <param name="d">Dependency object, the change occures on.</param>
        /// <param name="e">Property change details, such as old value and new value.</param>
        private static void OnOffsetYChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            BoxAdorner instance = (BoxAdorner)d;
            instance.OnOffsetYChanged(e);
        }
        /// <summary>
        /// Raises OffsetYChanged event.
        /// </summary>
        /// <param name="e">Property change details, such as old value and new value.</param>
        private void OnOffsetYChanged(DependencyPropertyChangedEventArgs e)
        {
            _topOffset = (double)e.NewValue;

            if (OffsetYChanged != null)
            {
                OffsetYChanged(this, e);
            }
        }

        #region Events
        /// <summary>
        /// Event that is raised when OffsetX property is changed.
        /// </summary>
        public event PropertyChangedCallback OffsetXChanged;
        /// <summary>
        /// Event that is raised when OffsetY property is changed.
        /// </summary>
        public event PropertyChangedCallback OffsetYChanged;
        #endregion

        #region Dependency properties
        /// <summary>
        /// 
        /// </summary>
        public static readonly DependencyProperty OffsetXProperty =
            DependencyProperty.Register("LeftOffset", typeof(double), typeof(BoxAdorner), new FrameworkPropertyMetadata(0d, FrameworkPropertyMetadataOptions.AffectsArrange | FrameworkPropertyMetadataOptions.AffectsParentArrange, new PropertyChangedCallback(OnOffsetXChanged)));
        /// <summary>
        /// 
        /// </summary>
        public static readonly DependencyProperty OffsetYProperty =
            DependencyProperty.Register("TopOffset", typeof(double), typeof(BoxAdorner), new FrameworkPropertyMetadata(0d, FrameworkPropertyMetadataOptions.AffectsArrange | FrameworkPropertyMetadataOptions.AffectsParentArrange, new PropertyChangedCallback(OnOffsetYChanged)));
        #endregion
    }
}
