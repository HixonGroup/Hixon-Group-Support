using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            Button hixongroupweb = new Button
            {
                Text = "Hixon Group Website",
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.Start
            };

            hixongroupweb.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new HixonGroupWeb());
            };

            Content = hixongroupweb;
        }
	}
}