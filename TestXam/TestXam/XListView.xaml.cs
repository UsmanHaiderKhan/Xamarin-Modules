using TestXam.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestXam
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class XListView : ContentPage
    {
        public XListView()
        {
            InitializeComponent();
            BindingContext = new PersonViewModel();
        }
    }
}
