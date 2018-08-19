using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestXam
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WebViewer : ContentPage
    {
        public WebViewer()
        {
            InitializeComponent();
            browse.Source = "";
        }

        private void Browse_OnNavigating(object sender, WebNavigatingEventArgs e)
        {
            loading.IsVisible = true;
        }

        private void Browse_OnNavigated(object sender, WebNavigatedEventArgs e)
        {
            loading.IsVisible = true;
        }
    }
}
