using System;
using System.Collections.Generic;
using System.Text;

namespace AppSpace.Models
{
    public class Objeto
    {
        public string id { get; set; }
        public string name { get; set; }
        public string englishName { get; set; }
        public string isPlanet { get; set; }
        public double density { get; set; }
        public double gravity { get; set; }
        public Objeto[] moons { get; set; }

        #region Collection  
        public string Nome { get; set; }
        public string Imagem { get; set; }
        public string Cor { get; set; }
        public string bodyType { get; set; }
        #endregion
    }
}
