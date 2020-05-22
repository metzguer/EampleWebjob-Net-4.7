using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebJobChollos.Data;
using WebJobChollos.Models;

namespace WebJobChollos.Repository
{
    public class RepositorioBbdd
    {
        CholloContext _context;
        public RepositorioBbdd()
        {
            _context = new CholloContext();
        }
        public int GetMaxIdChollos() {
            var consulta = _context.Chollos;
            if (consulta.Count() == 0)
                return 1;
            else
                return 0;//return consulta.Max(x => x.Id)+1;
        }

        public void ActualizarChollos(List<ChollosRss> chollos) {
            try {

                foreach (var cholloRss in chollos)
                {
                    CholoBbdd newChollo = new CholoBbdd();
                   
                    newChollo.Titulo = cholloRss.Titulo;
                    newChollo.Enlace = cholloRss.Enlace;
                    newChollo.Descripcion = cholloRss.Descripcion;
                    newChollo.Categoria = cholloRss.Categoria;
                   
                    _context.Chollos.Add(newChollo);
                   
                }
                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n\nError: {ex}");
            }

           
        }
    }
}
