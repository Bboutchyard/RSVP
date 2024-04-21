using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RSVP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void ExistingUserClicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new EventDetails());
        }

        private async void NewUserClicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new AccountManagement());
        }

        private async void GuestUserClicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new EventDetails());
        }
    }
}

