using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace hydroponicsenvironmentmanagement
{
    public partial class settings : ContentPage
    {
        public settings()
        {
            InitializeComponent();
            InitSwitch();
        }

        void HandleModeClicked(object sender, System.EventArgs e)
        {

            if (CurrentMode.Text == "Manual Mode On")
            {
                CurrentMode.Text = "Automation Mode On";
                WaterPump.IsEnabled = false;
                AirSwitch.IsEnabled = false;
                LightsSwitch.IsEnabled = false;
                WaterPumpText.TextColor = Color.LightGray;
                AirText.TextColor = Color.LightGray;
                LightsText.TextColor = Color.LightGray;

            }
            else {
                WaterPump.IsEnabled = true;
                AirSwitch.IsEnabled = true;
                LightsSwitch.IsEnabled = true;
                CurrentMode.Text = "Manual Mode On";
                WaterPumpText.TextColor = Color.Black;
                AirText.TextColor = Color.Black;
                LightsText.TextColor = Color.Black;
            }

        }

        void InitSwitch(){
            WaterPump.Toggled += WaterPump_Toggled;
        }

        private void WaterPump_Toggled(object sender, ToggledEventArgs e)
        {
            DisplayAlert("Toggle","Toggled","cancel");
        }
    }
}
