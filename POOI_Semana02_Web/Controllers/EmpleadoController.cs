using POOI_Semana02_Web.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace POOI_Semana02_Web.Controllers
{
    public class EmpleadoController : Controller
    {
        public static List<Empleado> listaEmp;

        public EmpleadoController()
        {
            if (listaEmp == null)
            {
                listaEmp = new List<Empleado>();
                listaEmp.Add(new Empleado(){ codigo= 1, nombre = "e", edad = 120 });
                listaEmp.Add(new Empleado() { codigo = 2, nombre = "j", edad = 130 });
            }
            
           
        }

        // GET: Empleado
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult listado()
        {
            Debug.WriteLine("Contador listado : " + listaEmp.Count);

            return View(GetListaEmp());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Empleado empleado)
        {
           
            listaEmp.Add(empleado);
           

            

            return View(empleado);
        }

        public List<Empleado> GetListaEmp()
        {



            return listaEmp;
        }

       
 



    }
}