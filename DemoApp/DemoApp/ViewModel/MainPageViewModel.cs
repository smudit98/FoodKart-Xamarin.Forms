using DemoApp.Model;
using DemoApp.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DemoApp.ViewModel
{
    class MainPageViewModel : INotifyPropertyChanged
    {

        private ObservableCollection<User> _listOfItems = new
    ObservableCollection<User>();
        public ObservableCollection<User> ListOfItems
        {
            get { return _listOfItems; }
            set
            {
                if (_listOfItems != value)
                {
                    _listOfItems = value;
                    RaisePropertyChanged();
                }
            }
        }
        private string username = null;
        private string password = null;
        private string loginMessage = null;
        public string Username
        {
            get { return username; }
            set
            {
                username = value;
                RaisePropertyChanged(nameof(Username));
            }
        }
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                RaisePropertyChanged(nameof(Password));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged([CallerMemberName]string caller = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(caller));
            }
        }

        public ICommand LoginCommand
        {
            get;
            private set;
        }
        public ICommand RegisterCommand
        {
            get;
            private set;
        }

        public MainPageViewModel()
        {
            ListOfItems.Add(new User());
            LoginCommand = new Command((e) =>
            {
                var item = (e as User);
                //TODO: LOGIN TO YOUR SYSTEM
                OnLoginCommandExecute(item);

            });
            RegisterCommand = new Command((e) =>
              {
                  OnRegisterCommandExecute();
              });
            //}

            //public event PropertyChangedEventHandler PropertyChanged;
            //void OnPropertyChanged([CallerMemberName]string propertyName = "") =>
            //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

            //public ICommand OnSignInCommandExecute { get; private set; }
            //public MainPageViewModel()
            //{
            //    //OnSignInCommandExecute = new Command<User>(OnLoginCommandExecute);
            //    OnSignInCommandExecute = new Command((e) =>
            //    {
            //        var item = e as User;
            //        OnLoginCommandExecute(item);
            //    });
            //}

            //private bool CanOnLoginCommandExecute(User arg)
            //{
            //    return true;
            //}
        }

        private void OnRegisterCommandExecute()
        {
            App.Current.MainPage.Navigation.PushAsync(new DemoApp.Views.Register());
        }

        private void OnLoginCommandExecute(User obj)
        {
            User user = new User(obj.Password, obj.Username);
            if (user.CheckInformation())
            {
                App.Current.MainPage.Navigation.PushAsync(new MasterDetailLearningPage());
            }
            else
            {
                App.Current.MainPage.DisplayAlert("Login", "Login NOT Success", "okay");
            }
        }

        
    }
}
