using System;
using System.Collections.Generic;
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

namespace OnlyPans
{
    /// <summary>
    /// Lógica de interacción para Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        bool Iniciado = false;

        public Page4()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            int _a = lbxEmpleados.SelectedIndex;
            lbxEmpleados.Items.Clear();
            ShowContent();
            lbxEmpleados.SelectedIndex = 0;
        }

        private void lbxEmpleados_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lbxEmpleados.SelectedIndex >= 0){ 
                MainWindow w = (MainWindow)Window.GetWindow(this);
                //MessageBox.Show(lbxEmpleados.SelectedIndex.ToString());
                //Mostrar contenido
                lblNombre.Content = w.Empleado[Int16.Parse((lbxEmpleados.SelectedIndex.ToString())), 0];
                lblCedula.Content = w.Empleado[Int16.Parse((lbxEmpleados.SelectedIndex.ToString())), 1];
                lblEdad.Content = w.Empleado[Int16.Parse((lbxEmpleados.SelectedIndex.ToString())), 2];
                lblSexo.Content = w.Empleado[Int16.Parse((lbxEmpleados.SelectedIndex.ToString())), 3];
            }
        }

        private void ShowContent()
        {
            MainWindow w = (MainWindow)Window.GetWindow(this);
            //Actualizar lista
            for (int i = 0; i <= w.NEmpleados; i++)
            {
                lbxEmpleados.Items.Add(w.Empleado[i, 0]);
            }
            lbxEmpleados.SelectedIndex = w.NEmpleados-1;
        }


        private void lblRegistrar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow w = (MainWindow)Window.GetWindow(this);
            w.MainFrame.Content = w.P5;
        }
    }
}
