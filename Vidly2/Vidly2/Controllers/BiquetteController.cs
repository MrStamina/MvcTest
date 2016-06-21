using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly2.Models;

namespace Vidly2.Controllers
{
    public class BiquetteController : Controller
    {
        // GET: Biquette
        public ViewResult Index()
        {
            var biquette = GetAllBiquette();
            return View(biquette);
        }

       private IEnumerable<Biquette> GetAllBiquette()
        {
            return new List<Biquette>
           {
               new Biquette {Id = 1, Nom = "Blanche" },
               new Biquette {Id = 2, Nom = "Emmanuel" }
           };
        }
    }
}