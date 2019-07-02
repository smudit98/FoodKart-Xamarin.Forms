using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DemoApp.Model
{
    public class User:INotifyPropertyChanged
    {
        public static Dictionary<string, string> logincred = new Dictionary<string, string>
        {
            ["m"] = "m",
            ["abcd"]="abcdpassword2"

        };
        public int Id { get; set; }


        public event PropertyChangedEventHandler PropertyChanged;

        public string Username { get; set; }
       
        public string Password
        {
            get;set;
        }
        public User() {
            
        }
        public User(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
            

        }
        public bool CheckInformation()
        {
            if (this.Username != null&& this.Password!=null)
            {
                if (logincred.ContainsKey(Username)) {
                    if (logincred[Username] == Password) return true;
                    else return false;
                }
                return false;
 
            }
            return false;
        }
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
