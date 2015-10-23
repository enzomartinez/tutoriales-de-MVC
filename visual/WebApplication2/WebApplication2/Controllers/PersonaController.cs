using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Index()
        {
            List<Persona> lista = new List<Persona>();
            Persona per1 = new Persona();
            per1.codigo = 1;
            per1.nombre = "Enzo";
            per1.apellidomat = " Fabian ";
            per1.apellidopat = "Martinez";
            lista.Add(per1);

            Persona per2 = new Persona();
            per2.codigo = 2;
            per2.nombre = "Fabian";
            per2.apellidomat = " Enzo ";
            per2.apellidopat = "Martinez";
            lista.Add(per2);

            Persona per3 = new Persona();
            per3.codigo = 3;
            per3.nombre = "Ariel";
            per3.apellidomat = " Sebastian ";
            per3.apellidopat = "Garcia";
            lista.Add(per3);


            return View(lista);
        }
    }
}