using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using POOI_Semana02_Web.Models;

namespace POOI_Semana02_Web.Controllers
{
    public class PersonaController : Controller
    {

        public static List<Persona> lista;

        public PersonaController()
        {
            
            if (lista == null)
            {
                lista = new List<Persona>();
                lista.Add(new Persona() { codigo=1, nombre="J", apellido= "j", edad= 10 });
                lista.Add(new Persona() { codigo = 2, nombre = "P", apellido = "P", edad = 25 });
            }
        }



        // GET: Persona
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            Debug.WriteLine("Create Get :: " + lista.Count);
            return View(new Persona());
        }


        [HttpPost]
        public ActionResult Create(Persona persona)
        {
            Debug.WriteLine("Codigo : " + persona.codigo);
            Debug.WriteLine("Nombre : " + persona.nombre);
            Debug.WriteLine("Apellido : " + persona.apellido);
            Debug.WriteLine("Edad     : " + persona.edad);
            lista.Add(persona);
            Debug.WriteLine("Create Post :: " + lista.Count);
            return View(persona);
        }


        public ActionResult Listado()
        {

            return View(lista);
        }


        public ActionResult Edit(int id)
        {
            Debug.WriteLine("Codigo : " + id);

            Persona objPersona = lista.First(x => x.codigo == id);

            return View(objPersona);
        }

        [HttpPost]
        public ActionResult Edit(Persona persona) {

            return View(persona);
        
        }






    }
}