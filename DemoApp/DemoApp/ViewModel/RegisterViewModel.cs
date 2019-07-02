using DemoApp.Model;
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
    class RegisterViewModel:INotifyPropertyChanged
    {
        private string firstName=null;
        private string lastName=null;
        private string password=null;

        private string confirmPassword=null;
        private string validationMessage=null;

        public string FirstName
        {
            get { return firstName; }
            set
            {
                firstName = value;
                RaisePropertyChanged(FirstName);

            }

        }
        public string LastName
        {
            get { return lastName; }
            set
            {
                lastName = value;
                RaisePropertyChanged(LastName);

            }

        }
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                RaisePropertyChanged(Password);

            }

        }
        public string ConfirmPassword
        {
            get { return confirmPassword; }
            set
            {
                confirmPassword = value;
                RaisePropertyChanged(ConfirmPassword);

            }

        }
        public string ValidationMessage
        {
            get { return validationMessage; }
            set
            {
                validationMessage = value;
                RaisePropertyChanged(ValidationMessage);

            }

        }
        public ICommand RegisterDoneCommand
        {
            get;
            private set;
        }
        private ObservableCollection<Register> _listOfItems = new ObservableCollection<Register>();
        public ObservableCollection<Register> ListOfItems
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
        public RegisterViewModel()
        {
            ListOfItems.Add(new Register());
            
            RegisterDoneCommand = new Command((e) =>
              {
                  var item = (e as Register);
                  RegisterProcedure(item);
              });
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged([CallerMemberName]string caller = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(caller));
            }
        }


        private void RegisterProcedure(Register obj)
        {
            Register reg = new Register(obj.FirstName, obj.LastName,obj.Password,obj.ConfirmPassword);
            
            if (!reg.RCheckInformation())
            {
                Application.Current.MainPage.DisplayAlert("Validation Fails", reg.ValidationMessage, "OK");
            }
            else
            {
                App.Current.MainPage.DisplayAlert("Success", "Registered!!!", "OK");
                User.logincred.Add(obj.FirstName, obj.Password);
                App.Current.MainPage.Navigation.PushAsync(new MainPage());
            }
        }
    }
}
