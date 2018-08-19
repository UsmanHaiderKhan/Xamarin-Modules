using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestXam
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Layout : ContentPage
    {
        public Layout()
        {
            InitializeComponent();
            //Layout=new Layout();
        }
    }
}
