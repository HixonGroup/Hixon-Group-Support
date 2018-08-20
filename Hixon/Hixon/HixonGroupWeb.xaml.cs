using System;
using Xamarin.Forms;

namespace Hixon
{
	public partial class HixonGroupWeb : ContentPage
	{
		public HixonGroupWeb ()
		{
			InitializeComponent ();
		}

        async void Backbtn(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage());
        }
	}
}