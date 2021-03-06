﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CovidTracker.Services
{
    public class MessageDialogService
    {

        public void Display(string Title, string Message)
        {
            Device.BeginInvokeOnMainThread(async () =>
            {
                await App.Current.MainPage.DisplayAlert(Title, Message, "Ok");
            });
        }

        public async Task DisplayAsync (string Title, string Message)
        {
            await App.Current.MainPage.DisplayAlert(Title, Message, "Ok");
        }
    }
}
