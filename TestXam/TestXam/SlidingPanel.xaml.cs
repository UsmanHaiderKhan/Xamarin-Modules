using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestXam
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SlidingPanel : ContentPage
    {
        public SlidingPanel()
        {
            InitializeComponent();
            body.TranslationY = Main.Height + 500;

        }

        private async void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
        {
            var initialPosition = Main.Height;
            var currentPosition = body.Height;
            await body.TranslateTo(0, (initialPosition - currentPosition) * 1, 500, Easing.SinIn);
        }
    }
}
