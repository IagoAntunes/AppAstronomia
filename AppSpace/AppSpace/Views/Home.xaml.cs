using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppSpace.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = new ViewModel.HomeViewModel();
        }
        private async void GoListaObjetos(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new PaginaListaObjeto());
        }
    }
}