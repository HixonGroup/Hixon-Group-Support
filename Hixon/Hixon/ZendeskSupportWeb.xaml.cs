using System;
using Xamarin.Forms;

namespace Hixon
{
    public partial class ZendeskSupportWeb : ContentPage
    {
        public ZendeskSupportWeb()
        {
            InitializeComponent();
        }

        async void Backbtn(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage());
        }
    }
}