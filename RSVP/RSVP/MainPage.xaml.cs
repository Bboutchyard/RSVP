using System;
using Xamarin.Forms;

namespace RSVP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void ExistingUserClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ViewEvents());
        }

        private async void NewUserClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddAccount());
        }

        private async void GuestUserClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ViewEvents());
        }
    }
}

