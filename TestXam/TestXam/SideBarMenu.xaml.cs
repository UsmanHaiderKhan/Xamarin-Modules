using System;
using System.Collections.Generic;
using TestXam.MenuItem;
using TestXam.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestXam
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SideBarMenu : MasterDetailPage
    {
        public List<MenuItems> MenuList { get; set; }

        public SideBarMenu()
        {
            InitializeComponent();
            MenuList = new List<MenuItems>();

            var page1 = new MenuItems()
            {
                Title = "Normal Students",
                Icon = "Userl.png",
                TargetType = typeof(View1)
            };

            var page2 = new MenuItems()
            {
                Title = "Disabled Students",
                Icon = "dis.png",
                TargetType = typeof(View2)
            };
            var page3 = new MenuItems()
            {
                Title = "Search Student",
                Icon = "serach.png",
                TargetType = typeof(View3)
            };
            var page4 = new MenuItems()
            {
                Title = "Email",
                Icon = "mail.png",
                TargetType = typeof(View4)
            };
            var page5 = new MenuItems()
            {
                Title = "Setting",
                Icon = "setting.png",
                TargetType = typeof(View5)
            };
            var page6 = new MenuItems()
            {
                Title = "Rate Us",
                Icon = "heart.png",
                TargetType = typeof(View6)
            };
            MenuList.Add(page1);
            MenuList.Add(page2);
            MenuList.Add(page3);
            MenuList.Add(page4);
            MenuList.Add(page5);
            MenuList.Add(page6);
            navigationDrawList.ItemsSource = MenuList;

            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(MainPage)));

            this.BindingContext = new
            {
                Header = "WellCome To EVS",
                Image = "http://www3.hilton.com/resources/media/hi/GSPSCHF/en_US/img/shared/full_page_image_gallery/main/HH_food_22_675x359_FitToBoxSmallDimension_Center.jpg",
                Footer = ""
            };
        }

        private void navigationDrawList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var items = (MenuItems)e.SelectedItem;
            Type page = items.TargetType;

            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Page)));
            IsPresented = false;
        }
    }
}
