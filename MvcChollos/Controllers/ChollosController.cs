using MvcChollos.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcChollos.Controllers
{
    public class ChollosController : Controller
    {
        RepositoryChollos _chollosRepository;
        public ChollosController()
        {
            _chollosRepository = new RepositoryChollos();
        }
        // GET: Chollos
        public ActionResult Index()
        {
            
            return View(_chollosRepository.GetChollos());
        }
    }
}