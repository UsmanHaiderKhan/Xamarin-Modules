using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestXam.BottomNavigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BottomNav : ContentPage
    {
        public BottomNav()
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

        private void TapGestureRecognizer_OnTapped3(object sender, EventArgs e)
        {
            var page = new Page3();
            Placeholder.Content = page.Content;
        }

        private void TapGestureRecognizer_OnTapped4(object sender, EventArgs e)
        {
            var page = new Page4();
            Placeholder.Content = page.Content;
        }

        private void TapGestureRecognizer_OnTapped5(object sender, EventArgs e)
        {
            var page = new Page5();
            Placeholder.Content = page.Content;
        }
    }
}
