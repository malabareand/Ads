using Ads.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ads.Repository.Mocks
{
    public class PersonaMocks
    {
        public IEnumerable<Persona> GetPersonas()
        {
            var list = new List<Persona>();
            for (var i = 0; i < 20; i++)
            {
                list.Add(new Persona()
                                {
                                    Nombre = string.Format("Persona n° {0}", i),
                                    Apellido = string.Format("Persona n° {0}", i),
                                    Rut = string.Format("{0}{1}{0}-{2}", (i+1)*10, i, i*7),
                                    FechaNacimiento = DateTime.Now.AddYears(-i),
                                    Sexo = i % 2 == 0 ? Sexo.Masculino : Sexo.Femenino
                                });
            }

            return list;
        }
    }
}
