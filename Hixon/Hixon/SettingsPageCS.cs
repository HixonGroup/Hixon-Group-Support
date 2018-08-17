﻿using System;
using Xamarin.Forms;

namespace Hixon
{
    class SettingsPageCS : ContentPage
    {
        public SettingsPageCS ()
        {
            Icon = "settings.png";
            Title = "Settings";
            Content = new StackLayout
            {
                Children = {
                    new Label {
                        Text = "Settings go here",
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                    }
                }
            };
        }
    }
}