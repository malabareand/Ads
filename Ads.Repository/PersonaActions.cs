using Ads.Domain;
using Ads.Domain.Entidades;
using Ads.Repository.Mocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ads.Repository
{
    public class PersonaActions : IPersonaActions
    {
        /***
         * TODO la idea a futuro es usar IoC,
         * para q podamos activar el uso de una bd o simplemente utilizar objetos mock
         ***/
        public IEnumerable<Persona> GetAllPersona()
        {
            return new PersonaMocks().GetPersonas();
        }

        public IEnumerable<Persona> GetPersonasByPais(string idPais)
        {
            throw new NotImplementedException();
        }

        public Persona CreatePersona(string rut, string nombre, string apellido, DateTime fechaNacimiento, Domain.Entidades.Sexo sexo)
        {
            throw new NotImplementedException();
        }

        public bool DeletePersona(string id)
        {
            throw new NotImplementedException();
        }
    }
}
