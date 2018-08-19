using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestXam.TopBarNavigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TopNavigation : ContentPage
    {
        public TopNavigation()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
        {
            var page = new Page1();
            Placeholder.Content = page.Content;
        }

        private void TapGestureRecognizer_OnTapped2(object sender, EventArgs e)
        {
            var page = new Page2();
            Placeholder.Content = page.Content;
        }
    }
}
