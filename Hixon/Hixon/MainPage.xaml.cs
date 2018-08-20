using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hixon
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
			InitializeComponent ();
		}

        async void Hixongroupweb(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new HixonGroupWeb());
        }
        async void Zendeskweb(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ZendeskSupportWeb());
        }
    }
}