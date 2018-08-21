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
    public partial class HixongroupSupportWeb : ContentPage
    {
        public HixongroupSupportWeb()
        {
            InitializeComponent();
        }

        async void Backbtn(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage());
        }
    }
}