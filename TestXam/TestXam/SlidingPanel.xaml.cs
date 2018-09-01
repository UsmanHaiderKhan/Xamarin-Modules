using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }
    }
}