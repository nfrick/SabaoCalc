using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SabaoCalc {
    public class Formula : INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;

        private double _oleo;
        private double _agua;
        private double _soda;
        public double Oleo {
            get => _oleo;
            set {
                _oleo = value;
                var _ratio = _oleo / 5;
                Agua = 2 * _ratio;
                Soda = 1 * _ratio;
                OnPropertyChanged();
            }
        }

        public double Agua {
            get => _agua;
            set {
                _agua = value;
                OnPropertyChanged();
            }
        }

        public double Soda {
            get => _soda;
            set {
                _soda = value;
                OnPropertyChanged();
            }
        }

        public Formula() {
            Oleo = 5;
        }

        void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            var handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
