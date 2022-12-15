using Agenda.docu;
using Agenda.logica;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Agenda
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {

        private logicaContactos logicaContactos;
        public Contacto contacto;
        private int posicion;
        private Boolean modificar;
        private int errores;
        public Window1(logicaContactos logicaContactos)
        {
            InitializeComponent();
            this.logicaContactos = logicaContactos;
            contacto = new Contacto();
            this.DataContext = contacto;
            modificar= false;
        }

        public Window1(logicaContactos logicaContactos, Contacto contactoMod, int posicion)
        {
            InitializeComponent();
            this.logicaContactos = logicaContactos;
            this.contacto = contactoMod;
            this.posicion  = posicion;
            this.DataContext = contacto;
            modificar= true;
        }


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (modificar) { logicaContactos.modContacto(contacto,posicion); }
            else
            logicaContactos.Add(contacto);
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Validation_Error(object sender, ValidationErrorEventArgs e) 
        {
            if (e.Action == ValidationErrorEventAction.Added)
                errores++;
            else
                errores--;
            if (errores == 0)
            {
                agregar.IsEnabled= true;
            }
            else
                agregar.IsEnabled= false;
        }

    }
}
