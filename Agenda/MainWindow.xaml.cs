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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Agenda
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private logicaContactos logicaContactos;
        public ObservableCollection<Contacto> listaContactos { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            /*
            listaContactos = new ObservableCollection<Contacto>();
            listaContactos.Add(new Contacto("Juan", "Lopez", "texto"));
            listaContactos.Add(new Contacto("Pepe", "Miguel", "texto2"));
            this.DataContext = this;*/
            this.logicaContactos= new logicaContactos();
            DataGridContactos.DataContext = logicaContactos;

        }


        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            var ventanaContactos = new Window1(logicaContactos);

            ventanaContactos.Show();
        }

        private void BtnModificar_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridContactos.SelectedIndex != -1)
            {
                Contacto contactos = (Contacto)DataGridContactos.SelectedItem;
                Window1 ventanaContactos = new Window1(logicaContactos, (Contacto)contactos.Clone(), DataGridContactos.SelectedIndex);
                ventanaContactos.Show();
            }

        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {



        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Contacto contactos = (Contacto)DataGridContactos.SelectedItem;
            logicaContactos.deleteContacto(contactos);
        }
    }
}
