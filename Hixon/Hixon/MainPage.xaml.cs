using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hixon.Pages;
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