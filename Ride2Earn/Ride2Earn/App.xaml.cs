﻿using Ride2Earn.Views.Register;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Ride2Earn.Data;
using Ride2Earn.Helpers;
using Ride2Earn.Views.Menu;
using Ride2Earn.Models;
using Ride2Earn.Views.Pages;

namespace Ride2Earn
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new SplashPage();

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        
    }
}
