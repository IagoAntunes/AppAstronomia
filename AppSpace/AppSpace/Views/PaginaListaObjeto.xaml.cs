﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppSpace.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaListaObjeto : ContentPage
    {
        public PaginaListaObjeto(String nome)
        {
            InitializeComponent();
            BindingContext = new ViewModel.PaginaListaObjetoViewModel(nome);
        }
    }
}