using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hixon.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{
		public HomePage ()
		{
			InitializeComponent ();
		}

        async void Hixongroupweb(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HixonGroupPage());
        }
        async void Zendeskweb(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ZendeskSupportWeb());
        }
    }
}