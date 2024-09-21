using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ciplg_BlankComponent
{
    public class BlankComponentSettings : ObservableRecipient
    {
        private double _blankWidth = 0;
        public double BlankWidth
        {
            get => _blankWidth;
            set
            {
                if (_blankWidth != value)
                {
                    _blankWidth = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
