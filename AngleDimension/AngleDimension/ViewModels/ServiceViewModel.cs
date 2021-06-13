using AngleDimension.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AngleDimension.ViewModels
{
    class ServiceViewModel: BaseViewModel
    {
        public ICommand BMSCommand => new Command(() => Application.Current.MainPage.Navigation.PushAsync(new BMSPage()));
        public ICommand WhatCommand => new Command(() => Application.Current.MainPage.Navigation.PushAsync(new WhatWeDoPage()));
    }
}
