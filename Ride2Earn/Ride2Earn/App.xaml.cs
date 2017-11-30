﻿using Ride2Earn.Data;
using Ride2Earn.Views.Register;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Ride2Earn
{
    public partial class App : Application
    {
        static UserDatabase Users;
        static TokenDatabase Tokens;
        public App()
        {
            InitializeComponent();

            MainPage = new LoginPage1();
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

        public static UserDatabase a
        {
            get
            {
                if (Users == null)
                {
                    Users = new UserDatabase();
                }
                return Users;
            }
        }
        public static TokenDatabase b
        {
            get
            {
                if (Tokens == null)
                {
                    Tokens = new TokenDatabase();
                }
                return Tokens;
            }
        }
    }
}
