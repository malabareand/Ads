using Ads.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ads.Domain
{
    public interface IPersonaActions
    {
        IEnumerable<Persona> GetAllPersona();
        IEnumerable<Persona> GetPersonasByPais(string idPais);
        Persona CreatePersona(string rut, string nombre, string apellido, DateTime fechaNacimiento, Sexo sexo);
        bool DeletePersona(string id);
    }
}
