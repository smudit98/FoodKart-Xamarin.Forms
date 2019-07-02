using DemoApp.Model;
using DemoApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoApp.Model
{
    class Register
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }

        public string ConfirmPassword { get; set; }
        public string ValidationMessage { get; set; }
        //public string PasswordValidationMessage { get; private set; }
        //public string ConfirmPasswordValidationMessage { get; private set; }
        //public string FirstNameValidationMessage { get; private set; }
        //public string LastNameValidationMessage { get; private set; }
        //public object UserDialogs { get; private set; }

         public Register()
        {

        }
        public Register(string text) { }
        public Register(string FirstName, string LastName, string Password, string ConfirmPassword)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Password = Password;
            this.ConfirmPassword = ConfirmPassword;

        }
      
        public bool RCheckInformation()
        {
            if (FirstName != null)
            {
                if (FirstName.Trim().Length < 2)
                {
                    ValidationMessage = "First Name must be at least two characters long";
                    return false;

                    //IsFirstNameVisible = Visibility.Visible;
                }


            }
            if (LastName != null)
            {
                if (LastName.Trim().Length < 2)
                {
                    ValidationMessage = "Last Name must be at least two characters long";
                    return false;
                    // IsLastNameVisible = Visibility.Visible;
                }

            }
            if (Password != null)
            {
                if (Password.Trim().Length < 2)
                {

                    ValidationMessage = "Password must be at least two characters long";
                    return false;
                   
                    // IsPasswordVisible = Visibility.Visible;
                }
                else if (Password.Trim().Length > 20)
                {
                    ValidationMessage = "Password cannot be m9ore than twenty characters long";
                    return false;
                    // IsPasswordVisible = Visibility.Visible;
                }
                else if (!Password.Any(char.IsUpper))
                {
                    ValidationMessage = "Password must contain at least one upper-case character";
                    return false;
                    //  IsPasswordVisible = Visibility.Visible;
                }
                else if (!Password.Any(char.IsLower))
                {
                    ValidationMessage = "Password must contain at least one lower-case character";
                    return false;
                    //  IsPasswordVisible = Visibility.Visible;
                }
                else if (!Password.Any(char.IsNumber))
                {
                    ValidationMessage = "Password must contain at least one number";
                    return false;
                    // IsPasswordVisible = Visibility.Visible;
                }
                if (ConfirmPassword != null)
                {
                    if (Password != ConfirmPassword)
                    {
                        ValidationMessage = "Password do not match";
                        return false;
                        // IsConfirmPasswordVisible = Visibility.Collapsed;

                    }

                    else
                    {
                        ValidationMessage = "Password is secure";
                        
                        return true;

                    }
                }
                else if (ConfirmPassword == null) return false;
                
            }
            
            else
            {
                ValidationMessage = "Please Enter All Value";
                return false;

            }
            
            return true;
        }
    }
}
