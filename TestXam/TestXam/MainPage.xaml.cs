using Rg.Plugins.Popup.Services;
using System;
using Xamarin.Forms;

namespace TestXam
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PushAsync(new DialogwithEntry());
        }
    }
}
