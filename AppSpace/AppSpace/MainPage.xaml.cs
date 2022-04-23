using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppSpace
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            Servico.Conexoes.ReceberDados();
        }
        private void GoHome(object sender, EventArgs args)
        {

            App.Current.MainPage = new NavigationPage(new Views.Home());
        }
    }
}
