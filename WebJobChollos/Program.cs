using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebJobChollos.Repository;

namespace WebJobChollos
{
    class Program
    {
        static void Main(string[] args)
        {
            RepositoryRss leerRss = new RepositoryRss();
            var listaChoollos = leerRss.GetChollos();

            foreach (var chollo in listaChoollos) {
                Console.WriteLine($"Titulo: {chollo.Titulo}, Categoria: {chollo.Categoria}");
            }
            RepositorioBbdd almacenamiento = new RepositorioBbdd();
            almacenamiento.ActualizarChollos(listaChoollos);
           
        }
    }
}
