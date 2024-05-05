using System;
using Xamarin.Forms;

namespace RSVP
{
    public partial class AddAccount : ContentPage
    {
        public readonly String Name = "Brandon Boutchyard";
        public readonly String Email = "brabou2776@students.ecpi.edu";
        public readonly String Password = "Password1";
        public Array[] CurrentUser;

        internal static User CurrrentUser { get; private set; }

        public AddAccount()
        {
            InitializeComponent();
        }

        public void OnLogoutClicked(object sender, EventArgs e)
        {
            User CurrentUser = new User { Name = null, Email = null };
        }

        public static void Login(string name, string email)
        {
            User CurrrentUser = new User { Name = name, Email = email };
        }

        public static void LoginAsGuest()
        {
            Login("Guest", "guest@example.com");
        }

        public static void OnSaveClicked(object sender, EventArgs e)
        {

        }
    }
}