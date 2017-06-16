﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrendingTopIt
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Login : ContentPage
	{
		public Login ()
		{
			InitializeComponent ();
		}
        async void OnSignUpButtonClicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new SignUpPage());
            //App.Navigation.InsertPageBefore(new SignUpPage(), this);
            // await Navigation.PopAsync();
            //   Navigation.PushAsync(new SignUpPage());
            //  await Navigation.PushAsync(new SignUpPage());
            //  App.Current.MainPage = new NavigationPage(new SignUpPage());
            if (Device.OS == TargetPlatform.iOS)
            {
                await Navigation.PopToRootAsync();
            }
            //Application.Current.MainPage = new SignUpPage();
            await Application.Current.MainPage.Navigation.PushAsync(new SignUpPage(), true);
        }
        async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            // Navigation.InsertPageBefore(new MainPage(), this);
            // await Navigation.PushAsync(new MainPage());
            //  App.Current.MainPage = new NavigationPage(new MainPage());
            if (Device.OS == TargetPlatform.iOS)
            {
                await Navigation.PopToRootAsync();
            }
              Application.Current.MainPage = new MasterPage();
          //  await Application.Current.MainPage.Navigation.PushAsync(new MasterPage(), true);


            // Navigation.InsertPageBefore(new MainPage(), this);
            //  await Navigation.PopAsync();
            /*var user = new User
            {
                Username = usernameEntry.Text,
                Password = passwordEntry.Text
            };

            var isValid = AreCredentialsCorrect(user);
            if (isValid)
            {
                App.IsUserLoggedIn = true;
                Navigation.InsertPageBefore(new MainPage(), this);
                await Navigation.PopAsync();
            }
            else
            {
                messageLabel.Text = "Login failed";
                //passwordEntry.Text = string.Empty;
            }*/
        }

    }
}