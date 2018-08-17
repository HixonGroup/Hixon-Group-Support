﻿using System;
using Xamarin.Forms;

namespace Hixon
{
    class TodayPageCS : ContentPage
    {
        public TodayPageCS ()
        {
            Icon = "today.png";
            Title = "Today";
            Content = new StackLayout
            {
                Children = {
                    new Label {
                        Text = "Today's appointments go here",
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                    }
                }
            };
        }
    }
}