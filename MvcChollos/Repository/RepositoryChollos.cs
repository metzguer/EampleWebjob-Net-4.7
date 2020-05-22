using MvcChollos.Data;
using MvcChollos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcChollos.Repository
{
    public class RepositoryChollos
    {
        ChollosContext _context;
        public RepositoryChollos()
        {
            _context = new ChollosContext();
        }

        public List<Chollo> GetChollos() {

            var consulta = from datos in _context.Chollos
                           orderby datos.Id descending
                           select datos;
            return consulta.ToList();
             
        }
    }
}