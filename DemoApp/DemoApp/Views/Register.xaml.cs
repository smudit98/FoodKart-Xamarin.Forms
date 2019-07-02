using DemoApp.Model;
using DemoApp.ViewModel;
using DemoApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Register : ContentPage
    {
        RegisterViewModel registerVM = new RegisterViewModel();
        public Register()
        {
            InitializeComponent();
            this.BindingContext = registerVM;
        }
        //void RegisterProcedure(object sender, EventArgs e)
        //{
        //    DemoApp.Model.Register register = new DemoApp.Model.Register(Entry_FirstName.Text, Entry_LastName.Text, Entry_Password.Text, Entry_CPassword.Text);
        //    if (!register.RCheckInformation())
        //    {
        //        DisplayAlert("Validation Fails", register.ValidationMessage, "OK");
        //    }else
        //    {
        //        DisplayAlert("Success", "Registered!!!", "OK");
        //        this.Navigation.PushAsync(new MainPage());
        //    }
            
            
        //    //else
        //    //{
        //    //    DisplayAlert("Register", "Invalid Details");
        //    //}
        //}
    }
    }