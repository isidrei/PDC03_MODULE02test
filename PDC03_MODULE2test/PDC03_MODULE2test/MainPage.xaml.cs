using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PDC03_MODULE2test
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OPENActivity1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new activity1());
        }
        private async void OPENActivity2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new activity2());
        }

    }
}
