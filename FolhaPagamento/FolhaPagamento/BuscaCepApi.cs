using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolhaPagamento
{
    class BuscaCepApi
    {
        private String cep { get; set; }
        public BuscaCepApi(String cep)
        {
            this.cep = cep;
        }

        public Endereco load()
        {
            Endereco endereco = null;
            HttpWebRequest request = (HttpWebRequest) WebRequest.Create("https://viacep.com.br/ws/" + cep + "/json/");
            request.AllowAutoRedirect = false;
            HttpWebResponse ChecaServidor = (HttpWebResponse)request.GetResponse();

            using (Stream web = ChecaServidor.GetResponseStream())
            {
                if (web != null)
                {
                    using (StreamReader reader = new StreamReader(web))
                    {
                        string answer = reader.ReadToEnd();
                        endereco = JsonConvert.DeserializeObject<Endereco>(answer);
                    }
                }
            }
            return endereco;
        }
    }
}
