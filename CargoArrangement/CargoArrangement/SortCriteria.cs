using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace CargoArrangement
{
    enum SortCriteria
    {
        [Description("Sorting Disabled")]
        None = 0,
        [Description("Sorting with algorith MaxSide")]
        Maxside = 1,
        [Description("Sorting with algorith Area")]
        Area = 2,
        [Description("Sorting with algorith Max")]
        Max = 3,
        [Description("Sorting with algorith Min")]
        Min = 4,
        [Description("Sorting with algorith Depth")]
        Depth = 5,
        [Description("Sorting with algorith Width")]
        Width = 6
    }
}
