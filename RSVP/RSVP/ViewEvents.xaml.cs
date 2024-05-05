using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace RSVP
{
    public partial class ViewEvent : ContentPage
    {
        public ViewEvent()
        {

        }

        public void OnEventSelected(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;

            if (selectedIndex != -1)
            {
                //Need to finish statement
            }
        }
    }
}

