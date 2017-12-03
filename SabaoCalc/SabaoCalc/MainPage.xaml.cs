using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SabaoCalc {
    public partial class MainPage : ContentPage {
        private readonly Formula _formula;

        public MainPage() {
            InitializeComponent();
            _formula = new Formula();
            BindingContext = _formula;
        }
    }
}
