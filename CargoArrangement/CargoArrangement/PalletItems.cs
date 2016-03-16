using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CargoArrangement.Models;

namespace CargoArrangement
{
    public class PalletItems : INotifyPropertyChanged
    {

        private ObservableCollection<PalletItem> _palletItems;
        public PalletItems()
        {
            ObservableCollection<PalletItem> _palletItems = new ObservableCollection<PalletItem>();

        }

        public void AddItem(PalletItem item)
        {
            _palletItems.Add(item);
        }

        public ObservableCollection<PalletItem> PalletItemsCollection
        {
            get
            {
                return _palletItems;
            }

            set
            {
                _palletItems = value;
                if (PropertyChanged != null)
                {
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                handler(this, e);
            }
        }
    }
}
