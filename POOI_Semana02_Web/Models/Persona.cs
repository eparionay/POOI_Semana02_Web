using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POOI_Semana02_Web.Models
{
    public class Persona
    {

        public int codigo { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int edad { get; set; }

        public Persona(){
            codigo= 0;
            nombre = "";
            apellido = "";
            edad= 0;
        }
        
    }
}