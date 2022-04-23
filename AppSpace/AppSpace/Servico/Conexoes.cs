using AppSpace.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Security;
using System.Text;

namespace AppSpace.Servico
{
    public class Conexoes
    {
        public static Objeto[] GetPlanets()
        {
            string url = "https://api.le-systeme-solaire.net/rest.php/bodies?filter[]=isPlanet,eq,true";
            WebClient wc = new WebClient();
            ServicePointManager.ServerCertificateValidationCallback = new
            RemoteCertificateValidationCallback
            (
               delegate { return true; }
            );
            var conteudo = wc.DownloadString(url);//Recebe dados do site

            ListOfPlanets resultados = JsonConvert.DeserializeObject<ListOfPlanets>(conteudo);//Converter JSON para objeto
            return resultados.bodies;
        }
        public static Objeto[] GetMoons()
        {
            string url = "https://api.le-systeme-solaire.net/rest.php/bodies?filter[]=bodtype,eq,moon";
            WebClient wc = new WebClient();
            ServicePointManager.ServerCertificateValidationCallback = new
            RemoteCertificateValidationCallback
            (
               delegate { return true; }
            );
            var conteudo = wc.DownloadString(url);//Recebe dados do site

            ListOfPlanets resultados = JsonConvert.DeserializeObject<ListOfPlanets>(conteudo);//Converter JSON para objeto
            return resultados.bodies;
        }

    }
}
