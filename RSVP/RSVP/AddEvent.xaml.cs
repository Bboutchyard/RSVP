using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace RSVP
{
    public partial class AddEvent : ContentPage
    {
        public AddEvent()
        {
            InitializeComponent();
        }

        public void OnAddEventClicked(object sender, EventArgs e)
        {
            DisplayAlert("Event Added", "Your event has been added successfully","Ok");
        }

        //Name of person hosting
        //Event name
        //Event address
        //Maximum allowed attendess
        //Event date and time
        //Deadline to RSVP
    }
}
