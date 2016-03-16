using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CargoArrangement
{
    class PrintLayout
    {
        public static readonly PrintLayout A4 = new PrintLayout("21.0cm", "29.7cm", "1.3cm", "0.0cm");
        public static readonly PrintLayout A3Narrow = new PrintLayout("29.7cm", "42cm", "1.27cm", "1.27cm");
        public static readonly PrintLayout A3Moderate = new PrintLayout("29.7cm", "42cm", "1.91cm", "2.54cm");
        private Thickness _Margin;
        private System.Windows.Size _Size;

        public PrintLayout(string width, string height, string leftrightMargin, string topbottomMargin)
            : this(width, height, leftrightMargin, topbottomMargin, leftrightMargin, topbottomMargin)
        {

        }

        public PrintLayout(string w, string h, string leftMargin, string topMargin, string rightMargin, string bottomMargin)
        {
            var converter = new System.Windows.LengthConverter();
            var width = (double)converter.ConvertFromInvariantString(w);
            var height = (double)converter.ConvertFromInvariantString(h);
            var marginLeft = (double)converter.ConvertFromInvariantString(leftMargin);
            var marginTop = (double)converter.ConvertFromInvariantString(topMargin);
            var marginRight = (double)converter.ConvertFromInvariantString(rightMargin);
            var marginBottom = (double)converter.ConvertFromInvariantString(bottomMargin);
            this._Size = new Size(width, height);
            this._Margin = new Thickness(marginLeft, marginTop, marginRight, marginBottom);

        }

        public Thickness Margin
        {
            get { return _Margin; }
            set { _Margin = value; }
        }

        public Size Size
        {
            get { return _Size; }
        }

        public double ColumnWidth
        {
            get
            {
                var column = 0.0;
                column = this.Size.Width - Margin.Left - Margin.Right;
                return column;
            }
        }


    }
}
