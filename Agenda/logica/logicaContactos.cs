using Agenda.docu;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.logica
{
   public class logicaContactos
    {
        public ObservableCollection<Contacto> listaContactos { get; set; }

        public logicaContactos() { 
        
        listaContactos = new ObservableCollection<Contacto>();
            listaContactos.Add(new Contacto("nombreTest", "apellidoTest", "mailTest"));
        }

        public void Add(Contacto contacto)
        {

            listaContactos.Add(contacto);
        }

        public void modContacto(Contacto contacto, int posicion)
        {
            listaContactos[posicion] = contacto;

        }

        public void deleteContacto(Contacto  contacto ) { 
        listaContactos.Remove(contacto);
        }
    }
}
