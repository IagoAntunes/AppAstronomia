using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Security;
using System.Text;

namespace AppSpace.Servico
{
    public class Conexoes
    {
        public static void ReceberDados()
        {
            string url = "https://api.le-systeme-solaire.net/rest.php/bodies";
            WebClient wc = new WebClient();
            ServicePointManager.ServerCertificateValidationCallback = new
            RemoteCertificateValidationCallback
            (
               delegate { return true; }
            );
            var conteudo = wc.DownloadString(url);//Recebe dados do site


        }

    }
}
