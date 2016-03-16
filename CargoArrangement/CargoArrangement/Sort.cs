using System;
using System.Collections.ObjectModel;
using CargoArrangement.Models;

namespace CargoArrangement
{
    class Sort
    {
        public Sort(ObservableCollection<PalletItem> block, SortCriteria criteria)
        {
            switch (criteria)
            {
                case SortCriteria.Maxside:
                    MaxSideSorting(block);
                    break;

                case SortCriteria.Area:
                    AreaSorting(block);
                    break;

                case SortCriteria.Max:
                    Max(block);
                    break;

                case SortCriteria.Min:
                    Min(block);
                    break;

                case SortCriteria.Width:
                    Width(block);
                    break;

                case SortCriteria.Depth:
                    Depth(block);
                    break;

            }
        }

        private void AreaSorting(ObservableCollection<PalletItem> block)
        {
            for (var n = 0; n < block.Count; n++)
                for (var i = n; i < block.Count; i++)
                {
                    if (block[n].Width * block[n].Depth < block[i].Width * block[i].Depth)
                    {
                        var tmp = block[n];
                        block[n] = block[i];
                        block[i] = tmp;
                    }
                }
        }

        private void MaxSideSorting(ObservableCollection<PalletItem> block)
        {

            Max(block);
            Min(block);
            Depth(block);
            Width(block);

        }

        private void Width(ObservableCollection<PalletItem> block)
        {
            for (var n = 0; n < block.Count; n++)
                for (var i = n; i < block.Count; i++)
                {
                    if (block[n].Width < block[i].Width)
                    {
                        var tmp = block[n];
                        block[n] = block[i];
                        block[i] = tmp;
                    }
                }
        }

        private void Depth(ObservableCollection<PalletItem> block)
        {
            for (var n = 0; n < block.Count; n++)
                for (var i = n; i < block.Count - 1; i++)
                {
                    if (block[n].Depth < block[i].Depth)
                    {
                        var tmp = block[n];
                        block[n] = block[i];
                        block[i] = tmp;
                    }
                }
        }

        private void Min(ObservableCollection<PalletItem> block)
        {
            for (var n = 0; n < block.Count; n++)
                for (var i = n; i < block.Count - 1; i++)
                {
                    if (Math.Min(block[n].Width, block[n].Depth) < Math.Min(block[i].Width, block[i].Depth))
                    {
                        var tmp = block[n];
                        block[n] = block[i];
                        block[i] = tmp;
                    }
                }
        }

        private void Max(ObservableCollection<PalletItem> block)
        {
            for (var n = 0; n < block.Count; n++)
                for (var i = n; i < block.Count - 1; i++)
                {
                    if (Math.Max(block[n].Width, block[n].Depth) < Math.Max(block[i].Width, block[i].Depth))
                    {
                        var tmp = block[n];
                        block[n] = block[i];
                        block[i] = tmp;
                    }
                }
        }
    }
}
