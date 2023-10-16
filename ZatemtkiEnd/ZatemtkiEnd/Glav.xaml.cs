using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ZatemtkiEnd
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Glav : ContentPage
	{
		public Glav ()
		{
			InitializeComponent ();
		}
        private async void OnButtonClicked(object sender, EventArgs e)
        {
            ZametkiVAR zametki = new ZametkiVAR();
            MainPage ZametkiPage = new MainPage();
            ZametkiPage.BindingContext = zametki;
            await Navigation.PushAsync(ZametkiPage);
        }
        private async void OnButtonClickedInfo(object sender, EventArgs e)
        {
            ZametkiVAR zametki = new ZametkiVAR();
            Instr ZametkiPage = new Instr();
            ZametkiPage.BindingContext = zametki;
            await Navigation.PushAsync(ZametkiPage);
        }
    }
}