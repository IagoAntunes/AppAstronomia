using AppSpace.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace AppSpace.ViewModel
{

    public class HomeViewModel
    {
        public List<Objeto> ListaDeObjetos { get; set; }

        public HomeViewModel()
        {
            ListaDeObjetos = new List<Objeto>
           {
               new Objeto{Nome = "Planetas",Imagem = "Jupter",Cor = "#cdb28a"},
               new Objeto{Nome = "Luas",Imagem = "Lua",Cor = "#acbccc"},
               new Objeto{Nome = "Satelites",Imagem = "Satelite",Cor = "#cdb28a"},
               new Objeto{Nome = "Foguetes",Imagem = "Foguete",Cor = "#cdb28a"},
           };


            Servico.Conexoes.ReceberDados();


        }


    }
}
