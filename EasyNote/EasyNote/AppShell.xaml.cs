using EasyNote.Models;
using EasyNote.ViewModels;
using EasyNote.Views;
using System;
using System.Collections.Generic;
using Xamarin.Essentials;
using Xamarin.Forms;


namespace EasyNote
{
    public partial class AppShell : Xamarin.Forms.Shell 
    {
        

        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));



        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            String oauthToken = await SecureStorage.GetAsync("Usuario");

            Correo nombe = new Correo
            {
                usuario = oauthToken
            };

            BindingContext = nombe;
        }


        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
            
        }

        private async void MenuItem_Clicked(object sender, EventArgs e)
        {
           

        }

        
    }
}
