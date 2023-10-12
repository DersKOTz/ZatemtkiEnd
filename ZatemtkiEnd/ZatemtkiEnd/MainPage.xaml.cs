using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ZatemtkiEnd
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }





        protected override void OnAppearing()
        {
            ZametkiList.ItemsSource = App.Database.GetItems();
            base.OnAppearing();
        }
        // обработка нажатия элемента в списке
        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ZametkiVAR selectedZametki = (ZametkiVAR)e.SelectedItem;
            ZametkiAdd ZametkiPage = new ZametkiAdd();
            ZametkiPage.BindingContext = selectedZametki;
            await Navigation.PushAsync(ZametkiPage);
        }
        // обработка нажатия кнопки добавления
        private async void CreateZametki(object sender, EventArgs e)
        {
            ZametkiVAR zametki = new ZametkiVAR();
            ZametkiAdd ZametkiPage = new ZametkiAdd();
            ZametkiPage.BindingContext = zametki;
            await Navigation.PushAsync(ZametkiPage);
        }
    }
}
