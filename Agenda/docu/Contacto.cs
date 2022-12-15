using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.docu
{
   public class Contacto : ICloneable, IDataErrorInfo
    {
        public String nombre { get; set; }
        public String apellido { get; set;}

        public String mail { get; set;}

        public string Error => throw new NotImplementedException();

        public string this[string columnName]
        {
            get 
            {
                String resultado = "";
                if (columnName == "nombre")
                {
                    if (string.IsNullOrEmpty(nombre))
                        resultado = "Debe introducir el nombre";
                }

                if(columnName== "apellido")
                {
                    if (string.IsNullOrEmpty(apellido))
                        resultado = "Debe introducir el apellido";
                }

                if (columnName == "mail")
                {
                    if (string.IsNullOrEmpty(apellido))
                        resultado = "Debe introducir el mail";
                }

                return resultado;
            }
        }

        public Contacto() 
        {

        
        
        }

        public Contacto(String nombre, String apellido, String mail)
        {

            this.nombre = nombre;
            this.apellido = apellido;
            this.mail = mail;

        }

        public override string ToString() { 
            return nombre + " " + apellido + " " + mail;
        }

        public object Clone()
        {
            return this.MemberwiseClone();  
        }
    }
    }

