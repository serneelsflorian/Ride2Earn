﻿using Ride2Earn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Ride2Earn.Data;
using Ride2Earn.Klassen;

namespace Ride2Earn.Views.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pagina1 : ContentPage
    {
        public Pagina1()
        {
            InitializeComponent();
            BindingContext = new Gebruiker();
        }

        async protected override void OnAppearing()
        {
            base.OnAppearing();
            lstGebruiker.ItemsSource = await App.Database.GetGebruikerAsync();
        }

        async void Aanpassen(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GegevensAanpassen());
        }
    }
}