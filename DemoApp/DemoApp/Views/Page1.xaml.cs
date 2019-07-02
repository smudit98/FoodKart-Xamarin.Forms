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
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }
        void OnfirstitemTapped(object sender,EventArgs e)
        {
            this.Navigation.PushAsync(new itemdetails());
        }
        void OnseconditemTapped(object sender, EventArgs e)
        {

        }
        void OnthirditemTapped(object sender, EventArgs e)
        {

        }
        void OnfourthitemTapped(object sender, EventArgs e)
        {

        }
    }
}