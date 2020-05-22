using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WebJobChollos.Models;

namespace WebJobChollos.Repository
{
    public class RepositoryRss
    {
        public RepositoryRss()
        {

        }

        public List<ChollosRss> GetChollos() {
            string URL = "https://www.chollometro.com/rss";

            XDocument docxml = XDocument.Load(URL);

            var consulta = from datos in docxml.Descendants("item")
                           select new ChollosRss
                           {
                            Titulo = datos.Element("title").Value,
                            Enlace = datos.Element("link").Value,
                            Descripcion = datos.Element("description").Value,
                            Categoria = datos.Element("category").Value
                           };

            return consulta.ToList();
        }
    }
}
