using DemoApp.MenuItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailLearningPage : MasterDetailPage
    {
        public MasterDetailLearningPage()
        {
            InitializeComponent();
            Detail = new NavigationPage(new Page1());
            IsPresented = false;
            NavigationPage.SetHasNavigationBar(this, false);
            this.listView.ItemSelected += OnItemSelected;

        }
        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageItem;
            if (item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                this.listView.SelectedItem = null;
                IsPresented = false;
            }
            IsPresented = false;
        }

        void OnMenu1ButtonClicked(object sender, EventArgs e)
        {
            //property of master detail page
            Detail = new NavigationPage(new Page1());
            IsPresented = false;
        }
        void OnMenu2ButtonClicked(object sender,EventArgs e)
        {
            Detail = new NavigationPage(new Page2());
            IsPresented = false;
        }
        void OnSignoutButtonClicked(object sender,EventArgs e)
        {
            IsPresented = false;
            Detail = new NavigationPage(new MainPage());
        }
        protected override bool OnBackButtonPressed()
        {
            return false;
        }
    }
}