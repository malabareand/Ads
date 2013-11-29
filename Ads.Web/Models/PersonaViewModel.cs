using Ads.Domain;
using Ads.Domain.Entidades;
using Ads.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ads.Web.Models
{
    public class PersonaViewModel
    {
        public IEnumerable<Persona> Personas
        {
            get { return _personas; }
            set { _personas = value; }
        }

        public PersonaViewModel()
        {
            _personaAction = (IPersonaActions)Activator.CreateInstance(typeof(PersonaActions));
            _personas = _personaAction.GetAllPersona();
        }

        private IPersonaActions _personaAction;
        private IEnumerable<Persona> _personas;
    }
}