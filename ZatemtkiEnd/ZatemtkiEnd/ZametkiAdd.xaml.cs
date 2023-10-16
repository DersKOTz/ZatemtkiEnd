using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace ZatemtkiEnd
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ZametkiAdd : ContentPage
    {
        
        public ZametkiAdd()
        {
            InitializeComponent();       
        }
        private void Save(object sender, EventArgs e)
        {
            var Zametkivar = (ZametkiVAR)BindingContext;
            if (!String.IsNullOrEmpty(Zametkivar.Nazv))
            {
                App.Database.SaveItem(Zametkivar);
            }
            this.Navigation.PopAsync();
        }
        private void Delete(object sender, EventArgs e)
        {
            var Zametkivar = (ZametkiVAR)BindingContext;
            App.Database.DeleteItem(Zametkivar.Id);
            this.Navigation.PopAsync();
        }
        private void Cancel(object sender, EventArgs e)
        {
            this.Navigation.PopAsync();
        }
        public void SaveSwitch(object sender, EventArgs e)
        {
            var Zametkivar = (ZametkiVAR)BindingContext;
            if (!String.IsNullOrEmpty(Zametkivar.Nazv))
            {
                App.Database.SaveItem(Zametkivar);
            }

            if (SwitchAdd.IsToggled)
            {
                StatusLabel.Text = "Статус: Завершено";
                StatusLabel.TextColor = Color.Green;
                SwitchAdd.ThumbColor = Color.Green;
                SwitchAdd.OnColor = Color.Chartreuse;
            }
            else
            {
                StatusLabel.Text = "Статус: В процессе";
                StatusLabel.TextColor = Color.Red;
                SwitchAdd.ThumbColor = Color.Red;
            }          
        }                  
    }
}