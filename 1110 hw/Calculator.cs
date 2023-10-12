using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1110_hw
{
    class Calculator :INotifyPropertyChanged
    {
        double _a_value;
        double _b_value;
        double _result =0 ;
        public double A_value
        {
            get
            {
                return _a_value;
            }
            set
            {
                _a_value = value;
                _result = _a_value + _b_value;
                onPropertyChanged(nameof(A_value));
                onPropertyChanged(nameof(Result));
            }
        }
        public double B_value
        {
            get
            {
                return _b_value;
            }
            set
            { 
                _b_value = value;
                _result = _a_value + _b_value;
                onPropertyChanged(nameof(B_value));
                onPropertyChanged(nameof(Result));
            }
        }
        public double Result
        {
            get
            {
                return _result;
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        void onPropertyChanged(params string[] Name)
        {
            PropertyChangedEventHandler? handler = PropertyChanged;
            if (handler != null)
            {
                foreach (var name in Name)
                {
                    handler(this, new PropertyChangedEventArgs(name));
                }
            }
        }
    }
  
}
