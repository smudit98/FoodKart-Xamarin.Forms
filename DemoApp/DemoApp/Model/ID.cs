using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace DemoApp.Model
{
    class ID:INotifyPropertyChanged
    {
        private int _number;
        private int _price;
        private int _amount;

        public int Number
        {
            get
            {
                return _number;
            }
            set
            {
                _number = value;
                RaisePropertyChanged(nameof(Number));

            }
        }
        public int Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
                RaisePropertyChanged(nameof(Price));

            }
        }
        public int Amount
        {
            get
            {
                return _amount;
            }
            set
            {
                getAmount();
                RaisePropertyChanged(nameof(Amount));

            }
        }
        public void getAmount()
        {
            Amount = Number * Price;
        }

        public ID(int x,int y)
        {
            Number = x;
            Price = y;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged([CallerMemberName]string caller = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(caller));
            }
        }
    }
}
