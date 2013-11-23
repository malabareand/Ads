using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ads.Web.Models
{
    public class PersonaViewModel
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }

        public PersonaViewModel()
        {
            Nombre = "Juanito";
            Apellido = "Perez";
            Edad = 19;
        }
    }
}