using System.ComponentModel;

namespace Gui
{
    public class AutoView : ViewModelBase // ipv INotifyPropertChanged
    {
        private string _nummerplaat;
        public string Nummerplaat 
        { 
            get 
            { 
                return _nummerplaat; 
            } 
            
            set 
            { 
                if(_nummerplaat != value) 
                { 
                    _nummerplaat = value; 
                    RaisePropertyChanged(); 
                } 
            } 
        }

        private string _merk;
        public string Merk 
        { 
            get { return _merk; } 
            set 
            { 
                if (_merk != value) 
                { 
                    _merk = value;
                    RaisePropertyChanged();
                } 
            } 
        }

        private string _model;
        public string Model
        {
            get { return _model; }
            set
            {
                if (_model != value)
                {
                    _model = value;
                    RaisePropertyChanged();
                }
            }
        }

        public AutoView(string nummerplaat, string merk, string model)
        {
            Nummerplaat = nummerplaat;
            Merk = merk;
            Model = model;
        }
    }
}
