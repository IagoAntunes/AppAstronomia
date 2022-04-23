using AppSpace.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppSpace.ViewModel
{
    public class PaginaListaObjetoViewModel
    {
        private string Name { get; set; }
        public string typeList { get; set; }
        public Objeto[] ListaItens { get; set; }
        public Objeto[] ListaItens2 { get; set; }
        public PaginaListaObjetoViewModel(string name)
        {
            this.Name = name;
            ListType();
        }

        public void ListType()
        {
            if(Name == "Planetas")
            {
                ListaItens = Servico.Conexoes.GetPlanets();
            }else if (Name == "Luas")
            {
                ListaItens = Servico.Conexoes.GetMoons().Take(10).ToArray();
 
            }
        }
    }
}
